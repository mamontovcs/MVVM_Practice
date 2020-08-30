using System.Collections.ObjectModel;
using System.Windows.Input;

namespace MVVM_Practice.MVVM
{
    class UserViewModel : ViewModelBase
    {
        private User _user;

        private ObservableCollection<User> _users;

        private ICommand _addCommand;

        private ICommand _updateCommand;

        public UserViewModel()
        {
            Users = new ObservableCollection<User>
            {
                new User{UserId = 1,FirstName="F1",LastName="L1"},
                new User{UserId = 2,FirstName="F2",LastName="L2"},
                new User{UserId = 3,FirstName="F3",LastName="L3"},
            };
        }

        public User User
        {
            get
            {
                return _user;
            }
            set
            {
                _user = value;
                NotifyPropertyChanged("User");
            }
        }

        public ObservableCollection<User> Users
        {
            get
            {
                return _users;
            }
            set
            {
                _users = value;
                NotifyPropertyChanged("Users");
            }
        }

        public ICommand AddUserCommand
        {
            get
            {
                if (_addCommand == null)
                    _addCommand = new RelayCommand(param => this.Add());
                return _addCommand;
            }
            set
            {
                _addCommand = value;
            }
        }

        public ICommand UpdateUsersCommand
        {
            get
            {
                if (_updateCommand == null)
                    _updateCommand = new RelayCommand(param => this.Update());
                return _updateCommand;
            }
            set
            {
                _addCommand = value;
            }
        }

        private void Add()
        {
            _user = new User(0, "ADD", "COMMAND");
            Users.Add(_user);
        }

        private void Update()
        {
            Users.Add(new User(0, "UPDATE", "COMMAND"));
        }
    }
}
