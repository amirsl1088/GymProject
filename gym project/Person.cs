using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gym_project
{
    public abstract class Person:ICommonprocsess
    {
        private string _phonenumber;
        public Person(string name,string phonenumber)
        {
            Name = name;
            PhoneNumber = phonenumber;
        }
        public string Name { get; set; }
        public string PhoneNumber
        {
            get
            {
                return _phonenumber;
            }
            set
            {
                if (value.Length != 11)
                {
                    throw new Exception("wrong phone number");
                }
                _phonenumber = value;
            }
        }

        public abstract void AddUser(Person person);


        public abstract void ReamoveUser(Person person);


        public abstract void UserDetails(Person person);
       
    }
}
