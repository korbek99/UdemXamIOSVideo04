// WARNING
//
// This file has been generated automatically by Visual Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace UdemXamIOSAccVideos
{
	[Register ("ViewController")]
	partial class ViewController
	{
		[Outlet]
		UIKit.UIButton BtnVideoInternet { get; set; }

		[Outlet]
		UIKit.UIButton BtnVideoLocal { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (BtnVideoLocal != null) {
				BtnVideoLocal.Dispose ();
				BtnVideoLocal = null;
			}

			if (BtnVideoInternet != null) {
				BtnVideoInternet.Dispose ();
				BtnVideoInternet = null;
			}
		}
	}
}
