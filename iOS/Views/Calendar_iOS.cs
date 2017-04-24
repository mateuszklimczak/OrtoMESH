using System;
using Softweb.Xamarin.Controls.iOS;
using UIKit;

namespace OrtoMESH.iOS
{
	public partial class Calendar_iOS : UIViewController
	{
		Calendar calendar; 

		public Calendar_iOS() : base("Calendar_iOS", null)
		{
		}

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();
			// Perform any additional setup after loading the view, typically from a nib.
//Create required objects
var calendar = new Calendar();
var menuView = new CalendarMenuView
{ Frame = new CGRect(0f, 0f, 320f, 40f) };
var contentView = new CalendarContentView
{ Frame = new CGRect(0f, 45f, 320f, 280f) };

//Customize calendar's appearance
var appearance = calendar.CalendarAppearance;
appearance.GetNSCalendar().FirstWeekDay = (nuint)3;
        appearance.DayCircleColorSelected = UIColor.rgba(52, 152, 219,1.0);
        appearance.DayCircleRatio = (9f / 10f);
        appearance.WeekDayFormat = CalendarWeekDayFormat.Single;
    
        //Link the views to the calendar
        calendar.MenuMonthsView = menuView;
        calendar.ContentView = contentView;
        
	    calendar.DateSelected += DateSelected;
	    calendar.NextPageLoaded += DidLoadNextPage;
	    calendar.PreviousPageLoaded += DidLoadPreviousPage;
	
        // Pass a function that returns text to display in month label
        //E.g. "JAN 2014" OR “01/2014"
        appearance.SetMonthLabelTextCallback (
            //Full month-name and year. E.g. DECEMBER 2014
            (NSDate date, Calendar cal) => new NSString(
                ((DateTime)date).ToString("MMMM yyyy")));
    
        //Add the views to the current view
        View.Add(menuView);
        View.Add(contentView);
    }

    public override void ViewWillAppear(bool animated)
{
	base.ViewWillAppear(animated);

	//Reload calendar
			calendar.ReloadData();
		}
	public void DateSelected(object sender, DateSelectedEventArgs args)
{
			Console.WriteLine(String.Format("Selected date is {0}", ((DateTime)args.Date).ToLocalTime().ToString("dd-MMM-yyyy")));
}

public void DidLoadPreviousPage(object sender, EventArgs args)
{
	Console.WriteLine("Loaded previous page");
}

public void DidLoadNextPage(object sender, EventArgs args)
{
			Console.WriteLine("Loaded next page"   );

		}


			
		
	}
}

