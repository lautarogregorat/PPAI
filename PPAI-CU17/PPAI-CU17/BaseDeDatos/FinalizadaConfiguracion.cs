using Microsoft.EntityFrameworkCore;
using PPAI_CU17.Modelo;
using PPAI_CU17.Modelo.Estados.Estado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI_CU17.BaseDeDatos
{
    public class FinalizadaConfiguracion : IEntityTypeConfiguration<Finalizada>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Finalizada> builder)
        {
            builder.ToTable("Estado");
            builder.HasBaseType<Estado>();

            builder.HasData(
                new Finalizada
                {
                    idEstado = 3
                });

        }
    }
}