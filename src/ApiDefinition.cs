using System;
using System.Runtime.InteropServices;
using AVFoundation;
using CoreAnimation;
using CoreFoundation;
using CoreGraphics;
using CoreMedia;
using Foundation;
using ObjCRuntime;
using Photos;
using UIKit;

namespace AsyncDisplayKitBindings
{
    // @protocol ASAsyncTransactionContainer
    [Protocol, Model]
    interface ASAsyncTransactionContainer
    {
        // @required @property (getter = asyncdisplaykit_isAsyncTransactionContainer, assign, nonatomic, setter = asyncdisplaykit_setAsyncTransactionContainer:) BOOL asyncdisplaykit_asyncTransactionContainer;
        [Abstract]
        [Export ("asyncdisplaykit_asyncTransactionContainer")]
        bool Asyncdisplaykit_asyncTransactionContainer { [Bind ("asyncdisplaykit_isAsyncTransactionContainer")] get; [Bind ("asyncdisplaykit_setAsyncTransactionContainer:")] set; }

        // @required @property (readonly, assign, nonatomic) ASAsyncTransactionContainerState asyncdisplaykit_asyncTransactionContainerState;
        [Abstract]
        [Export ("asyncdisplaykit_asyncTransactionContainerState", ArgumentSemantic.Assign)]
        ASAsyncTransactionContainerState Asyncdisplaykit_asyncTransactionContainerState { get; }

        // @required -(void)asyncdisplaykit_cancelAsyncTransactions;
        [Abstract]
        [Export ("asyncdisplaykit_cancelAsyncTransactions")]
        void Asyncdisplaykit_cancelAsyncTransactions ();

        // @required @property (nonatomic, setter = asyncdisplaykit_setCurrentAsyncTransaction:, strong) _ASAsyncTransaction * _Nullable asyncdisplaykit_currentAsyncTransaction;
        [Abstract]
        [NullAllowed, Export ("asyncdisplaykit_currentAsyncTransaction", ArgumentSemantic.Strong)]
        _ASAsyncTransaction Asyncdisplaykit_currentAsyncTransaction { get; [Bind ("asyncdisplaykit_setCurrentAsyncTransaction:")] set; }
    }

    interface IASAsyncTransactionContainer {}

    //// @interface ASAsyncTransactionContainer (CALayer) <ASAsyncTransactionContainer>
    //[Category]
    //[BaseType (typeof(CALayer))]
    //interface CALayer_ASAsyncTransactionContainer : IASAsyncTransactionContainer
    //{
    //    // @property (readonly, nonatomic, strong) _ASAsyncTransaction * _Nullable asyncdisplaykit_asyncTransaction;
    //    [NullAllowed, Export ("asyncdisplaykit_asyncTransaction", ArgumentSemantic.Strong)]
    //    _ASAsyncTransaction Asyncdisplaykit_asyncTransaction { get; }

    //    // @property (readonly, nonatomic, strong) CALayer * _Nullable asyncdisplaykit_parentTransactionContainer;
    //    [NullAllowed, Export ("asyncdisplaykit_parentTransactionContainer", ArgumentSemantic.Strong)]
    //    CALayer Asyncdisplaykit_parentTransactionContainer { get; }
    //}

    //// @interface ASAsyncTransactionContainer (UIView) <ASAsyncTransactionContainer>
    //[Category]
    //[BaseType (typeof(UIView))]
    //interface UIView_ASAsyncTransactionContainer : IASAsyncTransactionContainer
    //{
    //}

    //[Static]
    //[Verify (ConstantsInterfaceAssociation)]
    //partial interface Constants
    //{
    //    // extern const ASDimension ASDimensionAuto;
    //    [Field ("ASDimensionAuto", "__Internal")]
    //    ASDimension ASDimensionAuto { get; }
    //}

    //[Static]
    //[Verify (ConstantsInterfaceAssociation)]
    //partial interface Constants
    //{
    //    // extern const ASLayoutSize ASLayoutSizeAuto;
    //    [Field ("ASLayoutSizeAuto", "__Internal")]
    //    ASLayoutSize ASLayoutSizeAuto { get; }
    //}

    //[Static]
    //[Verify (ConstantsInterfaceAssociation)]
    //partial interface Constants
    //{
    //    // extern const ASSizeRange ASSizeRangeZero;
    //    [Field ("ASSizeRangeZero", "__Internal")]
    //    ASSizeRange ASSizeRangeZero { get; }

    //    // extern const ASSizeRange ASSizeRangeUnconstrained;
    //    [Field ("ASSizeRangeUnconstrained", "__Internal")]
    //    ASSizeRange ASSizeRangeUnconstrained { get; }
    //}

    //// @protocol ASLayoutElementAsciiArtProtocol <NSObject>
    //[Protocol, Model]
    //[BaseType (typeof(NSObject))]
    //interface ASLayoutElementAsciiArtProtocol
    //{
    //    // @required -(NSString * _Nonnull)asciiArtString;
    //    [Abstract]
    //    [Export ("asciiArtString")]
    //    [Verify (MethodToProperty)]
    //    string AsciiArtString { get; }

    //    // @required -(NSString * _Nonnull)asciiArtName;
    //    [Abstract]
    //    [Export ("asciiArtName")]
    //    [Verify (MethodToProperty)]
    //    string AsciiArtName { get; }
    //}

    //// @interface ASAsciiArtBoxCreator : NSObject
    //[BaseType (typeof(NSObject))]
    //interface ASAsciiArtBoxCreator
    //{
    //    // +(NSString * _Nonnull)horizontalBoxStringForChildren:(NSArray<NSString *> * _Nonnull)children parent:(NSString * _Nonnull)parent;
    //    [Static]
    //    [Export ("horizontalBoxStringForChildren:parent:")]
    //    string HorizontalBoxStringForChildren (string[] children, string parent);

    //    // +(NSString * _Nonnull)verticalBoxStringForChildren:(NSArray<NSString *> * _Nonnull)children parent:(NSString * _Nonnull)parent;
    //    [Static]
    //    [Export ("verticalBoxStringForChildren:parent:")]
    //    string VerticalBoxStringForChildren (string[] children, string parent);
    //}

    //// @protocol ASDebugNameProvider <NSObject>
    //[Protocol, Model]
    //[BaseType (typeof(NSObject))]
    //interface ASDebugNameProvider
    //{
    //    // @required @property (copy, nonatomic) NSString * _Nullable debugName;
    //    [Abstract]
    //    [NullAllowed, Export ("debugName")]
    //    string DebugName { get; set; }
    //}

    //// @protocol ASDebugDescriptionProvider
    //[Protocol, Model]
    //interface ASDebugDescriptionProvider
    //{
    //    // @required -(NSMutableArray<NSDictionary *> * _Nonnull)propertiesForDebugDescription;
    //    [Abstract]
    //    [Export ("propertiesForDebugDescription")]
    //    [Verify (MethodToProperty)]
    //    NSMutableArray<NSDictionary> PropertiesForDebugDescription { get; }
    //}

    //// @protocol ASDescriptionProvider
    //[Protocol, Model]
    //interface ASDescriptionProvider
    //{
    //    // @required -(NSMutableArray<NSDictionary *> * _Nonnull)propertiesForDescription;
    //    [Abstract]
    //    [Export ("propertiesForDescription")]
    //    [Verify (MethodToProperty)]
    //    NSMutableArray<NSDictionary> PropertiesForDescription { get; }
    //}

    //// @interface ASLayoutElementContext : NSObject
    //[BaseType (typeof(NSObject))]
    //interface ASLayoutElementContext
    //{
    //    // @property (nonatomic) int32_t transitionID;
    //    [Export ("transitionID")]
    //    int TransitionID { get; set; }
    //}

    //[Static]
    //[Verify (ConstantsInterfaceAssociation)]
    //partial interface Constants
    //{
    //    // extern const int32_t ASLayoutElementContextInvalidTransitionID;
    //    [Field ("ASLayoutElementContextInvalidTransitionID", "__Internal")]
    //    int ASLayoutElementContextInvalidTransitionID { get; }

    //    // extern const int32_t ASLayoutElementContextDefaultTransitionID;
    //    [Field ("ASLayoutElementContextDefaultTransitionID", "__Internal")]
    //    int ASLayoutElementContextDefaultTransitionID { get; }
    //}

    // @protocol ASLayoutElementExtensibility <NSObject>
    [Protocol, Model]
    [BaseType (typeof(NSObject))]
    interface ASLayoutElementExtensibility
    {
        // @required -(void)setLayoutOptionExtensionBool:(BOOL)value atIndex:(int)idx;
        [Abstract]
        [Export ("setLayoutOptionExtensionBool:atIndex:")]
        void SetLayoutOptionExtensionBool (bool value, int idx);

        // @required -(BOOL)layoutOptionExtensionBoolAtIndex:(int)idx;
        [Abstract]
        [Export ("layoutOptionExtensionBoolAtIndex:")]
        bool LayoutOptionExtensionBoolAtIndex (int idx);

        // @required -(void)setLayoutOptionExtensionInteger:(NSInteger)value atIndex:(int)idx;
        [Abstract]
        [Export ("setLayoutOptionExtensionInteger:atIndex:")]
        void SetLayoutOptionExtensionInteger (nint value, int idx);

        // @required -(NSInteger)layoutOptionExtensionIntegerAtIndex:(int)idx;
        [Abstract]
        [Export ("layoutOptionExtensionIntegerAtIndex:")]
        nint LayoutOptionExtensionIntegerAtIndex (int idx);

        // @required -(void)setLayoutOptionExtensionEdgeInsets:(UIEdgeInsets)value atIndex:(int)idx;
        [Abstract]
        [Export ("setLayoutOptionExtensionEdgeInsets:atIndex:")]
        void SetLayoutOptionExtensionEdgeInsets (UIEdgeInsets value, int idx);

        // @required -(UIEdgeInsets)layoutOptionExtensionEdgeInsetsAtIndex:(int)idx;
        [Abstract]
        [Export ("layoutOptionExtensionEdgeInsetsAtIndex:")]
        UIEdgeInsets LayoutOptionExtensionEdgeInsetsAtIndex (int idx);
    }

    // @protocol ASStackLayoutElement <NSObject>
    [Protocol, Model]
    [BaseType (typeof(NSObject))]
    interface ASStackLayoutElement
    {
        // @required @property (readwrite, nonatomic) CGFloat spacingBefore;
        [Abstract]
        [Export ("spacingBefore")]
        nfloat SpacingBefore { get; set; }

        // @required @property (readwrite, nonatomic) CGFloat spacingAfter;
        [Abstract]
        [Export ("spacingAfter")]
        nfloat SpacingAfter { get; set; }

        // @required @property (readwrite, nonatomic) CGFloat flexGrow;
        [Abstract]
        [Export ("flexGrow")]
        nfloat FlexGrow { get; set; }

        // @required @property (readwrite, nonatomic) CGFloat flexShrink;
        [Abstract]
        [Export ("flexShrink")]
        nfloat FlexShrink { get; set; }

        // @required @property (readwrite, nonatomic) ASDimension flexBasis;
        [Abstract]
        [Export ("flexBasis", ArgumentSemantic.Assign)]
        ASDimension FlexBasis { get; set; }

        // @required @property (readwrite, nonatomic) ASStackLayoutAlignSelf alignSelf;
        [Abstract]
        [Export ("alignSelf", ArgumentSemantic.Assign)]
        ASStackLayoutAlignSelf AlignSelf { get; set; }

        // @required @property (readwrite, nonatomic) CGFloat ascender;
        [Abstract]
        [Export ("ascender")]
        nfloat Ascender { get; set; }

        // @required @property (readwrite, nonatomic) CGFloat descender;
        [Abstract]
        [Export ("descender")]
        nfloat Descender { get; set; }
    }

    // @protocol ASAbsoluteLayoutElement
    [Protocol, Model]
    interface ASAbsoluteLayoutElement
    {
        // @required @property (assign, nonatomic) CGPoint layoutPosition;
        [Abstract]
        [Export ("layoutPosition", ArgumentSemantic.Assign)]
        CGPoint LayoutPosition { get; set; }
    }

    // @protocol ASTraitEnvironment <NSObject>
    [Protocol, Model]
    [BaseType (typeof(NSObject))]
    interface ASTraitEnvironment
    {
        // @required -(ASPrimitiveTraitCollection)primitiveTraitCollection;
        // @required -(void)setPrimitiveTraitCollection:(ASPrimitiveTraitCollection)traitCollection;
        [Abstract]
        [Export ("primitiveTraitCollection")]
        //[Verify (MethodToProperty)]
        ASPrimitiveTraitCollection PrimitiveTraitCollection { get; set; }

        // @required -(ASTraitCollection * _Nonnull)asyncTraitCollection;
        [Abstract]
        [Export ("asyncTraitCollection")]
        ASTraitCollection AsyncTraitCollection ();
    }

    interface IASTraitEnvironment {}

    // @interface ASTraitCollection : NSObject
    [BaseType (typeof(NSObject))]
    interface ASTraitCollection
    {
        // @property (readonly, assign, nonatomic) CGFloat displayScale;
        [Export ("displayScale")]
        nfloat DisplayScale { get; }

        // @property (readonly, assign, nonatomic) UIUserInterfaceSizeClass horizontalSizeClass;
        [Export ("horizontalSizeClass", ArgumentSemantic.Assign)]
        UIUserInterfaceSizeClass HorizontalSizeClass { get; }

        // @property (readonly, assign, nonatomic) UIUserInterfaceIdiom userInterfaceIdiom;
        [Export ("userInterfaceIdiom", ArgumentSemantic.Assign)]
        UIUserInterfaceIdiom UserInterfaceIdiom { get; }

        // @property (readonly, assign, nonatomic) UIUserInterfaceSizeClass verticalSizeClass;
        [Export ("verticalSizeClass", ArgumentSemantic.Assign)]
        UIUserInterfaceSizeClass VerticalSizeClass { get; }

        // @property (readonly, assign, nonatomic) UIForceTouchCapability forceTouchCapability;
        [Export ("forceTouchCapability", ArgumentSemantic.Assign)]
        UIForceTouchCapability ForceTouchCapability { get; }

        // @property (readonly, assign, nonatomic) CGSize containerSize;
        [Export ("containerSize", ArgumentSemantic.Assign)]
        CGSize ContainerSize { get; }

        // +(ASTraitCollection * _Nonnull)traitCollectionWithASPrimitiveTraitCollection:(ASPrimitiveTraitCollection)traits;
        [Static]
        [Export ("traitCollectionWithASPrimitiveTraitCollection:")]
        ASTraitCollection TraitCollectionWithASPrimitiveTraitCollection (ASPrimitiveTraitCollection traits);

        // +(ASTraitCollection * _Nonnull)traitCollectionWithUITraitCollection:(UITraitCollection * _Nonnull)traitCollection containerSize:(CGSize)windowSize;
        [Static]
        [Export ("traitCollectionWithUITraitCollection:containerSize:")]
        ASTraitCollection TraitCollectionWithUITraitCollection (UITraitCollection traitCollection, CGSize windowSize);

        // +(ASTraitCollection * _Nonnull)traitCollectionWithDisplayScale:(CGFloat)displayScale userInterfaceIdiom:(UIUserInterfaceIdiom)userInterfaceIdiom horizontalSizeClass:(UIUserInterfaceSizeClass)horizontalSizeClass verticalSizeClass:(UIUserInterfaceSizeClass)verticalSizeClass forceTouchCapability:(UIForceTouchCapability)forceTouchCapability containerSize:(CGSize)windowSize;
        [Static]
        [Export ("traitCollectionWithDisplayScale:userInterfaceIdiom:horizontalSizeClass:verticalSizeClass:forceTouchCapability:containerSize:")]
        ASTraitCollection TraitCollectionWithDisplayScale (nfloat displayScale, UIUserInterfaceIdiom userInterfaceIdiom, UIUserInterfaceSizeClass horizontalSizeClass, UIUserInterfaceSizeClass verticalSizeClass, UIForceTouchCapability forceTouchCapability, CGSize windowSize);

        // -(ASPrimitiveTraitCollection)primitiveTraitCollection;
        [Export ("primitiveTraitCollection")]
        //[Verify (MethodToProperty)]
        ASPrimitiveTraitCollection PrimitiveTraitCollection { get; }

        // -(BOOL)isEqualToTraitCollection:(ASTraitCollection * _Nonnull)traitCollection;
        [Export ("isEqualToTraitCollection:")]
        bool IsEqualToTraitCollection (ASTraitCollection traitCollection);
    }

    //[Static]
    //[Verify (ConstantsInterfaceAssociation)]
    //partial interface Constants
    //{
    //    // extern const CGFloat ASLayoutElementParentDimensionUndefined;
    //    [Field ("ASLayoutElementParentDimensionUndefined", "__Internal")]
    //    nfloat ASLayoutElementParentDimensionUndefined { get; }

    //    // extern const CGSize ASLayoutElementParentSizeUndefined;
    //    [Field ("ASLayoutElementParentSizeUndefined", "__Internal")]
    //    CGSize ASLayoutElementParentSizeUndefined { get; }
    //}

    // @protocol ASLayoutElement <ASLayoutElementExtensibility, ASTraitEnvironment, ASLayoutElementAsciiArtProtocol>
    [Protocol, Model]
    interface ASLayoutElement
    {
        // @required @property (readonly, assign, nonatomic) ASLayoutElementType layoutElementType;
        [Abstract]
        [Export ("layoutElementType", ArgumentSemantic.Assign)]
        ASLayoutElementType LayoutElementType { get; }

        // @required @property (readonly, nonatomic, strong) ASLayoutElementStyle * _Nonnull style;
        [Abstract]
        [Export ("style", ArgumentSemantic.Strong)]
        ASLayoutElementStyle Style { get; }

        // @required -(NSArray<id<ASLayoutElement>> * _Nullable)sublayoutElements;
        [Abstract]
        [NullAllowed, Export ("sublayoutElements")]
        //[Verify (MethodToProperty)]
        IASLayoutElement[] SublayoutElements { get; }

        // @required -(ASLayout * _Nonnull)layoutThatFits:(ASSizeRange)constrainedSize;
        [Abstract]
        [Export ("layoutThatFits:")]
        ASLayout LayoutThatFits (ASSizeRange constrainedSize);

        // @required -(ASLayout * _Nonnull)layoutThatFits:(ASSizeRange)constrainedSize parentSize:(CGSize)parentSize;
        [Abstract]
        [Export ("layoutThatFits:parentSize:")]
        ASLayout LayoutThatFits (ASSizeRange constrainedSize, CGSize parentSize);

        // @required -(ASLayout * _Nonnull)calculateLayoutThatFits:(ASSizeRange)constrainedSize;
        [Abstract]
        [Export ("calculateLayoutThatFits:")]
        ASLayout CalculateLayoutThatFits (ASSizeRange constrainedSize);

        // @required -(ASLayout * _Nonnull)calculateLayoutThatFits:(ASSizeRange)constrainedSize restrictedToSize:(ASLayoutElementSize)size relativeToParentSize:(CGSize)parentSize;
        [Abstract]
        [Export ("calculateLayoutThatFits:restrictedToSize:relativeToParentSize:")]
        ASLayout CalculateLayoutThatFits (ASSizeRange constrainedSize, ASLayoutElementSize size, CGSize parentSize);

        // @required -(BOOL)implementsLayoutMethod;
        [Abstract]
        [Export ("implementsLayoutMethod")]
        //[Verify (MethodToProperty)]
        bool ImplementsLayoutMethod { get; }
    }

    interface IASLayoutElement {}

    //[Static]
    //[Verify (ConstantsInterfaceAssociation)]
    //partial interface Constants
    //{
    //    // extern NSString *const _Nonnull ASLayoutElementStyleWidthProperty;
    //    [Field ("ASLayoutElementStyleWidthProperty", "__Internal")]
    //    NSString ASLayoutElementStyleWidthProperty { get; }

    //    // extern NSString *const _Nonnull ASLayoutElementStyleMinWidthProperty;
    //    [Field ("ASLayoutElementStyleMinWidthProperty", "__Internal")]
    //    NSString ASLayoutElementStyleMinWidthProperty { get; }

    //    // extern NSString *const _Nonnull ASLayoutElementStyleMaxWidthProperty;
    //    [Field ("ASLayoutElementStyleMaxWidthProperty", "__Internal")]
    //    NSString ASLayoutElementStyleMaxWidthProperty { get; }

    //    // extern NSString *const _Nonnull ASLayoutElementStyleHeightProperty;
    //    [Field ("ASLayoutElementStyleHeightProperty", "__Internal")]
    //    NSString ASLayoutElementStyleHeightProperty { get; }

    //    // extern NSString *const _Nonnull ASLayoutElementStyleMinHeightProperty;
    //    [Field ("ASLayoutElementStyleMinHeightProperty", "__Internal")]
    //    NSString ASLayoutElementStyleMinHeightProperty { get; }

    //    // extern NSString *const _Nonnull ASLayoutElementStyleMaxHeightProperty;
    //    [Field ("ASLayoutElementStyleMaxHeightProperty", "__Internal")]
    //    NSString ASLayoutElementStyleMaxHeightProperty { get; }

    //    // extern NSString *const _Nonnull ASLayoutElementStyleSpacingBeforeProperty;
    //    [Field ("ASLayoutElementStyleSpacingBeforeProperty", "__Internal")]
    //    NSString ASLayoutElementStyleSpacingBeforeProperty { get; }

    //    // extern NSString *const _Nonnull ASLayoutElementStyleSpacingAfterProperty;
    //    [Field ("ASLayoutElementStyleSpacingAfterProperty", "__Internal")]
    //    NSString ASLayoutElementStyleSpacingAfterProperty { get; }

    //    // extern NSString *const _Nonnull ASLayoutElementStyleFlexGrowProperty;
    //    [Field ("ASLayoutElementStyleFlexGrowProperty", "__Internal")]
    //    NSString ASLayoutElementStyleFlexGrowProperty { get; }

    //    // extern NSString *const _Nonnull ASLayoutElementStyleFlexShrinkProperty;
    //    [Field ("ASLayoutElementStyleFlexShrinkProperty", "__Internal")]
    //    NSString ASLayoutElementStyleFlexShrinkProperty { get; }

    //    // extern NSString *const _Nonnull ASLayoutElementStyleFlexBasisProperty;
    //    [Field ("ASLayoutElementStyleFlexBasisProperty", "__Internal")]
    //    NSString ASLayoutElementStyleFlexBasisProperty { get; }

    //    // extern NSString *const _Nonnull ASLayoutElementStyleAlignSelfProperty;
    //    [Field ("ASLayoutElementStyleAlignSelfProperty", "__Internal")]
    //    NSString ASLayoutElementStyleAlignSelfProperty { get; }

    //    // extern NSString *const _Nonnull ASLayoutElementStyleAscenderProperty;
    //    [Field ("ASLayoutElementStyleAscenderProperty", "__Internal")]
    //    NSString ASLayoutElementStyleAscenderProperty { get; }

    //    // extern NSString *const _Nonnull ASLayoutElementStyleDescenderProperty;
    //    [Field ("ASLayoutElementStyleDescenderProperty", "__Internal")]
    //    NSString ASLayoutElementStyleDescenderProperty { get; }

    //    // extern NSString *const _Nonnull ASLayoutElementStyleLayoutPositionProperty;
    //    [Field ("ASLayoutElementStyleLayoutPositionProperty", "__Internal")]
    //    NSString ASLayoutElementStyleLayoutPositionProperty { get; }
    //}

    // @protocol ASLayoutElementStyleDelegate <NSObject>
    [Protocol, Model]
    [BaseType (typeof(NSObject))]
    interface ASLayoutElementStyleDelegate
    {
        // @required -(void)style:(__kindof ASLayoutElementStyle * _Nonnull)style propertyDidChange:(NSString * _Nonnull)propertyName;
        [Abstract]
        [Export ("style:propertyDidChange:")]
        void PropertyDidChange (ASLayoutElementStyle style, string propertyName);
    }

    // @interface ASLayoutElementStyle : NSObject <ASStackLayoutElement, ASAbsoluteLayoutElement, ASLayoutElementExtensibility>
    [BaseType (typeof(NSObject))]
    interface ASLayoutElementStyle : ASStackLayoutElement, ASAbsoluteLayoutElement, ASLayoutElementExtensibility
    {
        // -(instancetype _Nonnull)initWithDelegate:(id<ASLayoutElementStyleDelegate> _Nonnull)delegate;
        [Export ("initWithDelegate:")]
        IntPtr Constructor (ASLayoutElementStyleDelegate @delegate);

        [Wrap ("WeakDelegate")]
        [NullAllowed]
        ASLayoutElementStyleDelegate Delegate { get; }

        // @property (readonly, nonatomic, weak) id<ASLayoutElementStyleDelegate> _Nullable delegate;
        [NullAllowed, Export ("delegate", ArgumentSemantic.Weak)]
        NSObject WeakDelegate { get; }

        // @property (assign, readwrite, nonatomic) ASDimension width;
        [Export ("width", ArgumentSemantic.Assign)]
        ASDimension Width { get; set; }

        // @property (assign, readwrite, nonatomic) ASDimension height;
        [Export ("height", ArgumentSemantic.Assign)]
        ASDimension Height { get; set; }

        // @property (assign, readwrite, nonatomic) ASDimension minHeight;
        [Export ("minHeight", ArgumentSemantic.Assign)]
        ASDimension MinHeight { get; set; }

        // @property (assign, readwrite, nonatomic) ASDimension maxHeight;
        [Export ("maxHeight", ArgumentSemantic.Assign)]
        ASDimension MaxHeight { get; set; }

        // @property (assign, readwrite, nonatomic) ASDimension minWidth;
        [Export ("minWidth", ArgumentSemantic.Assign)]
        ASDimension MinWidth { get; set; }

        // @property (assign, readwrite, nonatomic) ASDimension maxWidth;
        [Export ("maxWidth", ArgumentSemantic.Assign)]
        ASDimension MaxWidth { get; set; }

        // @property (assign, nonatomic) CGSize preferredSize;
        [Export ("preferredSize", ArgumentSemantic.Assign)]
        CGSize PreferredSize { get; set; }

        // @property (assign, nonatomic) CGSize minSize;
        [Export ("minSize", ArgumentSemantic.Assign)]
        CGSize MinSize { get; set; }

        // @property (assign, nonatomic) CGSize maxSize;
        [Export ("maxSize", ArgumentSemantic.Assign)]
        CGSize MaxSize { get; set; }

        // @property (assign, readwrite, nonatomic) ASLayoutSize preferredLayoutSize;
        [Export ("preferredLayoutSize", ArgumentSemantic.Assign)]
        ASLayoutSize PreferredLayoutSize { get; set; }

        // @property (assign, readwrite, nonatomic) ASLayoutSize minLayoutSize;
        [Export ("minLayoutSize", ArgumentSemantic.Assign)]
        ASLayoutSize MinLayoutSize { get; set; }

        // @property (assign, readwrite, nonatomic) ASLayoutSize maxLayoutSize;
        [Export ("maxLayoutSize", ArgumentSemantic.Assign)]
        ASLayoutSize MaxLayoutSize { get; set; }
    }

    // @protocol ASLayoutElementStylability
    [Protocol, Model]
    interface ASLayoutElementStylability
    {
        // @required -(instancetype _Nonnull)styledWithBlock:(void (^ _Nonnull)(__kindof ASLayoutElementStyle * _Nonnull))styleBlock;
        [Abstract]
        [Export ("styledWithBlock:")]
        IASLayoutElementStylability StyledWithBlock (Action<ASLayoutElementStyle> styleBlock);
    }

    interface IASLayoutElementStylability {}

    // typedef UIView * _Nonnull (^ASDisplayNodeViewBlock)();
    delegate UIView ASDisplayNodeViewBlock ();

    // typedef UIViewController * _Nonnull (^ASDisplayNodeViewControllerBlock)();
    delegate UIViewController ASDisplayNodeViewControllerBlock ();

    // typedef CALayer * _Nonnull (^ASDisplayNodeLayerBlock)();
    delegate CALayer ASDisplayNodeLayerBlock ();

    // typedef void (^ASDisplayNodeDidLoadBlock)(__kindof ASDisplayNode * _Nonnull);
    delegate void ASDisplayNodeDidLoadBlock (ASDisplayNode arg0);

    //// typedef void (^ASDisplayNodeContextModifier)(CGContextRef _Nonnull, id _Nullable);
    //unsafe delegate void ASDisplayNodeContextModifier (CGContextRef* arg0, [NullAllowed] NSObject arg1);

    // typedef ASLayoutSpec * _Nonnull (^ASLayoutSpecBlock)(__kindof ASDisplayNode * _Nonnull, ASSizeRange);
    delegate ASLayoutSpec ASLayoutSpecBlock (ASDisplayNode arg0, ASSizeRange arg1);

    // typedef void (^ASDisplayNodeNonFatalErrorBlock)(__kindof NSError * _Nonnull);
    delegate void ASDisplayNodeNonFatalErrorBlock (NSError arg0);

    //[Static]
    //[Verify (ConstantsInterfaceAssociation)]
    //partial interface Constants
    //{
    //    // extern const NSInteger ASDefaultDrawingPriority;
    //    [Field ("ASDefaultDrawingPriority", "__Internal")]
    //    nint ASDefaultDrawingPriority { get; }
    //}

    // @interface ASDisplayNode : NSObject
    [BaseType (typeof(NSObject))]
    partial interface ASDisplayNode : ASLayoutElement, ASLayoutElementStylability, ASAsyncTransactionContainer, ASInterfaceStateDelegate
    {
        // -(instancetype _Nonnull)initWithViewBlock:(ASDisplayNodeViewBlock _Nonnull)viewBlock;
        [Export ("initWithViewBlock:")]
        IntPtr Constructor (ASDisplayNodeViewBlock viewBlock);

        // -(instancetype _Nonnull)initWithViewBlock:(ASDisplayNodeViewBlock _Nonnull)viewBlock didLoadBlock:(ASDisplayNodeDidLoadBlock _Nullable)didLoadBlock;
        [Export ("initWithViewBlock:didLoadBlock:")]
        IntPtr Constructor (ASDisplayNodeViewBlock viewBlock, [NullAllowed] ASDisplayNodeDidLoadBlock didLoadBlock);

        // -(instancetype _Nonnull)initWithLayerBlock:(ASDisplayNodeLayerBlock _Nonnull)layerBlock;
        [Export ("initWithLayerBlock:")]
        IntPtr Constructor (ASDisplayNodeLayerBlock layerBlock);

        // -(instancetype _Nonnull)initWithLayerBlock:(ASDisplayNodeLayerBlock _Nonnull)layerBlock didLoadBlock:(ASDisplayNodeDidLoadBlock _Nullable)didLoadBlock;
        [Export ("initWithLayerBlock:didLoadBlock:")]
        IntPtr Constructor (ASDisplayNodeLayerBlock layerBlock, [NullAllowed] ASDisplayNodeDidLoadBlock didLoadBlock);

        // -(void)onDidLoad:(ASDisplayNodeDidLoadBlock _Nonnull)body;
        [Export ("onDidLoad:")]
        void OnDidLoad (ASDisplayNodeDidLoadBlock body);

        // -(void)setViewBlock:(ASDisplayNodeViewBlock _Nonnull)viewBlock;
        [Export ("setViewBlock:")]
        void SetViewBlock (ASDisplayNodeViewBlock viewBlock);

        // -(void)setLayerBlock:(ASDisplayNodeLayerBlock _Nonnull)layerBlock;
        [Export ("setLayerBlock:")]
        void SetLayerBlock (ASDisplayNodeLayerBlock layerBlock);

        // @property (readonly, getter = isSynchronous, assign, atomic) BOOL synchronous;
        [Export ("synchronous")]
        bool Synchronous { [Bind ("isSynchronous")] get; }

        // @property (readonly, nonatomic, strong) UIView * _Nonnull view;
        [Export ("view", ArgumentSemantic.Strong)]
        UIView View { get; }

        // @property (readonly, getter = isNodeLoaded, assign, nonatomic) BOOL nodeLoaded;
        [Export ("nodeLoaded")]
        bool NodeLoaded { [Bind ("isNodeLoaded")] get; }

        // @property (getter = isLayerBacked, assign, nonatomic) BOOL layerBacked;
        [Export ("layerBacked")]
        bool LayerBacked { [Bind ("isLayerBacked")] get; set; }

        // @property (readonly, nonatomic, strong) CALayer * _Nonnull layer;
        [Export ("layer", ArgumentSemantic.Strong)]
        CALayer Layer { get; }

        // @property (readonly, getter = isVisible) BOOL visible;
        [Export ("visible")]
        bool Visible { [Bind ("isVisible")] get; }

        // @property (readonly, getter = isInPreloadState) BOOL inPreloadState;
        [Export ("inPreloadState")]
        bool InPreloadState { [Bind ("isInPreloadState")] get; }

        // @property (readonly, getter = isInDisplayState) BOOL inDisplayState;
        [Export ("inDisplayState")]
        bool InDisplayState { [Bind ("isInDisplayState")] get; }

        // @property (readonly) ASInterfaceState interfaceState;
        [Export ("interfaceState")]
        ASInterfaceState InterfaceState { get; }

        // @property (copy, nonatomic, class) ASDisplayNodeNonFatalErrorBlock _Nonnull nonFatalErrorBlock;
        [Static]
        [Export ("nonFatalErrorBlock", ArgumentSemantic.Copy)]
        ASDisplayNodeNonFatalErrorBlock NonFatalErrorBlock { get; set; }

        // -(void)addSubnode:(ASDisplayNode * _Nonnull)subnode;
        [Export ("addSubnode:")]
        void AddSubnode (ASDisplayNode subnode);

        // -(void)insertSubnode:(ASDisplayNode * _Nonnull)subnode belowSubnode:(ASDisplayNode * _Nonnull)below;
        [Export ("insertSubnode:belowSubnode:")]
        void InsertSubnode (ASDisplayNode subnode, ASDisplayNode below);

        // -(void)insertSubnode:(ASDisplayNode * _Nonnull)subnode aboveSubnode:(ASDisplayNode * _Nonnull)above;
        [Export ("insertSubnode:aboveSubnode:")]
        void InsertSubnodeAboveSubnode (ASDisplayNode subnode, ASDisplayNode above);

        // -(void)insertSubnode:(ASDisplayNode * _Nonnull)subnode atIndex:(NSInteger)idx;
        [Export ("insertSubnode:atIndex:")]
        void InsertSubnodeAtIndex (ASDisplayNode subnode, nint idx);

        // -(void)replaceSubnode:(ASDisplayNode * _Nonnull)subnode withSubnode:(ASDisplayNode * _Nonnull)replacementSubnode;
        [Export ("replaceSubnode:withSubnode:")]
        void ReplaceSubnode (ASDisplayNode subnode, ASDisplayNode replacementSubnode);

        // -(void)removeFromSupernode;
        [Export ("removeFromSupernode")]
        void RemoveFromSupernode ();

        // @property (readonly, copy, nonatomic) NSArray<ASDisplayNode *> * _Nonnull subnodes;
        [Export ("subnodes", ArgumentSemantic.Copy)]
        ASDisplayNode[] Subnodes { get; }

        // @property (readonly, nonatomic, weak) ASDisplayNode * _Nullable supernode;
        [NullAllowed, Export ("supernode", ArgumentSemantic.Weak)]
        ASDisplayNode Supernode { get; }

        // @property (assign, nonatomic) BOOL displaysAsynchronously;
        [Export ("displaysAsynchronously")]
        bool DisplaysAsynchronously { get; set; }

        // @property (assign, nonatomic) BOOL displaySuspended;
        [Export ("displaySuspended")]
        bool DisplaySuspended { get; set; }

        // @property (assign, nonatomic) BOOL shouldAnimateSizeChanges;
        [Export ("shouldAnimateSizeChanges")]
        bool ShouldAnimateSizeChanges { get; set; }

        // -(void)recursivelySetDisplaySuspended:(BOOL)flag;
        [Export ("recursivelySetDisplaySuspended:")]
        void RecursivelySetDisplaySuspended (bool flag);

        // -(void)recursivelyClearContents;
        [Export ("recursivelyClearContents")]
        void RecursivelyClearContents ();

        // @property (assign, nonatomic) BOOL placeholderEnabled;
        [Export ("placeholderEnabled")]
        bool PlaceholderEnabled { get; set; }

        // @property (assign, nonatomic) NSTimeInterval placeholderFadeDuration;
        [Export ("placeholderFadeDuration")]
        double PlaceholderFadeDuration { get; set; }

        // @property (assign, atomic) NSInteger drawingPriority;
        [Export ("drawingPriority")]
        nint DrawingPriority { get; set; }

        // @property (assign, nonatomic) UIEdgeInsets hitTestSlop;
        [Export ("hitTestSlop", ArgumentSemantic.Assign)]
        UIEdgeInsets HitTestSlop { get; set; }

        // -(BOOL)pointInside:(CGPoint)point withEvent:(UIEvent * _Nullable)event __attribute__((warn_unused_result));
        [Export ("pointInside:withEvent:")]
        bool PointInside (CGPoint point, [NullAllowed] UIEvent @event);

        // -(CGPoint)convertPoint:(CGPoint)point toNode:(ASDisplayNode * _Nullable)node __attribute__((warn_unused_result));
        [Export ("convertPoint:toNode:")]
        CGPoint ConvertPointToNode (CGPoint point, [NullAllowed] ASDisplayNode node);

        // -(CGPoint)convertPoint:(CGPoint)point fromNode:(ASDisplayNode * _Nullable)node __attribute__((warn_unused_result));
        [Export ("convertPoint:fromNode:")]
        CGPoint ConvertPointFromNode (CGPoint point, [NullAllowed] ASDisplayNode node);

        // -(CGRect)convertRect:(CGRect)rect toNode:(ASDisplayNode * _Nullable)node __attribute__((warn_unused_result));
        [Export ("convertRect:toNode:")]
        CGRect ConvertRectToNode (CGRect rect, [NullAllowed] ASDisplayNode node);

        // -(CGRect)convertRect:(CGRect)rect fromNode:(ASDisplayNode * _Nullable)node __attribute__((warn_unused_result));
        [Export ("convertRect:fromNode:")]
        CGRect ConvertRectFromNode (CGRect rect, [NullAllowed] ASDisplayNode node);

        // @property (readonly, nonatomic) BOOL supportsLayerBacking;
        [Export ("supportsLayerBacking")]
        bool SupportsLayerBacking { get; }
    }

    //// @interface Debugging (ASDisplayNode) <ASDebugNameProvider>
    //[Category]
    //[BaseType (typeof(ASDisplayNode))]
    //interface ASDisplayNode_Debugging : IASDebugNameProvider
    //{
    //    // +(BOOL)shouldStoreUnflattenedLayouts;
    //    // +(void)setShouldStoreUnflattenedLayouts:(BOOL)shouldStore;
    //    [Static]
    //    [Export ("shouldStoreUnflattenedLayouts")]
    //    [Verify (MethodToProperty)]
    //    bool ShouldStoreUnflattenedLayouts { get; set; }

    //    // @property (readonly, nonatomic, strong) ASLayout * _Nullable unflattenedCalculatedLayout;
    //    [NullAllowed, Export ("unflattenedCalculatedLayout", ArgumentSemantic.Strong)]
    //    ASLayout UnflattenedCalculatedLayout { get; }

    //    // -(NSString * _Nonnull)displayNodeRecursiveDescription __attribute__((warn_unused_result));
    //    [Export ("displayNodeRecursiveDescription")]
    //    [Verify (MethodToProperty)]
    //    string DisplayNodeRecursiveDescription { get; }

    //    // @property (readonly, copy, atomic) NSString * _Nonnull detailedLayoutDescription;
    //    [Export ("detailedLayoutDescription")]
    //    string DetailedLayoutDescription { get; }
    //}

    // @interface UIViewBridge (ASDisplayNode)
    //[Category()]
    //[BaseType (typeof(ASDisplayNode))]
    partial interface ASDisplayNode
    {
        // -(void)setNeedsDisplay;
        [Export ("setNeedsDisplay")]
        void SetNeedsDisplay ();

        // -(void)setNeedsLayout;
        [Export ("setNeedsLayout")]
        void SetNeedsLayout ();

        // -(void)layoutIfNeeded;
        [Export ("layoutIfNeeded")]
        void LayoutIfNeeded ();

        // @property (assign, nonatomic) CGRect frame;
        [Export ("frame", ArgumentSemantic.Assign)]
        CGRect Frame { get; set; }

        // @property (assign, nonatomic) CGRect bounds;
        [Export ("bounds", ArgumentSemantic.Assign)]
        CGRect Bounds { get; set; }

        // @property (assign, nonatomic) CGPoint position;
        [Export ("position", ArgumentSemantic.Assign)]
        CGPoint Position { get; set; }

        // @property (assign, nonatomic) CGFloat alpha;
        [Export ("alpha")]
        nfloat Alpha { get; set; }

        // @property (assign, nonatomic) ASCornerRoundingType cornerRoundingType;
        [Export ("cornerRoundingType", ArgumentSemantic.Assign)]
        ASCornerRoundingType CornerRoundingType { get; set; }

        // @property (assign, nonatomic) CGFloat cornerRadius;
        [Export ("cornerRadius")]
        nfloat CornerRadius { get; set; }

        // @property (assign, nonatomic) BOOL clipsToBounds;
        [Export ("clipsToBounds")]
        bool ClipsToBounds { get; set; }

        // @property (getter = isHidden, nonatomic) BOOL hidden;
        [Export ("hidden")]
        bool Hidden { [Bind ("isHidden")] get; set; }

        // @property (getter = isOpaque, nonatomic) BOOL opaque;
        [Export ("opaque")]
        bool Opaque { [Bind ("isOpaque")] get; set; }

        // @property (nonatomic, strong) id _Nullable contents;
        [NullAllowed, Export ("contents", ArgumentSemantic.Strong)]
        NSObject Contents { get; set; }

        // @property (assign, nonatomic) CGRect contentsRect;
        [Export ("contentsRect", ArgumentSemantic.Assign)]
        CGRect ContentsRect { get; set; }

        // @property (assign, nonatomic) CGRect contentsCenter;
        [Export ("contentsCenter", ArgumentSemantic.Assign)]
        CGRect ContentsCenter { get; set; }

        // @property (assign, nonatomic) CGFloat contentsScale;
        [Export ("contentsScale")]
        nfloat ContentsScale { get; set; }

        // @property (assign, nonatomic) CGFloat rasterizationScale;
        [Export ("rasterizationScale")]
        nfloat RasterizationScale { get; set; }

        // @property (assign, nonatomic) CGPoint anchorPoint;
        [Export ("anchorPoint", ArgumentSemantic.Assign)]
        CGPoint AnchorPoint { get; set; }

        // @property (assign, nonatomic) CGFloat zPosition;
        [Export ("zPosition")]
        nfloat ZPosition { get; set; }

        // @property (assign, nonatomic) CATransform3D transform;
        [Export ("transform", ArgumentSemantic.Assign)]
        CATransform3D Transform { get; set; }

        // @property (assign, nonatomic) CATransform3D subnodeTransform;
        [Export ("subnodeTransform", ArgumentSemantic.Assign)]
        CATransform3D SubnodeTransform { get; set; }

        // @property (getter = isUserInteractionEnabled, assign, nonatomic) BOOL userInteractionEnabled;
        [Export ("userInteractionEnabled")]
        bool UserInteractionEnabled { [Bind ("isUserInteractionEnabled")] get; set; }

        // @property (getter = isExclusiveTouch, assign, nonatomic) BOOL exclusiveTouch;
        [Export ("exclusiveTouch")]
        bool ExclusiveTouch { [Bind ("isExclusiveTouch")] get; set; }

        // @property (nonatomic, strong) UIColor * _Nullable backgroundColor;
        [NullAllowed, Export ("backgroundColor", ArgumentSemantic.Strong)]
        UIColor BackgroundColor { get; set; }

        // @property (nonatomic, strong) UIColor * _Null_unspecified tintColor;
        [Export ("tintColor", ArgumentSemantic.Strong)]
        UIColor TintColor { get; set; }

        // -(void)tintColorDidChange;
        [Export ("tintColorDidChange")]
        void TintColorDidChange ();

        // @property (assign, nonatomic) UIViewContentMode contentMode;
        [Export ("contentMode", ArgumentSemantic.Assign)]
        UIViewContentMode ContentMode { get; set; }

        // @property (copy, nonatomic) NSString * _Nonnull contentsGravity;
        [Export ("contentsGravity")]
        string ContentsGravity { get; set; }

        // @property (assign, nonatomic) UISemanticContentAttribute semanticContentAttribute;
        [Export ("semanticContentAttribute", ArgumentSemantic.Assign)]
        UISemanticContentAttribute SemanticContentAttribute { get; set; }

        //// @property (nonatomic) CGColorRef _Nullable shadowColor;
        //[NullAllowed, Export ("shadowColor", ArgumentSemantic.Assign)]
        //unsafe CGColorRef* ShadowColor { get; set; }

        // @property (assign, nonatomic) CGFloat shadowOpacity;
        [Export ("shadowOpacity")]
        nfloat ShadowOpacity { get; set; }

        // @property (assign, nonatomic) CGSize shadowOffset;
        [Export ("shadowOffset", ArgumentSemantic.Assign)]
        CGSize ShadowOffset { get; set; }

        // @property (assign, nonatomic) CGFloat shadowRadius;
        [Export ("shadowRadius")]
        nfloat ShadowRadius { get; set; }

        // @property (assign, nonatomic) CGFloat borderWidth;
        [Export ("borderWidth")]
        nfloat BorderWidth { get; set; }

        //// @property (nonatomic) CGColorRef _Nullable borderColor;
        //[NullAllowed, Export ("borderColor", ArgumentSemantic.Assign)]
        //unsafe CGColorRef* BorderColor { get; set; }

        // @property (assign, nonatomic) BOOL allowsGroupOpacity;
        [Export ("allowsGroupOpacity")]
        bool AllowsGroupOpacity { get; set; }

        // @property (assign, nonatomic) BOOL allowsEdgeAntialiasing;
        [Export ("allowsEdgeAntialiasing")]
        bool AllowsEdgeAntialiasing { get; set; }

        // @property (assign, nonatomic) unsigned int edgeAntialiasingMask;
        [Export ("edgeAntialiasingMask")]
        uint EdgeAntialiasingMask { get; set; }

        // @property (assign, nonatomic) BOOL needsDisplayOnBoundsChange;
        [Export ("needsDisplayOnBoundsChange")]
        bool NeedsDisplayOnBoundsChange { get; set; }

        // @property (assign, nonatomic) BOOL autoresizesSubviews;
        [Export ("autoresizesSubviews")]
        bool AutoresizesSubviews { get; set; }

        // @property (assign, nonatomic) UIViewAutoresizing autoresizingMask;
        [Export ("autoresizingMask", ArgumentSemantic.Assign)]
        UIViewAutoresizing AutoresizingMask { get; set; }

        // -(BOOL)canBecomeFirstResponder;
        [Export ("canBecomeFirstResponder")]
        //[Verify (MethodToProperty)]
        bool CanBecomeFirstResponder { get; }

        // -(BOOL)becomeFirstResponder;
        [Export ("becomeFirstResponder")]
        //[Verify (MethodToProperty)]
        bool BecomeFirstResponder { get; }

        // -(BOOL)canResignFirstResponder;
        [Export ("canResignFirstResponder")]
        //[Verify (MethodToProperty)]
        bool CanResignFirstResponder { get; }

        // -(BOOL)resignFirstResponder;
        [Export ("resignFirstResponder")]
        //[Verify (MethodToProperty)]
        bool ResignFirstResponder { get; }

        // -(BOOL)isFirstResponder;
        [Export ("isFirstResponder")]
        //[Verify (MethodToProperty)]
        bool IsFirstResponder { get; }

        // -(BOOL)canPerformAction:(SEL _Nonnull)action withSender:(id _Nonnull)sender;
        [Export ("canPerformAction:withSender:")]
        bool CanPerformAction (Selector action, NSObject sender);
    }

    // @interface UIViewBridgeAccessibility (ASDisplayNode)
    //[Category]
    //[BaseType (typeof(ASDisplayNode))]
    partial interface ASDisplayNode
    {
        // @property (assign, nonatomic) BOOL isAccessibilityElement;
        [Export ("isAccessibilityElement")]
        bool IsAccessibilityElement { get; set; }

        // @property (copy, nonatomic) NSString * _Nullable accessibilityLabel;
        [NullAllowed, Export ("accessibilityLabel")]
        string AccessibilityLabel { get; set; }

        // @property (copy, nonatomic) NSAttributedString * _Nullable accessibilityAttributedLabel __attribute__((availability(tvos, introduced=11.0))) __attribute__((availability(ios, introduced=11.0)));
        //[TV (11, 0), iOS (11, 0)]
        [NullAllowed, Export ("accessibilityAttributedLabel", ArgumentSemantic.Copy)]
        NSAttributedString AccessibilityAttributedLabel { get; set; }

        // @property (copy, nonatomic) NSString * _Nullable accessibilityHint;
        [NullAllowed, Export ("accessibilityHint")]
        string AccessibilityHint { get; set; }

        // @property (copy, nonatomic) NSAttributedString * _Nullable accessibilityAttributedHint __attribute__((availability(tvos, introduced=11.0))) __attribute__((availability(ios, introduced=11.0)));
        //[TV (11, 0), iOS (11, 0)]
        [NullAllowed, Export ("accessibilityAttributedHint", ArgumentSemantic.Copy)]
        NSAttributedString AccessibilityAttributedHint { get; set; }

        // @property (copy, nonatomic) NSString * _Nullable accessibilityValue;
        [NullAllowed, Export ("accessibilityValue")]
        string AccessibilityValue { get; set; }

        // @property (copy, nonatomic) NSAttributedString * _Nullable accessibilityAttributedValue __attribute__((availability(tvos, introduced=11.0))) __attribute__((availability(ios, introduced=11.0)));
        //[TV (11, 0), iOS (11, 0)]
        [NullAllowed, Export ("accessibilityAttributedValue", ArgumentSemantic.Copy)]
        NSAttributedString AccessibilityAttributedValue { get; set; }

        // @property (assign, nonatomic) UIAccessibilityTraits accessibilityTraits;
        [Export ("accessibilityTraits")]
        ulong AccessibilityTraits { get; set; }

        // @property (assign, nonatomic) CGRect accessibilityFrame;
        [Export ("accessibilityFrame", ArgumentSemantic.Assign)]
        CGRect AccessibilityFrame { get; set; }

        // @property (copy, nonatomic) UIBezierPath * _Nullable accessibilityPath;
        [NullAllowed, Export ("accessibilityPath", ArgumentSemantic.Copy)]
        UIBezierPath AccessibilityPath { get; set; }

        // @property (assign, nonatomic) CGPoint accessibilityActivationPoint;
        [Export ("accessibilityActivationPoint", ArgumentSemantic.Assign)]
        CGPoint AccessibilityActivationPoint { get; set; }

        // @property (copy, nonatomic) NSString * _Nullable accessibilityLanguage;
        [NullAllowed, Export ("accessibilityLanguage")]
        string AccessibilityLanguage { get; set; }

        // @property (assign, nonatomic) BOOL accessibilityElementsHidden;
        [Export ("accessibilityElementsHidden")]
        bool AccessibilityElementsHidden { get; set; }

        // @property (assign, nonatomic) BOOL accessibilityViewIsModal;
        [Export ("accessibilityViewIsModal")]
        bool AccessibilityViewIsModal { get; set; }

        // @property (assign, nonatomic) BOOL shouldGroupAccessibilityChildren;
        [Export ("shouldGroupAccessibilityChildren")]
        bool ShouldGroupAccessibilityChildren { get; set; }

        // @property (assign, nonatomic) UIAccessibilityNavigationStyle accessibilityNavigationStyle;
        [Export ("accessibilityNavigationStyle", ArgumentSemantic.Assign)]
        UIAccessibilityNavigationStyle AccessibilityNavigationStyle { get; set; }

        // @property (copy, nonatomic) NSString * _Nullable accessibilityIdentifier;
        [NullAllowed, Export ("accessibilityIdentifier")]
        string AccessibilityIdentifier { get; set; }
    }

    // @interface ASLayoutElement (ASDisplayNode) <ASLayoutElement>
    //[Category]
    //[BaseType (typeof(ASDisplayNode))]
    //partial interface ASDisplayNode
    //{
    //    // -(ASLayout * _Nonnull)layoutThatFits:(ASSizeRange)constrainedSize;
    //    [Export ("layoutThatFits:")]
    //    ASLayout LayoutThatFits (ASSizeRange constrainedSize);
    //}

    // @interface ASLayoutElementStylability (ASDisplayNode) <ASLayoutElementStylability>
    //[Category]
    //[BaseType (typeof(ASDisplayNode))]
    partial interface ASDisplayNode
    {
    }

    // @interface ASLayout (ASDisplayNode)
    //[Category]
    //[BaseType (typeof(ASDisplayNode))]
    partial interface ASDisplayNode
    {
        // @property (readwrite, copy, nonatomic) ASLayoutSpecBlock _Nullable layoutSpecBlock;
        [NullAllowed, Export ("layoutSpecBlock", ArgumentSemantic.Copy)]
        ASLayoutSpecBlock LayoutSpecBlock { get; set; }

        // @property (readonly, assign, nonatomic) CGSize calculatedSize;
        [Export ("calculatedSize", ArgumentSemantic.Assign)]
        CGSize CalculatedSize { get; }

        // @property (readonly, assign, nonatomic) ASSizeRange constrainedSizeForCalculatedLayout;
        [Export ("constrainedSizeForCalculatedLayout", ArgumentSemantic.Assign)]
        ASSizeRange ConstrainedSizeForCalculatedLayout { get; }
    }

    // @interface ASLayoutTransitioning (ASDisplayNode)
    //[Category]
    //[BaseType (typeof(ASDisplayNode))]
    partial interface ASDisplayNode
    {
        // @property (assign, nonatomic) NSTimeInterval defaultLayoutTransitionDuration;
        [Export ("defaultLayoutTransitionDuration")]
        double DefaultLayoutTransitionDuration { get; set; }

        // @property (assign, nonatomic) NSTimeInterval defaultLayoutTransitionDelay;
        [Export ("defaultLayoutTransitionDelay")]
        double DefaultLayoutTransitionDelay { get; set; }

        // @property (assign, nonatomic) UIViewAnimationOptions defaultLayoutTransitionOptions;
        [Export ("defaultLayoutTransitionOptions", ArgumentSemantic.Assign)]
        UIViewAnimationOptions DefaultLayoutTransitionOptions { get; set; }

        // -(void)animateLayoutTransition:(id<ASContextTransitioning> _Nonnull)context;
        [Export ("animateLayoutTransition:")]
        void AnimateLayoutTransition (ASContextTransitioning context);

        // -(void)didCompleteLayoutTransition:(id<ASContextTransitioning> _Nonnull)context;
        [Export ("didCompleteLayoutTransition:")]
        void DidCompleteLayoutTransition (ASContextTransitioning context);

        // -(void)transitionLayoutWithSizeRange:(ASSizeRange)constrainedSize animated:(BOOL)animated shouldMeasureAsync:(BOOL)shouldMeasureAsync measurementCompletion:(void (^ _Nullable)())completion;
        [Export ("transitionLayoutWithSizeRange:animated:shouldMeasureAsync:measurementCompletion:")]
        void TransitionLayoutWithSizeRange (ASSizeRange constrainedSize, bool animated, bool shouldMeasureAsync, [NullAllowed] Action completion);

        // -(void)transitionLayoutWithAnimation:(BOOL)animated shouldMeasureAsync:(BOOL)shouldMeasureAsync measurementCompletion:(void (^ _Nullable)())completion;
        [Export ("transitionLayoutWithAnimation:shouldMeasureAsync:measurementCompletion:")]
        void TransitionLayoutWithAnimation (bool animated, bool shouldMeasureAsync, [NullAllowed] Action completion);

        // -(void)cancelLayoutTransition;
        [Export ("cancelLayoutTransition")]
        void CancelLayoutTransition ();
    }

    // @interface ASAutomaticSubnodeManagement (ASDisplayNode)
    //[Category]
    //[BaseType (typeof(ASDisplayNode))]
    partial interface ASDisplayNode
    {
        // @property (assign, nonatomic) BOOL automaticallyManagesSubnodes;
        [Export ("automaticallyManagesSubnodes")]
        bool AutomaticallyManagesSubnodes { get; set; }
    }

    //// @interface AsyncDisplayKit (UIView)
    //[Category]
    //[BaseType (typeof(UIView))]
    //interface UIView_AsyncDisplayKit
    //{
    //    // -(void)addSubnode:(ASDisplayNode * _Nonnull)node;
    //    [Export ("addSubnode:")]
    //    void AddSubnode (ASDisplayNode node);
    //}

    //// @interface AsyncDisplayKit (CALayer)
    //[Category]
    //[BaseType (typeof(CALayer))]
    //interface CALayer_AsyncDisplayKit
    //{
    //    // -(void)addSubnode:(ASDisplayNode * _Nonnull)node;
    //    [Export ("addSubnode:")]
    //    void AddSubnode (ASDisplayNode node);
    //}

    // @interface Ancestry (ASDisplayNode)
    //[Category]
    //[BaseType (typeof(ASDisplayNode))]
    partial interface ASDisplayNode
    {
        //// @property (readonly, atomic) id<NSFastEnumeration> _Nonnull supernodes;
        //[Export ("supernodes")]
        //NSFastEnumeration Supernodes { get; }

        //// @property (readonly, atomic) id<NSFastEnumeration> _Nonnull supernodesIncludingSelf;
        //[Export ("supernodesIncludingSelf")]
        //NSFastEnumeration SupernodesIncludingSelf { get; }

        // -(__kindof ASDisplayNode * _Nullable)supernodeOfClass:(Class _Nonnull)supernodeClass includingSelf:(BOOL)includeSelf;
        [Export ("supernodeOfClass:includingSelf:")]
        ASDisplayNode SupernodeOfClass (Class supernodeClass, bool includeSelf);

        // @property (readonly, copy, atomic) NSString * _Nonnull ancestryDescription;
        [Export ("ancestryDescription")]
        string AncestryDescription { get; }
    }

    // @interface Convenience (ASDisplayNode)
    //[Category]
    //[BaseType (typeof(ASDisplayNode))]
    partial interface ASDisplayNode
    {
        // @property (readonly, nonatomic) __kindof UIViewController * _Nullable closestViewController;
        [Export ("closestViewController")]
        UIViewController ClosestViewController { get; }
    }

    // @interface ASControlNode : ASDisplayNode
    [BaseType (typeof(ASDisplayNode))]
    partial interface ASControlNode
    {
        // @property (getter = isEnabled, assign, nonatomic) BOOL enabled;
        [Export ("enabled")]
        bool Enabled { [Bind ("isEnabled")] get; set; }

        // @property (getter = isHighlighted, assign, nonatomic) BOOL highlighted;
        [Export ("highlighted")]
        bool Highlighted { [Bind ("isHighlighted")] get; set; }

        // @property (getter = isSelected, assign, nonatomic) BOOL selected;
        [Export ("selected")]
        bool Selected { [Bind ("isSelected")] get; set; }

        // @property (readonly, getter = isTracking, assign, nonatomic) BOOL tracking;
        [Export ("tracking")]
        bool Tracking { [Bind ("isTracking")] get; }

        // @property (readonly, getter = isTouchInside, assign, nonatomic) BOOL touchInside;
        [Export ("touchInside")]
        bool TouchInside { [Bind ("isTouchInside")] get; }

        // -(void)addTarget:(id _Nullable)target action:(SEL _Nonnull)action forControlEvents:(ASControlNodeEvent)controlEvents;
        [Export ("addTarget:action:forControlEvents:")]
        void AddTarget ([NullAllowed] NSObject target, Selector action, ASControlNodeEvent controlEvents);

        // -(NSArray<NSString *> * _Nullable)actionsForTarget:(id _Nonnull)target forControlEvent:(ASControlNodeEvent)controlEvent __attribute__((warn_unused_result));
        [Export ("actionsForTarget:forControlEvent:")]
        [return: NullAllowed]
        string[] ActionsForTarget (NSObject target, ASControlNodeEvent controlEvent);

        // -(NSSet * _Nonnull)allTargets __attribute__((warn_unused_result));
        [Export ("allTargets")]
        //[Verify (MethodToProperty)]
        NSSet AllTargets { get; }

        // -(void)removeTarget:(id _Nullable)target action:(SEL _Nullable)action forControlEvents:(ASControlNodeEvent)controlEvents;
        [Export ("removeTarget:action:forControlEvents:")]
        void RemoveTarget ([NullAllowed] NSObject target, [NullAllowed] Selector action, ASControlNodeEvent controlEvents);

        // -(void)sendActionsForControlEvents:(ASControlNodeEvent)controlEvents withEvent:(UIEvent * _Nullable)event;
        [Export ("sendActionsForControlEvents:withEvent:")]
        void SendActionsForControlEvents (ASControlNodeEvent controlEvents, [NullAllowed] UIEvent @event);
    }

    // typedef UIImage * _Nullable (^asimagenode_modification_block_t)(UIImage * _Nonnull);
    delegate UIImage asimagenode_modification_block_t (UIImage arg0);

    // @interface ASImageNode : ASControlNode
    [BaseType (typeof(ASControlNode))]
    partial interface ASImageNode
    {
        // @property (nonatomic, strong) UIImage * _Nullable image;
        [NullAllowed, Export ("image", ArgumentSemantic.Strong)]
        UIImage Image { get; set; }

        // @property (nonatomic, strong) UIColor * _Nullable placeholderColor;
        [NullAllowed, Export ("placeholderColor", ArgumentSemantic.Strong)]
        UIColor PlaceholderColor { get; set; }

        // @property (getter = isCropEnabled, assign, nonatomic) BOOL cropEnabled;
        [Export ("cropEnabled")]
        bool CropEnabled { [Bind ("isCropEnabled")] get; set; }

        // @property (assign, nonatomic) BOOL forceUpscaling;
        [Export ("forceUpscaling")]
        bool ForceUpscaling { get; set; }

        // @property (assign, nonatomic) CGSize forcedSize;
        [Export ("forcedSize", ArgumentSemantic.Assign)]
        CGSize ForcedSize { get; set; }

        // -(void)setCropEnabled:(BOOL)cropEnabled recropImmediately:(BOOL)recropImmediately inBounds:(CGRect)cropBounds;
        [Export ("setCropEnabled:recropImmediately:inBounds:")]
        void SetCropEnabled (bool cropEnabled, bool recropImmediately, CGRect cropBounds);

        // @property (assign, readwrite, nonatomic) CGRect cropRect;
        [Export ("cropRect", ArgumentSemantic.Assign)]
        CGRect CropRect { get; set; }

        // @property (readwrite, copy, nonatomic) asimagenode_modification_block_t _Nullable imageModificationBlock;
        [NullAllowed, Export ("imageModificationBlock", ArgumentSemantic.Copy)]
        asimagenode_modification_block_t ImageModificationBlock { get; set; }

        // -(void)setNeedsDisplayWithCompletion:(void (^ _Nullable)(BOOL))displayCompletionBlock;
        [Export ("setNeedsDisplayWithCompletion:")]
        void SetNeedsDisplayWithCompletion ([NullAllowed] Action<bool> displayCompletionBlock);
    }

    // @interface AnimatedImage (ASImageNode)
    //[Category]
    //[BaseType (typeof(ASImageNode))]
    partial interface ASImageNode
    {
        // @property (nonatomic, strong) id<ASAnimatedImageProtocol> _Nullable animatedImage;
        [NullAllowed, Export ("animatedImage", ArgumentSemantic.Strong)]
        ASAnimatedImageProtocol AnimatedImage { get; set; }

        // @property (assign, nonatomic) BOOL animatedImagePaused;
        [Export ("animatedImagePaused")]
        bool AnimatedImagePaused { get; set; }

        // @property (nonatomic, strong) NSString * _Nonnull animatedImageRunLoopMode;
        [Export ("animatedImageRunLoopMode", ArgumentSemantic.Strong)]
        string AnimatedImageRunLoopMode { get; set; }

        // -(void)animatedImageSet:(id<ASAnimatedImageProtocol> _Nonnull)newAnimatedImage previousAnimatedImage:(id<ASAnimatedImageProtocol> _Nonnull)previousAnimatedImage;
        [Export ("animatedImageSet:previousAnimatedImage:")]
        void AnimatedImageSet (ASAnimatedImageProtocol newAnimatedImage, ASAnimatedImageProtocol previousAnimatedImage);
    }

    //// @interface Unavailable (ASImageNode)
    //[Category]
    //[BaseType (typeof(ASImageNode))]
    //interface ASImageNode_Unavailable
    //{
    //}

    // @interface ASTextNode : ASControlNode
    [BaseType (typeof(ASControlNode))]
    interface ASTextNode : ASTextNodeDelegate
    {
        // @property (copy, nonatomic) NSAttributedString * _Nullable attributedText;
        [NullAllowed, Export ("attributedText", ArgumentSemantic.Copy)]
        NSAttributedString AttributedText { get; set; }

        // @property (copy, nonatomic) NSAttributedString * _Nullable truncationAttributedText;
        [NullAllowed, Export ("truncationAttributedText", ArgumentSemantic.Copy)]
        NSAttributedString TruncationAttributedText { get; set; }

        // @property (copy, nonatomic) NSAttributedString * _Nullable additionalTruncationMessage;
        [NullAllowed, Export ("additionalTruncationMessage", ArgumentSemantic.Copy)]
        NSAttributedString AdditionalTruncationMessage { get; set; }

        // @property (assign, nonatomic) NSLineBreakMode truncationMode;
        [Export ("truncationMode", ArgumentSemantic.Assign)]
        UILineBreakMode TruncationMode { get; set; }

        // @property (readonly, getter = isTruncated, assign, nonatomic) BOOL truncated;
        [Export ("truncated")]
        bool Truncated { [Bind ("isTruncated")] get; }

        // @property (assign, nonatomic) NSUInteger maximumNumberOfLines;
        [Export ("maximumNumberOfLines")]
        nuint MaximumNumberOfLines { get; set; }

        // @property (readonly, assign, nonatomic) NSUInteger lineCount;
        [Export ("lineCount")]
        nuint LineCount { get; }

        // @property (nonatomic, strong) NSArray<UIBezierPath *> * _Nullable exclusionPaths;
        [NullAllowed, Export ("exclusionPaths", ArgumentSemantic.Strong)]
        UIBezierPath[] ExclusionPaths { get; set; }

        // @property (assign, nonatomic) BOOL placeholderEnabled;
        [Export ("placeholderEnabled")]
        bool PlaceholderEnabled { get; set; }

        // @property (nonatomic, strong) UIColor * _Nullable placeholderColor;
        [NullAllowed, Export ("placeholderColor", ArgumentSemantic.Strong)]
        UIColor PlaceholderColor { get; set; }

        // @property (assign, nonatomic) UIEdgeInsets placeholderInsets;
        [Export ("placeholderInsets", ArgumentSemantic.Assign)]
        UIEdgeInsets PlaceholderInsets { get; set; }

        // @property (readonly, assign, nonatomic) UIEdgeInsets shadowPadding;
        [Export ("shadowPadding", ArgumentSemantic.Assign)]
        UIEdgeInsets ShadowPadding { get; }

        // -(NSArray<NSValue *> * _Nonnull)rectsForTextRange:(NSRange)textRange __attribute__((warn_unused_result));
        [Export ("rectsForTextRange:")]
        NSValue[] RectsForTextRange (NSRange textRange);

        // -(NSArray<NSValue *> * _Nonnull)highlightRectsForTextRange:(NSRange)textRange __attribute__((warn_unused_result));
        [Export ("highlightRectsForTextRange:")]
        NSValue[] HighlightRectsForTextRange (NSRange textRange);

        // -(CGRect)frameForTextRange:(NSRange)textRange __attribute__((warn_unused_result));
        [Export ("frameForTextRange:")]
        CGRect FrameForTextRange (NSRange textRange);

        // -(CGRect)trailingRect __attribute__((warn_unused_result));
        [Export ("trailingRect")]
        //[Verify (MethodToProperty)]
        CGRect TrailingRect { get; }

        // @property (copy, nonatomic) NSArray<NSString *> * _Nonnull linkAttributeNames;
        [Export ("linkAttributeNames", ArgumentSemantic.Copy)]
        string[] LinkAttributeNames { get; set; }

        //// -(id _Nullable)linkAttributeValueAtPoint:(CGPoint)point attributeName:(NSString * _Nullable * _Nullable)attributeNameOut range:(NSRange * _Nullable)rangeOut __attribute__((warn_unused_result));
        //[Export ("linkAttributeValueAtPoint:attributeName:range:")]
        //[return: NullAllowed]
        //unsafe NSObject LinkAttributeValueAtPoint (CGPoint point, [NullAllowed] out string attributeNameOut, [NullAllowed] NSRange* rangeOut);

        // @property (assign, nonatomic) ASTextNodeHighlightStyle highlightStyle;
        [Export ("highlightStyle", ArgumentSemantic.Assign)]
        ASTextNodeHighlightStyle HighlightStyle { get; set; }

        // @property (assign, nonatomic) NSRange highlightRange;
        [Export ("highlightRange", ArgumentSemantic.Assign)]
        NSRange HighlightRange { get; set; }

        // -(void)setHighlightRange:(NSRange)highlightRange animated:(BOOL)animated;
        [Export ("setHighlightRange:animated:")]
        void SetHighlightRange (NSRange highlightRange, bool animated);

        [Wrap ("WeakDelegate")]
        [NullAllowed]
        ASTextNodeDelegate Delegate { get; set; }

        // @property (nonatomic, weak) id<ASTextNodeDelegate> _Nullable delegate;
        [NullAllowed, Export ("delegate", ArgumentSemantic.Weak)]
        NSObject WeakDelegate { get; set; }

        // @property (assign, nonatomic) BOOL longPressCancelsTouches;
        [Export ("longPressCancelsTouches")]
        bool LongPressCancelsTouches { get; set; }

        // @property (assign, nonatomic) BOOL passthroughNonlinkTouches;
        [Export ("passthroughNonlinkTouches")]
        bool PassthroughNonlinkTouches { get; set; }
    }

    // @protocol ASTextNodeDelegate <NSObject>
    [Protocol, Model]
    [BaseType (typeof(NSObject))]
    interface ASTextNodeDelegate
    {
        // @optional -(void)textNode:(ASTextNode * _Nonnull)textNode tappedLinkAttribute:(NSString * _Nonnull)attribute value:(id _Nonnull)value atPoint:(CGPoint)point textRange:(NSRange)textRange;
        [Export ("textNode:tappedLinkAttribute:value:atPoint:textRange:")]
        void TappedLinkAttribute (ASTextNode textNode, string attribute, NSObject value, CGPoint point, NSRange textRange);

        // @optional -(void)textNode:(ASTextNode * _Nonnull)textNode longPressedLinkAttribute:(NSString * _Nonnull)attribute value:(id _Nonnull)value atPoint:(CGPoint)point textRange:(NSRange)textRange;
        [Export ("textNode:longPressedLinkAttribute:value:atPoint:textRange:")]
        void LongPressedLinkAttribute (ASTextNode textNode, string attribute, NSObject value, CGPoint point, NSRange textRange);

        // @optional -(void)textNodeTappedTruncationToken:(ASTextNode * _Nonnull)textNode;
        [Export ("textNodeTappedTruncationToken:")]
        void TextNodeTappedTruncationToken (ASTextNode textNode);

        // @optional -(BOOL)textNode:(ASTextNode * _Nonnull)textNode shouldHighlightLinkAttribute:(NSString * _Nonnull)attribute value:(id _Nonnull)value atPoint:(CGPoint)point;
        [Export ("textNode:shouldHighlightLinkAttribute:value:atPoint:")]
        bool ShouldHighlightLinkAttribute (ASTextNode textNode, string attribute, NSObject value, CGPoint point);

        // @optional -(BOOL)textNode:(ASTextNode * _Nonnull)textNode shouldLongPressLinkAttribute:(NSString * _Nonnull)attribute value:(id _Nonnull)value atPoint:(CGPoint)point;
        [Export ("textNode:shouldLongPressLinkAttribute:value:atPoint:")]
        bool ShouldLongPressLinkAttribute (ASTextNode textNode, string attribute, NSObject value, CGPoint point);
    }

    //// @interface Unavailable (ASTextNode)
    //[Category]
    //[BaseType (typeof(ASTextNode))]
    //interface ASTextNode_Unavailable
    //{
    //}

    //// @interface Deprecated (ASTextNode)
    //[Category]
    //[BaseType (typeof(ASTextNode))]
    //interface ASTextNode_Deprecated
    //{
    //    // @property (copy, nonatomic) NSAttributedString * _Nullable attributedString __attribute__((deprecated("Use .attributedText instead.")));
    //    [NullAllowed, Export ("attributedString", ArgumentSemantic.Copy)]
    //    NSAttributedString AttributedString { get; set; }

    //    // @property (copy, nonatomic) NSAttributedString * _Nullable truncationAttributedString __attribute__((deprecated("Use .truncationAttributedText instead.")));
    //    [NullAllowed, Export ("truncationAttributedString", ArgumentSemantic.Copy)]
    //    NSAttributedString TruncationAttributedString { get; set; }
    //}

    //// @interface ASTextNode2 : ASControlNode
    //[BaseType (typeof(ASControlNode))]
    //interface ASTextNode2
    //{
    //    // @property (copy, nonatomic) NSAttributedString * _Nullable attributedText;
    //    [NullAllowed, Export ("attributedText", ArgumentSemantic.Copy)]
    //    NSAttributedString AttributedText { get; set; }

    //    // @property (copy, nonatomic) NSAttributedString * _Nullable truncationAttributedText;
    //    [NullAllowed, Export ("truncationAttributedText", ArgumentSemantic.Copy)]
    //    NSAttributedString TruncationAttributedText { get; set; }

    //    // @property (copy, nonatomic) NSAttributedString * _Nullable additionalTruncationMessage;
    //    [NullAllowed, Export ("additionalTruncationMessage", ArgumentSemantic.Copy)]
    //    NSAttributedString AdditionalTruncationMessage { get; set; }

    //    // @property (assign, nonatomic) NSLineBreakMode truncationMode;
    //    [Export ("truncationMode", ArgumentSemantic.Assign)]
    //    NSLineBreakMode TruncationMode { get; set; }

    //    // @property (readonly, getter = isTruncated, assign, nonatomic) BOOL truncated;
    //    [Export ("truncated")]
    //    bool Truncated { [Bind ("isTruncated")] get; }

    //    // @property (assign, nonatomic) NSUInteger maximumNumberOfLines;
    //    [Export ("maximumNumberOfLines")]
    //    nuint MaximumNumberOfLines { get; set; }

    //    // @property (readonly, assign, nonatomic) NSUInteger lineCount;
    //    [Export ("lineCount")]
    //    nuint LineCount { get; }

    //    // @property (nonatomic, strong) NSArray<UIBezierPath *> * _Nullable exclusionPaths;
    //    [NullAllowed, Export ("exclusionPaths", ArgumentSemantic.Strong)]
    //    UIBezierPath[] ExclusionPaths { get; set; }

    //    // @property (assign, nonatomic) BOOL placeholderEnabled;
    //    [Export ("placeholderEnabled")]
    //    bool PlaceholderEnabled { get; set; }

    //    // @property (nonatomic, strong) UIColor * _Nullable placeholderColor;
    //    [NullAllowed, Export ("placeholderColor", ArgumentSemantic.Strong)]
    //    UIColor PlaceholderColor { get; set; }

    //    // @property (assign, nonatomic) UIEdgeInsets placeholderInsets;
    //    [Export ("placeholderInsets", ArgumentSemantic.Assign)]
    //    UIEdgeInsets PlaceholderInsets { get; set; }

    //    // @property (readonly, assign, nonatomic) UIEdgeInsets shadowPadding;
    //    [Export ("shadowPadding", ArgumentSemantic.Assign)]
    //    UIEdgeInsets ShadowPadding { get; }

    //    // -(NSArray<NSValue *> * _Nonnull)rectsForTextRange:(NSRange)textRange __attribute__((warn_unused_result));
    //    [Export ("rectsForTextRange:")]
    //    NSValue[] RectsForTextRange (NSRange textRange);

    //    // -(NSArray<NSValue *> * _Nonnull)highlightRectsForTextRange:(NSRange)textRange __attribute__((warn_unused_result));
    //    [Export ("highlightRectsForTextRange:")]
    //    NSValue[] HighlightRectsForTextRange (NSRange textRange);

    //    // -(CGRect)frameForTextRange:(NSRange)textRange __attribute__((warn_unused_result));
    //    [Export ("frameForTextRange:")]
    //    CGRect FrameForTextRange (NSRange textRange);

    //    // -(CGRect)trailingRect __attribute__((warn_unused_result));
    //    [Export ("trailingRect")]
    //    [Verify (MethodToProperty)]
    //    CGRect TrailingRect { get; }

    //    // @property (copy, nonatomic) NSArray<NSString *> * _Nonnull linkAttributeNames;
    //    [Export ("linkAttributeNames", ArgumentSemantic.Copy)]
    //    string[] LinkAttributeNames { get; set; }

    //    // -(id _Nullable)linkAttributeValueAtPoint:(CGPoint)point attributeName:(NSString * _Nullable * _Nullable)attributeNameOut range:(NSRange * _Nullable)rangeOut __attribute__((warn_unused_result));
    //    [Export ("linkAttributeValueAtPoint:attributeName:range:")]
    //    [return: NullAllowed]
    //    unsafe NSObject LinkAttributeValueAtPoint (CGPoint point, [NullAllowed] out string attributeNameOut, [NullAllowed] NSRange* rangeOut);

    //    // @property (assign, nonatomic) ASTextNodeHighlightStyle highlightStyle;
    //    [Export ("highlightStyle", ArgumentSemantic.Assign)]
    //    ASTextNodeHighlightStyle HighlightStyle { get; set; }

    //    // @property (assign, nonatomic) NSRange highlightRange;
    //    [Export ("highlightRange", ArgumentSemantic.Assign)]
    //    NSRange HighlightRange { get; set; }

    //    // -(void)setHighlightRange:(NSRange)highlightRange animated:(BOOL)animated;
    //    [Export ("setHighlightRange:animated:")]
    //    void SetHighlightRange (NSRange highlightRange, bool animated);

    //    [Wrap ("WeakDelegate")]
    //    [NullAllowed]
    //    ASTextNodeDelegate Delegate { get; set; }

    //    // @property (nonatomic, weak) id<ASTextNodeDelegate> _Nullable delegate;
    //    [NullAllowed, Export ("delegate", ArgumentSemantic.Weak)]
    //    NSObject WeakDelegate { get; set; }

    //    // @property (assign, nonatomic) BOOL longPressCancelsTouches;
    //    [Export ("longPressCancelsTouches")]
    //    bool LongPressCancelsTouches { get; set; }

    //    // @property (assign, nonatomic) BOOL passthroughNonlinkTouches;
    //    [Export ("passthroughNonlinkTouches")]
    //    bool PassthroughNonlinkTouches { get; set; }

    //    // +(void)enableDebugging;
    //    [Static]
    //    [Export ("enableDebugging")]
    //    void EnableDebugging ();
    //}

    //// @interface Unavailable (ASTextNode2)
    //[Category]
    //[BaseType (typeof(ASTextNode2))]
    //interface ASTextNode2_Unavailable
    //{
    //}

    // @interface ASButtonNode : ASControlNode
    [BaseType (typeof(ASControlNode))]
    interface ASButtonNode
    {
        // @property (readonly, nonatomic) ASTextNode * _Nonnull titleNode;
        [Export ("titleNode")]
        ASTextNode TitleNode { get; }

        // @property (readonly, nonatomic) ASImageNode * _Nonnull imageNode;
        [Export ("imageNode")]
        ASImageNode ImageNode { get; }

        // @property (readonly, nonatomic) ASImageNode * _Nonnull backgroundImageNode;
        [Export ("backgroundImageNode")]
        ASImageNode BackgroundImageNode { get; }

        // @property (assign, nonatomic) CGFloat contentSpacing;
        [Export ("contentSpacing")]
        nfloat ContentSpacing { get; set; }

        // @property (assign, nonatomic) BOOL laysOutHorizontally;
        [Export ("laysOutHorizontally")]
        bool LaysOutHorizontally { get; set; }

        // @property (assign, nonatomic) ASHorizontalAlignment contentHorizontalAlignment;
        [Export ("contentHorizontalAlignment", ArgumentSemantic.Assign)]
        ASHorizontalAlignment ContentHorizontalAlignment { get; set; }

        // @property (assign, nonatomic) ASVerticalAlignment contentVerticalAlignment;
        [Export ("contentVerticalAlignment", ArgumentSemantic.Assign)]
        ASVerticalAlignment ContentVerticalAlignment { get; set; }

        // @property (assign, nonatomic) UIEdgeInsets contentEdgeInsets;
        [Export ("contentEdgeInsets", ArgumentSemantic.Assign)]
        UIEdgeInsets ContentEdgeInsets { get; set; }

        // @property (assign, nonatomic) ASButtonNodeImageAlignment imageAlignment;
        [Export ("imageAlignment", ArgumentSemantic.Assign)]
        ASButtonNodeImageAlignment ImageAlignment { get; set; }

        // -(NSAttributedString * _Nullable)attributedTitleForState:(UIControlState)state __attribute__((warn_unused_result));
        [Export ("attributedTitleForState:")]
        [return: NullAllowed]
        NSAttributedString AttributedTitleForState (UIControlState state);

        // -(void)setAttributedTitle:(NSAttributedString * _Nullable)title forState:(UIControlState)state;
        [Export ("setAttributedTitle:forState:")]
        void SetAttributedTitle ([NullAllowed] NSAttributedString title, UIControlState state);

        // -(void)setTitle:(NSString * _Nonnull)title withFont:(UIFont * _Nullable)font withColor:(UIColor * _Nullable)color forState:(UIControlState)state;
        [Export ("setTitle:withFont:withColor:forState:")]
        void SetTitle (string title, [NullAllowed] UIFont font, [NullAllowed] UIColor color, UIControlState state);

        // -(UIImage * _Nullable)imageForState:(UIControlState)state __attribute__((warn_unused_result));
        [Export ("imageForState:")]
        [return: NullAllowed]
        UIImage ImageForState (UIControlState state);

        // -(void)setImage:(UIImage * _Nullable)image forState:(UIControlState)state;
        [Export ("setImage:forState:")]
        void SetImage ([NullAllowed] UIImage image, UIControlState state);

        // -(void)setBackgroundImage:(UIImage * _Nullable)image forState:(UIControlState)state;
        [Export ("setBackgroundImage:forState:")]
        void SetBackgroundImage ([NullAllowed] UIImage image, UIControlState state);

        // -(UIImage * _Nullable)backgroundImageForState:(UIControlState)state __attribute__((warn_unused_result));
        [Export ("backgroundImageForState:")]
        [return: NullAllowed]
        UIImage BackgroundImageForState (UIControlState state);
    }

    //// @interface ASMapNode : ASImageNode
    //[BaseType (typeof(ASImageNode))]
    //interface ASMapNode
    //{
    //    // @property (nonatomic, strong) MKMapSnapshotOptions * _Nonnull options;
    //    [Export ("options", ArgumentSemantic.Strong)]
    //    MKMapSnapshotOptions Options { get; set; }

    //    // @property (assign, nonatomic) MKCoordinateRegion region;
    //    [Export ("region", ArgumentSemantic.Assign)]
    //    MKCoordinateRegion Region { get; set; }

    //    // @property (readonly, nonatomic) MKMapView * _Nullable mapView;
    //    [NullAllowed, Export ("mapView")]
    //    MKMapView MapView { get; }

    //    // @property (getter = isLiveMap, assign, nonatomic) BOOL liveMap;
    //    [Export ("liveMap")]
    //    bool LiveMap { [Bind ("isLiveMap")] get; set; }

    //    // @property (assign, nonatomic) BOOL needsMapReloadOnBoundsChange;
    //    [Export ("needsMapReloadOnBoundsChange")]
    //    bool NeedsMapReloadOnBoundsChange { get; set; }

    //    [Wrap ("WeakMapDelegate")]
    //    [NullAllowed]
    //    MKMapViewDelegate MapDelegate { get; set; }

    //    // @property (nonatomic, weak) id<MKMapViewDelegate> _Nullable mapDelegate;
    //    [NullAllowed, Export ("mapDelegate", ArgumentSemantic.Weak)]
    //    NSObject WeakMapDelegate { get; set; }

    //    // @property (copy, nonatomic) NSArray<id<MKAnnotation>> * _Nonnull annotations;
    //    [Export ("annotations", ArgumentSemantic.Copy)]
    //    MKAnnotation[] Annotations { get; set; }

    //    // @property (assign, nonatomic) ASMapNodeShowAnnotationsOptions showAnnotationsOptions;
    //    [Export ("showAnnotationsOptions", ArgumentSemantic.Assign)]
    //    ASMapNodeShowAnnotationsOptions ShowAnnotationsOptions { get; set; }

    //    // @property (copy, nonatomic) UIImage * _Nullable (^ _Nullable)(id<MKAnnotation> _Nonnull, CGPoint * _Nonnull) imageForStaticMapAnnotationBlock;
    //    [NullAllowed, Export ("imageForStaticMapAnnotationBlock", ArgumentSemantic.Copy)]
    //    unsafe Func<MKAnnotation, CoreGraphics.CGPoint*, UIImage> ImageForStaticMapAnnotationBlock { get; set; }
    //}

    // @interface ASNetworkImageNode : ASImageNode
    [BaseType (typeof(ASImageNode))]
    interface ASNetworkImageNode
    {
        // -(instancetype _Nonnull)initWithCache:(id<ASImageCacheProtocol> _Nullable)cache downloader:(id<ASImageDownloaderProtocol> _Nonnull)downloader __attribute__((objc_designated_initializer));
        [Export ("initWithCache:downloader:")]
        [DesignatedInitializer]
        IntPtr Constructor ([NullAllowed] ASImageCacheProtocol cache, ASImageDownloaderProtocol downloader);

        [Wrap ("WeakDelegate")]
        [NullAllowed]
        ASNetworkImageNodeDelegate Delegate { get; set; }

        // @property (readwrite, nonatomic, weak) id<ASNetworkImageNodeDelegate> _Nullable delegate;
        [NullAllowed, Export ("delegate", ArgumentSemantic.Weak)]
        NSObject WeakDelegate { get; set; }

        // @property (nonatomic, strong) UIImage * _Nullable image;
        [NullAllowed, Export ("image", ArgumentSemantic.Strong)]
        UIImage Image { get; set; }

        // @property (readwrite, nonatomic, strong) UIImage * _Nullable defaultImage;
        [NullAllowed, Export ("defaultImage", ArgumentSemantic.Strong)]
        UIImage DefaultImage { get; set; }

        // @property (readwrite, nonatomic, strong) NSURL * _Nullable URL;
        [NullAllowed, Export ("URL", ArgumentSemantic.Strong)]
        NSUrl URL { get; set; }

        // @property (readwrite, nonatomic, strong) NSArray<NSURL *> * _Nullable URLs;
        [NullAllowed, Export ("URLs", ArgumentSemantic.Strong)]
        NSUrl[] URLs { get; set; }

        // -(void)setURL:(NSURL * _Nullable)URL resetToDefault:(BOOL)reset;
        [Export ("setURL:resetToDefault:")]
        void SetURL ([NullAllowed] NSUrl URL, bool reset);

        // @property (assign, readwrite, nonatomic) BOOL shouldCacheImage;
        [Export ("shouldCacheImage")]
        bool ShouldCacheImage { get; set; }

        // @property (assign, readwrite, nonatomic) BOOL shouldRenderProgressImages;
        [Export ("shouldRenderProgressImages")]
        bool ShouldRenderProgressImages { get; set; }

        // @property (readonly, assign, nonatomic) CGFloat currentImageQuality;
        [Export ("currentImageQuality")]
        nfloat CurrentImageQuality { get; }

        // @property (readonly, assign, nonatomic) CGFloat renderedImageQuality;
        [Export ("renderedImageQuality")]
        nfloat RenderedImageQuality { get; }
    }

    // @protocol ASNetworkImageNodeDelegate <NSObject>
    [Protocol, Model]
    [BaseType (typeof(NSObject))]
    interface ASNetworkImageNodeDelegate
    {
        // @optional -(void)imageNode:(ASNetworkImageNode * _Nonnull)imageNode didLoadImage:(UIImage * _Nonnull)image;
        [Export ("imageNode:didLoadImage:")]
        void ImageNode (ASNetworkImageNode imageNode, UIImage image);

        // @optional -(void)imageNodeDidStartFetchingData:(ASNetworkImageNode * _Nonnull)imageNode;
        [Export ("imageNodeDidStartFetchingData:")]
        void ImageNodeDidStartFetchingData (ASNetworkImageNode imageNode);

        // @optional -(void)imageNode:(ASNetworkImageNode * _Nonnull)imageNode didFailWithError:(NSError * _Nonnull)error;
        [Export ("imageNode:didFailWithError:")]
        void ImageNode (ASNetworkImageNode imageNode, NSError error);

        // @optional -(void)imageNodeDidFinishDecoding:(ASNetworkImageNode * _Nonnull)imageNode;
        [Export ("imageNodeDidFinishDecoding:")]
        void ImageNodeDidFinishDecoding (ASNetworkImageNode imageNode);
    }

    //// @interface ASVideoNode : ASNetworkImageNode
    //[BaseType (typeof(ASNetworkImageNode))]
    //interface ASVideoNode
    //{
    //    // -(void)play;
    //    [Export ("play")]
    //    void Play ();

    //    // -(void)pause;
    //    [Export ("pause")]
    //    void Pause ();

    //    // -(BOOL)isPlaying;
    //    [Export ("isPlaying")]
    //    [Verify (MethodToProperty)]
    //    bool IsPlaying { get; }

    //    // -(void)resetToPlaceholder;
    //    [Export ("resetToPlaceholder")]
    //    void ResetToPlaceholder ();

    //    // @property (readwrite, nonatomic, strong) AVAsset * _Nullable asset;
    //    [NullAllowed, Export ("asset", ArgumentSemantic.Strong)]
    //    AVAsset Asset { get; set; }

    //    // @property (readwrite, nonatomic, strong) NSURL * _Nullable assetURL;
    //    [NullAllowed, Export ("assetURL", ArgumentSemantic.Strong)]
    //    NSUrl AssetURL { get; set; }

    //    // @property (readwrite, nonatomic, strong) AVVideoComposition * _Nullable videoComposition;
    //    [NullAllowed, Export ("videoComposition", ArgumentSemantic.Strong)]
    //    AVVideoComposition VideoComposition { get; set; }

    //    // @property (readwrite, nonatomic, strong) AVAudioMix * _Nullable audioMix;
    //    [NullAllowed, Export ("audioMix", ArgumentSemantic.Strong)]
    //    AVAudioMix AudioMix { get; set; }

    //    // @property (readonly, nonatomic, strong) AVPlayer * _Nullable player;
    //    [NullAllowed, Export ("player", ArgumentSemantic.Strong)]
    //    AVPlayer Player { get; }

    //    // @property (readonly, nonatomic, strong) AVPlayerLayer * _Nullable playerLayer;
    //    [NullAllowed, Export ("playerLayer", ArgumentSemantic.Strong)]
    //    AVPlayerLayer PlayerLayer { get; }

    //    // @property (readonly, nonatomic, strong) AVPlayerItem * _Nullable currentItem;
    //    [NullAllowed, Export ("currentItem", ArgumentSemantic.Strong)]
    //    AVPlayerItem CurrentItem { get; }

    //    // @property (assign, readwrite, nonatomic) BOOL shouldAutoplay;
    //    [Export ("shouldAutoplay")]
    //    bool ShouldAutoplay { get; set; }

    //    // @property (assign, readwrite, nonatomic) BOOL shouldAutorepeat;
    //    [Export ("shouldAutorepeat")]
    //    bool ShouldAutorepeat { get; set; }

    //    // @property (assign, readwrite, nonatomic) BOOL muted;
    //    [Export ("muted")]
    //    bool Muted { get; set; }

    //    // @property (assign, readwrite, nonatomic) BOOL shouldAggressivelyRecoverFromStall;
    //    [Export ("shouldAggressivelyRecoverFromStall")]
    //    bool ShouldAggressivelyRecoverFromStall { get; set; }

    //    // @property (readonly, assign, nonatomic) ASVideoNodePlayerState playerState;
    //    [Export ("playerState", ArgumentSemantic.Assign)]
    //    ASVideoNodePlayerState PlayerState { get; }

    //    // @property (assign, nonatomic) int32_t periodicTimeObserverTimescale;
    //    [Export ("periodicTimeObserverTimescale")]
    //    int PeriodicTimeObserverTimescale { get; set; }

    //    // @property (copy, nonatomic) NSString * _Nonnull gravity;
    //    [Export ("gravity")]
    //    string Gravity { get; set; }

    //    [Wrap ("WeakDelegate")]
    //    [NullAllowed]
    //    NSObject<ASVideoNodeDelegate, ASNetworkImageNodeDelegate> Delegate { get; set; }

    //    // @property (readwrite, nonatomic, weak) id<ASVideoNodeDelegate,ASNetworkImageNodeDelegate> _Nullable delegate;
    //    [NullAllowed, Export ("delegate", ArgumentSemantic.Weak)]
    //    NSObject WeakDelegate { get; set; }
    //}

    //// @protocol ASVideoNodeDelegate <ASNetworkImageNodeDelegate>
    //[Protocol, Model]
    //interface ASVideoNodeDelegate : IASNetworkImageNodeDelegate
    //{
    //    // @optional -(void)videoDidPlayToEnd:(ASVideoNode * _Nonnull)videoNode;
    //    [Export ("videoDidPlayToEnd:")]
    //    void VideoDidPlayToEnd (ASVideoNode videoNode);

    //    // @optional -(void)didTapVideoNode:(ASVideoNode * _Nonnull)videoNode;
    //    [Export ("didTapVideoNode:")]
    //    void DidTapVideoNode (ASVideoNode videoNode);

    //    // @optional -(void)videoNode:(ASVideoNode * _Nonnull)videoNode willChangePlayerState:(ASVideoNodePlayerState)state toState:(ASVideoNodePlayerState)toState;
    //    [Export ("videoNode:willChangePlayerState:toState:")]
    //    void VideoNode (ASVideoNode videoNode, ASVideoNodePlayerState state, ASVideoNodePlayerState toState);

    //    // @optional -(BOOL)videoNode:(ASVideoNode * _Nonnull)videoNode shouldChangePlayerStateTo:(ASVideoNodePlayerState)state;
    //    [Export ("videoNode:shouldChangePlayerStateTo:")]
    //    bool VideoNode (ASVideoNode videoNode, ASVideoNodePlayerState state);

    //    // @optional -(void)videoNode:(ASVideoNode * _Nonnull)videoNode didPlayToTimeInterval:(NSTimeInterval)timeInterval;
    //    [Export ("videoNode:didPlayToTimeInterval:")]
    //    void VideoNode (ASVideoNode videoNode, double timeInterval);

    //    // @optional -(void)videoNode:(ASVideoNode * _Nonnull)videoNode didStallAtTimeInterval:(NSTimeInterval)timeInterval;
    //    [Export ("videoNode:didStallAtTimeInterval:")]
    //    void VideoNode (ASVideoNode videoNode, double timeInterval);

    //    // @optional -(void)videoNodeDidStartInitialLoading:(ASVideoNode * _Nonnull)videoNode;
    //    [Export ("videoNodeDidStartInitialLoading:")]
    //    void VideoNodeDidStartInitialLoading (ASVideoNode videoNode);

    //    // @optional -(void)videoNodeDidFinishInitialLoading:(ASVideoNode * _Nonnull)videoNode;
    //    [Export ("videoNodeDidFinishInitialLoading:")]
    //    void VideoNodeDidFinishInitialLoading (ASVideoNode videoNode);

    //    // @optional -(void)videoNode:(ASVideoNode * _Nonnull)videoNode didSetCurrentItem:(AVPlayerItem * _Nonnull)currentItem;
    //    [Export ("videoNode:didSetCurrentItem:")]
    //    void VideoNode (ASVideoNode videoNode, AVPlayerItem currentItem);

    //    // @optional -(void)videoNodeDidRecoverFromStall:(ASVideoNode * _Nonnull)videoNode;
    //    [Export ("videoNodeDidRecoverFromStall:")]
    //    void VideoNodeDidRecoverFromStall (ASVideoNode videoNode);

    //    // @optional -(void)videoNode:(ASVideoNode * _Nonnull)videoNode didFailToLoadValueForKey:(NSString * _Nonnull)key asset:(AVAsset * _Nonnull)asset error:(NSError * _Nonnull)error;
    //    [Export ("videoNode:didFailToLoadValueForKey:asset:error:")]
    //    void VideoNode (ASVideoNode videoNode, string key, AVAsset asset, NSError error);
    //}

    //// @interface Unavailable (ASVideoNode)
    //[Category]
    //[BaseType (typeof(ASVideoNode))]
    //interface ASVideoNode_Unavailable
    //{
    //}

    // typedef ASCellNode * _Nonnull (^ASCellNodeBlock)();
    delegate ASCellNode ASCellNodeBlock ();

    // typedef BOOL (^asdisplaynode_iscancelled_block_t)();
    delegate bool asdisplaynode_iscancelled_block_t ();

    // @protocol ASInterfaceStateDelegate <NSObject>
    [Protocol, Model]
    [BaseType (typeof(NSObject))]
    interface ASInterfaceStateDelegate
    {
        // @required -(void)interfaceStateDidChange:(ASInterfaceState)newState fromState:(ASInterfaceState)oldState;
        [Abstract]
        [Export ("interfaceStateDidChange:fromState:")]
        void InterfaceStateDidChange (ASInterfaceState newState, ASInterfaceState oldState);

        // @required -(void)didEnterVisibleState;
        [Abstract]
        [Export ("didEnterVisibleState")]
        void DidEnterVisibleState ();

        // @required -(void)didExitVisibleState;
        [Abstract]
        [Export ("didExitVisibleState")]
        void DidExitVisibleState ();

        // @required -(void)didEnterDisplayState;
        [Abstract]
        [Export ("didEnterDisplayState")]
        void DidEnterDisplayState ();

        // @required -(void)didExitDisplayState;
        [Abstract]
        [Export ("didExitDisplayState")]
        void DidExitDisplayState ();

        // @required -(void)didEnterPreloadState;
        [Abstract]
        [Export ("didEnterPreloadState")]
        void DidEnterPreloadState ();

        // @required -(void)didExitPreloadState;
        [Abstract]
        [Export ("didExitPreloadState")]
        void DidExitPreloadState ();

        // @required -(void)nodeDidLayout;
        [Abstract]
        [Export ("nodeDidLayout")]
        void NodeDidLayout ();
    }

    interface IASInterfaceStateDelegate {}

    // @interface Subclassing (ASDisplayNode) <ASInterfaceStateDelegate>
    //[Category]
    //[BaseType (typeof(ASDisplayNode))]
    partial interface ASDisplayNode
    {
        // @property (readonly, nonatomic, strong) ASLayout * _Nullable calculatedLayout;
        [NullAllowed, Export ("calculatedLayout", ArgumentSemantic.Strong)]
        ASLayout CalculatedLayout { get; }

        // -(void)didLoad __attribute__((objc_requires_super));
        [Export ("didLoad")]
        //[RequiresSuper]
        void DidLoad ();

        // -(void)layout __attribute__((objc_requires_super));
        [Export ("layout")]
        //[RequiresSuper]
        void Layout ();

        // -(void)layoutDidFinish __attribute__((objc_requires_super));
        [Export ("layoutDidFinish")]
        //[RequiresSuper]
        void LayoutDidFinish ();

        // -(void)calculatedLayoutDidChange __attribute__((objc_requires_super));
        [Export ("calculatedLayoutDidChange")]
        //[RequiresSuper]
        void CalculatedLayoutDidChange ();

        //// -(ASLayout * _Nonnull)calculateLayoutThatFits:(ASSizeRange)constrainedSize;
        //[Export ("calculateLayoutThatFits:")]
        //ASLayout CalculateLayoutThatFits (ASSizeRange constrainedSize);

        //// -(ASLayout * _Nonnull)calculateLayoutThatFits:(ASSizeRange)constrainedSize restrictedToSize:(ASLayoutElementSize)size relativeToParentSize:(CGSize)parentSize;
        //[Export ("calculateLayoutThatFits:restrictedToSize:relativeToParentSize:")]
        //ASLayout CalculateLayoutThatFits (ASSizeRange constrainedSize, ASLayoutElementSize size, CGSize parentSize);

        // -(CGSize)calculateSizeThatFits:(CGSize)constrainedSize;
        [Export ("calculateSizeThatFits:")]
        CGSize CalculateSizeThatFits (CGSize constrainedSize);

        // -(ASLayoutSpec * _Nonnull)layoutSpecThatFits:(ASSizeRange)constrainedSize;
        [Export ("layoutSpecThatFits:")]
        ASLayoutSpec LayoutSpecThatFits (ASSizeRange constrainedSize);

        // -(void)invalidateCalculatedLayout;
        [Export ("invalidateCalculatedLayout")]
        void InvalidateCalculatedLayout ();

        //// -(void)didEnterVisibleState __attribute__((objc_requires_super));
        //[Export ("didEnterVisibleState")]
        ////[RequiresSuper]
        //void DidEnterVisibleState ();

        //// -(void)didExitVisibleState __attribute__((objc_requires_super));
        //[Export ("didExitVisibleState")]
        ////[RequiresSuper]
        //void DidExitVisibleState ();

        //// -(void)didEnterDisplayState __attribute__((objc_requires_super));
        //[Export ("didEnterDisplayState")]
        ////[RequiresSuper]
        //void DidEnterDisplayState ();

        //// -(void)didExitDisplayState __attribute__((objc_requires_super));
        //[Export ("didExitDisplayState")]
        ////[RequiresSuper]
        //void DidExitDisplayState ();

        //// -(void)didEnterPreloadState __attribute__((objc_requires_super));
        //[Export ("didEnterPreloadState")]
        ////[RequiresSuper]
        //void DidEnterPreloadState ();

        //// -(void)didExitPreloadState __attribute__((objc_requires_super));
        //[Export ("didExitPreloadState")]
        ////[RequiresSuper]
        //void DidExitPreloadState ();

        //// -(void)interfaceStateDidChange:(ASInterfaceState)newState fromState:(ASInterfaceState)oldState __attribute__((objc_requires_super));
        //[Export ("interfaceStateDidChange:fromState:")]
        ////RequiresSuper]
        //void InterfaceStateDidChange (ASInterfaceState newState, ASInterfaceState oldState);

        // -(void)asyncTraitCollectionDidChange;
        [Export ("asyncTraitCollectionDidChange")]
        void AsyncTraitCollectionDidChange ();

        // +(void)drawRect:(CGRect)bounds withParameters:(id _Nullable)parameters isCancelled:(asdisplaynode_iscancelled_block_t _Nonnull)isCancelledBlock isRasterizing:(BOOL)isRasterizing;
        [Static]
        [Export ("drawRect:withParameters:isCancelled:isRasterizing:")]
        void DrawRect (CGRect bounds, [NullAllowed] NSObject parameters, asdisplaynode_iscancelled_block_t isCancelledBlock, bool isRasterizing);

        // +(UIImage * _Nullable)displayWithParameters:(id _Nullable)parameters isCancelled:(asdisplaynode_iscancelled_block_t _Nonnull)isCancelledBlock;
        [Static]
        [Export ("displayWithParameters:isCancelled:")]
        [return: NullAllowed]
        UIImage DisplayWithParameters ([NullAllowed] NSObject parameters, asdisplaynode_iscancelled_block_t isCancelledBlock);

        // -(id<NSObject> _Nullable)drawParametersForAsyncLayer:(_ASDisplayLayer * _Nonnull)layer;
        [Export ("drawParametersForAsyncLayer:")]
        [return: NullAllowed]
        NSObject DrawParametersForAsyncLayer (_ASDisplayLayer layer);

        // -(void)displayWillStart __attribute__((deprecated("Use displayWillStartAsynchronously: instead."))) __attribute__((objc_requires_super));
        [Export ("displayWillStart")]
        //[RequiresSuper]
        void DisplayWillStart ();

        // -(void)displayWillStartAsynchronously:(BOOL)asynchronously __attribute__((objc_requires_super));
        [Export ("displayWillStartAsynchronously:")]
        //[RequiresSuper]
        void DisplayWillStartAsynchronously (bool asynchronously);

        // -(void)displayDidFinish __attribute__((objc_requires_super));
        [Export ("displayDidFinish")]
        //[RequiresSuper]
        void DisplayDidFinish ();

        // -(void)willEnterHierarchy __attribute__((objc_requires_super));
        [Export ("willEnterHierarchy")]
        //[RequiresSuper]
        void WillEnterHierarchy ();

        // -(void)didExitHierarchy __attribute__((objc_requires_super));
        [Export ("didExitHierarchy")]
        //[RequiresSuper]
        void DidExitHierarchy ();

        // @property (readonly, getter = isInHierarchy, assign, nonatomic) BOOL inHierarchy;
        [Export ("inHierarchy")]
        bool InHierarchy { [Bind ("isInHierarchy")] get; }

        // -(void)clearContents __attribute__((objc_requires_super));
        [Export ("clearContents")]
        //[RequiresSuper]
        void ClearContents ();

        // -(void)subnodeDisplayWillStart:(ASDisplayNode * _Nonnull)subnode __attribute__((objc_requires_super));
        [Export ("subnodeDisplayWillStart:")]
        //[RequiresSuper]
        void SubnodeDisplayWillStart (ASDisplayNode subnode);

        // -(void)subnodeDisplayDidFinish:(ASDisplayNode * _Nonnull)subnode __attribute__((objc_requires_super));
        [Export ("subnodeDisplayDidFinish:")]
        //[RequiresSuper]
        void SubnodeDisplayDidFinish (ASDisplayNode subnode);

        // -(void)setNeedsDisplayAtScale:(CGFloat)contentsScale;
        [Export ("setNeedsDisplayAtScale:")]
        void SetNeedsDisplayAtScale (nfloat contentsScale);

        // -(void)recursivelySetNeedsDisplayAtScale:(CGFloat)contentsScale;
        [Export ("recursivelySetNeedsDisplayAtScale:")]
        void RecursivelySetNeedsDisplayAtScale (nfloat contentsScale);

        // @property (readonly, assign, nonatomic) CGFloat contentsScaleForDisplay;
        [Export ("contentsScaleForDisplay")]
        nfloat ContentsScaleForDisplay { get; }

        // -(void)touchesBegan:(NSSet<UITouch *> * _Nonnull)touches withEvent:(UIEvent * _Nullable)event __attribute__((objc_requires_super));
        [Export ("touchesBegan:withEvent:")]
        //[RequiresSuper]
        void TouchesBegan (NSSet<UITouch> touches, [NullAllowed] UIEvent @event);

        // -(void)touchesMoved:(NSSet<UITouch *> * _Nonnull)touches withEvent:(UIEvent * _Nullable)event __attribute__((objc_requires_super));
        [Export ("touchesMoved:withEvent:")]
        //[RequiresSuper]
        void TouchesMoved (NSSet<UITouch> touches, [NullAllowed] UIEvent @event);

        // -(void)touchesEnded:(NSSet<UITouch *> * _Nonnull)touches withEvent:(UIEvent * _Nullable)event __attribute__((objc_requires_super));
        [Export ("touchesEnded:withEvent:")]
        //[RequiresSuper]
        void TouchesEnded (NSSet<UITouch> touches, [NullAllowed] UIEvent @event);

        // -(void)touchesCancelled:(NSSet<UITouch *> * _Nullable)touches withEvent:(UIEvent * _Nullable)event __attribute__((objc_requires_super));
        [Export ("touchesCancelled:withEvent:")]
        //[RequiresSuper]
        void TouchesCancelled ([NullAllowed] NSSet<UITouch> touches, [NullAllowed] UIEvent @event);

        // -(BOOL)gestureRecognizerShouldBegin:(UIGestureRecognizer * _Nonnull)gestureRecognizer;
        [Export ("gestureRecognizerShouldBegin:")]
        bool GestureRecognizerShouldBegin (UIGestureRecognizer gestureRecognizer);

        // -(UIView * _Nullable)hitTest:(CGPoint)point withEvent:(UIEvent * _Nullable)event;
        [Export ("hitTest:withEvent:")]
        [return: NullAllowed]
        UIView HitTest (CGPoint point, [NullAllowed] UIEvent @event);

        // -(UIImage * _Nullable)placeholderImage;
        [NullAllowed, Export ("placeholderImage")]
        //[Verify (MethodToProperty)]
        UIImage PlaceholderImage { get; }

        // -(NSString * _Nonnull)descriptionForRecursiveDescription;
        [Export ("descriptionForRecursiveDescription")]
        //[Verify (MethodToProperty)]
        string DescriptionForRecursiveDescription { get; }
    }

    //// @interface ASVideoPlayerNode : ASDisplayNode
    //[BaseType (typeof(ASDisplayNode))]
    //interface ASVideoPlayerNode
    //{
    //    [Wrap ("WeakDelegate")]
    //    [NullAllowed]
    //    ASVideoPlayerNodeDelegate Delegate { get; set; }

    //    // @property (nonatomic, weak) id<ASVideoPlayerNodeDelegate> _Nullable delegate;
    //    [NullAllowed, Export ("delegate", ArgumentSemantic.Weak)]
    //    NSObject WeakDelegate { get; set; }

    //    // @property (readonly, assign, nonatomic) CMTime duration;
    //    [Export ("duration", ArgumentSemantic.Assign)]
    //    CMTime Duration { get; }

    //    // @property (assign, nonatomic) BOOL controlsDisabled;
    //    [Export ("controlsDisabled")]
    //    bool ControlsDisabled { get; set; }

    //    // @property (assign, readwrite, nonatomic) BOOL shouldAutoPlay;
    //    [Export ("shouldAutoPlay")]
    //    bool ShouldAutoPlay { get; set; }

    //    // @property (assign, readwrite, nonatomic) BOOL shouldAutoRepeat;
    //    [Export ("shouldAutoRepeat")]
    //    bool ShouldAutoRepeat { get; set; }

    //    // @property (assign, readwrite, nonatomic) BOOL muted;
    //    [Export ("muted")]
    //    bool Muted { get; set; }

    //    // @property (readonly, assign, nonatomic) ASVideoNodePlayerState playerState;
    //    [Export ("playerState", ArgumentSemantic.Assign)]
    //    ASVideoNodePlayerState PlayerState { get; }

    //    // @property (assign, readwrite, nonatomic) BOOL shouldAggressivelyRecoverFromStall;
    //    [Export ("shouldAggressivelyRecoverFromStall")]
    //    bool ShouldAggressivelyRecoverFromStall { get; set; }

    //    // @property (readwrite, nonatomic, strong) NSURL * _Nullable placeholderImageURL;
    //    [NullAllowed, Export ("placeholderImageURL", ArgumentSemantic.Strong)]
    //    NSUrl PlaceholderImageURL { get; set; }

    //    // @property (readwrite, nonatomic, strong) AVAsset * _Nullable asset;
    //    [NullAllowed, Export ("asset", ArgumentSemantic.Strong)]
    //    AVAsset Asset { get; set; }

    //    // @property (readwrite, nonatomic, strong) NSURL * _Nullable assetURL;
    //    [NullAllowed, Export ("assetURL", ArgumentSemantic.Strong)]
    //    NSUrl AssetURL { get; set; }

    //    // @property (readonly, nonatomic, strong) ASVideoNode * _Nonnull videoNode;
    //    [Export ("videoNode", ArgumentSemantic.Strong)]
    //    ASVideoNode VideoNode { get; }

    //    // @property (assign, nonatomic) int32_t periodicTimeObserverTimescale;
    //    [Export ("periodicTimeObserverTimescale")]
    //    int PeriodicTimeObserverTimescale { get; set; }

    //    // @property (copy, nonatomic) NSString * _Nonnull gravity;
    //    [Export ("gravity")]
    //    string Gravity { get; set; }

    //    // -(instancetype _Nonnull)initWithURL:(NSURL * _Nonnull)URL;
    //    [Export ("initWithURL:")]
    //    IntPtr Constructor (NSUrl URL);

    //    // -(instancetype _Nonnull)initWithAsset:(AVAsset * _Nonnull)asset;
    //    [Export ("initWithAsset:")]
    //    IntPtr Constructor (AVAsset asset);

    //    // -(instancetype _Nonnull)initWithAsset:(AVAsset * _Nonnull)asset videoComposition:(AVVideoComposition * _Nonnull)videoComposition audioMix:(AVAudioMix * _Nonnull)audioMix;
    //    [Export ("initWithAsset:videoComposition:audioMix:")]
    //    IntPtr Constructor (AVAsset asset, AVVideoComposition videoComposition, AVAudioMix audioMix);

    //    // -(void)seekToTime:(CGFloat)percentComplete;
    //    [Export ("seekToTime:")]
    //    void SeekToTime (nfloat percentComplete);

    //    // -(void)play;
    //    [Export ("play")]
    //    void Play ();

    //    // -(void)pause;
    //    [Export ("pause")]
    //    void Pause ();

    //    // -(BOOL)isPlaying;
    //    [Export ("isPlaying")]
    //    [Verify (MethodToProperty)]
    //    bool IsPlaying { get; }

    //    // -(void)resetToPlaceholder;
    //    [Export ("resetToPlaceholder")]
    //    void ResetToPlaceholder ();
    //}

    //// @protocol ASVideoPlayerNodeDelegate <NSObject>
    //[Protocol, Model]
    //[BaseType (typeof(NSObject))]
    //interface ASVideoPlayerNodeDelegate
    //{
    //    // @optional -(NSArray * _Nonnull)videoPlayerNodeNeededDefaultControls:(ASVideoPlayerNode * _Nonnull)videoPlayer;
    //    [Export ("videoPlayerNodeNeededDefaultControls:")]
    //    [Verify (StronglyTypedNSArray)]
    //    NSObject[] VideoPlayerNodeNeededDefaultControls (ASVideoPlayerNode videoPlayer);

    //    // @optional -(NSDictionary * _Nonnull)videoPlayerNodeCustomControls:(ASVideoPlayerNode * _Nonnull)videoPlayer;
    //    [Export ("videoPlayerNodeCustomControls:")]
    //    NSDictionary VideoPlayerNodeCustomControls (ASVideoPlayerNode videoPlayer);

    //    // @optional -(ASLayoutSpec * _Nonnull)videoPlayerNodeLayoutSpec:(ASVideoPlayerNode * _Nonnull)videoPlayer forControls:(NSDictionary * _Nonnull)controls forMaximumSize:(CGSize)maxSize;
    //    [Export ("videoPlayerNodeLayoutSpec:forControls:forMaximumSize:")]
    //    ASLayoutSpec VideoPlayerNodeLayoutSpec (ASVideoPlayerNode videoPlayer, NSDictionary controls, CGSize maxSize);

    //    // @optional -(NSDictionary * _Nonnull)videoPlayerNodeTimeLabelAttributes:(ASVideoPlayerNode * _Nonnull)videoPlayer timeLabelType:(ASVideoPlayerNodeControlType)timeLabelType;
    //    [Export ("videoPlayerNodeTimeLabelAttributes:timeLabelType:")]
    //    NSDictionary VideoPlayerNodeTimeLabelAttributes (ASVideoPlayerNode videoPlayer, ASVideoPlayerNodeControlType timeLabelType);

    //    // @optional -(NSString * _Nonnull)videoPlayerNode:(ASVideoPlayerNode * _Nonnull)videoPlayerNode timeStringForTimeLabelType:(ASVideoPlayerNodeControlType)timeLabelType forTime:(CMTime)time;
    //    [Export ("videoPlayerNode:timeStringForTimeLabelType:forTime:")]
    //    string VideoPlayerNode (ASVideoPlayerNode videoPlayerNode, ASVideoPlayerNodeControlType timeLabelType, CMTime time);

    //    // @optional -(UIColor * _Nonnull)videoPlayerNodeScrubberMaximumTrackTint:(ASVideoPlayerNode * _Nonnull)videoPlayer;
    //    [Export ("videoPlayerNodeScrubberMaximumTrackTint:")]
    //    UIColor VideoPlayerNodeScrubberMaximumTrackTint (ASVideoPlayerNode videoPlayer);

    //    // @optional -(UIColor * _Nonnull)videoPlayerNodeScrubberMinimumTrackTint:(ASVideoPlayerNode * _Nonnull)videoPlayer;
    //    [Export ("videoPlayerNodeScrubberMinimumTrackTint:")]
    //    UIColor VideoPlayerNodeScrubberMinimumTrackTint (ASVideoPlayerNode videoPlayer);

    //    // @optional -(UIColor * _Nonnull)videoPlayerNodeScrubberThumbTint:(ASVideoPlayerNode * _Nonnull)videoPlayer;
    //    [Export ("videoPlayerNodeScrubberThumbTint:")]
    //    UIColor VideoPlayerNodeScrubberThumbTint (ASVideoPlayerNode videoPlayer);

    //    // @optional -(UIImage * _Nonnull)videoPlayerNodeScrubberThumbImage:(ASVideoPlayerNode * _Nonnull)videoPlayer;
    //    [Export ("videoPlayerNodeScrubberThumbImage:")]
    //    UIImage VideoPlayerNodeScrubberThumbImage (ASVideoPlayerNode videoPlayer);

    //    // @optional -(UIColor * _Nonnull)videoPlayerNodeSpinnerTint:(ASVideoPlayerNode * _Nonnull)videoPlayer;
    //    [Export ("videoPlayerNodeSpinnerTint:")]
    //    UIColor VideoPlayerNodeSpinnerTint (ASVideoPlayerNode videoPlayer);

    //    // @optional -(UIActivityIndicatorViewStyle)videoPlayerNodeSpinnerStyle:(ASVideoPlayerNode * _Nonnull)videoPlayer;
    //    [Export ("videoPlayerNodeSpinnerStyle:")]
    //    UIActivityIndicatorViewStyle VideoPlayerNodeSpinnerStyle (ASVideoPlayerNode videoPlayer);

    //    // @optional -(UIColor * _Nonnull)videoPlayerNodePlaybackButtonTint:(ASVideoPlayerNode * _Nonnull)videoPlayer;
    //    [Export ("videoPlayerNodePlaybackButtonTint:")]
    //    UIColor VideoPlayerNodePlaybackButtonTint (ASVideoPlayerNode videoPlayer);

    //    // @optional -(UIImage * _Nonnull)videoPlayerNodeFullScreenButtonImage:(ASVideoPlayerNode * _Nonnull)videoPlayer;
    //    [Export ("videoPlayerNodeFullScreenButtonImage:")]
    //    UIImage VideoPlayerNodeFullScreenButtonImage (ASVideoPlayerNode videoPlayer);

    //    // @optional -(void)didTapVideoPlayerNode:(ASVideoPlayerNode * _Nonnull)videoPlayer;
    //    [Export ("didTapVideoPlayerNode:")]
    //    void DidTapVideoPlayerNode (ASVideoPlayerNode videoPlayer);

    //    // @optional -(void)didTapFullScreenButtonNode:(ASButtonNode * _Nonnull)buttonNode;
    //    [Export ("didTapFullScreenButtonNode:")]
    //    void DidTapFullScreenButtonNode (ASButtonNode buttonNode);

    //    // @optional -(void)videoPlayerNode:(ASVideoPlayerNode * _Nonnull)videoPlayer didPlayToTime:(CMTime)time;
    //    [Export ("videoPlayerNode:didPlayToTime:")]
    //    void VideoPlayerNode (ASVideoPlayerNode videoPlayer, CMTime time);

    //    // @optional -(void)videoPlayerNode:(ASVideoPlayerNode * _Nonnull)videoPlayer willChangeVideoNodeState:(ASVideoNodePlayerState)state toVideoNodeState:(ASVideoNodePlayerState)toState;
    //    [Export ("videoPlayerNode:willChangeVideoNodeState:toVideoNodeState:")]
    //    void VideoPlayerNode (ASVideoPlayerNode videoPlayer, ASVideoNodePlayerState state, ASVideoNodePlayerState toState);

    //    // @optional -(BOOL)videoPlayerNode:(ASVideoPlayerNode * _Nonnull)videoPlayer shouldChangeVideoNodeStateTo:(ASVideoNodePlayerState)state;
    //    [Export ("videoPlayerNode:shouldChangeVideoNodeStateTo:")]
    //    bool VideoPlayerNode (ASVideoPlayerNode videoPlayer, ASVideoNodePlayerState state);

    //    // @optional -(void)videoPlayerNodeDidPlayToEnd:(ASVideoPlayerNode * _Nonnull)videoPlayer;
    //    [Export ("videoPlayerNodeDidPlayToEnd:")]
    //    void VideoPlayerNodeDidPlayToEnd (ASVideoPlayerNode videoPlayer);

    //    // @optional -(void)videoPlayerNode:(ASVideoPlayerNode * _Nonnull)videoPlayer didSetCurrentItem:(AVPlayerItem * _Nonnull)currentItem;
    //    [Export ("videoPlayerNode:didSetCurrentItem:")]
    //    void VideoPlayerNode (ASVideoPlayerNode videoPlayer, AVPlayerItem currentItem);

    //    // @optional -(void)videoPlayerNode:(ASVideoPlayerNode * _Nonnull)videoPlayer didStallAtTimeInterval:(NSTimeInterval)timeInterval;
    //    [Export ("videoPlayerNode:didStallAtTimeInterval:")]
    //    void VideoPlayerNode (ASVideoPlayerNode videoPlayer, double timeInterval);

    //    // @optional -(void)videoPlayerNodeDidStartInitialLoading:(ASVideoPlayerNode * _Nonnull)videoPlayer;
    //    [Export ("videoPlayerNodeDidStartInitialLoading:")]
    //    void VideoPlayerNodeDidStartInitialLoading (ASVideoPlayerNode videoPlayer);

    //    // @optional -(void)videoPlayerNodeDidFinishInitialLoading:(ASVideoPlayerNode * _Nonnull)videoPlayer;
    //    [Export ("videoPlayerNodeDidFinishInitialLoading:")]
    //    void VideoPlayerNodeDidFinishInitialLoading (ASVideoPlayerNode videoPlayer);

    //    // @optional -(void)videoPlayerNodeDidRecoverFromStall:(ASVideoPlayerNode * _Nonnull)videoPlayer;
    //    [Export ("videoPlayerNodeDidRecoverFromStall:")]
    //    void VideoPlayerNodeDidRecoverFromStall (ASVideoPlayerNode videoPlayer);
    //}

    //// @interface ASEditableTextNode : ASDisplayNode <UITextInputTraits>
    //[BaseType (typeof(ASDisplayNode))]
    //interface ASEditableTextNode : IUITextInputTraits
    //{
    //    // -(instancetype _Nonnull)initWithTextKitComponents:(ASTextKitComponents * _Nonnull)textKitComponents placeholderTextKitComponents:(ASTextKitComponents * _Nonnull)placeholderTextKitComponents;
    //    [Export ("initWithTextKitComponents:placeholderTextKitComponents:")]
    //    IntPtr Constructor (ASTextKitComponents textKitComponents, ASTextKitComponents placeholderTextKitComponents);

    //    [Wrap ("WeakDelegate")]
    //    [NullAllowed]
    //    ASEditableTextNodeDelegate Delegate { get; set; }

    //    // @property (readwrite, nonatomic, weak) id<ASEditableTextNodeDelegate> _Nullable delegate;
    //    [NullAllowed, Export ("delegate", ArgumentSemantic.Weak)]
    //    NSObject WeakDelegate { get; set; }

    //    // @property (nonatomic) BOOL scrollEnabled;
    //    [Export ("scrollEnabled")]
    //    bool ScrollEnabled { get; set; }

    //    // @property (readonly, nonatomic, strong) UITextView * _Nonnull textView;
    //    [Export ("textView", ArgumentSemantic.Strong)]
    //    UITextView TextView { get; }

    //    // @property (readwrite, nonatomic, strong) NSDictionary<NSString *,id> * _Nullable typingAttributes;
    //    [NullAllowed, Export ("typingAttributes", ArgumentSemantic.Strong)]
    //    NSDictionary<NSString, NSObject> TypingAttributes { get; set; }

    //    // @property (assign, readwrite, nonatomic) NSRange selectedRange;
    //    [Export ("selectedRange", ArgumentSemantic.Assign)]
    //    NSRange SelectedRange { get; set; }

    //    // -(BOOL)isDisplayingPlaceholder __attribute__((warn_unused_result));
    //    [Export ("isDisplayingPlaceholder")]
    //    [Verify (MethodToProperty)]
    //    bool IsDisplayingPlaceholder { get; }

    //    // @property (readwrite, nonatomic, strong) NSAttributedString * _Nullable attributedPlaceholderText;
    //    [NullAllowed, Export ("attributedPlaceholderText", ArgumentSemantic.Strong)]
    //    NSAttributedString AttributedPlaceholderText { get; set; }

    //    // @property (readwrite, copy, nonatomic) NSAttributedString * _Nullable attributedText;
    //    [NullAllowed, Export ("attributedText", ArgumentSemantic.Copy)]
    //    NSAttributedString AttributedText { get; set; }

    //    // @property (readonly, nonatomic) UITextInputMode * _Nonnull textInputMode;
    //    [Export ("textInputMode")]
    //    UITextInputMode TextInputMode { get; }

    //    // @property (readwrite, nonatomic) UIEdgeInsets textContainerInset;
    //    [Export ("textContainerInset", ArgumentSemantic.Assign)]
    //    UIEdgeInsets TextContainerInset { get; set; }

    //    // @property (assign, nonatomic) NSUInteger maximumLinesToDisplay;
    //    [Export ("maximumLinesToDisplay")]
    //    nuint MaximumLinesToDisplay { get; set; }

    //    // -(BOOL)isFirstResponder __attribute__((warn_unused_result));
    //    [Export ("isFirstResponder")]
    //    [Verify (MethodToProperty)]
    //    bool IsFirstResponder { get; }

    //    // -(BOOL)becomeFirstResponder;
    //    [Export ("becomeFirstResponder")]
    //    [Verify (MethodToProperty)]
    //    bool BecomeFirstResponder { get; }

    //    // -(BOOL)resignFirstResponder;
    //    [Export ("resignFirstResponder")]
    //    [Verify (MethodToProperty)]
    //    bool ResignFirstResponder { get; }

    //    // -(CGRect)frameForTextRange:(NSRange)textRange __attribute__((warn_unused_result));
    //    [Export ("frameForTextRange:")]
    //    CGRect FrameForTextRange (NSRange textRange);

    //    // @property (assign, readwrite, nonatomic) UITextAutocapitalizationType autocapitalizationType;
    //    [Export ("autocapitalizationType", ArgumentSemantic.Assign)]
    //    UITextAutocapitalizationType AutocapitalizationType { get; set; }

    //    // @property (assign, readwrite, nonatomic) UITextAutocorrectionType autocorrectionType;
    //    [Export ("autocorrectionType", ArgumentSemantic.Assign)]
    //    UITextAutocorrectionType AutocorrectionType { get; set; }

    //    // @property (assign, readwrite, nonatomic) UITextSpellCheckingType spellCheckingType;
    //    [Export ("spellCheckingType", ArgumentSemantic.Assign)]
    //    UITextSpellCheckingType SpellCheckingType { get; set; }

    //    // @property (assign, readwrite, nonatomic) UIKeyboardType keyboardType;
    //    [Export ("keyboardType", ArgumentSemantic.Assign)]
    //    UIKeyboardType KeyboardType { get; set; }

    //    // @property (assign, readwrite, nonatomic) UIKeyboardAppearance keyboardAppearance;
    //    [Export ("keyboardAppearance", ArgumentSemantic.Assign)]
    //    UIKeyboardAppearance KeyboardAppearance { get; set; }

    //    // @property (assign, readwrite, nonatomic) UIReturnKeyType returnKeyType;
    //    [Export ("returnKeyType", ArgumentSemantic.Assign)]
    //    UIReturnKeyType ReturnKeyType { get; set; }

    //    // @property (assign, readwrite, nonatomic) BOOL enablesReturnKeyAutomatically;
    //    [Export ("enablesReturnKeyAutomatically")]
    //    bool EnablesReturnKeyAutomatically { get; set; }

    //    // @property (getter = isSecureTextEntry, assign, readwrite, nonatomic) BOOL secureTextEntry;
    //    [Export ("secureTextEntry")]
    //    bool SecureTextEntry { [Bind ("isSecureTextEntry")] get; set; }
    //}

    //// @interface Unavailable (ASEditableTextNode)
    //[Category]
    //[BaseType (typeof(ASEditableTextNode))]
    //interface ASEditableTextNode_Unavailable
    //{
    //}

    //// @protocol ASEditableTextNodeDelegate <NSObject>
    //[Protocol, Model]
    //[BaseType (typeof(NSObject))]
    //interface ASEditableTextNodeDelegate
    //{
    //    // @optional -(BOOL)editableTextNodeShouldBeginEditing:(ASEditableTextNode * _Nonnull)editableTextNode;
    //    [Export ("editableTextNodeShouldBeginEditing:")]
    //    bool EditableTextNodeShouldBeginEditing (ASEditableTextNode editableTextNode);

    //    // @optional -(void)editableTextNodeDidBeginEditing:(ASEditableTextNode * _Nonnull)editableTextNode;
    //    [Export ("editableTextNodeDidBeginEditing:")]
    //    void EditableTextNodeDidBeginEditing (ASEditableTextNode editableTextNode);

    //    // @optional -(BOOL)editableTextNode:(ASEditableTextNode * _Nonnull)editableTextNode shouldChangeTextInRange:(NSRange)range replacementText:(NSString * _Nonnull)text;
    //    [Export ("editableTextNode:shouldChangeTextInRange:replacementText:")]
    //    bool EditableTextNode (ASEditableTextNode editableTextNode, NSRange range, string text);

    //    // @optional -(void)editableTextNodeDidChangeSelection:(ASEditableTextNode * _Nonnull)editableTextNode fromSelectedRange:(NSRange)fromSelectedRange toSelectedRange:(NSRange)toSelectedRange dueToEditing:(BOOL)dueToEditing;
    //    [Export ("editableTextNodeDidChangeSelection:fromSelectedRange:toSelectedRange:dueToEditing:")]
    //    void EditableTextNodeDidChangeSelection (ASEditableTextNode editableTextNode, NSRange fromSelectedRange, NSRange toSelectedRange, bool dueToEditing);

    //    // @optional -(void)editableTextNodeDidUpdateText:(ASEditableTextNode * _Nonnull)editableTextNode;
    //    [Export ("editableTextNodeDidUpdateText:")]
    //    void EditableTextNodeDidUpdateText (ASEditableTextNode editableTextNode);

    //    // @optional -(void)editableTextNodeDidFinishEditing:(ASEditableTextNode * _Nonnull)editableTextNode;
    //    [Export ("editableTextNodeDidFinishEditing:")]
    //    void EditableTextNodeDidFinishEditing (ASEditableTextNode editableTextNode);
    //}

    // @protocol ASImageContainerProtocol <NSObject>
    [Protocol, Model]
    [BaseType (typeof(NSObject))]
    interface ASImageContainerProtocol
    {
        // @required -(UIImage * _Nullable)asdk_image;
        [Abstract]
        [NullAllowed, Export ("asdk_image")]
        //[Verify (MethodToProperty)]
        UIImage Asdk_image { get; }

        // @required -(NSData * _Nullable)asdk_animatedImageData;
        [Abstract]
        [NullAllowed, Export ("asdk_animatedImageData")]
        //[Verify (MethodToProperty)]
        NSData Asdk_animatedImageData { get; }
    }

    // typedef void (^ASImageCacherCompletion)(id<ASImageContainerProtocol> _Nullable);
    delegate void ASImageCacherCompletion ([NullAllowed] ASImageContainerProtocol arg0);

    // @protocol ASImageCacheProtocol <NSObject>
    [Protocol, Model]
    [BaseType (typeof(NSObject))]
    interface ASImageCacheProtocol
    {
        // @required -(void)cachedImageWithURL:(NSURL * _Nonnull)URL callbackQueue:(dispatch_queue_t _Nonnull)callbackQueue completion:(ASImageCacherCompletion _Nonnull)completion;
        [Abstract]
        [Export ("cachedImageWithURL:callbackQueue:completion:")]
        void CachedImageWithURL (NSUrl URL, DispatchQueue callbackQueue, ASImageCacherCompletion completion);

        // @optional -(id<ASImageContainerProtocol> _Nullable)synchronouslyFetchedCachedImageWithURL:(NSURL * _Nonnull)URL;
        [Export ("synchronouslyFetchedCachedImageWithURL:")]
        [return: NullAllowed]
        ASImageContainerProtocol SynchronouslyFetchedCachedImageWithURL (NSUrl URL);

        // @optional -(void)clearFetchedImageFromCacheWithURL:(NSURL * _Nonnull)URL;
        [Export ("clearFetchedImageFromCacheWithURL:")]
        void ClearFetchedImageFromCacheWithURL (NSUrl URL);

        // @optional -(void)cachedImageWithURLs:(NSArray<NSURL *> * _Nonnull)URLs callbackQueue:(dispatch_queue_t _Nonnull)callbackQueue completion:(ASImageCacherCompletion _Nonnull)completion;
        [Export ("cachedImageWithURLs:callbackQueue:completion:")]
        void CachedImageWithURLs (NSUrl[] URLs, DispatchQueue callbackQueue, ASImageCacherCompletion completion);
    }

    // typedef void (^ASImageDownloaderCompletion)(id<ASImageContainerProtocol> _Nullable, NSError * _Nullable, id _Nullable);
    delegate void ASImageDownloaderCompletion ([NullAllowed] ASImageContainerProtocol arg0, [NullAllowed] NSError arg1, [NullAllowed] NSObject arg2);

    // typedef void (^ASImageDownloaderProgress)(CGFloat);
    delegate void ASImageDownloaderProgress (nfloat arg0);

    // typedef void (^ASImageDownloaderProgressImage)(UIImage * _Nonnull, CGFloat, id _Nullable);
    delegate void ASImageDownloaderProgressImage (UIImage arg0, nfloat arg1, [NullAllowed] NSObject arg2);

    // @protocol ASImageDownloaderProtocol <NSObject>
    [Protocol, Model]
    [BaseType (typeof(NSObject))]
    interface ASImageDownloaderProtocol
    {
        // @required -(id _Nullable)downloadImageWithURL:(NSURL * _Nonnull)URL callbackQueue:(dispatch_queue_t _Nonnull)callbackQueue downloadProgress:(ASImageDownloaderProgress _Nullable)downloadProgress completion:(ASImageDownloaderCompletion _Nonnull)completion;
        [Abstract]
        [Export ("downloadImageWithURL:callbackQueue:downloadProgress:completion:")]
        [return: NullAllowed]
        NSObject DownloadImageWithURL (NSUrl URL, DispatchQueue callbackQueue, [NullAllowed] ASImageDownloaderProgress downloadProgress, ASImageDownloaderCompletion completion);

        // @required -(void)cancelImageDownloadForIdentifier:(id _Nonnull)downloadIdentifier;
        [Abstract]
        [Export ("cancelImageDownloadForIdentifier:")]
        void CancelImageDownloadForIdentifier (NSObject downloadIdentifier);

        // @optional -(void)cancelImageDownloadWithResumePossibilityForIdentifier:(id _Nonnull)downloadIdentifier;
        [Export ("cancelImageDownloadWithResumePossibilityForIdentifier:")]
        void CancelImageDownloadWithResumePossibilityForIdentifier (NSObject downloadIdentifier);

        // @optional -(id<ASAnimatedImageProtocol> _Nullable)animatedImageWithData:(NSData * _Nonnull)animatedImageData;
        [Export ("animatedImageWithData:")]
        [return: NullAllowed]
        ASAnimatedImageProtocol AnimatedImageWithData (NSData animatedImageData);

        // @optional -(void)setProgressImageBlock:(ASImageDownloaderProgressImage _Nullable)progressBlock callbackQueue:(dispatch_queue_t _Nonnull)callbackQueue withDownloadIdentifier:(id _Nonnull)downloadIdentifier;
        [Export ("setProgressImageBlock:callbackQueue:withDownloadIdentifier:")]
        void SetProgressImageBlock ([NullAllowed] ASImageDownloaderProgressImage progressBlock, DispatchQueue callbackQueue, NSObject downloadIdentifier);

        // @optional -(void)setPriority:(ASImageDownloaderPriority)priority withDownloadIdentifier:(id _Nonnull)downloadIdentifier;
        [Export ("setPriority:withDownloadIdentifier:")]
        void SetPriority (ASImageDownloaderPriority priority, NSObject downloadIdentifier);

        // @optional -(id _Nullable)downloadImageWithURLs:(NSArray<NSURL *> * _Nonnull)URLs callbackQueue:(dispatch_queue_t _Nonnull)callbackQueue downloadProgress:(ASImageDownloaderProgress _Nullable)downloadProgress completion:(ASImageDownloaderCompletion _Nonnull)completion;
        [Export ("downloadImageWithURLs:callbackQueue:downloadProgress:completion:")]
        [return: NullAllowed]
        NSObject DownloadImageWithURLs (NSUrl[] URLs, DispatchQueue callbackQueue, [NullAllowed] ASImageDownloaderProgress downloadProgress, ASImageDownloaderCompletion completion);
    }

    // @protocol ASAnimatedImageProtocol <NSObject>
    [Protocol, Model]
    [BaseType (typeof(NSObject))]
    interface ASAnimatedImageProtocol
    {
        // @optional @property (readwrite, nonatomic) void (^ _Nonnull)(UIImage * _Nonnull) coverImageReadyCallback;
        [Export ("coverImageReadyCallback", ArgumentSemantic.Assign)]
        Action<UIImage> CoverImageReadyCallback { get; set; }

        // @optional -(BOOL)isDataSupported:(NSData * _Nonnull)data;
        [Export ("isDataSupported:")]
        bool IsDataSupported (NSData data);

        // @required @property (readonly, nonatomic) UIImage * _Nonnull coverImage;
        [Abstract]
        [Export ("coverImage")]
        UIImage CoverImage { get; }

        // @required @property (readonly, nonatomic) BOOL coverImageReady;
        [Abstract]
        [Export ("coverImageReady")]
        bool CoverImageReady { get; }

        // @required @property (readonly, nonatomic) CFTimeInterval totalDuration;
        [Abstract]
        [Export ("totalDuration")]
        double TotalDuration { get; }

        // @required @property (readonly, nonatomic) NSUInteger frameInterval;
        [Abstract]
        [Export ("frameInterval")]
        nuint FrameInterval { get; }

        // @required @property (readonly, nonatomic) size_t loopCount;
        [Abstract]
        [Export ("loopCount")]
        nuint LoopCount { get; }

        // @required @property (readonly, nonatomic) size_t frameCount;
        [Abstract]
        [Export ("frameCount")]
        nuint FrameCount { get; }

        // @required @property (readonly, nonatomic) BOOL playbackReady;
        [Abstract]
        [Export ("playbackReady")]
        bool PlaybackReady { get; }

        // @required @property (readonly, nonatomic) NSError * _Nonnull error;
        [Abstract]
        [Export ("error")]
        NSError Error { get; }

        //// @required @property (readwrite, nonatomic) dispatch_block_t _Nonnull playbackReadyCallback;
        //[Abstract]
        //[Export ("playbackReadyCallback", ArgumentSemantic.Assign)]
        //dispatch_block_t PlaybackReadyCallback { get; set; }

        //// @required -(CGImageRef _Nonnull)imageAtIndex:(NSUInteger)index;
        //[Abstract]
        //[Export ("imageAtIndex:")]
        //unsafe CGImageRef* ImageAtIndex (nuint index);

        // @required -(CFTimeInterval)durationAtIndex:(NSUInteger)index;
        [Abstract]
        [Export ("durationAtIndex:")]
        double DurationAtIndex (nuint index);

        // @required -(void)clearAnimatedImageCache;
        [Abstract]
        [Export ("clearAnimatedImageCache")]
        void ClearAnimatedImageCache ();
    }

    // @interface ASBasicImageDownloader : NSObject <ASImageDownloaderProtocol>
    [BaseType (typeof(NSObject))]
    [DisableDefaultCtor]
    interface ASBasicImageDownloader : ASImageDownloaderProtocol
    {
        // +(instancetype _Nonnull)sharedImageDownloader;
        [Static]
        [Export ("sharedImageDownloader")]
        ASBasicImageDownloader SharedImageDownloader ();
    }

    //[Static]
    //[Verify (ConstantsInterfaceAssociation)]
    //partial interface Constants
    //{
    //    // extern NSString *const _Nonnull ASMultiplexImageNodeErrorDomain;
    //    [Field ("ASMultiplexImageNodeErrorDomain", "__Internal")]
    //    NSString ASMultiplexImageNodeErrorDomain { get; }
    //}

    //// @interface ASMultiplexImageNode : ASImageNode
    //[BaseType (typeof(ASImageNode))]
    //interface ASMultiplexImageNode
    //{
    //    // -(instancetype _Nonnull)initWithCache:(id<ASImageCacheProtocol> _Nullable)cache downloader:(id<ASImageDownloaderProtocol> _Nullable)downloader __attribute__((objc_designated_initializer));
    //    [Export ("initWithCache:downloader:")]
    //    [DesignatedInitializer]
    //    IntPtr Constructor ([NullAllowed] ASImageCacheProtocol cache, [NullAllowed] ASImageDownloaderProtocol downloader);

    //    [Wrap ("WeakDelegate")]
    //    [NullAllowed]
    //    ASMultiplexImageNodeDelegate Delegate { get; set; }

    //    // @property (readwrite, nonatomic, weak) id<ASMultiplexImageNodeDelegate> _Nullable delegate;
    //    [NullAllowed, Export ("delegate", ArgumentSemantic.Weak)]
    //    NSObject WeakDelegate { get; set; }

    //    // @property (readwrite, nonatomic, weak) id<ASMultiplexImageNodeDataSource> _Nullable dataSource;
    //    [NullAllowed, Export ("dataSource", ArgumentSemantic.Weak)]
    //    ASMultiplexImageNodeDataSource DataSource { get; set; }

    //    // @property (assign, readwrite, nonatomic) BOOL downloadsIntermediateImages;
    //    [Export ("downloadsIntermediateImages")]
    //    bool DownloadsIntermediateImages { get; set; }

    //    // @property (readwrite, copy, nonatomic) NSArray<ASImageIdentifier> * _Nonnull imageIdentifiers;
    //    [Export ("imageIdentifiers", ArgumentSemantic.Copy)]
    //    NSObject<NSCopying, NSObject>[] ImageIdentifiers { get; set; }

    //    // -(void)reloadImageIdentifierSources;
    //    [Export ("reloadImageIdentifierSources")]
    //    void ReloadImageIdentifierSources ();

    //    // @property (readonly, nonatomic) ASImageIdentifier _Nullable loadedImageIdentifier;
    //    [NullAllowed, Export ("loadedImageIdentifier")]
    //    NSObject<NSCopying, NSObject> LoadedImageIdentifier { get; }

    //    // @property (readonly, nonatomic) ASImageIdentifier _Nullable displayedImageIdentifier;
    //    [NullAllowed, Export ("displayedImageIdentifier")]
    //    NSObject<NSCopying, NSObject> DisplayedImageIdentifier { get; }

    //    // @property (assign, readwrite, nonatomic) BOOL shouldRenderProgressImages;
    //    [Export ("shouldRenderProgressImages")]
    //    bool ShouldRenderProgressImages { get; set; }

    //    // @property (nonatomic, strong) PHImageManager * _Nullable imageManager;
    //    [NullAllowed, Export ("imageManager", ArgumentSemantic.Strong)]
    //    PHImageManager ImageManager { get; set; }
    //}

    //// @protocol ASMultiplexImageNodeDelegate <NSObject>
    //[Protocol, Model]
    //[BaseType (typeof(NSObject))]
    //interface ASMultiplexImageNodeDelegate
    //{
    //    // @optional -(void)multiplexImageNode:(ASMultiplexImageNode * _Nonnull)imageNode didStartDownloadOfImageWithIdentifier:(id _Nonnull)imageIdentifier;
    //    [Export ("multiplexImageNode:didStartDownloadOfImageWithIdentifier:")]
    //    void MultiplexImageNode (ASMultiplexImageNode imageNode, NSObject imageIdentifier);

    //    // @optional -(void)multiplexImageNode:(ASMultiplexImageNode * _Nonnull)imageNode didUpdateDownloadProgress:(CGFloat)downloadProgress forImageWithIdentifier:(ASImageIdentifier _Nonnull)imageIdentifier;
    //    [Export ("multiplexImageNode:didUpdateDownloadProgress:forImageWithIdentifier:")]
    //    void MultiplexImageNode (ASMultiplexImageNode imageNode, nfloat downloadProgress, NSObject<NSCopying, NSObject> imageIdentifier);

    //    // @optional -(void)multiplexImageNode:(ASMultiplexImageNode * _Nonnull)imageNode didFinishDownloadingImageWithIdentifier:(ASImageIdentifier _Nonnull)imageIdentifier error:(NSError * _Nullable)error;
    //    [Export ("multiplexImageNode:didFinishDownloadingImageWithIdentifier:error:")]
    //    void MultiplexImageNode (ASMultiplexImageNode imageNode, NSObject<NSCopying, NSObject> imageIdentifier, [NullAllowed] NSError error);

    //    // @optional -(void)multiplexImageNode:(ASMultiplexImageNode * _Nonnull)imageNode didUpdateImage:(UIImage * _Nullable)image withIdentifier:(ASImageIdentifier _Nullable)imageIdentifier fromImage:(UIImage * _Nullable)previousImage withIdentifier:(ASImageIdentifier _Nullable)previousImageIdentifier;
    //    [Export ("multiplexImageNode:didUpdateImage:withIdentifier:fromImage:withIdentifier:")]
    //    void MultiplexImageNode (ASMultiplexImageNode imageNode, [NullAllowed] UIImage image, [NullAllowed] NSObject<NSCopying, NSObject> imageIdentifier, [NullAllowed] UIImage previousImage, [NullAllowed] NSObject<NSCopying, NSObject> previousImageIdentifier);

    //    // @optional -(void)multiplexImageNode:(ASMultiplexImageNode * _Nonnull)imageNode didDisplayUpdatedImage:(UIImage * _Nullable)image withIdentifier:(ASImageIdentifier _Nullable)imageIdentifier;
    //    [Export ("multiplexImageNode:didDisplayUpdatedImage:withIdentifier:")]
    //    void MultiplexImageNode (ASMultiplexImageNode imageNode, [NullAllowed] UIImage image, [NullAllowed] NSObject<NSCopying, NSObject> imageIdentifier);

    //    // @optional -(void)multiplexImageNodeDidFinishDisplay:(ASMultiplexImageNode * _Nonnull)imageNode;
    //    [Export ("multiplexImageNodeDidFinishDisplay:")]
    //    void MultiplexImageNodeDidFinishDisplay (ASMultiplexImageNode imageNode);
    //}

    //// @protocol ASMultiplexImageNodeDataSource <NSObject>
    //[Protocol, Model]
    //[BaseType (typeof(NSObject))]
    //interface ASMultiplexImageNodeDataSource
    //{
    //    // @optional -(UIImage * _Nullable)multiplexImageNode:(ASMultiplexImageNode * _Nonnull)imageNode imageForImageIdentifier:(ASImageIdentifier _Nonnull)imageIdentifier;
    //    [Export ("multiplexImageNode:imageForImageIdentifier:")]
    //    [return: NullAllowed]
    //    UIImage MultiplexImageNode (ASMultiplexImageNode imageNode, NSObject<NSCopying, NSObject> imageIdentifier);

    //    // @optional -(NSURL * _Nullable)multiplexImageNode:(ASMultiplexImageNode * _Nonnull)imageNode URLForImageIdentifier:(ASImageIdentifier _Nonnull)imageIdentifier;
    //    [Export ("multiplexImageNode:URLForImageIdentifier:")]
    //    [return: NullAllowed]
    //    NSUrl MultiplexImageNode (ASMultiplexImageNode imageNode, NSObject<NSCopying, NSObject> imageIdentifier);

    //    // @optional -(PHAsset * _Nullable)multiplexImageNode:(ASMultiplexImageNode * _Nonnull)imageNode assetForLocalIdentifier:(NSString * _Nonnull)assetLocalIdentifier;
    //    [Export ("multiplexImageNode:assetForLocalIdentifier:")]
    //    [return: NullAllowed]
    //    PHAsset MultiplexImageNode (ASMultiplexImageNode imageNode, string assetLocalIdentifier);
    //}

    //// @interface ASPhotosFrameworkURLs (NSURL)
    //[Category]
    //[BaseType (typeof(NSUrl))]
    //interface NSURL_ASPhotosFrameworkURLs
    //{
    //    // +(NSURL * _Nonnull)URLWithAssetLocalIdentifier:(NSString * _Nonnull)assetLocalIdentifier targetSize:(CGSize)targetSize contentMode:(PHImageContentMode)contentMode options:(PHImageRequestOptions * _Nonnull)options __attribute__((warn_unused_result));
    //    [Static]
    //    [Export ("URLWithAssetLocalIdentifier:targetSize:contentMode:options:")]
    //    NSUrl URLWithAssetLocalIdentifier (string assetLocalIdentifier, CGSize targetSize, PHImageContentMode contentMode, PHImageRequestOptions options);
    //}

    //[Static]
    //[Verify (ConstantsInterfaceAssociation)]
    //partial interface Constants
    //{
    //    // extern NSString *const _Nonnull ASPhotosURLScheme;
    //    [Field ("ASPhotosURLScheme", "__Internal")]
    //    NSString ASPhotosURLScheme { get; }
    //}

    //// @interface ASPhotosFrameworkImageRequest : NSObject <NSCopying>
    //[BaseType (typeof(NSObject))]
    //interface ASPhotosFrameworkImageRequest : INSCopying
    //{
    //    // -(instancetype _Nonnull)initWithAssetIdentifier:(NSString * _Nonnull)assetIdentifier __attribute__((objc_designated_initializer));
    //    [Export ("initWithAssetIdentifier:")]
    //    [DesignatedInitializer]
    //    IntPtr Constructor (string assetIdentifier);

    //    // +(ASPhotosFrameworkImageRequest * _Nullable)requestWithURL:(NSURL * _Nonnull)url;
    //    [Static]
    //    [Export ("requestWithURL:")]
    //    [return: NullAllowed]
    //    ASPhotosFrameworkImageRequest RequestWithURL (NSUrl url);

    //    // @property (readonly, nonatomic) NSString * _Nonnull assetIdentifier;
    //    [Export ("assetIdentifier")]
    //    string AssetIdentifier { get; }

    //    // @property (nonatomic) CGSize targetSize;
    //    [Export ("targetSize", ArgumentSemantic.Assign)]
    //    CGSize TargetSize { get; set; }

    //    // @property (nonatomic) PHImageContentMode contentMode;
    //    [Export ("contentMode", ArgumentSemantic.Assign)]
    //    PHImageContentMode ContentMode { get; set; }

    //    // @property (nonatomic, strong) PHImageRequestOptions * _Nonnull options;
    //    [Export ("options", ArgumentSemantic.Strong)]
    //    PHImageRequestOptions Options { get; set; }

    //    // @property (readonly, nonatomic) NSURL * _Nonnull url;
    //    [Export ("url")]
    //    NSUrl Url { get; }
    //}

    //[Static]
    //[Verify (ConstantsInterfaceAssociation)]
    //partial interface Constants
    //{
    //    // extern const ASRangeTuningParameters ASRangeTuningParametersZero;
    //    [Field ("ASRangeTuningParametersZero", "__Internal")]
    //    ASRangeTuningParameters ASRangeTuningParametersZero { get; }
    //}

    // @protocol ASCommonTableDataSource <NSObject>
    [Protocol, Model]
    [BaseType (typeof(NSObject))]
    interface ASCommonTableDataSource
    {
        // @optional -(NSInteger)tableView:(UITableView * _Nonnull)tableView numberOfRowsInSection:(NSInteger)section __attribute__((deprecated("Implement -tableNode:numberOfRowsInSection: instead.")));
        [Export ("tableView:numberOfRowsInSection:")]
        nint NumberOfRowsInSection (UITableView tableView, nint section);

        // @optional -(NSInteger)numberOfSectionsInTableView:(UITableView * _Nonnull)tableView __attribute__((deprecated("Implement numberOfSectionsInTableNode: instead.")));
        [Export ("numberOfSectionsInTableView:")]
        nint NumberOfSectionsInTableView (UITableView tableView);

        // @optional -(NSString * _Nullable)tableView:(UITableView * _Nonnull)tableView titleForHeaderInSection:(NSInteger)section;
        [Export ("tableView:titleForHeaderInSection:")]
        [return: NullAllowed]
        string TitleForHeaderInSection (UITableView tableView, nint section);

        // @optional -(NSString * _Nullable)tableView:(UITableView * _Nonnull)tableView titleForFooterInSection:(NSInteger)section;
        [Export ("tableView:titleForFooterInSection:")]
        [return: NullAllowed]
        string TitleForFooterInSection (UITableView tableView, nint section);

        // @optional -(BOOL)tableView:(UITableView * _Nonnull)tableView canEditRowAtIndexPath:(NSIndexPath * _Nonnull)indexPath;
        [Export ("tableView:canEditRowAtIndexPath:")]
        bool CanEditRowAtIndexPath (UITableView tableView, NSIndexPath indexPath);

        // @optional -(BOOL)tableView:(UITableView * _Nonnull)tableView canMoveRowAtIndexPath:(NSIndexPath * _Nonnull)indexPath;
        [Export ("tableView:canMoveRowAtIndexPath:")]
        bool CanMoveRowAtIndexPath (UITableView tableView, NSIndexPath indexPath);

        // @optional -(NSArray<NSString *> * _Nullable)sectionIndexTitlesForTableView:(UITableView * _Nonnull)tableView;
        [Export ("sectionIndexTitlesForTableView:")]
        [return: NullAllowed]
        string[] SectionIndexTitlesForTableView (UITableView tableView);

        // @optional -(NSInteger)tableView:(UITableView * _Nonnull)tableView sectionForSectionIndexTitle:(NSString * _Nonnull)title atIndex:(NSInteger)index;
        [Export ("tableView:sectionForSectionIndexTitle:atIndex:")]
        nint SectionForSectionIndexTitle (UITableView tableView, string title, nint index);

        // @optional -(void)tableView:(UITableView * _Nonnull)tableView commitEditingStyle:(UITableViewCellEditingStyle)editingStyle forRowAtIndexPath:(NSIndexPath * _Nonnull)indexPath;
        [Export ("tableView:commitEditingStyle:forRowAtIndexPath:")]
        void CommitEditingStyle (UITableView tableView, UITableViewCellEditingStyle editingStyle, NSIndexPath indexPath);

        // @optional -(void)tableView:(UITableView * _Nonnull)tableView moveRowAtIndexPath:(NSIndexPath * _Nonnull)sourceIndexPath toIndexPath:(NSIndexPath * _Nonnull)destinationIndexPath;
        [Export ("tableView:moveRowAtIndexPath:toIndexPath:")]
        void MoveRowAtIndexPath (UITableView tableView, NSIndexPath sourceIndexPath, NSIndexPath destinationIndexPath);
    }

    interface IASCommonTableDataSource {}

    // @protocol ASCommonTableViewDelegate <NSObject, UIScrollViewDelegate>
    [Protocol, Model]
    [BaseType (typeof(NSObject))]
    interface ASCommonTableViewDelegate : IUIScrollViewDelegate
    {
        // @optional -(void)tableView:(UITableView * _Nonnull)tableView willDisplayHeaderView:(UIView * _Nonnull)view forSection:(NSInteger)section;
        [Export ("tableView:willDisplayHeaderView:forSection:")]
        void WillDisplayHeaderView (UITableView tableView, UIView view, nint section);

        // @optional -(void)tableView:(UITableView * _Nonnull)tableView willDisplayFooterView:(UIView * _Nonnull)view forSection:(NSInteger)section;
        [Export ("tableView:willDisplayFooterView:forSection:")]
        void WillDisplayFooterView (UITableView tableView, UIView view, nint section);

        // @optional -(void)tableView:(UITableView * _Nonnull)tableView didEndDisplayingHeaderView:(UIView * _Nonnull)view forSection:(NSInteger)section;
        [Export ("tableView:didEndDisplayingHeaderView:forSection:")]
        void DidEndDisplayingHeaderView (UITableView tableView, UIView view, nint section);

        // @optional -(void)tableView:(UITableView * _Nonnull)tableView didEndDisplayingFooterView:(UIView * _Nonnull)view forSection:(NSInteger)section;
        [Export ("tableView:didEndDisplayingFooterView:forSection:")]
        void DidEndDisplayingFooterView (UITableView tableView, UIView view, nint section);

        // @optional -(CGFloat)tableView:(UITableView * _Nonnull)tableView heightForHeaderInSection:(NSInteger)section;
        [Export ("tableView:heightForHeaderInSection:")]
        nfloat HeightForHeaderInSection (UITableView tableView, nint section);

        // @optional -(CGFloat)tableView:(UITableView * _Nonnull)tableView heightForFooterInSection:(NSInteger)section;
        [Export ("tableView:heightForFooterInSection:")]
        nfloat HeightForFooterInSection (UITableView tableView, nint section);

        // @optional -(UIView * _Nullable)tableView:(UITableView * _Nonnull)tableView viewForHeaderInSection:(NSInteger)section;
        [Export ("tableView:viewForHeaderInSection:")]
        [return: NullAllowed]
        UIView ViewForHeaderInSection (UITableView tableView, nint section);

        // @optional -(UIView * _Nullable)tableView:(UITableView * _Nonnull)tableView viewForFooterInSection:(NSInteger)section;
        [Export ("tableView:viewForFooterInSection:")]
        [return: NullAllowed]
        UIView ViewForFooterInSection (UITableView tableView, nint section);

        // @optional -(void)tableView:(UITableView * _Nonnull)tableView accessoryButtonTappedForRowWithIndexPath:(NSIndexPath * _Nonnull)indexPath;
        [Export ("tableView:accessoryButtonTappedForRowWithIndexPath:")]
        void TableView (UITableView tableView, NSIndexPath indexPath);

        // @optional -(BOOL)tableView:(UITableView * _Nonnull)tableView shouldHighlightRowAtIndexPath:(NSIndexPath * _Nonnull)indexPath __attribute__((deprecated("Implement -tableNode:shouldHighlightRowAtIndexPath: instead.")));
        [Export ("tableView:shouldHighlightRowAtIndexPath:")]
        bool ShouldHighlightRowAtIndexPath (UITableView tableView, NSIndexPath indexPath);

        // @optional -(void)tableView:(UITableView * _Nonnull)tableView didHighlightRowAtIndexPath:(NSIndexPath * _Nonnull)indexPath __attribute__((deprecated("Implement -tableNode:didHighlightRowAtIndexPath: instead.")));
        [Export ("tableView:didHighlightRowAtIndexPath:")]
        void DidHighlightRowAtIndexPath (UITableView tableView, NSIndexPath indexPath);

        // @optional -(void)tableView:(UITableView * _Nonnull)tableView didUnhighlightRowAtIndexPath:(NSIndexPath * _Nonnull)indexPath __attribute__((deprecated("Implement -tableNode:didUnhighlightRowAtIndexPath: instead.")));
        [Export ("tableView:didUnhighlightRowAtIndexPath:")]
        void DidUnhighlightRowAtIndexPath (UITableView tableView, NSIndexPath indexPath);

        // @optional -(NSIndexPath * _Nullable)tableView:(UITableView * _Nonnull)tableView willSelectRowAtIndexPath:(NSIndexPath * _Nonnull)indexPath __attribute__((deprecated("Implement -tableNode:willSelectRowAtIndexPath: instead.")));
        [Export ("tableView:willSelectRowAtIndexPath:")]
        [return: NullAllowed]
        NSIndexPath WillSelectRowAtIndexPath (UITableView tableView, NSIndexPath indexPath);

        // @optional -(NSIndexPath * _Nullable)tableView:(UITableView * _Nonnull)tableView willDeselectRowAtIndexPath:(NSIndexPath * _Nonnull)indexPath __attribute__((deprecated("Implement -tableNode:willDeselectRowAtIndexPath: instead.")));
        [Export ("tableView:willDeselectRowAtIndexPath:")]
        [return: NullAllowed]
        NSIndexPath WillDeselectRowAtIndexPath (UITableView tableView, NSIndexPath indexPath);

        // @optional -(void)tableView:(UITableView * _Nonnull)tableView didSelectRowAtIndexPath:(NSIndexPath * _Nonnull)indexPath __attribute__((deprecated("Implement -tableNode:didSelectRowAtIndexPath: instead.")));
        [Export ("tableView:didSelectRowAtIndexPath:")]
        void DidSelectRowAtIndexPath (UITableView tableView, NSIndexPath indexPath);

        // @optional -(void)tableView:(UITableView * _Nonnull)tableView didDeselectRowAtIndexPath:(NSIndexPath * _Nonnull)indexPath __attribute__((deprecated("Implement -tableNode:didDeselectRowAtIndexPath: instead.")));
        [Export ("tableView:didDeselectRowAtIndexPath:")]
        void DidDeselectRowAtIndexPath (UITableView tableView, NSIndexPath indexPath);

        // @optional -(UITableViewCellEditingStyle)tableView:(UITableView * _Nonnull)tableView editingStyleForRowAtIndexPath:(NSIndexPath * _Nonnull)indexPath;
        [Export ("tableView:editingStyleForRowAtIndexPath:")]
        UITableViewCellEditingStyle EditingStyleForRowAtIndexPath (UITableView tableView, NSIndexPath indexPath);

        // @optional -(NSString * _Nullable)tableView:(UITableView * _Nonnull)tableView titleForDeleteConfirmationButtonForRowAtIndexPath:(NSIndexPath * _Nonnull)indexPath;
        [Export ("tableView:titleForDeleteConfirmationButtonForRowAtIndexPath:")]
        [return: NullAllowed]
        string TitleForDeleteConfirmationButtonForRowAtIndexPath (UITableView tableView, NSIndexPath indexPath);

        // @optional -(NSArray<UITableViewRowAction *> * _Nullable)tableView:(UITableView * _Nonnull)tableView editActionsForRowAtIndexPath:(NSIndexPath * _Nonnull)indexPath;
        [Export ("tableView:editActionsForRowAtIndexPath:")]
        [return: NullAllowed]
        UITableViewRowAction[] EditActionsForRowAtIndexPath (UITableView tableView, NSIndexPath indexPath);

        // @optional -(BOOL)tableView:(UITableView * _Nonnull)tableView shouldIndentWhileEditingRowAtIndexPath:(NSIndexPath * _Nonnull)indexPath;
        [Export ("tableView:shouldIndentWhileEditingRowAtIndexPath:")]
        bool ShouldIndentWhileEditingRowAtIndexPath (UITableView tableView, NSIndexPath indexPath);

        // @optional -(void)tableView:(UITableView * _Nonnull)tableView willBeginEditingRowAtIndexPath:(NSIndexPath * _Nonnull)indexPath;
        [Export ("tableView:willBeginEditingRowAtIndexPath:")]
        void WillBeginEditingRowAtIndexPath (UITableView tableView, NSIndexPath indexPath);

        // @optional -(void)tableView:(UITableView * _Nonnull)tableView didEndEditingRowAtIndexPath:(NSIndexPath * _Nonnull)indexPath;
        [Export ("tableView:didEndEditingRowAtIndexPath:")]
        void DidEndEditingRowAtIndexPath (UITableView tableView, NSIndexPath indexPath);

        // @optional -(NSIndexPath * _Nonnull)tableView:(UITableView * _Nonnull)tableView targetIndexPathForMoveFromRowAtIndexPath:(NSIndexPath * _Nonnull)sourceIndexPath toProposedIndexPath:(NSIndexPath * _Nonnull)proposedDestinationIndexPath;
        [Export ("tableView:targetIndexPathForMoveFromRowAtIndexPath:toProposedIndexPath:")]
        NSIndexPath TargetIndexPathForMoveFromRowAtIndexPath (UITableView tableView, NSIndexPath sourceIndexPath, NSIndexPath proposedDestinationIndexPath);

        // @optional -(NSInteger)tableView:(UITableView * _Nonnull)tableView indentationLevelForRowAtIndexPath:(NSIndexPath * _Nonnull)indexPath;
        [Export ("tableView:indentationLevelForRowAtIndexPath:")]
        nint IndentationLevelForRowAtIndexPath (UITableView tableView, NSIndexPath indexPath);

        // @optional -(BOOL)tableView:(UITableView * _Nonnull)tableView shouldShowMenuForRowAtIndexPath:(NSIndexPath * _Nonnull)indexPath __attribute__((deprecated("Implement -tableNode:shouldShowMenuForRowAtIndexPath: instead.")));
        [Export ("tableView:shouldShowMenuForRowAtIndexPath:")]
        bool ShouldShowMenuForRowAtIndexPath (UITableView tableView, NSIndexPath indexPath);

        // @optional -(BOOL)tableView:(UITableView * _Nonnull)tableView canPerformAction:(SEL _Nonnull)action forRowAtIndexPath:(NSIndexPath * _Nonnull)indexPath withSender:(id _Nullable)sender __attribute__((deprecated("Implement -tableNode:canPerformAction:forRowAtIndexPath:withSender: instead.")));
        [Export ("tableView:canPerformAction:forRowAtIndexPath:withSender:")]
        bool CanPerformAction (UITableView tableView, Selector action, NSIndexPath indexPath, [NullAllowed] NSObject sender);

        // @optional -(void)tableView:(UITableView * _Nonnull)tableView performAction:(SEL _Nonnull)action forRowAtIndexPath:(NSIndexPath * _Nonnull)indexPath withSender:(id _Nullable)sender __attribute__((deprecated("Implement -tableNode:performAction:forRowAtIndexPath:withSender: instead.")));
        [Export ("tableView:performAction:forRowAtIndexPath:withSender:")]
        void PerformAction (UITableView tableView, Selector action, NSIndexPath indexPath, [NullAllowed] NSObject sender);
    }

    interface IASCommonTableViewDelegate {}

    // @interface ASTableView : UITableView
    [BaseType (typeof(UITableView))]
    interface ASTableView
    {
        // @property (readonly, nonatomic, weak) ASTableNode * _Nullable tableNode;
        [NullAllowed, Export ("tableNode", ArgumentSemantic.Weak)]
        ASTableNode TableNode { get; }

        // -(ASCellNode * _Nullable)nodeForRowAtIndexPath:(NSIndexPath * _Nonnull)indexPath __attribute__((warn_unused_result));
        [Export ("nodeForRowAtIndexPath:")]
        [return: NullAllowed]
        ASCellNode NodeForRowAtIndexPath (NSIndexPath indexPath);
    }

    //// @interface Deprecated (ASTableView)
    //[Category]
    //[BaseType (typeof(ASTableView))]
    //interface ASTableView_Deprecated
    //{
    //    [Wrap ("WeakAsyncDelegate")]
    //    [NullAllowed]
    //    ASTableDelegate AsyncDelegate { get; set; }

    //    // @property (nonatomic, weak) id<ASTableDelegate> _Nullable asyncDelegate __attribute__((deprecated("Use ASTableNode's .delegate property instead.")));
    //    [NullAllowed, Export ("asyncDelegate", ArgumentSemantic.Weak)]
    //    NSObject WeakAsyncDelegate { get; set; }

    //    // @property (nonatomic, weak) id<ASTableDataSource> _Nullable asyncDataSource __attribute__((deprecated("Use ASTableNode .dataSource property instead.")));
    //    [NullAllowed, Export ("asyncDataSource", ArgumentSemantic.Weak)]
    //    ASTableDataSource AsyncDataSource { get; set; }

    //    // -(instancetype _Nonnull)initWithFrame:(CGRect)frame style:(UITableViewStyle)style __attribute__((deprecated("Please use ASTableNode instead of ASTableView.")));
    //    [Export ("initWithFrame:style:")]
    //    IntPtr Constructor (CGRect frame, UITableViewStyle style);

    //    // @property (assign, nonatomic) CGFloat leadingScreensForBatching __attribute__((deprecated("Use ASTableNode property instead.")));
    //    [Export ("leadingScreensForBatching")]
    //    nfloat LeadingScreensForBatching { get; set; }

    //    // @property (assign, nonatomic) UIEdgeInsets contentInset __attribute__((deprecated("Use ASTableNode property instead")));
    //    [Export ("contentInset", ArgumentSemantic.Assign)]
    //    UIEdgeInsets ContentInset { get; set; }

    //    // @property (assign, nonatomic) CGPoint contentOffset __attribute__((deprecated("Use ASTableNode property instead.")));
    //    [Export ("contentOffset", ArgumentSemantic.Assign)]
    //    CGPoint ContentOffset { get; set; }

    //    // @property (nonatomic) BOOL automaticallyAdjustsContentOffset __attribute__((deprecated("Use ASTableNode property instead.")));
    //    [Export ("automaticallyAdjustsContentOffset")]
    //    bool AutomaticallyAdjustsContentOffset { get; set; }

    //    // @property (assign, nonatomic) BOOL inverted __attribute__((deprecated("Use ASTableNode property instead.")));
    //    [Export ("inverted")]
    //    bool Inverted { get; set; }

    //    // @property (readonly, nonatomic) NSIndexPath * _Nullable indexPathForSelectedRow __attribute__((deprecated("Use ASTableNode property instead.")));
    //    [NullAllowed, Export ("indexPathForSelectedRow")]
    //    NSIndexPath IndexPathForSelectedRow { get; }

    //    // @property (readonly, nonatomic) NSArray<NSIndexPath *> * _Nullable indexPathsForSelectedRows __attribute__((deprecated("Use ASTableNode property instead.")));
    //    [NullAllowed, Export ("indexPathsForSelectedRows")]
    //    NSIndexPath[] IndexPathsForSelectedRows { get; }

    //    // @property (readonly, nonatomic) NSArray<NSIndexPath *> * _Nullable indexPathsForVisibleRows __attribute__((deprecated("Use ASTableNode property instead.")));
    //    [NullAllowed, Export ("indexPathsForVisibleRows")]
    //    NSIndexPath[] IndexPathsForVisibleRows { get; }

    //    // -(ASRangeTuningParameters)tuningParametersForRangeType:(ASLayoutRangeType)rangeType __attribute__((deprecated("Use ASTableNode method instead."))) __attribute__((warn_unused_result));
    //    [Export ("tuningParametersForRangeType:")]
    //    ASRangeTuningParameters TuningParametersForRangeType (ASLayoutRangeType rangeType);

    //    // -(void)setTuningParameters:(ASRangeTuningParameters)tuningParameters forRangeType:(ASLayoutRangeType)rangeType __attribute__((deprecated("Use ASTableNode method instead.")));
    //    [Export ("setTuningParameters:forRangeType:")]
    //    void SetTuningParameters (ASRangeTuningParameters tuningParameters, ASLayoutRangeType rangeType);

    //    // -(ASRangeTuningParameters)tuningParametersForRangeMode:(ASLayoutRangeMode)rangeMode rangeType:(ASLayoutRangeType)rangeType __attribute__((deprecated("Use ASTableNode method instead."))) __attribute__((warn_unused_result));
    //    [Export ("tuningParametersForRangeMode:rangeType:")]
    //    ASRangeTuningParameters TuningParametersForRangeMode (ASLayoutRangeMode rangeMode, ASLayoutRangeType rangeType);

    //    // -(void)setTuningParameters:(ASRangeTuningParameters)tuningParameters forRangeMode:(ASLayoutRangeMode)rangeMode rangeType:(ASLayoutRangeType)rangeType __attribute__((deprecated("Use ASTableNode method instead.")));
    //    [Export ("setTuningParameters:forRangeMode:rangeType:")]
    //    void SetTuningParameters (ASRangeTuningParameters tuningParameters, ASLayoutRangeMode rangeMode, ASLayoutRangeType rangeType);

    //    // -(__kindof UITableViewCell * _Nullable)cellForRowAtIndexPath:(NSIndexPath * _Nonnull)indexPath __attribute__((deprecated("Use ASTableNode method instead.")));
    //    [Export ("cellForRowAtIndexPath:")]
    //    UITableViewCell CellForRowAtIndexPath (NSIndexPath indexPath);

    //    // -(void)scrollToRowAtIndexPath:(NSIndexPath * _Nonnull)indexPath atScrollPosition:(UITableViewScrollPosition)scrollPosition animated:(BOOL)animated __attribute__((deprecated("Use ASTableNode method instead.")));
    //    [Export ("scrollToRowAtIndexPath:atScrollPosition:animated:")]
    //    void ScrollToRowAtIndexPath (NSIndexPath indexPath, UITableViewScrollPosition scrollPosition, bool animated);

    //    // -(void)selectRowAtIndexPath:(NSIndexPath * _Nonnull)indexPath animated:(BOOL)animated scrollPosition:(UITableViewScrollPosition)scrollPosition __attribute__((deprecated("Use ASTableNode method instead.")));
    //    [Export ("selectRowAtIndexPath:animated:scrollPosition:")]
    //    void SelectRowAtIndexPath (NSIndexPath indexPath, bool animated, UITableViewScrollPosition scrollPosition);

    //    // -(NSIndexPath * _Nullable)indexPathForRowAtPoint:(CGPoint)point __attribute__((deprecated("Use ASTableNode method instead.")));
    //    [Export ("indexPathForRowAtPoint:")]
    //    [return: NullAllowed]
    //    NSIndexPath IndexPathForRowAtPoint (CGPoint point);

    //    // -(NSArray<NSIndexPath *> * _Nullable)indexPathsForRowsInRect:(CGRect)rect __attribute__((deprecated("Use ASTableNode method instead.")));
    //    [Export ("indexPathsForRowsInRect:")]
    //    [return: NullAllowed]
    //    NSIndexPath[] IndexPathsForRowsInRect (CGRect rect);

    //    // -(NSArray<ASCellNode *> * _Nonnull)visibleNodes __attribute__((deprecated("Use ASTableNode method instead."))) __attribute__((warn_unused_result));
    //    [Export ("visibleNodes")]
    //    [Verify (MethodToProperty)]
    //    ASCellNode[] VisibleNodes { get; }

    //    // -(NSIndexPath * _Nullable)indexPathForNode:(ASCellNode * _Nonnull)cellNode __attribute__((deprecated("Use ASTableNode method instead."))) __attribute__((warn_unused_result));
    //    [Export ("indexPathForNode:")]
    //    [return: NullAllowed]
    //    NSIndexPath IndexPathForNode (ASCellNode cellNode);

    //    // -(void)reloadDataWithCompletion:(void (^ _Nullable)())completion __attribute__((deprecated("Use ASTableNode method instead.")));
    //    [Export ("reloadDataWithCompletion:")]
    //    void ReloadDataWithCompletion ([NullAllowed] Action completion);

    //    // -(void)reloadData __attribute__((deprecated("Use ASTableNode method instead.")));
    //    [Export ("reloadData")]
    //    void ReloadData ();

    //    // -(void)relayoutItems __attribute__((deprecated("Use ASTableNode method instead.")));
    //    [Export ("relayoutItems")]
    //    void RelayoutItems ();

    //    // -(void)beginUpdates __attribute__((deprecated("Use ASTableNode's -performBatchUpdates:completion: instead.")));
    //    [Export ("beginUpdates")]
    //    void BeginUpdates ();

    //    // -(void)endUpdates __attribute__((deprecated("Use ASTableNode's -performBatchUpdates:completion: instead.")));
    //    [Export ("endUpdates")]
    //    void EndUpdates ();

    //    // -(void)endUpdatesAnimated:(BOOL)animated completion:(void (^ _Nullable)(BOOL))completion __attribute__((deprecated("Use ASTableNode's -performBatchUpdates:completion: instead.")));
    //    [Export ("endUpdatesAnimated:completion:")]
    //    void EndUpdatesAnimated (bool animated, [NullAllowed] Action<bool> completion);

    //    // @property (readonly, nonatomic) BOOL isProcessingUpdates;
    //    [Export ("isProcessingUpdates")]
    //    bool IsProcessingUpdates { get; }

    //    // -(void)onDidFinishProcessingUpdates:(void (^ _Nullable)())completion;
    //    [Export ("onDidFinishProcessingUpdates:")]
    //    void OnDidFinishProcessingUpdates ([NullAllowed] Action completion);

    //    // -(void)waitUntilAllUpdatesAreCommitted __attribute__((deprecated("Use -[ASTableNode waitUntilAllUpdatesAreProcessed] instead.")));
    //    [Export ("waitUntilAllUpdatesAreCommitted")]
    //    void WaitUntilAllUpdatesAreCommitted ();

    //    // -(void)insertSections:(NSIndexSet * _Nonnull)sections withRowAnimation:(UITableViewRowAnimation)animation __attribute__((deprecated("Use ASTableNode method instead.")));
    //    [Export ("insertSections:withRowAnimation:")]
    //    void InsertSections (NSIndexSet sections, UITableViewRowAnimation animation);

    //    // -(void)deleteSections:(NSIndexSet * _Nonnull)sections withRowAnimation:(UITableViewRowAnimation)animation __attribute__((deprecated("Use ASTableNode method instead.")));
    //    [Export ("deleteSections:withRowAnimation:")]
    //    void DeleteSections (NSIndexSet sections, UITableViewRowAnimation animation);

    //    // -(void)reloadSections:(NSIndexSet * _Nonnull)sections withRowAnimation:(UITableViewRowAnimation)animation __attribute__((deprecated("Use ASTableNode method instead.")));
    //    [Export ("reloadSections:withRowAnimation:")]
    //    void ReloadSections (NSIndexSet sections, UITableViewRowAnimation animation);

    //    // -(void)moveSection:(NSInteger)section toSection:(NSInteger)newSection __attribute__((deprecated("Use ASTableNode method instead.")));
    //    [Export ("moveSection:toSection:")]
    //    void MoveSection (nint section, nint newSection);

    //    // -(void)insertRowsAtIndexPaths:(NSArray<NSIndexPath *> * _Nonnull)indexPaths withRowAnimation:(UITableViewRowAnimation)animation __attribute__((deprecated("Use ASTableNode method instead.")));
    //    [Export ("insertRowsAtIndexPaths:withRowAnimation:")]
    //    void InsertRowsAtIndexPaths (NSIndexPath[] indexPaths, UITableViewRowAnimation animation);

    //    // -(void)deleteRowsAtIndexPaths:(NSArray<NSIndexPath *> * _Nonnull)indexPaths withRowAnimation:(UITableViewRowAnimation)animation __attribute__((deprecated("Use ASTableNode method instead.")));
    //    [Export ("deleteRowsAtIndexPaths:withRowAnimation:")]
    //    void DeleteRowsAtIndexPaths (NSIndexPath[] indexPaths, UITableViewRowAnimation animation);

    //    // -(void)reloadRowsAtIndexPaths:(NSArray<NSIndexPath *> * _Nonnull)indexPaths withRowAnimation:(UITableViewRowAnimation)animation __attribute__((deprecated("Use ASTableNode method instead.")));
    //    [Export ("reloadRowsAtIndexPaths:withRowAnimation:")]
    //    void ReloadRowsAtIndexPaths (NSIndexPath[] indexPaths, UITableViewRowAnimation animation);

    //    // -(void)moveRowAtIndexPath:(NSIndexPath * _Nonnull)indexPath toIndexPath:(NSIndexPath * _Nonnull)newIndexPath __attribute__((deprecated("Use ASTableNode method instead.")));
    //    [Export ("moveRowAtIndexPath:toIndexPath:")]
    //    void MoveRowAtIndexPath (NSIndexPath indexPath, NSIndexPath newIndexPath);

    //    // -(void)setContentOffset:(CGPoint)contentOffset animated:(BOOL)animated __attribute__((deprecated("Use ASTableNode method instead.")));
    //    [Export ("setContentOffset:animated:")]
    //    void SetContentOffset (CGPoint contentOffset, bool animated);
    //}

    // @protocol ASTableViewDataSource <ASTableDataSource>
    [Protocol, Model]
    interface ASTableViewDataSource
    {
    }

    // @protocol ASTableViewDelegate <ASTableDelegate>
    [Protocol, Model]
    interface ASTableViewDelegate
    {
    }

    // @protocol ASRangeControllerUpdateRangeProtocol <NSObject>
    [Protocol, Model]
    [BaseType (typeof(NSObject))]
    interface ASRangeControllerUpdateRangeProtocol
    {
        // @required -(void)updateCurrentRangeWithMode:(ASLayoutRangeMode)rangeMode;
        [Abstract]
        [Export ("updateCurrentRangeWithMode:")]
        void UpdateCurrentRangeWithMode (ASLayoutRangeMode rangeMode);
    }

    interface IASRangeControllerUpdateRangeProtocol {} 

    // @protocol ASRangeManagingNode <NSObject, ASTraitEnvironment>
    [Protocol, Model]
    [BaseType (typeof(NSObject))]
    interface ASRangeManagingNode : ASTraitEnvironment
    {
        // @required -(NSIndexPath * _Nullable)indexPathForNode:(ASCellNode * _Nonnull)node;
        [Abstract]
        [Export ("indexPathForNode:")]
        [return: NullAllowed]
        NSIndexPath IndexPathForNode (ASCellNode node);
    }

    interface IASRangeManagingNode {}

    // @interface ASTableNode : ASDisplayNode <ASRangeControllerUpdateRangeProtocol, ASRangeManagingNode>
    [BaseType (typeof(ASDisplayNode))]
    interface ASTableNode : ASRangeControllerUpdateRangeProtocol, ASRangeManagingNode
    {
        // -(instancetype _Nonnull)initWithStyle:(UITableViewStyle)style __attribute__((objc_designated_initializer));
        [Export ("initWithStyle:")]
        [DesignatedInitializer]
        IntPtr Constructor (UITableViewStyle style);

        // @property (readonly, nonatomic, strong) ASTableView * _Nonnull view;
        [Export ("view", ArgumentSemantic.Strong)]
        ASTableView View { get; }

        [Wrap ("WeakDelegate")]
        [NullAllowed]
        ASTableDelegate Delegate { get; set; }

        // @property (nonatomic, weak) id<ASTableDelegate> _Nullable delegate;
        [NullAllowed, Export ("delegate", ArgumentSemantic.Weak)]
        NSObject WeakDelegate { get; set; }

        // @property (nonatomic, weak) id<ASTableDataSource> _Nullable dataSource;
        [NullAllowed, Export ("dataSource", ArgumentSemantic.Weak)]
        ASTableDataSource DataSource { get; set; }

        // @property (assign, nonatomic) CGFloat leadingScreensForBatching;
        [Export ("leadingScreensForBatching")]
        nfloat LeadingScreensForBatching { get; set; }

        // @property (assign, nonatomic) BOOL inverted;
        [Export ("inverted")]
        bool Inverted { get; set; }

        // @property (assign, nonatomic) UIEdgeInsets contentInset;
        [Export ("contentInset", ArgumentSemantic.Assign)]
        UIEdgeInsets ContentInset { get; set; }

        // @property (assign, nonatomic) CGPoint contentOffset;
        [Export ("contentOffset", ArgumentSemantic.Assign)]
        CGPoint ContentOffset { get; set; }

        // -(void)setContentOffset:(CGPoint)contentOffset animated:(BOOL)animated;
        [Export ("setContentOffset:animated:")]
        void SetContentOffset (CGPoint contentOffset, bool animated);

        // @property (assign, nonatomic) BOOL automaticallyAdjustsContentOffset;
        [Export ("automaticallyAdjustsContentOffset")]
        bool AutomaticallyAdjustsContentOffset { get; set; }

        // @property (assign, nonatomic) BOOL allowsSelection;
        [Export ("allowsSelection")]
        bool AllowsSelection { get; set; }

        // @property (assign, nonatomic) BOOL allowsSelectionDuringEditing;
        [Export ("allowsSelectionDuringEditing")]
        bool AllowsSelectionDuringEditing { get; set; }

        // @property (assign, nonatomic) BOOL allowsMultipleSelection;
        [Export ("allowsMultipleSelection")]
        bool AllowsMultipleSelection { get; set; }

        // @property (assign, nonatomic) BOOL allowsMultipleSelectionDuringEditing;
        [Export ("allowsMultipleSelectionDuringEditing")]
        bool AllowsMultipleSelectionDuringEditing { get; set; }

        // -(ASRangeTuningParameters)tuningParametersForRangeType:(ASLayoutRangeType)rangeType __attribute__((warn_unused_result));
        [Export ("tuningParametersForRangeType:")]
        ASRangeTuningParameters TuningParametersForRangeType (ASLayoutRangeType rangeType);

        // -(void)setTuningParameters:(ASRangeTuningParameters)tuningParameters forRangeType:(ASLayoutRangeType)rangeType;
        [Export ("setTuningParameters:forRangeType:")]
        void SetTuningParameters (ASRangeTuningParameters tuningParameters, ASLayoutRangeType rangeType);

        // -(ASRangeTuningParameters)tuningParametersForRangeMode:(ASLayoutRangeMode)rangeMode rangeType:(ASLayoutRangeType)rangeType __attribute__((warn_unused_result));
        [Export ("tuningParametersForRangeMode:rangeType:")]
        ASRangeTuningParameters TuningParametersForRangeMode (ASLayoutRangeMode rangeMode, ASLayoutRangeType rangeType);

        // -(void)setTuningParameters:(ASRangeTuningParameters)tuningParameters forRangeMode:(ASLayoutRangeMode)rangeMode rangeType:(ASLayoutRangeType)rangeType;
        [Export ("setTuningParameters:forRangeMode:rangeType:")]
        void SetTuningParameters (ASRangeTuningParameters tuningParameters, ASLayoutRangeMode rangeMode, ASLayoutRangeType rangeType);

        // -(void)scrollToRowAtIndexPath:(NSIndexPath * _Nonnull)indexPath atScrollPosition:(UITableViewScrollPosition)scrollPosition animated:(BOOL)animated;
        [Export ("scrollToRowAtIndexPath:atScrollPosition:animated:")]
        void ScrollToRowAtIndexPath (NSIndexPath indexPath, UITableViewScrollPosition scrollPosition, bool animated);

        // -(void)reloadDataWithCompletion:(void (^ _Nullable)())completion;
        [Export ("reloadDataWithCompletion:")]
        void ReloadDataWithCompletion ([NullAllowed] Action completion);

        // -(void)reloadData;
        [Export ("reloadData")]
        void ReloadData ();

        // -(void)relayoutItems;
        [Export ("relayoutItems")]
        void RelayoutItems ();

        // -(void)performBatchAnimated:(BOOL)animated updates:(void (^ _Nullable)())updates completion:(void (^ _Nullable)(BOOL))completion;
        [Export ("performBatchAnimated:updates:completion:")]
        void PerformBatchAnimated (bool animated, [NullAllowed] Action updates, [NullAllowed] Action<bool> completion);

        // -(void)performBatchUpdates:(void (^ _Nullable)())updates completion:(void (^ _Nullable)(BOOL))completion;
        [Export ("performBatchUpdates:completion:")]
        void PerformBatchUpdates ([NullAllowed] Action updates, [NullAllowed] Action<bool> completion);

        // @property (readonly, nonatomic) BOOL isProcessingUpdates;
        [Export ("isProcessingUpdates")]
        bool IsProcessingUpdates { get; }

        // -(void)onDidFinishProcessingUpdates:(void (^ _Nullable)())didFinishProcessingUpdates;
        [Export ("onDidFinishProcessingUpdates:")]
        void OnDidFinishProcessingUpdates ([NullAllowed] Action didFinishProcessingUpdates);

        // -(void)waitUntilAllUpdatesAreProcessed;
        [Export ("waitUntilAllUpdatesAreProcessed")]
        void WaitUntilAllUpdatesAreProcessed ();

        // -(void)insertSections:(NSIndexSet * _Nonnull)sections withRowAnimation:(UITableViewRowAnimation)animation;
        [Export ("insertSections:withRowAnimation:")]
        void InsertSections (NSIndexSet sections, UITableViewRowAnimation animation);

        // -(void)deleteSections:(NSIndexSet * _Nonnull)sections withRowAnimation:(UITableViewRowAnimation)animation;
        [Export ("deleteSections:withRowAnimation:")]
        void DeleteSections (NSIndexSet sections, UITableViewRowAnimation animation);

        // -(void)reloadSections:(NSIndexSet * _Nonnull)sections withRowAnimation:(UITableViewRowAnimation)animation;
        [Export ("reloadSections:withRowAnimation:")]
        void ReloadSections (NSIndexSet sections, UITableViewRowAnimation animation);

        // -(void)moveSection:(NSInteger)section toSection:(NSInteger)newSection;
        [Export ("moveSection:toSection:")]
        void MoveSection (nint section, nint newSection);

        // -(void)insertRowsAtIndexPaths:(NSArray<NSIndexPath *> * _Nonnull)indexPaths withRowAnimation:(UITableViewRowAnimation)animation;
        [Export ("insertRowsAtIndexPaths:withRowAnimation:")]
        void InsertRowsAtIndexPaths (NSIndexPath[] indexPaths, UITableViewRowAnimation animation);

        // -(void)deleteRowsAtIndexPaths:(NSArray<NSIndexPath *> * _Nonnull)indexPaths withRowAnimation:(UITableViewRowAnimation)animation;
        [Export ("deleteRowsAtIndexPaths:withRowAnimation:")]
        void DeleteRowsAtIndexPaths (NSIndexPath[] indexPaths, UITableViewRowAnimation animation);

        // -(void)reloadRowsAtIndexPaths:(NSArray<NSIndexPath *> * _Nonnull)indexPaths withRowAnimation:(UITableViewRowAnimation)animation;
        [Export ("reloadRowsAtIndexPaths:withRowAnimation:")]
        void ReloadRowsAtIndexPaths (NSIndexPath[] indexPaths, UITableViewRowAnimation animation);

        // -(void)moveRowAtIndexPath:(NSIndexPath * _Nonnull)indexPath toIndexPath:(NSIndexPath * _Nonnull)newIndexPath;
        [Export ("moveRowAtIndexPath:toIndexPath:")]
        void MoveRowAtIndexPath (NSIndexPath indexPath, NSIndexPath newIndexPath);

        // -(void)selectRowAtIndexPath:(NSIndexPath * _Nullable)indexPath animated:(BOOL)animated scrollPosition:(UITableViewScrollPosition)scrollPosition;
        [Export ("selectRowAtIndexPath:animated:scrollPosition:")]
        void SelectRowAtIndexPath ([NullAllowed] NSIndexPath indexPath, bool animated, UITableViewScrollPosition scrollPosition);

        // -(void)deselectRowAtIndexPath:(NSIndexPath * _Nonnull)indexPath animated:(BOOL)animated;
        [Export ("deselectRowAtIndexPath:animated:")]
        void DeselectRowAtIndexPath (NSIndexPath indexPath, bool animated);

        // -(NSInteger)numberOfRowsInSection:(NSInteger)section __attribute__((warn_unused_result));
        [Export ("numberOfRowsInSection:")]
        nint NumberOfRowsInSection (nint section);

        // @property (readonly, nonatomic) NSInteger numberOfSections;
        [Export ("numberOfSections")]
        nint NumberOfSections { get; }

        // @property (readonly, nonatomic) NSArray<__kindof ASCellNode *> * _Nonnull visibleNodes;
        [Export ("visibleNodes")]
        ASCellNode[] VisibleNodes { get; }

        // -(__kindof ASCellNode * _Nullable)nodeForRowAtIndexPath:(NSIndexPath * _Nonnull)indexPath __attribute__((warn_unused_result));
        [Export ("nodeForRowAtIndexPath:")]
        ASCellNode NodeForRowAtIndexPath (NSIndexPath indexPath);

        //// -(NSIndexPath * _Nullable)indexPathForNode:(ASCellNode * _Nonnull)cellNode __attribute__((warn_unused_result));
        //[Export ("indexPathForNode:")]
        //[return: NullAllowed]
        //NSIndexPath IndexPathForNode (ASCellNode cellNode);

        // -(CGRect)rectForRowAtIndexPath:(NSIndexPath * _Nonnull)indexPath __attribute__((warn_unused_result));
        [Export ("rectForRowAtIndexPath:")]
        CGRect RectForRowAtIndexPath (NSIndexPath indexPath);

        // -(__kindof UITableViewCell * _Nullable)cellForRowAtIndexPath:(NSIndexPath * _Nonnull)indexPath __attribute__((warn_unused_result));
        [Export ("cellForRowAtIndexPath:")]
        UITableViewCell CellForRowAtIndexPath (NSIndexPath indexPath);

        // @property (readonly, nonatomic) NSIndexPath * _Nullable indexPathForSelectedRow;
        [NullAllowed, Export ("indexPathForSelectedRow")]
        NSIndexPath IndexPathForSelectedRow { get; }

        // @property (readonly, nonatomic) NSArray<NSIndexPath *> * _Nullable indexPathsForSelectedRows;
        [NullAllowed, Export ("indexPathsForSelectedRows")]
        NSIndexPath[] IndexPathsForSelectedRows { get; }

        // -(NSIndexPath * _Nullable)indexPathForRowAtPoint:(CGPoint)point __attribute__((warn_unused_result));
        [Export ("indexPathForRowAtPoint:")]
        [return: NullAllowed]
        NSIndexPath IndexPathForRowAtPoint (CGPoint point);

        // -(NSArray<NSIndexPath *> * _Nullable)indexPathsForRowsInRect:(CGRect)rect __attribute__((warn_unused_result));
        [Export ("indexPathsForRowsInRect:")]
        [return: NullAllowed]
        NSIndexPath[] IndexPathsForRowsInRect (CGRect rect);

        // -(NSArray<NSIndexPath *> * _Nonnull)indexPathsForVisibleRows __attribute__((warn_unused_result));
        [Export ("indexPathsForVisibleRows")]
        //[Verify (MethodToProperty)]
        NSIndexPath[] IndexPathsForVisibleRows { get; }
    }

    // @protocol ASTableDataSource <ASCommonTableDataSource, NSObject>
    [Protocol, Model]
    [BaseType (typeof(NSObject))]
    interface ASTableDataSource : ASCommonTableDataSource
    {
        // @optional -(NSInteger)numberOfSectionsInTableNode:(ASTableNode * _Nonnull)tableNode;
        [Export ("numberOfSectionsInTableNode:")]
        nint NumberOfSectionsInTableNode (ASTableNode tableNode);

        // @optional -(NSInteger)tableNode:(ASTableNode * _Nonnull)tableNode numberOfRowsInSection:(NSInteger)section;
        [Export ("tableNode:numberOfRowsInSection:")]
        nint NumberOfRowsInSection (ASTableNode tableNode, nint section);

        // @optional -(ASCellNodeBlock _Nonnull)tableNode:(ASTableNode * _Nonnull)tableNode nodeBlockForRowAtIndexPath:(NSIndexPath * _Nonnull)indexPath;
        [Export ("tableNode:nodeBlockForRowAtIndexPath:")]
        ASCellNodeBlock NodeBlockForRowAtIndexPath (ASTableNode tableNode, NSIndexPath indexPath);

        // @optional -(ASCellNode * _Nonnull)tableNode:(ASTableNode * _Nonnull)tableNode nodeForRowAtIndexPath:(NSIndexPath * _Nonnull)indexPath;
        [Export ("tableNode:nodeForRowAtIndexPath:")]
        ASCellNode NodeForRowAtIndexPath (ASTableNode tableNode, NSIndexPath indexPath);

        // @optional -(ASCellNode * _Nonnull)tableView:(ASTableView * _Nonnull)tableView nodeForRowAtIndexPath:(NSIndexPath * _Nonnull)indexPath __attribute__((deprecated("Use ASTableNode's method instead."))) __attribute__((warn_unused_result));
        [Export ("tableView:nodeForRowAtIndexPath:")]
        ASCellNode NodeForRowAtIndexPath (ASTableView tableView, NSIndexPath indexPath);

        // @optional -(ASCellNodeBlock _Nonnull)tableView:(ASTableView * _Nonnull)tableView nodeBlockForRowAtIndexPath:(NSIndexPath * _Nonnull)indexPath __attribute__((deprecated("Use ASTableNode's method instead."))) __attribute__((warn_unused_result));
        [Export ("tableView:nodeBlockForRowAtIndexPath:")]
        ASCellNodeBlock NodeBlockForRowAtIndexPath (ASTableView tableView, NSIndexPath indexPath);

        // @optional -(void)tableViewLockDataSource:(ASTableView * _Nonnull)tableView __attribute__((deprecated("Data source accesses are on the main thread. Method will not be called.")));
        [Export ("tableViewLockDataSource:")]
        void TableViewLockDataSource (ASTableView tableView);

        // @optional -(void)tableViewUnlockDataSource:(ASTableView * _Nonnull)tableView __attribute__((deprecated("Data source accesses are on the main thread. Method will not be called.")));
        [Export ("tableViewUnlockDataSource:")]
        void TableViewUnlockDataSource (ASTableView tableView);
    }

    // @protocol ASTableDelegate <ASCommonTableViewDelegate, NSObject>
    [Protocol, Model]
    [BaseType (typeof(NSObject))]
    interface ASTableDelegate : ASCommonTableViewDelegate
    {
        // @optional -(void)tableNode:(ASTableNode * _Nonnull)tableNode willDisplayRowWithNode:(ASCellNode * _Nonnull)node;
        [Export ("tableNode:willDisplayRowWithNode:")]
        void WillDisplayRowWithNode (ASTableNode tableNode, ASCellNode node);

        // @optional -(void)tableNode:(ASTableNode * _Nonnull)tableNode didEndDisplayingRowWithNode:(ASCellNode * _Nonnull)node;
        [Export ("tableNode:didEndDisplayingRowWithNode:")]
        void DidEndDisplayingRowWithNode (ASTableNode tableNode, ASCellNode node);

        // @optional -(NSIndexPath * _Nullable)tableNode:(ASTableNode * _Nonnull)tableNode willSelectRowAtIndexPath:(NSIndexPath * _Nonnull)indexPath;
        [Export ("tableNode:willSelectRowAtIndexPath:")]
        [return: NullAllowed]
        NSIndexPath WillSelectRowAtIndexPath (ASTableNode tableNode, NSIndexPath indexPath);

        // @optional -(void)tableNode:(ASTableNode * _Nonnull)tableNode didSelectRowAtIndexPath:(NSIndexPath * _Nonnull)indexPath;
        [Export ("tableNode:didSelectRowAtIndexPath:")]
        void DidSelectRowAtIndexPath (ASTableNode tableNode, NSIndexPath indexPath);

        // @optional -(NSIndexPath * _Nullable)tableNode:(ASTableNode * _Nonnull)tableNode willDeselectRowAtIndexPath:(NSIndexPath * _Nonnull)indexPath;
        [Export ("tableNode:willDeselectRowAtIndexPath:")]
        [return: NullAllowed]
        NSIndexPath WillDeselectRowAtIndexPath (ASTableNode tableNode, NSIndexPath indexPath);

        // @optional -(void)tableNode:(ASTableNode * _Nonnull)tableNode didDeselectRowAtIndexPath:(NSIndexPath * _Nonnull)indexPath;
        [Export ("tableNode:didDeselectRowAtIndexPath:")]
        void DidDeselectRowAtIndexPath (ASTableNode tableNode, NSIndexPath indexPath);

        // @optional -(BOOL)tableNode:(ASTableNode * _Nonnull)tableNode shouldHighlightRowAtIndexPath:(NSIndexPath * _Nonnull)indexPath;
        [Export ("tableNode:shouldHighlightRowAtIndexPath:")]
        bool ShouldHighlightRowAtIndexPath (ASTableNode tableNode, NSIndexPath indexPath);

        // @optional -(void)tableNode:(ASTableNode * _Nonnull)tableNode didHighlightRowAtIndexPath:(NSIndexPath * _Nonnull)indexPath;
        [Export ("tableNode:didHighlightRowAtIndexPath:")]
        void DidHighlightRowAtIndexPath (ASTableNode tableNode, NSIndexPath indexPath);

        // @optional -(void)tableNode:(ASTableNode * _Nonnull)tableNode didUnhighlightRowAtIndexPath:(NSIndexPath * _Nonnull)indexPath;
        [Export ("tableNode:didUnhighlightRowAtIndexPath:")]
        void DidUnhighlightRowAtIndexPath (ASTableNode tableNode, NSIndexPath indexPath);

        // @optional -(BOOL)tableNode:(ASTableNode * _Nonnull)tableNode shouldShowMenuForRowAtIndexPath:(NSIndexPath * _Nonnull)indexPath;
        [Export ("tableNode:shouldShowMenuForRowAtIndexPath:")]
        bool ShouldShowMenuForRowAtIndexPath (ASTableNode tableNode, NSIndexPath indexPath);

        // @optional -(BOOL)tableNode:(ASTableNode * _Nonnull)tableNode canPerformAction:(SEL _Nonnull)action forRowAtIndexPath:(NSIndexPath * _Nonnull)indexPath withSender:(id _Nullable)sender;
        [Export ("tableNode:canPerformAction:forRowAtIndexPath:withSender:")]
        bool CanPerformAction (ASTableNode tableNode, Selector action, NSIndexPath indexPath, [NullAllowed] NSObject sender);

        // @optional -(void)tableNode:(ASTableNode * _Nonnull)tableNode performAction:(SEL _Nonnull)action forRowAtIndexPath:(NSIndexPath * _Nonnull)indexPath withSender:(id _Nullable)sender;
        [Export ("tableNode:performAction:forRowAtIndexPath:withSender:")]
        void PerformAction (ASTableNode tableNode, Selector action, NSIndexPath indexPath, [NullAllowed] NSObject sender);

        // @optional -(ASSizeRange)tableNode:(ASTableNode * _Nonnull)tableNode constrainedSizeForRowAtIndexPath:(NSIndexPath * _Nonnull)indexPath;
        [Export ("tableNode:constrainedSizeForRowAtIndexPath:")]
        ASSizeRange ConstrainedSizeForRowAtIndexPath (ASTableNode tableNode, NSIndexPath indexPath);

        // @optional -(void)tableNode:(ASTableNode * _Nonnull)tableNode willBeginBatchFetchWithContext:(ASBatchContext * _Nonnull)context;
        [Export ("tableNode:willBeginBatchFetchWithContext:")]
        void WillBeginBatchFetchWithContext (ASTableNode tableNode, ASBatchContext context);

        // @optional -(BOOL)shouldBatchFetchForTableNode:(ASTableNode * _Nonnull)tableNode;
        [Export ("shouldBatchFetchForTableNode:")]
        bool ShouldBatchFetchForTableNode (ASTableNode tableNode);

        // @optional -(void)tableView:(ASTableView * _Nonnull)tableView willDisplayNode:(ASCellNode * _Nonnull)node forRowAtIndexPath:(NSIndexPath * _Nonnull)indexPath __attribute__((deprecated("Use ASTableNode's method instead.")));
        [Export ("tableView:willDisplayNode:forRowAtIndexPath:")]
        void WillDisplayNode (ASTableView tableView, ASCellNode node, NSIndexPath indexPath);

        // @optional -(void)tableView:(ASTableView * _Nonnull)tableView didEndDisplayingNode:(ASCellNode * _Nonnull)node forRowAtIndexPath:(NSIndexPath * _Nonnull)indexPath __attribute__((deprecated("Use ASTableNode's method instead.")));
        [Export ("tableView:didEndDisplayingNode:forRowAtIndexPath:")]
        void DidEndDisplayingNode (ASTableView tableView, ASCellNode node, NSIndexPath indexPath);

        // @optional -(void)tableView:(ASTableView * _Nonnull)tableView willBeginBatchFetchWithContext:(ASBatchContext * _Nonnull)context __attribute__((deprecated("Use ASTableNode's method instead.")));
        [Export ("tableView:willBeginBatchFetchWithContext:")]
        void WillBeginBatchFetchWithContext (ASTableView tableView, ASBatchContext context);

        // @optional -(BOOL)shouldBatchFetchForTableView:(ASTableView * _Nonnull)tableView __attribute__((deprecated("Use ASTableNode's method instead."))) __attribute__((warn_unused_result));
        [Export ("shouldBatchFetchForTableView:")]
        bool ShouldBatchFetchForTableView (ASTableView tableView);

        // @optional -(ASSizeRange)tableView:(ASTableView * _Nonnull)tableView constrainedSizeForRowAtIndexPath:(NSIndexPath * _Nonnull)indexPath __attribute__((deprecated("Use ASTableNode's method instead."))) __attribute__((warn_unused_result));
        [Export ("tableView:constrainedSizeForRowAtIndexPath:")]
        ASSizeRange ConstrainedSizeForRowAtIndexPath (ASTableView tableView, NSIndexPath indexPath);

        // @optional -(void)tableView:(ASTableView * _Nonnull)tableView willDisplayNodeForRowAtIndexPath:(NSIndexPath * _Nonnull)indexPath __attribute__((deprecated("Use ASTableNode's method instead.")));
        [Export ("tableView:willDisplayNodeForRowAtIndexPath:")]
        void WillDisplayNodeForRowAtIndexPath (ASTableView tableView, NSIndexPath indexPath);
    }

    interface IASTableDelegate {}

    //// @interface Deprecated (ASTableNode)
    //[Category]
    //[BaseType (typeof(ASTableNode))]
    //interface ASTableNode_Deprecated
    //{
    //    // -(void)waitUntilAllUpdatesAreCommitted __attribute__((deprecated("This method has been renamed to -waitUntilAllUpdatesAreProcessed.")));
    //    [Export ("waitUntilAllUpdatesAreCommitted")]
    //    void WaitUntilAllUpdatesAreCommitted ();
    //}

    //// @protocol ASCommonCollectionDataSource <NSObject>
    //[Protocol, Model]
    //[BaseType (typeof(NSObject))]
    //interface ASCommonCollectionDataSource
    //{
    //    // @optional -(NSInteger)collectionView:(UICollectionView * _Nonnull)collectionView numberOfItemsInSection:(NSInteger)section __attribute__((deprecated("Implement -collectionNode:numberOfItemsInSection: instead.")));
    //    [Export ("collectionView:numberOfItemsInSection:")]
    //    nint CollectionView (UICollectionView collectionView, nint section);

    //    // @optional -(NSInteger)numberOfSectionsInCollectionView:(UICollectionView * _Nonnull)collectionView __attribute__((deprecated("Implement -numberOfSectionsInCollectionNode: instead.")));
    //    [Export ("numberOfSectionsInCollectionView:")]
    //    nint NumberOfSectionsInCollectionView (UICollectionView collectionView);

    //    // @optional -(UICollectionReusableView * _Nonnull)collectionView:(UICollectionView * _Nonnull)collectionView viewForSupplementaryElementOfKind:(NSString * _Nonnull)kind atIndexPath:(NSIndexPath * _Nonnull)indexPath __attribute__((deprecated("Implement - collectionNode:nodeForSupplementaryElementOfKind:atIndexPath: instead.")));
    //    [Export ("collectionView:viewForSupplementaryElementOfKind:atIndexPath:")]
    //    UICollectionReusableView CollectionView (UICollectionView collectionView, string kind, NSIndexPath indexPath);
    //}

    //// @protocol ASCommonCollectionDelegate <NSObject, UIScrollViewDelegate>
    //[Protocol, Model]
    //[BaseType (typeof(NSObject))]
    //interface ASCommonCollectionDelegate : IUIScrollViewDelegate
    //{
    //    // @optional -(UICollectionViewTransitionLayout * _Nonnull)collectionView:(UICollectionView * _Nonnull)collectionView transitionLayoutForOldLayout:(UICollectionViewLayout * _Nonnull)fromLayout newLayout:(UICollectionViewLayout * _Nonnull)toLayout;
    //    [Export ("collectionView:transitionLayoutForOldLayout:newLayout:")]
    //    UICollectionViewTransitionLayout CollectionView (UICollectionView collectionView, UICollectionViewLayout fromLayout, UICollectionViewLayout toLayout);

    //    // @optional -(void)collectionView:(UICollectionView * _Nonnull)collectionView willDisplaySupplementaryView:(UICollectionReusableView * _Nonnull)view forElementKind:(NSString * _Nonnull)elementKind atIndexPath:(NSIndexPath * _Nonnull)indexPath __attribute__((deprecated("Implement -collectionNode:willDisplaySupplementaryView:forElementKind:atIndexPath: instead.")));
    //    [Export ("collectionView:willDisplaySupplementaryView:forElementKind:atIndexPath:")]
    //    void CollectionView (UICollectionView collectionView, UICollectionReusableView view, string elementKind, NSIndexPath indexPath);

    //    // @optional -(void)collectionView:(UICollectionView * _Nonnull)collectionView didEndDisplayingSupplementaryView:(UICollectionReusableView * _Nonnull)view forElementOfKind:(NSString * _Nonnull)elementKind atIndexPath:(NSIndexPath * _Nonnull)indexPath __attribute__((deprecated("Implement -collectionNode:didEndDisplayingSupplementaryView:forElementKind:atIndexPath: instead.")));
    //    [Export ("collectionView:didEndDisplayingSupplementaryView:forElementOfKind:atIndexPath:")]
    //    void CollectionView (UICollectionView collectionView, UICollectionReusableView view, string elementKind, NSIndexPath indexPath);

    //    // @optional -(BOOL)collectionView:(UICollectionView * _Nonnull)collectionView shouldHighlightItemAtIndexPath:(NSIndexPath * _Nonnull)indexPath __attribute__((deprecated("Implement collectionNode:shouldHighlightItemAtIndexPath: instead.")));
    //    [Export ("collectionView:shouldHighlightItemAtIndexPath:")]
    //    bool CollectionView (UICollectionView collectionView, NSIndexPath indexPath);

    //    // @optional -(void)collectionView:(UICollectionView * _Nonnull)collectionView didHighlightItemAtIndexPath:(NSIndexPath * _Nonnull)indexPath __attribute__((deprecated("Implement collectionNode:didHighlightItemAtIndexPath: instead.")));
    //    [Export ("collectionView:didHighlightItemAtIndexPath:")]
    //    void CollectionView (UICollectionView collectionView, NSIndexPath indexPath);

    //    // @optional -(void)collectionView:(UICollectionView * _Nonnull)collectionView didUnhighlightItemAtIndexPath:(NSIndexPath * _Nonnull)indexPath __attribute__((deprecated("Implement collectionNode:didUnhighlightItemAtIndexPath: instead.")));
    //    [Export ("collectionView:didUnhighlightItemAtIndexPath:")]
    //    void CollectionView (UICollectionView collectionView, NSIndexPath indexPath);

    //    // @optional -(BOOL)collectionView:(UICollectionView * _Nonnull)collectionView shouldSelectItemAtIndexPath:(NSIndexPath * _Nonnull)indexPath __attribute__((deprecated("Implement collectionNode:shouldSelectItemAtIndexPath: instead.")));
    //    [Export ("collectionView:shouldSelectItemAtIndexPath:")]
    //    bool CollectionView (UICollectionView collectionView, NSIndexPath indexPath);

    //    // @optional -(void)collectionView:(UICollectionView * _Nonnull)collectionView didSelectItemAtIndexPath:(NSIndexPath * _Nonnull)indexPath __attribute__((deprecated("Implement collectionNode:didSelectItemAtIndexPath: instead.")));
    //    [Export ("collectionView:didSelectItemAtIndexPath:")]
    //    void CollectionView (UICollectionView collectionView, NSIndexPath indexPath);

    //    // @optional -(BOOL)collectionView:(UICollectionView * _Nonnull)collectionView shouldDeselectItemAtIndexPath:(NSIndexPath * _Nonnull)indexPath __attribute__((deprecated("Implement collectionNode:shouldDeselectItemAtIndexPath: instead.")));
    //    [Export ("collectionView:shouldDeselectItemAtIndexPath:")]
    //    bool CollectionView (UICollectionView collectionView, NSIndexPath indexPath);

    //    // @optional -(void)collectionView:(UICollectionView * _Nonnull)collectionView didDeselectItemAtIndexPath:(NSIndexPath * _Nonnull)indexPath __attribute__((deprecated("Implement collectionNode:didDeselectItemAtIndexPath: instead.")));
    //    [Export ("collectionView:didDeselectItemAtIndexPath:")]
    //    void CollectionView (UICollectionView collectionView, NSIndexPath indexPath);

    //    // @optional -(BOOL)collectionView:(UICollectionView * _Nonnull)collectionView shouldShowMenuForItemAtIndexPath:(NSIndexPath * _Nonnull)indexPath __attribute__((deprecated("Implement collectionNode:shouldShowMenuForItemAtIndexPath: instead.")));
    //    [Export ("collectionView:shouldShowMenuForItemAtIndexPath:")]
    //    bool CollectionView (UICollectionView collectionView, NSIndexPath indexPath);

    //    // @optional -(BOOL)collectionView:(UICollectionView * _Nonnull)collectionView canPerformAction:(SEL _Nonnull)action forItemAtIndexPath:(NSIndexPath * _Nonnull)indexPath withSender:(id _Nullable)sender __attribute__((deprecated("Implement collectionNode:canPerformAction:forItemAtIndexPath:withSender: instead.")));
    //    [Export ("collectionView:canPerformAction:forItemAtIndexPath:withSender:")]
    //    bool CollectionView (UICollectionView collectionView, Selector action, NSIndexPath indexPath, [NullAllowed] NSObject sender);

    //    // @optional -(void)collectionView:(UICollectionView * _Nonnull)collectionView performAction:(SEL _Nonnull)action forItemAtIndexPath:(NSIndexPath * _Nonnull)indexPath withSender:(id _Nullable)sender __attribute__((deprecated("Implement collectionNode:performAction:forItemAtIndexPath:withSender: instead.")));
    //    [Export ("collectionView:performAction:forItemAtIndexPath:withSender:")]
    //    void CollectionView (UICollectionView collectionView, Selector action, NSIndexPath indexPath, [NullAllowed] NSObject sender);
    //}

    // @interface ASBatchContext : NSObject
    [BaseType (typeof(NSObject))]
    interface ASBatchContext
    {
        // -(BOOL)isFetching;
        [Export ("isFetching")]
        //[Verify (MethodToProperty)]
        bool IsFetching { get; }

        // -(void)completeBatchFetching:(BOOL)didComplete;
        [Export ("completeBatchFetching:")]
        void CompleteBatchFetching (bool didComplete);

        // -(BOOL)batchFetchingWasCancelled;
        [Export ("batchFetchingWasCancelled")]
        //[Verify (MethodToProperty)]
        bool BatchFetchingWasCancelled { get; }

        // -(void)cancelBatchFetching;
        [Export ("cancelBatchFetching")]
        void CancelBatchFetching ();

        // -(void)beginBatchFetching;
        [Export ("beginBatchFetching")]
        void BeginBatchFetching ();
    }

    //[Static]
    //[Verify (ConstantsInterfaceAssociation)]
    //partial interface Constants
    //{
    //    // extern const ASScrollDirection ASScrollDirectionHorizontalDirections;
    //    [Field ("ASScrollDirectionHorizontalDirections", "__Internal")]
    //    ASScrollDirection ASScrollDirectionHorizontalDirections { get; }

    //    // extern const ASScrollDirection ASScrollDirectionVerticalDirections;
    //    [Field ("ASScrollDirectionVerticalDirections", "__Internal")]
    //    ASScrollDirection ASScrollDirectionVerticalDirections { get; }
    //}

    //// @interface ASCollectionView : UICollectionView
    //[BaseType (typeof(UICollectionView))]
    //interface ASCollectionView
    //{
    //    // @property (readonly, nonatomic, weak) ASCollectionNode * _Nullable collectionNode;
    //    [NullAllowed, Export ("collectionNode", ArgumentSemantic.Weak)]
    //    ASCollectionNode CollectionNode { get; }

    //    // -(ASCellNode * _Nullable)nodeForItemAtIndexPath:(NSIndexPath * _Nonnull)indexPath __attribute__((warn_unused_result));
    //    [Export ("nodeForItemAtIndexPath:")]
    //    [return: NullAllowed]
    //    ASCellNode NodeForItemAtIndexPath (NSIndexPath indexPath);

    //    // -(NSIndexPath * _Nullable)indexPathForNode:(ASCellNode * _Nonnull)cellNode __attribute__((warn_unused_result));
    //    [Export ("indexPathForNode:")]
    //    [return: NullAllowed]
    //    NSIndexPath IndexPathForNode (ASCellNode cellNode);

    //    // -(ASCellNode * _Nullable)supplementaryNodeForElementKind:(NSString * _Nonnull)elementKind atIndexPath:(NSIndexPath * _Nonnull)indexPath __attribute__((warn_unused_result));
    //    [Export ("supplementaryNodeForElementKind:atIndexPath:")]
    //    [return: NullAllowed]
    //    ASCellNode SupplementaryNodeForElementKind (string elementKind, NSIndexPath indexPath);

    //    // -(id<ASSectionContext> _Nullable)contextForSection:(NSInteger)section __attribute__((warn_unused_result));
    //    [Export ("contextForSection:")]
    //    [return: NullAllowed]
    //    ASSectionContext ContextForSection (nint section);
    //}

    //// @interface Deprecated (ASCollectionView)
    //[Category]
    //[BaseType (typeof(ASCollectionView))]
    //interface ASCollectionView_Deprecated
    //{
    //    // @property (assign, nonatomic) BOOL inverted __attribute__((deprecated("Use ASCollectionNode property instead.")));
    //    [Export ("inverted")]
    //    bool Inverted { get; set; }

    //    // @property (assign, nonatomic) CGFloat leadingScreensForBatching __attribute__((deprecated("Use ASCollectionNode property instead.")));
    //    [Export ("leadingScreensForBatching")]
    //    nfloat LeadingScreensForBatching { get; set; }

    //    // @property (nonatomic, weak) id<ASCollectionViewLayoutInspecting> _Nullable layoutInspector __attribute__((deprecated("Use ASCollectionNode property instead.")));
    //    [NullAllowed, Export ("layoutInspector", ArgumentSemantic.Weak)]
    //    ASCollectionViewLayoutInspecting LayoutInspector { get; set; }

    //    // @property (readonly, nonatomic) ASScrollDirection scrollDirection __attribute__((deprecated("Use ASCollectionNode property instead.")));
    //    [Export ("scrollDirection")]
    //    ASScrollDirection ScrollDirection { get; }

    //    // @property (readonly, nonatomic) ASScrollDirection scrollableDirections __attribute__((deprecated("Use ASCollectionNode property instead.")));
    //    [Export ("scrollableDirections")]
    //    ASScrollDirection ScrollableDirections { get; }

    //    // @property (nonatomic) BOOL zeroContentInsets __attribute__((deprecated("Set automaticallyAdjustsScrollViewInsets=NO on your view controller instead.")));
    //    [Export ("zeroContentInsets")]
    //    bool ZeroContentInsets { get; set; }

    //    // @property (assign, nonatomic) UIEdgeInsets contentInset __attribute__((deprecated("Use ASCollectionNode property instead")));
    //    [Export ("contentInset", ArgumentSemantic.Assign)]
    //    UIEdgeInsets ContentInset { get; set; }

    //    // @property (assign, nonatomic) CGPoint contentOffset __attribute__((deprecated("Use ASCollectionNode property instead.")));
    //    [Export ("contentOffset", ArgumentSemantic.Assign)]
    //    CGPoint ContentOffset { get; set; }

    //    [Wrap ("WeakAsyncDelegate")]
    //    [NullAllowed]
    //    ASCollectionDelegate AsyncDelegate { get; set; }

    //    // @property (nonatomic, weak) id<ASCollectionDelegate> _Nullable asyncDelegate __attribute__((deprecated("Please use ASCollectionNode's .delegate property instead.")));
    //    [NullAllowed, Export ("asyncDelegate", ArgumentSemantic.Weak)]
    //    NSObject WeakAsyncDelegate { get; set; }

    //    // @property (nonatomic, weak) id<ASCollectionDataSource> _Nullable asyncDataSource __attribute__((deprecated("Please use ASCollectionNode's .dataSource property instead.")));
    //    [NullAllowed, Export ("asyncDataSource", ArgumentSemantic.Weak)]
    //    ASCollectionDataSource AsyncDataSource { get; set; }

    //    // -(instancetype _Nonnull)initWithCollectionViewLayout:(UICollectionViewLayout * _Nonnull)layout __attribute__((deprecated("Please use ASCollectionNode instead of ASCollectionView.")));
    //    [Export ("initWithCollectionViewLayout:")]
    //    IntPtr Constructor (UICollectionViewLayout layout);

    //    // -(instancetype _Nonnull)initWithFrame:(CGRect)frame collectionViewLayout:(UICollectionViewLayout * _Nonnull)layout __attribute__((deprecated("Please use ASCollectionNode instead of ASCollectionView.")));
    //    [Export ("initWithFrame:collectionViewLayout:")]
    //    IntPtr Constructor (CGRect frame, UICollectionViewLayout layout);

    //    // -(ASRangeTuningParameters)tuningParametersForRangeType:(ASLayoutRangeType)rangeType __attribute__((deprecated("Use ASCollectionNode method instead."))) __attribute__((warn_unused_result));
    //    [Export ("tuningParametersForRangeType:")]
    //    ASRangeTuningParameters TuningParametersForRangeType (ASLayoutRangeType rangeType);

    //    // -(void)setTuningParameters:(ASRangeTuningParameters)tuningParameters forRangeType:(ASLayoutRangeType)rangeType __attribute__((deprecated("Use ASCollectionNode method instead.")));
    //    [Export ("setTuningParameters:forRangeType:")]
    //    void SetTuningParameters (ASRangeTuningParameters tuningParameters, ASLayoutRangeType rangeType);

    //    // -(ASRangeTuningParameters)tuningParametersForRangeMode:(ASLayoutRangeMode)rangeMode rangeType:(ASLayoutRangeType)rangeType __attribute__((deprecated("Use ASCollectionNode method instead."))) __attribute__((warn_unused_result));
    //    [Export ("tuningParametersForRangeMode:rangeType:")]
    //    ASRangeTuningParameters TuningParametersForRangeMode (ASLayoutRangeMode rangeMode, ASLayoutRangeType rangeType);

    //    // -(void)setTuningParameters:(ASRangeTuningParameters)tuningParameters forRangeMode:(ASLayoutRangeMode)rangeMode rangeType:(ASLayoutRangeType)rangeType __attribute__((deprecated("Use ASCollectionNode method instead.")));
    //    [Export ("setTuningParameters:forRangeMode:rangeType:")]
    //    void SetTuningParameters (ASRangeTuningParameters tuningParameters, ASLayoutRangeMode rangeMode, ASLayoutRangeType rangeType);

    //    // -(__kindof UICollectionViewCell * _Nullable)cellForItemAtIndexPath:(NSIndexPath * _Nonnull)indexPath __attribute__((deprecated("Use ASCollectionNode method instead.")));
    //    [Export ("cellForItemAtIndexPath:")]
    //    UICollectionViewCell CellForItemAtIndexPath (NSIndexPath indexPath);

    //    // -(void)scrollToItemAtIndexPath:(NSIndexPath * _Nonnull)indexPath atScrollPosition:(UICollectionViewScrollPosition)scrollPosition animated:(BOOL)animated __attribute__((deprecated("Use ASCollectionNode method instead.")));
    //    [Export ("scrollToItemAtIndexPath:atScrollPosition:animated:")]
    //    void ScrollToItemAtIndexPath (NSIndexPath indexPath, UICollectionViewScrollPosition scrollPosition, bool animated);

    //    // -(void)selectItemAtIndexPath:(NSIndexPath * _Nonnull)indexPath animated:(BOOL)animated scrollPosition:(UICollectionViewScrollPosition)scrollPosition __attribute__((deprecated("Use ASCollectionNode method instead.")));
    //    [Export ("selectItemAtIndexPath:animated:scrollPosition:")]
    //    void SelectItemAtIndexPath (NSIndexPath indexPath, bool animated, UICollectionViewScrollPosition scrollPosition);

    //    // @property (readonly, nonatomic) NSArray<NSIndexPath *> * _Nonnull indexPathsForVisibleItems __attribute__((deprecated("Use ASCollectionNode property instead.")));
    //    [Export ("indexPathsForVisibleItems")]
    //    NSIndexPath[] IndexPathsForVisibleItems { get; }

    //    // @property (readonly, nonatomic) NSArray<NSIndexPath *> * _Nullable indexPathsForSelectedItems __attribute__((deprecated("Use ASCollectionNode property instead.")));
    //    [NullAllowed, Export ("indexPathsForSelectedItems")]
    //    NSIndexPath[] IndexPathsForSelectedItems { get; }

    //    // -(void)performBatchAnimated:(BOOL)animated updates:(void (^ _Nullable)())updates completion:(void (^ _Nullable)(BOOL))completion __attribute__((deprecated("Use ASCollectionNode method instead.")));
    //    [Export ("performBatchAnimated:updates:completion:")]
    //    void PerformBatchAnimated (bool animated, [NullAllowed] Action updates, [NullAllowed] Action<bool> completion);

    //    // -(void)performBatchUpdates:(void (^ _Nullable)())updates completion:(void (^ _Nullable)(BOOL))completion __attribute__((deprecated("Use ASCollectionNode method instead.")));
    //    [Export ("performBatchUpdates:completion:")]
    //    void PerformBatchUpdates ([NullAllowed] Action updates, [NullAllowed] Action<bool> completion);

    //    // -(void)relayoutItems __attribute__((deprecated("Use ASCollectionNode method instead.")));
    //    [Export ("relayoutItems")]
    //    void RelayoutItems ();

    //    // @property (readonly, nonatomic) BOOL isProcessingUpdates;
    //    [Export ("isProcessingUpdates")]
    //    bool IsProcessingUpdates { get; }

    //    // -(void)onDidFinishProcessingUpdates:(void (^ _Nullable)())completion;
    //    [Export ("onDidFinishProcessingUpdates:")]
    //    void OnDidFinishProcessingUpdates ([NullAllowed] Action completion);

    //    // -(void)waitUntilAllUpdatesAreCommitted __attribute__((deprecated("Use -[ASCollectionNode waitUntilAllUpdatesAreProcessed] instead.")));
    //    [Export ("waitUntilAllUpdatesAreCommitted")]
    //    void WaitUntilAllUpdatesAreCommitted ();

    //    // -(void)registerSupplementaryNodeOfKind:(NSString * _Nonnull)elementKind __attribute__((deprecated("Use ASCollectionNode method instead.")));
    //    [Export ("registerSupplementaryNodeOfKind:")]
    //    void RegisterSupplementaryNodeOfKind (string elementKind);

    //    // -(void)insertSections:(NSIndexSet * _Nonnull)sections __attribute__((deprecated("Use ASCollectionNode method instead.")));
    //    [Export ("insertSections:")]
    //    void InsertSections (NSIndexSet sections);

    //    // -(void)deleteSections:(NSIndexSet * _Nonnull)sections __attribute__((deprecated("Use ASCollectionNode method instead.")));
    //    [Export ("deleteSections:")]
    //    void DeleteSections (NSIndexSet sections);

    //    // -(void)reloadSections:(NSIndexSet * _Nonnull)sections __attribute__((deprecated("Use ASCollectionNode method instead.")));
    //    [Export ("reloadSections:")]
    //    void ReloadSections (NSIndexSet sections);

    //    // -(void)moveSection:(NSInteger)section toSection:(NSInteger)newSection __attribute__((deprecated("Use ASCollectionNode method instead.")));
    //    [Export ("moveSection:toSection:")]
    //    void MoveSection (nint section, nint newSection);

    //    // -(void)insertItemsAtIndexPaths:(NSArray<NSIndexPath *> * _Nonnull)indexPaths __attribute__((deprecated("Use ASCollectionNode method instead.")));
    //    [Export ("insertItemsAtIndexPaths:")]
    //    void InsertItemsAtIndexPaths (NSIndexPath[] indexPaths);

    //    // -(void)deleteItemsAtIndexPaths:(NSArray<NSIndexPath *> * _Nonnull)indexPaths __attribute__((deprecated("Use ASCollectionNode method instead.")));
    //    [Export ("deleteItemsAtIndexPaths:")]
    //    void DeleteItemsAtIndexPaths (NSIndexPath[] indexPaths);

    //    // -(void)reloadItemsAtIndexPaths:(NSArray<NSIndexPath *> * _Nonnull)indexPaths __attribute__((deprecated("Use ASCollectionNode method instead.")));
    //    [Export ("reloadItemsAtIndexPaths:")]
    //    void ReloadItemsAtIndexPaths (NSIndexPath[] indexPaths);

    //    // -(void)moveItemAtIndexPath:(NSIndexPath * _Nonnull)indexPath toIndexPath:(NSIndexPath * _Nonnull)newIndexPath __attribute__((deprecated("Use ASCollectionNode method instead.")));
    //    [Export ("moveItemAtIndexPath:toIndexPath:")]
    //    void MoveItemAtIndexPath (NSIndexPath indexPath, NSIndexPath newIndexPath);

    //    // -(CGSize)calculatedSizeForNodeAtIndexPath:(NSIndexPath * _Nonnull)indexPath __attribute__((deprecated("Call -calculatedSize on the node of interest instead.")));
    //    [Export ("calculatedSizeForNodeAtIndexPath:")]
    //    CGSize CalculatedSizeForNodeAtIndexPath (NSIndexPath indexPath);

    //    // -(NSArray<__kindof ASCellNode *> * _Nonnull)visibleNodes __attribute__((deprecated("Use ASCollectionNode method instead."))) __attribute__((warn_unused_result));
    //    [Export ("visibleNodes")]
    //    [Verify (MethodToProperty)]
    //    ASCellNode[] VisibleNodes { get; }

    //    // -(void)setContentOffset:(CGPoint)contentOffset animated:(BOOL)animated __attribute__((deprecated("Use ASCollectionNode method instead.")));
    //    [Export ("setContentOffset:animated:")]
    //    void SetContentOffset (CGPoint contentOffset, bool animated);
    //}

    //// @protocol ASCollectionViewDataSource <ASCollectionDataSource>
    //[Protocol, Model]
    //interface ASCollectionViewDataSource : IASCollectionDataSource
    //{
    //}

    //// @protocol ASCollectionViewDelegate <ASCollectionDelegate>
    //[Protocol, Model]
    //interface ASCollectionViewDelegate : IASCollectionDelegate
    //{
    //}

    //// @protocol ASCollectionDelegateFlowLayout <ASCollectionDelegate>
    //[Protocol, Model]
    //interface ASCollectionDelegateFlowLayout : IASCollectionDelegate
    //{
    //    // @optional -(UIEdgeInsets)collectionView:(UICollectionView * _Nonnull)collectionView layout:(UICollectionViewLayout * _Nonnull)collectionViewLayout insetForSectionAtIndex:(NSInteger)section;
    //    [Export ("collectionView:layout:insetForSectionAtIndex:")]
    //    UIEdgeInsets CollectionView (UICollectionView collectionView, UICollectionViewLayout collectionViewLayout, nint section);

    //    // @optional -(ASSizeRange)collectionNode:(ASCollectionNode * _Nonnull)collectionNode sizeRangeForHeaderInSection:(NSInteger)section;
    //    [Export ("collectionNode:sizeRangeForHeaderInSection:")]
    //    ASSizeRange CollectionNode (ASCollectionNode collectionNode, nint section);

    //    // @optional -(ASSizeRange)collectionNode:(ASCollectionNode * _Nonnull)collectionNode sizeRangeForFooterInSection:(NSInteger)section;
    //    [Export ("collectionNode:sizeRangeForFooterInSection:")]
    //    ASSizeRange CollectionNode (ASCollectionNode collectionNode, nint section);

    //    // @optional -(CGSize)collectionView:(ASCollectionView * _Nonnull)collectionView layout:(UICollectionViewLayout * _Nonnull)collectionViewLayout referenceSizeForHeaderInSection:(NSInteger)section __attribute__((deprecated("Implement collectionNode:sizeRangeForHeaderInSection: instead.")));
    //    [Export ("collectionView:layout:referenceSizeForHeaderInSection:")]
    //    CGSize CollectionView (ASCollectionView collectionView, UICollectionViewLayout collectionViewLayout, nint section);

    //    // @optional -(CGSize)collectionView:(ASCollectionView * _Nonnull)collectionView layout:(UICollectionViewLayout * _Nonnull)collectionViewLayout referenceSizeForFooterInSection:(NSInteger)section __attribute__((deprecated("Implement collectionNode:sizeRangeForFooterInSection: instead.")));
    //    [Export ("collectionView:layout:referenceSizeForFooterInSection:")]
    //    CGSize CollectionView (ASCollectionView collectionView, UICollectionViewLayout collectionViewLayout, nint section);
    //}

    //// @protocol ASCollectionViewDelegateFlowLayout <ASCollectionDelegateFlowLayout>
    //[Protocol, Model]
    //interface ASCollectionViewDelegateFlowLayout : IASCollectionDelegateFlowLayout
    //{
    //}

    //// @interface ASCollectionNode : ASDisplayNode <ASRangeControllerUpdateRangeProtocol, ASRangeManagingNode>
    //[BaseType (typeof(ASDisplayNode))]
    //[DisableDefaultCtor]
    //interface ASCollectionNode : IASRangeControllerUpdateRangeProtocol, IASRangeManagingNode
    //{
    //    // -(instancetype _Nonnull)initWithCollectionViewLayout:(UICollectionViewLayout * _Nonnull)layout;
    //    [Export ("initWithCollectionViewLayout:")]
    //    IntPtr Constructor (UICollectionViewLayout layout);

    //    // -(instancetype _Nonnull)initWithFrame:(CGRect)frame collectionViewLayout:(UICollectionViewLayout * _Nonnull)layout;
    //    [Export ("initWithFrame:collectionViewLayout:")]
    //    IntPtr Constructor (CGRect frame, UICollectionViewLayout layout);

    //    // @property (readonly, nonatomic, strong) ASCollectionView * _Nonnull view;
    //    [Export ("view", ArgumentSemantic.Strong)]
    //    ASCollectionView View { get; }

    //    [Wrap ("WeakDelegate")]
    //    [NullAllowed]
    //    ASCollectionDelegate Delegate { get; set; }

    //    // @property (nonatomic, weak) id<ASCollectionDelegate> _Nullable delegate;
    //    [NullAllowed, Export ("delegate", ArgumentSemantic.Weak)]
    //    NSObject WeakDelegate { get; set; }

    //    // @property (nonatomic, weak) id<ASCollectionDataSource> _Nullable dataSource;
    //    [NullAllowed, Export ("dataSource", ArgumentSemantic.Weak)]
    //    ASCollectionDataSource DataSource { get; set; }

    //    // @property (assign, nonatomic) CGFloat leadingScreensForBatching;
    //    [Export ("leadingScreensForBatching")]
    //    nfloat LeadingScreensForBatching { get; set; }

    //    // @property (assign, nonatomic) BOOL inverted;
    //    [Export ("inverted")]
    //    bool Inverted { get; set; }

    //    // @property (assign, nonatomic) BOOL allowsSelection;
    //    [Export ("allowsSelection")]
    //    bool AllowsSelection { get; set; }

    //    // @property (assign, nonatomic) BOOL allowsMultipleSelection;
    //    [Export ("allowsMultipleSelection")]
    //    bool AllowsMultipleSelection { get; set; }

    //    // @property (nonatomic, strong) UICollectionViewLayout * _Nonnull collectionViewLayout;
    //    [Export ("collectionViewLayout", ArgumentSemantic.Strong)]
    //    UICollectionViewLayout CollectionViewLayout { get; set; }

    //    // @property (nonatomic, weak) id<ASCollectionViewLayoutInspecting> _Nullable layoutInspector;
    //    [NullAllowed, Export ("layoutInspector", ArgumentSemantic.Weak)]
    //    ASCollectionViewLayoutInspecting LayoutInspector { get; set; }

    //    // @property (assign, nonatomic) UIEdgeInsets contentInset;
    //    [Export ("contentInset", ArgumentSemantic.Assign)]
    //    UIEdgeInsets ContentInset { get; set; }

    //    // @property (assign, nonatomic) CGPoint contentOffset;
    //    [Export ("contentOffset", ArgumentSemantic.Assign)]
    //    CGPoint ContentOffset { get; set; }

    //    // -(void)setContentOffset:(CGPoint)contentOffset animated:(BOOL)animated;
    //    [Export ("setContentOffset:animated:")]
    //    void SetContentOffset (CGPoint contentOffset, bool animated);

    //    // -(ASRangeTuningParameters)tuningParametersForRangeType:(ASLayoutRangeType)rangeType __attribute__((warn_unused_result));
    //    [Export ("tuningParametersForRangeType:")]
    //    ASRangeTuningParameters TuningParametersForRangeType (ASLayoutRangeType rangeType);

    //    // -(void)setTuningParameters:(ASRangeTuningParameters)tuningParameters forRangeType:(ASLayoutRangeType)rangeType;
    //    [Export ("setTuningParameters:forRangeType:")]
    //    void SetTuningParameters (ASRangeTuningParameters tuningParameters, ASLayoutRangeType rangeType);

    //    // -(ASRangeTuningParameters)tuningParametersForRangeMode:(ASLayoutRangeMode)rangeMode rangeType:(ASLayoutRangeType)rangeType __attribute__((warn_unused_result));
    //    [Export ("tuningParametersForRangeMode:rangeType:")]
    //    ASRangeTuningParameters TuningParametersForRangeMode (ASLayoutRangeMode rangeMode, ASLayoutRangeType rangeType);

    //    // -(void)setTuningParameters:(ASRangeTuningParameters)tuningParameters forRangeMode:(ASLayoutRangeMode)rangeMode rangeType:(ASLayoutRangeType)rangeType;
    //    [Export ("setTuningParameters:forRangeMode:rangeType:")]
    //    void SetTuningParameters (ASRangeTuningParameters tuningParameters, ASLayoutRangeMode rangeMode, ASLayoutRangeType rangeType);

    //    // -(void)scrollToItemAtIndexPath:(NSIndexPath * _Nonnull)indexPath atScrollPosition:(UICollectionViewScrollPosition)scrollPosition animated:(BOOL)animated;
    //    [Export ("scrollToItemAtIndexPath:atScrollPosition:animated:")]
    //    void ScrollToItemAtIndexPath (NSIndexPath indexPath, UICollectionViewScrollPosition scrollPosition, bool animated);

    //    // @property (readonly, nonatomic) ASScrollDirection scrollDirection;
    //    [Export ("scrollDirection")]
    //    ASScrollDirection ScrollDirection { get; }

    //    // @property (readonly, nonatomic) ASScrollDirection scrollableDirections;
    //    [Export ("scrollableDirections")]
    //    ASScrollDirection ScrollableDirections { get; }

    //    // -(void)registerSupplementaryNodeOfKind:(NSString * _Nonnull)elementKind;
    //    [Export ("registerSupplementaryNodeOfKind:")]
    //    void RegisterSupplementaryNodeOfKind (string elementKind);

    //    // -(void)performBatchAnimated:(BOOL)animated updates:(void (^ _Nullable)())updates completion:(void (^ _Nullable)(BOOL))completion;
    //    [Export ("performBatchAnimated:updates:completion:")]
    //    void PerformBatchAnimated (bool animated, [NullAllowed] Action updates, [NullAllowed] Action<bool> completion);

    //    // -(void)performBatchUpdates:(void (^ _Nullable)())updates completion:(void (^ _Nullable)(BOOL))completion;
    //    [Export ("performBatchUpdates:completion:")]
    //    void PerformBatchUpdates ([NullAllowed] Action updates, [NullAllowed] Action<bool> completion);

    //    // @property (readonly, nonatomic) BOOL isProcessingUpdates;
    //    [Export ("isProcessingUpdates")]
    //    bool IsProcessingUpdates { get; }

    //    // -(void)onDidFinishProcessingUpdates:(void (^ _Nullable)())didFinishProcessingUpdates;
    //    [Export ("onDidFinishProcessingUpdates:")]
    //    void OnDidFinishProcessingUpdates ([NullAllowed] Action didFinishProcessingUpdates);

    //    // -(void)waitUntilAllUpdatesAreProcessed;
    //    [Export ("waitUntilAllUpdatesAreProcessed")]
    //    void WaitUntilAllUpdatesAreProcessed ();

    //    // -(void)insertSections:(NSIndexSet * _Nonnull)sections;
    //    [Export ("insertSections:")]
    //    void InsertSections (NSIndexSet sections);

    //    // -(void)deleteSections:(NSIndexSet * _Nonnull)sections;
    //    [Export ("deleteSections:")]
    //    void DeleteSections (NSIndexSet sections);

    //    // -(void)reloadSections:(NSIndexSet * _Nonnull)sections;
    //    [Export ("reloadSections:")]
    //    void ReloadSections (NSIndexSet sections);

    //    // -(void)moveSection:(NSInteger)section toSection:(NSInteger)newSection;
    //    [Export ("moveSection:toSection:")]
    //    void MoveSection (nint section, nint newSection);

    //    // -(void)insertItemsAtIndexPaths:(NSArray<NSIndexPath *> * _Nonnull)indexPaths;
    //    [Export ("insertItemsAtIndexPaths:")]
    //    void InsertItemsAtIndexPaths (NSIndexPath[] indexPaths);

    //    // -(void)deleteItemsAtIndexPaths:(NSArray<NSIndexPath *> * _Nonnull)indexPaths;
    //    [Export ("deleteItemsAtIndexPaths:")]
    //    void DeleteItemsAtIndexPaths (NSIndexPath[] indexPaths);

    //    // -(void)reloadItemsAtIndexPaths:(NSArray<NSIndexPath *> * _Nonnull)indexPaths;
    //    [Export ("reloadItemsAtIndexPaths:")]
    //    void ReloadItemsAtIndexPaths (NSIndexPath[] indexPaths);

    //    // -(void)moveItemAtIndexPath:(NSIndexPath * _Nonnull)indexPath toIndexPath:(NSIndexPath * _Nonnull)newIndexPath;
    //    [Export ("moveItemAtIndexPath:toIndexPath:")]
    //    void MoveItemAtIndexPath (NSIndexPath indexPath, NSIndexPath newIndexPath);

    //    // -(void)reloadDataWithCompletion:(void (^ _Nullable)())completion;
    //    [Export ("reloadDataWithCompletion:")]
    //    void ReloadDataWithCompletion ([NullAllowed] Action completion);

    //    // -(void)reloadData;
    //    [Export ("reloadData")]
    //    void ReloadData ();

    //    // -(void)relayoutItems;
    //    [Export ("relayoutItems")]
    //    void RelayoutItems ();

    //    // @property (readonly, nonatomic) NSArray<NSIndexPath *> * _Nullable indexPathsForSelectedItems;
    //    [NullAllowed, Export ("indexPathsForSelectedItems")]
    //    NSIndexPath[] IndexPathsForSelectedItems { get; }

    //    // -(void)selectItemAtIndexPath:(NSIndexPath * _Nullable)indexPath animated:(BOOL)animated scrollPosition:(UICollectionViewScrollPosition)scrollPosition;
    //    [Export ("selectItemAtIndexPath:animated:scrollPosition:")]
    //    void SelectItemAtIndexPath ([NullAllowed] NSIndexPath indexPath, bool animated, UICollectionViewScrollPosition scrollPosition);

    //    // -(void)deselectItemAtIndexPath:(NSIndexPath * _Nonnull)indexPath animated:(BOOL)animated;
    //    [Export ("deselectItemAtIndexPath:animated:")]
    //    void DeselectItemAtIndexPath (NSIndexPath indexPath, bool animated);

    //    // -(NSInteger)numberOfItemsInSection:(NSInteger)section __attribute__((warn_unused_result));
    //    [Export ("numberOfItemsInSection:")]
    //    nint NumberOfItemsInSection (nint section);

    //    // @property (readonly, nonatomic) NSInteger numberOfSections;
    //    [Export ("numberOfSections")]
    //    nint NumberOfSections { get; }

    //    // @property (readonly, nonatomic) NSArray<__kindof ASCellNode *> * _Nonnull visibleNodes;
    //    [Export ("visibleNodes")]
    //    ASCellNode[] VisibleNodes { get; }

    //    // -(__kindof ASCellNode * _Nullable)nodeForItemAtIndexPath:(NSIndexPath * _Nonnull)indexPath __attribute__((warn_unused_result));
    //    [Export ("nodeForItemAtIndexPath:")]
    //    ASCellNode NodeForItemAtIndexPath (NSIndexPath indexPath);

    //    // -(id _Nullable)nodeModelForItemAtIndexPath:(NSIndexPath * _Nonnull)indexPath __attribute__((warn_unused_result));
    //    [Export ("nodeModelForItemAtIndexPath:")]
    //    [return: NullAllowed]
    //    NSObject NodeModelForItemAtIndexPath (NSIndexPath indexPath);

    //    // -(NSIndexPath * _Nullable)indexPathForNode:(ASCellNode * _Nonnull)cellNode __attribute__((warn_unused_result));
    //    [Export ("indexPathForNode:")]
    //    [return: NullAllowed]
    //    NSIndexPath IndexPathForNode (ASCellNode cellNode);

    //    // @property (readonly, nonatomic) NSArray<NSIndexPath *> * _Nonnull indexPathsForVisibleItems;
    //    [Export ("indexPathsForVisibleItems")]
    //    NSIndexPath[] IndexPathsForVisibleItems { get; }

    //    // -(NSIndexPath * _Nullable)indexPathForItemAtPoint:(CGPoint)point __attribute__((warn_unused_result));
    //    [Export ("indexPathForItemAtPoint:")]
    //    [return: NullAllowed]
    //    NSIndexPath IndexPathForItemAtPoint (CGPoint point);

    //    // -(UICollectionViewCell * _Nullable)cellForItemAtIndexPath:(NSIndexPath * _Nonnull)indexPath;
    //    [Export ("cellForItemAtIndexPath:")]
    //    [return: NullAllowed]
    //    UICollectionViewCell CellForItemAtIndexPath (NSIndexPath indexPath);

    //    // -(id<ASSectionContext> _Nullable)contextForSection:(NSInteger)section __attribute__((warn_unused_result));
    //    [Export ("contextForSection:")]
    //    [return: NullAllowed]
    //    ASSectionContext ContextForSection (nint section);
    //}

    //// @interface Deprecated (ASCollectionNode)
    //[Category]
    //[BaseType (typeof(ASCollectionNode))]
    //interface ASCollectionNode_Deprecated
    //{
    //    // -(void)waitUntilAllUpdatesAreCommitted __attribute__((deprecated("This method has been renamed to -waitUntilAllUpdatesAreProcessed.")));
    //    [Export ("waitUntilAllUpdatesAreCommitted")]
    //    void WaitUntilAllUpdatesAreCommitted ();
    //}

    //// @protocol ASCollectionDataSource <ASCommonCollectionDataSource>
    //[Protocol, Model]
    //interface ASCollectionDataSource : IASCommonCollectionDataSource
    //{
    //    // @optional -(NSInteger)collectionNode:(ASCollectionNode * _Nonnull)collectionNode numberOfItemsInSection:(NSInteger)section;
    //    [Export ("collectionNode:numberOfItemsInSection:")]
    //    nint CollectionNode (ASCollectionNode collectionNode, nint section);

    //    // @optional -(NSInteger)numberOfSectionsInCollectionNode:(ASCollectionNode * _Nonnull)collectionNode;
    //    [Export ("numberOfSectionsInCollectionNode:")]
    //    nint NumberOfSectionsInCollectionNode (ASCollectionNode collectionNode);

    //    // @optional -(id _Nullable)collectionNode:(ASCollectionNode * _Nonnull)collectionNode nodeModelForItemAtIndexPath:(NSIndexPath * _Nonnull)indexPath;
    //    [Export ("collectionNode:nodeModelForItemAtIndexPath:")]
    //    [return: NullAllowed]
    //    NSObject CollectionNode (ASCollectionNode collectionNode, NSIndexPath indexPath);

    //    // @optional -(ASCellNodeBlock _Nonnull)collectionNode:(ASCollectionNode * _Nonnull)collectionNode nodeBlockForItemAtIndexPath:(NSIndexPath * _Nonnull)indexPath;
    //    [Export ("collectionNode:nodeBlockForItemAtIndexPath:")]
    //    ASCellNodeBlock CollectionNode (ASCollectionNode collectionNode, NSIndexPath indexPath);

    //    // @optional -(ASCellNode * _Nonnull)collectionNode:(ASCollectionNode * _Nonnull)collectionNode nodeForItemAtIndexPath:(NSIndexPath * _Nonnull)indexPath;
    //    [Export ("collectionNode:nodeForItemAtIndexPath:")]
    //    ASCellNode CollectionNode (ASCollectionNode collectionNode, NSIndexPath indexPath);

    //    // @optional -(ASCellNodeBlock _Nonnull)collectionNode:(ASCollectionNode * _Nonnull)collectionNode nodeBlockForSupplementaryElementOfKind:(NSString * _Nonnull)kind atIndexPath:(NSIndexPath * _Nonnull)indexPath;
    //    [Export ("collectionNode:nodeBlockForSupplementaryElementOfKind:atIndexPath:")]
    //    ASCellNodeBlock CollectionNode (ASCollectionNode collectionNode, string kind, NSIndexPath indexPath);

    //    // @optional -(ASCellNode * _Nonnull)collectionNode:(ASCollectionNode * _Nonnull)collectionNode nodeForSupplementaryElementOfKind:(NSString * _Nonnull)kind atIndexPath:(NSIndexPath * _Nonnull)indexPath;
    //    [Export ("collectionNode:nodeForSupplementaryElementOfKind:atIndexPath:")]
    //    ASCellNode CollectionNode (ASCollectionNode collectionNode, string kind, NSIndexPath indexPath);

    //    // @optional -(id<ASSectionContext> _Nullable)collectionNode:(ASCollectionNode * _Nonnull)collectionNode contextForSection:(NSInteger)section;
    //    [Export ("collectionNode:contextForSection:")]
    //    [return: NullAllowed]
    //    ASSectionContext CollectionNode (ASCollectionNode collectionNode, nint section);

    //    // @optional -(NSArray<NSString *> * _Nonnull)collectionNode:(ASCollectionNode * _Nonnull)collectionNode supplementaryElementKindsInSection:(NSInteger)section;
    //    [Export ("collectionNode:supplementaryElementKindsInSection:")]
    //    string[] CollectionNode (ASCollectionNode collectionNode, nint section);

    //    // @optional -(ASCellNode * _Nonnull)collectionView:(ASCollectionView * _Nonnull)collectionView nodeForItemAtIndexPath:(NSIndexPath * _Nonnull)indexPath __attribute__((deprecated("Use ASCollectionNode's method instead.")));
    //    [Export ("collectionView:nodeForItemAtIndexPath:")]
    //    ASCellNode CollectionView (ASCollectionView collectionView, NSIndexPath indexPath);

    //    // @optional -(ASCellNodeBlock _Nonnull)collectionView:(ASCollectionView * _Nonnull)collectionView nodeBlockForItemAtIndexPath:(NSIndexPath * _Nonnull)indexPath __attribute__((deprecated("Use ASCollectionNode's method instead.")));
    //    [Export ("collectionView:nodeBlockForItemAtIndexPath:")]
    //    ASCellNodeBlock CollectionView (ASCollectionView collectionView, NSIndexPath indexPath);

    //    // @optional -(ASCellNode * _Nonnull)collectionView:(ASCollectionView * _Nonnull)collectionView nodeForSupplementaryElementOfKind:(NSString * _Nonnull)kind atIndexPath:(NSIndexPath * _Nonnull)indexPath __attribute__((deprecated("Use ASCollectionNode's method instead.")));
    //    [Export ("collectionView:nodeForSupplementaryElementOfKind:atIndexPath:")]
    //    ASCellNode CollectionView (ASCollectionView collectionView, string kind, NSIndexPath indexPath);

    //    // @optional -(void)collectionViewLockDataSource:(ASCollectionView * _Nonnull)collectionView __attribute__((deprecated("Data source accesses are on the main thread. Method will not be called.")));
    //    [Export ("collectionViewLockDataSource:")]
    //    void CollectionViewLockDataSource (ASCollectionView collectionView);

    //    // @optional -(void)collectionViewUnlockDataSource:(ASCollectionView * _Nonnull)collectionView __attribute__((deprecated("Data source accesses are on the main thread. Method will not be called.")));
    //    [Export ("collectionViewUnlockDataSource:")]
    //    void CollectionViewUnlockDataSource (ASCollectionView collectionView);
    //}

    //// @protocol ASCollectionDelegate <ASCommonCollectionDelegate, NSObject>
    //[Protocol, Model]
    //[BaseType (typeof(NSObject))]
    //interface ASCollectionDelegate : IASCommonCollectionDelegate
    //{
    //    // @optional -(ASSizeRange)collectionNode:(ASCollectionNode * _Nonnull)collectionNode constrainedSizeForItemAtIndexPath:(NSIndexPath * _Nonnull)indexPath;
    //    [Export ("collectionNode:constrainedSizeForItemAtIndexPath:")]
    //    ASSizeRange CollectionNode (ASCollectionNode collectionNode, NSIndexPath indexPath);

    //    // @optional -(void)collectionNode:(ASCollectionNode * _Nonnull)collectionNode willDisplayItemWithNode:(ASCellNode * _Nonnull)node;
    //    [Export ("collectionNode:willDisplayItemWithNode:")]
    //    void CollectionNode (ASCollectionNode collectionNode, ASCellNode node);

    //    // @optional -(void)collectionNode:(ASCollectionNode * _Nonnull)collectionNode didEndDisplayingItemWithNode:(ASCellNode * _Nonnull)node;
    //    [Export ("collectionNode:didEndDisplayingItemWithNode:")]
    //    void CollectionNode (ASCollectionNode collectionNode, ASCellNode node);

    //    // @optional -(void)collectionNode:(ASCollectionNode * _Nonnull)collectionNode willDisplaySupplementaryElementWithNode:(ASCellNode * _Nonnull)node __attribute__((availability(ios, introduced=8.0)));
    //    [iOS (8,0)]
    //    [Export ("collectionNode:willDisplaySupplementaryElementWithNode:")]
    //    void CollectionNode (ASCollectionNode collectionNode, ASCellNode node);

    //    // @optional -(void)collectionNode:(ASCollectionNode * _Nonnull)collectionNode didEndDisplayingSupplementaryElementWithNode:(ASCellNode * _Nonnull)node;
    //    [Export ("collectionNode:didEndDisplayingSupplementaryElementWithNode:")]
    //    void CollectionNode (ASCollectionNode collectionNode, ASCellNode node);

    //    // @optional -(BOOL)collectionNode:(ASCollectionNode * _Nonnull)collectionNode shouldHighlightItemAtIndexPath:(NSIndexPath * _Nonnull)indexPath;
    //    [Export ("collectionNode:shouldHighlightItemAtIndexPath:")]
    //    bool CollectionNode (ASCollectionNode collectionNode, NSIndexPath indexPath);

    //    // @optional -(void)collectionNode:(ASCollectionNode * _Nonnull)collectionNode didHighlightItemAtIndexPath:(NSIndexPath * _Nonnull)indexPath;
    //    [Export ("collectionNode:didHighlightItemAtIndexPath:")]
    //    void CollectionNode (ASCollectionNode collectionNode, NSIndexPath indexPath);

    //    // @optional -(void)collectionNode:(ASCollectionNode * _Nonnull)collectionNode didUnhighlightItemAtIndexPath:(NSIndexPath * _Nonnull)indexPath;
    //    [Export ("collectionNode:didUnhighlightItemAtIndexPath:")]
    //    void CollectionNode (ASCollectionNode collectionNode, NSIndexPath indexPath);

    //    // @optional -(BOOL)collectionNode:(ASCollectionNode * _Nonnull)collectionNode shouldSelectItemAtIndexPath:(NSIndexPath * _Nonnull)indexPath;
    //    [Export ("collectionNode:shouldSelectItemAtIndexPath:")]
    //    bool CollectionNode (ASCollectionNode collectionNode, NSIndexPath indexPath);

    //    // @optional -(BOOL)collectionNode:(ASCollectionNode * _Nonnull)collectionNode shouldDeselectItemAtIndexPath:(NSIndexPath * _Nonnull)indexPath;
    //    [Export ("collectionNode:shouldDeselectItemAtIndexPath:")]
    //    bool CollectionNode (ASCollectionNode collectionNode, NSIndexPath indexPath);

    //    // @optional -(void)collectionNode:(ASCollectionNode * _Nonnull)collectionNode didSelectItemAtIndexPath:(NSIndexPath * _Nonnull)indexPath;
    //    [Export ("collectionNode:didSelectItemAtIndexPath:")]
    //    void CollectionNode (ASCollectionNode collectionNode, NSIndexPath indexPath);

    //    // @optional -(void)collectionNode:(ASCollectionNode * _Nonnull)collectionNode didDeselectItemAtIndexPath:(NSIndexPath * _Nonnull)indexPath;
    //    [Export ("collectionNode:didDeselectItemAtIndexPath:")]
    //    void CollectionNode (ASCollectionNode collectionNode, NSIndexPath indexPath);

    //    // @optional -(BOOL)collectionNode:(ASCollectionNode * _Nonnull)collectionNode shouldShowMenuForItemAtIndexPath:(NSIndexPath * _Nonnull)indexPath;
    //    [Export ("collectionNode:shouldShowMenuForItemAtIndexPath:")]
    //    bool CollectionNode (ASCollectionNode collectionNode, NSIndexPath indexPath);

    //    // @optional -(BOOL)collectionNode:(ASCollectionNode * _Nonnull)collectionNode canPerformAction:(SEL _Nonnull)action forItemAtIndexPath:(NSIndexPath * _Nonnull)indexPath sender:(id _Nullable)sender;
    //    [Export ("collectionNode:canPerformAction:forItemAtIndexPath:sender:")]
    //    bool CollectionNode (ASCollectionNode collectionNode, Selector action, NSIndexPath indexPath, [NullAllowed] NSObject sender);

    //    // @optional -(void)collectionNode:(ASCollectionNode * _Nonnull)collectionNode performAction:(SEL _Nonnull)action forItemAtIndexPath:(NSIndexPath * _Nonnull)indexPath sender:(id _Nullable)sender;
    //    [Export ("collectionNode:performAction:forItemAtIndexPath:sender:")]
    //    void CollectionNode (ASCollectionNode collectionNode, Selector action, NSIndexPath indexPath, [NullAllowed] NSObject sender);

    //    // @optional -(void)collectionNode:(ASCollectionNode * _Nonnull)collectionNode willBeginBatchFetchWithContext:(ASBatchContext * _Nonnull)context;
    //    [Export ("collectionNode:willBeginBatchFetchWithContext:")]
    //    void CollectionNode (ASCollectionNode collectionNode, ASBatchContext context);

    //    // @optional -(BOOL)shouldBatchFetchForCollectionNode:(ASCollectionNode * _Nonnull)collectionNode;
    //    [Export ("shouldBatchFetchForCollectionNode:")]
    //    bool ShouldBatchFetchForCollectionNode (ASCollectionNode collectionNode);

    //    // @optional -(ASSizeRange)collectionView:(ASCollectionView * _Nonnull)collectionView constrainedSizeForNodeAtIndexPath:(NSIndexPath * _Nonnull)indexPath __attribute__((deprecated("Use ASCollectionNode's constrainedSizeForItemAtIndexPath: instead. PLEASE NOTE the very subtle method name change.")));
    //    [Export ("collectionView:constrainedSizeForNodeAtIndexPath:")]
    //    ASSizeRange CollectionView (ASCollectionView collectionView, NSIndexPath indexPath);

    //    // @optional -(void)collectionView:(ASCollectionView * _Nonnull)collectionView willDisplayNode:(ASCellNode * _Nonnull)node forItemAtIndexPath:(NSIndexPath * _Nonnull)indexPath __attribute__((deprecated("Use ASCollectionNode's method instead.")));
    //    [Export ("collectionView:willDisplayNode:forItemAtIndexPath:")]
    //    void CollectionView (ASCollectionView collectionView, ASCellNode node, NSIndexPath indexPath);

    //    // @optional -(void)collectionView:(ASCollectionView * _Nonnull)collectionView didEndDisplayingNode:(ASCellNode * _Nonnull)node forItemAtIndexPath:(NSIndexPath * _Nonnull)indexPath __attribute__((deprecated("Use ASCollectionNode's method instead.")));
    //    [Export ("collectionView:didEndDisplayingNode:forItemAtIndexPath:")]
    //    void CollectionView (ASCollectionView collectionView, ASCellNode node, NSIndexPath indexPath);

    //    // @optional -(void)collectionView:(ASCollectionView * _Nonnull)collectionView willBeginBatchFetchWithContext:(ASBatchContext * _Nonnull)context __attribute__((deprecated("Use ASCollectionNode's method instead.")));
    //    [Export ("collectionView:willBeginBatchFetchWithContext:")]
    //    void CollectionView (ASCollectionView collectionView, ASBatchContext context);

    //    // @optional -(BOOL)shouldBatchFetchForCollectionView:(ASCollectionView * _Nonnull)collectionView __attribute__((deprecated("Use ASCollectionNode's method instead.")));
    //    [Export ("shouldBatchFetchForCollectionView:")]
    //    bool ShouldBatchFetchForCollectionView (ASCollectionView collectionView);

    //    // @optional -(void)collectionView:(ASCollectionView * _Nonnull)collectionView willDisplayNodeForItemAtIndexPath:(NSIndexPath * _Nonnull)indexPath __attribute__((deprecated("Use ASCollectionNode's method instead.")));
    //    [Export ("collectionView:willDisplayNodeForItemAtIndexPath:")]
    //    void CollectionView (ASCollectionView collectionView, NSIndexPath indexPath);
    //}

    //// @protocol ASCollectionDataSourceInterop <ASCollectionDataSource>
    //[Protocol, Model]
    //interface ASCollectionDataSourceInterop : IASCollectionDataSource
    //{
    //    // @required -(__kindof UICollectionViewCell * _Nonnull)collectionView:(UICollectionView * _Nonnull)collectionView cellForItemAtIndexPath:(NSIndexPath * _Nonnull)indexPath;
    //    [Abstract]
    //    [Export ("collectionView:cellForItemAtIndexPath:")]
    //    UICollectionViewCell CollectionView (UICollectionView collectionView, NSIndexPath indexPath);

    //    // @optional -(UICollectionReusableView * _Nonnull)collectionView:(UICollectionView * _Nonnull)collectionView viewForSupplementaryElementOfKind:(NSString * _Nonnull)kind atIndexPath:(NSIndexPath * _Nonnull)indexPath;
    //    [Export ("collectionView:viewForSupplementaryElementOfKind:atIndexPath:")]
    //    UICollectionReusableView CollectionView (UICollectionView collectionView, string kind, NSIndexPath indexPath);

    //    // @optional @property (readonly, nonatomic, class) BOOL dequeuesCellsForNodeBackedItems;
    //    [Static]
    //    [Export ("dequeuesCellsForNodeBackedItems")]
    //    bool DequeuesCellsForNodeBackedItems { get; }
    //}

    //// @protocol ASCollectionDelegateInterop <ASCollectionDelegate>
    //[Protocol, Model]
    //interface ASCollectionDelegateInterop : IASCollectionDelegate
    //{
    //    // @optional -(void)collectionView:(UICollectionView * _Nonnull)collectionView willDisplayCell:(UICollectionViewCell * _Nonnull)cell forItemAtIndexPath:(NSIndexPath * _Nonnull)indexPath;
    //    [Export ("collectionView:willDisplayCell:forItemAtIndexPath:")]
    //    void WillDisplayCell (UICollectionView collectionView, UICollectionViewCell cell, NSIndexPath indexPath);

    //    // @optional -(void)collectionView:(UICollectionView * _Nonnull)collectionView didEndDisplayingCell:(UICollectionViewCell * _Nonnull)cell forItemAtIndexPath:(NSIndexPath * _Nonnull)indexPath;
    //    [Export ("collectionView:didEndDisplayingCell:forItemAtIndexPath:")]
    //    void DidEndDisplayingCell (UICollectionView collectionView, UICollectionViewCell cell, NSIndexPath indexPath);
    //}

    //// @interface Beta (ASCollectionNode)
    //[Category]
    //[BaseType (typeof(ASCollectionNode))]
    //interface ASCollectionNode_Beta
    //{
    //    // @property (nonatomic, strong) Class _Nullable collectionViewClass;
    //    [NullAllowed, Export ("collectionViewClass", ArgumentSemantic.Strong)]
    //    Class CollectionViewClass { get; set; }

    //    // @property (readonly, nonatomic, strong) ASElementMap * _Nonnull visibleElements;
    //    [Export ("visibleElements", ArgumentSemantic.Strong)]
    //    ASElementMap VisibleElements { get; }

    //    [Wrap ("WeakLayoutDelegate")]
    //    [NullAllowed]
    //    ASCollectionLayoutDelegate LayoutDelegate { get; }

    //    // @property (readonly, strong) id<ASCollectionLayoutDelegate> _Nullable layoutDelegate;
    //    [NullAllowed, Export ("layoutDelegate", ArgumentSemantic.Strong)]
    //    NSObject WeakLayoutDelegate { get; }

    //    [Wrap ("WeakBatchFetchingDelegate")]
    //    [NullAllowed]
    //    ASBatchFetchingDelegate BatchFetchingDelegate { get; set; }

    //    // @property (nonatomic, weak) id<ASBatchFetchingDelegate> _Nullable batchFetchingDelegate;
    //    [NullAllowed, Export ("batchFetchingDelegate", ArgumentSemantic.Weak)]
    //    NSObject WeakBatchFetchingDelegate { get; set; }

    //    // @property (assign, nonatomic) BOOL usesSynchronousDataLoading;
    //    [Export ("usesSynchronousDataLoading")]
    //    bool UsesSynchronousDataLoading { get; set; }

    //    // -(instancetype _Nonnull)initWithFrame:(CGRect)frame collectionViewLayout:(UICollectionViewLayout * _Nonnull)layout layoutFacilitator:(id<ASCollectionViewLayoutFacilitatorProtocol> _Nullable)layoutFacilitator;
    //    [Export ("initWithFrame:collectionViewLayout:layoutFacilitator:")]
    //    IntPtr Constructor (CGRect frame, UICollectionViewLayout layout, [NullAllowed] ASCollectionViewLayoutFacilitatorProtocol layoutFacilitator);

    //    // -(instancetype _Nonnull)initWithLayoutDelegate:(id<ASCollectionLayoutDelegate> _Nonnull)layoutDelegate layoutFacilitator:(id<ASCollectionViewLayoutFacilitatorProtocol> _Nullable)layoutFacilitator;
    //    [Export ("initWithLayoutDelegate:layoutFacilitator:")]
    //    IntPtr Constructor (ASCollectionLayoutDelegate layoutDelegate, [NullAllowed] ASCollectionViewLayoutFacilitatorProtocol layoutFacilitator);

    //    // -(void)beginUpdates __attribute__((deprecated("Use -performBatchUpdates:completion: instead.")));
    //    [Export ("beginUpdates")]
    //    void BeginUpdates ();

    //    // -(void)endUpdatesAnimated:(BOOL)animated __attribute__((deprecated("Use -performBatchUpdates:completion: instead.")));
    //    [Export ("endUpdatesAnimated:")]
    //    void EndUpdatesAnimated (bool animated);

    //    // -(void)endUpdatesAnimated:(BOOL)animated completion:(void (^ _Nullable)(BOOL))completion __attribute__((deprecated("Use -performBatchUpdates:completion: instead.")));
    //    [Export ("endUpdatesAnimated:completion:")]
    //    void EndUpdatesAnimated (bool animated, [NullAllowed] Action<bool> completion);
    //}

    //// @protocol ASCollectionViewLayoutInspecting <NSObject>
    //[Protocol, Model]
    //[BaseType (typeof(NSObject))]
    //interface ASCollectionViewLayoutInspecting
    //{
    //    // @required -(ASSizeRange)collectionView:(ASCollectionView * _Nonnull)collectionView constrainedSizeForNodeAtIndexPath:(NSIndexPath * _Nonnull)indexPath;
    //    [Abstract]
    //    [Export ("collectionView:constrainedSizeForNodeAtIndexPath:")]
    //    ASSizeRange CollectionView (ASCollectionView collectionView, NSIndexPath indexPath);

    //    // @required -(ASScrollDirection)scrollableDirections;
    //    [Abstract]
    //    [Export ("scrollableDirections")]
    //    [Verify (MethodToProperty)]
    //    ASScrollDirection ScrollableDirections { get; }

    //    // @optional -(ASSizeRange)collectionView:(ASCollectionView * _Nonnull)collectionView constrainedSizeForSupplementaryNodeOfKind:(NSString * _Nonnull)kind atIndexPath:(NSIndexPath * _Nonnull)indexPath;
    //    [Export ("collectionView:constrainedSizeForSupplementaryNodeOfKind:atIndexPath:")]
    //    ASSizeRange CollectionView (ASCollectionView collectionView, string kind, NSIndexPath indexPath);

    //    // @optional -(NSUInteger)collectionView:(ASCollectionView * _Nonnull)collectionView supplementaryNodesOfKind:(NSString * _Nonnull)kind inSection:(NSUInteger)section;
    //    [Export ("collectionView:supplementaryNodesOfKind:inSection:")]
    //    nuint CollectionView (ASCollectionView collectionView, string kind, nuint section);

    //    // @optional -(void)didChangeCollectionViewDelegate:(id<ASCollectionDelegate> _Nullable)delegate;
    //    [Export ("didChangeCollectionViewDelegate:")]
    //    void DidChangeCollectionViewDelegate ([NullAllowed] ASCollectionDelegate @delegate);

    //    // @optional -(void)didChangeCollectionViewDataSource:(id<ASCollectionDataSource> _Nullable)dataSource;
    //    [Export ("didChangeCollectionViewDataSource:")]
    //    void DidChangeCollectionViewDataSource ([NullAllowed] ASCollectionDataSource dataSource);

    //    // @optional -(NSUInteger)collectionView:(ASCollectionView * _Nonnull)collectionView numberOfSectionsForSupplementaryNodeOfKind:(NSString * _Nonnull)kind __attribute__((deprecated("Use ASCollectionNode's method instead.")));
    //    [Export ("collectionView:numberOfSectionsForSupplementaryNodeOfKind:")]
    //    nuint CollectionView (ASCollectionView collectionView, string kind);
    //}

    //// @interface ASCollectionViewLayoutInspector : NSObject <ASCollectionViewLayoutInspecting>
    //[BaseType (typeof(NSObject))]
    //interface ASCollectionViewLayoutInspector : IASCollectionViewLayoutInspecting
    //{
    //}

    //// @protocol ASCollectionViewLayoutFacilitatorProtocol <NSObject>
    //[Protocol, Model]
    //[BaseType (typeof(NSObject))]
    //interface ASCollectionViewLayoutFacilitatorProtocol
    //{
    //    // @required -(void)collectionViewWillEditCellsAtIndexPaths:(NSArray *)indexPaths batched:(BOOL)isBatched;
    //    [Abstract]
    //    [Export ("collectionViewWillEditCellsAtIndexPaths:batched:")]
    //    [Verify (StronglyTypedNSArray)]
    //    void CollectionViewWillEditCellsAtIndexPaths (NSObject[] indexPaths, bool isBatched);

    //    // @required -(void)collectionViewWillEditSectionsAtIndexSet:(NSIndexSet *)indexes batched:(BOOL)batched;
    //    [Abstract]
    //    [Export ("collectionViewWillEditSectionsAtIndexSet:batched:")]
    //    void CollectionViewWillEditSectionsAtIndexSet (NSIndexSet indexes, bool batched);

    //    // @required -(void)collectionViewWillPerformBatchUpdates;
    //    [Abstract]
    //    [Export ("collectionViewWillPerformBatchUpdates")]
    //    void CollectionViewWillPerformBatchUpdates ();
    //}

    // @interface ASCellNode : ASDisplayNode
    [BaseType (typeof(ASDisplayNode))]
    interface ASCellNode
    {
        // @property (assign, nonatomic) BOOL neverShowPlaceholders;
        [Export ("neverShowPlaceholders")]
        bool NeverShowPlaceholders { get; set; }

        // @property (readonly, copy, atomic) NSString * _Nullable supplementaryElementKind;
        [NullAllowed, Export ("supplementaryElementKind")]
        string SupplementaryElementKind { get; }

        // @property (readonly, nonatomic, strong) UICollectionViewLayoutAttributes * _Nullable layoutAttributes;
        [NullAllowed, Export ("layoutAttributes", ArgumentSemantic.Strong)]
        UICollectionViewLayoutAttributes LayoutAttributes { get; }

        // @property (getter = isSelected, assign, nonatomic) BOOL selected;
        [Export ("selected")]
        bool Selected { [Bind ("isSelected")] get; set; }

        // @property (getter = isHighlighted, assign, nonatomic) BOOL highlighted;
        [Export ("highlighted")]
        bool Highlighted { [Bind ("isHighlighted")] get; set; }

        // @property (readonly, atomic) NSIndexPath * _Nullable indexPath;
        [NullAllowed, Export ("indexPath")]
        NSIndexPath IndexPath { get; }

        // @property (atomic) id _Nullable nodeModel;
        [NullAllowed, Export ("nodeModel", ArgumentSemantic.Assign)]
        NSObject NodeModel { get; set; }

        // -(BOOL)canUpdateToNodeModel:(id _Nonnull)nodeModel;
        [Export ("canUpdateToNodeModel:")]
        bool CanUpdateToNodeModel (NSObject nodeModel);

        // @property (readonly, nonatomic) UIViewController * _Nullable viewController;
        [NullAllowed, Export ("viewController")]
        UIViewController ViewController { get; }

        // @property (readonly, atomic, weak) id<ASRangeManagingNode> _Nullable owningNode;
        [NullAllowed, Export ("owningNode", ArgumentSemantic.Weak)]
        ASRangeManagingNode OwningNode { get; }

        // -(void)touchesBegan:(NSSet<UITouch *> * _Nonnull)touches withEvent:(UIEvent * _Nullable)event __attribute__((objc_requires_super));
        [Export ("touchesBegan:withEvent:")]
        //[RequiresSuper]
        void TouchesBegan (NSSet<UITouch> touches, [NullAllowed] UIEvent @event);

        // -(void)touchesMoved:(NSSet<UITouch *> * _Nonnull)touches withEvent:(UIEvent * _Nullable)event __attribute__((objc_requires_super));
        [Export ("touchesMoved:withEvent:")]
        //[RequiresSuper]
        void TouchesMoved (NSSet<UITouch> touches, [NullAllowed] UIEvent @event);

        // -(void)touchesEnded:(NSSet<UITouch *> * _Nonnull)touches withEvent:(UIEvent * _Nullable)event __attribute__((objc_requires_super));
        [Export ("touchesEnded:withEvent:")]
        //[RequiresSuper]
        void TouchesEnded (NSSet<UITouch> touches, [NullAllowed] UIEvent @event);

        // -(void)touchesCancelled:(NSSet<UITouch *> * _Nullable)touches withEvent:(UIEvent * _Nullable)event __attribute__((objc_requires_super));
        [Export ("touchesCancelled:withEvent:")]
        //[RequiresSuper]
        void TouchesCancelled ([NullAllowed] NSSet<UITouch> touches, [NullAllowed] UIEvent @event);

        // -(void)applyLayoutAttributes:(UICollectionViewLayoutAttributes * _Nonnull)layoutAttributes;
        [Export ("applyLayoutAttributes:")]
        void ApplyLayoutAttributes (UICollectionViewLayoutAttributes layoutAttributes);

        // -(instancetype _Nonnull)initWithViewControllerBlock:(ASDisplayNodeViewControllerBlock _Nonnull)viewControllerBlock didLoadBlock:(ASDisplayNodeDidLoadBlock _Nullable)didLoadBlock;
        [Export ("initWithViewControllerBlock:didLoadBlock:")]
        IntPtr Constructor (ASDisplayNodeViewControllerBlock viewControllerBlock, [NullAllowed] ASDisplayNodeDidLoadBlock didLoadBlock);

        // -(void)cellNodeVisibilityEvent:(ASCellNodeVisibilityEvent)event inScrollView:(UIScrollView * _Nullable)scrollView withCellFrame:(CGRect)cellFrame;
        [Export ("cellNodeVisibilityEvent:inScrollView:withCellFrame:")]
        void CellNodeVisibilityEvent (ASCellNodeVisibilityEvent @event, [NullAllowed] UIScrollView scrollView, CGRect cellFrame);

        // @property (nonatomic) UITableViewCellSelectionStyle selectionStyle;
        [Export ("selectionStyle", ArgumentSemantic.Assign)]
        UITableViewCellSelectionStyle SelectionStyle { get; set; }

        // @property (nonatomic, strong) UIView * _Nullable selectedBackgroundView;
        [NullAllowed, Export ("selectedBackgroundView", ArgumentSemantic.Strong)]
        UIView SelectedBackgroundView { get; set; }

        //// @property (nonatomic) UITableViewCellAccessoryType accessoryType;
        //[Export ("accessoryType", ArgumentSemantic.Assign)]
        //UITableViewCellAccessoryType AccessoryType { get; set; }

        // @property (nonatomic) UIEdgeInsets separatorInset;
        [Export ("separatorInset", ArgumentSemantic.Assign)]
        UIEdgeInsets SeparatorInset { get; set; }
    }

    //// @interface Unavailable (ASCellNode)
    //[Category]
    //[BaseType (typeof(ASCellNode))]
    //interface ASCellNode_Unavailable
    //{
    //}

    //// @interface ASTextCellNode : ASCellNode
    //[BaseType (typeof(ASCellNode))]
    //interface ASTextCellNode
    //{
    //    // -(instancetype _Nonnull)initWithAttributes:(NSDictionary * _Nonnull)textAttributes insets:(UIEdgeInsets)textInsets;
    //    [Export ("initWithAttributes:insets:")]
    //    IntPtr Constructor (NSDictionary textAttributes, UIEdgeInsets textInsets);

    //    // @property (copy, nonatomic) NSString * _Nonnull text;
    //    [Export ("text")]
    //    string Text { get; set; }

    //    // @property (copy, nonatomic) NSDictionary * _Nonnull textAttributes;
    //    [Export ("textAttributes", ArgumentSemantic.Copy)]
    //    NSDictionary TextAttributes { get; set; }

    //    // @property (assign, nonatomic) UIEdgeInsets textInsets;
    //    [Export ("textInsets", ArgumentSemantic.Assign)]
    //    UIEdgeInsets TextInsets { get; set; }

    //    // @property (readonly, nonatomic, strong) ASTextNode * _Nonnull textNode;
    //    [Export ("textNode", ArgumentSemantic.Strong)]
    //    ASTextNode TextNode { get; }
    //}

    //// @protocol ASSectionContext
    //[Protocol, Model]
    //interface ASSectionContext
    //{
    //    // @required @property (copy, nonatomic) NSString * _Nullable sectionName;
    //    [Abstract]
    //    [NullAllowed, Export ("sectionName")]
    //    string SectionName { get; set; }

    //    // @required @property (nonatomic, weak) ASCollectionView * _Nullable collectionView;
    //    [Abstract]
    //    [NullAllowed, Export ("collectionView", ArgumentSemantic.Weak)]
    //    ASCollectionView CollectionView { get; set; }
    //}

    //// @interface ASElementMap : NSObject <NSCopying, NSFastEnumeration>
    //[BaseType (typeof(NSObject))]
    //interface ASElementMap : INSCopying, INSFastEnumeration
    //{
    //    // @property (readonly) NSInteger numberOfSections;
    //    [Export ("numberOfSections")]
    //    nint NumberOfSections { get; }

    //    // @property (readonly, copy) NSArray<NSString *> * _Nonnull supplementaryElementKinds;
    //    [Export ("supplementaryElementKinds", ArgumentSemantic.Copy)]
    //    string[] SupplementaryElementKinds { get; }

    //    // -(NSInteger)numberOfItemsInSection:(NSInteger)section;
    //    [Export ("numberOfItemsInSection:")]
    //    nint NumberOfItemsInSection (nint section);

    //    // -(id<ASSectionContext> _Nullable)contextForSection:(NSInteger)section;
    //    [Export ("contextForSection:")]
    //    [return: NullAllowed]
    //    ASSectionContext ContextForSection (nint section);

    //    // @property (readonly, copy) NSArray<NSIndexPath *> * _Nonnull itemIndexPaths;
    //    [Export ("itemIndexPaths", ArgumentSemantic.Copy)]
    //    NSIndexPath[] ItemIndexPaths { get; }

    //    // @property (readonly, copy) NSArray<ASCollectionElement *> * _Nonnull itemElements;
    //    [Export ("itemElements", ArgumentSemantic.Copy)]
    //    ASCollectionElement[] ItemElements { get; }

    //    // -(NSIndexPath * _Nullable)convertIndexPath:(NSIndexPath * _Nonnull)indexPath fromMap:(ASElementMap * _Nonnull)map;
    //    [Export ("convertIndexPath:fromMap:")]
    //    [return: NullAllowed]
    //    NSIndexPath ConvertIndexPath (NSIndexPath indexPath, ASElementMap map);

    //    // -(NSIndexPath * _Nullable)indexPathForElement:(ASCollectionElement * _Nonnull)element;
    //    [Export ("indexPathForElement:")]
    //    [return: NullAllowed]
    //    NSIndexPath IndexPathForElement (ASCollectionElement element);

    //    // -(NSIndexPath * _Nullable)indexPathForElementIfCell:(ASCollectionElement * _Nonnull)element;
    //    [Export ("indexPathForElementIfCell:")]
    //    [return: NullAllowed]
    //    NSIndexPath IndexPathForElementIfCell (ASCollectionElement element);

    //    // -(ASCollectionElement * _Nullable)elementForItemAtIndexPath:(NSIndexPath * _Nonnull)indexPath;
    //    [Export ("elementForItemAtIndexPath:")]
    //    [return: NullAllowed]
    //    ASCollectionElement ElementForItemAtIndexPath (NSIndexPath indexPath);

    //    // -(ASCollectionElement * _Nullable)supplementaryElementOfKind:(NSString * _Nonnull)supplementaryElementKind atIndexPath:(NSIndexPath * _Nonnull)indexPath;
    //    [Export ("supplementaryElementOfKind:atIndexPath:")]
    //    [return: NullAllowed]
    //    ASCollectionElement SupplementaryElementOfKind (string supplementaryElementKind, NSIndexPath indexPath);

    //    // -(ASCollectionElement * _Nullable)elementForLayoutAttributes:(UICollectionViewLayoutAttributes * _Nonnull)layoutAttributes;
    //    [Export ("elementForLayoutAttributes:")]
    //    [return: NullAllowed]
    //    ASCollectionElement ElementForLayoutAttributes (UICollectionViewLayoutAttributes layoutAttributes);

    //    // @property (readonly, atomic) NSString * _Nonnull smallDescription;
    //    [Export ("smallDescription")]
    //    string SmallDescription { get; }

    //    // -(instancetype _Nonnull)initWithSections:(NSArray<ASSection *> * _Nonnull)sections items:(ASCollectionElementTwoDimensionalArray * _Nonnull)items supplementaryElements:(ASSupplementaryElementDictionary * _Nonnull)supplementaryElements;
    //    [Export ("initWithSections:items:supplementaryElements:")]
    //    IntPtr Constructor (ASSection[] sections, NSArray<ASCollectionElement>[] items, NSDictionary<NSString, NSDictionary<NSIndexPath, ASCollectionElement>> supplementaryElements);
    //}

    //// @interface ASCollectionLayoutContext : NSObject
    //[BaseType (typeof(NSObject))]
    //[DisableDefaultCtor]
    //interface ASCollectionLayoutContext
    //{
    //    // @property (readonly, assign, nonatomic) CGSize viewportSize;
    //    [Export ("viewportSize", ArgumentSemantic.Assign)]
    //    CGSize ViewportSize { get; }

    //    // @property (readonly, assign, nonatomic) CGPoint initialContentOffset;
    //    [Export ("initialContentOffset", ArgumentSemantic.Assign)]
    //    CGPoint InitialContentOffset { get; }

    //    // @property (readonly, assign, nonatomic) ASScrollDirection scrollableDirections;
    //    [Export ("scrollableDirections", ArgumentSemantic.Assign)]
    //    ASScrollDirection ScrollableDirections { get; }

    //    // @property (readonly, nonatomic, weak) ASElementMap * _Nullable elements;
    //    [NullAllowed, Export ("elements", ArgumentSemantic.Weak)]
    //    ASElementMap Elements { get; }

    //    // @property (readonly, nonatomic, strong) id _Nullable additionalInfo;
    //    [NullAllowed, Export ("additionalInfo", ArgumentSemantic.Strong)]
    //    NSObject AdditionalInfo { get; }
    //}

    //// typedef ASCollectionElement * _Nullable (^ASCollectionLayoutStateGetElementBlock)(ASLayout * _Nonnull);
    //delegate ASCollectionElement ASCollectionLayoutStateGetElementBlock (ASLayout arg0);

    //// @interface ASCollectionLayoutConvenience (NSMapTable)
    //[Category]
    //[BaseType (typeof(NSMapTable))]
    //interface NSMapTable_ASCollectionLayoutConvenience
    //{
    //    // +(NSMapTable<ASCollectionElement *,UICollectionViewLayoutAttributes *> * _Nonnull)elementToLayoutAttributesTable;
    //    [Static]
    //    [Export ("elementToLayoutAttributesTable")]
    //    [Verify (MethodToProperty)]
    //    NSMapTable<ASCollectionElement, UICollectionViewLayoutAttributes> ElementToLayoutAttributesTable { get; }
    //}

    //// @interface ASCollectionLayoutState : NSObject
    //[BaseType (typeof(NSObject))]
    //[DisableDefaultCtor]
    //interface ASCollectionLayoutState
    //{
    //    // @property (readonly, nonatomic, strong) ASCollectionLayoutContext * _Nonnull context;
    //    [Export ("context", ArgumentSemantic.Strong)]
    //    ASCollectionLayoutContext Context { get; }

    //    // @property (readonly, assign, nonatomic) CGSize contentSize;
    //    [Export ("contentSize", ArgumentSemantic.Assign)]
    //    CGSize ContentSize { get; }

    //    // -(instancetype _Nonnull)initWithContext:(ASCollectionLayoutContext * _Nonnull)context contentSize:(CGSize)contentSize elementToLayoutAttributesTable:(NSMapTable<ASCollectionElement *,UICollectionViewLayoutAttributes *> * _Nonnull)table __attribute__((objc_designated_initializer));
    //    [Export ("initWithContext:contentSize:elementToLayoutAttributesTable:")]
    //    [DesignatedInitializer]
    //    IntPtr Constructor (ASCollectionLayoutContext context, CGSize contentSize, NSMapTable<ASCollectionElement, UICollectionViewLayoutAttributes> table);

    //    // -(instancetype _Nonnull)initWithContext:(ASCollectionLayoutContext * _Nonnull)context;
    //    [Export ("initWithContext:")]
    //    IntPtr Constructor (ASCollectionLayoutContext context);

    //    // -(instancetype _Nonnull)initWithContext:(ASCollectionLayoutContext * _Nonnull)context layout:(ASLayout * _Nonnull)layout getElementBlock:(ASCollectionLayoutStateGetElementBlock _Nonnull)getElementBlock;
    //    [Export ("initWithContext:layout:getElementBlock:")]
    //    IntPtr Constructor (ASCollectionLayoutContext context, ASLayout layout, ASCollectionLayoutStateGetElementBlock getElementBlock);

    //    // -(NSArray<UICollectionViewLayoutAttributes *> * _Nonnull)allLayoutAttributes;
    //    [Export ("allLayoutAttributes")]
    //    [Verify (MethodToProperty)]
    //    UICollectionViewLayoutAttributes[] AllLayoutAttributes { get; }

    //    // -(NSArray<UICollectionViewLayoutAttributes *> * _Nonnull)layoutAttributesForElementsInRect:(CGRect)rect;
    //    [Export ("layoutAttributesForElementsInRect:")]
    //    UICollectionViewLayoutAttributes[] LayoutAttributesForElementsInRect (CGRect rect);

    //    // -(UICollectionViewLayoutAttributes * _Nullable)layoutAttributesForItemAtIndexPath:(NSIndexPath * _Nonnull)indexPath;
    //    [Export ("layoutAttributesForItemAtIndexPath:")]
    //    [return: NullAllowed]
    //    UICollectionViewLayoutAttributes LayoutAttributesForItemAtIndexPath (NSIndexPath indexPath);

    //    // -(UICollectionViewLayoutAttributes * _Nullable)layoutAttributesForSupplementaryElementOfKind:(NSString * _Nonnull)kind atIndexPath:(NSIndexPath * _Nonnull)indexPath;
    //    [Export ("layoutAttributesForSupplementaryElementOfKind:atIndexPath:")]
    //    [return: NullAllowed]
    //    UICollectionViewLayoutAttributes LayoutAttributesForSupplementaryElementOfKind (string kind, NSIndexPath indexPath);

    //    // -(UICollectionViewLayoutAttributes * _Nullable)layoutAttributesForElement:(ASCollectionElement * _Nonnull)element;
    //    [Export ("layoutAttributesForElement:")]
    //    [return: NullAllowed]
    //    UICollectionViewLayoutAttributes LayoutAttributesForElement (ASCollectionElement element);
    //}

    //// @protocol ASCollectionLayoutDelegate <NSObject>
    //[Protocol, Model]
    //[BaseType (typeof(NSObject))]
    //interface ASCollectionLayoutDelegate
    //{
    //    // @required -(ASScrollDirection)scrollableDirections;
    //    [Abstract]
    //    [Export ("scrollableDirections")]
    //    [Verify (MethodToProperty)]
    //    ASScrollDirection ScrollableDirections { get; }

    //    // @required -(id _Nullable)additionalInfoForLayoutWithElements:(ASElementMap * _Nonnull)elements;
    //    [Abstract]
    //    [Export ("additionalInfoForLayoutWithElements:")]
    //    [return: NullAllowed]
    //    NSObject AdditionalInfoForLayoutWithElements (ASElementMap elements);

    //    // @required +(ASCollectionLayoutState * _Nonnull)calculateLayoutWithContext:(ASCollectionLayoutContext * _Nonnull)context;
    //    [Static, Abstract]
    //    [Export ("calculateLayoutWithContext:")]
    //    ASCollectionLayoutState CalculateLayoutWithContext (ASCollectionLayoutContext context);
    //}

    //// @interface ASCollectionFlowLayoutDelegate : NSObject <ASCollectionLayoutDelegate>
    //[BaseType (typeof(NSObject))]
    //interface ASCollectionFlowLayoutDelegate : IASCollectionLayoutDelegate
    //{
    //    // -(instancetype _Nonnull)initWithScrollableDirections:(ASScrollDirection)scrollableDirections __attribute__((objc_designated_initializer));
    //    [Export ("initWithScrollableDirections:")]
    //    [DesignatedInitializer]
    //    IntPtr Constructor (ASScrollDirection scrollableDirections);
    //}

    //// @protocol ASCollectionGalleryLayoutPropertiesProviding <NSObject>
    //[Protocol, Model]
    //[BaseType (typeof(NSObject))]
    //interface ASCollectionGalleryLayoutPropertiesProviding
    //{
    //    // @required -(CGSize)galleryLayoutDelegate:(ASCollectionGalleryLayoutDelegate * _Nonnull)delegate sizeForElements:(ASElementMap * _Nonnull)elements;
    //    [Abstract]
    //    [Export ("galleryLayoutDelegate:sizeForElements:")]
    //    CGSize GalleryLayoutDelegate (ASCollectionGalleryLayoutDelegate @delegate, ASElementMap elements);

    //    // @optional -(CGFloat)galleryLayoutDelegate:(ASCollectionGalleryLayoutDelegate * _Nonnull)delegate minimumLineSpacingForElements:(ASElementMap * _Nonnull)elements;
    //    [Export ("galleryLayoutDelegate:minimumLineSpacingForElements:")]
    //    nfloat GalleryLayoutDelegate (ASCollectionGalleryLayoutDelegate @delegate, ASElementMap elements);

    //    // @optional -(CGFloat)galleryLayoutDelegate:(ASCollectionGalleryLayoutDelegate * _Nonnull)delegate minimumInteritemSpacingForElements:(ASElementMap * _Nonnull)elements;
    //    [Export ("galleryLayoutDelegate:minimumInteritemSpacingForElements:")]
    //    nfloat GalleryLayoutDelegate (ASCollectionGalleryLayoutDelegate @delegate, ASElementMap elements);

    //    // @optional -(UIEdgeInsets)galleryLayoutDelegate:(ASCollectionGalleryLayoutDelegate * _Nonnull)delegate sectionInsetForElements:(ASElementMap * _Nonnull)elements;
    //    [Export ("galleryLayoutDelegate:sectionInsetForElements:")]
    //    UIEdgeInsets GalleryLayoutDelegate (ASCollectionGalleryLayoutDelegate @delegate, ASElementMap elements);
    //}

    //// @interface ASCollectionGalleryLayoutDelegate : NSObject <ASCollectionLayoutDelegate>
    //[BaseType (typeof(NSObject))]
    //[DisableDefaultCtor]
    //interface ASCollectionGalleryLayoutDelegate : IASCollectionLayoutDelegate
    //{
    //    // @property (nonatomic, weak) id<ASCollectionGalleryLayoutPropertiesProviding> _Nullable propertiesProvider;
    //    [NullAllowed, Export ("propertiesProvider", ArgumentSemantic.Weak)]
    //    ASCollectionGalleryLayoutPropertiesProviding PropertiesProvider { get; set; }

    //    // -(instancetype _Nonnull)initWithScrollableDirections:(ASScrollDirection)scrollableDirections __attribute__((objc_designated_initializer));
    //    [Export ("initWithScrollableDirections:")]
    //    [DesignatedInitializer]
    //    IntPtr Constructor (ASScrollDirection scrollableDirections);
    //}

    //// @protocol ASSectionController <NSObject>
    //[Protocol, Model]
    //[BaseType (typeof(NSObject))]
    //interface ASSectionController
    //{
    //    // @required -(ASCellNodeBlock _Nonnull)nodeBlockForItemAtIndex:(NSInteger)index;
    //    [Abstract]
    //    [Export ("nodeBlockForItemAtIndex:")]
    //    ASCellNodeBlock NodeBlockForItemAtIndex (nint index);

    //    // @optional -(BOOL)shouldBatchFetch;
    //    [Export ("shouldBatchFetch")]
    //    [Verify (MethodToProperty)]
    //    bool ShouldBatchFetch { get; }

    //    // @optional -(void)beginBatchFetchWithContext:(ASBatchContext * _Nonnull)context;
    //    [Export ("beginBatchFetchWithContext:")]
    //    void BeginBatchFetchWithContext (ASBatchContext context);

    //    // @optional -(ASSizeRange)sizeRangeForItemAtIndex:(NSInteger)index;
    //    [Export ("sizeRangeForItemAtIndex:")]
    //    ASSizeRange SizeRangeForItemAtIndex (nint index);
    //}

    //// @protocol ASSupplementaryNodeSource <NSObject>
    //[Protocol, Model]
    //[BaseType (typeof(NSObject))]
    //interface ASSupplementaryNodeSource
    //{
    //    // @required -(ASCellNodeBlock _Nonnull)nodeBlockForSupplementaryElementOfKind:(NSString * _Nonnull)elementKind atIndex:(NSInteger)index;
    //    [Abstract]
    //    [Export ("nodeBlockForSupplementaryElementOfKind:atIndex:")]
    //    ASCellNodeBlock NodeBlockForSupplementaryElementOfKind (string elementKind, nint index);

    //    // @optional -(ASSizeRange)sizeRangeForSupplementaryElementOfKind:(NSString * _Nonnull)elementKind atIndex:(NSInteger)index;
    //    [Export ("sizeRangeForSupplementaryElementOfKind:atIndex:")]
    //    ASSizeRange SizeRangeForSupplementaryElementOfKind (string elementKind, nint index);
    //}

    //// @interface ASScrollNode : ASDisplayNode
    //[BaseType (typeof(ASDisplayNode))]
    //interface ASScrollNode
    //{
    //    // @property (readonly, nonatomic, strong) UIScrollView * _Nonnull view;
    //    [Export ("view", ArgumentSemantic.Strong)]
    //    UIScrollView View { get; }

    //    // @property (assign, nonatomic) BOOL automaticallyManagesContentSize;
    //    [Export ("automaticallyManagesContentSize")]
    //    bool AutomaticallyManagesContentSize { get; set; }

    //    // @property (assign, nonatomic) ASScrollDirection scrollableDirections;
    //    [Export ("scrollableDirections", ArgumentSemantic.Assign)]
    //    ASScrollDirection ScrollableDirections { get; set; }
    //}

    //// @interface ASPagerFlowLayout : UICollectionViewFlowLayout
    //[BaseType (typeof(UICollectionViewFlowLayout))]
    //interface ASPagerFlowLayout
    //{
    //}

    //// @protocol ASPagerDataSource <NSObject>
    //[Protocol, Model]
    //[BaseType (typeof(NSObject))]
    //interface ASPagerDataSource
    //{
    //    // @required -(NSInteger)numberOfPagesInPagerNode:(ASPagerNode * _Nonnull)pagerNode;
    //    [Abstract]
    //    [Export ("numberOfPagesInPagerNode:")]
    //    nint NumberOfPagesInPagerNode (ASPagerNode pagerNode);

    //    // @optional -(ASCellNode * _Nonnull)pagerNode:(ASPagerNode * _Nonnull)pagerNode nodeAtIndex:(NSInteger)index;
    //    [Export ("pagerNode:nodeAtIndex:")]
    //    ASCellNode PagerNode (ASPagerNode pagerNode, nint index);

    //    // @optional -(ASCellNodeBlock _Nonnull)pagerNode:(ASPagerNode * _Nonnull)pagerNode nodeBlockAtIndex:(NSInteger)index;
    //    [Export ("pagerNode:nodeBlockAtIndex:")]
    //    ASCellNodeBlock PagerNode (ASPagerNode pagerNode, nint index);
    //}

    //// @protocol ASPagerDelegate <ASCollectionDelegate>
    //[Protocol, Model]
    //interface ASPagerDelegate : IASCollectionDelegate
    //{
    //}

    //// @interface ASPagerNode : ASCollectionNode
    //[BaseType (typeof(ASCollectionNode))]
    //interface ASPagerNode
    //{
    //    // -(instancetype _Nonnull)initWithCollectionViewLayout:(ASPagerFlowLayout * _Nonnull)flowLayout;
    //    [Export ("initWithCollectionViewLayout:")]
    //    IntPtr Constructor (ASPagerFlowLayout flowLayout);

    //    // -(id<ASPagerDataSource> _Nullable)dataSource __attribute__((warn_unused_result));
    //    // -(void)setDataSource:(id<ASPagerDataSource> _Nullable)dataSource;
    //    [NullAllowed, Export ("dataSource")]
    //    [Verify (MethodToProperty)]
    //    ASPagerDataSource DataSource { get; set; }

    //    // -(id<ASPagerDelegate> _Nullable)delegate __attribute__((warn_unused_result));
    //    // -(void)setDelegate:(id<ASPagerDelegate> _Nullable)delegate;
    //    [NullAllowed, Export ("delegate")]
    //    [Verify (MethodToProperty)]
    //    ASPagerDelegate Delegate { get; set; }

    //    // @property (readonly, nonatomic) ASCollectionView * _Nonnull view;
    //    [Export ("view")]
    //    ASCollectionView View { get; }

    //    // @property (readonly, assign, nonatomic) NSInteger currentPageIndex;
    //    [Export ("currentPageIndex")]
    //    nint CurrentPageIndex { get; }

    //    // -(void)scrollToPageAtIndex:(NSInteger)index animated:(BOOL)animated;
    //    [Export ("scrollToPageAtIndex:animated:")]
    //    void ScrollToPageAtIndex (nint index, bool animated);

    //    // -(ASCellNode * _Nonnull)nodeForPageAtIndex:(NSInteger)index __attribute__((warn_unused_result));
    //    [Export ("nodeForPageAtIndex:")]
    //    ASCellNode NodeForPageAtIndex (nint index);

    //    // -(NSInteger)indexOfPageWithNode:(ASCellNode * _Nonnull)node;
    //    [Export ("indexOfPageWithNode:")]
    //    nint IndexOfPageWithNode (ASCellNode node);

    //    // @property (assign, nonatomic) BOOL allowsAutomaticInsetsAdjustment;
    //    [Export ("allowsAutomaticInsetsAdjustment")]
    //    bool AllowsAutomaticInsetsAdjustment { get; set; }
    //}

    //// @interface Beta (ASPagerNode)
    //[Category]
    //[BaseType (typeof(ASPagerNode))]
    //interface ASPagerNode_Beta
    //{
    //}

    // audit-objc-generics: @interface ASNodeController<__covariant DisplayNodeType : ASDisplayNode *> : NSObject <ASInterfaceStateDelegate>
    [BaseType (typeof(NSObject))]
    interface ASNodeController : ASInterfaceStateDelegate
    {
        // @property (nonatomic, strong) DisplayNodeType node;
        [Export ("node", ArgumentSemantic.Strong)]
        ASDisplayNode Node { get; set; }

        // @property (assign, nonatomic) BOOL shouldInvertStrongReference;
        [Export ("shouldInvertStrongReference")]
        bool ShouldInvertStrongReference { get; set; }

        // -(void)loadNode;
        [Export ("loadNode")]
        void LoadNode ();

        //// -(void)didEnterVisibleState __attribute__((objc_requires_super));
        //[Export ("didEnterVisibleState")]
        ////[RequiresSuper]
        //void DidEnterVisibleState ();

        //// -(void)didExitVisibleState __attribute__((objc_requires_super));
        //[Export ("didExitVisibleState")]
        ////[RequiresSuper]
        //void DidExitVisibleState ();

        //// -(void)didEnterDisplayState __attribute__((objc_requires_super));
        //[Export ("didEnterDisplayState")]
        ////[RequiresSuper]
        //void DidEnterDisplayState ();

        //// -(void)didExitDisplayState __attribute__((objc_requires_super));
        //[Export ("didExitDisplayState")]
        ////[RequiresSuper]
        //void DidExitDisplayState ();

        //// -(void)didEnterPreloadState __attribute__((objc_requires_super));
        //[Export ("didEnterPreloadState")]
        ////[RequiresSuper]
        //void DidEnterPreloadState ();

        //// -(void)didExitPreloadState __attribute__((objc_requires_super));
        //[Export ("didExitPreloadState")]
        ////[RequiresSuper]
        //void DidExitPreloadState ();

        //// -(void)interfaceStateDidChange:(ASInterfaceState)newState fromState:(ASInterfaceState)oldState __attribute__((objc_requires_super));
        //[Export ("interfaceStateDidChange:fromState:")]
        ////[RequiresSuper]
        //void InterfaceStateDidChange (ASInterfaceState newState, ASInterfaceState oldState);
    }

    // @interface ASNodeController (ASDisplayNode)
    //[Category]
    //[BaseType (typeof(ASDisplayNode))]
    partial interface ASDisplayNode
    {
        // @property (readonly, nonatomic) ASNodeController * nodeController;
        [Export ("nodeController")]
        ASNodeController NodeController { get; }
    }

    //// @protocol ASVisibilityDepth <NSObject>
    //[Protocol, Model]
    //[BaseType (typeof(NSObject))]
    //interface ASVisibilityDepth
    //{
    //    // @required -(NSInteger)visibilityDepth;
    //    [Abstract]
    //    [Export ("visibilityDepth")]
    //    [Verify (MethodToProperty)]
    //    nint VisibilityDepth { get; }

    //    // @required -(void)visibilityDepthDidChange;
    //    [Abstract]
    //    [Export ("visibilityDepthDidChange")]
    //    void VisibilityDepthDidChange ();
    //}

    //// @protocol ASManagesChildVisibilityDepth <ASVisibilityDepth>
    //[Protocol, Model]
    //interface ASManagesChildVisibilityDepth : IASVisibilityDepth
    //{
    //    // @required -(NSInteger)visibilityDepthOfChildViewController:(UIViewController * _Nonnull)childViewController;
    //    [Abstract]
    //    [Export ("visibilityDepthOfChildViewController:")]
    //    nint VisibilityDepthOfChildViewController (UIViewController childViewController);
    //}

    //// typedef ASTraitCollection * _Nonnull (^ASDisplayTraitsForTraitCollectionBlock)(UITraitCollection * _Nonnull);
    //delegate ASTraitCollection ASDisplayTraitsForTraitCollectionBlock (UITraitCollection arg0);

    //// typedef ASTraitCollection * _Nonnull (^ASDisplayTraitsForTraitWindowSizeBlock)(CGSize);
    //delegate ASTraitCollection ASDisplayTraitsForTraitWindowSizeBlock (CGSize arg0);

    //// audit-objc-generics: @interface ASViewController<__covariant DisplayNodeType : ASDisplayNode *> : UIViewController <ASVisibilityDepth>
    //[BaseType (typeof(UIViewController))]
    //interface ASViewController : IASVisibilityDepth
    //{
    //    // -(instancetype _Nonnull)initWithNode:(DisplayNodeType _Nonnull)node;
    //    [Export ("initWithNode:")]
    //    IntPtr Constructor (ASDisplayNode node);

    //    // @property (readonly, nonatomic, strong) DisplayNodeType _Null_unspecified node;
    //    [Export ("node", ArgumentSemantic.Strong)]
    //    ASDisplayNode Node { get; }

    //    // @property (copy, nonatomic) ASDisplayTraitsForTraitCollectionBlock _Nonnull overrideDisplayTraitsWithTraitCollection;
    //    [Export ("overrideDisplayTraitsWithTraitCollection", ArgumentSemantic.Copy)]
    //    ASDisplayTraitsForTraitCollectionBlock OverrideDisplayTraitsWithTraitCollection { get; set; }

    //    // @property (copy, nonatomic) ASDisplayTraitsForTraitWindowSizeBlock _Nonnull overrideDisplayTraitsWithWindowSize;
    //    [Export ("overrideDisplayTraitsWithWindowSize", ArgumentSemantic.Copy)]
    //    ASDisplayTraitsForTraitWindowSizeBlock OverrideDisplayTraitsWithWindowSize { get; set; }

    //    // @property (readonly, nonatomic) ASInterfaceState interfaceState;
    //    [Export ("interfaceState")]
    //    ASInterfaceState InterfaceState { get; }

    //    // @property (assign, nonatomic) BOOL neverShowPlaceholders;
    //    [Export ("neverShowPlaceholders")]
    //    bool NeverShowPlaceholders { get; set; }
    //}

    //// @interface ASRangeControllerUpdateRangeProtocol (ASViewController)
    //[Category]
    //[BaseType (typeof(ASViewController))]
    //interface ASViewController_ASRangeControllerUpdateRangeProtocol
    //{
    //    // @property (assign, nonatomic) BOOL automaticallyAdjustRangeModeBasedOnViewEvents;
    //    [Export ("automaticallyAdjustRangeModeBasedOnViewEvents")]
    //    bool AutomaticallyAdjustRangeModeBasedOnViewEvents { get; set; }
    //}

    //// @interface ASNavigationController : UINavigationController <ASManagesChildVisibilityDepth>
    //[BaseType (typeof(UINavigationController))]
    //interface ASNavigationController : IASManagesChildVisibilityDepth
    //{
    //}

    //// @interface ASTabBarController : UITabBarController <ASManagesChildVisibilityDepth>
    //[BaseType (typeof(UITabBarController))]
    //interface ASTabBarController : IASManagesChildVisibilityDepth
    //{
    //}

    //// @interface ASEventLog : NSObject
    //[BaseType (typeof(NSObject))]
    //[DisableDefaultCtor]
    //interface ASEventLog
    //{
    //    // -(instancetype _Nonnull)initWithObject:(id _Nonnull)anObject;
    //    [Export ("initWithObject:")]
    //    IntPtr Constructor (NSObject anObject);

    //    // -(void)logEventWithBacktrace:(NSArray<NSString *> * _Nullable)backtrace format:(NSString * _Nonnull)format, ... __attribute__((format(NSString, 2, 3)));
    //    [Internal]
    //    [Export ("logEventWithBacktrace:format:", IsVariadic = true)]
    //    void LogEventWithBacktrace ([NullAllowed] string[] backtrace, string format, IntPtr varArgs);
    //}

    //[Static]
    //[Verify (ConstantsInterfaceAssociation)]
    //partial interface Constants
    //{
    //    // extern NSString *const _Nonnull ASDataControllerRowNodeKind;
    //    [Field ("ASDataControllerRowNodeKind", "__Internal")]
    //    NSString ASDataControllerRowNodeKind { get; }

    //    // extern NSString *const _Nonnull ASCollectionInvalidUpdateException;
    //    [Field ("ASCollectionInvalidUpdateException", "__Internal")]
    //    NSString ASCollectionInvalidUpdateException { get; }
    //}

    //// @protocol ASDataControllerSource <NSObject>
    //[Protocol, Model]
    //[BaseType (typeof(NSObject))]
    //interface ASDataControllerSource
    //{
    //    // @required -(ASCellNodeBlock _Nonnull)dataController:(ASDataController * _Nonnull)dataController nodeBlockAtIndexPath:(NSIndexPath * _Nonnull)indexPath;
    //    [Abstract]
    //    [Export ("dataController:nodeBlockAtIndexPath:")]
    //    ASCellNodeBlock DataController (ASDataController dataController, NSIndexPath indexPath);

    //    // @required -(NSUInteger)dataController:(ASDataController * _Nonnull)dataController rowsInSection:(NSUInteger)section;
    //    [Abstract]
    //    [Export ("dataController:rowsInSection:")]
    //    nuint DataController (ASDataController dataController, nuint section);

    //    // @required -(NSUInteger)numberOfSectionsInDataController:(ASDataController * _Nonnull)dataController;
    //    [Abstract]
    //    [Export ("numberOfSectionsInDataController:")]
    //    nuint NumberOfSectionsInDataController (ASDataController dataController);

    //    // @required -(BOOL)dataController:(ASDataController * _Nonnull)dataController presentedSizeForElement:(ASCollectionElement * _Nonnull)element matchesSize:(CGSize)size;
    //    [Abstract]
    //    [Export ("dataController:presentedSizeForElement:matchesSize:")]
    //    bool DataController (ASDataController dataController, ASCollectionElement element, CGSize size);

    //    // @required -(id _Nullable)dataController:(ASDataController * _Nonnull)dataController nodeModelForItemAtIndexPath:(NSIndexPath * _Nonnull)indexPath;
    //    [Abstract]
    //    [Export ("dataController:nodeModelForItemAtIndexPath:")]
    //    [return: NullAllowed]
    //    NSObject DataController (ASDataController dataController, NSIndexPath indexPath);

    //    // @optional -(ASSizeRange)dataController:(ASDataController * _Nonnull)dataController constrainedSizeForNodeAtIndexPath:(NSIndexPath * _Nonnull)indexPath;
    //    [Export ("dataController:constrainedSizeForNodeAtIndexPath:")]
    //    ASSizeRange DataController (ASDataController dataController, NSIndexPath indexPath);

    //    // @optional -(NSArray<NSString *> * _Nonnull)dataController:(ASDataController * _Nonnull)dataController supplementaryNodeKindsInSections:(NSIndexSet * _Nonnull)sections;
    //    [Export ("dataController:supplementaryNodeKindsInSections:")]
    //    string[] DataController (ASDataController dataController, NSIndexSet sections);

    //    // @optional -(NSUInteger)dataController:(ASDataController * _Nonnull)dataController supplementaryNodesOfKind:(NSString * _Nonnull)kind inSection:(NSUInteger)section;
    //    [Export ("dataController:supplementaryNodesOfKind:inSection:")]
    //    nuint DataController (ASDataController dataController, string kind, nuint section);

    //    // @optional -(ASCellNodeBlock _Nonnull)dataController:(ASDataController * _Nonnull)dataController supplementaryNodeBlockOfKind:(NSString * _Nonnull)kind atIndexPath:(NSIndexPath * _Nonnull)indexPath;
    //    [Export ("dataController:supplementaryNodeBlockOfKind:atIndexPath:")]
    //    ASCellNodeBlock DataController (ASDataController dataController, string kind, NSIndexPath indexPath);

    //    // @optional -(ASSizeRange)dataController:(ASDataController * _Nonnull)dataController constrainedSizeForSupplementaryNodeOfKind:(NSString * _Nonnull)kind atIndexPath:(NSIndexPath * _Nonnull)indexPath;
    //    [Export ("dataController:constrainedSizeForSupplementaryNodeOfKind:atIndexPath:")]
    //    ASSizeRange DataController (ASDataController dataController, string kind, NSIndexPath indexPath);

    //    // @optional -(id<ASSectionContext> _Nullable)dataController:(ASDataController * _Nonnull)dataController contextForSection:(NSInteger)section;
    //    [Export ("dataController:contextForSection:")]
    //    [return: NullAllowed]
    //    ASSectionContext DataController (ASDataController dataController, nint section);
    //}

    //// @protocol ASDataControllerDelegate <NSObject>
    //[Protocol, Model]
    //[BaseType (typeof(NSObject))]
    //interface ASDataControllerDelegate
    //{
    //    // @required -(void)dataController:(ASDataController * _Nonnull)dataController updateWithChangeSet:(_ASHierarchyChangeSet * _Nonnull)changeSet updates:(dispatch_block_t _Nonnull)updates;
    //    [Abstract]
    //    [Export ("dataController:updateWithChangeSet:updates:")]
    //    void UpdateWithChangeSet (ASDataController dataController, _ASHierarchyChangeSet changeSet, dispatch_block_t updates);
    //}

    //// @protocol ASDataControllerLayoutDelegate <NSObject>
    //[Protocol, Model]
    //[BaseType (typeof(NSObject))]
    //interface ASDataControllerLayoutDelegate
    //{
    //    // @required -(ASCollectionLayoutContext * _Nonnull)layoutContextWithElements:(ASElementMap * _Nonnull)elements;
    //    [Abstract]
    //    [Export ("layoutContextWithElements:")]
    //    ASCollectionLayoutContext LayoutContextWithElements (ASElementMap elements);

    //    // @required +(ASCollectionLayoutState * _Nonnull)calculateLayoutWithContext:(ASCollectionLayoutContext * _Nonnull)context;
    //    [Static, Abstract]
    //    [Export ("calculateLayoutWithContext:")]
    //    ASCollectionLayoutState CalculateLayoutWithContext (ASCollectionLayoutContext context);
    //}

    //// @interface ASDataController : NSObject
    //[BaseType (typeof(NSObject))]
    //[DisableDefaultCtor]
    //interface ASDataController
    //{
    //    // -(instancetype _Nonnull)initWithDataSource:(id<ASDataControllerSource> _Nonnull)dataSource node:(id<ASRangeManagingNode> _Nullable)node eventLog:(ASEventLog * _Nullable)eventLog __attribute__((objc_designated_initializer));
    //    [Export ("initWithDataSource:node:eventLog:")]
    //    [DesignatedInitializer]
    //    IntPtr Constructor (ASDataControllerSource dataSource, [NullAllowed] ASRangeManagingNode node, [NullAllowed] ASEventLog eventLog);

    //    // @property (readonly, nonatomic, weak) id<ASRangeManagingNode> _Nullable node;
    //    [NullAllowed, Export ("node", ArgumentSemantic.Weak)]
    //    ASRangeManagingNode Node { get; }

    //    // @property (readonly, copy, atomic) ASElementMap * _Nonnull visibleMap;
    //    [Export ("visibleMap", ArgumentSemantic.Copy)]
    //    ASElementMap VisibleMap { get; }

    //    // @property (readonly, copy, atomic) ASElementMap * _Nonnull pendingMap;
    //    [Export ("pendingMap", ArgumentSemantic.Copy)]
    //    ASElementMap PendingMap { get; }

    //    // @property (readonly, nonatomic, weak) id<ASDataControllerSource> _Nullable dataSource;
    //    [NullAllowed, Export ("dataSource", ArgumentSemantic.Weak)]
    //    ASDataControllerSource DataSource { get; }

    //    // @property (nonatomic, weak) id _Nullable validationErrorSource;
    //    [NullAllowed, Export ("validationErrorSource", ArgumentSemantic.Weak)]
    //    NSObject ValidationErrorSource { get; set; }

    //    [Wrap ("WeakDelegate")]
    //    [NullAllowed]
    //    ASDataControllerDelegate Delegate { get; set; }

    //    // @property (nonatomic, weak) id<ASDataControllerDelegate> _Nullable delegate;
    //    [NullAllowed, Export ("delegate", ArgumentSemantic.Weak)]
    //    NSObject WeakDelegate { get; set; }

    //    [Wrap ("WeakLayoutDelegate")]
    //    [NullAllowed]
    //    ASDataControllerLayoutDelegate LayoutDelegate { get; set; }

    //    // @property (nonatomic, weak) id<ASDataControllerLayoutDelegate> _Nullable layoutDelegate;
    //    [NullAllowed, Export ("layoutDelegate", ArgumentSemantic.Weak)]
    //    NSObject WeakLayoutDelegate { get; set; }

    //    // @property (readonly, nonatomic) BOOL initialReloadDataHasBeenCalled;
    //    [Export ("initialReloadDataHasBeenCalled")]
    //    bool InitialReloadDataHasBeenCalled { get; }

    //    // @property (assign, nonatomic) BOOL usesSynchronousDataLoading;
    //    [Export ("usesSynchronousDataLoading")]
    //    bool UsesSynchronousDataLoading { get; set; }

    //    // -(void)updateWithChangeSet:(_ASHierarchyChangeSet * _Nonnull)changeSet;
    //    [Export ("updateWithChangeSet:")]
    //    void UpdateWithChangeSet (_ASHierarchyChangeSet changeSet);

    //    // -(void)relayoutAllNodes;
    //    [Export ("relayoutAllNodes")]
    //    void RelayoutAllNodes ();

    //    // -(void)relayoutNodes:(id<NSFastEnumeration> _Nonnull)nodes nodesSizeChanged:(NSMutableArray * _Nonnull)nodesSizesChanged;
    //    [Export ("relayoutNodes:nodesSizeChanged:")]
    //    void RelayoutNodes (NSFastEnumeration nodes, NSMutableArray nodesSizesChanged);

    //    // @property (readonly, nonatomic) BOOL isProcessingUpdates;
    //    [Export ("isProcessingUpdates")]
    //    bool IsProcessingUpdates { get; }

    //    // -(void)onDidFinishProcessingUpdates:(void (^ _Nullable)())completion;
    //    [Export ("onDidFinishProcessingUpdates:")]
    //    void OnDidFinishProcessingUpdates ([NullAllowed] Action completion);

    //    // -(void)waitUntilAllUpdatesAreProcessed;
    //    [Export ("waitUntilAllUpdatesAreProcessed")]
    //    void WaitUntilAllUpdatesAreProcessed ();

    //    // -(void)environmentDidChange;
    //    [Export ("environmentDidChange")]
    //    void EnvironmentDidChange ();
    //}

    //[Static]
    //[Verify (ConstantsInterfaceAssociation)]
    //partial interface Constants
    //{
    //    // extern const CGPoint ASPointNull;
    //    [Field ("ASPointNull", "__Internal")]
    //    CGPoint ASPointNull { get; }
    //}

    // @interface ASLayout : NSObject
    [BaseType (typeof(NSObject))]
    interface ASLayout
    {
        // @property (readonly, nonatomic, weak) id<ASLayoutElement> _Nullable layoutElement;
        [NullAllowed, Export ("layoutElement", ArgumentSemantic.Weak)]
        IASLayoutElement LayoutElement { get; }

        // @property (readonly, assign, nonatomic) ASLayoutElementType type;
        [Export ("type", ArgumentSemantic.Assign)]
        ASLayoutElementType Type { get; }

        // @property (readonly, assign, nonatomic) CGSize size;
        [Export ("size", ArgumentSemantic.Assign)]
        CGSize Size { get; }

        // @property (readonly, assign, nonatomic) CGPoint position;
        [Export ("position", ArgumentSemantic.Assign)]
        CGPoint Position { get; }

        // @property (readonly, copy, nonatomic) NSArray<ASLayout *> * _Nonnull sublayouts;
        [Export ("sublayouts", ArgumentSemantic.Copy)]
        ASLayout[] Sublayouts { get; }

        // -(CGRect)frameForElement:(id<ASLayoutElement> _Nonnull)layoutElement;
        [Export ("frameForElement:")]
        CGRect FrameForElement (IASLayoutElement layoutElement);

        // @property (readonly, assign, nonatomic) CGRect frame;
        [Export ("frame", ArgumentSemantic.Assign)]
        CGRect Frame { get; }

        // -(instancetype _Nonnull)initWithLayoutElement:(id<ASLayoutElement> _Nonnull)layoutElement size:(CGSize)size position:(CGPoint)position sublayouts:(NSArray<ASLayout *> * _Nullable)sublayouts __attribute__((objc_designated_initializer));
        [Export ("initWithLayoutElement:size:position:sublayouts:")]
        [DesignatedInitializer]
        IntPtr Constructor (IASLayoutElement layoutElement, CGSize size, CGPoint position, [NullAllowed] ASLayout[] sublayouts);

        // +(instancetype _Nonnull)layoutWithLayoutElement:(id<ASLayoutElement> _Nonnull)layoutElement size:(CGSize)size position:(CGPoint)position sublayouts:(NSArray<ASLayout *> * _Nullable)sublayouts __attribute__((warn_unused_result));
        [Static]
        [Export ("layoutWithLayoutElement:size:position:sublayouts:")]
        ASLayout LayoutWithLayoutElement (IASLayoutElement layoutElement, CGSize size, CGPoint position, [NullAllowed] ASLayout[] sublayouts);

        // +(instancetype _Nonnull)layoutWithLayoutElement:(id<ASLayoutElement> _Nonnull)layoutElement size:(CGSize)size sublayouts:(NSArray<ASLayout *> * _Nullable)sublayouts __attribute__((warn_unused_result));
        [Static]
        [Export ("layoutWithLayoutElement:size:sublayouts:")]
        ASLayout LayoutWithLayoutElement (IASLayoutElement layoutElement, CGSize size, [NullAllowed] ASLayout[] sublayouts);

        // +(instancetype _Nonnull)layoutWithLayoutElement:(id<ASLayoutElement> _Nonnull)layoutElement size:(CGSize)size __attribute__((warn_unused_result));
        [Static]
        [Export ("layoutWithLayoutElement:size:")]
        ASLayout LayoutWithLayoutElement (IASLayoutElement layoutElement, CGSize size);

        // -(ASLayout * _Nonnull)filteredNodeLayoutTree __attribute__((warn_unused_result));
        [Export ("filteredNodeLayoutTree")]
        ASLayout FilteredNodeLayoutTree { get; }
    }

    //// @interface Unavailable (ASLayout)
    //[Category]
    //[BaseType (typeof(ASLayout))]
    //[DisableDefaultCtor]
    //interface ASLayout_Unavailable
    //{
    //}

    //// @interface Debugging (ASLayout)
    //[Category]
    //[BaseType (typeof(ASLayout))]
    //interface ASLayout_Debugging
    //{
    //    // +(BOOL)shouldRetainSublayoutLayoutElements;
    //    // +(void)setShouldRetainSublayoutLayoutElements:(BOOL)shouldRetain;
    //    [Static]
    //    [Export ("shouldRetainSublayoutLayoutElements")]
    //    [Verify (MethodToProperty)]
    //    bool ShouldRetainSublayoutLayoutElements { get; set; }

    //    // -(NSString * _Nonnull)recursiveDescription;
    //    [Export ("recursiveDescription")]
    //    [Verify (MethodToProperty)]
    //    string RecursiveDescription { get; }
    //}

    // @interface ASLayoutSpec : NSObject <ASLayoutElement, ASLayoutElementStylability, NSFastEnumeration, ASDescriptionProvider>
    [BaseType (typeof(NSObject))]
    interface ASLayoutSpec : ASLayoutElement, ASLayoutElementStylability
    //, INSFastEnumeration, IASDescriptionProvider
    {
        // @property (assign, nonatomic) BOOL isMutable;
        [Export ("isMutable")]
        bool IsMutable { get; set; }

        // @property (nonatomic, strong) id<ASLayoutElement> _Nullable child;
        [NullAllowed, Export ("child", ArgumentSemantic.Strong)]
        IASLayoutElement Child { get; set; }

        // @property (nonatomic, strong) NSArray<id<ASLayoutElement>> * _Nullable children;
        [NullAllowed, Export ("children", ArgumentSemantic.Strong)]
        IASLayoutElement[] Children { get; set; }
    }

    // @interface ASWrapperLayoutSpec : ASLayoutSpec
    [BaseType (typeof(ASLayoutSpec))]
    [DisableDefaultCtor]
    interface ASWrapperLayoutSpec
    {
        // +(instancetype _Nonnull)wrapperWithLayoutElement:(id<ASLayoutElement> _Nonnull)layoutElement __attribute__((warn_unused_result));
        [Static]
        [Export ("wrapperWithLayoutElement:")]
        ASWrapperLayoutSpec WrapperWithLayoutElement (IASLayoutElement layoutElement);

        // +(instancetype _Nonnull)wrapperWithLayoutElements:(NSArray<id<ASLayoutElement>> * _Nonnull)layoutElements __attribute__((warn_unused_result));
        [Static]
        [Export ("wrapperWithLayoutElements:")]
        ASWrapperLayoutSpec WrapperWithLayoutElements (IASLayoutElement[] layoutElements);

        // -(instancetype _Nonnull)initWithLayoutElement:(id<ASLayoutElement> _Nonnull)layoutElement __attribute__((warn_unused_result));
        [Export ("initWithLayoutElement:")]
        IntPtr Constructor (IASLayoutElement layoutElement);

        // -(instancetype _Nonnull)initWithLayoutElements:(NSArray<id<ASLayoutElement>> * _Nonnull)layoutElements __attribute__((warn_unused_result));
        [Export ("initWithLayoutElements:")]
        IntPtr Constructor (IASLayoutElement[] layoutElements);
    }

    //// @interface Debugging (ASLayoutSpec) <ASDebugNameProvider>
    //[Category]
    //[BaseType (typeof(ASLayoutSpec))]
    //interface ASLayoutSpec_Debugging : IASDebugNameProvider
    //{
    //    // +(NSString * _Nonnull)asciiArtStringForChildren:(NSArray * _Nonnull)children parentName:(NSString * _Nonnull)parentName direction:(ASStackLayoutDirection)direction;
    //    [Static]
    //    [Export ("asciiArtStringForChildren:parentName:direction:")]
    //    [Verify (StronglyTypedNSArray)]
    //    string AsciiArtStringForChildren (NSObject[] children, string parentName, ASStackLayoutDirection direction);

    //    // +(NSString * _Nonnull)asciiArtStringForChildren:(NSArray * _Nonnull)children parentName:(NSString * _Nonnull)parentName;
    //    [Static]
    //    [Export ("asciiArtStringForChildren:parentName:")]
    //    [Verify (StronglyTypedNSArray)]
    //    string AsciiArtStringForChildren (NSObject[] children, string parentName);
    //}

    // @interface ASBackgroundLayoutSpec : ASLayoutSpec
    [BaseType (typeof(ASLayoutSpec))]
    interface ASBackgroundLayoutSpec
    {
        // @property (nonatomic, strong) id<ASLayoutElement> _Nonnull background;
        [Export ("background", ArgumentSemantic.Strong)]
        IASLayoutElement Background { get; set; }

        // +(instancetype _Nonnull)backgroundLayoutSpecWithChild:(id<ASLayoutElement> _Nonnull)child background:(id<ASLayoutElement> _Nonnull)background __attribute__((warn_unused_result));
        [Static]
        [Export ("backgroundLayoutSpecWithChild:background:")]
        ASBackgroundLayoutSpec BackgroundLayoutSpecWithChild (IASLayoutElement child, IASLayoutElement background);
    }

    // @interface ASRelativeLayoutSpec : ASLayoutSpec
    [BaseType (typeof(ASLayoutSpec))]
    interface ASRelativeLayoutSpec
    {
        // @property (assign, nonatomic) ASRelativeLayoutSpecPosition horizontalPosition;
        [Export ("horizontalPosition", ArgumentSemantic.Assign)]
        ASRelativeLayoutSpecPosition HorizontalPosition { get; set; }

        // @property (assign, nonatomic) ASRelativeLayoutSpecPosition verticalPosition;
        [Export ("verticalPosition", ArgumentSemantic.Assign)]
        ASRelativeLayoutSpecPosition VerticalPosition { get; set; }

        // @property (assign, nonatomic) ASRelativeLayoutSpecSizingOption sizingOption;
        [Export ("sizingOption", ArgumentSemantic.Assign)]
        ASRelativeLayoutSpecSizingOption SizingOption { get; set; }

        // +(instancetype _Nonnull)relativePositionLayoutSpecWithHorizontalPosition:(ASRelativeLayoutSpecPosition)horizontalPosition verticalPosition:(ASRelativeLayoutSpecPosition)verticalPosition sizingOption:(ASRelativeLayoutSpecSizingOption)sizingOption child:(id<ASLayoutElement> _Nonnull)child __attribute__((warn_unused_result));
        [Static]
        [Export ("relativePositionLayoutSpecWithHorizontalPosition:verticalPosition:sizingOption:child:")]
        ASRelativeLayoutSpec RelativePositionLayoutSpecWithHorizontalPosition (ASRelativeLayoutSpecPosition horizontalPosition, ASRelativeLayoutSpecPosition verticalPosition, ASRelativeLayoutSpecSizingOption sizingOption, IASLayoutElement child);

        // -(instancetype _Nonnull)initWithHorizontalPosition:(ASRelativeLayoutSpecPosition)horizontalPosition verticalPosition:(ASRelativeLayoutSpecPosition)verticalPosition sizingOption:(ASRelativeLayoutSpecSizingOption)sizingOption child:(id<ASLayoutElement> _Nonnull)child;
        [Export ("initWithHorizontalPosition:verticalPosition:sizingOption:child:")]
        IntPtr Constructor (ASRelativeLayoutSpecPosition horizontalPosition, ASRelativeLayoutSpecPosition verticalPosition, ASRelativeLayoutSpecSizingOption sizingOption, IASLayoutElement child);
    }

    // @interface ASCenterLayoutSpec : ASRelativeLayoutSpec
    [BaseType (typeof(ASRelativeLayoutSpec))]
    interface ASCenterLayoutSpec
    {
        // @property (assign, nonatomic) ASCenterLayoutSpecCenteringOptions centeringOptions;
        [Export ("centeringOptions", ArgumentSemantic.Assign)]
        ASCenterLayoutSpecCenteringOptions CenteringOptions { get; set; }

        // @property (assign, nonatomic) ASCenterLayoutSpecSizingOptions sizingOptions;
        [Export ("sizingOptions", ArgumentSemantic.Assign)]
        ASCenterLayoutSpecSizingOptions SizingOptions { get; set; }

        // +(instancetype _Nonnull)centerLayoutSpecWithCenteringOptions:(ASCenterLayoutSpecCenteringOptions)centeringOptions sizingOptions:(ASCenterLayoutSpecSizingOptions)sizingOptions child:(id<ASLayoutElement> _Nonnull)child __attribute__((warn_unused_result));
        [Static]
        [Export ("centerLayoutSpecWithCenteringOptions:sizingOptions:child:")]
        ASCenterLayoutSpec CenterLayoutSpecWithCenteringOptions (ASCenterLayoutSpecCenteringOptions centeringOptions, ASCenterLayoutSpecSizingOptions sizingOptions, IASLayoutElement child);
    }

    // @interface ASInsetLayoutSpec : ASLayoutSpec
    [BaseType (typeof(ASLayoutSpec))]
    interface ASInsetLayoutSpec
    {
        // @property (assign, nonatomic) UIEdgeInsets insets;
        [Export ("insets", ArgumentSemantic.Assign)]
        UIEdgeInsets Insets { get; set; }

        // +(instancetype _Nonnull)insetLayoutSpecWithInsets:(UIEdgeInsets)insets child:(id<ASLayoutElement> _Nonnull)child __attribute__((warn_unused_result));
        [Static]
        [Export ("insetLayoutSpecWithInsets:child:")]
        ASInsetLayoutSpec InsetLayoutSpecWithInsets (UIEdgeInsets insets, IASLayoutElement child);
    }

    interface IASInsetLayoutSpec {}

    // @interface ASOverlayLayoutSpec : ASLayoutSpec
    [BaseType (typeof(ASLayoutSpec))]
    interface ASOverlayLayoutSpec
    {
        // @property (nonatomic, strong) id<ASLayoutElement> _Nonnull overlay;
        [Export ("overlay", ArgumentSemantic.Strong)]
        IASLayoutElement Overlay { get; set; }

        // +(instancetype _Nonnull)overlayLayoutSpecWithChild:(id<ASLayoutElement> _Nonnull)child overlay:(id<ASLayoutElement> _Nonnull)overlay __attribute__((warn_unused_result));
        [Static]
        [Export ("overlayLayoutSpecWithChild:overlay:")]
        ASOverlayLayoutSpec OverlayLayoutSpecWithChild (IASLayoutElement child, IASLayoutElement overlay);
    }

    // @interface ASRatioLayoutSpec : ASLayoutSpec
    [BaseType (typeof(ASLayoutSpec))]
    interface ASRatioLayoutSpec
    {
        // @property (assign, nonatomic) CGFloat ratio;
        [Export ("ratio")]
        nfloat Ratio { get; set; }

        // +(instancetype _Nonnull)ratioLayoutSpecWithRatio:(CGFloat)ratio child:(id<ASLayoutElement> _Nonnull)child __attribute__((warn_unused_result));
        [Static]
        [Export ("ratioLayoutSpecWithRatio:child:")]
        ASRatioLayoutSpec RatioLayoutSpecWithRatio (nfloat ratio, IASLayoutElement child);
    }

    // @interface ASAbsoluteLayoutSpec : ASLayoutSpec
    [BaseType (typeof(ASLayoutSpec))]
    interface ASAbsoluteLayoutSpec
    {
        // @property (assign, nonatomic) ASAbsoluteLayoutSpecSizing sizing;
        [Export ("sizing", ArgumentSemantic.Assign)]
        ASAbsoluteLayoutSpecSizing Sizing { get; set; }

        // +(instancetype _Nonnull)absoluteLayoutSpecWithSizing:(ASAbsoluteLayoutSpecSizing)sizing children:(NSArray<id<ASLayoutElement>> * _Nonnull)children __attribute__((warn_unused_result));
        [Static]
        [Export ("absoluteLayoutSpecWithSizing:children:")]
        ASAbsoluteLayoutSpec AbsoluteLayoutSpecWithSizing (ASAbsoluteLayoutSpecSizing sizing, IASLayoutElement[] children);

        // +(instancetype _Nonnull)absoluteLayoutSpecWithChildren:(NSArray<id<ASLayoutElement>> * _Nonnull)children __attribute__((warn_unused_result));
        [Static]
        [Export ("absoluteLayoutSpecWithChildren:")]
        ASAbsoluteLayoutSpec AbsoluteLayoutSpecWithChildren (IASLayoutElement[] children);
    }

    // @interface ASStackLayoutSpec : ASLayoutSpec
    [BaseType (typeof(ASLayoutSpec))]
    interface ASStackLayoutSpec
    {
        // @property (assign, nonatomic) ASStackLayoutDirection direction;
        [Export ("direction", ArgumentSemantic.Assign)]
        ASStackLayoutDirection Direction { get; set; }

        // @property (assign, nonatomic) CGFloat spacing;
        [Export ("spacing")]
        nfloat Spacing { get; set; }

        // @property (assign, nonatomic) ASHorizontalAlignment horizontalAlignment;
        [Export ("horizontalAlignment", ArgumentSemantic.Assign)]
        ASHorizontalAlignment HorizontalAlignment { get; set; }

        // @property (assign, nonatomic) ASVerticalAlignment verticalAlignment;
        [Export ("verticalAlignment", ArgumentSemantic.Assign)]
        ASVerticalAlignment VerticalAlignment { get; set; }

        // @property (assign, nonatomic) ASStackLayoutJustifyContent justifyContent;
        [Export ("justifyContent", ArgumentSemantic.Assign)]
        ASStackLayoutJustifyContent JustifyContent { get; set; }

        // @property (assign, nonatomic) ASStackLayoutAlignItems alignItems;
        [Export ("alignItems", ArgumentSemantic.Assign)]
        ASStackLayoutAlignItems AlignItems { get; set; }

        // @property (assign, nonatomic) ASStackLayoutFlexWrap flexWrap;
        [Export ("flexWrap", ArgumentSemantic.Assign)]
        ASStackLayoutFlexWrap FlexWrap { get; set; }

        // @property (assign, nonatomic) ASStackLayoutAlignContent alignContent;
        [Export ("alignContent", ArgumentSemantic.Assign)]
        ASStackLayoutAlignContent AlignContent { get; set; }

        // @property (assign, nonatomic) CGFloat lineSpacing;
        [Export ("lineSpacing")]
        nfloat LineSpacing { get; set; }

        // @property (getter = isConcurrent, assign, nonatomic) BOOL concurrent;
        [Export ("concurrent")]
        bool Concurrent { [Bind ("isConcurrent")] get; set; }

        // +(instancetype _Nonnull)stackLayoutSpecWithDirection:(ASStackLayoutDirection)direction spacing:(CGFloat)spacing justifyContent:(ASStackLayoutJustifyContent)justifyContent alignItems:(ASStackLayoutAlignItems)alignItems children:(NSArray<id<ASLayoutElement>> * _Nonnull)children __attribute__((warn_unused_result));
        [Static]
        [Export ("stackLayoutSpecWithDirection:spacing:justifyContent:alignItems:children:")]
        ASStackLayoutSpec StackLayoutSpecWithDirection (ASStackLayoutDirection direction, nfloat spacing, ASStackLayoutJustifyContent justifyContent, ASStackLayoutAlignItems alignItems, IASLayoutElement[] children);

        // +(instancetype _Nonnull)stackLayoutSpecWithDirection:(ASStackLayoutDirection)direction spacing:(CGFloat)spacing justifyContent:(ASStackLayoutJustifyContent)justifyContent alignItems:(ASStackLayoutAlignItems)alignItems flexWrap:(ASStackLayoutFlexWrap)flexWrap alignContent:(ASStackLayoutAlignContent)alignContent children:(NSArray<id<ASLayoutElement>> * _Nonnull)children __attribute__((warn_unused_result));
        [Static]
        [Export ("stackLayoutSpecWithDirection:spacing:justifyContent:alignItems:flexWrap:alignContent:children:")]
        ASStackLayoutSpec StackLayoutSpecWithDirection (ASStackLayoutDirection direction, nfloat spacing, ASStackLayoutJustifyContent justifyContent, ASStackLayoutAlignItems alignItems, ASStackLayoutFlexWrap flexWrap, ASStackLayoutAlignContent alignContent, IASLayoutElement[] children);

        // +(instancetype _Nonnull)stackLayoutSpecWithDirection:(ASStackLayoutDirection)direction spacing:(CGFloat)spacing justifyContent:(ASStackLayoutJustifyContent)justifyContent alignItems:(ASStackLayoutAlignItems)alignItems flexWrap:(ASStackLayoutFlexWrap)flexWrap alignContent:(ASStackLayoutAlignContent)alignContent lineSpacing:(CGFloat)lineSpacing children:(NSArray<id<ASLayoutElement>> * _Nonnull)children __attribute__((warn_unused_result));
        [Static]
        [Export ("stackLayoutSpecWithDirection:spacing:justifyContent:alignItems:flexWrap:alignContent:lineSpacing:children:")]
        ASStackLayoutSpec StackLayoutSpecWithDirection (ASStackLayoutDirection direction, nfloat spacing, ASStackLayoutJustifyContent justifyContent, ASStackLayoutAlignItems alignItems, ASStackLayoutFlexWrap flexWrap, ASStackLayoutAlignContent alignContent, nfloat lineSpacing, IASLayoutElement[] children);

        // +(instancetype _Nonnull)verticalStackLayoutSpec __attribute__((warn_unused_result));
        [Static]
        [Export ("verticalStackLayoutSpec")]
        ASStackLayoutSpec VerticalStackLayoutSpec ();

        // +(instancetype _Nonnull)horizontalStackLayoutSpec __attribute__((warn_unused_result));
        [Static]
        [Export ("horizontalStackLayoutSpec")]
        ASStackLayoutSpec HorizontalStackLayoutSpec ();
    }

    // typedef void (^asyncdisplaykit_async_transaction_completion_block_t)(_ASAsyncTransaction * _Nonnull, BOOL);
    delegate void asyncdisplaykit_async_transaction_completion_block_t (_ASAsyncTransaction arg0, bool arg1);

    // typedef id<NSObject> _Nullable (^asyncdisplaykit_async_transaction_operation_block_t)();
    delegate NSObject asyncdisplaykit_async_transaction_operation_block_t ();

    // typedef void (^asyncdisplaykit_async_transaction_operation_completion_block_t)(id _Nullable, BOOL);
    delegate void asyncdisplaykit_async_transaction_operation_completion_block_t ([NullAllowed] NSObject arg0, bool arg1);

    // typedef void (^asyncdisplaykit_async_transaction_complete_async_operation_block_t)(id _Nullable);
    delegate void asyncdisplaykit_async_transaction_complete_async_operation_block_t ([NullAllowed] NSObject arg0);

    // typedef void (^asyncdisplaykit_async_transaction_async_operation_block_t)(asyncdisplaykit_async_transaction_complete_async_operation_block_t _Nonnull);
    delegate void asyncdisplaykit_async_transaction_async_operation_block_t (asyncdisplaykit_async_transaction_complete_async_operation_block_t arg0);

    //[Static]
    //[Verify (ConstantsInterfaceAssociation)]
    //partial interface Constants
    //{
    //    // extern const NSInteger ASDefaultTransactionPriority;
    //    [Field ("ASDefaultTransactionPriority", "__Internal")]
    //    nint ASDefaultTransactionPriority { get; }
    //}

    // @interface _ASAsyncTransaction : NSObject
    [BaseType (typeof(NSObject))]
    interface _ASAsyncTransaction
    {
        // -(instancetype _Nonnull)initWithCompletionBlock:(asyncdisplaykit_async_transaction_completion_block_t _Nullable)completionBlock;
        [Export ("initWithCompletionBlock:")]
        IntPtr Constructor ([NullAllowed] asyncdisplaykit_async_transaction_completion_block_t completionBlock);

        // -(void)waitUntilComplete;
        [Export ("waitUntilComplete")]
        void WaitUntilComplete ();

        // @property (readonly, copy, nonatomic) asyncdisplaykit_async_transaction_completion_block_t _Nullable completionBlock;
        [NullAllowed, Export ("completionBlock", ArgumentSemantic.Copy)]
        asyncdisplaykit_async_transaction_completion_block_t CompletionBlock { get; }

        // @property (readonly, assign) ASAsyncTransactionState state;
        [Export ("state", ArgumentSemantic.Assign)]
        ASAsyncTransactionState State { get; }

        // -(void)addOperationWithBlock:(asyncdisplaykit_async_transaction_operation_block_t _Nonnull)block queue:(dispatch_queue_t _Nonnull)queue completion:(asyncdisplaykit_async_transaction_operation_completion_block_t _Nullable)completion;
        [Export ("addOperationWithBlock:queue:completion:")]
        void AddOperationWithBlock (asyncdisplaykit_async_transaction_operation_block_t block, DispatchQueue queue, [NullAllowed] asyncdisplaykit_async_transaction_operation_completion_block_t completion);

        // -(void)addOperationWithBlock:(asyncdisplaykit_async_transaction_operation_block_t _Nonnull)block priority:(NSInteger)priority queue:(dispatch_queue_t _Nonnull)queue completion:(asyncdisplaykit_async_transaction_operation_completion_block_t _Nullable)completion;
        [Export ("addOperationWithBlock:priority:queue:completion:")]
        void AddOperationWithBlock (asyncdisplaykit_async_transaction_operation_block_t block, nint priority, DispatchQueue queue, [NullAllowed] asyncdisplaykit_async_transaction_operation_completion_block_t completion);

        // -(void)addAsyncOperationWithBlock:(asyncdisplaykit_async_transaction_async_operation_block_t _Nonnull)block queue:(dispatch_queue_t _Nonnull)queue completion:(asyncdisplaykit_async_transaction_operation_completion_block_t _Nullable)completion;
        [Export ("addAsyncOperationWithBlock:queue:completion:")]
        void AddAsyncOperationWithBlock (asyncdisplaykit_async_transaction_async_operation_block_t block, DispatchQueue queue, [NullAllowed] asyncdisplaykit_async_transaction_operation_completion_block_t completion);

        // -(void)addAsyncOperationWithBlock:(asyncdisplaykit_async_transaction_async_operation_block_t _Nonnull)block priority:(NSInteger)priority queue:(dispatch_queue_t _Nonnull)queue completion:(asyncdisplaykit_async_transaction_operation_completion_block_t _Nullable)completion;
        [Export ("addAsyncOperationWithBlock:priority:queue:completion:")]
        void AddAsyncOperationWithBlock (asyncdisplaykit_async_transaction_async_operation_block_t block, nint priority, DispatchQueue queue, [NullAllowed] asyncdisplaykit_async_transaction_operation_completion_block_t completion);

        // -(void)addCompletionBlock:(asyncdisplaykit_async_transaction_completion_block_t _Nonnull)completion;
        [Export ("addCompletionBlock:")]
        void AddCompletionBlock (asyncdisplaykit_async_transaction_completion_block_t completion);

        // -(void)cancel;
        [Export ("cancel")]
        void Cancel ();

        // -(void)commit;
        [Export ("commit")]
        void Commit ();
    }

    //// @interface _ASAsyncTransactionGroup : NSObject
    //[BaseType (typeof(NSObject))]
    //interface _ASAsyncTransactionGroup
    //{
    //    // +(_ASAsyncTransactionGroup * _Nonnull)mainTransactionGroup;
    //    [Static]
    //    [Export ("mainTransactionGroup")]
    //    [Verify (MethodToProperty)]
    //    _ASAsyncTransactionGroup MainTransactionGroup { get; }

    //    // +(void)commit;
    //    [Static]
    //    [Export ("commit")]
    //    void Commit ();

    //    // -(void)addTransactionContainer:(id<ASAsyncTransactionContainer> _Nonnull)container;
    //    [Export ("addTransactionContainer:")]
    //    void AddTransactionContainer (ASAsyncTransactionContainer container);
    //}

    // @interface _ASDisplayLayer : CALayer
    [BaseType (typeof(CALayer))]
    interface _ASDisplayLayer
    {
        // @property (nonatomic, weak) ASDisplayNode * asyncdisplaykit_node;
        [Export ("asyncdisplaykit_node", ArgumentSemantic.Weak)]
        ASDisplayNode Asyncdisplaykit_node { get; set; }

        // @property (assign, nonatomic) BOOL displaysAsynchronously;
        [Export ("displaysAsynchronously")]
        bool DisplaysAsynchronously { get; set; }

        // -(void)cancelAsyncDisplay;
        [Export ("cancelAsyncDisplay")]
        void CancelAsyncDisplay ();

        // +(dispatch_queue_t)displayQueue;
        [Static]
        [Export ("displayQueue")]
        //[Verify (MethodToProperty)]
        DispatchQueue DisplayQueue { get; }

        //[Wrap ("WeakAsyncDelegate")]
        //_ASDisplayLayerDelegate AsyncDelegate { get; set; }

        // @property (atomic, weak) id<_ASDisplayLayerDelegate> asyncDelegate;
        [NullAllowed, Export ("asyncDelegate", ArgumentSemantic.Weak)]
        NSObject WeakAsyncDelegate { get; set; }

        // @property (getter = isDisplaySuspended, assign, nonatomic) BOOL displaySuspended;
        [Export ("displaySuspended")]
        bool DisplaySuspended { [Bind ("isDisplaySuspended")] get; set; }

        // -(void)displayImmediately;
        [Export ("displayImmediately")]
        void DisplayImmediately ();
    }

    //// @protocol ASCALayerExtendedDelegate
    //[Protocol, Model]
    //interface ASCALayerExtendedDelegate
    //{
    //    // @optional -(void)layer:(CALayer *)layer didChangeBoundsWithOldValue:(CGRect)oldBounds newValue:(CGRect)newBounds;
    //    [Export ("layer:didChangeBoundsWithOldValue:newValue:")]
    //    void DidChangeBoundsWithOldValue (CALayer layer, CGRect oldBounds, CGRect newBounds);
    //}

    //// @protocol _ASDisplayLayerDelegate <NSObject>
    //[Protocol, Model]
    //[BaseType (typeof(NSObject))]
    //interface _ASDisplayLayerDelegate
    //{
    //    // @optional +(void)drawRect:(CGRect)bounds withParameters:(id)parameters isCancelled:(asdisplaynode_iscancelled_block_t)isCancelledBlock isRasterizing:(BOOL)isRasterizing;
    //    [Static]
    //    [Export ("drawRect:withParameters:isCancelled:isRasterizing:")]
    //    void DrawRect (CGRect bounds, NSObject parameters, asdisplaynode_iscancelled_block_t isCancelledBlock, bool isRasterizing);

    //    // @optional +(UIImage *)displayWithParameters:(id<NSObject>)parameters isCancelled:(asdisplaynode_iscancelled_block_t)isCancelledBlock;
    //    [Static]
    //    [Export ("displayWithParameters:isCancelled:")]
    //    UIImage DisplayWithParameters (NSObject parameters, asdisplaynode_iscancelled_block_t isCancelledBlock);

    //    // @optional -(NSObject *)drawParametersForAsyncLayer:(_ASDisplayLayer *)layer;
    //    [Export ("drawParametersForAsyncLayer:")]
    //    NSObject DrawParametersForAsyncLayer (_ASDisplayLayer layer);

    //    // @optional -(void)willDisplayAsyncLayer:(_ASDisplayLayer *)layer asynchronously:(BOOL)asynchronously;
    //    [Export ("willDisplayAsyncLayer:asynchronously:")]
    //    void WillDisplayAsyncLayer (_ASDisplayLayer layer, bool asynchronously);

    //    // @optional -(void)didDisplayAsyncLayer:(_ASDisplayLayer *)layer;
    //    [Export ("didDisplayAsyncLayer:")]
    //    void DidDisplayAsyncLayer (_ASDisplayLayer layer);

    //    // @optional -(void)displayAsyncLayer:(_ASDisplayLayer *)asyncLayer asynchronously:(BOOL)asynchronously;
    //    [Export ("displayAsyncLayer:asynchronously:")]
    //    void DisplayAsyncLayer (_ASDisplayLayer asyncLayer, bool asynchronously);

    //    // @optional -(void)cancelDisplayAsyncLayer:(_ASDisplayLayer *)asyncLayer;
    //    [Export ("cancelDisplayAsyncLayer:")]
    //    void CancelDisplayAsyncLayer (_ASDisplayLayer asyncLayer);
    //}

    //// @interface _ASDisplayView : UIView
    //[BaseType (typeof(UIView))]
    //interface _ASDisplayView
    //{
    //    // -(void)__forwardTouchesBegan:(NSSet *)touches withEvent:(UIEvent *)event;
    //    [Export ("__forwardTouchesBegan:withEvent:")]
    //    void __forwardTouchesBegan (NSSet touches, UIEvent @event);

    //    // -(void)__forwardTouchesMoved:(NSSet *)touches withEvent:(UIEvent *)event;
    //    [Export ("__forwardTouchesMoved:withEvent:")]
    //    void __forwardTouchesMoved (NSSet touches, UIEvent @event);

    //    // -(void)__forwardTouchesEnded:(NSSet *)touches withEvent:(UIEvent *)event;
    //    [Export ("__forwardTouchesEnded:withEvent:")]
    //    void __forwardTouchesEnded (NSSet touches, UIEvent @event);

    //    // -(void)__forwardTouchesCancelled:(NSSet *)touches withEvent:(UIEvent *)event;
    //    [Export ("__forwardTouchesCancelled:withEvent:")]
    //    void __forwardTouchesCancelled (NSSet touches, UIEvent @event);
    //}

    //// @interface Beta (ASDisplayNode)
    //[Category]
    //[BaseType (typeof(ASDisplayNode))]
    //interface ASDisplayNode_Beta
    //{
    //    // -(void)recursivelyEnsureDisplaySynchronously:(BOOL)synchronously;
    //    [Export ("recursivelyEnsureDisplaySynchronously:")]
    //    void RecursivelyEnsureDisplaySynchronously (bool synchronously);

    //    // @property (copy, nonatomic) ASDisplayNodeContextModifier _Nullable willDisplayNodeContentWithRenderingContext;
    //    [NullAllowed, Export ("willDisplayNodeContentWithRenderingContext", ArgumentSemantic.Copy)]
    //    ASDisplayNodeContextModifier WillDisplayNodeContentWithRenderingContext { get; set; }

    //    // @property (copy, nonatomic) ASDisplayNodeContextModifier _Nullable didDisplayNodeContentWithRenderingContext;
    //    [NullAllowed, Export ("didDisplayNodeContentWithRenderingContext", ArgumentSemantic.Copy)]
    //    ASDisplayNodeContextModifier DidDisplayNodeContentWithRenderingContext { get; set; }

    //    // @property (assign, nonatomic) ASDisplayNodePerformanceMeasurementOptions measurementOptions;
    //    [Export ("measurementOptions", ArgumentSemantic.Assign)]
    //    ASDisplayNodePerformanceMeasurementOptions MeasurementOptions { get; set; }

    //    // @property (readonly, assign, nonatomic) ASDisplayNodePerformanceMeasurements performanceMeasurements;
    //    [Export ("performanceMeasurements", ArgumentSemantic.Assign)]
    //    ASDisplayNodePerformanceMeasurements PerformanceMeasurements { get; }

    //    // @property (assign, nonatomic) BOOL isAccessibilityContainer;
    //    [Export ("isAccessibilityContainer")]
    //    bool IsAccessibilityContainer { get; set; }

    //    // -(void)performAccessibilityCustomAction:(UIAccessibilityCustomAction * _Nonnull)action;
    //    [Export ("performAccessibilityCustomAction:")]
    //    void PerformAccessibilityCustomAction (UIAccessibilityCustomAction action);

    //    // -(BOOL)placeholderShouldPersist __attribute__((warn_unused_result));
    //    [Export ("placeholderShouldPersist")]
    //    [Verify (MethodToProperty)]
    //    bool PlaceholderShouldPersist { get; }

    //    // -(void)hierarchyDisplayDidFinish;
    //    [Export ("hierarchyDisplayDidFinish")]
    //    void HierarchyDisplayDidFinish ();

    //    // +(void)setRangeModeForMemoryWarnings:(ASLayoutRangeMode)rangeMode;
    //    [Static]
    //    [Export ("setRangeModeForMemoryWarnings:")]
    //    void SetRangeModeForMemoryWarnings (ASLayoutRangeMode rangeMode);

    //    // -(void)enableSubtreeRasterization;
    //    [Export ("enableSubtreeRasterization")]
    //    void EnableSubtreeRasterization ();
    //}

    //// @interface  (ASTextNode)
    //[Category]
    //[BaseType (typeof(ASTextNode))]
    //interface ASTextNode_
    //{
    //    // @property (copy, nonatomic) NSArray<NSNumber *> * _Nullable pointSizeScaleFactors;
    //    [NullAllowed, Export ("pointSizeScaleFactors", ArgumentSemantic.Copy)]
    //    NSNumber[] PointSizeScaleFactors { get; set; }

    //    // @property (assign, nonatomic) UIEdgeInsets textContainerInset;
    //    [Export ("textContainerInset", ArgumentSemantic.Assign)]
    //    UIEdgeInsets TextContainerInset { get; set; }

    //    // +(void)setExperimentOptions:(ASTextNodeExperimentOptions)options;
    //    [Static]
    //    [Export ("setExperimentOptions:")]
    //    void SetExperimentOptions (ASTextNodeExperimentOptions options);

    //    // @property (readonly, atomic) BOOL usingExperiment;
    //    [Export ("usingExperiment")]
    //    bool UsingExperiment { get; }
    //}

    //[Static]
    //[Verify (ConstantsInterfaceAssociation)]
    //partial interface Constants
    //{
    //    // extern NSString *const _Nonnull ASTransitionContextFromLayoutKey;
    //    [Field ("ASTransitionContextFromLayoutKey", "__Internal")]
    //    NSString ASTransitionContextFromLayoutKey { get; }

    //    // extern NSString *const _Nonnull ASTransitionContextToLayoutKey;
    //    [Field ("ASTransitionContextToLayoutKey", "__Internal")]
    //    NSString ASTransitionContextToLayoutKey { get; }
    //}

    // @protocol ASContextTransitioning <NSObject>
    [Protocol, Model]
    [BaseType (typeof(NSObject))]
    interface ASContextTransitioning
    {
        // @required -(BOOL)isAnimated;
        [Abstract]
        [Export ("isAnimated")]
        //[Verify (MethodToProperty)]
        bool IsAnimated { get; }

        // @required -(ASLayout * _Nullable)layoutForKey:(NSString * _Nonnull)key;
        [Abstract]
        [Export ("layoutForKey:")]
        [return: NullAllowed]
        ASLayout LayoutForKey (string key);

        // @required -(ASSizeRange)constrainedSizeForKey:(NSString * _Nonnull)key;
        [Abstract]
        [Export ("constrainedSizeForKey:")]
        ASSizeRange ConstrainedSizeForKey (string key);

        // @required -(NSArray<ASDisplayNode *> * _Nonnull)subnodesForKey:(NSString * _Nonnull)key;
        [Abstract]
        [Export ("subnodesForKey:")]
        ASDisplayNode[] SubnodesForKey (string key);

        // @required -(NSArray<ASDisplayNode *> * _Nonnull)insertedSubnodes;
        [Abstract]
        [Export ("insertedSubnodes")]
        //[Verify (MethodToProperty)]
        ASDisplayNode[] InsertedSubnodes { get; }

        // @required -(NSArray<ASDisplayNode *> * _Nonnull)removedSubnodes;
        [Abstract]
        [Export ("removedSubnodes")]
        //[Verify (MethodToProperty)]
        ASDisplayNode[] RemovedSubnodes { get; }

        // @required -(CGRect)initialFrameForNode:(ASDisplayNode * _Nonnull)node;
        [Abstract]
        [Export ("initialFrameForNode:")]
        CGRect InitialFrameForNode (ASDisplayNode node);

        // @required -(CGRect)finalFrameForNode:(ASDisplayNode * _Nonnull)node;
        [Abstract]
        [Export ("finalFrameForNode:")]
        CGRect FinalFrameForNode (ASDisplayNode node);

        // @required -(void)completeTransition:(BOOL)didComplete;
        [Abstract]
        [Export ("completeTransition:")]
        void CompleteTransition (bool didComplete);
    }

    //// @interface Subclassing (ASControlNode)
    //[Category]
    //[BaseType (typeof(ASControlNode))]
    partial interface ASControlNode
    {
        //// -(void)sendActionsForControlEvents:(ASControlNodeEvent)controlEvents withEvent:(UIEvent * _Nullable)touchEvent;
        //[Export ("sendActionsForControlEvents:withEvent:")]
        //void SendActionsForControlEvents (ASControlNodeEvent controlEvents, [NullAllowed] UIEvent touchEvent);

        // -(BOOL)beginTrackingWithTouch:(UITouch * _Nonnull)touch withEvent:(UIEvent * _Nullable)touchEvent;
        [Export ("beginTrackingWithTouch:withEvent:")]
        bool BeginTrackingWithTouch (UITouch touch, [NullAllowed] UIEvent touchEvent);

        // -(BOOL)continueTrackingWithTouch:(UITouch * _Nonnull)touch withEvent:(UIEvent * _Nullable)touchEvent;
        [Export ("continueTrackingWithTouch:withEvent:")]
        bool ContinueTrackingWithTouch (UITouch touch, [NullAllowed] UIEvent touchEvent);

        // -(void)cancelTrackingWithEvent:(UIEvent * _Nullable)touchEvent;
        [Export ("cancelTrackingWithEvent:")]
        void CancelTrackingWithEvent ([NullAllowed] UIEvent touchEvent);

        // -(void)endTrackingWithTouch:(UITouch * _Nullable)touch withEvent:(UIEvent * _Nullable)touchEvent;
        [Export ("endTrackingWithTouch:withEvent:")]
        void EndTrackingWithTouch ([NullAllowed] UITouch touch, [NullAllowed] UIEvent touchEvent);

        //// @property (getter = isHighlighted, assign, readwrite, nonatomic) BOOL highlighted;
        //[Export ("highlighted")]
        //bool Highlighted { [Bind ("isHighlighted")] get; set; }
    }

    //// @interface ASHighlightOverlayLayer : CALayer
    //[BaseType (typeof(CALayer))]
    //interface ASHighlightOverlayLayer
    //{
    //    // -(instancetype _Nonnull)initWithRects:(NSArray<NSValue *> * _Nonnull)rects targetLayer:(CALayer * _Nullable)targetLayer;
    //    [Export ("initWithRects:targetLayer:")]
    //    IntPtr Constructor (NSValue[] rects, [NullAllowed] CALayer targetLayer);

    //    // -(instancetype _Nonnull)initWithRects:(NSArray<NSValue *> * _Nonnull)rects;
    //    [Export ("initWithRects:")]
    //    IntPtr Constructor (NSValue[] rects);

    //    // @property (nonatomic, strong) CGColorRef _Nullable highlightColor __attribute__((NSObject));
    //    [NullAllowed, Export ("highlightColor", ArgumentSemantic.Strong)]
    //    unsafe CGColorRef* HighlightColor { get; set; }

    //    // @property (nonatomic, weak) CALayer * _Nullable targetLayer;
    //    [NullAllowed, Export ("targetLayer", ArgumentSemantic.Weak)]
    //    CALayer TargetLayer { get; set; }
    //}

    //// @interface ASHighlightOverlayLayerSupport (CALayer)
    //[Category]
    //[BaseType (typeof(CALayer))]
    //interface CALayer_ASHighlightOverlayLayerSupport
    //{
    //    // @property (assign, nonatomic, setter = as_setAllowsHighlightDrawing:) BOOL as_allowsHighlightDrawing;
    //    [Export ("as_allowsHighlightDrawing")]
    //    bool As_allowsHighlightDrawing { get; [Bind ("as_setAllowsHighlightDrawing:")] set; }
    //}

    //// @interface ASImageContainerProtocol (UIImage) <ASImageContainerProtocol>
    //[Category]
    //[BaseType (typeof(UIImage))]
    //interface UIImage_ASImageContainerProtocol : IASImageContainerProtocol
    //{
    //}

    //// @interface ASImageContainerProtocol (NSData) <ASImageContainerProtocol>
    //[Category]
    //[BaseType (typeof(NSData))]
    //interface NSData_ASImageContainerProtocol : IASImageContainerProtocol
    //{
    //}

    //// @interface ASMutableAttributedStringBuilder : NSMutableAttributedString
    //[BaseType (typeof(NSMutableAttributedString))]
    //interface ASMutableAttributedStringBuilder
    //{
    //    // -(instancetype _Nonnull)initWithString:(NSString * _Nonnull)str attributes:(NSDictionary<NSString *,id> * _Nullable)attrs;
    //    [Export ("initWithString:attributes:")]
    //    IntPtr Constructor (string str, [NullAllowed] NSDictionary<NSString, NSObject> attrs);

    //    // -(instancetype _Nonnull)initWithAttributedString:(NSAttributedString * _Nonnull)attrStr;
    //    [Export ("initWithAttributedString:")]
    //    IntPtr Constructor (NSAttributedString attrStr);

    //    // -(void)replaceCharactersInRange:(NSRange)range withString:(NSString * _Nonnull)str;
    //    [Export ("replaceCharactersInRange:withString:")]
    //    void ReplaceCharactersInRange (NSRange range, string str);

    //    // -(void)setAttributes:(NSDictionary<NSString *,id> * _Nullable)attrs range:(NSRange)range;
    //    [Export ("setAttributes:range:")]
    //    void SetAttributes ([NullAllowed] NSDictionary<NSString, NSObject> attrs, NSRange range);

    //    // -(void)addAttribute:(NSString * _Nonnull)name value:(id _Nonnull)value range:(NSRange)range;
    //    [Export ("addAttribute:value:range:")]
    //    void AddAttribute (string name, NSObject value, NSRange range);

    //    // -(void)addAttributes:(NSDictionary<NSString *,id> * _Nonnull)attrs range:(NSRange)range;
    //    [Export ("addAttributes:range:")]
    //    void AddAttributes (NSDictionary<NSString, NSObject> attrs, NSRange range);

    //    // -(void)removeAttribute:(NSString * _Nonnull)name range:(NSRange)range;
    //    [Export ("removeAttribute:range:")]
    //    void RemoveAttribute (string name, NSRange range);

    //    // -(void)replaceCharactersInRange:(NSRange)range withAttributedString:(NSAttributedString * _Nonnull)attrString;
    //    [Export ("replaceCharactersInRange:withAttributedString:")]
    //    void ReplaceCharactersInRange (NSRange range, NSAttributedString attrString);

    //    // -(void)insertAttributedString:(NSAttributedString * _Nonnull)attrString atIndex:(NSUInteger)loc;
    //    [Export ("insertAttributedString:atIndex:")]
    //    void InsertAttributedString (NSAttributedString attrString, nuint loc);

    //    // -(void)appendAttributedString:(NSAttributedString * _Nonnull)attrString;
    //    [Export ("appendAttributedString:")]
    //    void AppendAttributedString (NSAttributedString attrString);

    //    // -(void)deleteCharactersInRange:(NSRange)range;
    //    [Export ("deleteCharactersInRange:")]
    //    void DeleteCharactersInRange (NSRange range);

    //    // -(void)setAttributedString:(NSAttributedString * _Nonnull)attrString;
    //    [Export ("setAttributedString:")]
    //    void SetAttributedString (NSAttributedString attrString);

    //    // -(NSMutableAttributedString * _Nonnull)composedAttributedString;
    //    [Export ("composedAttributedString")]
    //    [Verify (MethodToProperty)]
    //    NSMutableAttributedString ComposedAttributedString { get; }
    //}

    //// audit-objc-generics: @interface ASRunLoopQueue<ObjectType> : NSObject
    //[BaseType (typeof(NSObject))]
    //interface ASRunLoopQueue
    //{
    //    // -(instancetype _Nonnull)initWithRunLoop:(CFRunLoopRef _Nonnull)runloop retainObjects:(BOOL)retainsObjects handler:(void (^ _Nullable)(ObjectType _Nonnull, BOOL))handlerBlock;
    //    [Export ("initWithRunLoop:retainObjects:handler:")]
    //    unsafe IntPtr Constructor (CFRunLoopRef* runloop, bool retainsObjects, [NullAllowed] Action<NSObject, bool> handlerBlock);

    //    // -(void)enqueue:(ObjectType _Nonnull)object;
    //    [Export ("enqueue:")]
    //    void Enqueue (NSObject @object);

    //    // @property (readonly, nonatomic) BOOL isEmpty;
    //    [Export ("isEmpty")]
    //    bool IsEmpty { get; }

    //    // @property (assign, nonatomic) NSUInteger batchSize;
    //    [Export ("batchSize")]
    //    nuint BatchSize { get; set; }

    //    // @property (assign, nonatomic) BOOL ensureExclusiveMembership;
    //    [Export ("ensureExclusiveMembership")]
    //    bool EnsureExclusiveMembership { get; set; }
    //}

    //// @interface ASDeallocQueue : NSObject
    //[BaseType (typeof(NSObject))]
    //interface ASDeallocQueue
    //{
    //    // +(instancetype _Nonnull)sharedDeallocationQueue;
    //    [Static]
    //    [Export ("sharedDeallocationQueue")]
    //    ASDeallocQueue SharedDeallocationQueue ();

    //    // -(void)test_drain;
    //    [Export ("test_drain")]
    //    void Test_drain ();

    //    // -(void)releaseObjectInBackground:(id _Nonnull)object;
    //    [Export ("releaseObjectInBackground:")]
    //    void ReleaseObjectInBackground (NSObject @object);
    //}

    //// @interface ASTextKitComponents : NSObject
    //[BaseType (typeof(NSObject))]
    //interface ASTextKitComponents
    //{
    //    // +(instancetype _Nonnull)componentsWithAttributedSeedString:(NSAttributedString * _Nullable)attributedSeedString textContainerSize:(CGSize)textContainerSize;
    //    [Static]
    //    [Export ("componentsWithAttributedSeedString:textContainerSize:")]
    //    ASTextKitComponents ComponentsWithAttributedSeedString ([NullAllowed] NSAttributedString attributedSeedString, CGSize textContainerSize);

    //    // +(instancetype _Nonnull)componentsWithTextStorage:(NSTextStorage * _Nonnull)textStorage textContainerSize:(CGSize)textContainerSize layoutManager:(NSLayoutManager * _Nonnull)layoutManager;
    //    [Static]
    //    [Export ("componentsWithTextStorage:textContainerSize:layoutManager:")]
    //    ASTextKitComponents ComponentsWithTextStorage (NSTextStorage textStorage, CGSize textContainerSize, NSLayoutManager layoutManager);

    //    // -(CGSize)sizeForConstrainedWidth:(CGFloat)constrainedWidth;
    //    [Export ("sizeForConstrainedWidth:")]
    //    CGSize SizeForConstrainedWidth (nfloat constrainedWidth);

    //    // -(CGSize)sizeForConstrainedWidth:(CGFloat)constrainedWidth forMaxNumberOfLines:(NSInteger)numberOfLines;
    //    [Export ("sizeForConstrainedWidth:forMaxNumberOfLines:")]
    //    CGSize SizeForConstrainedWidth (nfloat constrainedWidth, nint numberOfLines);

    //    // @property (readonly, nonatomic, strong) NSTextStorage * _Nonnull textStorage;
    //    [Export ("textStorage", ArgumentSemantic.Strong)]
    //    NSTextStorage TextStorage { get; }

    //    // @property (readonly, nonatomic, strong) NSTextContainer * _Nonnull textContainer;
    //    [Export ("textContainer", ArgumentSemantic.Strong)]
    //    NSTextContainer TextContainer { get; }

    //    // @property (readonly, nonatomic, strong) NSLayoutManager * _Nonnull layoutManager;
    //    [Export ("layoutManager", ArgumentSemantic.Strong)]
    //    NSLayoutManager LayoutManager { get; }

    //    // @property (nonatomic, strong) UITextView * _Nullable textView;
    //    [NullAllowed, Export ("textView", ArgumentSemantic.Strong)]
    //    UITextView TextView { get; set; }
    //}

    //// audit-objc-generics: @interface ASWeakSet<__covariant ObjectType> : NSObject <NSFastEnumeration>
    //[BaseType (typeof(NSObject))]
    //interface ASWeakSet : INSFastEnumeration
    //{
    //    // @property (readonly, getter = isEmpty, nonatomic) BOOL empty;
    //    [Export ("empty")]
    //    bool Empty { [Bind ("isEmpty")] get; }

    //    // -(BOOL)containsObject:(ObjectType _Nonnull)object __attribute__((warn_unused_result));
    //    [Export ("containsObject:")]
    //    bool ContainsObject (NSObject @object);

    //    // -(void)addObject:(ObjectType _Nonnull)object;
    //    [Export ("addObject:")]
    //    void AddObject (NSObject @object);

    //    // -(void)removeObject:(ObjectType _Nonnull)object;
    //    [Export ("removeObject:")]
    //    void RemoveObject (NSObject @object);

    //    // -(void)removeAllObjects;
    //    [Export ("removeAllObjects")]
    //    void RemoveAllObjects ();

    //    // -(NSArray<ObjectType> * _Nonnull)allObjects __attribute__((warn_unused_result));
    //    [Export ("allObjects")]
    //    [Verify (MethodToProperty)]
    //    NSObject[] AllObjects { get; }

    //    // @property (readonly, nonatomic) NSUInteger count;
    //    [Export ("count")]
    //    nuint Count { get; }
    //}

    //// @interface TextKitAdditions (NSMutableAttributedString)
    //[Category]
    //[BaseType (typeof(NSMutableAttributedString))]
    //interface NSMutableAttributedString_TextKitAdditions
    //{
    //    // -(void)attributeTextInRange:(NSRange)range withTextKitMinimumLineHeight:(CGFloat)minimumLineHeight;
    //    [Export ("attributeTextInRange:withTextKitMinimumLineHeight:")]
    //    void AttributeTextInRange (NSRange range, nfloat minimumLineHeight);

    //    // -(void)attributeTextInRange:(NSRange)range withTextKitMinimumLineHeight:(CGFloat)minimumLineHeight maximumLineHeight:(CGFloat)maximumLineHeight;
    //    [Export ("attributeTextInRange:withTextKitMinimumLineHeight:maximumLineHeight:")]
    //    void AttributeTextInRange (NSRange range, nfloat minimumLineHeight, nfloat maximumLineHeight);

    //    // -(void)attributeTextInRange:(NSRange)range withTextKitLineHeight:(CGFloat)lineHeight;
    //    [Export ("attributeTextInRange:withTextKitLineHeight:")]
    //    void AttributeTextInRange (NSRange range, nfloat lineHeight);

    //    // -(void)attributeTextInRange:(NSRange)range withTextKitParagraphStyle:(NSParagraphStyle * _Nonnull)paragraphStyle;
    //    [Export ("attributeTextInRange:withTextKitParagraphStyle:")]
    //    void AttributeTextInRange (NSRange range, NSParagraphStyle paragraphStyle);
    //}

    //// @interface ASLayoutInspectorProviding (UICollectionViewLayout)
    //[Category]
    //[BaseType (typeof(UICollectionViewLayout))]
    //interface UICollectionViewLayout_ASLayoutInspectorProviding
    //{
    //    // -(id<ASCollectionViewLayoutInspecting> _Nonnull)asdk_layoutInspector;
    //    [Export ("asdk_layoutInspector")]
    //    [Verify (MethodToProperty)]
    //    ASCollectionViewLayoutInspecting Asdk_layoutInspector { get; }
    //}

    //// @protocol ASDisplayProperties <NSObject>
    //[Protocol, Model]
    //[BaseType (typeof(NSObject))]
    //interface ASDisplayProperties
    //{
    //    // @required @property (assign, nonatomic) CGPoint position;
    //    [Abstract]
    //    [Export ("position", ArgumentSemantic.Assign)]
    //    CGPoint Position { get; set; }

    //    // @required @property (assign, nonatomic) CGFloat zPosition;
    //    [Abstract]
    //    [Export ("zPosition")]
    //    nfloat ZPosition { get; set; }

    //    // @required @property (assign, nonatomic) CGPoint anchorPoint;
    //    [Abstract]
    //    [Export ("anchorPoint", ArgumentSemantic.Assign)]
    //    CGPoint AnchorPoint { get; set; }

    //    // @required @property (assign, nonatomic) CGFloat cornerRadius;
    //    [Abstract]
    //    [Export ("cornerRadius")]
    //    nfloat CornerRadius { get; set; }

    //    // @required @property (nonatomic, strong) id _Nullable contents;
    //    [Abstract]
    //    [NullAllowed, Export ("contents", ArgumentSemantic.Strong)]
    //    NSObject Contents { get; set; }

    //    // @required @property (copy, nonatomic) NSString * _Nonnull contentsGravity;
    //    [Abstract]
    //    [Export ("contentsGravity")]
    //    string ContentsGravity { get; set; }

    //    // @required @property (assign, nonatomic) CGRect contentsRect;
    //    [Abstract]
    //    [Export ("contentsRect", ArgumentSemantic.Assign)]
    //    CGRect ContentsRect { get; set; }

    //    // @required @property (assign, nonatomic) CGRect contentsCenter;
    //    [Abstract]
    //    [Export ("contentsCenter", ArgumentSemantic.Assign)]
    //    CGRect ContentsCenter { get; set; }

    //    // @required @property (assign, nonatomic) CGFloat contentsScale;
    //    [Abstract]
    //    [Export ("contentsScale")]
    //    nfloat ContentsScale { get; set; }

    //    // @required @property (assign, nonatomic) CGFloat rasterizationScale;
    //    [Abstract]
    //    [Export ("rasterizationScale")]
    //    nfloat RasterizationScale { get; set; }

    //    // @required @property (assign, nonatomic) CATransform3D transform;
    //    [Abstract]
    //    [Export ("transform", ArgumentSemantic.Assign)]
    //    CATransform3D Transform { get; set; }

    //    // @required @property (assign, nonatomic) CATransform3D sublayerTransform;
    //    [Abstract]
    //    [Export ("sublayerTransform", ArgumentSemantic.Assign)]
    //    CATransform3D SublayerTransform { get; set; }

    //    // @required @property (assign, nonatomic) BOOL needsDisplayOnBoundsChange;
    //    [Abstract]
    //    [Export ("needsDisplayOnBoundsChange")]
    //    bool NeedsDisplayOnBoundsChange { get; set; }

    //    // @required @property (nonatomic, strong) CGColorRef _Nonnull shadowColor __attribute__((NSObject));
    //    [Abstract]
    //    [Export ("shadowColor", ArgumentSemantic.Strong)]
    //    unsafe CGColorRef* ShadowColor { get; set; }

    //    // @required @property (assign, nonatomic) CGFloat shadowOpacity;
    //    [Abstract]
    //    [Export ("shadowOpacity")]
    //    nfloat ShadowOpacity { get; set; }

    //    // @required @property (assign, nonatomic) CGSize shadowOffset;
    //    [Abstract]
    //    [Export ("shadowOffset", ArgumentSemantic.Assign)]
    //    CGSize ShadowOffset { get; set; }

    //    // @required @property (assign, nonatomic) CGFloat shadowRadius;
    //    [Abstract]
    //    [Export ("shadowRadius")]
    //    nfloat ShadowRadius { get; set; }

    //    // @required @property (assign, nonatomic) CGFloat borderWidth;
    //    [Abstract]
    //    [Export ("borderWidth")]
    //    nfloat BorderWidth { get; set; }

    //    // @required @property (getter = isOpaque, assign, nonatomic) BOOL opaque;
    //    [Abstract]
    //    [Export ("opaque")]
    //    bool Opaque { [Bind ("isOpaque")] get; set; }

    //    // @required @property (nonatomic, strong) CGColorRef _Nonnull borderColor __attribute__((NSObject));
    //    [Abstract]
    //    [Export ("borderColor", ArgumentSemantic.Strong)]
    //    unsafe CGColorRef* BorderColor { get; set; }

    //    // @required @property (nonatomic, strong) CGColorRef _Nonnull backgroundColor __attribute__((NSObject));
    //    [Abstract]
    //    [Export ("backgroundColor", ArgumentSemantic.Strong)]
    //    unsafe CGColorRef* BackgroundColor { get; set; }

    //    // @required @property (assign, nonatomic) BOOL allowsGroupOpacity;
    //    [Abstract]
    //    [Export ("allowsGroupOpacity")]
    //    bool AllowsGroupOpacity { get; set; }

    //    // @required @property (assign, nonatomic) BOOL allowsEdgeAntialiasing;
    //    [Abstract]
    //    [Export ("allowsEdgeAntialiasing")]
    //    bool AllowsEdgeAntialiasing { get; set; }

    //    // @required @property (assign, nonatomic) unsigned int edgeAntialiasingMask;
    //    [Abstract]
    //    [Export ("edgeAntialiasingMask")]
    //    uint EdgeAntialiasingMask { get; set; }

    //    // @required -(void)setNeedsDisplay;
    //    [Abstract]
    //    [Export ("setNeedsDisplay")]
    //    void SetNeedsDisplay ();

    //    // @required -(void)setNeedsLayout;
    //    [Abstract]
    //    [Export ("setNeedsLayout")]
    //    void SetNeedsLayout ();

    //    // @required -(void)layoutIfNeeded;
    //    [Abstract]
    //    [Export ("layoutIfNeeded")]
    //    void LayoutIfNeeded ();
    //}

    //// @protocol ASDisplayNodeViewProperties
    //[Protocol, Model]
    //interface ASDisplayNodeViewProperties
    //{
    //    // @required @property (assign, nonatomic) BOOL clipsToBounds;
    //    [Abstract]
    //    [Export ("clipsToBounds")]
    //    bool ClipsToBounds { get; set; }

    //    // @required @property (getter = isHidden, nonatomic) BOOL hidden;
    //    [Abstract]
    //    [Export ("hidden")]
    //    bool Hidden { [Bind ("isHidden")] get; set; }

    //    // @required @property (assign, nonatomic) BOOL autoresizesSubviews;
    //    [Abstract]
    //    [Export ("autoresizesSubviews")]
    //    bool AutoresizesSubviews { get; set; }

    //    // @required @property (assign, nonatomic) UIViewAutoresizing autoresizingMask;
    //    [Abstract]
    //    [Export ("autoresizingMask", ArgumentSemantic.Assign)]
    //    UIViewAutoresizing AutoresizingMask { get; set; }

    //    // @required @property (nonatomic, strong) UIColor * _Null_unspecified tintColor;
    //    [Abstract]
    //    [Export ("tintColor", ArgumentSemantic.Strong)]
    //    UIColor TintColor { get; set; }

    //    // @required @property (assign, nonatomic) CGFloat alpha;
    //    [Abstract]
    //    [Export ("alpha")]
    //    nfloat Alpha { get; set; }

    //    // @required @property (assign, nonatomic) CGRect bounds;
    //    [Abstract]
    //    [Export ("bounds", ArgumentSemantic.Assign)]
    //    CGRect Bounds { get; set; }

    //    // @required @property (assign, nonatomic) CGRect frame;
    //    [Abstract]
    //    [Export ("frame", ArgumentSemantic.Assign)]
    //    CGRect Frame { get; set; }

    //    // @required @property (assign, nonatomic) UIViewContentMode contentMode;
    //    [Abstract]
    //    [Export ("contentMode", ArgumentSemantic.Assign)]
    //    UIViewContentMode ContentMode { get; set; }

    //    // @required @property (assign, nonatomic) UISemanticContentAttribute semanticContentAttribute;
    //    [Abstract]
    //    [Export ("semanticContentAttribute", ArgumentSemantic.Assign)]
    //    UISemanticContentAttribute SemanticContentAttribute { get; set; }

    //    // @required @property (getter = isUserInteractionEnabled, assign, nonatomic) BOOL userInteractionEnabled;
    //    [Abstract]
    //    [Export ("userInteractionEnabled")]
    //    bool UserInteractionEnabled { [Bind ("isUserInteractionEnabled")] get; set; }

    //    // @required @property (getter = isExclusiveTouch, assign, nonatomic) BOOL exclusiveTouch;
    //    [Abstract]
    //    [Export ("exclusiveTouch")]
    //    bool ExclusiveTouch { [Bind ("isExclusiveTouch")] get; set; }

    //    // @required @property (getter = asyncdisplaykit_isAsyncTransactionContainer, assign, nonatomic, setter = asyncdisplaykit_setAsyncTransactionContainer:) BOOL asyncdisplaykit_asyncTransactionContainer;
    //    [Abstract]
    //    [Export ("asyncdisplaykit_asyncTransactionContainer")]
    //    bool Asyncdisplaykit_asyncTransactionContainer { [Bind ("asyncdisplaykit_isAsyncTransactionContainer")] get; [Bind ("asyncdisplaykit_setAsyncTransactionContainer:")] set; }

    //    // @required @property (copy, nonatomic) NSString * _Nullable accessibilityIdentifier;
    //    [Abstract]
    //    [NullAllowed, Export ("accessibilityIdentifier")]
    //    string AccessibilityIdentifier { get; set; }
    //}

    //// @interface ASDKFastImageNamed (UIImage)
    //[Category]
    //[BaseType (typeof(UIImage))]
    //interface UIImage_ASDKFastImageNamed
    //{
    //    // +(UIImage * _Nonnull)as_imageNamed:(NSString * _Nonnull)imageName;
    //    [Static]
    //    [Export ("as_imageNamed:")]
    //    UIImage As_imageNamed (string imageName);

    //    // +(UIImage * _Nonnull)as_imageNamed:(NSString * _Nonnull)imageName compatibleWithTraitCollection:(UITraitCollection * _Nullable)traitCollection;
    //    [Static]
    //    [Export ("as_imageNamed:compatibleWithTraitCollection:")]
    //    UIImage As_imageNamed (string imageName, [NullAllowed] UITraitCollection traitCollection);
    //}

    //// @interface ASDKResizableRoundedRects (UIImage)
    //[Category]
    //[BaseType (typeof(UIImage))]
    //interface UIImage_ASDKResizableRoundedRects
    //{
    //    // +(UIImage * _Nonnull)as_resizableRoundedImageWithCornerRadius:(CGFloat)cornerRadius cornerColor:(UIColor * _Nullable)cornerColor fillColor:(UIColor * _Nonnull)fillColor __attribute__((warn_unused_result));
    //    [Static]
    //    [Export ("as_resizableRoundedImageWithCornerRadius:cornerColor:fillColor:")]
    //    UIImage As_resizableRoundedImageWithCornerRadius (nfloat cornerRadius, [NullAllowed] UIColor cornerColor, UIColor fillColor);

    //    // +(UIImage * _Nonnull)as_resizableRoundedImageWithCornerRadius:(CGFloat)cornerRadius cornerColor:(UIColor * _Nonnull)cornerColor fillColor:(UIColor * _Nonnull)fillColor borderColor:(UIColor * _Nullable)borderColor borderWidth:(CGFloat)borderWidth __attribute__((warn_unused_result));
    //    [Static]
    //    [Export ("as_resizableRoundedImageWithCornerRadius:cornerColor:fillColor:borderColor:borderWidth:")]
    //    UIImage As_resizableRoundedImageWithCornerRadius (nfloat cornerRadius, UIColor cornerColor, UIColor fillColor, [NullAllowed] UIColor borderColor, nfloat borderWidth);

    //    // +(UIImage * _Nonnull)as_resizableRoundedImageWithCornerRadius:(CGFloat)cornerRadius cornerColor:(UIColor * _Nullable)cornerColor fillColor:(UIColor * _Nonnull)fillColor borderColor:(UIColor * _Nullable)borderColor borderWidth:(CGFloat)borderWidth roundedCorners:(UIRectCorner)roundedCorners scale:(CGFloat)scale __attribute__((warn_unused_result));
    //    [Static]
    //    [Export ("as_resizableRoundedImageWithCornerRadius:cornerColor:fillColor:borderColor:borderWidth:roundedCorners:scale:")]
    //    UIImage As_resizableRoundedImageWithCornerRadius (nfloat cornerRadius, [NullAllowed] UIColor cornerColor, UIColor fillColor, [NullAllowed] UIColor borderColor, nfloat borderWidth, UIRectCorner roundedCorners, nfloat scale);
    //}

    //// @interface Diffing (NSArray)
    //[Category]
    //[BaseType (typeof(NSArray))]
    //interface NSArray_Diffing
    //{
    //    // -(void)asdk_diffWithArray:(NSArray *)array insertions:(NSIndexSet **)insertions deletions:(NSIndexSet **)deletions;
    //    [Export ("asdk_diffWithArray:insertions:deletions:")]
    //    [Verify (StronglyTypedNSArray)]
    //    void Asdk_diffWithArray (NSObject[] array, out NSIndexSet insertions, out NSIndexSet deletions);

    //    // -(void)asdk_diffWithArray:(NSArray *)array insertions:(NSIndexSet **)insertions deletions:(NSIndexSet **)deletions compareBlock:(BOOL (^)(id, id))comparison;
    //    [Export ("asdk_diffWithArray:insertions:deletions:compareBlock:")]
    //    [Verify (StronglyTypedNSArray)]
    //    void Asdk_diffWithArray (NSObject[] array, out NSIndexSet insertions, out NSIndexSet deletions, Func<NSObject, NSObject, bool> comparison);
    //}

    //// @interface AsyncDisplayKit (UIResponder)
    //[Category]
    //[BaseType (typeof(UIResponder))]
    //interface UIResponder_AsyncDisplayKit
    //{
    //    // @property (readonly, nonatomic) __kindof UIViewController * _Nullable asdk_associatedViewController;
    //    [Export ("asdk_associatedViewController")]
    //    UIViewController Asdk_associatedViewController { get; }
    //}

    //// @interface Debugging (ASImageNode)
    //[Category]
    //[BaseType (typeof(ASImageNode))]
    //interface ASImageNode_Debugging
    //{
    //    // @property (nonatomic, class) BOOL shouldShowImageScalingOverlay;
    //    [Static]
    //    [Export ("shouldShowImageScalingOverlay")]
    //    bool ShouldShowImageScalingOverlay { get; set; }
    //}

    //// @interface Debugging (ASControlNode)
    //[Category]
    //[BaseType (typeof(ASControlNode))]
    //interface ASControlNode_Debugging
    //{
    //    // @property (nonatomic, class) BOOL enableHitTestDebug;
    //    [Static]
    //    [Export ("enableHitTestDebug")]
    //    bool EnableHitTestDebug { get; set; }
    //}

    //// @interface RangeDebugging (ASDisplayNode)
    //[Category]
    //[BaseType (typeof(ASDisplayNode))]
    //interface ASDisplayNode_RangeDebugging
    //{
    //    // @property (nonatomic, class) BOOL shouldShowRangeDebugOverlay;
    //    [Static]
    //    [Export ("shouldShowRangeDebugOverlay")]
    //    bool ShouldShowRangeDebugOverlay { get; set; }
    //}

    // typedef void (^ASTipDisplayBlock)(ASDisplayNode * _Nonnull, NSString * _Nonnull);
    delegate void ASTipDisplayBlock (ASDisplayNode arg0, string arg1);

    // @interface Tips (ASDisplayNode)
    //[Category]
    //[BaseType (typeof(ASDisplayNode))]
    partial interface ASDisplayNode
    {
        // @property (class) BOOL enableTips;
        [Static]
        [Export ("enableTips")]
        bool EnableTips { get; set; }

        // @property (copy, nonatomic, class) ASTipDisplayBlock _Null_unspecified tipDisplayBlock;
        [Static]
        [Export ("tipDisplayBlock", ArgumentSemantic.Copy)]
        ASTipDisplayBlock TipDisplayBlock { get; set; }
    }
}
