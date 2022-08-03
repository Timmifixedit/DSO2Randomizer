﻿
namespace DOS2Randomizer.UI {
    partial class SpellDesignPanel {
        /// <summary> 
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Komponenten-Designer generierter Code

        /// <summary> 
        /// Erforderliche Methode für die Designerunterstützung. 
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent() {
            this.level = new DOS2Randomizer.UI.LabeledValue();
            this.name = new DOS2Randomizer.UI.LabeledString();
            this.flowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.schoolBox = new DOS2Randomizer.UI.LabeledSchoolType();
            this.attributeBox = new DOS2Randomizer.UI.LabeledAttribute();
            this.flowLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // level
            // 
            this.level.Label = "Level";
            this.level.Location = new System.Drawing.Point(200, 3);
            this.level.Max = 20;
            this.level.Min = 1;
            this.level.Name = "level";
            this.level.Size = new System.Drawing.Size(191, 42);
            this.level.SplitPercentage = 50;
            this.level.TabIndex = 0;
            this.level.Value = 1;
            // 
            // name
            // 
            this.name.Label = "Spell name";
            this.name.Location = new System.Drawing.Point(3, 3);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(191, 42);
            this.name.SplitPercentage = 40;
            this.name.TabIndex = 1;
            this.name.Value = "";
            // 
            // flowLayoutPanel
            // 
            this.flowLayoutPanel.Controls.Add(this.name);
            this.flowLayoutPanel.Controls.Add(this.level);
            this.flowLayoutPanel.Controls.Add(this.schoolBox);
            this.flowLayoutPanel.Controls.Add(this.attributeBox);
            this.flowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel.Name = "flowLayoutPanel";
            this.flowLayoutPanel.Size = new System.Drawing.Size(505, 243);
            this.flowLayoutPanel.TabIndex = 2;
            // 
            // schoolBox
            // 
            this.schoolBox.Label = "School";
            this.schoolBox.Location = new System.Drawing.Point(3, 51);
            this.schoolBox.Name = "schoolBox";
            this.schoolBox.Size = new System.Drawing.Size(191, 26);
            this.schoolBox.SplitPercentage = 50;
            this.schoolBox.TabIndex = 2;
            this.schoolBox.Value = DOS2Randomizer.DataStructures.Spell.School.Aero;
            // 
            // attributeBox
            // 
            this.attributeBox.Label = "Scales with";
            this.attributeBox.Location = new System.Drawing.Point(200, 51);
            this.attributeBox.Name = "attributeBox";
            this.attributeBox.Size = new System.Drawing.Size(191, 33);
            this.attributeBox.SplitPercentage = 50;
            this.attributeBox.TabIndex = 3;
            this.attributeBox.Value = DOS2Randomizer.DataStructures.Attribute.Strength;
            // 
            // SpellDesignPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.flowLayoutPanel);
            this.Name = "SpellDesignPanel";
            this.Size = new System.Drawing.Size(505, 243);
            this.flowLayoutPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private LabeledValue level;
        private LabeledString name;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel;
        private LabeledSchoolType schoolBox;
        private LabeledAttribute attributeBox;
    }
}