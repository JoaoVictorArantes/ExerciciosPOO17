using ExerciciosPOO17.Entities;

namespace ExerciciosPOO17
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<TaxPayer> list = new List<TaxPayer>();

            int aux = 0;
            bool TaErrado = false;

            while (!TaErrado)
            {
                try
                {
                    Console.Write("Enter the number of tax payers: ");
                    aux = int.Parse(Console.ReadLine());
                }

                catch (FormatException e)
                {
                    TaErrado = false;

                    Console.WriteLine($"Você digitou um tipo de valor errado. :( \n{e.Message}");

                }
                catch (ArgumentNullException e)
                {
                    Console.WriteLine($"Você digitou um tipo de valor errado. :( \n{e.Message}");
                }
                finally
                {
                    if (!TaErrado)
                    {
                        Console.WriteLine("Aperte alguma tecla para tentar novamente.");

                        Console.ReadKey();

                        Console.Clear();
                    }

                    if (aux == 0 && TaErrado)
                    {
                        throw new FormatException();

                    }
                }

            }
            for (int i = 0; i < aux; i++)
            {
                String Name;
                double AnualIncome;
                double HealthExpenditures;
                char Situation = 'a';

                Console.WriteLine($"Tax payer #{i + 1} data:");



                while (!TaErrado)
                {
                    try
                    {
                        Console.Write("Individual or company (i/c)? ");
                        Situation = char.Parse(Console.ReadLine());

                    }
                    catch (FormatException e)
                    {
                        TaErrado = false;

                        Console.WriteLine($"Você digitou um tipo de valor errado. :( \n{e.Message}");

                    }
                    catch (ArgumentNullException e)
                    {
                        Console.WriteLine($"Você digitou um tipo de valor errado. :( \n{e.Message}");
                    }
                    finally
                    {
                        if (!TaErrado)
                        {
                            Console.WriteLine("Aperte alguma tecla para tentar novamente.");

                            Console.ReadKey();

                            Console.Clear();
                        }
                    }
                }
                if (Situation == 'i')
                {
                    while (!TaErrado)
                    {
                        try
                        {
                            Console.Write("Nome: ");
                            Name = Console.ReadLine();

                            Console.Write("Anual income: ");
                            AnualIncome = double.Parse(Console.ReadLine());

                            Console.Write("Health expenditures: ");
                            HealthExpenditures = double.Parse(Console.ReadLine());

                            list.Add(new Individual(Name, AnualIncome, HealthExpenditures));
                        }
                        catch (FormatException e)
                        {
                            TaErrado = false;

                            Console.WriteLine($"Você digitou um tipo de valor errado. :( \n{e.Message}");

                        }
                        catch (ArgumentNullException e)
                        {
                            Console.WriteLine($"Você digitou um tipo de valor errado. :( \n{e.Message}");
                        }
                        finally
                        {
                            if (!TaErrado)
                            {
                                Console.WriteLine("Aperte alguma tecla para tentar novamente.");

                                Console.ReadKey();

                                Console.Clear();
                            }
                        }
                    }
                }
                else if (Situation == 'c')
                {
                    while (!TaErrado)
                    {

                        try
                        {

                            Console.Write("Nome: ");
                            Name = Console.ReadLine();

                            Console.Write("Anual income: ");
                            AnualIncome = double.Parse(Console.ReadLine());

                            Console.Write("Number of employees: ");
                            int NumberOfEmployees = int.Parse(Console.ReadLine());

                            list.Add(new Company(Name, AnualIncome, NumberOfEmployees));

                        }
                        catch (FormatException e)
                        {
                            TaErrado = false;

                            Console.WriteLine($"Você digitou um tipo de valor errado. :( \n{e.Message}");

                        }
                        catch (ArgumentNullException e)
                        {
                            Console.WriteLine($"Você digitou um tipo de valor errado. :( \n{e.Message}");
                        }
                        finally
                        {
                            if (!TaErrado)
                            {
                                Console.WriteLine("Aperte alguma tecla para tentar novamente.");

                                Console.ReadKey();

                                Console.Clear();
                            }
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Digite uma opção válida! :)");
                }
            }

            Console.WriteLine("\nTax Paid:\n");

            double Ammount = 0;

            foreach (TaxPayer payer in list)
            {
                Console.WriteLine($"{payer.Name}: ${payer.Tax().ToString("F2")}");
                Ammount += payer.Tax();
            }

            Console.WriteLine($"\nTOTAL TAXES: {Ammount}");


            Console.ReadKey();
        }
    }
}
