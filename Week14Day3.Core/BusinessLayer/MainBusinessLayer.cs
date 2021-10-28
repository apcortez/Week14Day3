using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week14Day3.Core.Entities;
using Week14Day3.Core.Interfaces;

namespace Week14Day3.Core.BusinessLayer
{
    public class MainBusinessLayer : IBusinessLayer
    {
        private readonly IProdottoRepository prodottiRepo;
        private readonly IUtenteRepository utentiRepo;

        public MainBusinessLayer(IProdottoRepository prodotti, IUtenteRepository utenti)
        {
            prodottiRepo = prodotti;
            utentiRepo = utenti;
        }

        public string AddProduct(Prodotto prodotto)
        {
            Prodotto prodottoEsistente = prodottiRepo.GetByCode(prodotto.Codice);
            if (prodottoEsistente != null)
            {
                return "Errore: codice prodotto già presente.";
            }
            prodottiRepo.Add(prodotto);
            return "Inserimento prodotto aggiunto con successo.";
        }

        public string DeleteProduct(int id)
        {
            Prodotto productToDelete = prodottiRepo.GetById(id);
            if(productToDelete == null)
            {
                return "Impossibile eliminare il prodotto.";
            }
            prodottiRepo.Delete(id);
            return "Prodotto eliminato con successo.";
        }

        public string EditProduct(Prodotto prodotto)
        {
            Prodotto productToUpdate = prodottiRepo.GetById(prodotto.Id);
            if (productToUpdate == null)
            {
                return "Impossibile modificare il prodotto. Prodotto non trovato.";
            }
            productToUpdate.Descrizione = prodotto.Descrizione;
            productToUpdate.Tipologia = prodotto.Tipologia;
            productToUpdate.Costo = prodotto.Costo;
            productToUpdate.Prezzo = prodotto.Prezzo;
            prodottiRepo.Update(productToUpdate);
            return "Prodotto aggiornato con successo.";
        }

        public Utente GetAccount(string username)
        {
            if (string.IsNullOrEmpty(username))
            {
                return null;
            }
            return utentiRepo.GetByUsername(username);
        }

        public List<Prodotto> GetAllProducts()
        {
            return prodottiRepo.Fetch();
        }
    }
}
