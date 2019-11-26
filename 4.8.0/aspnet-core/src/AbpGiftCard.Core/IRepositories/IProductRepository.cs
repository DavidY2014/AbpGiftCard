using Abp.Domain.Repositories;
using AbpGiftCard.Entitys;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbpGiftCard.IRepositories
{
    /// <summary>
    /// 商品仓储
    /// </summary>
    public interface IProductRepository : IRepository<ProductInformation>
    {


    }
}
