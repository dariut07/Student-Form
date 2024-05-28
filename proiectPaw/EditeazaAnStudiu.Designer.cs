namespace proiectPaw
{
	partial class EditeazaAnStudiu
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
			this.label2 = new System.Windows.Forms.Label();
			this.IdAnStudiuTextBox = new System.Windows.Forms.TextBox();
			this.EditeazaProfCTextBox = new System.Windows.Forms.TextBox();
			this.OKbutton = new System.Windows.Forms.Button();
			this.CancelButton = new System.Windows.Forms.Button();
			this.SaveButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 47);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(119, 20);
			this.label1.TabIndex = 0;
			this.label1.Text = "Introduceti anul";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 112);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(159, 20);
			this.label2.TabIndex = 1;
			this.label2.Text = "Profesor coordonator";
			// 
			// IdAnStudiuTextBox
			// 
			this.IdAnStudiuTextBox.Location = new System.Drawing.Point(165, 47);
			this.IdAnStudiuTextBox.Name = "IdAnStudiuTextBox";
			this.IdAnStudiuTextBox.Size = new System.Drawing.Size(457, 26);
			this.IdAnStudiuTextBox.TabIndex = 2;
			// 
			// EditeazaProfCTextBox
			// 
			this.EditeazaProfCTextBox.Location = new System.Drawing.Point(189, 112);
			this.EditeazaProfCTextBox.Name = "EditeazaProfCTextBox";
			this.EditeazaProfCTextBox.Size = new System.Drawing.Size(347, 26);
			this.EditeazaProfCTextBox.TabIndex = 3;
			// 
			// OKbutton
			// 
			this.OKbutton.Location = new System.Drawing.Point(654, 31);
			this.OKbutton.Name = "OKbutton";
			this.OKbutton.Size = new System.Drawing.Size(78, 59);
			this.OKbutton.TabIndex = 4;
			this.OKbutton.Text = "OK";
			this.OKbutton.UseVisualStyleBackColor = true;
			this.OKbutton.Click += new System.EventHandler(this.OKbutton_Click);
			// 
			// CancelButton
			// 
			this.CancelButton.Location = new System.Drawing.Point(654, 114);
			this.CancelButton.Name = "CancelButton";
			this.CancelButton.Size = new System.Drawing.Size(75, 68);
			this.CancelButton.TabIndex = 5;
			this.CancelButton.Text = "Cancel";
			this.CancelButton.UseVisualStyleBackColor = true;
			this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
			// 
			// SaveButton
			// 
			this.SaveButton.Location = new System.Drawing.Point(557, 114);
			this.SaveButton.Name = "SaveButton";
			this.SaveButton.Size = new System.Drawing.Size(75, 71);
			this.SaveButton.TabIndex = 6;
			this.SaveButton.Text = "Save";
			this.SaveButton.UseVisualStyleBackColor = true;
			this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
			// 
			// EditeazaAnStudiu
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.ClientSize = new System.Drawing.Size(800, 194);
			this.Controls.Add(this.SaveButton);
			this.Controls.Add(this.CancelButton);
			this.Controls.Add(this.OKbutton);
			this.Controls.Add(this.EditeazaProfCTextBox);
			this.Controls.Add(this.IdAnStudiuTextBox);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "EditeazaAnStudiu";
			this.Text = "EditeazaAnStudiu";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox IdAnStudiuTextBox;
		private System.Windows.Forms.TextBox EditeazaProfCTextBox;
		private System.Windows.Forms.Button OKbutton;
		private System.Windows.Forms.Button CancelButton;
		private System.Windows.Forms.Button SaveButton;
	}
}