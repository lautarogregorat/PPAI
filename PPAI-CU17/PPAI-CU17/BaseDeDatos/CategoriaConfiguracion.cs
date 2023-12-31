﻿using Microsoft.EntityFrameworkCore;
using PPAI_CU17.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI_CU17.BaseDeDatos
{
    public class CategoriaConfiguracion : IEntityTypeConfiguration<Categoria>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Categoria> builder)
        {
            builder.ToTable("Categorias");
            builder.Property(c => c.nombre).HasColumnName("nombre_categoria");
            builder.Property(c => c.audioMensajeOpciones).HasColumnName("audio_mensaje_opciones");
            builder.Property(c => c.mensajeOpciones).HasColumnName("mensajesOpciones");
            builder.Property(c => c.nroOrden).HasColumnName("nro_orden_categoria");
            builder.HasMany(c => c.opciones).WithOne(o => o.categoria).HasForeignKey(o => o.idCategoria).IsRequired(false);

            builder.HasData(
              new Categoria
              {
                  idCategoria = 1,
                  nombre = "Informar Robo",
                  audioMensajeOpciones = "Si desea informar un robo y solicitar una nueva tarjeta marque 1\n Si desea informar un robo y anular su tarjeta marque 2\n Si desea finalizar la llamada marque 3",
                  mensajeOpciones = "Si quiere informar un robo marque 1",
                  nroOrden = 1
              });

        }
    }
}
