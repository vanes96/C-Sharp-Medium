using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Bag
    {
        private IReadOnlyCollection<Item> _items;
        private readonly uint _maxWeight;

        public void AddItem(string name, uint weight)
        {
            uint currentWeidth = (uint)_items.Sum(item => item.Weight);
            Item targetItem = _items.FirstOrDefault(item => item.Name == name);

            if (targetItem == null)
                throw new InvalidOperationException();

            if (currentWeidth + weight > _maxWeight)
                throw new InvalidOperationException();

            targetItem.AddWeight(weight);
        }
    }

    class Item
    {
        public uint Weight { get; private set; }
        public string Name { get; }
        public void AddWeight(uint weight)
        {
            Weight += weight;
        }
    }
}
