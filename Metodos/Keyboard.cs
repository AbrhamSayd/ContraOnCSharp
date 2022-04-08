using System.Windows.Forms;

namespace contraMapa.Metodos
{

    /// <summary>
    /// Teclas habilitadas en el juego
    /// </summary>
    public class Keyboard
    {
        #region Keys
        public bool Left { get; private set; }
        public bool Right { get; private set; }
        public bool Up { get; private set; }
        public bool Z { get; private set; }
        public bool HOLD { get; private set; }
        public bool X { get; private set; }
        public bool Down { get; private set; }

        public bool Jump { get; private set; }
        public bool Space { get; private set; }
        
        #endregion

        #region Methods
        public void SetKey(Keys key)
        {
           
            if (key == Keys.Left) this.Left = true;
            if (key == Keys.Right) this.Right = true;
            if (key == Keys.Down) this.Down = true;
            if (key == Keys.Up) this.Up = true;
            if (key == Keys.Z) { this.Z = true; Jump = true; this.HOLD = false; }
            if (key == Keys.X) this.X = true;

        }


        /// <summary>
        /// Limpia las teclas seleccionada
        /// </summary>
        public void Clear(Keys key)
        {
            if (key == Keys.Left) this.Left = false;
            if (key == Keys.Right) this.Right = false;
            if (key == Keys.Down) this.Down = false;
            if (key == Keys.Up) this.Up = false;
            if (key == Keys.Z & !HOLD)
            {
                this.Z = false;
                this.HOLD = true;
            }
            if (key == Keys.X) this.X = false;
            //Left = false;
            //Right = false;
            //Up = false;
            //Down = false;
            //Space = false;
            //X = false;
            //Z = false;
            //HOLD = true;
            //Jump = false;



        }
        #endregion
    }
}


