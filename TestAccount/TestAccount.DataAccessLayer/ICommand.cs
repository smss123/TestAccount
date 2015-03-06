using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAccount.DataAccessLayer
{
   internal interface ICommand
    {
        bool Add(object o);
        bool Edit(object o);
        bool Delete(object o);

    }
}
