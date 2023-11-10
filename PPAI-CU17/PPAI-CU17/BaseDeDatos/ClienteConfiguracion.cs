using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PPAI_CU17.Modelo;

namespace PPAI_CU17.BaseDeDatos
{
    internal class ClienteConfiguracion : IEntityTypeConfiguration<Cliente>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Cliente> builder)
        {
            builder.ToTable("Clientes");
            builder.Property(c => c.dni).HasColumnName("dni");
            builder.Property(c => c.nroCelular).HasColumnName("nro_celular");
            builder.HasMany(c => c.llamadas).WithOne(l => l.cliente).HasForeignKey(l => l.idCliente).IsRequired();
            builder.HasMany(i => i.info).WithOne(c => c.cliente).HasForeignKey(c => c.idCliente).IsRequired();
        }
    }
}
