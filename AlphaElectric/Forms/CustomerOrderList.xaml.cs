﻿using AlphaElectric_DataAccessLayer;
using AlphaElectric_DataAccessLayer.Factories;
using MaterialDesignThemes.Wpf;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;

namespace AlphaElectric.Forms
{
    /// <summary>
    /// Interaction logic for CompanyList.xaml
    /// </summary>
    public partial class CustomerOrderList : UserControl
    {
        public CustomerOrderList()
        {
            InitializeComponent();
            LoadData();
            PopupBox.Visibility = Visibility.Visible;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

        }

        void LoadData()
        {
            List<Product_CustomerOrderBT> custPurchaseBTList = new Product_CustomerOrderBTFactory().SelectAll();

            //Join Projects
            //List<CustomerOrder> custOrders = new CustomerOrderFactory().SelectAll();

            DataGrid.ItemsSource = custPurchaseBTList;
            //proPurchaseBTList.FirstOrDefault().PurchaseOrder.Contact.Phone
        }

        private void PopUp_AddNewCompany(object sender, RoutedEventArgs e)
        {
            //Window win = new Window();
            //ProductAddNew eDoc = new ProductAddNew();
            //win.Content = eDoc;
            //win.Title = "Add Product";
            //win.Width = 350;
            //win.Height = 450;
            //win.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            //win.Show();
            //ProductAddNew userControl1 = new ProductAddNew();
            //this.InitializeComponent();
            // UserControl win = new UserControl();
            //CompanyAddNew eDoc = new CompanyAddNew();
            //win.Content = eDoc;
            //win.Title = "Add Product";
            //win.Width = 350;
            //win.Height = 450;
            //win.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            //win.Show();
            //CompanyList complist = new CompanyList();


            TextBlock_TitleName.Visibility = Visibility.Collapsed;
            DataGrid.Visibility = Visibility.Collapsed;
            PopupBox.Visibility = Visibility.Collapsed;

            CustomerOrderAdd x = new CustomerOrderAdd();
            UserPages.Children.Clear();
            UserPages.Children.Add(x);
            PopupBoxWithClose.Visibility = Visibility.Visible;
        }

        private void PopUp_Close(object sender, RoutedEventArgs e)
        {
            UserPages.Children.Clear();
            PopupBoxWithClose.Visibility = Visibility.Hidden;

            LoadData();
            TextBlock_TitleName.Visibility = Visibility.Visible;
            DataGrid.Visibility = Visibility.Visible;
            PopupBox.Visibility = Visibility.Visible;
        }

    }
}
    