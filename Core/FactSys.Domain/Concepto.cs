namespace FactSys.Domain;

public class Concepto
{
    public string ClaveProdServ {get; set;}

    public string Cantidad {get; set;}

    public string ClaveUnidad {get; set;}

    public string Descripcion {get; set;}

    public string ValorUnitario {get; set;}

    public string Importe {get; set;}

    public string ObjetoImp {get; set;} = "02";
}
