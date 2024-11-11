using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CUPID_DATINGAPP
{
    public partial class UserSearch : UserControl
    {
        private List<User> _users;

        public UserSearch()
        {
            InitializeComponent();
            LoadUsers();
        }

        private void LoadUsers()
        {
            _users = new List<User>
            {
                new User { Username = "Benutzer 1", ProfileImage = "https://via.placeholder.com/40" },
                new User { Username = "Benutzer 2", ProfileImage = "https://via.placeholder.com/40" },
                new User { Username = "Benutzer 3", ProfileImage = "https://via.placeholder.com/40" },
                new User { Username = "Benutzer 4", ProfileImage = "https://via.placeholder.com/40" },
                new User { Username = "Benutzer 5", ProfileImage = "https://via.placeholder.com/40" },
                new User { Username = "Benutzer 6", ProfileImage = "https://via.placeholder.com/40" },
            };
            UserListView.ItemsSource = _users;
        }

        private void SearchTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            string searchTerm = SearchTextBox.Text.ToLower();
            var filteredUsers = _users.Where(u => u.Username.ToLower().Contains(searchTerm)).ToList();
            UserListView.ItemsSource = filteredUsers;
        }
    }
    public class User
    {
        public string Username { get; set; }
        public string ProfileImage { get; set; } // URL des Profilbildes
    }
}
