using System;

using UIKit;

using ARKit;
using SceneKit;

namespace ARDemo
{
    public partial class ViewController : UIViewController
    {

		ARSCNView arSCNView;
		ARSession arSession;
		ARSessionConfiguration arSessionConfig;






        protected ViewController(IntPtr handle) : base(handle)
        {
            // Note: this .ctor should not contain any initialization logic.

        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
			// Perform any additional setup after loading the view, typically from a nib.

        }

        partial void UIButton2935_TouchUpInside(UIButton sender)
		{
			ARViewController arViewCtrl = new ARViewController();

			this.PresentViewController(arViewCtrl, true, null);
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }
    }
}
