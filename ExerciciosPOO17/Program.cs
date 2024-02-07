using ExerciciosPOO17.Entities;

namespace ExerciciosPOO17
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<TaxPayer> list = new List<TaxPayer>();

            Console.Write("Enter the number of tax payers: ");
            int aux = int.Parse(Console.ReadLine());

            for (int i = 0; i < aux; i++)
            {
                Console.WriteLine($"Tax payer #{i + 1} data:");

                Console.Write("Individual or company (i/c)? ");
                char Situation = char.Parse(Console.ReadLine());

                String Name;
                double AnualIncome;


                if (Situation == 'i')
                {
                    Console.Write("Nome: ");
                    Name = Console.ReadLine();

                    Console.Write("Anual income: ");
                    AnualIncome = double.Parse(Console.ReadLine());

                    Console.Write("Health expenditures: ");
                    double HealthExpenditures = double.Parse(Console.ReadLine());

                    list.Add(new Individual(Name, AnualIncome, HealthExpenditures));
                }
                else if (Situation == 'c')
                {
                    Console.Write("Nome: ");
                    Name = Console.ReadLine();

                    Console.Write("Anual income: ");
                    AnualIncome = double.Parse(Console.ReadLine());

                    Console.Write("Number of employees: ");
                    int NumberOfEmployees = int.Parse(Console.ReadLine());

                    list.Add(new Company(Name, AnualIncome, NumberOfEmployees));
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
