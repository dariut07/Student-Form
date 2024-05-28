using Oracle.ManagedDataAccess.Client;
using proiectPaw.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proiectPaw.Repositories
{
	public class StudentRepo
	{

		public List<Student> FetchAllStudents()
		{
			var studenti = new List<Student>();

			using (OracleConnection conn = new OracleConnection(Constante.ConnectionString))
			{
				conn.Open();

				string sql = $"SELECT id_student, nume, prenume,data_nasterii,gen,id_an_studiu FROM STUDENTI";
				using (OracleCommand command = new OracleCommand(sql, conn))
				{
					OracleDataReader dataReader = command.ExecuteReader();
					while (dataReader.Read())
					{
						var student = new Student();

						student.idStudent = int.Parse(dataReader["id_student"].ToString());
						student.nume = dataReader["nume"].ToString();
						student.prenume = dataReader["prenume"].ToString();
						student.dataNasterii = Convert.ToDateTime(dataReader["data_nasterii"]);
						student.gen = Convert.ToChar(dataReader["gen"]);
						student.idAnStudiu = int.Parse(dataReader["id_an_studiu"].ToString());


						studenti.Add(student);
					}
				}

				conn.Close();
			}

			return studenti;
		}


		public void DeleteStudentById(int studentId)
		{
			using (OracleConnection conn = new OracleConnection(Constante.ConnectionString))
			{
				conn.Open();

				
				string checkSql = "SELECT COUNT(*) FROM STUDENTI WHERE id_student = :id";
				using (var checkCommand = new OracleCommand(checkSql, conn))
				{
					checkCommand.Parameters.Add("id", OracleDbType.Int32).Value = studentId;
					int count = Convert.ToInt32(checkCommand.ExecuteScalar());
					if (count == 0)
					{
						throw new Exception("Studentul cu acest ID nu există.");
					}
				}

				
				string deleteSql = "DELETE FROM STUDENTI WHERE id_student = :id";
				using (var command = new OracleCommand(deleteSql, conn))
				{
					command.Parameters.Add("id", OracleDbType.Int32).Value = studentId;
					command.ExecuteNonQuery();
				}

				conn.Close();
			}
		}


		public void AddStudent(Student student)
		{
			using (OracleConnection conn = new OracleConnection(Constante.ConnectionString))
			{
				conn.Open();

				string insertSql = @"
                    INSERT INTO Studenti (id_student, nume, prenume, data_nasterii, gen, id_an_studiu) 
                    VALUES (:id_student, :nume, :prenume, TO_DATE(:data_nasterii, 'DD-MM-YYYY'), :gen, :id_an_studiu)";

				using (var command = new OracleCommand(insertSql, conn))
				{
					command.Parameters.Add("id_student", OracleDbType.Int32).Value = student.idStudent;
					command.Parameters.Add("nume", OracleDbType.Varchar2).Value = student.nume;
					command.Parameters.Add("prenume", OracleDbType.Varchar2).Value = student.prenume;
					command.Parameters.Add("data_nasterii", OracleDbType.Varchar2).Value = student.dataNasterii.ToString("dd-MM-yyyy");
					command.Parameters.Add("gen", OracleDbType.Char).Value = student.gen;
					command.Parameters.Add("id_an_studiu", OracleDbType.Int32).Value = student.idAnStudiu;

					command.ExecuteNonQuery();
				}

				conn.Close();
			}

		}


		public int GetNextStudentId()
		{
			int nextId = 1;

			using (OracleConnection conn = new OracleConnection(Constante.ConnectionString))
			{
				conn.Open();

				string sql = "SELECT MAX(id_student) FROM STUDENTI";
				using (var command = new OracleCommand(sql, conn))
				{
					var result = command.ExecuteScalar();
					if (result != DBNull.Value)
					{
						nextId = Convert.ToInt32(result) + 1;
					}
				}

				conn.Close();
			}

			return nextId;
		}


		public Student FetchStudentById(int studentId)
		{
			using (OracleConnection conn = new OracleConnection(Constante.ConnectionString))
			{
				conn.Open();
				string sql = "SELECT id_student, nume, prenume, data_nasterii, gen, id_an_studiu FROM STUDENTI WHERE id_student = :id";
				using (var command = new OracleCommand(sql, conn))
				{
					command.Parameters.Add("id", OracleDbType.Int32).Value = studentId;

					using (OracleDataReader dataReader = command.ExecuteReader())
					{
						if (dataReader.Read())
						{
							return new Student
							{
								idStudent = Convert.ToInt32(dataReader["id_student"]),
								nume = dataReader["nume"].ToString(),
								prenume = dataReader["prenume"].ToString(),
								dataNasterii = Convert.ToDateTime(dataReader["data_nasterii"]),
								gen = Convert.ToChar(dataReader["gen"]),
								idAnStudiu = Convert.ToInt32(dataReader["id_an_studiu"])
							};
						}
					}
				}
				conn.Close();
			}
			return null;
		}



		public void UpdateStudent(Student student)
		{
			using (OracleConnection conn = new OracleConnection(Constante.ConnectionString))
			{
				conn.Open();
				string updateSql = @"
            UPDATE STUDENTI
            SET nume = :nume, prenume = :prenume, data_nasterii = TO_DATE(:data_nasterii, 'DD-MM-YYYY'), 
                gen = :gen, id_an_studiu = :id_an_studiu
            WHERE id_student = :id_student";

				using (var command = new OracleCommand(updateSql, conn))
				{
					
					command.Parameters.Add("nume", OracleDbType.Varchar2).Value = student.nume;
					command.Parameters.Add("prenume", OracleDbType.Varchar2).Value = student.prenume;
					command.Parameters.Add("data_nasterii", OracleDbType.Date).Value = student.dataNasterii; 
					command.Parameters.Add("gen", OracleDbType.Char).Value = student.gen;
					command.Parameters.Add("id_an_studiu", OracleDbType.Int32).Value = student.idAnStudiu;
					command.Parameters.Add("id_student", OracleDbType.Int32).Value = student.idStudent;
					command.ExecuteNonQuery();
				}
				conn.Close();
			}
		}


	}

}
