// See https://aka.ms/new-console-template for more information

using System;

class Program 
{
    static void Main(string[] args)
    {
        HaloGeneric halo = new HaloGeneric();
        halo.SapaUser("Aufa Azzaky");  
        
        DataGeneric<string> dataNIM = new DataGeneric<string>("103022400029"); 
        dataNIM.PrintData();
    }
}