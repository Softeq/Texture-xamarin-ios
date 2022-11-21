using System;
using System.Runtime.InteropServices;
using CoreAnimation;
using CoreGraphics;
using Foundation;
using ObjCRuntime;
using UIKit;

namespace AsyncDisplayKitBindings
{
    [Native]
    public enum ASAsyncTransactionContainerState : long
    {
        NoTransactions = 0,
        PendingTransactions
    }

    //static class CFunctions
    //{
    //    // extern BOOL ASMainThreadAssertionsAreDisabled ();
    //    [DllImport ("__Internal")]
    //    [Verify (PlatformInvoke)]
    //    static extern bool ASMainThreadAssertionsAreDisabled ();

    //    // extern void ASPushMainThreadAssertionsDisabled ();
    //    [DllImport ("__Internal")]
    //    [Verify (PlatformInvoke)]
    //    static extern void ASPushMainThreadAssertionsDisabled ();

    //    // extern void ASPopMainThreadAssertionsDisabled ();
    //    [DllImport ("__Internal")]
    //    [Verify (PlatformInvoke)]
    //    static extern void ASPopMainThreadAssertionsDisabled ();

    //    // BOOL ASPointsValidForLayout (CGFloat points) __attribute__((warn_unused_result));
    //    [DllImport ("__Internal")]
    //    [Verify (PlatformInvoke)]
    //    static extern bool ASPointsValidForLayout (nfloat points);

    //    // BOOL ASIsCGSizeValidForLayout (CGSize size) __attribute__((warn_unused_result));
    //    [DllImport ("__Internal")]
    //    [Verify (PlatformInvoke)]
    //    static extern bool ASIsCGSizeValidForLayout (CGSize size);

    //    // BOOL ASPointsValidForSize (CGFloat points) __attribute__((warn_unused_result));
    //    [DllImport ("__Internal")]
    //    [Verify (PlatformInvoke)]
    //    static extern bool ASPointsValidForSize (nfloat points);

    //    // BOOL ASIsCGSizeValidForSize (CGSize size) __attribute__((warn_unused_result));
    //    [DllImport ("__Internal")]
    //    [Verify (PlatformInvoke)]
    //    static extern bool ASIsCGSizeValidForSize (CGSize size);

    //    // BOOL ASIsCGPositionPointsValidForLayout (CGFloat points);
    //    [DllImport ("__Internal")]
    //    [Verify (PlatformInvoke)]
    //    static extern bool ASIsCGPositionPointsValidForLayout (nfloat points);

    //    // BOOL ASIsCGPositionValidForLayout (CGPoint point);
    //    [DllImport ("__Internal")]
    //    [Verify (PlatformInvoke)]
    //    static extern bool ASIsCGPositionValidForLayout (CGPoint point);

    //    // BOOL ASIsCGRectValidForLayout (CGRect rect);
    //    [DllImport ("__Internal")]
    //    [Verify (PlatformInvoke)]
    //    static extern bool ASIsCGRectValidForLayout (CGRect rect);

    //    // ASDimension ASDimensionMake (ASDimensionUnit unit, CGFloat value) __attribute__((overloadable));
    //    [DllImport ("__Internal")]
    //    [Verify (PlatformInvoke)]
    //    static extern ASDimension ASDimensionMake (ASDimensionUnit unit, nfloat value);

    //    // ASDimension ASDimensionMake (CGFloat points) __attribute__((warn_unused_result)) __attribute__((overloadable));
    //    [DllImport ("__Internal")]
    //    [Verify (PlatformInvoke)]
    //    static extern ASDimension ASDimensionMake (nfloat points);

    //    // extern ASDimension ASDimensionMake (NSString * _Nonnull dimension) __attribute__((warn_unused_result)) __attribute__((overloadable));
    //    [DllImport ("__Internal")]
    //    [Verify (PlatformInvoke)]
    //    static extern ASDimension ASDimensionMake (NSString dimension);

    //    // ASDimension ASDimensionMakeWithPoints (CGFloat points) __attribute__((warn_unused_result));
    //    [DllImport ("__Internal")]
    //    [Verify (PlatformInvoke)]
    //    static extern ASDimension ASDimensionMakeWithPoints (nfloat points);

    //    // ASDimension ASDimensionMakeWithFraction (CGFloat fraction) __attribute__((warn_unused_result));
    //    [DllImport ("__Internal")]
    //    [Verify (PlatformInvoke)]
    //    static extern ASDimension ASDimensionMakeWithFraction (nfloat fraction);

    //    // BOOL ASDimensionEqualToDimension (ASDimension lhs, ASDimension rhs) __attribute__((warn_unused_result));
    //    [DllImport ("__Internal")]
    //    [Verify (PlatformInvoke)]
    //    static extern bool ASDimensionEqualToDimension (ASDimension lhs, ASDimension rhs);

    //    // extern NSString * _Nonnull NSStringFromASDimension (ASDimension dimension) __attribute__((warn_unused_result));
    //    [DllImport ("__Internal")]
    //    [Verify (PlatformInvoke)]
    //    static extern NSString NSStringFromASDimension (ASDimension dimension);

    //    // CGFloat ASDimensionResolve (ASDimension dimension, CGFloat parentSize, CGFloat autoSize) __attribute__((warn_unused_result));
    //    [DllImport ("__Internal")]
    //    [Verify (PlatformInvoke)]
    //    static extern nfloat ASDimensionResolve (ASDimension dimension, nfloat parentSize, nfloat autoSize);

