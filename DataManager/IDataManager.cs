using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accademy.DataManager
{
    public interface IDataManager
    {
        bool LoginIsOK(string username, string password);
        bool UserIsAnOwner(string username);
    }
}
