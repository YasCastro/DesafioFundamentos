using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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
            string? placa = "";
            Console.WriteLine("Digite a placa do veículo para estacionar:");
            placa = Console.ReadLine();
            if(!String.IsNullOrWhiteSpace(placa)) veiculos.Add(placa.ToUpper());
        }
        public void RemoverVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para remover:");
            string? placa = Console.ReadLine();
            placa = String.IsNullOrWhiteSpace(placa) ? "" : placa;
            if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            {
                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");
                int tempoEstacionado = Convert.ToInt32(Console.ReadLine());
                decimal valorTotalPagar = precoInicial + tempoEstacionado * precoPorHora;
                veiculos.Remove(placa.ToUpper());
                Console.WriteLine($"O veículo {placa} foi removido e o preço total foi de: R$ {valorTotalPagar:0.00}");
            }
            else
            {
            Console.WriteLine("Desculpe, o veículo não está estacionado aqui. Confira se digitou a placa corretamente.");
            }

        }
        public void ListarVeiculos()
        {
            if(veiculos.Any()) 
            {
            Console.WriteLine("O veículos estacionados são:");
                foreach(string veiculo in veiculos)
                {
                    Console.WriteLine(veiculo);
                }
            }
            else 
            {
                Console.WriteLine("Não há veículos no estacionamento.");
            }
        }
    }
}