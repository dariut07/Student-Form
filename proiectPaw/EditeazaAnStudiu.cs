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
	public partial class EditeazaAnStudiu : Form
	{
		private AnStudiuRepo _anStudiuRepo;
		private AnStudiu _anStudiu;
		public EditeazaAnStudiu()
		{
			InitializeComponent();
			_anStudiuRepo= new AnStudiuRepo();
		}

		private void OKbutton_Click(object sender, EventArgs e)
		{
			int anStudiuId;
			if (int.TryParse(IdAnStudiuTextBox.Text, out anStudiuId))
			{
				_anStudiu = _anStudiuRepo.FetchAnStudiuById(anStudiuId);
				if (_anStudiu != null)
				{
					EditeazaProfCTextBox.Text = _anStudiu.profCoordonator;
				}
				else
				{
					MessageBox.Show("Anul de studiu cu acest ID nu a fost găsit", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
			else
			{
				MessageBox.Show("ID-ul introdus este invalid.", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void SaveButton_Click(object sender, EventArgs e)
		{
			if (_anStudiu != null)
			{
				_anStudiu.profCoordonator = EditeazaProfCTextBox.Text;

				try
				{
					if (string.IsNullOrWhiteSpace(EditeazaProfCTextBox.Text) || !EditeazaProfCTextBox.Text.All(c => char.IsLetter(c) || char.IsWhiteSpace(c)))
						throw new FormatException("Numele nu este valid.");
					_anStudiuRepo.UpdateAnStudiu(_anStudiu);
					MessageBox.Show("Anul de studiu a fost actualizat cu succes!", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
			
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
			else
			{
				MessageBox.Show("Nu există date de actualizat.", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void CancelButton_Click(object sender, EventArgs e)
		{
			Close();
		}
	}
}
