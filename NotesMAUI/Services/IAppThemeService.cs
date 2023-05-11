using System;
namespace NotesMAUI.Services
{
	public interface IAppThemeService
	{
        void ChangeTheme(AppThemeStyle appThemeStyle);

    }
    public enum AppThemeStyle
    {
        Default = 0,
        Light = 1,
        Dark = 2
    }
}

