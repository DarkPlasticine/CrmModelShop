using System;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace CrmDL.Models
{
    /// <summary>
    /// МОдель корзины
    /// </summary>
    public class Cart: BaseObject
    {
        public Guid ApplicationUserId { get; set; }
        public virtual ApplicationUser ApplicationUser { get; set; }
    }
}