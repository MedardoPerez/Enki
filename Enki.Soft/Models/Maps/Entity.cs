using System;

namespace ENKI.SOFT.Models.Maps
{
    public abstract class Entity
    {
        public string ModificadoPor { get; set; }
        public DateTime FechaTransaccion { get; set; }
        public string DescripcionTransaccion { get; set; }
        public string TransaccionUId { get; set; }
        public string TipoTransaccion { get; set; }
    }
}