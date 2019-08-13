using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MVVM_Template.Model
{
    public interface IMainService
    {
        void GetData(Action<MainItem, Exception> callback);
    }
}
