using System;
using System.Collections.Generic;

namespace AdmissionVGTU.Models
{
public class Application
{
    public int ApplicationID { get; set; }
    public int UserID { get; set; }
    public string UserFullName { get; set; }  
    public int LevelID { get; set; }
    public string LevelName { get; set; }     
    public decimal AverageGrade { get; set; }
    public decimal ExamScore { get; set; }
    public string DocumentPath { get; set; }
    public int StatusID { get; set; }
    public string StatusName { get; set; }
    public string StatusComment { get; set; }
    public DateTime SubmissionDate { get; set; }
    public DateTime LastUpdateDate { get; set; }
    public List<StudyProgram> SelectedPrograms { get; set; }
}
}