using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Doga_Override2
{
    class eszkoz : UserControl
    {
        private Label label2;
        public Label label1;

        public string tot { get; set; }
        public string mati { get; set; }
        

        public eszkoz(string type,string matii)
        {
            this.BackColor = Color.Blue;
            tot = type;
            mati = matii;
            InitializeComponent();
            this.Click += clickclass;
            label1.Text = type;


        }
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "label2";
            label2.BackColor = Color.Red;
            // 
            // eszkoz
            // 
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "eszkoz";
            this.Size = new System.Drawing.Size(50, 50);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        public virtual void clickclass(Object s,EventArgs e)
        {
            
            this.Click += (ss, ee) =>
            {
                MessageBox.Show($"Anyaga: {mati}");
                
            };
        }
    }
}
