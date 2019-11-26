using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbpGiftCard.Entitys
{
   public class CouponFinanceDetail: Entity, IHasCreationTime
    {
        public RepayMethod PayMethod { get; set; }

        public DateTime ReturnPayTime { get; set; }
        public bool IsOpenBill { get; set; }
        public BillType BillType { get; set; }

        public string BillContent { get; set; }
        public string BillTitle { get; set; }

        public string TaxIdentityNumber { get; set; }
        public string OpenBank { get; set; }
        public string OpenBankAccount { get; set; }
        public string BillAddress { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime CreationTime { get; set; }
    }

    /// <summary>
    /// 回款方式
    /// </summary>
    public enum RepayMethod
    {
        OnceRepay,
        DivdeRepay
    }

    public enum BillType
    {
        NormalBill,
        SpecifyBill
    }
}
