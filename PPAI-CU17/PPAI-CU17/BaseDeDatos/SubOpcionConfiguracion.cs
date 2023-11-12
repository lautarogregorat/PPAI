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
            builder.HasOne(s => s.opcionPadre).WithMany(o => o.subOpciones).HasForeignKey(s => s.idOpcion).IsRequired(false);
            builder.HasMany(s => s.validaciones).WithOne(v => v.subOpcion).HasForeignKey(v => v.idSubOpcion).IsRequired(false);

            builder.HasData(

                new SubOpcion
                {
                    idSubOpcion = 1,
                    nombre = "Si cuenta con los datos de la tarjeta marque 1",
                    nroOrden = 1,
                    idOpcion = 1
                },

                new SubOpcion
                {
                    idSubOpcion = 2,
                    nombre = "Si no cuenta con los datos de la tarjeta marque 2",
                    nroOrden = 2,
                    idOpcion = 1
                },
                new SubOpcion
                {
                    idSubOpcion = 3,
                    nombre = "Si desea registrar una respuesta de operador marque 1",
                    nroOrden = 3,
                    idOpcion = 1
                }
                );

        }
    }
}
