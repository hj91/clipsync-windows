﻿using Microsoft.AspNet.SignalR;
using Microsoft.Owin.Cors;
using Owin;

namespace ClipSync.SignalR {
    class Startup {
        public void Configuration(IAppBuilder app) {
            //app.UseCors(CorsOptions.AllowAll);
            //app.MapSignalR();

            app.Map("/signalr", map => {
                map.UseCors(CorsOptions.AllowAll);

                var hubConfiguration = new HubConfiguration {
                    EnableDetailedErrors = true,
                    EnableJSONP = true
                };

                map.RunSignalR(hubConfiguration);
            });
        }
    }
}
