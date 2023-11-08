using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaDischi
{
    public class SupportoMusicale
    {
        public string? Nome { get; set; }
        public string Descrizione { get; set; }
        public decimal Prezzo { get; set; }
        public List<Brani> ListaBrani { get; set; } = new List<Brani>();
        public override string ToString() => $"{Nome}, {Descrizione}, {Prezzo}, {ListaBrani.Count}";
    }
}