using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using TestAuthentication.Context;

namespace TestAuthentication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RolesController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        public RolesController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IEnumerable<IdentityRole> Get()
        {
            return _context.Roles.AsEnumerable();
        }

        [HttpPost]
        public void Post([FromBody] string roleName)
        {
            var roleToAdd = new IdentityRole
            {
                Name = roleName,
                NormalizedName = roleName.ToUpper()
            };

            _context.Roles.Add(roleToAdd);

            _context.SaveChanges();
        }

        [HttpDelete("{id}")]
        public void Delete(string id)
        {
            var roleToDelete = _context.Roles.First(r => r.Id.Equals(id));

            _context.Roles.Remove(roleToDelete);

            _context.SaveChanges();
        }

    }
}
