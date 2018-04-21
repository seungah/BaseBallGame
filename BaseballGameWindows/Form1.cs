using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaseballGameWindows
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void 새창NToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            BaseGame bg = new BaseGame();
            bg.MdiParent = this;//this = classForm1
            bg.Show(); //새창을 띄우는 것
        }

        private void 종료XToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close(); 
            //Application.Exit(); //완벽한 끝맺음이 되지 않음.
        }

        private void 계단식정렬ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade); //CasCade 계단 띵띵띵띵
        }

        private void 가로정렬ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);

        }

        private void 세로정렬ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical); 

        }
    }
}
