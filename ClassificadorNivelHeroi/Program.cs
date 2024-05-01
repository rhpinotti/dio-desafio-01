using Microsoft.VisualBasic;

namespace ClassificadorNivelHeroi;

class Program
{
    static Heroi? heroi;

    static void Main(string[] args)
    {
        try
        {
            Console.Clear();
            Console.WriteLine("Criação do herói");
            
            Console.Write("Nome do herói: ");
            var nome = Console.ReadLine();

            if (nome is null || nome.Trim().Length == 0)
            {
                Console.WriteLine("\tO nome não pode ser vazio, nomeado como QWDFR99.");
                nome = "QWDFR99";
            }

            Console.Write("Experiência inicial: ");
            if (!short.TryParse(Console.ReadLine(), out short experiencia))
            {
                Console.WriteLine("\tA experiência informada foi inválida, iniciando com 0 XP.");
                experiencia = 0;
            }

            CriarHeroi(nome, experiencia);

            bool encerrar = false;

            Console.WriteLine("Herói criado.");
            ExibirDadosHeroi();

            Console.WriteLine("\n--> pressione qualquer tecla para continuar ou q para sair.");
            if (Console.ReadKey().Key == ConsoleKey.Q)
                encerrar = true;

            while (!encerrar)
            {
                Console.Clear();
                
                Console.Write("Nova experiência: ");
                if (!short.TryParse(Console.ReadLine(), out short xp))
                {
                    Console.WriteLine("\tA experiência informada foi inválida, valor máximo de 32.767.\n\tZerando XP.");
                    xp = 0;
                }
                heroi?.AtualizarExperiencia(xp);
                
                ExibirDadosHeroi();

                Console.WriteLine("\n\n--> pressione qualquer tecla para continuar ou q para sair.");
                if (Console.ReadKey().Key == ConsoleKey.Q)
                    encerrar = true;
            }
        }
        catch
        {
            Console.WriteLine("Ops...Não foi possível criar o herói, execute novamente o programa.");
        }
    }

    static void CriarHeroi(string nome, short experiencia)
    {
        heroi = new Heroi(nome, experiencia);
    }

    static void ExibirDadosHeroi()
    {
        Console.WriteLine($"\nO Herói de nome **{heroi?.nome}** está no nível **{heroi?.ObterClasseHeroi()}**");
    }
}
