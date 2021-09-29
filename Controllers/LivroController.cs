using System;
using System.Collections.Generic;
using System.Linq;
using API.Data;
using API.Models;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("api/livro")]
    public class LivroController : ControllerBase
    {
        private readonly DataContext _context;
        public LivroController(DataContext context)
        {
            _context = context;
        }

        //POST: /api/livro/create
        [Route("create")]
        [HttpPost]
        public IActionResult Create([FromBody] Livro livro)
        {
            _context.Livros.Add(livro);
            _context.SaveChanges();
            return Created("", livro);
        }

       
        

        

       
    }
}