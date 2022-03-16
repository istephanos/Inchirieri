using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inchirieri
{
    internal class Client
    {
        string nume,prenume;
        string cnp, data_start, data_end;
        
        //	Constructor fara parametri
        public Client()
        {
            Console.WriteLine("Constructor fara parametri");
            Console.ReadKey();
            nume = string.Empty;
            prenume = string.Empty;
            cnp = string.Empty;
            data_start = string.Empty;
            data_end = string.Empty;
        }

        //	Constructor fara parametri
        public Client(string _nume,string _prenume,string _cnp, string _data_start,string _data_end)
        {
            nume = _nume;
            prenume =_prenume;
            cnp =_cnp;
            data_start =_data_start;
            data_end =_data_end;
        }

    }
}
