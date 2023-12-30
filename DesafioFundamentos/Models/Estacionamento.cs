namespace DesafioFundamentos.Models
{
    public class Estacionamento
    {
        private decimal precoInicial = 0;
        private decimal precoPorHora = 0;
        private List<string> veiculos = new List<string>();

        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
        }

        public void AdicionarVeiculo()
        {
            //Recebendo placa do carro a ser adicionado do usuário
            Console.WriteLine("Digite a placa do veículo para estacionar:");
            string placaCarroAAdicionar = Console.ReadLine();
            //Adicionando o carro na lista de veículos através da placa
            veiculos.Add(placaCarroAAdicionar);
        }

        public void RemoverVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para remover:");
            // Pedindo a placa do carro a ser removido
            string placa = Console.ReadLine();

            // Verifica se o veículo existe
            if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            {
                 //Pedindo para o usuário digitar a quantidade de horas que o veículo permaneceu estacionado
                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");
                string horas = Console.ReadLine();
                //Realizando calculo do valor final             
                decimal valorTotal; 
                valorTotal = precoInicial + precoPorHora * Convert.ToDecimal(horas);

                //Removendo carro da lista de veículos através da placa
                veiculos.Remove(placa);
                Console.WriteLine($"O veículo {placa} foi removido e o preço total foi de: R$ {valorTotal}");
            }
            else
            {
                Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
            }
        }

        public void ListarVeiculos()
        {
            // Verifica se há veículos no estacionamento
            if (veiculos.Any())
            {
                Console.WriteLine("Os veículos estacionados são:");
                // exibindo os veículos estacionados armazenados na lista veiculos
                foreach(string carro in veiculos){
                    Console.WriteLine(carro);
                }
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }
    }
}
