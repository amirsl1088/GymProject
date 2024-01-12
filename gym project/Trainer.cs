using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gym_project
{
    public class Trainer:Person
    {
        public Trainer(string name, string phonenumber, int days):base(name,phonenumber)
        {
            Days = days;
        }
        private int Salary = 150;
        public int Days { get; set; }

        public override void AddUser(Person person)
        {
            Console.WriteLine($"{person.Name} is added as trainer...");
        }

        public override void ReamoveUser(Person person)
        {
            Console.WriteLine($"{person.Name} is reamoved as trainer...");
        }

        public override void UserDetails(Person person)
        {
            Console.WriteLine($"trainer name={person.Name}, trainer phonenumbet={person.PhoneNumber}, salary={Salary*Days}");
        }
    }
}
