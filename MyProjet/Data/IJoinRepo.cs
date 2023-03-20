using MyProjet.Models;
using System.Collections.Generic;

namespace MyProjet.Data
{
    public interface IJoinRepo
    {
        public IEnumerable<Product> GetJoinTables();
    }
}
