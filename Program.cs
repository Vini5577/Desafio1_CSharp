using System;

class DIO {
        
static void Main(string[] args){

        int n = int.Parse(Console.ReadLine());
        int p = 1, s = 0;
        while (n > 0){
             int l = n % 10;

            p *= l;
            s += l;
            n /= 10;

           }

        Console.WriteLine("Valor de p(produto):");
        Console.WriteLine(p);
        Console.WriteLine("Valor de s(soma): ");
        Console.WriteLine(s);
        Console.WriteLine(p-s);
    }
}