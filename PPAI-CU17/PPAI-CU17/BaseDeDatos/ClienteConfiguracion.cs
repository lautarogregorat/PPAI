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
            builder.Property(c => c.nombreCompleto).HasColumnName("nombreCompleto");
            builder.Property(c => c.nroCelular).HasColumnName("nro_celular");
            builder.HasMany(c => c.llamadas).WithOne(l => l.cliente).HasForeignKey(l => l.idCliente).IsRequired(false);
            builder.HasMany(i => i.info).WithOne(c => c.cliente).HasForeignKey(c => c.idCliente).IsRequired(false);

            builder.HasData(
                new Cliente
                {
                    idCliente = 1,
                    nombreCompleto = "Juan ROMAN 10",
                    dni = "12345678",
                    nroCelular = "12345678"
                });

        }
    }
}
