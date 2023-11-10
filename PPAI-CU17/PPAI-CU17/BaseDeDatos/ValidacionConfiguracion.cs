using Microsoft.EntityFrameworkCore;
using PPAI_CU17.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI_CU17.BaseDeDatos
{
    public class ValidacionConfiguracion : IEntityTypeConfiguration<Validacion>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Validacion> builder)
        {
            builder.ToTable("Validaciones");
            builder.Property(v => v.audioMensajeValidacion).HasColumnName("audio_mensaje_validacion");
            builder.Property(v => v.nombre).HasColumnName("nombre_validacion");
            builder.HasOne(v => v.opcion).WithMany(o => o.validacionRequerida).HasForeignKey(v => v.idOpcion).IsRequired();
            builder.HasOne(v => v.subOpcion).WithMany( v => v.validaciones).HasForeignKey(v => v.idSubOpcion).IsRequired(false);
        }
    }
}
