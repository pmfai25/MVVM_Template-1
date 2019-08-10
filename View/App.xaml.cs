using GalaSoft.MvvmLight.Threading;
using MVVM_Template.CrossCutting;
using System.Windows;

namespace MVVM_Template.View
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        //set the logger
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        static App()
        {
            Logging.ConfigureLog4Net();

            DispatcherHelper.Initialize();

            log.Info("App Initialized");
        }
    }
}
