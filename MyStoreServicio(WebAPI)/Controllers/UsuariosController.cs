using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.UI;
using System.Web.Configuration;
using System.Web.Http;
using System.Web.Script.Services;
using EntitiesMyStore;

namespace MyStoreServicio_WebAPI_.Controllers
{
    public class UsuariosController : ApiController
    {
      
        // POST api/usuarios
       
        [HttpPost]
        public void createNewAccount([FromBody] Usuario usuario)
        {

           

            
            

        }

    }
}
