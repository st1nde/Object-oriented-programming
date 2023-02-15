using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsuranceExcercise
{
    internal class InsuranceManager: Insurance
    {

        List<Insurance> List = new List<Insurance>();

        public InsuranceManager()
        {

        }

        internal void AddInsurance(string animal, string name, bool isNeutered)
        {
            List.Add(new Insurance(animal, name, isNeutered, GetFee(animal, isNeutered)));
        }

        public double GetFee(string species, bool isNeutered)
        {
            if (species == "koira" && isNeutered == true)
            {
                return 50;
            }
            else if (species == "koira" && isNeutered == false)
            {
                return 80;
            }
            else if (species == "kissa" && isNeutered == true)
            {
                return 40;
            }
            else if (species == "kissa" && isNeutered == false)
            {
                return 60;
            }
            else return 0;

        }

        internal void PrintInsurances()
        {
            Console.WriteLine("Vakuutuksia yhteensä " + List.Count + "\n");
            Console.WriteLine("Vakuutukset:\n");
            foreach (Insurance insurance in List)
            {
                Console.Write(" " + insurance.ToString() + "\n\n");
            }
        }

        public void FindInsurances(string species, bool isNeutered)
        {
            Console.WriteLine("Löytyi:\n");
            foreach (Insurance insurance in List)
            {
                if(insurance.Species == species && isNeutered == insurance.Neutered)
                {
                    Console.WriteLine(" " + species + ": " + Name + "vakuutusmaksu " + GetFee(species, isNeutered) + "e\n");
                }
            }
        }
    }
}
