
using Domain.Models;
using Infrastructure.Setvices;

var s = new Student();

s.Id = 25;
s.FirstName =" Shahrom ";
s.LastName = " Sharipov ";
s.Address = " SoftClub ";
s.BirthDate = DateTime.Now;

var sService = new StudentSetvice();
sService.AddStudent(s);

foreach (var sElement in sService.GetStudents())
{
    Console.WriteLine(sElement.FirstName +
        sElement.LastName + sElement.Address + sElement.BirthDate);
}
var teacher =new Teacher();
teacher.Id = 11;
teacher.FirstName = " A ";
teacher.LastName = " b ";
teacher.Position= " Shahrom ";
teacher.ExperienceAmount = 12;

var ts = new TeacherSetvice();
ts.AddTeacher(teacher);

foreach (var tElement in ts.GetTeacher())
{
    Console.WriteLine ( tElement.Id + tElement.FirstName +
        tElement.LastName + tElement.Position + tElement.ExperienceAmount);
}
Console.WriteLine(" update  ");
teacher.Id = 11;
teacher.FirstName = " name";
teacher.LastName = "shahrom2  ";
teacher.Position = " Sharipov2 ";
teacher.ExperienceAmount = 12;
var ts2 = new TeacherSetvice();
ts2.UpdateTeacher(teacher);
foreach (var tsElement in ts.GetTeacher())
{
    Console.WriteLine ( tsElement.Id + tsElement.FirstName +
        tsElement.LastName + tsElement.Position + tsElement.ExperienceAmount);
}

