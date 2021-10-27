using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Week14Day3.Core.Entities;
using Week14Day3.Models;

namespace Week14Day3.Helper
{
    public static class Mapping
    {
        public static Prodotto toProdotto(this ProdottoViewModel prodottoViewModel)
        {
            return new Prodotto
            {
                Id = prodottoViewModel.Id, 
                Codice = prodottoViewModel.Codice, 
                Descrizione = prodottoViewModel.Descrizione, 
                Tipologia = (Core.Entities._Tipologia)prodottoViewModel.Tipologia,
                Costo = prodottoViewModel.Costo,
                Prezzo = prodottoViewModel.Prezzo
               
            };
        }

        public static ProdottoViewModel toProdottoViewModel(this Prodotto prodotto)
        {
        
            return new ProdottoViewModel
            {

                Id = prodotto.Id,
                Codice = prodotto.Codice,
                Descrizione = prodotto.Descrizione,
                Tipologia = (Models._Tipologia)prodotto.Tipologia,
                Costo = prodotto.Costo,
                Prezzo = prodotto.Prezzo


            };
        }
    }
}
