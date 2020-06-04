namespace Xamarinpreparcial2.Infrastructure     
{
    using Xamarinpreparcial2.ViewModels;
    public class InstanceLocator
    {
        public MainViewModel Main { get; set; }
        public InstanceLocator()
        {
            Main = new MainViewModel();
        }
        
    }
}
