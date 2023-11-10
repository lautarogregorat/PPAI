using Microsoft.Extensions.Hosting;
using PPAI_CU17.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using PPAI_CU17.BaseDeDatos;

namespace PPAI_CU17
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]

        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new VentanaLogin());
        }
    }
}