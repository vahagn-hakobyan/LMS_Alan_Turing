using LMS_Alan_Turing.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Razor.Language;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LMS_Alan_Turing.Controllers
{

     
    [Route("[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
       
        private readonly Alan_TuringContext baza;
        public UserController(Alan_TuringContext baza)
        {
            this.baza = baza;
            
        }
                  
        [HttpGet]
        public async Task<ActionResult<IEnumerable<User>>> GetUserItems()
        {
            return await baza.Users.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<User>> GetUserItem(long id)
        {
            id = 5;
            var todoItem = await baza.Users.FindAsync(id);
            if (todoItem == null)
            {
                return NotFound();
            }
            return todoItem;
        }
        [HttpPost]
        public async Task<ActionResult<User>> PostTodoItem(User item)
        {
            
            baza.Users.Add(item);
            await baza.SaveChangesAsync();
            return CreatedAtAction(nameof(GetUserItem), new { id = item.Id }, item);
        }









    }

}