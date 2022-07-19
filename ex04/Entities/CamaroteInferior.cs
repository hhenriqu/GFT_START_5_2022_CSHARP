namespace ex04
{
    public class CamaroteInferior : ClasseVIP
    {
        string endereco = "fileira 7";

        public void imprimeEndereco()
        {
            Console.WriteLine("O endereço é "+this.endereco);
        }
    }
}