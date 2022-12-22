

using Domain.Models;

namespace Infrastructure.Setvices
{

    public class TeacherSetvice
    {
        private List<Teacher> Teachers;

        public TeacherSetvice()
        {
            Teachers = new List<Teacher>();
        }
        public List<Teacher> GetTeacher()
        {
            return Teachers;
        }
        public void AddTeacher(Teacher teacher)
        {
            Teachers.Add(teacher);
        }
        public void UpdateTeacher(Teacher teacher)
        {
            var find = Teachers.FirstOrDefault(x => x.Id == teacher.Id);
            if (find != null)
            {
                find.Id = teacher.Id;
                find.FirstName = teacher.FirstName;
                find.LastName = teacher.LastName;

            }
        
        }
        public void Delete(int id)
        {
            var find = Teachers.FirstOrDefault(x => x.Id == id);
            Teachers.Remove(find);
        }
    }

}