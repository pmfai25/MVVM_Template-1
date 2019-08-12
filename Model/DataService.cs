using System;

namespace MVVM_Template.Model
{
    public class DataService : IDataService
    {
        public void GetData(Action<DataItem, Exception> callback)
        {
            var item = new DataItem("Welcome to MVVM Light");
            callback(item, null);
        }
    }
}