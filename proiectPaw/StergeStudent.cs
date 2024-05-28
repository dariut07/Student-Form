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
	public partial class StergeStudent : Form
	{
		private StudentRepo _studentRepo;
		public StergeStudent()
		{
			InitializeComponent();
			_studentRepo= new StudentRepo();
		}

		private void DeleteButton_Click(object sender, EventArgs e)
		{
			int idStudent;
			if (int.TryParse(StergeIdStudentTextBox.Text, out idStudent))
			{
				try
				{
					_studentRepo.DeleteStudentById(idStudent);
					MessageBox.Show("Studentul a fost șters cu succes!", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
				catch (Exception ex)
				{
					MessageBox.Show("A apărut o eroare: " + ex.Message, "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
			else
			{
				MessageBox.Show("ID-ul introdus este invalid.", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void CancelButton_Click(object sender, EventArgs e)
		{
			Close();
		}
	}
}
