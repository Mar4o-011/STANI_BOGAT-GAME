using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace STANI_BOGAT_GAME
{
    public partial class Game_over : Form
    {
        public Game_over()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            var f = new Nachalo();
            f.Show();
        }
    }
}
