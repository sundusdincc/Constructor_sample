internal class Program
{
    private static void Main(string[] args)
    {
       Calısan user1 = new Calısan("Ali","Y",1,"IK");
      

        Calısan user2 = new Calısan("Deniz","Yıldız",3,"IT");

        Student ogr1=new Student();
        ogr1.Name1="Ayşe";
        ogr1.Surname1="Baş";
        ogr1.StudentId=456789;

        Console.WriteLine(ogr1.GetFullName());

        Calısan user3=new Calısan("Tuğba","Küt",5,"IK");
        Calısan user4=new Calısan("Kader","Tuna",6,"IT");
        Calısan user5=new Calısan("Beyza","Pir");
        Calısan user6=new Calısan("Derya","Yücel");
        Calısan user7=new Calısan(user5); 
        Calısan user8=new Calısan();
        
        user1.CalisanBilgileri();
        user2.CalisanBilgileri();
        user3.CalisanBilgileri();
        user4.CalisanBilgileri();
        user5.CalisanBilgileri();
        user6.CalisanBilgileri();
        user7.CalisanBilgileri();
        user8.CalisanBilgileri();

    }
}

class Calısan
{
    public string Ad;
    public string Soyad;
    public int No;
    public string Departman;

    public Calısan(){} //Default Constructor
    private Calısan(int no){} //Private Constructor
    public Calısan(string ad,string soyad,int no, string departman) //Parameterized Constructor
    {
        this.Ad=ad;
        this.Soyad=soyad;
        this.No=no;
        this.Departman=departman;

        int sum=0;
        sum++;
    }
    
    public Calısan(string ad,string soyad)
    {
        this.Ad=ad;
        this.Soyad=soyad;
    }

    public Calısan(Calısan s) //Copy Constructor
    {
        Ad = s.Ad;
        Soyad = s.Soyad;
    }



    public void CalisanBilgileri()
    {
        Console.WriteLine("\nÇalışan Adı: {0}",Ad);
        Console.WriteLine("Çalışan Soyadı: {0}",Soyad);
        Console.WriteLine("Çalışan No: {0}",No);
        Console.WriteLine("Çalışan Departmanı: {0}",Departman);
    }


}

class Student
{
    private int id;
    private string Name;
    private string Surname;

    public int StudentId { get { return id; } set { if (value > 0) id = value; } }
    public string Name1 { get => Name; set => Name = value; }
    public string Surname1 { get => Surname; set => Surname = value; }


    public string GetFullName()
    {
        return Name1 + " " + Surname1;
    }
}
