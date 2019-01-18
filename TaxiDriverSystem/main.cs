using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxiDriverSystem
{
    class main
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            View view = new View();
            Model model = new Model();
            Controller controller = new Controller(view,model);
            view.ActivateView(controller);
            view.ShowDialog();

            // depndency design pattern

        }
    }
}
