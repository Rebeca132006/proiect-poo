using System;

namespace exercitiu1;

public class Student
{
    public string Nume{get;set;}
    public string Prenume{get;set;}
    public string NumarMatricol{get;set;}
    public int AnStudiu{get;set;}
    public List<Disciplina>Discipline {get;set;}
    public Student(string nume,string prenume,string numarmatricol,int anstudiu )
    {
        Prenume=prenume;
        Nume=nume;
        AnStudiu=anstudiu;
        NumarMatricol=numarmatricol;
        Discipline= new List<Disciplina>();
    }
    public void AfiseazaInfo()
    {
        Console.WriteLine($"STUDENT:{Nume} {Prenume},Numar Matricol: {NumarMatricol} ,Anul de studiu: {AnStudiu}");
        Console.WriteLine("Discipline inscrise: ");
        foreach(var d in Discipline)
        {
            Console.WriteLine($"{d.Nume},{d.Cod}");
        }
    }

}
