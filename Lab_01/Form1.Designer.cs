
namespace Lab_01
{
    partial class Lab01Form
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nomeTextBox = new System.Windows.Forms.TextBox();
            this.cursoComboBox = new System.Windows.Forms.ComboBox();
            this.exibirButton = new System.Windows.Forms.Button();
            this.mensagemLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "&Nome:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "&Curso";
            // 
            // nomeTextBox
            // 
            this.nomeTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nomeTextBox.Location = new System.Drawing.Point(90, 24);
            this.nomeTextBox.Name = "nomeTextBox";
            this.nomeTextBox.Size = new System.Drawing.Size(245, 23);
            this.nomeTextBox.TabIndex = 1;
            // 
            // cursoComboBox
            // 
            this.cursoComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cursoComboBox.FormattingEnabled = true;
            this.cursoComboBox.Items.AddRange(new object[] {
            "C#",
            "Delphi",
            "Java",
            "VB NET"});
            this.cursoComboBox.Location = new System.Drawing.Point(90, 73);
            this.cursoComboBox.Name = "cursoComboBox";
            this.cursoComboBox.Size = new System.Drawing.Size(245, 23);
            this.cursoComboBox.Sorted = true;
            this.cursoComboBox.TabIndex = 3;
            // 
            // exibirButton
            // 
            this.exibirButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.exibirButton.Location = new System.Drawing.Point(13, 115);
            this.exibirButton.Name = "exibirButton";
            this.exibirButton.Size = new System.Drawing.Size(342, 54);
            this.exibirButton.TabIndex = 4;
            this.exibirButton.Text = "Exibir";
            this.exibirButton.UseVisualStyleBackColor = true;
            this.exibirButton.Click += new System.EventHandler(this.exibirButton_Click);
            // 
            // mensagemLabel
            // 
            this.mensagemLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mensagemLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mensagemLabel.Location = new System.Drawing.Point(13, 180);
            this.mensagemLabel.Name = "mensagemLabel";
            this.mensagemLabel.Size = new System.Drawing.Size(342, 73);
            this.mensagemLabel.TabIndex = 5;
            this.mensagemLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Lab01Form
            // 
            this.AcceptButton = this.exibirButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 334);
            this.Controls.Add(this.mensagemLabel);
            this.Controls.Add(this.exibirButton);
            this.Controls.Add(this.cursoComboBox);
            this.Controls.Add(this.nomeTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Name = "Lab01Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Laboratório";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nomeTextBox;
        private System.Windows.Forms.ComboBox cursoComboBox;
        private System.Windows.Forms.Button exibirButton;
        private System.Windows.Forms.Label mensagemLabel;
    }
}

