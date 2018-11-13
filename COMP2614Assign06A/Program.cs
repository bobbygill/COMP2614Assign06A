using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP2614Assign06A
{
    /// <summary>
    /// The purpose of this program is to query a table on a remote SQL Server, 
    /// then process and display the data in a Windows Form (DataGridView). 
    /// 
    /// </summary>

    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //testing the DB, can delete later
            //ClientCollection clients = ClientRepository.GetAllClients();
            //ConsolePrinter.PrintClientCollection(clients);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}
