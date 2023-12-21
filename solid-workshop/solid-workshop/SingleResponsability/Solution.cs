namespace solid_workshop.SingleResponsability;
// Cada classe com uma responsabilidade

public class MensagemNova
{
    public int Id { get; set; }

    public string Tipo { get; set; }

    public int Remetente { get; set; }
}

public class Conversor
{
    public string ConvertePara(string formato)
    {
        if (formato == "json")
        {
            return @"{'json':'json'}";
        }
        else if (formato == "xml")
        {
            return @"<xml> </xml>";
        }
        else if (formato == "base64")
        {
            return @"31923891283912839";
        }

        throw new Exception("Formato não existe");
    }
}

