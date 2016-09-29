#region Referencias
using System;
using System.Net.Http;
using System.Net.Http.Headers;
#endregion
namespace ControlRM
{
    public class DatosConexion
    {
        #region Variables
        public static string rutaAPI = "https://parseapi.back4app.com/";
        public static string ApplicationId = "dce95rirzjF9buTD4HhYV8Qf1obb2IzByKABuaim";
        public static string APIKey = "i8wvKeDFXSZbVCXwAgOsmvckToYi9sTq95mc9YyF";
        #endregion
        #region Metodos
        public static HttpClient conexion()
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(rutaAPI);
            client.DefaultRequestHeaders.Add("X-Parse-Application-Id", ApplicationId);
            client.DefaultRequestHeaders.Add("X-Parse-REST-API-Key", APIKey);
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            return client;
        }
        #endregion
    }
}
