using System;

namespace CommerceShop.Data
{
    public interface IAuditEntity
    {
        int CreatedUserId { get; set; }
        DateTime CreatedDate { get; set; }
        int UpdateUserId { get; set; }
        DateTime UpdateDate { get; set; }
    }
}