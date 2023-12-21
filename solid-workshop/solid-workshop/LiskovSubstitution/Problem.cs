namespace solid_workshop.LiskovSubstitution;

public class Principal
{
    public void Teste(Pato pato)
    {
        pato.Nadar();
    }
}


public class Pato
{
    public virtual void Nadar()
    {
        //
    }
}

public class PatoDeBrinquedo : Pato
{
    private bool temBateria;

    public override void Nadar()
    {
        if (temBateria)
        {
            //
        }
    }
}