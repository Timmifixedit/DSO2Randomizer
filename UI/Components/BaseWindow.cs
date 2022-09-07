﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DOS2Randomizer.UI.Components
{
    public class BaseWindow : Form, IChoosableDesign
    {
        private DesignType _design = DesignType.Dark;
        public virtual DesignType Design
        {
            get => _design;
            set {
                _design = value;
                DarkModeHax.UseImmersiveDarkMode(Handle, value == DesignType.Dark);
                DesignHelper.ApplyDesign(value, Controls);
            }
        }
    }
}
