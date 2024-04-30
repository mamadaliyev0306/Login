using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginForm.Models
{
    public static class FunctionClass
    {
        public static List<Users> ReadAllLine(List<string> list)
        {
           List<Users> users = new List<Users>();
            foreach (string line in list)
            {
                string[] strings = line.Split(',');
                users.Add(new Users
                {
                   
                    Id = int.Parse(strings[0]),
                    FIO = strings[1],
                    UserName = strings[2],
                    Password = strings[3],
                    Role = strings[4],
                }) ; 
            }
            return users;
        }

  
    }
}
