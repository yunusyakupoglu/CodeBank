using DAL;
using DAL.Entities;
using DAL.Validations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Service
{
    public class CategoryService : ServiceBase<AppDbContext,Category,CategoryValidator>
    {
    }
}
