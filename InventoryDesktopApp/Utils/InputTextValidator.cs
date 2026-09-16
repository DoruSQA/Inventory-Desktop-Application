using Microsoft.VisualBasic.Devices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace InventoryDesktopApp.Utils
{
    public static class InputTextValidator
    {
    
        public static bool CheckPassword(string pass, Label label)
        {
            PasswordValidator password= new PasswordValidator(pass);
            if (!password.iscorrect) 
            {
                SystemSounds.Beep.Play();
                label.Visible= true;
                if (!password.hasDigits) { label.Text = "Your password should have at least one digit"; }
                if (!password.hasSymbols) { label.Text= "Your password should have at least one symbol"; }
                if (!password.isLong) { label.Text = "Your password should be at least 6 characters long"; }
                return false;
            }
            else
            {
                label.Visible= false;
                return true;
            }
        }

        public static bool CheckUsername(string user, Label label)
        {
            if (!(user.Length >= 5)) { label.Text = "Your username should be at least 5 characters long"; label.Visible = true;SystemSounds.Beep.Play();return false; }
            else { label.Visible = false;return true; }
        }
    }
}