    //    // ASLayoutSize ASLayoutSizeMake (ASDimension width, ASDimension height) __attribute__((warn_unused_result));
    //    [DllImport ("__Internal")]
    //    [Verify (PlatformInvoke)]
    //    static extern ASLayoutSize ASLayoutSizeMake (ASDimension width, ASDimension height);

    //    // CGSize ASLayoutSizeResolveSize (ASLayoutSize layoutSize, CGSize parentSize, CGSize autoSize);
    //    [DllImport ("__Internal")]
    //    [Verify (PlatformInvoke)]
    //    static extern CGSize ASLayoutSizeResolveSize (ASLayoutSize layoutSize, CGSize parentSize, CGSize autoSize);

    //    // NSString * _Nonnull NSStringFromASLayoutSize (ASLayoutSize size) __attribute__((warn_unused_result));
    //    [DllImport ("__Internal")]
    //    [Verify (PlatformInvoke)]
    //    static extern NSString NSStringFromASLayoutSize (ASLayoutSize size);

    //    // BOOL ASSizeRangeHasSignificantArea (ASSizeRange sizeRange) __attribute__((warn_unused_result));
    //    [DllImport ("__Internal")]
    //    [Verify (PlatformInvoke)]
    //    static extern bool ASSizeRangeHasSignificantArea (ASSizeRange sizeRange);

    //    // ASSizeRange ASSizeRangeMake (CGSize min, CGSize max) __attribute__((warn_unused_result)) __attribute__((overloadable));
    //    [DllImport ("__Internal")]
    //    [Verify (PlatformInvoke)]
    //    static extern ASSizeRange ASSizeRangeMake (CGSize min, CGSize max);

    //    // ASSizeRange ASSizeRangeMake (CGSize exactSize) __attribute__((warn_unused_result)) __attribute__((overloadable));
    //    [DllImport ("__Internal")]
    //    [Verify (PlatformInvoke)]
    //    static extern ASSizeRange ASSizeRangeMake (CGSize exactSize);

    //    // CGSize ASSizeRangeClamp (ASSizeRange sizeRange, CGSize size) __attribute__((warn_unused_result));
    //    [DllImport ("__Internal")]
    //    [Verify (PlatformInvoke)]
    //    static extern CGSize ASSizeRangeClamp (ASSizeRange sizeRange, CGSize size);

    //    // extern ASSizeRange ASSizeRangeIntersect (ASSizeRange sizeRange, ASSizeRange otherSizeRange) __attribute__((warn_unused_result));
    //    [DllImport ("__Internal")]
    //    [Verify (PlatformInvoke)]
    //    static extern ASSizeRange ASSizeRangeIntersect (ASSizeRange sizeRange, ASSizeRange otherSizeRange);

    //    // BOOL ASSizeRangeEqualToSizeRange (ASSizeRange lhs, ASSizeRange rhs) __attribute__((warn_unused_result));
    //    [DllImport ("__Internal")]
    //    [Verify (PlatformInvoke)]
    //    static extern bool ASSizeRangeEqualToSizeRange (ASSizeRange lhs, ASSizeRange rhs);

    //    // extern NSString * _Nonnull NSStringFromASSizeRange (ASSizeRange sizeRange) __attribute__((warn_unused_result));
    //    [DllImport ("__Internal")]
    //    [Verify (PlatformInvoke)]
    //    static extern NSString NSStringFromASSizeRange (ASSizeRange sizeRange);

    //    // extern NSString * _Nonnull ASGetDescriptionValueString (id _Nonnull object);
    //    [DllImport ("__Internal")]
    //    [Verify (PlatformInvoke)]
    //    static extern NSString ASGetDescriptionValueString (NSObject @object);

    //    // extern NSString * _Nonnull ASObjectDescriptionMakeWithoutObject (NSArray<NSDictionary *> * _Nullable propertyGroups);
    //    [DllImport ("__Internal")]
    //    [Verify (PlatformInvoke)]
    //    static extern NSString ASObjectDescriptionMakeWithoutObject ([NullAllowed] NSDictionary[] propertyGroups);

    //    // extern NSString * _Nonnull ASObjectDescriptionMake (id _Nonnull object, NSArray<NSDictionary *> * _Nullable propertyGroups);
    //    [DllImport ("__Internal")]
    //    [Verify (PlatformInvoke)]
    //    static extern NSString ASObjectDescriptionMake (NSObject @object, [NullAllowed] NSDictionary[] propertyGroups);

    //    // extern NSString * _Nonnull ASObjectDescriptionMakeTiny (id _Nullable object);
    //    [DllImport ("__Internal")]
    //    [Verify (PlatformInvoke)]
    //    static extern NSString ASObjectDescriptionMakeTiny ([NullAllowed] NSObject @object);

    //    // extern NSString * _Nullable ASStringWithQuotesIfMultiword (NSString * _Nullable string);
    //    [DllImport ("__Internal")]
    //    [Verify (PlatformInvoke)]
    //    [return: NullAllowed]
    //    static extern NSString ASStringWithQuotesIfMultiword ([NullAllowed] NSString @string);

    //    // extern void ASLayoutElementPushContext (ASLayoutElementContext * _Nonnull context);
    //    [DllImport ("__Internal")]
    //    [Verify (PlatformInvoke)]
    //    static extern void ASLayoutElementPushContext (ASLayoutElementContext context);

    //    // extern ASLayoutElementContext * _Nullable ASLayoutElementGetCurrentContext ();
    //    [DllImport ("__Internal")]
    //    [Verify (PlatformInvoke)]
    //    [return: NullAllowed]
    //    static extern ASLayoutElementContext ASLayoutElementGetCurrentContext ();

