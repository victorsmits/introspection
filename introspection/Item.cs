using System;
namespace introspection
{
    public class Item
    {
        private static int nextid = 0;

        public readonly int ID;
        private readonly string name;
        private readonly int price;

        public Item(string name, int price)
        {
            this.ID = ++nextid;
            this.name = name;
            this.price = price;
        }

        public string Name
        {
            get { return name; }
        }

        public int Price
        {
            get { return price; }
        }
    }
}
