using MeuTodo.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace MeuTodo.Controllers
{
    [ApiController]
    [Route(template: "v1")]
    public class TodoController : ControllerBase
    {
        [HttpGet]
        [Route(template: "todos")]
        public List<Todo> Get()
        {
            return new List<Todo>();
        }
    }
}
