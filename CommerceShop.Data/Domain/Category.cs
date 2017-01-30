using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace CommerceShop.Data.Domain
{
    [Table("Category", Schema = "Production")]
    public class Category : BaseEntity, IAuditEntity
    {
        public string Name { get; set; }
        public int PictureId { get; set; }
        public string ShortDescription { get; set; }
        public string LongDescription { get; set; }
        public int CreatedUserId { get; set; }
        public DateTime CreatedDate { get; set; }
        public int UpdateUserId { get; set; }
        public DateTime UpdateDate { get; set; }
    }
}