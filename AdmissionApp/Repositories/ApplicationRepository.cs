using System;
using System.Collections.Generic;
using System.Data;
using Npgsql;
using NpgsqlTypes;
using AdmissionVGTU.Models;

namespace AdmissionVGTU.Repositories
{
    public class ApplicationRepository
    {
        public static int CreateApplication(Application application)
        {

            string query = @"
                INSERT INTO applications (userid, levelid, averagegrade, examscore, documentpath, statusid)
                VALUES (@UserID, @LevelID, @AverageGrade, @ExamScore, @DocumentPath, @StatusID)
                RETURNING applicationid";

            NpgsqlParameter[] parameters = {
                new NpgsqlParameter("@UserID", application.UserID),
                new NpgsqlParameter("@LevelID", application.LevelID),
                new NpgsqlParameter { ParameterName = "@AverageGrade", NpgsqlDbType = NpgsqlDbType.Numeric, Value = application.AverageGrade > 0 ? (object)application.AverageGrade : DBNull.Value },
                new NpgsqlParameter { ParameterName = "@ExamScore", NpgsqlDbType = NpgsqlDbType.Numeric, Value = application.ExamScore > 0 ? (object)application.ExamScore : DBNull.Value },
                new NpgsqlParameter("@DocumentPath", (object)application.DocumentPath ?? DBNull.Value),
                new NpgsqlParameter("@StatusID", 1) 
            };

            int applicationId = Convert.ToInt32(DatabaseHelper.ExecuteScalar(query, parameters));

            if (applicationId > 0 && application.SelectedPrograms.Count > 0)
            {
                foreach (var program in application.SelectedPrograms)
                {
                    string programQuery = @"
                        INSERT INTO applicationprograms (applicationid, programid)
                        VALUES (@ApplicationID, @ProgramID)";

                    NpgsqlParameter[] programParams = {
                        new NpgsqlParameter("@ApplicationID", applicationId),
                        new NpgsqlParameter("@ProgramID", program.ProgramID)
                    };

                    DatabaseHelper.ExecuteNonQuery(programQuery, programParams);
                }
            }

            return applicationId;
        }
        public static List<Application> GetApplicationsByUserId(int userId)
        {
            string query = @"
                SELECT a.*, s.statusname, e.levelname
                FROM applications a
                JOIN applicationstatuses s ON a.statusid = s.statusid
                JOIN educationlevels e ON a.levelid = e.levelid
                WHERE a.userid = @UserID
                ORDER BY a.submissiondate DESC";

            NpgsqlParameter[] parameters = {
                new NpgsqlParameter("@UserID", userId)
            };

            DataTable result = DatabaseHelper.ExecuteQuery(query, parameters);
            List<Application> applications = new List<Application>();

            foreach (DataRow row in result.Rows)
            {
                Application app = new Application
                {
                    ApplicationID = Convert.ToInt32(row["applicationid"]),
                    UserID = Convert.ToInt32(row["userid"]),
                    LevelID = Convert.ToInt32(row["levelid"]),
                    LevelName = row["levelname"].ToString(),
                    AverageGrade = row["averagegrade"] != DBNull.Value ? Convert.ToDecimal(row["averagegrade"]) : 0,
                    ExamScore = row["examscore"] != DBNull.Value ? Convert.ToDecimal(row["examscore"]) : 0,
                    DocumentPath = row["documentpath"] != DBNull.Value ? row["documentpath"].ToString() : string.Empty,
                    StatusID = Convert.ToInt32(row["statusid"]),
                    StatusName = row["statusname"].ToString(),
                    StatusComment = row["statuscomment"] != DBNull.Value ? row["statuscomment"].ToString() : string.Empty,
                    SubmissionDate = Convert.ToDateTime(row["submissiondate"]),
                    LastUpdateDate = Convert.ToDateTime(row["lastupdatedate"]),
                    SelectedPrograms = GetApplicationPrograms(Convert.ToInt32(row["applicationid"]))
                };

                applications.Add(app);
            }

            return applications;
        }

