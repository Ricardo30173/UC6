using EstacionamentoConsole.Controllers;
using EstacionamentoConsole.Models;

using Microsoft.EntityFrameworkCore;

using Microsoft.Extensions.DependencyInjection;

using Microsoft.Extensions.Hosting;

var host = Host.CreateDefaultBuilder(args)

    .ConfigureServices((context, services) =>

    {

        services.AddDbContext<EstacionamentoDbContext>(opt =>

            opt.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=EstacionamentoDB;Trusted_Connection=True;TrustServerCertificate=True;"));

        services.AddTransient<ClienteController>();
    })

    .Build();

var clienteController = host.Services.GetRequiredService<ClienteController>();
bool sair = false;




while (!sair) 
{
    Console.Clear();
     
    Console.WriteLine("===== Sistema de Estacionamento =====");
    Console.WriteLine("1. Listar clientes ");
    Console.WriteLine("2. Adicionar cliente ");
    Console.WriteLine("3. (A FAZER) Gerenciar Veiculos ");
    Console.WriteLine("4. (A FAZER) Gerenciar vagas ");
    Console.WriteLine("5. (A FAZER) Ver detalhes do clientes ");
    Console.WriteLine("0. Sair");   

    string opcao = Console.ReadLine();
    Console.WriteLine($"Opção escolhida {opcao}");

    switch (opcao)
    {
        case "1":
            clienteController.ListarCliente();
            break;
        case "2":
            clienteController.AdicionarCliente();
            break;
        case "3":
            Console.WriteLine("Chamou o Gerenciar Veiculos");
            break;
        case "4":
            Console.WriteLine("Chamou o Gerenciar vagas");
            break;
        case "5":
           clienteController.VerDetalhesCliente();
            Console.ReadKey();
            break;
        case "0":
            sair = true;
            break;
        default:
            Console.Clear();
            Console.WriteLine("Opção inválida. Tente novamente.");
            Console.ReadKey();
                 break;
    }
}
Console.WriteLine("Encerrando o sistema. Até logo!");