using System;
using SFML.System;
using SFML.Graphics;

namespace Simple2DRayCasting
{
	class LineShape : Drawable
	{
		private Vertex[] vertices = new Vertex[2];
		private Color color = Color.White;

		public void SetPoints(Vertex A, Vertex B)
		{
			vertices[0] = new Vertex(A.Position, color);
			vertices[1] = new Vertex(B.Position, color);
		}
		public void SetPoints(float x1, float y1,
							  float x2, float y2)
		{
			vertices[0] = new Vertex(new Vector2f(x1, y1), color);
			vertices[1] = new Vertex(new Vector2f(x2, y2), color);
		}
		public void SetPoints(Vector2f point1, Vector2f point2)
		{
			vertices[0] = new Vertex(point1, color);
			vertices[1] = new Vertex(point2, color);
		}
		public void SetColor(Color c)
			=> color = c;

		public LineShape()
		{
			vertices[0] = new Vertex();
			vertices[1] = new Vertex();
		}

		public void Draw(RenderTarget target, RenderStates states)
		{
			target.Draw(vertices, 0, 2, PrimitiveType.Lines, states);
		}
	}
}
