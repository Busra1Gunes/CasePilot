using Autofac;
using Autofac.Extras.DynamicProxy;
using Business.Abstract;
using Business.Concrete;
using Castle.DynamicProxy;

using Core.CrossCuttingConcerns.Caching;
using Core.CrossCuttingConcerns.Caching.Microsoft;
using Core.Utilities.Interceptors;
using DataAccess.Abstract;
using DataAccess.Concrete;
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
              // ============================================
            // AUTHENTICATION & PASSWORD
            // ============================================
            builder.RegisterType<PasswordManager>().As<IPasswordService>().InstancePerLifetimeScope();
            builder.RegisterType<AuthManager>().As<IAuthService>().InstancePerLifetimeScope();

            // ============================================
            // USER
            // ============================================
            builder.RegisterType<UserManager>().As<IUserService>().InstancePerLifetimeScope();
            builder.RegisterType<EfUserDal>().As<IUserDal>().InstancePerLifetimeScope();

            // ============================================
            // CASE FILE
            // ============================================
            builder.RegisterType<CaseFileManager>().As<ICaseFileService>().InstancePerLifetimeScope();
            builder.RegisterType<EfCaseFileDal>().As<ICaseFileDal>().InstancePerLifetimeScope();

            // ============================================
            // CASE TYPE
            // ============================================
            builder.RegisterType<CaseTypeManager>().As<ICaseTypeService>().InstancePerLifetimeScope();
            builder.RegisterType<EfCaseTypeDal>().As<ICaseTypeDal>().InstancePerLifetimeScope();

            // ============================================
            // APPLICATION TYPE
            // ============================================
            builder.RegisterType<ApplicationTypeManager>().As<IApplicationTypeService>().InstancePerLifetimeScope();
            builder.RegisterType<EfApplicationTypeDal>().As<IApplicationTypeDal>().InstancePerLifetimeScope();

            // ============================================
            // CASE FILE DOCUMENT
            // ============================================
            builder.RegisterType<CaseFileDocumentManager>().As<ICaseFileDocumentService>().InstancePerLifetimeScope();
            builder.RegisterType<EfCaseFileDocumentDal>().As<ICaseFileDocumentDal>().InstancePerLifetimeScope();

            // ============================================
            // CASE FILE DEFENDANT
            // ============================================
            builder.RegisterType<CaseFileDefendantManager>().As<ICaseFileDefendantService>().InstancePerLifetimeScope();
            builder.RegisterType<EfCaseFileDefendantDal>().As<ICaseFileDefendantDal>().InstancePerLifetimeScope();

            // ============================================
            // ACCOUNT TRANSACTION
            // ============================================
            builder.RegisterType<AccountTransactionManager>().As<IAccountTransactionService>().InstancePerLifetimeScope();
            builder.RegisterType<EfAccountTransactionDal>().As<IAccountTransactionDal>().InstancePerLifetimeScope();

            // ============================================
            // CASE FILE SHARE
            // ============================================
            builder.RegisterType<CaseFileShareManager>().As<ICaseFileShareService>().InstancePerLifetimeScope();
            builder.RegisterType<EfCaseFileShareDal>().As<ICaseFileShareDal>().InstancePerLifetimeScope();

            // ============================================
            // DEFENDANT
            // ============================================
            builder.RegisterType<DefendantManager>().As<IDefendantService>().InstancePerLifetimeScope();
            builder.RegisterType<EfDefendantDal>().As<IDefendantDal>().InstancePerLifetimeScope();

            // ============================================
            // DOCUMENT TYPE
            // ============================================
            builder.RegisterType<EfDocumentTypeDal>().As<IDocumentTypeDal>().InstancePerLifetimeScope();

            // ============================================
            // CITY & DISTRICT
            // ============================================
            builder.RegisterType<EfCityDal>().As<ICityDal>().InstancePerLifetimeScope();
            builder.RegisterType<EfDistrictDal>().As<IDistrictDal>().InstancePerLifetimeScope();
            builder.RegisterType<CityDistrictManager>().As<ICityDistrictService>().InstancePerLifetimeScope();

            // ============================================
            // MAIN SERVICE
            // ============================================
            builder.RegisterType<CasePilotContext>().AsSelf().InstancePerLifetimeScope();
            builder.RegisterType<MainManager>().As<IMainService>().InstancePerLifetimeScope();

            // ============================================
            // ROLE & PERMISSION
            // ============================================
            builder.RegisterType<RoleManager>().As<IRoleService>().InstancePerLifetimeScope();
            builder.RegisterType<EfRoleDal>().As<IRoleDal>().InstancePerLifetimeScope();

            builder.RegisterType<PermissionManager>().As<IPermissionService>().InstancePerLifetimeScope();
            builder.RegisterType<EfPermissionDal>().As<IPermissionDal>().InstancePerLifetimeScope();

            builder.RegisterType<RolePermissionManager>().As<IRolePermissionService>().InstancePerLifetimeScope();
            builder.RegisterType<EfRolePermissionDal>().As<IRolePermissionDal>().InstancePerLifetimeScope();

            // ============================================
            // CASE FILE NOTE
            // ============================================
            builder.RegisterType<CaseFileNoteManager>().As<ICaseFileNoteService>().InstancePerLifetimeScope();
            builder.RegisterType<EfCaseFileNoteDal>().As<ICaseFileNoteDal>().InstancePerLifetimeScope();

            // ============================================
            // COURT
            // ============================================
            builder.RegisterType<CourtManager>().As<ICourtService>().InstancePerLifetimeScope();
            builder.RegisterType<EfCourtDal>().As<ICourtDal>().InstancePerLifetimeScope();

            // ============================================
            // HEARING
            // ============================================
            builder.RegisterType<HearingManager>().As<IHearingService>().InstancePerLifetimeScope();
            builder.RegisterType<EfHearingDal>().As<IHearingDal>().InstancePerLifetimeScope();

            // ============================================
            // INCOME (GELİR) - YENİ EKLENDI
            // ============================================
            builder.RegisterType<IncomeManager>().As<IIncomeService>().InstancePerLifetimeScope();
            builder.RegisterType<EfIncomeDal>().As<IIncomeDal>().InstancePerLifetimeScope();

            builder.RegisterType<IncomeCategoryManager>().As<IIncomeCategoryService>().InstancePerLifetimeScope();
            builder.RegisterType<EfIncomeCategoryDal>().As<IIncomeCategoryDal>().InstancePerLifetimeScope();

            // ============================================
            // EXPENSE (GİDER) - YENİ EKLENDI
            // ============================================
            builder.RegisterType<ExpenseManager>().As<IExpenseService>().InstancePerLifetimeScope();
            builder.RegisterType<EfExpenseDal>().As<IExpenseDal>().InstancePerLifetimeScope();

            builder.RegisterType<ExpenseCategoryManager>().As<IExpenseCategoryService>().InstancePerLifetimeScope();
            builder.RegisterType<EfExpenseCategoryDal>().As<IExpenseCategoryDal>().InstancePerLifetimeScope();

            // ============================================
            // CACHE SERVICE
            // ============================================
            builder.RegisterType<RedisCacheManager>().As<ICacheService>().InstancePerLifetimeScope();

            // ============================================
            // ASSEMBLY INTERCEPTORS
            // ============================================
            var assembly = System.Reflection.Assembly.GetExecutingAssembly();

            builder.RegisterAssemblyTypes(assembly).AsImplementedInterfaces()
                .EnableInterfaceInterceptors(new ProxyGenerationOptions()
                {
                    Selector = new AspectInterceptorSelector()
                })
                .SingleInstance();
        }

       
    }
}
