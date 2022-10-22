using System.ComponentModel.DataAnnotations;

namespace UsersApi
{
    public class UsersType
    {
        public int Id { get; set; }
        [StringLength(20)]
        public string UsersName { get; set; } = string.Empty;
    }
}
