using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication3.Controllers.ORM;

namespace WebApplication3.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdminUserController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetAll()
        {
            WebContext context = new WebContext();
            List<AdminUser> users = context.Users.ToList();
            return Ok(users);

        }
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            WebContext context = new WebContext();
            AdminUser user = context.Users.Find(id);
            if(user == null)
            {
                return NotFound("bulunamadı");
            }
            return Ok(user);

        }
        [HttpPost]
        public IActionResult Post(AdminUser user)
        {
            WebContext context = new WebContext();
            context.Users.Add(user);
            context.SaveChanges();
            return Ok("ekleme başarılı");

        }
        [HttpDelete]
        public IActionResult Delete(int id)
        {
            WebContext context = new WebContext();
            AdminUser user=context.Users.Find(id);
            if(user == null)
            {
                return NotFound("bulunamadı");
            }
            context.Users.Remove(user);
            context.SaveChanges();
            return Ok("silme başarılı");
        }
        [HttpPut]
        public IActionResult Put(AdminUser user)
        {
            WebContext context = new WebContext();
            AdminUser entity=context.Users.FirstOrDefault(q=>q.Id==user.Id);
            entity.Name= user.Name;
            entity.Email= user.Email;
            entity.Phone= user.Phone;
            entity.Surname= user.Surname;
            context.SaveChanges();
            return Ok("Güncelleme tamamlandı");

        }
    }
}
