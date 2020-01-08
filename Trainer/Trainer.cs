using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GTA;
using GTA.Native;
using GTA.Math;
using System.Windows.Forms;

namespace Trainer
{
    public class Trainer: Script
    {
        public Trainer()
        {
            Tick += onTick;
            KeyDown += onKeyDown;
            KeyUp += onKeyUp;

            renderUI();
        }

        // TODO: Create a UI Menu using the API
        private void renderUI()
        {

        }

        private void onTick(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void onKeyUp(object sender, KeyEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void onKeyDown(object sender, KeyEventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
