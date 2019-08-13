namespace MVVM_Template.Model
{
    public class MainItem
    {
        public string Title
        {
            get;
            private set;
        }

        public MainItem(string title)
        {
            Title = title;
        }
    }
}