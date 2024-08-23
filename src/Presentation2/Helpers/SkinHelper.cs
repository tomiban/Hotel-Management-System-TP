using MaterialSkin.Controls;
using MaterialSkin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PresentationLayer.Helpers
{
    public class SkinHelper
    {
        public static void ApplyTheme(MaterialForm form, MaterialSkinManager.Themes theme, ColorScheme colorScheme)
        {
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.EnforceBackcolorOnAllComponents = true;
            materialSkinManager.AddFormToManage(form);
            materialSkinManager.Theme = theme;
            materialSkinManager.ColorScheme = colorScheme;
        }
    }
}
