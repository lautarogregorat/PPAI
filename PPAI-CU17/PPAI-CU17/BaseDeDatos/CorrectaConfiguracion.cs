using Microsoft.EntityFrameworkCore;
using PPAI_CU17.Modelo.Estados.Estado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI_CU17.BaseDeDatos
{
    internal class CorrectaConfiguracion : IEntityTypeConfiguration<Correcta>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Correcta> builder)
        {
            builder.ToTable("Estado");
            builder.HasBaseType<Estado>();

            builder.HasData(
                new Correcta
                {
                    idEstado = 7
                });

        }
    }
}
