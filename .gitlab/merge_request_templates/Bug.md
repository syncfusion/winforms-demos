### Bug Description ###

Clearly and concisely describe the problem or feature (this cannot be empty).

### Root Cause ###

Briefly describe the root cause and analysis of the problem.
If there is an internal discussion on the forum, provide the link.

### Reason for not identifying earlier ###

Find how it was missed in our earlier testing and development by analysing the below checklist. This will help prevent similar mistakes in the future. 

**Guidelines/documents are not followed**

Common guidelines / Core team guideline
Specification document
Requirement document

**Guidelines/documents are not given**

Common guidelines / Core team guideline
Specification document
Requirement document

**Reason:**
Mention any one or more reasons from the above points.

**Action taken:**
What action did you take to avoid this in future?

**Related areas:**
Is there any other related areas also to be addressed?
               
### Is Breaking issue? ###

If it is a breaking issue, provide the commit detail which caused this break.

### Solution description ###

Describe your code changes in detail for reviewers.

### Output screenshots ###

Post the output screenshots if an UI is affected or added due to this bug.

**Before changes:**
Add the image which was taken before making these changes. Place a cursor here and click "Attach a file" button and upload the image.

**After changes:**
Add the image which was taken after making these changes. Place a cursor here and click "Attach a file" button and upload the image.

### Areas affected and ensured ###

List out the areas are affected by your code changes. 
Is there any existing behavior change of other features due to this code change?

### Does it have any known issues?

If this fix contains any known issues, provide the proper details about the issues.

### Does it have memory leak?

Ensure the fix contains memory leak or not (if applicable).

### MR CheckList ###

- [ ] Does it follow the design [guidelines](https://docs.microsoft.com/en-us/dotnet/standard/design-guidelines/)? It is mandatory that, we should not move the changes without reading this.
- [ ] Did UI automation passed without errors? If it is customer issue, make sure it is included in the IR automation.
- [ ] Properly working in Xamarin.Forms [previewer](https://docs.microsoft.com/en-us/xamarin/xamarin-forms/xaml/xaml-previewer?tabs=vswin).
- [ ] Ensured in iOS, Android, UWP and macOS (if supported).
- [ ] Have you ensured the changes in Android API 19 and iOS 9?
- [ ] Did you record this case in the unit test or UI test?
