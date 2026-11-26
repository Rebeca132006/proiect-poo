using System;

namespace exercitiu1;

public class Disciplina
{
   public string Nume{get;set;}
   public int Cod{get;set;}
   public Disciplina(string nume,int cod)
    {
        Nume=nume;
        Cod=cod;
    }
}
