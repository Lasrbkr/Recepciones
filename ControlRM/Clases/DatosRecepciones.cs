#region Referencias
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
#endregion
namespace ControlRM
{
    public class DatosRecepciones
    {
        #region Metodos
        public Task<bool> SP_InsertarRecepciones(RecepcionesModel recepcion)
        {
            return Task.Run(async () =>
             {
                 try
                 {
                     bool resultado = false;
                     using (var client = DatosConexion.conexion())
                     {
                         HttpResponseMessage response = await client.PostAsync(DatosConexion.rutaAPI + "classes/Recepciones", new StringContent(JsonConvert.SerializeObject(recepcion), Encoding.UTF8, "application/json"));
                         if (response.IsSuccessStatusCode)
                         {
                             recepcion.objectId = response.Headers.Location.Segments[response.Headers.Location.Segments.Length - 1];
                             resultado = true;
                         }
                         else
                             resultado = false;
                     }
                     return resultado;
                 }
                 catch (Exception ex)
                 {
                     Debug.WriteLine(ex.Message);
                     return false;
                }
            });
        }
        public Task<List<RecepcionesModel>> SP_CargarListaRecepciones()
        {
            return Task.Run(async () =>
            {
                List<RecepcionesModel> lista = new List<RecepcionesModel>();
                try
                {
                    using (var client = DatosConexion.conexion())
                    {
                        HttpResponseMessage response = await client.GetAsync("classes/Recepciones");
                        if (response.IsSuccessStatusCode)
                        {
                            var content = await response.Content.ReadAsStringAsync();
                            var obj = JsonConvert.DeserializeObject<RecepcionesList>(content);
                            lista = obj.results;
                        }
                    }
                    return lista == null ? new List<RecepcionesModel>() : lista;
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex.Message);
                    return lista == null ? new List<RecepcionesModel>() : lista;
                }
            });
        }
        #endregion
    }
}