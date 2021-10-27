using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week14Day3.Core.Entities;
using Week14Day3.Core.Interfaces;

namespace Week14Day3.RepositoryEF.Repositories
{
    public class ProdottoRepository : IProdottoRepository
    {
        private readonly ProdottoContext prodottoCtx;
        public ProdottoRepository()
        {
            prodottoCtx = new ProdottoContext();
        }
        public bool Add(Prodotto item)
        {
            if (item == null)
                return false;

            try
            {
                prodottoCtx.Prodotti.Add(item);
                prodottoCtx.SaveChanges();
                return true;


            }
            catch (Exception ex)
            {

                Console.WriteLine("Errore: " + ex.Message);
                return false;
            }
        }

        public bool Delete(int id)
        {
            if (id <= 0)
                return false;

            try
            {
                var product = prodottoCtx.Prodotti.Find(id);

                if (product != null)
                    prodottoCtx.Prodotti.Remove(product);

                prodottoCtx.SaveChanges();
                return true;


            }
            catch (Exception ex)
            {
                
                Console.WriteLine("Errore: " + ex.Message);
                return false;
            }
        }

        public List<Prodotto> Fetch()
        {
            try
            {
                var products = prodottoCtx.Prodotti.ToList();
                return products;
            }
            catch (Exception)
            {
                return new List<Prodotto>();
            }
        }

        public Prodotto GetByCode(string codice)
        {
            if (codice == null)
                return null;


            return prodottoCtx.Prodotti.Where(p => p.Codice == codice).FirstOrDefault();
        }

        public Prodotto GetById(int id)
        {
            if (id <= 0)
                return null;

            return prodottoCtx.Prodotti.Find(id);
        }

        public bool Update(Prodotto item)
        {
            if (item ==null)
                return false;

            try
            {
                prodottoCtx.Prodotti.Update(item);
                prodottoCtx.SaveChanges();
                return true;


            }
            catch (Exception ex)
            {

                Console.WriteLine("Errore: " + ex.Message);
                return false;
            }
        }
    }
}
