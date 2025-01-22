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
    public partial class Tool : UserControl
    {
        public string Type { get; set; }
        public string Material { get; set; }
        public Tool(string type, string material)
        {
            InitializeComponent();
            Type = type;
            Material = material;
            label1.Text = type;
        }
        public virtual void Tool_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Material, Type);
        }
    }
}
