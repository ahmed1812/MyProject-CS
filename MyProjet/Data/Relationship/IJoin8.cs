using MyProjet.Models;
using System.Collections.Generic;

namespace MyProjet.Data.Relationship
{
    public interface IJoin8
    {
        public IEnumerable<Department> GetParentChildGrandChildGreatGrandChildData();

    }
}
