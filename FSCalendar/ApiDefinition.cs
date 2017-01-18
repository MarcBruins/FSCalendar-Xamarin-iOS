using System;
using CoreAnimation;
using CoreGraphics;
using Foundation;
using ObjCRuntime;
using UIKit;

namespace WenchaoD.FSCalendar
{
    [Static]
    partial interface Constants
    {
        // extern const CGFloat FSCalendarStandardHeaderHeight __attribute__((visibility("default")));
        [Field("FSCalendarStandardHeaderHeight", "__Internal")]
        nfloat FSCalendarStandardHeaderHeight { get; }

        // extern const CGFloat FSCalendarStandardWeekdayHeight __attribute__((visibility("default")));
        [Field("FSCalendarStandardWeekdayHeight", "__Internal")]
        nfloat FSCalendarStandardWeekdayHeight { get; }

        // extern const CGFloat FSCalendarStandardMonthlyPageHeight __attribute__((visibility("default")));
        [Field("FSCalendarStandardMonthlyPageHeight", "__Internal")]
        nfloat FSCalendarStandardMonthlyPageHeight { get; }

        // extern const CGFloat FSCalendarStandardWeeklyPageHeight __attribute__((visibility("default")));
        [Field("FSCalendarStandardWeeklyPageHeight", "__Internal")]
        nfloat FSCalendarStandardWeeklyPageHeight { get; }

        // extern const CGFloat FSCalendarStandardCellDiameter __attribute__((visibility("default")));
        [Field("FSCalendarStandardCellDiameter", "__Internal")]
        nfloat FSCalendarStandardCellDiameter { get; }

        // extern const CGFloat FSCalendarStandardSeparatorThickness __attribute__((visibility("default")));
        [Field("FSCalendarStandardSeparatorThickness", "__Internal")]
        nfloat FSCalendarStandardSeparatorThickness { get; }

        // extern const CGFloat FSCalendarAutomaticDimension __attribute__((visibility("default")));
        [Field("FSCalendarAutomaticDimension", "__Internal")]
        nfloat FSCalendarAutomaticDimension { get; }

        // extern const CGFloat FSCalendarDefaultBounceAnimationDuration __attribute__((visibility("default")));
        [Field("FSCalendarDefaultBounceAnimationDuration", "__Internal")]
        nfloat FSCalendarDefaultBounceAnimationDuration { get; }

        // extern const CGFloat FSCalendarStandardRowHeight __attribute__((visibility("default")));
        [Field("FSCalendarStandardRowHeight", "__Internal")]
        nfloat FSCalendarStandardRowHeight { get; }

        // extern const CGFloat FSCalendarStandardTitleTextSize __attribute__((visibility("default")));
        [Field("FSCalendarStandardTitleTextSize", "__Internal")]
        nfloat FSCalendarStandardTitleTextSize { get; }

        // extern const CGFloat FSCalendarStandardSubtitleTextSize __attribute__((visibility("default")));
        [Field("FSCalendarStandardSubtitleTextSize", "__Internal")]
        nfloat FSCalendarStandardSubtitleTextSize { get; }

        // extern const CGFloat FSCalendarStandardWeekdayTextSize __attribute__((visibility("default")));
        [Field("FSCalendarStandardWeekdayTextSize", "__Internal")]
        nfloat FSCalendarStandardWeekdayTextSize { get; }

        // extern const CGFloat FSCalendarStandardHeaderTextSize __attribute__((visibility("default")));
        [Field("FSCalendarStandardHeaderTextSize", "__Internal")]
        nfloat FSCalendarStandardHeaderTextSize { get; }

        // extern const CGFloat FSCalendarMaximumEventDotDiameter __attribute__((visibility("default")));
        [Field("FSCalendarMaximumEventDotDiameter", "__Internal")]
        nfloat FSCalendarMaximumEventDotDiameter { get; }

        // extern const CGFloat FSCalendarStandardScopeHandleHeight __attribute__((visibility("default")));
        [Field("FSCalendarStandardScopeHandleHeight", "__Internal")]
        nfloat FSCalendarStandardScopeHandleHeight { get; }

        // extern const NSInteger FSCalendarDefaultHourComponent __attribute__((visibility("default")));
        [Field("FSCalendarDefaultHourComponent", "__Internal")]
        nint FSCalendarDefaultHourComponent { get; }

        // extern NSString *const FSCalendarDefaultCellReuseIdentifier __attribute__((visibility("default")));
        [Field("FSCalendarDefaultCellReuseIdentifier", "__Internal")]
        NSString FSCalendarDefaultCellReuseIdentifier { get; }

        // extern NSString *const FSCalendarInvalidArgumentsExceptionName __attribute__((visibility("default")));
        [Field("FSCalendarInvalidArgumentsExceptionName", "__Internal")]
        NSString FSCalendarInvalidArgumentsExceptionName { get; }

        //// extern double FSCalendarVersionNumber;
        //[Field("FSCalendarVersionNumber", "__Internal")]
        //double FSCalendarVersionNumber { get; }

        //// extern const unsigned char [] FSCalendarVersionString;
        //[Field("FSCalendarVersionString", "__Internal")]
        //IntPtr FSCalendarVersionString { get; }

        //// extern double FSCalendarVersionNumber;
        //[Field("FSCalendarVersionNumber", "__Internal")]
        //double FSCalendarVersionNumber { get; }

        //// extern const unsigned char [] FSCalendarVersionString;
        //[Field("FSCalendarVersionString", "__Internal")]
        //byte[] FSCalendarVersionString { get; }
    }

    // @interface FSCalendarAppearance : NSObject
    [BaseType(typeof(NSObject))]
    interface FSCalendarAppearance
    {
        // @property (nonatomic, strong) UIFont * titleFont;
        [Export("titleFont", ArgumentSemantic.Strong)]
        UIFont TitleFont { get; set; }

        // @property (nonatomic, strong) UIFont * subtitleFont;
        [Export("subtitleFont", ArgumentSemantic.Strong)]
        UIFont SubtitleFont { get; set; }

        // @property (nonatomic, strong) UIFont * weekdayFont;
        [Export("weekdayFont", ArgumentSemantic.Strong)]
        UIFont WeekdayFont { get; set; }

        // @property (nonatomic, strong) UIFont * headerTitleFont;
        [Export("headerTitleFont", ArgumentSemantic.Strong)]
        UIFont HeaderTitleFont { get; set; }

        // @property (assign, nonatomic) CGPoint titleOffset;
        [Export("titleOffset", ArgumentSemantic.Assign)]
        CGPoint TitleOffset { get; set; }

        // @property (assign, nonatomic) CGPoint subtitleOffset;
        [Export("subtitleOffset", ArgumentSemantic.Assign)]
        CGPoint SubtitleOffset { get; set; }

        // @property (assign, nonatomic) CGPoint eventOffset;
        [Export("eventOffset", ArgumentSemantic.Assign)]
        CGPoint EventOffset { get; set; }

        // @property (assign, nonatomic) CGPoint imageOffset;
        [Export("imageOffset", ArgumentSemantic.Assign)]
        CGPoint ImageOffset { get; set; }

        // @property (nonatomic, strong) UIColor * eventDefaultColor;
        [Export("eventDefaultColor", ArgumentSemantic.Strong)]
        UIColor EventDefaultColor { get; set; }

        // @property (nonatomic, strong) UIColor * eventSelectionColor;
        [Export("eventSelectionColor", ArgumentSemantic.Strong)]
        UIColor EventSelectionColor { get; set; }

        // @property (nonatomic, strong) UIColor * weekdayTextColor;
        [Export("weekdayTextColor", ArgumentSemantic.Strong)]
        UIColor WeekdayTextColor { get; set; }

        // @property (nonatomic, strong) UIColor * headerTitleColor;
        [Export("headerTitleColor", ArgumentSemantic.Strong)]
        UIColor HeaderTitleColor { get; set; }

        // @property (nonatomic, strong) NSString * headerDateFormat;
        [Export("headerDateFormat", ArgumentSemantic.Strong)]
        string HeaderDateFormat { get; set; }

        // @property (assign, nonatomic) CGFloat headerMinimumDissolvedAlpha;
        [Export("headerMinimumDissolvedAlpha")]
        nfloat HeaderMinimumDissolvedAlpha { get; set; }

        // @property (nonatomic, strong) UIColor * titleDefaultColor;
        [Export("titleDefaultColor", ArgumentSemantic.Strong)]
        UIColor TitleDefaultColor { get; set; }

        // @property (nonatomic, strong) UIColor * titleSelectionColor;
        [Export("titleSelectionColor", ArgumentSemantic.Strong)]
        UIColor TitleSelectionColor { get; set; }

        // @property (nonatomic, strong) UIColor * titleTodayColor;
        [Export("titleTodayColor", ArgumentSemantic.Strong)]
        UIColor TitleTodayColor { get; set; }

        // @property (nonatomic, strong) UIColor * titlePlaceholderColor;
        [Export("titlePlaceholderColor", ArgumentSemantic.Strong)]
        UIColor TitlePlaceholderColor { get; set; }

        // @property (nonatomic, strong) UIColor * titleWeekendColor;
        [Export("titleWeekendColor", ArgumentSemantic.Strong)]
        UIColor TitleWeekendColor { get; set; }

        // @property (nonatomic, strong) UIColor * subtitleDefaultColor;
        [Export("subtitleDefaultColor", ArgumentSemantic.Strong)]
        UIColor SubtitleDefaultColor { get; set; }

        // @property (nonatomic, strong) UIColor * subtitleSelectionColor;
        [Export("subtitleSelectionColor", ArgumentSemantic.Strong)]
        UIColor SubtitleSelectionColor { get; set; }

        // @property (nonatomic, strong) UIColor * subtitleTodayColor;
        [Export("subtitleTodayColor", ArgumentSemantic.Strong)]
        UIColor SubtitleTodayColor { get; set; }

        // @property (nonatomic, strong) UIColor * subtitlePlaceholderColor;
        [Export("subtitlePlaceholderColor", ArgumentSemantic.Strong)]
        UIColor SubtitlePlaceholderColor { get; set; }

