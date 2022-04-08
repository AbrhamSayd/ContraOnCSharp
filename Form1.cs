using System;
using System.Threading;
using System.Windows.Forms;

namespace contraMapa
{
    public partial class Form1 : Form
    {
        bool arrivo = false;
        public Form1()
        {
            InitializeComponent();


        }


        private void timerMoveMenu_Tick(object sender, EventArgs e)
        {
            if (pbMenu.Left <= 2)
            {
                lblText.Visible = true;
                System.Media.SoundPlayer player = new System.Media.SoundPlayer(ResourceSprites._01_Title);
                player.Play();
                timerMoveMenu.Stop();
                arrivo = true;


            }
            else
            {
                pbMenu.Left -= 50;
            }
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter && arrivo)
            {
                Thread.Sleep(2000);
                SceneOne_1 frm = new SceneOne_1();
                frm.Show();
                
                this.Close();
            }
        }
    }
}
