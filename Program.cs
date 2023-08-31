using DesafioFundamentos.Models;


Console.WriteLine("Seja bem vindo ao sistema de estacionamento!\n" +
                  "Digite o preço para estacionar:");
decimal valor = Convert.ToDecimal(Console.ReadLine());


Console.WriteLine("Agora digite o preço adicional por hora:");
decimal preco = Convert.ToDecimal(Console.ReadLine());

Console.Clear();
Estacionamento veiculo = new(valor, preco);


bool menu = true;

while (menu)
{
    Console.WriteLine("Infoeme a opção desejada.");
    Console.WriteLine("1) Cadastrar veiculos.");
    Console.WriteLine("2) Listar veiculos.");
    Console.WriteLine("3) Remover veiculos");
    Console.WriteLine("4) Encerrar.");

    switch (Console.ReadLine())
    {
        case "1":
            veiculo.AdicionaVeiculo();
            break;

        case "2":
            veiculo.ListarVeiculos();
            break;
        case "3":
            veiculo.RemoverVeiculo();
            break;
        case "4":
            menu = false;
            break;
        default:
            Console.WriteLine("Opção invalida.");
            break;
    }

    Console.WriteLine("Precione uma tecla para continuar.");
    Console.ReadKey();
    Console.Clear();
}

Console.WriteLine("Sistema finalizado.");
