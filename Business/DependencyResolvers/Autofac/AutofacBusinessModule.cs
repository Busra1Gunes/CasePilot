using Autofac;
using Autofac.Extras.DynamicProxy;
using Business.Abstract;
using Business.Concrete;
using Castle.DynamicProxy;

using Core.CrossCuttingConcerns.Caching;
using Core.CrossCuttingConcerns.Caching.Microsoft;
using Core.Utilities.Interceptors;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.DependencyResolvers.Autofac
{
    public class AutofacBusinessModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {


            builder.RegisterType<AuthManager>().As<IAuthService>().InstancePerLifetimeScope();
        

            builder.RegisterType<UserManager>().As<IUserService>().InstancePerLifetimeScope();
            builder.RegisterType<EfUserDal>().As<IUserDal>().InstancePerLifetimeScope();

            builder.RegisterType<CaseFileManager>().As<ICaseFileService>().InstancePerLifetimeScope();
            builder.RegisterType<EfCaseFileDal>().As<ICaseFileDal>().InstancePerLifetimeScope();

			builder.RegisterType<CaseTypeManager>().As<ICaseTypeService>().InstancePerLifetimeScope();
			builder.RegisterType<EfCaseTypeDal>().As<ICaseTypeDal>().InstancePerLifetimeScope();

            builder.RegisterType<ApplicationTypeManager>().As<IApplicationTypeService>().InstancePerLifetimeScope();
            builder.RegisterType<EfApplicationTypeDal>().As<IApplicationTypeDal>().InstancePerLifetimeScope();

            builder.RegisterType<CaseFileDocumentManager>().As<ICaseFileDocumentService>().InstancePerLifetimeScope();
            builder.RegisterType<EfCaseFileDocumentDal>().As<ICaseFileDocumentDal>().InstancePerLifetimeScope();


            builder.RegisterType<CaseFileDefendantManager>().As<ICaseFileDefendantService>().InstancePerLifetimeScope();
            builder.RegisterType<EfCaseFileDefendantDal>().As<ICaseFileDefendantDal>().InstancePerLifetimeScope();

            builder.RegisterType<AccountTransactionManager>().As<IAccountTransactionService>().InstancePerLifetimeScope();
            builder.RegisterType<EfAccountTransactionDal>().As<IAccountTransactionDal>().InstancePerLifetimeScope();

            builder.RegisterType<CaseFileShareManager>().As<ICaseFileShareService>().InstancePerLifetimeScope();
            builder.RegisterType<EfCaseFileShareDal>().As<ICaseFileShareDal>().InstancePerLifetimeScope();

            builder.RegisterType<DefendantManager>().As<IDefendantService>().InstancePerLifetimeScope();
            builder.RegisterType<EfDefendantDal>().As<IDefendantDal>().InstancePerLifetimeScope();

            builder.RegisterType<RedisCacheManager>().As<ICacheService>().InstancePerLifetimeScope();           

			builder.RegisterType<EfDocumentTypeDal>().As<IDocumentTypeDal>().InstancePerLifetimeScope();


            builder.RegisterType<EfCityDal>().As<ICityDal>().InstancePerLifetimeScope();
            builder.RegisterType<EfDistrictDal>().As<IDistrictDal>().InstancePerLifetimeScope();
            builder.RegisterType<CityDistrictManager>().As<ICityDistrictService>().InstancePerLifetimeScope();

            builder.RegisterType<CasePilotContext>().AsSelf().InstancePerLifetimeScope();
            builder.RegisterType<MainManager>().As<IMainService>().InstancePerLifetimeScope();


            builder.RegisterType<RoleManager>().As<IRoleService>().InstancePerLifetimeScope();
            builder.RegisterType<EfRoleDal>().As<IRoleDal>().InstancePerLifetimeScope();


            builder.RegisterType<PermissionManager>().As<IPermissionService>().InstancePerLifetimeScope();
            builder.RegisterType<EfPermissionDal>().As<IPermissionDal>().InstancePerLifetimeScope();

            builder.RegisterType<RolePermissionManager>().As<IRolePermissionService>().InstancePerLifetimeScope();
            builder.RegisterType<EfRolePermissionDal>().As<IRolePermissionDal>().InstancePerLifetimeScope();

            builder.RegisterType<CaseFileNoteManager>().As<ICaseFileNoteService>().InstancePerLifetimeScope();
            builder.RegisterType<EfCaseFileNoteDal>().As<ICaseFileNoteDal>().InstancePerLifetimeScope();


            builder.RegisterType<CourtManager>().As<ICourtService>().InstancePerLifetimeScope();
            builder.RegisterType<EfCourtDal>().As<ICourtDal>().InstancePerLifetimeScope();

            builder.RegisterType<HearingManager>().As<IHearingService>().InstancePerLifetimeScope();
            builder.RegisterType<EfHearingDal>().As<IHearingDal>().InstancePerLifetimeScope();


            //Bu C# kodu, Dependency Injection (Bağımlılık Enjeksiyonu) işlemi için kullanılan bir yapılandırmadır
            //ve genellikle Autofac gibi bir Inversion of Control (IoC) konteyneri kullanılarak gerçekleştirilir. Kodun amacı,
            //belirtilen assembly'deki tüm sınıfları tarayarak, onların uyguladıkları arayüzler ile birlikte IoC konteynerine kaydetmek
            //ve bu sınıflar için interceptor (kesici) tanımlamaktır.
            var assembly = System.Reflection.Assembly.GetExecutingAssembly();

            builder.RegisterAssemblyTypes(assembly).AsImplementedInterfaces()
                .EnableInterfaceInterceptors(new ProxyGenerationOptions()
                {
                    Selector = new AspectInterceptorSelector() // <== BU ÖNEMLİ
                })
                .SingleInstance();
        }

       
    }
}
