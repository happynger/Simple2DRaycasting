using System;
using SFML.Graphics;
using SFML.System;

namespace Simple2DRayCasting
{
	class Boundary
	{
		public Vector2f A;
		public Vector2f B;

		public Boundary(float x1, float y1,
						float x2, float y2)
		{
			A = new Vector2f(x1, y1);
			B = new Vector2f(x2, y2);
		}

		public void DrawBoundary(ref RenderWindow window)
		{
			LineShape line = new LineShape();
			line.SetPoints(A, B);
			window.Draw(line);
		}
	}
}
