using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using MovieManagement.Application.Common.Interfaces;
using MovieManagement.Infrastructure.FileStore;

namespace MovieManagement.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddTransient<IFileStore, FileStore.FileStore>();
            services.AddTransient<IFileWrapper, FileWrapper>();
            services.AddTransient<IDirectoryWrapper, DirectoryWrapper>();
            return services;
        }
    }
}
