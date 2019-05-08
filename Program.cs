using System;
using System.Linq;
using SFML.System;
using SFML.Graphics;
using SFML.Window;

namespace Simple2DRayCasting
{
	class Program
	{
		private static uint Height = 800;
		private static uint Width = 800;
		static void Main(string[] args)
		{
			Boundary b1 = new Boundary(0, 100, 100, 0);

			ContextSettings settings = new ContextSettings()
			{
				DepthBits = 24,
				StencilBits = 8,
				AntialiasingLevel = 4,
				MajorVersion = 3,
				MinorVersion = 0
			};

			VideoMode screenSize = new VideoMode(Width, Height, 24);
			RenderWindow window = new RenderWindow(screenSize, "SimpleRayCasting", Styles.Resize | Styles.Close, settings);
			window.SetFramerateLimit(60);
			window.SetVerticalSyncEnabled(true);
			window.SetActive(false);
			window.RequestFocus();

			while (window.IsOpen)
			{
				window.DispatchEvents();
				window.Clear();
				b1.DrawBoundary(ref window);
				window.Display();
			}
		}
	}
}
