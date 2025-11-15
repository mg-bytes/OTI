using OTI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OTI.Data
{
    public class FileReader
    {
        // Path-ul catre fisierele text care contin elevii si notele
        private string _catalog;
        private string _note;
        
        private List<String> _materiiBaza = new List<string>
        {
            "Matematica",
            "Informatica",
            "Romana",
            "Engleza",
            "Fizica"
        };

        public FileReader(string catalog, string note)
        {
            this._catalog = catalog;
            this._note = note;
        }

        public List<Elev> LoadElevi()
        {
            List<Elev> elevi = new List<Elev>();



            return elevi;
        }
    }
}
