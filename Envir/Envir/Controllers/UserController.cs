﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Envir.Models;
using Envir.Services;
using Microsoft.AspNetCore.Mvc;
namespace Envir.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        private readonly UserService _userService;

        public UserController(UserService userService)
        {
            _userService = userService;
        }

        [HttpGet]
        public ActionResult<List<User>> Get() => _userService.Get();

        [HttpGet("{id:length(24)}", Name = "GetUser")]
        public ActionResult<User> Get(string id)
        {
            var user = _userService.Get(id);

            if (user == null)
            {
                return NotFound();
            }
            return user;
        }

        [HttpPost]
        public ActionResult<User> Create(User user)
        {
            _userService.Create(user);

            return CreatedAtRoute("GetUser", new { id = user.Id.ToString() }, user);
        }

    }
}
