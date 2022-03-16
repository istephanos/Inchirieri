using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inchirieri
{
    internal class Masini
    {
        string firma;
        string model;
        string an_fabricatie;
        string culoare;
        //bool disponibilitate;

        //constructor fara parametri
        public Masini()
        {
            firma =string.Empty;
            model = string.Empty;
            an_fabricatie = string.Empty;
            culoare = string.Empty;
        }

        //constructor cu parametri

        public Masini(string _firma, string _model, string _an_fabricatie,string _culoare)
        {
            firma = _firma;
            model = _model;
            an_fabricatie = _an_fabricatie;
            culoare = _culoare;
        }
    }
}
