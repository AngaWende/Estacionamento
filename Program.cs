// See https://aka.ms/new-console-template for more information
using System.Diagnostics.CodeAnalysis;
using Estacionamento;


string menu = "Digite:\n1 - Cadastrar veículo\n2 - Remover veículo\n3 - Listar veículo\n4 - Sair\n";

System.Console.WriteLine("Digite o valor inicial: ");
decimal valorInicial = Convert.ToDecimal(Console.ReadLine());

System.Console.WriteLine("Digite o valor de cada hora: ");
decimal valorDeCadaHora = Convert.ToDecimal(Console.ReadLine());

string opcao = "";

Estacionamento.Estacionamento est = new Estacionamento.Estacionamento(valorInicial, valorDeCadaHora);

while(opcao != "4"){
    Console.Clear();
    System.Console.WriteLine(menu);
    opcao = Console.ReadLine();
    

    switch(opcao){
        case "1":
            est.AdicionarVeiculo();
            break;
        case "2":
            est.RemoverVeiculo();
            break;
        case "3":
            est.ListarVeiculos();
        break;
        case "4":
            System.Console.WriteLine("Finalizando.");
            Environment.Exit(0);
        break;
        default:
            System.Console.WriteLine("Opção inválida");
        break;
            
    }
    System.Console.WriteLine("\nPresione qualquer tecla para continuar...");
    Console.ReadLine();
}