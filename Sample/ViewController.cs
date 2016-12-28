using System;
using UIKit;

namespace Sample
{
    public partial class ViewController : UIViewController
    {
        protected ViewController(IntPtr handle) : base(handle)
        {
            // Note: this .ctor should not contain any initialization logic.
        }

        public override void LoadView()
        {
            base.LoadView();
           // ObjCRuntime.Class.ThrowOnInitFailure = false;
           
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.

            // In loadView(Recommended) or viewDidLoad
            //            FSCalendar* calendar = [[FSCalendar alloc] initWithFrame: CGRectMake(0, 0, 320, 300)];
            //            calendar.dataSource = self;
            //            calendar.delegate = self;
            //[self.view addSubview:calendar];
            //self.calendar = calendar;

            var calendar = new FSCalendar();
            calendar.Frame = new CoreGraphics.CGRect(0, 0, 320, 300);
            View.Add(calendar);

        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }
    }
}
