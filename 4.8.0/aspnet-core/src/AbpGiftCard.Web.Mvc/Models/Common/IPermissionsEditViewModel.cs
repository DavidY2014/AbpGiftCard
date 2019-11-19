using System.Collections.Generic;
using AbpGiftCard.Roles.Dto;

namespace AbpGiftCard.Web.Models.Common
{
    public interface IPermissionsEditViewModel
    {
        List<FlatPermissionDto> Permissions { get; set; }
    }
}