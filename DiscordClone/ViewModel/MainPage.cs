

using System.Collections.ObjectModel;

namespace DiscordClone.ViewModel
{
    class MainPage
    {
       

        public ObservableCollection<Model> Models { get; set; }

        public MainPage() { 
        
            Models = new ObservableCollection<Model>() { 
                new Model
                {
                    Title = "General",
                    Icon = "🔨",
                    subTitle = "Forge",
                },

            
            };
        }
             
        
    }

    public class Model
    {
      
        public string Title { get; set; }

        public string Icon { get; set; }

        public string subTitle { get; set; }
    }
}
