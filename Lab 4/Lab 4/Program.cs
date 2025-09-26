class Cricle
{
    public double RadiusCircle { get; set; }
    
    public Cricle (double radiuscircle)
    {
        RadiusCircle = radiuscircle;
    }
    //räknar ut area
    public double GetAreaCircle()
    {
        return RadiusCircle * RadiusCircle * Math.PI;
    }
    public double GetVolymCricle()
    {
        return 4.0 * Math.PI * Math.Pow(RadiusCircle, 3) / 3.0;
    }
    public double GetOmkretsCricle()
    {
        return 2.0 * Math.PI * RadiusCircle;
    }
}
class Triangle
{
    public double BaseTriangle { get; set; }
    public double HeightTriangle { get; set; }
    public double LängdTriangle { get; set; }
    public double Sida1 { get; set; }
    public double Sida2 { get; set; }
    public double Sida3 { get; set; }

    private Triangle() { }

    public static Triangle FromArea(double basetriangle, double heighttriangle )
    {
        return new Triangle { BaseTriangle = basetriangle, HeightTriangle = heighttriangle };
    }
    public static Triangle FromPrism(double längdtriangle, double basetriangle2, double heighttriangle2)
    {
        return new Triangle { LängdTriangle = längdtriangle, BaseTriangle = basetriangle2, HeightTriangle = heighttriangle2 };
    }

    public static Triangle FromSides(double sida1, double sida2, double sida3)
    {
        return new Triangle { Sida1 = sida1, Sida2 = sida2, Sida3 = sida3 };
    }
    public double GetAreaTriangle()
    {
        return BaseTriangle * HeightTriangle / 2.0;
    }

    public double GetVolymTriangle()
    {
        return GetAreaTriangle() * LängdTriangle;
    }

    public double GetOmkretsTriangle()
    {
        return Sida1 + Sida2 + Sida3;
    }
}
class Rektangle
{
    public double BaseRektangle { get; set; }
    public double HöjdRektangel { get; set; }
    public double BaseRektangle3 { get; set; }
    public double HöjdRektangel3 { get; set; }
    public double DjupRektangel { get; set; }

    private Rektangle() { }


    public static Rektangle FromArea(double baserektangle, double höjdregtangel)
    {
        return new Rektangle { BaseRektangle = baserektangle, HöjdRektangel = höjdregtangel };
    }
    public static Rektangle FromVolym(double djuprektangel, double baserektangle3, double höjdrektangel3)
    {
        return new Rektangle {DjupRektangel = djuprektangel, BaseRektangle3 = baserektangle3, HöjdRektangel3 = höjdrektangel3};
    }
    public double GetAreaRektangle()
    {
        return BaseRektangle * HöjdRektangel;
    }

    public double GetVolymRektangel()
    {
        return BaseRektangle3 * HöjdRektangel3 * DjupRektangel;
    }

