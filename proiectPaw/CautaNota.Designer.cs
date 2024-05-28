namespace proiectPaw
{
	partial class CautaNota
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
			this.label1 = new System.Windows.Forms.Label();
			this.IdStudentTextBox = new System.Windows.Forms.TextBox();
			this.OKbutton = new System.Windows.Forms.Button();
			this.DisciplineComboBox = new System.Windows.Forms.ComboBox();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(22, 29);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(200, 20);
			this.label1.TabIndex = 0;
			this.label1.Text = "Introduceti id-ul studentului";
			// 
			// IdStudentTextBox
			// 
			this.IdStudentTextBox.Location = new System.Drawing.Point(243, 29);
			this.IdStudentTextBox.Name = "IdStudentTextBox";
			this.IdStudentTextBox.Size = new System.Drawing.Size(385, 26);
			this.IdStudentTextBox.TabIndex = 1;
			// 
			// OKbutton
			// 
			this.OKbutton.Location = new System.Drawing.Point(669, 22);
			this.OKbutton.Name = "OKbutton";
			this.OKbutton.Size = new System.Drawing.Size(75, 40);
			this.OKbutton.TabIndex = 2;
			this.OKbutton.Text = "OK";
			this.OKbutton.UseVisualStyleBackColor = true;
			this.OKbutton.Click += new System.EventHandler(this.OKbutton_Click);
			// 
			// DisciplineComboBox
			// 
			this.DisciplineComboBox.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
			this.DisciplineComboBox.FormattingEnabled = true;
			this.DisciplineComboBox.Location = new System.Drawing.Point(243, 81);
			this.DisciplineComboBox.Name = "DisciplineComboBox";
			this.DisciplineComboBox.Size = new System.Drawing.Size(385, 28);
			this.DisciplineComboBox.TabIndex = 3;
			this.DisciplineComboBox.SelectedIndexChanged += new System.EventHandler(this.DisciplineComboBox_SelectedIndexChanged);
			// 
			// CautaNota
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.ClientSize = new System.Drawing.Size(800, 161);
			this.Controls.Add(this.DisciplineComboBox);
			this.Controls.Add(this.OKbutton);
			this.Controls.Add(this.IdStudentTextBox);
			this.Controls.Add(this.label1);
			this.Name = "CautaNota";
			this.Text = "CautaNota";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox IdStudentTextBox;
		private System.Windows.Forms.Button OKbutton;
		private System.Windows.Forms.ComboBox DisciplineComboBox;
	}
}