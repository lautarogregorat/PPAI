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
    public class PPAIContext : DbContext
    {
        public DbSet<Validacion> Validaciones { get; set; }
        public DbSet<Llamada> Llamadas { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Opcion> Opciones { get; set; }
        public DbSet<SubOpcion> SubOpciones { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<InformacionCliente> InformacionClientes { get; set; }
        public DbSet<CambiodeEstado> CambiosDeEstado { get; set; }

        public DbSet<Estado> Estados { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connectionString = "Data Source=D:\\FEDE\\FACULTAD\\2023\\DSI\\PPAI_Entrega_3\\PPAI-CU17\\PPAI-CU17\\BaseDeDatos\\ppai.db";

            optionsBuilder.UseSqlite(connectionString);
        }

        // Solo cuando se crea la BD, se ejecuta OnModelCreating

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configuración del modelo creado
            modelBuilder.ApplyConfiguration(new ValidacionConfiguracion());
            modelBuilder.ApplyConfiguration(new LlamadaConfiguracion());
            modelBuilder.ApplyConfiguration(new ClienteConfiguracion());
            modelBuilder.ApplyConfiguration(new OpcionConfiguracion());
            modelBuilder.ApplyConfiguration(new SubOpcionConfiguracion());
            modelBuilder.ApplyConfiguration(new CategoriaConfiguracion());
            modelBuilder.ApplyConfiguration(new InformacionClienteConfiguracion());
            modelBuilder.ApplyConfiguration(new CambioDeEstadoConfiguracion());
            modelBuilder.ApplyConfiguration(new EstadoConfiguracion());
            modelBuilder.ApplyConfiguration(new IniciadaConfiguracion());
            modelBuilder.ApplyConfiguration(new CorrectaConfiguracion());
            modelBuilder.ApplyConfiguration(new CanceladaConfiguracion());
            modelBuilder.ApplyConfiguration(new FinalizadaConfiguracion());
            modelBuilder.ApplyConfiguration(new DescartadaConfiguracion());
            modelBuilder.ApplyConfiguration(new PendienteEscuchaConfiguracion());
            modelBuilder.ApplyConfiguration(new EnCursoConfiguracion());

        }
    }   
               
    }

