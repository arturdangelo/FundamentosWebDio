using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentos
{
    public class Estacionamento
    {
        decimal precoInicial = 5.00M;
        decimal precoPorHora = 3.00M;
        List<string> veiculos = new List<string>();
        string placa = null;
        int horas = 0;

        public void AdicionarVeiculo()
        {
            Console.WriteLine("Informe a placa do veículo:");
            placa = Console.ReadLine();
            veiculos.Add(placa);
            Console.WriteLine();
        }

        public void RemoverVeiculo()
        {
            Console.WriteLine("Informe a placa do veículo para remover:");
            placa = Console.ReadLine();
            Console.WriteLine();

            string veiculoRemovido = veiculos.FirstOrDefault(x => x == placa);

            if (veiculoRemovido != null)
            {
                Console.WriteLine("Informe a quantidade de horas");
                horas = int.Parse(Console.ReadLine());
                Console.WriteLine($"Valor final: R$ {(precoInicial + (precoPorHora * horas))}");

                veiculos.Remove(veiculoRemovido);
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Veículo não encontrado.");
                Console.WriteLine();
            }
        }

        public void ListarVeiculos()
        {
            foreach (string v in veiculos)
            {
                Console.WriteLine(v);
            }
            Console.WriteLine();
        }
    }
}
