
public class Fata
{
    public int Inaltime { get; set; }
    public string Nume { get; set; }

    public Fata(int inaltime, string nume)
    {
        Inaltime = inaltime;
        Nume = nume;
    }
}

public class Caine
{
    public int greuatate { get; set; }
    public string rasa { get; set; }

    public Caine(string rasa)
    {
        this.rasa = rasa;
    }

    public Caine(int greuatate, string rasa)
    {
        this.greuatate = greuatate;
        this.rasa = rasa;
    }
}

internal class Program
{ 
    private static void Main(string[] args)
    {
        Fata fetita1 = new Fata(164, "Ioana");
        Fata fetita2 = new Fata(135, "Irina");

        Caine catelul_meu = new Caine("Teckel");
        int greutate = catelul_meu.greuatate;
        Console.WriteLine(greutate);
        Caine cainele_tau = new Caine(30, "Husky");
        Console.WriteLine(cainele_tau.greuatate);
    }
}
