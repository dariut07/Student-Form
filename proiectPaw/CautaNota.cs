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
//aici este o problema la comboBox:valoarea accesata din lista ramane acolo chiar daca introduc
//un nou id si dispare abia cand accesez combo box-ul pt noul id
namespace proiectPaw
{
	public partial class CautaNota : Form
	{
		private DisciplinaRepo _disciplinaRepo;
		private NoteRepo _noteRepo;
		private Student _student;
		private StudentRepo _studentRepo;

		public CautaNota()
		{
			InitializeComponent();
			_disciplinaRepo = new DisciplinaRepo();
			_noteRepo = new NoteRepo();
			_studentRepo = new StudentRepo();
		}
		private void OKbutton_Click(object sender, EventArgs e)
		{
			try
			{
				if (!int.TryParse(IdStudentTextBox.Text, out int studentId))
				{
					throw new FormatException("ID-ul studentului nu este valid");
				}
				_student = _studentRepo.FetchStudentById(studentId);

				if (_student == null)
				{
					MessageBox.Show("Studentul cu acest ID nu a fost găsit", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}

				List<Disciplina> discipline = _disciplinaRepo.getDisciplineByIdStudent(studentId);

				if (discipline.Count == 0)
				{
					MessageBox.Show("Studentul nu este înscris la nicio disciplină.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
					return;
				}

				DisciplineComboBox.Items.Clear();
				foreach (var disciplina in discipline)
				{
					DisciplineComboBox.Items.Add(disciplina.denumire);
				}
				DisciplineComboBox.Tag = discipline;
			}
			catch (FormatException ex)
			{
				MessageBox.Show(ex.Message, "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			catch (Exception ex)
			{
				MessageBox.Show("A apărut o eroare: " + ex.Message, "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void DisciplineComboBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (DisciplineComboBox.SelectedItem == null) return;

			string selectedDisciplina = DisciplineComboBox.SelectedItem.ToString();
			List<Disciplina> discipline = (List<Disciplina>)DisciplineComboBox.Tag;

			var disciplina = discipline.Find(d => d.denumire == selectedDisciplina);

			if (disciplina == null) return;

			int studentId = int.Parse(IdStudentTextBox.Text);

			int nota = _noteRepo.GetNota(studentId, disciplina.idDisciplina);

			if (nota!=-1)
			{
				MessageBox.Show($"Nota pentru disciplina {disciplina.denumire} este: {nota}", "Nota Student", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			else
			{
				MessageBox.Show($"Nu există notă pentru disciplina {disciplina.denumire}.", "Nota Student", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
		}
	}
}
