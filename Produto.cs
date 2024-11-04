using SQLite;
namespace MauiAppMinhasCompras.Models

public class Produto
{
	string _descricao;
	[PrimaryKey, AutoIncrement]
	public int Id { get; set; }
	public string Descricao
	{
		get => _descricao;
		set
		{
			if (value == null)
			{
				throw new exception("por favor, preencha a descrição");
			}
			Descricao = value;
		}
	}
}
		


	
	
