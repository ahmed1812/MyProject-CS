using MyProjet.Models;
using System.Collections.Generic;

namespace MyProjet.Data.Relationship
{
    public interface IJoinRepo
    {
        public IEnumerable<Product> GetJoinTables();
    }
}
