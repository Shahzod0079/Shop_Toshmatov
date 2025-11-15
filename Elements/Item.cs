using System.Windows;

namespace Shop_Toshmatov.Elements
{
    internal class Item : UIElement
    {
        private object item;

        public Item(object item)
        {
            this.item = item;
        }
    }
}