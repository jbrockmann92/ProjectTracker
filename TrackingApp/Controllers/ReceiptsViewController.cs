using Foundation;
using System;
using System.Collections.Generic;
using UIKit;
using ProjectAPI.Models;

namespace TrackingApp
{
    public partial class ReceiptsViewController : UIViewController
    {
        public List<Receipt> receipts;

        public ReceiptsViewController (IntPtr handle) : base (handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();


        }
    }
}