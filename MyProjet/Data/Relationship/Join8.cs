using System.Data;

namespace MyProjet.Data.Relationship
{
    public class Join8 : IJoin8
    {
        private readonly IDbConnection _conn;

        public Join8(IDbConnection conn)
        {
            _conn = conn;
        }
    }
}
