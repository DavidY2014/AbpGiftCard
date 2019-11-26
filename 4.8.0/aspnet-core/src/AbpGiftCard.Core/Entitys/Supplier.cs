using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace AbpGiftCard.Entitys
{
    public class Supplier : Entity, IHasCreationTime
    {
        [Required]
        public int SupplierId { get; set; }

        [Required]
        public string SupplierName { get; set; }

        [Required]
        public SupplierType SupplierType { get; set; }

        [Required]
        public string FinanceContactor { get; set; }
        public string FinancePhone { get; set; }

        /// <summary>
        /// 发货人的姓名
        /// </summary>
        [Required]
        public string DeliveryName { get; set;  }

        public string DeliveryPhone { get; set; }

        #region 新增界面增加的

        public string CompanyName { get; set; }

        public string CompanyAddress { get; set; }

        /// <summary>
        /// 售后
        /// </summary>
        public string ServiceContactor { get; set; }
        public string ServicePhone { get; set; }

        public Finance FinanceRef { get; set; }

        #endregion

        public DateTime CreationTime { get; set; }
    }

    public enum SupplierType
    {
        Self,
        Third,
    }
}
