

using Domain.Models;

namespace Infrastructure.Setvices
{

    public class CourseSetvice
    {
        private List<Course> Courses;

        public CourseSetvice()
        {
            Courses = new List<Course>();
        }
        public List<Course> GetCourses()
        {
            return Courses;
        }
        public void AddCourse(Course course)
        {
            Courses.Add(course);
        }
        public void UpdateStudent(Course course)
        {
            var find = Courses.FirstOrDefault(x => x.Id == course.Id);
            if(find != null)
            {
                find.Id = course.Id;
                find.Title = course.Title;
                find.Description = course.Description;
            }
        }
        public void Delete(int id)
        {
            var find = Courses.FirstOrDefault(x => x.Id == id);
            Courses.Remove(find);
        }
    }

}