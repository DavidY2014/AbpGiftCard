using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace AbpGiftCard.Entitys
{
    public class ProductInformation : Entity, IHasCreationTime
    {

        public const int MaxLength = 255;

        public ProductInformation()
        {
            this.ProductName = string.Empty;
            this.ProductTitle = string.Empty;
        }

        public string DeliveryAddress { get; set; }

        [Required]
        public string ProductName { get; set; }

        [Required]
        public string ProductTitle { get; set; }

        [Required]
        public int ProductId { get; set; }

        public string BelongSupplierName { get; set; }

        [Required]
        public int SupplierId { get; set; }
        public int Class1Id { get; set; }
        public string Class1Name { get; set; }

        public int Class2Id { get; set; }
        public string Class2Name { get; set; }

        public double Cost { get; set; }

        [Required]
        public double SalePrice { get; set; }
        public int TotalStock { get; set; }
        public int SaledStock { get; set; }

        [Required]
        public ProductEnum ProductStatus { get; set;}


        [MaxLength(MaxLength)]
        public string Description { get; set; }

        public DateTime CreationTime { get; set; }
        
    
    }

    public enum ProductEnum
    {
        Yes,
        No
    }
}
