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

      private string _message;

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
            selectedContact.Messages.Add(new MessageModel {
               Username = "Jómagam",
               UsernameColor = "#034a56",
               ImageSource = "./Icons/crown.jpg",
               Message = Message,
               Time = DateTime.Now,
               IsNativeOrigin = false,
               FirstMessage = true
            });
            Message = "";
         });

         Contacts.Add(new ContactModel {
            Username = "Ezerszatyrú Piri",
            ImageSource = "https://www.arlette.hu/wp-content/uploads/2017/02/%C3%B6regasszony-600x460.jpg",
            Messages = new ObservableCollection<MessageModel>()
         });

         Contacts[0].Messages.Add(new MessageModel {
            Username = "Ezerszatyrú Piri",
            UsernameColor = "#d0051b",
            ImageSource = "https://www.arlette.hu/wp-content/uploads/2017/02/%C3%B6regasszony-600x460.jpg",
            Message = "Segítene átkelni a zebrán, fiatalember?",
            Time = DateTime.Now,
            IsNativeOrigin = false,
            FirstMessage = true
         });

         Contacts[0].Messages.Add(new MessageModel {
            Username = "Jómagam",
            UsernameColor = "#034a56",
            ImageSource = "./Icons/crown.jpg",
            Message = "Csókolom.",
            Time = DateTime.Now,
            IsNativeOrigin = false,
            FirstMessage = true
         });

         Contacts[0].Messages.Add(new MessageModel {
            Username = "Jómagam",
            UsernameColor = "#034a56",
            ImageSource = "./Icons/crown.jpg",
            Message = "Adjon egy kis gondolkodási időt.",
            Time = DateTime.Now,
            IsNativeOrigin = false,
            FirstMessage = true
         });

         Contacts[0].Messages.Add(new MessageModel {
            Username = "Ezerszatyrú Piri",
            UsernameColor = "#d0051b",
            ImageSource = "https://www.arlette.hu/wp-content/uploads/2017/02/%C3%B6regasszony-600x460.jpg",
            Message = "Döntsön gyorsan, nagyon sietek.",
            Time = DateTime.Now,
            IsNativeOrigin = false,
            FirstMessage = true
         });

         Contacts[0].Messages.Add(new MessageModel {
            Username = "Ezerszatyrú Piri",
            UsernameColor = "#d0051b",
            ImageSource = "https://www.arlette.hu/wp-content/uploads/2017/02/%C3%B6regasszony-600x460.jpg",
            Message = "A banyatankomat is elhúzhatná a Penny-ig.",
            Time = DateTime.Now,
            IsNativeOrigin = false,
            FirstMessage = true
         });

         Contacts.Add(new ContactModel {
            Username = "Dagadt Pista",
            ImageSource = "https://ripost.hu/wp-content/uploads/kepadatbazis/thumbs/2015-11-05/1c36163323a700cd8b78780b0480fa78/620x0.jpg",
            Messages = new ObservableCollection<MessageModel>()
         });

         Contacts[1].Messages.Add(new MessageModel {
            Username = "Dagadt Pista",
            UsernameColor = "#130987",
            ImageSource = "https://ripost.hu/wp-content/uploads/kepadatbazis/thumbs/2015-11-05/1c36163323a700cd8b78780b0480fa78/620x0.jpg",
            Message = "Isten éltessen, haver!.",
            Time = DateTime.Now,
            IsNativeOrigin = false,
            FirstMessage = true
         });

         Contacts[1].Messages.Add(new MessageModel {
            Username = "Jómagam",
            UsernameColor = "#034a56",
            ImageSource = "./Icons/crown.jpg",
            Message = "Tudod kit nevezz havernak!",
            Time = DateTime.Now,
            IsNativeOrigin = false,
            FirstMessage = true
         });

         Contacts[1].Messages.Add(new MessageModel {
            Username = "Jómagam",
            UsernameColor = "#034a56",
            ImageSource = "./Icons/crown.jpg",
            Message = "Nyolcadik óta nem is láttalak!",
            Time = DateTime.Now,
            IsNativeOrigin = false,
            FirstMessage = true
         });

         Contacts[1].Messages.Add(new MessageModel {
            Username = "Dagadt Pista",
            UsernameColor = "#130987",
            ImageSource = "https://ripost.hu/wp-content/uploads/kepadatbazis/thumbs/2015-11-05/1c36163323a700cd8b78780b0480fa78/620x0.jpg",
            Message = "Pff, mekkora gyökér lettél.",
            Time = DateTime.Now,
            IsNativeOrigin = false,
            FirstMessage = true
         });

         Contacts[1].Messages.Add(new MessageModel {
            Username = "Dagadt Pista",
            UsernameColor = "#130987",
            ImageSource = "https://ripost.hu/wp-content/uploads/kepadatbazis/thumbs/2015-11-05/1c36163323a700cd8b78780b0480fa78/620x0.jpg",
            Message = "Akkor jobb is, ha nem ismerlek.",
            Time = DateTime.Now,
            IsNativeOrigin = false,
            FirstMessage = true
         });

         Contacts.Add(new ContactModel {
            Username = "Rikárdó",
            ImageSource = "https://i.ytimg.com/vi/BP3lODEM_2I/hqdefault.jpg",
            Messages = new ObservableCollection<MessageModel>()
         });

         Contacts[2].Messages.Add(new MessageModel {
            Username = "Rikárdó",
            UsernameColor = "#fdfd04",
            ImageSource = "https://i.ytimg.com/vi/BP3lODEM_2I/hqdefault.jpg",
            Message = "szia uram",
            Time = DateTime.Now,
            IsNativeOrigin = false,
            FirstMessage = true
         });

         Contacts[2].Messages.Add(new MessageModel {
            Username = "Jómagam",
            UsernameColor = "#034a56",
            ImageSource = "./Icons/crown.jpg",
            Message = "Te meg mit akarsz?",
            Time = DateTime.Now,
            IsNativeOrigin = false,
            FirstMessage = true
         });

         Contacts[2].Messages.Add(new MessageModel {
            Username = "Rikárdó",
            UsernameColor = "#fdfd04",
            ImageSource = "https://i.ytimg.com/vi/BP3lODEM_2I/hqdefault.jpg",
            Message = "alig hsznalt nyomtato a fedele  van meg a tobbi resze eltunt de  megjavithato",
            Time = DateTime.Now,
            IsNativeOrigin = false,
            FirstMessage = true
         });

         Contacts[2].Messages.Add(new MessageModel {
            Username = "Rikárdó",
            UsernameColor = "#fdfd04",
            ImageSource = "https://i.ytimg.com/vi/BP3lODEM_2I/hqdefault.jpg",
            Message = "25000",
            Time = DateTime.Now,
            IsNativeOrigin = false,
            FirstMessage = true
         });

         Contacts[2].Messages.Add(new MessageModel {
            Username = "Rikárdó",
            UsernameColor = "#fdfd04",
            ImageSource = "https://i.ytimg.com/vi/BP3lODEM_2I/hqdefault.jpg",
            Message = "nem lopott",
            Time = DateTime.Now,
            IsNativeOrigin = false,
            FirstMessage = true
         });

         Contacts[2].Messages.Add(new MessageModel {
            Username = "Jómagam",
            UsernameColor = "#034a56",
            ImageSource = "./Icons/crown.jpg",
            Message = "Tehát konkrétan van egy eladó semmid?",
            Time = DateTime.Now,
            IsNativeOrigin = false,
            FirstMessage = true
         });

         Contacts[2].Messages.Add(new MessageModel {
            Username = "Rikárdó",
            UsernameColor = "#fdfd04",
            ImageSource = "https://i.ytimg.com/vi/BP3lODEM_2I/hqdefault.jpg",
            Message = "mt mondom h a fedele megvan te rakos kutyafeju hollokutya",
            Time = DateTime.Now,
            IsNativeOrigin = false,
            FirstMessage = true
         });

         Contacts[2].Messages.Add(new MessageModel {
            Username = "Jómagam",
            UsernameColor = "#034a56",
            ImageSource = "./Icons/crown.jpg",
            Message = "De az mit takar?",
            Time = DateTime.Now,
            IsNativeOrigin = false,
            FirstMessage = true
         });

         Contacts[2].Messages.Add(new MessageModel {
            Username = "Rikárdó",
            UsernameColor = "#fdfd04",
            ImageSource = "https://i.ytimg.com/vi/BP3lODEM_2I/hqdefault.jpg",
            Message = "mit nem lhet erteni te rokszforti  szokeveny kutya h a fedele van meg amvewl lecsukod",
            Time = DateTime.Now,
            IsNativeOrigin = false,
            FirstMessage = true
         });

         Contacts[2].Messages.Add(new MessageModel {
            Username = "Jómagam",
            UsernameColor = "#034a56",
            ImageSource = "./Icons/crown.jpg",
            Message = "Te veszélyesen hülye vagy xD",
            Time = DateTime.Now,
            IsNativeOrigin = false,
            FirstMessage = true
         });
      }
   }
}
