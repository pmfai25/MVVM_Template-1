using GalaSoft.MvvmLight;
using MVVM_Template.Model;
using System.Collections.ObjectModel;

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
    public class ShowDataViewModel : ViewModelBase
    {
        /// <summary>
        /// Initializes a new instance of the MainViewModel class.
        /// </summary>
        public ShowDataViewModel()
        {
            this.dataCollection = new DataService().GetData();
        }

        private ObservableCollection<DataItem> dataCollection;
        public ObservableCollection<DataItem> DataCollection
        {
            get
            {
                return dataCollection;
            }
            set
            {
                dataCollection = value;
                RaisePropertyChanged("DataCollection");
            }
        }
    }
}