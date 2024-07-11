using System.Drawing;
using System.Drawing.Drawing2D;

namespace ns0
{

}
internal static class Class1
{
	public static GraphicsPath smethod_0(float float_0, float float_1, float float_2, float float_3, float float_4)
	{
		GraphicsPath graphicsPath = new GraphicsPath();
		graphicsPath.AddLine(float_0 + float_4, float_1, float_0 + float_2 - float_4 * 2f, float_1);
		graphicsPath.AddArc(float_0 + float_2 - float_4 * 2f, float_1, float_4 * 2f, float_4 * 2f, 270f, 90f);
		graphicsPath.AddLine(float_0 + float_2, float_1 + float_4, float_0 + float_2, float_1 + float_3 - float_4 * 2f);
		graphicsPath.AddArc(float_0 + float_2 - float_4 * 2f, float_1 + float_3 - float_4 * 2f, float_4 * 2f, float_4 * 2f, 0f, 90f);
		graphicsPath.AddLine(float_0 + float_2 - float_4 * 2f, float_1 + float_3, float_0 + float_4, float_1 + float_3);
		graphicsPath.AddArc(float_0, float_1 + float_3 - float_4 * 2f, float_4 * 2f, float_4 * 2f, 90f, 90f);
		graphicsPath.AddLine(float_0, float_1 + float_3 - float_4 * 2f, float_0, float_1 + float_4);
		graphicsPath.AddArc(float_0, float_1, float_4 * 2f, float_4 * 2f, 180f, 90f);
		graphicsPath.CloseFigure();
		return graphicsPath;
	}

	public static GraphicsPath smethod_1(Rectangle rectangle_0, float float_0)
	{
		return smethod_0(rectangle_0.X, rectangle_0.Y, rectangle_0.Width, rectangle_0.Height, float_0);
	}

	public static Color smethod_2(Color color_0, Color color_1, double double_0)
	{
		double num = double_0 / 255.0;
		double num2 = 1.0 - num;
		int red = (int)(color_0.R * num2 + color_1.R * num);
		int green = (int)(color_0.G * num2 + color_1.G * num);
		int blue = (int)(color_0.B * num2 + color_1.B * num);
		return Color.FromArgb(red, green, blue);
	}

	public static Color smethod_3(Color color_0, Color color_1)
	{
		return smethod_2(color_0, color_1, color_1.A);
	}
}
