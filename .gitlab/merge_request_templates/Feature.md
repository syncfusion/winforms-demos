### Feature description ###

Clearly and concisely describe the problem or feature (this cannot be empty).

### Analysis and design ###

If there is an external design, link to its project documentation area.
If there is an internal discussion on the forum, provide the link.

### Solution description ###

Describe your code changes in detail for reviewers.

### Output screenshots ###

Post the output screenshots if an UI is affected or added due to this feature.

### Areas affected and ensured ###

List the areas are affected by your code changes.

### API Changes ###

List all API changes here (or just put None), example:

Added:
 - string ListView.GroupName { get; set; } //Bindable Property
 - int ListView.GroupId { get; set; } // Bindable Property
 - void ListView.Clear ();

Changed:
 - object ListView.SelectedItem => Cell ListView.SelectedItem

### Behavioral Changes ###

Describe any non-bug related behavioral changes that may change how users app behaves when upgrading to this version of the codebase.

### Test cases ###

Provide the unit testing written file details to understand the use cases considered in this implementation.
If there is no TDD (if it’s not possible to follow), provide the UI automation script location and the Excel file that contains the use cases considered in this implementation.
Provide the test cases Excel file alone if the feature cannot be automated in any case.

List out all the scenarios you have tested after include these changes. You can refer the predefined scenarios from below link.

https://syncfusion.atlassian.net/wiki/display/CHARTXAMARIN/Chart+Test+Plan

### Testbed sample location ###

Provide the test bed sample location where code reviewers can review the new feature’s behaviors. This depends on the CI process that your team follows. It can be from NPMCI, HockeyApp, staging site, local server, etc.

### Does it have any known issues?

If this feature contains any known issues, provide the proper details about the issues.

### Does it have memory leak?

Ensure the feature contains memory leak or not (if applicable).

### MR CheckList ###

- [ ] Does it follow the design [guidelines](https://docs.microsoft.com/en-us/dotnet/standard/design-guidelines/)? It is mandatory that, we should not move the changes without reading this.
- [ ] Did UI automation passed without errors? If it is customer issue, make sure it is included in the IR automation.
- [ ] Properly working in Xamarin.Forms [previewer](https://docs.microsoft.com/en-us/xamarin/xamarin-forms/xaml/xaml-previewer?tabs=vswin).
- [ ] Ensured in iOS, Android, UWP and macOS (if supported).
- [ ] Have you added API comments if it is new API?
- [ ] Does it need localization? If so, update resx file in [GitHub](https://github.com/syncfusion/xamarin-localized-texts).
- [ ] Whether we have added new APIs? If so, whether it is as per the [guidelines](https://docs.microsoft.com/en-us/dotnet/standard/design-guidelines/)?
- [ ] If changes are made in the Xamarin.Forms sample browser project file, whether it is included in the props file too? If not, your sample level changes will not reflect in the application published in the hockey app.
- [ ] Have you ensured the changes in Android API 19 and iOS 9?
