using System;

namespace MVVM_Template.Model
{
    public class MainService : IMainService
    {
        public void GetData(Action<MainItem, Exception> callback)
        {
            var item = new MainItem("This is a MVVM Light Template!");
            callback(item, null);
        }
    }
}