using System;

namespace P3_2_1204013
{
    partial class Child_Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.OutputLbel = new System.Windows.Forms.Label();
            this.ExitButton = new System.Windows.Forms.Button();
            this.DisplayButton = new System.Windows.Forms.Button();
            this.OutputGrupBox = new System.Windows.Forms.GroupBox();
            this.DateOption = new System.Windows.Forms.RadioButton();
            this.TimeOpinion = new System.Windows.Forms.RadioButton();
            this.OutputGrupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // OutputLbel
            // 
            this.OutputLbel.AutoSize = true;
            this.OutputLbel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.OutputLbel.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OutputLbel.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.OutputLbel.Location = new System.Drawing.Point(0, 16);
            this.OutputLbel.Name = "OutputLbel";
            this.OutputLbel.Size = new System.Drawing.Size(2, 25);
            this.OutputLbel.TabIndex = 1;
            this.OutputLbel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(55, 53);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(75, 23);
            this.ExitButton.TabIndex = 0;
            this.ExitButton.Text = "E&xit";
            this.ExitButton.UseVisualStyleBackColor = true;
            // 
            // DisplayButton
            // 
            this.DisplayButton.Location = new System.Drawing.Point(157, 53);
            this.DisplayButton.Name = "DisplayButton";
            this.DisplayButton.Size = new System.Drawing.Size(75, 23);
            this.DisplayButton.TabIndex = 2;
            this.DisplayButton.Text = "E&xit";
            this.DisplayButton.UseVisualStyleBackColor = true;
            // 
            // OutputGrupBox
            // 
            this.OutputGrupBox.Controls.Add(this.DateOption);
            this.OutputGrupBox.Controls.Add(this.TimeOpinion);
            this.OutputGrupBox.Location = new System.Drawing.Point(8, 152);
            this.OutputGrupBox.Name = "OutputGrupBox";
            this.OutputGrupBox.Size = new System.Drawing.Size(200, 104);
            this.OutputGrupBox.TabIndex = 3;
            this.OutputGrupBox.TabStop = false;
            this.OutputGrupBox.Text = "Chose Output";
            // 
            // DateOption
            // 
            this.DateOption.AutoSize = true;
            this.DateOption.Location = new System.Drawing.Point(16, 30);
            this.DateOption.Name = "DateOption";
            this.DateOption.Size = new System.Drawing.Size(156, 21);
            this.DateOption.TabIndex = 1;
            this.DateOption.TabStop = true;
            this.DateOption.Text = "DisplayCurrent D&ate";
            this.DateOption.UseVisualStyleBackColor = true;
            // 
            // TimeOpinion
            // 
            this.TimeOpinion.AutoSize = true;
            this.TimeOpinion.Location = new System.Drawing.Point(16, 57);
            this.TimeOpinion.Name = "TimeOpinion";
            this.TimeOpinion.Size = new System.Drawing.Size(171, 21);
            this.TimeOpinion.TabIndex = 0;
            this.TimeOpinion.TabStop = true;
            this.TimeOpinion.Text = "Display Current D&Time";
            this.TimeOpinion.UseVisualStyleBackColor = true;
            // 
            // Child_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 253);
            this.Controls.Add(this.OutputGrupBox);
            this.Controls.Add(this.DisplayButton);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.OutputLbel);
            this.DataBindings.Add(new System.Windows.Forms.Binding("Location", global::P3_2_1204013.Properties.Settings.Default, "top", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.Location = global::P3_2_1204013.Properties.Settings.Default.top;
            this.Name = "Child_Form";
            this.MinimumSizeChanged += new System.EventHandler(this.top);
            this.DockChanged += new System.EventHandler(this.top);
            this.OutputGrupBox.ResumeLayout(false);
            this.OutputGrupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void top(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Label OutputLbel;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button DisplayButton;
        private System.Windows.Forms.GroupBox OutputGrupBox;
        private System.Windows.Forms.RadioButton DateOption;
        private System.Windows.Forms.RadioButton TimeOpinion;
    }
}