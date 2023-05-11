using Microsoft.Maui.ApplicationModel;
using NotesMAUI.Models;
using NotesMAUI.Themes;

namespace NotesMAUI;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();
        Application.Current.RequestedThemeChanged += OnRequestedChanged;
        InitializeAppTheme();
        Routing.RegisterRoute(nameof(), typeof());
        Routing.RegisterRoute(nameof(), typeof());
        Routing.RegisterRoute(nameof(), typeof());
        Routing.RegisterRoute(nameof(), typeof());

        MainPage = new AppShell();
	}
    private void OnRequestedChanged(object sender, AppThemeChangedEventArgs e)
    {

        //check if we need to use system config
        //or app config
        if (Preferences.ContainsKey(AppConstantsModel.DarkModeKey))
        {
            //force to use app config 
            InitializeAppTheme(null);
        }
        else
        {
            InitializeAppTheme(e.RequestedTheme);
        }
    }

    public void InitializeAppTheme(AppTheme? oSAppTheme = null)
    {
        if (oSAppTheme == null)
        {
            if (Preferences.Get(AppConstantsModel.DarkModeKey, false))
            {
                oSAppTheme = AppTheme.Dark;
            }
            else
            {
                oSAppTheme = AppTheme.Light;
            }
        }

        ICollection<ResourceDictionary> mergedDictionaries =
                Application.Current.Resources.MergedDictionaries;

        if (mergedDictionaries != null)
        {
            mergedDictionaries.Clear();
        }

        if (oSAppTheme == AppTheme.Dark)
        {
            mergedDictionaries.Add(new DarkTheme());
        }
        else
        {
            mergedDictionaries.Add(new LightTheme());
        }

        Application.Current.UserAppTheme = oSAppTheme ?? AppTheme.Unspecified;
    }
}

