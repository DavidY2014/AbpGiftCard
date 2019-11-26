using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace AbpGiftCard.Entitys
{
    /// <summary>
    /// 劵订单
    /// </summary>
    public class CouponOrder : Entity, IHasCreationTime
    {
        [Required]
        public string CustomerName { get; set; }
        public string SaleManName { get; set; }

        public int BatchNumber { get; set; }

        [Required]
        public int SaleCount { get; set; }

        [Required]
        public double Price { get; set;}

        public double Amount { get; set; }

        [Required]
        public DateTime Validatetime { get; set; }

        public int StartRangeNumber { get; set; }
        public int EndRangeNumber { get; set; }

        [Required]
        public CouponStatus CouponStatus { get; set; }

        public string OperatorName { get; set; }
        public DateTime CreationTime { get; set; }

        #region 关联的详情信息,合同信息

        public bool IsSignContact { get; set; }

        public Contract ContractRef { get; set; }

        public ActiveMethod ActiveMethod { get; set; } 

        public DateTime ActiveTime { get; set; }



        #endregion


    }

    public enum CouponStatus
    {
        Active,
        InActive
    }

    public enum ActiveMethod
    {
        ActiveRightNow,
        SpecifyTimeActive
    }
}
