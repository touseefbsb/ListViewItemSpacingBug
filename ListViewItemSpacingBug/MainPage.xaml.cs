﻿using System.Collections.Generic;
using Windows.UI.Xaml.Controls;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace ListViewItemSpacingBug
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public List<Person> People { get; set; }
        public MainPage()
        {
            this.InitializeComponent();
            People = new List<Person> { new Person { Name = "abc" }, new Person { Name = "asas" } };
        }
    }
}
