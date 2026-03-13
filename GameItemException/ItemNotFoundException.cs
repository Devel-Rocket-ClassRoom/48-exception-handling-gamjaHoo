using System;

namespace GameItemException
{
    public class ItemNotFoundException : Exception
    {
        public string ItemName { get; }

        public ItemNotFoundException(string itemName)
            : base($"아이템을 찾을 수 없습니다: {itemName}")
        {
            ItemName = itemName;
        }
    }
}