        // @property (nonatomic, strong) UIColor * subtitleWeekendColor;
        [Export("subtitleWeekendColor", ArgumentSemantic.Strong)]
        UIColor SubtitleWeekendColor { get; set; }

        // @property (nonatomic, strong) UIColor * selectionColor;
        [Export("selectionColor", ArgumentSemantic.Strong)]
        UIColor SelectionColor { get; set; }

        // @property (nonatomic, strong) UIColor * todayColor;
        [Export("todayColor", ArgumentSemantic.Strong)]
        UIColor TodayColor { get; set; }

        // @property (nonatomic, strong) UIColor * todaySelectionColor;
        [Export("todaySelectionColor", ArgumentSemantic.Strong)]
        UIColor TodaySelectionColor { get; set; }

        // @property (nonatomic, strong) UIColor * borderDefaultColor;
        [Export("borderDefaultColor", ArgumentSemantic.Strong)]
        UIColor BorderDefaultColor { get; set; }

        // @property (nonatomic, strong) UIColor * borderSelectionColor;
        [Export("borderSelectionColor", ArgumentSemantic.Strong)]
        UIColor BorderSelectionColor { get; set; }

        // @property (assign, nonatomic) CGFloat borderRadius;
        [Export("borderRadius")]
        nfloat BorderRadius { get; set; }

        // @property (assign, nonatomic) FSCalendarCaseOptions caseOptions;
        [Export("caseOptions", ArgumentSemantic.Assign)]
        FSCalendarCaseOptions CaseOptions { get; set; }

        // @property (assign, nonatomic) FSCalendarSeparators separators;
        [Export("separators", ArgumentSemantic.Assign)]
        FSCalendarSeparators Separators { get; set; }

        // @property (assign, nonatomic) BOOL adjustsFontSizeToFitContentSize;
        [Export("adjustsFontSizeToFitContentSize")]
        bool AdjustsFontSizeToFitContentSize { get; set; }

        // -(void)invalidateAppearance;
        [Export("invalidateAppearance")]
        void InvalidateAppearance();
    }

    // @interface FSCalendarCell : UICollectionViewCell
    [BaseType(typeof(UICollectionViewCell))]
    interface FSCalendarCell
    {
        // @property (nonatomic, weak) FSCalendar * calendar;
        [Export("calendar", ArgumentSemantic.Weak)]
        FSCalendar Calendar { get; set; }

        // @property (nonatomic, weak) FSCalendarAppearance * appearance;
        //[Export("appearance", ArgumentSemantic.Weak)]
        //FSCalendarAppearance Appearance { get; set; }

        // @property (nonatomic, weak) UILabel * titleLabel;
        [Export("titleLabel", ArgumentSemantic.Weak)]
        UILabel TitleLabel { get; set; }

        // @property (nonatomic, weak) UILabel * subtitleLabel;
        [Export("subtitleLabel", ArgumentSemantic.Weak)]
        UILabel SubtitleLabel { get; set; }

        // @property (nonatomic, weak) UIImageView * imageView;
        [Export("imageView", ArgumentSemantic.Weak)]
        UIImageView ImageView { get; set; }

        // @property (nonatomic, weak) CAShapeLayer * shapeLayer;
        [Export("shapeLayer", ArgumentSemantic.Weak)]
        CAShapeLayer ShapeLayer { get; set; }

        // @property (nonatomic, weak) FSCalendarEventIndicator * eventIndicator;
        [Export("eventIndicator", ArgumentSemantic.Weak)]
        FSCalendarEventIndicator EventIndicator { get; set; }

        // @property (nonatomic, strong) NSString * title;
        [Export("title", ArgumentSemantic.Strong)]
        string Title { get; set; }

        // @property (nonatomic, strong) NSString * subtitle;
        [Export("subtitle", ArgumentSemantic.Strong)]
        string Subtitle { get; set; }

        // @property (nonatomic, strong) UIImage * image;
        [Export("image", ArgumentSemantic.Strong)]
        UIImage Image { get; set; }

        // @property (assign, nonatomic) FSCalendarMonthPosition monthPosition;
        [Export("monthPosition", ArgumentSemantic.Assign)]
        FSCalendarMonthPosition MonthPosition { get; set; }

        // @property (assign, nonatomic) NSInteger numberOfEvents;
        [Export("numberOfEvents")]
        nint NumberOfEvents { get; set; }

        // @property (assign, nonatomic) BOOL dateIsToday;
        [Export("dateIsToday")]
        bool DateIsToday { get; set; }

        // @property (assign, nonatomic) BOOL weekend;
        [Export("weekend")]
        bool Weekend { get; set; }

        // @property (assign, nonatomic) BOOL placeholder;
        [Export("placeholder")]
        bool Placeholder { get; set; }

        // @property (nonatomic, strong) UIColor * preferredFillDefaultColor;
        [Export("preferredFillDefaultColor", ArgumentSemantic.Strong)]
        UIColor PreferredFillDefaultColor { get; set; }

        // @property (nonatomic, strong) UIColor * preferredFillSelectionColor;
        [Export("preferredFillSelectionColor", ArgumentSemantic.Strong)]
        UIColor PreferredFillSelectionColor { get; set; }

        // @property (nonatomic, strong) UIColor * preferredTitleDefaultColor;
        [Export("preferredTitleDefaultColor", ArgumentSemantic.Strong)]
        UIColor PreferredTitleDefaultColor { get; set; }

        // @property (nonatomic, strong) UIColor * preferredTitleSelectionColor;
        [Export("preferredTitleSelectionColor", ArgumentSemantic.Strong)]
        UIColor PreferredTitleSelectionColor { get; set; }

        // @property (nonatomic, strong) UIColor * preferredSubtitleDefaultColor;
        [Export("preferredSubtitleDefaultColor", ArgumentSemantic.Strong)]
        UIColor PreferredSubtitleDefaultColor { get; set; }

        // @property (nonatomic, strong) UIColor * preferredSubtitleSelectionColor;
        [Export("preferredSubtitleSelectionColor", ArgumentSemantic.Strong)]
        UIColor PreferredSubtitleSelectionColor { get; set; }

        // @property (nonatomic, strong) UIColor * preferredBorderDefaultColor;
        [Export("preferredBorderDefaultColor", ArgumentSemantic.Strong)]
        UIColor PreferredBorderDefaultColor { get; set; }

        // @property (nonatomic, strong) UIColor * preferredBorderSelectionColor;
        [Export("preferredBorderSelectionColor", ArgumentSemantic.Strong)]
        UIColor PreferredBorderSelectionColor { get; set; }

        // @property (assign, nonatomic) CGPoint preferredTitleOffset;
        [Export("preferredTitleOffset", ArgumentSemantic.Assign)]
        CGPoint PreferredTitleOffset { get; set; }

        // @property (assign, nonatomic) CGPoint preferredSubtitleOffset;
        [Export("preferredSubtitleOffset", ArgumentSemantic.Assign)]
        CGPoint PreferredSubtitleOffset { get; set; }

        // @property (assign, nonatomic) CGPoint preferredImageOffset;
        [Export("preferredImageOffset", ArgumentSemantic.Assign)]
        CGPoint PreferredImageOffset { get; set; }

        // @property (assign, nonatomic) CGPoint preferredEventOffset;
        [Export("preferredEventOffset", ArgumentSemantic.Assign)]
        CGPoint PreferredEventOffset { get; set; }

        // @property (nonatomic, strong) NSArray<UIColor *> * preferredEventDefaultColors;
        [Export("preferredEventDefaultColors", ArgumentSemantic.Strong)]
        UIColor[] PreferredEventDefaultColors { get; set; }

        // @property (nonatomic, strong) NSArray<UIColor *> * preferredEventSelectionColors;
        [Export("preferredEventSelectionColors", ArgumentSemantic.Strong)]
        UIColor[] PreferredEventSelectionColors { get; set; }

        // @property (assign, nonatomic) CGFloat preferredBorderRadius;
        [Export("preferredBorderRadius")]
        nfloat PreferredBorderRadius { get; set; }

        // -(instancetype)initWithFrame:(CGRect)frame __attribute__((objc_requires_super));
        [Export("initWithFrame:")]
        //[RequiresSuper]
        IntPtr Constructor(CGRect frame);

        // -(instancetype)initWithCoder:(NSCoder *)aDecoder __attribute__((objc_requires_super));
        //[Export("initWithCoder:")]
        //[RequiresSuper]
        //IntPtr Constructor(NSCoder aDecoder);

        // -(void)layoutSubviews __attribute__((objc_requires_super));
        [Export("layoutSubviews")]
        //[RequiresSuper]
        void LayoutSubviews();

        // -(void)configureAppearance __attribute__((objc_requires_super));
        [Export("configureAppearance")]
        //[RequiresSuper]
        void ConfigureAppearance();

        // -(void)invalidateTitleFont;
        [Export("invalidateTitleFont")]
        void InvalidateTitleFont();

        // -(void)invalidateSubtitleFont;
        [Export("invalidateSubtitleFont")]
        void InvalidateSubtitleFont();

        // -(void)invalidateTitleTextColor;
        [Export("invalidateTitleTextColor")]
        void InvalidateTitleTextColor();

        // -(void)invalidateSubtitleTextColor;
        [Export("invalidateSubtitleTextColor")]
        void InvalidateSubtitleTextColor();

        // -(void)invalidateBorderColors;
        [Export("invalidateBorderColors")]
        void InvalidateBorderColors();

        // -(void)invalidateFillColors;
        [Export("invalidateFillColors")]
        void InvalidateFillColors();

        // -(void)invalidateEventColors;
        [Export("invalidateEventColors")]
        void InvalidateEventColors();

        // -(void)invalidateBorderRadius;
        [Export("invalidateBorderRadius")]
        void InvalidateBorderRadius();

        // -(void)invalidateImage;
        [Export("invalidateImage")]
        void InvalidateImage();

