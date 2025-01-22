using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2025_01_22
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Controls.Add(new Tool("lapát", "fém"));
            Controls.Add(new Hammer("kalapács", "fém", "fa") { Top = 50 });
            Controls.Add(new Screwdriver("csavarhúzó", "fém", "csillag") { Top = 100 });
        }
    }
}
