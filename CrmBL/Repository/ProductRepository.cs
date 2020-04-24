using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CrmBL.Models;

namespace CrmBL.Repository
{
    public class ProductRepository: Repository<Product>
    {
        public ProductRepository(Context context) : base(context)
        {
        }
    }
}
