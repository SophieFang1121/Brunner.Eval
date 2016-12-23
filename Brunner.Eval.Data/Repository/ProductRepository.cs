using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Brunner.Eval.Data.Repository
{
    public class ProductRepository:IProductRepository
    {
        public void Save(Entity.Product product, Guid userID)
        {
            throw new NotImplementedException();
        }

        public List<Entity.Product> GetAll()
        {
            throw new NotImplementedException();
        }

        public Entity.Product Get(int id)
        {
            throw new NotImplementedException();
        }

        public List<Entity.Product> Search(string filterExpression)
        {
            throw new NotImplementedException();
        }
    }
}
