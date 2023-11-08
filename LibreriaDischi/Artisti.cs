using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaDischi
{
    public class Artisti
    {
        [Key]
        public string? Nome { get; set; }
        public string? Biografia { get; set; }
        public string? Nazionalita { get; set; }

        public override string ToString()
        {
            return $"{Nome}, {Biografia}, {Nazionalita}";
        }
    }
}
