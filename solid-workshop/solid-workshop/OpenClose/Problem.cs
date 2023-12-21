namespace solid_workshop.OpenClose;

    public class AplicacaoService
    {
        public void Integra()
        {
            new Integrador().IntegrarEmail();
        }
    }


public class Integrador
{
    public bool IntegrarEmail()
    {
        return true;
    }
}