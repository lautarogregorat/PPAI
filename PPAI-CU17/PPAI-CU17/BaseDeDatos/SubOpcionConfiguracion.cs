using Microsoft.EntityFrameworkCore;
using PPAI_CU17.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI_CU17.BaseDeDatos
{
    public class SubOpcionConfiguracion : IEntityTypeConfiguration<SubOpcion>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<SubOpcion> builder)
        {
            builder.ToTable("SubOpciones");
            builder.Property(s => s.nombre).HasColumnName("nombre_subopcion");
            builder.Property(s => s.nroOrden).HasColumnName("nro_orden_subopcion");
            builder.HasOne(s => s.opcionPadre).WithMany(o => o.subOpciones).HasForeignKey(s => s.idOpcion).IsRequired();
            builder.HasMany(s => s.validaciones).WithOne(v => v.subOpcion).HasForeignKey(v => v.idSubOpcion).IsRequired(false);
            
        }
    }
}
