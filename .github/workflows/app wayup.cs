using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			<? xml version = "1.0" encoding = "UTF-8" ?>
< ContentPage xmlns = "http://xamarin.com/schemas/2014/forms"

			 xmlns: x = "http://schemas.microsoft.com/winfx/2009/xaml"

			 x: Class = "Notes.Views.NotesPage"

			 Title = "Notes" >

	< !--Layout children vertically -->

	< StackLayout Margin = "20" >

		< Editor x: Name = "editor"

				Placeholder = "Enter your note"

				HeightRequest = "100" />

		< !--Layout children in two columns -->

		< Grid ColumnDefinitions = "*,*" >

			< Button Text = "Save"

					Clicked = "OnSaveButtonClicked" />

			< Button Grid.Column = "1"

					Text = "Delete"

					Clicked = "OnDeleteButtonClicked" />

		</ Grid >

	</ StackLayout >
</ ContentPage >
		}
	}using System;
using System.IO;
using Xamarin.Forms;

namespace Notes.Views
	{
		public partial class NotesPage : ContentPage
		{
			string _fileName = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "notes.txt");

			public NotesPage()
			{
				InitializeComponent();

				// Read the file.
				if (File.Exists(_fileName))
				{
					editor.Text = File.ReadAllText(_fileName);
				}
			}

			void OnSaveButtonClicked(object sender, EventArgs e)
			{
				// Save the file.
				File.WriteAllText(_fileName, editor.Text);
			}

			void OnDeleteButtonClicked(object sender, EventArgs e)
			{
				// Delete the file.
				if (File.Exists(_fileName))
				{
					File.Delete(_fileName);
				}
				editor.Text = string.Empty;
			}
		}
	}<? xml version="1.0" encoding="UTF-8"?>
<ContentPage xmlns = "http://xamarin.com/schemas/2014/forms"

			 xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
             x:Class="Notes.Views.AboutPage"
             Title="About">
    <!-- Layout children in two rows -->
    <Grid RowDefinitions = "Auto,*" >

		< Image Source="xamarin_logo.png"
               BackgroundColor="{OnPlatform iOS=LightSlateGray, Android=#2196F3}"
               VerticalOptions="Center"
               HeightRequest="64" />
        <!-- Layout children vertically -->
        <StackLayout Grid.Row="1"
                     Margin= "20"

					 Spacing= "20" >

			< Label FontSize= "22" >

				< Label.FormattedText >

					< FormattedString >

						< FormattedString.Spans >

							< Span Text= "Notes"

								  FontAttributes= "Bold"

								  FontSize= "22" />

							< Span Text= " v1.0" />

						</ FormattedString.Spans >

					</ FormattedString >

				</ Label.FormattedText >

			</ Label >

			< Label Text= "This app is written in XAML and C# with the Xamarin Platform." />

			< Button Text= "Learn more"

					Clicked= "OnButtonClicked" />

		</ StackLayout >

	</ Grid >
</ ContentPage >
}
using System;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace Notes.Views
{
	public partial class AboutPage : ContentPage
	{
		public AboutPage()
		{
			InitializeComponent();
		}

		async void OnButtonClicked(object sender, EventArgs e)
		{
			// Launch the specified URL in the system browser.
			await Launcher.OpenAsync("https://aka.ms/xamarin-quickstart");
		}
	}
}using System;
using System.IO;
using Xamarin.Forms;

namespace Notes.Views
{
	public partial class NotesPage : ContentPage
	{
		string _fileName = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "notes.txt");

		public NotesPage()
		{
			InitializeComponent();

			// Read the file.
			if (File.Exists(_fileName))
			{
				editor.Text = File.ReadAllText(_fileName);
			}
		}

		void OnSaveButtonClicked(object sender, EventArgs e)
		{
			// Save the file.
			File.WriteAllText(_fileName, editor.Text);
		}

