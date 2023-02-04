using OnClick.Data.Models.Base;

namespace OnClick.Data.Models
{
    public class User : BaseEntity
    {
        public string? Email { get; set; }
        public string? Password { get; set; }
    }
}
