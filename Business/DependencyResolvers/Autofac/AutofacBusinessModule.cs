using Autofac;
using Autofac.Extras.DynamicProxy;
using Business.Abstract;
using Business.Concrete;
using Castle.DynamicProxy;
using Core.Utilities.Interceptors;
using DataAccess.Abstract;
using DataAccess.Concrete;
using DataAccess.Concrete.EntityFramework;
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
            //Birisi senden IStockService isterse ona StockManager registe et
            builder.RegisterType<KullaniciManager>().As<IKullaniciService>().InstancePerLifetimeScope();
            builder.RegisterType<EfKullaniciDal>().As<IKullaniciDal>().InstancePerLifetimeScope();

            builder.RegisterType<DosyaManager>().As<IDosyaService>().InstancePerLifetimeScope();
            builder.RegisterType<EfDosyaDal>().As<IDosyaDal>().InstancePerLifetimeScope();
			builder.RegisterType<DavaTurManager>().As<IDavaTurService>().InstancePerLifetimeScope();
			builder.RegisterType<EfDavaTurDal>().As<IDavaTurDal>().InstancePerLifetimeScope();
			builder.RegisterType<Context>().AsSelf().InstancePerLifetimeScope();




            //Bu C# kodu, Dependency Injection (Bağımlılık Enjeksiyonu) işlemi için kullanılan bir yapılandırmadır
            //ve genellikle Autofac gibi bir Inversion of Control (IoC) konteyneri kullanılarak gerçekleştirilir. Kodun amacı,
            //belirtilen assembly'deki tüm sınıfları tarayarak, onların uyguladıkları arayüzler ile birlikte IoC konteynerine kaydetmek
            //ve bu sınıflar için interceptor (kesici) tanımlamaktır.
            var assembly = System.Reflection.Assembly.GetExecutingAssembly();

            builder.RegisterAssemblyTypes(assembly).AsImplementedInterfaces()
                .EnableInterfaceInterceptors(new ProxyGenerationOptions()
                {
                    Selector = new AspectInterceptorSelector()
                }).SingleInstance();

        }
    }
}