    public double GetOmkretsRektangel()
    {
        return BaseRektangle * 2.0 + HöjdRektangel * 2.0;
    }

}

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("1. Cirkel");
            Console.WriteLine("2. Triangel");
            Console.WriteLine("3. Rektangel");
            Console.WriteLine("0. Avsluta");
            Console.WriteLine("Välj en siffra (0-3)");

            string input = Console.ReadLine();

            switch (input)
            {                
                case "1":
                    while (true)
                    {
                        Console.WriteLine("Vad vill du räkna ut?");
                        Console.WriteLine("1. Area");
                        Console.WriteLine("2. Volym (Klot)");
                        Console.WriteLine("3. Omkrets");
                        Console.WriteLine("0. Tillbaka");

                        string circleChoice = Console.ReadLine();

                        if (circleChoice == "0")
                        {
                            break;
                        }                        
                        switch (circleChoice)
                        {

                            case "1":
                                Console.WriteLine("Vad är radien på cirkeln?(cm): ");
                                if (!double.TryParse(Console.ReadLine(), out double radiuscircle))
                                {
                                    Console.WriteLine("Felaktig inmatning, försök igen!\n");
                                    continue; // börja om undermenyn
                                }
                                Cricle mycirclea = new Cricle(radiuscircle); //radius på circeln
                                Console.WriteLine($"Arean på cirkeln är: {mycirclea.GetAreaCircle()} cm\n");
                                break;

                            case "2":
                                Console.WriteLine("Vad är radien på cirkeln?(cm): ");
                                if (!double.TryParse(Console.ReadLine(), out double radiuscircle2))
                                {
                                    Console.WriteLine("Felaktig inmatning, försök igen!\n");
                                    continue; // börja om undermenyn
                                }
                                Cricle mycirclev = new Cricle(radiuscircle2);
                                Console.WriteLine($"Volymen på klotet är: {mycirclev.GetVolymCricle()} cm\n");
                                break;

                            case "3":
                                Console.WriteLine("Vad är radien på cirkeln?(cm): ");
                                if (!double.TryParse(Console.ReadLine(), out double radiuscircle3))
                                {
                                    Console.WriteLine("Felaktig inmatning, försök igen!\n");
                                    continue; // börja om undermenyn
                                }
                                Cricle mycircleo = new Cricle(radiuscircle3);
                                Console.WriteLine($"Omkretsen på cirkeln är: {mycircleo.GetOmkretsCricle()} cm\n");
                                break;

                            default:
                                Console.WriteLine("Felaktigt svar! Försök igen.\n");
                                break;
                        }
                    }
                    break;
                case "2":
                    while (true)
                    {
                        Console.WriteLine("Vad vill du räkna ut?");
                        Console.WriteLine("1. Area");
                        Console.WriteLine("2. Volym (prisma)");
                        Console.WriteLine("3. Omkrets");
                        Console.WriteLine("0. Tillbaka");

                        string triangleChoice = Console.ReadLine();

                        if (triangleChoice == "0")
                        {
                            break;
                        }

                        switch (triangleChoice)
                        {
                            case "1":
                                Console.WriteLine("Vad är basen?(cm): ");

                                if (!double.TryParse(Console.ReadLine(), out double basetriangle))
                                {
                                    Console.WriteLine("Felaktig inmatning, försök igen!\n");
                                    continue;
                                }

                                Console.WriteLine("Vad är höjden?(cm): ");
                                if (!double.TryParse(Console.ReadLine(), out double heighttriangle))
                                {
                                    Console.WriteLine("Felaktig inmatning, försök igen!\n");
                                    continue;
                                }

                                Triangle mytrianglea = Triangle.FromArea(basetriangle, heighttriangle);
                                Console.WriteLine($"Arean på Triangeln är: {mytrianglea.GetAreaTriangle()} cm\n");

                                break;
                            case "2":
                                Console.WriteLine("Vad är basen?(cm): ");
                                if (!double.TryParse(Console.ReadLine(), out double basetriangle2))
                                {
                                    Console.WriteLine("Felaktig inmatning, försök igen!\n");
                                    continue;
                                }
                                
                                Console.WriteLine("Vad är höjden?(cm): ");
                                if (!double.TryParse(Console.ReadLine(), out double heighttriangle2))
                                {
                                    Console.WriteLine("Felaktig inmatning, försök igen!\n");
                                    continue;
                                }

                                Console.WriteLine("Vad är längden?(cm): ");
                                if (!double.TryParse(Console.ReadLine(), out double längdtriangle))
                                {
                                    Console.WriteLine("Felaktig inmatning, försök igen!\n");
                                    continue;
                                }

                                Triangle mytrianglev = Triangle.FromPrism(basetriangle2, heighttriangle2, längdtriangle); //radius på circeln
                                Console.WriteLine($"Volymen på Prisman är: {mytrianglev.GetVolymTriangle()} cm\n");
                                break;

                            case "3":
                                Console.WriteLine("Vad är längden på sida A?(cm): ");
                                if (!double.TryParse(Console.ReadLine(), out double sida1))
                                {
                                    Console.WriteLine("Felaktig inmatning, försök igen!\n");
                                    continue;
                                }

                                Console.WriteLine("Vad är längden på sida B?(cm): ");
                                if (!double.TryParse(Console.ReadLine(), out double sida2))
                                {
                                    Console.WriteLine("Felaktig inmatning, försök igen!\n");
                                    continue;
                                }

                                Console.WriteLine("Vad är längden på sida C?(cm): ");
                                if (!double.TryParse(Console.ReadLine(), out double sida3))
                                {
                                    Console.WriteLine("Felaktig inmatning, försök igen!\n");
                                    continue;
                                }

                                Triangle mytriangleo = Triangle.FromSides(sida1, sida2, sida3); //radius på circeln
                                Console.WriteLine($"Omkretsen på Triangeln är: {mytriangleo.GetOmkretsTriangle()} cm\n");
                                break;

                            default:
                                Console.WriteLine("Felaktigt svar! Försök igen.\n");
                                return;
                        }
                    }
                    break;

                case "3":
                    while (true)
                    {
                        Console.WriteLine("Vad vill du räkna ut?");
                        Console.WriteLine("1. Area");
                        Console.WriteLine("2. Volym (Rektangel)");
                        Console.WriteLine("3. Omkrets");
                        Console.WriteLine("0. Tillbaka");

                        string rektangleChoice = Console.ReadLine();
                        if (rektangleChoice == "0")
                        {
                            break;
                        }

                        switch (rektangleChoice)
                        {
                            case "1":
                                Console.WriteLine("Vad är basen?(cm): ");
                                if (!double.TryParse(Console.ReadLine(), out double baserektangle))
                                {
                                    Console.WriteLine("Felaktig inmatning, försök igen!\n");
                                    continue;
                                }

                                Console.WriteLine("Vad är höjden?(cm): ");
                                if (!double.TryParse(Console.ReadLine(), out double höjdregtangel))
                                {
                                    Console.WriteLine("Felaktig inmatning, försök igen!\n");
                                    continue;
                                }

                                Rektangle myrektangle = Rektangle.FromArea(baserektangle, höjdregtangel);
                                Console.WriteLine($"Arean på rektageln är: {myrektangle.GetAreaRektangle()} cm\n");
                                break;
                            case "2":
                                Console.WriteLine("Vad är basen?(cm): ");
                                if (!double.TryParse(Console.ReadLine(), out double baserektangle3))
                                {
                                    Console.WriteLine("Felaktig inmatning, försök igen!\n");
                                    continue;
                                }

                                Console.WriteLine("Vad är höjden?(cm): ");
                                if (!double.TryParse(Console.ReadLine(), out double höjdregtangel3))
                                {
                                    Console.WriteLine("Felaktig inmatning, försök igen!\n");
                                    continue;
                                }
                                Console.WriteLine("Vad är djupet?(cm): ");
                                if (!double.TryParse(Console.ReadLine(), out double djuprektangel))
                                {
                                    Console.WriteLine("Felaktig inmatning, försök igen!\n");
                                    continue;
                                }

                                Rektangle myrektangle3 = Rektangle.FromVolym(baserektangle3, höjdregtangel3, djuprektangel);
                                Console.WriteLine($"Arean på rektageln är: {myrektangle3.GetVolymRektangel()} cm\n");
                                break;
                            case "3":
                                Console.WriteLine("Vad är basen?(cm): ");
                                if (!double.TryParse(Console.ReadLine(), out double baserektangle2))
                                {
                                    Console.WriteLine("Felaktig inmatning, försök igen!\n");
                                    continue;
                                }
                                Console.WriteLine("Vad är höjden?(cm): ");
                                if (!double.TryParse(Console.ReadLine(), out double höjdregtangel2))
                                {
                                    Console.WriteLine("Felaktig inmatning, försök igen!\n");
                                    continue;
                                }
                                Rektangle myrektangle2 = Rektangle.FromArea(baserektangle2, höjdregtangel2);
                                Console.WriteLine($"Omkretsen på rektageln är: {myrektangle2.GetOmkretsRektangel()} cm\n");
                                break;
                            default:
                                Console.WriteLine("Felaktigt svar! Försök igen.\n");
                                break;
                        }
                    }
                    break;
                case "0":
                    Console.WriteLine("Programmet avslutas.\n");
                    return;

                default:
                    Console.WriteLine("Felaktigt svar! Försök igen.\n");
                    break;
            }
        }       
    }
}