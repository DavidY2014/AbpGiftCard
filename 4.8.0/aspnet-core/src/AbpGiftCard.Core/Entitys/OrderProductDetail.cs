using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbpGiftCard.Entitys
{
    /// <summary>
    /// 商品订单下的商品明细
    /// </summary>
    public class OrderProductDetail : Entity, IHasCreationTime
    {
        public string ProductName { get; set; }

        public int ProductId { get; set; }

        public string BelongSupplierName { get; set; }
        public int BelongSupplierId { get; set; }

        public int BuyCount { get; set;}

        public DateTime CreationTime { get; set; }
    }
}
