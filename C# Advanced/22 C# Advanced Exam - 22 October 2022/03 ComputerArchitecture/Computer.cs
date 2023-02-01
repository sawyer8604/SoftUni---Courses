using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace ComputerArchitecture
{
    public class Computer
    {
        private List<CPU> multiprocessor;
        public Computer(string model, int capacity)
        {
            Model = model;
            Capacity = capacity;
            this.multiprocessor = new List<CPU>();
        }

        public string Model { get; set; }
        public int Capacity { get; set; }
        public List<CPU> Multiprocessor => this.multiprocessor;

        public int Count => Multiprocessor.Count;

        public void Add(CPU cpu)
        {
            if (this.Count < this.Capacity)
            {
                this.multiprocessor.Add(cpu);
            }
        }

        public bool Remove(string brand)
        {

            var cpuToRemove = this.multiprocessor.FirstOrDefault(x => x.Brand == brand);

            if (cpuToRemove != default)
            {
                this.multiprocessor.Remove(cpuToRemove);
                return true;
            }
            return false;
        }

        public CPU MostPowerful()
        {
            return this.multiprocessor.OrderByDescending(x => x.Frequency).FirstOrDefault();
        }

        public CPU GetCPU(string brand)
        {
            return this.multiprocessor.FirstOrDefault(x => x.Brand == brand);
        }

        public string Report()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"CPUs in the Computer {this.Model}:");


            if (this.multiprocessor.Any())
            {
                foreach (var item in Multiprocessor)
                {
                    sb.AppendLine(item.ToString());
                }
            }

            return sb.ToString().TrimEnd();
        }
    }
}
