﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DOS2Randomizer.DataStructures;

namespace DOS2Randomizer.UI {
    public partial class SpellDesignPanel : UserControl {
        private Spell _spell;
        private Spell[] _allSpells;
        public SpellDesignPanel() {
            InitializeComponent();
            typeSelection.Data = (Spell.Type[]) Enum.GetValues(typeof(Spell.Type));
            SubscribeToControls();
        }

        private void SubscribeToControls() {
            name.OnValueChanged = value => {
                if (_spell != null) {
                    _spell.Name = value;
                }    
            };
            level.OnValueChanged = value => {
                if (_spell != null) {
                    _spell.Level = value;
                }
            };
            schoolBox.OnValueChanged = value => {
                if (_spell != null) {
                    _spell.SchoolType = value;
                }
            };
            attributeBox.OnValueChanged = value => {
                if (_spell != null) {
                    _spell.Scaling= value;
                }
            };
            typeSelection.OnValueChanged = value => {
                if (_spell != null) {
                    _spell.Types = value;
                }
            };
            dependencies.OnValueChanged = value => {
                if (_spell != null) {
                    _spell.Dependencies = value;
                }
            };
            memSlots.OnValueChanged = value => {
                if (_spell != null) {
                    _spell.MemorySlots = value;
                }
            };
            cost.OnValueChanged = value => {
                if (_spell != null) {
                    _spell.LoadoutCost = value;
                }
            };
        }

        private void UnsubscribeFromControls() {
            level.OnValueChanged = null;
            name.OnValueChanged = null;
            schoolBox.OnValueChanged = null;
            attributeBox.OnValueChanged = null;
            typeSelection.OnValueChanged = null;
            dependencies.OnValueChanged = null;
            memSlots.OnValueChanged = null;
            cost.OnValueChanged = null;
        }

        public Spell Spell {
            get => _spell;
            set {
                _spell = value;
                if (_spell != null) {
                    UnsubscribeFromControls();
                    RefreshUi();
                    SubscribeToControls();
                }
            }
        }

        public Spell[] AllSpells {
            get => _allSpells;
            set {
                _allSpells = value;
                dependencies.Data = _allSpells;
            }
        }

        private void RefreshUi() {
            try {
                name.Value = _spell.Name;
                level.Value = _spell.Level;
                schoolBox.Value = _spell.SchoolType;
                attributeBox.Value = _spell.Scaling;
                typeSelection.Value = _spell.Types;
                dependencies.Value = _spell.Dependencies;
                memSlots.Value = _spell.MemorySlots;
                cost.Value = _spell.LoadoutCost;
            } catch (ArgumentException e) {
                MessageBox.Show(Resources.ErrorMessages.InvalidConfigValues + e.Message);
            }
        }
    }
}
