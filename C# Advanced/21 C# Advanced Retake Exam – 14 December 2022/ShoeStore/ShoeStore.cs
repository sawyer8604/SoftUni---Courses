using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShoeStore
{
    public class ShoeStore
    {
        public ShoeStore(string name, int storageCapacity)
        {
            Name = name;
            StorageCapacity = storageCapacity;
            Shoes = new List<Shoe>();
        }

        //  •	Name – string
        //•	StorageCapacity – int
        //•	Shoes – List<Shoe>

        public string Name { get; set; }
        public int StorageCapacity { get; set; }
        public List<Shoe> Shoes { get; private set; }
        public int Count => Shoes.Count;

        public string AddShoe(Shoe shoe)
        {
            if (Shoes.Count == StorageCapacity)
            {
                return $"No more space in the storage room.";
            }

            Shoes.Add(shoe);

            return $"Successfully added {shoe.Type} {shoe.Material} pair of shoes to the store.";
        }

        public int RemoveShoes(string material)
        {
            return Shoes.Where(x => x.Material == material).Count(); ;
        }

        public List<Shoe> GetShoesByType(string type)
        {
            return Shoes.Where(x => x.Type.ToLower() == type.ToLower()).ToList();

        }
        public Shoe GetShoeBySize(double size)
        {
            return Shoes.Where(x => x.Size == size).FirstOrDefault();
        }

        public string StockList(double size, string type)
        {
            var list = Shoes.Where(x => x.Size == size).Where(y => y.Type == type).ToList();

            if (list.Count == 0)
            {
                return "No matches found!";
            }

            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Stock list for size {size} - {type} shoes:");

            foreach (var item in list)
            {
                sb.AppendLine(item.ToString());
            }

            return sb.ToString().TrimEnd();
        }
    }
}
