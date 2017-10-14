using System;

using UIKit;
using ARKit;
using SceneKit;

namespace ARDemo
{
    public partial class ARViewController : UIViewController
	{
		ARSCNView arSCNView;
		ARSession arSession;
        ARConfiguration arSessionConfig;

  //      public ARViewController() // : base("ARViewController", null)
  //      {

		//}

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
			// Perform any additional setup after loading the view, typically from a nib.


        }


		public override void ViewWillAppear(bool animated)
		{
			base.ViewWillAppear(animated);
            //ARWorldTrackingSessionConfiguration config;// = new A
            //ARWorldTrackingSessionConfiguration
            ARWorldTrackingConfiguration config = new ARWorldTrackingConfiguration();
            //ARWorldTrackingSessionConfiguration config = new ARWorldTrackingSessionConfiguration{


            //};
			config.PlaneDetection = ARPlaneDetection.Horizontal;
			arSessionConfig = config;
			arSessionConfig.LightEstimationEnabled = true;

			arSession = new ARSession();

			arSCNView = new ARSCNView();
			arSCNView.Frame = View.Bounds;
			arSCNView.Session = arSession;
			arSCNView.AutomaticallyUpdatesLighting = true;
			View.AddSubview(this.arSCNView);
            arSession.Run(this.arSessionConfig,ARSessionRunOptions.RemoveExistingAnchors);



			var scene = SCNScene.FromFile("Models.scnassets/chair/chair.scn");

			SCNNode node = scene.RootNode.ChildNodes[0];


			node.Position = new SCNVector3(0, -1, -1);

			arSCNView.Scene.RootNode.AddNodes(node);



		}

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }
    }
}

