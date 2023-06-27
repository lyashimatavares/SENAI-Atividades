using AtividadeCodificacao.Classes;

//váriavel para armazenar a opção digitada pelo usuário
string? opcao;

do
{
    //limpar o console
    Console.Clear();

    //menu de opções
    Console.Write(@"
    
    1 - Cadastrar PJ
    0 - Sair
    ");

    //variával opcao recebe a opção digitada
    opcao = Console.ReadLine();

    //instanciando um objeto para manipular os métodos de pessoa jurídica
    PessoaJuridica metodosPj = new PessoaJuridica();

    //estrutura condicional - if/else - comparação
    if (opcao == "1")
    {
        //instanciando um objeto de pessoa jurídica que receberá os valores das propriedades
        PessoaJuridica pj = new PessoaJuridica();

        //entrada do nome
        Console.WriteLine("Digite o nome da PJ: ");
        pj.Nome = Console.ReadLine();

        //entrada do rendimento
        Console.WriteLine("Informe o rendimento: ");
        pj.Rendimento = Console.ReadLine();

        //entrada do CNPJ
        Console.WriteLine("Informe um CNPJ válido (ex: XX.XXX.XXX/0001-XX): ");
        pj.Cnpj = Console.ReadLine();

        //chamada do método para inserir o objeto
        metodosPj.Inserir(pj);

        Console.WriteLine("Cadastro realizado com sucesso!");
        Console.WriteLine("Aperte ENTER para continuar");
        Console.ReadLine();
    } 
    else if(opcao == "0") {
        break;
    }
    else
    {
        Console.WriteLine("Opção inválida");
        Console.WriteLine("Aperte ENTER para continuar");
        Console.ReadLine();
        break;
    }

} while (opcao != "0");