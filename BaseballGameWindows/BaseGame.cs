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
    public partial class BaseGame : Form
    {
        private BaseballGameEngine bge;
        public BaseGame()
        {
            InitializeComponent();
            bge = new BaseballGameEngine();
            bge.init();
            MessageBox.Show(bge.GetQuiz());
        }

        private void bInput_Click(object sender, EventArgs e)
        {
            //tNumber 1,2,3에 있는 값을 가져와서
            //String으로 판별하고
            try
            {
                int a = int.Parse(tNumber1.Text);
            }
            catch
            {
                MessageBox.Show("첫번째 숫자 이상");
                tNumber1.Text = "";
                return;
            }
            try
            {
                int a = int.Parse(tNumber2.Text);
            }
            catch
            {
                MessageBox.Show("두번째 숫자 이상");
                tNumber2.Text = "";
                return;
            }
            try
            {
                int a = int.Parse(tNumber3.Text);
            }
            catch
            {
                MessageBox.Show("세번째 숫자 이상");
                tNumber3.Text = "";
                return;
            }
            String input = tNumber1.Text + tNumber2.Text + tNumber3.Text;
            //BaseballGameEngine에 주자
            //게임엔진에 strike, ball을 판정하자
            bge.Play(input);
            statusLabel.Text = String.Format("Strike : {0}, Ball : {1}", bge.Getstrike(), bge.Getball());
            statusLabel.Text = String.Format(input);

            if (bge.Getstrike() == bge.GetQuizLength())
            {
                MessageBox.Show("정답");
                Clear();
                bge.init(); //다시 퀴즈냄.
            }

        }

        private void bClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void Clear()
        {
            tNumber1.Text = "";
            tNumber2.Text = "";
            tNumber3.Text = "";
            statusLabel.Text = "BaseBall!!";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
