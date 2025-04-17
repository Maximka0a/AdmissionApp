using System;

namespace AdmissionVGTU.Models
{
    public class User
    {
        public int UserID { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public int RoleID { get; set; }
        public string RoleName { get; set; }
        public string FullName { get; set; }
        public string PassportData { get; set; }
        public string SNILS { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string ParentFullName { get; set; }
        public string PreviousInstitution { get; set; }
        public DateTime RegistrationDate { get; set; }
    }
}