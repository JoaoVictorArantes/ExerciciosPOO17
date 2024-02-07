using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosPOO17.Entities
{
    abstract class TaxPayer
    {
        public String Name { get; set; }
        public double AnualIncome { get; set; }

        protected TaxPayer(string name, double anualIncome)
        {
            this.Name = name;
            this.AnualIncome = anualIncome;
        }

        public abstract double Tax();

    }
}
