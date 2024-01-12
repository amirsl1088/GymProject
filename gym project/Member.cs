using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gym_project
{
    public class Member:Person
    {
        public Member(string name,string phonenumber,int days):base(name,phonenumber)
        {
            Days = days;
        }
        private int Tuition = 50;
        public int Days { get; set; }
        public override void AddUser(Person person)
        {
            Console.WriteLine($"{person.Name} is added as member....");
        }

        public override void ReamoveUser(Person person)
        {
            Console.WriteLine($"{person.Name} is reamoved as member...");
        }

        public override void UserDetails(Person person)
        {
            Console.WriteLine($"member name={person.Name} , member phonenumber={person.PhoneNumber}, tuition={Tuition*Days}");
        }
    }
}
