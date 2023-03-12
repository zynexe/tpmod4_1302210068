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


class DoorMachine
{
    private State currentState;

    public DoorMachine()
    {
        currentState = new LockedState();
        Console.WriteLine("Pintu terkunci");
    }

    public void SetState(State state)
    {
        currentState = state;
        currentState.Display();
    }

    public void OpenDoor()
    {
        currentState.OpenDoor(this);
    }

    public void CloseDoor()
    {
        currentState.CloseDoor(this);
    }
}

abstract class State
{
    public abstract void OpenDoor(DoorMachine doorMachine);
    public abstract void CloseDoor(DoorMachine doorMachine);
    public abstract void Display();
}

class LockedState : State
{
    public override void OpenDoor(DoorMachine doorMachine)
    {
        Console.WriteLine("Pintu terkunci, tidak bisa dibuka");
    }

    public override void CloseDoor(DoorMachine doorMachine)
    {
        Console.WriteLine("Pintu sudah terkunci");
    }

    public override void Display()
    {
        Console.WriteLine("Pintu terkunci");
    }
}

class UnlockedState : State
{
    public override void OpenDoor(DoorMachine doorMachine)
    {
        Console.WriteLine("Pintu sudah terbuka");
        doorMachine.SetState(new LockedState());
    }

    public override void CloseDoor(DoorMachine doorMachine)
    {
        Console.WriteLine("Pintu sudah tertutup");
    }

    public override void Display()
    {
        Console.WriteLine("Pintu tidak terkunci");
    }
}

class Program
{
    static void Main(string[] args)
    {
        //1
        KodePos kodePos = new KodePos();
        Console.WriteLine("Kode Pos Kelurahan Batununggal: " + kodePos.getKodePos("Batununggal"));
        //2
        DoorMachine doorMachine = new DoorMachine();
        doorMachine.OpenDoor(); // mencoba membuka pintu saat terkunci
        doorMachine.SetState(new UnlockedState()); // membuka pintu
        doorMachine.CloseDoor(); // menutup pintu
    }
}
