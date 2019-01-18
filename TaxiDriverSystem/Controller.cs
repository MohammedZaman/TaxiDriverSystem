using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaxiDriverSystem
{
    public class Controller
    {
        private View view;
        private Model model;
        public Controller(View view , Model model)
        {
            this.view = view;
            this.model = model;
            view.SetController(this);// addding event handlers to buttons
           

        }

        public void MyClickEvent(object sender, EventArgs e)
        {
           

// events from the view
            if (sender == view.getBtn1()) {
                //MessageBox.Show("This click was on button:" + ((Button)sender).Text + view.getBtn1());
                GenericRepository<Breed> repos = new GenericRepository<Breed>();
                Breed dog = new Breed();
                dog.Breed1 = "dog";
                dog.BreedID = 56;
                dog.FoodCostPerKG = 45;
                dog.HousingCosts = 67;
                dog.SpeciesID = 6;
               
                repos.insert(dog);
                repos.save();
                

            }
            else if(sender == view.getBtn2())
            {
                MessageBox.Show("This click was on button:" + ((Button)sender).Text + view.getBtn2());
            }

            

        }




    }
}
