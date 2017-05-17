// WARNING
//
// This file has been generated automatically by Xamarin Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;

namespace XamariniOSJson
{
    [Register ("ViewController")]
    partial class ViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton btnRead { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton btnWrite { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel lblDisplay { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField txtInput { get; set; }

        [Action ("BtnRead_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void BtnRead_TouchUpInside (UIKit.UIButton sender);

        [Action ("BtnWrite_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void BtnWrite_TouchUpInside (UIKit.UIButton sender);

        void ReleaseDesignerOutlets ()
        {
            if (btnRead != null) {
                btnRead.Dispose ();
                btnRead = null;
            }

            if (btnWrite != null) {
                btnWrite.Dispose ();
                btnWrite = null;
            }

            if (lblDisplay != null) {
                lblDisplay.Dispose ();
                lblDisplay = null;
            }

            if (txtInput != null) {
                txtInput.Dispose ();
                txtInput = null;
            }
        }
    }
}