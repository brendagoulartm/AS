// Classe Livro (Classe Derivada de ItemBiblioteca)
public class Livro : ItemBiblioteca
{
    // Propriedade adicional
    public string Autor { get; set; }

    // Construtor
    public Livro(int id, string titulo, string autor) : base(id, titulo)
    {
        Autor = autor;
    }

    // Método para exibir a DescricaoInterna
    public void ExibirDescricaoInterna()
    {
        Console.WriteLine($"Descrição Interna: {DescricaoInterna}");
    }
}
