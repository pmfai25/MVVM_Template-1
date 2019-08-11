using CommonServiceLocator;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.CommandWpf;
using System.Linq;

namespace MVVM_Template.ViewModel
{
    /// <summary>
    /// This class contains properties that the main View can data bind to.
    /// <para>
    /// Use the <strong>mvvminpc</strong> snippet to add bindable properties to this ViewModel.
    /// </para>
    /// <para>
    /// You can also use Blend to data bind with the tool's support.
    /// </para>
    /// <para>
    /// See http://www.galasoft.ch/mvvm
    /// </para>
    /// </summary>
    public class MainViewModel : ViewModelBase
    {
        /// <summary>
        /// Initializes a new instance of the MainViewModel class.
        /// </summary>
        public MainViewModel()
        {
            //if (IsInDesignMode)
            //{
            //    // Code runs in Blend --> create design time data.
            //}
            //else
            //{
            //    // Code runs "for real"
            //}

            //using (var context = new EntityModel())
            //{
            //    var studentList = context.tblUsers.SqlQuery("Select * from tblUser").ToList();
            //}
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