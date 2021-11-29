using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CoaMVC.Models;

    public class COA_Context : DbContext
    {
        public COA_Context (DbContextOptions<COA_Context> options)
            : base(options)
        {
        }

        public DbSet<CoaMVC.Models.Usuario> Usuario { get; set; }
    }
