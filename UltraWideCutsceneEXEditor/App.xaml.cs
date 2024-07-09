using System.Configuration;
using System.Data;
using System.Windows;

namespace UltraWideCutsceneEXEditor
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public ResourceDictionary ThemeDictionary
        {
            get { return Resources.MergedDictionaries[0]; }
        }
    }

}
