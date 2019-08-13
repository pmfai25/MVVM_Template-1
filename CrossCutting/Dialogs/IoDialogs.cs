namespace MVVM_Template.CrossCutting
{
    using System.Windows.Forms; 

    /// <summary>
    /// IO Dialogs Class
    /// </summary>
    public static class IoDialogs
    {
        //set the logger
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        
        /// <summary>
        /// Select file using OpenFileDialog
        /// </summary>
        /// <returns>Filename with path</returns>
        public static string GetFilePath()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                return openFileDialog.FileName;
            }

            return null;
        }
    }
}