        // Получение всех заявлений (для приемной комиссии)
        public static List<Application> GetAllApplications(string statusFilter = null, int levelFilter = 0, DateTime? dateFilter = null)
        {
            string query = @"
                SELECT a.*, s.statusname, e.levelname, u.fullname as userfullname
                FROM applications a
                JOIN applicationstatuses s ON a.statusid = s.statusid
                JOIN educationlevels e ON a.levelid = e.levelid
                JOIN users u ON a.userid = u.userid
                WHERE 1=1 ";

            List<NpgsqlParameter> parameters = new List<NpgsqlParameter>();

            if (!string.IsNullOrEmpty(statusFilter))
            {
                query += " AND s.statusname = @StatusName";
                parameters.Add(new NpgsqlParameter("@StatusName", statusFilter));
            }

            if (levelFilter > 0)
            {
                query += " AND a.levelid = @LevelID";
                parameters.Add(new NpgsqlParameter("@LevelID", levelFilter));
            }

            if (dateFilter.HasValue)
            {
                query += " AND DATE(a.submissiondate) = @SubmissionDate";
                parameters.Add(new NpgsqlParameter("@SubmissionDate", dateFilter.Value.Date));
            }

            query += " ORDER BY a.submissiondate DESC";

            DataTable result = DatabaseHelper.ExecuteQuery(query, parameters.ToArray());
            List<Application> applications = new List<Application>();

            foreach (DataRow row in result.Rows)
            {
                Application app = new Application
                {
                    ApplicationID = Convert.ToInt32(row["applicationid"]),
                    UserID = Convert.ToInt32(row["userid"]),
                    UserFullName = row["userfullname"].ToString(),
                    LevelID = Convert.ToInt32(row["levelid"]),
                    LevelName = row["levelname"].ToString(),
                    AverageGrade = row["averagegrade"] != DBNull.Value ? Convert.ToDecimal(row["averagegrade"]) : 0,
                    ExamScore = row["examscore"] != DBNull.Value ? Convert.ToDecimal(row["examscore"]) : 0,
                    DocumentPath = row["documentpath"] != DBNull.Value ? row["documentpath"].ToString() : string.Empty,
                    StatusID = Convert.ToInt32(row["statusid"]),
                    StatusName = row["statusname"].ToString(),
                    StatusComment = row["statuscomment"] != DBNull.Value ? row["statuscomment"].ToString() : string.Empty,
                    SubmissionDate = Convert.ToDateTime(row["submissiondate"]),
                    LastUpdateDate = Convert.ToDateTime(row["lastupdatedate"]),
                    SelectedPrograms = GetApplicationPrograms(Convert.ToInt32(row["applicationid"]))
                };

                applications.Add(app);
            }

            return applications;
        }

        // Обновление статуса заявления
        public static bool UpdateApplicationStatus(int applicationId, int statusId, string comment)
        {
            string query = @"
                UPDATE applications
                SET statusid = @StatusID,
                    statuscomment = @StatusComment,
                    lastupdatedate = CURRENT_TIMESTAMP
                WHERE applicationid = @ApplicationID";

            NpgsqlParameter[] parameters = {
                new NpgsqlParameter("@ApplicationID", applicationId),
                new NpgsqlParameter("@StatusID", statusId),
                new NpgsqlParameter("@StatusComment", (object)comment ?? DBNull.Value)
            };

            return DatabaseHelper.ExecuteNonQuery(query, parameters) > 0;
        }

        // Получение направлений подготовки для заявления
        public static List<StudyProgram> GetApplicationPrograms(int applicationId)
        {
            string query = @"
                SELECT p.*
                FROM applicationprograms ap
                JOIN studyprograms p ON ap.programid = p.programid
                WHERE ap.applicationid = @ApplicationID";

            NpgsqlParameter[] parameters = {
                new NpgsqlParameter("@ApplicationID", applicationId)
            };

            DataTable result = DatabaseHelper.ExecuteQuery(query, parameters);
            List<StudyProgram> programs = new List<StudyProgram>();

            foreach (DataRow row in result.Rows)
            {
                StudyProgram program = new StudyProgram
                {
                    ProgramID = Convert.ToInt32(row["programid"]),
                    ProgramName = row["programname"].ToString(),
                    LevelID = Convert.ToInt32(row["levelid"])
                };

                programs.Add(program);
            }

            return programs;
        }
    }
}