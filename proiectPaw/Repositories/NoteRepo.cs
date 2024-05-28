using Oracle.ManagedDataAccess.Client;
using proiectPaw.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proiectPaw.Repositories
{
	public class NoteRepo
	{
		public int GetNota(int idStudent, int idDisciplina)
		{
			using (OracleConnection conn = new OracleConnection(Constante.ConnectionString))
			{
				conn.Open();

				string sql = "SELECT nota FROM note WHERE id_student = :id_student AND id_disciplina = :id_disciplina";

				using (var command = new OracleCommand(sql, conn))
				{
					command.Parameters.Add("id_student", OracleDbType.Int32).Value = idStudent;
					command.Parameters.Add("id_disciplina", OracleDbType.Int32).Value = idDisciplina;

					var result = command.ExecuteScalar();

					if (result != null && int.TryParse(result.ToString(), out int nota))
					{
						return nota;
					}
					else
					{
						return -1; // Nota nu a fost găsită
					}
				}
			}
		}
	}
}
