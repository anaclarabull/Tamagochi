using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tamagochi_Back
{
    internal class Tamagochi
    {
        public int Id { get; set; }
        public string Name { get; set; } = default!;
        public string Url { get; set; } = default!;
        public int BaseExperience { get; set; }

        public override string ToString()
        {
            return $"{Name} (ID: {Id}, Base Experience: {BaseExperience})";
        }
    }
}
