using System;

namespace ex02
{
  class Program
  {
    static void Main()
    {
      Console.WriteLine("Prontos pra rolar o dado?");
      Console.WriteLine("Escolha sua Raça?");
      Console.WriteLine("1 - Anão");
      Console.WriteLine("2 - Elfo");
      Console.WriteLine("3 - Humano");

      int player = int.Parse(Console.ReadLine());

      switch (player)
      {
        case 1:
          Anao anao = new Anao();
          break;
        case 2:
          Elfo elfo = new Elfo();
          break;
        case 3:
          Humano humano = new Humano();
          break;
      }


      Console.WriteLine("Pegue seu D20 e role os atributos!");
      Console.WriteLine("Qual é o valor da Constituiçao?");
      anao = int.Parse(Console.ReadLine());
      Console.WriteLine("Qual é o valor da Força?");
      anao.setFor = int.Parse(Console.ReadLine());
      Console.WriteLine("Qual é o valor da Sabedoria?");
      anao.setSab = int.Parse(Console.ReadLine());
      Console.WriteLine("Qual é o valor da Destreza?");
      anao.setDes = int.Parse(Console.ReadLine());
      Console.WriteLine("Qual é o valor da Carisma?");
      anao.setCar = int.Parse(Console.ReadLine());
      Console.WriteLine("Qual é o valor da Inteligencia?");
      anao.setInt = int.Parse(Console.ReadLine());

      Console.WriteLine("Sua Raça e Atributos São:");
      Console.WriteLine("Sua Raça e Atributos São:");
    }

    }
  }
}