public class LivroDigital : Livro
{
    public string FormatoArquivo = "";

    public LivroDigital(string titulo, string _Autor, string isbn, int quantidadeEmEstoque, string formatoArquivo)
        : base(titulo, _Autor, isbn, quantidadeEmEstoque)
    {
        FormatoArquivo = formatoArquivo;
    }
}
