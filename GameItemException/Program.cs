using GameItemException;
using System;

namespace GameItemException
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== 인벤토리 테스트 ===");

            Inventory inventory = new Inventory(3);

            try
            {
                inventory.AddItem("검");
                inventory.AddItem("방패");
                inventory.AddItem("포션");
                inventory.AddItem("활");
            }
            catch (InventoryFullException ex)
            {
                Console.WriteLine($"[인벤토리 오류] {ex.Message}");
            }

            inventory.ShowItems();

            try
            {
                inventory.RemoveItem("포션");
                inventory.RemoveItem("도끼");
            }
            catch (ItemNotFoundException ex)
            {
                Console.WriteLine($"[인벤토리 오류] {ex.Message}");
            }

            inventory.ShowItems();
        }
    }
}