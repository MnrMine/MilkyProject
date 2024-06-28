using MilkyProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilkyProject.BusinesLayer.Astract
{
    public interface ICategoryService : IGenericService<Category>
    {
        int TGetCategoryCount();
    }
}
