using LmbdLnq;
using System.Threading;
using LinqExceptions;
using System.Linq;
namespace System
{
    public class Tasks
    {

        
        public static void Runer()
        {
            string prompt = @"
____    __    ____  _______  __        ______   ______   .___  ___.  _______           _______   _______      ___      .______             __    __       _______. _______ .______      
\   \  /  \  /   / |   ____||  |      /      | /  __  \  |   \/   | |   ____|         |       \ |   ____|    /   \     |   _  \           |  |  |  |     /       ||   ____||   _  \     
 \   \/    \/   /  |  |__   |  |     |  ,----'|  |  |  | |  \  /  | |  |__            |  .--.  ||  |__      /  ^  \    |  |_)  |          |  |  |  |    |   (----`|  |__   |  |_)  |    
  \            /   |   __|  |  |     |  |     |  |  |  | |  |\/|  | |   __|           |  |  |  ||   __|    /  /_\  \   |      /           |  |  |  |     \   \    |   __|  |      /     
   \    /\    /    |  |____ |  `----.|  `----.|  `--'  | |  |  |  | |  |____          |  '--'  ||  |____  /  _____  \  |  |\  \----.      |  `--'  | .----)   |   |  |____ |  |\  \----.
    \__/  \__/     |_______||_______| \______| \______/  |__|  |__| |_______|         |_______/ |_______|/__/     \__\ | _| `._____|       \______/  |_______/    |_______|| _| `._____|
                                                                                                                                                                                        

";

            string[] options = {
                 "1) rhyta.com ve ya dayrep.com domenlerinde emaili olan borclulari cixartmag"
                ,"2) Yashi 26 - dan 36 - ya qeder olan borclulari cixartmag"
                ,"3) Borcu 5000 - den cox olmayan borclularic cixartmag"
                ,"4) Butov adi 18 simvoldan cox olan ve telefon nomresinde 2 ve ya 2 - den cox 7 reqemi olan borclulari cixartmaq"
                ,"5) Qishda anadan olan borclulari cixardmaq"
                ,"6) Borcu, umumi borclarin orta borcunnan cox olan borclulari cixarmaq ve evvel familyaya gore sonra ise meblegin azalmagina gore sortirovka etmek"
                ,"7) Telefon nomresinde 8 olmayan borclularin yalniz familyasin, yashin ve umumi borcun meblegin cixarmaq"
                ,"8) Adinda ve familyasinda hec olmasa 3 eyni herf olan borclularin siyahisin cixarmaq ve onlari elifba sirasina gore sortirovka elemek"
                ,"9)borclulardan en coxu hansi ilde dogulubsa hemin ili cixartmaq"
                ,"10)Borcu en boyuk olan 5 borclunun siyahisini cixartmaq"
                ,"11)Butun borcu olanlarin borcunu cemleyib umumi borcu cixartmaq"
                ,"12)2ci dunya muharibesin gormush borclularin siyahisi cixartmaq"
                ,"13)Nomresinde tekrar reqemler olmayan borclularin ve onlarin borcunun meblegin cixartmaq"
                ,"14)Tesevvur edek ki,butun borclari olanlar bugunden etibaren her ay 500 azn pul odeyecekler.Oz ad gunune kimi borcun oduyub qurtara bilenlerin siyahisin cixartmaq"
                ,"15)Adindaki ve familyasindaki herflerden \"smile\" sozunu yaza bileceyimiz borclularin siyahisini cixartmaq"
                ,"Go to Back"};
            Menu mainMenu = new Menu(prompt, options);
            mainMenu.Run();
            int selectedIndex = mainMenu.Run();

            switch (selectedIndex)
            {
                case 0:
                    m1();
                    break;
                case 1:
                    m2();
                    break;
                case 2:
                    m3();
                    break;
                case 3:
                    m4();
                    break;
                case 4:
                    m5();
                    break;
                case 5:
                    m6();
                    break;
                case 6:
                    m7();
                    break;
                case 7:
                    m8();
                    break;
                case 8:
                    m9();
                    break;
                case 9:
                    m10();
                    break;
                case 10:
                    m11();
                    break;
                case 11:
                    m12();
                    break;
                case 12:
                    m13();
                    break;
                case 13:
                    m14();
                    break;
                case 14:
                    m15();
                    break;
                case 15:
                    mainMenu.Run();
                    break;
                default:
                    break;
            }


             void m1()
            {
                ////////////////////////////////////////////////////////////////////////////////////////////////
                //1) rhyta.com ve ya dayrep.com domenlerinde emaili olan borclulari cixartmag
                ////////////////////////////////////////////////////////////////////////////////////////////////
                
                var debtors = DebtorContainer.GetDebtors();
                var debtorsByDomains = debtors
                    .Where(d =>
                    {
                        var domainAddress = d.Email.Split('@', ' ')[1];
                        if (domainAddress == "rhyta.com" || domainAddress == "dayrep.com")
                            return true;
                        return false;
                    })
                    .ToList();
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine(@"
                    /////////////////////////////////////////////////////////////////////////////////
                    //1) rhyta.com ve ya dayrep.com domenlerinde emaili olan borclulari cixartmag  //
                    ///////////////////////////////////////////////////////////////////////////////// ");
                Console.WriteLine("\n");
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                debtorsByDomains.ForEach(Console.WriteLine);
                Console.WriteLine(@" Do you want to go back or exit 
1 Go back
2 Exit");
                //int a  = Console.Read();
               // if (a == 0)
               // {
                   // PressBack();
               // }
                //else if (a == 2) System.Environment.Exit(0);
            }
            void m2()
            {
                ////////////////////////////////////////////////////////////////////////////////////////////////
                //2) Yashi 26 - dan 36 - ya qeder olan borclulari cixartmag
                ////////////////////////////////////////////////////////////////////////////////////////////////

                var debtors = DebtorContainer.GetDebtors();
                var debtorsByAge = debtors.Where(d =>
                {
                    var age = DateTime.Now.Year - d.BirthDay.Year;

                    if (age > 25 && age < 36)
                        return true;
                    return false;
                })
                    .ToList();
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine(@"
                    ///////////////////////////////////////////////////////////////
                    //2) Yashi 26 - dan 36 - ya qeder olan borclulari cixartmag //
                    /////////////////////////////////////////////////////////////");
                Console.WriteLine("\n");
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                debtorsByAge.ForEach(Console.WriteLine);
                //PressBack();
            }
            void m3()
            {
                ////////////////////////////////////////////////////////////////////////////////////////////////
                //3) Borcu 5000 - den cox olmayan borclularic cixartmag
                ////////////////////////////////////////////////////////////////////////////////////////////////

                var debtors = DebtorContainer.GetDebtors();
                var debtorsByDebt = debtors
                    .Where(d => d.Debt <= 5000)
                    .ToList();
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine(@"
                    //////////////////////////////////////////////////////////
                    //3) Borcu 5000 - den cox olmayan borclularic cixartmag//
                    ///////////////////////////////////////////////////////// ");
                Console.WriteLine("\n");
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                debtorsByDebt.ForEach(Console.WriteLine);
               // PressBack();
            }
          
            void m4()
            {
                ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                //4) Butov adi 18 simvoldan cox olan ve telefon nomresinde 2 ve ya 2 - den cox 7 reqemi olan borclulari cixartmaq
                ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                try
                {
                    var debtors = DebtorContainer.GetDebtors();
                var debtorsByNameLength = debtors
                    .Where(d =>
                    {
                        var counter = 0;
                        for (int i = 0; i < d.FullName.Length; i++)
                        {
                            if (!(d.FullName[i] == ' '))
                            {
                                counter++;
                            }
                        }
                        if (counter > 18) return true;
                        else
                        {
                            return false;
                        } })
                    .Where(d => d.Phone.Count(c => c == '7') >= 2)
                    .ToList();
            Console.Clear();
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine(@"
                    ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                    //4) Butov adi 18 simvoldan cox olan ve telefon nomresinde 2 ve ya 2 - den cox 7 reqemi olan borclulari cixartmaq//
                    /////////////////////////////////////////////////////////////////////////////////////////////////////////////////// ");
                    Console.WriteLine("\n");
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    debtorsByNameLength.ForEach(Console.WriteLine);
                    //PressBack();
                    if (debtorsByNameLength.Count == 0)
                    {
                        Console.BackgroundColor = ConsoleColor.Yellow;
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        throw new NUllData("\n\n This kind of sorting impossible... No data that follow this requirement ");
                    }

                }
                catch (NUllData ex)
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine(@"
                    ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                    //4) Butov adi 18 simvoldan cox olan ve telefon nomresinde 2 ve ya 2 - den cox 7 reqemi olan borclulari cixartmaq//
                    /////////////////////////////////////////////////////////////////////////////////////////////////////////////////// ");
                    Console.WriteLine("\n");
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    Console.WriteLine(ex.Message);
                  //  PressBack();
                }
               
            }
            void m5()
            {
                ////////////////////////////////////////////////////////////////////////////////////////////////
                //5) Qishda anadan olan borclulari cixardmaq
                ////////////////////////////////////////////////////////////////////////////////////////////////

                var debtors = DebtorContainer.GetDebtors();
                var onlyWinterDebtors = debtors
                    .Where(d => d.BirthDay.Month == 12 || d.BirthDay.Month == 1 || d.BirthDay.Month == 2)
                    .ToList();
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine(@"
                    //////////////////////////////////////////////
                    //5) Qishda anadan olan borclulari cixardmaq//
                    ////////////////////////////////////////////// ");
                Console.WriteLine("\n");
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                onlyWinterDebtors.ForEach(Console.WriteLine);
              //  PressBack();
            }
            void m6()
            {
                ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                //6) Borcu, umumi borclarin orta borcunnan cox olan borclulari cixarmaq ve evvel familyaya gore sonra ise meblegin azalmagina gore sortirovka etmek
                ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

                var debtors = DebtorContainer.GetDebtors();
                var averageDebt = debtors.Average(d => d.Debt);
                var debtorsHigherThanAvg = debtors.
                    Where(d => d.Debt > averageDebt)
                    .ToList();

                var debtorsSortedBySurname = debtorsHigherThanAvg.OrderBy(d =>
                {
                    var nameComponents = d.FullName.Split(' ');
                    return nameComponents[nameComponents.Length - 1];
                })
                    .ToList();
                Console.Clear();
                Console.WriteLine(@" 
                /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                //6) Borcu, umumi borclarin orta borcunnan cox olan borclulari cixarmaq ve evvel familyaya gore sonra ise meblegin azalmagina gore sortirovka etmek//
                /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////");
                Console.WriteLine("\n\n\n\n");      
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine($@"Avarage debt is : {averageDebt}");
                Console.WriteLine("\n\n\n\n");      
                debtorsSortedBySurname.ForEach(Console.WriteLine);
                Console.WriteLine("\n");
                var descDebtorsSortedByDebt = debtorsHigherThanAvg
                    .OrderByDescending(d => d.Debt)
                    .ToList();
                Console.ForegroundColor = ConsoleColor.DarkRed;
                debtorsSortedBySurname.ForEach(Console.WriteLine);
              //  PressBack();
            }
            void m7()
            {

                ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                //7) Telefon nomresinde 8 olmayan borclularin yalniz familyasin, yashin ve umumi borcun meblegin cixarmaq
                ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

                var debtors = DebtorContainer.GetDebtors();
                var debtors3 = debtors
                    .Where(d => !d.Phone.Contains('8'))
                    .ToList();

                debtors3.ForEach(d =>
                {
                    var nameComponents = d.FullName.Split(' ');
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine(@"
                    /////////////////////////////////////////////////////////////////////////////////////////////////////////////
                    //7) Telefon nomresinde 8 olmayan borclularin yalniz familyasin, yashin ve umumi borcun meblegin cixarmaq  //
                    ///////////////////////////////////////////////////////////////////////////////////////////////////////////// ");
                    Console.WriteLine("\n");
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    Console.WriteLine($"{nameComponents[nameComponents.Length - 1]} {DateTime.Now.Year - d.BirthDay.Year} {d.Phone} {d.Debt}");
                });
               // PressBack();
            }

            void m8()
            {

                ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                //8)Adinda ve familyasinda hec olmasa 3 eyni herf olan borclularin siyahisin cixarmaq ve onlari elifba sirasina gore sortirovka elemek
                ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

                var debtors = DebtorContainer.GetDebtors();
                var debtors4 = debtors
                    .Where(d => d.FullName.CheckOccurrence(3))
                    .OrderBy(d => d.FullName)
                    .ToList();
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine(@"
                    //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                    //8)Adinda ve familyasinda hec olmasa 3 eyni herf olan borclularin siyahisin cixarmaq ve onlari elifba sirasina gore sortirovka elemek  //
                    //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////");
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                debtors4.ForEach(Console.WriteLine);
             //   PressBack();
            }

            void m9()
            {
                ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                //9)borclulardan en coxu hansi ilde dogulubsa hemin ili cixartmaq
                ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////


                var debtors = DebtorContainer.GetDebtors();
                var years = debtors.Select(d => d.BirthDay.Year).ToList();
                var year = years.GetMostOccurrenceData();
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine(@"
                    ////////////////////////////////////////////////////////////////////
                    //9)borclulardan en coxu hansi ilde dogulubsa hemin ili cixartmaq //
                    ////////////////////////////////////////////////////////////////////");
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine(year);
             //   PressBack();
            }
            void m10()
            {    ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                 //10)Borcu en boyuk olan 5 borclunun siyahisini cixartmaq
                 ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////


                var debtors = DebtorContainer.GetDebtors();
                var firstFiveHigherDebtors = debtors
                    .OrderByDescending(d => d.Debt)
                    .Take(5)
                    .ToList();
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine(@"
                    ////////////////////////////////////////////////////////////////
                    //10)Borcu en boyuk olan 5 borclunun siyahisini cixartmaq     //
                    ////////////////////////////////////////////////////////////////");
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                firstFiveHigherDebtors.ForEach(Console.WriteLine);
            //    PressBack();
            }
            void m11()
            {  ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
               //11)Butun borcu olanlarin borcunu cemleyib umumi borcu cixartmaq
               ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

                var debtors = DebtorContainer.GetDebtors();
                var totalDebt = debtors.Sum(d => d.Debt);
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine(@"
                    ////////////////////////////////////////////////////////////////////
                    //11)Butun borcu olanlarin borcunu cemleyib umumi borcu cixartmaq //
                    ////////////////////////////////////////////////////////////////////");
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine(totalDebt);
             //   PressBack();
            }
            void m12()
            {
                ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                //12)2ci dunya muharibesin gormush borclularin siyahisi cixartmaq
                ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

                var debtors = DebtorContainer.GetDebtors();
                var debtorsBySecondWoW = debtors
                    .Where(d => d.BirthDay.Year >= 1939 &&
                                d.BirthDay.Year <= 1945)
                    .ToList();
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine(@"
                    ////////////////////////////////////////////////////////////////////
                    //12)2ci dunya muharibesin gormush borclularin siyahisi cixartmaq //
                    ////////////////////////////////////////////////////////////////////");
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                debtorsBySecondWoW.ForEach(Console.WriteLine);
            //    PressBack();
            }
            void m13()
            {
                ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                //13)Nomresinde tekrar reqemler olmayan borclularin ve onlarin borcunun meblegin cixartmaq
                ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

                var debtors = DebtorContainer.GetDebtors();
                var debtorsNum = debtors.Where(d =>
                {
                    for (var i = 0; i < d.Phone.Length; i++)
                    {
                        if (!char.IsDigit(d.Phone[i]))
                            continue;

                        if (d.Phone.Count(n => n == d.Phone[i]) != 1)
                            return false;
                    }
                    return true;
                }).ToList();
                debtorsNum.ForEach(d =>
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine(@"
                    /////////////////////////////////////////////////////////////////////////////////////////////
                    //13)Nomresinde tekrar reqemler olmayan borclularin ve onlarin borcunun meblegin cixartmaq //
                    /////////////////////////////////////////////////////////////////////////////////////////////");
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    Console.WriteLine($"{d.FullName} {d.Debt}");
                });
             //   PressBack();
            }

            void m14()
            {
                ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                //14)Tesevvur edek ki,butun borclari olanlar bugunden etibaren her ay 500 azn pul odeyecekler.Oz ad gunune kimi borcun oduyub qurtara bilenlerin siyahisin cixartmaq
                ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

                var debtors = DebtorContainer.GetDebtors();
                var oneYearDebt = 6000;
                Func<int, int, bool> payChecker = (debt, month) => debt - (month * 500) <= 0;
                var debtorsClean = debtors.Where(d =>
                {
                    if (d.Debt <= oneYearDebt)
                    {
                        var birthMonth = d.BirthDay.Month;
                        var nowMonth = DateTime.Now.Month;
                        if (birthMonth > nowMonth)
                        {
                            if (payChecker(d.Debt, (birthMonth - nowMonth)))
                                return true;
                        }
                        else
                        {
                            if (payChecker(d.Debt, ((12 + birthMonth) - nowMonth)))
                                return true;
                        }
                    }
                    return false;
                }).ToList();
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine(@"
                    ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                    //14)Tesevvur edek ki,butun borclari olanlar bugunden etibaren her ay 500 azn pul odeyecekler.Oz ad gunune kimi borcun oduyub qurtara bilenlerin siyahisin cixartmaq //
                    ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////");
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                debtorsClean.ForEach(Console.WriteLine);
              //  PressBack();
            }
            void m15()
            {
                ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                //15)Adindaki ve familyasindaki herflerden "smile" sozunu yaza bileceyimiz borclularin siyahisini cixartmaq
                ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

                var debtors = DebtorContainer.GetDebtors();
                var debtors7 = debtors.Where(d =>
                {
                    var fullname = d.FullName.ToLower();
                    foreach (var character in "smile")
                    {
                        if (!fullname.Contains(character))
                            return false;
                    }
                    return true;
                }).ToList();
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine(@"
                    //////////////////////////////////////////////////////////////////////////////////////////////////////////////
                    //15)Adindaki ve familyasindaki herflerden 'smile' sozunu yaza bileceyimiz borclularin siyahisini cixartmaq //
                    //////////////////////////////////////////////////////////////////////////////////////////////////////////////");
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                debtors7.ForEach(Console.WriteLine);
                //Console.ReadLine();
             //   PressBack();
            }

              void PressBack()
            {
                Console.WriteLine("\n");
                Console.WriteLine(" For going to back press Escape button on keyboard");
                ConsoleKey keyPressed;
                do
                {
                    Console.Clear();
                    ConsoleKeyInfo keyInfo = Console.ReadKey(true);
                    keyPressed = keyInfo.Key;

                    if (keyPressed == ConsoleKey.Escape)
                    {
                        mainMenu.Run();
                    }
                } while (keyPressed != ConsoleKey.Escape);
            }

        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string ToString()
        {
            return base.ToString();
        }
      
    }
}
