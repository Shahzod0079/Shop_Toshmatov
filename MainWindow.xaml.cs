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

namespace Shop_Toshmatov
{
    public partial class MainWindow : Window
    {
        List<object> AllItems = Classes.RepoItems.AllItems();

        public MainWindow()
        {
            InitializeComponent();
            if (parent == null)
            {
                MessageBox.Show("Элемент 'parent' не найден в XAML");
                return;
            }

            if (AllItems == null || AllItems.Count == 0)
            {
                MessageBox.Show("Нет данных для отображения");
                return;
            }
            CreateUI();
        }
        public void CreateUI()
        {
            if (AllItems == null) return;

            if (parent == null) return;

            foreach (object Item in AllItems)
            {
                if (Item == null) continue;

                parent.Children.Add(new Elements.UserControl1(Item));
            }
        }
    }
}