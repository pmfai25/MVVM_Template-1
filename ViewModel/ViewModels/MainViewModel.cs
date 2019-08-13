using CommonServiceLocator;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.CommandWpf;
using MVVM_Template.Model;
using System.Linq;

namespace MVVM_Template.ViewModel
{
    public class MainViewModel : ViewModelBase
    {
        private readonly IMainService _dataService;
        
        /// <summary>
        /// Initializes a new instance of the MainViewModel class.
        /// </summary>
        public MainViewModel(IMainService dataService)
        {
            _dataService = dataService;
            _dataService.GetData(
                (item, error) =>
                {
                    WelcomeTitle = item.Title;
                });

           this.CurrentContentView = this;
        }

        private string _welcomeTitle;
        public string WelcomeTitle
        {
            get
            {
                return _welcomeTitle;
            }
            set
            {
                _welcomeTitle = value;
                RaisePropertyChanged("WelcomeTitle");
            }
        }

        private ViewModelBase currentContentView;
        public ViewModelBase CurrentContentView
        {
            get
            {
                return currentContentView;
            }
            set
            {
                currentContentView = value;
                RaisePropertyChanged("CurrentContentView");
            }
        }

        private RelayCommand _aboutCommand;
        public RelayCommand AboutCommand
        {
            get
            {
                if (_aboutCommand == null)
                {
                    _aboutCommand = new RelayCommand(() =>
                    {
                        this.CurrentContentView = ServiceLocator.Current.GetInstance<AboutViewModel>();
                    });
                }
                return _aboutCommand;
            }
        }

        private RelayCommand _showDataCommand;
        public RelayCommand ShowDataCommand
        {
            get
            {
                if (_showDataCommand == null)
                {
                    _showDataCommand = new RelayCommand(() =>
                    {
                        this.CurrentContentView = ServiceLocator.Current.GetInstance<ShowDataViewModel>();
                    });
                }
                return _showDataCommand;
            }
        }

        private RelayCommand<IClosable> _closeWindowCommand;
        public RelayCommand<IClosable> CloseWindowCommand
        {
            get
            {
                if (_closeWindowCommand == null)
                {
                    _closeWindowCommand = new RelayCommand<IClosable>((IClosable window) =>
                    {
                        if (window != null)
                        {
                            window.Close();
                        }
                    });
                }
                return _closeWindowCommand;
            }
        }
    }
}