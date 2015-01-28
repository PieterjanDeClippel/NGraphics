using System;

namespace NGraphics
{

	public class NullPlatform : IPlatform
	{
		public IImageSurface CreateImageSurface (int pixelWidth, int pixelHeight, bool transparency = true)
		{
			throw new NotSupportedException ();
		}
	}
	
}