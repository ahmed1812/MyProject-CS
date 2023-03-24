using MyProjet.Models;
using System.Collections.Generic;

namespace MyProjet.Data
{
    public interface IJoin3Tables
    {
        public IEnumerable<Product> GetParentChildGrandChildData();
    }
}
