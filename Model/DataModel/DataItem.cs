using System;

namespace MVVM_Template.Model
{
    public class DataItem
    {
        public DataItem()
        {  }

        public long Id { get; set; }

        public string Name { get; set; }

        public string Profession { get; set; }

        public DateTime TimeStamp { get; set; }
    }
}