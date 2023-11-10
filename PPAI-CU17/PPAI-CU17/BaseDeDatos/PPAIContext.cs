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
    public class PPAIContext: DbContext
    {
           public DbSet<Validacion> Validaciones { get; set; }
           public DbSet<Llamada> LLamadas { get; set; }
           public DbSet<Opcion> Opciones { get; set; }
           public DbSet<SubOpcion> SubOpciones { get; set; }
           public DbSet<Cliente> Clientes { get; set; }
           public DbSet <CambiodeEstado> CambiodeEstados { get; set; }
           public DbSet<InformacionCliente> InformacionClientes { get; set; } 
           public DbSet<Categoria> Categorias { get; set; }
          

          protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
          {
            string connectionString = "Data Source=GREGO;Initial Catalog=PPAI;Integrated Security=True; TrustServerCertificate=True;Encrypt=False;";

            optionsBuilder.UseSqlServer(connectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.ApplyConfiguration(new ValidacionConfiguracion());
            modelBuilder.ApplyConfiguration(new LlamadaConfiguracion());
            modelBuilder.ApplyConfiguration(new ClienteConfiguracion());
            modelBuilder.ApplyConfiguration(new OpcionConfiguracion());
            modelBuilder.ApplyConfiguration(new SubOpcionConfiguracion());
            modelBuilder.ApplyConfiguration(new CategoriaConfiguracion());
            modelBuilder.ApplyConfiguration(new InformacionClienteConfiguracion());
            modelBuilder.ApplyConfiguration(new CambioDeEstadoConfiguracion());


        }
    }

        
    }

