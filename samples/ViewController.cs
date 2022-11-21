// Developed by Softeq Development Corporation
// http://www.softeq.com

using System;
using UIKit;

namespace AsyncDisplayKitSamples;

public partial class ViewController : UIViewController
{
    protected ViewController(IntPtr handle) : base(handle)
    {
        // Note: this .ctor should not contain any initialization logic.
    }

    public override void ViewDidLoad()
    {
        base.ViewDidLoad();

        // add AsyncDisplayKit node to UIKit view:
        var node = new SampleViewNode();
        var childView = node.View;

        View!.AddSubview(childView);

        // use Auto-Layouting from parent view:
        childView.TranslatesAutoresizingMaskIntoConstraints = false;
        View.AddConstraints(new[] {
            childView.LeftAnchor.ConstraintEqualTo(View.LeftAnchor),
            childView.RightAnchor.ConstraintEqualTo(View.RightAnchor),
            childView.CenterYAnchor.ConstraintEqualTo(View.CenterYAnchor),
            childView.HeightAnchor.ConstraintEqualTo(300),
        });

        // bind data:
        var model = new DataModel
        {
            Title = "Lorem Ipsum is simply dummy text of the printing and typesetting industry",
            Image = "https://picsum.photos/200",
        };
        node.Update(model);


        // udpate data:
        var timer = new System.Timers.Timer(2000);
        timer.Elapsed += (sender, e) =>
        {
            var additionalText = e.SignalTime.Millisecond % 2 == 0
                ? " simply dummy text of the printing and typesetting industry"
                : "";
            var data = new DataModel
            {
                Title = $"Lorem Ipsum is {e.SignalTime.ToString()}{additionalText}",
                Image = $"https://picsum.photos/200?random={e.SignalTime.Millisecond}",
            };
            node.Update(data);
        };
        timer.AutoReset = true;
        timer.Enabled = true;
    }

    public override void DidReceiveMemoryWarning()
    {
        base.DidReceiveMemoryWarning();
        // Release any cached data, images, etc that aren't in use.
    }
}
