using Oracle.ManagedDataAccess.Client;
using proiectPaw.Entities;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proiectPaw.Repositories
{
	public class AnStudiuRepo
	{public List<AnStudiu> AnStudiuFetchData()
		{
			var anList = new List<AnStudiu>();
			using (OracleConnection conn = new OracleConnection(Constante.ConnectionString))
			{
				conn.Open();
				string sql = "SELECT id_an_studiu,profesor_coordonator FROM ANI_STUDIU";
				using (OracleCommand cmd = new OracleCommand(sql, conn))
				{
					OracleDataReader dataReader = cmd.ExecuteReader();
					while (dataReader.Read())
					{
						AnStudiu anS = new AnStudiu();
						anS.idAnStudiu = int.Parse(dataReader["id_an_studiu"].ToString());
						anS.profCoordonator = dataReader["profesor_coordonator"].ToString();
						
						
						
						anList.Add(anS);
					}
				}
					conn.Close();
			}
				return anList;

		}
		public AnStudiu FetchAnStudiuById(int anStudiuId)
		{
			using (OracleConnection conn = new OracleConnection(Constante.ConnectionString))
			{
				conn.Open();
				string sql = "SELECT id_an_studiu, profesor_coordonator FROM Ani_Studiu WHERE id_an_studiu = :id_an_studiu";
				using (var command = new OracleCommand(sql, conn))
				{
					command.Parameters.Add("id_an_studiu", OracleDbType.Int32).Value = anStudiuId;

					using (OracleDataReader dataReader = command.ExecuteReader())
					{
						if (dataReader.Read())
						{
							return new AnStudiu
							{
								idAnStudiu = Convert.ToInt32(dataReader["id_an_studiu"]),
								profCoordonator = dataReader["profesor_coordonator"].ToString()
							};
						}
					}
				}
				conn.Close();
			}
			return null;
		}
		public void UpdateAnStudiu(AnStudiu anStudiu)
		{
			using (OracleConnection conn = new OracleConnection(Constante.ConnectionString))
			{
				conn.Open();

				string updateSql = @"
                    UPDATE Ani_Studiu
                    SET profesor_coordonator = :profesor_coordonator
                    WHERE id_an_studiu = :id_an_studiu";

				using (var command = new OracleCommand(updateSql, conn))
				{
					command.Parameters.Add("profesor_coordonator", OracleDbType.Varchar2).Value = anStudiu.profCoordonator;
					command.Parameters.Add("id_an_studiu", OracleDbType.Int32).Value = anStudiu.idAnStudiu;

					command.ExecuteNonQuery();
				}

				conn.Close();
			}
		}

		

	}
}
