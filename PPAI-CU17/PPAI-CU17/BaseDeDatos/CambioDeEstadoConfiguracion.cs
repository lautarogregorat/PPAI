using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PPAI_CU17.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI_CU17.BaseDeDatos
{
    public class CambioDeEstadoConfiguracion : IEntityTypeConfiguration<CambiodeEstado>
    {
        public void Configure(EntityTypeBuilder<CambiodeEstado> builder)
        {
            builder.ToTable("CambiosDeEstados");
            builder.Property(c => c.fechaHoraInicio).HasColumnName("fecha_hora_inicio");
            builder.HasOne(c => c.llamada).WithMany(l => l.cambioDeEstado).HasForeignKey(c => c.idLlamada).IsRequired();
        }
    }
}
