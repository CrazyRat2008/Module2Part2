using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp32
{
    internal class Appliance
    {
        public interface IAppliance
        {
            string Abbreviation { get; }
            string Name { get; }
            string Brand { get; set; }
            string Model { get; set; }
            string GetInfo(bool abbreviated = false);
        }

        public class CoffeeGrinder : IAppliance
        {
            public string Abbreviation => "CG";
            public string Name => "Coffee Grinder";
            public string Brand { get; set; }
            public string Model { get; set; }

            public string GetInfo(bool abbreviated = false)
            {
                if (abbreviated)
                {
                    return $"{this.Abbreviation}: Coffee Grinder";
                }
                else
                {
                    return $"Coffee Grinder - Brand: {this.Brand}, Model: {this.Model}";
                }
            }
        }

        public class Mixer : IAppliance
        {
            public string Abbreviation => "MX";
            public string Name => "Mixer";
            public string Brand { get; set; }
            public string Model { get; set; }

            public string GetInfo(bool abbreviated = false)
            {
                if (abbreviated)
                {
                    return $"{this.Abbreviation}: Mixer";
                }
                else
                {
                    return $"Mixer - Brand: {this.Brand}, Model: {this.Model}";
                }
            }
        }

        public class Blender : IAppliance
        {
            public string Abbreviation => "BL";
            public string Name => "Blender";
            public string Brand { get; set; }
            public string Model { get; set; }

            public string GetInfo(bool abbreviated = false)
            {
                if (abbreviated)
                {
                    return $"{this.Abbreviation}: Blender";
                }
                else
                {
                    return $"Blender - Brand: {this.Brand}, Model: {this.Model}";
                }
            }
        }
    }
}
