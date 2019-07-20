using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Desafio.API.DTOs;
using Desafio.Repositorio.Abstrato.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Desafio.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        public IUsuarioRepositorio Repositorio { get; }

        public UsuarioController(IUsuarioRepositorio repositorio)
        {
            Repositorio = repositorio ?? throw new ArgumentNullException(nameof(repositorio));
        }

        [HttpGet]
        public IActionResult Get()
        {
            var usuarios = Repositorio.Get();

            return new JsonResult(usuarios);
        }

        [HttpGet("Tudo")]
        public IActionResult GetFull()
        {
            var usuariosCompleto = Repositorio.GetFull();

            return new JsonResult(usuariosCompleto);
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var usuario = Repositorio.Get(id);

            return new JsonResult(usuario);
        }

        [HttpPost]
        public IActionResult Create([FromBody] UsuarioDTO request)
        {
            return Ok();
        }
    }
}