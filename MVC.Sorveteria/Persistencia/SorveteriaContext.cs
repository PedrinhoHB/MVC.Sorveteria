using MVC.Sorveteria.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MVC.Sorveteria.Persistencia
{
    public class SorveteriaContext : DbContext
    {
        public DbSet<Sorvete> Sorvetes { get; set; }
        public DbSet<Loja> Lojas { get; set; }
    }
}