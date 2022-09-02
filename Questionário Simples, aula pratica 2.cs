using System;

namespace hideki.aula.definir
{
    class Program
    {
        static void Main(string[] args)
        {
           
            //                 Variaveis
            string nome, telefone, email;

            //                Começo do código
            Console.WriteLine("Olá, tudo bem, poderia respnde nossa pesquisa? ");

            Console.WriteLine("Me diga seu nome? ");
            nome = Console.ReadLine();

            Console.WriteLine("Bacana,"+nome+" poderia me informar o seu email? ");
            email = Console.ReadLine();

            Console.WriteLine("Poderia me informar seu número de telefone? ");
            telefone = Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Seus dados são:\n Nome: " + nome +
                "\n E-mail: " + email +
                "\n Telefone: " + telefone +
                "\n Se seus dados estiverem corretos? " +
                "\n Digite S para sim e N para não.");
            confirmacao = Console.ReadLine();

            if (confirmacao == "S") {
                Console.WriteLine("Magnifico, terminamos nossa pesquisa.\n Origada por participar! ");
            }
            else
            {
                Console.WriteLine("Poxa, que pena. \n ");

            }


            Console.Clear();

            Console.ReadKey();
            //                                        Fim projeto 


        }
    }
}
