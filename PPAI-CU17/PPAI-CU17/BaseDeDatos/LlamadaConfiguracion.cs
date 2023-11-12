using PPAI_CU17.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PPAI_CU17.Modelo.Estados.Estado;

namespace PPAI_CU17.BaseDeDatos
{
    public class LlamadaConfiguracion : IEntityTypeConfiguration<Llamada>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Llamada> builder)
        {
            builder.ToTable("Llamadas");
            builder.Property(l => l.descripcionOperador).HasColumnName("descripcion_operador");
            builder.Property(l => l.detalleAccionRequerida).HasColumnName("detalle_accion_requerida");
            builder.Property(l => l.duracion).HasColumnName("duracion");
            builder.Property(l => l.encuestaEnviada).HasColumnName("encuesta_enviada");
            builder.Property(l => l.observacionAuditor).HasColumnName("observacion_auditor");
            builder.HasOne(l => l.cliente).WithMany(e => e.llamadas).HasForeignKey(e => e.idCliente).IsRequired();
            builder.HasOne(l => l.opcionSeleccionada).WithMany(l => l.llamadas).HasForeignKey(l => l.idOpcion).IsRequired(false);
            builder.HasOne(l => l.subopcionSeleccionada).WithMany(l => l.llamadas).HasForeignKey(l => l.idSubOpcion).IsRequired(false);
            builder.HasMany(l => l.cambioDeEstado).WithOne(c => c.llamada).HasForeignKey(c => c.idLlamada).IsRequired(false);


            builder.HasData(
            new Llamada
            {
                idLlamada = 1,
                descripcionOperador = "",
                detalleAccionRequerida = "",
                duracion = new TimeSpan(0, 0, 0, 0),
                encuestaEnviada = false,
                observacionAuditor = "",
                idCliente = 1,
                idOpcion = 1,
                idSubOpcion = 1
            });

        }
    }
}
