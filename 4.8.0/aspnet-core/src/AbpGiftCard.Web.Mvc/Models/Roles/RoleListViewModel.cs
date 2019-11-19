using System.Collections.Generic;
using AbpGiftCard.Roles.Dto;

namespace AbpGiftCard.Web.Models.Roles
{
    public class RoleListViewModel
    {
        public IReadOnlyList<RoleListDto> Roles { get; set; }

        public IReadOnlyList<PermissionDto> Permissions { get; set; }
    }
}
