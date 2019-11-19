using Abp.Authorization;
using AbpGiftCard.Authorization.Roles;
using AbpGiftCard.Authorization.Users;

namespace AbpGiftCard.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
