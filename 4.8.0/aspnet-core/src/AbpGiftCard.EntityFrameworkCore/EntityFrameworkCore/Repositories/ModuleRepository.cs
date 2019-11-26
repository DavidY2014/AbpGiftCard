using Abp.EntityFrameworkCore;
using AbpGiftCard.Entitys;
using AbpGiftCard.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace AbpGiftCard.EntityFrameworkCore.Repositories
{
   public class ModuleRepository: AbpGiftCardRepositoryBase<Module>, IModuleRepository
    {
        public ModuleRepository(IDbContextProvider<AbpGiftCardDbContext> dbContextProvider)
            : base(dbContextProvider)
        {
        }

        public bool Delete(string ids)
        {
            var idList = ids.Split(',');
            Expression<Func<Module, bool>> exp = m => idList.Contains(m.Id.ToString());

            bool result = true;
            Delete(exp);
            return result;

        }

        public IEnumerable<Module> LoadModules(int pageindex, int pagesize)
        {
            return Context.Modules.OrderBy(u => u.Id).Skip((pageindex - 1) * pagesize).Take(pagesize);

        }


    }
}