        // -(UIColor *)colorForCurrentStateInDictionary:(NSDictionary *)dictionary;
        [Export("colorForCurrentStateInDictionary:")]
        UIColor ColorForCurrentStateInDictionary(NSDictionary dictionary);

        // -(void)performSelecting;
        [Export("performSelecting")]
        void PerformSelecting();
    }

    // @interface FSCalendarEventIndicator : UIView
    [BaseType(typeof(UIView))]
    interface FSCalendarEventIndicator
    {
        // @property (assign, nonatomic) NSInteger numberOfEvents;
        [Export("numberOfEvents")]
        nint NumberOfEvents { get; set; }

        // @property (nonatomic, strong) id color;
        [Export("color", ArgumentSemantic.Strong)]
        NSObject Color { get; set; }
    }

    // @interface FSCalendarWeekdayView : UIView
    [BaseType(typeof(UIView))]
    interface FSCalendarWeekdayView
    {
        // @property (readonly, nonatomic) NSHashTable<UILabel *> * _Nonnull weekdayLabels;
        [Export("weekdayLabels")]
        NSSet<UILabel> WeekdayLabels { get; }

        // @property (readonly, nonatomic) UIView * _Nonnull contentView;
        [Export("contentView")]
        UIView ContentView { get; }

        // @property (nonatomic, weak) FSCalendar * _Nullable calendar;
        [NullAllowed, Export("calendar", ArgumentSemantic.Weak)]
        FSCalendar Calendar { get; set; }

        // -(void)invalidateWeekdaySymbols;
        [Export("invalidateWeekdaySymbols")]
        void InvalidateWeekdaySymbols();
    }

    // @interface FSCalendarHeaderView : UIView
    [BaseType(typeof(UIView))]
    interface FSCalendarHeaderView
    {
        // @property (nonatomic, weak) FSCalendarCollectionView * collectionView;
        [Export("collectionView", ArgumentSemantic.Weak)]
        FSCalendarCollectionView CollectionView { get; set; }

        // @property (nonatomic, weak) FSCalendarHeaderLayout * collectionViewLayout;
        [Export("collectionViewLayout", ArgumentSemantic.Weak)]
        FSCalendarHeaderLayout CollectionViewLayout { get; set; }

        // @property (nonatomic, weak) FSCalendar * calendar;
        [Export("calendar", ArgumentSemantic.Weak)]
        FSCalendar Calendar { get; set; }

        // @property (nonatomic, weak) FSCalendarAppearance * appearance;
        //[Export("appearance", ArgumentSemantic.Weak)]
        //FSCalendarAppearance Appearance { get; set; }

        // @property (assign, nonatomic) CGFloat scrollOffset;
        [Export("scrollOffset")]
        nfloat ScrollOffset { get; set; }

        // @property (assign, nonatomic) UICollectionViewScrollDirection scrollDirection;
        [Export("scrollDirection", ArgumentSemantic.Assign)]
        UICollectionViewScrollDirection ScrollDirection { get; set; }

        // @property (assign, nonatomic) BOOL scrollEnabled;
        [Export("scrollEnabled")]
        bool ScrollEnabled { get; set; }

        // @property (assign, nonatomic) BOOL needsAdjustingViewFrame;
        [Export("needsAdjustingViewFrame")]
        bool NeedsAdjustingViewFrame { get; set; }

        // @property (assign, nonatomic) BOOL needsAdjustingMonthPosition;
        [Export("needsAdjustingMonthPosition")]
        bool NeedsAdjustingMonthPosition { get; set; }

        // -(void)reloadData;
        [Export("reloadData")]
        void ReloadData();
    }

    // @interface FSCalendarHeaderCell : UICollectionViewCell
    [BaseType(typeof(UICollectionViewCell))]
    interface FSCalendarHeaderCell
    {
        // @property (nonatomic, weak) UILabel * titleLabel;
        [Export("titleLabel", ArgumentSemantic.Weak)]
        UILabel TitleLabel { get; set; }

        // @property (nonatomic, weak) FSCalendarHeaderView * header;
        [Export("header", ArgumentSemantic.Weak)]
        FSCalendarHeaderView Header { get; set; }

        // -(void)invalidateHeaderFont;
        [Export("invalidateHeaderFont")]
        void InvalidateHeaderFont();

        // -(void)invalidateHeaderTextColor;
        [Export("invalidateHeaderTextColor")]
        void InvalidateHeaderTextColor();
    }

    // @interface FSCalendarHeaderLayout : UICollectionViewFlowLayout
    [BaseType(typeof(UICollectionViewFlowLayout))]
    interface FSCalendarHeaderLayout
    {
    }

    // @interface FSCalendarHeaderTouchDeliver : UIView
    [BaseType(typeof(UIView))]
    interface FSCalendarHeaderTouchDeliver
    {
        // @property (nonatomic, weak) FSCalendar * calendar;
        [Export("calendar", ArgumentSemantic.Weak)]
        FSCalendar Calendar { get; set; }

        // @property (nonatomic, weak) FSCalendarHeaderView * header;
        [Export("header", ArgumentSemantic.Weak)]
        FSCalendarHeaderView Header { get; set; }
    }



    // @protocol FSCalendarDataSource <NSObject>
    [Protocol, Model]
    [BaseType(typeof(NSObject))]
    interface FSCalendarDataSource
    {
        // @optional -(NSString * _Nullable)calendar:(FSCalendar * _Nonnull)calendar titleForDate:(NSDate * _Nonnull)date;
        [Export("calendar:titleForDate:")]
        [return: NullAllowed]
        string Calendar(FSCalendar calendar, NSDate date);

        // @optional -(NSString * _Nullable)calendar:(FSCalendar * _Nonnull)calendar subtitleForDate:(NSDate * _Nonnull)date;
        [Export("calendar:subtitleForDate:")]
        [return: NullAllowed]
        string SubtitleForDate(FSCalendar calendar, NSDate date);

        // @optional -(UIImage * _Nullable)calendar:(FSCalendar * _Nonnull)calendar imageForDate:(NSDate * _Nonnull)date;
        [Export("calendar:imageForDate:")]
        [return: NullAllowed]
        UIImage ImageForDate(FSCalendar calendar, NSDate date);

        // @optional -(NSDate * _Nonnull)minimumDateForCalendar:(FSCalendar * _Nonnull)calendar;
        [Export("minimumDateForCalendar:")]
        NSDate MinimumDateForCalendar(FSCalendar calendar);

        // @optional -(NSDate * _Nonnull)maximumDateForCalendar:(FSCalendar * _Nonnull)calendar;
        [Export("maximumDateForCalendar:")]
        NSDate MaximumDateForCalendar(FSCalendar calendar);

        // @optional -(__kindof FSCalendarCell * _Nonnull)calendar:(FSCalendar * _Nonnull)calendar cellForDate:(NSDate * _Nonnull)date atMonthPosition:(FSCalendarMonthPosition)position;
        [Export("calendar:cellForDate:atMonthPosition:")]
        FSCalendarCell CellForDate(FSCalendar calendar, NSDate date, FSCalendarMonthPosition position);

        // @optional -(NSInteger)calendar:(FSCalendar * _Nonnull)calendar numberOfEventsForDate:(NSDate * _Nonnull)date;
        [Export("calendar:numberOfEventsForDate:")]
        nint NumberOfEventsForDate(FSCalendar calendar, NSDate date);

        // @optional -(BOOL)calendar:(FSCalendar * _Nonnull)calendar hasEventForDate:(NSDate * _Nonnull)date __attribute__((deprecated(" Use -calendar:numberOfEventsForDate: instead")));
        [Export("calendar:hasEventForDate:")]
        bool HasEventForDate(FSCalendar calendar, NSDate date);
    }

    // @protocol FSCalendarDelegate <NSObject>
    [Protocol, Model]
    [BaseType(typeof(NSObject))]
    interface FSCalendarDelegate
    {
        // @optional -(BOOL)calendar:(FSCalendar * _Nonnull)calendar shouldSelectDate:(NSDate * _Nonnull)date atMonthPosition:(FSCalendarMonthPosition)monthPosition;
        [Export("calendar:shouldSelectDate:atMonthPosition:")]
        bool ShouldSelectDate(FSCalendar calendar, NSDate date, FSCalendarMonthPosition monthPosition);

        // @optional -(BOOL)calendar:(FSCalendar * _Nonnull)calendar shouldSelectDate:(NSDate * _Nonnull)date __attribute__((deprecated(" Use -calendar:shouldSelectDate:atMonthPosition: instead")));
        [Export("calendar:shouldSelectDate:")]
        bool ShouldSelectDate(FSCalendar calendar, NSDate date);

        // @optional -(void)calendar:(FSCalendar * _Nonnull)calendar didSelectDate:(NSDate * _Nonnull)date atMonthPosition:(FSCalendarMonthPosition)monthPosition;
        [Export("calendar:didSelectDate:atMonthPosition:")]
        void DidSelectDate(FSCalendar calendar, NSDate date, FSCalendarMonthPosition monthPosition);

        // @optional -(void)calendar:(FSCalendar * _Nonnull)calendar didSelectDate:(NSDate * _Nonnull)date __attribute__((deprecated(" Use -calendar:didSelectDate:atMonthPosition: instead")));
        [Export("calendar:didSelectDate:")]
        void DidSelectDate(FSCalendar calendar, NSDate date);

        // @optional -(BOOL)calendar:(FSCalendar * _Nonnull)calendar shouldDeselectDate:(NSDate * _Nonnull)date atMonthPosition:(FSCalendarMonthPosition)monthPosition;
        [Export("calendar:shouldDeselectDate:atMonthPosition:")]
        bool ShouldDeselectDate(FSCalendar calendar, NSDate date, FSCalendarMonthPosition monthPosition);

        // @optional -(BOOL)calendar:(FSCalendar * _Nonnull)calendar shouldDeselectDate:(NSDate * _Nonnull)date __attribute__((deprecated(" Use -calendar:shouldDeselectDate:atMonthPosition: instead")));
        [Export("calendar:shouldDeselectDate:")]
        bool ShouldDeselectDate(FSCalendar calendar, NSDate date);

