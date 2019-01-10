using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace MyStoreServicio_WebAPI_
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Configuración y servicios de API web

            // Rutas de API web
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
            /// Correccion para los servicios Web API que serializan EF Entities con referencias circulares
            /// Enlace del recurso (http://code.msdn.microsoft.com/Loop-Reference-handling-in-caaffaf7)
            config.Formatters.JsonFormatter.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore;
        }
    }
}
