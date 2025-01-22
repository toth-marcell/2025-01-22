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
    public partial class Hammer : Tool
    {
        public string HandleMaterial { get; set; }
        public Hammer(string type, string material, string handleMaterial) : base(type, material)
        {
            InitializeComponent();
            HandleMaterial = handleMaterial;
        }
        public override void Tool_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"{Material}, {HandleMaterial}", Type);
        }
    }
}
