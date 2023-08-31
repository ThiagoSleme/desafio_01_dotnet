

namespace DesafioFundamentos.Models
{
    public class Estacionamento
    {
        public decimal valorInicial { get; set; }
        public decimal valorPorHora { get; set; }
        public List<string> cadastroVeiculos = new();


        public Estacionamento(decimal valor, decimal procoHora)
        {
            this.valorInicial = valor;
            this.valorPorHora = procoHora;
        }

        public void AdicionaVeiculo()
        {
            Console.Clear();
            Console.WriteLine("Informe a placa do veiculo que irá estacionar !");
            string placa = Console.ReadLine()!.ToUpper();

            cadastroVeiculos.Add($"{placa}");
            Console.WriteLine("Veiculo registrado com sucesso! ");

            Thread.Sleep(2000);
            Console.Clear();
        }

        public void ListarVeiculos()
        {
            if (cadastroVeiculos.Any())
            {
                foreach (var item in cadastroVeiculos)
                {
                    Console.WriteLine($"Os veiculos listados são: Placa - {item}");
                }
            }
            else
            {
                Console.WriteLine("Nenhum veiculo cadastrado.");
            }
        }

        public void RemoverVeiculo()
        {
            Console.Clear();
            Console.WriteLine("Digite a placa do veículo para remover:");
            string placa = Console.ReadLine()!.ToUpper();

            if (cadastroVeiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            {
                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");

                int horasEstacionado = Convert.ToInt32(Console.ReadLine());

                decimal valorTotal = (valorPorHora * horasEstacionado) + valorInicial;

                cadastroVeiculos.Remove(placa);

                Console.WriteLine($"O veículo de Placa: {placa} foi removido e o preço total foi de: R$ {valorTotal.ToString("c")}");
            }
            else
            {
                Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
            }
        }

    }
}