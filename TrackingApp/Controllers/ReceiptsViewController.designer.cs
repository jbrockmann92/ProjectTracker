// WARNING
//
// This file has been generated automatically by Visual Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace TrackingApp
{
    [Register ("ReceiptsViewController")]
    partial class ReceiptsViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton AddReceiptsButton { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel ReceiptInfo { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel ReceiptName { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel ReceiptsProjectNumber { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel ReceiptsProjectTitle { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (AddReceiptsButton != null) {
                AddReceiptsButton.Dispose ();
                AddReceiptsButton = null;
            }

            if (ReceiptInfo != null) {
                ReceiptInfo.Dispose ();
                ReceiptInfo = null;
            }

            if (ReceiptName != null) {
                ReceiptName.Dispose ();
                ReceiptName = null;
            }

            if (ReceiptsProjectNumber != null) {
                ReceiptsProjectNumber.Dispose ();
                ReceiptsProjectNumber = null;
            }

            if (ReceiptsProjectTitle != null) {
                ReceiptsProjectTitle.Dispose ();
                ReceiptsProjectTitle = null;
            }
        }
    }
}