using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASSIGNMENT.Models
{
    internal class Student
    {
        public Student(string id, string name, string email, string phone, int sex, string address)
        {
            ID = id;
            Name = name;
            Email = email;
            Phone = phone;
            Sex = sex;
            Address = address;
        }
        public string ID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public int Sex { get; set; }
        public string Address { get; set; }
    }
}
