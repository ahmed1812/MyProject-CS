using MyProjet.Models;
using System.Collections.Generic;

namespace MyProjet.Data
{
    public class Join3Tables : IJoin3Tables
    {
        public IEnumerable<Product> GetParentChildGrandChildData()
        {
            string sql = @"SELECT p.*, c.*, gc.*
                   FROM ParentTable p
                   JOIN ChildTable c ON p.Id = c.ParentId
                   JOIN GrandChildTable gc ON c.Id = gc.ChildId";

            var data = _db.Query<ParentModel, ChildModel, GrandChildModel, ParentModel>(
                sql,
                (parent, child, grandChild) =>
                {
                    child.GrandChildCollection.Add(grandChild);

                    if (!parent.ChildCollection.Contains(child))
                    {
                        parent.ChildCollection.Add(child);
                    }

                    return parent;
                },
                splitOn: "ParentId, ChildId"
            );

            return data;
        }

    }
}
