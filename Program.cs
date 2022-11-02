using System.Diagnostics;

// istanzo un oggetto
Prodotto iphone = new Prodotto("Iphone", "telefono molto costoso", 133333.33f);

Console.WriteLine("Codice Iphone : " + iphone.GetCodice());
Console.WriteLine("Prezzo Iphone : " +  iphone.GetPrice() + " $");
Console.WriteLine("Prezzo Iphone ivato : " + iphone.GetPriceWithIva() + " $");
Console.WriteLine("Nome prodotto integrale : " + iphone.GetFullName());
Console.WriteLine("Codice pad left : " + iphone.GetPadLeftCodice());

public class Prodotto
{
    // creazione delle variabili
    private int codice;
    public string nome;
    public string descrizione;
    private double prezzo;
    public int iva;

    // construttore
    public Prodotto(string nome, string descrizione, float prezzo)
    {
        Random rnd = new Random();
        codice = rnd.Next(1, 10000);
        this.nome = nome;
        this.descrizione = descrizione;
        this.prezzo = prezzo;
        iva = 22;
    }
    
    // metodi
    public int GetCodice()
    {
        return this.codice;
    }

    public double GetPrice()
    {
        return this.prezzo;
    }

    public void SetPrice(double prezzo)
    {
        this.prezzo = prezzo;
    }

    public double GetPriceWithIva()
    {
        return (this.prezzo * this.iva) / 100;
    }

    public string GetFullName()
    {
        return this.nome + this.codice;
    }

    public string GetPadLeftCodice()
    {
        //char pad = '0';

        //return codice.ToString().PadLeft(8, pad);

        //funzione alternativa fatta a mano

        string codicePadLeft = codice.ToString();

        for (int i = 0; codicePadLeft.Length < 8; i++)
        {
            codicePadLeft = "0" + codicePadLeft;
        }

        return codicePadLeft;
    }
}