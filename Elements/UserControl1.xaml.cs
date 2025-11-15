using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Shop_Toshmatov.Classes;

namespace Shop_Toshmatov.Elements
{
    public partial class UserControl1 : UserControl
    {
        public UserControl1(object itemData)
        {
            InitializeComponent();

            Classes.Shop ShopData = itemData as Classes.Shop;
            tbName.Content = ShopData.Name;
            tbPrice.Content = "Цена: " + ShopData.Price;
            if (itemData is Classes.Children)
            {
                Classes.Children ChildrenData = itemData as Classes.Children;
                tbCharacteristic.Content = "Возраст: " + ChildrenData.Age;
            }
            if (itemData is Classes.Sport)
            {
                Classes.Sport SportData = itemData as Classes.Sport;
                tbCharacteristic.Content = "Размер: " + SportData.Size;
            }
        }
    }
}