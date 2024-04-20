namespace WebApplication3.Controllers.ORM
{
    public class BaseEntity
    {
        public int Id { get; set; }
        public DateTime AddDate { get; set; }
        public bool IsDeleted { get; set; }

    }
}
