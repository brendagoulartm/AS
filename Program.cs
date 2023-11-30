// Definição da classe principal do programa
class Program
{
    // Ponto de entrada do programa
    static void Main()
    {
        // Criação de uma instância da classe Biblioteca
        Biblioteca biblioteca = new Biblioteca();

        // Loop principal do programa, continuará até que o usuário escolha a opção "Sair"
        while (true)
        {
            // Exibe o menu de opções para o usuário
            Console.WriteLine("Menu:");
            Console.WriteLine("1. Adicionar Livro");
            Console.WriteLine("2. Buscar Livro por Título");
            Console.WriteLine("3. Remover Livro");
            Console.WriteLine("4. Sair");

            // Solicita que o usuário escolha uma opção
            Console.Write("Escolha uma opção: ");
            string opcao = Console.ReadLine();

            // Estrutura switch para lidar com diferentes opções do usuário
            switch (opcao)
            {
                // Caso 1: Chama o método para adicionar um novo livro à biblioteca
                case "1":
                    AdicionarLivro(biblioteca);
                    break;

                // Caso 2: Chama o método para buscar um livro por título na biblioteca
                case "2":
                    BuscarLivroPorTitulo(biblioteca);
                    break;

                // Caso 3: Chama o método para remover um livro da biblioteca
                case "3":
                    RemoverLivro(biblioteca);
                    break;

                // Caso 4: Encerra o programa
                case "4":
                    Environment.Exit(0);
                    break;

                // Caso padrão: Informa o usuário sobre uma opção inválida
                default:
                    Console.WriteLine("Opção inválida. Tente novamente.");
                    break;
            }
        }
    }

    // Método para adicionar um novo livro à biblioteca
    static void AdicionarLivro(Biblioteca biblioteca)
    {
        // Solicita informações sobre o novo livro ao usuário
        Console.Write("Digite o ID do livro: ");
        int id = int.Parse(Console.ReadLine());

        Console.Write("Digite o título do livro: ");
        string titulo = Console.ReadLine();

        Console.Write("Digite o autor do livro: ");
        string autor = Console.ReadLine();

        // Cria um novo objeto Livro e o adiciona à biblioteca
        Livro novoLivro = new Livro(id, titulo, autor);
        biblioteca.AdicionarItem(novoLivro);
    }

    // Método para buscar um livro por título na biblioteca
    static void BuscarLivroPorTitulo(Biblioteca biblioteca)
    {
        // Solicita ao usuário que digite o título do livro a ser buscado
        Console.Write("Digite o título do livro a ser buscado: ");
        string tituloBusca = Console.ReadLine();

        // Chama o método da biblioteca para buscar o livro por título
        Livro livroEncontrado = biblioteca.BuscarItemPorTitulo(tituloBusca);

        // Verifica se o livro foi encontrado e exibe informações
        if (livroEncontrado != null)
        {
            Console.WriteLine($"Livro encontrado: {livroEncontrado.Titulo} - Autor: {livroEncontrado.Autor}");
            livroEncontrado.ExibirDescricaoInterna();
        }
        else
        {
            Console.WriteLine("Livro não encontrado na biblioteca.");
        }
    }

    // Método para remover um livro da biblioteca
    static void RemoverLivro(Biblioteca biblioteca)
    {
        // Solicita ao usuário que digite o título do livro a ser removido
        Console.Write("Digite o título do livro a ser removido: ");
        string tituloRemocao = Console.ReadLine();

        // Chama o método da biblioteca para buscar o livro por título
        Livro livroParaRemover = biblioteca.BuscarItemPorTitulo(tituloRemocao);

        // Verifica se o livro foi encontrado e o remove da biblioteca
        if (livroParaRemover != null)
        {
            biblioteca.RemoverItem(livroParaRemover);
        }
        else
        {
            Console.WriteLine("Livro não encontrado na biblioteca.");
        }
    }
}
