using CourseApp.Models;

namespace CourseApp.ViewModels
{
    public class CourseStudentViewModel
    {
        public Course crs { get; set; }
        public List<student> std { get; set; }
    }
}