    //    // extern void ASLayoutElementPopContext ();
    //    [DllImport ("__Internal")]
    //    [Verify (PlatformInvoke)]
    //    static extern void ASLayoutElementPopContext ();

    //    // ASLayoutElementSize ASLayoutElementSizeMake () __attribute__((warn_unused_result));
    //    [DllImport ("__Internal")]
    //    [Verify (PlatformInvoke)]
    //    static extern ASLayoutElementSize ASLayoutElementSizeMake ();

    //    // ASLayoutElementSize ASLayoutElementSizeMakeFromCGSize (CGSize size) __attribute__((warn_unused_result));
    //    [DllImport ("__Internal")]
    //    [Verify (PlatformInvoke)]
    //    static extern ASLayoutElementSize ASLayoutElementSizeMakeFromCGSize (CGSize size);

    //    // BOOL ASLayoutElementSizeEqualToLayoutElementSize (ASLayoutElementSize lhs, ASLayoutElementSize rhs) __attribute__((warn_unused_result));
    //    [DllImport ("__Internal")]
    //    [Verify (PlatformInvoke)]
    //    static extern bool ASLayoutElementSizeEqualToLayoutElementSize (ASLayoutElementSize lhs, ASLayoutElementSize rhs);

    //    // extern NSString * _Nonnull NSStringFromASLayoutElementSize (ASLayoutElementSize size) __attribute__((warn_unused_result));
    //    [DllImport ("__Internal")]
    //    [Verify (PlatformInvoke)]
    //    static extern NSString NSStringFromASLayoutElementSize (ASLayoutElementSize size);

    //    // extern ASSizeRange ASLayoutElementSizeResolveAutoSize (ASLayoutElementSize size, const CGSize parentSize, ASSizeRange autoASSizeRange) __attribute__((warn_unused_result));
    //    [DllImport ("__Internal")]
    //    [Verify (PlatformInvoke)]
    //    static extern ASSizeRange ASLayoutElementSizeResolveAutoSize (ASLayoutElementSize size, CGSize parentSize, ASSizeRange autoASSizeRange);

    //    // ASSizeRange ASLayoutElementSizeResolve (ASLayoutElementSize size, const CGSize parentSize) __attribute__((warn_unused_result));
    //    [DllImport ("__Internal")]
    //    [Verify (PlatformInvoke)]
    //    static extern ASSizeRange ASLayoutElementSizeResolve (ASLayoutElementSize size, CGSize parentSize);

    //    // extern float __builtin_huge_valf () __attribute__((nothrow)) __attribute__((const));
    //    [DllImport ("__Internal")]
    //    [Verify (PlatformInvoke)]
    //    static extern float __builtin_huge_valf ();

    //    // extern ASPrimitiveTraitCollection ASPrimitiveTraitCollectionMakeDefault ();
    //    [DllImport ("__Internal")]
    //    [Verify (PlatformInvoke)]
    //    static extern ASPrimitiveTraitCollection ASPrimitiveTraitCollectionMakeDefault ();

    //    // extern ASPrimitiveTraitCollection ASPrimitiveTraitCollectionFromUITraitCollection (UITraitCollection * _Nonnull traitCollection);
    //    [DllImport ("__Internal")]
    //    [Verify (PlatformInvoke)]
    //    static extern ASPrimitiveTraitCollection ASPrimitiveTraitCollectionFromUITraitCollection (UITraitCollection traitCollection);

    //    // extern BOOL ASPrimitiveTraitCollectionIsEqualToASPrimitiveTraitCollection (ASPrimitiveTraitCollection lhs, ASPrimitiveTraitCollection rhs);
    //    [DllImport ("__Internal")]
    //    [Verify (PlatformInvoke)]
    //    static extern bool ASPrimitiveTraitCollectionIsEqualToASPrimitiveTraitCollection (ASPrimitiveTraitCollection lhs, ASPrimitiveTraitCollection rhs);

    //    // extern NSString * _Nonnull NSStringFromASPrimitiveTraitCollection (ASPrimitiveTraitCollection traits);
    //    [DllImport ("__Internal")]
    //    [Verify (PlatformInvoke)]
    //    static extern NSString NSStringFromASPrimitiveTraitCollection (ASPrimitiveTraitCollection traits);

    //    // extern void ASTraitCollectionPropagateDown (id<ASLayoutElement> _Nonnull element, ASPrimitiveTraitCollection traitCollection);
    //    [DllImport ("__Internal")]
    //    [Verify (PlatformInvoke)]
    //    static extern void ASTraitCollectionPropagateDown (ASLayoutElement element, ASPrimitiveTraitCollection traitCollection);

    //    // extern void ASPerformMainThreadDeallocation (id _Nullable object);
    //    [DllImport ("__Internal")]
    //    [Verify (PlatformInvoke)]
    //    static extern void ASPerformMainThreadDeallocation ([NullAllowed] NSObject @object);

    //    // BOOL ASInterfaceStateIncludesVisible (ASInterfaceState interfaceState);
    //    [DllImport ("__Internal")]
    //    [Verify (PlatformInvoke)]
    //    static extern bool ASInterfaceStateIncludesVisible (ASInterfaceState interfaceState);

    //    // BOOL ASInterfaceStateIncludesDisplay (ASInterfaceState interfaceState);
    //    [DllImport ("__Internal")]
    //    [Verify (PlatformInvoke)]
    //    static extern bool ASInterfaceStateIncludesDisplay (ASInterfaceState interfaceState);

    //    // BOOL ASInterfaceStateIncludesPreload (ASInterfaceState interfaceState);
    //    [DllImport ("__Internal")]
    //    [Verify (PlatformInvoke)]
    //    static extern bool ASInterfaceStateIncludesPreload (ASInterfaceState interfaceState);

