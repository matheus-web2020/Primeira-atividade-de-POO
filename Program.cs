using System;

namespace PrimeiraAtividadePOO
{
    class Program
    {
        static void Main(string[] args)
        {
            SuperMan fusca = new SuperMan();
            fusca.nome = "Matheus Fusca";
            fusca.traje = "1";
            
            Console.WriteLine(fusca.nome);

            Console.WriteLine(fusca.Defender());
            Console.WriteLine(fusca.super_força(10f, 56f));

            Console.WriteLine(fusca.Atacar());
            Console.WriteLine(fusca.laser(20f, 50f));

            Console.WriteLine(fusca.Melhorar());
            Console.WriteLine(fusca.invencibilidade(1010f, 357f));

            Console.WriteLine(fusca.Melhorar2());
        }
    }
}
