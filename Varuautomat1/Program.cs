namespace Varuautomat1
{
    internal class Program
    {
        static void Main(string[] args)
        {
           

            // här kommer valen för dom olika Produkterna
            Ponchos.ponchos.Add(new Ponchos("Ponchos", 25, "Regn ponchos"));
            Console.WriteLine(Ponchos.ponchos);

            Drickor.drickor.Add(new Drickor("fanta", 2, "Fanta Dryck"));
            Drickor.drickor.Add(new Drickor("pepsi", 2, "Pepsi Dryck"));
            Drickor.drickor.Add(new Drickor("7up", 2, "7up Dryck"));
            Console.WriteLine(Drickor.drickor);

            Chips.chips.Add(new Chips("grillchips", 3, "Chips med Grill smak"));
            Chips.chips.Add(new Chips("pringles", 3, "Chips i en burk"));
            Chips.chips.Add(new Chips("sourcreamchips", 3, "Chips med sourcream smak"));
            Console.WriteLine(Chips.chips);
            // här är mina attributer och variabler som används i programmet
            int saldo = 0;
            string köp;
            string köpPoncho;
            string köpDricka;
            string köpChips;
            

            bool Varuautomatenärigång = true;

            while (Varuautomatenärigång)
            {
                
                // här kommer jag att visa en meny för användaren så dom kan se vad som finns
                Console.WriteLine("  -------------------------------------------  ");
                Console.WriteLine(" --------------------------------------------- ");
                Console.WriteLine("-----------------------------------------------");
                Console.WriteLine("------------------- Meny ----------------------");
                Console.WriteLine("1: Var snäll och lägga in Pengar i automaten  :");
                Console.WriteLine("2: Här är våra Dryck alternativ               :");
                Console.WriteLine("3: Här är våra Chips alternativ               :");
                Console.WriteLine("4: Här är vår Poncho för regn                 :");
                Console.WriteLine("5: Avsluta                                    :");
                Console.WriteLine("-----------------------------------------------");
                Console.WriteLine(" --------------------------------------------- ");
                Console.WriteLine("  -------------------------------------------  ");
                Console.WriteLine("   -----------------------------------------   ");
                Console.WriteLine("Var vänligen använd knapparna 1, 2, 3, 4, 5 i dessa steg för att använda programmet");
                Console.WriteLine("var snäll skriv in den produkten du vill ha med små bokstäver");

                ConsoleKeyInfo info;
                info = Console.ReadKey();
                





                switch (info.Key)
                {
                    case ConsoleKey.D1:
                        Console.Clear();
                        Console.WriteLine("Var snäll och lägg i summan du behagar");
                        Console.WriteLine("Klicka Enter efter du har angett summan");
                        saldo += Convert.ToInt32(Console.ReadLine());



                        Console.WriteLine($"Saldo: {saldo}, drakmer");
                        break;

                    case ConsoleKey.D2:
                        Console.WriteLine("Här är Drickorna som finns tillgängliga");

                        foreach (Drickor i in Drickor.drickor)
                        {
                            Console.WriteLine($"Här finns alternativen {i.Namn}, {i.VaruBeskrivning} den kostar {i.Pris} Drakmer");

                        }

                        Console.WriteLine("Vill du köpa j/n");
                        köpDricka = Console.ReadLine();
                        if (köpDricka == "j")
                        {
                            Console.WriteLine("Vänligen välj Drickan du behagar");
                            
                            köp = Console.ReadLine();

                            foreach (Drickor drickor in Drickor.drickor)
                            {
                                if (drickor.Namn == köp && saldo >= drickor.Pris)
                                {
                                    Console.Clear();
                                    saldo -= drickor.Pris;
                                    Console.WriteLine($"vänligen vänta medans {köp} tas ut, den kostade {drickor.Pris} Drakmer");
                                    Console.WriteLine($"Du har nu {saldo} Drakmer kvarstående ");

                                    drickor.Using();
                                    drickor.Info();
                                    break;
                                }
                                else
                                {
                                    Console.Clear();
                                    Console.WriteLine("Du har lagt i en för liten summa drakmer, vänligen lägg i mer för att fortsätta");

                                }

                            }
                        }
                        break;

                    case ConsoleKey.D3:
                        Console.Clear();
                        Console.WriteLine("Här är Chipsen som finns tillgängliga");

                        foreach (Chips i in Chips.chips)
                        {
                            Console.WriteLine($"Du har valt {i.Namn}, {i.VaruBeskrivning} den kostar {i.Pris} Drakmer");

                        }

                        Console.WriteLine("Vill du köpa j/n");
                        köpChips = Console.ReadLine();
                        if (köpChips == "j")
                        {
                            Console.WriteLine("Vänligen välj Chipsen du behagar");
                            köp = Console.ReadLine();

                            foreach (Chips chips in Chips.chips)
                            {
                                if (chips.Namn == köp && saldo >= chips.Pris)
                                {
                                    saldo -= chips.Pris;
                                    Console.WriteLine($"vänligen vänta medans {köp} tas ut, det kostade {chips.Pris} Drakmer");
                                    Console.WriteLine($"Du har nu {saldo} Drakmer kvarstående ");

                                    chips.Using();
                                    chips.Info();
                                    break;
                                }
                                else
                                {
                                    Console.Clear();
                                    Console.WriteLine("Du har lagt i en för liten summa drakmer, vänligen lägg i mer för att fortsätta");

                                }

                            }
                        }
                        break;

                    case ConsoleKey.D4:
                        Console.Clear();
                        Console.WriteLine("Här är Ponchos som finns tillgängliga");

                        foreach (Ponchos i in Ponchos.ponchos)
                        {
                            Console.WriteLine($"Du har valt {i.Namn}, {i.VaruBeskrivning} den kostar {i.Pris} Drakmer");

                        }

                        Console.WriteLine("Vill du köpa j/n");
                        köpPoncho = Console.ReadLine();
                        if (köpPoncho == "j")
                        {
                            Console.WriteLine("Vänligen välj Ponchon du behagar");
                            köp = Console.ReadLine();

                            foreach (Ponchos ponchos in Ponchos.ponchos)
                            {
                                if (ponchos.Namn == köp && saldo >= ponchos.Pris)
                                {
                                    saldo -= ponchos.Pris;
                                    Console.WriteLine($"vänligen vänta medans {köp} tas ut, det kostade {ponchos.Pris} Drakmer");
                                    Console.WriteLine($"Du har nu {saldo} Drakmer kvarstående ");

                                    ponchos.Using();
                                    ponchos.Info();
                                    break;
                                }
                                else
                                {
                                    Console.Clear();
                                    Console.WriteLine("Du har lagt i en för liten summa drakmer, vänligen lägg i mer för att fortsätta");

                                }

                            }
                        }
                        break;


                    //Här räknas växeln ut

                    case ConsoleKey.D5:
                        Varuautomatenärigång = false;
                        Console.WriteLine($" Här är det värdes som skall returneras till dig {saldo} Drakmer");







                        break;







                }




            } 













        }
    }
}