    //    // BOOL ASInterfaceStateIncludesMeasureLayout (ASInterfaceState interfaceState);
    //    [DllImport ("__Internal")]
    //    [Verify (PlatformInvoke)]
    //    static extern bool ASInterfaceStateIncludesMeasureLayout (ASInterfaceState interfaceState);

    //    // NSString * _Nonnull NSStringFromASInterfaceState (ASInterfaceState interfaceState) __attribute__((unused));
    //    [DllImport ("__Internal")]
    //    [Verify (PlatformInvoke)]
    //    static extern NSString NSStringFromASInterfaceState (ASInterfaceState interfaceState);

    //    // NSString * _Nonnull NSStringFromASInterfaceStateChange (ASInterfaceState oldState, ASInterfaceState newState) __attribute__((unused));
    //    [DllImport ("__Internal")]
    //    [Verify (PlatformInvoke)]
    //    static extern NSString NSStringFromASInterfaceStateChange (ASInterfaceState oldState, ASInterfaceState newState);

    //    // extern ASInterfaceState ASInterfaceStateForDisplayNode (ASDisplayNode * _Nonnull displayNode, UIWindow * _Nonnull window) __attribute__((warn_unused_result));
    //    [DllImport ("__Internal")]
    //    [Verify (PlatformInvoke)]
    //    static extern ASInterfaceState ASInterfaceStateForDisplayNode (ASDisplayNode displayNode, UIWindow window);

    //    // extern ASDisplayNode * _Nullable ASLayerToDisplayNode (CALayer * _Nullable layer) __attribute__((warn_unused_result));
    //    [DllImport ("__Internal")]
    //    [Verify (PlatformInvoke)]
    //    [return: NullAllowed]
    //    static extern ASDisplayNode ASLayerToDisplayNode ([NullAllowed] CALayer layer);

    //    // extern ASDisplayNode * _Nullable ASViewToDisplayNode (UIView * _Nullable view) __attribute__((warn_unused_result));
    //    [DllImport ("__Internal")]
    //    [Verify (PlatformInvoke)]
    //    [return: NullAllowed]
    //    static extern ASDisplayNode ASViewToDisplayNode ([NullAllowed] UIView view);

    //    // extern ASDisplayNode * _Nonnull ASDisplayNodeUltimateParentOfNode (ASDisplayNode * _Nonnull node) __attribute__((warn_unused_result));
    //    [DllImport ("__Internal")]
    //    [Verify (PlatformInvoke)]
    //    static extern ASDisplayNode ASDisplayNodeUltimateParentOfNode (ASDisplayNode node);

    //    // extern void ASDisplayNodePerformBlockOnEveryNode (CALayer * _Nullable layer, ASDisplayNode * _Nullable node, BOOL traverseSublayers, void (^ _Nonnull)(ASDisplayNode * _Nonnull) block);
    //    [DllImport ("__Internal")]
    //    [Verify (PlatformInvoke)]
    //    static extern void ASDisplayNodePerformBlockOnEveryNode ([NullAllowed] CALayer layer, [NullAllowed] ASDisplayNode node, bool traverseSublayers, Action<ASDisplayNode> block);

    //    // extern void ASDisplayNodePerformBlockOnEveryNodeBFS (ASDisplayNode * _Nonnull node, void (^ _Nonnull)(ASDisplayNode * _Nonnull) block);
    //    [DllImport ("__Internal")]
    //    [Verify (PlatformInvoke)]
    //    static extern void ASDisplayNodePerformBlockOnEveryNodeBFS (ASDisplayNode node, Action<ASDisplayNode> block);

    //    // extern void ASDisplayNodePerformBlockOnEverySubnode (ASDisplayNode * _Nonnull node, BOOL traverseSublayers, void (^ _Nonnull)(ASDisplayNode * _Nonnull) block);
    //    [DllImport ("__Internal")]
    //    [Verify (PlatformInvoke)]
    //    static extern void ASDisplayNodePerformBlockOnEverySubnode (ASDisplayNode node, bool traverseSublayers, Action<ASDisplayNode> block);

    //    // extern ASDisplayNode * _Nullable ASDisplayNodeFindFirstSupernode (ASDisplayNode * _Nullable node, BOOL (^ _Nonnull)(ASDisplayNode * _Nonnull) block) __attribute__((deprecated("Use the `supernodes` property instead."))) __attribute__((warn_unused_result));
    //    [DllImport ("__Internal")]
    //    [Verify (PlatformInvoke)]
    //    [return: NullAllowed]
    //    static extern ASDisplayNode ASDisplayNodeFindFirstSupernode ([NullAllowed] ASDisplayNode node, Func<ASDisplayNode, bool> block);

    //    // extern __kindof ASDisplayNode * _Nullable ASDisplayNodeFindFirstSupernodeOfClass (ASDisplayNode * _Nonnull start, Class _Nonnull c) __attribute__((deprecated("Use the `supernodeOfClass:includingSelf:` method instead."))) __attribute__((warn_unused_result));
    //    [DllImport ("__Internal")]
    //    [Verify (PlatformInvoke)]
    //    static extern ASDisplayNode ASDisplayNodeFindFirstSupernodeOfClass (ASDisplayNode start, Class c);

    //    // extern UIWindow * _Nullable ASFindWindowOfLayer (CALayer * _Nonnull layer) __attribute__((warn_unused_result));
    //    [DllImport ("__Internal")]
    //    [Verify (PlatformInvoke)]
    //    [return: NullAllowed]
    //    static extern UIWindow ASFindWindowOfLayer (CALayer layer);

