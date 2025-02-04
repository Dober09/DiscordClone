

using System.Collections.ObjectModel;

namespace DiscordClone.ViewModel
{
    class MainPage
    {
       

        public ObservableCollection<Group> Groups { get; set; }

        public MainPage() { 
        
            Groups = new ObservableCollection<Group>() { 
                new Group
                {
                    id=1,
                    image="mettlestate.png"
                }, new Group
                {
                    id=2,
                    image="blender.png"
                }, new Group
                {
                    id=3,
                    image="chess.webp"
                }, new Group
                {
                    id=4,
                    image="bitbucket.png"
                },new Group  {
                    id=5,
                    image="plus.png"
                },

            
            };
        }
             
        
    }

    public class Group
    {
      
        public int id{ get; set; }

        public string image { get; set; }

       
    }
}
