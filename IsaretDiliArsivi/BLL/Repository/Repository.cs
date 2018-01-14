using Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Repository
{
    public class Repository
    {
        public class CategoriesRepo : RepositoryBase<Categories, int> { }

        public class GifNamesRepo : RepositoryBase<GifNames, int> { }
    }
}
