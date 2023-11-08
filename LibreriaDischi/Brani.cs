using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaDischi
{
    public class Brani
    {
        public int Codice { get; set; }
        public string? Titolo { get; set; }
        public string? Genere { get; set; }
        public decimal Durata { get; set; }

        public List<Artisti> ListaArtisti { get; set; } = new List<Artisti>();
    }
}
