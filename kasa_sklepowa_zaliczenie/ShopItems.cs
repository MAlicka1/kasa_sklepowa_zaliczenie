using System.Collections.Generic;

namespace kasa_sklepowa_zaliczenie
{
    internal partial class Program
    {
        public class ShopItems
        {
            private List<Item> items;

            public List<Item> getShopItems()
            {
                return items;
            }

            public void setShopItems(List<Item> items)
            {
                this.items = items;
            }

            public Item getItemByBarcode(string barcode)
            {
                foreach (Item item in items)
                {
                    if (item.getBarcode() == barcode)
                    {
                        return item;
                    }
                }

                return null;
            }
        }
    }
}

