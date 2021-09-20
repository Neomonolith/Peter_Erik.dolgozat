using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Peter_Erik.dolgozat
{
  class Program
  {

    static List<adatok> lista = new List<adatok>();
    static void Main(string[] args)
    {
     
      elsofeladat();
      masodikfeladat();
      harmadikfeladat();
      negyedikfeladat();
      otodikfeladat();
      hatodikfeladat();

      Console.ReadKey();
    }

    private static void hatodikfeladat()
    {
      
     
      foreach (var l in lista)
      {
        while (l.Ido.Month == 05)
        {
      Console.WriteLine("6. feladat: Májusban volt csatlakozás");
        }
       
       
      }


    }

    private static void otodikfeladat()
    {
      
      foreach (var l in lista)
      {
        if (l.Orszag.Contains("Magyarország"))
        {
          Console.WriteLine($"5. feladat: Magyarország csatlakozásának dátuma:   {l.Ido.Date}");
        }
      }
    }

    private static void negyedikfeladat()
    {
      int counter = 0;
      foreach (var l in lista)
      {
        if (l.Ido.Year == 2007)
        {
          counter++;
        }
      }
      Console.WriteLine($"4. feladat: 2007-ben {counter} ország csatlakozott.");
    
    
      }


    private static void harmadikfeladat()
    {
      Console.WriteLine($"3. feladat: EU tagállamainak száma: {lista.Count()}db");
    }

    private static void masodikfeladat()
    {
      Console.WriteLine("2. feladat: adatok beolvasása");
      StreamReader be = new StreamReader("EUcsatlakozas.txt");
      //Console.ReadLine();


      while (!be.EndOfStream)
      {

        string[] a = be.ReadLine().Split(';');

        lista.Add( new adatok((a[0]),DateTime.Parse(a[1])));

        
      }
      
      be.Close();
    }
    private static void elsofeladat()
    {
     //Néven mentés
    }
  }
}












