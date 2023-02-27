using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Instryment
{
    internal class Program
    {
        interface Tool
        {
            void Play();
            const string KEY = "До Мажор";
        }
        class Gitara : Tool
        {
            public Gitara(int stringsCount)
            {
                this.stringsCount = stringsCount;
            }
            private int stringsCount;

            public void Play()
            {
                Console.WriteLine("Играет гитара с струнами " + stringsCount);
            }
        }
        class Drum : Tool
        {
            public Drum(int quantity)
            {
                this.quantity = quantity;
            }
            private int quantity;

            public void Play()
            {
                Console.WriteLine("Играет барабан с деревянными палочками " + quantity);
            }
        }
        class Pipe : Tool
        {
            public Pipe(int size)
            {
                this.size = size;
            }
            private int size;

            public void Play()
            {
                Console.WriteLine("Играет труба, размер которой " + size);
            }
        }
        static void Main(string[] args)
        {
            Gitara gitara = new Gitara(4);
            Drum drum = new Drum(2);
            Pipe pipe = new Pipe(53);
            Tool[] tool = { gitara, drum, pipe };
            foreach (Tool item in tool)
            {
                item.Play();
            }
        }


    }
    
}
