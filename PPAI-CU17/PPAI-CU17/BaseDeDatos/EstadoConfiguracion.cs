using Microsoft.EntityFrameworkCore;
using PPAI_CU17.Modelo.Estados.Estado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI_CU17.BaseDeDatos
{
    internal class EstadoConfiguracion : IEntityTypeConfiguration<Estado>

    {

        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Estado> builder)
        {

            builder.ToTable("Estado");
            builder.HasDiscriminator<string>("Nombre")
              .HasValue<Estado>("Estado")
              .HasValue<Finalizada>("Finalizada")
              .HasValue<EnCurso>("EnCurso")
              .HasValue<Cancelada>("Cancelada")
              .HasValue<Iniciada>("Iniciada")
              .HasValue<PendienteEscucha>("PendienteDeEscucha")
              .HasValue<Descartada>("Descartada")
              .HasValue<Correcta>("Correcta");

            
        }

    }
}