using System.Runtime.CompilerServices;

namespace DesafioFundamentos.Models
{
    public class Estacionamento
    {
        private decimal precoInicial = 0;
        private decimal precoPorHora = 0;

         public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
        }


        private List<string> veiculos = new List<string>();
      

        public void AdicionarVeiculo()
        {
            // Pedindo para o usuário digitar uma placa (ReadLine) e adicionar na lista "veiculos"
            Console.WriteLine("Digite a placa do veículo para estacionar:");
            string placa = Console.ReadLine();
            veiculos.Add(placa);
            
        }

        public void RemoverVeiculo()
        {
            if (veiculos.Any())
            {
                Console.WriteLine("Digite a placa do veículo para remover:");

                // Pedir para o usuário digitar a placa e armazenar na variável placa
                // *IMPLEMENTE AQUI*
                 string placa = Console.ReadLine();

                // Verifica se o veículo existe
                if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
                {
                    //declarando uma variavel do tipo TimeSpan.
                    TimeSpan horas = new TimeSpan();
                    decimal valorTotal = 0; 

                    // Pedir para o usuário digitar a quantidade de horas que o veículo permaneceu estacionado,
                    do
                    {
                        Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado: (formato 'HH:mm', exemplo: '02:30') ");

                               //enquanto não for possivel converter para *TimeSpan* e passar o valor digitado para a variavel *horas*, requisitar novamente o valor.  
                    }   while (!TimeSpan.TryParse(Console.ReadLine(), out horas));
                

                    
                    //declarando uma nova variavel do tipo decimal para converter o periodo de tempo estecionado em decimal, para tornar possivel realizar calculos com o valor.
                    decimal horasEmDecimal = (decimal) horas.TotalHours;
                    valorTotal = precoInicial + (precoPorHora * horasEmDecimal);
                
                    // removendo a placa digitada da lista de veículos
                    veiculos.Remove(placa);

                    //formatando o valorTotal para que apresente duas casas decimais depois da virgula.
                    string valorTotalFormatado = valorTotal.ToString("F2");
                    //apresentando valores ao usuario.
                    Console.WriteLine($"O veículo {placa} foi removido e o preço total foi de: R$ {valorTotalFormatado}");
                }
                else
                {   
                    Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
                }
                
            }

            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
            
        }

        public void ListarVeiculos()
        {
            // Verifica se há veículos no estacionamento
            if (veiculos.Any())
            {
                Console.WriteLine("Os veículos estacionados são:");
                // laço de repetição para exibir os veículos estacionados
                int contador = 0;
                foreach(string item in veiculos)
                {
                    Console.WriteLine(item);
                    contador++;
                }
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }
    }
}
