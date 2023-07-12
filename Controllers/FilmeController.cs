using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FilmesApi.Models;
using Microsoft.EntityFrameworkCore.Internal;
using FilmesApi.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Http.HttpResults;

namespace FilmesApi.Controllers;

[ApiController]
[Route("api/filmes")]
public class FilmeController : ControllerBase
{
    private readonly FilmeDbContext context;

    public FilmeController(FilmeDbContext context)
    {
        this.context = context;
    }

    [HttpGet]
    public async Task<ActionResult<List<Filme>>> Get() {
      return Ok(await context.Filmes.ToListAsync());
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<Filme>> Get(int id) {
        Filme? filme = await context.Filmes.FindAsync(id);

        if (filme is null)
        {
          return NotFound("Não existe filme com o índice apresentado.");
        }

        return Ok(filme);
    }

    [HttpPost]
    public async Task<ActionResult<Filme>> Post([FromBody] Filme dto)
    {
        try
        {
            var filme = context.Filmes.Add(dto);
            await context.SaveChangesAsync();

            return CreatedAtAction(nameof(Get), filme);
        }
        catch (Exception e)
        {
            return BadRequest(e.Message);
        }
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
