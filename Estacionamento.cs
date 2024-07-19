using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Estacionamento
{
    public class Estacionamento
    {
        private decimal valorInicial = 0;
        private decimal valorDeCadaHora = 0;
        private List<string> veiculos = new List<string>();

        public Estacionamento(decimal valorInicial, decimal valorDeCadaHora){
            this.valorInicial = valorInicial;
            this.valorDeCadaHora = valorDeCadaHora;

        }

        public void AdicionarVeiculo(){
            System.Console.WriteLine("Digite a placa do veículo");
            string placa = Console.ReadLine();
            Console.Clear();
            this.veiculos.Add(placa);
            System.Console.WriteLine($"Veiculo com a placa {placa} cadastrado");
        }

        public void RemoverVeiculo(){
            System.Console.WriteLine("Digite a placa do veículo a ser removido");
            string placa = Console.ReadLine();
            Console.Clear();
            if (this.veiculos.Contains(placa))
            {
                this.veiculos.Remove(placa);
                System.Console.WriteLine($"Veiculo com a placa {placa} removido");
                this.CalcularTotal();
            }else{
                System.Console.WriteLine($"Não foi encontrado veículo com a placa {placa}");
            }

        }

        public void ListarVeiculos(){
            if (this.veiculos.Count == 0)
            {
                System.Console.WriteLine("Nenhum veículo estacionado");
            }
            else
            {

                foreach (string v in veiculos)
                {
                    System.Console.WriteLine(v);
                }
            }
        }

        public void CalcularTotal(){
            System.Console.WriteLine("Quantas horas o veículo ficou no estacionamento?");
            int horas = Convert.ToInt16(Console.ReadLine());
            Console.Clear();
            decimal valorACobrar = (horas * this.valorDeCadaHora) + this.valorInicial;
            System.Console.WriteLine($"Valor a ser cobrado: {valorACobrar}");
        }





    }
}