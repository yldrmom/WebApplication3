namespace WebApplication3.Controllers.ORM
{
    public class AdminUser:BaseEntity
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Surname { get; set; }
        public string Phone { get; set; }

    }
}
