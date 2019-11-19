using Abp.AutoMapper;
using AbpGiftCard.Roles.Dto;
using AbpGiftCard.Web.Models.Common;

namespace AbpGiftCard.Web.Models.Roles
{
    [AutoMapFrom(typeof(GetRoleForEditOutput))]
    public class EditRoleModalViewModel : GetRoleForEditOutput, IPermissionsEditViewModel
    {
        public bool HasPermission(FlatPermissionDto permission)
        {
            return GrantedPermissionNames.Contains(permission.Name);
        }
    }
}
