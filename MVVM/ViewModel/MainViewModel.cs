using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using WPF_App.Core;
using WPF_App.MVVM.Model;

namespace WPF_App.MVVM.ViewModel {
   class MainViewModel : ObservableObject {

      public ObservableCollection<MessageModel> Messages { get; set; }
      public ObservableCollection<ContactModel> Contacts { get; set; }

      private ContactModel selectedContact;

      public ContactModel SelectedContact {
         get { return selectedContact; }
         set { selectedContact = value;
            OnPropertyChanged();
         }
      }

      private string _message
         ;

      public string Message {
         get { return _message; }
         set { _message = value;
            OnPropertyChanged();
         }
      }

      public RelayCommand SendCommand { get; set; }


      public MainViewModel() {
         Messages = new ObservableCollection<MessageModel>();
         Contacts = new ObservableCollection<ContactModel>();

         SendCommand = new RelayCommand(o => {
            Messages.Add(new MessageModel {
               Message = Message,
               FirstMessage = false
            });
            Message = "";
         });

         Messages.Add(new MessageModel {
            Username = "Ezerszatyrú Piri",
            UsernameColor = "#4010ff",
            ImageSource = "https://www.arlette.hu/wp-content/uploads/2017/02/%C3%B6regasszony-600x460.jpg",
            Message = "Segítene átkelni a zebrán, fiatalember?",
            Time = DateTime.Now,
            IsNativeOrigin = false,
            FirstMessage = true
         });

         Messages.Add(new MessageModel {
            Username = "Ezerszatyrú Piri",
            UsernameColor = "#4010ff",
            ImageSource = "https://www.arlette.hu/wp-content/uploads/2017/02/%C3%B6regasszony-600x460.jpg",
            Message = "Döntsön gyorsan, nagyon sietek.",
            Time = DateTime.Now,
            IsNativeOrigin = false,
            FirstMessage = false
         });

         Messages.Add(new MessageModel {
            Username = "Ezerszatyrú Piri",
            UsernameColor = "#4010ff",
            ImageSource = "https://www.arlette.hu/wp-content/uploads/2017/02/%C3%B6regasszony-600x460.jpg",
            Message = "A banyatankomat is elhúzhatná a Penny-ig.",
            Time = DateTime.Now,
            IsNativeOrigin = false,
            FirstMessage = false
         });

         Messages.Add(new MessageModel {
            Username = "Dagadt Pista",
            UsernameColor = "#4010ff",
            ImageSource = "https://ripost.hu/wp-content/uploads/kepadatbazis/thumbs/2015-11-05/1c36163323a700cd8b78780b0480fa78/620x0.jpg",
            Message = "Majd én segítek, Piri néni.",
            Time = DateTime.Now,
            IsNativeOrigin = false
         });

         Messages.Add(new MessageModel {
            Username = "Dagadt Pista",
            UsernameColor = "#4010ff",
            ImageSource = "https://ripost.hu/wp-content/uploads/kepadatbazis/thumbs/2015-11-05/1c36163323a700cd8b78780b0480fa78/620x0.jpg",
            Message = "Ezek a mai fiatalok semmire nem jók.",
            Time = DateTime.Now,
            IsNativeOrigin = false
         });

         Contacts.Add(new ContactModel {
            Username = "Ezerszatyrú Piri",
            ImageSource = "https://www.arlette.hu/wp-content/uploads/2017/02/%C3%B6regasszony-600x460.jpg",
            Messages = Messages
         });

         Contacts.Add(new ContactModel {
            Username = "Dagadt Pista",
            ImageSource = "https://ripost.hu/wp-content/uploads/kepadatbazis/thumbs/2015-11-05/1c36163323a700cd8b78780b0480fa78/620x0.jpg",
            Messages = Messages
         });

         Contacts.Add(new ContactModel {
            Username = "Rikárdó",
            ImageSource = "https://i.ytimg.com/vi/BP3lODEM_2I/hqdefault.jpg",
            Messages = Messages
         });
      }
   }
}
