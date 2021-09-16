using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using App.Service.Services.Interfaces;

namespace App.Web.Api
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonsController : Controller
    {
        private IuserService _userService;

        public PersonsController(IuserService userService)
        {
            _userService = userService;
        }

        [HttpGet("{id}")]
        public IActionResult GetUser([FromRoute] int id)
        {
            return new ObjectResult(_userService.GetPerson(id));
        }
    }
}
