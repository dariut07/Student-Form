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
	public partial class EditeazaStudent : Form
	{
		private StudentRepo _studentRepo;
		private Student _student;
		public EditeazaStudent()
		{
			InitializeComponent();
			_studentRepo = new StudentRepo();
		}

		private void OkButton_Click(object sender, EventArgs e)
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

				EditeazaNumeStudentTextBox.Text = _student.nume;
				EditeazaPrenumeTextBox.Text = _student.prenume;
				EditeazaDataNtextBox.Text = _student.dataNasterii.ToString("dd-MM-yyyy");
				EditeazaGenTextBox.Text = _student.gen.ToString();
				EditeazaAnStudiuTextBox.Text = _student.idAnStudiu.ToString();
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

		private void SaveButton_Click(object sender, EventArgs e)
		{
			try
			{
				if (string.IsNullOrWhiteSpace(EditeazaNumeStudentTextBox.Text) || !EditeazaNumeStudentTextBox.Text.All(char.IsLetter))
					throw new FormatException("Numele nu este valid");

				if (string.IsNullOrWhiteSpace(EditeazaPrenumeTextBox.Text) || !EditeazaPrenumeTextBox.Text.All(char.IsLetter))
					throw new FormatException("Prenumele nu este valid");

				if (string.IsNullOrWhiteSpace(EditeazaGenTextBox.Text) || (EditeazaGenTextBox.Text.ToUpper() != "M" && EditeazaGenTextBox.Text.ToUpper() != "F"))
					throw new FormatException("Genul nu este valid");

				if (!int.TryParse(EditeazaAnStudiuTextBox.Text, out int idAnStudiu) || (idAnStudiu < 1 || idAnStudiu > 3))
					throw new FormatException("ID-ul anului de studiu nu este valid");

				if (!DateTime.TryParseExact(EditeazaDataNtextBox.Text, "dd-MM-yyyy", null, System.Globalization.DateTimeStyles.None, out DateTime dataNasterii))
					throw new FormatException("Data nașterii nu este într-un format valid");

				_student.nume = EditeazaNumeStudentTextBox.Text;
				_student.prenume = EditeazaPrenumeTextBox.Text;
				_student.dataNasterii = dataNasterii;
				_student.gen = EditeazaGenTextBox.Text.ToUpper()[0];
				_student.idAnStudiu = idAnStudiu;

				_studentRepo.UpdateStudent(_student);

				MessageBox.Show("Studentul a fost actualizat cu succes", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
				Close();
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

		private void CancelButton_Click(object sender, EventArgs e)
		{
			Close();
		}
	}
}
