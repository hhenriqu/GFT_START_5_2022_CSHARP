namespace ex04
{
    public class ClasseVIP : Ingresso
    {
        public ClasseVIP()
        {
            double adicional = 156.26;
            this.valor += adicional;
        }

        public override void imprimeValor()
        {
            Console.WriteLine(this.valor);
        }


    }
}