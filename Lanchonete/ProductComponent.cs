using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lanchonete
{
    class ProductComponent
    {
        public string Name { get; private set; }

        public ProductComponent(string name)
        {
            this.Name = name;
        }
    }
}
