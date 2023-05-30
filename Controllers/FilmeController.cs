using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FilmesApi.Models;

namespace FilmesApi.Controllers;

[ApiController]
[Route("api/filmes")]
public class FilmeController : ControllerBase
{
    private IList<Filme> Filmes = MockFilmes.Filmes;

    [HttpGet]
    public IActionResult Get() {
      return Ok(Filmes);
    }

    [HttpGet("{id}")]
    public IActionResult Get(int id) {    
      Filme filme = Filmes.ElementAtOrDefault(id - 1);
      if (filme == null)
      {
          return NotFound("Não existe filme com o índice apresentado.");
      }

      return Ok(filme);
    }

    [HttpPost]
    public IActionResult Post([FromBody] Filme dto) {
      Filmes.Add(dto);
      return Ok(Filmes.Last());
    }

    [HttpPut("{id}")]
    public String Put(int id, [FromBody] String text) {
      return "ei ei ei :) o id é " + id + "e o texto é" + text;
    }

    [HttpDelete("{id}")]
    public String Delete(int id) {
      return "é foi deletado do id " + id;
    }
}
