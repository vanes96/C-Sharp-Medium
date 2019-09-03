using System;
using System.Collections.Generic;
using System.Linq;

namespace Task1._3
{
    class Bag
    {
        private List<Item> _items;
        private readonly int _maxWeight;

        public void AddItem(string name, int weight)
        {
            int currentWeidth = _items.Sum(item => item.Weight);
            Item targetItem = _items.FirstOrDefault(item => item.Name == name);

            if (targetItem == null)
                throw new InvalidOperationException();

            if (weight < 0)
                throw new InvalidOperationException();

            if (currentWeidth + weight > _maxWeight)
                throw new InvalidOperationException();

            targetItem.AddWeight(weight);
        }
    }

    class Item
    {
        public int Weight { get; private set; }

        public string Name { get; }

        public void AddWeight(int weight)
        {
            if (weight < 0)
                throw new InvalidOperationException();

            Weight += weight;
        }
    }
}
