using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DAL
{
    public class Db : DbContext
    {
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Directors> Directors { get; set; }

        public Db(DbContextOptions<Db> options) : base(options)
        {

        }

    }
}
