using System;

//constrcutor masina
public class Masina
{
    public string Model { get; set; }
    public int An { get; set; }
    public double Pret { get; set; }
    public bool Inchiriata { get; set; } 

    public Masina(string model, int an, double pret)
    {
        Model = model;
        An = an;
        Pret = pret;
        Inchiriata = false; 
    }

    public override string ToString()
    {
        return $"{Model}, {An}, {Pret}";
    }
}
