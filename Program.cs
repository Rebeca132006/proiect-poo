using System;
using System.Collections.Generic;
namespace exercitiu1;

class Program
{
    static void Main(string[] args)
    {
        List<Student> listaStudenti = new List<Student>();
        bool ruleaza = true;

        while (ruleaza)
        {
            Console.WriteLine("\n--- MENU ---");
            Console.WriteLine("1. Adauga student");
            Console.WriteLine("2. Afiseaza toti studentii");
            Console.WriteLine("3. Iesire");
            Console.Write("Alege opțiunea: ");

            string optiune = Console.ReadLine()!;

            if (optiune == "1")
            {
                Console.Write("Prenume: ");
                string prenume = Console.ReadLine()!;

                Console.Write("Nume: ");
                string nume = Console.ReadLine()!;

                Console.Write("Numar matricol: ");
                string regNum = Console.ReadLine()!;

                Console.Write("An studiu: ");
                int.TryParse(Console.ReadLine(), out int an); // Conversie sigură conform cerinței

                Student st = new Student(prenume, nume, regNum, an);

                // Adăugăm o disciplină de probă
                Console.Write("Adaugă o disciplină (nume): ");
                string numeDisc = Console.ReadLine()!;
               Console.Write("Cod disciplină: ");
                int codDisc = int.Parse(Console.ReadLine()!); // Convertim textul în int
                st.Discipline.Add(new Disciplina(numeDisc, codDisc));

                listaStudenti.Add(st);
                Console.WriteLine("Student adăugat cu succes!");
            }
            else if (optiune == "2")
            {
                Console.WriteLine("\n--- LISTA STUDENTI ---");
                foreach (var s in listaStudenti)
                {
                    s.AfiseazaInfo();
                }
            }
            else if (optiune == "3")
            {
                ruleaza = false;
            }
        }
    }
}
            
        