using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace TomCafe_Assignement
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        // 2.1. For Menu Display 
        List<ValueMeal> ValueMealList = new List<ValueMeal>();
        List<Side> SideList = new List<Side>();
        List<Beverage> BeverageList = new List<Beverage>();
        List<MenuItem> MenuItemList = new List<MenuItem>();

        // 2.2 For Shopping Cart Display
        List<OrderItem> OrderList = new List<OrderItem>();

        public MainPage()
        {
            this.InitializeComponent();
            ListsValues();
            DisplayButtons();
        }

        public void cartdisplay()
        {
           
        }

        public void ListsValues()
        {
            //ValueMeal
            //DateTime
            DateTime sevenAm = new DateTime(2018, 2, 28, 7, 0, 0);
            DateTime twoPm = new DateTime(2018, 2, 28, 14, 0, 0);
            DateTime tenAm = new DateTime(2018, 2, 28, 10, 0, 0);
            DateTime sevenPm = new DateTime(2018, 2, 28, 19, 0, 0);
            DateTime fourPm = new DateTime(2018, 2, 28, 16, 0, 0);
            DateTime tenPm = new DateTime(2018, 2, 28, 22, 0, 0);
            DateTime midnight = new DateTime(2018, 2, 28, 0, 0, 0);
            DateTime endmorning = new DateTime(2018, 2, 28, 23, 59, 59);

            ValueMeal vm1 = new ValueMeal("Hotcake with sausage", 6.90, sevenAm, twoPm);
            ValueMeal vm2 = new ValueMeal("Hamburger", 7.50, tenAm, sevenPm);
            ValueMeal vm3 = new ValueMeal("Ribeye steak", 10.20, midnight, endmorning);
            ValueMeal vm4 = new ValueMeal("Nasi Lemak", 5.40, fourPm, tenPm);

            ValueMealList.Add(vm1);
            ValueMealList.Add(vm2);
            ValueMealList.Add(vm3);
            ValueMealList.Add(vm4);

            //Sides
            Side side1 = new Side("Hash brown", 2.10);
            Side side2 = new Side("Truffle fries", 3.70);
            Side side3 = new Side("Calamari", 3.40);
            Side side4 = new Side("Caesar salad", 4.30);

            SideList.Add(side1);
            SideList.Add(side2);
            SideList.Add(side3);
            SideList.Add(side4);

            //Beverages
            Beverage b1 = new Beverage("Cola", 2.85, 0.00);
            Beverage b2 = new Beverage("Green Tea", 3.70, 0.00);
            Beverage b3 = new Beverage("Coffee", 2.70, 0.00);
            Beverage b4 = new Beverage("Tea", 2.70, 0.00);
            Beverage b5 = new Beverage("Tom's Root Beer", 9.70, 0.00);
            Beverage b6 = new Beverage("Mocktail", 15.90, 0.00);

            BeverageList.Add(b1);
            BeverageList.Add(b2);
            BeverageList.Add(b3);
            BeverageList.Add(b4);
            BeverageList.Add(b5);
            BeverageList.Add(b6);

            //Bundles
            MenuItem Mi1 = new MenuItem("Breakfast set", 7.90);
            MenuItem Mi2 = new MenuItem("Hamburger combo", 10.20);
            MenuItem Mi3 = new MenuItem("Dinner set", 18.50);

            MenuItemList.Add(Mi1);
            MenuItemList.Add(Mi2);
            MenuItemList.Add(Mi3);
        }

        /* TEMPLATE*/
        public void DisplayButtons()
        {
            itemsListView.ItemsSource = ValueMealList;
            itemsListView.ItemsSource = SideList;
            itemsListView.ItemsSource = BeverageList;
        }

        //Buttons
        private void bundlesButton_Click(object sender, RoutedEventArgs e)
        {
            itemsListView.ItemsSource = null;
            itemsListView.ItemsSource = MenuItemList;
        }

        private void mainsButton_Click(object sender, RoutedEventArgs e)
        {
            itemsListView.ItemsSource = null;
            itemsListView.ItemsSource = ValueMealList;
        }

        private void sidesButton_Click(object sender, RoutedEventArgs e)
        {
            itemsListView.ItemsSource = null;
            itemsListView.ItemsSource = SideList;
        }

        private void beveragesButton_Click(object sender, RoutedEventArgs e)
        {
            itemsListView.ItemsSource = null;
            itemsListView.ItemsSource = BeverageList;
        }

        private void addButton_Click(object sender, RoutedEventArgs e)
        {

            //OrderList c = new OrderItem((MenuItem)itemsListView.SelectedItem );
            OrderItem c = new OrderItem((MenuItem)itemsListView.SelectedItem);
            OrderList.Add(c);
            cartsListView.ItemsSource = null;
            cartsListView.ItemsSource = OrderList;
    
        }

        private void orderButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void cancelButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void removeButton_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
