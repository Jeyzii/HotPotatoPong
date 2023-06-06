using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotPotatoPong
{
    public partial class ContinueStop1p : Form
    {
        public ContinueStop1p()
        {
            InitializeComponent();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 go = new Form1();
            go.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
            elmo go = new elmo();
            go.Show();
        }
    }
}
