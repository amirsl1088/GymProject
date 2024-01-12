using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gym_project
{
    public static class Gymmanagment
    {
        private static List<Person> _person = new();
        public static void AddMember(string name,string phonenumber,int days)
        {
            var member = new Member(name, phonenumber, days);
            _person.Add(member);
            member.AddUser(member);
        }
        public static void AddTrainer(string name,string phonenumber,int days)
        {
            var trainer = new Trainer(name, phonenumber, days);
            _person.Add(trainer);
            trainer.AddUser(trainer);
        }
        public static List<Person> GetPeople()
        {
            return _person;
        }
        public static void ReamoveMember(string name)
        {
            var person = _person.FirstOrDefault(_ => _.Name == name);
            if(person is Member)
            {
                _person.Remove(person);
                person.ReamoveUser(person);
            }
            else
            {
                Console.WriteLine("wrong member");
            }
        }
        public static void ReamoveTrainer(string name)
        {
            var person = _person.FirstOrDefault(_ => _.Name == name);
            if(person is Trainer)
            {
                _person.Remove(person);
                person.ReamoveUser(person);
            }
            else
            {
                Console.WriteLine("wrong trainer");
            }
        }
    }
}
