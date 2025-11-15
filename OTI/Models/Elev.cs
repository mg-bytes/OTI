using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OTI.Models
{
    public class Elev
    {
        public int id { get; set; }
        public string Nume { get; set; }
        public string Prenume { get; set; }
        public string Clasa { get; set; }
        public int Varsta { get; set; }
        public string Email { get; set; }
        public string Telefon { get; set; }
        
        // Fiecare elev poate sa aiba spre exemplu o Materie(Matematica, [9, 3, 10, 4]).
        public List<Materie> Materii { get; set; }
    }
}
