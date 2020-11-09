using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Accademy.MailSystem
{   
    public class MailManager
    {
        public event MailManagerEventHandler MailArrived;
    }
}
