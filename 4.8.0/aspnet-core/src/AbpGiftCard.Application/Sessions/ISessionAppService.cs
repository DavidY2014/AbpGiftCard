using System.Threading.Tasks;
using Abp.Application.Services;
using AbpGiftCard.Sessions.Dto;

namespace AbpGiftCard.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
