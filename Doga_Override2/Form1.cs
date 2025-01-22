using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Doga_Override2
{
    public partial class Form1 : Form
        
    {
        public Form1()
        {
            InitializeComponent();
            start();
        }
        public void start()
        {
            
            eszkoz lapat = new eszkoz("Shovel", "Iron");
            this.Controls.Add(lapat);

            kalapacs hammer = new kalapacs("Fém", "Fa") { Top=lapat.Top+200};
            this.Controls.Add(hammer);

            csavarhuzo screwdriver = new csavarhuzo("Fém", "Muanyag") {Top=lapat.Top+300};
            this.Controls.Add(screwdriver);
            

        }
    }
}
