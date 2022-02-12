﻿using System.Web.Http;
using System.Web.Http.Dispatcher;
using Castle.Windsor;
using UOM.Config.Castle;

namespace ServiceHost
{
    public static class HostConfigurator
    {
        public static void Config()
        {
            var container = new WindsorContainer();
            UomBootstrapper.Config(container);

            var castleActivator = new CastleControllerActivator(container);
            GlobalConfiguration.Configuration
                .Services.Replace(typeof(IHttpControllerActivator), castleActivator);
        }
    }
}