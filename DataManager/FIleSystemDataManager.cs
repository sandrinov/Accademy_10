using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accademy.DataManager
{
    public class FIleSystemDataManager : IDataManager
    {
        private string bankDir = @"D:\temp\BankDB";
        private string usersFileName;
        private string clientiFileName;
        private string ccFileName;
        private string movimentiFileName;

        public FIleSystemDataManager()
        {
            usersFileName = System.IO.Path.Combine(bankDir, "Users.txt");
            clientiFileName = System.IO.Path.Combine(bankDir, "Clienti.txt");
            ccFileName = System.IO.Path.Combine(bankDir, "ContiCorrenti.txt");
            movimentiFileName = System.IO.Path.Combine(bankDir, "Movimenti.txt");
        }
        public bool LoginIsOK(string username, string password)
        {

            bool result = false;
            // per stampare su due righe \r\n quindi ora sta interpretando come caratteri di escape
            // quindi o metto doppio backslash oppure metto chiocciola davanti ai doppi apici
            
            
            string line;
            char[] chararray = new char[1]; // se scrivessi char[] ca starei dichiarando un puntatore vuoto
            chararray[0] = ';';
            System.IO.StreamReader file = new System.IO.StreamReader(usersFileName);
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

        public bool UserIsAnOwner(string username)
        {
            bool result = false;
            string line;
            char[] chararray = new char[1]; // se scrivessi char[] ca starei dichiarando un puntatore vuoto
            chararray[0] = ';';
            System.IO.StreamReader file = new System.IO.StreamReader(ccFileName);
            while ((line = file.ReadLine()) != null) // quella tra paresntesi si chiama guardia ed e' un espressione booleana
            {
                String[] resultArray = line.Split(chararray);
                string current_user = resultArray[0];               
                if (username == current_user)
                {
                    result = true;
                    break;
                }
            }
            return result;
        }
    }
}
