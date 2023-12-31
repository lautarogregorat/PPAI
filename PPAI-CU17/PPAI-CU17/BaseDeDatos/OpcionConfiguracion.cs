﻿using Microsoft.EntityFrameworkCore;
using PPAI_CU17.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI_CU17.BaseDeDatos
{
    public class OpcionConfiguracion : IEntityTypeConfiguration<Opcion>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Opcion> builder)
        {
            builder.ToTable("Opciones");
            builder.Property(o => o.nombre).HasColumnName("nombre_opcion");
            builder.Property(o => o.mensajeOpcion).HasColumnName("mensaje_opcion");
            builder.Property(o => o.nroOrden).HasColumnName("nro_orden");
            builder.Property(o => o.audioMensajeSubopcion).HasColumnName("audio_mensaje_subopcion");
            builder.HasMany(o => o.llamadas).WithOne(l => l.opcionSeleccionada).HasForeignKey(l => l.idOpcion).IsRequired(false);
            builder.HasMany(o => o.subOpciones).WithOne(s => s.opcionPadre).HasForeignKey(o => o.idOpcion).IsRequired(false);
            builder.HasMany(o => o.validacionRequerida).WithOne(v => v.opcion).HasForeignKey(v => v.idOpcion).IsRequired(false);
            builder.HasOne(o => o.categoria).WithMany(c => c.opciones).HasForeignKey(o => o.idCategoria).IsRequired(false);

            builder.HasData(
                new Opcion
                {
                    idOpcion = 1,
                    nombre = "Solicitar nueva tarjeta",
                    mensajeOpcion = "Si desea informar un robo y solicitar una nueva tarjeta marque 1",
                    nroOrden = 1,
                    audioMensajeSubopcion = "Si cuenta con los datos de la tarjeta marque 1\nSi no cuenta con los datos de la tarjeta marque 2\nSi desea comunicarse con un responsable de atencion al cliente marque 3\n Si desea finalizar la llamada marque 4 ",
                    idCategoria = 1
                });

        }
    }
}
