﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Controls;
using BoxProject.Model;

namespace BoxProject.ViewModel
{
    class BoxVm
    {
        public ItemCatalog _myItems { get; set; }
        private Serialization _Serialize;
        private Box _affordableBox;
        private Box _averageBox;
        private Box _expensiveBox;
        private MainPageVm _mainPageVm;
        private ObservableCollection<Item> _myItemCollection;
        private ObservableCollection<Item> _itemsForMyBox;
       // private Category;
       

        Random rnd = new Random();
        int position = 0;
        Item myItem = new Item();
        
        public ObservableCollection<Item> MyItemCollection
        {
            get => _myItemCollection;
            set => _myItemCollection = value;
        }

        public ObservableCollection<Item> ItemsForMyBox
        {
            get => _itemsForMyBox;
            set => _itemsForMyBox = value;
        }

        internal MainPageVm MainPageVm { get => _mainPageVm; set => _mainPageVm = value; }

        //public Box AffordableBox
        //{
        //    get => _affordableBox;
        //    set => _affordableBox = value;
        //}

        //public Box AverageBox
        //{
        //    get => _averageBox;
        //    set => _averageBox = value;
        //}

        //public Box ExpensiveBox
        //{
        //    get => _expensiveBox;
        //    set => _expensiveBox = value;
        //}

        public BoxVm()
        {
            _affordableBox = new Box();

            _averageBox = new Box();

            _expensiveBox = new Box();

            _myItems = new ItemCatalog();

            _Serialize = new Serialization();
            
            

            ItemsForMyBox = new ObservableCollection<Item>();

        

            ReadMyItems();

            //ChooseItemsForCategory();

            CreateAffordableBox();

            CreateAverageBox();

            CreateExpensiveBox();

        }

        public async void ReadMyItems()
        {
            MyItemCollection = await _Serialize.LoadFromJson();
            _myItems.MyItems = MyItemCollection;
        }

        //public void ChooseItemsForCategory()
        //{
        //    foreach (var item in MyItemCollection)
        //    {
        //        if (SelectedCategory.Name == item.Category)
        //            ItemsForMyBox.Add(item);
        //    }
        //}

        public void CreateAffordableBox()
        {
            ObservableCollection<Item> affordableItems = new ObservableCollection<Item>();

            foreach (var item in ItemsForMyBox)
            {
                if (item.Affordable == true)
                {
                    affordableItems.Add(item);

                }
            }

            for (int i = 0; i < 10; i++)
            {
                position = rnd.Next(1, affordableItems.Count + 1);
                myItem = affordableItems.ElementAt(position);
                _affordableBox.ItemsInMyBox.Add(myItem);
            }
        }

        public void CreateAverageBox()
        {
            ObservableCollection<Item> averageItems = new ObservableCollection<Item>();

            foreach (var item in ItemsForMyBox)
            {
                if (item.Average == true)
                {
                    averageItems.Add(item);
                }
            }

            for (int i = 0; i < 10; i++)
            {
                position = rnd.Next(1, averageItems.Count + 1);
                myItem = averageItems.ElementAt(position);
                _averageBox.ItemsInMyBox.Add(myItem);
            }
        }

        public void CreateExpensiveBox()
        {
            ObservableCollection<Item> expensiveItems = new ObservableCollection<Item>();

            foreach (var item in ItemsForMyBox)
            {
                if (item.Expensive == true)
                {
                    expensiveItems.Add(item);
                }
            }

            for (int i = 0; i < 10; i++)
            {
                position = rnd.Next(1, expensiveItems.Count + 1);
                myItem = expensiveItems.ElementAt(position);
                _expensiveBox.ItemsInMyBox.Add(myItem);
            }
        }


    }
}
