using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace AbpGiftCard.Entitys
{
    public class Finance : Entity, IHasCreationTime
    {
        [Required]
        public string TaxNumber { get; set; }

        [Required]
        public string TaxTitle { get; set;}

        [Required]
        public string Openbank { get; set; }

        [Required]
        public string BankAccount { get; set; }

        public DateTime CreationTime { get; set; }
    }
}
