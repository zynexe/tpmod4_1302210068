using System;
using System.Collections.Generic;

class KodePos
{
    private Dictionary<string, string> kodepos = new Dictionary<string, string>()
    {
        {"Batununggal", "40266"},
        {"A. Kujangsari", "40287"},
        {"Mengger", "40267"},
        {"Wates", "40256"},
        {"Cijaura", "40287"},
        {"Jatisari", "40286"},
        {"Margasari", "40286"},
        {"Sekejati", "40286"},
        {"Kebonwaru", "40272"},
        {"Maleer", "40274"},
        {"Samoja", "40277"}
    };

    public string getKodePos(string kelurahan)
    {
        if (kodepos.ContainsKey(kelurahan))
        {
            return kodepos[kelurahan];
        }
        else
        {
            return "Kode pos tidak ditemukan";
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        KodePos kodePos = new KodePos();
        Console.WriteLine("Kode Pos Kelurahan Batununggal: " + kodePos.getKodePos("Batununggal"));
    }
}
