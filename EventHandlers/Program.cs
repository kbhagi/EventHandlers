using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventHandlers
{
    class Program
    {
        static void Main(string[] args)
        {


        }
        //Declare Event
        public event EventHandler ButtonClickEvent, ButtonTappedEvent;
        //Create Function to Handle Event
        private static void OnButtonClickEvent(object sender, EventArgs eventArgs)
//Register/Subscribe Events
ButtonClickEvent += OnButtonClickEvent;
ButtonTappedEvent += OnButtonClickEvent;

//Unregister/Unsibscribe Events
ButtonClickEvent -= OnButtonClickEvent;
ButtonTappedEvent -= OnButtonClickEvent;

//Invoke Events

ButtonClickEvent.Invoke(this, EventArgs.Empty);
ButtonTappedEvent.Invoke(this, EventArgs.Empty);
//Register/Subscribe Events Using Lambda

SaveButton.Click += (sender,args) =>
{
            //Perform Actions
};
//Register/Subscribe Events Using Delegates
SaveButton.Click += delegate(object sender, RoutedEventArgs args)
 {
 //Perform Actions                       
  };
} }

