using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TallerPinReyes.Models;

namespace TallerPinReyes.Data
{
    public class TallerPinReyesContext : DbContext
    {
        public TallerPinReyesContext (DbContextOptions<TallerPinReyesContext> options)
            : base(options)
        {
        }

        public DbSet<TallerPinReyes.Models.Usuario> Usuario { get; set; } = default!;
    }
}
