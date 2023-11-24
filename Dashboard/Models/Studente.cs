using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dashboard.Models
{
    public class Studente(string nome, string cognome, string immagineProfilo)
    {
        public string Nome => nome;
        public string Cognome => cognome;
        public string ImmagineProfilo { get => immagineProfilo;
            set => immagineProfilo = value; }
    }
}
