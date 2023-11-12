using Microsoft.EntityFrameworkCore;
using PPAI_CU17.Modelo.Estados.Estado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI_CU17.BaseDeDatos
{
    internal class PendienteEscuchaConfiguracion : IEntityTypeConfiguration<PendienteEscucha>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<PendienteEscucha> builder)
        {
            builder.ToTable("Estado");
            builder.HasBaseType<Estado>();

            builder.HasData(
                new PendienteEscucha
                {
                    idEstado = 5
                });

        }
    }
}
