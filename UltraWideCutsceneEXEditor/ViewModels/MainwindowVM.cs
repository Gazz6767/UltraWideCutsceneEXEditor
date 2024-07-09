using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Windows.Controls;

namespace UltraWideCutsceneEXEditor.ViewModels
{
    public partial class MainwindowVM : ObservableObject
    {
        [ObservableProperty]
        bool isPremade_Frame = false;

        [ObservableProperty]
        bool isCustomMade_Frame = false;

        [ObservableProperty]
        Page? selectedPage;

        private Page premadePage = new Views.PremadePage();
        private Page customMadePage = new Views.CustomPage();

        [RelayCommand]
        public void Load()
        {
            // find JSON file in Documents Folder and populate a service to store the data
        }

        partial void OnIsPremade_FrameChanged(bool value)
        {
            if (value) 
            { 
                IsPremade_Frame = true; 
                IsCustomMade_Frame = false;
                SelectedPage = premadePage;
                return;
            }
            ClearPage();
        }

        partial void OnIsCustomMade_FrameChanged(bool value)
        {
            if (value) 
            { 
                IsCustomMade_Frame = true; 
                IsPremade_Frame = false;
                SelectedPage = customMadePage;
                return;
            }     
            ClearPage();
        }

        private void ClearPage()
        {
            if (!IsCustomMade_Frame && !IsPremade_Frame)
            {
                SelectedPage = null;
            }
        }
    }
}