    //    // extern UIView * _Nullable ASFindClosestViewOfLayer (CALayer * _Nonnull layer) __attribute__((warn_unused_result));
    //    [DllImport ("__Internal")]
    //    [Verify (PlatformInvoke)]
    //    [return: NullAllowed]
    //    static extern UIView ASFindClosestViewOfLayer (CALayer layer);

    //    // extern ASDisplayNode * _Nullable ASDisplayNodeFindClosestCommonAncestor (ASDisplayNode * _Nonnull node1, ASDisplayNode * _Nonnull node2) __attribute__((warn_unused_result));
    //    [DllImport ("__Internal")]
    //    [Verify (PlatformInvoke)]
    //    [return: NullAllowed]
    //    static extern ASDisplayNode ASDisplayNodeFindClosestCommonAncestor (ASDisplayNode node1, ASDisplayNode node2);

    //    // extern NSArray<ASDisplayNode *> * _Nonnull ASCollectDisplayNodes (ASDisplayNode * _Nonnull node) __attribute__((warn_unused_result));
    //    [DllImport ("__Internal")]
    //    [Verify (PlatformInvoke)]
    //    static extern ASDisplayNode[] ASCollectDisplayNodes (ASDisplayNode node);

    //    // extern NSArray<ASDisplayNode *> * _Nonnull ASDisplayNodeFindAllSubnodes (ASDisplayNode * _Nonnull start, BOOL (^ _Nonnull)(ASDisplayNode * _Nonnull) block) __attribute__((warn_unused_result));
    //    [DllImport ("__Internal")]
    //    [Verify (PlatformInvoke)]
    //    static extern ASDisplayNode[] ASDisplayNodeFindAllSubnodes (ASDisplayNode start, Func<ASDisplayNode, bool> block);

    //    // extern NSArray<__kindof ASDisplayNode *> * _Nonnull ASDisplayNodeFindAllSubnodesOfClass (ASDisplayNode * _Nonnull start, Class _Nonnull c) __attribute__((warn_unused_result));
    //    [DllImport ("__Internal")]
    //    [Verify (PlatformInvoke)]
    //    static extern ASDisplayNode[] ASDisplayNodeFindAllSubnodesOfClass (ASDisplayNode start, Class c);

    //    // extern __kindof ASDisplayNode * _Nullable ASDisplayNodeFindFirstNode (ASDisplayNode * _Nonnull start, BOOL (^ _Nonnull)(ASDisplayNode * _Nonnull) block) __attribute__((warn_unused_result));
    //    [DllImport ("__Internal")]
    //    [Verify (PlatformInvoke)]
    //    static extern ASDisplayNode ASDisplayNodeFindFirstNode (ASDisplayNode start, Func<ASDisplayNode, bool> block);

    //    // extern __kindof ASDisplayNode * _Nullable ASDisplayNodeFindFirstSubnode (ASDisplayNode * _Nonnull start, BOOL (^ _Nonnull)(ASDisplayNode * _Nonnull) block) __attribute__((warn_unused_result));
    //    [DllImport ("__Internal")]
    //    [Verify (PlatformInvoke)]
    //    static extern ASDisplayNode ASDisplayNodeFindFirstSubnode (ASDisplayNode start, Func<ASDisplayNode, bool> block);

    //    // extern __kindof ASDisplayNode * _Nullable ASDisplayNodeFindFirstSubnodeOfClass (ASDisplayNode * _Nonnull start, Class _Nonnull c) __attribute__((warn_unused_result));
    //    [DllImport ("__Internal")]
    //    [Verify (PlatformInvoke)]
    //    static extern ASDisplayNode ASDisplayNodeFindFirstSubnodeOfClass (ASDisplayNode start, Class c);

    //    // extern UIColor * _Nonnull ASDisplayNodeDefaultPlaceholderColor () __attribute__((warn_unused_result));
    //    [DllImport ("__Internal")]
    //    [Verify (PlatformInvoke)]
    //    static extern UIColor ASDisplayNodeDefaultPlaceholderColor ();

    //    // extern UIColor * _Nonnull ASDisplayNodeDefaultTintColor () __attribute__((warn_unused_result));
    //    [DllImport ("__Internal")]
    //    [Verify (PlatformInvoke)]
    //    static extern UIColor ASDisplayNodeDefaultTintColor ();

    //    // extern void ASDisplayNodeDisableHierarchyNotifications (ASDisplayNode * _Nonnull node);
    //    [DllImport ("__Internal")]
    //    [Verify (PlatformInvoke)]
    //    static extern void ASDisplayNodeDisableHierarchyNotifications (ASDisplayNode node);

    //    // extern void ASDisplayNodeEnableHierarchyNotifications (ASDisplayNode * _Nonnull node);
    //    [DllImport ("__Internal")]
    //    [Verify (PlatformInvoke)]
    //    static extern void ASDisplayNodeEnableHierarchyNotifications (ASDisplayNode node);

    //    // extern void _ASSetDebugNames (Class _Nonnull owningClass, NSString * _Nonnull names, ASDisplayNode * _Nullable object, ...);
    //    [DllImport ("__Internal")]
    //    [Verify (PlatformInvoke)]
    //    static extern void _ASSetDebugNames (Class owningClass, NSString names, [NullAllowed] ASDisplayNode @object, IntPtr varArgs);

    //    // extern asimagenode_modification_block_t _Nonnull ASImageNodeRoundBorderModificationBlock (CGFloat borderWidth, UIColor * _Nullable borderColor);
    //    [DllImport ("__Internal")]
    //    [Verify (PlatformInvoke)]
    //    static extern asimagenode_modification_block_t ASImageNodeRoundBorderModificationBlock (nfloat borderWidth, [NullAllowed] UIColor borderColor);

