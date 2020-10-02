/*
 * Created by SharpDevelop.
 * User: telephonedude
 * Date: 12/09/2018
 * Time: 11:57 PM
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
using System.ComponentModel;

namespace Testing
{
	public class Unit
	{
		public string Name{get; set;} 
		public int IDNumber{get; set;}
		public string Description{get; set;}
		public string Category {get; set;}
		public int AvailQuantity{get; set;}
		public int TotalQuantity{get; set;}
		public string Brand{get; set;}
		public string Supplier {get; set;}
		public int OrigPrice {get; set;}
		public int RetailPrice{get; set;}
		public string Status {get; set;}
		public string Date {get; set;}
		public string Pic {get; set;}
		public string Pic1 {get; set;}
		public string Pic2 {get; set;}
		public string Pic3 {get; set;}
		public string Pic4 {get; set;}
		public int Quantity {get; set;}
		public int TotalPrice{get; set;}
		public int TotalPriceSell{get; set;}
	}
	
	public partial class Window1 : Window
	{
		public string GroupBinding = "Category";
		public int TotalProfit = 0;
		public int TotalCustomers = 0;
		public int TotalSold = 0;
		public int TotalReturned = 0;
		public int TotalDisposed = 0;
		public int TotalUnsold = 0;
		public int TotalInventory = 0;
		
		List<Unit> weapon_list_; // we will use this to hold collection of data.
		List<Unit> selection_list_;
		public Window1()
		{
			InitializeComponent(); 
			allbutton_Close();
			// we will initialized the list with some items.This is just example.
			
			selection_list_ = new List<Unit>();
			weapon_list_ = new List<Unit>(){
new Unit() {Name="Accord", IDNumber = 272001, Description = "Affordable", Category = "Sedan", AvailQuantity = 5 , TotalQuantity = 0 , Brand = "Honda", Supplier = "Japan" , OrigPrice = 1938000 , RetailPrice = 1970000, Status = "Normal", Date= " Sept 24, 2018", Pic = "MJZeny/accord1.jpg",Pic1 = "MJZeny/accord2.jpg" ,Pic2 = "MJZeny/accord3.jpg" , Pic3 = "MJZeny/accord4.jpg" , Pic4 = "MJZeny/accord5.jpg"},
new Unit() {Name="Brio" , IDNumber = 272002, Description = "Economical", Category = "Hatchback", AvailQuantity = 5 , TotalQuantity = 0 , Brand = "Honda", Supplier = "Japan" , OrigPrice = 642000, RetailPrice = 720000, Status = "Normal", Date= " Sept 25, 2018", Pic = "MJZeny/brio1.jpg",Pic1 = "MJZeny/brio2.jpg" ,Pic2 = "MJZeny/brio3.jpg" , Pic3 = "MJZeny/brio4.jpg" , Pic4 = "MJZeny/brio5.jpg"},
new Unit() {Name="BR-V" , IDNumber = 272003, Description = "Automotive", Category = "SUV", AvailQuantity = 5 , TotalQuantity = 0 , Brand = "Honda", Supplier = "Japan" , OrigPrice = 1103000, RetailPrice = 1150700 , Status = "Normal", Date= " Sept 26, 2018", Pic = "MJZeny/br-v1.jpg",Pic1 = "MJZeny/br-v2.jpg" ,Pic2 = "MJZeny/br-v3.jpg" , Pic3 = "MJZeny/br-v4.jpg" , Pic4 = "MJZeny/br-v5.jpg"},
new Unit() {Name="City" , IDNumber = 272004, Description = "Elegant", Category = "Crossover", AvailQuantity = 5 , TotalQuantity = 0 , Brand = "Honda", Supplier = "Japan" , OrigPrice = 828000, RetailPrice = 870500 , Status = "Normal", Date= " Sept 27, 2018", Pic = "MJZeny/city1.jpg",Pic1 = "MJZeny/city2.jpg" ,Pic2 = "MJZeny/city3.jpg" , Pic3 = "MJZeny/city4.jpg" , Pic4 = "MJZeny/city5.jpg"},
new Unit() {Name="Civic" , IDNumber = 272005, Description = "Sporty", Category = "Sports Utility", AvailQuantity = 5 , TotalQuantity = 0 , Brand = "Honda", Supplier = "Japan" , OrigPrice = 1138000, RetailPrice = 1238000, Status = "Normal", Date= " Sept 28, 2018", Pic = "MJZeny/civic1.jpg",Pic1 = "MJZeny/civic2.jpg" ,Pic2 = "MJZeny/civic3.jpg" , Pic3 = "MJZeny/civic4.jpg" , Pic4 = "MJZeny/civic5.jpg"},
new Unit() {Name="Clarity" , IDNumber = 272006, Description = "Affordable", Category = "Sedan", AvailQuantity = 5 , TotalQuantity = 0 , Brand = "Honda", Supplier = "Japan" , OrigPrice = 1856118, RetailPrice = 1976118, Status = "Normal", Date= " Sept 29, 2018", Pic = "MJZeny/clarity1.png",Pic1 = "MJZeny/clarity2.png" ,Pic2 = "MJZeny/clarity3.png" , Pic3 = "MJZeny/clarity4.png" , Pic4 = "MJZeny/clarity5.png"},
new Unit() {Name="CR-V" , IDNumber = 272007, Description = "Economical", Category = "Sedan", AvailQuantity = 5 , TotalQuantity = 0 , Brand = "Honda", Supplier = "Japan" , OrigPrice = 1658000, RetailPrice = 1698000 , Status = "Normal", Date= " Sept 30, 2018", Pic = "MJZeny/cr-v1.jpg",Pic1 = "MJZeny/cr-v2.jpg" ,Pic2 = "MJZeny/cr-v3.jpg" , Pic3 = "MJZeny/cr-v4.jpg" , Pic4 = "MJZeny/cr-v5.jpg"},
new Unit() {Name="Jazz " , IDNumber = 272008, Description = "Luxurious", Category = "Crossover", AvailQuantity = 5 , TotalQuantity = 0 , Brand = "Honda", Supplier = "Japan" , OrigPrice = 857000 , RetailPrice = 880000 , Status = "Normal", Date= " Sept 22, 2018", Pic = "MJZeny/freed1.png",Pic1 = "MJZeny/freed2.png" ,Pic2 = "MJZeny/freed3.png" , Pic3 = "MJZeny/freed4.png" , Pic4 = "MJZeny/freed5.png"},
new Unit() {Name="Freed" , IDNumber = 272009, Description = "Sporty", Category = "MVP", AvailQuantity = 5 , TotalQuantity = 0 , Brand = "Honda", Supplier = "Japan" , OrigPrice = 1048000, RetailPrice = 943200 , Status = "Normal", Date= " Oct 1, 2018", Pic = "MJZeny/jazz1.jpg",Pic1 = "MJZeny/jazz2.jpg" ,Pic2 = "MJZeny/jazz3.jpg" , Pic3 = "MJZeny/jazz4.jpg" , Pic4 = "MJZeny/jazz5.jpg"},
new Unit() {Name="Legend" , IDNumber = 272010, Description = "Economical", Category = "Coupe", AvailQuantity = 5 , TotalQuantity = 0 , Brand = "Honda", Supplier = "Japan" , OrigPrice = 4385000, RetailPrice =4425000 , Status = "Normal", Date= " Sept 24, 2018", Pic = "MJZeny/legend1.png",Pic1 = "MJZeny/legend2.png" ,Pic2 = "MJZeny/legend3.png" , Pic3 = "MJZeny/legend4.png" , Pic4 = "MJZeny/legend5.png"},
new Unit() {Name="Mobilio" , IDNumber = 272011, Description = "Standard", Category = "SUV", AvailQuantity = 5 , TotalQuantity = 0 , Brand = "Honda", Supplier = "Japan" , OrigPrice = 884000, RetailPrice = 920000 , Status = "Normal", Date= " Sept 25, 2018", Pic = "MJZeny/mobilio1.jpg",Pic1 = "MJZeny/mobilio2.jpg" ,Pic2 = "MJZeny/mobilio3.jpg" , Pic3 = "MJZeny/mobilio4.jpg" , Pic4 = "MJZeny/mobilio5.jpg"},
new Unit() {Name="Nsx" , IDNumber = 272012, Description = "Sporty", Category = "Sports Utility", AvailQuantity = 5 , TotalQuantity = 0 , Brand = "Honda", Supplier = "Japan" , OrigPrice = 22734604, RetailPrice =  22956604, Status = "Normal", Date= " Sept 26, 2018", Pic = "MJZeny/nsx1.png",Pic1 = "MJZeny/nsx2.png" ,Pic2 = "MJZeny/nsx3.png" , Pic3 = "MJZeny/nsx4.png" , Pic4 = "MJZeny/nsx5.png"},
new Unit() {Name="Odyssey" , IDNumber = 272013, Description = "Economical", Category = "MVP", AvailQuantity = 5 , TotalQuantity = 0 , Brand = "Honda", Supplier = "Japan" , OrigPrice = 2138000, RetailPrice = 2248000, Status = "Normal", Date= " Sept 27, 2018", Pic = "MJZeny/odyssey1.jpg",Pic1 = "MJZeny/odyssey2.jpg" ,Pic2 = "MJZeny/odyssey3.jpg" , Pic3 = "MJZeny/odyssey4.jpg" , Pic4 = "MJZeny/odyssey5.jpg"},
new Unit() {Name="Pilot" , IDNumber = 272014, Description = "Legendary", Category = "SUV", AvailQuantity = 5 , TotalQuantity = 0 , Brand = "Honda", Supplier = "Japan" , OrigPrice = 1380000, RetailPrice = 1400000 , Status = "Normal", Date= " Sept 28, 2018", Pic = "MJZeny/pilot1.jpg",Pic1 = "MJZeny/pilot2.jpg" ,Pic2 = "MJZeny/pilot3.jpg" , Pic3 = "MJZeny/pilot4.jpg" , Pic4 = "MJZeny/pilot5.jpg"},
new Unit() {Name="s660" , IDNumber = 272015, Description = "Sporty", Category = "Sports Utility", AvailQuantity = 5 , TotalQuantity = 0 , Brand = "Honda", Supplier = "Japan" , OrigPrice =1400000 , RetailPrice = 1680000 , Status = "Normal", Date= " Sept 29, 2018", Pic = "MJZeny/s6601.png",Pic1 = "MJZeny/s6602.png" ,Pic2 = "MJZeny/s6603.png" , Pic3 = "MJZeny/s6604.png" , Pic4 = "MJZeny/s6605.png"},
new Unit() {Name="Dion" , IDNumber = 272016, Description = "Standard", Category = "Van", AvailQuantity = 5 , TotalQuantity = 0 , Brand = "Mitsubishi", Supplier = "Japan" , OrigPrice =1799000 , RetailPrice = 1819100, Status = "Normal", Date= " Sept 30, 2018", Pic = "MJZeny/dion1.jpg",Pic1 = "MJZeny/dion2.jpg" ,Pic2 = "MJZeny/dion3.jpg" , Pic3 = "MJZeny/dion4.jpg" , Pic4 = "MJZeny/dion5.jpg"},
new Unit() {Name="Carisma" , IDNumber = 272017, Description = "", Category = "Sedan", AvailQuantity = 5 , TotalQuantity = 0 , Brand = "Mitsubishi", Supplier = "Japan" , OrigPrice =1215000 , RetailPrice = 1230500 , Status = "Normal", Date= " Oct 1, 2018", Pic = "MJZeny/carisma1.jpg",Pic1 = "MJZeny/carisma2.jpg" ,Pic2 = "MJZeny/carisma3.jpg" , Pic3 = "MJZeny/carisma4.jpg" , Pic4 = "MJZeny/carisma5.jpg"},
new Unit() {Name="Eclipse" , IDNumber = 272018, Description = "Automotive", Category = "Crossover", AvailQuantity = 5 , TotalQuantity = 0 , Brand = "Mitsubishi", Supplier = "Japan" , OrigPrice =1150000, RetailPrice = 1335000 , Status = "Normal", Date= " Sept 24, 2018", Pic = "MJZeny/eclipse1.jpg",Pic1 = "MJZeny/eclipse2.jpg" ,Pic2 = "MJZeny/eclipse3.jpg" , Pic3 = "MJZeny/clipse4.jpg" , Pic4 = "MJZeny/eclipse5.jpg"},
new Unit() {Name="Zinger" , IDNumber = 272019, Description = "Legendary", Category = "SUV", AvailQuantity = 5 , TotalQuantity = 0 , Brand = "Mitsubishi", Supplier = "Japan" , OrigPrice =690000 , RetailPrice = 692100 , Status = "Normal", Date= " Sept 25, 2018", Pic = "MJZeny/zinger1.jpg",Pic1 = "MJZeny/zinger2.jpg" ,Pic2 = "MJZeny/zinger3.jpg" , Pic3 = "MJZeny/zinger4.jpg" , Pic4 = "MJZeny/zinger5.jpg"},
					
					
new Unit() {Name = "Expedition", IDNumber = 412512, Description = "Urban Vehicle", Category = "SUV", AvailQuantity = 5, TotalQuantity = 6, Brand = "Ford", Supplier = "USA", OrigPrice = 2602972, RetailPrice = 3123566, Status = "Normal", Date = "September 22, 2018", Pic = "JocarGhee/Expedition1.png", Pic1 = "JocarGhee/Expedition2.jpg", Pic2 = "JocarGhee/Expedition3.jpg", Pic3 = "JocarGhee/Expedition4.jpg", Pic4 = "JocarGhee/Expedition5.jpg"},
new Unit() {Name = "Fiesta", IDNumber = 413512, Description = "Nice", Category = "Sedan", AvailQuantity = 5, TotalQuantity = 5, Brand = "Ford", Supplier = "USA", OrigPrice = 770317, RetailPrice = 924380, Status = "Normal", Date = "September 25, 2018", Pic = "JocarGhee/fiesta1.png", Pic1 = "JocarGhee/fiesta2.png", Pic2 = "JocarGhee/fiesta3.png", Pic3 = "JocarGhee/fiesta4.png", Pic4 = "JocarGhee/fiesta5.jpg"},
new Unit() {Name = "Explorer", IDNumber = 134512, Description = "Urban Vehicle", Category = "SUV", AvailQuantity = 5, TotalQuantity = 5, Brand = "Ford", Supplier = "USA", OrigPrice = 1742907, RetailPrice = 2091488, Status = "Normal", Date = "September 27, 2018", Pic = "JocarGhee/explorer1.png", Pic1 = "JocarGhee/explorer2.png", Pic2 = "JocarGhee/explorer3.png", Pic3 = "JocarGhee/explorer4.jpg", Pic4 = "JocarGhee/explorer5.jpg"},
new Unit() {Name = "Mustang", IDNumber = 155512, Description = "Elegant", Category = "Sport Car", AvailQuantity = 5, TotalQuantity = 4, Brand = "Ford", Supplier = "USA", OrigPrice = 3033547, RetailPrice = 3640256, Status = "Normal", Date = "September 24, 2018", Pic = "JocarGhee/mustang1.png", Pic1 = "JocarGhee/mustang2.jpg", Pic2 = "JocarGhee/mustang3.png", Pic3 = "JocarGhee/mustang4.jpg", Pic4 = "JocarGhee/mustang5.jpg"},
new Unit() {Name = "Ranger", IDNumber = 166512, Description = "Heavy Duty", Category = "Truck", AvailQuantity = 5, TotalQuantity = 7, Brand = "Ford", Supplier = "USA", OrigPrice = 627967, RetailPrice = 753560, Status = "Normal", Date = "October 01, 2018", Pic = "JocarGhee/ranger1.jpg", Pic1 = "JocarGhee/ranger2.jpg", Pic2 = "JocarGhee/ranger3.jpg", Pic3 = "JocarGhee/ranger4.jpg", Pic4 = "JocarGhee/ranger5.jpg"},
new Unit() {Name = "Focus", IDNumber = 147512, Description = "Nice", Category = "Sedan", AvailQuantity = 5, TotalQuantity = 4, Brand = "Ford", Supplier = "USA", OrigPrice = 973403, RetailPrice = 1168083, Status = "Normal", Date = "September 28, 2018", Pic = "JocarGhee/focus1.png", Pic1 = "JocarGhee/focus2.jpg", Pic2 = "JocarGhee/focus3.jpg", Pic3 = "JocarGhee/focus4.jpg", Pic4 = "JocarGhee/focus5.png"},
new Unit() {Name = "Flex", IDNumber = 185512, Description = "Classic", Category = "SUV", AvailQuantity = 5, TotalQuantity = 3, Brand = "Ford", Supplier = "USA", OrigPrice = 1642313, RetailPrice = 1970775, Status = "Normal", Date = "September 30, 2018", Pic = "JocarGhee/flex1.png", Pic1 = "JocarGhee/flex2.jpg", Pic2 = "JocarGhee/flex3.jpg", Pic3 = "JocarGhee/flex4.png", Pic4 = "JocarGhee/flex5.jpg"},
new Unit() {Name = "Escape", IDNumber = 196512, Description = "Compact SUV for Urban use", Category = "SUV", AvailQuantity = 5, TotalQuantity = 6, Brand = "Ford", Supplier = "USA", OrigPrice = 1298232, RetailPrice = 1557878, Status = "Normal", Date = "September 22, 2018", Pic = "JocarGhee/escape1.png", Pic1 = "JocarGhee/escape2.jpg", Pic2 = "JocarGhee/escape3.jpg", Pic3 = "JocarGhee/escape4.png", Pic4 = "JocarGhee/escape5.png"},
new Unit() {Name = "Transit", IDNumber = 191142, Description = "Family Vehicle", Category = "Van", AvailQuantity = 5, TotalQuantity = 8, Brand = "Ford", Supplier = "USA", OrigPrice = 1755922, RetailPrice = 2107106, Status = "Normal", Date = "September 24, 2018", Pic = "JocarGhee/transit1.png", Pic1 = "JocarGhee/transit2.png", Pic2 = "JocarGhee/transit3.jpg", Pic3 = "JocarGhee/transit4.jpg", Pic4 = "JocarGhee/transit5.png"},
new Unit() {Name = "Econoline", IDNumber = 159212, Description = "Classic", Category = "Van", AvailQuantity = 5, TotalQuantity = 6, Brand = "Ford", Supplier = "USA", OrigPrice = 1068574, RetailPrice = 1282288, Status = "Normal", Date = "September 29, 2018", Pic = "JocarGhee/eco1.jpg", Pic1 = "JocarGhee/eco2.jpg", Pic2 = "JocarGhee/eco3.jpg", Pic3 = "JocarGhee/eco4.jpg", Pic4 = "JocarGhee/eco5.jpg"},
new Unit() {Name = "Freestyle", IDNumber = 144312, Description = "Nice", Category = "SUV", AvailQuantity = 5, TotalQuantity = 5, Brand = "Ford", Supplier = "USA", OrigPrice = 1357884, RetailPrice = 1629460, Status = "Normal", Date = "October 03, 2018", Pic = "JocarGhee/free1.jpg", Pic1 = "JocarGhee/free2.jpg", Pic2 = "JocarGhee/free3.jpg", Pic3 = "JocarGhee/free4.jpg", Pic4 = "JocarGhee/free5.jpg"},
new Unit() {Name = "Edge", IDNumber = 193412, Description = "Elegant", Category = "SUV", AvailQuantity = 5, TotalQuantity = 6, Brand = "Ford", Supplier = "USA", OrigPrice = 1589711, RetailPrice = 1907653, Status = "Normal", Date = "October 01, 2018", Pic = "JocarGhee/edge1.png", Pic1 = "JocarGhee/edge2.jpg", Pic2 = "JocarGhee/edge3.jpg", Pic3 = "JocarGhee/edge4.png", Pic4 = "JocarGhee/edge5.jpg"},
new Unit() {Name = "EcoSport", IDNumber = 519512, Description = "Heavy Duty", Category = "SUV", AvailQuantity = 5, TotalQuantity = 7, Brand = "Ford", Supplier = "USA", OrigPrice = 1084300, RetailPrice = 1301160, Status = "Normal", Date = "October 02, 2018", Pic = "JocarGhee/sport1.jpg", Pic1 = "JocarGhee/sport2.jpg", Pic2 = "JocarGhee/sport3.png", Pic3 = "JocarGhee/sport4.jpg", Pic4 = "JocarGhee/sport5.jpg"},
new Unit() {Name = "F-150", IDNumber = 169612, Description = "High Capacity Vehicle", Category = "Truck", AvailQuantity = 5, TotalQuantity = 5, Brand = "Ford", Supplier = "USA", OrigPrice = 1502403, RetailPrice = 1802883, Status = "Normal", Date = "September 22, 2018", Pic = "JocarGhee/F1.jpg", Pic1 = "JocarGhee/F2.jpg", Pic2 = "JocarGhee/F3.jpg", Pic3 = "JocarGhee/F4.jpg", Pic4 = "JocarGhee/F5.jpg"},
new Unit() {Name = "Super Duty", IDNumber = 197412, Description = "Heavy Duty", Category = "Truck", AvailQuantity = 5, TotalQuantity = 6, Brand = "Ford", Supplier = "USA", OrigPrice = 1806896, RetailPrice = 2168275, Status = "Normal", Date = "September 24, 2018", Pic = "JocarGhee/super1.jpg", Pic1 = "JocarGhee/super2.jpg", Pic2 = "JocarGhee/super3.jpg", Pic3 = "JocarGhee/super4.jpg", Pic4 = "JocarGhee/super5.jpg"},
new Unit() {Name = "Endeavor", IDNumber = 213112, Description = "Elegant", Category = "SUV", AvailQuantity = 5, TotalQuantity = 6, Brand = "Mitsubishi", Supplier = "Japan", OrigPrice = 628780, RetailPrice = 754536, Status = "Normal", Date = "September 22, 2018", Pic = "JocarGhee/endev1.png", Pic1 = "JocarGhee/endev2.png", Pic2 = "JocarGhee/endev3.jpg", Pic3 = "JocarGhee/endev4.jpg", Pic4 = "JocarGhee/endev5.jpg"},
new Unit() {Name = "Celeste", IDNumber = 227112, Description = "Classic", Category = "Sedan", AvailQuantity = 5, TotalQuantity = 5, Brand = "Mitsubishi", Supplier = "Japan", OrigPrice = 178511, RetailPrice = 214213, Status = "Normal", Date = "September 24, 2018", Pic = "JocarGhee/cel1.jpg", Pic1 = "JocarGhee/cel2.jpg", Pic2 = "JocarGhee/cel3.jpg", Pic3 = "JocarGhee/cel4.jpg", Pic4 = "JocarGhee/cel5.jpg"},
new Unit() {Name = "Galant", IDNumber = 238112, Description = "Classic", Category = "Sedan", AvailQuantity = 5, TotalQuantity = 7, Brand = "Mitsubishi", Supplier = "Japan", OrigPrice = 319948, RetailPrice = 383937, Status = "Normal", Date = "September 25, 2018", Pic = "JocarGhee/gal1.jpg", Pic1 = "JocarGhee/gal2.png", Pic2 = "JocarGhee/gal3.jpg", Pic3 = "JocarGhee/gal4.jpg", Pic4 = "JocarGhee/gal5.jpg"},
new Unit() {Name = "Triton", IDNumber = 249112, Description = "High Capacity Vehicle", Category = "Pickup Truck", AvailQuantity = 5, TotalQuantity = 5, Brand = "Mitsubishi", Supplier = "Japan", OrigPrice = 2433779, RetailPrice = 2920534, Status = "Normal", Date = "September 26, 2018", Pic = "JocarGhee/tri1.jpg", Pic1 = "JocarGhee/tri2.jpg", Pic2 = "JocarGhee/tri3.jpg", Pic3 = "JocarGhee/tri4.jpg", Pic4 = "JocarGhee/tri5.jpg"},
new Unit() {Name = "L-300", IDNumber = 255112, Description = "Heavy Duty", Category = "Truck", AvailQuantity = 5, TotalQuantity = 8, Brand = "Mitsubishi", Supplier = "Japan", OrigPrice = 620000, RetailPrice = 744000, Status = "Normal", Date = "September 27, 2018", Pic = "JocarGhee/L1.jpg", Pic1 = "JocarGhee/L2.jpg", Pic2 = "JocarGhee/L3.png", Pic3 = "JocarGhee/L4.jpg", Pic4 = "JocarGhee/L5.jpg"},
			
new Unit() {Name="Baleno", IDNumber = 123568, Description = "5 Seater Car", Category="Sub-compact", AvailQuantity = 9, TotalQuantity = 0, Brand = "Suzuki", Supplier = "Japan", OrigPrice =  650000, RetailPrice =  695000, Status = "Normal", Date = "January 19, 2018", Pic="JamesEarl/SuzukiBaleno.jpg", Pic1="JamesEarl/SuzukiBaleno1.jpg", Pic2 = "JamesEarl/SuzukiBaleno2.jpg", Pic3 = "JamesEarl/SuzukiBaleno3.jpg", Pic4 = "JamesEarl/SuzukiBaleno4.jpg"},
new Unit() {Name="WagonR", IDNumber = 154289, Description = "Spacious Budget hatchback", Category="Hatchback", AvailQuantity = 10, TotalQuantity = 0, Brand = "Suzuki", Supplier = "Japan", OrigPrice =  560000, RetailPrice =  600000, Status = "Normal", Date = "August 18, 2018", Pic="JamesEarl/SuzukiWagonR.jpg", Pic1="JamesEarl/SuzukiWagonR1.jpg", Pic2 = "JamesEarl/SuzukiWagonR2.jpg", Pic3 = "JamesEarl/SuzukiWagonR3.jpg", Pic4 = "JamesEarl/SuzukiWagonR4.jpg"},
new Unit() {Name="SCross", IDNumber = 121245, Description = "Crossover styling with cruise control", Category="SUV", AvailQuantity = 8, TotalQuantity = 0, Brand = "Suzuki", Supplier = "Japan", OrigPrice =  640000, RetailPrice =  650000, Status = "Normal", Date = "October 22, 2018", Pic="JamesEarl/SuzukiSCross.jpg", Pic1="JamesEarl/SuzukiSCross1.jpg", Pic2 = "JamesEarl/SuzukiSCross2.jpg", Pic3 = "JamesEarl/SuzukiSCross3.jpg", Pic4 = "JamesEarl/SuzukiSCross4.jpg"},
new Unit() {Name="Ignis", IDNumber = 178932, Description = "Rugged City Car", Category="SUV", AvailQuantity = 9, TotalQuantity = 0, Brand = "Suzuki", Supplier = "Japan", OrigPrice =  630000, RetailPrice =  750000, Status = "Normal", Date = "June 23, 2018", Pic="JamesEarl/SuzukiIgnis.jpg", Pic1="JamesEarl/SuzukiIgnis1.jpg", Pic2 = "JamesEarl/SuzukiIgnis2.jpg", Pic3 = "JamesEarl/SuzukiIgnis3.jpg", Pic4 = "JamesEarl/SuzukiIgnis4.jpg"},
new Unit() {Name="Alto", IDNumber = 154037, Description = "PintSize City Car", Category="Sub-compact", AvailQuantity = 8, TotalQuantity = 0, Brand = "Suzuki", Supplier = "Japan", OrigPrice =  500000, RetailPrice =  600000, Status = "Normal", Date = "September 21, 2018", Pic="JamesEarl/SuzukiAlto.jpg", Pic1="JamesEarl/SuzukiAlto1.jpg", Pic2 = "JamesEarl/SuzukiAlto2.jpg", Pic3 = "JamesEarl/SuzukiAlto3.jpg", Pic4 = "JamesEarl/SuzukiAlto4.jpg"},
new Unit() {Name="Apv", IDNumber = 161902, Description = "All Purpose Car", Category="Van", AvailQuantity = 10, TotalQuantity = 0, Brand = "Suzuki", Supplier = "Japan", OrigPrice =  808000, RetailPrice =  828000, Status = "Normal", Date = "September 23, 2018", Pic="JamesEarl/SuzukiApv.jpg", Pic1="JamesEarl/SuzukiApv1.jpg", Pic2 = "JamesEarl/SuzukiApv2.jpg", Pic3 = "JamesEarl/SuzukiApv3.jpg", Pic4 = "JamesEarl/SuzukiApv4.jpg"},
new Unit() {Name="Celerio", IDNumber = 152345, Description = "Subcompact Car Market", Category="Hatchback", AvailQuantity = 7, TotalQuantity = 0, Brand = "Suzuki", Supplier = "Japan", OrigPrice =  598000, RetailPrice =  608000, Status = "Normal", Date = "September 25, 2018", Pic="JamesEarl/SuzukiCELERIO.jpg", Pic1="JamesEarl/SuzukiCELERIO1.jpg", Pic2 = "JamesEarl/SuzukiCELERIO2.jpg", Pic3 = "JamesEarl/SuzukiCELERIO3.jpg", Pic4 = "JamesEarl/SuzukiCELERIO4.jpg"},
new Unit() {Name="Ciaz", IDNumber = 153034, Description = "Big Boot Space", Category="Sub-compact", AvailQuantity = 9, TotalQuantity = 0, Brand = "Suzuki", Supplier = "Japan", OrigPrice =  845000, RetailPrice =  995000, Status = "Normal", Date = "September 26, 2018", Pic="JamesEarl/SuzukiCiaz.jpg", Pic1="JamesEarl/SuzukiCiaz1.jpg", Pic2 = "JamesEarl/SuzukiCiaz2.jpg", Pic3 = "JamesEarl/SuzukiCiaz3.jpg", Pic4 = "JamesEarl/SuzukiCiaz4.jpg"},
new Unit() {Name="Dzire", IDNumber = 123568, Description = "Car Roomier", Category="Sub-compact", AvailQuantity = 10, TotalQuantity = 0, Brand = "Suzuki", Supplier = "Japan", OrigPrice =  698000, RetailPrice =  700000, Status = "Normal", Date = "September 27, 2018", Pic="JamesEarl/SuzukiDZIRE.jpg", Pic1="JamesEarl/SuzukiDZIRE1.jpg", Pic2 = "JamesEarl/SuzukiDZIRE2.jpg", Pic3 = "JamesEarl/SuzukiDZIRE3.jpg", Pic4 = "JamesEarl/SuzukiDZIRE4.jpg"},
new Unit() {Name="Ertiga", IDNumber = 147258, Description = "Life Utility Car", Category="SUV", AvailQuantity = 6, TotalQuantity = 0, Brand = "Suzuki", Supplier = "Japan", OrigPrice =  865000, RetailPrice =  880000, Status = "Normal", Date = "September 28, 2018", Pic="JamesEarl/SuzukiERTIGA.jpg", Pic1="JamesEarl/SuzukiERTIGA1.jpg", Pic2 = "JamesEarl/SuzukiERTIGA2.jpg", Pic3 = "JamesEarl/SuzukiERTIGA3.jpg", Pic4 = "JamesEarl/SuzukiERTIGA4.jpg"},
new Unit() {Name="Grand Vitara", IDNumber = 147369, Description = "Road Oriented Crossover", Category="SUV", AvailQuantity = 9, TotalQuantity = 0, Brand = "Suzuki", Supplier = "Japan", OrigPrice =  1210000, RetailPrice =  1300000,  Status = "Normal", Date = "September 29, 2018", Pic="JamesEarl/SuzukiGRANDVITARA .jpg", Pic1="JamesEarl/SuzukiGRANDVITARA1.jpg", Pic2 = "JamesEarl/SuzukiGRANDVITARA2.jpg", Pic3 = "JamesEarl/SuzukiGRANDVITARA3.jpg", Pic4 = "JamesEarl/SuzukiGRANDVITARA4.jpg"},
new Unit() {Name="Jimny", IDNumber = 256314, Description = "Four Wheel Drive Car", Category="SUV", AvailQuantity = 9, TotalQuantity = 0, Brand = "Suzuki", Supplier = "Japan", OrigPrice =  965000,  RetailPrice =  995000, Status = "Normal", Date = "September 30, 2018", Pic="JamesEarl/SuzukiJIMMY.jpg", Pic1="JamesEarl/SuzukiJIMMY1.jpg", Pic2 = "JamesEarl/SuzukiJIMMY2.jpg", Pic3 = "JamesEarl/SuzukiJIMMY3.jpg", Pic4 = "JamesEarl/SuzukiJIMMY4.jpg"},
new Unit() {Name="Montero Sport", IDNumber = 145263, Description = "Endeavor Car", Category="SUV", AvailQuantity = 10, TotalQuantity = 0, Brand = "Mitsubishi", Supplier = "Japan", OrigPrice =  1719000, RetailPrice =  1950000, Status = "Normal", Date = "September 31, 2018", Pic="JamesEarl/MitsubishiMONTEROSPORT.jpg", Pic1="JamesEarl/MitsubishiMONTEROSPORT1.jpg", Pic2 = "JamesEarl/MitsubishiMONTEROSPORT2.jpg", Pic3 = "JamesEarl/MitsubishiMONTEROSPORT3.jpg", Pic4 = "JamesEarl/MitsubishiMONTEROSPORT4.jpg"},
new Unit() {Name="Pajero", IDNumber = 478855, Description = "Short Wheelbase", Category="SUV", AvailQuantity = 5, TotalQuantity = 0, Brand = "Mitsubishi", Supplier = "Japan", OrigPrice =  2842000, RetailPrice =  2902000, Status = "Normal", Date = "October 1, 2018", Pic="JamesEarl/MitsubishiPAJERO.jpg", Pic1="JamesEarl/MitsubishiPAJERO1.jpg", Pic2 = "JamesEarl/MitsubishiPAJERO2.jpg", Pic3 = "JamesEarl/MitsubishiPAJERO3.jpg", Pic4 = "JamesEarl/MitsubishiPAJERO4.jpg"},
new Unit() {Name="Strada", IDNumber = 789456, Description = "Traditional Pickup", Category="Pickup", AvailQuantity = 7, TotalQuantity = 0, Brand = "Mitsubishi", Supplier = "Japan", OrigPrice =  1048000, RetailPrice =  1960000, Status = "Normal", Date = "October 1, 2018", Pic="JamesEarl/MitsubishiStrada.jpg", Pic1="JamesEarl/MitsubishiStrada1.jpg", Pic2 = "JamesEarl/MitsubishiStrada2.jpg", Pic3 = "JamesEarl/MitsubishiStrada3.jpg", Pic4 = "JamesEarl/MitsubishiStrada4.jpg"},
new Unit() {Name="Super Carry", IDNumber = 112244, Description = "Transportation", Category="SUV", AvailQuantity = 9, TotalQuantity = 0, Brand = "Suzuki", Supplier = "Japan", OrigPrice =  539000, RetailPrice =  560000, Status = "Normal", Date = "October 2, 2018", Pic="JamesEarl/SuzukiSUPERCARRY.jpg", Pic1="JamesEarl/SuzukiSUPERCARRY1.jpg", Pic2 = "JamesEarl/SuzukiSUPERCARRY2.jpg", Pic3 = "JamesEarl/SuzukiSUPERCARRY3.jpg", Pic4 = "JamesEarl/SuzukiSUPERCARRY4.jpg"},
new Unit() {Name="Swift", IDNumber = 159357, Description = "Supermini Car", Category="Sub-compact", AvailQuantity = 10 ,TotalQuantity = 0, Brand = "Suzuki", Supplier = "Japan", OrigPrice =  799000, RetailPrice =  820000, Status = "Normal", Date = "October 2, 2018", Pic="JamesEarl/SuzukiSWIFT.jpg", Pic1="JamesEarl/SuzukiSWIFT1.jpg", Pic2 = "JamesEarl/SuzukiSWIFT2.jpg", Pic3 = "JamesEarl/SuzukiSWIFT3.jpg", Pic4 = "JamesEarl/SuzukiSWIFT4.jpg"},
new Unit() {Name="Vitara", IDNumber = 357951, Description = "Compact Crossover", Category="Sub-compact", AvailQuantity = 10 ,TotalQuantity = 0, Brand = "Suzuki", Supplier = "Japan", OrigPrice =  988000, RetailPrice =  1000000, Status = "Normal", Date = "October 3, 2018", Pic="JamesEarl/SuzukiVITARA.jpg", Pic1="JamesEarl/SuzukiVITARA1.jpg", Pic2 = "JamesEarl/SuzukiVITARA2.jpg", Pic3 = "JamesEarl/SuzukiVITARA3.jpg", Pic4 = "JamesEarl/SuzukiVITARA4.jpg"},
new Unit() {Name="Xpander", IDNumber = 357951, Description = "Seven Seater MPV", Category="SUV", AvailQuantity = 10 ,TotalQuantity = 0, Brand = "Mitsubishi", Supplier = "Japan", OrigPrice =  960000, RetailPrice =  1200000, Status = "Normal", Date = "October 3, 2018", Pic="JamesEarl/MitsubishiXPANDER.jpg", Pic1="JamesEarl/MitsubishiXPANDER1.jpg", Pic2 = "JamesEarl/MitsubishiXPANDER2.jpg", Pic3 = "JamesEarl/MitsubishiXPANDER3.jpg", Pic4 = "JamesEarl/MitsubishiXPANDER4.jpg"},

new Unit() {Name="Grand Starex", IDNumber = 253001, Description = "Affordable", Category = "Van", AvailQuantity = 5 , TotalQuantity = 0 , Brand = "Hyundai", Supplier = "Korea" , OrigPrice = 2085000 , RetailPrice = 3006500, Status = "Normal", Date = "Sept 24, 2018", Pic = "CqaerJayann/GS1.jpg",Pic1 = "CqaerJayann/GS2.jpg" ,Pic2 = "CqaerJayann/GS3.jpg" , Pic3 = "CqaerJayann/GS4.jpg" , Pic4 = "CqaerJayann/GS5.jpg"},
new Unit() {Name="Eon" , IDNumber = 253002, Description = "Economical", Category = "Hatchback", AvailQuantity = 5 , TotalQuantity = 0 , Brand = "Hyundai", Supplier = "Korea" , OrigPrice = 508000, RetailPrice = 520200, Status = "Normal", Date = "Sept 25, 2018", Pic = "CqaerJayann/Eon1.jpg",Pic1 = "CqaerJayann/Eon2.jpg" ,Pic2 = "CqaerJayann/Eon3.png" , Pic3 = "CqaerJayann/Eon4.jpg" , Pic4 = "CqaerJayann/Eon5.jpg"},
new Unit() {Name="Tucson" , IDNumber = 253003, Description = "Sporty", Category = "Sports Utility", AvailQuantity = 5 , TotalQuantity = 0 , Brand = "Hyundai", Supplier = "Korea" , OrigPrice = 1163000, RetailPrice = 1256700 , Status = "Normal", Date = "Sept 26, 2018", Pic = "CqaerJayann/T1.jpg",Pic1 = "CqaerJayann/T2.jpg" ,Pic2 = "CqaerJayann/T3.jpg" , Pic3 = "CqaerJayann/T4.jpg" , Pic4 = "CqaerJayann/T5.jpg"},
new Unit() {Name="Accent" , IDNumber = 253004, Description = "Elegant", Category = "Sub-compact", AvailQuantity = 5 , TotalQuantity = 0 , Brand = "Hyundai", Supplier = "Korea" , OrigPrice = 695000, RetailPrice = 725500 , Status = "Normal", Date = "Sept 27, 2018", Pic = "CqaerJayann/Acc1.png",Pic1 = "CqaerJayann/Acc2.png" ,Pic2 = "CqaerJayann/Acc3.png" , Pic3 = "CqaerJayann/Acc4.jpg" , Pic4 = "CqaerJayann/Acc5.png"},
new Unit() {Name="Grand Santa Fe" , IDNumber = 253005, Description = "Sporty", Category = "Sports Utility", AvailQuantity = 5 , TotalQuantity = 0 , Brand = "Hyundai", Supplier = "Korea" , OrigPrice = 1840000, RetailPrice = 1906000 , Status = "Normal", Date = "Sept 28, 2018", Pic = "CqaerJayann/GSF1.jpg",Pic1 = "CqaerJayann/GSF2.jpg" ,Pic2 = "CqaerJayann/GSF3.jpg" , Pic3 = "CqaerJayann/GSF4.jpg" , Pic4 = "CqaerJayann/GSF5.jpg"},
new Unit() {Name="Creta" , IDNumber = 253006, Description = "Sporty", Category = "Sports Utility", AvailQuantity = 5 , TotalQuantity = 0 , Brand = "Hyundai", Supplier = "Korea" , OrigPrice = 1038000, RetailPrice = 1204200, Status = "Normal", Date = "Sept 29, 2018", Pic = "CqaerJayann/C1.jpg",Pic1 = "CqaerJayann/C2.jpg" ,Pic2 = "CqaerJayann/C3.jpg" , Pic3 = "CqaerJayann/C4.jpg" , Pic4 = "CqaerJayann/C5.jpg"},
new Unit() {Name="Getz" , IDNumber = 253007, Description = "Economical", Category = "Hatchback", AvailQuantity = 5 , TotalQuantity = 0 , Brand = "Hyundai", Supplier = "Korea" , OrigPrice = 895000, RetailPrice = 910500 , Status = "Normal", Date = "Sept 30, 2018", Pic = "CqaerJayann/G1.jpg",Pic1 = "CqaerJayann/G2.jpg" ,Pic2 = "CqaerJayann/G3.jpg" , Pic3 = "CqaerJayann/G4.jpg" , Pic4 = "CqaerJayann/G5.jpg"},
new Unit() {Name="Genesis " , IDNumber = 253008, Description = "Luxurious", Category = "Coupe", AvailQuantity = 5 , TotalQuantity = 0 , Brand = "Hyundai", Supplier = "Korea" , OrigPrice = 1384000, RetailPrice = 1405600 , Status = "Normal", Date = "Sept 22, 2018", Pic = "CqaerJayann/Gen1.png",Pic1 = "CqaerJayann/Gen2.jpg" ,Pic2 = "CqaerJayann/Gen3.jpg" , Pic3 = "CqaerJayann/Gen4.jpg" , Pic4 = "CqaerJayann/Gen5.jpg"},
new Unit() {Name="Kona" , IDNumber = 253009, Description = "Sporty", Category = "Sports Utility", AvailQuantity = 5 , TotalQuantity = 0 , Brand = "Hyundai", Supplier = "Korea" , OrigPrice = 1048000, RetailPrice = 1100200 , Status = "Normal", Date = "Oct 1, 2018", Pic = "CqaerJayann/Ko1.jpg",Pic1 = "CqaerJayann/Ko2.jpg" ,Pic2 = "CqaerJayann/Ko3.jpg" , Pic3 = "CqaerJayann/Ko4.jpg" , Pic4 = "CqaerJayann/Ko5.jpg"},
new Unit() {Name="Grand i10" , IDNumber = 253010, Description = "Economical", Category = "Hatchback", AvailQuantity = 5 , TotalQuantity = 0 , Brand = "Hyundai", Supplier = "Korea" , OrigPrice = 920000, RetailPrice = 980800 , Status = "Normal", Date = "Sept 24, 2018", Pic = "CqaerJayann/i101.jpg",Pic1 = "CqaerJayann/i102.jpg" ,Pic2 = "CqaerJayann/i103.png" , Pic3 = "CqaerJayann/i104.jpg" , Pic4 = "CqaerJayann/i105.jpg"},
new Unit() {Name="Veloster" , IDNumber = 253011, Description = "Standard", Category = "Mid-size", AvailQuantity = 5 , TotalQuantity = 0 , Brand = "Hyundai", Supplier = "Korea" , OrigPrice = 1060000, RetailPrice = 1100000 , Status = "Normal", Date = "Sept 25, 2018", Pic = "CqaerJayann/V1.jpg",Pic1 = "CqaerJayann/V2.jpg" ,Pic2 = "CqaerJayann/V3.jpg" , Pic3 = "CqaerJayann/V4.jpg" , Pic4 = "CqaerJayann/V5.png"},
new Unit() {Name="Elantra" , IDNumber = 253012, Description = "Classic", Category = "Compact", AvailQuantity = 5 , TotalQuantity = 0 , Brand = "Hyundai", Supplier = "Korea" , OrigPrice = 970000, RetailPrice =  990000, Status = "Normal", Date = "Sept 26, 2018", Pic = "CqaerJayann/El1.png",Pic1 = "CqaerJayann/El2.jpg" ,Pic2 = "CqaerJayann/El3.jpg" , Pic3 = "CqaerJayann/El4.jpg" , Pic4 = "CqaerJayann/El5.jpg"},
new Unit() {Name="i20" , IDNumber = 253013, Description = "Economical", Category = "Hatchback", AvailQuantity = 5 , TotalQuantity = 0 , Brand = "Hyundai", Supplier = "Korea" , OrigPrice = 945000, RetailPrice = 970500, Status = "Normal", Date = "Sept 27, 2018", Pic = "CqaerJayann/i201.jpg",Pic1 = "CqaerJayann/i202.jpg" ,Pic2 = "CqaerJayann/i203.jpg" , Pic3 = "CqaerJayann/i204.png" , Pic4 = "CqaerJayann/i205.jpg"},
new Unit() {Name="Sonata" , IDNumber = 253014, Description = "Legendary", Category = "Sedan", AvailQuantity = 5 , TotalQuantity = 0 , Brand = "Hyundai", Supplier = "Korea" , OrigPrice = 1698000, RetailPrice = 1758200 , Status = "Normal", Date = "Sept 28, 2018", Pic = "CqaerJayann/Son1.jpg",Pic1 = "CqaerJayann/Son2.jpg" ,Pic2 = "CqaerJayann/Son3.jpg" , Pic3 = "CqaerJayann/Son4.jpg" , Pic4 = "CqaerJayann/Son5.jpg"},
new Unit() {Name="i30" , IDNumber = 253015, Description = "Limitless", Category = "Crossover", AvailQuantity = 5 , TotalQuantity = 0 , Brand = "Hyundai", Supplier = "Korea" , OrigPrice =950000 , RetailPrice = 1020000 , Status = "Normal", Date = "Sept 29, 2018", Pic = "CqaerJayann/i301.png",Pic1 = "CqaerJayann/i302.jpg" ,Pic2 = "CqaerJayann/i303.png" , Pic3 = "CqaerJayann/i304.jpg" , Pic4 = "CqaerJayann/i305.jpg"},
new Unit() {Name="Lancer X" , IDNumber = 264000, Description = "Sporty", Category = "Sports Utility", AvailQuantity = 5 , TotalQuantity = 0 , Brand = "Mitsubishi", Supplier = "Japan" , OrigPrice =1799000 , RetailPrice = 1859100, Status = "Normal", Date = "Sept 30, 2018", Pic = "CqaerJayann/LX1.jpg",Pic1 = "CqaerJayann/LX2.jpg" ,Pic2 = "CqaerJayann/LX3.jpg" , Pic3 = "CqaerJayann/LX4.jpg" , Pic4 = "CqaerJayann/LX5.jpg"},
new Unit() {Name="Asx" , IDNumber = 264001, Description = "Sporty", Category = "Sports Utility", AvailQuantity = 5 , TotalQuantity = 0 , Brand = "Mitsubishi", Supplier = "Japan" , OrigPrice =1215000 , RetailPrice = 1303500 , Status = "Normal", Date = "Oct 1, 2018", Pic = "CqaerJayann/Asx1.jpg",Pic1 = "CqaerJayann/Asx2.jpg" ,Pic2 = "CqaerJayann/Asx3.jpg" , Pic3 = "CqaerJayann/Asx4.jpg" , Pic4 = "CqaerJayann/Asx5.jpg"},
new Unit() {Name="i-MiEV" , IDNumber = 264002, Description = "Automotive", Category = "City Car", AvailQuantity = 5 , TotalQuantity = 0 , Brand = "Mitsubishi", Supplier = "Japan" , OrigPrice =1150000, RetailPrice = 1225000 , Status = "Normal", Date = "Sept 24, 2018", Pic = "CqaerJayann/im1.jpg",Pic1 = "CqaerJayann/im2.jpg" ,Pic2 = "CqaerJayann/im3.jpg" , Pic3 = "CqaerJayann/im4.JPG" , Pic4 = "CqaerJayann/im5.jpg"},
new Unit() {Name="Mirage G4" , IDNumber = 264003, Description = "Legendary", Category = "Sedan", AvailQuantity = 5 , TotalQuantity = 0 , Brand = "Mitsubishi", Supplier = "Japan" , OrigPrice =769000 , RetailPrice = 800100 , Status = "Normal", Date = "Sept 25, 2018", Pic = "CqaerJayann/Mir1.png",Pic1 = "CqaerJayann/Mir2.jpg" ,Pic2 = "CqaerJayann/Mir3.jpg" , Pic3 = "CqaerJayann/Mir4.jpg" , Pic4 = "CqaerJayann/Mir5.jpg"},


			};
			foreach(Unit Unit in weapon_list_)
			{
				TotalInventory = TotalInventory + Unit.AvailQuantity;
			}
			RefeshView();
			}//reload the list view.
		void ListViewItem_MouseDoubleClick(object sender, System.Windows.Input.MouseButtonEventArgs e) 
			{ //if item is selected via double click event, open a window and pass the selected data.
				var selected_item = weapon_view.SelectedItem as Unit; //get the selected item from the list.
				if(selected_item != null) { //if it is not null, meaning there is a selected item.
				var window = new Window2 (selected_item); 
				window.ShowDialog(); 
				RefeshView();
				}
			}
		void RefeshView() 
			{ //this will update the view (refresh display)
				weapon_view.ItemsSource = null; //set to null first.
				weapon_view.ItemsSource = weapon_list_; //update the view with the list.
			var sort_items = new List<string>();
			sort_items.Add("Name");
			SortItems(sort_items, ListSortDirection.Ascending);
				totalinventorybox.Text = TotalInventory.ToString();
				totalprofitbox.Text = TotalProfit.ToString();
				customerbox.Text = TotalCustomers.ToString();
				totalcarsbox.Text = TotalSold.ToString();
				returnedbox.Text = TotalReturned.ToString();
				disposedbox.Text = TotalDisposed.ToString();
				unsoldbox.Text = TotalUnsold.ToString();
			}
		
		void GroupItems()
		{
			var view = (CollectionView)CollectionViewSource.GetDefaultView(weapon_view.ItemsSource);
			view.GroupDescriptions.Clear();
			var groupDescription = new PropertyGroupDescription(GroupBinding);
			view.GroupDescriptions.Add(groupDescription);
		}
		void SortItems(List<string> sortItems, ListSortDirection sortDirection)
		{
			var view = (CollectionView)CollectionViewSource.GetDefaultView(weapon_view.ItemsSource);
			foreach(var item in sortItems){
				var sortDescription = new SortDescription(item,sortDirection);
				view.SortDescriptions.Add(sortDescription);
			}
		}
		
		void Purchase_btn_Click(object sender, RoutedEventArgs e)
		{
			var data = weapon_view.SelectedItem as Unit; //get the selected item from list.
			if(data != null) { //check if the selected item is not null.
			var view_window = new Window2(data); 
			view_window.addBtn.IsEnabled= true;
			view_window.datebox.IsReadOnly = false;
			view_window.purchasebox.IsEnabled = true;
			view_window.ShowDialog();
				if(view_window.returntype == 1)
				{
					return;
				}
			TotalInventory = TotalInventory + view_window.quantity;
			MessageBox.Show(data.Name + "'s Quantity is updated!!");
			}
			
			RefeshView();
		}
		
		void Sell_btn_Click(object sender, RoutedEventArgs e)
		{
			var data = weapon_view.SelectedItem as Unit; //get the selected item from list.
			if(data != null) { //check if the selected item is not null.
				var view_window = new Window2(data); 
				view_window.sellbox.IsEnabled = true;
				view_window.sellBtn.IsEnabled= true;
				view_window.ShowDialog();
				if(view_window.returntype == 1)
				{
					return;
				}
				MessageBox.Show(data.Name + " has been added to the cart!!");
				var selected_item = weapon_view.SelectedItem as Unit;
				selection_list_.Add(selected_item);
				if(selection_list_.HasDuplicates())
					{
					selection_list_.Remove(selected_item);
					}
				RefeshView1();
				}
				RefeshView();
		}
		
		void EditBtn_Click(object sender, RoutedEventArgs e)
		{
			var data = weapon_view.SelectedItem as Unit; //get the selected item from list.
			if(data != null) { //check if the selected item is not null.
			var view_window = new Window2(data);  
			view_window.namebox.IsReadOnly = false;
			view_window.descbox.IsReadOnly = false;
			view_window.brandbox.IsReadOnly = false;
			view_window.supplybox.IsReadOnly = false;
			view_window.pricebox.IsReadOnly = false;
			view_window.retailpricebox.IsReadOnly = false;
			view_window.categorybox.IsReadOnly = false;
			view_window.statusbox.IsEnabled = true;
			view_window.ShowDialog();
			MessageBox.Show(data.Name + " is updated!!.");
			}
			RefeshView();
		}
		
		void RefeshView1() 
			{ //this will update the view (refresh display)
				selected_view.ItemsSource = null; //set to null first.
				selected_view.ItemsSource = selection_list_; //update the view with the list.
			}
		void confirm_btn_Click(object sender, RoutedEventArgs e)
		{
			var data = selected_view.SelectedItem as Unit; //get the selected item from list.
			if(data == null)
			{
				MessageBox.Show("Please select from list before confirming purchase, thank you!","Error", MessageBoxButton.OK,MessageBoxImage.Exclamation);
				return;
			}
			if(data != null) {
				var result = MessageBox.Show("Are you sure, the total price is P"+data.TotalPriceSell, "Confirmation", MessageBoxButton.YesNo, MessageBoxImage.Exclamation);
				if(result == MessageBoxResult.No){
					return;
					}
				TotalCustomers++;
				TotalSold = TotalSold + data.Quantity;
				TotalProfit = data.TotalPriceSell - (data.OrigPrice * data.Quantity);
				selection_list_.Remove (data);
				MessageBox.Show("Thank you for your purchase!", "Thank You!", MessageBoxButton.OK, MessageBoxImage.Exclamation);
				RefeshView();
				RefeshView1();
			}
			}
		
		void remove_btn_Click(object sender, RoutedEventArgs e)
		{
			var data = selected_view.SelectedItem as Unit; //get the selected item from list 
			if(data != null){ //check if the selected item is not null.mu
				var result = MessageBox.Show("Are you sure your want to delete the selected Car from your cart?",
			                             "Warning!", MessageBoxButton.YesNo, MessageBoxImage.Warning);
			if(result == MessageBoxResult.Yes){
					
			foreach(Unit Unit in weapon_list_)
			{
				if(data.Name == Unit.Name)
				{
					Unit.AvailQuantity = Unit.AvailQuantity + data.Quantity;
				}
			}
				if(selection_list_.Remove (data)) { //remove the data from the weapon list.
				MessageBox.Show("Selected Car is deleted!."); 
				RefeshView(); //reload the list view.
				RefeshView1();
				}
			}
			}
		}
		void clear_btn_Click(object sender, RoutedEventArgs e)
		{
			var result = MessageBox.Show("Are you sure your want to clear the list ?",
			                             "Warning!", MessageBoxButton.YesNo, MessageBoxImage.Warning);
			if(result == MessageBoxResult.Yes){ //if Yes is selected, clear the list.
				
				foreach(Unit Unit1 in selection_list_)
				{
							
					foreach(Unit Unit in weapon_list_)
					{
						if(Unit1.Name == Unit.Name)
						{
							Unit.AvailQuantity = Unit.AvailQuantity + Unit1.Quantity;
						}
			
					}
			}
			selection_list_.Clear(); //reload the list view.
			RefeshView();
			RefeshView1();
	        }
		}
		
		void Select_btn_Click(object sender, RoutedEventArgs e)
		{ //returned items
			var selected_item = weapon_view.SelectedItem as Unit;
			if (selected_item != null)
			{
			if (selected_item.Status != "Defective")
			{
				MessageBox.Show("Error! Please change the status to 'Defective' in order to Return Product");
				return;
			}
			TotalReturned = TotalReturned + selected_item.AvailQuantity;
			TotalUnsold = TotalUnsold + selected_item.AvailQuantity;
			selected_item.AvailQuantity = 0;
			selected_item.Status = "Returned";
			MessageBox.Show("You have successfully returned item!");
			RefeshView();
			}
		}
		void Dispose_btn_Click(object sender, RoutedEventArgs e)
		{
			var selected_item = weapon_view.SelectedItem as Unit;
			if (selected_item != null)
			{
			if (selected_item.Status != "Defective")
			{
				MessageBox.Show("Error! Please change the status to 'Defective' in order to Dispose Product");
				return;
			}
			TotalDisposed = TotalDisposed + selected_item.AvailQuantity;
			TotalUnsold = TotalUnsold + selected_item.AvailQuantity;
			selected_item.AvailQuantity = 0;
			selected_item.Status = "Disposed";
			MessageBox.Show("You have successfully disposed item!");
			RefeshView();
			}
		}
		void dashboard_btn_Click(object sender, RoutedEventArgs e)
		{
			CarControl.SelectedIndex = 0;
		}
		
		void purchaseCar_btn_Click(object sender, RoutedEventArgs e)
		{
			allbutton_Close();
			purchase_btn.IsEnabled = true;
			CarControl.SelectedIndex = 1;
		}
		
		void sellCar_btn_Click(object sender, RoutedEventArgs e)
		{
			allbutton_Close();
			sell_btn.IsEnabled = true;
			confirmsell_btn.IsEnabled = true;
			removeselect_btn.IsEnabled = true;
			clear_btn.IsEnabled = true;
			CarControl.SelectedIndex = 1;
		}
		
		void returnCar_btn_Click(object sender, RoutedEventArgs e)
		{
			allbutton_Close();
			select_btn.IsEnabled = true;
			CarControl.SelectedIndex = 1;
		}
		
		void disposeCar_btn_Click(object sender, RoutedEventArgs e)
		{
			allbutton_Close();
			dispose_btn.IsEnabled = true;
			CarControl.SelectedIndex = 1;
		}
		
		void viewall_btn_Click(object sender, RoutedEventArgs e)
		{
			CarControl.SelectedIndex = 1;
			RefeshView();
		}
		
		void viewbrand_btn_Click(object sender, RoutedEventArgs e)
		{
			GroupBinding = "Category";
			CarControl.SelectedIndex = 1;
			GroupItems();
			RefeshView();
		}
		
		void viewstatus_btn_Click(object sender, RoutedEventArgs e)
		{
			GroupBinding = "Status";	
			CarControl.SelectedIndex = 1;
			GroupItems();
			RefeshView();
		}
		
			
		void viewcategory_btn_Click(object sender, RoutedEventArgs e)
		{
			GroupBinding = "Brand";	
			CarControl.SelectedIndex = 1;
			GroupItems();
			RefeshView();
		}
		
		void update_btn_Click(object sender, RoutedEventArgs e)
		{
			allbutton_Close();
			edit_btn.IsEnabled = true;
			CarControl.SelectedIndex = 1;
		}
		
		void viewcart_btn_Click(object sender, RoutedEventArgs e)
		{
			CarControl.SelectedIndex = 2;
		}
		
		void allbutton_Close()
		{
			confirmsell_btn.IsEnabled = false;
			removeselect_btn.IsEnabled = false;
			clear_btn.IsEnabled = false;
			select_btn.IsEnabled = false;
			dispose_btn.IsEnabled = false;
			purchase_btn.IsEnabled = false;
			sell_btn.IsEnabled = false;
			edit_btn.IsEnabled = false;
		}
	}
	
	
	
	
	
	
	
	
	
	
	//checks for dupes
	public static class EnumerableExtensions
    {
        public static bool HasDuplicates<T>(this IEnumerable<T> subjects)
        {
            return HasDuplicates(subjects, EqualityComparer<T>.Default);
        }


        public static bool HasDuplicates<T>(this IEnumerable<T> subjects, IEqualityComparer<T> comparer)
        {
            if(subjects == null)
                throw new ArgumentNullException("subjects");

            if(comparer == null)
                throw new ArgumentNullException("comparer");

            var set = new HashSet<T>(comparer);

            foreach (var s in subjects)
                if (!set.Add(s))
                    return true;

            return false;
        }
    }

}