        // @optional -(void)calendar:(FSCalendar * _Nonnull)calendar didDeselectDate:(NSDate * _Nonnull)date atMonthPosition:(FSCalendarMonthPosition)monthPosition;
        [Export("calendar:didDeselectDate:atMonthPosition:")]
        void DidDeselectDate(FSCalendar calendar, NSDate date, FSCalendarMonthPosition monthPosition);

        // @optional -(void)calendar:(FSCalendar * _Nonnull)calendar didDeselectDate:(NSDate * _Nonnull)date __attribute__((deprecated(" Use -calendar:didDeselectDate:atMonthPosition: instead")));
        [Export("calendar:didDeselectDate:")]
        void DidDeselectDate(FSCalendar calendar, NSDate date);

        // @optional -(void)calendar:(FSCalendar * _Nonnull)calendar boundingRectWillChange:(CGRect)bounds animated:(BOOL)animated;
        [Export("calendar:boundingRectWillChange:animated:")]
        void BoundingRectWillChange(FSCalendar calendar, CGRect bounds, bool animated);

        // @optional -(void)calendar:(FSCalendar * _Nonnull)calendar willDisplayCell:(FSCalendarCell * _Nonnull)cell forDate:(NSDate * _Nonnull)date atMonthPosition:(FSCalendarMonthPosition)monthPosition;
        [Export("calendar:willDisplayCell:forDate:atMonthPosition:")]
        void WillDisplayCell(FSCalendar calendar, FSCalendarCell cell, NSDate date, FSCalendarMonthPosition monthPosition);

        // @optional -(void)calendarCurrentPageDidChange:(FSCalendar * _Nonnull)calendar;
        [Export("calendarCurrentPageDidChange:")]
        void CalendarCurrentPageDidChange(FSCalendar calendar);

        // @optional -(void)calendarCurrentScopeWillChange:(FSCalendar * _Nonnull)calendar animated:(BOOL)animated __attribute__((deprecated(" Use -calendar:boundingRectWillChange:animated: instead")));
        [Export("calendarCurrentScopeWillChange:animated:")]
        void CalendarCurrentScopeWillChange(FSCalendar calendar, bool animated);

        // @optional -(void)calendarCurrentMonthDidChange:(FSCalendar * _Nonnull)calendar __attribute__((deprecated(" Use -calendarCurrentPageDidChange: instead")));
        [Export("calendarCurrentMonthDidChange:")]
        void CalendarCurrentMonthDidChange(FSCalendar calendar);
    }

    // @protocol FSCalendarDelegateAppearance <NSObject>
    [Protocol, Model]
    [BaseType(typeof(NSObject))]
    interface FSCalendarDelegateAppearance
    {
        // @optional -(UIColor * _Nullable)calendar:(FSCalendar * _Nonnull)calendar appearance:(FSCalendarAppearance * _Nonnull)appearance fillDefaultColorForDate:(NSDate * _Nonnull)date;
        [Export("calendar:appearance:fillDefaultColorForDate:")]
        [return: NullAllowed]
        UIColor FillDefaultColorForDate(FSCalendar calendar, FSCalendarAppearance appearance, NSDate date);

        // @optional -(UIColor * _Nullable)calendar:(FSCalendar * _Nonnull)calendar appearance:(FSCalendarAppearance * _Nonnull)appearance fillSelectionColorForDate:(NSDate * _Nonnull)date;
        [Export("calendar:appearance:fillSelectionColorForDate:")]
        [return: NullAllowed]
        UIColor FillSelectionColorForDate(FSCalendar calendar, FSCalendarAppearance appearance, NSDate date);

        // @optional -(UIColor * _Nullable)calendar:(FSCalendar * _Nonnull)calendar appearance:(FSCalendarAppearance * _Nonnull)appearance titleDefaultColorForDate:(NSDate * _Nonnull)date;
        [Export("calendar:appearance:titleDefaultColorForDate:")]
        [return: NullAllowed]
        UIColor TitleDefaultColorForDate(FSCalendar calendar, FSCalendarAppearance appearance, NSDate date);

        // @optional -(UIColor * _Nullable)calendar:(FSCalendar * _Nonnull)calendar appearance:(FSCalendarAppearance * _Nonnull)appearance titleSelectionColorForDate:(NSDate * _Nonnull)date;
        [Export("calendar:appearance:titleSelectionColorForDate:")]
        [return: NullAllowed]
        UIColor TitleSelectionColorForDate(FSCalendar calendar, FSCalendarAppearance appearance, NSDate date);

        // @optional -(UIColor * _Nullable)calendar:(FSCalendar * _Nonnull)calendar appearance:(FSCalendarAppearance * _Nonnull)appearance subtitleDefaultColorForDate:(NSDate * _Nonnull)date;
        [Export("calendar:appearance:subtitleDefaultColorForDate:")]
        [return: NullAllowed]
        UIColor SubtitleDefaultColorForDate(FSCalendar calendar, FSCalendarAppearance appearance, NSDate date);

        // @optional -(UIColor * _Nullable)calendar:(FSCalendar * _Nonnull)calendar appearance:(FSCalendarAppearance * _Nonnull)appearance subtitleSelectionColorForDate:(NSDate * _Nonnull)date;
        [Export("calendar:appearance:subtitleSelectionColorForDate:")]
        [return: NullAllowed]
        UIColor SubtitleSelectionColorForDate(FSCalendar calendar, FSCalendarAppearance appearance, NSDate date);

        // @optional -(NSArray<UIColor *> * _Nullable)calendar:(FSCalendar * _Nonnull)calendar appearance:(FSCalendarAppearance * _Nonnull)appearance eventDefaultColorsForDate:(NSDate * _Nonnull)date;
        [Export("calendar:appearance:eventDefaultColorsForDate:")]
        [return: NullAllowed]
        UIColor[] EventDefaultColorsForDate(FSCalendar calendar, FSCalendarAppearance appearance, NSDate date);

        // @optional -(NSArray<UIColor *> * _Nullable)calendar:(FSCalendar * _Nonnull)calendar appearance:(FSCalendarAppearance * _Nonnull)appearance eventSelectionColorsForDate:(NSDate * _Nonnull)date;
        [Export("calendar:appearance:eventSelectionColorsForDate:")]
        [return: NullAllowed]
        UIColor[] EventSelectionColorsForDate(FSCalendar calendar, FSCalendarAppearance appearance, NSDate date);

        // @optional -(UIColor * _Nullable)calendar:(FSCalendar * _Nonnull)calendar appearance:(FSCalendarAppearance * _Nonnull)appearance borderDefaultColorForDate:(NSDate * _Nonnull)date;
        [Export("calendar:appearance:borderDefaultColorForDate:")]
        [return: NullAllowed]
        UIColor BorderDefaultColorForDate(FSCalendar calendar, FSCalendarAppearance appearance, NSDate date);

        // @optional -(UIColor * _Nullable)calendar:(FSCalendar * _Nonnull)calendar appearance:(FSCalendarAppearance * _Nonnull)appearance borderSelectionColorForDate:(NSDate * _Nonnull)date;
        [Export("calendar:appearance:borderSelectionColorForDate:")]
        [return: NullAllowed]
        UIColor BorderSelectionColorForDate(FSCalendar calendar, FSCalendarAppearance appearance, NSDate date);

        // @optional -(CGPoint)calendar:(FSCalendar * _Nonnull)calendar appearance:(FSCalendarAppearance * _Nonnull)appearance titleOffsetForDate:(NSDate * _Nonnull)date;
        [Export("calendar:appearance:titleOffsetForDate:")]
        CGPoint TitleOffsetForDate(FSCalendar calendar, FSCalendarAppearance appearance, NSDate date);

        // @optional -(CGPoint)calendar:(FSCalendar * _Nonnull)calendar appearance:(FSCalendarAppearance * _Nonnull)appearance subtitleOffsetForDate:(NSDate * _Nonnull)date;
        [Export("calendar:appearance:subtitleOffsetForDate:")]
        CGPoint SubtitleOffsetForDate(FSCalendar calendar, FSCalendarAppearance appearance, NSDate date);

        // @optional -(CGPoint)calendar:(FSCalendar * _Nonnull)calendar appearance:(FSCalendarAppearance * _Nonnull)appearance imageOffsetForDate:(NSDate * _Nonnull)date;
        [Export("calendar:appearance:imageOffsetForDate:")]
        CGPoint ImageOffsetForDate(FSCalendar calendar, FSCalendarAppearance appearance, NSDate date);

        // @optional -(CGPoint)calendar:(FSCalendar * _Nonnull)calendar appearance:(FSCalendarAppearance * _Nonnull)appearance eventOffsetForDate:(NSDate * _Nonnull)date;
        [Export("calendar:appearance:eventOffsetForDate:")]
        CGPoint EventOffsetForDate(FSCalendar calendar, FSCalendarAppearance appearance, NSDate date);

        // @optional -(CGFloat)calendar:(FSCalendar * _Nonnull)calendar appearance:(FSCalendarAppearance * _Nonnull)appearance borderRadiusForDate:(NSDate * _Nonnull)date;
        [Export("calendar:appearance:borderRadiusForDate:")]
        nfloat BorderRadiusForDate(FSCalendar calendar, FSCalendarAppearance appearance, NSDate date);

        // @optional -(UIColor * _Nullable)calendar:(FSCalendar * _Nonnull)calendar appearance:(FSCalendarAppearance * _Nonnull)appearance fillColorForDate:(NSDate * _Nonnull)date __attribute__((deprecated(" Use -calendar:appearance:fillDefaultColorForDate: instead")));
        [Export("calendar:appearance:fillColorForDate:")]
        [return: NullAllowed]
        UIColor FillColorForDate(FSCalendar calendar, FSCalendarAppearance appearance, NSDate date);

