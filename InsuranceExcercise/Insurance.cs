using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsuranceExcercise
{
    public class Insurance
    {
        private string species;
        private string name;
        private bool neutered;
        private double fee;

        public string Species { get => species; set => species = value; }
        public bool Neutered { get => neutered; set => neutered = value; }
        public string Name { get => name; set => name = value; }

        public Insurance(string animal, String name, bool isNeutered, double payment)
        {
            this.Species = animal;
            this.Name = name;
            this.Neutered = isNeutered;
            this.fee = payment;
        }
        public Insurance()
        {
            this.Species = string.Empty;
            this.Name = string.Empty;
            this.Neutered = false;
            this.fee = 0.0;
        }
        public string GetNeuteredInfo()
        {
            if (Neutered)
            {
                return "leikattu";
            }
            else
            {
                return "leikkaamaton";
            }
        }
        public override string ToString()
        {
            return this.Species + ": " + this.Name + ", " + this.GetNeuteredInfo();
        }
    }
}