    //    // extern asimagenode_modification_block_t _Nonnull ASImageNodeTintColorModificationBlock (UIColor * _Nonnull color);
    //    [DllImport ("__Internal")]
    //    [Verify (PlatformInvoke)]
    //    static extern asimagenode_modification_block_t ASImageNodeTintColorModificationBlock (UIColor color);

    //    // BOOL ASDisplayNodeThreadIsMain ();
    //    [DllImport ("__Internal")]
    //    [Verify (PlatformInvoke)]
    //    static extern bool ASDisplayNodeThreadIsMain ();

    //    // extern BOOL ASRangeTuningParametersEqualToRangeTuningParameters (ASRangeTuningParameters lhs, ASRangeTuningParameters rhs);
    //    [DllImport ("__Internal")]
    //    [Verify (PlatformInvoke)]
    //    static extern bool ASRangeTuningParametersEqualToRangeTuningParameters (ASRangeTuningParameters lhs, ASRangeTuningParameters rhs);

    //    // extern BOOL ASScrollDirectionContainsVerticalDirection (ASScrollDirection scrollDirection);
    //    [DllImport ("__Internal")]
    //    [Verify (PlatformInvoke)]
    //    static extern bool ASScrollDirectionContainsVerticalDirection (ASScrollDirection scrollDirection);

    //    // extern BOOL ASScrollDirectionContainsHorizontalDirection (ASScrollDirection scrollDirection);
    //    [DllImport ("__Internal")]
    //    [Verify (PlatformInvoke)]
    //    static extern bool ASScrollDirectionContainsHorizontalDirection (ASScrollDirection scrollDirection);

    //    // extern BOOL ASScrollDirectionContainsRight (ASScrollDirection scrollDirection);
    //    [DllImport ("__Internal")]
    //    [Verify (PlatformInvoke)]
    //    static extern bool ASScrollDirectionContainsRight (ASScrollDirection scrollDirection);

    //    // extern BOOL ASScrollDirectionContainsLeft (ASScrollDirection scrollDirection);
    //    [DllImport ("__Internal")]
    //    [Verify (PlatformInvoke)]
    //    static extern bool ASScrollDirectionContainsLeft (ASScrollDirection scrollDirection);

    //    // extern BOOL ASScrollDirectionContainsUp (ASScrollDirection scrollDirection);
    //    [DllImport ("__Internal")]
    //    [Verify (PlatformInvoke)]
    //    static extern bool ASScrollDirectionContainsUp (ASScrollDirection scrollDirection);

    //    // extern BOOL ASScrollDirectionContainsDown (ASScrollDirection scrollDirection);
    //    [DllImport ("__Internal")]
    //    [Verify (PlatformInvoke)]
    //    static extern bool ASScrollDirectionContainsDown (ASScrollDirection scrollDirection);

    //    // extern ASScrollDirection ASScrollDirectionApplyTransform (ASScrollDirection scrollDirection, CGAffineTransform transform);
    //    [DllImport ("__Internal")]
    //    [Verify (PlatformInvoke)]
    //    static extern ASScrollDirection ASScrollDirectionApplyTransform (ASScrollDirection scrollDirection, CGAffineTransform transform);

    //    // extern ASSizeRange NodeConstrainedSizeForScrollDirection (ASCollectionView * _Nonnull collectionView);
    //    [DllImport ("__Internal")]
    //    [Verify (PlatformInvoke)]
    //    static extern ASSizeRange NodeConstrainedSizeForScrollDirection (ASCollectionView collectionView);

    //    // extern ASLayoutRangeMode ASLayoutRangeModeForVisibilityDepth (NSUInteger visibilityDepth);
    //    [DllImport ("__Internal")]
    //    [Verify (PlatformInvoke)]
    //    static extern ASLayoutRangeMode ASLayoutRangeModeForVisibilityDepth (nuint visibilityDepth);

    //    // extern BOOL ASPointIsNull (CGPoint point);
    //    [DllImport ("__Internal")]
    //    [Verify (PlatformInvoke)]
    //    static extern bool ASPointIsNull (CGPoint point);

    //    // extern ASLayout * _Nonnull ASCalculateRootLayout (id<ASLayoutElement> _Nonnull rootLayoutElement, const ASSizeRange sizeRange);
    //    [DllImport ("__Internal")]
    //    [Verify (PlatformInvoke)]
    //    static extern ASLayout ASCalculateRootLayout (ASLayoutElement rootLayoutElement, ASSizeRange sizeRange);

    //    // extern ASLayout * _Nonnull ASCalculateLayout (id<ASLayoutElement> _Nonnull layoutElement, const ASSizeRange sizeRange, const CGSize parentSize);
    //    [DllImport ("__Internal")]
    //    [Verify (PlatformInvoke)]
    //    static extern ASLayout ASCalculateLayout (ASLayoutElement layoutElement, ASSizeRange sizeRange, CGSize parentSize);

    //    // extern void ASPerformBlockOnMainThread (void (^ _Nonnull)() block);
    //    [DllImport ("__Internal")]
    //    [Verify (PlatformInvoke)]
    //    static extern void ASPerformBlockOnMainThread (Action block);

    //    // extern void ASPerformBlockOnBackgroundThread (void (^ _Nonnull)() block);
    //    [DllImport ("__Internal")]
    //    [Verify (PlatformInvoke)]
    //    static extern void ASPerformBlockOnBackgroundThread (Action block);

