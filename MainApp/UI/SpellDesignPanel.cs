﻿using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DOS2Randomizer.DataStructures;
using DOS2Randomizer.UI.Components;

namespace DOS2Randomizer.UI {

    /// <summary>
    /// User control used to configure a spell
    /// </summary>
    public partial class SpellDesignPanel : BaseControl {
        private Spell? _spell;
        private Spell[]? _allSpells;
        public SpellDesignPanel() {
            InitializeComponent();
            typeSelection.Data = (Spell.Type[]) Enum.GetValues(typeof(Spell.Type));
            search.OnValueChanged += _ => { dependencies.Value = _spell?.Dependencies; };
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
            skillPointsPanel1.OnValueChanged = value => {
                if (_spell != null) {
                    _spell.SchoolRequirements = value.ToImmutableDictionary();
                }
            };
            attributeBox.OnValueChanged = value => {
                if (_spell != null) {
                    _spell.Scaling= value;
                }
            };
            typeSelection.OnValueChanged = value => {
                if (_spell != null) {
                    _spell.Types = value.ToImmutableArray();
                }
            };
            dependencies.OnValueChanged = value => {
                if (_spell != null) {
                    var tmp = value as Spell[] ?? value.ToArray();
                    var removed = dependencies.Data.Except(tmp);
                    _spell.Dependencies = _spell.Dependencies.Except(removed).Union(tmp).ToImmutableArray();
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
            requiredEquipment.OnValueChanged = value => {
                if (_spell != null) {
                    _spell.EquipmentRequirement = value;
                }
            };
            benefitBox.OnValueChanged = value => {
                if (_spell != null) {
                    _spell.Benefit = value;
                }
            };
        }

        private void UnsubscribeFromControls() {
            level.OnValueChanged = null;
            name.OnValueChanged = null;
            skillPointsPanel1.OnValueChanged = null;
            attributeBox.OnValueChanged = null;
            typeSelection.OnValueChanged = null;
            dependencies.OnValueChanged = null;
            memSlots.OnValueChanged = null;
            cost.OnValueChanged = null;
            requiredEquipment.OnValueChanged = null;
            benefitBox.OnValueChanged = null;
        }

        public Spell? Spell {
            get => _spell;
            set {
                _spell = value;
                if (_spell != null) {
                    search.AllSpells = AllSpells?.Except(new[] { _spell }).ToArray();
                    UnsubscribeFromControls();
                    RefreshUi();
                    SubscribeToControls();
                }
            }
        }

        public Spell[]? AllSpells {
            get => _allSpells;
            set {
                _allSpells = value;
                search.AllSpells = _allSpells;
            }
        }

        private void RefreshUi() {
            if (_spell is null) {
                return;
            }

            try {
                name.Value = _spell.Name;
                level.Value = _spell.Level;
                skillPointsPanel1.Value = new Dictionary<Spell.School, int>(_spell.SchoolRequirements);
                attributeBox.Value = _spell.Scaling;
                typeSelection.Value = _spell.Types;
                dependencies.Value = _spell.Dependencies;
                memSlots.Value = _spell.MemorySlots;
                cost.Value = _spell.LoadoutCost;
                requiredEquipment.Value = _spell.EquipmentRequirement;
                benefitBox.Value = _spell.Benefit;
            } catch (ArgumentException e) {
                MessageBox.Show(Resources.ErrorMessages.InvalidConfigValues + e.Message);
            }
        }
    }
}
