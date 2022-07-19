using System;

namespace ex04
{
  class Program
  {
    static void Main()
    {
      Ingresso ticket = new Ingresso();
      ticket.imprimeValor();
      ClasseVIP ticketvip = new ClasseVIP();
      ticketvip.imprimeValor();
      IngressoNormal ticketnormal = new IngressoNormal();
      ticketnormal.imprimeIngressoNormal();
      CamaroteInferior ticketcamaroteinf = new CamaroteInferior();
      ticketcamaroteinf.imprimeEndereco();
      CamaroteSuperior ticketcamarotesuperior = new CamaroteSuperior();
      ticketcamarotesuperior.imprimeValor();
      ticketcamarotesuperior.imprimeEndereco();
    }
  }
}