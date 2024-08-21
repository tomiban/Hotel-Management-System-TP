using Domain.Entities;
using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentation.Views
{
    public partial class CrearEditarHabitacion : MaterialForm, ICrearEditarHabitacion
    {
        readonly MaterialSkin.MaterialSkinManager materialSkinManager;

        public CrearEditarHabitacion( )
        {
            InitializeComponent();
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
        }

        public int Id => throw new NotImplementedException();

        public int NroHabitacion => throw new NotImplementedException();

        public TipoHabitacion TipoHabitacion => throw new NotImplementedException();

        public bool Disponible => throw new NotImplementedException();

        public int PrecioPorNoche => throw new NotImplementedException();

        public event EventHandler SaveEvent;
        public event EventHandler BackEvent;
    }
}
