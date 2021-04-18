using System;
using System.Windows;
using System.Windows.Media;

namespace RGBSlider
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		#region RGB
		public byte R { get; set; }
		public byte G { get; set; }
		public byte B { get; set; }
		#endregion

		public MainWindow() => InitializeComponent();

		#region Sliders
		private void Red_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
		{
			R = Convert.ToByte(e.NewValue);
			TBR.Text = Convert.ToByte(e.NewValue).ToString();
		}
		private void Green_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
		{
			G = Convert.ToByte(e.NewValue);
			TBG.Text = Convert.ToByte(e.NewValue).ToString();
		}
		private void Blue_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
		{
			B = Convert.ToByte(e.NewValue);
			TBB.Text = Convert.ToByte(e.NewValue).ToString();
		}
		#endregion

		private void Window_MouseMove(object sender, System.Windows.Input.MouseEventArgs e) => Background = new SolidColorBrush(Color.FromRgb(R, G, B));

		#region TextBoxChanged

		private void TBR_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
		{
			try
			{
				Red.Value = Convert.ToByte(TBR.Text);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void TBG_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
		{
			try
			{
				Green.Value = Convert.ToByte(TBG.Text);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void TBB_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
		{
			try
			{
				Blue.Value = Convert.ToByte(TBB.Text);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}
		#endregion
	}
}