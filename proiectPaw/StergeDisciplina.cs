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
	public partial class StergeDisciplina : Form
	{
		private DisciplinaRepo _disciplinaRepo;
		public StergeDisciplina()
		{
			InitializeComponent();
			_disciplinaRepo = new DisciplinaRepo();

		}

		private void DeleteButton_Click(object sender, EventArgs e)
		{
			try
			{
				if (!int.TryParse(StergeDisciplinaTextBox.Text, out int disciplinaId))
				{
					throw new FormatException("ID-ul disciplinei nu este valid");
				}

				_disciplinaRepo.DeleteDisciplinaById(disciplinaId);

				MessageBox.Show("Disciplina a fost ștearsă cu succes", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
