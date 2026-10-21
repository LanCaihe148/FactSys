namespace FactSys.Domain;

public class Comprobante
{
    public string Version {get; set; } = "4.0";

    public string Serie {get; set; } 

    public string Folio {get; set;}

    public DateTime Fecha {get; set;}

    public string FormaPago {get; set;}

    public string NoCertificado {get; set;}

    public string SubTotal {get; set;}

    public string Moneda {get; set;} = "MXM";

    public string Total {get; set;}

    public string TipoDeComprobante {get; set;} = "I";

    public string Exportacion {get; set;} = "01";

    public string MetodoPago {get; set;}

    public string LugarExpedicion {get; set;}


    public Emisor Emisor {get; set;}
    public Receptor Receptor {get; set;}
    public List<Concepto> Conceptos {get; set;} = new();
}
