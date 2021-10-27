using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week14Day3.Core.Entities;

namespace Week14Day3.Core.BusinessLayer
{
    public interface IBusinessLayer
    {
        #region Prodotto
        public List<Prodotto> GetAllProducts();
        public string AddProduct(Prodotto prodotto);
        public string DeleteProduct(int id);
        public string EditProduct(Prodotto prodotto);
        
        #endregion
    }
}
