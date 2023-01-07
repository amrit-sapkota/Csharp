using Infomax.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infomax.Services
{
    public class MockStudentRepository : IStudentRepository
    {
        private List<Student> _studentList;

        public MockStudentRepository()
        {
            _studentList = new List<Student>()
            {
                new Student() { Id = 1, Name = "Amrit Sapkota", Gender = Gender.Male, Address = "Siteldevi",Contact
                = "9856012345", Email = "amrit@gmail.com",  },
                new Student() { Id = 2, Name = "Basudev Thapa", Gender = Gender.Male, Address = "Ganeshtole",Contact
                = "9856012345", Email = "basu@gmail.com", }
            };

            /*Student std1 = new Student();
            std1.Name = "Rohan Thapa";
            std1.Email = "rohan@gmail.com";
            //......
            Student std2 = new Student();
            std2.Name = "Rohani Thapa";
            _studentList = new List<Student>();
            _studentList.Add(std1);
            _studentList.Add(std2);*/
        }
        IEnumerable<Student> IStudentRepository.GetAllStudents()
        {
            return _studentList;
        }
    }
}