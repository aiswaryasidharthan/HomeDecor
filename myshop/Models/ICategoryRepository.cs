using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace myshop.Models
{
    public interface ICategoryRepository
    {
        IEnumerable<Category> GetCategories { get; }
    }

}
