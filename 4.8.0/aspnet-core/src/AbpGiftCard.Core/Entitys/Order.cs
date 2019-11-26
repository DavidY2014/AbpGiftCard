using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbpGiftCard.Entitys
{
    /// <summary>
    /// 商品订单
    /// </summary>
    public class Order : Entity, IHasCreationTime
    {
        public int OrderId { get; set; }

        public ICollection<OrderProductDetail> orderProducts { get; set; }

        public string CouponNumber { get; set; }
        public int BatchNumber { get; set; }

        public OrderStatus OrderStatus { get; set; }

        public string ContactPhone { get; set; }

        public string ReceiverName { get; set; }

        public string ReceiverAddress { get; set; }

        public string DeliveryNumber { get; set; }

        public DateTime CreationTime { get; set; }
    }

    public enum OrderStatus
    {
        WaitingSend,
        AlreadSend,
    }
}
