using System.Data;

namespace AdmissionVGTU.Repositories
{
    public class ReportRepository
    {
        public static DataTable GetApplicationsByProgram()
        {
            string query = @"
                SELECT p.programname, COUNT(ap.applicationid) as applicationcount
                FROM studyprograms p
                LEFT JOIN applicationprograms ap ON p.programid = ap.programid
                GROUP BY p.programname
                ORDER BY applicationcount DESC";

            return DatabaseHelper.ExecuteQuery(query);
        }

        public static DataTable GetApplicationsByStatus()
        {
            string query = @"
                SELECT s.statusname, COUNT(a.applicationid) as applicationcount
                FROM applicationstatuses s
                LEFT JOIN applications a ON s.statusid = a.statusid
                GROUP BY s.statusname";

            return DatabaseHelper.ExecuteQuery(query);
        }
    }
}