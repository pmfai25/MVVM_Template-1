using GalaSoft.MvvmLight;
using MVVM_Template.Model;

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
    public class AboutViewModel : ViewModelBase
    {
        /// <summary>
        /// Initializes a new instance of the MainViewModel class.
        /// </summary>
        public AboutViewModel()
        {
            this.aboutTitle = new AboutItem("This is the About component.").Title;
        }

        private string aboutTitle;
        public string AboutTitle
        {
            get
            {
                return aboutTitle;
            }
            set
            {
                aboutTitle = value;
                RaisePropertyChanged("AboutTitle");
            }
        }
    }
}