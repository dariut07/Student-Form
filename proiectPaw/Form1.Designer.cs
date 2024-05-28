namespace proiectPaw
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
			this.components = new System.ComponentModel.Container();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.studentiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.afisareStudentiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.adaugaStudentiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.editeazaStudentiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.stergeStudentiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.disciplineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.afiseazaDisciplineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.adaugaDisciplineToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.editeazaDisciplineToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.stergeDisciplineToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.anStudiiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.afiseazaAnStudiiToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.editeazaAnStudiiToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
			this.cautaNotaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.restanteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.dataGridView = new System.Windows.Forms.DataGridView();
			this.menuStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
			this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.studentiToolStripMenuItem,
            this.disciplineToolStripMenuItem,
            this.anStudiiToolStripMenuItem,
            this.cautaNotaToolStripMenuItem,
            this.restanteToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(800, 33);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// studentiToolStripMenuItem
			// 
			this.studentiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.afisareStudentiToolStripMenuItem,
            this.adaugaStudentiToolStripMenuItem,
            this.editeazaStudentiToolStripMenuItem,
            this.stergeStudentiToolStripMenuItem});
			this.studentiToolStripMenuItem.Name = "studentiToolStripMenuItem";
			this.studentiToolStripMenuItem.Size = new System.Drawing.Size(93, 29);
			this.studentiToolStripMenuItem.Text = "Studenti";
			// 
			// afisareStudentiToolStripMenuItem
			// 
			this.afisareStudentiToolStripMenuItem.Name = "afisareStudentiToolStripMenuItem";
			this.afisareStudentiToolStripMenuItem.Size = new System.Drawing.Size(179, 34);
			this.afisareStudentiToolStripMenuItem.Text = "Afisare";
			this.afisareStudentiToolStripMenuItem.Click += new System.EventHandler(this.afisareStudentiToolStripMenuItem_Click);
			// 
			// adaugaStudentiToolStripMenuItem
			// 
			this.adaugaStudentiToolStripMenuItem.Name = "adaugaStudentiToolStripMenuItem";
			this.adaugaStudentiToolStripMenuItem.Size = new System.Drawing.Size(179, 34);
			this.adaugaStudentiToolStripMenuItem.Text = "Adauga";
			this.adaugaStudentiToolStripMenuItem.Click += new System.EventHandler(this.adaugaStudentiToolStripMenuItem_Click);
			// 
			// editeazaStudentiToolStripMenuItem
			// 
			this.editeazaStudentiToolStripMenuItem.Name = "editeazaStudentiToolStripMenuItem";
			this.editeazaStudentiToolStripMenuItem.Size = new System.Drawing.Size(179, 34);
			this.editeazaStudentiToolStripMenuItem.Text = "Editeaza";
			this.editeazaStudentiToolStripMenuItem.Click += new System.EventHandler(this.editeazaStudentiToolStripMenuItem_Click);
			// 
			// stergeStudentiToolStripMenuItem
			// 
			this.stergeStudentiToolStripMenuItem.Name = "stergeStudentiToolStripMenuItem";
			this.stergeStudentiToolStripMenuItem.Size = new System.Drawing.Size(179, 34);
			this.stergeStudentiToolStripMenuItem.Text = "Sterge";
			this.stergeStudentiToolStripMenuItem.Click += new System.EventHandler(this.stergeStudentiToolStripMenuItem_Click);
			// 
			// disciplineToolStripMenuItem
			// 
			this.disciplineToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.afiseazaDisciplineToolStripMenuItem,
            this.adaugaDisciplineToolStripMenuItem1,
            this.editeazaDisciplineToolStripMenuItem1,
            this.stergeDisciplineToolStripMenuItem1});
			this.disciplineToolStripMenuItem.Name = "disciplineToolStripMenuItem";
			this.disciplineToolStripMenuItem.Size = new System.Drawing.Size(103, 29);
			this.disciplineToolStripMenuItem.Text = "Discipline";
			// 
			// afiseazaDisciplineToolStripMenuItem
			// 
			this.afiseazaDisciplineToolStripMenuItem.Name = "afiseazaDisciplineToolStripMenuItem";
			this.afiseazaDisciplineToolStripMenuItem.Size = new System.Drawing.Size(179, 34);
			this.afiseazaDisciplineToolStripMenuItem.Text = "Afiseaza";
			this.afiseazaDisciplineToolStripMenuItem.Click += new System.EventHandler(this.afiseazaDisciplineToolStripMenuItem_Click);
			// 
			// adaugaDisciplineToolStripMenuItem1
			// 
			this.adaugaDisciplineToolStripMenuItem1.Name = "adaugaDisciplineToolStripMenuItem1";
			this.adaugaDisciplineToolStripMenuItem1.Size = new System.Drawing.Size(179, 34);
			this.adaugaDisciplineToolStripMenuItem1.Text = "Adauga";
			this.adaugaDisciplineToolStripMenuItem1.Click += new System.EventHandler(this.adaugaDisciplineToolStripMenuItem1_Click);
			// 
			// editeazaDisciplineToolStripMenuItem1
			// 
			this.editeazaDisciplineToolStripMenuItem1.Name = "editeazaDisciplineToolStripMenuItem1";
			this.editeazaDisciplineToolStripMenuItem1.Size = new System.Drawing.Size(179, 34);
			this.editeazaDisciplineToolStripMenuItem1.Text = "Editeaza";
			this.editeazaDisciplineToolStripMenuItem1.Click += new System.EventHandler(this.editeazaDisciplineToolStripMenuItem1_Click);
			// 
			// stergeDisciplineToolStripMenuItem1
			// 
			this.stergeDisciplineToolStripMenuItem1.Name = "stergeDisciplineToolStripMenuItem1";
			this.stergeDisciplineToolStripMenuItem1.Size = new System.Drawing.Size(179, 34);
			this.stergeDisciplineToolStripMenuItem1.Text = "Sterge";
			this.stergeDisciplineToolStripMenuItem1.Click += new System.EventHandler(this.stergeDisciplineToolStripMenuItem1_Click);
			// 
			// anStudiiToolStripMenuItem
			// 
			this.anStudiiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.afiseazaAnStudiiToolStripMenuItem1,
            this.editeazaAnStudiiToolStripMenuItem2});
			this.anStudiiToolStripMenuItem.Name = "anStudiiToolStripMenuItem";
			this.anStudiiToolStripMenuItem.Size = new System.Drawing.Size(99, 29);
			this.anStudiiToolStripMenuItem.Text = "An Studii";
			// 
			// afiseazaAnStudiiToolStripMenuItem1
			// 
			this.afiseazaAnStudiiToolStripMenuItem1.Name = "afiseazaAnStudiiToolStripMenuItem1";
			this.afiseazaAnStudiiToolStripMenuItem1.Size = new System.Drawing.Size(179, 34);
			this.afiseazaAnStudiiToolStripMenuItem1.Text = "Afiseaza";
			this.afiseazaAnStudiiToolStripMenuItem1.Click += new System.EventHandler(this.afiseazaAnStudiiToolStripMenuItem1_Click);
			// 
			// editeazaAnStudiiToolStripMenuItem2
			// 
			this.editeazaAnStudiiToolStripMenuItem2.Name = "editeazaAnStudiiToolStripMenuItem2";
			this.editeazaAnStudiiToolStripMenuItem2.Size = new System.Drawing.Size(179, 34);
			this.editeazaAnStudiiToolStripMenuItem2.Text = "Editeaza";
			this.editeazaAnStudiiToolStripMenuItem2.Click += new System.EventHandler(this.editeazaAnStudiiToolStripMenuItem2_Click);
			// 
			// cautaNotaToolStripMenuItem
			// 
			this.cautaNotaToolStripMenuItem.Name = "cautaNotaToolStripMenuItem";
			this.cautaNotaToolStripMenuItem.Size = new System.Drawing.Size(117, 29);
			this.cautaNotaToolStripMenuItem.Text = "Cauta Nota";
			this.cautaNotaToolStripMenuItem.Click += new System.EventHandler(this.cautaNotaToolStripMenuItem_Click);
			// 
			// restanteToolStripMenuItem
			// 
			this.restanteToolStripMenuItem.Name = "restanteToolStripMenuItem";
			this.restanteToolStripMenuItem.Size = new System.Drawing.Size(95, 29);
			this.restanteToolStripMenuItem.Text = "Restante";
			this.restanteToolStripMenuItem.Click += new System.EventHandler(this.restanteToolStripMenuItem_Click);
			// 
			// contextMenuStrip1
			// 
			this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
			this.contextMenuStrip1.Name = "contextMenuStrip1";
			this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
			// 
			// dataGridView
			// 
			this.dataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView.Location = new System.Drawing.Point(26, 53);
			this.dataGridView.Name = "dataGridView";
			this.dataGridView.RowHeadersWidth = 62;
			this.dataGridView.RowTemplate.Height = 28;
			this.dataGridView.Size = new System.Drawing.Size(746, 385);
			this.dataGridView.TabIndex = 2;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.dataGridView);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "Form1";
			this.Text = "Facultate";
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem studentiToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem afisareStudentiToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem adaugaStudentiToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem editeazaStudentiToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem stergeStudentiToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem disciplineToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem afiseazaDisciplineToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem adaugaDisciplineToolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem editeazaDisciplineToolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem stergeDisciplineToolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem anStudiiToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem afiseazaAnStudiiToolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem editeazaAnStudiiToolStripMenuItem2;
		private System.Windows.Forms.ToolStripMenuItem cautaNotaToolStripMenuItem;
		private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
		private System.Windows.Forms.DataGridView dataGridView;
		private System.Windows.Forms.ToolStripMenuItem restanteToolStripMenuItem;
	}
}

