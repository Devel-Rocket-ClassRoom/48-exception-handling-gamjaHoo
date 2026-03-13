using System;

namespace GameItemException
{
    public class InventoryFullException : Exception
    {
        public int Capacity { get; }
        public string ItemName { get; }

        public InventoryFullException(int capacity, string itemName)
            : base($"인벤토리가 가득 찼습니다. (용량: {capacity}, 아이템: {itemName})")
        {
            Capacity = capacity;
            ItemName = itemName;
        }
    }
}