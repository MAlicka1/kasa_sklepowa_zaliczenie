using System;

namespace kasa_sklepowa_zaliczenie
{
    internal partial class Program
    {
        public class Item
        {
            private string name;
            private double price;
            private int vat;
            private string barcode;

            public Item(string barcode, string name, double price, int vat)
            {
                this.barcode = barcode;
                this.name = name;
                this.price = price;
                this.vat = vat;
            }

            public string getName()
            {
                return name;
            }
            public double getPrice()
            {
                return price;
            }
            public int getVat()
            {
                return vat;
            }
            public string getBarcode()
            {
                return barcode;
            }
            public double getSumVat()
            {
                double vat = (price * this.vat) / 100;
                double roundVat = Math.Round(vat, 2);

                return roundVat;
            }

            public double getPriceGross()
            {
                return getSumVat() + price;
            }

        }
    }
}
