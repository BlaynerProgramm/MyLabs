using System;
using System.Windows;
using System.Windows.Media;
using System.Windows.Shapes;
using System.Windows.Controls;

namespace CaptchaGenerator_WPF
{
	/// <summary>
	/// Генератор линий
	/// </summary>
	public class LineGenerator
	{
		/// <summary>
		/// Генерирует линии для canvas
		/// </summary>
		/// <param name="canvas"></param>
		/// <returns></returns>
		public static Line DrawLines(Canvas canvas)
		{
			Random random = new();
			if (random.Next(0, 1) == 0)
			{
				return new Line
				{
					HorizontalAlignment = HorizontalAlignment.Center,

					X1 = 0,
					Y1 = canvas.ActualHeight - random.Next(1, (int)canvas.ActualWidth),
					X2 = (int)canvas.ActualWidth,
					Y2 = random.Next(1, (int)canvas.ActualHeight),

					StrokeThickness = random.Next(1, 3),

					Stroke = new SolidColorBrush(new Color
					{
						A = (byte)random.Next(0, 255),
						B = (byte)random.Next(0, 255),
						G = (byte)random.Next(0, 255),
						R = (byte)random.Next(0, 255)
					})

				};
			}
			else
			{
				return new Line
				{
					HorizontalAlignment = HorizontalAlignment.Center,

					X1 = (int)canvas.ActualWidth,
					Y1 = (int)canvas.ActualWidth - random.Next(10, (int)canvas.ActualWidth),
					X2 = 0,
					Y2 = random.Next(10, (int)canvas.ActualWidth),

					StrokeThickness = random.Next(0, 3),
					Stroke = Brushes.Black,
				};
			}
		}
	}
}