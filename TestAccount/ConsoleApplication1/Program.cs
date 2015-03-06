using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestAccount.DataAccessLayer.Secuirty;
using TestAccount.DataAccessLayer;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            UserGroup u = new UserGroup() {
                 GroupDescription ="Hi Am Sezer",
                  GroupName = "Hi Am Sezer Qtz",
            };

           

            foreach (var item in UserGroupCommand.GetAll())
            {
                Console.WriteLine(" GroupName:{0} - Description {1}", item.GroupName, item.GroupDescription);
            }


            Console.Read();
        }
    }
}
