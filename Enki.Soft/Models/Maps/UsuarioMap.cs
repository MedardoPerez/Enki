using ENKI.SOFT.Models.Entidades;
using ENKI.SOFT.Models.Infraestructura.core;

namespace ENKI.SOFT.Models.Maps
{
    internal class UsuarioMap : EntityConfiguration<Usuario>
    {
        public UsuarioMap()
        {
            ToTable("Usuario");
            HasKey(r => r.UsuarioId);
            Property(r => r.UsuarioId).HasColumnName("UsuarioId");
            Property(r => r.Contrasena).HasColumnName("Contrasena");
            Property(r => r.Nombre).HasColumnName("Nombre").IsRequired().IsUnicode(false).HasMaxLength(50);
            // Property(t => t.FechaTransaccion).HasColumnName("FechaTransaccion");
            // Property(t => t.DescripcionTransaccion).HasColumnName("DescripcionTransaccion").IsRequired().IsUnicode(false).HasMaxLength(50);
            // Property(t => t.ModificadoPor).HasColumnName("ModificadoPor").IsRequired().IsUnicode(false).HasMaxLength(20);
            // Property(t => t.TipoTransaccion).HasColumnName("TipoTransaccion").IsRequired().IsUnicode(false).HasMaxLength(50);
            // Property(t => t.TransaccionUId).HasColumnName("TransaccionUId");
        }
    }
}