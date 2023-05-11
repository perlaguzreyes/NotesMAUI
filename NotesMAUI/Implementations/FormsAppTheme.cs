using System;
using Microsoft.Maui.ApplicationModel;
using NotesMAUI.Services;

namespace NotesMAUI.Implementations
{
	public class FormsAppTheme : IAppThemeService
    {
        public void ChangeTheme(AppThemeStyle appThemeStyle)
        {
            switch (appThemeStyle)
            {
                case AppThemeStyle.Light:
                    Application.Current.UserAppTheme = AppTheme.Light;
                    break;
                case AppThemeStyle.Dark:
                    Application.Current.UserAppTheme = AppTheme.Dark;
                    break;
            }
        }
    }
}

