
namespace CA1
{
    partial class Form1
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
            this.departureInput = new System.Windows.Forms.TextBox();
            this.departureInputLabel = new System.Windows.Forms.Label();
            this.departureSearchButton = new System.Windows.Forms.Button();
            this.departureCombo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.flyingToCombo = new System.Windows.Forms.ComboBox();
            this.flyingToSearchButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.flyingToInput = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // departureInput
            // 
            this.departureInput.Location = new System.Drawing.Point(12, 38);
            this.departureInput.Name = "departureInput";
            this.departureInput.Size = new System.Drawing.Size(169, 20);
            this.departureInput.TabIndex = 0;
            // 
            // departureInputLabel
            // 
            this.departureInputLabel.AutoSize = true;
            this.departureInputLabel.Location = new System.Drawing.Point(12, 19);
            this.departureInputLabel.Name = "departureInputLabel";
            this.departureInputLabel.Size = new System.Drawing.Size(79, 13);
            this.departureInputLabel.TabIndex = 1;
            this.departureInputLabel.Text = "Departing From";
            // 
            // departureSearchButton
            // 
            this.departureSearchButton.Location = new System.Drawing.Point(197, 38);
            this.departureSearchButton.Name = "departureSearchButton";
            this.departureSearchButton.Size = new System.Drawing.Size(75, 20);
            this.departureSearchButton.TabIndex = 2;
            this.departureSearchButton.Text = "Search";
            this.departureSearchButton.UseVisualStyleBackColor = true;
            this.departureSearchButton.Click += new System.EventHandler(this.departureSearchButton_Click);
            // 
            // departureCombo
            // 
            this.departureCombo.FormattingEnabled = true;
            this.departureCombo.Location = new System.Drawing.Point(12, 101);
            this.departureCombo.Name = "departureCombo";
            this.departureCombo.Size = new System.Drawing.Size(169, 21);
            this.departureCombo.TabIndex = 3;
            this.departureCombo.Format += new System.Windows.Forms.ListControlConvertEventHandler(this.departureComboFormat);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Select One of the Following";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(532, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Select One of the Following";
            // 
            // flyingToCombo
            // 
            this.flyingToCombo.FormattingEnabled = true;
            this.flyingToCombo.Location = new System.Drawing.Point(532, 101);
            this.flyingToCombo.Name = "flyingToCombo";
            this.flyingToCombo.Size = new System.Drawing.Size(169, 21);
            this.flyingToCombo.TabIndex = 8;
            this.flyingToCombo.Format += new System.Windows.Forms.ListControlConvertEventHandler(this.flyingToComboFormat);
            // 
            // flyingToSearchButton
            // 
            this.flyingToSearchButton.Location = new System.Drawing.Point(717, 38);
            this.flyingToSearchButton.Name = "flyingToSearchButton";
            this.flyingToSearchButton.Size = new System.Drawing.Size(75, 20);
            this.flyingToSearchButton.TabIndex = 7;
            this.flyingToSearchButton.Text = "Search";
            this.flyingToSearchButton.UseVisualStyleBackColor = true;
            this.flyingToSearchButton.Click += new System.EventHandler(this.flyingToSearchButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(532, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Flying To";
            // 
            // flyingToInput
            // 
            this.flyingToInput.Location = new System.Drawing.Point(532, 38);
            this.flyingToInput.Name = "flyingToInput";
            this.flyingToInput.Size = new System.Drawing.Size(169, 20);
            this.flyingToInput.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.flyingToCombo);
            this.Controls.Add(this.flyingToSearchButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.flyingToInput);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.departureCombo);
            this.Controls.Add(this.departureSearchButton);
            this.Controls.Add(this.departureInputLabel);
            this.Controls.Add(this.departureInput);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox departureInput;
        private System.Windows.Forms.Label departureInputLabel;
        private System.Windows.Forms.Button departureSearchButton;
        private System.Windows.Forms.ComboBox departureCombo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox flyingToCombo;
        private System.Windows.Forms.Button flyingToSearchButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox flyingToInput;
    }
}

