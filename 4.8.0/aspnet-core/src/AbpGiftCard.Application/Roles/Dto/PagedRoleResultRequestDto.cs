using Abp.Application.Services.Dto;

namespace AbpGiftCard.Roles.Dto
{
    public class PagedRoleResultRequestDto : PagedResultRequestDto
    {
        public string Keyword { get; set; }
    }
}

