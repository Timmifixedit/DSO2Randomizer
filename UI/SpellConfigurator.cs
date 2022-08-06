﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DOS2Randomizer.DataStructures;
using DOS2Randomizer.Util;
using Newtonsoft.Json;
using MessageBox = System.Windows.Forms.MessageBox;

namespace DOS2Randomizer.UI {
    public partial class SpellConfigurator : Form {
        private Spell[] _spells;

        private Spell[] Spells {
            get => _spells;
            set {
                _spells = value;
                spellDesignPanel.AllSpells = _spells;
                search.AllSpells = _spells;
            }
        }
        public SpellConfigurator() {
            InitializeComponent();
            spellList.OnImageClick = spell => { spellDesignPanel.Spell = spell; };
        }

        private void import_Click(object sender, EventArgs e) {
            using var fileChooser = new OpenFileDialog{Filter = Resources.Misc.JsonFilter};
            if (fileChooser.ShowDialog() == DialogResult.OK) {
                Spells = FileIo.ImportSpells(fileChooser.FileName);
            }
        }

        private void save_Click(object sender, EventArgs e) {
            if (spellList.Spells is null) {
                MessageBox.Show(Resources.ErrorMessages.NoSpells);
                return;
            }

            using var fileChooser = new SaveFileDialog { AddExtension = true, DefaultExt = ".json"};
            if (fileChooser.ShowDialog() == DialogResult.OK) {
                try {
                    using var file = fileChooser.OpenFile();
                    using var writer = new StreamWriter(file);
                    var json = JsonConvert.SerializeObject(Spells);
                    writer.Write(json);
                } catch (IOException exception) {
                    MessageBox.Show(Resources.ErrorMessages.SaveError + exception.Message);
                }
            }
        }

        private void create_Click(object sender, EventArgs e) {
            using var dirChooser = new FolderBrowserDialog {ShowNewFolderButton = false};
            if (dirChooser.ShowDialog() == DialogResult.OK) {
                var files = Directory.GetFiles(dirChooser.SelectedPath, "*.png", SearchOption.AllDirectories);
                System.Diagnostics.Debug.WriteLine("Found the following png files");
                foreach (var file in files) {
                    System.Diagnostics.Debug.WriteLine(file);
                }

                Spells = files.Select(imageFile => new Spell("<unknown>", imageFile)).ToArray();
            }
        }
    }
}
