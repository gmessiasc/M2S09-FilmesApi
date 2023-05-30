using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FilmesApi.Models;

public class Filme
{
    public int Id { get; set; }

    public String Name { get; set; }

    public String Director { get; set; }

    public String Genre { get; set; }

    public int Duration { get; set; }
}
