using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbpGiftCard.Entitys
{
    public class Contract: Entity, IHasCreationTime
    {
        public string ContractTitle { get; set; }

        public string ContractCode { get; set; }


        public DateTime CreationTime { get; set; }
    }
}
