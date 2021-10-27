using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Week14Day3.Models
{
    public class ProdottoViewModel
    {
        public int Id { get; set; }
        public string Codice { get; set; }
        public string Descrizione { get; set; }
        public _Tipologia Tipologia { get; set; }
        public decimal Prezzo { get; set; }
        public decimal Costo { get; set; }
    }
    public enum _Tipologia
    {
        Elettronica,
        Abbigliamento,
        Casalinghi
    }
}
