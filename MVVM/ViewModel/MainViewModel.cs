using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using WPF_App.MVVM.Model;

namespace WPF_App.MVVM.ViewModel {
   class MainViewModel {

      public ObservableCollection<MessageModel> Messages { get; set; }
      public ObservableCollection<ContactModel> Contacts { get; set; }

      public MainViewModel() {
         Messages = new ObservableCollection<MessageModel>();
         Contacts = new ObservableCollection<ContactModel>();
      }
   }
}
