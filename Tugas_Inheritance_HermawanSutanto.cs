namespace Tugas_PBO_Pr
{
   
}

class Ban
{
    public string Merk;

    public Ban(string merk)
    {
        this.Merk = merk;
    }
}

class Michelin : Ban
{
    public Michelin() : base("michelin")
    {
    }
}
class Bridgestone : Ban
{
    public Bridgestone() : base("bridgestone")
    {
    }
}
class Mobil
{
    public string Merk;
    public string Tipe;
    public Ban ban;
    public Mobil(string merk, string tipe)
    {
        this.Merk = merk;
        this.Tipe = tipe;
    }
    public void NyalakanMesin()
    {
        Console.WriteLine($"mesin mobil {this.Merk} bertipe {this.Tipe} menyala");
    }
    public void MatikanMesin()
    {
        Console.WriteLine($"mesin mobil {this.Merk} bertipe {this.Tipe} mati");
    }
}
class Honda : Mobil
{
    public Honda(string tipe) : base("Honda", tipe)
    {
    }
}
class Brio : Honda
{
    public Brio() : base("Brio")
    {
    }
}
class Civic : Honda
{
    public Civic() : base("Civic")
    {
    }
    public void VtecKickedIn()
    {
        Console.WriteLine($"Ngeeeng Wooosh!!!");
    }
}

class Daihatsu : Mobil
{
    public Daihatsu(string tipe) : base("Daihatsu", tipe)
    {
    }
}
class Xenia : Daihatsu
{
    public Xenia() : base("Xenia")
    {
    }
}
class Ayla : Daihatsu
{
    public Ayla() : base("Ayla")
    {
    }
}

class Toyota : Mobil
{
    public Toyota(string tipe) : base("Toyota", tipe)
    {
    }
}
class Agya: Toyota
{
    public Agya() : base("Agya")
    {
    }
}
class Innova : Toyota
{
    public Innova() : base("Innova")
    {
    }
}
class Avanza : Toyota
{
    public Avanza() : base("Avanza")
    {
    }
    public void NyalakanLampu()
    {
        Console.WriteLine($"lampu mobil {this.Merk} bertipe {this.Tipe} menyala");
    }
}
internal class Program
{
    private static void Main(string[] args)
    {
        Mobil mobil1 = new Agya();
        mobil1.ban = new Michelin();
        mobil1.NyalakanMesin();
        mobil1.MatikanMesin();
        Mobil mobil2 = new Avanza();
        //Avanza avanza = new Avanza();
        //avanza.NyalakanLampu(); 
        mobil2.ban = new Bridgestone();
        Civic civic1 = new Civic();
        civic1.VtecKickedIn();
        civic1.ban = new Bridgestone();
    }
}
