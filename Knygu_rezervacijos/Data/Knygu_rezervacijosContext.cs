using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Knygu_rezervacijos.Models;

namespace Knygu_rezervacijos.Data
{
    public class Knygu_rezervacijosContext : DbContext
    {
        public Knygu_rezervacijosContext(DbContextOptions<Knygu_rezervacijosContext> options)
            : base(options)
        {
        }

        public DbSet<Knygu_rezervacijos.Models.Knyga> Knyga { get; set; }
    }
}