using System;
using System.Windows.Forms;
using GTA;

namespace clothInfoGen
{
    public class Main : Script
    {
        public Main()
        {
            this.Tick += this.OnTick;
            this.KeyUp += this.OnKeyUp;
        }

        private void OnTick(object sender, EventArgs e)
        {
            Game.Player.WantedLevel = 0;
        }

        private void OnKeyUp(object sender, KeyEventArgs e)
        {

        }
    }
}