using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gym_project
{
    public interface ICommonprocsess
    {
        void AddUser( Person person);
        void ReamoveUser(Person person);
        void UserDetails(Person person);
    }
}
