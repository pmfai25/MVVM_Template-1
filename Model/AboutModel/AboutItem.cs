namespace MVVM_Template.Model
{
    public class AboutItem
    {
        public string Title
        {
            get;
            private set;
        }

        public AboutItem(string title)
        {
            Title = title;
        }
    }
}