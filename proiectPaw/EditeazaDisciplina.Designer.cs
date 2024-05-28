namespace proiectPaw
{
	partial class EditeazaDisciplina
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
			this.IdDisciplinalabel = new System.Windows.Forms.Label();
			this.DenumireDisciplinalabel = new System.Windows.Forms.Label();
			this.NrCreditelabel = new System.Windows.Forms.Label();
			this.IdDisciplinatextBox = new System.Windows.Forms.TextBox();
			this.EditNumarCreditetextBox = new System.Windows.Forms.TextBox();
			this.EditDenumireDisciplinatextBox = new System.Windows.Forms.TextBox();
			this.SaveButton = new System.Windows.Forms.Button();
			this.CancelButton = new System.Windows.Forms.Button();
			this.Okbutton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// IdDisciplinalabel
			// 
			this.IdDisciplinalabel.AutoSize = true;
			this.IdDisciplinalabel.Location = new System.Drawing.Point(12, 41);
			this.IdDisciplinalabel.Name = "IdDisciplinalabel";
			this.IdDisciplinalabel.Size = new System.Drawing.Size(189, 20);
			this.IdDisciplinalabel.TabIndex = 0;
			this.IdDisciplinalabel.Text = "Introduceti id-ul disciplinei";
			// 
			// DenumireDisciplinalabel
			// 
			this.DenumireDisciplinalabel.AutoSize = true;
			this.DenumireDisciplinalabel.Location = new System.Drawing.Point(31, 181);
			this.DenumireDisciplinalabel.Name = "DenumireDisciplinalabel";
			this.DenumireDisciplinalabel.Size = new System.Drawing.Size(149, 20);
			this.DenumireDisciplinalabel.TabIndex = 1;
			this.DenumireDisciplinalabel.Text = "Denumire Disciplina";
			// 
			// NrCreditelabel
			// 
			this.NrCreditelabel.AutoSize = true;
			this.NrCreditelabel.Location = new System.Drawing.Point(31, 226);
			this.NrCreditelabel.Name = "NrCreditelabel";
			this.NrCreditelabel.Size = new System.Drawing.Size(108, 20);
			this.NrCreditelabel.TabIndex = 2;
			this.NrCreditelabel.Text = "Numar credite";
			// 
			// IdDisciplinatextBox
			// 
			this.IdDisciplinatextBox.Location = new System.Drawing.Point(226, 41);
			this.IdDisciplinatextBox.Name = "IdDisciplinatextBox";
			this.IdDisciplinatextBox.Size = new System.Drawing.Size(502, 26);
			this.IdDisciplinatextBox.TabIndex = 3;
			// 
			// EditNumarCreditetextBox
			// 
			this.EditNumarCreditetextBox.Location = new System.Drawing.Point(186, 220);
			this.EditNumarCreditetextBox.Name = "EditNumarCreditetextBox";
			this.EditNumarCreditetextBox.Size = new System.Drawing.Size(502, 26);
			this.EditNumarCreditetextBox.TabIndex = 4;
			// 
			// EditDenumireDisciplinatextBox
			// 
			this.EditDenumireDisciplinatextBox.Location = new System.Drawing.Point(186, 181);
			this.EditDenumireDisciplinatextBox.Name = "EditDenumireDisciplinatextBox";
			this.EditDenumireDisciplinatextBox.Size = new System.Drawing.Size(502, 26);
			this.EditDenumireDisciplinatextBox.TabIndex = 5;
			// 
			// SaveButton
			// 
			this.SaveButton.Location = new System.Drawing.Point(287, 270);
			this.SaveButton.Name = "SaveButton";
			this.SaveButton.Size = new System.Drawing.Size(75, 60);
			this.SaveButton.TabIndex = 6;
			this.SaveButton.Text = "Save";
			this.SaveButton.UseVisualStyleBackColor = true;
			this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
			// 
			// CancelButton
			// 
			this.CancelButton.Location = new System.Drawing.Point(406, 270);
			this.CancelButton.Name = "CancelButton";
			this.CancelButton.Size = new System.Drawing.Size(75, 60);
			this.CancelButton.TabIndex = 7;
			this.CancelButton.Text = "Cancel";
			this.CancelButton.UseVisualStyleBackColor = true;
			this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
			// 
			// Okbutton
			// 
			this.Okbutton.Location = new System.Drawing.Point(642, 87);
			this.Okbutton.Name = "Okbutton";
			this.Okbutton.Size = new System.Drawing.Size(75, 60);
			this.Okbutton.TabIndex = 8;
			this.Okbutton.Text = "OK";
			this.Okbutton.UseVisualStyleBackColor = true;
			this.Okbutton.Click += new System.EventHandler(this.Okbutton_Click);
			// 
			// EditeazaDisciplina
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.ClientSize = new System.Drawing.Size(753, 342);
			this.Controls.Add(this.Okbutton);
			this.Controls.Add(this.CancelButton);
			this.Controls.Add(this.SaveButton);
			this.Controls.Add(this.EditDenumireDisciplinatextBox);
			this.Controls.Add(this.EditNumarCreditetextBox);
			this.Controls.Add(this.IdDisciplinatextBox);
			this.Controls.Add(this.NrCreditelabel);
			this.Controls.Add(this.DenumireDisciplinalabel);
			this.Controls.Add(this.IdDisciplinalabel);
			this.Name = "EditeazaDisciplina";
			this.Text = "EditeazaDisciplina";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label IdDisciplinalabel;
		private System.Windows.Forms.Label DenumireDisciplinalabel;
		private System.Windows.Forms.Label NrCreditelabel;
		private System.Windows.Forms.TextBox IdDisciplinatextBox;
		private System.Windows.Forms.TextBox EditNumarCreditetextBox;
		private System.Windows.Forms.TextBox EditDenumireDisciplinatextBox;
		private System.Windows.Forms.Button SaveButton;
		private System.Windows.Forms.Button CancelButton;
		private System.Windows.Forms.Button Okbutton;
	}
}