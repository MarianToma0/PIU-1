using System;
using System.Collections.Generic;
using System.IO;

public class ManagerMasini
{
    private static List<Masina> masiniDisponibile = new List<Masina>();
    //adaugarea masinilor in program(model,an,pret)
    public static void AdaugaMasina()
    {
        Console.WriteLine("Introduceti detalii despre masina:");
        Console.Write("Model: ");
        string model = Console.ReadLine();
        Console.Write("An: ");
        int an = int.Parse(Console.ReadLine());
        Console.Write("Pret: ");
        double pret = double.Parse(Console.ReadLine());

        Masina masina = new Masina(model, an, pret);
        masiniDisponibile.Add(masina);

        Console.WriteLine("Detalii despre masina adaugate cu succes.");
    }
    //Inchirierea lor
    public static void InchiriazaMasina()
    {
        AfiseazaMasini();
        Console.Write("Introduceti numarul masinii pe care doriti sa o inchiriati: ");
        int numarMasina = int.Parse(Console.ReadLine());

        if (numarMasina >= 0 && numarMasina < masiniDisponibile.Count)
        {
            Masina masinaSelectata = masiniDisponibile[numarMasina];
            if (!masinaSelectata.Inchiriata)
            {
                masinaSelectata.Inchiriata = true;
                Console.WriteLine("Masina a fost inchiriata cu succes.");
            }
            else
            {
                Console.WriteLine("Masina este deja inchiriată.");
            }
        }
        else
        {
            Console.WriteLine("Numarul masinii introdus nu este valid.");
        }
    }
    //returnarea lor
    public static void ReturneazaMasina()
    {
        AfiseazaMasini();
        Console.Write("Introduceti numarul masinii pe care doriti sa o returnati: ");
        int numarMasina = int.Parse(Console.ReadLine());

        if (numarMasina >= 0 && numarMasina < masiniDisponibile.Count)
        {
            Masina masinaSelectata = masiniDisponibile[numarMasina];
            if (masinaSelectata.Inchiriata)
            {
                masinaSelectata.Inchiriata = false;
                Console.WriteLine("Masina a fost returnata cu succes.");
            }
            else
            {
                Console.WriteLine("Masina nu este inchiriata.");
            }
        }
        else
        {
            Console.WriteLine("Numarul masinii introdus nu este valid.");
        }
    }
    //stock-ul de masini
    public static void AfiseazaMasini()
    {
        Console.WriteLine("Masini disponibile pentru inchiriere:");
        for (int i = 0; i < masiniDisponibile.Count; i++)
        {
            Console.WriteLine($"{i}. {masiniDisponibile[i]}");
        }
    }
    //eliminarea masinilor din program
    public static void EliminaMasina()
    {
        AfiseazaMasini();
        Console.Write("Introduceti numarul masinii pe care doriti sa o eliminati: ");
        int numarMasina = int.Parse(Console.ReadLine());

        if (numarMasina >= 0 && numarMasina < masiniDisponibile.Count)
        {
            masiniDisponibile.RemoveAt(numarMasina);
            Console.WriteLine("Masina a fost eliminata cu succes.");
        }
        else
        {
            Console.WriteLine("Numarul masinii introdus nu este valid.");
        }
    }
    //cauta masina dupa denumirea introdusa in partea de adaugare
    public static List<Masina> CautaMasinaDupaNume(string numeCautat)
    {
        List<Masina> rezultat = new List<Masina>();

        foreach (Masina masina in masiniDisponibile)
        {
            if (masina.Model.Equals(numeCautat, StringComparison.OrdinalIgnoreCase))
            {
                rezultat.Add(masina);
            }
        }

        return rezultat;
    }
    

    
}


