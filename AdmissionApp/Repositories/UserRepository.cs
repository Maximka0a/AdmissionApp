using System;
using System.Data;
using Npgsql;
using AdmissionVGTU.Models;

namespace AdmissionVGTU.Repositories
{
    public class UserRepository
    {
        // Аутентификация пользователя
        public static User Authenticate(string username, string password)
        {
            string query = @"
                SELECT u.userid, u.username, u.roleid, r.rolename, u.fullname, u.email 
                FROM users u
                JOIN userroles r ON u.roleid = r.roleid
                WHERE u.username = @Username AND u.password = @Password";

            NpgsqlParameter[] parameters = {
                new NpgsqlParameter("@Username", username),
                new NpgsqlParameter("@Password", password)
            };

            DataTable result = DatabaseHelper.ExecuteQuery(query, parameters);

            if (result.Rows.Count > 0)
            {
                DataRow row = result.Rows[0];
                User user = new User
                {
                    UserID = Convert.ToInt32(row["userid"]),
                    Username = row["username"].ToString(),
                    RoleID = Convert.ToInt32(row["roleid"]),
                    RoleName = row["rolename"].ToString(),
                    FullName = row["fullname"].ToString(),
                    Email = row["email"].ToString()
                };
                return user;
            }

            return null;
        }

        // Регистрация нового пользователя
        public static bool Register(User user)
        {
            string query = @"
                INSERT INTO users (username, password, roleid, fullname, passportdata, snils, 
                                  email, phone, parentfullname, previousinstitution)
                VALUES (@Username, @Password, @RoleID, @FullName, @PassportData, @SNILS, 
                        @Email, @Phone, @ParentFullName, @PreviousInstitution)";

            NpgsqlParameter[] parameters = {
                new NpgsqlParameter("@Username", user.Username),
                new NpgsqlParameter("@Password", user.Password),
                new NpgsqlParameter("@RoleID", user.RoleID),
                new NpgsqlParameter("@FullName", user.FullName),
                new NpgsqlParameter("@PassportData", (object)user.PassportData ?? DBNull.Value),
                new NpgsqlParameter("@SNILS", (object)user.SNILS ?? DBNull.Value),
                new NpgsqlParameter("@Email", user.Email),
                new NpgsqlParameter("@Phone", (object)user.Phone ?? DBNull.Value),
                new NpgsqlParameter("@ParentFullName", (object)user.ParentFullName ?? DBNull.Value),
                new NpgsqlParameter("@PreviousInstitution", (object)user.PreviousInstitution ?? DBNull.Value)
            };

            return DatabaseHelper.ExecuteNonQuery(query, parameters) > 0;
        }

        // Получение информации о пользователе
        public static User GetUserById(int userId)
        {
            string query = @"
                SELECT u.*, r.rolename
                FROM users u
                JOIN userroles r ON u.roleid = r.roleid
                WHERE u.userid = @UserID";

            NpgsqlParameter[] parameters = {
                new NpgsqlParameter("@UserID", userId)
            };

            DataTable result = DatabaseHelper.ExecuteQuery(query, parameters);

            if (result.Rows.Count > 0)
            {
                DataRow row = result.Rows[0];
                User user = new User
                {
                    UserID = Convert.ToInt32(row["userid"]),
                    Username = row["username"].ToString(),
                    RoleID = Convert.ToInt32(row["roleid"]),
                    RoleName = row["rolename"].ToString(),
                    FullName = row["fullname"].ToString(),
                    PassportData = row["passportdata"] != DBNull.Value ? row["passportdata"].ToString() : null,
                    SNILS = row["snils"] != DBNull.Value ? row["snils"].ToString() : null,
                    Email = row["email"].ToString(),
                    Phone = row["phone"] != DBNull.Value ? row["phone"].ToString() : null,
                    ParentFullName = row["parentfullname"] != DBNull.Value ? row["parentfullname"].ToString() : null,
                    PreviousInstitution = row["previousinstitution"] != DBNull.Value ? row["previousinstitution"].ToString() : null,
                    RegistrationDate = Convert.ToDateTime(row["registrationdate"])
                };
                return user;
            }

            return null;
        }
    }
}