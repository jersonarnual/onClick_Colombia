using OnClick.Data.Models.Base;

namespace OnClick.Data.Models
{
    public class User : BaseEntity
    {
        public string? FirstName{ get; set; }
        public string? LastName { get; set; }
        public string? Email { get; set; }
        public string? Number { get; set; }

        public string? ApplicationUserId { get; set; }
        public virtual ApplicationUser? ApplicationUser { get; set; }
    }
}
