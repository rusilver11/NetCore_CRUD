using Microsoft.AspNetCore.Mvc;
using NetCore_CRUD.Models;
using NetCore_CRUD.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCore_CRUD.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUsersService _userService;
        public UserController(IUsersService userService)
        {
            _userService = userService;
        }

        // GET: api/<UserController>
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var result = await _userService.GetUserList();
            return Ok(result);
        }

        // GET api/<UserController>/5
        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetUser(int id)
        {
            var result = await _userService.GetUser(id);
            return Ok(result);
        }

        // POST api/<UserController>
        [HttpPost]
        public async Task<IActionResult> AddUser([FromBody] tbl_users.create_user user)
        {
            var result = await _userService.CreateUser(user);
            return Ok(result);
        }

        // PUT api/<UserController>/5
        [HttpPut("{id:int}")]
        public async Task<IActionResult> UpdateUser(int id,[FromBody] tbl_users.create_user user)
        {
            var result = await _userService.UpdateUser(id, user);
            return Ok(result);
        }

        // DELETE api/<UserController>/5
        [HttpDelete("{id:int}")]
        public async Task<IActionResult> DeleteUser(int id)
        {
            var result = await _userService.DeleteUser(id);
            return Ok(result);
        }
    }
}
