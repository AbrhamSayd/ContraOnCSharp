using contraMapa.Metodos;
using System;
using System.Windows.Forms;

namespace contraMapa
{
    public partial class SceneOne_1 : Form
    {

        int items = 0;
        bool debug = false;
        public bool pRight, pLeft, jumping, pDown, downing, Z, X;
        public int playerSpeed = 2;
        public int force = 8;
        public int backgroundSpeed = 5;
        int jump_speed = 1;
        public int i = 0;
        public int des = 5;
        public int e01X, e01Y;
        public int lives = 3;

        public SceneOne_1()
        {
            InitializeComponent();
            HideElements("Ground");
            //Audio();
            //e01X = 896;
            //e01Y = 208;
            //rainMeteors();
            relocateFire();
            Audio();

        }

        
        private void points_Tick(object sender, EventArgs e)
        {
            double total = Convert.ToDouble(llbP.Text);
            total = total + 1;
            llbP.Text = total.ToString();

        }

        private void SceneOne_1_Load(object sender, EventArgs e)
        {
            
        }


        #region Properties
        /// <summary>
        /// Informacion de teclas precionadas
        /// </summary>
        protected Keyboard Keyboard { get; set; }
        #endregion
        #region Methods
        //colisiones

        /// <summary>
        /// Oculta los elementos llamados
        /// </summary>
        /// ///<param name="index">
        ///Se indica que el tipo de tag para evaluar
        ///</param>


        private void relocateFire()
        {
            Random rnd = new Random();
            foreach (Control item in this.Controls)
            {
                if (item is PictureBox && (string)item.Tag == "Item")
                {
                    item.Location = new System.Drawing.Point(rnd.Next(900, 8000), rnd.Next(398, 600));
                    foreach (Control itemPa in this.Controls)
                    {
                        if (itemPa is PictureBox && (string)itemPa.Tag == "Item")
                        {
                            if (item.Bounds.IntersectsWith(itemPa.Bounds))
                            {

                                itemPa.Location = new System.Drawing.Point(rnd.Next(900 + item.Width, 8000), rnd.Next(398 + item.Height, 600));
                            }
                        }

                    }

                }
            }
        }

        private void Audio()
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(ResourceSprites.Stage1);
            player.PlayLooping();
            //Crashea el sistema

        }
        //private void EnemiesMovement()
        //{
        //    int x = pbEnemie01.Location.X;
        //    int y = pbEnemie01.Location.Y;

        //    //#1
        //    e01X = e01X + des;
        //    if (e01X <= 640)
        //    {
        //        des = +5;
        //    }
        //    if (e01X >= 900)
        //    {
        //        des = -5;
        //    }
        //    pbEnemie01.Location = new System.Drawing.Point(e01X,e01Y);
        //}
        //private void rainMeteors() {
        //Random random = new Random();
        //    for (int i = 0; i < 70; i++)
        //    {

        //        PictureBox pictureBox = new PictureBox();
        //        pictureBox.Image = ResourceSprites.Fire;
        //        pictureBox.Location = new System.Drawing.Point(random.Next(0, pbpBackGround.Width), 0);
        //    }

        //}
        private void HideFire()
        {

            foreach (Control item in this.Controls)
            {
                if (item is PictureBox && (string)item.Tag == "Item")
                {
                    i++;
                    llbP.Text = i.ToString();

                    if (item.Location.X > 0 && item.Location.X < 980 && items != 10)
                    {
                        items++;
                        item.Visible = true;
                    }
                    else
                    {
                        item.Visible = false;
                        items = 0;
                    }
                }
            }
        }

        private void HideElements(string index)
        {
            foreach (Control item in this.Controls)
            {
                if (item is PictureBox && (string)item.Tag == index)
                {
                    if (debug)
                    {
                        item.BackColor = System.Drawing.Color.Black;
                        item.BackgroundImage = null;
                        item.Visible = true;
                    }
                    item.Size = new System.Drawing.Size(item.Size.Width, 12);
                    item.Visible = false;
                }
            }
        }
        /// <summary>
        /// Mueve los elementos
        /// </summary>
        ///<param name="direction">
        ///Se indica la direccion back or forward
        ///</param>
        private void MoveGameElements(string direction)
        {
            foreach (Control item in this.Controls)
            {
                if (item is PictureBox && (string)item.Tag == "Ground" || item is PictureBox && (string)item.Tag == "Enemie" || item is PictureBox && (string)item.Tag == "Item")
                {

                    if (direction == "back")//dibujamos los items hacia atras
                    {
                        item.Left -= backgroundSpeed;
                    }
                    if (direction == "forward")//dibujamos los items hacia adelante
                    {
                        item.Left += backgroundSpeed;

                    }


                }
            }
        }

        #endregion Methods
        #region Events
        private void SceneOne_1_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Left) pLeft = true;
            if (e.KeyCode == Keys.Right) pRight = true;
            if (e.KeyCode == Keys.Down) pDown = true;
            if (e.KeyCode == Keys.Z && jumping == false) jumping = true;
            if (e.KeyCode == Keys.X && pDown == true) downing = true;




        }

        private void SceneOne_1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left) pLeft = false;
            if (e.KeyCode == Keys.Right) pRight = false;
            if (e.KeyCode == Keys.Down) pDown = false;
            if (downing) downing = false;
            if (jumping) jumping = false;



        }

        private void TimerMovement_Tick(object sender, EventArgs e)
        {
            HideFire();
            if (lives > 0)
            {
                if (lives == 3) { life01.Visible = true; life02.Visible = true; life03.Visible = true; }
                if (lives == 2) { life01.Visible = true; life02.Visible = true; life03.Visible = false; }
                if (lives == 1) { life01.Visible = true; life02.Visible = false; life03.Visible = false; }

                //EnemiesMovement();
                pbPlayer.Top += jump_speed;

                if (pLeft == true && pbPlayer.Left > 20)
                {
                    pbPlayer.Left -= playerSpeed;
                }
                if (pRight == true && pbPlayer.Left + (pbPlayer.Width + 130) < this.ClientSize.Width)
                {
                    pbPlayer.Left += playerSpeed;
                }


                if (pLeft == true && pbpBackGround.Left < 0)
                {
                    pbpBackGround.Left += backgroundSpeed;
                    MoveGameElements("forward");
                }

                if (pRight == true && pbpBackGround.Left > -7339)
                {
                    pbpBackGround.Left -= backgroundSpeed;
                    MoveGameElements("back");
                }

                if (jumping == true)
                {
                    jump_speed = -12;
                    force -= 1;
                }
                else
                {
                    jump_speed = 12;
                }
                if (downing == true)
                {
                    pbPlayer.Top += 80;
                    downing = false;
                }

                if (jumping == true && force < 0)
                {
                    jumping = false;
                }

                foreach (Control x in this.Controls)
                {

                    if (x is PictureBox && (string)x.Tag == "Ground")
                    {

                        if (pbPlayer.Bounds.IntersectsWith(x.Bounds) && jumping == false)
                        {
                            force = 8;
                            pbPlayer.Top = x.Top - pbPlayer.Height - 5;
                            jump_speed = 0;
                        }


                        x.BringToFront();

                    }
                    if (x is PictureBox && (string)x.Tag == "Item" && x.Visible == true)
                    {
                        if (pbPlayer.Bounds.IntersectsWith(x.Bounds))
                        {
                            x.Visible = false;

                            lives--;
                            break;
                        }

                    }



                }
            }
            else
            {
                TimerMovement.Stop();
                MessageBox.Show("Game Over");
                Application.Exit();

            }

        }
        #endregion Events
    }
}