		void OnDeleteButtonClicked(object sender, EventArgs e)
		{
			// Delete the file.
			if (File.Exists(_fileName))
			{
				File.Delete(_fileName);
			}
			editor.Text = string.Empty;
		}
	}
}<? xml version = "1.0" encoding = "UTF-8" ?>
< ContentPage xmlns = "http://xamarin.com/schemas/2014/forms"

			 xmlns: x = "http://schemas.microsoft.com/winfx/2009/xaml"

			 x: Class = "Notes.Views.AboutPage"

			 Title = "About" >

	< !--Layout children in two rows -->
    <Grid RowDefinitions="Auto,*">
        <Image Source="xamarin_logo.png"
               BackgroundColor="{OnPlatform iOS=LightSlateGray, Android=#2196F3}"
               VerticalOptions="Center"
               HeightRequest="64" />
        <!-- Layout children vertically -->
        <StackLayout Grid.Row="1"
                     Margin="20"
                     Spacing="20">
            <Label FontSize="22">
                <Label.FormattedText>
                    <FormattedString>
                        <FormattedString.Spans>
                            <Span Text="Notes"
                                  FontAttributes="Bold"
                                  FontSize="22" />
                            <Span Text=" v1.0" />
                        </FormattedString.Spans>
                    </FormattedString>
                </Label.FormattedText>
            </Label>
            <Label Text="This app is written in XAML and C# with the Xamarin Platform." />
            <Button Text="Learn more"
                    Clicked="OnButtonClicked" />
        </StackLayout>
    </<?xml version="1.0" encoding="UTF-8"?>
<ContentPage xmlns="http://xamarin.com/schemas/2014/forms"
             xmlns:x = "http://schemas.microsoft.com/winfx/2009/xaml"

			 x: Class = "Notes.Views.AboutPage"

			 Title = "About" >

	< !--Layout children in two rows -->
    <Grid RowDefinitions="Auto,*">
        <Image Source="xamarin_logo.png"
               BackgroundColor="{OnPlatform iOS=LightSlateGray, Android=#2196F3}"
               VerticalOptions="Center"
               HeightRequest="64" />
        <!-- Layout children vertically -->
        <StackLayout Grid.Row="1"
                     Margin="20"
                     Spacing="20">
            <Label FontSize="22">
                <Label.FormattedText>
                    <FormattedString>
                        <FormattedString.Spans>
                            <Span Text="Notes"
                                  FontAttributes="Bold"
                                  FontSize="22" />
                            <Span Text=" v1.0" />
                        </FormattedString.Spans>
                    </FormattedString>
                </Label.FormattedText>
            </Label>
            <Label Text="This app is written in XAML and C# with the Xamarin Platform." />
            <Button Text="Learn more"
                    Clicked="OnButtonClicked" />
        </StackLayout>
    </Grid>
</ContentPage>Grid>
</ContentPage>
	using System;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace Notes.Views
{
	public partial class AboutPage : ContentPage
	{
		public AboutPage()
		{
			InitializeComponent();
		}

		async void OnButtonClicked(object sender, EventArgs e)
		{
			// Launch the specified URL in the system browser.
			await Launcher.OpenAsync("https://aka.ms/xamarin-quickstart");
		}
	}
}<? xml version = "1.0" encoding = "UTF-8" ?>
< Shell xmlns = "http://xamarin.com/schemas/2014/forms"

	   xmlns: x = "http://schemas.microsoft.com/winfx/2009/xaml"

	   xmlns: views = "clr-namespace:Notes.Views"

	   x: Class = "Notes.AppShell" >

	< !--Display a bottom tab bar containing two tabs -->   
    <TabBar>
        <ShellContent Title="Notes"
                      Icon="icon_feed.png"
                      ContentTemplate="{DataTemplate views:NotesPage}" />
        <ShellContent Title="About"
                      Icon="icon_about.png"
                      ContentTemplate="{DataTemplate views:AboutPage}" />
    </TabBar>
</Shell>using Xamarin.Forms;

namespace Notes
{
	public partial class AppShell : Shell
	{
		public AppShell()
		{
			InitializeComponent();
		}
	}
}<? xml version = "1.0" encoding = "utf-8" ?>
< Application xmlns = "http://xamarin.com/schemas/2014/forms"

			 xmlns: x = "http://schemas.microsoft.com/winfx/2009/xaml"

			 x: Class = "Notes.App" >

</ Application >using Xamarin.Forms;

namespace Notes
{
	public partial class App : Application
	{

		public App()
		{
			InitializeComponent();
			MainPage = new AppShell();
		}

		protected override void OnStart()
		{
		}

		protected override void OnSleep()
		{
		}

		protected override void OnResume()
		{
		}
	}
}