        // @optional -(UIColor * _Nullable)calendar:(FSCalendar * _Nonnull)calendar appearance:(FSCalendarAppearance * _Nonnull)appearance selectionColorForDate:(NSDate * _Nonnull)date __attribute__((deprecated(" Use -calendar:appearance:fillSelectionColorForDate: instead")));
        [Export("calendar:appearance:selectionColorForDate:")]
        [return: NullAllowed]
        UIColor SelectionColorForDate(FSCalendar calendar, FSCalendarAppearance appearance, NSDate date);

        // @optional -(UIColor * _Nullable)calendar:(FSCalendar * _Nonnull)calendar appearance:(FSCalendarAppearance * _Nonnull)appearance eventColorForDate:(NSDate * _Nonnull)date __attribute__((deprecated(" Use -calendar:appearance:eventDefaultColorsForDate: instead")));
        [Export("calendar:appearance:eventColorForDate:")]
        [return: NullAllowed]
        UIColor EventColorForDate(FSCalendar calendar, FSCalendarAppearance appearance, NSDate date);

        // @optional -(NSArray * _Nullable)calendar:(FSCalendar * _Nonnull)calendar appearance:(FSCalendarAppearance * _Nonnull)appearance eventColorsForDate:(NSDate * _Nonnull)date __attribute__((deprecated(" Use -calendar:appearance:eventDefaultColorsForDate: instead")));
        [Export("calendar:appearance:eventColorsForDate:")]
        [return: NullAllowed]
        NSObject[] EventColorsForDate(FSCalendar calendar, FSCalendarAppearance appearance, NSDate date);

        // @optional -(FSCalendarCellShape)calendar:(FSCalendar * _Nonnull)calendar appearance:(FSCalendarAppearance * _Nonnull)appearance cellShapeForDate:(NSDate * _Nonnull)date __attribute__((deprecated(" Use -calendar:appearance:borderRadiusForDate: instead")));
        [Export("calendar:appearance:cellShapeForDate:")]
        FSCalendarCellShape CellShapeForDate(FSCalendar calendar, FSCalendarAppearance appearance, NSDate date);
    }

    // @interface FSCalendar : UIView
    [BaseType(typeof(UIView))]
    interface FSCalendar
    {
        [Wrap("WeakDelegate")]
        [NullAllowed]
        FSCalendarDelegate Delegate { get; set; }

        // @property (nonatomic, weak) id<FSCalendarDelegate> _Nullable delegate __attribute__((iboutlet));
        [NullAllowed, Export("delegate", ArgumentSemantic.Weak)]
        NSObject WeakDelegate { get; set; }

        // @property (nonatomic, weak) id<FSCalendarDataSource> _Nullable dataSource __attribute__((iboutlet));
        [NullAllowed, Export("dataSource", ArgumentSemantic.Weak)]
        FSCalendarDataSource DataSource { get; set; }

        // @property (nonatomic, strong) NSDate * _Nullable today;
        [NullAllowed, Export("today", ArgumentSemantic.Strong)]
        NSDate Today { get; set; }

        // @property (nonatomic, strong) NSDate * _Nonnull currentPage;
        [Export("currentPage", ArgumentSemantic.Strong)]
        NSDate CurrentPage { get; set; }

        // @property (copy, nonatomic) NSLocale * _Nonnull locale;
        [Export("locale", ArgumentSemantic.Copy)]
        NSLocale Locale { get; set; }

        // @property (assign, nonatomic) FSCalendarScrollDirection scrollDirection;
        [Export("scrollDirection", ArgumentSemantic.Assign)]
        FSCalendarScrollDirection ScrollDirection { get; set; }

        // @property (assign, nonatomic) FSCalendarScope scope;
        [Export("scope", ArgumentSemantic.Assign)]
        FSCalendarScope Scope { get; set; }

        // @property (readonly, nonatomic) UIPanGestureRecognizer * _Nonnull scopeGesture;
        [Export("scopeGesture")]
        UIPanGestureRecognizer ScopeGesture { get; }

        // @property (readonly, nonatomic) UILongPressGestureRecognizer * _Nonnull swipeToChooseGesture;
        [Export("swipeToChooseGesture")]
        UILongPressGestureRecognizer SwipeToChooseGesture { get; }

        // @property (assign, nonatomic) FSCalendarPlaceholderType placeholderType;
        [Export("placeholderType", ArgumentSemantic.Assign)]
        FSCalendarPlaceholderType PlaceholderType { get; set; }

        // @property (assign, nonatomic) NSUInteger firstWeekday;
        [Export("firstWeekday")]
        nuint FirstWeekday { get; set; }

        // @property (assign, nonatomic) CGFloat headerHeight;
        [Export("headerHeight")]
        nfloat HeaderHeight { get; set; }

        // @property (assign, nonatomic) CGFloat weekdayHeight;
        [Export("weekdayHeight")]
        nfloat WeekdayHeight { get; set; }

        // @property (nonatomic, strong) FSCalendarWeekdayView * _Nonnull calendarWeekdayView;
        [Export("calendarWeekdayView", ArgumentSemantic.Strong)]
        FSCalendarWeekdayView CalendarWeekdayView { get; set; }

        // @property (nonatomic, strong) FSCalendarHeaderView * _Nonnull calendarHeaderView;
        [Export("calendarHeaderView", ArgumentSemantic.Strong)]
        FSCalendarHeaderView CalendarHeaderView { get; set; }

        // @property (assign, nonatomic) BOOL allowsSelection;
        [Export("allowsSelection")]
        bool AllowsSelection { get; set; }

        // @property (assign, nonatomic) BOOL allowsMultipleSelection;
        [Export("allowsMultipleSelection")]
        bool AllowsMultipleSelection { get; set; }

        // @property (assign, nonatomic) BOOL pagingEnabled;
        [Export("pagingEnabled")]
        bool PagingEnabled { get; set; }

        // @property (assign, nonatomic) BOOL scrollEnabled;
        [Export("scrollEnabled")]
        bool ScrollEnabled { get; set; }

        // @property (assign, nonatomic) BOOL showsScopeHandle;
        [Export("showsScopeHandle")]
        bool ShowsScopeHandle { get; set; }

        // @property (assign, nonatomic) CGFloat lineHeightMultiplier;
        [Export("lineHeightMultiplier")]
        nfloat LineHeightMultiplier { get; set; }

        // @property (readonly, nonatomic) FSCalendarAppearance * _Nonnull appearance;
        //[Export("appearance")]
        //FSCalendarAppearance Appearance { get; }

        // @property (readonly, nonatomic) NSDate * _Nonnull minimumDate;
        [Export("minimumDate")]
        NSDate MinimumDate { get; }

        // @property (readonly, nonatomic) NSDate * _Nonnull maximumDate;
        [Export("maximumDate")]
        NSDate MaximumDate { get; }

        // @property (readonly, nonatomic) NSDate * _Nonnull selectedDate;
        [Export("selectedDate")]
        NSDate SelectedDate { get; }

        // @property (readonly, nonatomic) NSArray<NSDate *> * _Nonnull selectedDates;
        [Export("selectedDates")]
        NSDate[] SelectedDates { get; }

        // -(void)reloadData;
        [Export("reloadData")]
        void ReloadData();

        // -(void)setScope:(FSCalendarScope)scope animated:(BOOL)animated;
        [Export("setScope:animated:")]
        void SetScope(FSCalendarScope scope, bool animated);

        // -(void)selectDate:(NSDate * _Nullable)date;
        [Export("selectDate:")]
        void SelectDate([NullAllowed] NSDate date);

        // -(void)selectDate:(NSDate * _Nullable)date scrollToDate:(BOOL)scrollToDate;
        [Export("selectDate:scrollToDate:")]
        void SelectDate([NullAllowed] NSDate date, bool scrollToDate);

        // -(void)deselectDate:(NSDate * _Nonnull)date;
        [Export("deselectDate:")]
        void DeselectDate(NSDate date);

        // -(void)setCurrentPage:(NSDate * _Nonnull)currentPage animated:(BOOL)animated;
        [Export("setCurrentPage:animated:")]
        void SetCurrentPage(NSDate currentPage, bool animated);

        // -(void)registerClass:(Class _Nonnull)cellClass forCellReuseIdentifier:(NSString * _Nonnull)identifier;
        [Export("registerClass:forCellReuseIdentifier:")]
        void RegisterClass(Class cellClass, string identifier);

        // -(__kindof FSCalendarCell * _Nonnull)dequeueReusableCellWithIdentifier:(NSString * _Nonnull)identifier forDate:(NSDate * _Nonnull)date atMonthPosition:(FSCalendarMonthPosition)position;
        [Export("dequeueReusableCellWithIdentifier:forDate:atMonthPosition:")]
        FSCalendarCell DequeueReusableCellWithIdentifier(string identifier, NSDate date, FSCalendarMonthPosition position);

        // -(__kindof FSCalendarCell * _Nonnull)cellForDate:(NSDate * _Nonnull)date atMonthPosition:(FSCalendarMonthPosition)position;
        [Export("cellForDate:atMonthPosition:")]
        FSCalendarCell CellForDate(NSDate date, FSCalendarMonthPosition position);

        // -(NSDate * _Nonnull)dateForCell:(FSCalendarCell * _Nonnull)cell;
        [Export("dateForCell:")]
        NSDate DateForCell(FSCalendarCell cell);

        // -(FSCalendarMonthPosition)monthPositionForCell:(FSCalendarCell * _Nonnull)cell;
        [Export("monthPositionForCell:")]
        FSCalendarMonthPosition MonthPositionForCell(FSCalendarCell cell);

        // -(NSArray<__kindof FSCalendarCell *> * _Nonnull)visibleCells;
        [Export("visibleCells")]
        FSCalendarCell[] VisibleCells { get; }

        // -(CGRect)frameForDate:(NSDate * _Nonnull)date;
        [Export("frameForDate:")]
        CGRect FrameForDate(NSDate date);
    }

    // @interface IBExtension (FSCalendar)
    [BaseType(typeof(FSCalendar))]
    interface FSCalendar_IBExtension
    {
    }

    // @interface FSCalendarCollectionView : UICollectionView
    [BaseType(typeof(UICollectionView))]
    interface FSCalendarCollectionView
    {
    }

