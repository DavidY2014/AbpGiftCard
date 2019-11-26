using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbpGiftCard.Entitys
{
    public class Catelog : Entity, IHasCreationTime
    {
        public int ClassId { get; set; }

        public string ClassName { get; set; }

        public ClassLevel Level { get; set; }


        public DateTime CreationTime { get; set; }
    }

    public enum ClassLevel
    {
        First,Second,Third
    }
}
