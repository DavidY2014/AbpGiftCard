using System.Collections.Generic;
using AbpGiftCard.Roles.Dto;
using AbpGiftCard.Users.Dto;

namespace AbpGiftCard.Web.Models.Users
{
    public class UserListViewModel
    {
        public IReadOnlyList<UserDto> Users { get; set; }

        public IReadOnlyList<RoleDto> Roles { get; set; }
    }
}