    // @interface FSCalendarSeparator : UICollectionReusableView
    [BaseType(typeof(UICollectionReusableView))]
    interface FSCalendarSeparator
    {
    }

    // @interface FSCalendarCollectionViewLayout : UICollectionViewFlowLayout
    [BaseType(typeof(UICollectionViewFlowLayout))]
    interface FSCalendarCollectionViewLayout
    {
        // @property (nonatomic, weak) FSCalendar * calendar;
        [Export("calendar", ArgumentSemantic.Weak)]
        FSCalendar Calendar { get; set; }
    }

    // @interface FSCalendarScopeHandle : UIView <UIGestureRecognizerDelegate>
    [BaseType(typeof(UIView))]
    interface FSCalendarScopeHandle : IUIGestureRecognizerDelegate
    {
        // @property (nonatomic, weak) UIPanGestureRecognizer * panGesture;
        [Export("panGesture", ArgumentSemantic.Weak)]
        UIPanGestureRecognizer PanGesture { get; set; }

        // @property (nonatomic, weak) FSCalendar * calendar;
        [Export("calendar", ArgumentSemantic.Weak)]
        FSCalendar Calendar { get; set; }

        // -(void)handlePan:(id)sender;
        [Export("handlePan:")]
        void HandlePan(NSObject sender);
    }

    // @interface FSCalendarAnimator : NSObject <UIGestureRecognizerDelegate>
    [BaseType(typeof(NSObject))]
    interface FSCalendarAnimator : IUIGestureRecognizerDelegate
    {
        // @property (nonatomic, weak) FSCalendar * calendar;
        [Export("calendar", ArgumentSemantic.Weak)]
        FSCalendar Calendar { get; set; }

        // @property (nonatomic, weak) FSCalendarCollectionView * collectionView;
        [Export("collectionView", ArgumentSemantic.Weak)]
        FSCalendarCollectionView CollectionView { get; set; }

        // @property (nonatomic, weak) FSCalendarCollectionViewLayout * collectionViewLayout;
        [Export("collectionViewLayout", ArgumentSemantic.Weak)]
        FSCalendarCollectionViewLayout CollectionViewLayout { get; set; }

        // @property (assign, nonatomic) FSCalendarTransition transition;
        [Export("transition", ArgumentSemantic.Assign)]
        FSCalendarTransition Transition { get; set; }

        // @property (assign, nonatomic) FSCalendarTransitionState state;
        [Export("state", ArgumentSemantic.Assign)]
        FSCalendarTransitionState State { get; set; }

        // @property (assign, nonatomic) CGSize cachedMonthSize;
        [Export("cachedMonthSize", ArgumentSemantic.Assign)]
        CGSize CachedMonthSize { get; set; }

        // -(instancetype)initWithCalendar:(FSCalendar *)calendar;
        [Export("initWithCalendar:")]
        IntPtr Constructor(FSCalendar calendar);

        // -(void)performScopeTransitionFromScope:(FSCalendarScope)fromScope toScope:(FSCalendarScope)toScope animated:(BOOL)animated;
        [Export("performScopeTransitionFromScope:toScope:animated:")]
        void PerformScopeTransitionFromScope(FSCalendarScope fromScope, FSCalendarScope toScope, bool animated);

        // -(void)performBoundingRectTransitionFromMonth:(NSDate *)fromMonth toMonth:(NSDate *)toMonth duration:(CGFloat)duration;
        [Export("performBoundingRectTransitionFromMonth:toMonth:duration:")]
        void PerformBoundingRectTransitionFromMonth(NSDate fromMonth, NSDate toMonth, nfloat duration);

        // -(void)handlePan:(id)sender;
        [Export("handlePan:")]
        void HandlePan(NSObject sender);
    }

    // @interface FSCalendarTransitionAttributes : NSObject
    [BaseType(typeof(NSObject))]
    interface FSCalendarTransitionAttributes
    {
        // @property (assign, nonatomic) CGRect sourceBounds;
        [Export("sourceBounds", ArgumentSemantic.Assign)]
        CGRect SourceBounds { get; set; }

        // @property (assign, nonatomic) CGRect targetBounds;
        [Export("targetBounds", ArgumentSemantic.Assign)]
        CGRect TargetBounds { get; set; }

        // @property (nonatomic, strong) NSDate * sourcePage;
        [Export("sourcePage", ArgumentSemantic.Strong)]
        NSDate SourcePage { get; set; }

        // @property (nonatomic, strong) NSDate * targetPage;
        [Export("targetPage", ArgumentSemantic.Strong)]
        NSDate TargetPage { get; set; }

        // @property (assign, nonatomic) NSInteger focusedRowNumber;
        [Export("focusedRowNumber")]
        nint FocusedRowNumber { get; set; }

        // @property (assign, nonatomic) NSDate * focusedDate;
        [Export("focusedDate", ArgumentSemantic.Assign)]
        NSDate FocusedDate { get; set; }

        // @property (nonatomic, strong) NSDate * firstDayOfMonth;
        [Export("firstDayOfMonth", ArgumentSemantic.Strong)]
        NSDate FirstDayOfMonth { get; set; }
    }

    // @interface FSCalendarCalculator : NSObject
    [BaseType(typeof(NSObject))]
    interface FSCalendarCalculator
    {
        // @property (nonatomic, weak) FSCalendar * calendar;
        [Export("calendar", ArgumentSemantic.Weak)]
        FSCalendar Calendar { get; set; }

        // @property (assign, nonatomic) CGFloat monthHeight;
        [Export("monthHeight")]
        nfloat MonthHeight { get; set; }

        // @property (assign, nonatomic) CGFloat titleHeight;
        [Export("titleHeight")]
        nfloat TitleHeight { get; set; }

        // @property (assign, nonatomic) CGFloat subtitleHeight;
        [Export("subtitleHeight")]
        nfloat SubtitleHeight { get; set; }

        // @property (readonly, nonatomic) NSInteger numberOfSections;
        [Export("numberOfSections")]
        nint NumberOfSections { get; }

        // -(instancetype)initWithCalendar:(FSCalendar *)calendar;
        [Export("initWithCalendar:")]
        IntPtr Constructor(FSCalendar calendar);

        // -(NSDate *)safeDateForDate:(NSDate *)date;
        [Export("safeDateForDate:")]
        NSDate SafeDateForDate(NSDate date);

        // -(NSDate *)dateForIndexPath:(NSIndexPath *)indexPath;
        [Export("dateForIndexPath:")]
        NSDate DateForIndexPath(NSIndexPath indexPath);

        // -(NSDate *)dateForIndexPath:(NSIndexPath *)indexPath scope:(FSCalendarScope)scope;
        [Export("dateForIndexPath:scope:")]
        NSDate DateForIndexPath(NSIndexPath indexPath, FSCalendarScope scope);

        // -(NSIndexPath *)indexPathForDate:(NSDate *)date;
        [Export("indexPathForDate:")]
        NSIndexPath IndexPathForDate(NSDate date);

        // -(NSIndexPath *)indexPathForDate:(NSDate *)date scope:(FSCalendarScope)scope;
        [Export("indexPathForDate:scope:")]
        NSIndexPath IndexPathForDate(NSDate date, FSCalendarScope scope);

        // -(NSIndexPath *)indexPathForDate:(NSDate *)date atMonthPosition:(FSCalendarMonthPosition)position;
        [Export("indexPathForDate:atMonthPosition:")]
        NSIndexPath IndexPathForDate(NSDate date, FSCalendarMonthPosition position);

        // -(NSIndexPath *)indexPathForDate:(NSDate *)date atMonthPosition:(FSCalendarMonthPosition)position scope:(FSCalendarScope)scope;
        [Export("indexPathForDate:atMonthPosition:scope:")]
        NSIndexPath IndexPathForDate(NSDate date, FSCalendarMonthPosition position, FSCalendarScope scope);

        // -(NSDate *)pageForSection:(NSInteger)section;
        [Export("pageForSection:")]
        NSDate PageForSection(nint section);

        // -(NSDate *)weekForSection:(NSInteger)section;
        [Export("weekForSection:")]
        NSDate WeekForSection(nint section);

        // -(NSDate *)monthForSection:(NSInteger)section;
        [Export("monthForSection:")]
        NSDate MonthForSection(nint section);

        // -(NSDate *)monthHeadForSection:(NSInteger)section;
        [Export("monthHeadForSection:")]
        NSDate MonthHeadForSection(nint section);

        // -(NSInteger)numberOfHeadPlaceholdersForMonth:(NSDate *)month;
        [Export("numberOfHeadPlaceholdersForMonth:")]
        nint NumberOfHeadPlaceholdersForMonth(NSDate month);

        // -(NSInteger)numberOfRowsInMonth:(NSDate *)month;
        [Export("numberOfRowsInMonth:")]
        nint NumberOfRowsInMonth(NSDate month);

        // -(NSInteger)numberOfRowsInSection:(NSInteger)section;
        [Export("numberOfRowsInSection:")]
        nint NumberOfRowsInSection(nint section);

        // -(FSCalendarMonthPosition)monthPositionForIndexPath:(NSIndexPath *)indexPath;
        [Export("monthPositionForIndexPath:")]
        FSCalendarMonthPosition MonthPositionForIndexPath(NSIndexPath indexPath);

        // -(void)reloadSections;
        [Export("reloadSections")]
        void ReloadSections();
    }

    // @interface FSCalendarDelegateProxy : NSObject
    [BaseType(typeof(NSObject))]
    interface FSCalendarDelegateProxy
    {
        // @property (nonatomic, weak) FSCalendar * calendar;
        [Export("calendar", ArgumentSemantic.Weak)]
        FSCalendar Calendar { get; set; }

        // -(instancetype)initWithCalendar:(FSCalendar *)calendar;
        [Export("initWithCalendar:")]
        IntPtr Constructor(FSCalendar calendar);

        // -(NSString *)titleForDate:(NSDate *)date;
        [Export("titleForDate:")]
        string TitleForDate(NSDate date);

