using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntitiesMyStore;
using MyStoreEntityModel;
using System.Net;
using System.Net.Http;
using System.Security.Cryptography;
using System.Web;
using System.Web.UI;
using System.Web.Configuration;
using System.Web.Http;
using HerramientasMyStore;

namespace DAL
{
    public class UsuarioDALL
    {
        Herramientas herramientas = new Herramientas();
       public HttpResponseMessage createNewAccount( UsuarioData usuario)
        {

            HttpRequestMessage request = new HttpRequestMessage();
            var statuscode= request.CreateResponse(HttpStatusCode.NotModified); ;
            using (MyStoreDbEntities entitiesModel = new MyStoreDbEntities())
            {
                using (var transaction = entitiesModel.Database.BeginTransaction())
                {
                    try
                    {
                        var newUser = new Usuario
                        {
                            firstName = usuario.firstName,
                            lastName = usuario.lastName,
                            email = usuario.email,
                            password = herramientas.GetMd5Hash(usuario.password)
                        };

                        entitiesModel.Usuario.Add(newUser);
                        entitiesModel.SaveChanges();

                        statuscode= request.CreateResponse(HttpStatusCode.Created);
                    }
                    catch (Exception)
                    {
                        transaction.Rollback();


                    }
                }
  
            }

            return statuscode;
        }
    }
}
