using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

namespace ConsoleApp2
{
    public class Republic
    {
        public string Name { get; set; }

        public Republic(string name)
        {
            Name = name;
        }

        public virtual void Describe()
        {
            Console.WriteLine($"Это Республика: {Name}");
        }
    }

    public class Monarchy : Republic
    {
        public string Monarch { get; set; }

        public Monarchy(string name, string monarch) : base(name)
        {
            Monarch = monarch;
        }

        public override void Describe()
        {
            Console.WriteLine($"Это Монархия: {Name}, монарх - {Monarch}");
        }
    }

    public class Kingdom : Monarchy
    {
        public Kingdom(string name, string monarch) : base(name, monarch) { }

        public override void Describe()
        {
            Console.WriteLine($"Это Королевство: {Name}, король - {Monarch}");
        }
    }

    public class State : Republic
    {
        public State(string name) : base(name) { }

        public override void Describe()
        {
            Console.WriteLine($"Это Государство: {Name}");
        }
    }
}