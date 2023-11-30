public class Biblioteca
{
    private List<ItemBiblioteca> itensBiblioteca;

    // Construtor
    public Biblioteca()
    {
        itensBiblioteca = new List<ItemBiblioteca>();
    }

    // Método para adicionar item à biblioteca (sobrecarga)
    public void AdicionarItem(Livro livro)
    {
        itensBiblioteca.Add(livro);
        Console.WriteLine($"Livro '{livro.Titulo}' adicionado à biblioteca.");
    }

    // Método para remover item da biblioteca (sobrecarga)
    public void RemoverItem(Livro livro)
    {
        itensBiblioteca.Remove(livro);
        Console.WriteLine($"Livro '{livro.Titulo}' removido da biblioteca.");
    }

    // Método de busca por título (sobrecarga)
    public Livro BuscarItemPorTitulo(string titulo)
    {
        return itensBiblioteca.OfType<Livro>().FirstOrDefault(item => item.Titulo == titulo);
    }

    // Método de busca por ID (sobrecarga)
    public ItemBiblioteca BuscarItemPorId(int id)
    {
        return itensBiblioteca.FirstOrDefault(item => item.Id == id);
    }
}