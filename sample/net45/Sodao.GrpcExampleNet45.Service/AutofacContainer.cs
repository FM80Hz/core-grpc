﻿using Autofac;
using Sodao.Core.Grpc.Intercept;
using Sodao.GrpcExampleNet45.Service.Tracer;

namespace Sodao.GrpcExampleNet45.Service
{
    public class AutofacContainer
    {
        public static IContainer Register()
        {
            var builder = new ContainerBuilder();
            var container = builder.Build(Autofac.Builder.ContainerBuildOptions.None);
            return container;
        }
    }
}
