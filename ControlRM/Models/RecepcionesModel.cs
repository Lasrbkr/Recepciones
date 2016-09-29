#region Referencias
using System;
using System.Collections.Generic;
#endregion
namespace ControlRM
{
    public class RecepcionesList
    {
        public List<RecepcionesModel> results { get; set; }
    }
    public class RecepcionesModel
    {
        public string objectId { get; set; }
        public string createdAt { get; set; }
        public string updatedAt { get; set; }
        public string Nombre { get; set; }
        public Fecha Fecha { get; set; }
        public string Animal { get; set; }
        public string Concepto { get; set; }
        public double Kilos { get; set; }
        public string Vale { get; set; }
        public string Chofer { get; set; }
        public double KilosEntrada { get; set; }
        public double KilosSalida { get; set; }
        public int Consecutivo { get; set; }
        public double APagar { get; set; }
        public string Observaciones { get; set; }
        public bool Sirve { get; set; }
    }
    public class Fecha
    {
        public string __type { get; set; }
        public DateTime iso { get; set; }
    }
}
