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
    public partial class въпрос_2 : Form
    {
        public въпрос_2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            var f = new Game_over();
            f.Show();
        }
        
        
        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            var f = new Game_over();
            f.Show();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            var f = new Game_over();
            f.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            var f = new въпрос_3();
            f.Show();
        }
    }
}
