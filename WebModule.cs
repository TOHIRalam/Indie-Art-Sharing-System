using Autofac;
using Autofac.Core;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;

namespace Indie_Art_Sharing_System
{
    public class WebModule : Module
    {
        private readonly string _connectionString;
        private readonly string _migrationAssemblyName;
        private readonly IConfiguration _configuration;
        private readonly IWebHostEnvironment _webHostEnvironment;

        public WebModule(string connectionStringName, string migrationAssemblyName,
            IConfiguration configuration,
            IWebHostEnvironment webHostEnvironment)
        {
            _connectionString = connectionStringName;
            _migrationAssemblyName = migrationAssemblyName;
            _configuration = configuration;
            _webHostEnvironment = webHostEnvironment;
        }

        protected override void Load(ContainerBuilder builder)
        {

            /*builder.RegisterType<TracksModel>().AsSelf();
            builder.RegisterType<CourseBatchModel>().AsSelf();
            builder.RegisterType<ReferralModel>().AsSelf();
            builder.RegisterType<CourseModel>().AsSelf();
            builder.RegisterType<DataTablesAjaxRequestModel>().As<IDataTablesAjaxRequestModel>()
                .InstancePerLifetimeScope();*/

            base.Load(builder);
        }
    }
}