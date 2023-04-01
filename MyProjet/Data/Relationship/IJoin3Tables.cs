using MyProjet.Models;
using System.Collections.Generic;

namespace MyProjet.Data.Relationship
{
    public interface IJoin3Tables
    {
        public IEnumerable<Product> GetParentChildGrandChildData();
    }
}
