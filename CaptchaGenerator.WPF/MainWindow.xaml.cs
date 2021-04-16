using System.Windows;

namespace CaptchaGenerator_WPF
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		public MainWindow() => InitializeComponent();

		private void Window_Loaded(object sender, RoutedEventArgs e)
		{
			for (int i = 0; i < 50; i++)
			{
				canvas.Children.Add(LineGenerator.DrawLines(canvas));
			}
			CaptchaGenerate();
		}
		/// <summary>
		/// Вызывает генерацию каптчи
		/// </summary>
		/// <returns>каптчу</returns>
		private void CaptchaGenerate() => textCanvas.Content = new CaptchaGenerator().Captcha;

		private void BtEnter_Click(object sender, RoutedEventArgs e)
		{
			if (tbEnterCaptcha.Text == textCanvas.Content.ToString())
			{
				MessageBox.Show("Верно", "Ok", MessageBoxButton.OK, MessageBoxImage.Information);
				CaptchaGenerate();
				tbEnterCaptcha.Text = "";
			}
			else
			{
				MessageBox.Show("Неправильно", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
			}
		}
	}
}