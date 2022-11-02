Prodotto iphone = new Prodotto("a", "d", 13.33f, 22);

iphone.GetCodice();

public class Prodotto
{
    private int codice;
    public string nome;
    public string descrizione;
    private float prezzo;
    public int iva;

    public Prodotto(string nome, string descrizione, float prezzo, int iva)
    {
        Random rnd = new Random();
        codice = rnd.Next(1, 100000000);
        this.nome = nome;
        this.descrizione = descrizione;
        this.prezzo = prezzo;
        this.iva = iva;
    }

    public int GetCodice()
    {
        return this.codice;
    }

    public float GetPrice()
    {
        return this.prezzo;
    }

    public float GetPriceWithIva()
    {
        return (this.prezzo * this.iva) / 100;
    }
}