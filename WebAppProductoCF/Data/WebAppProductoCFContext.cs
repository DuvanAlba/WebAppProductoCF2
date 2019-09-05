using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebAppProductoCF.Models;

    public class WebAppProductoCFContext : DbContext
    {
        public WebAppProductoCFContext (DbContextOptions<WebAppProductoCFContext> options)
            : base(options)
        {
        }

        public DbSet<WebAppProductoCF.Models.Categoria> Categoria { get; set; }

        public DbSet<WebAppProductoCF.Models.Producto> Producto { get; set; }
    }
