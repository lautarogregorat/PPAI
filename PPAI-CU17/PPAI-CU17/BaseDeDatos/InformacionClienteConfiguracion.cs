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
    internal class InformacionClienteConfiguracion : IEntityTypeConfiguration<InformacionCliente>
    {
        public void Configure(EntityTypeBuilder<InformacionCliente> builder)
        {
            builder.ToTable("InformacionClientes");
            builder.Property(c => c.datoAValidar).HasColumnName("dato_a_validar");
            builder.HasOne( c => c.cliente).WithMany( c => c.info).HasForeignKey( c => c.idCliente).IsRequired();
            builder.HasOne(c => c.validacion).WithMany(c => c.informacionClientes).HasForeignKey(c => c.idValidacion).IsRequired(false);

            builder.HasData(
                new InformacionCliente
                {
                    idInformacionCliente = 1,
                    datoAValidar = "3",
                    idCliente = 1,
                    idValidacion = 1
                },
                new InformacionCliente
                {
                    idInformacionCliente = 2,
                    datoAValidar = "12/10/12",
                    idCliente = 1,
                    idValidacion = 2
                },
                new InformacionCliente
                {
                    idInformacionCliente = 3,
                    datoAValidar = "5200",
                    idCliente = 1,
                    idValidacion = 3
                }
                );

        }

    }
}
