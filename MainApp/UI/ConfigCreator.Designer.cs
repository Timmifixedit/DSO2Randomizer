﻿
using DOS2Randomizer.UI.Components;

namespace DOS2Randomizer.UI {
    partial class ConfigCreator {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConfigCreator));
            this.tabControl = new DOS2Randomizer.UI.Components.TabControl();
            this.general = new System.Windows.Forms.TabPage();
            this.generalLayout = new System.Windows.Forms.TableLayoutPanel();
            this.generalSplitLayout = new System.Windows.Forms.TableLayoutPanel();
            this.configName = new DOS2Randomizer.UI.LabeledString();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.saveButton = new DOS2Randomizer.UI.Components.Button();
            this.importMatchConfig = new DOS2Randomizer.UI.Components.Button();
            this.nChooseKLayout = new System.Windows.Forms.TableLayoutPanel();
            this.n = new DOS2Randomizer.UI.LabeledValue();
            this.k = new DOS2Randomizer.UI.LabeledValue();
            this.memSlots = new DOS2Randomizer.UI.LabeledValue();
            this.pdfLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.levelSpecific = new System.Windows.Forms.TabPage();
            this.unlimShuffles = new DOS2Randomizer.UI.Components.CheckBox();
            this.levelSpecificTable = new DOS2Randomizer.UI.LevelSpecificTable();
            this.spells = new System.Windows.Forms.TabPage();
            this.spellMainLayout = new System.Windows.Forms.TableLayoutPanel();
            this.spellListLayout = new System.Windows.Forms.TableLayoutPanel();
            this.spellList = new DOS2Randomizer.UI.SpellList();
            this.spellSearchLayout = new System.Windows.Forms.TableLayoutPanel();
            this.importSpells = new DOS2Randomizer.UI.Components.Button();
            this.spellSearch = new DOS2Randomizer.UI.SpellSearch();
            this.spellDesignPanel1 = new DOS2Randomizer.UI.SpellDesignPanel();
            this.tabControl.SuspendLayout();
            this.general.SuspendLayout();
            this.generalLayout.SuspendLayout();
            this.generalSplitLayout.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.nChooseKLayout.SuspendLayout();
            this.levelSpecific.SuspendLayout();
            this.spells.SuspendLayout();
            this.spellMainLayout.SuspendLayout();
            this.spellListLayout.SuspendLayout();
            this.spellSearchLayout.SuspendLayout();
            this.SuspendLayout();
            // 
            // designButton
            // 
            this.designButton.FlatAppearance.BorderSize = 0;
            this.designButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(98)))), ((int)(((byte)(0)))));
            this.designButton.UseVisualStyleBackColor = false;
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.general);
            this.tabControl.Controls.Add(this.levelSpecific);
            this.tabControl.Controls.Add(this.spells);
            this.tabControl.Design = DOS2Randomizer.UI.DesignType.Dark;
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(811, 468);
            this.tabControl.TabIndex = 0;
            // 
            // general
            // 
            this.general.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.general.Controls.Add(this.generalLayout);
            this.general.Location = new System.Drawing.Point(4, 24);
            this.general.Name = "general";
            this.general.Padding = new System.Windows.Forms.Padding(3);
            this.general.Size = new System.Drawing.Size(803, 440);
            this.general.TabIndex = 0;
            this.general.Text = "General";
            // 
            // generalLayout
            // 
            this.generalLayout.ColumnCount = 1;
            this.generalLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.generalLayout.Controls.Add(this.generalSplitLayout, 0, 0);
            this.generalLayout.Controls.Add(this.nChooseKLayout, 0, 3);
            this.generalLayout.Controls.Add(this.memSlots, 0, 2);
            this.generalLayout.Controls.Add(this.pdfLayout, 0, 1);
            this.generalLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.generalLayout.Location = new System.Drawing.Point(3, 3);
            this.generalLayout.Name = "generalLayout";
            this.generalLayout.RowCount = 4;
            this.generalLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.18182F));
            this.generalLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 63.63636F));
            this.generalLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.generalLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.generalLayout.Size = new System.Drawing.Size(797, 434);
            this.generalLayout.TabIndex = 9;
            // 
            // generalSplitLayout
            // 
            this.generalSplitLayout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.generalSplitLayout.ColumnCount = 2;
            this.generalSplitLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 71.42857F));
            this.generalSplitLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.57143F));
            this.generalSplitLayout.Controls.Add(this.configName, 0, 0);
            this.generalSplitLayout.Controls.Add(this.tableLayoutPanel1, 1, 0);
            this.generalSplitLayout.Location = new System.Drawing.Point(3, 5);
            this.generalSplitLayout.Name = "generalSplitLayout";
            this.generalSplitLayout.RowCount = 1;
            this.generalSplitLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.generalSplitLayout.Size = new System.Drawing.Size(791, 67);
            this.generalSplitLayout.TabIndex = 10;
            // 
            // configName
            // 
            this.configName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.configName.Design = DOS2Randomizer.UI.DesignType.Dark;
            this.configName.Label = "Configuration Name";
            this.configName.Location = new System.Drawing.Point(3, 12);
            this.configName.Name = "configName";
            this.configName.Size = new System.Drawing.Size(559, 42);
            this.configName.SplitPercentage = 40;
            this.configName.TabIndex = 4;
            this.configName.Value = "";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.saveButton, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.importMatchConfig, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(568, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(200, 61);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // saveButton
            // 
            this.saveButton.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.saveButton.Design = DOS2Randomizer.UI.DesignType.Dark;
            this.saveButton.FlatAppearance.BorderSize = 0;
            this.saveButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(98)))), ((int)(((byte)(0)))));
            this.saveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveButton.ForeColor = System.Drawing.Color.White;
            this.saveButton.Location = new System.Drawing.Point(3, 3);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 0;
            this.saveButton.Text = "Save as";
            this.saveButton.UseVisualStyleBackColor = false;
            this.saveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // importMatchConfig
            // 
            this.importMatchConfig.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.importMatchConfig.Design = DOS2Randomizer.UI.DesignType.Dark;
            this.importMatchConfig.FlatAppearance.BorderSize = 0;
            this.importMatchConfig.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(98)))), ((int)(((byte)(0)))));
            this.importMatchConfig.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.importMatchConfig.ForeColor = System.Drawing.Color.White;
            this.importMatchConfig.Location = new System.Drawing.Point(3, 33);
            this.importMatchConfig.Name = "importMatchConfig";
            this.importMatchConfig.Size = new System.Drawing.Size(75, 23);
            this.importMatchConfig.TabIndex = 1;
            this.importMatchConfig.Text = "Import";
            this.importMatchConfig.UseVisualStyleBackColor = false;
            this.importMatchConfig.Click += new System.EventHandler(this.importConfig_Click);
            // 
            // nChooseKLayout
            // 
            this.nChooseKLayout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.nChooseKLayout.ColumnCount = 2;
            this.nChooseKLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.nChooseKLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.nChooseKLayout.Controls.Add(this.n, 0, 0);
            this.nChooseKLayout.Controls.Add(this.k, 1, 0);
            this.nChooseKLayout.Location = new System.Drawing.Point(3, 397);
            this.nChooseKLayout.Name = "nChooseKLayout";
            this.nChooseKLayout.RowCount = 1;
            this.nChooseKLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.nChooseKLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.nChooseKLayout.Size = new System.Drawing.Size(791, 33);
            this.nChooseKLayout.TabIndex = 8;
            // 
            // n
            // 
            this.n.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.n.Design = DOS2Randomizer.UI.DesignType.Dark;
            this.n.Label = "From";
            this.n.Location = new System.Drawing.Point(242, 3);
            this.n.Max = 100;
            this.n.Min = 0;
            this.n.Name = "n";
            this.n.Size = new System.Drawing.Size(150, 27);
            this.n.SplitPercentage = 71;
            this.n.TabIndex = 0;
            this.n.Value = 0;
            // 
            // k
            // 
            this.k.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.k.Design = DOS2Randomizer.UI.DesignType.Dark;
            this.k.Label = "spells choose";
            this.k.Location = new System.Drawing.Point(398, 3);
            this.k.Max = 100;
            this.k.Min = 0;
            this.k.Name = "k";
            this.k.Size = new System.Drawing.Size(150, 27);
            this.k.SplitPercentage = 71;
            this.k.TabIndex = 1;
            this.k.Value = 0;
            // 
            // memSlots
            // 
            this.memSlots.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.memSlots.Design = DOS2Randomizer.UI.DesignType.Dark;
            this.memSlots.Label = "Maximum number of memory slots";
            this.memSlots.Location = new System.Drawing.Point(3, 357);
            this.memSlots.Max = 100;
            this.memSlots.Min = 0;
            this.memSlots.Name = "memSlots";
            this.memSlots.Size = new System.Drawing.Size(791, 33);
            this.memSlots.SplitPercentage = 50;
            this.memSlots.TabIndex = 11;
            this.memSlots.Value = 0;
            // 
            // pdfLayout
            // 
            this.pdfLayout.AutoScroll = true;
            this.pdfLayout.AutoScrollMinSize = new System.Drawing.Size(1500, 0);
            this.pdfLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pdfLayout.Location = new System.Drawing.Point(3, 81);
            this.pdfLayout.Name = "pdfLayout";
            this.pdfLayout.Size = new System.Drawing.Size(791, 270);
            this.pdfLayout.TabIndex = 12;
            // 
            // levelSpecific
            // 
            this.levelSpecific.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.levelSpecific.Controls.Add(this.unlimShuffles);
            this.levelSpecific.Controls.Add(this.levelSpecificTable);
            this.levelSpecific.Location = new System.Drawing.Point(4, 24);
            this.levelSpecific.Name = "levelSpecific";
            this.levelSpecific.Padding = new System.Windows.Forms.Padding(3);
            this.levelSpecific.Size = new System.Drawing.Size(803, 440);
            this.levelSpecific.TabIndex = 1;
            this.levelSpecific.Text = "Level Specific";
            // 
            // unlimShuffles
            // 
            this.unlimShuffles.AutoSize = true;
            this.unlimShuffles.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.unlimShuffles.Design = DOS2Randomizer.UI.DesignType.Dark;
            this.unlimShuffles.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(98)))), ((int)(((byte)(0)))));
            this.unlimShuffles.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(98)))), ((int)(((byte)(0)))));
            this.unlimShuffles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.unlimShuffles.ForeColor = System.Drawing.Color.White;
            this.unlimShuffles.Location = new System.Drawing.Point(429, 6);
            this.unlimShuffles.Name = "unlimShuffles";
            this.unlimShuffles.Size = new System.Drawing.Size(118, 19);
            this.unlimShuffles.TabIndex = 1;
            this.unlimShuffles.Text = "unlimited shuffles";
            this.unlimShuffles.UseVisualStyleBackColor = false;
            this.unlimShuffles.CheckedChanged += new System.EventHandler(this.unlimShuffles_CheckedChanged);
            // 
            // levelSpecificTable
            // 
            this.levelSpecificTable.Design = DOS2Randomizer.UI.DesignType.Dark;
            this.levelSpecificTable.Location = new System.Drawing.Point(3, 3);
            this.levelSpecificTable.Name = "levelSpecificTable";
            this.levelSpecificTable.Size = new System.Drawing.Size(420, 416);
            this.levelSpecificTable.TabIndex = 0;
            // 
            // spells
            // 
            this.spells.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.spells.Controls.Add(this.spellMainLayout);
            this.spells.Location = new System.Drawing.Point(4, 24);
            this.spells.Name = "spells";
            this.spells.Size = new System.Drawing.Size(192, 72);
            this.spells.TabIndex = 2;
            this.spells.Text = "Spells";
            // 
            // spellMainLayout
            // 
            this.spellMainLayout.ColumnCount = 1;
            this.spellMainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.spellMainLayout.Controls.Add(this.spellListLayout, 0, 0);
            this.spellMainLayout.Controls.Add(this.spellDesignPanel1, 0, 1);
            this.spellMainLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spellMainLayout.Location = new System.Drawing.Point(0, 0);
            this.spellMainLayout.Name = "spellMainLayout";
            this.spellMainLayout.RowCount = 2;
            this.spellMainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 32.46445F));
            this.spellMainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 67.53555F));
            this.spellMainLayout.Size = new System.Drawing.Size(192, 72);
            this.spellMainLayout.TabIndex = 2;
            // 
            // spellListLayout
            // 
            this.spellListLayout.ColumnCount = 2;
            this.spellListLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.80083F));
            this.spellListLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 72.19917F));
            this.spellListLayout.Controls.Add(this.spellList, 1, 0);
            this.spellListLayout.Controls.Add(this.spellSearchLayout, 0, 0);
            this.spellListLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spellListLayout.Location = new System.Drawing.Point(3, 3);
            this.spellListLayout.Name = "spellListLayout";
            this.spellListLayout.RowCount = 1;
            this.spellListLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.spellListLayout.Size = new System.Drawing.Size(186, 17);
            this.spellListLayout.TabIndex = 0;
            // 
            // spellList
            // 
            this.spellList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.spellList.ClickEnabled = true;
            this.spellList.Design = DOS2Randomizer.UI.DesignType.Dark;
            this.spellList.Location = new System.Drawing.Point(54, 3);
            this.spellList.Name = "spellList";
            this.spellList.Size = new System.Drawing.Size(129, 11);
            this.spellList.Spells = null;
            this.spellList.TabIndex = 0;
            // 
            // spellSearchLayout
            // 
            this.spellSearchLayout.ColumnCount = 1;
            this.spellSearchLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.spellSearchLayout.Controls.Add(this.importSpells, 0, 0);
            this.spellSearchLayout.Controls.Add(this.spellSearch, 0, 1);
            this.spellSearchLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spellSearchLayout.Location = new System.Drawing.Point(3, 3);
            this.spellSearchLayout.Name = "spellSearchLayout";
            this.spellSearchLayout.RowCount = 2;
            this.spellSearchLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.spellSearchLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.spellSearchLayout.Size = new System.Drawing.Size(45, 11);
            this.spellSearchLayout.TabIndex = 1;
            // 
            // importSpells
            // 
            this.importSpells.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.importSpells.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.importSpells.Design = DOS2Randomizer.UI.DesignType.Dark;
            this.importSpells.FlatAppearance.BorderSize = 0;
            this.importSpells.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(98)))), ((int)(((byte)(0)))));
            this.importSpells.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.importSpells.ForeColor = System.Drawing.Color.White;
            this.importSpells.Location = new System.Drawing.Point(3, 3);
            this.importSpells.Name = "importSpells";
            this.importSpells.Size = new System.Drawing.Size(39, 1);
            this.importSpells.TabIndex = 1;
            this.importSpells.Text = "Import";
            this.importSpells.UseVisualStyleBackColor = false;
            this.importSpells.Click += new System.EventHandler(this.importSpells_Click);
            // 
            // spellSearch
            // 
            this.spellSearch.AllSpells = null;
            this.spellSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.spellSearch.CaseSensitive = false;
            this.spellSearch.Design = DOS2Randomizer.UI.DesignType.Dark;
            this.spellSearch.Label = "Search";
            this.spellSearch.Location = new System.Drawing.Point(3, 8);
            this.spellSearch.ManagedCollection = this.spellList;
            this.spellSearch.Name = "spellSearch";
            this.spellSearch.Size = new System.Drawing.Size(39, 1);
            this.spellSearch.SplitPercentage = 30;
            this.spellSearch.TabIndex = 2;
            this.spellSearch.Value = "";
            // 
            // spellDesignPanel1
            // 
            this.spellDesignPanel1.AllSpells = null;
            this.spellDesignPanel1.Design = DOS2Randomizer.UI.DesignType.Dark;
            this.spellDesignPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spellDesignPanel1.Location = new System.Drawing.Point(3, 26);
            this.spellDesignPanel1.Name = "spellDesignPanel1";
            this.spellDesignPanel1.Size = new System.Drawing.Size(186, 43);
            this.spellDesignPanel1.Spell = null;
            this.spellDesignPanel1.TabIndex = 1;
            // 
            // ConfigCreator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 468);
            this.Controls.Add(this.tabControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ConfigCreator";
            this.Text = "Create Match Config";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ConfigCreator_KeyDown);
            this.Controls.SetChildIndex(this.tabControl, 0);
            this.Controls.SetChildIndex(this.designButton, 0);
            this.tabControl.ResumeLayout(false);
            this.general.ResumeLayout(false);
            this.generalLayout.ResumeLayout(false);
            this.generalSplitLayout.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.nChooseKLayout.ResumeLayout(false);
            this.levelSpecific.ResumeLayout(false);
            this.levelSpecific.PerformLayout();
            this.spells.ResumeLayout(false);
            this.spellMainLayout.ResumeLayout(false);
            this.spellListLayout.ResumeLayout(false);
            this.spellSearchLayout.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DOS2Randomizer.UI.Components.TabControl tabControl;
        private System.Windows.Forms.TabPage general;
        private System.Windows.Forms.TabPage levelSpecific;
        private System.Windows.Forms.TabPage spells;
        private System.Windows.Forms.TableLayoutPanel nChooseKLayout;
        private System.Windows.Forms.TableLayoutPanel generalLayout;
        private System.Windows.Forms.TableLayoutPanel generalSplitLayout;
        private LabeledValue memSlots;
        private LabeledValue n;
        private LabeledValue k;
        private LabeledString configName;
        private SpellList spellList;
        private DOS2Randomizer.UI.Components.Button importSpells;
        private System.Windows.Forms.TableLayoutPanel spellMainLayout;
        private System.Windows.Forms.TableLayoutPanel spellListLayout;
        private SpellDesignPanel spellDesignPanel1;
        private System.Windows.Forms.TableLayoutPanel spellSearchLayout;
        private SpellSearch spellSearch;
        private LevelSpecificTable levelSpecificTable;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DOS2Randomizer.UI.Components.Button saveButton;
        private DOS2Randomizer.UI.Components.Button importMatchConfig;
        private System.Windows.Forms.FlowLayoutPanel pdfLayout;
        private CheckBox unlimShuffles;
    }
}