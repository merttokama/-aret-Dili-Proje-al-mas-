using Entity.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class MyContext : DbContext
    {
        public MyContext()
            : base("name=MyCon")
        {

        }

        public DbSet<Categories> Kategoriler { get; set; }
        public DbSet<GifNames> GifIsımleri { get; set; }
    }
}