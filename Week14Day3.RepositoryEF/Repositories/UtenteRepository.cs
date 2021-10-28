using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week14Day3.Core.Entities;
using Week14Day3.Core.Interfaces;

namespace Week14Day3.RepositoryEF.Repositories
{
    public class UtenteRepository : IUtenteRepository
    {
        public bool Add(Utente item)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Utente> Fetch()
        {
            throw new NotImplementedException();
        }

        public Utente GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Utente GetByUsername(string username)
        {
            using (var ctx = new ProdottoContext())
            {
                if (string.IsNullOrEmpty(username))
                {
                    return null;
                }
                return ctx.Utenti.FirstOrDefault(u => u.Username == username);
            }
        }

        public bool Update(Utente item)
        {
            throw new NotImplementedException();
        }
    }
}
