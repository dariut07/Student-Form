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
	public partial class Restanta : Form
	{
		private Student _student;
		private StudentRepo _studentRepo;
		private DisciplinaRepo _disciplinaRepo;
		public Restanta()
		{
			InitializeComponent();
			_studentRepo = new StudentRepo();
			_disciplinaRepo= new DisciplinaRepo();

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
				List<Disciplina> restante = _disciplinaRepo.getRestante(studentId);

				if (restante.Count == 0)
				{
					MessageBox.Show("Studentul nu are restanțe", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
				else
				{
					StringBuilder restanteMessage = new StringBuilder("Studentul are restanțe la următoarele discipline:\n");
					foreach (var restanta in restante)
					{
						restanteMessage.AppendLine($"- {restanta.denumire}");
					}
					MessageBox.Show(restanteMessage.ToString(), "Restanțe", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
			}
			catch(FormatException ex)
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
