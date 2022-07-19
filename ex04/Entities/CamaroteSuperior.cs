namespace ex04
{
  public class CamaroteSuperior : ClasseVIP
  {

    public CamaroteSuperior()
    {
      double adicional = 156.26;
      this.valor += adicional;
    }

    string endereco = "fileira 9 andar superior";

    public void imprimeEndereco()
    {
      Console.WriteLine("O endereço é " + this.endereco);
    }
  }
}