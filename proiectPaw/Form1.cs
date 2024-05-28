using proiectPaw.Entities;
using proiectPaw.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proiectPaw
{
	public partial class Form1 : Form

	{
		private StudentRepo _studentRepo;
		private DisciplinaRepo _disciplinaRepo;
		private AnStudiuRepo _anStudiuRepo;
		private NoteRepo _noteRepo;
		public Form1()
		{
			InitializeComponent();
			_studentRepo = new StudentRepo();
			_disciplinaRepo= new DisciplinaRepo();
			_noteRepo = new NoteRepo();
			_anStudiuRepo= new AnStudiuRepo();
			
			dataGridView.AutoGenerateColumns = true;
		}
		private void SetDataSource(object dataSource)
		{
			dataGridView.DataSource = dataSource;
		}
		private void afisareStudentiToolStripMenuItem_Click(object sender, EventArgs e)
		{
			var students = _studentRepo.FetchAllStudents();
			SetDataSource(students);

		}

		private void afiseazaDisciplineToolStripMenuItem_Click(object sender, EventArgs e)
		{
			var discipline = _disciplinaRepo.DisciplinaFetchData();
			SetDataSource(discipline);

		}

		private void afiseazaAnStudiiToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			var anStudii=_anStudiuRepo.AnStudiuFetchData();
			SetDataSource(anStudii);
		}

		

		private void adaugaStudentiToolStripMenuItem_Click(object sender, EventArgs e)
		{
			var adaugaStudentForm = new AdaugaStudent();
			adaugaStudentForm.ShowDialog();
			

		}
		private void editeazaStudentiToolStripMenuItem_Click(object sender, EventArgs e)
		{
			EditeazaStudent editStudentForm = new EditeazaStudent();
			editStudentForm.ShowDialog();

		}
		
		private void stergeStudentiToolStripMenuItem_Click(object sender, EventArgs e)
		{
			StergeStudent deleteStudentForm = new StergeStudent();
			deleteStudentForm.ShowDialog();

		}

		private void adaugaDisciplineToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			var adaugaDisciplinaForm=new AdaugaDisciplina();
			adaugaDisciplinaForm.ShowDialog();
		}

		private void editeazaDisciplineToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			EditeazaDisciplina editeazaDisciplinaForm = new EditeazaDisciplina();
			editeazaDisciplinaForm.ShowDialog();
		}

		private void stergeDisciplineToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			StergeDisciplina stergeDisciplinaForm = new StergeDisciplina();
			stergeDisciplinaForm.ShowDialog();
		}

		

		private void editeazaAnStudiiToolStripMenuItem2_Click(object sender, EventArgs e)
		{
			EditeazaAnStudiu editAnStudiuForm = new EditeazaAnStudiu();
			editAnStudiuForm.ShowDialog();
		}

		private void cautaNotaToolStripMenuItem_Click(object sender, EventArgs e)
		{
			CautaNota cautaNotaForm=new CautaNota();
			cautaNotaForm.ShowDialog();
		}

		private void restanteToolStripMenuItem_Click(object sender, EventArgs e)
		{Restanta restantaForm=new Restanta();
			restantaForm.ShowDialog();	

		}
	}
}
