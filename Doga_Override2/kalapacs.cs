using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Doga_Override2
{
    class kalapacs:eszkoz
    {
        public string hammerhmat { get; set; }
        public kalapacs(string tot,string mati):base(tot,mati)
        {
        }
        public override void clickclass(Object e ,EventArgs s)
        {
            this.Click += (ss, ee) =>
            {
                MessageBox.Show(mati,hammerhmat);
            };
        }

    }
}
