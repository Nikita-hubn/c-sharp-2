using System;

namespace app
{
    class Program
  {
    //  замена строки в текстовом файле.
    static bool ReplaceString(string str,string btr)
    {
      //  Проверка наличия файла.
      //if (!File.Exists(filename)) return false;

      //читка как массив
    StreamReader f=new StreamReader("D:/again nx/proba.txt");
    while(!f.EndOfStream){
        string s = f.ReadLine();
        string[] words = s.Split(' ');

        foreach (var word in words)
        {
            System.Console.WriteLine($"<{word}>");
        }
        string bava=words[1];
        int count=words.Length; 
        for(int i=0; i<words.Length; i++){
            if(words[i]==btr){
            words[i]=str;
            }
        }
      File.WriteAllLines("D:/again nx/proba.txt", words);
    }
    f.Close();
      //string[] arrays = File.ReadAllLines("D:/again nx/proba.txt");
      return true;
    
      //  Проверка позиции строки
      //if ((position < 0) || (position >= arrays.Length))
        //return false;
      //замена
      //arrays[position] = str;
      //  Записать массив строк в файл 
      
      //  Вернуть результат
      
    }

    static void Main(string[] args)
    {
      Console.WriteLine("Enter needed string:");
      string str = Console.ReadLine();
      Console.WriteLine("Enter removed string:");
      string btr  = Console.ReadLine();
      //int pos;
      //Console.WriteLine("Enter position:");
      //pos = Convert.ToInt32(Console.ReadLine());
      ReplaceString(str, btr);
      if (ReplaceString(str, btr))
        Console.WriteLine("Ok!");
      else
        Console.WriteLine("Error.");
    }
  }
}
