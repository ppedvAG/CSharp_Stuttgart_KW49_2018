using ppedv.PureTrendy.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class EfContext : DbContext
    {
        public DbSet<Schlaginstrument> Schlaginstrument { get; set; }
        public DbSet<Blasinstrument> Blasinstrument { get; set; }



    }
}