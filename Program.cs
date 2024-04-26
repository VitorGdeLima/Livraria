using System.Runtime.InteropServices;

namespace Livraria;
class Program
  //Alunos: Vitor Guilherme de Lima
{
static void Main()
{
Livro livro1 = new Livro("A Hora da Estrela", "Clarice Lispector", "9788556510761", 122);
LivroDigital livroDigital1 = new LivroDigital("A Hora da Estrela", "Clarice Lispector", "9788556510761", 475, "PDF");

livro1.AdicionarEstoque(69);
livro1.Vender(102);

livroDigital1.AdicionarEstoque(32);
livroDigital1.Vender(401);

livro1.ImprimirEstadoEstoque();
livroDigital1.ImprimirEstadoEstoque();
}
}
