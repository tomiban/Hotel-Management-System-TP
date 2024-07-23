using MaterialSkin.Controls;
using MaterialSkin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GestionHotelWinForms.Models;

namespace GestionHotelWinForms.Views
{
    public partial class Register : MaterialForm, IRegisterView
    {
        readonly MaterialSkin.MaterialSkinManager materialSkinManager;

        public event EventHandler RegisterEvent;
       

        public string Nombre => txtNombre.Text;

        public string Apellido => txtApellido.Text;

        public string Edad => txtEdad.Text;

        public string Telefono => txtTelefono.Text;

        public string Username => txtUsuario.Text;

        public string Contraseña => txtContraseña.Text;

        public Role Role => Role.Client;

        public Register()
        {
           
            materialSkinManager = MaterialSkin.MaterialSkinManager.Instance;
            materialSkinManager.EnforceBackcolorOnAllComponents = true;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.DARK;
            materialSkinManager = MaterialSkin.MaterialSkinManager.Instance;
            materialSkinManager.EnforceBackcolorOnAllComponents = true;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.DARK;

            materialSkinManager.ColorScheme = new ColorScheme(
         Primary.DeepPurple600,   // Deep Purple más oscuro para un mejor contraste
         Primary.DeepPurple700,   // Deep Purple oscuro para el contraste principal
         Primary.Cyan700,   // Deep Purple base para fondos principales
         Accent.Cyan700,         // Acento verde 400 para destacar
         TextShade.WHITE          // Color de texto blanco para el contraste
     );
            InitializeComponent();
            AssocciateAndRaiseViewEvents();
        }

        private void AssocciateAndRaiseViewEvents()
        {
            btnRegistrarse.Click += delegate { RegisterEvent?.Invoke(this, EventArgs.Empty); };
        }

        public void ShowMessage(string title, string message)
        { 
           
            MaterialMessageBox.Show(this, title, message);
        }
    }
}
