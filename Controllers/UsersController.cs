using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using wastemanagementapi.Data;
using wastemanagementapi.Mappers;

namespace wastemanagementapi.Controllers
{
    [Route("api/user")]
    [ApiController]
    public class UsersController : ControllerBase
    
    {
        private readonly ApplicationDBContext _context;
        public UsersController(ApplicationDBContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var users = _context.User.ToList()
                        .Select(s => s.ToUserResponseDTO());

            return Ok(users);
        }

        [HttpGet("{id}")]
        public IActionResult GetUserById([FromRoute] int id){
            var user = _context.User.FirstOrDefault(x => x.Id == id);
            if (user == null)
            {
                return NotFound();
            }
            return Ok(user.ToUserResponseDTO());
        }

    }
}