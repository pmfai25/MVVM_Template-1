using GalaSoft.MvvmLight;

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
    public class TranslateViewModel : ViewModelBase
    {
        /// <summary>
        /// Initializes a new instance of the MainViewModel class.
        /// </summary>
        public TranslateViewModel()
        {
            ////if (IsInDesignMode)
            ////{
            ////    // Code runs in Blend --> create design time data.
            ////}
            ////else
            ////{
            ////    // Code runs "for real"
            ////}
        }

        private string typedText;
        public string TypedText
        {
            get
            {
                return typedText;
            }
            set
            {
                typedText = value;
                RaisePropertyChanged("TypedText");
                this.MorseCode = this.typedText;
            }
        }

        private string morseCode;
        public string MorseCode
        {
            get
            {
                return morseCode;
            }
            set
            {
                morseCode = value;
                RaisePropertyChanged("MorseCode");
               // this.TypedText = this.MorseCode;
            }
        }

    }
}