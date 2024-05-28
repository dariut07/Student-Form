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
//ATENTIE:DATA NASTERII SE VA INTRODUCE DE FORMA:DD-MM-YYYY,NU DD.MM.YYYY


namespace proiectPaw
{
	public partial class AdaugaStudent : Form
	{
		private StudentRepo _studentRepo;
		public AdaugaStudent()
		{
			InitializeComponent();
			_studentRepo= new StudentRepo();
		}

		private void Savebutton_Click(object sender, EventArgs e)
		{
			try
			{
				// Validează intrările
				if (string.IsNullOrWhiteSpace(NumetextBox.Text) || !NumetextBox.Text.All(Char.IsLetter))
					throw new FormatException("Numele nu este valid");

				if (string.IsNullOrWhiteSpace(PrenumetextBox.Text) || !PrenumetextBox.Text.All(Char.IsLetter))
					throw new FormatException("Prenumele nu este valid");

				if (string.IsNullOrWhiteSpace(GentextBox.Text) || (GentextBox.Text.ToUpper() != "M" && GentextBox.Text.ToUpper() != "F"))
					throw new FormatException("Genul nu este valid");

				if (!DateTime.TryParseExact(DataNasteriitextBox.Text, "dd-MM-yyyy", null, System.Globalization.DateTimeStyles.None, out DateTime dataNasterii))
					throw new FormatException("Data nașterii nu este într-un format valid");


				if (!int.TryParse(AnStudiutextBox.Text, out int idAnStudiu) || (idAnStudiu < 1 || idAnStudiu > 3))
					throw new FormatException("Anul de studiu nu este valid");

				// Construit studentul
				var student = new Student
				{
					idStudent = _studentRepo.GetNextStudentId(),
					nume = NumetextBox.Text,
					prenume = PrenumetextBox.Text,
					dataNasterii = dataNasterii,
					gen = GentextBox.Text.ToUpper()[0],
					idAnStudiu = idAnStudiu
				};
				_studentRepo.AddStudent(student);

				MessageBox.Show("Studentul a fost adăugat cu succes", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

		private void Cancelbutton_Click(object sender, EventArgs e)
		{
			Close();
		}
	}
}
