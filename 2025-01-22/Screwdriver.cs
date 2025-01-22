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
    public partial class Screwdriver : Tool
    {
        public string Head { get; set; }
        public Screwdriver(string type, string material, string head) : base(type, material)
        {
            InitializeComponent();
            Head = head;
        }
        public override void Tool_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"{Type} anyaga {Material}, feje {Head}.", Type);
        }
    }
}
