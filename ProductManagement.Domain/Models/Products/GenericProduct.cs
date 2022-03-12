using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductManagement.Domain.Models.Products
{
    public class GenericProduct : Product
    {
        public GenericProduct(string name)  : base(name)
        {
            
        }

        public GenericProduct(string name, GenericProduct parentProduct) : base(name, parentProduct)
        {
            
        }
    }
}