        // -(NSString *)subtitleForDate:(NSDate *)date;
        [Export("subtitleForDate:")]
        string SubtitleForDate(NSDate date);

        // -(UIImage *)imageForDate:(NSDate *)date;
        [Export("imageForDate:")]
        UIImage ImageForDate(NSDate date);

        // -(NSInteger)numberOfEventsForDate:(NSDate *)date;
        [Export("numberOfEventsForDate:")]
        nint NumberOfEventsForDate(NSDate date);

        // -(NSDate *)minimumDateForCalendar;
        [Export("minimumDateForCalendar")]
        NSDate MinimumDateForCalendar { get; }

        // -(NSDate *)maximumDateForCalendar;
        [Export("maximumDateForCalendar")]
        NSDate MaximumDateForCalendar { get; }

        // -(FSCalendarCell *)cellForDate:(NSDate *)date atMonthPosition:(FSCalendarMonthPosition)position;
        [Export("cellForDate:atMonthPosition:")]
        FSCalendarCell CellForDate(NSDate date, FSCalendarMonthPosition position);

        // -(BOOL)shouldSelectDate:(NSDate *)date atMonthPosition:(FSCalendarMonthPosition)position;
        [Export("shouldSelectDate:atMonthPosition:")]
        bool ShouldSelectDate(NSDate date, FSCalendarMonthPosition position);

        // -(void)didSelectDate:(NSDate *)date atMonthPosition:(FSCalendarMonthPosition)position;
        [Export("didSelectDate:atMonthPosition:")]
        void DidSelectDate(NSDate date, FSCalendarMonthPosition position);

        // -(BOOL)shouldDeselectDate:(NSDate *)date atMonthPosition:(FSCalendarMonthPosition)position;
        [Export("shouldDeselectDate:atMonthPosition:")]
        bool ShouldDeselectDate(NSDate date, FSCalendarMonthPosition position);

        // -(void)didDeselectDate:(NSDate *)date atMonthPosition:(FSCalendarMonthPosition)position;
        [Export("didDeselectDate:atMonthPosition:")]
        void DidDeselectDate(NSDate date, FSCalendarMonthPosition position);

        // -(void)currentPageDidChange;
        [Export("currentPageDidChange")]
        void CurrentPageDidChange();

        // -(BOOL)boundingRectWillChange:(BOOL)animated;
        [Export("boundingRectWillChange:")]
        bool BoundingRectWillChange(bool animated);

        // -(void)willDisplayCell:(FSCalendarCell *)cell forDate:(NSDate *)date atMonthPosition:(FSCalendarMonthPosition)position;
        [Export("willDisplayCell:forDate:atMonthPosition:")]
        void WillDisplayCell(FSCalendarCell cell, NSDate date, FSCalendarMonthPosition position);

        // -(UIColor *)preferredFillDefaultColorForDate:(NSDate *)date;
        [Export("preferredFillDefaultColorForDate:")]
        UIColor PreferredFillDefaultColorForDate(NSDate date);

        // -(UIColor *)preferredFillSelectionColorForDate:(NSDate *)date;
        [Export("preferredFillSelectionColorForDate:")]
        UIColor PreferredFillSelectionColorForDate(NSDate date);

        // -(UIColor *)preferredTitleDefaultColorForDate:(NSDate *)date;
        [Export("preferredTitleDefaultColorForDate:")]
        UIColor PreferredTitleDefaultColorForDate(NSDate date);

        // -(UIColor *)preferredTitleSelectionColorForDate:(NSDate *)date;
        [Export("preferredTitleSelectionColorForDate:")]
        UIColor PreferredTitleSelectionColorForDate(NSDate date);

        // -(UIColor *)preferredSubtitleDefaultColorForDate:(NSDate *)date;
        [Export("preferredSubtitleDefaultColorForDate:")]
        UIColor PreferredSubtitleDefaultColorForDate(NSDate date);

        // -(UIColor *)preferredSubtitleSelectionColorForDate:(NSDate *)date;
        [Export("preferredSubtitleSelectionColorForDate:")]
        UIColor PreferredSubtitleSelectionColorForDate(NSDate date);

        // -(UIColor *)preferredBorderDefaultColorForDate:(NSDate *)date;
        [Export("preferredBorderDefaultColorForDate:")]
        UIColor PreferredBorderDefaultColorForDate(NSDate date);

        // -(UIColor *)preferredBorderSelectionColorForDate:(NSDate *)date;
        [Export("preferredBorderSelectionColorForDate:")]
        UIColor PreferredBorderSelectionColorForDate(NSDate date);

        // -(CGPoint)preferredTitleOffsetForDate:(NSDate *)date;
        [Export("preferredTitleOffsetForDate:")]
        CGPoint PreferredTitleOffsetForDate(NSDate date);

        // -(CGPoint)preferredSubtitleOffsetForDate:(NSDate *)date;
        [Export("preferredSubtitleOffsetForDate:")]
        CGPoint PreferredSubtitleOffsetForDate(NSDate date);

        // -(CGPoint)preferredImageOffsetForDate:(NSDate *)date;
        [Export("preferredImageOffsetForDate:")]
        CGPoint PreferredImageOffsetForDate(NSDate date);

        // -(CGPoint)preferredEventOffsetForDate:(NSDate *)date;
        [Export("preferredEventOffsetForDate:")]
        CGPoint PreferredEventOffsetForDate(NSDate date);

        // -(NSArray<UIColor *> *)preferredEventDefaultColorsForDate:(NSDate *)date;
        [Export("preferredEventDefaultColorsForDate:")]
        UIColor[] PreferredEventDefaultColorsForDate(NSDate date);

        // -(NSArray<UIColor *> *)preferredEventSelectionColorsForDate:(NSDate *)date;
        [Export("preferredEventSelectionColorsForDate:")]
        UIColor[] PreferredEventSelectionColorsForDate(NSDate date);

        // -(CGFloat)preferredBorderRadiusForDate:(NSDate *)date;
        [Export("preferredBorderRadiusForDate:")]
        nfloat PreferredBorderRadiusForDate(NSDate date);
    }

    // @interface FSCalendarStickyHeader : UICollectionReusableView
    [BaseType(typeof(UICollectionReusableView))]
    interface FSCalendarStickyHeader
    {
        // @property (nonatomic, weak) FSCalendar * calendar;
        [Export("calendar", ArgumentSemantic.Weak)]
        FSCalendar Calendar { get; set; }

        // @property (nonatomic, weak) FSCalendarAppearance * appearance;
        [Export("appearance", ArgumentSemantic.Weak)]
        FSCalendarAppearance CalendarAppearance { get; set; }

        // @property (nonatomic, weak) UILabel * titleLabel;
        [Export("titleLabel", ArgumentSemantic.Weak)]
        UILabel TitleLabel { get; set; }

        // @property (nonatomic, strong) NSDate * month;
        [Export("month", ArgumentSemantic.Strong)]
        NSDate Month { get; set; }

        // -(void)invalidateHeaderFont;
        [Export("invalidateHeaderFont")]
        void InvalidateHeaderFont();

        // -(void)invalidateHeaderTextColor;
        [Export("invalidateHeaderTextColor")]
        void InvalidateHeaderTextColor();

        // -(void)invalidateWeekdayFont;
        [Export("invalidateWeekdayFont")]
        void InvalidateWeekdayFont();

        // -(void)invalidateWeekdayTextColor;
        [Export("invalidateWeekdayTextColor")]
        void InvalidateWeekdayTextColor();

        // -(void)invalidateWeekdaySymbols;
        [Export("invalidateWeekdaySymbols")]
        void InvalidateWeekdaySymbols();

        // -(void)reloadData;
        [Export("reloadData")]
        void ReloadData();
    }

    // @interface Dynamic (FSCalendar)
    [BaseType(typeof(FSCalendar))]
    interface FSCalendar_Dynamic
    {
        // @property (readonly, nonatomic) FSCalendarCollectionView * collectionView;
        [Export("collectionView")]
        FSCalendarCollectionView CollectionView { get; }

        // @property (readonly, nonatomic) FSCalendarScopeHandle * scopeHandle;
        [Export("scopeHandle")]
        FSCalendarScopeHandle ScopeHandle { get; }

        // @property (readonly, nonatomic) FSCalendarCollectionViewLayout * collectionViewLayout;
        [Export("collectionViewLayout")]
        FSCalendarCollectionViewLayout CollectionViewLayout { get; }

        // @property (readonly, nonatomic) FSCalendarAnimator * animator;
        [Export("animator")]
        FSCalendarAnimator Animator { get; }

        // @property (readonly, nonatomic) FSCalendarCalculator * calculator;
        [Export("calculator")]
        FSCalendarCalculator Calculator { get; }

        // @property (readonly, nonatomic) FSCalendarDelegateProxy * proxy;
        [Export("proxy")]
        FSCalendarDelegateProxy Proxy { get; }

        // @property (readonly, nonatomic) BOOL floatingMode;
        [Export("floatingMode")]
        bool FloatingMode { get; }

        // @property (readonly, nonatomic) NSArray * visibleStickyHeaders;
        [Export("visibleStickyHeaders")]
        NSObject[] VisibleStickyHeaders { get; }

        // @property (readonly, nonatomic) CGFloat preferredHeaderHeight;
        [Export("preferredHeaderHeight")]
        nfloat PreferredHeaderHeight { get; }

        // @property (readonly, nonatomic) CGFloat preferredWeekdayHeight;
        [Export("preferredWeekdayHeight")]
        nfloat PreferredWeekdayHeight { get; }

        // @property (readonly, nonatomic) CGFloat preferredRowHeight;
        [Export("preferredRowHeight")]
        nfloat PreferredRowHeight { get; }

        // @property (readonly, nonatomic) CGFloat preferredPadding;
        [Export("preferredPadding")]
        nfloat PreferredPadding { get; }

        // @property (readonly, nonatomic) UIView * bottomBorder;
        [Export("bottomBorder")]
        UIView BottomBorder { get; }

        // @property (readonly, nonatomic) NSCalendar * gregorian;
        [Export("gregorian")]
        NSCalendar Gregorian { get; }

