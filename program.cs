using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        int mes;
        int dia;
        string per;

        
        Console.WriteLine ("Olá! Seja bem-vindo a MIltom's Go a sua empresa de viagens aerea");
        Console.WriteLine("Digite o numero do mes que você deseja viajar: 8 Agosto, 9 Setembro, 10 Outubro");
        mes=Int32.Parse(Console.ReadLine());
        
        if(mes<8 || mes>10){
            Console.WriteLine("Mês inválido");
            Console.ReadLine();
            Console.Clear();
            Main(null);
            return;
        }
        
        Console.WriteLine("\nDigite o dia em que deseja viajar, dias disponiveis entre 6 e 21:");
        dia=Int32.Parse(Console.ReadLine());
        
        if(dia<6 || dia>21){
            Console.WriteLine("Dia inválido");
            Console.ReadLine();
            Console.Clear();
            Main(null);
            return;
        }
        
        Console.WriteLine("\nEm que periodo você deseja viajar: 'Manhã', 'Tarde' ou 'Noite'. Escreva da forma apresentada");
        per=Console.ReadLine();

        if(per!="Manhã" && per!="Tarde" && per!="Noite"){
            Console.WriteLine("Periodo inválido...");
            Console.ReadLine();
            Console.Clear();
            Main(null);
            return;
        }
        
        Console.WriteLine("\nPassagem comprada com sucesso");
        Console.WriteLine($"Passagem comprada no dia {dia} do mes {mes} no periodo da {per}");
        
        Console.ReadKey();
    }
}
