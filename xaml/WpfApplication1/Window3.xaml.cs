using System.Collections;
using System.Windows;

namespace WpfApplication1
{
	/// <summary>
	/// Interaction logic for Window3.xaml
	/// </summary>
	public partial class Window3 : Window
	{
		public Window3()
		{
			InitializeComponent();

			// Don’t do this in production, use MVVM…
			ListBox1.ItemsSource = new []
			{
				new {Icon = "🗂", Text = "Bilder"},
				new {Icon = "🍎", Text = "Apfel.ico"},
				new {Icon = "🍌", Text = "Banane.ico"},
				new {Icon = "🍋", Text = "Zitrone.ico"},
				new {Icon = "🍒", Text = "Kirsche.ico"},
				new {Icon = "🍍", Text = "Ananas.ico"},
			};
		}
	}
}
