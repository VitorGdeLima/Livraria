using System.Security.Cryptography.X509Certificates;

public class Livro
{
	public string Titulo = "";
	public string Autor = "";
	public string ISBN = "";
	public int QuantidadeEmEstoque = 0;

	public Livro(string titulo, string autor ,string isbn, int quantidadeEmEstoque)
	{
		Autor = autor;
		Titulo = titulo;
		ISBN = isbn;
		QuantidadeEmEstoque = quantidadeEmEstoque;
	}

	public void AdicionarEstoque(int quantidade)
	{
		QuantidadeEmEstoque += quantidade;
	}

	public void Vender(int quantidade)
	{
		if (QuantidadeEmEstoque >= quantidade)
		{
			QuantidadeEmEstoque -= quantidade;
		}
		else
		{
			Console.WriteLine("Estoque insuficiente! ");
		}
	}

	public void ImprimirEstadoEstoque()
	{
		Console.WriteLine($"Livro: {Titulo}, Autor: {Autor}, ISBN: {ISBN}, Quantidade em Estoque: {QuantidadeEmEstoque}");
	}
}