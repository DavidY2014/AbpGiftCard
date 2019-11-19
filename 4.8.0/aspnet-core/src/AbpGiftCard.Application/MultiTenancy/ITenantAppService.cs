using Abp.Application.Services;
using Abp.Application.Services.Dto;
using AbpGiftCard.MultiTenancy.Dto;

namespace AbpGiftCard.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

