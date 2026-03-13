using System;
using System.Collections.Generic;
using System.Text;

namespace GameItemException
{
    internal class Inventory
    {
        private int _maxCapacity;
        private List<string> items;
        
        public Inventory(int maxCapacity)
        {
            _maxCapacity = maxCapacity;
            items = new List<string>();
        }

        public void AddItem(string itemName)
        {
            if(items.Count == _maxCapacity)
            {
                throw new InventoryFullException(_maxCapacity, itemName);
            }
            items.Add(itemName);
            Console.WriteLine($"아이템 '{itemName}' 추가됨");
        }

        public void RemoveItem(string itemName)
        {
            if(!items.Contains(itemName) )
            {
                throw new ItemNotFoundException(itemName);
            }
            items.Remove(itemName);
            Console.WriteLine($"아이템 '{itemName}' 제거됨");
        }

        public void ShowItems()
        {
            Console.Write("현재 인벤토리: ");
            for(int i = 0; i < items.Count; i++)
            {
                if (i == 0)
                {
                    Console.Write(items[i]);
                }
                else
                {
                    Console.Write($", {items[i]}");
                }
            }
            Console.WriteLine();
        }
    }
}
