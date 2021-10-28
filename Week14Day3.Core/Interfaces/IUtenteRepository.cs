using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week14Day3.Core.Entities;

namespace Week14Day3.Core.Interfaces
{
    public interface IUtenteRepository : IRepository<Utente>
    {
        Utente GetByUsername(string username);
    }
}
