using StudentMicroservice.Model;
using System.Collections.Generic;

namespace StudentMicroservice.Repo
{
    public class StudentRepository: IStudentRepository
    {
        public List<Student> GetAllStudent() {
            return GetStudents();        
        }

        private List<Student> GetStudents() {
            return new List<Student>() {
            new Student(){Id=1,Age=23, Department="ECE", Name="Arun", Phonenumber =00000000},
            new Student(){Id=2,Age=24, Department="EIE", Name="Kamal", Phonenumber =00000000},
            new Student(){Id=3,Age=23, Department="ECI", Name="Vijay", Phonenumber =00000000},
            new Student(){Id=4,Age=24, Department="IT", Name="Ajith", Phonenumber =00000000},
            new Student(){Id=5,Age=25, Department="ECE", Name="Vikram", Phonenumber =00000000},
            new Student(){Id=6,Age=24, Department="ECE", Name="Taran", Phonenumber =00000000},
            new Student(){Id=7,Age=23, Department="EEE", Name="Arun", Phonenumber =00000000},
            new Student(){Id=8,Age=23, Department="EEE", Name="Danush", Phonenumber =00000000},
            new Student(){Id=9,Age=22, Department="CSE", Name="Simbu", Phonenumber =00000000},
            new Student(){Id=10,Age=23, Department="CSE", Name="Raj", Phonenumber =00000000}
            };
        }
    }

    public interface IStudentRepository
    {
        public List<Student> GetAllStudent();
    }
}
