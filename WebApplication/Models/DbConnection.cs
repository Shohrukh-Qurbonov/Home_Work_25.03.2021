using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Data.SqlClient;
using Dapper;

namespace WebApplication.Models
{
    public abstract class DbConnection<T> : IDbReader<T>
    {
     
        public List<T> ReadAll()
        {
			try
			{
				using (IDbConnection db = new SqlConnection(ConString.connention))
				{
					return db.Query<T>($"SELECT * FROM {typeof(T).Name}").ToList();
				}
			}
			catch (Exception)
			{
				return null;
			}
        }
    }
}