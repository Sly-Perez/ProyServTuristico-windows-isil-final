using System;
using System.Windows.Forms;

namespace ProyServTuristico_GUI
{
    public static class NavigationHelper
    {
        public static void ReturnToMenuPrincipal(Form currentForm)
        {
            MenuPrincipalForm menuForm = Application.OpenForms["MenuPrincipalForm"] as MenuPrincipalForm;

            if (menuForm == null)
            {
                menuForm = new MenuPrincipalForm();
                menuForm.Show();
            }
            else
            {
                menuForm.UpdateUserName();
                menuForm.Activate();
            }

            currentForm.Close();
        }


        public static void OpenForm(Form currentForm, Form newForm)
        {
            newForm.Show();
            currentForm.Close();
        }
    }
}
