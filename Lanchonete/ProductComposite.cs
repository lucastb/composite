using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lanchonete
{
    class ProductComposite : ProductComponent
    {
        private IList<ProductComponent> products;

        public ProductComposite(String name) : base(name)
        {
            products = new List<ProductComponent>();
        }

        public void AddProduct(ProductComponent p)
        {
            products.Add(p);
        }

        public void RemoveProduct(ProductComponent p)
        {
            products.Remove(p);
        }
    }
}
