# TestMergedWith
Xamarin.Forms app to demonstrate the ResourceDictionary MergedWith property.  In the app, ResourceDictionaries are defined at
three levels:

	1) In a separate PCL (ResourceLibrary.CustomResources)
	2) In App.xaml (which references the separate PCL CustomResources via MergedWith)
	3) In TestMergedWith4Page (which also references the separate PCL CustomResources  via MergedWith)

In the app, there is a StackLayout defined in MainPage.xaml.  It references a Style (TitleBarStyle) and  a color (Color_1)
that are defined at all three levels (PCL, App.xaml and page-level).  By commenting or uncommenting those at the 
various levels, all the above scenarios can be tried.

There is a bug filed on Bugzilla on this as it does not seem to be working 100%.  Please see 
https://bugzilla.xamarin.com/show_bug.cgi?id=42264.

When using DynamicResource to access an explicit resource (i.e., one marked with x:key "-name-") it works as expected.  But when 
attempting the same access using StaticResource, it works in some cases and not others.  

	• If there is no page-level dictionary and the key is only defined in the PCL, it does not seem to work.
	• If there is a page-level dictionary and the key is only defined in the PCL, it does seem to work.
	• If the key is defined in either App.xaml or the page-level dictionary it seems to work.

Implicit resources (i.e., ones that are not marked with x:key "-name-", and that get applied automatically by control type) seem to 
work regardless of where they are defined.


