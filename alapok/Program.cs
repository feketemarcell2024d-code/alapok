Console.WriteLine("Kérem a tanulo nevét: ");
string TanuloNev = Console.ReadLine();
Console.WriteLine("Kérem a tanulo pontszamat: ");
int tanulopontszam = int.Parse(Console.ReadLine());
int maxpontszam = 97;
double szazalek = (double)tanulopontszam / maxpontszam * 100;
//szazalek = Math.Round(szazalek, 0);
Console.WriteLine($"A tanulo neve: {TanuloNev}");
Console.WriteLine($"Eredmény: @{tanulopontszam}/{maxpontszam} ({szazalek:F2}%)");
if (szazalek >= 50)
    Console.WriteLine("A tanulo eredménye: Sikeres");

else
    Console.WriteLine("A tanulo eredménye: Sikertelen!");