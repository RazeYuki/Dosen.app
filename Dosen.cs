namespace DosenMod;

public class Dosen
{
    private int ID = 1;
    private string name = "Dosen Pengampu";
    private int NIK = 123456789;
    private string Gender = "Male";
    private string matkul = "Pemrograman Berorientasi Object";


    public void attDosen(string nama, int nik)
    {
        name = nama;
        NIK = nik;
    }

    public void addCourse(string matkul)
    {
        this.matkul = $"{this.matkul}, {matkul}";
    }

    public void display()
    {
        Console.WriteLine();
        Console.WriteLine($"ID : {ID}");
        Console.WriteLine($"Name: {name}");
        Console.WriteLine($"NIK : {NIK}");
        Console.WriteLine($"Gender : {Gender}");
        Console.WriteLine($"Course : {matkul}");
    }
}