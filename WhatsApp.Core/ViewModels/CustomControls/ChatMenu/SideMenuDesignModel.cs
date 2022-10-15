using System.Collections.ObjectModel;

namespace WhatsApp.Core
{
    public class SideMenuDesignModel : SideMenuViewModel, IBaseDesignViewModel<SideMenuDesignModel>
    {
        public static SideMenuDesignModel Instance = new();

        public SideMenuDesignModel()
        {
            
        }
    }
}
