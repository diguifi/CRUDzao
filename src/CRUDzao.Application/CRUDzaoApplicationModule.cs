using System.Reflection;
using Abp.Authorization;
using Abp.Authorization.Roles;
using Abp.Authorization.Users;
using Abp.AutoMapper;
using Abp.Domain.Repositories;
using Abp.Modules;
using CRUDzao.Authorization.Roles;
using CRUDzao.Authorization.Users;
using CRUDzao.Clients.Dtos;
using CRUDzao.Entities.Client;
using CRUDzao.Roles.Dto;
using CRUDzao.Users.Dto;

namespace CRUDzao
{
    [DependsOn(typeof(CRUDzaoCoreModule), typeof(AbpAutoMapperModule))]
    public class CRUDzaoApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Modules.AbpAutoMapper().Configurators.Add(config =>
            {
                config.CreateMap<CreateClientInput, Client>()
                .ConstructUsing(x => new Client(x.FirstName, x.LastName, x.City, x.Adress,
                x.Number, x.Email, x.Phone, x.Birth, x.Height, x.Weight));

                config.CreateMap<UpdateClientInput, Client>()
                .ConstructUsing(x => new Client(x.FirstName, x.LastName, x.City, x.Adress,
                x.Number, x.Email, x.Phone, x.Birth, x.Height, x.Weight));
            });
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());

            // TODO: Is there somewhere else to store these, with the dto classes
            Configuration.Modules.AbpAutoMapper().Configurators.Add(cfg =>
            {
                // Role and permission
                cfg.CreateMap<Permission, string>().ConvertUsing(r => r.Name);
                cfg.CreateMap<RolePermissionSetting, string>().ConvertUsing(r => r.Name);

                cfg.CreateMap<CreateRoleDto, Role>().ForMember(x => x.Permissions, opt => opt.Ignore());
                cfg.CreateMap<RoleDto, Role>().ForMember(x => x.Permissions, opt => opt.Ignore());
                
                cfg.CreateMap<UserDto, User>();
                cfg.CreateMap<UserDto, User>().ForMember(x => x.Roles, opt => opt.Ignore());

                cfg.CreateMap<CreateUserDto, User>();
                cfg.CreateMap<CreateUserDto, User>().ForMember(x => x.Roles, opt => opt.Ignore());
            });
        }
    }
}
