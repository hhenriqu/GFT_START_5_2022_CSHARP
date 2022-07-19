namespace ex02
{
    public class Elfo : Raca
    {
    public void setConst(int value)
    {
      this.constituicao = constituicao;
    }
    public void setFor(int value)
    {
      this.forca = value;
    }
    public void setSab(int value)
    {
      this.sabedoria = value;
    }
    public void setDes(int value)
    {
      this.destreza = value + 2;
    }
    public void setCar(int value)
    {
      this.carisma = value + 2;
    }
    public void setInt(int value)
    {
      this.inteligencia = value + 2;
    }
    }
}