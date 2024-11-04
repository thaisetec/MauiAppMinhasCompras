using MauiAppMinhasCompras.Models;
using SQLite;

namespace MauiAppMinhasCompras.Helpers
{

	public class SQLiteDatabaseHelper
	{
		readonly SQLiteDatabaseHelper
		public SQLiteDatabaseHelper(string path)

		{
			_conn = new SQLiteDatabaseHelper(string path);
			_conn.CreateTableAsync<Produto>().wait();

		}
	}
}
