using System.Diagnostics;

// istanzo un oggetto
Prodotto iphone = new Prodotto("Iphone", "telefono molto costoso", 133333.33f);

Console.WriteLine("Codice Iphone : " + iphone.Codice);
Console.WriteLine("Prezzo Iphone : " +  iphone.Prezzo + " $");
Console.WriteLine("Prezzo Iphone ivato : " + iphone.GetPriceWithIva() + " $");
Console.WriteLine("Nome prodotto integrale : " + iphone.GetFullName());
Console.WriteLine("Codice pad left : " + iphone.GetPadLeftCodice());

public class Prodotto
{
    // creazione delle variabili
    public int Codice { get; private set; }
    public string Nome { get; set; }
    public string Descrizione { get; set; }
    public double Prezzo { get; set; }
    public int Iva { get; set; }

    // construttore
    public Prodotto(string nome, string descrizione, float prezzo)
    {
        Random rnd = new Random();
        Codice = rnd.Next(1, 10000);
        this.Nome = nome;
        this.Descrizione = descrizione;
        this.Prezzo = prezzo;
        Iva = 22;
    }
    
    // metodi

    public double GetPriceWithIva()
    {
        return (this.Prezzo * this.Iva) / 100;
    }

    public string GetFullName()
    {
        return this.Nome + this.Codice;
    }

    public string GetPadLeftCodice()
    {
        //funzione PadLeft di c#

        /*        
         * char pad = '0';
         * return codice.ToString().PadLeft(8, pad);
        */

        //funzione alternativa fatta a mano

        string codicePadLeft = Codice.ToString();

        for (int i = 0; codicePadLeft.Length < 8; i++)
        {
            codicePadLeft = "0" + codicePadLeft;
        }

        return codicePadLeft;
    }
}