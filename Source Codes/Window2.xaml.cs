/*
 * Created by SharpDevelop.
 * User: telephonedude
 * Date: 09/13/2018
 * Time: 07:21
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Text.RegularExpressions;

namespace Testing
{
	public partial class Window2 : Window
	{
		public int picnum=0;
		public int newquantity;
		public int quantity;
		public int availquantity;
		public int returntype;
		 public Unit Data{ get; set; } //setter & getter property. public Window2 (Unit in_data)
		 public Window2(Unit in_data)
		 {
		 InitializeComponent(); 
		 Data = in_data; //set the received data. 
		 this.DataContext = Data; //set data to Window's binding.
		 }
	void AddBtn_Click(object sender, RoutedEventArgs e)
	{
		if(purchasebox.Text == "")
		{
			MessageBox.Show("Error, quantity box must not be empty","Error", MessageBoxButton.OK, MessageBoxImage.Error);
			return;
		}
		availquantity = int.Parse(availablebox.Text);
		quantity = int.Parse(purchasebox.Text);
		newquantity = availquantity + quantity;
		Data.TotalPrice = Data.OrigPrice*quantity;
		var result = MessageBox.Show("Are you sure? The total price will be P"+Data.TotalPrice.ToString(),"Confirmation", MessageBoxButton.YesNo, MessageBoxImage.Information);
		if(result == MessageBoxResult.No){
			return;
			}
		Data.AvailQuantity = newquantity;
		Data.Status = "New";
		Data = DataContext as Unit;
		Close();
	}
	void CloseBtn_Click(object sender, RoutedEventArgs e)
	{ 
		returntype = 1;
		Data = null; //set Data to null. 
		Close(); //close the window.
	}
	void SellBtn_Click(object sender, RoutedEventArgs e)
	{
		if(sellbox.Text == "")
		{
			MessageBox.Show("Error, quantity box must not be empty","Error", MessageBoxButton.OK, MessageBoxImage.Error);
			return;
		}
		quantity = int.Parse(sellbox.Text);
		Data.TotalPriceSell = Data.RetailPrice*quantity;
		if(quantity > Data.AvailQuantity)
		{
			MessageBox.Show("Error! Must have less than "+Data.AvailQuantity+" units in order to order, please input again", "Error", MessageBoxButton.OK,MessageBoxImage.Error);
			return;
		}
		var result = MessageBox.Show("Are you sure? The total price will be P"+Data.TotalPriceSell.ToString(),"Confirmation", MessageBoxButton.YesNo, MessageBoxImage.Information);
		if(result == MessageBoxResult.No){
			return;
			}
		Data.Quantity = quantity;
		Data.AvailQuantity = Data.AvailQuantity - quantity;
		Close();
	}
	void NextBtn_Click(object sender, RoutedEventArgs e)
	{
		prevBtn.IsEnabled = true;
		picnum++;
		if(picnum==0)
		{
			CarPic.Visibility= Visibility.Visible;
			CarPic1.Visibility= Visibility.Hidden;
			CarPic2.Visibility= Visibility.Hidden;
			CarPic3.Visibility= Visibility.Hidden;
			CarPic4.Visibility= Visibility.Hidden;
		}
		if(picnum==1)
		{
			CarPic.Visibility= Visibility.Hidden;
			CarPic1.Visibility= Visibility.Visible;
			CarPic2.Visibility= Visibility.Hidden;
			CarPic3.Visibility= Visibility.Hidden;
			CarPic4.Visibility= Visibility.Hidden;
		}
		if(picnum==2)
		{
			CarPic.Visibility= Visibility.Hidden;
			CarPic1.Visibility= Visibility.Hidden;
			CarPic2.Visibility= Visibility.Visible;
			CarPic3.Visibility= Visibility.Hidden;
			CarPic4.Visibility= Visibility.Hidden;
		}
		if(picnum==3)
		{
			CarPic.Visibility= Visibility.Hidden;
			CarPic1.Visibility= Visibility.Hidden;
			CarPic2.Visibility= Visibility.Hidden;
			CarPic3.Visibility= Visibility.Visible;
			CarPic4.Visibility= Visibility.Hidden;
		}
		if(picnum==4)
		{
			CarPic.Visibility= Visibility.Hidden;
			CarPic1.Visibility= Visibility.Hidden;
			CarPic2.Visibility= Visibility.Hidden;
			CarPic3.Visibility= Visibility.Hidden;
			CarPic4.Visibility= Visibility.Visible;
			nextBtn.IsEnabled = false;
		}
		
		
	}
	void PrevBtn_Click(object sender, RoutedEventArgs e)
	{
		nextBtn.IsEnabled = true;
		picnum--;
		if(picnum==0)
		{
			prevBtn.IsEnabled = false;
			CarPic.Visibility= Visibility.Visible;
			CarPic1.Visibility= Visibility.Hidden;
			CarPic2.Visibility= Visibility.Hidden;
			CarPic3.Visibility= Visibility.Hidden;
			CarPic4.Visibility= Visibility.Hidden;
		}
		if(picnum==1)
		{
			CarPic.Visibility= Visibility.Hidden;
			CarPic1.Visibility= Visibility.Visible;
			CarPic2.Visibility= Visibility.Hidden;
			CarPic3.Visibility= Visibility.Hidden;
			CarPic4.Visibility= Visibility.Hidden;
		}
		if(picnum==2)
		{
			CarPic.Visibility= Visibility.Hidden;
			CarPic1.Visibility= Visibility.Hidden;
			CarPic2.Visibility= Visibility.Visible;
			CarPic3.Visibility= Visibility.Hidden;
			CarPic4.Visibility= Visibility.Hidden;
		}
		if(picnum==3)
		{
			CarPic.Visibility= Visibility.Hidden;
			CarPic1.Visibility= Visibility.Hidden;
			CarPic2.Visibility= Visibility.Hidden;
			CarPic3.Visibility= Visibility.Visible;
			CarPic4.Visibility= Visibility.Hidden;
		}
		if(picnum==4)
		{
			CarPic.Visibility= Visibility.Hidden;
			CarPic1.Visibility= Visibility.Hidden;
			CarPic2.Visibility= Visibility.Hidden;
			CarPic3.Visibility= Visibility.Hidden;
			CarPic4.Visibility= Visibility.Visible;
			nextBtn.IsEnabled = false;
		}
	}
		
		void textbox_preview(object sender, TextCompositionEventArgs e)
		{
			e.Handled = new Regex("^[0-9]+$").IsMatch(e.Text);
		}
		void numberbox_preview(object sender, TextCompositionEventArgs e)
		{
			e.Handled = new Regex("[^0-9]+").IsMatch(e.Text);
		}
}
}
