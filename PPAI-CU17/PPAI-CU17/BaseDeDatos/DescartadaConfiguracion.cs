using Microsoft.EntityFrameworkCore;
using PPAI_CU17.Modelo.Estados.Estado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI_CU17.BaseDeDatos
{
    internal class DescartadaConfiguracion : IEntityTypeConfiguration<Descartada>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Descartada> builder)
        {
            builder.ToTable("Estado");
            builder.HasBaseType<Estado>();
            builder.HasData(
                new Descartada
                {
                    idEstado = 6
                });

        }
    }
}
