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

        }

    }
}
