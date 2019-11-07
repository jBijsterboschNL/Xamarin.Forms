using Xamarin.Forms.CustomAttributes;
using Xamarin.Forms.Internals;
 
#if UITEST
using Xamarin.UITest;
using NUnit.Framework;
#endif
 
namespace Xamarin.Forms.Controls.Issues
{
	[Preserve(AllMembers = true)]
	[Issue(IssueTracker.Github, 7037, "Xamarin.Forms.Visual.Material Android Placeholder Font Size issue", PlatformAffected.Android)]
	public class Bugzilla1 : TestContentPage // or TestMasterDetailPage, etc ...
	{
		protected override void Init()
		{
			// Initialize ui here instead of ctor
			var descriptionLabel = new Label
			{
				AutomationId = "IssuePageLabel",
				Text = "On Android the Hint text size is not being set properly from the Entry.FontSize property."
			};

			double fontSize64 = 64; // to make sure you will see the difference :)
			Entry defaultEntryPlaceholder = new Entry { Placeholder = "Placeholder size 64", FontSize = fontSize64 };
			Entry defaultEntryText = new Entry { Text = "Text size 64", Placeholder = "Placeholder size 64", FontSize = fontSize64 };
			Entry materialEntryPlaceholder = new Entry { Placeholder = "Placeholder size 64", Visual = VisualMarker.Material, FontSize = fontSize64 };
			Entry materialEntryText = new Entry { Text = "Text size 64", Placeholder = "Placeholder size 64", Visual = VisualMarker.Material, FontSize = fontSize64 };

			Content = new StackLayout { Children = { descriptionLabel, defaultEntryPlaceholder, defaultEntryText, materialEntryPlaceholder, materialEntryText } };
		}

//#if UITEST
//		[Test]
//		public void Issue1Test()
//		{
//			RunningApp.Screenshot("I am at Issue 7037");
//			RunningApp.WaitForElement(q => q.Marked("IssuePageLabel"));
//			RunningApp.Screenshot("I see the Label");
//		}
//#endif
	}
}