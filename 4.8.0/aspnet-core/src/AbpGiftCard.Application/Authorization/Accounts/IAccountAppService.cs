using System.Threading.Tasks;
using Abp.Application.Services;
using AbpGiftCard.Authorization.Accounts.Dto;

namespace AbpGiftCard.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
