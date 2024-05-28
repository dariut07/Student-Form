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
	public partial class AdaugaDisciplina : Form
	{
		private DisciplinaRepo _disciplinaRepo;
		public AdaugaDisciplina()
		{
			InitializeComponent();
			_disciplinaRepo= new DisciplinaRepo();
		}

		private void SaveButton_Click(object sender, EventArgs e)
		{
			try
			{
				if (string.IsNullOrWhiteSpace(DenumireTextBox.Text) || !DenumireTextBox.Text.All(c => char.IsLetter(c) || char.IsWhiteSpace(c)))
					throw new FormatException("Denumirea nu este valida");

				if (!int.TryParse(CrediteTextBox.Text, out int nrCredite) || (nrCredite < 0 || nrCredite > 10))
					throw new FormatException("Numarul de credite este invalid");

				var disciplina = new Disciplina
				{
					idDisciplina = _disciplinaRepo.GetNextDisciplinaId(),
					denumire =DenumireTextBox.Text,
					nrCredite = nrCredite
				};
				_disciplinaRepo.AddDisciplina(disciplina);

				MessageBox.Show("Disciplina a fost adăugata cu succes", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