    //    // BOOL ASObjectIsEqual (id<NSObject> obj, id<NSObject> otherObj);
    //    [DllImport ("__Internal")]
    //    [Verify (PlatformInvoke)]
    //    static extern bool ASObjectIsEqual (NSObject obj, NSObject otherObj);

    //    // extern NSUInteger ASHashBytes (void * _Nonnull bytes, size_t length);
    //    [DllImport ("__Internal")]
    //    [Verify (PlatformInvoke)]
    //    static extern unsafe nuint ASHashBytes (void* bytes, nuint length);

    //    // extern void ASDisableLogging ();
    //    [DllImport ("__Internal")]
    //    [Verify (PlatformInvoke)]
    //    static extern void ASDisableLogging ();

    //    // extern os_log_t ASNodeLog ();
    //    [DllImport ("__Internal")]
    //    [Verify (PlatformInvoke)]
    //    static extern OS_os_log ASNodeLog ();

    //    // extern os_log_t ASLayoutLog ();
    //    [DllImport ("__Internal")]
    //    [Verify (PlatformInvoke)]
    //    static extern OS_os_log ASLayoutLog ();

    //    // extern os_log_t ASDisplayLog ();
    //    [DllImport ("__Internal")]
    //    [Verify (PlatformInvoke)]
    //    static extern OS_os_log ASDisplayLog ();

    //    // extern os_log_t ASCollectionLog ();
    //    [DllImport ("__Internal")]
    //    [Verify (PlatformInvoke)]
    //    static extern OS_os_log ASCollectionLog ();

    //    // extern os_log_t ASImageLoadingLog ();
    //    [DllImport ("__Internal")]
    //    [Verify (PlatformInvoke)]
    //    static extern OS_os_log ASImageLoadingLog ();

    //    // extern os_log_t ASMainThreadDeallocationLog ();
    //    [DllImport ("__Internal")]
    //    [Verify (PlatformInvoke)]
    //    static extern OS_os_log ASMainThreadDeallocationLog ();

    //    // CGFloat ASCGFloatFromString (NSString * _Nonnull string);
    //    [DllImport ("__Internal")]
    //    [Verify (PlatformInvoke)]
    //    static extern nfloat ASCGFloatFromString (NSString @string);

    //    // CGFloat ASCGFloatFromNumber (NSNumber * _Nonnull number);
    //    [DllImport ("__Internal")]
    //    [Verify (PlatformInvoke)]
    //    static extern nfloat ASCGFloatFromNumber (NSNumber number);

    //    // BOOL CGSizeEqualToSizeWithIn (CGSize size1, CGSize size2, CGFloat delta);
    //    [DllImport ("__Internal")]
    //    [Verify (PlatformInvoke)]
    //    static extern bool CGSizeEqualToSizeWithIn (CGSize size1, CGSize size2, nfloat delta);
    //}

    [Native]
    public enum ASDimensionUnit : long
    {
        Auto,
        Points,
        Fraction
    }

    [StructLayout (LayoutKind.Sequential)]
    public struct ASDimension
    {
        public ASDimensionUnit unit;

        public nfloat value;
    }

    [StructLayout (LayoutKind.Sequential)]
    public struct ASLayoutSize
    {
        public ASDimension width;

        public ASDimension height;
    }

    [StructLayout (LayoutKind.Sequential)]
    public struct ASSizeRange
    {
        public CGSize min;

        public CGSize max;
    }

    [StructLayout (LayoutKind.Sequential)]
    public struct ASLayoutElementStyleExtensions
    {
        public bool[] boolExtensions;

        public nint[] integerExtensions;

        public UIEdgeInsets[] edgeInsetsExtensions;
    }

    [StructLayout (LayoutKind.Sequential)]
    public struct ASLayoutElementSize
    {
        public ASDimension width;

        public ASDimension height;

        public ASDimension minWidth;

        public ASDimension maxWidth;

        public ASDimension minHeight;

        public ASDimension maxHeight;
    }

    [Native]
    public enum ASStackLayoutDirection : long
    {
        Vertical,
        Horizontal
    }

    [Native]
    public enum ASStackLayoutJustifyContent : long
    {
        Start,
        Center,
        End,
        SpaceBetween,
        SpaceAround
    }

    [Native]
    public enum ASStackLayoutAlignItems : long
    {
        Start,
        End,
        Center,
        Stretch,
        BaselineFirst,
        BaselineLast,
        NotSet
    }

    [Native]
    public enum ASStackLayoutAlignSelf : long
    {
        Auto,
        Start,
        End,
        Center,
        Stretch
    }

    [Native]
    public enum ASStackLayoutFlexWrap : long
    {
        NoWrap,
        Wrap
    }

    [Native]
    public enum ASStackLayoutAlignContent : long
    {
        Start,
        Center,
        End,
        SpaceBetween,
        SpaceAround,
        Stretch
    }

    [Native]
    public enum ASHorizontalAlignment : long
    {
        HorizontalAlignmentNone,
        HorizontalAlignmentLeft,
        HorizontalAlignmentMiddle,
        HorizontalAlignmentRight,
        AlignmentLeft = HorizontalAlignmentLeft,
        AlignmentMiddle = HorizontalAlignmentMiddle,
        AlignmentRight = HorizontalAlignmentRight
    }

    [Native]
    public enum ASVerticalAlignment : long
    {
        VerticalAlignmentNone,
        VerticalAlignmentTop,
        VerticalAlignmentCenter,
        VerticalAlignmentBottom,
        AlignmentTop = VerticalAlignmentTop,
        AlignmentCenter = VerticalAlignmentCenter,
        AlignmentBottom = VerticalAlignmentBottom
    }

