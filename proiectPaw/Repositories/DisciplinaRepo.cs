using Oracle.ManagedDataAccess.Client;
using proiectPaw.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proiectPaw.Repositories
{
	public class DisciplinaRepo
	{

		public List<Disciplina> DisciplinaFetchData()
		{
			var discipline = new List<Disciplina>();

			using (OracleConnection conn = new OracleConnection(Constante.ConnectionString))
			{
				conn.Open();
				string sql = "SELECT id_disciplina,nume_disciplina,numar_credite FROM DISCIPLINE ";

				using (OracleCommand cmd = new OracleCommand(sql, conn))
				{

					OracleDataReader dataReader = cmd.ExecuteReader();
					while (dataReader.Read())
					{
						Disciplina disciplina= new Disciplina();
						disciplina.idDisciplina = int.Parse(dataReader["id_disciplina"].ToString());
						disciplina.denumire = dataReader["nume_disciplina"].ToString();
						disciplina.nrCredite = int.Parse(dataReader["numar_credite"].ToString());

						

						

						discipline.Add(disciplina);
					}
				}

				conn.Close();
			}

			return discipline;
		}
		public void AddDisciplina(Disciplina disciplina)
		{
			using (OracleConnection conn = new OracleConnection(Constante.ConnectionString))
			{
				conn.Open();

				string insertSql = @"
            INSERT INTO Discipline (id_disciplina, nume_disciplina, numar_credite) 
            VALUES (:id_disciplina, :nume_disciplina, :numar_credite)";

				using (var command = new OracleCommand(insertSql, conn))
				{
					command.Parameters.Add("id_disciplina", OracleDbType.Int32).Value = disciplina.idDisciplina;
					command.Parameters.Add("nume_disciplina", OracleDbType.Varchar2).Value = disciplina.denumire;
					command.Parameters.Add("numar_credite", OracleDbType.Int32).Value = disciplina.nrCredite;

					command.ExecuteNonQuery();
				}

				conn.Close();
			}
		}
		public int GetNextDisciplinaId()
		{
			int nextId = 1;

			using (OracleConnection conn = new OracleConnection(Constante.ConnectionString))
			{
				conn.Open();

				string sql = "SELECT MAX(id_disciplina) FROM Discipline";
				using (var command = new OracleCommand(sql, conn))
				{
					var result = command.ExecuteScalar(); //returneaza prima valoare gasita
					if (result != DBNull.Value)
					{
						nextId = Convert.ToInt32(result) + 1;
					}
				}

				conn.Close();
			}

			return nextId;
		}
		public void UpdateDisciplina(Disciplina disciplina)
		{
			using (OracleConnection conn = new OracleConnection(Constante.ConnectionString))
			{
				conn.Open();
				string updateSql = @"
                UPDATE Discipline
                SET nume_disciplina = :nume_disciplina, numar_credite = :numar_credite
                WHERE id_disciplina = :id_disciplina";

				using (var command = new OracleCommand(updateSql, conn))
				{
					command.Parameters.Add("nume_disciplina", OracleDbType.Varchar2).Value = disciplina.denumire;
					command.Parameters.Add("numar_credite", OracleDbType.Int32).Value = disciplina.nrCredite;
					command.Parameters.Add("id_disciplina", OracleDbType.Int32).Value = disciplina.idDisciplina;
					
	

					command.ExecuteNonQuery(); //se foloseste pentru a executa comenzi care nu returneaza niciun query
				}
				conn.Close();
			}
		}
		public Disciplina FetchDisciplinaById(int disciplinaId)
		{
			using (OracleConnection conn = new OracleConnection(Constante.ConnectionString))
			{
				conn.Open();
				string sql = "SELECT id_disciplina, nume_disciplina, numar_credite FROM Discipline WHERE id_disciplina = :id";
				using (var command = new OracleCommand(sql, conn))
				{
					command.Parameters.Add("id", OracleDbType.Int32).Value = disciplinaId;

					using (OracleDataReader dataReader = command.ExecuteReader())
					{
						if (dataReader.Read())
						{
							return new Disciplina
							{
								idDisciplina = Convert.ToInt32(dataReader["id_disciplina"]),
								denumire = dataReader["nume_disciplina"].ToString(),
								nrCredite = Convert.ToInt32(dataReader["numar_credite"])
							};
						}
					}
				}
				conn.Close();
			}
			return null;
		}
		public void DeleteDisciplinaById(int disciplinaId)
		{
			using (OracleConnection conn = new OracleConnection(Constante.ConnectionString))
			{
				conn.Open();
				string checkSql = "SELECT COUNT(*) FROM DISCIPLINE WHERE id_disciplina = :id";
				using (var checkCommand = new OracleCommand(checkSql, conn))
				{
					checkCommand.Parameters.Add("id", OracleDbType.Int32).Value = disciplinaId;
					int count = Convert.ToInt32(checkCommand.ExecuteScalar());
					if (count == 0)
					{
						throw new Exception("Disciplina cu acest ID nu există.");
					}
				}

				string deleteSql = "DELETE FROM Discipline WHERE id_disciplina = :id_disciplina";
				using (var command = new OracleCommand(deleteSql, conn))
				{
					command.Parameters.Add("id_disciplina", OracleDbType.Int32).Value = disciplinaId;
					command.ExecuteNonQuery();
				}


				conn.Close();
			}

		}
		public List<Disciplina> getRestante(int idStudent)
		{
			List<Disciplina> restante = new List<Disciplina>();
			using (OracleConnection conn = new OracleConnection(Constante.ConnectionString))
			{
				conn.Open();
				string sql = $"SELECT n.id_disciplina,d.nume_disciplina, d.numar_credite FROM NOTE n,DISCIPLINE d WHERE n.ID_DISCIPLINA=d.ID_DISCIPLINA" +
					$" AND n.id_student=:id AND n.nota<5 AND n.nota>0";
				using (OracleCommand command = new OracleCommand(sql, conn))
				{
					command.Parameters.Add("id", OracleDbType.Int32).Value = idStudent;
					OracleDataReader dataReader = command.ExecuteReader();
					while (dataReader.Read())
					{
						var restanta = new Disciplina();

						restanta.idDisciplina = Convert.ToInt32(dataReader["id_disciplina"]);
						restanta.denumire = dataReader["nume_disciplina"].ToString();
						restanta.nrCredite = Convert.ToInt32(dataReader["numar_credite"]);


						restante.Add(restanta);
					}
				}
				conn.Close();

			}
				return restante;
		}
		public List<Disciplina> getDisciplineByIdStudent(int idStudent)
		{
			List<Disciplina> restante = new List<Disciplina>();
			using (OracleConnection conn = new OracleConnection(Constante.ConnectionString))
			{
				conn.Open();
				string sql = $"SELECT n.id_disciplina,d.nume_disciplina, d.numar_credite FROM NOTE n,DISCIPLINE d WHERE n.ID_DISCIPLINA=d.ID_DISCIPLINA" +
					$" AND n.id_student=:id";
				using (OracleCommand command = new OracleCommand(sql, conn))
				{
					command.Parameters.Add("id", OracleDbType.Int32).Value = idStudent;
					OracleDataReader dataReader = command.ExecuteReader();
					while (dataReader.Read())
					{
						var restanta = new Disciplina();

						restanta.idDisciplina = Convert.ToInt32(dataReader["id_disciplina"]);
						restanta.denumire = dataReader["nume_disciplina"].ToString();
						restanta.nrCredite = Convert.ToInt32(dataReader["numar_credite"]);


						restante.Add(restanta);
					}
				}
				conn.Close();

			}
			return restante;
		}


	}
}
