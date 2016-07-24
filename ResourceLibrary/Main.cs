using System;
namespace ResourceLibrary
{
	public static class ResourceLibrary
	{
		public static void Init()
		{
			// If a project intends to reference this library (Demo.Custom) from XAML, then
			// include a call to this method somewhere in the code-behind of the referencing
			// project, because just referencing the library in XAML is not enough.
			// This method doesn't do anything itself, but by calling it, it ensures that
			// Demo.Custom library gets included properly in the app.
		}
	}
}