    [StructLayout (LayoutKind.Sequential)]
    public struct ASPrimitiveTraitCollection
    {
        public nfloat displayScale;

        public UIUserInterfaceSizeClass horizontalSizeClass;

        public UIUserInterfaceIdiom userInterfaceIdiom;

        public UIUserInterfaceSizeClass verticalSizeClass;

        public UIForceTouchCapability forceTouchCapability;

        public CGSize containerSize;
    }

    [Native]
    public enum ASLayoutElementType : long
    {
        LayoutSpec,
        DisplayNode
    }

    [Native]
    public enum ASInterfaceState : long
    {
        None = 0,
        MeasureLayout = 1 << 0,
        Preload = 1 << 1,
        Display = 1 << 2,
        Visible = 1 << 3,
        InHierarchy = MeasureLayout | Preload | Display | Visible
    }

    [Native]
    public enum ASCornerRoundingType : long
    {
        DefaultSlowCALayer,
        Precomposited,
        Clipping
    }

    [Native]
    public enum ASControlNodeEvent : long
    {
        TouchDown = 1 << 0,
        TouchDownRepeat = 1 << 1,
        TouchDragInside = 1 << 2,
        TouchDragOutside = 1 << 3,
        TouchUpInside = 1 << 4,
        TouchUpOutside = 1 << 5,
        TouchCancel = 1 << 6,
        ValueChanged = 1 << 12,
        PrimaryActionTriggered = 1 << 13,
        AllEvents = 4294967295L
    }

    [Native]
    public enum ASTextNodeHighlightStyle : long
    {
        Light,
        Dark
    }

    [Native]
    public enum ASButtonNodeImageAlignment : long
    {
        Beginning,
        End
    }

    [Native]
    public enum ASMapNodeShowAnnotationsOptions : long
    {
        Ignored = 0,
        Zoomed = 1 << 0,
        Animated = 1 << 1
    }

    [Native]
    public enum ASVideoNodePlayerState : long
    {
        Unknown,
        InitialLoading,
        ReadyToPlay,
        PlaybackLikelyToKeepUpButNotPlaying,
        Playing,
        Loading,
        Paused,
        Finished
    }

    [Native]
    public enum ASVideoPlayerNodeControlType : long
    {
        PlaybackButton,
        ElapsedText,
        DurationText,
        Scrubber,
        FullScreenButton,
        FlexGrowSpacer
    }

    [Native]
    public enum ASImageDownloaderPriority : long
    {
        Preload = 0,
        Imminent,
        Visible
    }

    [Native]
    public enum ASMultiplexImageNodeErrorCode : long
    {
        NoSourceForImage = 0,
        BestImageIdentifierChanged,
        PhotosImageManagerFailedWithoutError,
        PHAssetIsUnavailable
    }

    [StructLayout (LayoutKind.Sequential)]
    public struct ASRangeTuningParameters
    {
        public nfloat leadingBufferScreenfuls;

        public nfloat trailingBufferScreenfuls;
    }

    [Native]
    public enum ASLayoutRangeMode : long
    {
        Unspecified = -1,
        Minimum = 0,
        Full,
        VisibleOnly,
        LowMemory
    }

    [Native]
    public enum ASLayoutRangeType : long
    {
        Display,
        Preload
    }

    [Native]
    public enum ASScrollDirection : long
    {
        None = 0,
        Right = 1 << 0,
        Left = 1 << 1,
        Up = 1 << 2,
        Down = 1 << 3
    }

    [Native]
    public enum ASCellNodeVisibilityEvent : long
    {
        Visible,
        VisibleRectChanged,
        Invisible,
        WillBeginDragging,
        DidEndDragging
    }

    [Native]
    public enum ASRelativeLayoutSpecPosition : long
    {
        None = 0,
        Start = 1,
        Center = 2,
        End = 3
    }

    [Native]
    public enum ASRelativeLayoutSpecSizingOption : long
    {
        Default,
        MinimumWidth = 1 << 0,
        MinimumHeight = 1 << 1,
        MinimumSize = MinimumWidth | MinimumHeight
    }

    [Native]
    public enum ASCenterLayoutSpecCenteringOptions : long
    {
        None = 0,
        X = 1 << 0,
        Y = 1 << 1,
        Xy = X | Y
    }

    [Native]
    public enum ASCenterLayoutSpecSizingOptions : long
    {
        Default = 0,
        MinimumX = 1 << 0,
        MinimumY = 1 << 1,
        MinimumXY = ASCenterLayoutSpecSizingOptions.MinimumX | ASCenterLayoutSpecSizingOptions.MinimumY
    }

    [Native]
    public enum ASAbsoluteLayoutSpecSizing : long
    {
        Default,
        SizeToFit
    }

    [Native]
    public enum ASAsyncTransactionState : long
    {
        Open = 0,
        Committed,
        Canceled,
        Complete
    }

    [Native]
    public enum ASDisplayNodePerformanceMeasurementOptions : long
    {
        Spec = 1 << 0,
        Computation = 1 << 1
    }

    [StructLayout (LayoutKind.Sequential)]
    public struct ASDisplayNodePerformanceMeasurements
    {
        public double layoutSpecTotalTime;

        public nint layoutSpecNumberOfPasses;

        public double layoutComputationTotalTime;

        public nint layoutComputationNumberOfPasses;
    }

    [Native]
    public enum ASTextNodeExperimentOptions : long
    {
        Subclasses = 1 << 0,
        RandomInstances = 1 << 1,
        AllInstances = 1 << 2,
        Debugging = 1 << 3
    }
}
