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
        }

        private void onKeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.NumPad0)
            {
                Vehicle vehicle = World.CreateVehicle(VehicleHash.Rhino, Game.Player.Character.Position + Game.Player.Character.ForwardVector * 3.0f, Game.Player.Character.Heading + 90);
                vehicle.PlaceOnGround();
            }
            else if (e.KeyCode == Keys.NumPad1)
            {
                Vehicle vehicle = World.CreateVehicle(VehicleHash.Apc, Game.Player.Character.Position + Game.Player.Character.ForwardVector * 3.0f, Game.Player.Character.Heading + 90);
            }

        }

        private void onKeyDown(object sender, KeyEventArgs e)
        {
        }
    }
}
