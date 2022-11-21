// Developed by Softeq Development Corporation
// http://www.softeq.com

using CoreAnimation;
using CoreGraphics;
using Foundation;
using UIKit;
using AsyncDisplayKitBindings;

namespace AsyncDisplayKitSamples;

public partial class ViewController
{
    public class SampleViewNode : ASDisplayNode
    {
        private readonly ASTextNode _title = new ASTextNode();
        private readonly ASNetworkImageNode _image = new ASNetworkImageNode();
        private readonly ASDisplayNode _gradient = new ASDisplayNode();
        private CAGradientLayer _gradientLayer;

        public SampleViewNode()
        {
            AutomaticallyManagesSubnodes = true;

            // setup image:
            _image.ShouldCacheImage = false;
            _image.Style.PreferredLayoutSize = new ASLayoutSize
            {
                width = new ASDimension
                {
                    unit = ASDimensionUnit.Auto
                },
                height = new ASDimension
                {
                    unit = ASDimensionUnit.Points,
                    value = 100
                }
            };

            // set gradient:
            _gradientLayer = new CAGradientLayer
            {
                Colors = new[]
                {
                    UIColor.Purple.CGColor,
                    UIColor.Red.CGColor,
                    UIColor.Orange.CGColor,
                },
                StartPoint = new CGPoint(x: 0, y: 0),
                EndPoint = new CGPoint(x: 1, y: 1),
            };
            _gradient.Layer.AddSublayer(_gradientLayer);
        }

        public override ASLayoutSpec LayoutSpecThatFits(ASSizeRange constrainedSize)
        {
            _gradientLayer.Frame = new CGRect(CGPoint.Empty, constrainedSize.max);

            return new ASBackgroundLayoutSpec
            {
                Background = _gradient,
                Child = new ASInsetLayoutSpec
                {
                    Insets = new UIEdgeInsets(20, 20, 16, 20),
                    Child = new ASStackLayoutSpec
                    {
                        Direction = ASStackLayoutDirection.Vertical,
                        AlignItems = ASStackLayoutAlignItems.Stretch,
                        Children = new IASLayoutElement[]
                        {
                            _image,
                            _title,
                        },
                        Spacing = 20,
                    }
                },
            };
        }

        public void Update(DataModel model)
        {
            _title.AttributedText = new NSAttributedString(model.Title);
            _image.SetURL(new NSUrl(model.Image), true);
        }
    }
}
