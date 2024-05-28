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
	public partial class EditeazaDisciplina : Form
	{
		private DisciplinaRepo _disciplinaRepo;
		private Disciplina _disciplina;

		public EditeazaDisciplina()
		{
			InitializeComponent();
			_disciplinaRepo = new DisciplinaRepo();
		}

		private void Okbutton_Click(object sender, EventArgs e)
		{
			try
			{
				if (!int.TryParse(IdDisciplinatextBox.Text, out int disciplinaId))
				{
					throw new FormatException("ID-ul disciplinei nu este valid");
				}

				_disciplina = _disciplinaRepo.FetchDisciplinaById(disciplinaId);

				if (_disciplina == null)
				{
					MessageBox.Show("Disciplina cu acest ID nu a fost găsită", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}

				EditDenumireDisciplinatextBox.Text = _disciplina.denumire;
				EditNumarCreditetextBox.Text = _disciplina.nrCredite.ToString();
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
				if (string.IsNullOrWhiteSpace(EditDenumireDisciplinatextBox.Text)|| !EditDenumireDisciplinatextBox.Text.All(c => char.IsLetter(c) || char.IsWhiteSpace(c)))
					throw new FormatException("Denumirea nu este validă");

				if (!int.TryParse(EditNumarCreditetextBox.Text, out int nrCredite) || nrCredite < 1)
					throw new FormatException("Numărul de credite nu este valid");

				_disciplina.denumire = EditDenumireDisciplinatextBox.Text;
				_disciplina.nrCredite = nrCredite;

				_disciplinaRepo.UpdateDisciplina(_disciplina);

				MessageBox.Show("Disciplina a fost actualizată cu succes", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
