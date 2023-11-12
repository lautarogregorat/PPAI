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
            builder.HasOne(v => v.opcion).WithMany(o => o.validacionRequerida).HasForeignKey(v => v.idOpcion).IsRequired(false);
            builder.HasOne(v => v.subOpcion).WithMany(v => v.validaciones).HasForeignKey(v => v.idSubOpcion).IsRequired(false);
            builder.HasMany(v => v.informacionClientes).WithOne(i => i.validacion).HasForeignKey(i => i.idValidacion).IsRequired(false);

            builder.HasData(
                new Validacion
                {
                    idValidacion = 1,
                    audioMensajeValidacion = "Ingrese la cantidad de hijos: ",
                    nombre = "Cantidad de hijos",
                    idOpcion = 1,
                    idSubOpcion = 1
                },
                new Validacion
                {
                    idValidacion = 2,
                    audioMensajeValidacion = "Ingrese su fecha de nacimiento dd/mm/aaaa",
                    nombre = "Fecha Nacimiento",
                    idOpcion = 1,
                    idSubOpcion = 1
                },
            new Validacion
            {
                idValidacion = 3,
                audioMensajeValidacion = "Ingrese su codigo postal: ",
                nombre = "Codigo postal",
                idOpcion = 1,
                idSubOpcion = 1
            }
                );

        }
    }
}
