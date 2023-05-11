namespace NotesMAUI.Pages;

public class MVVMDetailNotePage : ContentPage
{
	public MVVMDetailNotePage()
	{
		Content = new VerticalStackLayout
		{
			Children = {
				new Label { HorizontalOptions = LayoutOptions.Center, VerticalOptions = LayoutOptions.Center, Text = "Welcome to .NET MAUI!"
				}
			}
		};
	}
}