        // @property (readonly, nonatomic) NSDateComponents * components;
        [Export("components")]
        NSDateComponents Components { get; }

        // @property (readonly, nonatomic) NSDateFormatter * formatter;
        [Export("formatter")]
        NSDateFormatter Formatter { get; }

        // @property (readonly, nonatomic) UIView * contentView;
        [Export("contentView")]
        UIView ContentView { get; }

        // @property (readonly, nonatomic) UIView * daysContainer;
        [Export("daysContainer")]
        UIView DaysContainer { get; }

        // @property (assign, nonatomic) BOOL needsAdjustingMonthPosition;
        [Export("needsAdjustingMonthPosition")]
        bool NeedsAdjustingMonthPosition { get; set; }

        // @property (assign, nonatomic) BOOL needsAdjustingViewFrame;
        [Export("needsAdjustingViewFrame")]
        bool NeedsAdjustingViewFrame { get; set; }

        // -(void)invalidateWeekdayFont;
        [Export("invalidateWeekdayFont")]
        void InvalidateWeekdayFont();

        // -(void)invalidateWeekdayTextColor;
        [Export("invalidateWeekdayTextColor")]
        void InvalidateWeekdayTextColor();

        // -(void)invalidateHeaders;
        [Export("invalidateHeaders")]
        void InvalidateHeaders();

        // -(void)invalidateWeekdaySymbols;
        [Export("invalidateWeekdaySymbols")]
        void InvalidateWeekdaySymbols();

        // -(BOOL)isPageInRange:(NSDate *)page;
        [Export("isPageInRange:")]
        bool IsPageInRange(NSDate page);

        // -(BOOL)isDateInRange:(NSDate *)date;
        [Export("isDateInRange:")]
        bool IsDateInRange(NSDate date);

        // -(CGSize)sizeThatFits:(CGSize)size scope:(FSCalendarScope)scope;
        [Export("sizeThatFits:scope:")]
        CGSize SizeThatFits(CGSize size, FSCalendarScope scope);
    }

    // @interface Dynamic (FSCalendarAppearance)
    [BaseType(typeof(FSCalendarAppearance))]
    interface FSCalendarAppearance_Dynamic
    {
        // @property (readwrite, nonatomic) FSCalendar * calendar;
        [Export("calendar", ArgumentSemantic.Assign)]
        FSCalendar Calendar { get; set; }

        // @property (readonly, nonatomic) NSDictionary * backgroundColors;
        [Export("backgroundColors")]
        NSDictionary BackgroundColors { get; }

        // @property (readonly, nonatomic) NSDictionary * titleColors;
        [Export("titleColors")]
        NSDictionary TitleColors { get; }

        // @property (readonly, nonatomic) NSDictionary * subtitleColors;
        [Export("subtitleColors")]
        NSDictionary SubtitleColors { get; }

        // @property (readonly, nonatomic) NSDictionary * borderColors;
        [Export("borderColors")]
        NSDictionary BorderColors { get; }

        // @property (readonly, nonatomic) UIFont * preferredTitleFont;
        [Export("preferredTitleFont")]
        UIFont PreferredTitleFont { get; }

        // @property (readonly, nonatomic) UIFont * preferredSubtitleFont;
        [Export("preferredSubtitleFont")]
        UIFont PreferredSubtitleFont { get; }

        // @property (readonly, nonatomic) UIFont * preferredWeekdayFont;
        [Export("preferredWeekdayFont")]
        UIFont PreferredWeekdayFont { get; }

        // @property (readonly, nonatomic) UIFont * preferredHeaderTitleFont;
        [Export("preferredHeaderTitleFont")]
        UIFont PreferredHeaderTitleFont { get; }

        // -(void)adjustTitleIfNecessary;
        [Export("adjustTitleIfNecessary")]
        void AdjustTitleIfNecessary();

        // -(void)invalidateFonts;
        [Export("invalidateFonts")]
        void InvalidateFonts();
    }

    // @interface FSCalendarExtensions (UIView)
    [BaseType(typeof(UIView))]
    interface UIView_FSCalendarExtensions
    {
        // @property (nonatomic) CGFloat fs_width;
        [Export("fs_width")]
        nfloat Fs_width { get; set; }

        // @property (nonatomic) CGFloat fs_height;
        [Export("fs_height")]
        nfloat Fs_height { get; set; }

        // @property (nonatomic) CGFloat fs_top;
        [Export("fs_top")]
        nfloat Fs_top { get; set; }

        // @property (nonatomic) CGFloat fs_left;
        [Export("fs_left")]
        nfloat Fs_left { get; set; }

        // @property (nonatomic) CGFloat fs_bottom;
        [Export("fs_bottom")]
        nfloat Fs_bottom { get; set; }

        // @property (nonatomic) CGFloat fs_right;
        [Export("fs_right")]
        nfloat Fs_right { get; set; }
    }

    // @interface FSCalendarExtensions (CALayer)
    [BaseType(typeof(CALayer))]
    interface CALayer_FSCalendarExtensions
    {
        // @property (nonatomic) CGFloat fs_width;
        [Export("fs_width")]
        nfloat Fs_width { get; set; }

        // @property (nonatomic) CGFloat fs_height;
        [Export("fs_height")]
        nfloat Fs_height { get; set; }

        // @property (nonatomic) CGFloat fs_top;
        [Export("fs_top")]
        nfloat Fs_top { get; set; }

        // @property (nonatomic) CGFloat fs_left;
        [Export("fs_left")]
        nfloat Fs_left { get; set; }

        // @property (nonatomic) CGFloat fs_bottom;
        [Export("fs_bottom")]
        nfloat Fs_bottom { get; set; }

        // @property (nonatomic) CGFloat fs_right;
        [Export("fs_right")]
        nfloat Fs_right { get; set; }
    }

    // @interface FSCalendarExtensions (NSCalendar)
    [BaseType(typeof(NSCalendar))]
    interface NSCalendar_FSCalendarExtensions
    {
        // -(NSDate * _Nullable)fs_firstDayOfMonth:(NSDate * _Nonnull)month;
        [Export("fs_firstDayOfMonth:")]
        [return: NullAllowed]
        NSDate Fs_firstDayOfMonth(NSDate month);

        // -(NSDate * _Nullable)fs_lastDayOfMonth:(NSDate * _Nonnull)month;
        [Export("fs_lastDayOfMonth:")]
        [return: NullAllowed]
        NSDate Fs_lastDayOfMonth(NSDate month);

        // -(NSDate * _Nullable)fs_firstDayOfWeek:(NSDate * _Nonnull)week;
        [Export("fs_firstDayOfWeek:")]
        [return: NullAllowed]
        NSDate Fs_firstDayOfWeek(NSDate week);

        // -(NSDate * _Nullable)fs_lastDayOfWeek:(NSDate * _Nonnull)week;
        [Export("fs_lastDayOfWeek:")]
        [return: NullAllowed]
        NSDate Fs_lastDayOfWeek(NSDate week);

        // -(NSDate * _Nullable)fs_middleDayOfWeek:(NSDate * _Nonnull)week;
        [Export("fs_middleDayOfWeek:")]
        [return: NullAllowed]
        NSDate Fs_middleDayOfWeek(NSDate week);

        // -(NSInteger)fs_numberOfDaysInMonth:(NSDate * _Nonnull)month;
        [Export("fs_numberOfDaysInMonth:")]
        nint Fs_numberOfDaysInMonth(NSDate month);
    }

    // @interface FSCalendarExtensions (NSCache)
    [BaseType(typeof(NSCache))]
    interface NSCache_FSCalendarExtensions
    {
        // -(void)setObject:(id _Nullable)obj forKeyedSubscript:(id<NSCopying> _Nonnull)key;
        [Export("setObject:forKeyedSubscript:")]
        void SetObject([NullAllowed] NSObject obj, NSCopying key);

        // -(id _Nonnull)objectForKeyedSubscript:(id<NSCopying> _Nonnull)key;
        [Export("objectForKeyedSubscript:")]
        NSObject ObjectForKeyedSubscript(NSCopying key);
    }

    // @interface FSCalendarExtensions (NSObject)
    [BaseType(typeof(NSObject))]
    interface NSObject_FSCalendarExtensions
    {
        // -(void)fs_setVariable:(id _Nonnull)variable forKey:(NSString * _Nonnull)key;
        [Export("fs_setVariable:forKey:")]
        void Fs_setVariable(NSObject variable, string key);

        // -(id _Nonnull)fs_variableForKey:(NSString * _Nonnull)key;
        [Export("fs_variableForKey:")]
        NSObject Fs_variableForKey(string key);

        // -(void)fs_setUnsignedIntegerVariable:(NSUInteger)value forKey:(NSString * _Nonnull)key;
        [Export("fs_setUnsignedIntegerVariable:forKey:")]
        void Fs_setUnsignedIntegerVariable(nuint value, string key);

        // -(NSUInteger)fs_unsignedIntegerVariableForKey:(NSString * _Nonnull)key;
        [Export("fs_unsignedIntegerVariableForKey:")]
        nuint Fs_unsignedIntegerVariableForKey(string key);

        // -(id _Nonnull)fs_performSelector:(SEL _Nonnull)selector withObjects:(id _Nullable)firstObject, ... __attribute__((sentinel(0, 1)));
        [Internal]
        [Export("fs_performSelector:withObjects:", IsVariadic = true)]
        NSObject Fs_performSelector(Selector selector, [NullAllowed] NSObject firstObject, IntPtr varArgs);
    }

    //[Static]
    //[Verify(ConstantsInterfaceAssociation)]
    //partial interface Constants
    //{
    //    // extern double FSCalendarVersionNumber;
    //    [Field("FSCalendarVersionNumber", "__Internal")]
    //    double FSCalendarVersionNumber { get; }

    //    // extern const unsigned char [] FSCalendarVersionString;
    //    [Field("FSCalendarVersionString", "__Internal")]
    //    byte[] FSCalendarVersionString { get; }
    //}
}