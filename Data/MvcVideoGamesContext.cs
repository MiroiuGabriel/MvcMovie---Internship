using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MvcMovie.Models;

namespace MvcMovie.Data
{
    public class MvcVideoGamesContext : DbContext
    {
        public MvcVideoGamesContext (DbContextOptions<MvcVideoGamesContext> options)
            : base(options)
        {
        }

        public DbSet<MvcMovie.Models.VideoGame> VideoGame { get; set; } = default!;
    }
}
