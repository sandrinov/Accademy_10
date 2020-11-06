using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accademy.DataManager
{
    public class FIleSystemDataManager : IDataManager
    {
        public bool LoginIsOK(string username, string password)
        {

            bool result = false;
            String dir = @"D:\temp\BankDB";
            // per stampare su due righe \r\n quindi ora sta interpretando come caratteri di escape
            // quindi o metto doppio backslash oppure metto chiocciola davanti ai doppi apici
            String filename = "Users.txt";
            String path =  System.IO.Path.Combine(dir, filename);
            string line;
            char[] chararray = new char[1]; // se scrivessi char[] ca starei dichiarando un puntatore vuoto
            chararray[0] = ';';
            System.IO.StreamReader file = new System.IO.StreamReader(path);
            while ((line = file.ReadLine()) != null) // quella tra paresntesi si chiama guardia ed e' un espressione booleana
            {
                String[] resultArray = line.Split(chararray);
                string current_user = resultArray[0];
                string current_pw = resultArray[1];
                if (username == current_user && password == current_pw)
                {
                    result = true;
                    break;
                }
            }
            return result;
        }
    }
}
