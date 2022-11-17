using BlazorExc11.Models;
using Blazorise.Extensions;

namespace BlazorExc11.Pages
{
    public partial class Students
    {
        private static List<Student> students = new List<Student>();

        protected override async Task OnInitializedAsync()
        {
            if(students.IsNullOrEmpty())
            {
                Studies informatyka = new Studies
                {
                    Name = "informatyka"
                };

                students.Add(new Student
                {
                    Id = 1,
                    FirstName = "John",
                    LastName = "Smith",
                    Birthdate = new DateOnly(1990, 2, 25),
                    Studies = informatyka
                });
                students.Add(new Student
                {
                    Id = 2,
                    FirstName = "Anne",
                    LastName = "Aaaaa",
                    Birthdate = new DateOnly(1995, 2, 12),
                    Studies = informatyka
                });
                students.Add(new Student
                {
                    Id = 3,
                    FirstName = "AAAA",
                    LastName = "ZZZZ",
                    Birthdate = new DateOnly(1995, 2, 12),
                    Studies = informatyka
                });
            }
            
        }

        private void DeleteStudent(Student st)
        {
            if(students.Contains(st))
            {
                students.Remove(st);
            }
        }

        public static List<Student> GetStudents()
        {
            return students;
        }
    }
}
