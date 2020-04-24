using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CrmBL.Interface;
using CrmBL.Models;

namespace CrmBL.Repository
{
    public class MarkRepository: Repository<Mark>
    {
        public MarkRepository(Context context) : base(context)
        {
        }
    }
}
