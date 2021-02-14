<a name='assembly'></a>
# xyLOGIX.Core.Extensions

## Contents

- [ControlExtensions](#T-xyLOGIX-Core-Extensions-ControlExtensions 'xyLOGIX.Core.Extensions.ControlExtensions')
  - [InvokeIfRequired(obj,action)](#M-xyLOGIX-Core-Extensions-ControlExtensions-InvokeIfRequired-System-ComponentModel-ISynchronizeInvoke,System-Windows-Forms-MethodInvoker- 'xyLOGIX.Core.Extensions.ControlExtensions.InvokeIfRequired(System.ComponentModel.ISynchronizeInvoke,System.Windows.Forms.MethodInvoker)')
- [DictionaryExtensions](#T-xyLOGIX-Core-Extensions-DictionaryExtensions 'xyLOGIX.Core.Extensions.DictionaryExtensions')
  - [ToObject\`\`1(source)](#M-xyLOGIX-Core-Extensions-DictionaryExtensions-ToObject``1-System-Collections-Generic-Dictionary{System-String,System-String}- 'xyLOGIX.Core.Extensions.DictionaryExtensions.ToObject``1(System.Collections.Generic.Dictionary{System.String,System.String})')
- [EnumerableExtensions](#T-xyLOGIX-Core-Extensions-EnumerableExtensions 'xyLOGIX.Core.Extensions.EnumerableExtensions')
  - [IsAnyOf\`\`1(source,testObjects)](#M-xyLOGIX-Core-Extensions-EnumerableExtensions-IsAnyOf``1-``0,``0[]- 'xyLOGIX.Core.Extensions.EnumerableExtensions.IsAnyOf``1(``0,``0[])')
  - [ShuffleIterator\`\`1(source,rng)](#M-xyLOGIX-Core-Extensions-EnumerableExtensions-ShuffleIterator``1-System-Collections-Generic-IEnumerable{``0},System-Random- 'xyLOGIX.Core.Extensions.EnumerableExtensions.ShuffleIterator``1(System.Collections.Generic.IEnumerable{``0},System.Random)')
  - [Shuffle\`\`1(source)](#M-xyLOGIX-Core-Extensions-EnumerableExtensions-Shuffle``1-System-Collections-Generic-IEnumerable{``0}- 'xyLOGIX.Core.Extensions.EnumerableExtensions.Shuffle``1(System.Collections.Generic.IEnumerable{``0})')
  - [Shuffle\`\`1(source,rng)](#M-xyLOGIX-Core-Extensions-EnumerableExtensions-Shuffle``1-System-Collections-Generic-IEnumerable{``0},System-Random- 'xyLOGIX.Core.Extensions.EnumerableExtensions.Shuffle``1(System.Collections.Generic.IEnumerable{``0},System.Random)')
- [FormExtensions](#T-xyLOGIX-Core-Extensions-FormExtensions 'xyLOGIX.Core.Extensions.FormExtensions')
  - [CenterForm(child,parent)](#M-xyLOGIX-Core-Extensions-FormExtensions-CenterForm-System-Windows-Forms-Form,System-Windows-Forms-Form- 'xyLOGIX.Core.Extensions.FormExtensions.CenterForm(System.Windows.Forms.Form,System.Windows.Forms.Form)')
  - [CenterForm(form,screen)](#M-xyLOGIX-Core-Extensions-FormExtensions-CenterForm-System-Windows-Forms-Form,System-Windows-Forms-Screen- 'xyLOGIX.Core.Extensions.FormExtensions.CenterForm(System.Windows.Forms.Form,System.Windows.Forms.Screen)')
  - [DoIfDisposed(form,action)](#M-xyLOGIX-Core-Extensions-FormExtensions-DoIfDisposed-xyLOGIX-Core-Extensions-IForm,System-Action- 'xyLOGIX.Core.Extensions.FormExtensions.DoIfDisposed(xyLOGIX.Core.Extensions.IForm,System.Action)')
  - [DoIfNotDisposed(form,action)](#M-xyLOGIX-Core-Extensions-FormExtensions-DoIfNotDisposed-xyLOGIX-Core-Extensions-IForm,System-Action- 'xyLOGIX.Core.Extensions.FormExtensions.DoIfNotDisposed(xyLOGIX.Core.Extensions.IForm,System.Action)')
  - [ShowDialogAsync(form,owner)](#M-xyLOGIX-Core-Extensions-FormExtensions-ShowDialogAsync-System-Windows-Forms-Form,System-Windows-Forms-IWin32Window- 'xyLOGIX.Core.Extensions.FormExtensions.ShowDialogAsync(System.Windows.Forms.Form,System.Windows.Forms.IWin32Window)')
  - [ShowDialogAsync(form)](#M-xyLOGIX-Core-Extensions-FormExtensions-ShowDialogAsync-System-Windows-Forms-Form- 'xyLOGIX.Core.Extensions.FormExtensions.ShowDialogAsync(System.Windows.Forms.Form)')
  - [ShowOnPrimaryMonitor(form)](#M-xyLOGIX-Core-Extensions-FormExtensions-ShowOnPrimaryMonitor-System-Windows-Forms-Form- 'xyLOGIX.Core.Extensions.FormExtensions.ShowOnPrimaryMonitor(System.Windows.Forms.Form)')
- [IForm](#T-xyLOGIX-Core-Extensions-IForm 'xyLOGIX.Core.Extensions.IForm')
  - [ProgressBar](#P-xyLOGIX-Core-Extensions-IForm-ProgressBar 'xyLOGIX.Core.Extensions.IForm.ProgressBar')
- [IntExtensions](#T-xyLOGIX-Core-Extensions-IntExtensions 'xyLOGIX.Core.Extensions.IntExtensions')
  - [EqualsOneOf(value,list)](#M-xyLOGIX-Core-Extensions-IntExtensions-EqualsOneOf-System-Int32,System-Int32[]- 'xyLOGIX.Core.Extensions.IntExtensions.EqualsOneOf(System.Int32,System.Int32[])')
- [ListHelpers](#T-xyLOGIX-Core-Extensions-ListHelpers 'xyLOGIX.Core.Extensions.ListHelpers')
  - [AddDistinct(collection,item)](#M-xyLOGIX-Core-Extensions-ListHelpers-AddDistinct-System-Windows-Forms-ComboBox-ObjectCollection,System-Object- 'xyLOGIX.Core.Extensions.ListHelpers.AddDistinct(System.Windows.Forms.ComboBox.ObjectCollection,System.Object)')
  - [AddDistinct\`\`1(list,item)](#M-xyLOGIX-Core-Extensions-ListHelpers-AddDistinct``1-System-Collections-Generic-IList{``0},``0- 'xyLOGIX.Core.Extensions.ListHelpers.AddDistinct``1(System.Collections.Generic.IList{``0},``0)')
  - [AddDistinct\`\`1(collection,item)](#M-xyLOGIX-Core-Extensions-ListHelpers-AddDistinct``1-System-Collections-Generic-ICollection{``0},``0- 'xyLOGIX.Core.Extensions.ListHelpers.AddDistinct``1(System.Collections.Generic.ICollection{``0},``0)')
  - [Clone\`\`1(source)](#M-xyLOGIX-Core-Extensions-ListHelpers-Clone``1-System-Collections-Generic-ICollection{``0}- 'xyLOGIX.Core.Extensions.ListHelpers.Clone``1(System.Collections.Generic.ICollection{``0})')
  - [IsOneOf(value,valueSet)](#M-xyLOGIX-Core-Extensions-ListHelpers-IsOneOf-System-Int32,System-Collections-Generic-IEnumerable{System-Int32}- 'xyLOGIX.Core.Extensions.ListHelpers.IsOneOf(System.Int32,System.Collections.Generic.IEnumerable{System.Int32})')
  - [ToSetString(list)](#M-xyLOGIX-Core-Extensions-ListHelpers-ToSetString-System-Collections-IList- 'xyLOGIX.Core.Extensions.ListHelpers.ToSetString(System.Collections.IList)')
- [Resources](#T-xyLOGIX-Core-Extensions-Properties-Resources 'xyLOGIX.Core.Extensions.Properties.Resources')
  - [Culture](#P-xyLOGIX-Core-Extensions-Properties-Resources-Culture 'xyLOGIX.Core.Extensions.Properties.Resources.Culture')
  - [NCharsMustBePositive](#P-xyLOGIX-Core-Extensions-Properties-Resources-NCharsMustBePositive 'xyLOGIX.Core.Extensions.Properties.Resources.NCharsMustBePositive')
  - [PersonNameEmpty](#P-xyLOGIX-Core-Extensions-Properties-Resources-PersonNameEmpty 'xyLOGIX.Core.Extensions.Properties.Resources.PersonNameEmpty')
  - [PersonNameIncorrectFormat](#P-xyLOGIX-Core-Extensions-Properties-Resources-PersonNameIncorrectFormat 'xyLOGIX.Core.Extensions.Properties.Resources.PersonNameIncorrectFormat')
  - [ResourceManager](#P-xyLOGIX-Core-Extensions-Properties-Resources-ResourceManager 'xyLOGIX.Core.Extensions.Properties.Resources.ResourceManager')
- [StringExtensions](#T-xyLOGIX-Core-Extensions-StringExtensions 'xyLOGIX.Core.Extensions.StringExtensions')
  - [AcronymList](#F-xyLOGIX-Core-Extensions-StringExtensions-AcronymList 'xyLOGIX.Core.Extensions.StringExtensions.AcronymList')
  - [AlwaysCapitalizeIfFirstWord](#F-xyLOGIX-Core-Extensions-StringExtensions-AlwaysCapitalizeIfFirstWord 'xyLOGIX.Core.Extensions.StringExtensions.AlwaysCapitalizeIfFirstWord')
  - [CapitalizeableAsFirstWords](#F-xyLOGIX-Core-Extensions-StringExtensions-CapitalizeableAsFirstWords 'xyLOGIX.Core.Extensions.StringExtensions.CapitalizeableAsFirstWords')
  - [NamesOfStreetsThatShouldBeCapitalized](#F-xyLOGIX-Core-Extensions-StringExtensions-NamesOfStreetsThatShouldBeCapitalized 'xyLOGIX.Core.Extensions.StringExtensions.NamesOfStreetsThatShouldBeCapitalized')
  - [ShortWordsThatAreNotAcronyms](#F-xyLOGIX-Core-Extensions-StringExtensions-ShortWordsThatAreNotAcronyms 'xyLOGIX.Core.Extensions.StringExtensions.ShortWordsThatAreNotAcronyms')
  - [StateAbbrList](#F-xyLOGIX-Core-Extensions-StringExtensions-StateAbbrList 'xyLOGIX.Core.Extensions.StringExtensions.StateAbbrList')
  - [IsEmailAddressInvalid](#P-xyLOGIX-Core-Extensions-StringExtensions-IsEmailAddressInvalid 'xyLOGIX.Core.Extensions.StringExtensions.IsEmailAddressInvalid')
  - [AnyContainNoCase(collection,value)](#M-xyLOGIX-Core-Extensions-StringExtensions-AnyContainNoCase-System-Collections-Generic-IEnumerable{System-String},System-String- 'xyLOGIX.Core.Extensions.StringExtensions.AnyContainNoCase(System.Collections.Generic.IEnumerable{System.String},System.String)')
  - [AsProseList\`\`1(source,selectorFunc)](#M-xyLOGIX-Core-Extensions-StringExtensions-AsProseList``1-System-Collections-Generic-IEnumerable{``0},System-Func{``0,System-String}- 'xyLOGIX.Core.Extensions.StringExtensions.AsProseList``1(System.Collections.Generic.IEnumerable{``0},System.Func{``0,System.String})')
  - [BreakTextIntoLines(text)](#M-xyLOGIX-Core-Extensions-StringExtensions-BreakTextIntoLines-System-String- 'xyLOGIX.Core.Extensions.StringExtensions.BreakTextIntoLines(System.String)')
  - [CleanLine(line)](#M-xyLOGIX-Core-Extensions-StringExtensions-CleanLine-System-String- 'xyLOGIX.Core.Extensions.StringExtensions.CleanLine(System.String)')
  - [ContainsAnyOf(value,searchStrings)](#M-xyLOGIX-Core-Extensions-StringExtensions-ContainsAnyOf-System-String,System-Collections-Generic-IEnumerable{System-String}- 'xyLOGIX.Core.Extensions.StringExtensions.ContainsAnyOf(System.String,System.Collections.Generic.IEnumerable{System.String})')
  - [ContainsAnyOf(value,searchChars)](#M-xyLOGIX-Core-Extensions-StringExtensions-ContainsAnyOf-System-String,System-Char[]- 'xyLOGIX.Core.Extensions.StringExtensions.ContainsAnyOf(System.String,System.Char[])')
  - [ContainsNoCase(stringToSearch,value)](#M-xyLOGIX-Core-Extensions-StringExtensions-ContainsNoCase-System-String,System-String- 'xyLOGIX.Core.Extensions.StringExtensions.ContainsNoCase(System.String,System.String)')
  - [ContainsNoCase(stringToSearch,value)](#M-xyLOGIX-Core-Extensions-StringExtensions-ContainsNoCase-System-String,System-Char- 'xyLOGIX.Core.Extensions.StringExtensions.ContainsNoCase(System.String,System.Char)')
  - [ContainsNoCase(collection,value)](#M-xyLOGIX-Core-Extensions-StringExtensions-ContainsNoCase-System-Collections-Generic-IEnumerable{System-String},System-String- 'xyLOGIX.Core.Extensions.StringExtensions.ContainsNoCase(System.Collections.Generic.IEnumerable{System.String},System.String)')
  - [DoInitialCaps(value)](#M-xyLOGIX-Core-Extensions-StringExtensions-DoInitialCaps-System-String- 'xyLOGIX.Core.Extensions.StringExtensions.DoInitialCaps(System.String)')
  - [DomainMapper(match)](#M-xyLOGIX-Core-Extensions-StringExtensions-DomainMapper-System-Text-RegularExpressions-Match- 'xyLOGIX.Core.Extensions.StringExtensions.DomainMapper(System.Text.RegularExpressions.Match)')
  - [EnsureAtIsInFront(twitterSite)](#M-xyLOGIX-Core-Extensions-StringExtensions-EnsureAtIsInFront-System-String- 'xyLOGIX.Core.Extensions.StringExtensions.EnsureAtIsInFront(System.String)')
  - [EqualsNoCase(str1,str2)](#M-xyLOGIX-Core-Extensions-StringExtensions-EqualsNoCase-System-String,System-String- 'xyLOGIX.Core.Extensions.StringExtensions.EqualsNoCase(System.String,System.String)')
  - [EqualsNoCase(str1,str2,comparisonType)](#M-xyLOGIX-Core-Extensions-StringExtensions-EqualsNoCase-System-String,System-String,System-StringComparison- 'xyLOGIX.Core.Extensions.StringExtensions.EqualsNoCase(System.String,System.String,System.StringComparison)')
  - [GetCompactedString(stringToCompact,font,maxWidth)](#M-xyLOGIX-Core-Extensions-StringExtensions-GetCompactedString-System-String,System-Drawing-Font,System-Int32- 'xyLOGIX.Core.Extensions.StringExtensions.GetCompactedString(System.String,System.Drawing.Font,System.Int32)')
  - [GetFirstNChars(value,nChars)](#M-xyLOGIX-Core-Extensions-StringExtensions-GetFirstNChars-System-String,System-Int32- 'xyLOGIX.Core.Extensions.StringExtensions.GetFirstNChars(System.String,System.Int32)')
  - [GetPersonFirstName(fullName)](#M-xyLOGIX-Core-Extensions-StringExtensions-GetPersonFirstName-System-String- 'xyLOGIX.Core.Extensions.StringExtensions.GetPersonFirstName(System.String)')
  - [GetPersonLastName(fullName)](#M-xyLOGIX-Core-Extensions-StringExtensions-GetPersonLastName-System-String- 'xyLOGIX.Core.Extensions.StringExtensions.GetPersonLastName(System.String)')
  - [IsAcronymOrStateAbbr(array,i)](#M-xyLOGIX-Core-Extensions-StringExtensions-IsAcronymOrStateAbbr-System-Collections-Generic-IList{System-String},System-Int32- 'xyLOGIX.Core.Extensions.StringExtensions.IsAcronymOrStateAbbr(System.Collections.Generic.IList{System.String},System.Int32)')
  - [IsDecimal(value)](#M-xyLOGIX-Core-Extensions-StringExtensions-IsDecimal-System-String- 'xyLOGIX.Core.Extensions.StringExtensions.IsDecimal(System.String)')
  - [IsNumeric(value)](#M-xyLOGIX-Core-Extensions-StringExtensions-IsNumeric-System-String- 'xyLOGIX.Core.Extensions.StringExtensions.IsNumeric(System.String)')
  - [IsOneOf(value,choices)](#M-xyLOGIX-Core-Extensions-StringExtensions-IsOneOf-System-String,System-Collections-Generic-IEnumerable{System-String}- 'xyLOGIX.Core.Extensions.StringExtensions.IsOneOf(System.String,System.Collections.Generic.IEnumerable{System.String})')
  - [IsRomanNumerals(value)](#M-xyLOGIX-Core-Extensions-StringExtensions-IsRomanNumerals-System-String- 'xyLOGIX.Core.Extensions.StringExtensions.IsRomanNumerals(System.String)')
  - [IsSpecialWordAtBeginningOfPhrase(words,currentWord)](#M-xyLOGIX-Core-Extensions-StringExtensions-IsSpecialWordAtBeginningOfPhrase-System-String[],System-String- 'xyLOGIX.Core.Extensions.StringExtensions.IsSpecialWordAtBeginningOfPhrase(System.String[],System.String)')
  - [IsStreetNameComponent(array,i)](#M-xyLOGIX-Core-Extensions-StringExtensions-IsStreetNameComponent-System-Collections-Generic-IReadOnlyList{System-String},System-Int32- 'xyLOGIX.Core.Extensions.StringExtensions.IsStreetNameComponent(System.Collections.Generic.IReadOnlyList{System.String},System.Int32)')
  - [IsValidEmail(value)](#M-xyLOGIX-Core-Extensions-StringExtensions-IsValidEmail-System-String- 'xyLOGIX.Core.Extensions.StringExtensions.IsValidEmail(System.String)')
  - [PluralizeWord(word,culture)](#M-xyLOGIX-Core-Extensions-StringExtensions-PluralizeWord-System-String,System-Globalization-CultureInfo- 'xyLOGIX.Core.Extensions.StringExtensions.PluralizeWord(System.String,System.Globalization.CultureInfo)')
  - [PluralizeWord(word)](#M-xyLOGIX-Core-Extensions-StringExtensions-PluralizeWord-System-String- 'xyLOGIX.Core.Extensions.StringExtensions.PluralizeWord(System.String)')
  - [RemoveDigitsAndPunctuation(value)](#M-xyLOGIX-Core-Extensions-StringExtensions-RemoveDigitsAndPunctuation-System-String- 'xyLOGIX.Core.Extensions.StringExtensions.RemoveDigitsAndPunctuation(System.String)')
  - [RemoveTrailingBackslashes(value)](#M-xyLOGIX-Core-Extensions-StringExtensions-RemoveTrailingBackslashes-System-String- 'xyLOGIX.Core.Extensions.StringExtensions.RemoveTrailingBackslashes(System.String)')
  - [StartsWithAnyOf(text,list)](#M-xyLOGIX-Core-Extensions-StringExtensions-StartsWithAnyOf-System-String,System-Collections-Generic-IEnumerable{System-String}- 'xyLOGIX.Core.Extensions.StringExtensions.StartsWithAnyOf(System.String,System.Collections.Generic.IEnumerable{System.String})')
  - [StartsWithNoCase(value,searchText)](#M-xyLOGIX-Core-Extensions-StringExtensions-StartsWithNoCase-System-String,System-String- 'xyLOGIX.Core.Extensions.StringExtensions.StartsWithNoCase(System.String,System.String)')
  - [Sub(format,args)](#M-xyLOGIX-Core-Extensions-StringExtensions-Sub-System-String,System-Object[]- 'xyLOGIX.Core.Extensions.StringExtensions.Sub(System.String,System.Object[])')
  - [ToASCII(value)](#M-xyLOGIX-Core-Extensions-StringExtensions-ToASCII-System-String- 'xyLOGIX.Core.Extensions.StringExtensions.ToASCII(System.String)')
  - [ToAcronym(phrase)](#M-xyLOGIX-Core-Extensions-StringExtensions-ToAcronym-System-String- 'xyLOGIX.Core.Extensions.StringExtensions.ToAcronym(System.String)')
  - [ToAcronymLetter(word)](#M-xyLOGIX-Core-Extensions-StringExtensions-ToAcronymLetter-System-String- 'xyLOGIX.Core.Extensions.StringExtensions.ToAcronymLetter(System.String)')
  - [ToGuidWithNoPunctuation(guid)](#M-xyLOGIX-Core-Extensions-StringExtensions-ToGuidWithNoPunctuation-System-Guid- 'xyLOGIX.Core.Extensions.StringExtensions.ToGuidWithNoPunctuation(System.Guid)')
  - [ToInitialCaps(value)](#M-xyLOGIX-Core-Extensions-StringExtensions-ToInitialCaps-System-String- 'xyLOGIX.Core.Extensions.StringExtensions.ToInitialCaps(System.String)')
  - [ToList(source,separators)](#M-xyLOGIX-Core-Extensions-StringExtensions-ToList-System-String,System-String[]- 'xyLOGIX.Core.Extensions.StringExtensions.ToList(System.String,System.String[])')
  - [ToUnicode(value)](#M-xyLOGIX-Core-Extensions-StringExtensions-ToUnicode-System-String- 'xyLOGIX.Core.Extensions.StringExtensions.ToUnicode(System.String)')
  - [TrimLine(currentLine)](#M-xyLOGIX-Core-Extensions-StringExtensions-TrimLine-System-String- 'xyLOGIX.Core.Extensions.StringExtensions.TrimLine(System.String)')
- [TypeExtensions](#T-xyLOGIX-Core-Extensions-TypeExtensions 'xyLOGIX.Core.Extensions.TypeExtensions')
  - [IsSameOrSubclass(potentialDescendant,potentialBaseType)](#M-xyLOGIX-Core-Extensions-TypeExtensions-IsSameOrSubclass-System-Type,System-Type- 'xyLOGIX.Core.Extensions.TypeExtensions.IsSameOrSubclass(System.Type,System.Type)')

<a name='T-xyLOGIX-Core-Extensions-ControlExtensions'></a>
## ControlExtensions `type`

##### Namespace

xyLOGIX.Core.Extensions

##### Summary

The `ControlExtensions` class provides helper methods for extending the functionality of .NET framework controls.

<a name='M-xyLOGIX-Core-Extensions-ControlExtensions-InvokeIfRequired-System-ComponentModel-ISynchronizeInvoke,System-Windows-Forms-MethodInvoker-'></a>
### InvokeIfRequired(obj,action) `method`

##### Summary

Provides a thread-safe way to run managed code against, e.g., a GUI-thread control.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| obj | [System.ComponentModel.ISynchronizeInvoke](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ComponentModel.ISynchronizeInvoke 'System.ComponentModel.ISynchronizeInvoke') | (Required.) Reference to an instance of an object that implements the [ISynchronizeInvoke](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ComponentModel.ISynchronizeInvoke 'System.ComponentModel.ISynchronizeInvoke') interface. |
| action | [System.Windows.Forms.MethodInvoker](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.MethodInvoker 'System.Windows.Forms.MethodInvoker') | (Required.) Reference to a [MethodInvoker](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.MethodInvoker 'System.Windows.Forms.MethodInvoker') delegate that defines the code to be run. |

##### Example

This example shows how to call the [InvokeIfRequired](#M-xyLOGIX-Core-Extensions-ControlExtensions-InvokeIfRequired 'xyLOGIX.Core.Extensions.ControlExtensions.InvokeIfRequired') method.

```
 namespace Foo
 {
     public class Form1
     {
         private System.Windows.Forms.Label mainInstructionLabel;
         private System.Windows.Forms.TextBox filenameTextBox;
         private System.Windows.Forms.Button okButton;
         public Form1()
         {
             InitializeComponent();
         }
         protected override void OnLoad(EventArgs e)
         {
             // Let's suppose we are calling this form from another thread.
             // To fill the text box, we need to use Invoke, if required.
             // NOTE: You can call the InvokeIfRequired extension method on any
             // of the child controls of the form.  Just do not call it on the form
             // itself; i.e., do not do 'this.InvokeIfRequired(...)'.
             filenameTextBox.InvokeIfRequired(()=&gt; {
                 mainInstructionLabel.Text = "Type the name of the file to open:";
                 okButton.DialogResult = DialogResult.OK;
                 AcceptButton = okButton;
             });
         }
         /* ... other form code ... */
     }
 }
 
```

##### Remarks

This method should always be called for a child control of a frame window; never the window itself (even though, technically, it also derives from [Control](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.Control 'System.Windows.Forms.Control') and implements the [ISynchronizeInvoke](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ComponentModel.ISynchronizeInvoke 'System.ComponentModel.ISynchronizeInvoke') interface).

<a name='T-xyLOGIX-Core-Extensions-DictionaryExtensions'></a>
## DictionaryExtensions `type`

##### Namespace

xyLOGIX.Core.Extensions

##### Summary

Provides methods for extending any dictionary.

<a name='M-xyLOGIX-Core-Extensions-DictionaryExtensions-ToObject``1-System-Collections-Generic-Dictionary{System-String,System-String}-'></a>
### ToObject\`\`1(source) `method`

##### Summary

Transforms an instance of an object of type
[String}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.Dictionary 'System.Collections.Generic.Dictionary{System.String,System.String}')
into an object by mapping the dictionary elements onto the object's
properties that have the same name.

##### Returns

Reference to an instance of an object of type T whose properties are
filled in with the values from the `source`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| source | [System.Collections.Generic.Dictionary{System.String,System.String}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.Dictionary 'System.Collections.Generic.Dictionary{System.String,System.String}') | Reference to an instance of an object of type
[String}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.Dictionary 'System.Collections.Generic.Dictionary{System.String,System.String}')
,
whose key-value pairs identify what properties to fill with what information. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | Type parameter identifying the object to receive the dictionary's information. |

##### Remarks

In order for this method to work, the object and the dictionary must
have the same schema.

<a name='T-xyLOGIX-Core-Extensions-EnumerableExtensions'></a>
## EnumerableExtensions `type`

##### Namespace

xyLOGIX.Core.Extensions

##### Summary

Helper methods for collections.

<a name='M-xyLOGIX-Core-Extensions-EnumerableExtensions-IsAnyOf``1-``0,``0[]-'></a>
### IsAnyOf\`\`1(source,testObjects) `method`

##### Summary

Compares the `source` object with the `testObjects` provided, to see if any of the `testObjects` is a match.

##### Returns

True if any of the `testObjects` equals the source; false otherwise.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| source | [\`\`0](#T-``0 '``0') | Source object to check. |
| testObjects | [\`\`0[]](#T-``0[] '``0[]') | Object or objects that should be compared to source with the [Equals](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object.Equals 'System.Object.Equals') method. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | Type of the object to be tested. |

<a name='M-xyLOGIX-Core-Extensions-EnumerableExtensions-ShuffleIterator``1-System-Collections-Generic-IEnumerable{``0},System-Random-'></a>
### ShuffleIterator\`\`1(source,rng) `method`

##### Summary

Shuffles the elements of the sequence into a random order, and then returns the resulting sequence. From the Fisher-Yates-Durstenfeld shuffle.  Uses the random-number generator passed in the `rng` parameter.  Behaves like the [Shuffle](#M-xyLOGIX-Core-Extensions-EnumerableExtensions-Shuffle 'xyLOGIX.Core.Extensions.EnumerableExtensions.Shuffle') method, although this method can be utilized as an iterator.

##### Returns

A new sequence, with the order of the elements randomized, according to the Fisher-Yates-Durstenfeld shuffle.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| source | [System.Collections.Generic.IEnumerable{\`\`0}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable 'System.Collections.Generic.IEnumerable{``0}') | Sequence to be shuffled. |
| rng | [System.Random](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Random 'System.Random') | A [Random](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Random 'System.Random') instance with which to generate new random values for the shuffle operation. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | Type of the elements of the sequence. |

##### Remarks

see, e.g.,

<a name='M-xyLOGIX-Core-Extensions-EnumerableExtensions-Shuffle``1-System-Collections-Generic-IEnumerable{``0}-'></a>
### Shuffle\`\`1(source) `method`

##### Summary

Shuffles the elements of the sequence into a random order, and then returns the resulting sequence. From the Fisher-Yates-Durstenfeld shuffle.

##### Returns

A new sequence, with the order of the elements randomized, according to the Fisher-Yates-Durstenfeld shuffle.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| source | [System.Collections.Generic.IEnumerable{\`\`0}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable 'System.Collections.Generic.IEnumerable{``0}') | Sequence to be shuffled. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | Type of the elements of the sequence. |

##### Remarks

see, e.g.,

<a name='M-xyLOGIX-Core-Extensions-EnumerableExtensions-Shuffle``1-System-Collections-Generic-IEnumerable{``0},System-Random-'></a>
### Shuffle\`\`1(source,rng) `method`

##### Summary

Shuffles the elements of the sequence into a random order, and then returns the resulting sequence. From the Fisher-Yates-Durstenfeld shuffle.  Uses the random-number generator passed in the `rng` parameter.

##### Returns

A new sequence, with the order of the elements randomized, according to the Fisher-Yates-Durstenfeld shuffle.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| source | [System.Collections.Generic.IEnumerable{\`\`0}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable 'System.Collections.Generic.IEnumerable{``0}') | Sequence to be shuffled. |
| rng | [System.Random](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Random 'System.Random') | A [Random](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Random 'System.Random') instance with which to generate new random values for the shuffle operation. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | Type of the elements of the sequence. |

##### Remarks

see, e.g.,

<a name='T-xyLOGIX-Core-Extensions-FormExtensions'></a>
## FormExtensions `type`

##### Namespace

xyLOGIX.Core.Extensions

##### Summary

Helper methods for manipulating windows forms.

<a name='M-xyLOGIX-Core-Extensions-FormExtensions-CenterForm-System-Windows-Forms-Form,System-Windows-Forms-Form-'></a>
### CenterForm(child,parent) `method`

##### Summary

Centers this form on the specified `parent` form.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| child | [System.Windows.Forms.Form](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.Form 'System.Windows.Forms.Form') | Reference to the form to be centered. |
| parent | [System.Windows.Forms.Form](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.Form 'System.Windows.Forms.Form') | Reference to the parent form. |

<a name='M-xyLOGIX-Core-Extensions-FormExtensions-CenterForm-System-Windows-Forms-Form,System-Windows-Forms-Screen-'></a>
### CenterForm(form,screen) `method`

##### Summary

Centers the specified `form` to the specific
`screen` that is passed.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| form | [System.Windows.Forms.Form](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.Form 'System.Windows.Forms.Form') | Reference to an instance of [Form](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.Form 'System.Windows.Forms.Form')
that specifies the form to be centered. |
| screen | [System.Windows.Forms.Screen](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.Screen 'System.Windows.Forms.Screen') | Reference to an instance of
[Screen](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.Screen 'System.Windows.Forms.Screen')
that specifies the screen that
the form is to be centered on. |

<a name='M-xyLOGIX-Core-Extensions-FormExtensions-DoIfDisposed-xyLOGIX-Core-Extensions-IForm,System-Action-'></a>
### DoIfDisposed(form,action) `method`

##### Summary

Invokes an action on the form unless it's not disposed, in which case
nothing is done.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| form | [xyLOGIX.Core.Extensions.IForm](#T-xyLOGIX-Core-Extensions-IForm 'xyLOGIX.Core.Extensions.IForm') | A [Form](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.Form 'System.Windows.Forms.Form') on which to perform the
`action`. |
| action | [System.Action](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Action 'System.Action') | An [Action](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Action 'System.Action') specifying code to be run if the form
is disposed. |

<a name='M-xyLOGIX-Core-Extensions-FormExtensions-DoIfNotDisposed-xyLOGIX-Core-Extensions-IForm,System-Action-'></a>
### DoIfNotDisposed(form,action) `method`

##### Summary

Invokes an action on the form unless it's disposed, in which case
nothing is done.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| form | [xyLOGIX.Core.Extensions.IForm](#T-xyLOGIX-Core-Extensions-IForm 'xyLOGIX.Core.Extensions.IForm') | A [Form](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.Form 'System.Windows.Forms.Form') on which to perform the
`action`. |
| action | [System.Action](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Action 'System.Action') | An [Action](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Action 'System.Action') specifying code to be run if the form
is not disposed. |

<a name='M-xyLOGIX-Core-Extensions-FormExtensions-ShowDialogAsync-System-Windows-Forms-Form,System-Windows-Forms-IWin32Window-'></a>
### ShowDialogAsync(form,owner) `method`

##### Summary

Shows a modal dialog that can be awaited upon while a task completes.

##### Returns

An awaitable
[DialogResult}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.Tasks.Task 'System.Threading.Tasks.Task{System.Windows.Forms.DialogResult}')
that contains the result of the dialog's closure.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| form | [System.Windows.Forms.Form](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.Form 'System.Windows.Forms.Form') | Reference to an instance of an object that is a child class of
[Form](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.Form 'System.Windows.Forms.Form')
that represents the form to be shown. |
| owner | [System.Windows.Forms.IWin32Window](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.IWin32Window 'System.Windows.Forms.IWin32Window') | Reference to an instance of an object that implements the
[IWin32Window](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.IWin32Window 'System.Windows.Forms.IWin32Window')
that represents the
form's owner window. |

<a name='M-xyLOGIX-Core-Extensions-FormExtensions-ShowDialogAsync-System-Windows-Forms-Form-'></a>
### ShowDialogAsync(form) `method`

##### Summary

Shows a modal dialog that can be awaited upon while a task completes.

##### Returns

An awaitable
[DialogResult}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.Tasks.Task 'System.Threading.Tasks.Task{System.Windows.Forms.DialogResult}')
that contains the result of the dialog's closure.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| form | [System.Windows.Forms.Form](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.Form 'System.Windows.Forms.Form') | Reference to an instance of an object that is a child class of
[Form](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.Form 'System.Windows.Forms.Form')
that represents the form to be shown. |

<a name='M-xyLOGIX-Core-Extensions-FormExtensions-ShowOnPrimaryMonitor-System-Windows-Forms-Form-'></a>
### ShowOnPrimaryMonitor(form) `method`

##### Summary

Shows the specified `form` on the user's primary
monitor (whatever monitor they have designated as Monitor #1)

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| form | [System.Windows.Forms.Form](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.Form 'System.Windows.Forms.Form') | Reference to the [Form](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.Form 'System.Windows.Forms.Form') to be moved
to the user's primary monitor. The form is also centered on the screen. |

<a name='T-xyLOGIX-Core-Extensions-IForm'></a>
## IForm `type`

##### Namespace

xyLOGIX.Core.Extensions

<a name='P-xyLOGIX-Core-Extensions-IForm-ProgressBar'></a>
### ProgressBar `property`

##### Summary

Gets a reference to the progress bar control.

<a name='T-xyLOGIX-Core-Extensions-IntExtensions'></a>
## IntExtensions `type`

##### Namespace

xyLOGIX.Core.Extensions

##### Summary

Provides methods that extend the [Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') class.

<a name='M-xyLOGIX-Core-Extensions-IntExtensions-EqualsOneOf-System-Int32,System-Int32[]-'></a>
### EqualsOneOf(value,list) `method`

##### Summary

Returns a value indicating whether the specified `value` is equal to one of the items in a collection of integers.

##### Returns

`true` if `value` is one of the elements of the collection; `false` if not.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | Integer to be compared to the members of the list. |
| list | [System.Int32[]](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32[] 'System.Int32[]') | Collection of integers that should be searched for the `value`. |

<a name='T-xyLOGIX-Core-Extensions-ListHelpers'></a>
## ListHelpers `type`

##### Namespace

xyLOGIX.Core.Extensions

##### Summary

Provides methods to help with lists of items.

<a name='M-xyLOGIX-Core-Extensions-ListHelpers-AddDistinct-System-Windows-Forms-ComboBox-ObjectCollection,System-Object-'></a>
### AddDistinct(collection,item) `method`

##### Summary

Adds an `item` to a `collection`,
but only if the item is not already present in the collection. If it
is, then this method does nothing.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| collection | [System.Windows.Forms.ComboBox.ObjectCollection](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.ComboBox.ObjectCollection 'System.Windows.Forms.ComboBox.ObjectCollection') | Reference to a collection that implements the
[IList](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IList 'System.Collections.Generic.IList')
interface for items of
type `T`. |
| item | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | Element to be added to the collection, unless it's in the collection already. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | Type of the new element. |

<a name='M-xyLOGIX-Core-Extensions-ListHelpers-AddDistinct``1-System-Collections-Generic-IList{``0},``0-'></a>
### AddDistinct\`\`1(list,item) `method`

##### Summary

Adds an `item` to a `list`, but only
if the item is not already present in the collection. If it is, then
this method does nothing.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| list | [System.Collections.Generic.IList{\`\`0}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IList 'System.Collections.Generic.IList{``0}') | Reference to a collection that implements the
[IList](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IList 'System.Collections.Generic.IList')
interface for items of
type `T`. |
| item | [\`\`0](#T-``0 '``0') | Element to be added to the collection, unless it's in the collection already. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | Type of the new element. |

<a name='M-xyLOGIX-Core-Extensions-ListHelpers-AddDistinct``1-System-Collections-Generic-ICollection{``0},``0-'></a>
### AddDistinct\`\`1(collection,item) `method`

##### Summary

Adds an `item` to a `collection`,
but only if the item is not already present in the collection. If it
is, then this method does nothing.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| collection | [System.Collections.Generic.ICollection{\`\`0}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.ICollection 'System.Collections.Generic.ICollection{``0}') | Reference to a collection that implements the
[IList](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IList 'System.Collections.Generic.IList')
interface for items of
type `T`. |
| item | [\`\`0](#T-``0 '``0') | Element to be added to the collection, unless it's in the collection already. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | Type of the new element. |

<a name='M-xyLOGIX-Core-Extensions-ListHelpers-Clone``1-System-Collections-Generic-ICollection{``0}-'></a>
### Clone\`\`1(source) `method`

##### Summary

Creates a duplicate of the list given to it and returns a reference to
the clone.

##### Returns

Reference to the duplicate of the collection referenced by
`source`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| source | [System.Collections.Generic.ICollection{\`\`0}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.ICollection 'System.Collections.Generic.ICollection{``0}') | Reference to the collection to make a duplicate of. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | Type of object in the list. |

<a name='M-xyLOGIX-Core-Extensions-ListHelpers-IsOneOf-System-Int32,System-Collections-Generic-IEnumerable{System-Int32}-'></a>
### IsOneOf(value,valueSet) `method`

##### Summary

Gets a value indicating whether the `value` is among
the elements of the `valueSet`.

##### Returns

true if `value` is in the `valueSet`
; false otherwise.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | Value to compare. |
| valueSet | [System.Collections.Generic.IEnumerable{System.Int32}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable 'System.Collections.Generic.IEnumerable{System.Int32}') | Range of integer values to check. |

<a name='M-xyLOGIX-Core-Extensions-ListHelpers-ToSetString-System-Collections-IList-'></a>
### ToSetString(list) `method`

##### Summary

Writes a list variable out as a set {1,2,3,4} e.g., as in mathematics.
Stops past the tenth item.

##### Returns

The `list`, formatted as a set string.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| list | [System.Collections.IList](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.IList 'System.Collections.IList') | List to be written. |

##### Remarks

This method is helpful for writing some of the members of a collection
to a log file.

<a name='T-xyLOGIX-Core-Extensions-Properties-Resources'></a>
## Resources `type`

##### Namespace

xyLOGIX.Core.Extensions.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-xyLOGIX-Core-Extensions-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-xyLOGIX-Core-Extensions-Properties-Resources-NCharsMustBePositive'></a>
### NCharsMustBePositive `property`

##### Summary

Looks up a localized string similar to nChars parameter must be greater than zero..

<a name='P-xyLOGIX-Core-Extensions-Properties-Resources-PersonNameEmpty'></a>
### PersonNameEmpty `property`

##### Summary

Looks up a localized string similar to GetPersonLastName: Cannot parse empty value for Full Name..

<a name='P-xyLOGIX-Core-Extensions-Properties-Resources-PersonNameIncorrectFormat'></a>
### PersonNameIncorrectFormat `property`

##### Summary

Looks up a localized string similar to The Full Name should at least be two words, separated by a space, such as '<FirstName> <LastName>'..

<a name='P-xyLOGIX-Core-Extensions-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.

<a name='T-xyLOGIX-Core-Extensions-StringExtensions'></a>
## StringExtensions `type`

##### Namespace

xyLOGIX.Core.Extensions

##### Summary

Provides methods and properties to assist with manipulating strings of text.

<a name='F-xyLOGIX-Core-Extensions-StringExtensions-AcronymList'></a>
### AcronymList `constants`

##### Summary

Collection of strings that are commonly-used acronyms.

<a name='F-xyLOGIX-Core-Extensions-StringExtensions-AlwaysCapitalizeIfFirstWord'></a>
### AlwaysCapitalizeIfFirstWord `constants`

##### Summary

Collection of strings that should always be capitalized if they are
the first word of a phrase.

<a name='F-xyLOGIX-Core-Extensions-StringExtensions-CapitalizeableAsFirstWords'></a>
### CapitalizeableAsFirstWords `constants`

##### Summary

Collection of strings that are potentially needing to be capitalized
if they are the first word of a phrase or a name.

<a name='F-xyLOGIX-Core-Extensions-StringExtensions-NamesOfStreetsThatShouldBeCapitalized'></a>
### NamesOfStreetsThatShouldBeCapitalized `constants`

##### Summary

Collection of strings that contain words commonly found in the name
of a street, and that need to be capitalized.

<a name='F-xyLOGIX-Core-Extensions-StringExtensions-ShortWordsThatAreNotAcronyms'></a>
### ShortWordsThatAreNotAcronyms `constants`

##### Summary

Collection of strings which are short words but are not acronyms per se.

<a name='F-xyLOGIX-Core-Extensions-StringExtensions-StateAbbrList'></a>
### StateAbbrList `constants`

##### Summary

Collection of strings that are the two-letter abbreviations of the
50 U.S. states.

<a name='P-xyLOGIX-Core-Extensions-StringExtensions-IsEmailAddressInvalid'></a>
### IsEmailAddressInvalid `property`

##### Summary

Gets or sets a value that indicates whether the string most recently
checked for whether it contains a valid email address, does in fact
contain such a valid address.

<a name='M-xyLOGIX-Core-Extensions-StringExtensions-AnyContainNoCase-System-Collections-Generic-IEnumerable{System-String},System-String-'></a>
### AnyContainNoCase(collection,value) `method`

##### Summary

Asks if the search text, in `value`, is a substring
of any of the strings in `collection`, ignoring case.

##### Returns

`true` if the indicated value is in the specified collection,
regardless of case; `false` otherwise.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| collection | [System.Collections.Generic.IEnumerable{System.String}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable 'System.Collections.Generic.IEnumerable{System.String}') | Collection to search. |
| value | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Value to compare. |

<a name='M-xyLOGIX-Core-Extensions-StringExtensions-AsProseList``1-System-Collections-Generic-IEnumerable{``0},System-Func{``0,System-String}-'></a>
### AsProseList\`\`1(source,selectorFunc) `method`

##### Summary

Takes a source and a selector function and exports a string that is
comma-separated according to proper English grammar, i.e. `"dog,
            cat, and horse"` not just `"dog, cat, horse."`

##### Returns

String containing the strings selected by the selector, as
illustrated above.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| source | [System.Collections.Generic.IEnumerable{\`\`0}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable 'System.Collections.Generic.IEnumerable{``0}') | Collection of `TSource` to iterate over. |
| selectorFunc | [System.Func{\`\`0,System.String}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Func 'System.Func{``0,System.String}') | Delegate specifying the way to represent each element of the
collection `source` as a string. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TSource | Type of each item in the source collection. |

##### Remarks

If this method is fed an `null` reference or the empty
collection for `source`, then the return value is
the empty string.

<a name='M-xyLOGIX-Core-Extensions-StringExtensions-BreakTextIntoLines-System-String-'></a>
### BreakTextIntoLines(text) `method`

##### Summary

Breaks a large body of `text` into individual
lines, on the newline character for the particular operating system.
The result is a collection of strings, one for each line.

##### Returns

Collection of strings containing one string per line of `text`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| text | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) String containing the text to be split. |

##### Remarks

If this method is passed the empty string or a blank string as
input, then it returns the empty collection.

<a name='M-xyLOGIX-Core-Extensions-StringExtensions-CleanLine-System-String-'></a>
### CleanLine(line) `method`

##### Summary

Strips newlines from the text in `line`, and then
calls [Trim](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String.Trim 'System.String.Trim') on the results.

##### Returns

Same as input, except all newline characters and whitespace has been removed.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| line | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Text to clean. |

##### Remarks

If the empty string is provided as input, then the empty string is returned.

<a name='M-xyLOGIX-Core-Extensions-StringExtensions-ContainsAnyOf-System-String,System-Collections-Generic-IEnumerable{System-String}-'></a>
### ContainsAnyOf(value,searchStrings) `method`

##### Summary

Returns `true` if the `value` has any of the
strings in `searchStrings` as a substring.

##### Returns

Value indicating whether any of the strings in `searchStrings` are substrings (case-insensitive) of
`value`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) The value to be used as a filter. |
| searchStrings | [System.Collections.Generic.IEnumerable{System.String}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable 'System.Collections.Generic.IEnumerable{System.String}') | (Required.) Collection of strings, any of which might be substrings
of `value`. |

##### Remarks

If `value` is the empty string or if the `searchStrings` collection is empty or is a `null`
reference, then this method returns `false`.

<a name='M-xyLOGIX-Core-Extensions-StringExtensions-ContainsAnyOf-System-String,System-Char[]-'></a>
### ContainsAnyOf(value,searchChars) `method`

##### Summary

Returns `true` if the `value` contains any of
the characters in `searchChars` (case-insensitive).

##### Returns

`true` if the string in `value` contains any
of the characters (case-insensitive) in the `searchChars` array; `false` otherwise.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) String to be searched. |
| searchChars | [System.Char[]](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Char[] 'System.Char[]') | (Required.) Array of characters to look for in the `value`. |

##### Remarks

If this method is passed the empty string for `value` or a `null` reference or an empty collection for
`searchChars`, then this method returns `false`.

<a name='M-xyLOGIX-Core-Extensions-StringExtensions-ContainsNoCase-System-String,System-String-'></a>
### ContainsNoCase(stringToSearch,value) `method`

##### Summary

Searches one string for another. Case-insensitive.

##### Returns

Returns true if the stringToSearch contains the substring value,
regardless of case; false otherwise.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| stringToSearch | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The string to be searched. |
| value | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Value to search for. |

<a name='M-xyLOGIX-Core-Extensions-StringExtensions-ContainsNoCase-System-String,System-Char-'></a>
### ContainsNoCase(stringToSearch,value) `method`

##### Summary

Searches one string for another. Case-insensitive.

##### Returns

Returns true if the stringToSearch contains the substring value,
regardless of case; false otherwise.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| stringToSearch | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The string to be searched. |
| value | [System.Char](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Char 'System.Char') | Value to search for. |

<a name='M-xyLOGIX-Core-Extensions-StringExtensions-ContainsNoCase-System-Collections-Generic-IEnumerable{System-String},System-String-'></a>
### ContainsNoCase(collection,value) `method`

##### Summary

Case-insensitive version of the collection Contains method.

##### Returns

TRUE if the indicated value is in the specified collection,
regardless of case; FALSE otherwise.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| collection | [System.Collections.Generic.IEnumerable{System.String}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable 'System.Collections.Generic.IEnumerable{System.String}') | Collection to search. |
| value | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Value to compare. |

<a name='M-xyLOGIX-Core-Extensions-StringExtensions-DoInitialCaps-System-String-'></a>
### DoInitialCaps(value) `method`

##### Summary

Helper method to aid in transforming text casing of a string to
Initial Caps.

##### Returns

Word provided in `value` with its first letter
replaced with a capital letter and all the remaining letters as lowercase.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) String containing the word that needs to be initial-capitalized. |

##### Remarks

If this method is provided with the empty or whitespace string, then
this method returns the empty string.

<a name='M-xyLOGIX-Core-Extensions-StringExtensions-DomainMapper-System-Text-RegularExpressions-Match-'></a>
### DomainMapper(match) `method`

##### Summary

Helper for determining whether strings contain valid email addresses.

##### Returns

Correctly-formatted domain-name matching value.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| match | [System.Text.RegularExpressions.Match](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Text.RegularExpressions.Match 'System.Text.RegularExpressions.Match') | Reference to an instance of [Match](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Text.RegularExpressions.Match 'System.Text.RegularExpressions.Match') that resulted from a
regex search. |

##### Remarks

This method also sets the value of the [IsEmailAddressInvalid](#P-xyLOGIX-Core-Extensions-StringExtensions-IsEmailAddressInvalid 'xyLOGIX.Core.Extensions.StringExtensions.IsEmailAddressInvalid')
property to `true` in the event that an error occurs.

<a name='M-xyLOGIX-Core-Extensions-StringExtensions-EnsureAtIsInFront-System-String-'></a>
### EnsureAtIsInFront(twitterSite) `method`

##### Summary

Double-checks a `twitterSite` (at-mention) string
to make sure it begins with the character '@'.

##### Returns

String containing the same value as in `twitterSite`, but one which is guaranteed to start with the
'@' character.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| twitterSite | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) Twitter handle to at-mention. |

##### Remarks

If this method is passed the empty string, then the result is the
empty string.

<a name='M-xyLOGIX-Core-Extensions-StringExtensions-EqualsNoCase-System-String,System-String-'></a>
### EqualsNoCase(str1,str2) `method`

##### Summary

A case-insensitive equality comparer for strings. Basically,
converts each of its operands to lowercase before comparing.

##### Returns

Whether the two strings are the same, regardless of case.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| str1 | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | First string to compare. |
| str2 | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Second string to compare. |

<a name='M-xyLOGIX-Core-Extensions-StringExtensions-EqualsNoCase-System-String,System-String,System-StringComparison-'></a>
### EqualsNoCase(str1,str2,comparisonType) `method`

##### Summary

A case-insensitive equality comparer for strings. Basically,
converts each of its operands to lowercase before comparing.

##### Returns

Whether the two strings are the same, regardless of case.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| str1 | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | First string to compare. |
| str2 | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Second string to compare. |
| comparisonType | [System.StringComparison](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.StringComparison 'System.StringComparison') | One of the [StringComparison](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.StringComparison 'System.StringComparison') values saying how
the strings are to be compared. |

<a name='M-xyLOGIX-Core-Extensions-StringExtensions-GetCompactedString-System-String,System-Drawing-Font,System-Int32-'></a>
### GetCompactedString(stringToCompact,font,maxWidth) `method`

##### Summary

Re-expresses strings with ellipsis (...) if they are longer than a
certain length.

##### Returns

Version of the string that has ellipsis (...) so as to fit within
the given length.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| stringToCompact | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The text to be compacted. |
| font | [System.Drawing.Font](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Drawing.Font 'System.Drawing.Font') | Font the text is in. |
| maxWidth | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The maximum length of the string. |

<a name='M-xyLOGIX-Core-Extensions-StringExtensions-GetFirstNChars-System-String,System-Int32-'></a>
### GetFirstNChars(value,nChars) `method`

##### Summary

Gets the first `nChars` characters of the string
`value` and returns them; returns the entire string
`value` if the string is smaller than `nChars` characters in length.

##### Returns

First `nChars` characters of the string in
`value`; or, if `value` is shorter
than `nChars` characters, the entire string that is
passed in `value` is returned. If a problem
occurred, the empty string is returned.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | String to pull the first `nChars` characters from. |
| nChars | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | (Must be a positive number.) Number of characters from the start of
the string to get. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentOutOfRangeException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentOutOfRangeException 'System.ArgumentOutOfRangeException') | Thrown if `nChars` has a zero or negative number
value. `nChars` must be a positive number. |

<a name='M-xyLOGIX-Core-Extensions-StringExtensions-GetPersonFirstName-System-String-'></a>
### GetPersonFirstName(fullName) `method`

##### Summary

Very naïve determination of person first name 99.9% of the time,
persons' names are // given as <First Name> <Rest>.

##### Returns

String containing the first name of the person. Empty string if this
method is passed the empty string as input.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| fullName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) String value containing the full name of the person. |

##### Remarks

Therefore, we can assume that, if we break the name field up by
spaces, then everything before the first space is word of the first name.

This should even catch 'fancy' last name, such as "de la Haye." For
instance, this method would read "Nathan de la Montoya" and return
"Nathan," so our way of determining the last name is pretty safe,
given the above assumptions and input patterns. If the empty string
is passed as input to this method, then the empty string is returned.

<a name='M-xyLOGIX-Core-Extensions-StringExtensions-GetPersonLastName-System-String-'></a>
### GetPersonLastName(fullName) `method`

##### Summary

Very naïve determination of person last name. In our software
consulting and tutoring practice, new clients tend to given their
first and last name only when signing up --- about 99.9% of the time.

##### Returns

String containing the first name of the person. Empty string if this
method is passed the empty string as input.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| fullName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) String value containing the full name of the person. |

##### Remarks

Therefore, we can assume that, if we break the name field up by
spaces, then everything after the first space is word of the last name.

This should even catch 'fancy' last name, such as "de la Haye." For
instance, this method would read "Nathan de la Montoya" and return
"de la Montoya," so our way of determining the last name is pretty
safe, given the above assumptions and input patterns. If the empty
string is passed as input, then the empty string is returned. If a
string containing just one word is passed as input, a [InvalidDataException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IO.InvalidDataException 'System.IO.InvalidDataException') is thrown.

<a name='M-xyLOGIX-Core-Extensions-StringExtensions-IsAcronymOrStateAbbr-System-Collections-Generic-IList{System-String},System-Int32-'></a>
### IsAcronymOrStateAbbr(array,i) `method`

##### Summary

Determines whether the current word in the text being parsed for a
character-casing operation is

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| array | [System.Collections.Generic.IList{System.String}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IList 'System.Collections.Generic.IList{System.String}') |  |
| i | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') |  |

<a name='M-xyLOGIX-Core-Extensions-StringExtensions-IsDecimal-System-String-'></a>
### IsDecimal(value) `method`

##### Summary

Determines whether the `value` passed is a
`decimal` number or not.

##### Returns

`true` if the string passed in `value` is the
string representation of a value that is in the range of the
`decimal` data type; `false` otherwise. The method also
returns `false` if it is passed the empty string.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) String containing the value or not. |

<a name='M-xyLOGIX-Core-Extensions-StringExtensions-IsNumeric-System-String-'></a>
### IsNumeric(value) `method`

##### Summary

Determines whether the `value` passed is the string
representation of a 32-bit `int` or not.

##### Returns

`true` if the string passed in `value` is the
string representation of a value that is in the range of the 32-bit
`int` data type; `false` otherwise. The method also
returns `false` if it is passed the empty string.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) String containing the value or not. |

<a name='M-xyLOGIX-Core-Extensions-StringExtensions-IsOneOf-System-String,System-Collections-Generic-IEnumerable{System-String}-'></a>
### IsOneOf(value,choices) `method`

##### Summary

Performs a culture-invariant, case-insensitive, OR match of the
`value` against the `choices` provided.

##### Returns

`true` if the string `value` matches one or
more of the `choices`; `false` otherwise.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Value to match. |
| choices | [System.Collections.Generic.IEnumerable{System.String}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable 'System.Collections.Generic.IEnumerable{System.String}') | Choices to match against. |

##### Remarks

If `value` is the empty string, or if `choices` is the empty collection, then this method returns `false`.

<a name='M-xyLOGIX-Core-Extensions-StringExtensions-IsRomanNumerals-System-String-'></a>
### IsRomanNumerals(value) `method`

##### Summary

Determines whether the passed [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') contains Roman numerals.

##### Returns

TRUE if the value contains Roman numerals; FALSE otherwise.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Value to be checked. |

<a name='M-xyLOGIX-Core-Extensions-StringExtensions-IsSpecialWordAtBeginningOfPhrase-System-String[],System-String-'></a>
### IsSpecialWordAtBeginningOfPhrase(words,currentWord) `method`

##### Summary

Gets a value indicating whether a special word, such as 'The' or
'Dr.' or 'Mr.' or 'Ms.' or 'A' etc. is the first word of a word and
still needs to be initial-capitalized.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| words | [System.String[]](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String[] 'System.String[]') | Array of words (a phrase split on spaces, etc.) |
| currentWord | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Current word being checked. |

<a name='M-xyLOGIX-Core-Extensions-StringExtensions-IsStreetNameComponent-System-Collections-Generic-IReadOnlyList{System-String},System-Int32-'></a>
### IsStreetNameComponent(array,i) `method`

##### Summary

Determines whether the current element in the list of words being
parsed (as part of a character-casing operation) is the component of
common names for US streets.

##### Returns

`true` if the current word belongs as part of the name of
common US streets; `false` otherwise.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| array | [System.Collections.Generic.IReadOnlyList{System.String}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IReadOnlyList 'System.Collections.Generic.IReadOnlyList{System.String}') | (Required.) Collection of words from the text being parsed. |
| i | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | (Required.) Index into the `array` of the current
word being parsed. |

##### Remarks

If this method is provided with the empty collection or an array
index outside the bounds of the collection, then this method returns `false`.

<a name='M-xyLOGIX-Core-Extensions-StringExtensions-IsValidEmail-System-String-'></a>
### IsValidEmail(value) `method`

##### Summary

Validates whether `value` is a valid email address
or not.

##### Returns

true if the string contains a valid email address value; false otherwise.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | String to be checked. |

<a name='M-xyLOGIX-Core-Extensions-StringExtensions-PluralizeWord-System-String,System-Globalization-CultureInfo-'></a>
### PluralizeWord(word,culture) `method`

##### Summary

Pluralizes the word passed in, applying language rules from the
specified `culture`.

##### Returns

The `word` if it is not plural; otherwise, a string
containing the plural version of the `word`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| word | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Word to be pluralized. |
| culture | [System.Globalization.CultureInfo](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Globalization.CultureInfo 'System.Globalization.CultureInfo') | Specifies the [CultureInfo](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Globalization.CultureInfo 'System.Globalization.CultureInfo') value
to use when applying language rules. |

##### Remarks

If the empty string is passed for `word`, then this
method returns the empty string.

<a name='M-xyLOGIX-Core-Extensions-StringExtensions-PluralizeWord-System-String-'></a>
### PluralizeWord(word) `method`

##### Summary

Pluralizes the word passed in, using the current UI culture.

##### Returns

The `word` if it is not plural; otherwise, a string
containing the plural version of the `word`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| word | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | String containing the word to be pluralized. |

##### Remarks

If the empty string is passed for `word`, then this
method returns the empty string.

<a name='M-xyLOGIX-Core-Extensions-StringExtensions-RemoveDigitsAndPunctuation-System-String-'></a>
### RemoveDigitsAndPunctuation(value) `method`

##### Summary

Strips all punctuation and numeric digits from a string and trims
the result.

##### Returns

String after transformation.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | String to have punctuation and numbers stripped. |

##### Remarks

If the empty string is passed to `value`, then the
empty string is returned.

<a name='M-xyLOGIX-Core-Extensions-StringExtensions-RemoveTrailingBackslashes-System-String-'></a>
### RemoveTrailingBackslashes(value) `method`

##### Summary

Removes any trailing '\' characters from the string provided in
`value`.

##### Returns

Same as `value`, but with no trailing backslash characters.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) String containing the value to be stripped of trailing
backslash characters. |

##### Remarks

If this method is passed the empty string, then this method returns
the empty string.

<a name='M-xyLOGIX-Core-Extensions-StringExtensions-StartsWithAnyOf-System-String,System-Collections-Generic-IEnumerable{System-String}-'></a>
### StartsWithAnyOf(text,list) `method`

##### Summary

Gets a value indicating whether `text` starts with
any of the values in the `list`.

##### Returns

true if the `text` starts with any of the entries
in `list`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| text | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | String to be checked. |
| list | [System.Collections.Generic.IEnumerable{System.String}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable 'System.Collections.Generic.IEnumerable{System.String}') | List of entries. |

##### Remarks

This method performs a case-insensitive search. It returns
`false` if passed the empty string for `text`
or the empty collection for `list`.

<a name='M-xyLOGIX-Core-Extensions-StringExtensions-StartsWithNoCase-System-String,System-String-'></a>
### StartsWithNoCase(value,searchText) `method`

##### Summary

Tells whether the `value` starts with the substring
`searchText`, ignoring case.

##### Returns

`true` if `value` starts with the `searchText`. `false` otherwise.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Value to search. |
| searchText | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Suspected starting substring. |

##### Remarks

If `value` is the empty string or if `searchText` is the empty string, then this method returns `false`.

<a name='M-xyLOGIX-Core-Extensions-StringExtensions-Sub-System-String,System-Object[]-'></a>
### Sub(format,args) `method`

##### Summary

Formats a string using the `format` and `args`.

##### Returns

A string with the format placeholders replaced by the args.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| format | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) String containing the format. |
| args | [System.Object[]](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object[] 'System.Object[]') | (Optional.) Collection of args whose values are to be replaced in
the format string. |

##### Remarks

This method is just an alias for [Format](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String.Format 'System.String.Format'). It is here to provide a way to
translate VB to C# code and still use the moniker Sub from VB that
does the same operation. If this method is passed the empty string
for `format`, then the return value is the empty string.

<a name='M-xyLOGIX-Core-Extensions-StringExtensions-ToASCII-System-String-'></a>
### ToASCII(value) `method`

##### Summary

Forces all characters in the input string, `value`,
to be ASCII-encoded characters only. If any Unicode characters are
found in `value`, then they are mapped back into
the range of ASCII-encoded values.

##### Returns

Same string as `value`, except that all characters
are now ASCII-encoded.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) String containing the characters to be processed. |

##### Remarks

If this method is passed the empty or whitespace string for
`value`, then this method returns the empty string.

<a name='M-xyLOGIX-Core-Extensions-StringExtensions-ToAcronym-System-String-'></a>
### ToAcronym(phrase) `method`

##### Summary

Turns the specified `phrase` into an all-caps
acronym, if a corresponding entry is not found in our dictionary
fields of short, non-acronym terms, i.e., [ShortWordsThatAreNotAcronyms](#F-xyLOGIX-Core-Extensions-StringExtensions-ShortWordsThatAreNotAcronyms 'xyLOGIX.Core.Extensions.StringExtensions.ShortWordsThatAreNotAcronyms').

##### Returns

Acronym converted from `phrase`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| phrase | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) String containing the phrase to turn into an acronym. |

##### Remarks

If this method is passed the empty or whitespace string, then it
returns the empty string. If this method is passed a word or phrase
that is short, but not an acronym, then the input is returned with
no alteration.

<a name='M-xyLOGIX-Core-Extensions-StringExtensions-ToAcronymLetter-System-String-'></a>
### ToAcronymLetter(word) `method`

##### Summary

Uses the first letter (turned into being uppercase, if necessary) of
the `word` provided to be one of the letters of an
acronym that is being built, e.g., from a phrase, using the first
letter of each of the words of the phrase as each of the
corresponding letters of the resulting acronym.

##### Returns

String containing the letter(s) to be utilized in the acronym.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| word | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) String containing the word whose first letter should be
made into an corresponding acronym letter. |

##### Remarks

If `word` is the empty or whitespace string, then
this method returns the empty string.

<a name='M-xyLOGIX-Core-Extensions-StringExtensions-ToGuidWithNoPunctuation-System-Guid-'></a>
### ToGuidWithNoPunctuation(guid) `method`

##### Summary

Turns a GUID into a string representation but removes all the '{',
'}' and '-' from the string representation, so that the string
representation contains only letters and/or numbers.

##### Returns

String representation with no '{', '}' and '-' in the string
representation, so that the string representation contains only
letters and/or numbers.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| guid | [System.Guid](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Guid 'System.Guid') | Reference to a [Guid](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Guid 'System.Guid') to turn into a string of
letters and numbers. |

<a name='M-xyLOGIX-Core-Extensions-StringExtensions-ToInitialCaps-System-String-'></a>
### ToInitialCaps(value) `method`

##### Summary

Returns a value that is the same as the string specified, but in
Initial Caps format.

##### Returns

String with the casing changed to InitialCaps.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Value whose case should be changed. |

##### Remarks

If this method is passed the empty or whitespace string, then it
returns the empty string.

<a name='M-xyLOGIX-Core-Extensions-StringExtensions-ToList-System-String,System-String[]-'></a>
### ToList(source,separators) `method`

##### Summary

Turns a delimited [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') into a collection of
strings with one delimited entry per element.

##### Returns

Collection of strings containing the delimited entries.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| source | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) String containing the text to be transformed. |
| separators | [System.String[]](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String[] 'System.String[]') | Collection of strings specifying the delimiter(s) to split upon. |

##### Remarks

Any empty entries in the resultant collection are removed. If the
empty string is provided as input to this method, then the method
returns the empty string. If no separators are specified, then the
empty collection is returned.

<a name='M-xyLOGIX-Core-Extensions-StringExtensions-ToUnicode-System-String-'></a>
### ToUnicode(value) `method`

##### Summary

Translates each character of the provided `value`,
character-by-character, to Unicode encoding. This method performs
the inverse operation of the [ToASCII](#M-xyLOGIX-Core-Extensions-StringExtensions-ToASCII 'xyLOGIX.Core.Extensions.StringExtensions.ToASCII') method.

##### Returns

String containing the re-encoded corresponding text to that in
`value`; or the empty string if the empty string is
provided to this method.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) String containing the text to be re-encoded. |

<a name='M-xyLOGIX-Core-Extensions-StringExtensions-TrimLine-System-String-'></a>
### TrimLine(currentLine) `method`

##### Summary

Trims the `currentLine` of text; i.e., removes
whitespace both before and after the text.

##### Returns

Trimmed text.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| currentLine | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) Text to trim. |

##### Remarks

If the empty or whitespace string is provided for `currentLine`, then the empty string is returned by this method.

<a name='T-xyLOGIX-Core-Extensions-TypeExtensions'></a>
## TypeExtensions `type`

##### Namespace

xyLOGIX.Core.Extensions

##### Summary

Helper methods to assist in handling runtime type information.

<a name='M-xyLOGIX-Core-Extensions-TypeExtensions-IsSameOrSubclass-System-Type,System-Type-'></a>
### IsSameOrSubclass(potentialDescendant,potentialBaseType) `method`

##### Summary

Ascertains whether the `potentialDescendant` is of the same, or a subclass of, the base class whose [Type](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Type 'System.Type') is passed.

##### Returns

True if the type of the `potentialDescendant` is the same as, or a subclass of, the base type.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| potentialDescendant | [System.Type](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Type 'System.Type') | Type to be examined. |
| potentialBaseType | [System.Type](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Type 'System.Type') | Reference to the [Type](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Type 'System.Type') structure of the class you think might be the `potentialDescendant`'s base. |
