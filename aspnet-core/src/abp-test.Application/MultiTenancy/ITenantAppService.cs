using Abp.Application.Services;
using abp-test.MultiTenancy.Dto;

namespace abp-test.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

