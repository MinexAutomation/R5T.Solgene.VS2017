﻿using System;

using Microsoft.Extensions.DependencyInjection;

using R5T.Dacia;


namespace R5T.Solgene.VS2017
{
    public static class IServiceCollectionExtensions
    {
        /// <summary>
        /// Adds the <see cref="VisualStudio2017SolutionFileGenerator"/> implementation of <see cref="IVisualStudioSolutionFileGenerator"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceCollection AddVisualStudio2017SolutionFileGenerator(this IServiceCollection services)
        {
            services.AddSingleton<IVisualStudio2017SolutionFileGenerator, VisualStudio2017SolutionFileGenerator>();

            return services;
        }

        /// <summary>
        /// Adds the <see cref="VisualStudio2017SolutionFileGenerator"/> implementation of <see cref="IVisualStudioSolutionFileGenerator"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static ServiceAction<IVisualStudio2017SolutionFileGenerator> AddVisualStudio2017SolutionFileGeneratorAction(this IServiceCollection services)
        {
            var serviceAction = new ServiceAction<IVisualStudio2017SolutionFileGenerator>(() => services.AddVisualStudio2017SolutionFileGenerator());
            return serviceAction;
        }

        /// <summary>
        /// Adds the <see cref="VisualStudioSolutionFileGenerator"/> implementation of <see cref="IVisualStudioSolutionFileGenerator"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceCollection AddVisualStudioSolutionFileGenerator(this IServiceCollection services,
            ServiceAction<IVisualStudio2017SolutionFileGenerator> addVisualStudio2017SolutionFileGenerator)
        {
            services
                .AddSingleton<IVisualStudioSolutionFileGenerator, VisualStudioSolutionFileGenerator>()
                .RunServiceAction(addVisualStudio2017SolutionFileGenerator)
                ;

            return services;
        }

        /// <summary>
        /// Adds the <see cref="VisualStudioSolutionFileGenerator"/> implementation of <see cref="IVisualStudioSolutionFileGenerator"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static ServiceAction<IVisualStudioSolutionFileGenerator> AddVisualStudioSolutionFileGeneratorAction(this IServiceCollection services,
            ServiceAction<IVisualStudio2017SolutionFileGenerator> addVisualStudio2017SolutionFileGenerator)
        {
            var serviceAction = new ServiceAction<IVisualStudioSolutionFileGenerator>(() => services.AddVisualStudioSolutionFileGenerator(addVisualStudio2017SolutionFileGenerator));
            return serviceAction;
        }
    }
}
