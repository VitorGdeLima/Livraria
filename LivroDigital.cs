public class LivroDigital : Livro
{
    public string FormatoArquivo { get; set; }

    public LivroDigital(string titulo, string autor, string isbn, int quantidadeEmEstoque, string formatoArquivo)
        : base(titulo, autor, isbn, quantidadeEmEstoque)
    {
        FormatoArquivo = formatoArquivo;
    }
}
