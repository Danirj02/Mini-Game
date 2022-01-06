using System;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Usando o retorno de dados podemos fazer um questinario ou até uma conversa com respostas
              pré programadas!!! pode ser feito com if else tbm mais fiz com switch🍫 */
            Console.WriteLine("Olá escreva seu nome se quiser jogar!");
            string Nome = Console.ReadLine();
            Console.WriteLine("Então você é o " + Nome);
            Console.WriteLine("Escolha uma arma\nEspada, Marchado, Arco");
            string Arma = Console.ReadLine();
            switch (Arma)
            {
                case "Espada":
                    Console.WriteLine("Sua vida é de 50 força de 70");
                    break;
                case "Marchado":
                    Console.WriteLine("Sua vida é de 75 força de 50");
                    break;
                case "Arco":
                    Console.WriteLine("Sua vida é de 100 força de 35");
                    break;
                    default: 
                    Console.WriteLine("Não temos essa arma");
                    break;
            }
            Console.WriteLine("Então vc tem habilidades com\n" + Arma);
            Console.WriteLine("Vamos testar suas habilidades\nUm monstro apareceu o q vc quer fazer?");
            Console.WriteLine("Fugir, Atacar, Defender");
            string ação = Console.ReadLine();
            switch (ação)
            {
                case "Fugir":
                    Console.WriteLine("Você caiu e o monstro te matou\nGAME OVER");
                    break;
                        case "Atacar":
                    Console.WriteLine("Você matou o monstro\nWIN!");
                    break;
                case "Defender":
                    Console.WriteLine("Você sofreu 20 de dano!");
                    break;
            }
           string Movimento = Console.ReadLine();
            switch (Movimento)
            {
                case "Defender":
                    Console.WriteLine("E agora vc pode atacar!\n ataca e o mata\nWIN!");
                    break;
            }
            Console.WriteLine("Espero que tenha gostado");
        }
    }
}
