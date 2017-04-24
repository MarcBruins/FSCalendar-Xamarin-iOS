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
        // extern const CGFloat FSCalendarStandardHeaderHeight;
        [Field("FSCalendarStandardHeaderHeight", "__Internal")]
        nfloat FSCalendarStandardHeaderHeight { get; }

        // extern const CGFloat FSCalendarStandardWeekdayHeight;
        [Field("FSCalendarStandardWeekdayHeight", "__Internal")]
        nfloat FSCalendarStandardWeekdayHeight { get; }

        // extern const CGFloat FSCalendarStandardMonthlyPageHeight;
        [Field("FSCalendarStandardMonthlyPageHeight", "__Internal")]
        nfloat FSCalendarStandardMonthlyPageHeight { get; }

        // extern const CGFloat FSCalendarStandardWeeklyPageHeight;
        [Field("FSCalendarStandardWeeklyPageHeight", "__Internal")]
        nfloat FSCalendarStandardWeeklyPageHeight { get; }

        // extern const CGFloat FSCalendarStandardCellDiameter;
        [Field("FSCalendarStandardCellDiameter", "__Internal")]
        nfloat FSCalendarStandardCellDiameter { get; }

        // extern const CGFloat FSCalendarStandardSeparatorThickness;
        [Field("FSCalendarStandardSeparatorThickness", "__Internal")]
        nfloat FSCalendarStandardSeparatorThickness { get; }

        // extern const CGFloat FSCalendarAutomaticDimension;
        [Field("FSCalendarAutomaticDimension", "__Internal")]
        nfloat FSCalendarAutomaticDimension { get; }

        // extern const CGFloat FSCalendarDefaultBounceAnimationDuration;
        [Field("FSCalendarDefaultBounceAnimationDuration", "__Internal")]
        nfloat FSCalendarDefaultBounceAnimationDuration { get; }

        // extern const CGFloat FSCalendarStandardRowHeight;
        [Field("FSCalendarStandardRowHeight", "__Internal")]
        nfloat FSCalendarStandardRowHeight { get; }

        // extern const CGFloat FSCalendarStandardTitleTextSize;
        [Field("FSCalendarStandardTitleTextSize", "__Internal")]
        nfloat FSCalendarStandardTitleTextSize { get; }

        // extern const CGFloat FSCalendarStandardSubtitleTextSize;
        [Field("FSCalendarStandardSubtitleTextSize", "__Internal")]
        nfloat FSCalendarStandardSubtitleTextSize { get; }

        // extern const CGFloat FSCalendarStandardWeekdayTextSize;
        [Field("FSCalendarStandardWeekdayTextSize", "__Internal")]
        nfloat FSCalendarStandardWeekdayTextSize { get; }

        // extern const CGFloat FSCalendarStandardHeaderTextSize;
        [Field("FSCalendarStandardHeaderTextSize", "__Internal")]
        nfloat FSCalendarStandardHeaderTextSize { get; }

        // extern const CGFloat FSCalendarMaximumEventDotDiameter;
        [Field("FSCalendarMaximumEventDotDiameter", "__Internal")]
        nfloat FSCalendarMaximumEventDotDiameter { get; }

        // extern const CGFloat FSCalendarStandardScopeHandleHeight;
        [Field("FSCalendarStandardScopeHandleHeight", "__Internal")]
        nfloat FSCalendarStandardScopeHandleHeight { get; }

        // extern const NSInteger FSCalendarDefaultHourComponent __attribute__((visibility("default")));
        [Field("FSCalendarDefaultHourComponent", "__Internal")]
        nint FSCalendarDefaultHourComponent { get; }

        // extern NSString *const FSCalendarDefaultCellReuseIdentifier __attribute__((visibility("default")));
        [Field("FSCalendarDefaultCellReuseIdentifier", "__Internal")]
        NSString FSCalendarDefaultCellReuseIdentifier { get; }

        // extern NSString *const FSCalendarBlankCellReuseIdentifier __attribute__((visibility("default")));
        [Field("FSCalendarBlankCellReuseIdentifier", "__Internal")]
        NSString FSCalendarBlankCellReuseIdentifier { get; }

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
        
		// extern const CGPoint CGPointInfinity;
        //[Field("CGPointInfinity", "__Internal")]
        //CGPoint CGPointInfinity { get; }

        //// extern const unsigned char [] FSCalendarVersionString;
        //[Field("FSCalendarVersionString", "__Internal")]
        //byte[] FSCalendarVersionString { get; }

        // extern const CGSize CGSizeAutomatic;
        [Field("CGSizeAutomatic", "__Internal")]
        CGSize CGSizeAutomatic { get; }
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

        // @property (getter = isPlaceholder, assign, nonatomic) BOOL placeholder;
        [Export("placeholder")]
        bool Placeholder { [Bind("isPlaceholder")] get; set; }

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

    // @interface FSCalendarBlankCell : UICollectionViewCell
    [BaseType(typeof(UICollectionViewCell))]
    interface FSCalendarBlankCell
    {
        // -(void)configureAppearance;
        [Export("configureAppearance")]
        void ConfigureAppearance();
    }

    // @interface FSCalendarWeekdayView : UIView
    [BaseType(typeof(UIView))]
    interface FSCalendarWeekdayView
    {
        // @property (readonly, nonatomic) NSArray<UILabel *> * _Nonnull weekdayLabels;
        [Export("weekdayLabels")]
        UILabel[] WeekdayLabels { get; }

        // -(void)configureAppearance;
        [Export("configureAppearance")]
        void ConfigureAppearance();
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

        // -(void)setScrollOffset:(CGFloat)scrollOffset animated:(BOOL)animated;
        [Export("setScrollOffset:animated:")]
        void SetScrollOffset(nfloat scrollOffset, bool animated);

        // -(void)reloadData;
        [Export("reloadData")]
        void ReloadData();

        // -(void)configureAppearance;
        [Export("configureAppearance")]
        void ConfigureAppearance();
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
        [Export("calendar:shouldSelectDate:atMonthPosition:")
         , DelegateName("FSCalendarDateAtMonthPositionDelegate")
         , DefaultValue(true)]
        bool ShouldSelectDateAtMonthPosition(FSCalendar calendar, NSDate date, FSCalendarMonthPosition monthPosition);

        // @optional -(BOOL)calendar:(FSCalendar * _Nonnull)calendar shouldSelectDate:(NSDate * _Nonnull)date __attribute__((deprecated(" Use -calendar:shouldSelectDate:atMonthPosition: instead")));
        [Export("calendar:shouldSelectDate:")
         , DelegateName("FSCalendarDateDelegate")
         , DefaultValue(true)]
        bool ShouldSelectDate(FSCalendar calendar, NSDate date);

        // @optional -(void)calendar:(FSCalendar * _Nonnull)calendar didSelectDate:(NSDate * _Nonnull)date atMonthPosition:(FSCalendarMonthPosition)monthPosition;
        [Export("calendar:didSelectDate:atMonthPosition:")
         , EventArgs("FSCalendarDateWithPosition")]
        void DidSelectDateAtMonthPosition(FSCalendar calendar, NSDate date, FSCalendarMonthPosition monthPosition);

        // @optional -(void)calendar:(FSCalendar * _Nonnull)calendar didSelectDate:(NSDate * _Nonnull)date __attribute__((deprecated(" Use -calendar:didSelectDate:atMonthPosition: instead")));
        [Export("calendar:didSelectDate:")
         , EventArgs("FSCalendarDate")]
        void DidSelectDate(FSCalendar calendar, NSDate date);

        // @optional -(BOOL)calendar:(FSCalendar * _Nonnull)calendar shouldDeselectDate:(NSDate * _Nonnull)date atMonthPosition:(FSCalendarMonthPosition)monthPosition;
        [Export("calendar:shouldDeselectDate:atMonthPosition:")
         , DelegateName("FSCalendarDateAtMonthPositionDelegate")
         , DefaultValue(true)]
        bool ShouldDeselectDateAtMonthPosition(FSCalendar calendar, NSDate date, FSCalendarMonthPosition monthPosition);

        // @optional -(BOOL)calendar:(FSCalendar * _Nonnull)calendar shouldDeselectDate:(NSDate * _Nonnull)date __attribute__((deprecated(" Use -calendar:shouldDeselectDate:atMonthPosition: instead")));
        [Export("calendar:shouldDeselectDate:")
         , DelegateName("FSCalendarDateDelegate")
         , DefaultValue(true)]
        bool ShouldDeselectDate(FSCalendar calendar, NSDate date);

        // @optional -(void)calendar:(FSCalendar * _Nonnull)calendar didDeselectDate:(NSDate * _Nonnull)date atMonthPosition:(FSCalendarMonthPosition)monthPosition;
        [Export("calendar:didDeselectDate:atMonthPosition:")
         , EventArgs("FSCalendarDateWithPosition")]
        void DidDeselectDateAtMonthPosition(FSCalendar calendar, NSDate date, FSCalendarMonthPosition monthPosition);

        // @optional -(void)calendar:(FSCalendar * _Nonnull)calendar didDeselectDate:(NSDate * _Nonnull)date __attribute__((deprecated(" Use -calendar:didDeselectDate:atMonthPosition: instead")));
        [Export("calendar:didDeselectDate:")
         , EventArgs("FSCalendarDate")]
        void DidDeselectDate(FSCalendar calendar, NSDate date);

        // @optional -(void)calendar:(FSCalendar * _Nonnull)calendar boundingRectWillChange:(CGRect)bounds animated:(BOOL)animated;
        [Export("calendar:boundingRectWillChange:animated:")
         , EventArgs("BoundingRect")]
        void BoundingRectWillChange(FSCalendar calendar, CGRect bounds, bool animated);

        // @optional -(void)calendar:(FSCalendar * _Nonnull)calendar willDisplayCell:(FSCalendarCell * _Nonnull)cell forDate:(NSDate * _Nonnull)date atMonthPosition:(FSCalendarMonthPosition)monthPosition;
        [Export("calendar:willDisplayCell:forDate:atMonthPosition:")
         , EventArgs("FSCalendarCell")]
        void WillDisplayCell(FSCalendar calendar, FSCalendarCell cell, NSDate date, FSCalendarMonthPosition monthPosition);

        // @optional -(void)calendarCurrentPageDidChange:(FSCalendar * _Nonnull)calendar;
        [Export("calendarCurrentPageDidChange:")
         , EventArgs("FSCalendarChange")]
        void CalendarCurrentPageDidChange(FSCalendar calendar);

        // @optional -(void)calendarCurrentScopeWillChange:(FSCalendar * _Nonnull)calendar animated:(BOOL)animated __attribute__((deprecated(" Use -calendar:boundingRectWillChange:animated: instead")));
        [Export("calendarCurrentScopeWillChange:animated:")
         , EventArgs("FSCalendarChangeAnimated")]
        void CalendarCurrentScopeWillChange(FSCalendar calendar, bool animated);

        // @optional -(void)calendarCurrentMonthDidChange:(FSCalendar * _Nonnull)calendar __attribute__((deprecated(" Use -calendarCurrentPageDidChange: instead")));
        [Export("calendarCurrentMonthDidChange:")
         , EventArgs("FSCalendarChange")]
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
    [BaseType(typeof(UIView)
              , Delegates = new string[] { "WeakDelegate" }
              , Events = new Type[] { typeof(FSCalendarDelegate) })]
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

        // @property (readonly, nonatomic) UIPanGestureRecognizer * _Nonnull scopeGesture __attribute__((deprecated(" Use handleScopeGesture: instead")));
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

        // @property (assign, nonatomic) BOOL showsScopeHandle __attribute__((deprecated(" Use handleScopeGesture: instead")));
        [Export("showsScopeHandle")]
        bool ShowsScopeHandle { get; set; }

        // @property (assign, nonatomic) CGFloat lineHeightMultiplier;
        [Export("lineHeightMultiplier")]
        nfloat LineHeightMultiplier { get; set; }

        // @property (readonly, nonatomic) FSCalendarAppearance * _Nonnull appearance;
        [Export("appearance")]
        FSCalendarAppearance CalendarAppearance { get; }

        // @property (readonly, nonatomic) NSDate * _Nonnull minimumDate;
        [Export("minimumDate")]
        NSDate MinimumDate { get; }

        // @property (readonly, nonatomic) NSDate * _Nonnull maximumDate;
        [Export("maximumDate")]
        NSDate MaximumDate { get; }

        // @property (readonly, nonatomic) NSDate * _Nullable selectedDate;
        [NullAllowed, Export("selectedDate")]
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

        // -(void)setNeedsConfigureAppearance;
        [Export("setNeedsConfigureAppearance")]
        void SetNeedsConfigureAppearance();

        // -(void)handleScopeGesture:(UIPanGestureRecognizer * _Nonnull)sender;
        [Export("handleScopeGesture:")]
        void HandleScopeGesture(UIPanGestureRecognizer sender);
    }

    // @interface FSCalendarCollectionView : UICollectionView
    [BaseType(typeof(UICollectionView))]
    interface FSCalendarCollectionView
    {
    }
}