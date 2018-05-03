using System;
using UIKit;
using CoreGraphics;
using Foundation;
using AVFoundation;


namespace UdemXamIOSAccVideos
{
    public partial class ViewController : UIViewController
    {
        protected ViewController(IntPtr handle) : base(handle)
        {
            // Note: this .ctor should not contain any initialization logic.
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            BtnVideoLocal.TouchUpInside += delegate
            {
                AVPlayer Reproductor;
                AVPlayerLayer CapadeReproductor;
                AVAsset Recurso;
                AVPlayerItem RecursoReproducir;

                Recurso = AVAsset.FromUrl(NSUrl.FromFilename("VID-20180501-WA0001.mp4"));
                RecursoReproducir = new AVPlayerItem(Recurso);
                Reproductor = new AVPlayer(RecursoReproducir);
                CapadeReproductor = AVPlayerLayer.FromPlayer(Reproductor);
                CapadeReproductor.Frame = new CGRect(50, 100, 300, 300);
                View.Layer.AddSublayer(CapadeReproductor);
                Reproductor.Play();
            };

            BtnVideoInternet.TouchUpInside += delegate
            {
                AVPlayer Reproductor;
                AVPlayerLayer CapadeReproductor;
                AVAsset Recurso;
                AVPlayerItem RecursoReproducir;

                Recurso = AVAsset.FromUrl(NSUrl.FromString("https://www.youtube.com/watch?v=DEz-imekZDw"));
                RecursoReproducir = new AVPlayerItem(Recurso);
                Reproductor = new AVPlayer(RecursoReproducir);
                CapadeReproductor = AVPlayerLayer.FromPlayer(Reproductor);
                CapadeReproductor.Frame = new CGRect(50, 340, 300, 300);
                View.Layer.AddSublayer(CapadeReproductor);
                Reproductor.Play();
            };

            // Perform any additional setup after loading the view, typically from a nib.
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }
    }
}
