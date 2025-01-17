﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOS2Randomizer.UI.Components {
    public class Label : System.Windows.Forms.Label, IChoosableDesign {
        private DesignType _design = DesignType.Dark;
        public DesignType Design {
            get => _design;
            set {
                _design = value;
                var design = UI.Design.Get(_design);
                ForeColor = design.TextColor;
                FlatStyle = design.FlatStyle;
            }
        }
    }
}
