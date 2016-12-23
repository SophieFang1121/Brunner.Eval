using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Brunner.Eval.Data.Entity;


namespace Brunner.Eval.Data.Repository

{
    public interface IProductRepository
    {
         void Save(Product product,Guid userID );
         List<Product> GetAll();
         Product Get(int id);
         List<Product> Search(string filterExpression);
    }
}
