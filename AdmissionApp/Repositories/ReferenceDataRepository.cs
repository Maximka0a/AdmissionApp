using System;
using System.Collections.Generic;
using System.Data;
using Npgsql;
using AdmissionApp.Models;

namespace AdmissionApp.Repositories
{
    public class ReferenceDataRepository
    {
        // Получение всех уровней образования
        public static List<EducationLevel> GetEducationLevels()
        {
            string query = "SELECT * FROM educationlevels ORDER BY levelid";
            DataTable result = DatabaseHelper.ExecuteQuery(query);
            List<EducationLevel> levels = new List<EducationLevel>();

            foreach (DataRow row in result.Rows)
            {
                EducationLevel level = new EducationLevel
                {
                    LevelID = Convert.ToInt32(row["levelid"]),
                    LevelName = row["levelname"].ToString()
                };

                levels.Add(level);
            }

            return levels;
        }

        // Получение направлений подготовки по уровню образования
        public static List<StudyProgram> GetStudyProgramsByLevel(int levelId)
        {
            string query = "SELECT * FROM studyprograms WHERE levelid = @LevelID ORDER BY programname";

            NpgsqlParameter[] parameters = {
                new NpgsqlParameter("@LevelID", levelId)
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

        // Получение всех статусов заявлений
        public static List<ApplicationStatus> GetApplicationStatuses()
        {
            string query = "SELECT * FROM applicationstatuses ORDER BY statusid";
            DataTable result = DatabaseHelper.ExecuteQuery(query);
            List<ApplicationStatus> statuses = new List<ApplicationStatus>();

            foreach (DataRow row in result.Rows)
            {
                ApplicationStatus status = new ApplicationStatus
                {
                    StatusID = Convert.ToInt32(row["statusid"]),
                    StatusName = row["statusname"].ToString()
                };

                statuses.Add(status);
            }

            return statuses;
        }

        // Добавление нового направления подготовки
        public static bool AddStudyProgram(StudyProgram program)
        {
            string query = @"
                INSERT INTO studyprograms (programname, levelid)
                VALUES (@ProgramName, @LevelID)";

            NpgsqlParameter[] parameters = {
                new NpgsqlParameter("@ProgramName", program.ProgramName),
                new NpgsqlParameter("@LevelID", program.LevelID)
            };

            return DatabaseHelper.ExecuteNonQuery(query, parameters) > 0;
        }

        // Удаление направления подготовки
        public static bool DeleteStudyProgram(int programId)
        {
            string query = "DELETE FROM studyprograms WHERE programid = @ProgramID";

            NpgsqlParameter[] parameters = {
                new NpgsqlParameter("@ProgramID", programId)
            };

            return DatabaseHelper.ExecuteNonQuery(query, parameters) > 0;
        }
    }
}