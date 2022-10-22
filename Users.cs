using System.ComponentModel.DataAnnotations;

namespace UsersApi
{
    public class Users
    {
        public int Id { get; set; }

        [StringLength(20)]
        public string FirstName { get; set; } = string.Empty;

        [StringLength(20)]
        public string LastName { get; set; } = string.Empty;  
        public int UserTypeId { get; set; }
        public UsersType? UserType { get; set; }

        [StringLength(200)]
        public string EmailUser { get; set; } = string.Empty;

        [StringLength(20)]
        public string BirthDate { get; set; } = string.Empty; //A Data está recebendo em string pois a validação será feita no front

        public int LevelOfSchooling { get; set; }

    }
}
