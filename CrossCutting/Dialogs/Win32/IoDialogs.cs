using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MVVM_Template.CrossCutting
{
    public class IoDialog
    {
        //set the logger
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public IoDialog()
        { }

        public static string LoadFile()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                return openFileDialog.FileName;
            }

            return null;
        }

        //public static string LoadDumpPath()
        //{
        //    System.Windows.Forms.FolderBrowserDialog fbDialog = new System.Windows.Forms.FolderBrowserDialog();
        //    fbDialog.ShowNewFolderButton = true;
        //    DialogResult result = fbDialog.ShowDialog();

        //    if (result == DialogResult.OK)
        //    {
        //        return fbDialog.SelectedPath + "\\";
        //    }

        //    return null;
        //}
    }
}
