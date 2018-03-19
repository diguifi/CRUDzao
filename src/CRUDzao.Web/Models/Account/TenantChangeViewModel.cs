using Abp.AutoMapper;
using CRUDzao.Sessions.Dto;

namespace CRUDzao.Web.Models.Account
{
    [AutoMapFrom(typeof(GetCurrentLoginInformationsOutput))]
    public class TenantChangeViewModel
    {
        public TenantLoginInfoDto Tenant { get; set; }
    }
}