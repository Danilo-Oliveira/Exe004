using System;

namespace ExeJoseInterface
{
    public class Player : IJogo, ITela
    {
        // Atributos
        public string Name { get; set; }
        public string Genero { get; set; }
        public string Origem { get; set; }


        // construtor
        public Player(){

        }

        public Player(string name, string genero, string origem){
            Name = name;
            Genero = genero;
            Origem = origem;
        }

        // Metodos Jogo
        void IJogo.Pular(){
            System.Console.WriteLine("Vamos Pular!!");
        }

        void IJogo.Atacar(){
            System.Console.WriteLine("Mata todo mundo!!");
        }

        void IJogo.Defender(){
            System.Console.WriteLine("Quem tem escudo ai!!");
        }

        void IJogo.ProcurarItem(){
            System.Console.WriteLine("Procurando...");
        }

        void IJogo.Descansar(){
            System.Console.WriteLine("Dormindo não me acorde...");
        }

        // Metodo Jogador

        void ITela.InformacaoJogador(){
            System.Console.Write("Informe seu nome, Jogador: ");
            string namePlayer = Console.ReadLine();

            System.Console.Write("Informe seu genêro, Jogador: ");
            string generoPlayer = Console.ReadLine();

            System.Console.Write("Informe sua Origem, Jogador: ");
            string origemPlayer = Console.ReadLine();

            IJogo player = new Player(namePlayer, generoPlayer, origemPlayer);

            System.Console.WriteLine();

            System.Console.Write("Por favor escolha uma Ação\nPular, Atacar, Defender, Procurar, Descansar\nQual é a sua Ação: ");

            string acao = Console.ReadLine();
            System.Console.WriteLine();

            switch (acao)
            {
                case "Pular":
                    IJogo pular = new Player();
                    System.Console.WriteLine(player);
                    pular.Pular();
                    break;
                case "Atacar":
                    IJogo atacar = new Player();
                    System.Console.WriteLine(player);
                    atacar.Atacar();
                    break;
                case "Defender":
                    IJogo defender = new Player();
                    System.Console.WriteLine(player);
                    defender.Defender();
                    break;
                case "Procurar":
                    IJogo procurar = new Player();
                    System.Console.WriteLine(player);
                    procurar.ProcurarItem();
                    break;
                case "Descansar":
                    IJogo descansar = new Player();
                    System.Console.WriteLine(player);
                    descansar.Defender();
                    break;
                default:
                    Console.WriteLine("Informação errada, volte e escolhar entre: \nPular, Atacar, Defender, Procurar, Descansar !!");
                    break;
            }
        }

        // Metodo Override

        public override string ToString(){
            return $"Suas informações.\nNome do Jogador: {Name}\nGenêro do Jogador: {Genero}\nOrigem do Jogador: {Origem}\n";
        }
    }
}