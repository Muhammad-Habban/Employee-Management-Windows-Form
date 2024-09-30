using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Extensions.DependencyInjection;
using EmployeeManagementBLL;

namespace EmployeeManagementApplication
{
    internal static class Program
    {
        public static ServiceProvider serviceProvider;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            
            var services = new ServiceCollection();
            services.AddSingleton<EmployeeManagementBLL.IEmployeeManagementBLL, EmployeeManagementBLL.EmployeeManagementBLL>();
            serviceProvider = services.BuildServiceProvider();
            Application.Run(new Form1());
        }
    }
}
