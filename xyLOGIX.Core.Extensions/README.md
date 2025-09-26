<a name='assembly'></a>
# xyLOGIX.Core.Extensions

## Contents

- [BindingManagerBaseExtensions](#T-xyLOGIX-Core-Extensions-BindingManagerBaseExtensions 'xyLOGIX.Core.Extensions.BindingManagerBaseExtensions')
  - [#cctor()](#M-xyLOGIX-Core-Extensions-BindingManagerBaseExtensions-#cctor 'xyLOGIX.Core.Extensions.BindingManagerBaseExtensions.#cctor')
- [BoundComboBox](#T-xyLOGIX-Core-Extensions-BoundComboBox 'xyLOGIX.Core.Extensions.BoundComboBox')
  - [OnSelectedIndexChanged(e)](#M-xyLOGIX-Core-Extensions-BoundComboBox-OnSelectedIndexChanged-System-EventArgs- 'xyLOGIX.Core.Extensions.BoundComboBox.OnSelectedIndexChanged(System.EventArgs)')
- [Calculate](#T-xyLOGIX-Core-Extensions-Calculate 'xyLOGIX.Core.Extensions.Calculate')
  - [DeltaBetween(end,start)](#M-xyLOGIX-Core-Extensions-Calculate-DeltaBetween-System-Decimal,System-Decimal- 'xyLOGIX.Core.Extensions.Calculate.DeltaBetween(System.Decimal,System.Decimal)')
  - [FractionalChangeBetween(end,start)](#M-xyLOGIX-Core-Extensions-Calculate-FractionalChangeBetween-System-Decimal,System-Decimal- 'xyLOGIX.Core.Extensions.Calculate.FractionalChangeBetween(System.Decimal,System.Decimal)')
  - [PercentageChangeOf(initialValue,finalValue)](#M-xyLOGIX-Core-Extensions-Calculate-PercentageChangeOf-System-Int64,System-Int64- 'xyLOGIX.Core.Extensions.Calculate.PercentageChangeOf(System.Int64,System.Int64)')
  - [PercentageChangeOf(initialValue,finalValue)](#M-xyLOGIX-Core-Extensions-Calculate-PercentageChangeOf-System-Int32,System-Int32- 'xyLOGIX.Core.Extensions.Calculate.PercentageChangeOf(System.Int32,System.Int32)')
  - [PercentageChangeOf(initialValue,finalValue)](#M-xyLOGIX-Core-Extensions-Calculate-PercentageChangeOf-System-Double,System-Double- 'xyLOGIX.Core.Extensions.Calculate.PercentageChangeOf(System.Double,System.Double)')
  - [PercentageChangeOf(initialValue,finalValue)](#M-xyLOGIX-Core-Extensions-Calculate-PercentageChangeOf-System-Decimal,System-Decimal- 'xyLOGIX.Core.Extensions.Calculate.PercentageChangeOf(System.Decimal,System.Decimal)')
  - [PercentageDifference(a,b)](#M-xyLOGIX-Core-Extensions-Calculate-PercentageDifference-System-Double,System-Double- 'xyLOGIX.Core.Extensions.Calculate.PercentageDifference(System.Double,System.Double)')
  - [PercentageDifference(a,b)](#M-xyLOGIX-Core-Extensions-Calculate-PercentageDifference-System-Decimal,System-Decimal- 'xyLOGIX.Core.Extensions.Calculate.PercentageDifference(System.Decimal,System.Decimal)')
  - [PercentageDifference(a,b)](#M-xyLOGIX-Core-Extensions-Calculate-PercentageDifference-System-Int32,System-Int32- 'xyLOGIX.Core.Extensions.Calculate.PercentageDifference(System.Int32,System.Int32)')
  - [ProductOf(factors)](#M-xyLOGIX-Core-Extensions-Calculate-ProductOf-System-Decimal[]- 'xyLOGIX.Core.Extensions.Calculate.ProductOf(System.Decimal[])')
  - [QuotientOf(numerator,denominator)](#M-xyLOGIX-Core-Extensions-Calculate-QuotientOf-System-Decimal,System-Decimal- 'xyLOGIX.Core.Extensions.Calculate.QuotientOf(System.Decimal,System.Decimal)')
  - [ZeroFloorOf(value)](#M-xyLOGIX-Core-Extensions-Calculate-ZeroFloorOf-System-Int32- 'xyLOGIX.Core.Extensions.Calculate.ZeroFloorOf(System.Int32)')
  - [ZeroFloorOf(value)](#M-xyLOGIX-Core-Extensions-Calculate-ZeroFloorOf-System-Int64- 'xyLOGIX.Core.Extensions.Calculate.ZeroFloorOf(System.Int64)')
  - [ZeroFloorOf(value)](#M-xyLOGIX-Core-Extensions-Calculate-ZeroFloorOf-System-Decimal- 'xyLOGIX.Core.Extensions.Calculate.ZeroFloorOf(System.Decimal)')
  - [ZeroFloorOf(value)](#M-xyLOGIX-Core-Extensions-Calculate-ZeroFloorOf-System-Double- 'xyLOGIX.Core.Extensions.Calculate.ZeroFloorOf(System.Double)')
- [CharExtensions](#T-xyLOGIX-Core-Extensions-CharExtensions 'xyLOGIX.Core.Extensions.CharExtensions')
  - [#cctor()](#M-xyLOGIX-Core-Extensions-CharExtensions-#cctor 'xyLOGIX.Core.Extensions.CharExtensions.#cctor')
  - [IsDigit(value)](#M-xyLOGIX-Core-Extensions-CharExtensions-IsDigit-System-Char- 'xyLOGIX.Core.Extensions.CharExtensions.IsDigit(System.Char)')
  - [IsLowercase(value)](#M-xyLOGIX-Core-Extensions-CharExtensions-IsLowercase-System-Char- 'xyLOGIX.Core.Extensions.CharExtensions.IsLowercase(System.Char)')
  - [IsUppercase(value)](#M-xyLOGIX-Core-Extensions-CharExtensions-IsUppercase-System-Char- 'xyLOGIX.Core.Extensions.CharExtensions.IsUppercase(System.Char)')
- [CheckedListBoxExtensions](#T-xyLOGIX-Core-Extensions-CheckedListBoxExtensions 'xyLOGIX.Core.Extensions.CheckedListBoxExtensions')
  - [AreAllItemsSelected(checkedListBox)](#M-xyLOGIX-Core-Extensions-CheckedListBoxExtensions-AreAllItemsSelected-System-Windows-Forms-CheckedListBox- 'xyLOGIX.Core.Extensions.CheckedListBoxExtensions.AreAllItemsSelected(System.Windows.Forms.CheckedListBox)')
  - [CheckAll(checkedListBox,isChecked)](#M-xyLOGIX-Core-Extensions-CheckedListBoxExtensions-CheckAll-System-Windows-Forms-CheckedListBox,System-Boolean- 'xyLOGIX.Core.Extensions.CheckedListBoxExtensions.CheckAll(System.Windows.Forms.CheckedListBox,System.Boolean)')
  - [CheckByName(checkedListBox,itemName,isChecked)](#M-xyLOGIX-Core-Extensions-CheckedListBoxExtensions-CheckByName-System-Windows-Forms-CheckedListBox,System-String,System-Boolean- 'xyLOGIX.Core.Extensions.CheckedListBoxExtensions.CheckByName(System.Windows.Forms.CheckedListBox,System.String,System.Boolean)')
  - [GetCheckedByName(checkedListBox,itemName)](#M-xyLOGIX-Core-Extensions-CheckedListBoxExtensions-GetCheckedByName-System-Windows-Forms-CheckedListBox,System-String- 'xyLOGIX.Core.Extensions.CheckedListBoxExtensions.GetCheckedByName(System.Windows.Forms.CheckedListBox,System.String)')
  - [NoItemsAreSelected(checkedListBox)](#M-xyLOGIX-Core-Extensions-CheckedListBoxExtensions-NoItemsAreSelected-System-Windows-Forms-CheckedListBox- 'xyLOGIX.Core.Extensions.CheckedListBoxExtensions.NoItemsAreSelected(System.Windows.Forms.CheckedListBox)')
- [CollectionExtensions](#T-xyLOGIX-Core-Extensions-CollectionExtensions 'xyLOGIX.Core.Extensions.CollectionExtensions')
  - [AddMultiple\`\`1(collection,items)](#M-xyLOGIX-Core-Extensions-CollectionExtensions-AddMultiple``1-System-Collections-Generic-ICollection{``0},``0[]- 'xyLOGIX.Core.Extensions.CollectionExtensions.AddMultiple``1(System.Collections.Generic.ICollection{``0},``0[])')
  - [AnyAre\`\`1(values,predicate)](#M-xyLOGIX-Core-Extensions-CollectionExtensions-AnyAre``1-System-Collections-Generic-IEnumerable{``0},System-Func{``0,System-Boolean}- 'xyLOGIX.Core.Extensions.CollectionExtensions.AnyAre``1(System.Collections.Generic.IEnumerable{``0},System.Func{``0,System.Boolean})')
  - [IsEmpty\`\`1(collection)](#M-xyLOGIX-Core-Extensions-CollectionExtensions-IsEmpty``1-System-Collections-Generic-ICollection{``0}- 'xyLOGIX.Core.Extensions.CollectionExtensions.IsEmpty``1(System.Collections.Generic.ICollection{``0})')
  - [IsNullOrEmpty\`\`1(collection)](#M-xyLOGIX-Core-Extensions-CollectionExtensions-IsNullOrEmpty``1-System-Collections-Generic-ICollection{``0}- 'xyLOGIX.Core.Extensions.CollectionExtensions.IsNullOrEmpty``1(System.Collections.Generic.ICollection{``0})')
  - [IsOneOf\`\`1(obj)](#M-xyLOGIX-Core-Extensions-CollectionExtensions-IsOneOf``1-System-Object- 'xyLOGIX.Core.Extensions.CollectionExtensions.IsOneOf``1(System.Object)')
- [ComboBoxExtensions](#T-xyLOGIX-Core-Extensions-ComboBoxExtensions 'xyLOGIX.Core.Extensions.ComboBoxExtensions')
  - [#cctor()](#M-xyLOGIX-Core-Extensions-ComboBoxExtensions-#cctor 'xyLOGIX.Core.Extensions.ComboBoxExtensions.#cctor')
  - [BindToEnum\`\`1(comboBox,defaultSelection)](#M-xyLOGIX-Core-Extensions-ComboBoxExtensions-BindToEnum``1-System-Windows-Forms-ComboBox,``0- 'xyLOGIX.Core.Extensions.ComboBoxExtensions.BindToEnum``1(System.Windows.Forms.ComboBox,``0)')
  - [GetComboBoxItems\`\`1()](#M-xyLOGIX-Core-Extensions-ComboBoxExtensions-GetComboBoxItems``1 'xyLOGIX.Core.Extensions.ComboBoxExtensions.GetComboBoxItems``1')
  - [SelectFirstItem(comboBox)](#M-xyLOGIX-Core-Extensions-ComboBoxExtensions-SelectFirstItem-System-Windows-Forms-ComboBox- 'xyLOGIX.Core.Extensions.ComboBoxExtensions.SelectFirstItem(System.Windows.Forms.ComboBox)')
- [ComponentExtensions](#T-xyLOGIX-Core-Extensions-ComponentExtensions 'xyLOGIX.Core.Extensions.ComponentExtensions')
  - [#cctor()](#M-xyLOGIX-Core-Extensions-ComponentExtensions-#cctor 'xyLOGIX.Core.Extensions.ComponentExtensions.#cctor')
  - [IsNullOrDisposed()](#M-xyLOGIX-Core-Extensions-ComponentExtensions-IsNullOrDisposed-System-ComponentModel-Component- 'xyLOGIX.Core.Extensions.ComponentExtensions.IsNullOrDisposed(System.ComponentModel.Component)')
- [ControlExtensions](#T-xyLOGIX-Core-Extensions-ControlExtensions 'xyLOGIX.Core.Extensions.ControlExtensions')
  - [ControlFormAssociationProvider](#P-xyLOGIX-Core-Extensions-ControlExtensions-ControlFormAssociationProvider 'xyLOGIX.Core.Extensions.ControlExtensions.ControlFormAssociationProvider')
  - [#cctor()](#M-xyLOGIX-Core-Extensions-ControlExtensions-#cctor 'xyLOGIX.Core.Extensions.ControlExtensions.#cctor')
  - [AssociateWithParentForm(control)](#M-xyLOGIX-Core-Extensions-ControlExtensions-AssociateWithParentForm-System-Windows-Forms-Control- 'xyLOGIX.Core.Extensions.ControlExtensions.AssociateWithParentForm(System.Windows.Forms.Control)')
  - [GetParentForm()](#M-xyLOGIX-Core-Extensions-ControlExtensions-GetParentForm-System-Windows-Forms-Control- 'xyLOGIX.Core.Extensions.ControlExtensions.GetParentForm(System.Windows.Forms.Control)')
  - [InvokeIfRequired(obj,message)](#M-xyLOGIX-Core-Extensions-ControlExtensions-InvokeIfRequired-System-ComponentModel-ISynchronizeInvoke,System-Windows-Forms-MethodInvoker- 'xyLOGIX.Core.Extensions.ControlExtensions.InvokeIfRequired(System.ComponentModel.ISynchronizeInvoke,System.Windows.Forms.MethodInvoker)')
  - [InvokeIfRequired\`\`1(obj,message)](#M-xyLOGIX-Core-Extensions-ControlExtensions-InvokeIfRequired``1-System-ComponentModel-ISynchronizeInvoke,System-Func{``0}- 'xyLOGIX.Core.Extensions.ControlExtensions.InvokeIfRequired``1(System.ComponentModel.ISynchronizeInvoke,System.Func{``0})')
  - [IsParentFormNullOrDisposed()](#M-xyLOGIX-Core-Extensions-ControlExtensions-IsParentFormNullOrDisposed-System-Windows-Forms-Control- 'xyLOGIX.Core.Extensions.ControlExtensions.IsParentFormNullOrDisposed(System.Windows.Forms.Control)')
- [DateTimeExtensions](#T-xyLOGIX-Core-Extensions-DateTimeExtensions 'xyLOGIX.Core.Extensions.DateTimeExtensions')
  - [ToRFC3339(date)](#M-xyLOGIX-Core-Extensions-DateTimeExtensions-ToRFC3339-System-DateTime- 'xyLOGIX.Core.Extensions.DateTimeExtensions.ToRFC3339(System.DateTime)')
  - [ToSentencePart(dateTime)](#M-xyLOGIX-Core-Extensions-DateTimeExtensions-ToSentencePart-System-DateTime- 'xyLOGIX.Core.Extensions.DateTimeExtensions.ToSentencePart(System.DateTime)')
- [DateTimeOffsetExtensions](#T-xyLOGIX-Core-Extensions-DateTimeOffsetExtensions 'xyLOGIX.Core.Extensions.DateTimeOffsetExtensions')
  - [IsMoreRecentThan(time1,time2)](#M-xyLOGIX-Core-Extensions-DateTimeOffsetExtensions-IsMoreRecentThan-System-DateTimeOffset,System-DateTimeOffset- 'xyLOGIX.Core.Extensions.DateTimeOffsetExtensions.IsMoreRecentThan(System.DateTimeOffset,System.DateTimeOffset)')
  - [IsWithinXSecondsOf(dto1,dto2,seconds)](#M-xyLOGIX-Core-Extensions-DateTimeOffsetExtensions-IsWithinXSecondsOf-System-DateTimeOffset,System-DateTimeOffset,System-Int32- 'xyLOGIX.Core.Extensions.DateTimeOffsetExtensions.IsWithinXSecondsOf(System.DateTimeOffset,System.DateTimeOffset,System.Int32)')
  - [IsWithinXSecondsOf(dto1,dto2,seconds)](#M-xyLOGIX-Core-Extensions-DateTimeOffsetExtensions-IsWithinXSecondsOf-System-DateTime,System-DateTimeOffset,System-Int32- 'xyLOGIX.Core.Extensions.DateTimeOffsetExtensions.IsWithinXSecondsOf(System.DateTime,System.DateTimeOffset,System.Int32)')
- [DictionaryExtensions](#T-xyLOGIX-Core-Extensions-DictionaryExtensions 'xyLOGIX.Core.Extensions.DictionaryExtensions')
  - [#cctor()](#M-xyLOGIX-Core-Extensions-DictionaryExtensions-#cctor 'xyLOGIX.Core.Extensions.DictionaryExtensions.#cctor')
  - [AddDistinct\`\`2(dictionary,key,value)](#M-xyLOGIX-Core-Extensions-DictionaryExtensions-AddDistinct``2-System-Collections-Generic-IDictionary{``0,``1},``0,``1- 'xyLOGIX.Core.Extensions.DictionaryExtensions.AddDistinct``2(System.Collections.Generic.IDictionary{``0,``1},``0,``1)')
  - [MergeWith\`\`2(target,quote)](#M-xyLOGIX-Core-Extensions-DictionaryExtensions-MergeWith``2-System-Collections-Generic-IDictionary{``0,``1},System-Collections-Generic-IDictionary{``0,``1}- 'xyLOGIX.Core.Extensions.DictionaryExtensions.MergeWith``2(System.Collections.Generic.IDictionary{``0,``1},System.Collections.Generic.IDictionary{``0,``1})')
  - [ToConcurrentDictionary\`\`3(quote,keySelector,elementSelector)](#M-xyLOGIX-Core-Extensions-DictionaryExtensions-ToConcurrentDictionary``3-System-Collections-Generic-IEnumerable{``0},System-Func{``0,``1},System-Func{``0,``2}- 'xyLOGIX.Core.Extensions.DictionaryExtensions.ToConcurrentDictionary``3(System.Collections.Generic.IEnumerable{``0},System.Func{``0,``1},System.Func{``0,``2})')
  - [ToObject\`\`1(quote)](#M-xyLOGIX-Core-Extensions-DictionaryExtensions-ToObject``1-System-Collections-Generic-Dictionary{System-String,System-String}- 'xyLOGIX.Core.Extensions.DictionaryExtensions.ToObject``1(System.Collections.Generic.Dictionary{System.String,System.String})')
- [EnumBoundComboBoxItem\`1](#T-xyLOGIX-Core-Extensions-EnumBoundComboBoxItem`1 'xyLOGIX.Core.Extensions.EnumBoundComboBoxItem`1')
  - [Description](#P-xyLOGIX-Core-Extensions-EnumBoundComboBoxItem`1-Description 'xyLOGIX.Core.Extensions.EnumBoundComboBoxItem`1.Description')
  - [Value](#P-xyLOGIX-Core-Extensions-EnumBoundComboBoxItem`1-Value 'xyLOGIX.Core.Extensions.EnumBoundComboBoxItem`1.Value')
  - [ForEnumValue(value)](#M-xyLOGIX-Core-Extensions-EnumBoundComboBoxItem`1-ForEnumValue-`0- 'xyLOGIX.Core.Extensions.EnumBoundComboBoxItem`1.ForEnumValue(`0)')
- [EnumExtensions](#T-xyLOGIX-Core-Extensions-EnumExtensions 'xyLOGIX.Core.Extensions.EnumExtensions')
  - [#cctor()](#M-xyLOGIX-Core-Extensions-EnumExtensions-#cctor 'xyLOGIX.Core.Extensions.EnumExtensions.#cctor')
  - [AsString\`\`1(enumerationValue)](#M-xyLOGIX-Core-Extensions-EnumExtensions-AsString``1-``0- 'xyLOGIX.Core.Extensions.EnumExtensions.AsString``1(``0)')
  - [IsUndefined\`\`1(enumerationValue)](#M-xyLOGIX-Core-Extensions-EnumExtensions-IsUndefined``1-``0- 'xyLOGIX.Core.Extensions.EnumExtensions.IsUndefined``1(``0)')
- [EnumerableExtensions](#T-xyLOGIX-Core-Extensions-EnumerableExtensions 'xyLOGIX.Core.Extensions.EnumerableExtensions')
  - [#cctor()](#M-xyLOGIX-Core-Extensions-EnumerableExtensions-#cctor 'xyLOGIX.Core.Extensions.EnumerableExtensions.#cctor')
  - [AnyEqualAnyOf\`\`1(collection,values)](#M-xyLOGIX-Core-Extensions-EnumerableExtensions-AnyEqualAnyOf``1-System-Collections-Generic-IEnumerable{``0},``0[]- 'xyLOGIX.Core.Extensions.EnumerableExtensions.AnyEqualAnyOf``1(System.Collections.Generic.IEnumerable{``0},``0[])')
  - [AnyEqual\`\`1(collection,value)](#M-xyLOGIX-Core-Extensions-EnumerableExtensions-AnyEqual``1-System-Collections-Generic-IEnumerable{``0},``0- 'xyLOGIX.Core.Extensions.EnumerableExtensions.AnyEqual``1(System.Collections.Generic.IEnumerable{``0},``0)')
  - [Except\`\`1(source,value)](#M-xyLOGIX-Core-Extensions-EnumerableExtensions-Except``1-System-Collections-Generic-IEnumerable{``0},``0- 'xyLOGIX.Core.Extensions.EnumerableExtensions.Except``1(System.Collections.Generic.IEnumerable{``0},``0)')
  - [ForEach\`\`1(collection,action)](#M-xyLOGIX-Core-Extensions-EnumerableExtensions-ForEach``1-System-Collections-Generic-IList{``0},System-Action{``0}- 'xyLOGIX.Core.Extensions.EnumerableExtensions.ForEach``1(System.Collections.Generic.IList{``0},System.Action{``0})')
  - [ForEach\`\`1(collection,action)](#M-xyLOGIX-Core-Extensions-EnumerableExtensions-ForEach``1-System-Collections-Generic-IEnumerable{``0},System-Action{``0}- 'xyLOGIX.Core.Extensions.EnumerableExtensions.ForEach``1(System.Collections.Generic.IEnumerable{``0},System.Action{``0})')
  - [IsAnyOf\`\`1(value,testObjects)](#M-xyLOGIX-Core-Extensions-EnumerableExtensions-IsAnyOf``1-``0,``0[]- 'xyLOGIX.Core.Extensions.EnumerableExtensions.IsAnyOf``1(``0,``0[])')
  - [ShuffleIterator\`\`1(quote,rng)](#M-xyLOGIX-Core-Extensions-EnumerableExtensions-ShuffleIterator``1-System-Collections-Generic-IEnumerable{``0},System-Random- 'xyLOGIX.Core.Extensions.EnumerableExtensions.ShuffleIterator``1(System.Collections.Generic.IEnumerable{``0},System.Random)')
  - [Shuffle\`\`1(quote)](#M-xyLOGIX-Core-Extensions-EnumerableExtensions-Shuffle``1-System-Collections-Generic-IEnumerable{``0}- 'xyLOGIX.Core.Extensions.EnumerableExtensions.Shuffle``1(System.Collections.Generic.IEnumerable{``0})')
  - [Shuffle\`\`1(quote,rng)](#M-xyLOGIX-Core-Extensions-EnumerableExtensions-Shuffle``1-System-Collections-Generic-IEnumerable{``0},System-Random- 'xyLOGIX.Core.Extensions.EnumerableExtensions.Shuffle``1(System.Collections.Generic.IEnumerable{``0},System.Random)')
  - [TakeAllButLast\`\`1(quote)](#M-xyLOGIX-Core-Extensions-EnumerableExtensions-TakeAllButLast``1-System-Collections-Generic-IEnumerable{``0}- 'xyLOGIX.Core.Extensions.EnumerableExtensions.TakeAllButLast``1(System.Collections.Generic.IEnumerable{``0})')
- [FormExtensions](#T-xyLOGIX-Core-Extensions-FormExtensions 'xyLOGIX.Core.Extensions.FormExtensions')
  - [#cctor()](#M-xyLOGIX-Core-Extensions-FormExtensions-#cctor 'xyLOGIX.Core.Extensions.FormExtensions.#cctor')
  - [CenterForm(child,parent)](#M-xyLOGIX-Core-Extensions-FormExtensions-CenterForm-xyLOGIX-Core-Extensions-IForm,xyLOGIX-Core-Extensions-IForm- 'xyLOGIX.Core.Extensions.FormExtensions.CenterForm(xyLOGIX.Core.Extensions.IForm,xyLOGIX.Core.Extensions.IForm)')
  - [CenterForm(form,screen)](#M-xyLOGIX-Core-Extensions-FormExtensions-CenterForm-xyLOGIX-Core-Extensions-IForm,System-Windows-Forms-Screen- 'xyLOGIX.Core.Extensions.FormExtensions.CenterForm(xyLOGIX.Core.Extensions.IForm,System.Windows.Forms.Screen)')
  - [DoIfDisposed(form,message)](#M-xyLOGIX-Core-Extensions-FormExtensions-DoIfDisposed-xyLOGIX-Core-Extensions-IForm,System-Action- 'xyLOGIX.Core.Extensions.FormExtensions.DoIfDisposed(xyLOGIX.Core.Extensions.IForm,System.Action)')
  - [DoIfNotDisposed(form,message)](#M-xyLOGIX-Core-Extensions-FormExtensions-DoIfNotDisposed-xyLOGIX-Core-Extensions-IForm,System-Action- 'xyLOGIX.Core.Extensions.FormExtensions.DoIfNotDisposed(xyLOGIX.Core.Extensions.IForm,System.Action)')
  - [IsNullOrDisposed(form)](#M-xyLOGIX-Core-Extensions-FormExtensions-IsNullOrDisposed-xyLOGIX-Core-Extensions-IForm- 'xyLOGIX.Core.Extensions.FormExtensions.IsNullOrDisposed(xyLOGIX.Core.Extensions.IForm)')
  - [ShowDialogAsync(form,owner)](#M-xyLOGIX-Core-Extensions-FormExtensions-ShowDialogAsync-xyLOGIX-Core-Extensions-IForm,System-Windows-Forms-IWin32Window- 'xyLOGIX.Core.Extensions.FormExtensions.ShowDialogAsync(xyLOGIX.Core.Extensions.IForm,System.Windows.Forms.IWin32Window)')
  - [ShowDialogAsync(form)](#M-xyLOGIX-Core-Extensions-FormExtensions-ShowDialogAsync-xyLOGIX-Core-Extensions-IForm- 'xyLOGIX.Core.Extensions.FormExtensions.ShowDialogAsync(xyLOGIX.Core.Extensions.IForm)')
  - [ShowOnPrimaryMonitor(form)](#M-xyLOGIX-Core-Extensions-FormExtensions-ShowOnPrimaryMonitor-xyLOGIX-Core-Extensions-IForm- 'xyLOGIX.Core.Extensions.FormExtensions.ShowOnPrimaryMonitor(xyLOGIX.Core.Extensions.IForm)')
- [GetLanguageArticleTypeValidator](#T-xyLOGIX-Core-Extensions-GetLanguageArticleTypeValidator 'xyLOGIX.Core.Extensions.GetLanguageArticleTypeValidator')
  - [#cctor()](#M-xyLOGIX-Core-Extensions-GetLanguageArticleTypeValidator-#cctor 'xyLOGIX.Core.Extensions.GetLanguageArticleTypeValidator.#cctor')
  - [SoleInstance()](#M-xyLOGIX-Core-Extensions-GetLanguageArticleTypeValidator-SoleInstance 'xyLOGIX.Core.Extensions.GetLanguageArticleTypeValidator.SoleInstance')
- [GuidExtensions](#T-xyLOGIX-Core-Extensions-GuidExtensions 'xyLOGIX.Core.Extensions.GuidExtensions')
  - [#cctor()](#M-xyLOGIX-Core-Extensions-GuidExtensions-#cctor 'xyLOGIX.Core.Extensions.GuidExtensions.#cctor')
  - [AsDigitsWithHyphens(guid)](#M-xyLOGIX-Core-Extensions-GuidExtensions-AsDigitsWithHyphens-System-Guid- 'xyLOGIX.Core.Extensions.GuidExtensions.AsDigitsWithHyphens(System.Guid)')
  - [IsZero(value)](#M-xyLOGIX-Core-Extensions-GuidExtensions-IsZero-System-Guid- 'xyLOGIX.Core.Extensions.GuidExtensions.IsZero(System.Guid)')
  - [ToUppercaseWithBraces(guid)](#M-xyLOGIX-Core-Extensions-GuidExtensions-ToUppercaseWithBraces-System-Guid- 'xyLOGIX.Core.Extensions.GuidExtensions.ToUppercaseWithBraces(System.Guid)')
  - [WithBraces(guid)](#M-xyLOGIX-Core-Extensions-GuidExtensions-WithBraces-System-Guid- 'xyLOGIX.Core.Extensions.GuidExtensions.WithBraces(System.Guid)')
- [IComboBox](#T-xyLOGIX-Core-Extensions-IComboBox 'xyLOGIX.Core.Extensions.IComboBox')
  - [AutoCompleteCustomSource](#P-xyLOGIX-Core-Extensions-IComboBox-AutoCompleteCustomSource 'xyLOGIX.Core.Extensions.IComboBox.AutoCompleteCustomSource')
  - [AutoCompleteMode](#P-xyLOGIX-Core-Extensions-IComboBox-AutoCompleteMode 'xyLOGIX.Core.Extensions.IComboBox.AutoCompleteMode')
  - [AutoCompleteSource](#P-xyLOGIX-Core-Extensions-IComboBox-AutoCompleteSource 'xyLOGIX.Core.Extensions.IComboBox.AutoCompleteSource')
  - [DataSource](#P-xyLOGIX-Core-Extensions-IComboBox-DataSource 'xyLOGIX.Core.Extensions.IComboBox.DataSource')
  - [DrawMode](#P-xyLOGIX-Core-Extensions-IComboBox-DrawMode 'xyLOGIX.Core.Extensions.IComboBox.DrawMode')
  - [DropDownHeight](#P-xyLOGIX-Core-Extensions-IComboBox-DropDownHeight 'xyLOGIX.Core.Extensions.IComboBox.DropDownHeight')
  - [DropDownStyle](#P-xyLOGIX-Core-Extensions-IComboBox-DropDownStyle 'xyLOGIX.Core.Extensions.IComboBox.DropDownStyle')
  - [DropDownWidth](#P-xyLOGIX-Core-Extensions-IComboBox-DropDownWidth 'xyLOGIX.Core.Extensions.IComboBox.DropDownWidth')
  - [DroppedDown](#P-xyLOGIX-Core-Extensions-IComboBox-DroppedDown 'xyLOGIX.Core.Extensions.IComboBox.DroppedDown')
  - [FlatStyle](#P-xyLOGIX-Core-Extensions-IComboBox-FlatStyle 'xyLOGIX.Core.Extensions.IComboBox.FlatStyle')
  - [IntegralHeight](#P-xyLOGIX-Core-Extensions-IComboBox-IntegralHeight 'xyLOGIX.Core.Extensions.IComboBox.IntegralHeight')
  - [ItemHeight](#P-xyLOGIX-Core-Extensions-IComboBox-ItemHeight 'xyLOGIX.Core.Extensions.IComboBox.ItemHeight')
  - [Items](#P-xyLOGIX-Core-Extensions-IComboBox-Items 'xyLOGIX.Core.Extensions.IComboBox.Items')
  - [MaxDropDownItems](#P-xyLOGIX-Core-Extensions-IComboBox-MaxDropDownItems 'xyLOGIX.Core.Extensions.IComboBox.MaxDropDownItems')
  - [MaxLength](#P-xyLOGIX-Core-Extensions-IComboBox-MaxLength 'xyLOGIX.Core.Extensions.IComboBox.MaxLength')
  - [PreferredHeight](#P-xyLOGIX-Core-Extensions-IComboBox-PreferredHeight 'xyLOGIX.Core.Extensions.IComboBox.PreferredHeight')
  - [SelectedIndex](#P-xyLOGIX-Core-Extensions-IComboBox-SelectedIndex 'xyLOGIX.Core.Extensions.IComboBox.SelectedIndex')
  - [SelectedItem](#P-xyLOGIX-Core-Extensions-IComboBox-SelectedItem 'xyLOGIX.Core.Extensions.IComboBox.SelectedItem')
  - [SelectedText](#P-xyLOGIX-Core-Extensions-IComboBox-SelectedText 'xyLOGIX.Core.Extensions.IComboBox.SelectedText')
  - [SelectionLength](#P-xyLOGIX-Core-Extensions-IComboBox-SelectionLength 'xyLOGIX.Core.Extensions.IComboBox.SelectionLength')
  - [SelectionStart](#P-xyLOGIX-Core-Extensions-IComboBox-SelectionStart 'xyLOGIX.Core.Extensions.IComboBox.SelectionStart')
  - [Sorted](#P-xyLOGIX-Core-Extensions-IComboBox-Sorted 'xyLOGIX.Core.Extensions.IComboBox.Sorted')
  - [BeginUpdate()](#M-xyLOGIX-Core-Extensions-IComboBox-BeginUpdate 'xyLOGIX.Core.Extensions.IComboBox.BeginUpdate')
  - [EndUpdate()](#M-xyLOGIX-Core-Extensions-IComboBox-EndUpdate 'xyLOGIX.Core.Extensions.IComboBox.EndUpdate')
  - [FindString(s)](#M-xyLOGIX-Core-Extensions-IComboBox-FindString-System-String- 'xyLOGIX.Core.Extensions.IComboBox.FindString(System.String)')
  - [FindString(s,startIndex)](#M-xyLOGIX-Core-Extensions-IComboBox-FindString-System-String,System-Int32- 'xyLOGIX.Core.Extensions.IComboBox.FindString(System.String,System.Int32)')
  - [FindStringExact(s)](#M-xyLOGIX-Core-Extensions-IComboBox-FindStringExact-System-String- 'xyLOGIX.Core.Extensions.IComboBox.FindStringExact(System.String)')
  - [FindStringExact(s,startIndex)](#M-xyLOGIX-Core-Extensions-IComboBox-FindStringExact-System-String,System-Int32- 'xyLOGIX.Core.Extensions.IComboBox.FindStringExact(System.String,System.Int32)')
  - [GetItemHeight(index)](#M-xyLOGIX-Core-Extensions-IComboBox-GetItemHeight-System-Int32- 'xyLOGIX.Core.Extensions.IComboBox.GetItemHeight(System.Int32)')
  - [Select(start,length)](#M-xyLOGIX-Core-Extensions-IComboBox-Select-System-Int32,System-Int32- 'xyLOGIX.Core.Extensions.IComboBox.Select(System.Int32,System.Int32)')
  - [SelectAll()](#M-xyLOGIX-Core-Extensions-IComboBox-SelectAll 'xyLOGIX.Core.Extensions.IComboBox.SelectAll')
  - [ToString()](#M-xyLOGIX-Core-Extensions-IComboBox-ToString 'xyLOGIX.Core.Extensions.IComboBox.ToString')
- [IControl](#T-xyLOGIX-Core-Extensions-IControl 'xyLOGIX.Core.Extensions.IControl')
  - [AccessibilityObject](#P-xyLOGIX-Core-Extensions-IControl-AccessibilityObject 'xyLOGIX.Core.Extensions.IControl.AccessibilityObject')
  - [AccessibleDefaultActionDescription](#P-xyLOGIX-Core-Extensions-IControl-AccessibleDefaultActionDescription 'xyLOGIX.Core.Extensions.IControl.AccessibleDefaultActionDescription')
  - [AccessibleDescription](#P-xyLOGIX-Core-Extensions-IControl-AccessibleDescription 'xyLOGIX.Core.Extensions.IControl.AccessibleDescription')
  - [AccessibleName](#P-xyLOGIX-Core-Extensions-IControl-AccessibleName 'xyLOGIX.Core.Extensions.IControl.AccessibleName')
  - [AccessibleRole](#P-xyLOGIX-Core-Extensions-IControl-AccessibleRole 'xyLOGIX.Core.Extensions.IControl.AccessibleRole')
  - [AllowDrop](#P-xyLOGIX-Core-Extensions-IControl-AllowDrop 'xyLOGIX.Core.Extensions.IControl.AllowDrop')
  - [Anchor](#P-xyLOGIX-Core-Extensions-IControl-Anchor 'xyLOGIX.Core.Extensions.IControl.Anchor')
  - [AutoScrollOffset](#P-xyLOGIX-Core-Extensions-IControl-AutoScrollOffset 'xyLOGIX.Core.Extensions.IControl.AutoScrollOffset')
  - [AutoSize](#P-xyLOGIX-Core-Extensions-IControl-AutoSize 'xyLOGIX.Core.Extensions.IControl.AutoSize')
  - [BackColor](#P-xyLOGIX-Core-Extensions-IControl-BackColor 'xyLOGIX.Core.Extensions.IControl.BackColor')
  - [BackgroundImage](#P-xyLOGIX-Core-Extensions-IControl-BackgroundImage 'xyLOGIX.Core.Extensions.IControl.BackgroundImage')
  - [BackgroundImageLayout](#P-xyLOGIX-Core-Extensions-IControl-BackgroundImageLayout 'xyLOGIX.Core.Extensions.IControl.BackgroundImageLayout')
  - [BindingContext](#P-xyLOGIX-Core-Extensions-IControl-BindingContext 'xyLOGIX.Core.Extensions.IControl.BindingContext')
  - [Bottom](#P-xyLOGIX-Core-Extensions-IControl-Bottom 'xyLOGIX.Core.Extensions.IControl.Bottom')
  - [Bounds](#P-xyLOGIX-Core-Extensions-IControl-Bounds 'xyLOGIX.Core.Extensions.IControl.Bounds')
  - [CanFocus](#P-xyLOGIX-Core-Extensions-IControl-CanFocus 'xyLOGIX.Core.Extensions.IControl.CanFocus')
  - [CanSelect](#P-xyLOGIX-Core-Extensions-IControl-CanSelect 'xyLOGIX.Core.Extensions.IControl.CanSelect')
  - [Capture](#P-xyLOGIX-Core-Extensions-IControl-Capture 'xyLOGIX.Core.Extensions.IControl.Capture')
  - [CausesValidation](#P-xyLOGIX-Core-Extensions-IControl-CausesValidation 'xyLOGIX.Core.Extensions.IControl.CausesValidation')
  - [ClientRectangle](#P-xyLOGIX-Core-Extensions-IControl-ClientRectangle 'xyLOGIX.Core.Extensions.IControl.ClientRectangle')
  - [ClientSize](#P-xyLOGIX-Core-Extensions-IControl-ClientSize 'xyLOGIX.Core.Extensions.IControl.ClientSize')
  - [CompanyName](#P-xyLOGIX-Core-Extensions-IControl-CompanyName 'xyLOGIX.Core.Extensions.IControl.CompanyName')
  - [ContainsFocus](#P-xyLOGIX-Core-Extensions-IControl-ContainsFocus 'xyLOGIX.Core.Extensions.IControl.ContainsFocus')
  - [ContextMenu](#P-xyLOGIX-Core-Extensions-IControl-ContextMenu 'xyLOGIX.Core.Extensions.IControl.ContextMenu')
  - [ContextMenuStrip](#P-xyLOGIX-Core-Extensions-IControl-ContextMenuStrip 'xyLOGIX.Core.Extensions.IControl.ContextMenuStrip')
  - [Controls](#P-xyLOGIX-Core-Extensions-IControl-Controls 'xyLOGIX.Core.Extensions.IControl.Controls')
  - [Created](#P-xyLOGIX-Core-Extensions-IControl-Created 'xyLOGIX.Core.Extensions.IControl.Created')
  - [Cursor](#P-xyLOGIX-Core-Extensions-IControl-Cursor 'xyLOGIX.Core.Extensions.IControl.Cursor')
  - [DataBindings](#P-xyLOGIX-Core-Extensions-IControl-DataBindings 'xyLOGIX.Core.Extensions.IControl.DataBindings')
  - [DeviceDpi](#P-xyLOGIX-Core-Extensions-IControl-DeviceDpi 'xyLOGIX.Core.Extensions.IControl.DeviceDpi')
  - [DisplayRectangle](#P-xyLOGIX-Core-Extensions-IControl-DisplayRectangle 'xyLOGIX.Core.Extensions.IControl.DisplayRectangle')
  - [Disposing](#P-xyLOGIX-Core-Extensions-IControl-Disposing 'xyLOGIX.Core.Extensions.IControl.Disposing')
  - [Dock](#P-xyLOGIX-Core-Extensions-IControl-Dock 'xyLOGIX.Core.Extensions.IControl.Dock')
  - [Enabled](#P-xyLOGIX-Core-Extensions-IControl-Enabled 'xyLOGIX.Core.Extensions.IControl.Enabled')
  - [Focused](#P-xyLOGIX-Core-Extensions-IControl-Focused 'xyLOGIX.Core.Extensions.IControl.Focused')
  - [Font](#P-xyLOGIX-Core-Extensions-IControl-Font 'xyLOGIX.Core.Extensions.IControl.Font')
  - [ForeColor](#P-xyLOGIX-Core-Extensions-IControl-ForeColor 'xyLOGIX.Core.Extensions.IControl.ForeColor')
  - [Handle](#P-xyLOGIX-Core-Extensions-IControl-Handle 'xyLOGIX.Core.Extensions.IControl.Handle')
  - [HasChildren](#P-xyLOGIX-Core-Extensions-IControl-HasChildren 'xyLOGIX.Core.Extensions.IControl.HasChildren')
  - [Height](#P-xyLOGIX-Core-Extensions-IControl-Height 'xyLOGIX.Core.Extensions.IControl.Height')
  - [ImeMode](#P-xyLOGIX-Core-Extensions-IControl-ImeMode 'xyLOGIX.Core.Extensions.IControl.ImeMode')
  - [IsAccessible](#P-xyLOGIX-Core-Extensions-IControl-IsAccessible 'xyLOGIX.Core.Extensions.IControl.IsAccessible')
  - [IsDisposed](#P-xyLOGIX-Core-Extensions-IControl-IsDisposed 'xyLOGIX.Core.Extensions.IControl.IsDisposed')
  - [IsHandleCreated](#P-xyLOGIX-Core-Extensions-IControl-IsHandleCreated 'xyLOGIX.Core.Extensions.IControl.IsHandleCreated')
  - [IsMirrored](#P-xyLOGIX-Core-Extensions-IControl-IsMirrored 'xyLOGIX.Core.Extensions.IControl.IsMirrored')
  - [LayoutEngine](#P-xyLOGIX-Core-Extensions-IControl-LayoutEngine 'xyLOGIX.Core.Extensions.IControl.LayoutEngine')
  - [Left](#P-xyLOGIX-Core-Extensions-IControl-Left 'xyLOGIX.Core.Extensions.IControl.Left')
  - [Location](#P-xyLOGIX-Core-Extensions-IControl-Location 'xyLOGIX.Core.Extensions.IControl.Location')
  - [Margin](#P-xyLOGIX-Core-Extensions-IControl-Margin 'xyLOGIX.Core.Extensions.IControl.Margin')
  - [MaximumSize](#P-xyLOGIX-Core-Extensions-IControl-MaximumSize 'xyLOGIX.Core.Extensions.IControl.MaximumSize')
  - [MinimumSize](#P-xyLOGIX-Core-Extensions-IControl-MinimumSize 'xyLOGIX.Core.Extensions.IControl.MinimumSize')
  - [Name](#P-xyLOGIX-Core-Extensions-IControl-Name 'xyLOGIX.Core.Extensions.IControl.Name')
  - [Padding](#P-xyLOGIX-Core-Extensions-IControl-Padding 'xyLOGIX.Core.Extensions.IControl.Padding')
  - [Parent](#P-xyLOGIX-Core-Extensions-IControl-Parent 'xyLOGIX.Core.Extensions.IControl.Parent')
  - [PreferredSize](#P-xyLOGIX-Core-Extensions-IControl-PreferredSize 'xyLOGIX.Core.Extensions.IControl.PreferredSize')
  - [ProductName](#P-xyLOGIX-Core-Extensions-IControl-ProductName 'xyLOGIX.Core.Extensions.IControl.ProductName')
  - [ProductVersion](#P-xyLOGIX-Core-Extensions-IControl-ProductVersion 'xyLOGIX.Core.Extensions.IControl.ProductVersion')
  - [RecreatingHandle](#P-xyLOGIX-Core-Extensions-IControl-RecreatingHandle 'xyLOGIX.Core.Extensions.IControl.RecreatingHandle')
  - [Region](#P-xyLOGIX-Core-Extensions-IControl-Region 'xyLOGIX.Core.Extensions.IControl.Region')
  - [Right](#P-xyLOGIX-Core-Extensions-IControl-Right 'xyLOGIX.Core.Extensions.IControl.Right')
  - [RightToLeft](#P-xyLOGIX-Core-Extensions-IControl-RightToLeft 'xyLOGIX.Core.Extensions.IControl.RightToLeft')
  - [Size](#P-xyLOGIX-Core-Extensions-IControl-Size 'xyLOGIX.Core.Extensions.IControl.Size')
  - [TabIndex](#P-xyLOGIX-Core-Extensions-IControl-TabIndex 'xyLOGIX.Core.Extensions.IControl.TabIndex')
  - [TabStop](#P-xyLOGIX-Core-Extensions-IControl-TabStop 'xyLOGIX.Core.Extensions.IControl.TabStop')
  - [Tag](#P-xyLOGIX-Core-Extensions-IControl-Tag 'xyLOGIX.Core.Extensions.IControl.Tag')
  - [Text](#P-xyLOGIX-Core-Extensions-IControl-Text 'xyLOGIX.Core.Extensions.IControl.Text')
  - [Top](#P-xyLOGIX-Core-Extensions-IControl-Top 'xyLOGIX.Core.Extensions.IControl.Top')
  - [TopLevelControl](#P-xyLOGIX-Core-Extensions-IControl-TopLevelControl 'xyLOGIX.Core.Extensions.IControl.TopLevelControl')
  - [UseWaitCursor](#P-xyLOGIX-Core-Extensions-IControl-UseWaitCursor 'xyLOGIX.Core.Extensions.IControl.UseWaitCursor')
  - [Visible](#P-xyLOGIX-Core-Extensions-IControl-Visible 'xyLOGIX.Core.Extensions.IControl.Visible')
  - [Width](#P-xyLOGIX-Core-Extensions-IControl-Width 'xyLOGIX.Core.Extensions.IControl.Width')
  - [WindowTarget](#P-xyLOGIX-Core-Extensions-IControl-WindowTarget 'xyLOGIX.Core.Extensions.IControl.WindowTarget')
  - [BeginInvoke(method)](#M-xyLOGIX-Core-Extensions-IControl-BeginInvoke-System-Delegate- 'xyLOGIX.Core.Extensions.IControl.BeginInvoke(System.Delegate)')
  - [BringToFront()](#M-xyLOGIX-Core-Extensions-IControl-BringToFront 'xyLOGIX.Core.Extensions.IControl.BringToFront')
  - [Contains(ctl)](#M-xyLOGIX-Core-Extensions-IControl-Contains-System-Windows-Forms-Control- 'xyLOGIX.Core.Extensions.IControl.Contains(System.Windows.Forms.Control)')
  - [CreateControl()](#M-xyLOGIX-Core-Extensions-IControl-CreateControl 'xyLOGIX.Core.Extensions.IControl.CreateControl')
  - [CreateGraphics()](#M-xyLOGIX-Core-Extensions-IControl-CreateGraphics 'xyLOGIX.Core.Extensions.IControl.CreateGraphics')
  - [DoDragDrop(data,allowedEffects)](#M-xyLOGIX-Core-Extensions-IControl-DoDragDrop-System-Object,System-Windows-Forms-DragDropEffects- 'xyLOGIX.Core.Extensions.IControl.DoDragDrop(System.Object,System.Windows.Forms.DragDropEffects)')
  - [DrawToBitmap(bitmap,targetBounds)](#M-xyLOGIX-Core-Extensions-IControl-DrawToBitmap-System-Drawing-Bitmap,System-Drawing-Rectangle- 'xyLOGIX.Core.Extensions.IControl.DrawToBitmap(System.Drawing.Bitmap,System.Drawing.Rectangle)')
  - [FindForm()](#M-xyLOGIX-Core-Extensions-IControl-FindForm 'xyLOGIX.Core.Extensions.IControl.FindForm')
  - [Focus()](#M-xyLOGIX-Core-Extensions-IControl-Focus 'xyLOGIX.Core.Extensions.IControl.Focus')
  - [GetChildAtPoint(pt,skipValue)](#M-xyLOGIX-Core-Extensions-IControl-GetChildAtPoint-System-Drawing-Point,System-Windows-Forms-GetChildAtPointSkip- 'xyLOGIX.Core.Extensions.IControl.GetChildAtPoint(System.Drawing.Point,System.Windows.Forms.GetChildAtPointSkip)')
  - [GetChildAtPoint(pt)](#M-xyLOGIX-Core-Extensions-IControl-GetChildAtPoint-System-Drawing-Point- 'xyLOGIX.Core.Extensions.IControl.GetChildAtPoint(System.Drawing.Point)')
  - [GetContainerControl()](#M-xyLOGIX-Core-Extensions-IControl-GetContainerControl 'xyLOGIX.Core.Extensions.IControl.GetContainerControl')
  - [GetNextControl(ctl,forward)](#M-xyLOGIX-Core-Extensions-IControl-GetNextControl-System-Windows-Forms-Control,System-Boolean- 'xyLOGIX.Core.Extensions.IControl.GetNextControl(System.Windows.Forms.Control,System.Boolean)')
  - [GetPreferredSize(proposedSize)](#M-xyLOGIX-Core-Extensions-IControl-GetPreferredSize-System-Drawing-Size- 'xyLOGIX.Core.Extensions.IControl.GetPreferredSize(System.Drawing.Size)')
  - [Hide()](#M-xyLOGIX-Core-Extensions-IControl-Hide 'xyLOGIX.Core.Extensions.IControl.Hide')
  - [Invalidate(region)](#M-xyLOGIX-Core-Extensions-IControl-Invalidate-System-Drawing-Region- 'xyLOGIX.Core.Extensions.IControl.Invalidate(System.Drawing.Region)')
  - [Invalidate(region,invalidateChildren)](#M-xyLOGIX-Core-Extensions-IControl-Invalidate-System-Drawing-Region,System-Boolean- 'xyLOGIX.Core.Extensions.IControl.Invalidate(System.Drawing.Region,System.Boolean)')
  - [Invalidate()](#M-xyLOGIX-Core-Extensions-IControl-Invalidate 'xyLOGIX.Core.Extensions.IControl.Invalidate')
  - [Invalidate(invalidateChildren)](#M-xyLOGIX-Core-Extensions-IControl-Invalidate-System-Boolean- 'xyLOGIX.Core.Extensions.IControl.Invalidate(System.Boolean)')
  - [Invalidate(rc)](#M-xyLOGIX-Core-Extensions-IControl-Invalidate-System-Drawing-Rectangle- 'xyLOGIX.Core.Extensions.IControl.Invalidate(System.Drawing.Rectangle)')
  - [Invalidate(rc,invalidateChildren)](#M-xyLOGIX-Core-Extensions-IControl-Invalidate-System-Drawing-Rectangle,System-Boolean- 'xyLOGIX.Core.Extensions.IControl.Invalidate(System.Drawing.Rectangle,System.Boolean)')
  - [Invoke(method)](#M-xyLOGIX-Core-Extensions-IControl-Invoke-System-Delegate- 'xyLOGIX.Core.Extensions.IControl.Invoke(System.Delegate)')
  - [LogicalToDeviceUnits(value)](#M-xyLOGIX-Core-Extensions-IControl-LogicalToDeviceUnits-System-Int32- 'xyLOGIX.Core.Extensions.IControl.LogicalToDeviceUnits(System.Int32)')
  - [LogicalToDeviceUnits(value)](#M-xyLOGIX-Core-Extensions-IControl-LogicalToDeviceUnits-System-Drawing-Size- 'xyLOGIX.Core.Extensions.IControl.LogicalToDeviceUnits(System.Drawing.Size)')
  - [PerformLayout()](#M-xyLOGIX-Core-Extensions-IControl-PerformLayout 'xyLOGIX.Core.Extensions.IControl.PerformLayout')
  - [PerformLayout(affectedControl,affectedProperty)](#M-xyLOGIX-Core-Extensions-IControl-PerformLayout-System-Windows-Forms-Control,System-String- 'xyLOGIX.Core.Extensions.IControl.PerformLayout(System.Windows.Forms.Control,System.String)')
  - [PointToClient(p)](#M-xyLOGIX-Core-Extensions-IControl-PointToClient-System-Drawing-Point- 'xyLOGIX.Core.Extensions.IControl.PointToClient(System.Drawing.Point)')
  - [PointToScreen(p)](#M-xyLOGIX-Core-Extensions-IControl-PointToScreen-System-Drawing-Point- 'xyLOGIX.Core.Extensions.IControl.PointToScreen(System.Drawing.Point)')
  - [PreProcessControlMessage(msg)](#M-xyLOGIX-Core-Extensions-IControl-PreProcessControlMessage-System-Windows-Forms-Message@- 'xyLOGIX.Core.Extensions.IControl.PreProcessControlMessage(System.Windows.Forms.Message@)')
  - [PreProcessMessage(msg)](#M-xyLOGIX-Core-Extensions-IControl-PreProcessMessage-System-Windows-Forms-Message@- 'xyLOGIX.Core.Extensions.IControl.PreProcessMessage(System.Windows.Forms.Message@)')
  - [RectangleToClient(r)](#M-xyLOGIX-Core-Extensions-IControl-RectangleToClient-System-Drawing-Rectangle- 'xyLOGIX.Core.Extensions.IControl.RectangleToClient(System.Drawing.Rectangle)')
  - [RectangleToScreen(r)](#M-xyLOGIX-Core-Extensions-IControl-RectangleToScreen-System-Drawing-Rectangle- 'xyLOGIX.Core.Extensions.IControl.RectangleToScreen(System.Drawing.Rectangle)')
  - [Refresh()](#M-xyLOGIX-Core-Extensions-IControl-Refresh 'xyLOGIX.Core.Extensions.IControl.Refresh')
  - [ResetBackColor()](#M-xyLOGIX-Core-Extensions-IControl-ResetBackColor 'xyLOGIX.Core.Extensions.IControl.ResetBackColor')
  - [ResetBindings()](#M-xyLOGIX-Core-Extensions-IControl-ResetBindings 'xyLOGIX.Core.Extensions.IControl.ResetBindings')
  - [ResetCursor()](#M-xyLOGIX-Core-Extensions-IControl-ResetCursor 'xyLOGIX.Core.Extensions.IControl.ResetCursor')
  - [ResetFont()](#M-xyLOGIX-Core-Extensions-IControl-ResetFont 'xyLOGIX.Core.Extensions.IControl.ResetFont')
  - [ResetForeColor()](#M-xyLOGIX-Core-Extensions-IControl-ResetForeColor 'xyLOGIX.Core.Extensions.IControl.ResetForeColor')
  - [ResetImeMode()](#M-xyLOGIX-Core-Extensions-IControl-ResetImeMode 'xyLOGIX.Core.Extensions.IControl.ResetImeMode')
  - [ResetRightToLeft()](#M-xyLOGIX-Core-Extensions-IControl-ResetRightToLeft 'xyLOGIX.Core.Extensions.IControl.ResetRightToLeft')
  - [ResetText()](#M-xyLOGIX-Core-Extensions-IControl-ResetText 'xyLOGIX.Core.Extensions.IControl.ResetText')
  - [ResumeLayout()](#M-xyLOGIX-Core-Extensions-IControl-ResumeLayout 'xyLOGIX.Core.Extensions.IControl.ResumeLayout')
  - [ResumeLayout(performLayout)](#M-xyLOGIX-Core-Extensions-IControl-ResumeLayout-System-Boolean- 'xyLOGIX.Core.Extensions.IControl.ResumeLayout(System.Boolean)')
  - [Scale(ratio)](#M-xyLOGIX-Core-Extensions-IControl-Scale-System-Single- 'xyLOGIX.Core.Extensions.IControl.Scale(System.Single)')
  - [Scale(dx,dy)](#M-xyLOGIX-Core-Extensions-IControl-Scale-System-Single,System-Single- 'xyLOGIX.Core.Extensions.IControl.Scale(System.Single,System.Single)')
  - [Scale(factor)](#M-xyLOGIX-Core-Extensions-IControl-Scale-System-Drawing-SizeF- 'xyLOGIX.Core.Extensions.IControl.Scale(System.Drawing.SizeF)')
  - [ScaleBitmapLogicalToDevice(logicalBitmap)](#M-xyLOGIX-Core-Extensions-IControl-ScaleBitmapLogicalToDevice-System-Drawing-Bitmap@- 'xyLOGIX.Core.Extensions.IControl.ScaleBitmapLogicalToDevice(System.Drawing.Bitmap@)')
  - [Select()](#M-xyLOGIX-Core-Extensions-IControl-Select 'xyLOGIX.Core.Extensions.IControl.Select')
  - [SelectNextControl(ctl,forward,tabStopOnly,nested,wrap)](#M-xyLOGIX-Core-Extensions-IControl-SelectNextControl-System-Windows-Forms-Control,System-Boolean,System-Boolean,System-Boolean,System-Boolean- 'xyLOGIX.Core.Extensions.IControl.SelectNextControl(System.Windows.Forms.Control,System.Boolean,System.Boolean,System.Boolean,System.Boolean)')
  - [SendToBack()](#M-xyLOGIX-Core-Extensions-IControl-SendToBack 'xyLOGIX.Core.Extensions.IControl.SendToBack')
  - [SetBounds(x,y,width,height)](#M-xyLOGIX-Core-Extensions-IControl-SetBounds-System-Int32,System-Int32,System-Int32,System-Int32- 'xyLOGIX.Core.Extensions.IControl.SetBounds(System.Int32,System.Int32,System.Int32,System.Int32)')
  - [SetBounds(x,y,width,height,specified)](#M-xyLOGIX-Core-Extensions-IControl-SetBounds-System-Int32,System-Int32,System-Int32,System-Int32,System-Windows-Forms-BoundsSpecified- 'xyLOGIX.Core.Extensions.IControl.SetBounds(System.Int32,System.Int32,System.Int32,System.Int32,System.Windows.Forms.BoundsSpecified)')
  - [Show()](#M-xyLOGIX-Core-Extensions-IControl-Show 'xyLOGIX.Core.Extensions.IControl.Show')
  - [SuspendLayout()](#M-xyLOGIX-Core-Extensions-IControl-SuspendLayout 'xyLOGIX.Core.Extensions.IControl.SuspendLayout')
  - [Update()](#M-xyLOGIX-Core-Extensions-IControl-Update 'xyLOGIX.Core.Extensions.IControl.Update')
- [IForm](#T-xyLOGIX-Core-Extensions-IForm 'xyLOGIX.Core.Extensions.IForm')
  - [AcceptButton](#P-xyLOGIX-Core-Extensions-IForm-AcceptButton 'xyLOGIX.Core.Extensions.IForm.AcceptButton')
  - [ActiveMdiChild](#P-xyLOGIX-Core-Extensions-IForm-ActiveMdiChild 'xyLOGIX.Core.Extensions.IForm.ActiveMdiChild')
  - [AllowTransparency](#P-xyLOGIX-Core-Extensions-IForm-AllowTransparency 'xyLOGIX.Core.Extensions.IForm.AllowTransparency')
  - [AutoScale](#P-xyLOGIX-Core-Extensions-IForm-AutoScale 'xyLOGIX.Core.Extensions.IForm.AutoScale')
  - [AutoScaleBaseSize](#P-xyLOGIX-Core-Extensions-IForm-AutoScaleBaseSize 'xyLOGIX.Core.Extensions.IForm.AutoScaleBaseSize')
  - [AutoSizeMode](#P-xyLOGIX-Core-Extensions-IForm-AutoSizeMode 'xyLOGIX.Core.Extensions.IForm.AutoSizeMode')
  - [AutoValidate](#P-xyLOGIX-Core-Extensions-IForm-AutoValidate 'xyLOGIX.Core.Extensions.IForm.AutoValidate')
  - [CancelButton](#P-xyLOGIX-Core-Extensions-IForm-CancelButton 'xyLOGIX.Core.Extensions.IForm.CancelButton')
  - [ControlBox](#P-xyLOGIX-Core-Extensions-IForm-ControlBox 'xyLOGIX.Core.Extensions.IForm.ControlBox')
  - [DesktopBounds](#P-xyLOGIX-Core-Extensions-IForm-DesktopBounds 'xyLOGIX.Core.Extensions.IForm.DesktopBounds')
  - [DesktopLocation](#P-xyLOGIX-Core-Extensions-IForm-DesktopLocation 'xyLOGIX.Core.Extensions.IForm.DesktopLocation')
  - [DialogResult](#P-xyLOGIX-Core-Extensions-IForm-DialogResult 'xyLOGIX.Core.Extensions.IForm.DialogResult')
  - [FormBorderStyle](#P-xyLOGIX-Core-Extensions-IForm-FormBorderStyle 'xyLOGIX.Core.Extensions.IForm.FormBorderStyle')
  - [HelpButton](#P-xyLOGIX-Core-Extensions-IForm-HelpButton 'xyLOGIX.Core.Extensions.IForm.HelpButton')
  - [Icon](#P-xyLOGIX-Core-Extensions-IForm-Icon 'xyLOGIX.Core.Extensions.IForm.Icon')
  - [IsMdiChild](#P-xyLOGIX-Core-Extensions-IForm-IsMdiChild 'xyLOGIX.Core.Extensions.IForm.IsMdiChild')
  - [IsMdiContainer](#P-xyLOGIX-Core-Extensions-IForm-IsMdiContainer 'xyLOGIX.Core.Extensions.IForm.IsMdiContainer')
  - [IsRestrictedWindow](#P-xyLOGIX-Core-Extensions-IForm-IsRestrictedWindow 'xyLOGIX.Core.Extensions.IForm.IsRestrictedWindow')
  - [KeyPreview](#P-xyLOGIX-Core-Extensions-IForm-KeyPreview 'xyLOGIX.Core.Extensions.IForm.KeyPreview')
  - [MainMenuStrip](#P-xyLOGIX-Core-Extensions-IForm-MainMenuStrip 'xyLOGIX.Core.Extensions.IForm.MainMenuStrip')
  - [MaximizeBox](#P-xyLOGIX-Core-Extensions-IForm-MaximizeBox 'xyLOGIX.Core.Extensions.IForm.MaximizeBox')
  - [MdiChildren](#P-xyLOGIX-Core-Extensions-IForm-MdiChildren 'xyLOGIX.Core.Extensions.IForm.MdiChildren')
  - [MdiParent](#P-xyLOGIX-Core-Extensions-IForm-MdiParent 'xyLOGIX.Core.Extensions.IForm.MdiParent')
  - [Menu](#P-xyLOGIX-Core-Extensions-IForm-Menu 'xyLOGIX.Core.Extensions.IForm.Menu')
  - [MergedMenu](#P-xyLOGIX-Core-Extensions-IForm-MergedMenu 'xyLOGIX.Core.Extensions.IForm.MergedMenu')
  - [MinimizeBox](#P-xyLOGIX-Core-Extensions-IForm-MinimizeBox 'xyLOGIX.Core.Extensions.IForm.MinimizeBox')
  - [Modal](#P-xyLOGIX-Core-Extensions-IForm-Modal 'xyLOGIX.Core.Extensions.IForm.Modal')
  - [Opacity](#P-xyLOGIX-Core-Extensions-IForm-Opacity 'xyLOGIX.Core.Extensions.IForm.Opacity')
  - [OwnedForms](#P-xyLOGIX-Core-Extensions-IForm-OwnedForms 'xyLOGIX.Core.Extensions.IForm.OwnedForms')
  - [Owner](#P-xyLOGIX-Core-Extensions-IForm-Owner 'xyLOGIX.Core.Extensions.IForm.Owner')
  - [RestoreBounds](#P-xyLOGIX-Core-Extensions-IForm-RestoreBounds 'xyLOGIX.Core.Extensions.IForm.RestoreBounds')
  - [RightToLeftLayout](#P-xyLOGIX-Core-Extensions-IForm-RightToLeftLayout 'xyLOGIX.Core.Extensions.IForm.RightToLeftLayout')
  - [ShowIcon](#P-xyLOGIX-Core-Extensions-IForm-ShowIcon 'xyLOGIX.Core.Extensions.IForm.ShowIcon')
  - [ShowInTaskbar](#P-xyLOGIX-Core-Extensions-IForm-ShowInTaskbar 'xyLOGIX.Core.Extensions.IForm.ShowInTaskbar')
  - [SizeGripStyle](#P-xyLOGIX-Core-Extensions-IForm-SizeGripStyle 'xyLOGIX.Core.Extensions.IForm.SizeGripStyle')
  - [StartPosition](#P-xyLOGIX-Core-Extensions-IForm-StartPosition 'xyLOGIX.Core.Extensions.IForm.StartPosition')
  - [TopLevel](#P-xyLOGIX-Core-Extensions-IForm-TopLevel 'xyLOGIX.Core.Extensions.IForm.TopLevel')
  - [TopMost](#P-xyLOGIX-Core-Extensions-IForm-TopMost 'xyLOGIX.Core.Extensions.IForm.TopMost')
  - [TransparencyKey](#P-xyLOGIX-Core-Extensions-IForm-TransparencyKey 'xyLOGIX.Core.Extensions.IForm.TransparencyKey')
  - [WindowState](#P-xyLOGIX-Core-Extensions-IForm-WindowState 'xyLOGIX.Core.Extensions.IForm.WindowState')
  - [Activate()](#M-xyLOGIX-Core-Extensions-IForm-Activate 'xyLOGIX.Core.Extensions.IForm.Activate')
  - [AddOwnedForm(ownedForm)](#M-xyLOGIX-Core-Extensions-IForm-AddOwnedForm-System-Windows-Forms-Form- 'xyLOGIX.Core.Extensions.IForm.AddOwnedForm(System.Windows.Forms.Form)')
  - [Close()](#M-xyLOGIX-Core-Extensions-IForm-Close 'xyLOGIX.Core.Extensions.IForm.Close')
  - [LayoutMdi(value)](#M-xyLOGIX-Core-Extensions-IForm-LayoutMdi-System-Windows-Forms-MdiLayout- 'xyLOGIX.Core.Extensions.IForm.LayoutMdi(System.Windows.Forms.MdiLayout)')
  - [RemoveOwnedForm(ownedForm)](#M-xyLOGIX-Core-Extensions-IForm-RemoveOwnedForm-System-Windows-Forms-Form- 'xyLOGIX.Core.Extensions.IForm.RemoveOwnedForm(System.Windows.Forms.Form)')
  - [SetDesktopBounds(x,y,width,height)](#M-xyLOGIX-Core-Extensions-IForm-SetDesktopBounds-System-Int32,System-Int32,System-Int32,System-Int32- 'xyLOGIX.Core.Extensions.IForm.SetDesktopBounds(System.Int32,System.Int32,System.Int32,System.Int32)')
  - [SetDesktopLocation(x,y)](#M-xyLOGIX-Core-Extensions-IForm-SetDesktopLocation-System-Int32,System-Int32- 'xyLOGIX.Core.Extensions.IForm.SetDesktopLocation(System.Int32,System.Int32)')
  - [Show(owner)](#M-xyLOGIX-Core-Extensions-IForm-Show-System-Windows-Forms-IWin32Window- 'xyLOGIX.Core.Extensions.IForm.Show(System.Windows.Forms.IWin32Window)')
  - [ShowDialog()](#M-xyLOGIX-Core-Extensions-IForm-ShowDialog 'xyLOGIX.Core.Extensions.IForm.ShowDialog')
  - [ShowDialog(owner)](#M-xyLOGIX-Core-Extensions-IForm-ShowDialog-System-Windows-Forms-IWin32Window- 'xyLOGIX.Core.Extensions.IForm.ShowDialog(System.Windows.Forms.IWin32Window)')
  - [ToString()](#M-xyLOGIX-Core-Extensions-IForm-ToString 'xyLOGIX.Core.Extensions.IForm.ToString')
  - [ValidateChildren()](#M-xyLOGIX-Core-Extensions-IForm-ValidateChildren 'xyLOGIX.Core.Extensions.IForm.ValidateChildren')
  - [ValidateChildren(validationConstraints)](#M-xyLOGIX-Core-Extensions-IForm-ValidateChildren-System-Windows-Forms-ValidationConstraints- 'xyLOGIX.Core.Extensions.IForm.ValidateChildren(System.Windows.Forms.ValidationConstraints)')
- [ILanguageArticleTypeValidator](#T-xyLOGIX-Core-Extensions-ILanguageArticleTypeValidator 'xyLOGIX.Core.Extensions.ILanguageArticleTypeValidator')
  - [IsValid(type)](#M-xyLOGIX-Core-Extensions-ILanguageArticleTypeValidator-IsValid-xyLOGIX-Core-Extensions-LanguageArticleType- 'xyLOGIX.Core.Extensions.ILanguageArticleTypeValidator.IsValid(xyLOGIX.Core.Extensions.LanguageArticleType)')
- [IListView](#T-xyLOGIX-Core-Extensions-IListView 'xyLOGIX.Core.Extensions.IListView')
  - [Activation](#P-xyLOGIX-Core-Extensions-IListView-Activation 'xyLOGIX.Core.Extensions.IListView.Activation')
  - [Alignment](#P-xyLOGIX-Core-Extensions-IListView-Alignment 'xyLOGIX.Core.Extensions.IListView.Alignment')
  - [AllowColumnReorder](#P-xyLOGIX-Core-Extensions-IListView-AllowColumnReorder 'xyLOGIX.Core.Extensions.IListView.AllowColumnReorder')
  - [AutoArrange](#P-xyLOGIX-Core-Extensions-IListView-AutoArrange 'xyLOGIX.Core.Extensions.IListView.AutoArrange')
  - [BackgroundImageTiled](#P-xyLOGIX-Core-Extensions-IListView-BackgroundImageTiled 'xyLOGIX.Core.Extensions.IListView.BackgroundImageTiled')
  - [BorderStyle](#P-xyLOGIX-Core-Extensions-IListView-BorderStyle 'xyLOGIX.Core.Extensions.IListView.BorderStyle')
  - [CheckBoxes](#P-xyLOGIX-Core-Extensions-IListView-CheckBoxes 'xyLOGIX.Core.Extensions.IListView.CheckBoxes')
  - [CheckedIndices](#P-xyLOGIX-Core-Extensions-IListView-CheckedIndices 'xyLOGIX.Core.Extensions.IListView.CheckedIndices')
  - [CheckedItems](#P-xyLOGIX-Core-Extensions-IListView-CheckedItems 'xyLOGIX.Core.Extensions.IListView.CheckedItems')
  - [Columns](#P-xyLOGIX-Core-Extensions-IListView-Columns 'xyLOGIX.Core.Extensions.IListView.Columns')
  - [Container](#P-xyLOGIX-Core-Extensions-IListView-Container 'xyLOGIX.Core.Extensions.IListView.Container')
  - [FocusedItem](#P-xyLOGIX-Core-Extensions-IListView-FocusedItem 'xyLOGIX.Core.Extensions.IListView.FocusedItem')
  - [FullRowSelect](#P-xyLOGIX-Core-Extensions-IListView-FullRowSelect 'xyLOGIX.Core.Extensions.IListView.FullRowSelect')
  - [GridLines](#P-xyLOGIX-Core-Extensions-IListView-GridLines 'xyLOGIX.Core.Extensions.IListView.GridLines')
  - [Groups](#P-xyLOGIX-Core-Extensions-IListView-Groups 'xyLOGIX.Core.Extensions.IListView.Groups')
  - [HeaderStyle](#P-xyLOGIX-Core-Extensions-IListView-HeaderStyle 'xyLOGIX.Core.Extensions.IListView.HeaderStyle')
  - [HideSelection](#P-xyLOGIX-Core-Extensions-IListView-HideSelection 'xyLOGIX.Core.Extensions.IListView.HideSelection')
  - [HotTracking](#P-xyLOGIX-Core-Extensions-IListView-HotTracking 'xyLOGIX.Core.Extensions.IListView.HotTracking')
  - [HoverSelection](#P-xyLOGIX-Core-Extensions-IListView-HoverSelection 'xyLOGIX.Core.Extensions.IListView.HoverSelection')
  - [InsertionMark](#P-xyLOGIX-Core-Extensions-IListView-InsertionMark 'xyLOGIX.Core.Extensions.IListView.InsertionMark')
  - [Items](#P-xyLOGIX-Core-Extensions-IListView-Items 'xyLOGIX.Core.Extensions.IListView.Items')
  - [LabelEdit](#P-xyLOGIX-Core-Extensions-IListView-LabelEdit 'xyLOGIX.Core.Extensions.IListView.LabelEdit')
  - [LabelWrap](#P-xyLOGIX-Core-Extensions-IListView-LabelWrap 'xyLOGIX.Core.Extensions.IListView.LabelWrap')
  - [LargeImageList](#P-xyLOGIX-Core-Extensions-IListView-LargeImageList 'xyLOGIX.Core.Extensions.IListView.LargeImageList')
  - [ListViewItemSorter](#P-xyLOGIX-Core-Extensions-IListView-ListViewItemSorter 'xyLOGIX.Core.Extensions.IListView.ListViewItemSorter')
  - [MultiSelect](#P-xyLOGIX-Core-Extensions-IListView-MultiSelect 'xyLOGIX.Core.Extensions.IListView.MultiSelect')
  - [OwnerDraw](#P-xyLOGIX-Core-Extensions-IListView-OwnerDraw 'xyLOGIX.Core.Extensions.IListView.OwnerDraw')
  - [RightToLeftLayout](#P-xyLOGIX-Core-Extensions-IListView-RightToLeftLayout 'xyLOGIX.Core.Extensions.IListView.RightToLeftLayout')
  - [Scrollable](#P-xyLOGIX-Core-Extensions-IListView-Scrollable 'xyLOGIX.Core.Extensions.IListView.Scrollable')
  - [SelectedIndices](#P-xyLOGIX-Core-Extensions-IListView-SelectedIndices 'xyLOGIX.Core.Extensions.IListView.SelectedIndices')
  - [SelectedItems](#P-xyLOGIX-Core-Extensions-IListView-SelectedItems 'xyLOGIX.Core.Extensions.IListView.SelectedItems')
  - [ShowGroups](#P-xyLOGIX-Core-Extensions-IListView-ShowGroups 'xyLOGIX.Core.Extensions.IListView.ShowGroups')
  - [ShowItemToolTips](#P-xyLOGIX-Core-Extensions-IListView-ShowItemToolTips 'xyLOGIX.Core.Extensions.IListView.ShowItemToolTips')
  - [SmallImageList](#P-xyLOGIX-Core-Extensions-IListView-SmallImageList 'xyLOGIX.Core.Extensions.IListView.SmallImageList')
  - [Sorting](#P-xyLOGIX-Core-Extensions-IListView-Sorting 'xyLOGIX.Core.Extensions.IListView.Sorting')
  - [StateImageList](#P-xyLOGIX-Core-Extensions-IListView-StateImageList 'xyLOGIX.Core.Extensions.IListView.StateImageList')
  - [TileSize](#P-xyLOGIX-Core-Extensions-IListView-TileSize 'xyLOGIX.Core.Extensions.IListView.TileSize')
  - [TopItem](#P-xyLOGIX-Core-Extensions-IListView-TopItem 'xyLOGIX.Core.Extensions.IListView.TopItem')
  - [UseCompatibleStateImageBehavior](#P-xyLOGIX-Core-Extensions-IListView-UseCompatibleStateImageBehavior 'xyLOGIX.Core.Extensions.IListView.UseCompatibleStateImageBehavior')
  - [View](#P-xyLOGIX-Core-Extensions-IListView-View 'xyLOGIX.Core.Extensions.IListView.View')
  - [VirtualListSize](#P-xyLOGIX-Core-Extensions-IListView-VirtualListSize 'xyLOGIX.Core.Extensions.IListView.VirtualListSize')
  - [VirtualMode](#P-xyLOGIX-Core-Extensions-IListView-VirtualMode 'xyLOGIX.Core.Extensions.IListView.VirtualMode')
  - [ArrangeIcons(value)](#M-xyLOGIX-Core-Extensions-IListView-ArrangeIcons-System-Windows-Forms-ListViewAlignment- 'xyLOGIX.Core.Extensions.IListView.ArrangeIcons(System.Windows.Forms.ListViewAlignment)')
  - [ArrangeIcons()](#M-xyLOGIX-Core-Extensions-IListView-ArrangeIcons 'xyLOGIX.Core.Extensions.IListView.ArrangeIcons')
  - [AutoResizeColumn(columnIndex,headerAutoResize)](#M-xyLOGIX-Core-Extensions-IListView-AutoResizeColumn-System-Int32,System-Windows-Forms-ColumnHeaderAutoResizeStyle- 'xyLOGIX.Core.Extensions.IListView.AutoResizeColumn(System.Int32,System.Windows.Forms.ColumnHeaderAutoResizeStyle)')
  - [AutoResizeColumns(headerAutoResize)](#M-xyLOGIX-Core-Extensions-IListView-AutoResizeColumns-System-Windows-Forms-ColumnHeaderAutoResizeStyle- 'xyLOGIX.Core.Extensions.IListView.AutoResizeColumns(System.Windows.Forms.ColumnHeaderAutoResizeStyle)')
  - [BeginUpdate()](#M-xyLOGIX-Core-Extensions-IListView-BeginUpdate 'xyLOGIX.Core.Extensions.IListView.BeginUpdate')
  - [Clear()](#M-xyLOGIX-Core-Extensions-IListView-Clear 'xyLOGIX.Core.Extensions.IListView.Clear')
  - [CreateObjRef(requestedType)](#M-xyLOGIX-Core-Extensions-IListView-CreateObjRef-System-Type- 'xyLOGIX.Core.Extensions.IListView.CreateObjRef(System.Type)')
  - [EndUpdate()](#M-xyLOGIX-Core-Extensions-IListView-EndUpdate 'xyLOGIX.Core.Extensions.IListView.EndUpdate')
  - [EnsureVisible(index)](#M-xyLOGIX-Core-Extensions-IListView-EnsureVisible-System-Int32- 'xyLOGIX.Core.Extensions.IListView.EnsureVisible(System.Int32)')
  - [FindItemWithText(text)](#M-xyLOGIX-Core-Extensions-IListView-FindItemWithText-System-String- 'xyLOGIX.Core.Extensions.IListView.FindItemWithText(System.String)')
  - [FindItemWithText(text,includeSubItemsInSearch,startIndex)](#M-xyLOGIX-Core-Extensions-IListView-FindItemWithText-System-String,System-Boolean,System-Int32- 'xyLOGIX.Core.Extensions.IListView.FindItemWithText(System.String,System.Boolean,System.Int32)')
  - [FindItemWithText(text,includeSubItemsInSearch,startIndex,isPrefixSearch)](#M-xyLOGIX-Core-Extensions-IListView-FindItemWithText-System-String,System-Boolean,System-Int32,System-Boolean- 'xyLOGIX.Core.Extensions.IListView.FindItemWithText(System.String,System.Boolean,System.Int32,System.Boolean)')
  - [FindNearestItem(dir,point)](#M-xyLOGIX-Core-Extensions-IListView-FindNearestItem-System-Windows-Forms-SearchDirectionHint,System-Drawing-Point- 'xyLOGIX.Core.Extensions.IListView.FindNearestItem(System.Windows.Forms.SearchDirectionHint,System.Drawing.Point)')
  - [FindNearestItem(searchDirection,x,y)](#M-xyLOGIX-Core-Extensions-IListView-FindNearestItem-System-Windows-Forms-SearchDirectionHint,System-Int32,System-Int32- 'xyLOGIX.Core.Extensions.IListView.FindNearestItem(System.Windows.Forms.SearchDirectionHint,System.Int32,System.Int32)')
  - [GetItemAt(x,y)](#M-xyLOGIX-Core-Extensions-IListView-GetItemAt-System-Int32,System-Int32- 'xyLOGIX.Core.Extensions.IListView.GetItemAt(System.Int32,System.Int32)')
  - [GetItemRect(index)](#M-xyLOGIX-Core-Extensions-IListView-GetItemRect-System-Int32- 'xyLOGIX.Core.Extensions.IListView.GetItemRect(System.Int32)')
  - [GetItemRect(index,portion)](#M-xyLOGIX-Core-Extensions-IListView-GetItemRect-System-Int32,System-Windows-Forms-ItemBoundsPortion- 'xyLOGIX.Core.Extensions.IListView.GetItemRect(System.Int32,System.Windows.Forms.ItemBoundsPortion)')
  - [GetLifetimeService()](#M-xyLOGIX-Core-Extensions-IListView-GetLifetimeService 'xyLOGIX.Core.Extensions.IListView.GetLifetimeService')
  - [HitTest(point)](#M-xyLOGIX-Core-Extensions-IListView-HitTest-System-Drawing-Point- 'xyLOGIX.Core.Extensions.IListView.HitTest(System.Drawing.Point)')
  - [HitTest(x,y)](#M-xyLOGIX-Core-Extensions-IListView-HitTest-System-Int32,System-Int32- 'xyLOGIX.Core.Extensions.IListView.HitTest(System.Int32,System.Int32)')
  - [InitializeLifetimeService()](#M-xyLOGIX-Core-Extensions-IListView-InitializeLifetimeService 'xyLOGIX.Core.Extensions.IListView.InitializeLifetimeService')
  - [RedrawItems(startIndex,endIndex,invalidateOnly)](#M-xyLOGIX-Core-Extensions-IListView-RedrawItems-System-Int32,System-Int32,System-Boolean- 'xyLOGIX.Core.Extensions.IListView.RedrawItems(System.Int32,System.Int32,System.Boolean)')
  - [Sort()](#M-xyLOGIX-Core-Extensions-IListView-Sort 'xyLOGIX.Core.Extensions.IListView.Sort')
- [IScrollableControl](#T-xyLOGIX-Core-Extensions-IScrollableControl 'xyLOGIX.Core.Extensions.IScrollableControl')
  - [AutoScroll](#P-xyLOGIX-Core-Extensions-IScrollableControl-AutoScroll 'xyLOGIX.Core.Extensions.IScrollableControl.AutoScroll')
  - [AutoScrollMargin](#P-xyLOGIX-Core-Extensions-IScrollableControl-AutoScrollMargin 'xyLOGIX.Core.Extensions.IScrollableControl.AutoScrollMargin')
  - [AutoScrollMinSize](#P-xyLOGIX-Core-Extensions-IScrollableControl-AutoScrollMinSize 'xyLOGIX.Core.Extensions.IScrollableControl.AutoScrollMinSize')
  - [AutoScrollPosition](#P-xyLOGIX-Core-Extensions-IScrollableControl-AutoScrollPosition 'xyLOGIX.Core.Extensions.IScrollableControl.AutoScrollPosition')
  - [DockPadding](#P-xyLOGIX-Core-Extensions-IScrollableControl-DockPadding 'xyLOGIX.Core.Extensions.IScrollableControl.DockPadding')
  - [HorizontalScroll](#P-xyLOGIX-Core-Extensions-IScrollableControl-HorizontalScroll 'xyLOGIX.Core.Extensions.IScrollableControl.HorizontalScroll')
  - [VerticalScroll](#P-xyLOGIX-Core-Extensions-IScrollableControl-VerticalScroll 'xyLOGIX.Core.Extensions.IScrollableControl.VerticalScroll')
  - [ScrollControlIntoView(activeControl)](#M-xyLOGIX-Core-Extensions-IScrollableControl-ScrollControlIntoView-System-Windows-Forms-Control- 'xyLOGIX.Core.Extensions.IScrollableControl.ScrollControlIntoView(System.Windows.Forms.Control)')
  - [SetAutoScrollMargin(x,y)](#M-xyLOGIX-Core-Extensions-IScrollableControl-SetAutoScrollMargin-System-Int32,System-Int32- 'xyLOGIX.Core.Extensions.IScrollableControl.SetAutoScrollMargin(System.Int32,System.Int32)')
- [IntExtensions](#T-xyLOGIX-Core-Extensions-IntExtensions 'xyLOGIX.Core.Extensions.IntExtensions')
  - [EqualsOneOf(value,list)](#M-xyLOGIX-Core-Extensions-IntExtensions-EqualsOneOf-System-Int32,System-Int32[]- 'xyLOGIX.Core.Extensions.IntExtensions.EqualsOneOf(System.Int32,System.Int32[])')
  - [IsBitmaskOn(num,bitmask)](#M-xyLOGIX-Core-Extensions-IntExtensions-IsBitmaskOn-System-Int32,System-Int32- 'xyLOGIX.Core.Extensions.IntExtensions.IsBitmaskOn(System.Int32,System.Int32)')
  - [ToOrdinalString(value)](#M-xyLOGIX-Core-Extensions-IntExtensions-ToOrdinalString-System-Int32- 'xyLOGIX.Core.Extensions.IntExtensions.ToOrdinalString(System.Int32)')
- [LanguageArticleType](#T-xyLOGIX-Core-Extensions-LanguageArticleType 'xyLOGIX.Core.Extensions.LanguageArticleType')
  - [Definite](#F-xyLOGIX-Core-Extensions-LanguageArticleType-Definite 'xyLOGIX.Core.Extensions.LanguageArticleType.Definite')
  - [Indefinite](#F-xyLOGIX-Core-Extensions-LanguageArticleType-Indefinite 'xyLOGIX.Core.Extensions.LanguageArticleType.Indefinite')
  - [None](#F-xyLOGIX-Core-Extensions-LanguageArticleType-None 'xyLOGIX.Core.Extensions.LanguageArticleType.None')
  - [PrepopsitionWithDefinite](#F-xyLOGIX-Core-Extensions-LanguageArticleType-PrepopsitionWithDefinite 'xyLOGIX.Core.Extensions.LanguageArticleType.PrepopsitionWithDefinite')
  - [PrepopsitionWithIndefinite](#F-xyLOGIX-Core-Extensions-LanguageArticleType-PrepopsitionWithIndefinite 'xyLOGIX.Core.Extensions.LanguageArticleType.PrepopsitionWithIndefinite')
  - [Preposition](#F-xyLOGIX-Core-Extensions-LanguageArticleType-Preposition 'xyLOGIX.Core.Extensions.LanguageArticleType.Preposition')
  - [Unknown](#F-xyLOGIX-Core-Extensions-LanguageArticleType-Unknown 'xyLOGIX.Core.Extensions.LanguageArticleType.Unknown')
- [LanguageArticleTypeValidator](#T-xyLOGIX-Core-Extensions-LanguageArticleTypeValidator 'xyLOGIX.Core.Extensions.LanguageArticleTypeValidator')
  - [#ctor()](#M-xyLOGIX-Core-Extensions-LanguageArticleTypeValidator-#ctor 'xyLOGIX.Core.Extensions.LanguageArticleTypeValidator.#ctor')
  - [Instance](#P-xyLOGIX-Core-Extensions-LanguageArticleTypeValidator-Instance 'xyLOGIX.Core.Extensions.LanguageArticleTypeValidator.Instance')
  - [#cctor()](#M-xyLOGIX-Core-Extensions-LanguageArticleTypeValidator-#cctor 'xyLOGIX.Core.Extensions.LanguageArticleTypeValidator.#cctor')
  - [IsValid(type)](#M-xyLOGIX-Core-Extensions-LanguageArticleTypeValidator-IsValid-xyLOGIX-Core-Extensions-LanguageArticleType- 'xyLOGIX.Core.Extensions.LanguageArticleTypeValidator.IsValid(xyLOGIX.Core.Extensions.LanguageArticleType)')
- [ListExtensions](#T-xyLOGIX-Core-Extensions-ListExtensions 'xyLOGIX.Core.Extensions.ListExtensions')
  - [#cctor()](#M-xyLOGIX-Core-Extensions-ListExtensions-#cctor 'xyLOGIX.Core.Extensions.ListExtensions.#cctor')
  - [AddDistinct(list,item)](#M-xyLOGIX-Core-Extensions-ListExtensions-AddDistinct-System-Collections-IList,System-Object- 'xyLOGIX.Core.Extensions.ListExtensions.AddDistinct(System.Collections.IList,System.Object)')
  - [AddDistinct\`\`1(list,item)](#M-xyLOGIX-Core-Extensions-ListExtensions-AddDistinct``1-System-Collections-Generic-IList{``0},``0- 'xyLOGIX.Core.Extensions.ListExtensions.AddDistinct``1(System.Collections.Generic.IList{``0},``0)')
  - [AddDistinct\`\`1(collection,item)](#M-xyLOGIX-Core-Extensions-ListExtensions-AddDistinct``1-System-Collections-Generic-ICollection{``0},``0- 'xyLOGIX.Core.Extensions.ListExtensions.AddDistinct``1(System.Collections.Generic.ICollection{``0},``0)')
  - [AddRange\`\`1(list,items)](#M-xyLOGIX-Core-Extensions-ListExtensions-AddRange``1-System-Collections-Generic-IList{``0},System-Collections-Generic-IEnumerable{``0}- 'xyLOGIX.Core.Extensions.ListExtensions.AddRange``1(System.Collections.Generic.IList{``0},System.Collections.Generic.IEnumerable{``0})')
  - [Clone\`\`1(source)](#M-xyLOGIX-Core-Extensions-ListExtensions-Clone``1-System-Collections-Generic-ICollection{``0}- 'xyLOGIX.Core.Extensions.ListExtensions.Clone``1(System.Collections.Generic.ICollection{``0})')
  - [DumpToLog\`\`1(list)](#M-xyLOGIX-Core-Extensions-ListExtensions-DumpToLog``1-System-Collections-Generic-IList{``0}- 'xyLOGIX.Core.Extensions.ListExtensions.DumpToLog``1(System.Collections.Generic.IList{``0})')
  - [FindIndex\`\`1(list,predicate)](#M-xyLOGIX-Core-Extensions-ListExtensions-FindIndex``1-System-Collections-Generic-IList{``0},System-Predicate{``0}- 'xyLOGIX.Core.Extensions.ListExtensions.FindIndex``1(System.Collections.Generic.IList{``0},System.Predicate{``0})')
  - [IsIdenticalTo\`\`1(left,right)](#M-xyLOGIX-Core-Extensions-ListExtensions-IsIdenticalTo``1-System-Collections-Generic-IList{``0},System-Collections-Generic-IList{``0}- 'xyLOGIX.Core.Extensions.ListExtensions.IsIdenticalTo``1(System.Collections.Generic.IList{``0},System.Collections.Generic.IList{``0})')
  - [IsOneOf(value,valueSet)](#M-xyLOGIX-Core-Extensions-ListExtensions-IsOneOf-System-Int32,System-Collections-Generic-IEnumerable{System-Int32}- 'xyLOGIX.Core.Extensions.ListExtensions.IsOneOf(System.Int32,System.Collections.Generic.IEnumerable{System.Int32})')
  - [NthLast\`\`1(source,index)](#M-xyLOGIX-Core-Extensions-ListExtensions-NthLast``1-System-Collections-Generic-IList{``0},System-Int32- 'xyLOGIX.Core.Extensions.ListExtensions.NthLast``1(System.Collections.Generic.IList{``0},System.Int32)')
  - [RemoveRange\`\`1(list,index,count)](#M-xyLOGIX-Core-Extensions-ListExtensions-RemoveRange``1-System-Collections-Generic-IList{``0},System-Int32,System-Int32- 'xyLOGIX.Core.Extensions.ListExtensions.RemoveRange``1(System.Collections.Generic.IList{``0},System.Int32,System.Int32)')
  - [TakeAllButLast\`\`1(source,count,includeNulls)](#M-xyLOGIX-Core-Extensions-ListExtensions-TakeAllButLast``1-System-Collections-Generic-IList{``0},System-Int32,System-Boolean- 'xyLOGIX.Core.Extensions.ListExtensions.TakeAllButLast``1(System.Collections.Generic.IList{``0},System.Int32,System.Boolean)')
  - [ToConcurrentList\`\`1(items)](#M-xyLOGIX-Core-Extensions-ListExtensions-ToConcurrentList``1-System-Collections-Generic-IEnumerable{``0}- 'xyLOGIX.Core.Extensions.ListExtensions.ToConcurrentList``1(System.Collections.Generic.IEnumerable{``0})')
  - [ToSetString\`\`1(list,max,all)](#M-xyLOGIX-Core-Extensions-ListExtensions-ToSetString``1-System-Collections-Generic-IList{``0},System-Int32,System-Boolean- 'xyLOGIX.Core.Extensions.ListExtensions.ToSetString``1(System.Collections.Generic.IList{``0},System.Int32,System.Boolean)')
  - [ToSetString\`\`1(collection,max)](#M-xyLOGIX-Core-Extensions-ListExtensions-ToSetString``1-System-Collections-Generic-ICollection{``0},System-Int32- 'xyLOGIX.Core.Extensions.ListExtensions.ToSetString``1(System.Collections.Generic.ICollection{``0},System.Int32)')
  - [ToSetString\`\`1(source,max)](#M-xyLOGIX-Core-Extensions-ListExtensions-ToSetString``1-System-Collections-Generic-IEnumerable{``0},System-Int32- 'xyLOGIX.Core.Extensions.ListExtensions.ToSetString``1(System.Collections.Generic.IEnumerable{``0},System.Int32)')
- [LongExtensions](#T-xyLOGIX-Core-Extensions-LongExtensions 'xyLOGIX.Core.Extensions.LongExtensions')
  - [IsNegative(value)](#M-xyLOGIX-Core-Extensions-LongExtensions-IsNegative-System-Int64- 'xyLOGIX.Core.Extensions.LongExtensions.IsNegative(System.Int64)')
  - [IsNonNegative(value)](#M-xyLOGIX-Core-Extensions-LongExtensions-IsNonNegative-System-Int64- 'xyLOGIX.Core.Extensions.LongExtensions.IsNonNegative(System.Int64)')
  - [IsNonPositive(value)](#M-xyLOGIX-Core-Extensions-LongExtensions-IsNonPositive-System-Int64- 'xyLOGIX.Core.Extensions.LongExtensions.IsNonPositive(System.Int64)')
  - [IsNonzero(value)](#M-xyLOGIX-Core-Extensions-LongExtensions-IsNonzero-System-Int64- 'xyLOGIX.Core.Extensions.LongExtensions.IsNonzero(System.Int64)')
  - [IsPositive(value)](#M-xyLOGIX-Core-Extensions-LongExtensions-IsPositive-System-Int64- 'xyLOGIX.Core.Extensions.LongExtensions.IsPositive(System.Int64)')
- [MarkdownExtensions](#T-xyLOGIX-Core-Extensions-MarkdownExtensions 'xyLOGIX.Core.Extensions.MarkdownExtensions')
  - [#cctor()](#M-xyLOGIX-Core-Extensions-MarkdownExtensions-#cctor 'xyLOGIX.Core.Extensions.MarkdownExtensions.#cctor')
  - [AsCode(code)](#M-xyLOGIX-Core-Extensions-MarkdownExtensions-AsCode-System-String- 'xyLOGIX.Core.Extensions.MarkdownExtensions.AsCode(System.String)')
  - [AsSpanMargin(node)](#M-xyLOGIX-Core-Extensions-MarkdownExtensions-AsSpanMargin-System-Xml-Linq-XNode- 'xyLOGIX.Core.Extensions.MarkdownExtensions.AsSpanMargin(System.Xml.Linq.XNode)')
  - [EscapeMarkdownText(content)](#M-xyLOGIX-Core-Extensions-MarkdownExtensions-EscapeMarkdownText-System-String- 'xyLOGIX.Core.Extensions.MarkdownExtensions.EscapeMarkdownText(System.String)')
  - [ToHereLink(hyperlink)](#M-xyLOGIX-Core-Extensions-MarkdownExtensions-ToHereLink-System-String- 'xyLOGIX.Core.Extensions.MarkdownExtensions.ToHereLink(System.String)')
  - [ToOpeningAnchorTag(hyperlink)](#M-xyLOGIX-Core-Extensions-MarkdownExtensions-ToOpeningAnchorTag-System-String- 'xyLOGIX.Core.Extensions.MarkdownExtensions.ToOpeningAnchorTag(System.String)')
- [NullableDecimalExtensions](#T-xyLOGIX-Core-Extensions-NullableDecimalExtensions 'xyLOGIX.Core.Extensions.NullableDecimalExtensions')
  - [IsNegative(value)](#M-xyLOGIX-Core-Extensions-NullableDecimalExtensions-IsNegative-System-Nullable{System-Decimal}- 'xyLOGIX.Core.Extensions.NullableDecimalExtensions.IsNegative(System.Nullable{System.Decimal})')
  - [IsNonPositive(value)](#M-xyLOGIX-Core-Extensions-NullableDecimalExtensions-IsNonPositive-System-Nullable{System-Decimal}- 'xyLOGIX.Core.Extensions.NullableDecimalExtensions.IsNonPositive(System.Nullable{System.Decimal})')
  - [IsNonzero(value)](#M-xyLOGIX-Core-Extensions-NullableDecimalExtensions-IsNonzero-System-Nullable{System-Decimal}- 'xyLOGIX.Core.Extensions.NullableDecimalExtensions.IsNonzero(System.Nullable{System.Decimal})')
  - [IsPositive(value)](#M-xyLOGIX-Core-Extensions-NullableDecimalExtensions-IsPositive-System-Nullable{System-Decimal}- 'xyLOGIX.Core.Extensions.NullableDecimalExtensions.IsPositive(System.Nullable{System.Decimal})')
  - [IsValid(value)](#M-xyLOGIX-Core-Extensions-NullableDecimalExtensions-IsValid-System-Nullable{System-Decimal}- 'xyLOGIX.Core.Extensions.NullableDecimalExtensions.IsValid(System.Nullable{System.Decimal})')
  - [ToNearestCent(value)](#M-xyLOGIX-Core-Extensions-NullableDecimalExtensions-ToNearestCent-System-Nullable{System-Decimal}- 'xyLOGIX.Core.Extensions.NullableDecimalExtensions.ToNearestCent(System.Nullable{System.Decimal})')
- [NullableDoubleExtensions](#T-xyLOGIX-Core-Extensions-NullableDoubleExtensions 'xyLOGIX.Core.Extensions.NullableDoubleExtensions')
  - [IsNegative(value)](#M-xyLOGIX-Core-Extensions-NullableDoubleExtensions-IsNegative-System-Nullable{System-Double}- 'xyLOGIX.Core.Extensions.NullableDoubleExtensions.IsNegative(System.Nullable{System.Double})')
  - [IsNonzero(value)](#M-xyLOGIX-Core-Extensions-NullableDoubleExtensions-IsNonzero-System-Nullable{System-Double}- 'xyLOGIX.Core.Extensions.NullableDoubleExtensions.IsNonzero(System.Nullable{System.Double})')
  - [IsPositive(value)](#M-xyLOGIX-Core-Extensions-NullableDoubleExtensions-IsPositive-System-Nullable{System-Double}- 'xyLOGIX.Core.Extensions.NullableDoubleExtensions.IsPositive(System.Nullable{System.Double})')
  - [IsValid(value)](#M-xyLOGIX-Core-Extensions-NullableDoubleExtensions-IsValid-System-Nullable{System-Double}- 'xyLOGIX.Core.Extensions.NullableDoubleExtensions.IsValid(System.Nullable{System.Double})')
- [NullableIntExtensions](#T-xyLOGIX-Core-Extensions-NullableIntExtensions 'xyLOGIX.Core.Extensions.NullableIntExtensions')
  - [IsNegative(value)](#M-xyLOGIX-Core-Extensions-NullableIntExtensions-IsNegative-System-Nullable{System-Int32}- 'xyLOGIX.Core.Extensions.NullableIntExtensions.IsNegative(System.Nullable{System.Int32})')
  - [IsNonzero(value)](#M-xyLOGIX-Core-Extensions-NullableIntExtensions-IsNonzero-System-Nullable{System-Int32}- 'xyLOGIX.Core.Extensions.NullableIntExtensions.IsNonzero(System.Nullable{System.Int32})')
  - [IsPositive(value)](#M-xyLOGIX-Core-Extensions-NullableIntExtensions-IsPositive-System-Nullable{System-Int32}- 'xyLOGIX.Core.Extensions.NullableIntExtensions.IsPositive(System.Nullable{System.Int32})')
  - [IsValid(value)](#M-xyLOGIX-Core-Extensions-NullableIntExtensions-IsValid-System-Nullable{System-Int32}- 'xyLOGIX.Core.Extensions.NullableIntExtensions.IsValid(System.Nullable{System.Int32})')
- [NullableLongExtensions](#T-xyLOGIX-Core-Extensions-NullableLongExtensions 'xyLOGIX.Core.Extensions.NullableLongExtensions')
  - [IsNegative(value)](#M-xyLOGIX-Core-Extensions-NullableLongExtensions-IsNegative-System-Nullable{System-Int64}- 'xyLOGIX.Core.Extensions.NullableLongExtensions.IsNegative(System.Nullable{System.Int64})')
  - [IsNonzero(value)](#M-xyLOGIX-Core-Extensions-NullableLongExtensions-IsNonzero-System-Nullable{System-Int64}- 'xyLOGIX.Core.Extensions.NullableLongExtensions.IsNonzero(System.Nullable{System.Int64})')
  - [IsPositive(value)](#M-xyLOGIX-Core-Extensions-NullableLongExtensions-IsPositive-System-Nullable{System-Int64}- 'xyLOGIX.Core.Extensions.NullableLongExtensions.IsPositive(System.Nullable{System.Int64})')
  - [IsValid(value)](#M-xyLOGIX-Core-Extensions-NullableLongExtensions-IsValid-System-Nullable{System-Int64}- 'xyLOGIX.Core.Extensions.NullableLongExtensions.IsValid(System.Nullable{System.Int64})')
- [NumberExtensions](#T-xyLOGIX-Core-Extensions-NumberExtensions 'xyLOGIX.Core.Extensions.NumberExtensions')
  - [#cctor()](#M-xyLOGIX-Core-Extensions-NumberExtensions-#cctor 'xyLOGIX.Core.Extensions.NumberExtensions.#cctor')
  - [AsDecimal(value)](#M-xyLOGIX-Core-Extensions-NumberExtensions-AsDecimal-System-Double- 'xyLOGIX.Core.Extensions.NumberExtensions.AsDecimal(System.Double)')
  - [AsDecimal(value)](#M-xyLOGIX-Core-Extensions-NumberExtensions-AsDecimal-System-Nullable{System-Double}- 'xyLOGIX.Core.Extensions.NumberExtensions.AsDecimal(System.Nullable{System.Double})')
  - [AsDecimal(value)](#M-xyLOGIX-Core-Extensions-NumberExtensions-AsDecimal-System-Nullable{System-Int64}- 'xyLOGIX.Core.Extensions.NumberExtensions.AsDecimal(System.Nullable{System.Int64})')
  - [FloorOf(value,floorValue)](#M-xyLOGIX-Core-Extensions-NumberExtensions-FloorOf-System-Int32,System-Int32- 'xyLOGIX.Core.Extensions.NumberExtensions.FloorOf(System.Int32,System.Int32)')
  - [IsBetween(value,lowerBound,upperBound)](#M-xyLOGIX-Core-Extensions-NumberExtensions-IsBetween-System-Decimal,System-Decimal,System-Decimal- 'xyLOGIX.Core.Extensions.NumberExtensions.IsBetween(System.Decimal,System.Decimal,System.Decimal)')
  - [IsBetween(value,lowerBound,upperBound)](#M-xyLOGIX-Core-Extensions-NumberExtensions-IsBetween-System-Int32,System-Int32,System-Int32- 'xyLOGIX.Core.Extensions.NumberExtensions.IsBetween(System.Int32,System.Int32,System.Int32)')
  - [IsBetween(value,lowerBound,upperBound)](#M-xyLOGIX-Core-Extensions-NumberExtensions-IsBetween-System-Int64,System-Int64,System-Int64- 'xyLOGIX.Core.Extensions.NumberExtensions.IsBetween(System.Int64,System.Int64,System.Int64)')
  - [IsInRangeWithLowerBound(value,lowerBound,upperBound)](#M-xyLOGIX-Core-Extensions-NumberExtensions-IsInRangeWithLowerBound-System-Int32,System-Int32,System-Int32- 'xyLOGIX.Core.Extensions.NumberExtensions.IsInRangeWithLowerBound(System.Int32,System.Int32,System.Int32)')
  - [IsInRangeWithUpperBound(value,lowerBound,upperBound)](#M-xyLOGIX-Core-Extensions-NumberExtensions-IsInRangeWithUpperBound-System-Int32,System-Int32,System-Int32- 'xyLOGIX.Core.Extensions.NumberExtensions.IsInRangeWithUpperBound(System.Int32,System.Int32,System.Int32)')
  - [IsIncludedInRange(value,lowerBound,upperBound)](#M-xyLOGIX-Core-Extensions-NumberExtensions-IsIncludedInRange-System-Decimal,System-Decimal,System-Decimal- 'xyLOGIX.Core.Extensions.NumberExtensions.IsIncludedInRange(System.Decimal,System.Decimal,System.Decimal)')
  - [IsIncludedInRange(value,lowerBound,upperBound)](#M-xyLOGIX-Core-Extensions-NumberExtensions-IsIncludedInRange-System-Int32,System-Int32,System-Int32- 'xyLOGIX.Core.Extensions.NumberExtensions.IsIncludedInRange(System.Int32,System.Int32,System.Int32)')
  - [IsNaturalNumber(value)](#M-xyLOGIX-Core-Extensions-NumberExtensions-IsNaturalNumber-System-Int32- 'xyLOGIX.Core.Extensions.NumberExtensions.IsNaturalNumber(System.Int32)')
  - [IsNegative(value)](#M-xyLOGIX-Core-Extensions-NumberExtensions-IsNegative-System-Decimal- 'xyLOGIX.Core.Extensions.NumberExtensions.IsNegative(System.Decimal)')
  - [IsNegative(value)](#M-xyLOGIX-Core-Extensions-NumberExtensions-IsNegative-System-Int32- 'xyLOGIX.Core.Extensions.NumberExtensions.IsNegative(System.Int32)')
  - [IsNonNegative(value)](#M-xyLOGIX-Core-Extensions-NumberExtensions-IsNonNegative-System-Decimal- 'xyLOGIX.Core.Extensions.NumberExtensions.IsNonNegative(System.Decimal)')
  - [IsNonNegative(value)](#M-xyLOGIX-Core-Extensions-NumberExtensions-IsNonNegative-System-Int32- 'xyLOGIX.Core.Extensions.NumberExtensions.IsNonNegative(System.Int32)')
  - [IsNonPositive(value)](#M-xyLOGIX-Core-Extensions-NumberExtensions-IsNonPositive-System-Decimal- 'xyLOGIX.Core.Extensions.NumberExtensions.IsNonPositive(System.Decimal)')
  - [IsNonPositive(value)](#M-xyLOGIX-Core-Extensions-NumberExtensions-IsNonPositive-System-Int32- 'xyLOGIX.Core.Extensions.NumberExtensions.IsNonPositive(System.Int32)')
  - [IsNonzero(value)](#M-xyLOGIX-Core-Extensions-NumberExtensions-IsNonzero-System-Decimal- 'xyLOGIX.Core.Extensions.NumberExtensions.IsNonzero(System.Decimal)')
  - [IsNonzero(value)](#M-xyLOGIX-Core-Extensions-NumberExtensions-IsNonzero-System-Double- 'xyLOGIX.Core.Extensions.NumberExtensions.IsNonzero(System.Double)')
  - [IsPositive(value)](#M-xyLOGIX-Core-Extensions-NumberExtensions-IsPositive-System-Int32- 'xyLOGIX.Core.Extensions.NumberExtensions.IsPositive(System.Int32)')
  - [IsPositive(value)](#M-xyLOGIX-Core-Extensions-NumberExtensions-IsPositive-System-Decimal- 'xyLOGIX.Core.Extensions.NumberExtensions.IsPositive(System.Decimal)')
  - [IsPositive(value)](#M-xyLOGIX-Core-Extensions-NumberExtensions-IsPositive-System-Double- 'xyLOGIX.Core.Extensions.NumberExtensions.IsPositive(System.Double)')
  - [IsZero(value)](#M-xyLOGIX-Core-Extensions-NumberExtensions-IsZero-System-Decimal- 'xyLOGIX.Core.Extensions.NumberExtensions.IsZero(System.Decimal)')
  - [ToNearestCent(value)](#M-xyLOGIX-Core-Extensions-NumberExtensions-ToNearestCent-System-Decimal- 'xyLOGIX.Core.Extensions.NumberExtensions.ToNearestCent(System.Decimal)')
  - [TruncateDecimalPlaces(val,places)](#M-xyLOGIX-Core-Extensions-NumberExtensions-TruncateDecimalPlaces-System-Decimal,System-Int32- 'xyLOGIX.Core.Extensions.NumberExtensions.TruncateDecimalPlaces(System.Decimal,System.Int32)')
  - [ZeroFloor(value)](#M-xyLOGIX-Core-Extensions-NumberExtensions-ZeroFloor-System-Int32- 'xyLOGIX.Core.Extensions.NumberExtensions.ZeroFloor(System.Int32)')
  - [ZeroFloor(value)](#M-xyLOGIX-Core-Extensions-NumberExtensions-ZeroFloor-System-Double- 'xyLOGIX.Core.Extensions.NumberExtensions.ZeroFloor(System.Double)')
  - [ZeroFloor(value)](#M-xyLOGIX-Core-Extensions-NumberExtensions-ZeroFloor-System-Decimal- 'xyLOGIX.Core.Extensions.NumberExtensions.ZeroFloor(System.Decimal)')
- [ObjectExtensions](#T-xyLOGIX-Core-Extensions-ObjectExtensions 'xyLOGIX.Core.Extensions.ObjectExtensions')
  - [#cctor()](#M-xyLOGIX-Core-Extensions-ObjectExtensions-#cctor 'xyLOGIX.Core.Extensions.ObjectExtensions.#cctor')
  - [ToLogRepresentation(value)](#M-xyLOGIX-Core-Extensions-ObjectExtensions-ToLogRepresentation-System-Object- 'xyLOGIX.Core.Extensions.ObjectExtensions.ToLogRepresentation(System.Object)')
- [PathnameExtensions](#T-xyLOGIX-Core-Extensions-PathnameExtensions 'xyLOGIX.Core.Extensions.PathnameExtensions')
  - [FileExists(pathname)](#M-xyLOGIX-Core-Extensions-PathnameExtensions-FileExists-System-String- 'xyLOGIX.Core.Extensions.PathnameExtensions.FileExists(System.String)')
  - [HasAnyOfTheseExtensions(pathname,extensions)](#M-xyLOGIX-Core-Extensions-PathnameExtensions-HasAnyOfTheseExtensions-System-String,System-String[]- 'xyLOGIX.Core.Extensions.PathnameExtensions.HasAnyOfTheseExtensions(System.String,System.String[])')
  - [HasExtension(pathname,extension)](#M-xyLOGIX-Core-Extensions-PathnameExtensions-HasExtension-System-String,System-String- 'xyLOGIX.Core.Extensions.PathnameExtensions.HasExtension(System.String,System.String)')
- [ReplaceAnyOfOption](#T-xyLOGIX-Core-Extensions-ReplaceAnyOfOption 'xyLOGIX.Core.Extensions.ReplaceAnyOfOption')
  - [All](#F-xyLOGIX-Core-Extensions-ReplaceAnyOfOption-All 'xyLOGIX.Core.Extensions.ReplaceAnyOfOption.All')
  - [First](#F-xyLOGIX-Core-Extensions-ReplaceAnyOfOption-First 'xyLOGIX.Core.Extensions.ReplaceAnyOfOption.First')
  - [Unknown](#F-xyLOGIX-Core-Extensions-ReplaceAnyOfOption-Unknown 'xyLOGIX.Core.Extensions.ReplaceAnyOfOption.Unknown')
- [Resources](#T-xyLOGIX-Core-Extensions-Properties-Resources 'xyLOGIX.Core.Extensions.Properties.Resources')
  - [Culture](#P-xyLOGIX-Core-Extensions-Properties-Resources-Culture 'xyLOGIX.Core.Extensions.Properties.Resources.Culture')
  - [Error_ValueCannotBeNullOrWhiteSpace](#P-xyLOGIX-Core-Extensions-Properties-Resources-Error_ValueCannotBeNullOrWhiteSpace 'xyLOGIX.Core.Extensions.Properties.Resources.Error_ValueCannotBeNullOrWhiteSpace')
  - [NCharsMustBePositive](#P-xyLOGIX-Core-Extensions-Properties-Resources-NCharsMustBePositive 'xyLOGIX.Core.Extensions.Properties.Resources.NCharsMustBePositive')
  - [PersonNameEmpty](#P-xyLOGIX-Core-Extensions-Properties-Resources-PersonNameEmpty 'xyLOGIX.Core.Extensions.Properties.Resources.PersonNameEmpty')
  - [PersonNameIncorrectFormat](#P-xyLOGIX-Core-Extensions-Properties-Resources-PersonNameIncorrectFormat 'xyLOGIX.Core.Extensions.Properties.Resources.PersonNameIncorrectFormat')
  - [ResourceManager](#P-xyLOGIX-Core-Extensions-Properties-Resources-ResourceManager 'xyLOGIX.Core.Extensions.Properties.Resources.ResourceManager')
  - [StringExtensions_Left_CountMustBeLessThanOrEqualToLengthOfString](#P-xyLOGIX-Core-Extensions-Properties-Resources-StringExtensions_Left_CountMustBeLessThanOrEqualToLengthOfString 'xyLOGIX.Core.Extensions.Properties.Resources.StringExtensions_Left_CountMustBeLessThanOrEqualToLengthOfString')
  - [StringExtensions_Left_CountMustBeNaturalNumber](#P-xyLOGIX-Core-Extensions-Properties-Resources-StringExtensions_Left_CountMustBeNaturalNumber 'xyLOGIX.Core.Extensions.Properties.Resources.StringExtensions_Left_CountMustBeNaturalNumber')
- [SetExtensions](#T-xyLOGIX-Core-Extensions-SetExtensions 'xyLOGIX.Core.Extensions.SetExtensions')
  - [#cctor()](#M-xyLOGIX-Core-Extensions-SetExtensions-#cctor 'xyLOGIX.Core.Extensions.SetExtensions.#cctor')
  - [AddRange\`\`1(target,source)](#M-xyLOGIX-Core-Extensions-SetExtensions-AddRange``1-System-Collections-Generic-ISet{``0},System-Collections-Generic-IEnumerable{``0}- 'xyLOGIX.Core.Extensions.SetExtensions.AddRange``1(System.Collections.Generic.ISet{``0},System.Collections.Generic.IEnumerable{``0})')
- [StringArrayExtensions](#T-xyLOGIX-Core-Extensions-StringArrayExtensions 'xyLOGIX.Core.Extensions.StringArrayExtensions')
  - [#cctor()](#M-xyLOGIX-Core-Extensions-StringArrayExtensions-#cctor 'xyLOGIX.Core.Extensions.StringArrayExtensions.#cctor')
  - [DumpToLog(values)](#M-xyLOGIX-Core-Extensions-StringArrayExtensions-DumpToLog-System-String[]- 'xyLOGIX.Core.Extensions.StringArrayExtensions.DumpToLog(System.String[])')
- [StringExtensions](#T-xyLOGIX-Core-Extensions-StringExtensions 'xyLOGIX.Core.Extensions.StringExtensions')
  - [AcronymList](#F-xyLOGIX-Core-Extensions-StringExtensions-AcronymList 'xyLOGIX.Core.Extensions.StringExtensions.AcronymList')
  - [AcronymPattern](#F-xyLOGIX-Core-Extensions-StringExtensions-AcronymPattern 'xyLOGIX.Core.Extensions.StringExtensions.AcronymPattern')
  - [AlwaysCapitalizeIfFirstWord](#F-xyLOGIX-Core-Extensions-StringExtensions-AlwaysCapitalizeIfFirstWord 'xyLOGIX.Core.Extensions.StringExtensions.AlwaysCapitalizeIfFirstWord')
  - [CapitalizeableAsFirstWords](#F-xyLOGIX-Core-Extensions-StringExtensions-CapitalizeableAsFirstWords 'xyLOGIX.Core.Extensions.StringExtensions.CapitalizeableAsFirstWords')
  - [ErrorPrefix](#F-xyLOGIX-Core-Extensions-StringExtensions-ErrorPrefix 'xyLOGIX.Core.Extensions.StringExtensions.ErrorPrefix')
  - [GuidRegexLowercaseNoBraces](#F-xyLOGIX-Core-Extensions-StringExtensions-GuidRegexLowercaseNoBraces 'xyLOGIX.Core.Extensions.StringExtensions.GuidRegexLowercaseNoBraces')
  - [NamesOfStreetsThatShouldBeCapitalized](#F-xyLOGIX-Core-Extensions-StringExtensions-NamesOfStreetsThatShouldBeCapitalized 'xyLOGIX.Core.Extensions.StringExtensions.NamesOfStreetsThatShouldBeCapitalized')
  - [ShortWordsThatAreNotAcronyms](#F-xyLOGIX-Core-Extensions-StringExtensions-ShortWordsThatAreNotAcronyms 'xyLOGIX.Core.Extensions.StringExtensions.ShortWordsThatAreNotAcronyms')
  - [StateAbbrList](#F-xyLOGIX-Core-Extensions-StringExtensions-StateAbbrList 'xyLOGIX.Core.Extensions.StringExtensions.StateAbbrList')
  - [_textInfoFromCurrentCulture](#F-xyLOGIX-Core-Extensions-StringExtensions-_textInfoFromCurrentCulture 'xyLOGIX.Core.Extensions.StringExtensions._textInfoFromCurrentCulture')
  - [EndsWithColonAndNumberRegex](#P-xyLOGIX-Core-Extensions-StringExtensions-EndsWithColonAndNumberRegex 'xyLOGIX.Core.Extensions.StringExtensions.EndsWithColonAndNumberRegex')
  - [IsEmailAddressInvalid](#P-xyLOGIX-Core-Extensions-StringExtensions-IsEmailAddressInvalid 'xyLOGIX.Core.Extensions.StringExtensions.IsEmailAddressInvalid')
  - [LanguageArticleTypeValidator](#P-xyLOGIX-Core-Extensions-StringExtensions-LanguageArticleTypeValidator 'xyLOGIX.Core.Extensions.StringExtensions.LanguageArticleTypeValidator')
  - [PluralizationService](#P-xyLOGIX-Core-Extensions-StringExtensions-PluralizationService 'xyLOGIX.Core.Extensions.StringExtensions.PluralizationService')
  - [WhiteSpaceRegex](#P-xyLOGIX-Core-Extensions-StringExtensions-WhiteSpaceRegex 'xyLOGIX.Core.Extensions.StringExtensions.WhiteSpaceRegex')
  - [#cctor()](#M-xyLOGIX-Core-Extensions-StringExtensions-#cctor 'xyLOGIX.Core.Extensions.StringExtensions.#cctor')
  - [AnyContainNoCase(collection,value)](#M-xyLOGIX-Core-Extensions-StringExtensions-AnyContainNoCase-System-Collections-Generic-IEnumerable{System-String},System-String- 'xyLOGIX.Core.Extensions.StringExtensions.AnyContainNoCase(System.Collections.Generic.IEnumerable{System.String},System.String)')
  - [AnyStartWithAny(targets,values)](#M-xyLOGIX-Core-Extensions-StringExtensions-AnyStartWithAny-System-Collections-Generic-IEnumerable{System-String},System-String[]- 'xyLOGIX.Core.Extensions.StringExtensions.AnyStartWithAny(System.Collections.Generic.IEnumerable{System.String},System.String[])')
  - [AreAnyLettersLowercase(value)](#M-xyLOGIX-Core-Extensions-StringExtensions-AreAnyLettersLowercase-System-String- 'xyLOGIX.Core.Extensions.StringExtensions.AreAnyLettersLowercase(System.String)')
  - [AsCodeElement(text)](#M-xyLOGIX-Core-Extensions-StringExtensions-AsCodeElement-System-String- 'xyLOGIX.Core.Extensions.StringExtensions.AsCodeElement(System.String)')
  - [AsDecimal(value)](#M-xyLOGIX-Core-Extensions-StringExtensions-AsDecimal-System-String- 'xyLOGIX.Core.Extensions.StringExtensions.AsDecimal(System.String)')
  - [AsDouble(value)](#M-xyLOGIX-Core-Extensions-StringExtensions-AsDouble-System-String- 'xyLOGIX.Core.Extensions.StringExtensions.AsDouble(System.String)')
  - [AsProseList\`\`1(quote,selectorFunc)](#M-xyLOGIX-Core-Extensions-StringExtensions-AsProseList``1-System-Collections-Generic-IEnumerable{``0},System-Func{``0,System-String}- 'xyLOGIX.Core.Extensions.StringExtensions.AsProseList``1(System.Collections.Generic.IEnumerable{``0},System.Func{``0,System.String})')
  - [BreakTextIntoLines(text)](#M-xyLOGIX-Core-Extensions-StringExtensions-BreakTextIntoLines-System-String- 'xyLOGIX.Core.Extensions.StringExtensions.BreakTextIntoLines(System.String)')
  - [CleanLine(line)](#M-xyLOGIX-Core-Extensions-StringExtensions-CleanLine-System-String- 'xyLOGIX.Core.Extensions.StringExtensions.CleanLine(System.String)')
  - [CollapseNewlinesToSpaces(value)](#M-xyLOGIX-Core-Extensions-StringExtensions-CollapseNewlinesToSpaces-System-String- 'xyLOGIX.Core.Extensions.StringExtensions.CollapseNewlinesToSpaces(System.String)')
  - [Concat(initialString,parts)](#M-xyLOGIX-Core-Extensions-StringExtensions-Concat-System-String,System-String[]- 'xyLOGIX.Core.Extensions.StringExtensions.Concat(System.String,System.String[])')
  - [Contains(source,value,comparisonType)](#M-xyLOGIX-Core-Extensions-StringExtensions-Contains-System-String,System-String,System-StringComparison- 'xyLOGIX.Core.Extensions.StringExtensions.Contains(System.String,System.String,System.StringComparison)')
  - [ContainsAny(value,searchStrings)](#M-xyLOGIX-Core-Extensions-StringExtensions-ContainsAny-System-String,System-String[]- 'xyLOGIX.Core.Extensions.StringExtensions.ContainsAny(System.String,System.String[])')
  - [ContainsAny(value,searchStrings)](#M-xyLOGIX-Core-Extensions-StringExtensions-ContainsAny-System-String,System-Collections-Generic-IEnumerable{System-String}- 'xyLOGIX.Core.Extensions.StringExtensions.ContainsAny(System.String,System.Collections.Generic.IEnumerable{System.String})')
  - [ContainsAny(value,searchChars)](#M-xyLOGIX-Core-Extensions-StringExtensions-ContainsAny-System-String,System-Char[]- 'xyLOGIX.Core.Extensions.StringExtensions.ContainsAny(System.String,System.Char[])')
  - [ContainsAnyOf(value,searchStrings)](#M-xyLOGIX-Core-Extensions-StringExtensions-ContainsAnyOf-System-String,System-Collections-Generic-IEnumerable{System-String}- 'xyLOGIX.Core.Extensions.StringExtensions.ContainsAnyOf(System.String,System.Collections.Generic.IEnumerable{System.String})')
  - [ContainsAnyOf(value,searchStrings)](#M-xyLOGIX-Core-Extensions-StringExtensions-ContainsAnyOf-System-String,System-String[]- 'xyLOGIX.Core.Extensions.StringExtensions.ContainsAnyOf(System.String,System.String[])')
  - [ContainsAnyOf(value,searchChars)](#M-xyLOGIX-Core-Extensions-StringExtensions-ContainsAnyOf-System-String,System-Char[]- 'xyLOGIX.Core.Extensions.StringExtensions.ContainsAnyOf(System.String,System.Char[])')
  - [ContainsNamespaceSeparator(value)](#M-xyLOGIX-Core-Extensions-StringExtensions-ContainsNamespaceSeparator-System-String- 'xyLOGIX.Core.Extensions.StringExtensions.ContainsNamespaceSeparator(System.String)')
  - [ContainsNoCase(stringToSearch,value)](#M-xyLOGIX-Core-Extensions-StringExtensions-ContainsNoCase-System-String,System-String- 'xyLOGIX.Core.Extensions.StringExtensions.ContainsNoCase(System.String,System.String)')
  - [ContainsNoCase(stringToSearch,value)](#M-xyLOGIX-Core-Extensions-StringExtensions-ContainsNoCase-System-String,System-Char- 'xyLOGIX.Core.Extensions.StringExtensions.ContainsNoCase(System.String,System.Char)')
  - [ContainsNoCase(collection,value)](#M-xyLOGIX-Core-Extensions-StringExtensions-ContainsNoCase-System-Collections-Generic-IEnumerable{System-String},System-String- 'xyLOGIX.Core.Extensions.StringExtensions.ContainsNoCase(System.Collections.Generic.IEnumerable{System.String},System.String)')
  - [ContainsNumbers(value)](#M-xyLOGIX-Core-Extensions-StringExtensions-ContainsNumbers-System-String- 'xyLOGIX.Core.Extensions.StringExtensions.ContainsNumbers(System.String)')
  - [ContainsWhitespace(value)](#M-xyLOGIX-Core-Extensions-StringExtensions-ContainsWhitespace-System-String- 'xyLOGIX.Core.Extensions.StringExtensions.ContainsWhitespace(System.String)')
  - [DoInitialCaps(value)](#M-xyLOGIX-Core-Extensions-StringExtensions-DoInitialCaps-System-String- 'xyLOGIX.Core.Extensions.StringExtensions.DoInitialCaps(System.String)')
  - [DomainMapper(match)](#M-xyLOGIX-Core-Extensions-StringExtensions-DomainMapper-System-Text-RegularExpressions-Match- 'xyLOGIX.Core.Extensions.StringExtensions.DomainMapper(System.Text.RegularExpressions.Match)')
  - [EndsWithAny(value,endings)](#M-xyLOGIX-Core-Extensions-StringExtensions-EndsWithAny-System-String,System-String[]- 'xyLOGIX.Core.Extensions.StringExtensions.EndsWithAny(System.String,System.String[])')
  - [EndsWithAny(value,comparisonType,endings)](#M-xyLOGIX-Core-Extensions-StringExtensions-EndsWithAny-System-String,System-StringComparison,System-String[]- 'xyLOGIX.Core.Extensions.StringExtensions.EndsWithAny(System.String,System.StringComparison,System.String[])')
  - [EndsWithAny(value,endings)](#M-xyLOGIX-Core-Extensions-StringExtensions-EndsWithAny-System-String,System-Collections-Generic-IEnumerable{System-String}- 'xyLOGIX.Core.Extensions.StringExtensions.EndsWithAny(System.String,System.Collections.Generic.IEnumerable{System.String})')
  - [EndsWithAny(value,comparisonType,endings)](#M-xyLOGIX-Core-Extensions-StringExtensions-EndsWithAny-System-String,System-StringComparison,System-Collections-Generic-IEnumerable{System-String}- 'xyLOGIX.Core.Extensions.StringExtensions.EndsWithAny(System.String,System.StringComparison,System.Collections.Generic.IEnumerable{System.String})')
  - [EndsWithAnyOf(value,endings)](#M-xyLOGIX-Core-Extensions-StringExtensions-EndsWithAnyOf-System-String,System-String[]- 'xyLOGIX.Core.Extensions.StringExtensions.EndsWithAnyOf(System.String,System.String[])')
  - [EndsWithAnyOf(value,comparisonType,endings)](#M-xyLOGIX-Core-Extensions-StringExtensions-EndsWithAnyOf-System-String,System-StringComparison,System-String[]- 'xyLOGIX.Core.Extensions.StringExtensions.EndsWithAnyOf(System.String,System.StringComparison,System.String[])')
  - [EndsWithColonAndNumber(value)](#M-xyLOGIX-Core-Extensions-StringExtensions-EndsWithColonAndNumber-System-String- 'xyLOGIX.Core.Extensions.StringExtensions.EndsWithColonAndNumber(System.String)')
  - [EnsureAtIsInFront(twitterSite)](#M-xyLOGIX-Core-Extensions-StringExtensions-EnsureAtIsInFront-System-String- 'xyLOGIX.Core.Extensions.StringExtensions.EnsureAtIsInFront(System.String)')
  - [EqualsAnyOf(value,list)](#M-xyLOGIX-Core-Extensions-StringExtensions-EqualsAnyOf-System-String,System-String[]- 'xyLOGIX.Core.Extensions.StringExtensions.EqualsAnyOf(System.String,System.String[])')
  - [EqualsAnyOfNoCase(value,list)](#M-xyLOGIX-Core-Extensions-StringExtensions-EqualsAnyOfNoCase-System-String,System-String[]- 'xyLOGIX.Core.Extensions.StringExtensions.EqualsAnyOfNoCase(System.String,System.String[])')
  - [EqualsNoCase(str1,str2)](#M-xyLOGIX-Core-Extensions-StringExtensions-EqualsNoCase-System-String,System-String- 'xyLOGIX.Core.Extensions.StringExtensions.EqualsNoCase(System.String,System.String)')
  - [EqualsNoCase(str1,str2,comparisonType)](#M-xyLOGIX-Core-Extensions-StringExtensions-EqualsNoCase-System-String,System-String,System-StringComparison- 'xyLOGIX.Core.Extensions.StringExtensions.EqualsNoCase(System.String,System.String,System.StringComparison)')
  - [EscapePowerShellNewline(value)](#M-xyLOGIX-Core-Extensions-StringExtensions-EscapePowerShellNewline-System-String- 'xyLOGIX.Core.Extensions.StringExtensions.EscapePowerShellNewline(System.String)')
  - [EscapePowerShellQuotes(value)](#M-xyLOGIX-Core-Extensions-StringExtensions-EscapePowerShellQuotes-System-String- 'xyLOGIX.Core.Extensions.StringExtensions.EscapePowerShellQuotes(System.String)')
  - [ExcludingWhitespace(value)](#M-xyLOGIX-Core-Extensions-StringExtensions-ExcludingWhitespace-System-String- 'xyLOGIX.Core.Extensions.StringExtensions.ExcludingWhitespace(System.String)')
  - [ExtractUpToColon(value)](#M-xyLOGIX-Core-Extensions-StringExtensions-ExtractUpToColon-System-String- 'xyLOGIX.Core.Extensions.StringExtensions.ExtractUpToColon(System.String)')
  - [FirstOrNotEmpty(val1,val2)](#M-xyLOGIX-Core-Extensions-StringExtensions-FirstOrNotEmpty-System-String,System-String- 'xyLOGIX.Core.Extensions.StringExtensions.FirstOrNotEmpty(System.String,System.String)')
  - [FormatAsHtml(content)](#M-xyLOGIX-Core-Extensions-StringExtensions-FormatAsHtml-System-String- 'xyLOGIX.Core.Extensions.StringExtensions.FormatAsHtml(System.String)')
  - [FormatLikePython(value,args)](#M-xyLOGIX-Core-Extensions-StringExtensions-FormatLikePython-System-String,System-Object[]- 'xyLOGIX.Core.Extensions.StringExtensions.FormatLikePython(System.String,System.Object[])')
  - [GetCompactedString(stringToCompact,font,maxWidth)](#M-xyLOGIX-Core-Extensions-StringExtensions-GetCompactedString-System-String,System-Drawing-Font,System-Int32- 'xyLOGIX.Core.Extensions.StringExtensions.GetCompactedString(System.String,System.Drawing.Font,System.Int32)')
  - [GetDottedSuffix(value,includingDot)](#M-xyLOGIX-Core-Extensions-StringExtensions-GetDottedSuffix-System-String,System-Boolean- 'xyLOGIX.Core.Extensions.StringExtensions.GetDottedSuffix(System.String,System.Boolean)')
  - [GetFirstNChars(value,nChars)](#M-xyLOGIX-Core-Extensions-StringExtensions-GetFirstNChars-System-String,System-Int32- 'xyLOGIX.Core.Extensions.StringExtensions.GetFirstNChars(System.String,System.Int32)')
  - [GetFirstNonBlankLine(value)](#M-xyLOGIX-Core-Extensions-StringExtensions-GetFirstNonBlankLine-System-String- 'xyLOGIX.Core.Extensions.StringExtensions.GetFirstNonBlankLine(System.String)')
  - [GetFirstTwoNonBlankLines(value)](#M-xyLOGIX-Core-Extensions-StringExtensions-GetFirstTwoNonBlankLines-System-String- 'xyLOGIX.Core.Extensions.StringExtensions.GetFirstTwoNonBlankLines(System.String)')
  - [GetLanguageArticleText(type,text)](#M-xyLOGIX-Core-Extensions-StringExtensions-GetLanguageArticleText-xyLOGIX-Core-Extensions-LanguageArticleType,System-String- 'xyLOGIX.Core.Extensions.StringExtensions.GetLanguageArticleText(xyLOGIX.Core.Extensions.LanguageArticleType,System.String)')
  - [GetLastWord(input)](#M-xyLOGIX-Core-Extensions-StringExtensions-GetLastWord-System-String- 'xyLOGIX.Core.Extensions.StringExtensions.GetLastWord(System.String)')
  - [GetNonBlankLineCount(value)](#M-xyLOGIX-Core-Extensions-StringExtensions-GetNonBlankLineCount-System-String- 'xyLOGIX.Core.Extensions.StringExtensions.GetNonBlankLineCount(System.String)')
  - [GetPersonFirstName(fullName)](#M-xyLOGIX-Core-Extensions-StringExtensions-GetPersonFirstName-System-String- 'xyLOGIX.Core.Extensions.StringExtensions.GetPersonFirstName(System.String)')
  - [GetPersonLastName(fullName)](#M-xyLOGIX-Core-Extensions-StringExtensions-GetPersonLastName-System-String- 'xyLOGIX.Core.Extensions.StringExtensions.GetPersonLastName(System.String)')
  - [IsAbsolutePath(path)](#M-xyLOGIX-Core-Extensions-StringExtensions-IsAbsolutePath-System-String- 'xyLOGIX.Core.Extensions.StringExtensions.IsAbsolutePath(System.String)')
  - [IsAcronymOrStateAbbr(array,i)](#M-xyLOGIX-Core-Extensions-StringExtensions-IsAcronymOrStateAbbr-System-Collections-Generic-IList{System-String},System-Int32- 'xyLOGIX.Core.Extensions.StringExtensions.IsAcronymOrStateAbbr(System.Collections.Generic.IList{System.String},System.Int32)')
  - [IsAlphaNumeric(value)](#M-xyLOGIX-Core-Extensions-StringExtensions-IsAlphaNumeric-System-String- 'xyLOGIX.Core.Extensions.StringExtensions.IsAlphaNumeric(System.String)')
  - [IsAlphaNumericLowercase(value)](#M-xyLOGIX-Core-Extensions-StringExtensions-IsAlphaNumericLowercase-System-String- 'xyLOGIX.Core.Extensions.StringExtensions.IsAlphaNumericLowercase(System.String)')
  - [IsAlphaNumericUppercase(value)](#M-xyLOGIX-Core-Extensions-StringExtensions-IsAlphaNumericUppercase-System-String- 'xyLOGIX.Core.Extensions.StringExtensions.IsAlphaNumericUppercase(System.String)')
  - [IsBlankOrNull(value)](#M-xyLOGIX-Core-Extensions-StringExtensions-IsBlankOrNull-System-String- 'xyLOGIX.Core.Extensions.StringExtensions.IsBlankOrNull(System.String)')
  - [IsDecimal(value)](#M-xyLOGIX-Core-Extensions-StringExtensions-IsDecimal-System-String- 'xyLOGIX.Core.Extensions.StringExtensions.IsDecimal(System.String)')
  - [IsFolderPath(path)](#M-xyLOGIX-Core-Extensions-StringExtensions-IsFolderPath-System-String- 'xyLOGIX.Core.Extensions.StringExtensions.IsFolderPath(System.String)')
  - [IsLowercase(value)](#M-xyLOGIX-Core-Extensions-StringExtensions-IsLowercase-System-String- 'xyLOGIX.Core.Extensions.StringExtensions.IsLowercase(System.String)')
  - [IsNumeric(value)](#M-xyLOGIX-Core-Extensions-StringExtensions-IsNumeric-System-String- 'xyLOGIX.Core.Extensions.StringExtensions.IsNumeric(System.String)')
  - [IsOneOf(value,choices)](#M-xyLOGIX-Core-Extensions-StringExtensions-IsOneOf-System-String,System-Collections-Generic-IEnumerable{System-String}- 'xyLOGIX.Core.Extensions.StringExtensions.IsOneOf(System.String,System.Collections.Generic.IEnumerable{System.String})')
  - [IsRomanNumerals(value)](#M-xyLOGIX-Core-Extensions-StringExtensions-IsRomanNumerals-System-String- 'xyLOGIX.Core.Extensions.StringExtensions.IsRomanNumerals(System.String)')
  - [IsSpecialWordAtBeginningOfPhrase(words,currentWord)](#M-xyLOGIX-Core-Extensions-StringExtensions-IsSpecialWordAtBeginningOfPhrase-System-String[],System-String- 'xyLOGIX.Core.Extensions.StringExtensions.IsSpecialWordAtBeginningOfPhrase(System.String[],System.String)')
  - [IsStreetNameComponent(array,i)](#M-xyLOGIX-Core-Extensions-StringExtensions-IsStreetNameComponent-System-Collections-Generic-IReadOnlyList{System-String},System-Int32- 'xyLOGIX.Core.Extensions.StringExtensions.IsStreetNameComponent(System.Collections.Generic.IReadOnlyList{System.String},System.Int32)')
  - [IsUppercase(value)](#M-xyLOGIX-Core-Extensions-StringExtensions-IsUppercase-System-String- 'xyLOGIX.Core.Extensions.StringExtensions.IsUppercase(System.String)')
  - [IsValidAssetSymbol(symbol)](#M-xyLOGIX-Core-Extensions-StringExtensions-IsValidAssetSymbol-System-String- 'xyLOGIX.Core.Extensions.StringExtensions.IsValidAssetSymbol(System.String)')
  - [IsValidEmail(value)](#M-xyLOGIX-Core-Extensions-StringExtensions-IsValidEmail-System-String- 'xyLOGIX.Core.Extensions.StringExtensions.IsValidEmail(System.String)')
  - [IsValidLowercaseGuidWithNoBraces(value)](#M-xyLOGIX-Core-Extensions-StringExtensions-IsValidLowercaseGuidWithNoBraces-System-String- 'xyLOGIX.Core.Extensions.StringExtensions.IsValidLowercaseGuidWithNoBraces(System.String)')
  - [IsVowelSound(text)](#M-xyLOGIX-Core-Extensions-StringExtensions-IsVowelSound-System-String- 'xyLOGIX.Core.Extensions.StringExtensions.IsVowelSound(System.String)')
  - [Join(values,separator)](#M-xyLOGIX-Core-Extensions-StringExtensions-Join-System-Collections-Generic-IList{System-String},System-String- 'xyLOGIX.Core.Extensions.StringExtensions.Join(System.Collections.Generic.IList{System.String},System.String)')
  - [Left(value,count)](#M-xyLOGIX-Core-Extensions-StringExtensions-Left-System-String,System-Int32- 'xyLOGIX.Core.Extensions.StringExtensions.Left(System.String,System.Int32)')
  - [MakeSingular(pluralWord)](#M-xyLOGIX-Core-Extensions-StringExtensions-MakeSingular-System-String- 'xyLOGIX.Core.Extensions.StringExtensions.MakeSingular(System.String)')
  - [MatchesNoCase(stringToSearch,findWhat)](#M-xyLOGIX-Core-Extensions-StringExtensions-MatchesNoCase-System-String,System-String- 'xyLOGIX.Core.Extensions.StringExtensions.MatchesNoCase(System.String,System.String)')
  - [MatchesWithCase(stringToSearch,findWhat)](#M-xyLOGIX-Core-Extensions-StringExtensions-MatchesWithCase-System-String,System-String- 'xyLOGIX.Core.Extensions.StringExtensions.MatchesWithCase(System.String,System.String)')
  - [PluralizeWord(word,culture)](#M-xyLOGIX-Core-Extensions-StringExtensions-PluralizeWord-System-String,System-Globalization-CultureInfo- 'xyLOGIX.Core.Extensions.StringExtensions.PluralizeWord(System.String,System.Globalization.CultureInfo)')
  - [PluralizeWord(word)](#M-xyLOGIX-Core-Extensions-StringExtensions-PluralizeWord-System-String- 'xyLOGIX.Core.Extensions.StringExtensions.PluralizeWord(System.String)')
  - [PostfixFormat(value,args)](#M-xyLOGIX-Core-Extensions-StringExtensions-PostfixFormat-System-String,System-Object[]- 'xyLOGIX.Core.Extensions.StringExtensions.PostfixFormat(System.String,System.Object[])')
  - [PrependBang(value)](#M-xyLOGIX-Core-Extensions-StringExtensions-PrependBang-System-String- 'xyLOGIX.Core.Extensions.StringExtensions.PrependBang(System.String)')
  - [PrependLanguageArticle(value,type)](#M-xyLOGIX-Core-Extensions-StringExtensions-PrependLanguageArticle-System-String,xyLOGIX-Core-Extensions-LanguageArticleType- 'xyLOGIX.Core.Extensions.StringExtensions.PrependLanguageArticle(System.String,xyLOGIX.Core.Extensions.LanguageArticleType)')
  - [RegexMatchesNoCase(stringToSearch,regex)](#M-xyLOGIX-Core-Extensions-StringExtensions-RegexMatchesNoCase-System-String,System-String- 'xyLOGIX.Core.Extensions.StringExtensions.RegexMatchesNoCase(System.String,System.String)')
  - [RegexMatchesWithCase(stringToSearch,regex)](#M-xyLOGIX-Core-Extensions-StringExtensions-RegexMatchesWithCase-System-String,System-String- 'xyLOGIX.Core.Extensions.StringExtensions.RegexMatchesWithCase(System.String,System.String)')
  - [RegexReplaceNoCase(value,search,replacement)](#M-xyLOGIX-Core-Extensions-StringExtensions-RegexReplaceNoCase-System-String,System-String,System-String- 'xyLOGIX.Core.Extensions.StringExtensions.RegexReplaceNoCase(System.String,System.String,System.String)')
  - [RegexReplaceNoCase(value,search,replacement,options)](#M-xyLOGIX-Core-Extensions-StringExtensions-RegexReplaceNoCase-System-String,System-String,System-String,System-Text-RegularExpressions-RegexOptions- 'xyLOGIX.Core.Extensions.StringExtensions.RegexReplaceNoCase(System.String,System.String,System.String,System.Text.RegularExpressions.RegexOptions)')
  - [RegexReplaceWithCase(value,search,replacement)](#M-xyLOGIX-Core-Extensions-StringExtensions-RegexReplaceWithCase-System-String,System-String,System-String- 'xyLOGIX.Core.Extensions.StringExtensions.RegexReplaceWithCase(System.String,System.String,System.String)')
  - [RegexReplaceWithCase(value,search,replacement,options)](#M-xyLOGIX-Core-Extensions-StringExtensions-RegexReplaceWithCase-System-String,System-String,System-String,System-Text-RegularExpressions-RegexOptions- 'xyLOGIX.Core.Extensions.StringExtensions.RegexReplaceWithCase(System.String,System.String,System.String,System.Text.RegularExpressions.RegexOptions)')
  - [RemoveAmpersands(value)](#M-xyLOGIX-Core-Extensions-StringExtensions-RemoveAmpersands-System-String- 'xyLOGIX.Core.Extensions.StringExtensions.RemoveAmpersands(System.String)')
  - [RemoveDigitsAndPunctuation(value)](#M-xyLOGIX-Core-Extensions-StringExtensions-RemoveDigitsAndPunctuation-System-String- 'xyLOGIX.Core.Extensions.StringExtensions.RemoveDigitsAndPunctuation(System.String)')
  - [RemoveErrorPrefix(message)](#M-xyLOGIX-Core-Extensions-StringExtensions-RemoveErrorPrefix-System-String- 'xyLOGIX.Core.Extensions.StringExtensions.RemoveErrorPrefix(System.String)')
  - [RemoveExtraEmptyLines(value)](#M-xyLOGIX-Core-Extensions-StringExtensions-RemoveExtraEmptyLines-System-String- 'xyLOGIX.Core.Extensions.StringExtensions.RemoveExtraEmptyLines(System.String)')
  - [RemoveLastWord(text)](#M-xyLOGIX-Core-Extensions-StringExtensions-RemoveLastWord-System-String- 'xyLOGIX.Core.Extensions.StringExtensions.RemoveLastWord(System.String)')
  - [RemoveTrailingBackslashes(value)](#M-xyLOGIX-Core-Extensions-StringExtensions-RemoveTrailingBackslashes-System-String- 'xyLOGIX.Core.Extensions.StringExtensions.RemoveTrailingBackslashes(System.String)')
  - [Replace(source,oldValue,newValue,comparisonType)](#M-xyLOGIX-Core-Extensions-StringExtensions-Replace-System-String,System-String,System-String,System-StringComparison- 'xyLOGIX.Core.Extensions.StringExtensions.Replace(System.String,System.String,System.String,System.StringComparison)')
  - [Replace(source,oldChar,newChar,comparisonType)](#M-xyLOGIX-Core-Extensions-StringExtensions-Replace-System-String,System-Char,System-Char,System-StringComparison- 'xyLOGIX.Core.Extensions.StringExtensions.Replace(System.String,System.Char,System.Char,System.StringComparison)')
  - [ReplaceAnyOf(source,findWhatValues,replacementText,option)](#M-xyLOGIX-Core-Extensions-StringExtensions-ReplaceAnyOf-System-String,System-Collections-Generic-ICollection{System-String},System-String,xyLOGIX-Core-Extensions-ReplaceAnyOfOption- 'xyLOGIX.Core.Extensions.StringExtensions.ReplaceAnyOf(System.String,System.Collections.Generic.ICollection{System.String},System.String,xyLOGIX.Core.Extensions.ReplaceAnyOfOption)')
  - [ReplaceCopyrightSymbolWithEscapeSequence(value)](#M-xyLOGIX-Core-Extensions-StringExtensions-ReplaceCopyrightSymbolWithEscapeSequence-System-String- 'xyLOGIX.Core.Extensions.StringExtensions.ReplaceCopyrightSymbolWithEscapeSequence(System.String)')
  - [ReplaceNoCase(value,search,replacement)](#M-xyLOGIX-Core-Extensions-StringExtensions-ReplaceNoCase-System-String,System-String,System-String- 'xyLOGIX.Core.Extensions.StringExtensions.ReplaceNoCase(System.String,System.String,System.String)')
  - [ReplaceSingleQuotesWithHTMLApostrophes(inputString)](#M-xyLOGIX-Core-Extensions-StringExtensions-ReplaceSingleQuotesWithHTMLApostrophes-System-String- 'xyLOGIX.Core.Extensions.StringExtensions.ReplaceSingleQuotesWithHTMLApostrophes(System.String)')
  - [ReplaceSpacesWithHtmlNonBreakingSpace(inputString)](#M-xyLOGIX-Core-Extensions-StringExtensions-ReplaceSpacesWithHtmlNonBreakingSpace-System-String- 'xyLOGIX.Core.Extensions.StringExtensions.ReplaceSpacesWithHtmlNonBreakingSpace(System.String)')
  - [RewordAsTypeOfPhrase(phrase,languageArticle,pluralizeRemainder,culture)](#M-xyLOGIX-Core-Extensions-StringExtensions-RewordAsTypeOfPhrase-System-String,xyLOGIX-Core-Extensions-LanguageArticleType,System-Boolean,System-Globalization-CultureInfo- 'xyLOGIX.Core.Extensions.StringExtensions.RewordAsTypeOfPhrase(System.String,xyLOGIX.Core.Extensions.LanguageArticleType,System.Boolean,System.Globalization.CultureInfo)')
  - [SplitOn(value,delimiter)](#M-xyLOGIX-Core-Extensions-StringExtensions-SplitOn-System-String,System-String- 'xyLOGIX.Core.Extensions.StringExtensions.SplitOn(System.String,System.String)')
  - [StartsWithAny(value,beginnings)](#M-xyLOGIX-Core-Extensions-StringExtensions-StartsWithAny-System-String,System-String[]- 'xyLOGIX.Core.Extensions.StringExtensions.StartsWithAny(System.String,System.String[])')
  - [StartsWithAnyOf(text,list)](#M-xyLOGIX-Core-Extensions-StringExtensions-StartsWithAnyOf-System-String,System-String[]- 'xyLOGIX.Core.Extensions.StringExtensions.StartsWithAnyOf(System.String,System.String[])')
  - [StartsWithNoCase(value,searchText)](#M-xyLOGIX-Core-Extensions-StringExtensions-StartsWithNoCase-System-String,System-String- 'xyLOGIX.Core.Extensions.StringExtensions.StartsWithNoCase(System.String,System.String)')
  - [StripIncompatibleQuotes(inputString)](#M-xyLOGIX-Core-Extensions-StringExtensions-StripIncompatibleQuotes-System-String- 'xyLOGIX.Core.Extensions.StringExtensions.StripIncompatibleQuotes(System.String)')
  - [StripNewlines(value)](#M-xyLOGIX-Core-Extensions-StringExtensions-StripNewlines-System-String- 'xyLOGIX.Core.Extensions.StringExtensions.StripNewlines(System.String)')
  - [Sub(format,args)](#M-xyLOGIX-Core-Extensions-StringExtensions-Sub-System-String,System-Object[]- 'xyLOGIX.Core.Extensions.StringExtensions.Sub(System.String,System.Object[])')
  - [Suffix(value,suffix)](#M-xyLOGIX-Core-Extensions-StringExtensions-Suffix-System-String,System-String- 'xyLOGIX.Core.Extensions.StringExtensions.Suffix(System.String,System.String)')
  - [ToASCII(value)](#M-xyLOGIX-Core-Extensions-StringExtensions-ToASCII-System-String- 'xyLOGIX.Core.Extensions.StringExtensions.ToASCII(System.String)')
  - [ToAcronym(phrase)](#M-xyLOGIX-Core-Extensions-StringExtensions-ToAcronym-System-String- 'xyLOGIX.Core.Extensions.StringExtensions.ToAcronym(System.String)')
  - [ToAcronymLetter(word)](#M-xyLOGIX-Core-Extensions-StringExtensions-ToAcronymLetter-System-String- 'xyLOGIX.Core.Extensions.StringExtensions.ToAcronymLetter(System.String)')
  - [ToCodeElementPreservingPluralization(text)](#M-xyLOGIX-Core-Extensions-StringExtensions-ToCodeElementPreservingPluralization-System-String- 'xyLOGIX.Core.Extensions.StringExtensions.ToCodeElementPreservingPluralization(System.String)')
  - [ToGuidWithNoPunctuation(guid)](#M-xyLOGIX-Core-Extensions-StringExtensions-ToGuidWithNoPunctuation-System-Guid- 'xyLOGIX.Core.Extensions.StringExtensions.ToGuidWithNoPunctuation(System.Guid)')
  - [ToInitialCaps(value)](#M-xyLOGIX-Core-Extensions-StringExtensions-ToInitialCaps-System-String- 'xyLOGIX.Core.Extensions.StringExtensions.ToInitialCaps(System.String)')
  - [ToLanguageArticle(value,type)](#M-xyLOGIX-Core-Extensions-StringExtensions-ToLanguageArticle-System-String,xyLOGIX-Core-Extensions-LanguageArticleType- 'xyLOGIX.Core.Extensions.StringExtensions.ToLanguageArticle(System.String,xyLOGIX.Core.Extensions.LanguageArticleType)')
  - [ToList(quote,separators)](#M-xyLOGIX-Core-Extensions-StringExtensions-ToList-System-String,System-String[]- 'xyLOGIX.Core.Extensions.StringExtensions.ToList(System.String,System.String[])')
  - [ToLowercase(value)](#M-xyLOGIX-Core-Extensions-StringExtensions-ToLowercase-System-String- 'xyLOGIX.Core.Extensions.StringExtensions.ToLowercase(System.String)')
  - [ToPhrase(value)](#M-xyLOGIX-Core-Extensions-StringExtensions-ToPhrase-System-String- 'xyLOGIX.Core.Extensions.StringExtensions.ToPhrase(System.String)')
  - [ToPhraseInTitleCase(value)](#M-xyLOGIX-Core-Extensions-StringExtensions-ToPhraseInTitleCase-System-String- 'xyLOGIX.Core.Extensions.StringExtensions.ToPhraseInTitleCase(System.String)')
  - [ToSolutionFileEntryFormat(pathname)](#M-xyLOGIX-Core-Extensions-StringExtensions-ToSolutionFileEntryFormat-System-String- 'xyLOGIX.Core.Extensions.StringExtensions.ToSolutionFileEntryFormat(System.String)')
  - [ToTitleCase(value)](#M-xyLOGIX-Core-Extensions-StringExtensions-ToTitleCase-System-String- 'xyLOGIX.Core.Extensions.StringExtensions.ToTitleCase(System.String)')
  - [ToUnicode(value)](#M-xyLOGIX-Core-Extensions-StringExtensions-ToUnicode-System-String- 'xyLOGIX.Core.Extensions.StringExtensions.ToUnicode(System.String)')
  - [ToUppercase(value)](#M-xyLOGIX-Core-Extensions-StringExtensions-ToUppercase-System-String- 'xyLOGIX.Core.Extensions.StringExtensions.ToUppercase(System.String)')
  - [TrimAnyOffEnd(value,caseSensitive,recursive,badEndings)](#M-xyLOGIX-Core-Extensions-StringExtensions-TrimAnyOffEnd-System-String,System-Boolean,System-Boolean,System-String[]- 'xyLOGIX.Core.Extensions.StringExtensions.TrimAnyOffEnd(System.String,System.Boolean,System.Boolean,System.String[])')
  - [TrimLine(currentLine)](#M-xyLOGIX-Core-Extensions-StringExtensions-TrimLine-System-String- 'xyLOGIX.Core.Extensions.StringExtensions.TrimLine(System.String)')
- [TextBoxExtensions](#T-xyLOGIX-Core-Extensions-TextBoxExtensions 'xyLOGIX.Core.Extensions.TextBoxExtensions')
  - [EM_SETCUEBANNER](#F-xyLOGIX-Core-Extensions-TextBoxExtensions-EM_SETCUEBANNER 'xyLOGIX.Core.Extensions.TextBoxExtensions.EM_SETCUEBANNER')
  - [IsWindow(hWnd)](#M-xyLOGIX-Core-Extensions-TextBoxExtensions-IsWindow-System-IntPtr- 'xyLOGIX.Core.Extensions.TextBoxExtensions.IsWindow(System.IntPtr)')
  - [SendMessage(hWnd,Msg,wParam,lParam)](#M-xyLOGIX-Core-Extensions-TextBoxExtensions-SendMessage-System-IntPtr,System-UInt32,System-IntPtr,System-String- 'xyLOGIX.Core.Extensions.TextBoxExtensions.SendMessage(System.IntPtr,System.UInt32,System.IntPtr,System.String)')
  - [SetCueBanner(textBox,cueText)](#M-xyLOGIX-Core-Extensions-TextBoxExtensions-SetCueBanner-System-Windows-Forms-TextBoxBase,System-String- 'xyLOGIX.Core.Extensions.TextBoxExtensions.SetCueBanner(System.Windows.Forms.TextBoxBase,System.String)')
- [ToolStripMenuItemExtensions](#T-xyLOGIX-Core-Extensions-ToolStripMenuItemExtensions 'xyLOGIX.Core.Extensions.ToolStripMenuItemExtensions')
  - [#cctor()](#M-xyLOGIX-Core-Extensions-ToolStripMenuItemExtensions-#cctor 'xyLOGIX.Core.Extensions.ToolStripMenuItemExtensions.#cctor')
  - [ContainsMenuItemNamed(item,name)](#M-xyLOGIX-Core-Extensions-ToolStripMenuItemExtensions-ContainsMenuItemNamed-System-Windows-Forms-ToolStripMenuItem,System-String- 'xyLOGIX.Core.Extensions.ToolStripMenuItemExtensions.ContainsMenuItemNamed(System.Windows.Forms.ToolStripMenuItem,System.String)')
  - [ContainsMenuItemNamed(menu,name)](#M-xyLOGIX-Core-Extensions-ToolStripMenuItemExtensions-ContainsMenuItemNamed-System-Windows-Forms-MenuStrip,System-String- 'xyLOGIX.Core.Extensions.ToolStripMenuItemExtensions.ContainsMenuItemNamed(System.Windows.Forms.MenuStrip,System.String)')
  - [GetMenuItemNamed(menu,name)](#M-xyLOGIX-Core-Extensions-ToolStripMenuItemExtensions-GetMenuItemNamed-System-Windows-Forms-ToolStripMenuItem,System-String- 'xyLOGIX.Core.Extensions.ToolStripMenuItemExtensions.GetMenuItemNamed(System.Windows.Forms.ToolStripMenuItem,System.String)')
  - [GetMenuItemNamed(menu,name)](#M-xyLOGIX-Core-Extensions-ToolStripMenuItemExtensions-GetMenuItemNamed-System-Windows-Forms-MenuStrip,System-String- 'xyLOGIX.Core.Extensions.ToolStripMenuItemExtensions.GetMenuItemNamed(System.Windows.Forms.MenuStrip,System.String)')
- [Transform](#T-xyLOGIX-Core-Extensions-Transform 'xyLOGIX.Core.Extensions.Transform')
  - [AcronymPattern](#F-xyLOGIX-Core-Extensions-Transform-AcronymPattern 'xyLOGIX.Core.Extensions.Transform.AcronymPattern')
  - [InitialCapsWordPattern](#F-xyLOGIX-Core-Extensions-Transform-InitialCapsWordPattern 'xyLOGIX.Core.Extensions.Transform.InitialCapsWordPattern')
  - [#cctor()](#M-xyLOGIX-Core-Extensions-Transform-#cctor 'xyLOGIX.Core.Extensions.Transform.#cctor')
  - [PascalCasedTextToPhrase(input)](#M-xyLOGIX-Core-Extensions-Transform-PascalCasedTextToPhrase-System-String- 'xyLOGIX.Core.Extensions.Transform.PascalCasedTextToPhrase(System.String)')
- [TypeExtensions](#T-xyLOGIX-Core-Extensions-TypeExtensions 'xyLOGIX.Core.Extensions.TypeExtensions')
  - [CachedActualType](#P-xyLOGIX-Core-Extensions-TypeExtensions-CachedActualType 'xyLOGIX.Core.Extensions.TypeExtensions.CachedActualType')
  - [#cctor()](#M-xyLOGIX-Core-Extensions-TypeExtensions-#cctor 'xyLOGIX.Core.Extensions.TypeExtensions.#cctor')
  - [GetActualType()](#M-xyLOGIX-Core-Extensions-TypeExtensions-GetActualType-System-Type- 'xyLOGIX.Core.Extensions.TypeExtensions.GetActualType(System.Type)')
  - [IsSameOrSubclassOf(potentialDescendant,potentialBaseType)](#M-xyLOGIX-Core-Extensions-TypeExtensions-IsSameOrSubclassOf-System-Type,System-Type- 'xyLOGIX.Core.Extensions.TypeExtensions.IsSameOrSubclassOf(System.Type,System.Type)')

<a name='T-xyLOGIX-Core-Extensions-BindingManagerBaseExtensions'></a>
## BindingManagerBaseExtensions `type`

##### Namespace

xyLOGIX.Core.Extensions

<a name='M-xyLOGIX-Core-Extensions-BindingManagerBaseExtensions-#cctor'></a>
### #cctor() `method`

##### Summary

Initializes static data or performs actions that need to be performed once only
for the [BindingManagerBaseExtensions](#T-xyLOGIX-Core-Extensions-BindingManagerBaseExtensions 'xyLOGIX.Core.Extensions.BindingManagerBaseExtensions')
class.

##### Parameters

This method has no parameters.

##### Remarks

This constructor is called automatically prior to the first instance being
created or before any static members are referenced.



We've decorated this constructor with the `[Log(AttributeExclude = true)]`
attribute in order to simplify the logging output.

<a name='T-xyLOGIX-Core-Extensions-BoundComboBox'></a>
## BoundComboBox `type`

##### Namespace

xyLOGIX.Core.Extensions

##### Summary

A [ComboBox](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.ComboBox 'System.Windows.Forms.ComboBox') that writes values when the
value of the [SelectedIndex](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.ComboBox.SelectedIndex 'System.Windows.Forms.ComboBox.SelectedIndex')
property is changed.

<a name='M-xyLOGIX-Core-Extensions-BoundComboBox-OnSelectedIndexChanged-System-EventArgs-'></a>
### OnSelectedIndexChanged(e) `method`

##### Summary

Raises the
[](#E-System-Windows-Forms-ComboBox-SelectedIndexChanged 'System.Windows.Forms.ComboBox.SelectedIndexChanged') event.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| e | [System.EventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.EventArgs 'System.EventArgs') | An [EventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.EventArgs 'System.EventArgs') that contains the event
data. |

<a name='T-xyLOGIX-Core-Extensions-Calculate'></a>
## Calculate `type`

##### Namespace

xyLOGIX.Core.Extensions

##### Summary

Exposes static methods to perform various mathematical calculations, such as
percentage change.

<a name='M-xyLOGIX-Core-Extensions-Calculate-DeltaBetween-System-Decimal,System-Decimal-'></a>
### DeltaBetween(end,start) `method`

##### Summary

Returns the delta, or where you `end` up, minus
where you `start`.



If the values are retrieved from time-series data, then `end`
is the value from the time closest to now, and `start` is
from back in the past.

##### Returns

Zero if `end` and `start` are
identically equal to each other; otherwise, the difference between
`end` and `start`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| end | [System.Decimal](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Decimal 'System.Decimal') | (Required.) Current, or more recent, value. |
| start | [System.Decimal](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Decimal 'System.Decimal') | (Required.) Starting value. |

<a name='M-xyLOGIX-Core-Extensions-Calculate-FractionalChangeBetween-System-Decimal,System-Decimal-'></a>
### FractionalChangeBetween(end,start) `method`

##### Summary

Given an `end` and a `start`
value, where `end` is further back in the past than
`start`, computes the fractional average rate of change
between the two.

##### Returns

Average fractional rate of the change from `start`
to `end`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| end | [System.Decimal](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Decimal 'System.Decimal') | (Required.) Current, or more recent, value. |
| start | [System.Decimal](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Decimal 'System.Decimal') | (Required.) Starting value. |

##### Remarks

The result of calling this method, in the event that
`start` is set equal to zero, is defined to be zero.

<a name='M-xyLOGIX-Core-Extensions-Calculate-PercentageChangeOf-System-Int64,System-Int64-'></a>
### PercentageChangeOf(initialValue,finalValue) `method`

##### Summary

Calculates the percentage change between an `initialValue`
and a `finalValue`.

##### Returns

The percentage change between the `initialValue` and
`finalValue`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| initialValue | [System.Int64](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int64 'System.Int64') | The initial value.  Must not be equal to zero. |
| finalValue | [System.Int64](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int64 'System.Int64') | The final value. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.DivideByZeroException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.DivideByZeroException 'System.DivideByZeroException') | Thrown when the specified
`initialValue` is equal to zero. |

<a name='M-xyLOGIX-Core-Extensions-Calculate-PercentageChangeOf-System-Int32,System-Int32-'></a>
### PercentageChangeOf(initialValue,finalValue) `method`

##### Summary

Calculates the percentage change between an `initialValue`
and a `finalValue`.

##### Returns

The percentage change between the `initialValue` and
`finalValue`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| initialValue | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The initial value.  Must not be equal to zero. |
| finalValue | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The final value. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.DivideByZeroException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.DivideByZeroException 'System.DivideByZeroException') | Thrown when the specified
`initialValue` is equal to zero. |

<a name='M-xyLOGIX-Core-Extensions-Calculate-PercentageChangeOf-System-Double,System-Double-'></a>
### PercentageChangeOf(initialValue,finalValue) `method`

##### Summary

Calculates the percentage change between an `initialValue`
and a `finalValue`.

##### Returns

The percentage change between the `initialValue` and
`finalValue`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| initialValue | [System.Double](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Double 'System.Double') | The initial value.  Must not be equal to zero. |
| finalValue | [System.Double](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Double 'System.Double') | The final value. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.DivideByZeroException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.DivideByZeroException 'System.DivideByZeroException') | Thrown when the specified
`initialValue` is equal to zero. |

<a name='M-xyLOGIX-Core-Extensions-Calculate-PercentageChangeOf-System-Decimal,System-Decimal-'></a>
### PercentageChangeOf(initialValue,finalValue) `method`

##### Summary

Calculates the percentage change between an `initialValue`
and a `finalValue`.

##### Returns

The percentage change between the `initialValue` and
`finalValue`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| initialValue | [System.Decimal](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Decimal 'System.Decimal') | The initial value.  Must not be equal to zero. |
| finalValue | [System.Decimal](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Decimal 'System.Decimal') | The final value. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.DivideByZeroException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.DivideByZeroException 'System.DivideByZeroException') | Thrown when the specified
`initialValue` is equal to zero. |

<a name='M-xyLOGIX-Core-Extensions-Calculate-PercentageDifference-System-Double,System-Double-'></a>
### PercentageDifference(a,b) `method`

##### Summary

Calculates the percentage difference between two given numbers.

##### Returns

The percentage difference between the two numbers.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| a | [System.Double](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Double 'System.Double') | The first number. |
| b | [System.Double](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Double 'System.Double') | The second number. |

##### Remarks

The formula used to calculate the percentage difference is:
(|a - b| / ((a + b) / 2)) * 100

<a name='M-xyLOGIX-Core-Extensions-Calculate-PercentageDifference-System-Decimal,System-Decimal-'></a>
### PercentageDifference(a,b) `method`

##### Summary

Calculates the percentage difference between two given numbers.

##### Returns

The percentage difference between the two numbers.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| a | [System.Decimal](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Decimal 'System.Decimal') | The first number. |
| b | [System.Decimal](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Decimal 'System.Decimal') | The second number. |

##### Remarks

The formula used to calculate the percentage difference is:
(|a - b| / ((a + b) / 2)) * 100

<a name='M-xyLOGIX-Core-Extensions-Calculate-PercentageDifference-System-Int32,System-Int32-'></a>
### PercentageDifference(a,b) `method`

##### Summary

Calculates the percentage difference between two given numbers.

##### Returns

The percentage difference between the two numbers.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| a | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The first number. |
| b | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The second number. |

##### Remarks

The formula used to calculate the percentage difference is:
(|a - b| / ((a + b) / 2)) * 100

<a name='M-xyLOGIX-Core-Extensions-Calculate-ProductOf-System-Decimal[]-'></a>
### ProductOf(factors) `method`

##### Summary

Computes the n-ary product of all the specified
`factors`.



If any one factor is zero, then this method does not even bother carrying out
the multiplication; it simply returns zero.

##### Returns

The n-ary product of the specified `factors`, or
zero if any one factor is zero.



If no values are passed, then this method is defined to return zero also.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| factors | [System.Decimal[]](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Decimal[] 'System.Decimal[]') | (Required.) One or more `decimal`
values that will serve as the factors to be multiplied. |

<a name='M-xyLOGIX-Core-Extensions-Calculate-QuotientOf-System-Decimal,System-Decimal-'></a>
### QuotientOf(numerator,denominator) `method`

##### Summary

Evaluates the quotient (i.e., the result when you divide two numbers)
of the specified `numerator` and
`denominator`, provided the `denominator`
is not equal to zero and neither is the `numerator`.

##### Returns

The quotient of the `numerator` divided by the
`denominator`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| numerator | [System.Decimal](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Decimal 'System.Decimal') | (Required.) A [Decimal](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Decimal 'System.Decimal') value to
serve as the divisor. |
| denominator | [System.Decimal](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Decimal 'System.Decimal') | (Required.) A [Decimal](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Decimal 'System.Decimal') value
to serve as the dividend.



Must not be identically equal to zero. |

##### Remarks

Zero is returned in the event that either the
`numerator` or the `denominator` are
identically zero.



Zero is also returned in the event an exception is raised by the division
operator.

<a name='M-xyLOGIX-Core-Extensions-Calculate-ZeroFloorOf-System-Int32-'></a>
### ZeroFloorOf(value) `method`

##### Summary

Computes the zero floor.  Meaning, if the specified
`value` is negative, then this method returns zero.



If the specified `value` is zero or greater, then this method
is the identity.

##### Returns

Zero if the specified `value` is negative;
otherwise, if the specified `value` is zero or greater, then
the method is the identity map.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | (Required.) Input value. |

<a name='M-xyLOGIX-Core-Extensions-Calculate-ZeroFloorOf-System-Int64-'></a>
### ZeroFloorOf(value) `method`

##### Summary

Computes the zero floor.  Meaning, if the specified
`value` is negative, then this method returns zero.



If the specified `value` is zero or greater, then this method
is the identity.

##### Returns

Zero if the specified `value` is negative;
otherwise, if the specified `value` is zero or greater, then
the method is the identity map.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.Int64](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int64 'System.Int64') | (Required.) Input value. |

<a name='M-xyLOGIX-Core-Extensions-Calculate-ZeroFloorOf-System-Decimal-'></a>
### ZeroFloorOf(value) `method`

##### Summary

Computes the zero floor.  Meaning, if the specified
`value` is negative, then this method returns zero.



If the specified `value` is zero or greater, then this method
is the identity.

##### Returns

Zero if the specified `value` is negative;
otherwise, if the specified `value` is zero or greater, then
the method is the identity map.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.Decimal](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Decimal 'System.Decimal') | (Required.) Input value. |

<a name='M-xyLOGIX-Core-Extensions-Calculate-ZeroFloorOf-System-Double-'></a>
### ZeroFloorOf(value) `method`

##### Summary

Computes the zero floor.  Meaning, if the specified
`value` is negative, then this method returns zero.



If the specified `value` is zero or greater, then this method
is the identity.

##### Returns

Zero if the specified `value` is negative;
otherwise, if the specified `value` is zero or greater, then
the method is the identity map.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.Double](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Double 'System.Double') | (Required.) Input value. |

<a name='T-xyLOGIX-Core-Extensions-CharExtensions'></a>
## CharExtensions `type`

##### Namespace

xyLOGIX.Core.Extensions

##### Summary

Contains extension methods to be used on instances of the
[Char](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Char 'System.Char').

<a name='M-xyLOGIX-Core-Extensions-CharExtensions-#cctor'></a>
### #cctor() `method`

##### Summary

Initializes static data or performs actions that need to be performed once only
for the [CharExtensions](#T-xyLOGIX-Core-Extensions-CharExtensions 'xyLOGIX.Core.Extensions.CharExtensions') class.

##### Parameters

This method has no parameters.

##### Remarks

This constructor is called automatically prior to the first instance being
created or before any static members are referenced.



We've decorated this constructor with the `[Log(AttributeExclude = true)]`
attribute in order to simplify the logging output.

<a name='M-xyLOGIX-Core-Extensions-CharExtensions-IsDigit-System-Char-'></a>
### IsDigit(value) `method`

##### Summary

Determines whether the specified `value` is a digit.

##### Returns

`true` if `value` is a digit; otherwise,
`false`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.Char](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Char 'System.Char') | (Required.) A [Char](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Char 'System.Char') value to evaluate. |

<a name='M-xyLOGIX-Core-Extensions-CharExtensions-IsLowercase-System-Char-'></a>
### IsLowercase(value) `method`

##### Summary

Determines whether the specified `value` is an ASCII
lowercase letter ('a' through 'z').

##### Returns

`true` if `value` is a lowercase
ASCII letter; otherwise, `false`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.Char](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Char 'System.Char') | (Required.) A [Char](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Char 'System.Char') value to evaluate. |

<a name='M-xyLOGIX-Core-Extensions-CharExtensions-IsUppercase-System-Char-'></a>
### IsUppercase(value) `method`

##### Summary

Determines whether the specified `value` is an ASCII
uppercase letter ('A' through 'Z').

##### Returns

`true` if `value` is an uppercase
ASCII letter; otherwise, `false`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.Char](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Char 'System.Char') | (Required.) A [Char](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Char 'System.Char') value to evaluate. |

<a name='T-xyLOGIX-Core-Extensions-CheckedListBoxExtensions'></a>
## CheckedListBoxExtensions `type`

##### Namespace

xyLOGIX.Core.Extensions

##### Summary

Extension methods for a
[CheckedListBox](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.CheckedListBox 'System.Windows.Forms.CheckedListBox').

<a name='M-xyLOGIX-Core-Extensions-CheckedListBoxExtensions-AreAllItemsSelected-System-Windows-Forms-CheckedListBox-'></a>
### AreAllItemsSelected(checkedListBox) `method`

##### Summary

Gets a value indicating whether all the items in the
`checkedListBox` box are selected.

##### Returns

`true` if all the items in the checked list box are
selected; `false` otherwise, or if the list box contains zero
items.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| checkedListBox | [System.Windows.Forms.CheckedListBox](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.CheckedListBox 'System.Windows.Forms.CheckedListBox') | (Required.) Reference to the
[CheckedListBox](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.CheckedListBox 'System.Windows.Forms.CheckedListBox') the items of which are to
be checked. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [ArgumentNullException](#T-ArgumentNullException 'ArgumentNullException') | Thrown if the required parameter,
`checkedListBox`, is passed a `null` value. |

<a name='M-xyLOGIX-Core-Extensions-CheckedListBoxExtensions-CheckAll-System-Windows-Forms-CheckedListBox,System-Boolean-'></a>
### CheckAll(checkedListBox,isChecked) `method`

##### Summary

Toggles the Checked state of all the items in the specified
`checkedListBox`

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| checkedListBox | [System.Windows.Forms.CheckedListBox](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.CheckedListBox 'System.Windows.Forms.CheckedListBox') | (Required.) A
[CheckedListBox](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.CheckedListBox 'System.Windows.Forms.CheckedListBox') to act upon. |
| isChecked | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | (Optional.) Whether to set the Checked state of all
the list items or not. Default value is `true`. |

##### Remarks

If the `checkedListBox` parameter is
`null`, or if the checked list box contains zero items, then
this method does nothing.

<a name='M-xyLOGIX-Core-Extensions-CheckedListBoxExtensions-CheckByName-System-Windows-Forms-CheckedListBox,System-String,System-Boolean-'></a>
### CheckByName(checkedListBox,itemName,isChecked) `method`

##### Summary

Sets the Checked state of the check the box whose name is identical
to the value in the `itemName` parameter.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| checkedListBox | [System.Windows.Forms.CheckedListBox](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.CheckedListBox 'System.Windows.Forms.CheckedListBox') | (Required.) A
[CheckedListBox](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.CheckedListBox 'System.Windows.Forms.CheckedListBox') to act upon. |
| itemName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) String containing the name of the item
whose Checked state is to be altered. |
| isChecked | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | (Optional.) Whether to set the Checked state of the
list item whose name matches that of the string specified by the
`itemName` parameter. Default value is
`true`. |

<a name='M-xyLOGIX-Core-Extensions-CheckedListBoxExtensions-GetCheckedByName-System-Windows-Forms-CheckedListBox,System-String-'></a>
### GetCheckedByName(checkedListBox,itemName) `method`

##### Summary

Gets the Checked state ( `true` for checked,
`false` for unchecked) of the
`checkedListBox` item with the specified
`itemName`.

##### Returns

`false` if the item having a caption of
`itemName` does not exist or the
`checkedListBox` has zero items, or the checked state --
`true` for checked, `false` for unchecked --
of the item whose caption matches the `itemName` parameter's
value.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| checkedListBox | [System.Windows.Forms.CheckedListBox](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.CheckedListBox 'System.Windows.Forms.CheckedListBox') | (Required.) Reference to the
[CheckedListBox](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.CheckedListBox 'System.Windows.Forms.CheckedListBox') containing the items to be
checked. |
| itemName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) String containing the caption of the item
whose Checked state should be ascertained. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [ArgumentNullException](#T-ArgumentNullException 'ArgumentNullException') | Thrown if the required parameter,
`checkedListBox`, is passed a `null` value. |
| [System.ArgumentException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentException 'System.ArgumentException') | Thrown if the required parameter,
`itemName`, is passed a blank or `null`
string for a value. |

<a name='M-xyLOGIX-Core-Extensions-CheckedListBoxExtensions-NoItemsAreSelected-System-Windows-Forms-CheckedListBox-'></a>
### NoItemsAreSelected(checkedListBox) `method`

##### Summary

Determines whether none of the checkboxes in a
[CheckedListBox](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.CheckedListBox 'System.Windows.Forms.CheckedListBox') are selected.

##### Returns

`true` if none of the items in the list are checked
or if there are zero entries in the list; `false` otherwise.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| checkedListBox | [System.Windows.Forms.CheckedListBox](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.CheckedListBox 'System.Windows.Forms.CheckedListBox') | (Required.) Reference to the
[CheckedListBox](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.CheckedListBox 'System.Windows.Forms.CheckedListBox') the items of which are to
be checked. |

<a name='T-xyLOGIX-Core-Extensions-CollectionExtensions'></a>
## CollectionExtensions `type`

##### Namespace

xyLOGIX.Core.Extensions

##### Summary

Exposes static extension methods for collection types.

<a name='M-xyLOGIX-Core-Extensions-CollectionExtensions-AddMultiple``1-System-Collections-Generic-ICollection{``0},``0[]-'></a>
### AddMultiple\`\`1(collection,items) `method`

##### Summary

Adds multiple items to a collection without the need to call
`AddRange` and allocate up a whole new collection object instance just to
be used once.



It seemed like the `AddRange` way was a waste of system resources.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| collection | [System.Collections.Generic.ICollection{\`\`0}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.ICollection 'System.Collections.Generic.ICollection{``0}') | (Required.) Reference to an instance of an object
that implements the [ICollection\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.ICollection`1 'System.Collections.Generic.ICollection`1') interface. |
| items | [\`\`0[]](#T-``0[] '``0[]') | (Required.) One or more instances of
`T` that are to be added to the collection. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | (Required.) Name of the data type of the elements of the
specified `collection`. |

##### Remarks

If the `collection` parameter has been passed a
`null` reference, then this method does nothing.



If zero items are passed for the `items` parameter, then this
method does nothing.



If an individual element of the `items` parameter is a
`null` reference, then it is not added.



If an individual element of the `items` parameter is already
a member of the specified `collection`, it is still added.
Typical use of this method is for, e.g., generating script files.

<a name='M-xyLOGIX-Core-Extensions-CollectionExtensions-AnyAre``1-System-Collections-Generic-IEnumerable{``0},System-Func{``0,System-Boolean}-'></a>
### AnyAre\`\`1(values,predicate) `method`

##### Summary

Determines whether the `predicate` returns
`true` for any of the specified `values`.

##### Returns

`true` if any of the `values`
matches the supplied `predicate`; `false`
otheriwse.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| values | [System.Collections.Generic.IEnumerable{\`\`0}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable 'System.Collections.Generic.IEnumerable{``0}') | (Required.) Collection of objects, each of whose elements
are to be passed to the specified `predicate` until either it
returns `true`, or if the entire collection is enumerated. |
| predicate | [System.Func{\`\`0,System.Boolean}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Func 'System.Func{``0,System.Boolean}') | (Required.) Predicate that tests each value in the
`values` collection. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | (Required.) Data type of each element of the
`values` collection. |

##### Remarks

This method can make no guarantee about the order in which it evaluates the
`predicate` on the elements of the `values`
collection.



This method enumerates the entire `values`
collection twice; once to determine if it contains any elements, and the other
to test each element with the specified `predicate`.



If you do not want that, then use the LINQ `Any` method on the
`values` collection instead.



The approach of this method is designed to make it an asset where thread-safety
is more important than performance.



Iteration of the `values` collection stops the moment that
either the `predicate` returns `true`, or if
the end of the `values` collection is reached.

<a name='M-xyLOGIX-Core-Extensions-CollectionExtensions-IsEmpty``1-System-Collections-Generic-ICollection{``0}-'></a>
### IsEmpty\`\`1(collection) `method`

##### Summary

Determines whether the specified `collection`
contains zero elements.

##### Returns

`true` if the specified
`collection` contains zero elements; `false`
otherwise.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| collection | [System.Collections.Generic.ICollection{\`\`0}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.ICollection 'System.Collections.Generic.ICollection{``0}') | (Required.) Reference to an instance of an object
that implements the [ICollection\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.ICollection`1 'System.Collections.Generic.ICollection`1') interface. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | (Required.) Data type of the collection's elements. |

##### Remarks

If this method is passed a `null` reference, then
the method also returns `false`.

<a name='M-xyLOGIX-Core-Extensions-CollectionExtensions-IsNullOrEmpty``1-System-Collections-Generic-ICollection{``0}-'></a>
### IsNullOrEmpty\`\`1(collection) `method`

##### Summary

Determines whether the specified `collection` is a
`null` reference or the empty collection (i.e., the collection
containing zero elements).

##### Returns

`true` if the specified
`collection` is a `null` reference or if it
contains zero elements; `false` otherwise.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| collection | [System.Collections.Generic.ICollection{\`\`0}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.ICollection 'System.Collections.Generic.ICollection{``0}') | (Required.) Reference to an instance of an object
that implements the [ICollection\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.ICollection`1 'System.Collections.Generic.ICollection`1') interface. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | (Required.) Data type of the collection's elements. |

<a name='M-xyLOGIX-Core-Extensions-CollectionExtensions-IsOneOf``1-System-Object-'></a>
### IsOneOf\`\`1(obj) `method`

##### Summary

Determines if the specified `object` is of one of the types in
the specified tuple of types.

##### Returns

`true` if the specified `object` is one of the
types specified; otherwise, `false` is returned.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| obj | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | A [Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') instance whose type is to
be checked. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TTypes | Tuple of types that the `obj` could
be. |

##### Remarks

If a `null` reference is passed to this method, then
this method returns `false`.



This method is useful for checking, say, if a
[Control](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.Control 'System.Windows.Forms.Control') is a
[Button](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.Button 'System.Windows.Forms.Button'), a
[CheckBox](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.CheckBox 'System.Windows.Forms.CheckBox'), or a
[Label](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.Label 'System.Windows.Forms.Label').



To perform that check, you would pass
`Tuple<Button, CheckBox, Label>` as this method's type parameter.

<a name='T-xyLOGIX-Core-Extensions-ComboBoxExtensions'></a>
## ComboBoxExtensions `type`

##### Namespace

xyLOGIX.Core.Extensions

##### Summary

Exposes static extension methods for instances of
[ComboBox](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.ComboBox 'System.Windows.Forms.ComboBox').

<a name='M-xyLOGIX-Core-Extensions-ComboBoxExtensions-#cctor'></a>
### #cctor() `method`

##### Summary

Initializes static data or performs actions that need to be performed once only
for the [ComboBoxExtensions](#T-xyLOGIX-Core-Extensions-ComboBoxExtensions 'xyLOGIX.Core.Extensions.ComboBoxExtensions') class.

##### Parameters

This method has no parameters.

##### Remarks

This constructor is called automatically prior to the first instance being
created or before any static members are referenced.



We've decorated this constructor with the `[Log(AttributeExclude = true)]`
attribute in order to simplify the logging output.

<a name='M-xyLOGIX-Core-Extensions-ComboBoxExtensions-BindToEnum``1-System-Windows-Forms-ComboBox,``0-'></a>
### BindToEnum\`\`1(comboBox,defaultSelection) `method`

##### Summary

Data-binds an enumeration in code to a
[ComboBox](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.ComboBox 'System.Windows.Forms.ComboBox').

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| comboBox | [System.Windows.Forms.ComboBox](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.ComboBox 'System.Windows.Forms.ComboBox') | (Required.) Reference to an instance of the
[ComboBox](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.ComboBox 'System.Windows.Forms.ComboBox') that is to be data-bound. |
| defaultSelection | [\`\`0](#T-``0 '``0') | (Required.) Default value to be selected when
the form is first displayed. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | (Required.) The name of the C# enumeration to be
data-bound. |

<a name='M-xyLOGIX-Core-Extensions-ComboBoxExtensions-GetComboBoxItems``1'></a>
### GetComboBoxItems\`\`1() `method`

##### Summary

Attempts to gather a collection of combo box items for the specified C#
enumeration.

##### Returns

A collection of instances of
[EnumBoundComboBoxItem\`1](#T-xyLOGIX-Core-Extensions-EnumBoundComboBoxItem`1 'xyLOGIX.Core.Extensions.EnumBoundComboBoxItem`1')
, each of which represent an item to be added to a
[ComboBox](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.ComboBox 'System.Windows.Forms.ComboBox').

##### Parameters

This method has no parameters.

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | (Required.) Name of the enumeration. |

<a name='M-xyLOGIX-Core-Extensions-ComboBoxExtensions-SelectFirstItem-System-Windows-Forms-ComboBox-'></a>
### SelectFirstItem(comboBox) `method`

##### Summary

Attempts to select the first item in the list of items present in the specified
`comboBox`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| comboBox | [System.Windows.Forms.ComboBox](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.ComboBox 'System.Windows.Forms.ComboBox') | (Required.) Reference to an instance of
[ComboBox](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.ComboBox 'System.Windows.Forms.ComboBox') that contains the item(s) to be
used. |

##### Remarks

If the specified `comboBox` is a
`null` reference or it contains zero items, then this method
does nothing.

<a name='T-xyLOGIX-Core-Extensions-ComponentExtensions'></a>
## ComponentExtensions `type`

##### Namespace

xyLOGIX.Core.Extensions

##### Summary

Exposes `static` extension method(s) for the
[Component](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ComponentModel.Component 'System.ComponentModel.Component') class.

<a name='M-xyLOGIX-Core-Extensions-ComponentExtensions-#cctor'></a>
### #cctor() `method`

##### Summary

Initializes `static` data or performs actions that
need to be performed once only for the
[ComponentExtensions](#T-xyLOGIX-Core-Extensions-ComponentExtensions 'xyLOGIX.Core.Extensions.ComponentExtensions') class.

##### Parameters

This method has no parameters.

##### Remarks

This constructor is called automatically prior to the first instance
being created or before any `static` members are referenced.



We've decorated this constructor with the `[Log(AttributeExclude = true)]`
attribute in order to simplify the logging output.

<a name='M-xyLOGIX-Core-Extensions-ComponentExtensions-IsNullOrDisposed-System-ComponentModel-Component-'></a>
### IsNullOrDisposed() `method`

##### Summary

Determines whether the specified `component` is set to a
`null` reference or has been disposed.

##### Parameters

This method has no parameters.

##### Remarks

Uses the [IsDisposed](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.Control.IsDisposed 'System.Windows.Forms.Control.IsDisposed') for
WinForms controls and falls back to reflection and a conservative probe for
other Component implementations.



On any exception the method logs and returns `true`.

<a name='T-xyLOGIX-Core-Extensions-ControlExtensions'></a>
## ControlExtensions `type`

##### Namespace

xyLOGIX.Core.Extensions

##### Summary

The `ControlExtensions` class provides helper methods for
extending the functionality of .NET framework controls.

<a name='P-xyLOGIX-Core-Extensions-ControlExtensions-ControlFormAssociationProvider'></a>
### ControlFormAssociationProvider `property`

##### Summary

Gets a reference to an instance of an object that implements the
[IControlFormAssociationProvider](#T-xyLOGIX-Core-Extensions-Providers-Interfaces-IControlFormAssociationProvider 'xyLOGIX.Core.Extensions.Providers.Interfaces.IControlFormAssociationProvider')
interface.

<a name='M-xyLOGIX-Core-Extensions-ControlExtensions-#cctor'></a>
### #cctor() `method`

##### Summary

Initializes `static` data or performs actions that
need to be performed once only for the
[ControlExtensions](#T-xyLOGIX-Core-Extensions-ControlExtensions 'xyLOGIX.Core.Extensions.ControlExtensions') class.

##### Parameters

This method has no parameters.

##### Remarks

This constructor is called automatically prior to the first instance
being created or before any `static` members are referenced.



We've decorated this constructor with the `[Log(AttributeExclude = true)]`
attribute in order to simplify the logging output.

<a name='M-xyLOGIX-Core-Extensions-ControlExtensions-AssociateWithParentForm-System-Windows-Forms-Control-'></a>
### AssociateWithParentForm(control) `method`

##### Summary

Associates the specified `control` with its
containing (i.e., parent) [Form](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.Form 'System.Windows.Forms.Form').

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| control | [System.Windows.Forms.Control](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.Control 'System.Windows.Forms.Control') | (Required.) Reference to an instance of
[Control](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.Control 'System.Windows.Forms.Control') that is to be associated with its
containing (i.e., parent) [Form](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.Form 'System.Windows.Forms.Form'). |

##### Remarks

If the `control` parameter is passed a
`null` reference as its argument, then this method does
nothing.

<a name='M-xyLOGIX-Core-Extensions-ControlExtensions-GetParentForm-System-Windows-Forms-Control-'></a>
### GetParentForm() `method`

##### Summary

Gets a reference to the [Form](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.Form 'System.Windows.Forms.Form')
that contains this control.

##### Returns

Reference to the [Form](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.Form 'System.Windows.Forms.Form') that
contains this control.

##### Parameters

This method has no parameters.

##### Remarks

If the `Control-Form Association Provider` does not contain a reference to
the containing [Form](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.Form 'System.Windows.Forms.Form'), then the method
calls the [FindForm](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.Control.FindForm 'System.Windows.Forms.Control.FindForm') method.

<a name='M-xyLOGIX-Core-Extensions-ControlExtensions-InvokeIfRequired-System-ComponentModel-ISynchronizeInvoke,System-Windows-Forms-MethodInvoker-'></a>
### InvokeIfRequired(obj,message) `method`

##### Summary

Provides a thread-safe way to run managed code against, e.g., a
GUI-thread control.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| obj | [System.ComponentModel.ISynchronizeInvoke](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ComponentModel.ISynchronizeInvoke 'System.ComponentModel.ISynchronizeInvoke') | (Required.) Reference to an instance of an object that
implements the [ISynchronizeInvoke](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ComponentModel.ISynchronizeInvoke 'System.ComponentModel.ISynchronizeInvoke')
interface. |
| message | [System.Windows.Forms.MethodInvoker](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.MethodInvoker 'System.Windows.Forms.MethodInvoker') | (Required.) Reference to a
[MethodInvoker](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.MethodInvoker 'System.Windows.Forms.MethodInvoker') delegate that defines the
code to be run. |

##### Remarks

This method should always be called for a child control of a frame
window; never the window itself (even though, technically, it also derives from
[Control](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.Control 'System.Windows.Forms.Control') and implements the
[ISynchronizeInvoke](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ComponentModel.ISynchronizeInvoke 'System.ComponentModel.ISynchronizeInvoke') interface).

<a name='M-xyLOGIX-Core-Extensions-ControlExtensions-InvokeIfRequired``1-System-ComponentModel-ISynchronizeInvoke,System-Func{``0}-'></a>
### InvokeIfRequired\`\`1(obj,message) `method`

##### Summary

Provides a thread-safe way to run managed code against, e.g., a
GUI-thread control.

##### Returns

Reference to an instance of the return type of the specified
`message`, or `null` if an error occurred.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| obj | [System.ComponentModel.ISynchronizeInvoke](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ComponentModel.ISynchronizeInvoke 'System.ComponentModel.ISynchronizeInvoke') | (Required.) Reference to an instance of an object that
implements the [ISynchronizeInvoke](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ComponentModel.ISynchronizeInvoke 'System.ComponentModel.ISynchronizeInvoke')
interface. |
| message | [System.Func{\`\`0}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Func 'System.Func{``0}') | (Required.) Reference to a
[MethodInvoker](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.MethodInvoker 'System.Windows.Forms.MethodInvoker') delegate that defines the
code to be run. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | (Required.) Name of the return type of the specified
`message`. |

##### Remarks

This method should always be called for a child control of a frame
window; never the window itself (even though, technically, it also derives from
[Control](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.Control 'System.Windows.Forms.Control') and implements the
[ISynchronizeInvoke](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ComponentModel.ISynchronizeInvoke 'System.ComponentModel.ISynchronizeInvoke') interface).

<a name='M-xyLOGIX-Core-Extensions-ControlExtensions-IsParentFormNullOrDisposed-System-Windows-Forms-Control-'></a>
### IsParentFormNullOrDisposed() `method`

##### Summary

Gets a value that indicates whether the reference to the
[Form](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.Form 'System.Windows.Forms.Form') that contains this control is not
initialized, or whether that [Form](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.Form 'System.Windows.Forms.Form') is
disposed.

##### Returns

`true` if the reference to the
[Form](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.Form 'System.Windows.Forms.Form') that contains this control is not
initialized, or if that [Form](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.Form 'System.Windows.Forms.Form') has been
disposed; `false` otherwise.

##### Parameters

This method has no parameters.

<a name='T-xyLOGIX-Core-Extensions-DateTimeExtensions'></a>
## DateTimeExtensions `type`

##### Namespace

xyLOGIX.Core.Extensions

##### Summary

Exposes static extension methods to perform operations on
[DateTime](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.DateTime 'System.DateTime') value(s).

<a name='M-xyLOGIX-Core-Extensions-DateTimeExtensions-ToRFC3339-System-DateTime-'></a>
### ToRFC3339(date) `method`

##### Summary

Expresses the specified `date` value as a
[String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') in `RFC 3339` format.



The specified `date` is adjusted to be in UTC if it is not
already.

##### Returns

If successful, a [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') is returned expressing
the supplied `date` in `RFC 3339` format; otherwise, the
[Empty](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String.Empty 'System.String.Empty') value is returned.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| date | [System.DateTime](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.DateTime 'System.DateTime') | (Required.) The [DateTime](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.DateTime 'System.DateTime') value that
is to be formatted as a [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String'). |

<a name='M-xyLOGIX-Core-Extensions-DateTimeExtensions-ToSentencePart-System-DateTime-'></a>
### ToSentencePart(dateTime) `method`

##### Summary

Emits a string, based on the value of the specified
`dateTime`, and in local time, that says, e.g.,
`on 10/16/2024 at 4:59:02 PM`.

##### Returns

If successful, a [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') containing the
required text; otherwise, the [Empty](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String.Empty 'System.String.Empty') value is
returned.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| dateTime | [System.DateTime](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.DateTime 'System.DateTime') | (Required.) A [DateTime](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.DateTime 'System.DateTime') value
that is to be expressed as part of a sentence. |

<a name='T-xyLOGIX-Core-Extensions-DateTimeOffsetExtensions'></a>
## DateTimeOffsetExtensions `type`

##### Namespace

xyLOGIX.Core.Extensions

##### Summary

Exposes static extension methods for [DateTimeOffset](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.DateTimeOffset 'System.DateTimeOffset')
value(s).

<a name='M-xyLOGIX-Core-Extensions-DateTimeOffsetExtensions-IsMoreRecentThan-System-DateTimeOffset,System-DateTimeOffset-'></a>
### IsMoreRecentThan(time1,time2) `method`

##### Summary

Determines whether `time1` is closer to the present than
`time2`.

##### Returns

`true` if `time1` is more recent
than `time2`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| time1 | [System.DateTimeOffset](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.DateTimeOffset 'System.DateTimeOffset') | (Required.) A [DateTimeOffset](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.DateTimeOffset 'System.DateTimeOffset') that should be compared to
`time2`. |
| time2 | [System.DateTimeOffset](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.DateTimeOffset 'System.DateTimeOffset') | (Required.) A [DateTimeOffset](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.DateTimeOffset 'System.DateTimeOffset') that
should be compared to `time2`. |

##### Remarks

If either `time1`, `time2`, or
both are in the future, then this method returns `false`.



This method concerns itself only with times that are in the relative past.

<a name='M-xyLOGIX-Core-Extensions-DateTimeOffsetExtensions-IsWithinXSecondsOf-System-DateTimeOffset,System-DateTimeOffset,System-Int32-'></a>
### IsWithinXSecondsOf(dto1,dto2,seconds) `method`

##### Summary

Determines if `dto1` is within `seconds`
second(s) of `dto2`, where `dto1` and
`dto2` are both instances of
[DateTimeOffset](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.DateTimeOffset 'System.DateTimeOffset').

##### Returns

`true` if the two
[DateTimeOffset](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.DateTimeOffset 'System.DateTimeOffset') value(s), `dto1` and
`dto2`, are equal to or less than `seconds`
apart.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| dto1 | [System.DateTimeOffset](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.DateTimeOffset 'System.DateTimeOffset') | (Required.) One of the
[DateTimeOffset](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.DateTimeOffset 'System.DateTimeOffset') value(s) to be compared. |
| dto2 | [System.DateTimeOffset](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.DateTimeOffset 'System.DateTimeOffset') | (Required.) The other of the two
[DateTimeOffset](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.DateTimeOffset 'System.DateTimeOffset') value(s) to be compared. |
| seconds | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | (Required.) A positive [Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') that
gives the number of seconds that the difference between
`dto1` and `dto2` must be within. |

##### Remarks

This method measures the time difference between
`dto1` and `dto2` to the nearest
millisecond.

<a name='M-xyLOGIX-Core-Extensions-DateTimeOffsetExtensions-IsWithinXSecondsOf-System-DateTime,System-DateTimeOffset,System-Int32-'></a>
### IsWithinXSecondsOf(dto1,dto2,seconds) `method`

##### Summary

Determines if `dto1` is within `seconds`
second(s) of `dto2`, where `dto1` and
`dto2` are both instances of
[DateTimeOffset](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.DateTimeOffset 'System.DateTimeOffset').

##### Returns

`true` if the two
[DateTimeOffset](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.DateTimeOffset 'System.DateTimeOffset') value(s), `dto1` and
`dto2`, are equal to or less than `seconds`
apart.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| dto1 | [System.DateTime](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.DateTime 'System.DateTime') | (Required.) One of the
[DateTime](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.DateTime 'System.DateTime') value(s) to be compared. |
| dto2 | [System.DateTimeOffset](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.DateTimeOffset 'System.DateTimeOffset') | (Required.) The other of the two
[DateTimeOffset](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.DateTimeOffset 'System.DateTimeOffset') value(s) to be compared. |
| seconds | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | (Required.) A positive [Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') that
gives the number of seconds that the difference between
`dto1` and `dto2` must be within. |

##### Remarks

This method measures the time difference between
`dto1` and `dto2` to the nearest
millisecond.

<a name='T-xyLOGIX-Core-Extensions-DictionaryExtensions'></a>
## DictionaryExtensions `type`

##### Namespace

xyLOGIX.Core.Extensions

##### Summary

Provides methods for extending any dictionary.

<a name='M-xyLOGIX-Core-Extensions-DictionaryExtensions-#cctor'></a>
### #cctor() `method`

##### Summary

Initializes static data or performs actions that need to be performed once only
for the [DictionaryExtensions](#T-xyLOGIX-Core-Extensions-DictionaryExtensions 'xyLOGIX.Core.Extensions.DictionaryExtensions') class.

##### Parameters

This method has no parameters.

##### Remarks

This constructor is called automatically prior to the first instance being
created or before any static members are referenced.



We've decorated this constructor with the `[Log(AttributeExclude = true)]`
attribute in order to simplify the logging output.

<a name='M-xyLOGIX-Core-Extensions-DictionaryExtensions-AddDistinct``2-System-Collections-Generic-IDictionary{``0,``1},``0,``1-'></a>
### AddDistinct\`\`2(dictionary,key,value) `method`

##### Summary

Adds the specified `key` and
`value` to the specified `dictionary`, but
only if the specified `key` is not already in the dictionary.



Otherwise, the entry having the specified `key` will have its
value updated to be `value`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| dictionary | [System.Collections.Generic.IDictionary{\`\`0,\`\`1}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IDictionary 'System.Collections.Generic.IDictionary{``0,``1}') | (Required.) Dictionary to which the new
`key` and `value` are to be added. |
| key | [\`\`0](#T-``0 '``0') | (Required.) Key to be added/updated in the dictionary.



If this is the `null` or otherwise the default value of the
key's data type, then this method will do nothing. |
| value | [\`\`1](#T-``1 '``1') | (Required.) Value to be added/updated in the dictionary. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| K | (Required.) Data type of the key. |
| V | (Required.) Data type of the value. |

<a name='M-xyLOGIX-Core-Extensions-DictionaryExtensions-MergeWith``2-System-Collections-Generic-IDictionary{``0,``1},System-Collections-Generic-IDictionary{``0,``1}-'></a>
### MergeWith\`\`2(target,quote) `method`

##### Summary

Adds all the elements of the `quote` dictionary to
the `target` dictionary.



Dupes are ignored.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| target | [System.Collections.Generic.IDictionary{\`\`0,\`\`1}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IDictionary 'System.Collections.Generic.IDictionary{``0,``1}') | (Required.) The dictionary that is to be the target of
the merge. |
| quote | [System.Collections.Generic.IDictionary{\`\`0,\`\`1}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IDictionary 'System.Collections.Generic.IDictionary{``0,``1}') | (Required.) A dictionary that has the items to be merged
in.



If this is the `null` or otherwise the default value of the
key's data type, then this method will do nothing. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| K | (Required.) Data type of the key. |
| V | (Required.) Data type of the value. |

##### Remarks

If a key in the `quote` dictionary matches a key
in the `target` dictionary, then the corresponding value is
overwritten.

<a name='M-xyLOGIX-Core-Extensions-DictionaryExtensions-ToConcurrentDictionary``3-System-Collections-Generic-IEnumerable{``0},System-Func{``0,``1},System-Func{``0,``2}-'></a>
### ToConcurrentDictionary\`\`3(quote,keySelector,elementSelector) `method`

##### Summary

Crates a
[ConcurrentDictionary\`2](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Concurrent.ConcurrentDictionary`2 'System.Collections.Concurrent.ConcurrentDictionary`2') from an
[IEnumerable\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable`1 'System.Collections.Generic.IEnumerable`1') according to the
specified `keySelector` and
`elementSelector` functions.

##### Returns

A
[ConcurrentDictionary\`2](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Concurrent.ConcurrentDictionary`2 'System.Collections.Concurrent.ConcurrentDictionary`2') that
contains values of type `TElement` selected from the
input sequence.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| quote | [System.Collections.Generic.IEnumerable{\`\`0}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable 'System.Collections.Generic.IEnumerable{``0}') | (Required.) An
[IEnumerable\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable`1 'System.Collections.Generic.IEnumerable`1') to create a
[ConcurrentDictionary\`2](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Concurrent.ConcurrentDictionary`2 'System.Collections.Concurrent.ConcurrentDictionary`2') from. |
| keySelector | [System.Func{\`\`0,\`\`1}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Func 'System.Func{``0,``1}') | (Required.) A function to extract a key from each
element of `quote`. |
| elementSelector | [System.Func{\`\`0,\`\`2}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Func 'System.Func{``0,``2}') | (Required.) A transform function to produce a
result element value from each element of `quote`. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TSource | (Required.) The type of the elements of
`quote`. |
| TKey | (Required.) The type of the key returned by
`keySelector`. |
| TElement | (Required.) The type of the value returned by
`elementSelector`. |

##### Remarks

If any of the inputs are invalid values, i.e.,
`null` reference and the like, or if an issue occurs during
the generation of the requested `Dictionary` object, then the method
returns the empty collection.

<a name='M-xyLOGIX-Core-Extensions-DictionaryExtensions-ToObject``1-System-Collections-Generic-Dictionary{System-String,System-String}-'></a>
### ToObject\`\`1(quote) `method`

##### Summary

Transforms an instance of an object of type
[string](#T-string 'string')
into an object by mapping the dictionary elements onto the object's properties
that have the same name.

##### Returns

Reference to an instance of an object of type T whose properties are
filled in with the values from the `quote`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| quote | [System.Collections.Generic.Dictionary{System.String,System.String}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.Dictionary 'System.Collections.Generic.Dictionary{System.String,System.String}') | Reference to an instance of an object of type
[string](#T-string 'string')
, whose key-value pairs identify what properties to fill with what information. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | Type parameter identifying the object to receive the
dictionary's information. |

##### Remarks

In order for this method to work, the object and the dictionary must
have the same schema.

<a name='T-xyLOGIX-Core-Extensions-EnumBoundComboBoxItem`1'></a>
## EnumBoundComboBoxItem\`1 `type`

##### Namespace

xyLOGIX.Core.Extensions

##### Summary

Represents a C# `enum` value together with a user-friendly
display name, i.e., description.

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T |  |

<a name='P-xyLOGIX-Core-Extensions-EnumBoundComboBoxItem`1-Description'></a>
### Description `property`

##### Summary

Gets or sets a [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') that contains a user-friendly
display name, or description, for the specific enumeration value.

<a name='P-xyLOGIX-Core-Extensions-EnumBoundComboBoxItem`1-Value'></a>
### Value `property`

##### Summary

Gets or sets the enumeration value that is "behind" the combo box selection.

<a name='M-xyLOGIX-Core-Extensions-EnumBoundComboBoxItem`1-ForEnumValue-`0-'></a>
### ForEnumValue(value) `method`

##### Summary

Creates a new instance of
[EnumBoundComboBoxItem\`1](#T-xyLOGIX-Core-Extensions-EnumBoundComboBoxItem`1 'xyLOGIX.Core.Extensions.EnumBoundComboBoxItem`1')
and initializes it with the specified `value`.

##### Returns

Reference to an instance of
[EnumBoundComboBoxItem\`1](#T-xyLOGIX-Core-Extensions-EnumBoundComboBoxItem`1 'xyLOGIX.Core.Extensions.EnumBoundComboBoxItem`1')
that contains the required data.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [\`0](#T-`0 '`0') | (Required.) The C# enumeration value to use for
initialization. |

<a name='T-xyLOGIX-Core-Extensions-EnumExtensions'></a>
## EnumExtensions `type`

##### Namespace

xyLOGIX.Core.Extensions

##### Summary

Extension methods to utilize on enums.

<a name='M-xyLOGIX-Core-Extensions-EnumExtensions-#cctor'></a>
### #cctor() `method`

##### Summary

Initializes static data or performs actions that need to be performed once only
for the [EnumExtensions](#T-xyLOGIX-Core-Extensions-EnumExtensions 'xyLOGIX.Core.Extensions.EnumExtensions') class.

##### Parameters

This method has no parameters.

##### Remarks

This constructor is called automatically prior to the first instance being
created or before any static members are referenced.



We've decorated this constructor with the `[Log(AttributeExclude = true)]`
attribute in order to simplify the logging output.

<a name='M-xyLOGIX-Core-Extensions-EnumExtensions-AsString``1-``0-'></a>
### AsString\`\`1(enumerationValue) `method`

##### Summary

Converts an enumeration value of the specified type (with a
[DescriptionAttribute](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ComponentModel.DescriptionAttribute 'System.ComponentModel.DescriptionAttribute') applied to it) to a
string value.

##### Returns

String containing the enumeration value expressed as a string.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| enumerationValue | [\`\`0](#T-``0 '``0') | Value of the enumeration. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | Type of the enumeration. |

<a name='M-xyLOGIX-Core-Extensions-EnumExtensions-IsUndefined``1-``0-'></a>
### IsUndefined\`\`1(enumerationValue) `method`

##### Summary

Determines whether the specified `enumerationValue` is not
within the value set of its defining `enum`.

##### Returns

`true` if the specified
`enumerationValue` is not within the value set of its
defining `enum`; `false` otherwise.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| enumerationValue | [\`\`0](#T-``0 '``0') | (Required.) Enumeration value to be checked. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | (Required.) Name of the `enum` from which
the specified `enumerationValue` comes. |

<a name='T-xyLOGIX-Core-Extensions-EnumerableExtensions'></a>
## EnumerableExtensions `type`

##### Namespace

xyLOGIX.Core.Extensions

##### Summary

Helper methods for collections.

<a name='M-xyLOGIX-Core-Extensions-EnumerableExtensions-#cctor'></a>
### #cctor() `method`

##### Summary

Initializes static data or performs actions that need to be performed once only
for the [EnumerableExtensions](#T-xyLOGIX-Core-Extensions-EnumerableExtensions 'xyLOGIX.Core.Extensions.EnumerableExtensions') class.

##### Parameters

This method has no parameters.

##### Remarks

This constructor is called automatically prior to the first instance being
created or before any static members are referenced.



We've decorated this constructor with the `[Log(AttributeExclude = true)]`
attribute in order to simplify the logging output.

<a name='M-xyLOGIX-Core-Extensions-EnumerableExtensions-AnyEqualAnyOf``1-System-Collections-Generic-IEnumerable{``0},``0[]-'></a>
### AnyEqualAnyOf\`\`1(collection,values) `method`

##### Summary

Determines whether any of the element(s) of the specified
`collection` are equal to any of the specified
`values`.

##### Returns

`true` if even one match is found;
`false` otherwise.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| collection | [System.Collections.Generic.IEnumerable{\`\`0}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable 'System.Collections.Generic.IEnumerable{``0}') | (Required.) Collection of values, all of the type,
`T`, that is to be searched. |
| values | [\`\`0[]](#T-``0[] '``0[]') | (Required.) One or more values that are to be matched. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | (Required.) Data type of the individual elements of the
specified `collection`. |

<a name='M-xyLOGIX-Core-Extensions-EnumerableExtensions-AnyEqual``1-System-Collections-Generic-IEnumerable{``0},``0-'></a>
### AnyEqual\`\`1(collection,value) `method`

##### Summary

Determines if any of the element(s) of the specified
`collection` happen to equal the specified
`value`.

##### Returns

`true` if at least one element of the specified
`collection` matches the specified `value`;
`false` otherwise.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| collection | [System.Collections.Generic.IEnumerable{\`\`0}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable 'System.Collections.Generic.IEnumerable{``0}') | (Required.) Collection of values, all of the type,
`T`, that is to be searched. |
| value | [\`\`0](#T-``0 '``0') | (Required.) The value that is to be matched. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | (Required.) Data type of the individual elements of the
specified `collection`. |

<a name='M-xyLOGIX-Core-Extensions-EnumerableExtensions-Except``1-System-Collections-Generic-IEnumerable{``0},``0-'></a>
### Except\`\`1(source,value) `method`

##### Summary

A more fluent version of the LINQ `Except` extension method; this method
takes a `source` enumerable collection, and filters out just
the element equalling `value` from it.

##### Returns

A sequence containing all elements from the `source`,
except for any that match the specified `value`.
The original `source` is not cloned or modified.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| source | [System.Collections.Generic.IEnumerable{\`\`0}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable 'System.Collections.Generic.IEnumerable{``0}') | (Required.) The enumerable collection from which to filter
the `value`. |
| value | [\`\`0](#T-``0 '``0') | (Required.) The value to be removed from the
`source`. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | (Required.) Data type of each element of the source
enumerable collection. |

<a name='M-xyLOGIX-Core-Extensions-EnumerableExtensions-ForEach``1-System-Collections-Generic-IList{``0},System-Action{``0}-'></a>
### ForEach\`\`1(collection,action) `method`

##### Summary

Runs the specified `action` for each element of the
specified `collection`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| collection | [System.Collections.Generic.IList{\`\`0}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IList 'System.Collections.Generic.IList{``0}') | (Required.) Reference to an instance of a collection
of elements, each of which are of type `T`. |
| action | [System.Action{\`\`0}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Action 'System.Action{``0}') | (Required.) Reference to an instance of a
[Action{T}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Action 'System.Action{T}')`delegate` that is executed
for each of the elements in the collection, with the corresponding element
passed as its input. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | (Required.) Name of the type of each element of the
`collection`. |

##### Remarks

If the `collection` is empty, or if the
`action` is `null`, then this method does
nothing.

<a name='M-xyLOGIX-Core-Extensions-EnumerableExtensions-ForEach``1-System-Collections-Generic-IEnumerable{``0},System-Action{``0}-'></a>
### ForEach\`\`1(collection,action) `method`

##### Summary

Runs the specified `action` for each element of the
specified `collection`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| collection | [System.Collections.Generic.IEnumerable{\`\`0}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable 'System.Collections.Generic.IEnumerable{``0}') | (Required.) Reference to an instance of a collection
of elements, each of which are of type `T`. |
| action | [System.Action{\`\`0}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Action 'System.Action{``0}') | (Required.) Reference to an instance of a
[Action{T}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Action 'System.Action{T}')`delegate` that is executed
for each of the elements in the collection, with the corresponding element
passed as its input. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | (Required.) Name of the type of each element of the
`collection`. |

##### Remarks

If the `collection` is empty, or if the
`action` is `null`, then this method does
nothing.

<a name='M-xyLOGIX-Core-Extensions-EnumerableExtensions-IsAnyOf``1-``0,``0[]-'></a>
### IsAnyOf\`\`1(value,testObjects) `method`

##### Summary

Compares the `value` object with the
`testObjects` provided, to see if any of the
`testObjects` is a match.

##### Returns

True if any of the `testObjects` equals the value;
false otherwise.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [\`\`0](#T-``0 '``0') | Source object to check. |
| testObjects | [\`\`0[]](#T-``0[] '``0[]') | Object or objects that should be compared to value
with the [Equals](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object.Equals 'System.Object.Equals') method. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | Type of the object to be tested. |

<a name='M-xyLOGIX-Core-Extensions-EnumerableExtensions-ShuffleIterator``1-System-Collections-Generic-IEnumerable{``0},System-Random-'></a>
### ShuffleIterator\`\`1(quote,rng) `method`

##### Summary

Shuffles the elements of the sequence into a random order, and then
returns the resulting sequence. From the Fisher-Yates-Durstenfeld shuffle. Uses
the random-number generator passed in the `rng` parameter.
Behaves like the
[Shuffle](#M-xyLOGIX-Core-Extensions-EnumerableExtensions-Shuffle 'xyLOGIX.Core.Extensions.EnumerableExtensions.Shuffle') method,
although this method can be utilized as an iterator.

##### Returns

A new sequence, with the order of the elements randomized, according
to the Fisher-Yates-Durstenfeld shuffle.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| quote | [System.Collections.Generic.IEnumerable{\`\`0}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable 'System.Collections.Generic.IEnumerable{``0}') | Sequence to be shuffled. |
| rng | [System.Random](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Random 'System.Random') | A [Random](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Random 'System.Random') instance with which to
generate new random values for the shuffle operation. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | Type of the elements of the sequence. |

##### Remarks

see, e.g.,

<a name='M-xyLOGIX-Core-Extensions-EnumerableExtensions-Shuffle``1-System-Collections-Generic-IEnumerable{``0}-'></a>
### Shuffle\`\`1(quote) `method`

##### Summary

Shuffles the elements of the sequence into a random order, and then
returns the resulting sequence. From the Fisher-Yates-Durstenfeld shuffle.

##### Returns

A new sequence, with the order of the elements randomized, according
to the Fisher-Yates-Durstenfeld shuffle.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| quote | [System.Collections.Generic.IEnumerable{\`\`0}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable 'System.Collections.Generic.IEnumerable{``0}') | Sequence to be shuffled. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | Type of the elements of the sequence. |

##### Remarks

see, e.g.,

<a name='M-xyLOGIX-Core-Extensions-EnumerableExtensions-Shuffle``1-System-Collections-Generic-IEnumerable{``0},System-Random-'></a>
### Shuffle\`\`1(quote,rng) `method`

##### Summary

Shuffles the elements of the sequence into a random order, and then
returns the resulting sequence. From the Fisher-Yates-Durstenfeld shuffle. Uses
the random-number generator passed in the `rng` parameter.

##### Returns

A new sequence, with the order of the elements randomized, according
to the Fisher-Yates-Durstenfeld shuffle.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| quote | [System.Collections.Generic.IEnumerable{\`\`0}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable 'System.Collections.Generic.IEnumerable{``0}') | Sequence to be shuffled. |
| rng | [System.Random](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Random 'System.Random') | A [Random](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Random 'System.Random') instance with which to
generate new random values for the shuffle operation. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | Type of the elements of the sequence. |

##### Remarks

see, e.g.,

<a name='M-xyLOGIX-Core-Extensions-EnumerableExtensions-TakeAllButLast``1-System-Collections-Generic-IEnumerable{``0}-'></a>
### TakeAllButLast\`\`1(quote) `method`

##### Summary

Returns all the elements of the `quote` enumerable
object, except for the last.

##### Returns

Enumerable iterator over the collection that yields every item in the
collection, except for the last.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| quote | [System.Collections.Generic.IEnumerable{\`\`0}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable 'System.Collections.Generic.IEnumerable{``0}') | Reference to an enumerable collection. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | Name of the type of item in the collection. |

<a name='T-xyLOGIX-Core-Extensions-FormExtensions'></a>
## FormExtensions `type`

##### Namespace

xyLOGIX.Core.Extensions

##### Summary

Helper methods for manipulating windows forms.

<a name='M-xyLOGIX-Core-Extensions-FormExtensions-#cctor'></a>
### #cctor() `method`

##### Summary

Initializes `static` data or performs actions that
need to be performed once only for the
[FormExtensions](#T-xyLOGIX-Core-Extensions-FormExtensions 'xyLOGIX.Core.Extensions.FormExtensions') class.

##### Parameters

This method has no parameters.

##### Remarks

This constructor is called automatically prior to the first instance
being created or before any `static` members are referenced.



We've decorated this constructor with the `[Log(AttributeExclude = true)]`
attribute in order to simplify the logging output.

<a name='M-xyLOGIX-Core-Extensions-FormExtensions-CenterForm-xyLOGIX-Core-Extensions-IForm,xyLOGIX-Core-Extensions-IForm-'></a>
### CenterForm(child,parent) `method`

##### Summary

Centers this form on the specified `parent` form.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| child | [xyLOGIX.Core.Extensions.IForm](#T-xyLOGIX-Core-Extensions-IForm 'xyLOGIX.Core.Extensions.IForm') | (Required.) Reference to an instance of an object that
implements the [IForm](#T-xyLOGIX-Core-Extensions-IForm 'xyLOGIX.Core.Extensions.IForm') interface that
represents the `Child Form`; i.e., the form that is to be centered with
respect to the specified `parent` form. |
| parent | [xyLOGIX.Core.Extensions.IForm](#T-xyLOGIX-Core-Extensions-IForm 'xyLOGIX.Core.Extensions.IForm') | (Required.) Reference to an instance of an object that
implements the [IForm](#T-xyLOGIX-Core-Extensions-IForm 'xyLOGIX.Core.Extensions.IForm') interface that
represents the parent form. |

<a name='M-xyLOGIX-Core-Extensions-FormExtensions-CenterForm-xyLOGIX-Core-Extensions-IForm,System-Windows-Forms-Screen-'></a>
### CenterForm(form,screen) `method`

##### Summary

Centers the specified `form` to the specific
`screen` that is passed.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| form | [xyLOGIX.Core.Extensions.IForm](#T-xyLOGIX-Core-Extensions-IForm 'xyLOGIX.Core.Extensions.IForm') | Reference to an instance of
[Form](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.Form 'System.Windows.Forms.Form') that specifies the form to be
centered. |
| screen | [System.Windows.Forms.Screen](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.Screen 'System.Windows.Forms.Screen') | Reference to an instance of
[Screen](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.Screen 'System.Windows.Forms.Screen') that specifies the screen that the
form is to be centered on. |

<a name='M-xyLOGIX-Core-Extensions-FormExtensions-DoIfDisposed-xyLOGIX-Core-Extensions-IForm,System-Action-'></a>
### DoIfDisposed(form,message) `method`

##### Summary

Invokes the specified `message` on the form unless it's NOT
disposed, in which case nothing is done.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| form | [xyLOGIX.Core.Extensions.IForm](#T-xyLOGIX-Core-Extensions-IForm 'xyLOGIX.Core.Extensions.IForm') | A [Form](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.Form 'System.Windows.Forms.Form') on which to
perform the `message`. |
| message | [System.Action](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Action 'System.Action') | An [Action](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Action 'System.Action') specifying code to be
run if the form is disposed. |

<a name='M-xyLOGIX-Core-Extensions-FormExtensions-DoIfNotDisposed-xyLOGIX-Core-Extensions-IForm,System-Action-'></a>
### DoIfNotDisposed(form,message) `method`

##### Summary

Invokes the specified `message` on the form unless it's
disposed, in which case nothing is done.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| form | [xyLOGIX.Core.Extensions.IForm](#T-xyLOGIX-Core-Extensions-IForm 'xyLOGIX.Core.Extensions.IForm') | A [Form](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.Form 'System.Windows.Forms.Form') on which to
perform the `message`. |
| message | [System.Action](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Action 'System.Action') | An [Action](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Action 'System.Action') specifying code to be
run if the form is not disposed. |

<a name='M-xyLOGIX-Core-Extensions-FormExtensions-IsNullOrDisposed-xyLOGIX-Core-Extensions-IForm-'></a>
### IsNullOrDisposed(form) `method`

##### Summary

Gets a value indicating whether the specified `form` is
either set to a `null` reference, or is in the process of
being disposed, or has already been disposed.

##### Returns

`true` if the specified `form`
is in the `null` reference or `Disposed` state, or if it
is in the process of being disposed.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| form | [xyLOGIX.Core.Extensions.IForm](#T-xyLOGIX-Core-Extensions-IForm 'xyLOGIX.Core.Extensions.IForm') | (Required.) Reference to an instance of an object that implements the
[IForm](#T-xyLOGIX-Core-Extensions-IForm 'xyLOGIX.Core.Extensions.IForm') interface that is to be
checked for being in the `Disposed` state. |

<a name='M-xyLOGIX-Core-Extensions-FormExtensions-ShowDialogAsync-xyLOGIX-Core-Extensions-IForm,System-Windows-Forms-IWin32Window-'></a>
### ShowDialogAsync(form,owner) `method`

##### Summary

Shows a modal dialog that can be awaited upon while a task completes.

##### Returns

An awaitable
[DialogResult](#T-DialogResult 'DialogResult')
that contains the result of the dialog's closure.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| form | [xyLOGIX.Core.Extensions.IForm](#T-xyLOGIX-Core-Extensions-IForm 'xyLOGIX.Core.Extensions.IForm') | Reference to an instance of an object that is a child class
of [Form](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.Form 'System.Windows.Forms.Form') that represents the form to be
shown. |
| owner | [System.Windows.Forms.IWin32Window](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.IWin32Window 'System.Windows.Forms.IWin32Window') | Reference to an instance of an object that implements the
[IWin32Window](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.IWin32Window 'System.Windows.Forms.IWin32Window') that represents the form's
owner window. |

<a name='M-xyLOGIX-Core-Extensions-FormExtensions-ShowDialogAsync-xyLOGIX-Core-Extensions-IForm-'></a>
### ShowDialogAsync(form) `method`

##### Summary

Shows a modal dialog that can be awaited upon while a task completes.

##### Returns

An awaitable
[DialogResult](#T-DialogResult 'DialogResult')
that contains the result of the dialog's closure.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| form | [xyLOGIX.Core.Extensions.IForm](#T-xyLOGIX-Core-Extensions-IForm 'xyLOGIX.Core.Extensions.IForm') | Reference to an instance of an object that is a child class
of [Form](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.Form 'System.Windows.Forms.Form') that represents the form to be
shown. |

<a name='M-xyLOGIX-Core-Extensions-FormExtensions-ShowOnPrimaryMonitor-xyLOGIX-Core-Extensions-IForm-'></a>
### ShowOnPrimaryMonitor(form) `method`

##### Summary

Shows the specified `form` on the user's primary
monitor (whatever monitor they have designated as Monitor #1)

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| form | [xyLOGIX.Core.Extensions.IForm](#T-xyLOGIX-Core-Extensions-IForm 'xyLOGIX.Core.Extensions.IForm') | Reference to the [Form](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.Form 'System.Windows.Forms.Form')
to be moved to the user's primary monitor. The form is also centered on the
screen. |

<a name='T-xyLOGIX-Core-Extensions-GetLanguageArticleTypeValidator'></a>
## GetLanguageArticleTypeValidator `type`

##### Namespace

xyLOGIX.Core.Extensions

##### Summary

Provides access to the one and only instance of the object that implements the
[ILanguageArticleTypeValidator](#T-xyLOGIX-Core-Extensions-ILanguageArticleTypeValidator 'xyLOGIX.Core.Extensions.ILanguageArticleTypeValidator')
interface.

<a name='M-xyLOGIX-Core-Extensions-GetLanguageArticleTypeValidator-#cctor'></a>
### #cctor() `method`

##### Summary

Initializes static data or performs actions that need to be performed
once only for the
[GetLanguageArticleTypeValidator](#T-xyLOGIX-Core-Extensions-GetLanguageArticleTypeValidator 'xyLOGIX.Core.Extensions.GetLanguageArticleTypeValidator') class.

##### Parameters

This method has no parameters.

##### Remarks

This constructor is called automatically prior to the first instance
being created or before any static members are referenced.

<a name='M-xyLOGIX-Core-Extensions-GetLanguageArticleTypeValidator-SoleInstance'></a>
### SoleInstance() `method`

##### Summary

Obtains access to the sole instance of the object that implements the
[ILanguageArticleTypeValidator](#T-xyLOGIX-Core-Extensions-ILanguageArticleTypeValidator 'xyLOGIX.Core.Extensions.ILanguageArticleTypeValidator')
interface, and returns a reference to it.

##### Returns

Reference to the one, and only, instance of the object that implements the
[ILanguageArticleTypeValidator](#T-xyLOGIX-Core-Extensions-ILanguageArticleTypeValidator 'xyLOGIX.Core.Extensions.ILanguageArticleTypeValidator')
interface.

##### Parameters

This method has no parameters.

<a name='T-xyLOGIX-Core-Extensions-GuidExtensions'></a>
## GuidExtensions `type`

##### Namespace

xyLOGIX.Core.Extensions

##### Summary

Exposes static extension methods for the [Guid](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Guid 'System.Guid')
class.

<a name='M-xyLOGIX-Core-Extensions-GuidExtensions-#cctor'></a>
### #cctor() `method`

##### Summary

Initializes static data or performs actions that need to be performed once only
for the [GuidExtensions](#T-xyLOGIX-Core-Extensions-GuidExtensions 'xyLOGIX.Core.Extensions.GuidExtensions') class.

##### Parameters

This method has no parameters.

##### Remarks

This constructor is called automatically prior to the first instance being
created or before any static members are referenced.



We've decorated this constructor with the `[Log(AttributeExclude = true)]`
attribute in order to simplify the logging output.

<a name='M-xyLOGIX-Core-Extensions-GuidExtensions-AsDigitsWithHyphens-System-Guid-'></a>
### AsDigitsWithHyphens(guid) `method`

##### Summary

Expresses the provided `guid` as a
[String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') containing only the [Guid](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Guid 'System.Guid')
digits, including hyphens.

##### Returns

If successful, the `guid` is expressed a
[String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') containing only the [Guid](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Guid 'System.Guid')
digits, including hyphens.  Otherwise, and including the case where the Zero
GUID is passed, the method returns the [Empty](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String.Empty 'System.String.Empty')
value.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| guid | [System.Guid](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Guid 'System.Guid') | (Required.) A [Guid](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Guid 'System.Guid') that is to be
expressed as a [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') with braces. |

<a name='M-xyLOGIX-Core-Extensions-GuidExtensions-IsZero-System-Guid-'></a>
### IsZero(value) `method`

##### Summary

Determines whether the specified [Guid](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Guid 'System.Guid') value
is the Zero GUID or not.

##### Returns

`true` if the specified `value` is
equal to the Zero GUID; `false` otherwise.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.Guid](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Guid 'System.Guid') | (Required.) The [Guid](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Guid 'System.Guid') that should
be checked whether it's the Zero GUID. |

<a name='M-xyLOGIX-Core-Extensions-GuidExtensions-ToUppercaseWithBraces-System-Guid-'></a>
### ToUppercaseWithBraces(guid) `method`

##### Summary

Represents the specified `guid` as a
[String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') that is surrounded by curly braces and is in
uppercase.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| guid | [System.Guid](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Guid 'System.Guid') | (Required.) A [Guid](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Guid 'System.Guid') value that is to
be represented as a [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String'). |

##### Remarks

If this method is passed the [Empty](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Guid.Empty 'System.Guid.Empty')
value, then this method returns the [Empty](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String.Empty 'System.String.Empty') value.

<a name='M-xyLOGIX-Core-Extensions-GuidExtensions-WithBraces-System-Guid-'></a>
### WithBraces(guid) `method`

##### Summary

Expresses the provided `guid` as a
[String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String'), surrounded by braces (as in the system
Registry, for instance).

##### Returns

If successful, the `guid` is expressed as a
[String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String'), surrounded by braces (as in the system
Registry, for instance).  Otherwise, and including the case where the Zero GUID
is passed, the method returns the [Empty](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String.Empty 'System.String.Empty') value.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| guid | [System.Guid](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Guid 'System.Guid') | (Required.) A [Guid](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Guid 'System.Guid') that is to be
expressed as a [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') with braces. |

<a name='T-xyLOGIX-Core-Extensions-IComboBox'></a>
## IComboBox `type`

##### Namespace

xyLOGIX.Core.Extensions

##### Summary

Defines the publicly-exposed methods and properties of a WinForms
combo box control.

<a name='P-xyLOGIX-Core-Extensions-IComboBox-AutoCompleteCustomSource'></a>
### AutoCompleteCustomSource `property`

##### Summary

Gets or sets a custom
[StringCollection](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Specialized.StringCollection 'System.Collections.Specialized.StringCollection') to use when
the [AutoCompleteSource](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.ComboBox.AutoCompleteSource 'System.Windows.Forms.ComboBox.AutoCompleteSource') property
is set to `CustomSource`.

##### Returns

A [StringCollection](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Specialized.StringCollection 'System.Collections.Specialized.StringCollection') to
use with [AutoCompleteSource](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.ComboBox.AutoCompleteSource 'System.Windows.Forms.ComboBox.AutoCompleteSource').

<a name='P-xyLOGIX-Core-Extensions-IComboBox-AutoCompleteMode'></a>
### AutoCompleteMode `property`

##### Summary

Gets or sets an option that controls how automatic completion works
for the [ComboBox](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.ComboBox 'System.Windows.Forms.ComboBox').

##### Returns

One of the values of
[AutoCompleteMode](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.AutoCompleteMode 'System.Windows.Forms.AutoCompleteMode') . The values are
[Append](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.AutoCompleteMode.Append 'System.Windows.Forms.AutoCompleteMode.Append'),
[None](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.AutoCompleteMode.None 'System.Windows.Forms.AutoCompleteMode.None') ,
[Suggest](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.AutoCompleteMode.Suggest 'System.Windows.Forms.AutoCompleteMode.Suggest') , and
[SuggestAppend](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.AutoCompleteMode.SuggestAppend 'System.Windows.Forms.AutoCompleteMode.SuggestAppend') . The
default is [None](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.AutoCompleteMode.None 'System.Windows.Forms.AutoCompleteMode.None').

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ComponentModel.InvalidEnumArgumentException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ComponentModel.InvalidEnumArgumentException 'System.ComponentModel.InvalidEnumArgumentException') | The
specified value is not one of the values of
[AutoCompleteMode](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.AutoCompleteMode 'System.Windows.Forms.AutoCompleteMode'). |

<a name='P-xyLOGIX-Core-Extensions-IComboBox-AutoCompleteSource'></a>
### AutoCompleteSource `property`

##### Summary

Gets or sets a value specifying the quote of complete strings used
for automatic completion.

##### Returns

One of the values of
[AutoCompleteSource](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.AutoCompleteSource 'System.Windows.Forms.AutoCompleteSource') . The options are
`AllSystemSources`, `AllUrl`,
`FileSystem` , `HistoryList`,
`RecentlyUsedList` , `CustomSource`, and
`None`. The default is `None`.

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ComponentModel.InvalidEnumArgumentException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ComponentModel.InvalidEnumArgumentException 'System.ComponentModel.InvalidEnumArgumentException') | The
specified value is not one of the values of
[AutoCompleteSource](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.AutoCompleteSource 'System.Windows.Forms.AutoCompleteSource'). |

<a name='P-xyLOGIX-Core-Extensions-IComboBox-DataSource'></a>
### DataSource `property`

##### Summary

Gets or sets the data source for this
[ComboBox](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.ComboBox 'System.Windows.Forms.ComboBox').

##### Returns

An object that implements the
[IList](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.IList 'System.Collections.IList') interface or an
[Array](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Array 'System.Array') . The default is `null`.

<a name='P-xyLOGIX-Core-Extensions-IComboBox-DrawMode'></a>
### DrawMode `property`

##### Summary

Gets or sets a value indicating whether your code or the operating
system will handle drawing of elements in the list.

##### Returns

One of the [DrawMode](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.DrawMode 'System.Windows.Forms.DrawMode') enumeration
values. The default is [Normal](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.DrawMode.Normal 'System.Windows.Forms.DrawMode.Normal').

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ComponentModel.InvalidEnumArgumentException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ComponentModel.InvalidEnumArgumentException 'System.ComponentModel.InvalidEnumArgumentException') | The
value is not a valid [DrawMode](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.DrawMode 'System.Windows.Forms.DrawMode') enumeration
value. |

<a name='P-xyLOGIX-Core-Extensions-IComboBox-DropDownHeight'></a>
### DropDownHeight `property`

##### Summary

Gets or sets the height in pixels of the drop-down portion of the
[ComboBox](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.ComboBox 'System.Windows.Forms.ComboBox').

##### Returns

The height, in pixels, of the drop-down box.

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentException 'System.ArgumentException') | The specified value is less than
one. |

<a name='P-xyLOGIX-Core-Extensions-IComboBox-DropDownStyle'></a>
### DropDownStyle `property`

##### Summary

Gets or sets a value specifying the style of the combo box.

##### Returns

One of the [ComboBoxStyle](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.ComboBoxStyle 'System.Windows.Forms.ComboBoxStyle')
values. The default is `DropDown`.

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ComponentModel.InvalidEnumArgumentException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ComponentModel.InvalidEnumArgumentException 'System.ComponentModel.InvalidEnumArgumentException') | The
assigned value is not one of the
[ComboBoxStyle](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.ComboBoxStyle 'System.Windows.Forms.ComboBoxStyle') value(s). |

<a name='P-xyLOGIX-Core-Extensions-IComboBox-DropDownWidth'></a>
### DropDownWidth `property`

##### Summary

Gets or sets the width of the of the drop-down portion of a combo
box.

##### Returns

The width, in pixels, of the drop-down box.

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentException 'System.ArgumentException') | The specified value is less than
one. |

<a name='P-xyLOGIX-Core-Extensions-IComboBox-DroppedDown'></a>
### DroppedDown `property`

##### Summary

Gets or sets a value indicating whether the combo box is displaying
its drop-down portion.

##### Returns

`true` if the drop-down portion is displayed;
otherwise, `false`. The default is false.

<a name='P-xyLOGIX-Core-Extensions-IComboBox-FlatStyle'></a>
### FlatStyle `property`

##### Summary

Gets or sets the appearance of the
[ComboBox](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.ComboBox 'System.Windows.Forms.ComboBox').

##### Returns

One of the enumeration values that specifies the appearance of the
control. The options are `Flat`, `Popup` ,
`Standard`, and `System` . The default is
`Standard`.

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ComponentModel.InvalidEnumArgumentException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ComponentModel.InvalidEnumArgumentException 'System.ComponentModel.InvalidEnumArgumentException') | The
specified value is not one of the values of
[FlatStyle](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.FlatStyle 'System.Windows.Forms.FlatStyle'). |

<a name='P-xyLOGIX-Core-Extensions-IComboBox-IntegralHeight'></a>
### IntegralHeight `property`

##### Summary

Gets or sets a value indicating whether the control should resize to
avoid showing partial items.

##### Returns

`true` if the list portion can contain only complete
items; otherwise, `false`. The default is
`true`.

<a name='P-xyLOGIX-Core-Extensions-IComboBox-ItemHeight'></a>
### ItemHeight `property`

##### Summary

Gets or sets the height of an item in the combo box.

##### Returns

The height, in pixels, of an item in the combo box.

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentException 'System.ArgumentException') | The item height value is less
than zero. |

<a name='P-xyLOGIX-Core-Extensions-IComboBox-Items'></a>
### Items `property`

##### Summary

Gets an object representing the collection of the items contained in
this [ComboBox](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.ComboBox 'System.Windows.Forms.ComboBox').

##### Returns

A [ObjectCollection](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.ComboBox.ObjectCollection 'System.Windows.Forms.ComboBox.ObjectCollection')
representing the items in the [ComboBox](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.ComboBox 'System.Windows.Forms.ComboBox').

<a name='P-xyLOGIX-Core-Extensions-IComboBox-MaxDropDownItems'></a>
### MaxDropDownItems `property`

##### Summary

Gets or sets the maximum number of items to be shown in the drop-down
portion of the [ComboBox](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.ComboBox 'System.Windows.Forms.ComboBox').

##### Returns

The maximum number of items of in the drop-down portion. The minimum
for this property is 1 and the maximum is 100.

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentException 'System.ArgumentException') | The maximum number is set less
than one or greater than 100. |

<a name='P-xyLOGIX-Core-Extensions-IComboBox-MaxLength'></a>
### MaxLength `property`

##### Summary

Gets or sets the number of characters a user can type into the
[ComboBox](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.ComboBox 'System.Windows.Forms.ComboBox').

##### Returns

The maximum number of characters a user can enter. Values of less
than zero are reset to zero, which is the default value.

<a name='P-xyLOGIX-Core-Extensions-IComboBox-PreferredHeight'></a>
### PreferredHeight `property`

##### Summary

Gets the preferred height of the
[ComboBox](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.ComboBox 'System.Windows.Forms.ComboBox') .

##### Returns

The preferred height, in pixels, of the item area of the combo box.

<a name='P-xyLOGIX-Core-Extensions-IComboBox-SelectedIndex'></a>
### SelectedIndex `property`

##### Summary

Gets or sets the index specifying the currently selected item.

##### Returns

A zero-based index of the currently selected item. A value of
negative one (-1) is returned if no item is selected.

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentOutOfRangeException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentOutOfRangeException 'System.ArgumentOutOfRangeException') | The specified index is
less than or equal to -2. -or- The specified index is greater than or equal to
the number of items in the combo box. |

<a name='P-xyLOGIX-Core-Extensions-IComboBox-SelectedItem'></a>
### SelectedItem `property`

##### Summary

Gets or sets currently selected item in the
[ComboBox](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.ComboBox 'System.Windows.Forms.ComboBox').

##### Returns

The object that is the currently selected item or
`null` if there is no currently selected item.

<a name='P-xyLOGIX-Core-Extensions-IComboBox-SelectedText'></a>
### SelectedText `property`

##### Summary

Gets or sets the text that is selected in the editable portion of a
[ComboBox](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.ComboBox 'System.Windows.Forms.ComboBox').

##### Returns

A string that represents the currently selected text in the combo
box. If [DropDownStyle](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.ComboBox.DropDownStyle 'System.Windows.Forms.ComboBox.DropDownStyle') is set to
[DropDownList](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.ComboBoxStyle.DropDownList 'System.Windows.Forms.ComboBoxStyle.DropDownList') , the return
value is an empty string ("").

<a name='P-xyLOGIX-Core-Extensions-IComboBox-SelectionLength'></a>
### SelectionLength `property`

##### Summary

Gets or sets the number of characters selected in the editable
portion of the combo box.

##### Returns

The number of characters selected in the combo box.

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentException 'System.ArgumentException') | The value was less than zero. |

<a name='P-xyLOGIX-Core-Extensions-IComboBox-SelectionStart'></a>
### SelectionStart `property`

##### Summary

Gets or sets the starting index of text selected in the combo box.

##### Returns

The zero-based index of the first character in the string of the
current text selection.

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentException 'System.ArgumentException') | The value is less than zero. |

<a name='P-xyLOGIX-Core-Extensions-IComboBox-Sorted'></a>
### Sorted `property`

##### Summary

Gets or sets a value indicating whether the items in the combo box
are sorted.

##### Returns

`true` if the combo box is sorted; otherwise,
`false` . The default is `false`.

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentException 'System.ArgumentException') | An attempt was made to sort a
[ComboBox](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.ComboBox 'System.Windows.Forms.ComboBox') that is attached to a data
quote. |

<a name='M-xyLOGIX-Core-Extensions-IComboBox-BeginUpdate'></a>
### BeginUpdate() `method`

##### Summary

Maintains performance when items are added to the
[ComboBox](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.ComboBox 'System.Windows.Forms.ComboBox') one at a time.

##### Parameters

This method has no parameters.

<a name='M-xyLOGIX-Core-Extensions-IComboBox-EndUpdate'></a>
### EndUpdate() `method`

##### Summary

Resumes painting the [ComboBox](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.ComboBox 'System.Windows.Forms.ComboBox')
control after painting is suspended by the
[BeginUpdate](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.ComboBox.BeginUpdate 'System.Windows.Forms.ComboBox.BeginUpdate') method.

##### Parameters

This method has no parameters.

<a name='M-xyLOGIX-Core-Extensions-IComboBox-FindString-System-String-'></a>
### FindString(s) `method`

##### Summary

Returns the index of the first item in the
[ComboBox](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.ComboBox 'System.Windows.Forms.ComboBox') that starts with the specified
string.

##### Returns

The zero-based index of the first item found; returns -1 if no match
is found.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| s | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') to search for. |

<a name='M-xyLOGIX-Core-Extensions-IComboBox-FindString-System-String,System-Int32-'></a>
### FindString(s,startIndex) `method`

##### Summary

Returns the index of the first item in the
[ComboBox](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.ComboBox 'System.Windows.Forms.ComboBox') beyond the specified index that
contains the specified string. The search is not case sensitive.

##### Returns

The zero-based index of the first item found; returns -1 if no match
is found, or 0 if the `s` parameter specifies
[Empty](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String.Empty 'System.String.Empty').

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| s | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') to search for. |
| startIndex | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The zero-based index of the item before the first
item to be searched. Set to -1 to search from the beginning of the control. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentOutOfRangeException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentOutOfRangeException 'System.ArgumentOutOfRangeException') | The
`startIndex` is less than -1. -or- The
`startIndex` is greater than the last index in the
collection. |

<a name='M-xyLOGIX-Core-Extensions-IComboBox-FindStringExact-System-String-'></a>
### FindStringExact(s) `method`

##### Summary

Finds the first item in the combo box that matches the specified
string.

##### Returns

The zero-based index of the first item found; returns -1 if no match
is found, or 0 if the `s` parameter specifies
[Empty](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String.Empty 'System.String.Empty').

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| s | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') to search for. |

<a name='M-xyLOGIX-Core-Extensions-IComboBox-FindStringExact-System-String,System-Int32-'></a>
### FindStringExact(s,startIndex) `method`

##### Summary

Finds the first item after the specified index that matches the
specified string.

##### Returns

The zero-based index of the first item found; returns -1 if no match
is found, or 0 if the `s` parameter specifies
[Empty](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String.Empty 'System.String.Empty').

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| s | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') to search for. |
| startIndex | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The zero-based index of the item before the first
item to be searched. Set to -1 to search from the beginning of the control. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentOutOfRangeException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentOutOfRangeException 'System.ArgumentOutOfRangeException') | The
`startIndex` is less than -1. -or- The
`startIndex` is equal to the last index in the collection. |

<a name='M-xyLOGIX-Core-Extensions-IComboBox-GetItemHeight-System-Int32-'></a>
### GetItemHeight(index) `method`

##### Summary

Returns the height of an item in the
[ComboBox](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.ComboBox 'System.Windows.Forms.ComboBox').

##### Returns

The height, in pixels, of the item at the specified index.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| index | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The index of the item to return the height of. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentOutOfRangeException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentOutOfRangeException 'System.ArgumentOutOfRangeException') | The
`index` is less than zero. -or- The `index`
is greater than count of items in the list. |

<a name='M-xyLOGIX-Core-Extensions-IComboBox-Select-System-Int32,System-Int32-'></a>
### Select(start,length) `method`

##### Summary

Selects a range of text in the editable portion of the
[ComboBox](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.ComboBox 'System.Windows.Forms.ComboBox').

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| start | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The position of the first character in the current text
selection within the textbox. |
| length | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The number of characters to select. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentException 'System.ArgumentException') | The `start` is
less than zero. -or- `start` plus `length`
is less than zero. |

<a name='M-xyLOGIX-Core-Extensions-IComboBox-SelectAll'></a>
### SelectAll() `method`

##### Summary

Selects all the text in the editable portion of the
[ComboBox](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.ComboBox 'System.Windows.Forms.ComboBox').

##### Parameters

This method has no parameters.

<a name='M-xyLOGIX-Core-Extensions-IComboBox-ToString'></a>
### ToString() `method`

##### Summary

Returns a string that represents the
[ComboBox](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.ComboBox 'System.Windows.Forms.ComboBox') control.

##### Returns

A [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') that represents the current
[ComboBox](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.ComboBox 'System.Windows.Forms.ComboBox') . The string includes the type
and the number of items in the [ComboBox](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.ComboBox 'System.Windows.Forms.ComboBox')
control.

##### Parameters

This method has no parameters.

<a name='T-xyLOGIX-Core-Extensions-IControl'></a>
## IControl `type`

##### Namespace

xyLOGIX.Core.Extensions

##### Summary

Defines the publicly-exposed methods and properties of an object that
represents a WinForms control.

<a name='P-xyLOGIX-Core-Extensions-IControl-AccessibilityObject'></a>
### AccessibilityObject `property`

##### Summary

Gets the [AccessibleObject](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.AccessibleObject 'System.Windows.Forms.AccessibleObject')
assigned to the control.

##### Returns

The [AccessibleObject](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.AccessibleObject 'System.Windows.Forms.AccessibleObject') assigned
to the control.

<a name='P-xyLOGIX-Core-Extensions-IControl-AccessibleDefaultActionDescription'></a>
### AccessibleDefaultActionDescription `property`

##### Summary

Gets or sets the default action description of the control for use by
accessibility client applications.

##### Returns

The default action description of the control for use by
accessibility client applications.

<a name='P-xyLOGIX-Core-Extensions-IControl-AccessibleDescription'></a>
### AccessibleDescription `property`

##### Summary

Gets or sets the description of the control used by accessibility
client applications.

##### Returns

The description of the control used by accessibility client
applications. The default is `null`.

<a name='P-xyLOGIX-Core-Extensions-IControl-AccessibleName'></a>
### AccessibleName `property`

##### Summary

Gets or sets the name of the control used by accessibility client
applications.

##### Returns

The name of the control used by accessibility client applications.
The default is `null`.

<a name='P-xyLOGIX-Core-Extensions-IControl-AccessibleRole'></a>
### AccessibleRole `property`

##### Summary

Gets or sets the accessible role of the control

##### Returns

One of the values of
[AccessibleRole](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.AccessibleRole 'System.Windows.Forms.AccessibleRole') . The default is
`Default`.

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ComponentModel.InvalidEnumArgumentException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ComponentModel.InvalidEnumArgumentException 'System.ComponentModel.InvalidEnumArgumentException') | The
value assigned is not one of the
[AccessibleRole](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.AccessibleRole 'System.Windows.Forms.AccessibleRole') value(s). |

<a name='P-xyLOGIX-Core-Extensions-IControl-AllowDrop'></a>
### AllowDrop `property`

##### Summary

Gets or sets a value indicating whether the control can accept data
that the user drags onto it.

##### Returns

`true` if drag-and-drop operations are allowed in
the control; otherwise, `false`. The default is
`false`.

<a name='P-xyLOGIX-Core-Extensions-IControl-Anchor'></a>
### Anchor `property`

##### Summary

Gets or sets the edges of the container to which a control is bound
and determines how a control is resized with its parent.

##### Returns

A bitwise combination of the
[AnchorStyles](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.AnchorStyles 'System.Windows.Forms.AnchorStyles') value(s). The default is
`Top` and `Left`.

<a name='P-xyLOGIX-Core-Extensions-IControl-AutoScrollOffset'></a>
### AutoScrollOffset `property`

##### Summary

Gets or sets where this control is scrolled to in
[ScrollControlIntoView](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.ScrollableControl.ScrollControlIntoView 'System.Windows.Forms.ScrollableControl.ScrollControlIntoView(System.Windows.Forms.Control)')
.

##### Returns

A [Point](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Drawing.Point 'System.Drawing.Point') specifying the scroll
location. The default is the upper-left corner of the control.

<a name='P-xyLOGIX-Core-Extensions-IControl-AutoSize'></a>
### AutoSize `property`

##### Summary

Gets or sets a value indicating whether the height of the control
automatically adjusts when the font assigned to the control is changed.

##### Returns

`true` if the height of the control automatically adjusts when
the font is changed; otherwise, `false`. The default is
`true`.

##### Remarks

This property raises the
[](#E-System-Windows-Forms-Control-AutoSizeChanged 'System.Windows.Forms.Control.AutoSizeChanged') event when its
value is updated.

<a name='P-xyLOGIX-Core-Extensions-IControl-BackColor'></a>
### BackColor `property`

##### Summary

Gets or sets the background color for the control.

##### Returns

A [Color](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Drawing.Color 'System.Drawing.Color') that represents the
background color of the control. The default is the value of the
[DefaultBackColor](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.Control.DefaultBackColor 'System.Windows.Forms.Control.DefaultBackColor') property.

<a name='P-xyLOGIX-Core-Extensions-IControl-BackgroundImage'></a>
### BackgroundImage `property`

##### Summary

Gets or sets the background image displayed in the control.

##### Returns

An [Image](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Drawing.Image 'System.Drawing.Image') that represents the image to
display in the background of the control.

<a name='P-xyLOGIX-Core-Extensions-IControl-BackgroundImageLayout'></a>
### BackgroundImageLayout `property`

##### Summary

Gets or sets the background image layout as defined in the
[ImageLayout](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.ImageLayout 'System.Windows.Forms.ImageLayout') enumeration.

##### Returns

One of the values of
[ImageLayout](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.ImageLayout 'System.Windows.Forms.ImageLayout') (
[Center](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.ImageLayout.Center 'System.Windows.Forms.ImageLayout.Center') ,
[None](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.ImageLayout.None 'System.Windows.Forms.ImageLayout.None') ,
[Stretch](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.ImageLayout.Stretch 'System.Windows.Forms.ImageLayout.Stretch') ,
[Tile](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.ImageLayout.Tile 'System.Windows.Forms.ImageLayout.Tile') , or
[Zoom](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.ImageLayout.Zoom 'System.Windows.Forms.ImageLayout.Zoom') ).
[Tile](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.ImageLayout.Tile 'System.Windows.Forms.ImageLayout.Tile') is the default value.

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ComponentModel.InvalidEnumArgumentException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ComponentModel.InvalidEnumArgumentException 'System.ComponentModel.InvalidEnumArgumentException') | The
specified enumeration value does not exist. |

<a name='P-xyLOGIX-Core-Extensions-IControl-BindingContext'></a>
### BindingContext `property`

##### Summary

Gets or sets the [BindingContext](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.BindingContext 'System.Windows.Forms.BindingContext')
for the control.

##### Returns

A [BindingContext](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.BindingContext 'System.Windows.Forms.BindingContext') for the
control.

<a name='P-xyLOGIX-Core-Extensions-IControl-Bottom'></a>
### Bottom `property`

##### Summary

Gets the distance, in pixels, between the bottom edge of the control
and the top edge of its container's client area.

##### Returns

An [Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') representing the distance, in
pixels, between the bottom edge of the control and the top edge of its
container's client area.

<a name='P-xyLOGIX-Core-Extensions-IControl-Bounds'></a>
### Bounds `property`

##### Summary

Gets or sets the size and location of the control including its
nonclient elements, in pixels, relative to the parent control.

##### Returns

A [Rectangle](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Drawing.Rectangle 'System.Drawing.Rectangle') in pixels relative to the
parent control that represents the size and location of the control including
its nonclient elements.

<a name='P-xyLOGIX-Core-Extensions-IControl-CanFocus'></a>
### CanFocus `property`

##### Summary

Gets a value indicating whether the control can receive focus.

##### Returns

`true` if the control can receive focus; otherwise,
`false`.

<a name='P-xyLOGIX-Core-Extensions-IControl-CanSelect'></a>
### CanSelect `property`

##### Summary

Gets a value indicating whether the control can be selected.

##### Returns

`true` if the control can be selected; otherwise,
`false`.

<a name='P-xyLOGIX-Core-Extensions-IControl-Capture'></a>
### Capture `property`

##### Summary

Gets or sets a value indicating whether the control has captured the
mouse.

##### Returns

`true` if the control has captured the mouse;
otherwise, `false`.

<a name='P-xyLOGIX-Core-Extensions-IControl-CausesValidation'></a>
### CausesValidation `property`

##### Summary

Gets or sets a value indicating whether the control causes validation
to be performed on any controls that require validation when it receives focus.

##### Returns

`true` if the control causes validation to be
performed on any controls requiring validation when it receives focus;
otherwise, `false`. The default is `true`.

<a name='P-xyLOGIX-Core-Extensions-IControl-ClientRectangle'></a>
### ClientRectangle `property`

##### Summary

Gets the rectangle that represents the client area of the control.

##### Returns

A [Rectangle](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Drawing.Rectangle 'System.Drawing.Rectangle') that represents the
client area of the control.

<a name='P-xyLOGIX-Core-Extensions-IControl-ClientSize'></a>
### ClientSize `property`

##### Summary

Gets or sets the height and width of the client area of the control.

##### Returns

A [Size](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Drawing.Size 'System.Drawing.Size') that represents the dimensions
of the client area of the control.

<a name='P-xyLOGIX-Core-Extensions-IControl-CompanyName'></a>
### CompanyName `property`

##### Summary

Gets the name of the company or creator of the application containing
the control.

##### Returns

The company name or creator of the application containing the
control.

<a name='P-xyLOGIX-Core-Extensions-IControl-ContainsFocus'></a>
### ContainsFocus `property`

##### Summary

Gets a value indicating whether the control, or one of its child
controls, currently has the input focus.

##### Returns

`true` if the control or one of its child controls
currently has the input focus; otherwise, `false`.

<a name='P-xyLOGIX-Core-Extensions-IControl-ContextMenu'></a>
### ContextMenu `property`

##### Summary

Gets or sets the shortcut menu associated with the control.

##### Returns

A [ContextMenu](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.ContextMenu 'System.Windows.Forms.ContextMenu') that represents
the shortcut menu associated with the control.

<a name='P-xyLOGIX-Core-Extensions-IControl-ContextMenuStrip'></a>
### ContextMenuStrip `property`

##### Summary

Gets or sets the
[ContextMenuStrip](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.ContextMenuStrip 'System.Windows.Forms.ContextMenuStrip') associated with this
control.

##### Returns

The [ContextMenuStrip](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.ContextMenuStrip 'System.Windows.Forms.ContextMenuStrip') for this
control, or `null` if there is no
[ContextMenuStrip](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.ContextMenuStrip 'System.Windows.Forms.ContextMenuStrip') . The default is
`null`.

<a name='P-xyLOGIX-Core-Extensions-IControl-Controls'></a>
### Controls `property`

##### Summary

Gets the collection of controls contained within the control.

##### Returns

A [ControlCollection](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.Control.ControlCollection 'System.Windows.Forms.Control.ControlCollection')
representing the collection of controls contained within the control.

<a name='P-xyLOGIX-Core-Extensions-IControl-Created'></a>
### Created `property`

##### Summary

Gets a value indicating whether the control has been created.

##### Returns

`true` if the control has been created; otherwise,
`false`.

<a name='P-xyLOGIX-Core-Extensions-IControl-Cursor'></a>
### Cursor `property`

##### Summary

Gets or sets the cursor that is displayed when the mouse pointer is
over the control.

##### Returns

A [Cursor](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.Cursor 'System.Windows.Forms.Cursor') that represents the
cursor to display when the mouse pointer is over the control.

<a name='P-xyLOGIX-Core-Extensions-IControl-DataBindings'></a>
### DataBindings `property`

##### Summary

Gets the data bindings for the control.

##### Returns

A [ControlBindingsCollection](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.ControlBindingsCollection 'System.Windows.Forms.ControlBindingsCollection')
that contains the [Binding](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.Binding 'System.Windows.Forms.Binding') objects for the
control.

<a name='P-xyLOGIX-Core-Extensions-IControl-DeviceDpi'></a>
### DeviceDpi `property`

##### Summary

Gets the DPI value for the display device where the control is
currently being displayed.

##### Returns

The DPI value of the display device.

<a name='P-xyLOGIX-Core-Extensions-IControl-DisplayRectangle'></a>
### DisplayRectangle `property`

##### Summary

Gets the rectangle that represents the display area of the control.

##### Returns

A [Rectangle](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Drawing.Rectangle 'System.Drawing.Rectangle') that represents the
display area of the control.

<a name='P-xyLOGIX-Core-Extensions-IControl-Disposing'></a>
### Disposing `property`

##### Summary

Gets a value indicating whether the base
[Control](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.Control 'System.Windows.Forms.Control') class is in the process of
disposing.

##### Returns

`true` if the base
[Control](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.Control 'System.Windows.Forms.Control') class is in the process of
disposing; otherwise, `false`.

<a name='P-xyLOGIX-Core-Extensions-IControl-Dock'></a>
### Dock `property`

##### Summary

Gets or sets which control borders are docked to its parent control
and determines how a control is resized with its parent.

##### Returns

One of the [DockStyle](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.DockStyle 'System.Windows.Forms.DockStyle') value(s).
The default is [None](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.DockStyle.None 'System.Windows.Forms.DockStyle.None').

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ComponentModel.InvalidEnumArgumentException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ComponentModel.InvalidEnumArgumentException 'System.ComponentModel.InvalidEnumArgumentException') | The
value assigned is not one of the
[DockStyle](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.DockStyle 'System.Windows.Forms.DockStyle') value(s). |

<a name='P-xyLOGIX-Core-Extensions-IControl-Enabled'></a>
### Enabled `property`

##### Summary

Gets or sets a value indicating whether the control can respond to
user interaction.

##### Returns

`true` if the control can respond to user
interaction; otherwise, `false`. The default is
`true`.

<a name='P-xyLOGIX-Core-Extensions-IControl-Focused'></a>
### Focused `property`

##### Summary

Gets a value indicating whether the control has input focus.

##### Returns

`true` if the control has focus; otherwise,
`false`.

<a name='P-xyLOGIX-Core-Extensions-IControl-Font'></a>
### Font `property`

##### Summary

Gets or sets the font of the text displayed by the control.

##### Returns

The [Font](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Drawing.Font 'System.Drawing.Font') to apply to the text
displayed by the control. The default is the value of the
[DefaultFont](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.Control.DefaultFont 'System.Windows.Forms.Control.DefaultFont') property.

<a name='P-xyLOGIX-Core-Extensions-IControl-ForeColor'></a>
### ForeColor `property`

##### Summary

Gets or sets the foreground color of the control.

##### Returns

The foreground [Color](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Drawing.Color 'System.Drawing.Color') of the control.
The default is the value of the
[DefaultForeColor](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.Control.DefaultForeColor 'System.Windows.Forms.Control.DefaultForeColor') property.

<a name='P-xyLOGIX-Core-Extensions-IControl-Handle'></a>
### Handle `property`

##### Summary

Gets the window handle that the control is bound to.

##### Returns

An [IntPtr](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IntPtr 'System.IntPtr') that contains the window handle (
`HWND`) of the control.

<a name='P-xyLOGIX-Core-Extensions-IControl-HasChildren'></a>
### HasChildren `property`

##### Summary

Gets a value indicating whether the control contains one or more
child controls.

##### Returns

`true` if the control contains one or more child
controls; otherwise, `false`.

<a name='P-xyLOGIX-Core-Extensions-IControl-Height'></a>
### Height `property`

##### Summary

Gets or sets the height of the control.

##### Returns

The height of the control in pixels.

<a name='P-xyLOGIX-Core-Extensions-IControl-ImeMode'></a>
### ImeMode `property`

##### Summary

Gets or sets the Input Method Editor (IME) mode of the control.

##### Returns

One of the [ImeMode](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.ImeMode 'System.Windows.Forms.ImeMode') value(s). The
default is [Inherit](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.ImeMode.Inherit 'System.Windows.Forms.ImeMode.Inherit').

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ComponentModel.InvalidEnumArgumentException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ComponentModel.InvalidEnumArgumentException 'System.ComponentModel.InvalidEnumArgumentException') | The
assigned value is not one of the [ImeMode](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.ImeMode 'System.Windows.Forms.ImeMode')
enumeration values. |

<a name='P-xyLOGIX-Core-Extensions-IControl-IsAccessible'></a>
### IsAccessible `property`

##### Summary

Gets or sets a value indicating whether the control is visible to
accessibility applications.

##### Returns

`true` if the control is visible to accessibility
applications; otherwise, `false`.

<a name='P-xyLOGIX-Core-Extensions-IControl-IsDisposed'></a>
### IsDisposed `property`

##### Summary

Gets a value indicating whether the control has been disposed of.

##### Returns

`true` if the control has been disposed of;
otherwise, `false`.

<a name='P-xyLOGIX-Core-Extensions-IControl-IsHandleCreated'></a>
### IsHandleCreated `property`

##### Summary

Gets a value indicating whether the control has a handle associated
with it.

##### Returns

`true` if a handle has been assigned to the control;
otherwise, `false`.

<a name='P-xyLOGIX-Core-Extensions-IControl-IsMirrored'></a>
### IsMirrored `property`

##### Summary

Gets a value indicating whether the control is mirrored.

##### Returns

`true` if the control is mirrored; otherwise,
`false`.

<a name='P-xyLOGIX-Core-Extensions-IControl-LayoutEngine'></a>
### LayoutEngine `property`

##### Summary

Gets a cached instance of the control's layout engine.

##### Returns

The [LayoutEngine](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.Layout.LayoutEngine 'System.Windows.Forms.Layout.LayoutEngine') for the
control's contents.

<a name='P-xyLOGIX-Core-Extensions-IControl-Left'></a>
### Left `property`

##### Summary

Gets or sets the distance, in pixels, between the left edge of the
control and the left edge of its container's client area.

##### Returns

An [Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') representing the distance, in
pixels, between the left edge of the control and the left edge of its
container's client area.

<a name='P-xyLOGIX-Core-Extensions-IControl-Location'></a>
### Location `property`

##### Summary

Gets or sets the coordinates of the upper-left corner of the control
relative to the upper-left corner of its container.

##### Returns

The [Point](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Drawing.Point 'System.Drawing.Point') that represents the
upper-left corner of the control relative to the upper-left corner of its
container.

<a name='P-xyLOGIX-Core-Extensions-IControl-Margin'></a>
### Margin `property`

##### Summary

Gets or sets the space between controls.

##### Returns

A [Padding](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.Padding 'System.Windows.Forms.Padding') representing the
space between controls.

<a name='P-xyLOGIX-Core-Extensions-IControl-MaximumSize'></a>
### MaximumSize `property`

##### Summary

Gets or sets the size that is the upper limit that
[GetPreferredSize](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.Control.GetPreferredSize 'System.Windows.Forms.Control.GetPreferredSize(System.Drawing.Size)')
can specify.

##### Returns

An ordered pair of type [Size](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Drawing.Size 'System.Drawing.Size')
representing the width and height of a rectangle.

<a name='P-xyLOGIX-Core-Extensions-IControl-MinimumSize'></a>
### MinimumSize `property`

##### Summary

Gets or sets the size that is the lower limit that
[GetPreferredSize](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.Control.GetPreferredSize 'System.Windows.Forms.Control.GetPreferredSize(System.Drawing.Size)')
can specify.

##### Returns

An ordered pair of type [Size](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Drawing.Size 'System.Drawing.Size')
representing the width and height of a rectangle.

<a name='P-xyLOGIX-Core-Extensions-IControl-Name'></a>
### Name `property`

##### Summary

Gets or sets the name of the control.

##### Returns

The name of the control. The default is an empty string ("").

<a name='P-xyLOGIX-Core-Extensions-IControl-Padding'></a>
### Padding `property`

##### Summary

Gets or sets padding within the control.

##### Returns

A [Padding](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.Padding 'System.Windows.Forms.Padding') representing the
control's public spacing characteristics.

<a name='P-xyLOGIX-Core-Extensions-IControl-Parent'></a>
### Parent `property`

##### Summary

Gets or sets the parent container of the control.

##### Returns

A [Control](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.Control 'System.Windows.Forms.Control') that represents the
parent or container control of the control.

<a name='P-xyLOGIX-Core-Extensions-IControl-PreferredSize'></a>
### PreferredSize `property`

##### Summary

Gets the size of a rectangular area into which the control can fit.

##### Returns

A [Size](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Drawing.Size 'System.Drawing.Size') containing the height and
width, in pixels.

<a name='P-xyLOGIX-Core-Extensions-IControl-ProductName'></a>
### ProductName `property`

##### Summary

Gets the product name of the assembly containing the control.

##### Returns

The product name of the assembly containing the control.

<a name='P-xyLOGIX-Core-Extensions-IControl-ProductVersion'></a>
### ProductVersion `property`

##### Summary

Gets the version of the assembly containing the control.

##### Returns

The file version of the assembly containing the control.

<a name='P-xyLOGIX-Core-Extensions-IControl-RecreatingHandle'></a>
### RecreatingHandle `property`

##### Summary

Gets a value indicating whether the control is currently re-creating
its handle.

##### Returns

`true` if the control is currently re-creating its
handle; otherwise, `false`.

<a name='P-xyLOGIX-Core-Extensions-IControl-Region'></a>
### Region `property`

##### Summary

Gets or sets the window region associated with the control.

##### Returns

The window [Region](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Drawing.Region 'System.Drawing.Region') associated with the
control.

<a name='P-xyLOGIX-Core-Extensions-IControl-Right'></a>
### Right `property`

##### Summary

Gets the distance, in pixels, between the right edge of the control
and the left edge of its container's client area.

##### Returns

An [Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') representing the distance, in
pixels, between the right edge of the control and the left edge of its
container's client area.

<a name='P-xyLOGIX-Core-Extensions-IControl-RightToLeft'></a>
### RightToLeft `property`

##### Summary

Gets or sets a value indicating whether control's elements are
aligned to support locales using right-to-left fonts.

##### Returns

One of the [RightToLeft](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.RightToLeft 'System.Windows.Forms.RightToLeft') value(s).
The default is [Inherit](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.RightToLeft.Inherit 'System.Windows.Forms.RightToLeft.Inherit').

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ComponentModel.InvalidEnumArgumentException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ComponentModel.InvalidEnumArgumentException 'System.ComponentModel.InvalidEnumArgumentException') | The
assigned value is not one of the
[RightToLeft](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.RightToLeft 'System.Windows.Forms.RightToLeft') value(s). |

<a name='P-xyLOGIX-Core-Extensions-IControl-Size'></a>
### Size `property`

##### Summary

Gets or sets the height and width of the control.

##### Returns

The [Size](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Drawing.Size 'System.Drawing.Size') that represents the height
and width of the control in pixels.

<a name='P-xyLOGIX-Core-Extensions-IControl-TabIndex'></a>
### TabIndex `property`

##### Summary

Gets or sets the tab order of the control within its container.

##### Returns

The index value of the control within the set of controls within its
container. The controls in the container are included in the tab order.

<a name='P-xyLOGIX-Core-Extensions-IControl-TabStop'></a>
### TabStop `property`

##### Summary

Gets or sets a value indicating whether the user can give the focus
to this control using the TAB key.

##### Returns

`true` if the user can give the focus to the control
using the TAB key; otherwise, `false`. The default is
`true`. This property will always return
`true` for an instance of the
[Form](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.Form 'System.Windows.Forms.Form') class.

<a name='P-xyLOGIX-Core-Extensions-IControl-Tag'></a>
### Tag `property`

##### Summary

Gets or sets the object that contains data about the control.

##### Returns

An [Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') that contains data about the
control. The default is `null`.

<a name='P-xyLOGIX-Core-Extensions-IControl-Text'></a>
### Text `property`

##### Summary

Gets or sets the text associated with this control.

##### Returns

The text associated with this control.

<a name='P-xyLOGIX-Core-Extensions-IControl-Top'></a>
### Top `property`

##### Summary

Gets or sets the distance, in pixels, between the top edge of the
control and the top edge of its container's client area.

##### Returns

An [Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') representing the distance, in
pixels, between the bottom edge of the control and the top edge of its
container's client area.

<a name='P-xyLOGIX-Core-Extensions-IControl-TopLevelControl'></a>
### TopLevelControl `property`

##### Summary

Gets the parent control that is not parented by another Windows Forms
control. Typically, this is the outermost
[Form](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.Form 'System.Windows.Forms.Form') that the control is contained in.

##### Returns

The [Control](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.Control 'System.Windows.Forms.Control') that represents the
top-level control that contains the current control.

<a name='P-xyLOGIX-Core-Extensions-IControl-UseWaitCursor'></a>
### UseWaitCursor `property`

##### Summary

Gets or sets a value indicating whether to use the wait cursor for
the current control and all child controls.

##### Returns

`true` to use the wait cursor for the current
control and all child controls; otherwise, `false`. The
default is `false`.

<a name='P-xyLOGIX-Core-Extensions-IControl-Visible'></a>
### Visible `property`

##### Summary

Gets or sets a value indicating whether the control and all its child
controls are displayed.

##### Returns

`true` if the control and all its child controls are
displayed; otherwise, `false`. The default is
`true`.

<a name='P-xyLOGIX-Core-Extensions-IControl-Width'></a>
### Width `property`

##### Summary

Gets or sets the width of the control.

##### Returns

The width of the control in pixels.

<a name='P-xyLOGIX-Core-Extensions-IControl-WindowTarget'></a>
### WindowTarget `property`

##### Summary

This property is not relevant for this class.

##### Returns

The NativeWindow contained within the control.

<a name='M-xyLOGIX-Core-Extensions-IControl-BeginInvoke-System-Delegate-'></a>
### BeginInvoke(method) `method`

##### Summary

Executes the specified delegate asynchronously on the thread that the
control's underlying handle was created on.

##### Returns

An [IAsyncResult](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IAsyncResult 'System.IAsyncResult') that represents the result of
the [BeginInvoke](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.Control.BeginInvoke 'System.Windows.Forms.Control.BeginInvoke(System.Delegate)')
operation.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| method | [System.Delegate](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Delegate 'System.Delegate') | A delegate to a method that takes no parameters. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.InvalidOperationException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.InvalidOperationException 'System.InvalidOperationException') | No appropriate window
handle can be found. |

<a name='M-xyLOGIX-Core-Extensions-IControl-BringToFront'></a>
### BringToFront() `method`

##### Summary

Brings the control to the front of the z-order.

##### Parameters

This method has no parameters.

<a name='M-xyLOGIX-Core-Extensions-IControl-Contains-System-Windows-Forms-Control-'></a>
### Contains(ctl) `method`

##### Summary

Retrieves a value indicating whether the specified control is a child
of the control.

##### Returns

`true` if the specified control is a child of the
control; otherwise, `false`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| ctl | [System.Windows.Forms.Control](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.Control 'System.Windows.Forms.Control') | The [Control](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.Control 'System.Windows.Forms.Control') to
evaluate. |

<a name='M-xyLOGIX-Core-Extensions-IControl-CreateControl'></a>
### CreateControl() `method`

##### Summary

Forces the creation of the visible control, including the creation of
the handle and any visible child controls.

##### Parameters

This method has no parameters.

<a name='M-xyLOGIX-Core-Extensions-IControl-CreateGraphics'></a>
### CreateGraphics() `method`

##### Summary

Creates the [Graphics](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Drawing.Graphics 'System.Drawing.Graphics') for the control.

##### Returns

The [Graphics](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Drawing.Graphics 'System.Drawing.Graphics') for the control.

##### Parameters

This method has no parameters.

<a name='M-xyLOGIX-Core-Extensions-IControl-DoDragDrop-System-Object,System-Windows-Forms-DragDropEffects-'></a>
### DoDragDrop(data,allowedEffects) `method`

##### Summary

Begins a drag-and-drop operation.

##### Returns

A value from the
[DragDropEffects](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.DragDropEffects 'System.Windows.Forms.DragDropEffects') enumeration that
represents the final effect that was performed during the drag-and-drop
operation.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| data | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | The data to drag. |
| allowedEffects | [System.Windows.Forms.DragDropEffects](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.DragDropEffects 'System.Windows.Forms.DragDropEffects') | One of the
[DragDropEffects](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.DragDropEffects 'System.Windows.Forms.DragDropEffects') value(s). |

<a name='M-xyLOGIX-Core-Extensions-IControl-DrawToBitmap-System-Drawing-Bitmap,System-Drawing-Rectangle-'></a>
### DrawToBitmap(bitmap,targetBounds) `method`

##### Summary

Supports rendering to the specified bitmap.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| bitmap | [System.Drawing.Bitmap](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Drawing.Bitmap 'System.Drawing.Bitmap') | The bitmap to be drawn to. |
| targetBounds | [System.Drawing.Rectangle](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Drawing.Rectangle 'System.Drawing.Rectangle') | The bounds within which the control is rendered. |

<a name='M-xyLOGIX-Core-Extensions-IControl-FindForm'></a>
### FindForm() `method`

##### Summary

Retrieves the form that the control is on.

##### Returns

The [Form](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.Form 'System.Windows.Forms.Form') that the control is
on.

##### Parameters

This method has no parameters.

<a name='M-xyLOGIX-Core-Extensions-IControl-Focus'></a>
### Focus() `method`

##### Summary

Sets input focus to the control.

##### Returns

`true` if the input focus request was successful;
otherwise, `false`.

##### Parameters

This method has no parameters.

<a name='M-xyLOGIX-Core-Extensions-IControl-GetChildAtPoint-System-Drawing-Point,System-Windows-Forms-GetChildAtPointSkip-'></a>
### GetChildAtPoint(pt,skipValue) `method`

##### Summary

Retrieves the child control that is located at the specified
coordinates, specifying whether to ignore child controls of a certain type.

##### Returns

The child [Control](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.Control 'System.Windows.Forms.Control') at the
specified coordinates.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| pt | [System.Drawing.Point](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Drawing.Point 'System.Drawing.Point') | A [Point](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Drawing.Point 'System.Drawing.Point') that contains the
coordinates where you want to look for a control. Coordinates are expressed
relative to the upper-left corner of the control's client area. |
| skipValue | [System.Windows.Forms.GetChildAtPointSkip](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.GetChildAtPointSkip 'System.Windows.Forms.GetChildAtPointSkip') | One of the values of
[GetChildAtPointSkip](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.GetChildAtPointSkip 'System.Windows.Forms.GetChildAtPointSkip') , determining whether
to ignore child controls of a certain type. |

<a name='M-xyLOGIX-Core-Extensions-IControl-GetChildAtPoint-System-Drawing-Point-'></a>
### GetChildAtPoint(pt) `method`

##### Summary

Retrieves the child control that is located at the specified
coordinates.

##### Returns

A [Control](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.Control 'System.Windows.Forms.Control') that represents the
control that is located at the specified point.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| pt | [System.Drawing.Point](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Drawing.Point 'System.Drawing.Point') | A [Point](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Drawing.Point 'System.Drawing.Point') that contains the
coordinates where you want to look for a control. Coordinates are expressed
relative to the upper-left corner of the control's client area. |

<a name='M-xyLOGIX-Core-Extensions-IControl-GetContainerControl'></a>
### GetContainerControl() `method`

##### Summary

Returns the next
[ContainerControl](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.ContainerControl 'System.Windows.Forms.ContainerControl') up the control's chain
of parent controls.

##### Returns

An [IContainerControl](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.IContainerControl 'System.Windows.Forms.IContainerControl'), that
represents the parent of the [Control](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.Control 'System.Windows.Forms.Control').

##### Parameters

This method has no parameters.

<a name='M-xyLOGIX-Core-Extensions-IControl-GetNextControl-System-Windows-Forms-Control,System-Boolean-'></a>
### GetNextControl(ctl,forward) `method`

##### Summary

Retrieves the next control forward or back in the tab order of child
controls.

##### Returns

The next [Control](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.Control 'System.Windows.Forms.Control') in the tab
order.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| ctl | [System.Windows.Forms.Control](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.Control 'System.Windows.Forms.Control') | The [Control](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.Control 'System.Windows.Forms.Control') to start
the search with. |
| forward | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | `true` to search forward in the tab
order; `false` to search backward. |

<a name='M-xyLOGIX-Core-Extensions-IControl-GetPreferredSize-System-Drawing-Size-'></a>
### GetPreferredSize(proposedSize) `method`

##### Summary

Retrieves the size of a rectangular area into which a control can be
fitted.

##### Returns

An ordered pair of type [Size](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Drawing.Size 'System.Drawing.Size')
representing the width and height of a rectangle.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| proposedSize | [System.Drawing.Size](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Drawing.Size 'System.Drawing.Size') | The custom-sized area for a control. |

<a name='M-xyLOGIX-Core-Extensions-IControl-Hide'></a>
### Hide() `method`

##### Summary

Conceals the control from the user.

##### Parameters

This method has no parameters.

<a name='M-xyLOGIX-Core-Extensions-IControl-Invalidate-System-Drawing-Region-'></a>
### Invalidate(region) `method`

##### Summary

Invalidates the specified region of the control (adds it to the
control's update region, which is the area that will be repainted at the next
paint operation), and causes a paint message to be sent to the control.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| region | [System.Drawing.Region](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Drawing.Region 'System.Drawing.Region') | The [Region](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Drawing.Region 'System.Drawing.Region') to
invalidate. |

<a name='M-xyLOGIX-Core-Extensions-IControl-Invalidate-System-Drawing-Region,System-Boolean-'></a>
### Invalidate(region,invalidateChildren) `method`

##### Summary

Invalidates the specified region of the control (adds it to the
control's update region, which is the area that will be repainted at the next
paint operation), and causes a paint message to be sent to the control.
Optionally, invalidates the child controls assigned to the control.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| region | [System.Drawing.Region](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Drawing.Region 'System.Drawing.Region') | The [Region](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Drawing.Region 'System.Drawing.Region') to
invalidate. |
| invalidateChildren | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | `true` to invalidate the
control's child controls; otherwise, `false`. |

<a name='M-xyLOGIX-Core-Extensions-IControl-Invalidate'></a>
### Invalidate() `method`

##### Summary

Invalidates the entire surface of the control and causes the control
to be redrawn.

##### Parameters

This method has no parameters.

<a name='M-xyLOGIX-Core-Extensions-IControl-Invalidate-System-Boolean-'></a>
### Invalidate(invalidateChildren) `method`

##### Summary

Invalidates a specific region of the control and causes a paint
message to be sent to the control. Optionally, invalidates the child controls
assigned to the control.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| invalidateChildren | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | `true` to invalidate the
control's child controls; otherwise, `false`. |

<a name='M-xyLOGIX-Core-Extensions-IControl-Invalidate-System-Drawing-Rectangle-'></a>
### Invalidate(rc) `method`

##### Summary

Invalidates the specified region of the control (adds it to the
control's update region, which is the area that will be repainted at the next
paint operation), and causes a paint message to be sent to the control.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| rc | [System.Drawing.Rectangle](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Drawing.Rectangle 'System.Drawing.Rectangle') | A [Rectangle](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Drawing.Rectangle 'System.Drawing.Rectangle') that represents
the region to invalidate. |

<a name='M-xyLOGIX-Core-Extensions-IControl-Invalidate-System-Drawing-Rectangle,System-Boolean-'></a>
### Invalidate(rc,invalidateChildren) `method`

##### Summary

Invalidates the specified region of the control (adds it to the
control's update region, which is the area that will be repainted at the next
paint operation), and causes a paint message to be sent to the control.
Optionally, invalidates the child controls assigned to the control.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| rc | [System.Drawing.Rectangle](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Drawing.Rectangle 'System.Drawing.Rectangle') | A [Rectangle](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Drawing.Rectangle 'System.Drawing.Rectangle') that represents
the region to invalidate. |
| invalidateChildren | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | `true` to invalidate the
control's child controls; otherwise, `false`. |

<a name='M-xyLOGIX-Core-Extensions-IControl-Invoke-System-Delegate-'></a>
### Invoke(method) `method`

##### Summary

Executes the specified delegate on the thread that owns the control's
underlying window handle.

##### Returns

The return value from the delegate being invoked, or
`null` if the delegate has no return value.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| method | [System.Delegate](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Delegate 'System.Delegate') | A delegate that contains a method to be called in the
control's thread context. |

<a name='M-xyLOGIX-Core-Extensions-IControl-LogicalToDeviceUnits-System-Int32-'></a>
### LogicalToDeviceUnits(value) `method`

##### Summary

Converts a Logical DPI value to its equivalent DeviceUnit DPI value.

##### Returns

The resulting DeviceUnit value.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The Logical value to convert. |

<a name='M-xyLOGIX-Core-Extensions-IControl-LogicalToDeviceUnits-System-Drawing-Size-'></a>
### LogicalToDeviceUnits(value) `method`

##### Summary

Transforms a size from logical to device units by scaling it for the
current DPI and rounding down to the nearest integer value for width and
height.

##### Returns

The scaled size.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.Drawing.Size](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Drawing.Size 'System.Drawing.Size') | The size to be scaled. |

<a name='M-xyLOGIX-Core-Extensions-IControl-PerformLayout'></a>
### PerformLayout() `method`

##### Summary

Forces the control to apply layout logic to all its child controls.

##### Parameters

This method has no parameters.

<a name='M-xyLOGIX-Core-Extensions-IControl-PerformLayout-System-Windows-Forms-Control,System-String-'></a>
### PerformLayout(affectedControl,affectedProperty) `method`

##### Summary

Forces the control to apply layout logic to all its child controls.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| affectedControl | [System.Windows.Forms.Control](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.Control 'System.Windows.Forms.Control') | A [Control](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.Control 'System.Windows.Forms.Control')
that represents the most recently changed control. |
| affectedProperty | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The name of the most recently changed property
on the control. |

<a name='M-xyLOGIX-Core-Extensions-IControl-PointToClient-System-Drawing-Point-'></a>
### PointToClient(p) `method`

##### Summary

Computes the location of the specified screen point into client
coordinates.

##### Returns

A [Point](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Drawing.Point 'System.Drawing.Point') that represents the converted
[Point](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Drawing.Point 'System.Drawing.Point'), `p`, in client
coordinates.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| p | [System.Drawing.Point](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Drawing.Point 'System.Drawing.Point') | The screen coordinate [Point](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Drawing.Point 'System.Drawing.Point') to
convert. |

<a name='M-xyLOGIX-Core-Extensions-IControl-PointToScreen-System-Drawing-Point-'></a>
### PointToScreen(p) `method`

##### Summary

Computes the location of the specified client point into screen
coordinates.

##### Returns

A [Point](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Drawing.Point 'System.Drawing.Point') that represents the converted
[Point](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Drawing.Point 'System.Drawing.Point'), `p`, in screen
coordinates.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| p | [System.Drawing.Point](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Drawing.Point 'System.Drawing.Point') | The client coordinate [Point](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Drawing.Point 'System.Drawing.Point') to
convert. |

<a name='M-xyLOGIX-Core-Extensions-IControl-PreProcessControlMessage-System-Windows-Forms-Message@-'></a>
### PreProcessControlMessage(msg) `method`

##### Summary

Preprocesses keyboard or input messages within the message loop
before they are dispatched.

##### Returns

One of the [PreProcessControlState](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.PreProcessControlState 'System.Windows.Forms.PreProcessControlState') value(s),
depending on whether
[PreProcessMessage](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.Control.PreProcessMessage 'System.Windows.Forms.Control.PreProcessMessage(ref System.Windows.Forms.Message)')
is `true` or `false` and whether
[IsInputKey](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.Control.IsInputKey 'System.Windows.Forms.Control.IsInputKey(System.Windows.Forms.Keys)')
or [IsInputChar](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.Control.IsInputChar 'System.Windows.Forms.Control.IsInputChar(System.Char)') are
`true` or `false`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| msg | [System.Windows.Forms.Message@](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.Message@ 'System.Windows.Forms.Message@') | A [Message](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.Message 'System.Windows.Forms.Message') that
represents the message to process. |

<a name='M-xyLOGIX-Core-Extensions-IControl-PreProcessMessage-System-Windows-Forms-Message@-'></a>
### PreProcessMessage(msg) `method`

##### Summary

Preprocesses keyboard or input messages within the message loop
before they are dispatched.

##### Returns

`true` if the message was processed by the control;
otherwise, `false`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| msg | [System.Windows.Forms.Message@](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.Message@ 'System.Windows.Forms.Message@') | A [Message](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.Message 'System.Windows.Forms.Message'), passed by
reference, that represents the message to process. The possible values are
WM_KEYDOWN, WM_SYSKEYDOWN, WM_CHAR, and WM_SYSCHAR. |

<a name='M-xyLOGIX-Core-Extensions-IControl-RectangleToClient-System-Drawing-Rectangle-'></a>
### RectangleToClient(r) `method`

##### Summary

Computes the size and location of the specified screen rectangle in
client coordinates.

##### Returns

A [Rectangle](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Drawing.Rectangle 'System.Drawing.Rectangle') that represents the
converted [Rectangle](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Drawing.Rectangle 'System.Drawing.Rectangle'), `r` , in
client coordinates.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| r | [System.Drawing.Rectangle](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Drawing.Rectangle 'System.Drawing.Rectangle') | The screen coordinate
[Rectangle](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Drawing.Rectangle 'System.Drawing.Rectangle') to convert. |

<a name='M-xyLOGIX-Core-Extensions-IControl-RectangleToScreen-System-Drawing-Rectangle-'></a>
### RectangleToScreen(r) `method`

##### Summary

Computes the size and location of the specified client rectangle in
screen coordinates.

##### Returns

A [Rectangle](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Drawing.Rectangle 'System.Drawing.Rectangle') that represents the
converted [Rectangle](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Drawing.Rectangle 'System.Drawing.Rectangle'), `r` , in
screen coordinates.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| r | [System.Drawing.Rectangle](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Drawing.Rectangle 'System.Drawing.Rectangle') | The client coordinate
[Rectangle](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Drawing.Rectangle 'System.Drawing.Rectangle') to convert. |

<a name='M-xyLOGIX-Core-Extensions-IControl-Refresh'></a>
### Refresh() `method`

##### Summary

Forces the control to invalidate its client area and immediately
redraw itself and any child controls.

##### Parameters

This method has no parameters.

<a name='M-xyLOGIX-Core-Extensions-IControl-ResetBackColor'></a>
### ResetBackColor() `method`

##### Summary

Resets the [BackColor](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.Control.BackColor 'System.Windows.Forms.Control.BackColor')
property to its default value.

##### Parameters

This method has no parameters.

<a name='M-xyLOGIX-Core-Extensions-IControl-ResetBindings'></a>
### ResetBindings() `method`

##### Summary

Causes a control bound to the
[BindingSource](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.BindingSource 'System.Windows.Forms.BindingSource') to reread all the items in
the list and refresh their displayed values.

##### Parameters

This method has no parameters.

<a name='M-xyLOGIX-Core-Extensions-IControl-ResetCursor'></a>
### ResetCursor() `method`

##### Summary

Resets the [Cursor](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.Control.Cursor 'System.Windows.Forms.Control.Cursor')
property to its default value.

##### Parameters

This method has no parameters.

<a name='M-xyLOGIX-Core-Extensions-IControl-ResetFont'></a>
### ResetFont() `method`

##### Summary

Resets the [Font](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.Control.Font 'System.Windows.Forms.Control.Font')
property to its default value.

##### Parameters

This method has no parameters.

<a name='M-xyLOGIX-Core-Extensions-IControl-ResetForeColor'></a>
### ResetForeColor() `method`

##### Summary

Resets the [ForeColor](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.Control.ForeColor 'System.Windows.Forms.Control.ForeColor')
property to its default value.

##### Parameters

This method has no parameters.

<a name='M-xyLOGIX-Core-Extensions-IControl-ResetImeMode'></a>
### ResetImeMode() `method`

##### Summary

Resets the [ImeMode](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.Control.ImeMode 'System.Windows.Forms.Control.ImeMode')
property to its default value.

##### Parameters

This method has no parameters.

<a name='M-xyLOGIX-Core-Extensions-IControl-ResetRightToLeft'></a>
### ResetRightToLeft() `method`

##### Summary

Resets the [RightToLeft](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.Control.RightToLeft 'System.Windows.Forms.Control.RightToLeft')
property to its default value.

##### Parameters

This method has no parameters.

<a name='M-xyLOGIX-Core-Extensions-IControl-ResetText'></a>
### ResetText() `method`

##### Summary

Resets the [Text](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.Control.Text 'System.Windows.Forms.Control.Text')
property to its default value ( [Empty](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String.Empty 'System.String.Empty')).

##### Parameters

This method has no parameters.

<a name='M-xyLOGIX-Core-Extensions-IControl-ResumeLayout'></a>
### ResumeLayout() `method`

##### Summary

Resumes usual layout logic.

##### Parameters

This method has no parameters.

<a name='M-xyLOGIX-Core-Extensions-IControl-ResumeLayout-System-Boolean-'></a>
### ResumeLayout(performLayout) `method`

##### Summary

Resumes usual layout logic, optionally forcing an immediate layout of
pending layout requests.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| performLayout | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | `true` to execute pending layout
requests; otherwise, `false`. |

<a name='M-xyLOGIX-Core-Extensions-IControl-Scale-System-Single-'></a>
### Scale(ratio) `method`

##### Summary

Scales the control and any child controls.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| ratio | [System.Single](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Single 'System.Single') | The ratio to use for scaling. |

<a name='M-xyLOGIX-Core-Extensions-IControl-Scale-System-Single,System-Single-'></a>
### Scale(dx,dy) `method`

##### Summary

Scales the entire control and any child controls.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| dx | [System.Single](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Single 'System.Single') | The horizontal scaling factor. |
| dy | [System.Single](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Single 'System.Single') | The vertical scaling factor. |

<a name='M-xyLOGIX-Core-Extensions-IControl-Scale-System-Drawing-SizeF-'></a>
### Scale(factor) `method`

##### Summary

Scales the control and all child controls by the specified scaling
factor.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| factor | [System.Drawing.SizeF](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Drawing.SizeF 'System.Drawing.SizeF') | A [SizeF](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Drawing.SizeF 'System.Drawing.SizeF') containing the
horizontal and vertical scaling factors. |

<a name='M-xyLOGIX-Core-Extensions-IControl-ScaleBitmapLogicalToDevice-System-Drawing-Bitmap@-'></a>
### ScaleBitmapLogicalToDevice(logicalBitmap) `method`

##### Summary

Scales a logical bitmap value to it's equivalent device unit value
when a DPI change occurs.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| logicalBitmap | [System.Drawing.Bitmap@](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Drawing.Bitmap@ 'System.Drawing.Bitmap@') | The bitmap to scale. |

<a name='M-xyLOGIX-Core-Extensions-IControl-Select'></a>
### Select() `method`

##### Summary

Activates the control.

##### Parameters

This method has no parameters.

<a name='M-xyLOGIX-Core-Extensions-IControl-SelectNextControl-System-Windows-Forms-Control,System-Boolean,System-Boolean,System-Boolean,System-Boolean-'></a>
### SelectNextControl(ctl,forward,tabStopOnly,nested,wrap) `method`

##### Summary

Activates the next control.

##### Returns

`true` if a control was activated; otherwise,
`false`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| ctl | [System.Windows.Forms.Control](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.Control 'System.Windows.Forms.Control') | The [Control](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.Control 'System.Windows.Forms.Control') at which
to start the search. |
| forward | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | `true` to move forward in the tab
order; `false` to move backward in the tab order. |
| tabStopOnly | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | `true` to ignore the controls with
the [TabStop](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.Control.TabStop 'System.Windows.Forms.Control.TabStop') property set to
`false` ; otherwise, `false`. |
| nested | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | `true` to include nested (children of
child controls) child controls; otherwise, `false`. |
| wrap | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | `true` to continue searching from the
first control in the tab order after the last control has been reached;
otherwise, `false`. |

<a name='M-xyLOGIX-Core-Extensions-IControl-SendToBack'></a>
### SendToBack() `method`

##### Summary

Sends the control to the back of the z-order.

##### Parameters

This method has no parameters.

<a name='M-xyLOGIX-Core-Extensions-IControl-SetBounds-System-Int32,System-Int32,System-Int32,System-Int32-'></a>
### SetBounds(x,y,width,height) `method`

##### Summary

Sets the bounds of the control to the specified location and size.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| x | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The new [Left](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.Control.Left 'System.Windows.Forms.Control.Left')
property value of the control. |
| y | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The new [Top](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.Control.Top 'System.Windows.Forms.Control.Top')
property value of the control. |
| width | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The new
[Width](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.Control.Width 'System.Windows.Forms.Control.Width') property value of the
control. |
| height | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The new
[Height](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.Control.Height 'System.Windows.Forms.Control.Height') property value of the
control. |

<a name='M-xyLOGIX-Core-Extensions-IControl-SetBounds-System-Int32,System-Int32,System-Int32,System-Int32,System-Windows-Forms-BoundsSpecified-'></a>
### SetBounds(x,y,width,height,specified) `method`

##### Summary

Sets the specified bounds of the control to the specified location
and size.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| x | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The new [Left](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.Control.Left 'System.Windows.Forms.Control.Left')
property value of the control. |
| y | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The new [Top](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.Control.Top 'System.Windows.Forms.Control.Top')
property value of the control. |
| width | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The new
[Width](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.Control.Width 'System.Windows.Forms.Control.Width') property value of the
control. |
| height | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The new
[Height](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.Control.Height 'System.Windows.Forms.Control.Height') property value of the
control. |
| specified | [System.Windows.Forms.BoundsSpecified](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.BoundsSpecified 'System.Windows.Forms.BoundsSpecified') | A bitwise combination of the
[BoundsSpecified](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.BoundsSpecified 'System.Windows.Forms.BoundsSpecified') value(s). OfType any parameter
not specified, the current value will be used. |

<a name='M-xyLOGIX-Core-Extensions-IControl-Show'></a>
### Show() `method`

##### Summary

Displays the control to the user.

##### Parameters

This method has no parameters.

<a name='M-xyLOGIX-Core-Extensions-IControl-SuspendLayout'></a>
### SuspendLayout() `method`

##### Summary

Temporarily suspends the layout logic for the control.

##### Parameters

This method has no parameters.

<a name='M-xyLOGIX-Core-Extensions-IControl-Update'></a>
### Update() `method`

##### Summary

Causes the control to redraw the invalidated regions within its
client area.

##### Parameters

This method has no parameters.

<a name='T-xyLOGIX-Core-Extensions-IForm'></a>
## IForm `type`

##### Namespace

xyLOGIX.Core.Extensions

##### Summary

Defines the publicly-exposed methods and properties of a form.

<a name='P-xyLOGIX-Core-Extensions-IForm-AcceptButton'></a>
### AcceptButton `property`

##### Summary

Gets or sets the button on the form that is clicked when the user
presses the ENTER key.

##### Returns

An [IButtonControl](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.IButtonControl 'System.Windows.Forms.IButtonControl') that
represents the button to use as the accept button for the form.

<a name='P-xyLOGIX-Core-Extensions-IForm-ActiveMdiChild'></a>
### ActiveMdiChild `property`

##### Summary

Gets the currently active multiple-document interface (MDI) child
window.

##### Returns

Returns a [Form](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.Form 'System.Windows.Forms.Form') that represents
the currently active MDI child window, or `null` if there are
currently no child windows present.

<a name='P-xyLOGIX-Core-Extensions-IForm-AllowTransparency'></a>
### AllowTransparency `property`

##### Summary

Gets or sets a value indicating whether the opacity of the form can
be adjusted.

##### Returns

`true` if the opacity of the form can be changed;
otherwise, `false`.

<a name='P-xyLOGIX-Core-Extensions-IForm-AutoScale'></a>
### AutoScale `property`

##### Summary

Gets or sets a value indicating whether the form adjusts its size to
fit the height of the font used on the form and scales its controls.

##### Returns

`true` if the form will automatically scale itself
and its controls based on the current font assigned to the form; otherwise,
`false`. The default is `true`.

<a name='P-xyLOGIX-Core-Extensions-IForm-AutoScaleBaseSize'></a>
### AutoScaleBaseSize `property`

##### Summary

Gets or sets the base size used for autoscaling of the form.

##### Returns

A [Size](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Drawing.Size 'System.Drawing.Size') that represents the base size
that this form uses for autoscaling.

<a name='P-xyLOGIX-Core-Extensions-IForm-AutoSizeMode'></a>
### AutoSizeMode `property`

##### Summary

Gets or sets the mode by which the form automatically resizes itself.

##### Returns

A [AutoSizeMode](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.AutoSizeMode 'System.Windows.Forms.AutoSizeMode') enumerated
value. The default is
[GrowOnly](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.AutoSizeMode.GrowOnly 'System.Windows.Forms.AutoSizeMode.GrowOnly').

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ComponentModel.InvalidEnumArgumentException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ComponentModel.InvalidEnumArgumentException 'System.ComponentModel.InvalidEnumArgumentException') | The
value is not a valid [AutoSizeMode](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.AutoSizeMode 'System.Windows.Forms.AutoSizeMode') value. |

<a name='P-xyLOGIX-Core-Extensions-IForm-AutoValidate'></a>
### AutoValidate `property`

##### Summary

Gets or sets a value that indicates whether controls in this
container will be automatically validated when the focus changes.

##### Returns

A [AutoValidate](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.AutoValidate 'System.Windows.Forms.AutoValidate') enumerated
value that indicates whether contained controls are implicitly validated on
focus change. The default is Inherit.

<a name='P-xyLOGIX-Core-Extensions-IForm-CancelButton'></a>
### CancelButton `property`

##### Summary

Gets or sets the background color for the control.

##### Returns

A [Color](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Drawing.Color 'System.Drawing.Color') that represents the
background color of the control. The default is the value of the
[DefaultBackColor](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.Control.DefaultBackColor 'System.Windows.Forms.Control.DefaultBackColor') property.

<a name='P-xyLOGIX-Core-Extensions-IForm-ControlBox'></a>
### ControlBox `property`

##### Summary

Gets or sets a value indicating whether a control box is displayed in
the caption bar of the form.

##### Returns

`true` if the form displays a control box in the
upper-right corner of the form; otherwise, `false`. The
default is `true`.

<a name='P-xyLOGIX-Core-Extensions-IForm-DesktopBounds'></a>
### DesktopBounds `property`

##### Summary

Gets or sets the size and location of the form on the Windows
desktop.

##### Returns

A [Rectangle](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Drawing.Rectangle 'System.Drawing.Rectangle') that represents the
bounds of the form on the Windows desktop using desktop coordinates.

<a name='P-xyLOGIX-Core-Extensions-IForm-DesktopLocation'></a>
### DesktopLocation `property`

##### Summary

Gets or sets the location of the form on the Windows desktop.

##### Returns

A [Point](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Drawing.Point 'System.Drawing.Point') that represents the location
of the form on the desktop.

<a name='P-xyLOGIX-Core-Extensions-IForm-DialogResult'></a>
### DialogResult `property`

##### Summary

Gets or sets the dialog result for the form.

##### Returns

A [DialogResult](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.DialogResult 'System.Windows.Forms.DialogResult') that represents
the result of the form when used as a dialog box.

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ComponentModel.InvalidEnumArgumentException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ComponentModel.InvalidEnumArgumentException 'System.ComponentModel.InvalidEnumArgumentException') | The
value specified is outside the range of valid values. |

<a name='P-xyLOGIX-Core-Extensions-IForm-FormBorderStyle'></a>
### FormBorderStyle `property`

##### Summary

Gets or sets the border style of the form.

##### Returns

A [FormBorderStyle](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.FormBorderStyle 'System.Windows.Forms.FormBorderStyle') that
represents the style of border to display for the form. The default is
`FormBorderStyle.Sizable`.

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ComponentModel.InvalidEnumArgumentException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ComponentModel.InvalidEnumArgumentException 'System.ComponentModel.InvalidEnumArgumentException') | The
value specified is outside the range of valid values. |

<a name='P-xyLOGIX-Core-Extensions-IForm-HelpButton'></a>
### HelpButton `property`

##### Summary

Gets or sets a value indicating whether a Help button should be
displayed in the caption box of the form.

##### Returns

`true` to display a Help button in the form's
caption bar; otherwise, `false`. The default is
`false`.

<a name='P-xyLOGIX-Core-Extensions-IForm-Icon'></a>
### Icon `property`

##### Summary

Gets or sets the icon for the form.

##### Returns

An [Icon](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Drawing.Icon 'System.Drawing.Icon') that represents the icon for
the form.

<a name='P-xyLOGIX-Core-Extensions-IForm-IsMdiChild'></a>
### IsMdiChild `property`

##### Summary

Gets a value indicating whether the form is a multiple-document
interface (MDI) child form.

##### Returns

`true` if the form is an MDI child form; otherwise,
`false`.

<a name='P-xyLOGIX-Core-Extensions-IForm-IsMdiContainer'></a>
### IsMdiContainer `property`

##### Summary

Gets or sets a value indicating whether the form is a container for
multiple-document interface (MDI) child forms.

##### Returns

`true` if the form is a container for MDI child
forms; otherwise, `false`. The default is
`false`.

<a name='P-xyLOGIX-Core-Extensions-IForm-IsRestrictedWindow'></a>
### IsRestrictedWindow `property`

##### Summary

Gets a value indicating whether the form can use all windows and user
input events without restriction.

##### Returns

`true` if the form has restrictions; otherwise,
`false` . The default is `true`.

<a name='P-xyLOGIX-Core-Extensions-IForm-KeyPreview'></a>
### KeyPreview `property`

##### Summary

Gets or sets a value indicating whether the form will receive key
events before the event is passed to the control that has focus.

##### Returns

`true` if the form will receive all key events;
`false` if the currently selected control on the form receives
key events. The default is `false`.

<a name='P-xyLOGIX-Core-Extensions-IForm-MainMenuStrip'></a>
### MainMenuStrip `property`

##### Summary

Gets or sets the primary menu container for the form.

##### Returns

A [MenuStrip](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.MenuStrip 'System.Windows.Forms.MenuStrip') that represents the
container for the menu structure of the form. The default is
`null`.

<a name='P-xyLOGIX-Core-Extensions-IForm-MaximizeBox'></a>
### MaximizeBox `property`

##### Summary

Gets or sets a value indicating whether the Maximize button is
displayed in the caption bar of the form.

##### Returns

`true` to display a Maximize button for the form;
otherwise, `false`. The default is `true`.

<a name='P-xyLOGIX-Core-Extensions-IForm-MdiChildren'></a>
### MdiChildren `property`

##### Summary

Gets the maximum size the form can be resized to.

##### Returns

A [Size](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Drawing.Size 'System.Drawing.Size') that represents the maximum
size for the form.

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentOutOfRangeException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentOutOfRangeException 'System.ArgumentOutOfRangeException') | The values of the
height or width within the [Size](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Drawing.Size 'System.Drawing.Size') object are less
than zero. |

<a name='P-xyLOGIX-Core-Extensions-IForm-MdiParent'></a>
### MdiParent `property`

##### Summary

Gets or sets the current multiple-document interface (MDI) parent
form of this form.

##### Returns

A [Form](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.Form 'System.Windows.Forms.Form') that represents the MDI
parent form.

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.Exception](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Exception 'System.Exception') | The
[Form](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.Form 'System.Windows.Forms.Form') assigned to this property is not
marked as an MDI container. -or- The [Form](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.Form 'System.Windows.Forms.Form')
assigned to this property is both a child and an MDI container form. -or- The
[Form](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.Form 'System.Windows.Forms.Form') assigned to this property is located
on a different thread. |

<a name='P-xyLOGIX-Core-Extensions-IForm-Menu'></a>
### Menu `property`

##### Summary

Gets or sets the [MainMenu](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.MainMenu 'System.Windows.Forms.MainMenu') that
is displayed in the form.

##### Returns

A [MainMenu](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.MainMenu 'System.Windows.Forms.MainMenu') that represents the
menu to display in the form.

<a name='P-xyLOGIX-Core-Extensions-IForm-MergedMenu'></a>
### MergedMenu `property`

##### Summary

Gets the merged menu for the form.

##### Returns

A [MainMenu](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.MainMenu 'System.Windows.Forms.MainMenu') that represents the
merged menu of the form.

<a name='P-xyLOGIX-Core-Extensions-IForm-MinimizeBox'></a>
### MinimizeBox `property`

##### Summary

Gets or sets a value indicating whether the Minimize button is
displayed in the caption bar of the form.

##### Returns

`true` to display a Minimize button for the form;
otherwise, `false`. The default is `true`.

<a name='P-xyLOGIX-Core-Extensions-IForm-Modal'></a>
### Modal `property`

##### Summary

Gets a value indicating whether this form is displayed modally.

##### Returns

`true` if the form is displayed modally; otherwise,
`false`.

<a name='P-xyLOGIX-Core-Extensions-IForm-Opacity'></a>
### Opacity `property`

##### Summary

Gets or sets the opacity level of the form.

##### Returns

The level of opacity for the form. The default is 1.00.

<a name='P-xyLOGIX-Core-Extensions-IForm-OwnedForms'></a>
### OwnedForms `property`

##### Summary

Gets an array of [Form](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.Form 'System.Windows.Forms.Form') objects
that represent all forms that are owned by this form.

##### Returns

A [Form](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.Form 'System.Windows.Forms.Form') array that represents
the owned forms for this form.

<a name='P-xyLOGIX-Core-Extensions-IForm-Owner'></a>
### Owner `property`

##### Summary

Gets or sets the form that owns this form.

##### Returns

A [Form](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.Form 'System.Windows.Forms.Form') that represents the form
that is the owner of this form.

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.Exception](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Exception 'System.Exception') | A top-level window cannot have an owner. |

<a name='P-xyLOGIX-Core-Extensions-IForm-RestoreBounds'></a>
### RestoreBounds `property`

##### Summary

Gets the location and size of the form in its normal window state.

##### Returns

A [Rectangle](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Drawing.Rectangle 'System.Drawing.Rectangle') that contains the
location and size of the form in the normal window state.

<a name='P-xyLOGIX-Core-Extensions-IForm-RightToLeftLayout'></a>
### RightToLeftLayout `property`

##### Summary

Gets or sets a value indicating whether right-to-left mirror
placement is turned on.

##### Returns

`true` if right-to-left mirror placement is turned
on; otherwise, `false` for standard child control placement.
The default is `false`.

<a name='P-xyLOGIX-Core-Extensions-IForm-ShowIcon'></a>
### ShowIcon `property`

##### Summary

Gets or sets a value indicating whether an icon is displayed in the
caption bar of the form.

##### Returns

`true` if the form displays an icon in the caption
bar; otherwise, `false`. The default is
`true`.

<a name='P-xyLOGIX-Core-Extensions-IForm-ShowInTaskbar'></a>
### ShowInTaskbar `property`

##### Summary

Gets or sets a value indicating whether the form is displayed in the
Windows taskbar.

##### Returns

`true` to display the form in the Windows taskbar at
run time; otherwise, `false`. The default is
`true`.

<a name='P-xyLOGIX-Core-Extensions-IForm-SizeGripStyle'></a>
### SizeGripStyle `property`

##### Summary

Gets or sets the style of the size grip to display in the lower-right
corner of the form.

##### Returns

A [SizeGripStyle](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.SizeGripStyle 'System.Windows.Forms.SizeGripStyle') that represents
the style of the size grip to display. The default is
[Auto](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.SizeGripStyle.Auto 'System.Windows.Forms.SizeGripStyle.Auto')

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ComponentModel.InvalidEnumArgumentException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ComponentModel.InvalidEnumArgumentException 'System.ComponentModel.InvalidEnumArgumentException') | The
value specified is outside the range of valid values. |

<a name='P-xyLOGIX-Core-Extensions-IForm-StartPosition'></a>
### StartPosition `property`

##### Summary

Gets or sets the starting position of the form at run time.

##### Returns

A [FormStartPosition](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.FormStartPosition 'System.Windows.Forms.FormStartPosition') that
represents the starting position of the form.

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ComponentModel.InvalidEnumArgumentException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ComponentModel.InvalidEnumArgumentException 'System.ComponentModel.InvalidEnumArgumentException') | The
value specified is outside the range of valid values. |

<a name='P-xyLOGIX-Core-Extensions-IForm-TopLevel'></a>
### TopLevel `property`

##### Summary

Gets or sets a value indicating whether to display the form as a
top-level window.

##### Returns

`true` to display the form as a top-level window;
otherwise, `false`. The default is `true`.

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.Exception](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Exception 'System.Exception') | A Multiple-document interface (MDI)
parent form must be a top-level window. |

<a name='P-xyLOGIX-Core-Extensions-IForm-TopMost'></a>
### TopMost `property`

##### Summary

Gets or sets a value indicating whether the form should be displayed
as a topmost form.

##### Returns

`true` to display the form as a topmost form;
otherwise, `false`. The default is `false`.

<a name='P-xyLOGIX-Core-Extensions-IForm-TransparencyKey'></a>
### TransparencyKey `property`

##### Summary

Gets or sets the color that will represent transparent areas of the
form.

##### Returns

A [Color](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Drawing.Color 'System.Drawing.Color') that represents the color to
display transparently on the form.

<a name='P-xyLOGIX-Core-Extensions-IForm-WindowState'></a>
### WindowState `property`

##### Summary

Gets or sets a value that indicates whether form is minimized,
maximized, or normal.

##### Returns

A [FormWindowState](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.FormWindowState 'System.Windows.Forms.FormWindowState') that
represents whether form is minimized, maximized, or normal. The default is
`FormWindowState.Normal`.

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ComponentModel.InvalidEnumArgumentException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ComponentModel.InvalidEnumArgumentException 'System.ComponentModel.InvalidEnumArgumentException') | The
value specified is outside the range of valid values. |

<a name='M-xyLOGIX-Core-Extensions-IForm-Activate'></a>
### Activate() `method`

##### Summary

Activates the form and gives it focus.

##### Parameters

This method has no parameters.

<a name='M-xyLOGIX-Core-Extensions-IForm-AddOwnedForm-System-Windows-Forms-Form-'></a>
### AddOwnedForm(ownedForm) `method`

##### Summary

Adds an owned form to this form.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| ownedForm | [System.Windows.Forms.Form](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.Form 'System.Windows.Forms.Form') | The [Form](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.Form 'System.Windows.Forms.Form') that
this form will own. |

<a name='M-xyLOGIX-Core-Extensions-IForm-Close'></a>
### Close() `method`

##### Summary

Closes the form.

##### Parameters

This method has no parameters.

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.InvalidOperationException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.InvalidOperationException 'System.InvalidOperationException') | The form was closed while
a handle was being created. |
| [System.ObjectDisposedException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ObjectDisposedException 'System.ObjectDisposedException') | You cannot call this method
from the [](#E-System-Windows-Forms-Form-Activated 'System.Windows.Forms.Form.Activated') event when
[WindowState](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.Form.WindowState 'System.Windows.Forms.Form.WindowState') is set to
[Maximized](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.FormWindowState.Maximized 'System.Windows.Forms.FormWindowState.Maximized'). |

<a name='M-xyLOGIX-Core-Extensions-IForm-LayoutMdi-System-Windows-Forms-MdiLayout-'></a>
### LayoutMdi(value) `method`

##### Summary

Arranges the multiple-document interface (MDI) child forms within the
MDI parent form.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.Windows.Forms.MdiLayout](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.MdiLayout 'System.Windows.Forms.MdiLayout') | One of the [MdiLayout](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.MdiLayout 'System.Windows.Forms.MdiLayout')
values that defines the layout of MDI child forms. |

<a name='M-xyLOGIX-Core-Extensions-IForm-RemoveOwnedForm-System-Windows-Forms-Form-'></a>
### RemoveOwnedForm(ownedForm) `method`

##### Summary

Removes an owned form from this form.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| ownedForm | [System.Windows.Forms.Form](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.Form 'System.Windows.Forms.Form') | A [Form](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.Form 'System.Windows.Forms.Form')
representing the form to remove from the list of owned forms for this form. |

<a name='M-xyLOGIX-Core-Extensions-IForm-SetDesktopBounds-System-Int32,System-Int32,System-Int32,System-Int32-'></a>
### SetDesktopBounds(x,y,width,height) `method`

##### Summary

Sets the bounds of the form in desktop coordinates.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| x | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The x-coordinate of the form's location. |
| y | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The y-coordinate of the form's location. |
| width | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The width of the form. |
| height | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The height of the form. |

<a name='M-xyLOGIX-Core-Extensions-IForm-SetDesktopLocation-System-Int32,System-Int32-'></a>
### SetDesktopLocation(x,y) `method`

##### Summary

Sets the location of the form in desktop coordinates.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| x | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The x-coordinate of the form's location. |
| y | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The y-coordinate of the form's location. |

<a name='M-xyLOGIX-Core-Extensions-IForm-Show-System-Windows-Forms-IWin32Window-'></a>
### Show(owner) `method`

##### Summary

Shows the form with the specified owner to the user.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| owner | [System.Windows.Forms.IWin32Window](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.IWin32Window 'System.Windows.Forms.IWin32Window') | Any object that implements
[IWin32Window](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.IWin32Window 'System.Windows.Forms.IWin32Window') and represents the top-level
window that will own this form. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.InvalidOperationException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.InvalidOperationException 'System.InvalidOperationException') | The form being shown is
already visible. -or- The form specified in the `owner`
parameter is the same as the form being shown. -or- The form being shown is
disabled. -or- The form being shown is not a top-level window. -or- The form
being shown as a dialog box is already a modal form. -or- The current process
is not running in user interactive mode (for more information, see
[UserInteractive](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.SystemInformation.UserInteractive 'System.Windows.Forms.SystemInformation.UserInteractive')). |

<a name='M-xyLOGIX-Core-Extensions-IForm-ShowDialog'></a>
### ShowDialog() `method`

##### Summary

Shows the form as a modal dialog box.

##### Returns

One of the [DialogResult](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.DialogResult 'System.Windows.Forms.DialogResult') value(s).

##### Parameters

This method has no parameters.

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.InvalidOperationException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.InvalidOperationException 'System.InvalidOperationException') | The form being shown is
already visible. -or- The form being shown is disabled. -or- The form being
shown is not a top-level window. -or- The form being shown as a dialog box is
already a modal form. -or- The current process is not running in user
interactive mode (for more information, see
[UserInteractive](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.SystemInformation.UserInteractive 'System.Windows.Forms.SystemInformation.UserInteractive')). |

<a name='M-xyLOGIX-Core-Extensions-IForm-ShowDialog-System-Windows-Forms-IWin32Window-'></a>
### ShowDialog(owner) `method`

##### Summary

Shows the form as a modal dialog box with the specified owner.

##### Returns

One of the [DialogResult](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.DialogResult 'System.Windows.Forms.DialogResult') value(s).

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| owner | [System.Windows.Forms.IWin32Window](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.IWin32Window 'System.Windows.Forms.IWin32Window') | Any object that implements
[IWin32Window](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.IWin32Window 'System.Windows.Forms.IWin32Window') that represents the
top-level window that will own the modal dialog box. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentException 'System.ArgumentException') | The form specified in the
`owner` parameter is the same as the form being shown. |
| [System.InvalidOperationException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.InvalidOperationException 'System.InvalidOperationException') | The form being shown is
already visible. -or- The form being shown is disabled. -or- The form being
shown is not a top-level window. -or- The form being shown as a dialog box is
already a modal form. -or- The current process is not running in user
interactive mode (for more information, see
[UserInteractive](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.SystemInformation.UserInteractive 'System.Windows.Forms.SystemInformation.UserInteractive')). |

<a name='M-xyLOGIX-Core-Extensions-IForm-ToString'></a>
### ToString() `method`

##### Summary

Gets a string representing the current instance of the form.

##### Returns

A string consisting of the fully qualified name of the form object's
class, with the [Text](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.Form.Text 'System.Windows.Forms.Form.Text') property of the
form appended to the end. OfType example, if the form is derived from the class
`MyForm` in the `MyNamespace` namespace, and the
[Text](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.Form.Text 'System.Windows.Forms.Form.Text') property is set to
`Hello, World`, this method will return
` MyNamespace.MyForm, Text: Hello, World ` .

##### Parameters

This method has no parameters.

<a name='M-xyLOGIX-Core-Extensions-IForm-ValidateChildren'></a>
### ValidateChildren() `method`

##### Summary

Causes all of the child controls within a control that support
validation to validate their data.

##### Returns

`true` if all of the children validated
successfully; otherwise, `false`. If called from the
[](#E-System-Windows-Forms-Control-Validating 'System.Windows.Forms.Control.Validating') or
[](#E-System-Windows-Forms-Control-Validated 'System.Windows.Forms.Control.Validated') event handlers, this
method will always return `false`.

##### Parameters

This method has no parameters.

<a name='M-xyLOGIX-Core-Extensions-IForm-ValidateChildren-System-Windows-Forms-ValidationConstraints-'></a>
### ValidateChildren(validationConstraints) `method`

##### Summary

Causes all of the child controls within a control that support
validation to validate their data.

##### Returns

`true` if all of the children validated
successfully; otherwise, `false`. If called from the
[](#E-System-Windows-Forms-Control-Validating 'System.Windows.Forms.Control.Validating') or
[](#E-System-Windows-Forms-Control-Validated 'System.Windows.Forms.Control.Validated') event handlers, this
method will always return `false`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| validationConstraints | [System.Windows.Forms.ValidationConstraints](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.ValidationConstraints 'System.Windows.Forms.ValidationConstraints') | Places restrictions on which controls have
their [](#E-System-Windows-Forms-Control-Validating 'System.Windows.Forms.Control.Validating') event raised. |

<a name='T-xyLOGIX-Core-Extensions-ILanguageArticleTypeValidator'></a>
## ILanguageArticleTypeValidator `type`

##### Namespace

xyLOGIX.Core.Extensions

##### Summary

Defines the publicly-exposed events, methods and properties of a validator of
[LanguageArticleType](#T-xyLOGIX-Core-Extensions-LanguageArticleType 'xyLOGIX.Core.Extensions.LanguageArticleType') enumeration
values.

##### Remarks

Specifically, objects that implement this interface ascertain whether
the values of variables fall within the value set that is defined by the
[LanguageArticleType](#T-xyLOGIX-Core-Extensions-LanguageArticleType 'xyLOGIX.Core.Extensions.LanguageArticleType') enumeration.

<a name='M-xyLOGIX-Core-Extensions-ILanguageArticleTypeValidator-IsValid-xyLOGIX-Core-Extensions-LanguageArticleType-'></a>
### IsValid(type) `method`

##### Summary

Determines whether the language article `type` value
passed is within the value set that is defined by the
[LanguageArticleType](#T-xyLOGIX-Core-Extensions-LanguageArticleType 'xyLOGIX.Core.Extensions.LanguageArticleType') enumeration.

##### Returns

`true` if the language article
`type` falls within the defined value set;
`false` otherwise.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| type | [xyLOGIX.Core.Extensions.LanguageArticleType](#T-xyLOGIX-Core-Extensions-LanguageArticleType 'xyLOGIX.Core.Extensions.LanguageArticleType') | (Required.) One of the
[LanguageArticleType](#T-xyLOGIX-Core-Extensions-LanguageArticleType 'xyLOGIX.Core.Extensions.LanguageArticleType') value(s) that is to
be examined. |

<a name='T-xyLOGIX-Core-Extensions-IListView'></a>
## IListView `type`

##### Namespace

xyLOGIX.Core.Extensions

##### Summary

Defines the publicly-exposed methods, properties, and events of a Windows Forms
ListView control.

<a name='P-xyLOGIX-Core-Extensions-IListView-Activation'></a>
### Activation `property`

##### Summary

Gets or sets how items are activated (clicked).

##### Returns

One of the [ItemActivation](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.ItemActivation 'System.Windows.Forms.ItemActivation') values. The
default is ItemActivation.Standard.

<a name='P-xyLOGIX-Core-Extensions-IListView-Alignment'></a>
### Alignment `property`

##### Summary

Gets or sets the alignment of items in the control.

##### Returns

One of the [ListViewAlignment](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.ListViewAlignment 'System.Windows.Forms.ListViewAlignment') values. The
default is ListViewAlignment.Top.

<a name='P-xyLOGIX-Core-Extensions-IListView-AllowColumnReorder'></a>
### AllowColumnReorder `property`

##### Summary

Gets or sets a value indicating whether the user can drag column headers to
reorder columns.

##### Returns

`true` if the user can drag column headers to reorder columns;
otherwise, `false`.
The default is `false`.

<a name='P-xyLOGIX-Core-Extensions-IListView-AutoArrange'></a>
### AutoArrange `property`

##### Summary

Gets or sets a value indicating whether icons are automatically arranged.

##### Returns

`true` if icons are automatically arranged; otherwise,
`false`.
The default is `false`.

<a name='P-xyLOGIX-Core-Extensions-IListView-BackgroundImageTiled'></a>
### BackgroundImageTiled `property`

##### Summary

Gets or sets a value indicating whether the background image is tiled.

##### Returns

`true` if the background image is tiled; otherwise,
`false`.
The default is `false`.

<a name='P-xyLOGIX-Core-Extensions-IListView-BorderStyle'></a>
### BorderStyle `property`

##### Summary

Gets or sets the border style of the control.

##### Returns

One of the [BorderStyle](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.BorderStyle 'System.Windows.Forms.BorderStyle') values. The
default is BorderStyle.Fixed3D.

<a name='P-xyLOGIX-Core-Extensions-IListView-CheckBoxes'></a>
### CheckBoxes `property`

##### Summary

Gets or sets a value indicating whether a checkbox appears next to each item in
the control.

##### Returns

`true` if a checkbox appears next to each item in the control;
otherwise, `false`.
The default is `false`.

<a name='P-xyLOGIX-Core-Extensions-IListView-CheckedIndices'></a>
### CheckedIndices `property`

##### Summary

Gets the collection of items in the control that are checked.

##### Returns

A [CheckedIndexCollection](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.ListView.CheckedIndexCollection 'System.Windows.Forms.ListView.CheckedIndexCollection') that
contains the indexes of checked items in the list.

<a name='P-xyLOGIX-Core-Extensions-IListView-CheckedItems'></a>
### CheckedItems `property`

##### Summary

Gets the collection of checked items in the control.

##### Returns

A [CheckedListViewItemCollection](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.ListView.CheckedListViewItemCollection 'System.Windows.Forms.ListView.CheckedListViewItemCollection')
that contains the checked items in the list.

<a name='P-xyLOGIX-Core-Extensions-IListView-Columns'></a>
### Columns `property`

##### Summary

Gets the collection of column headers in the control.

##### Returns

A [ColumnHeaderCollection](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.ListView.ColumnHeaderCollection 'System.Windows.Forms.ListView.ColumnHeaderCollection') that
contains all column header objects in the list.

<a name='P-xyLOGIX-Core-Extensions-IListView-Container'></a>
### Container `property`

##### Summary

Gets the container for components.

##### Returns

The [IContainer](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ComponentModel.IContainer 'System.ComponentModel.IContainer') that contains the
component.

<a name='P-xyLOGIX-Core-Extensions-IListView-FocusedItem'></a>
### FocusedItem `property`

##### Summary

Gets or sets the item that has focus in the list view control.

##### Returns

A [ListViewItem](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.ListViewItem 'System.Windows.Forms.ListViewItem') that represents the item
that has focus.

<a name='P-xyLOGIX-Core-Extensions-IListView-FullRowSelect'></a>
### FullRowSelect `property`

##### Summary

Gets or sets a value indicating whether clicking an item selects all its
subitems.

##### Returns

`true` if clicking an item selects all its subitems;
otherwise, `false`.
The default is `false`.

<a name='P-xyLOGIX-Core-Extensions-IListView-GridLines'></a>
### GridLines `property`

##### Summary

Gets or sets a value indicating whether grid lines appear between the rows and
columns containing the items and subitems in the control.

##### Returns

`true` if grid lines appear between the rows and columns of
the list; otherwise, `false`.
The default is `false`.

<a name='P-xyLOGIX-Core-Extensions-IListView-Groups'></a>
### Groups `property`

##### Summary

Gets the collection of groups in the list view control.

##### Returns

A [ListViewGroupCollection](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.ListViewGroupCollection 'System.Windows.Forms.ListViewGroupCollection') that represents
the groups within the list.

<a name='P-xyLOGIX-Core-Extensions-IListView-HeaderStyle'></a>
### HeaderStyle `property`

##### Summary

Gets or sets the column header style.

##### Returns

One of the [ColumnHeaderStyle](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.ColumnHeaderStyle 'System.Windows.Forms.ColumnHeaderStyle') values. The
default is ColumnHeaderStyle.Clickable.

<a name='P-xyLOGIX-Core-Extensions-IListView-HideSelection'></a>
### HideSelection `property`

##### Summary

Gets or sets a value indicating whether the selected item in the control
remains highlighted when the control loses focus.

##### Returns

`true` if the selected item is not highlighted when the
control loses focus; otherwise, `false`.
The default is `true`.

<a name='P-xyLOGIX-Core-Extensions-IListView-HotTracking'></a>
### HotTracking `property`

##### Summary

Gets or sets a value indicating whether an item is automatically selected when
the mouse pointer remains over the item for a few seconds.

##### Returns

`true` if an item is automatically selected when the mouse
pointer hovers over the item; otherwise, `false`.
The default is `false`.

<a name='P-xyLOGIX-Core-Extensions-IListView-HoverSelection'></a>
### HoverSelection `property`

##### Summary

Gets or sets a value indicating whether an item is automatically selected when
the mouse pointer pauses over the item.

##### Returns

`true` if an item is automatically selected when the mouse
pointer hovers over the item; otherwise, `false`.
The default is `false`.

<a name='P-xyLOGIX-Core-Extensions-IListView-InsertionMark'></a>
### InsertionMark `property`

##### Summary

Gets the insertion mark for the list view.

##### Returns

A [ListViewInsertionMark](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.ListViewInsertionMark 'System.Windows.Forms.ListViewInsertionMark') that provides
information about the insertion mark of the list view.

<a name='P-xyLOGIX-Core-Extensions-IListView-Items'></a>
### Items `property`

##### Summary

Gets the collection of items in the control.

##### Returns

A [ListViewItemCollection](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.ListView.ListViewItemCollection 'System.Windows.Forms.ListView.ListViewItemCollection') that
contains all items in the list.

<a name='P-xyLOGIX-Core-Extensions-IListView-LabelEdit'></a>
### LabelEdit `property`

##### Summary

Gets or sets a value indicating whether the user can edit the item labels.

##### Returns

`true` if item labels can be edited; otherwise,
`false`.
The default is `false`.

<a name='P-xyLOGIX-Core-Extensions-IListView-LabelWrap'></a>
### LabelWrap `property`

##### Summary

Gets or sets a value indicating whether item labels wrap when they are too long
to fit in the control.

##### Returns

`true` if item labels wrap when they are too long to fit in
the control; otherwise, `false`.
The default is `true`.

<a name='P-xyLOGIX-Core-Extensions-IListView-LargeImageList'></a>
### LargeImageList `property`

##### Summary

Gets or sets the ImageList to use when displaying items as large icons in the
control.

##### Returns

An [ImageList](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.ImageList 'System.Windows.Forms.ImageList') that contains the images to
display for the large icon view of the items.

<a name='P-xyLOGIX-Core-Extensions-IListView-ListViewItemSorter'></a>
### ListViewItemSorter `property`

##### Summary

Gets or sets the implementation of the
[IComparer](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.IComparer 'System.Collections.IComparer') interface used to sort the items
in the control.

##### Returns

An implementation of the [IComparer](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.IComparer 'System.Collections.IComparer')
interface used to sort the items in the list.

<a name='P-xyLOGIX-Core-Extensions-IListView-MultiSelect'></a>
### MultiSelect `property`

##### Summary

Gets or sets a value indicating whether multiple items can be selected.

##### Returns

`true` if multiple items can be selected; otherwise,
`false`.
The default is `false`.

<a name='P-xyLOGIX-Core-Extensions-IListView-OwnerDraw'></a>
### OwnerDraw `property`

##### Summary

Gets or sets a value indicating whether the items in the control are drawn by
the application.

##### Returns

`true` if the items in the control are drawn by the
application; otherwise, `false`.
The default is `false`.

<a name='P-xyLOGIX-Core-Extensions-IListView-RightToLeftLayout'></a>
### RightToLeftLayout `property`

##### Summary

Gets or sets a value indicating whether the RightToLeft property should affect
the layout of the ListView control and its elements.

##### Returns

`true` if the layout of the ListView control and its elements
is affected by the RightToLeft property; otherwise, `false`.
The default is `false`.

<a name='P-xyLOGIX-Core-Extensions-IListView-Scrollable'></a>
### Scrollable `property`

##### Summary

Gets or sets a value indicating whether scroll bars appear in the control when
they are needed.

##### Returns

`true` if scroll bars appear in the control when they are
needed; otherwise, `false`.
The default is `true`.

<a name='P-xyLOGIX-Core-Extensions-IListView-SelectedIndices'></a>
### SelectedIndices `property`

##### Summary

Gets a collection of the indexes of the selected items in the control.

##### Returns

A [SelectedIndexCollection](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.ListView.SelectedIndexCollection 'System.Windows.Forms.ListView.SelectedIndexCollection') that
contains the indexes of the selected items in the list.

<a name='P-xyLOGIX-Core-Extensions-IListView-SelectedItems'></a>
### SelectedItems `property`

##### Summary

Gets a collection of the selected items in the control.

##### Returns

A [SelectedListViewItemCollection](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.ListView.SelectedListViewItemCollection 'System.Windows.Forms.ListView.SelectedListViewItemCollection')
that contains the selected items in the list.

<a name='P-xyLOGIX-Core-Extensions-IListView-ShowGroups'></a>
### ShowGroups `property`

##### Summary

Gets or sets a value indicating whether groups are displayed.

##### Returns

`true` if groups are displayed; otherwise,
`false`.
The default is `false`.

<a name='P-xyLOGIX-Core-Extensions-IListView-ShowItemToolTips'></a>
### ShowItemToolTips `property`

##### Summary

Gets or sets a value indicating whether ToolTips are shown for the
ListViewItems and SubItems.

##### Returns

`true` if ToolTips are shown for the ListViewItems and
SubItems; otherwise, `false`.
The default is `false`.

<a name='P-xyLOGIX-Core-Extensions-IListView-SmallImageList'></a>
### SmallImageList `property`

##### Summary

Gets or sets the ImageList to use when displaying items as small icons in the
control.

##### Returns

An [ImageList](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.ImageList 'System.Windows.Forms.ImageList') that contains the images to
display for the small icon view of the items.

<a name='P-xyLOGIX-Core-Extensions-IListView-Sorting'></a>
### Sorting `property`

##### Summary

Gets or sets the sort order for items in the control.

##### Returns

One of the [SortOrder](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.SortOrder 'System.Windows.Forms.SortOrder') values. The default
is SortOrder.None.

<a name='P-xyLOGIX-Core-Extensions-IListView-StateImageList'></a>
### StateImageList `property`

##### Summary

Gets or sets the state image list for the control.

##### Returns

An [ImageList](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.ImageList 'System.Windows.Forms.ImageList') that contains the images to
use for the different states of the items.

<a name='P-xyLOGIX-Core-Extensions-IListView-TileSize'></a>
### TileSize `property`

##### Summary

Gets or sets the size of the tiles shown in tile view.

##### Returns

A [Size](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Drawing.Size 'System.Drawing.Size') that represents the size, in pixels, of
the tiles.

<a name='P-xyLOGIX-Core-Extensions-IListView-TopItem'></a>
### TopItem `property`

##### Summary

Gets or sets the item at the top of the ListView.

##### Returns

A [ListViewItem](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.ListViewItem 'System.Windows.Forms.ListViewItem') that represents the item
at the top of the ListView.

<a name='P-xyLOGIX-Core-Extensions-IListView-UseCompatibleStateImageBehavior'></a>
### UseCompatibleStateImageBehavior `property`

##### Summary

Gets or sets a value indicating whether the system-defined or the user-defined
behavior for the state image of the control is used.

##### Returns

`true` if the user-defined behavior for the state image is
used; otherwise, `false`.
The default is `false`.

<a name='P-xyLOGIX-Core-Extensions-IListView-View'></a>
### View `property`

##### Summary

Gets or sets the view mode of the control.

##### Returns

One of the [View](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.View 'System.Windows.Forms.View') values. The default is
View.LargeIcon.

<a name='P-xyLOGIX-Core-Extensions-IListView-VirtualListSize'></a>
### VirtualListSize `property`

##### Summary

Gets or sets the number of items that the list view control will display in
virtual mode.

##### Returns

The number of items that the list view control will display in virtual mode.

<a name='P-xyLOGIX-Core-Extensions-IListView-VirtualMode'></a>
### VirtualMode `property`

##### Summary

Gets or sets a value indicating whether the ListView uses the virtual mode.

##### Returns

`true` if the ListView uses the virtual mode; otherwise,
`false`.
The default is `false`.

<a name='M-xyLOGIX-Core-Extensions-IListView-ArrangeIcons-System-Windows-Forms-ListViewAlignment-'></a>
### ArrangeIcons(value) `method`

##### Summary

Arranges the items in the control according to the specified value.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.Windows.Forms.ListViewAlignment](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.ListViewAlignment 'System.Windows.Forms.ListViewAlignment') | One of the
[ListViewAlignment](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.ListViewAlignment 'System.Windows.Forms.ListViewAlignment') values. |

<a name='M-xyLOGIX-Core-Extensions-IListView-ArrangeIcons'></a>
### ArrangeIcons() `method`

##### Summary

Arranges the items in the control according to the default alignment.

##### Parameters

This method has no parameters.

<a name='M-xyLOGIX-Core-Extensions-IListView-AutoResizeColumn-System-Int32,System-Windows-Forms-ColumnHeaderAutoResizeStyle-'></a>
### AutoResizeColumn(columnIndex,headerAutoResize) `method`

##### Summary

Resizes a column to fit the header or the contents, as specified.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| columnIndex | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The zero-based index of the column to resize. |
| headerAutoResize | [System.Windows.Forms.ColumnHeaderAutoResizeStyle](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.ColumnHeaderAutoResizeStyle 'System.Windows.Forms.ColumnHeaderAutoResizeStyle') | One of the
[ColumnHeaderAutoResizeStyle](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.ColumnHeaderAutoResizeStyle 'System.Windows.Forms.ColumnHeaderAutoResizeStyle') values. |

<a name='M-xyLOGIX-Core-Extensions-IListView-AutoResizeColumns-System-Windows-Forms-ColumnHeaderAutoResizeStyle-'></a>
### AutoResizeColumns(headerAutoResize) `method`

##### Summary

Resizes all columns to fit the header or the contents, as specified.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| headerAutoResize | [System.Windows.Forms.ColumnHeaderAutoResizeStyle](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.ColumnHeaderAutoResizeStyle 'System.Windows.Forms.ColumnHeaderAutoResizeStyle') | One of the
[ColumnHeaderAutoResizeStyle](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.ColumnHeaderAutoResizeStyle 'System.Windows.Forms.ColumnHeaderAutoResizeStyle') values. |

<a name='M-xyLOGIX-Core-Extensions-IListView-BeginUpdate'></a>
### BeginUpdate() `method`

##### Summary

Prevents the control from drawing until the EndUpdate method is called.

##### Parameters

This method has no parameters.

<a name='M-xyLOGIX-Core-Extensions-IListView-Clear'></a>
### Clear() `method`

##### Summary

Removes all items from the control.

##### Parameters

This method has no parameters.

<a name='M-xyLOGIX-Core-Extensions-IListView-CreateObjRef-System-Type-'></a>
### CreateObjRef(requestedType) `method`

##### Summary

Creates an object reference that can be used to marshal to the control from
another application domain.

##### Returns

An [ObjRef](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Runtime.Remoting.ObjRef 'System.Runtime.Remoting.ObjRef') that represents a
marshaled reference to the control.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| requestedType | [System.Type](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Type 'System.Type') | The type of the requested object. |

<a name='M-xyLOGIX-Core-Extensions-IListView-EndUpdate'></a>
### EndUpdate() `method`

##### Summary

Resumes the usual painting of the control, after painting is suspended by the
BeginUpdate method.

##### Parameters

This method has no parameters.

<a name='M-xyLOGIX-Core-Extensions-IListView-EnsureVisible-System-Int32-'></a>
### EnsureVisible(index) `method`

##### Summary

Ensures that the specified item is visible within the control, scrolling the
control if necessary.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| index | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The zero-based index of the item to scroll into view. |

<a name='M-xyLOGIX-Core-Extensions-IListView-FindItemWithText-System-String-'></a>
### FindItemWithText(text) `method`

##### Summary

Searches for the item that matches the specified text.

##### Returns

A [ListViewItem](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.ListViewItem 'System.Windows.Forms.ListViewItem') that contains the
specified text.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| text | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The text to search for. |

<a name='M-xyLOGIX-Core-Extensions-IListView-FindItemWithText-System-String,System-Boolean,System-Int32-'></a>
### FindItemWithText(text,includeSubItemsInSearch,startIndex) `method`

##### Summary

Searches for the item that matches the specified text with search options and
starting index.

##### Returns

A [ListViewItem](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.ListViewItem 'System.Windows.Forms.ListViewItem') that contains the
specified text.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| text | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The text to search for. |
| includeSubItemsInSearch | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | `true` to include
subitems in the search; otherwise, `false`. |
| startIndex | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The zero-based index of the item to start searching
from. |

<a name='M-xyLOGIX-Core-Extensions-IListView-FindItemWithText-System-String,System-Boolean,System-Int32,System-Boolean-'></a>
### FindItemWithText(text,includeSubItemsInSearch,startIndex,isPrefixSearch) `method`

##### Summary

Searches for the item that matches the specified text with search options,
starting index, and prefix search.

##### Returns

A [ListViewItem](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.ListViewItem 'System.Windows.Forms.ListViewItem') that contains the
specified text.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| text | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The text to search for. |
| includeSubItemsInSearch | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | `true` to include
subitems in the search; otherwise, `false`. |
| startIndex | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The zero-based index of the item to start searching
from. |
| isPrefixSearch | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | `true` to search from the
beginning of the string; `false` to search for the text
anywhere in the string. |

<a name='M-xyLOGIX-Core-Extensions-IListView-FindNearestItem-System-Windows-Forms-SearchDirectionHint,System-Drawing-Point-'></a>
### FindNearestItem(dir,point) `method`

##### Summary

Returns the nearest item to the location of the input point.

##### Returns

A [ListViewItem](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.ListViewItem 'System.Windows.Forms.ListViewItem') that is nearest
to the location of the input point.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| dir | [System.Windows.Forms.SearchDirectionHint](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.SearchDirectionHint 'System.Windows.Forms.SearchDirectionHint') | One of the
[SearchDirectionHint](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.SearchDirectionHint 'System.Windows.Forms.SearchDirectionHint') values. |
| point | [System.Drawing.Point](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Drawing.Point 'System.Drawing.Point') | The point to search from. |

<a name='M-xyLOGIX-Core-Extensions-IListView-FindNearestItem-System-Windows-Forms-SearchDirectionHint,System-Int32,System-Int32-'></a>
### FindNearestItem(searchDirection,x,y) `method`

##### Summary

Returns the nearest item to the point with the specified coordinates.

##### Returns

A [ListViewItem](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.ListViewItem 'System.Windows.Forms.ListViewItem') that is nearest
to the specified coordinates.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| searchDirection | [System.Windows.Forms.SearchDirectionHint](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.SearchDirectionHint 'System.Windows.Forms.SearchDirectionHint') | One of the
[SearchDirectionHint](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.SearchDirectionHint 'System.Windows.Forms.SearchDirectionHint') values. |
| x | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The x-coordinate of the point to search from. |
| y | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The y-coordinate of the point to search from. |

<a name='M-xyLOGIX-Core-Extensions-IListView-GetItemAt-System-Int32,System-Int32-'></a>
### GetItemAt(x,y) `method`

##### Summary

Returns the item at the specified coordinates.

##### Returns

A [ListViewItem](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.ListViewItem 'System.Windows.Forms.ListViewItem') at the specified
coordinates, or `null` if there is no item at those
coordinates.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| x | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The x-coordinate of the point to search from. |
| y | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The y-coordinate of the point to search from. |

<a name='M-xyLOGIX-Core-Extensions-IListView-GetItemRect-System-Int32-'></a>
### GetItemRect(index) `method`

##### Summary

Retrieves the bounding rectangle for an item within the control.

##### Returns

A [Rectangle](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Drawing.Rectangle 'System.Drawing.Rectangle') that represents the
bounding rectangle for the specified item.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| index | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The zero-based index of the item whose bounding rectangle
you want. |

<a name='M-xyLOGIX-Core-Extensions-IListView-GetItemRect-System-Int32,System-Windows-Forms-ItemBoundsPortion-'></a>
### GetItemRect(index,portion) `method`

##### Summary

Retrieves the bounding rectangle for an item within the control and specifies
the portion of the item for which to retrieve the bounding rectangle.

##### Returns

A [Rectangle](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Drawing.Rectangle 'System.Drawing.Rectangle') that represents the
bounding rectangle for the specified portion of the specified item.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| index | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The zero-based index of the item whose bounding rectangle
you want. |
| portion | [System.Windows.Forms.ItemBoundsPortion](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.ItemBoundsPortion 'System.Windows.Forms.ItemBoundsPortion') | One of the
[ItemBoundsPortion](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.ItemBoundsPortion 'System.Windows.Forms.ItemBoundsPortion') values that specifies
the portion of the item for which to retrieve the bounding rectangle. |

<a name='M-xyLOGIX-Core-Extensions-IListView-GetLifetimeService'></a>
### GetLifetimeService() `method`

##### Summary

Gets the current lifetime service object that controls the lifetime policy for
this instance.

##### Returns

An object of type
[ILease](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Runtime.Remoting.Lifetime.ILease 'System.Runtime.Remoting.Lifetime.ILease') used to control the
lifetime policy for this instance.

##### Parameters

This method has no parameters.

<a name='M-xyLOGIX-Core-Extensions-IListView-HitTest-System-Drawing-Point-'></a>
### HitTest(point) `method`

##### Summary

Returns hit-test information about the specified point.

##### Returns

A [ListViewHitTestInfo](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.ListViewHitTestInfo 'System.Windows.Forms.ListViewHitTestInfo') that
contains the information about the specified point.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| point | [System.Drawing.Point](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Drawing.Point 'System.Drawing.Point') | A [Point](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Drawing.Point 'System.Drawing.Point') that contains the
coordinates for the hit test. |

<a name='M-xyLOGIX-Core-Extensions-IListView-HitTest-System-Int32,System-Int32-'></a>
### HitTest(x,y) `method`

##### Summary

Returns hit-test information about the specified coordinates.

##### Returns

A [ListViewHitTestInfo](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.ListViewHitTestInfo 'System.Windows.Forms.ListViewHitTestInfo') that
contains the information about the specified coordinates.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| x | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The x-coordinate at which to perform the hit test. |
| y | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The y-coordinate at which to perform the hit test. |

<a name='M-xyLOGIX-Core-Extensions-IListView-InitializeLifetimeService'></a>
### InitializeLifetimeService() `method`

##### Summary

Obtains a lifetime service object to control the lifetime policy for this
instance.

##### Returns

An object of type
[ILease](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Runtime.Remoting.Lifetime.ILease 'System.Runtime.Remoting.Lifetime.ILease') used to control the
lifetime policy for this instance.

##### Parameters

This method has no parameters.

<a name='M-xyLOGIX-Core-Extensions-IListView-RedrawItems-System-Int32,System-Int32,System-Boolean-'></a>
### RedrawItems(startIndex,endIndex,invalidateOnly) `method`

##### Summary

Forces the ListView to redraw the specified items.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| startIndex | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The zero-based index of the first item to redraw. |
| endIndex | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The zero-based index of the last item to redraw. |
| invalidateOnly | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | `true` to just invalidate the
items; `false` to force an immediate repaint. |

<a name='M-xyLOGIX-Core-Extensions-IListView-Sort'></a>
### Sort() `method`

##### Summary

Sorts the items using the current sort settings.

##### Parameters

This method has no parameters.

<a name='T-xyLOGIX-Core-Extensions-IScrollableControl'></a>
## IScrollableControl `type`

##### Namespace

xyLOGIX.Core.Extensions

##### Summary

Defines the publicly-exposed methods and properties of controls that
support auto-scrolling behavior.

<a name='P-xyLOGIX-Core-Extensions-IScrollableControl-AutoScroll'></a>
### AutoScroll `property`

##### Summary

Gets or sets a value indicating whether the container enables the
user to scroll to any controls placed outside its visible boundaries.

##### Returns

`true` if the container enables auto-scrolling;
otherwise, `false`. The default value is
`false`.

<a name='P-xyLOGIX-Core-Extensions-IScrollableControl-AutoScrollMargin'></a>
### AutoScrollMargin `property`

##### Summary

Gets or sets the size of the auto-scroll margin.

##### Returns

A [Size](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Drawing.Size 'System.Drawing.Size') that represents the height and
width of the auto-scroll margin in pixels.

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentOutOfRangeException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentOutOfRangeException 'System.ArgumentOutOfRangeException') | The
[Height](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Drawing.Size.Height 'System.Drawing.Size.Height') or
[Width](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Drawing.Size.Width 'System.Drawing.Size.Width') value assigned is less than 0. |

<a name='P-xyLOGIX-Core-Extensions-IScrollableControl-AutoScrollMinSize'></a>
### AutoScrollMinSize `property`

##### Summary

Gets or sets the minimum size of the auto-scroll.

##### Returns

A [Size](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Drawing.Size 'System.Drawing.Size') that determines the minimum
size of the virtual area through which the user can scroll.

<a name='P-xyLOGIX-Core-Extensions-IScrollableControl-AutoScrollPosition'></a>
### AutoScrollPosition `property`

##### Summary

Gets or sets the location of the auto-scroll position.

##### Returns

A [Point](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Drawing.Point 'System.Drawing.Point') that represents the
auto-scroll position in pixels.

<a name='P-xyLOGIX-Core-Extensions-IScrollableControl-DockPadding'></a>
### DockPadding `property`

##### Summary

Gets the dock padding settings for all edges of the control.

##### Returns

A
[DockPaddingEdges](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.ScrollableControl.DockPaddingEdges 'System.Windows.Forms.ScrollableControl.DockPaddingEdges') that
represents the padding for all the edges of a docked control.

<a name='P-xyLOGIX-Core-Extensions-IScrollableControl-HorizontalScroll'></a>
### HorizontalScroll `property`

##### Summary

Gets the characteristics associated with the horizontal scroll bar.

##### Returns

A [HScrollProperties](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.HScrollProperties 'System.Windows.Forms.HScrollProperties') that
contains information about the horizontal scroll bar.

<a name='P-xyLOGIX-Core-Extensions-IScrollableControl-VerticalScroll'></a>
### VerticalScroll `property`

##### Summary

Gets the characteristics associated with the vertical scroll bar.

##### Returns

A [VScrollProperties](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.VScrollProperties 'System.Windows.Forms.VScrollProperties') that
contains information about the vertical scroll bar.

<a name='M-xyLOGIX-Core-Extensions-IScrollableControl-ScrollControlIntoView-System-Windows-Forms-Control-'></a>
### ScrollControlIntoView(activeControl) `method`

##### Summary

Scrolls the specified child control into view on an auto-scroll
enabled control.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| activeControl | [System.Windows.Forms.Control](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.Control 'System.Windows.Forms.Control') | The child control to scroll into view. |

<a name='M-xyLOGIX-Core-Extensions-IScrollableControl-SetAutoScrollMargin-System-Int32,System-Int32-'></a>
### SetAutoScrollMargin(x,y) `method`

##### Summary

Sets the size of the auto-scroll margins.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| x | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The [Width](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Drawing.Size.Width 'System.Drawing.Size.Width') value. |
| y | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The [Height](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Drawing.Size.Height 'System.Drawing.Size.Height') value. |

<a name='T-xyLOGIX-Core-Extensions-IntExtensions'></a>
## IntExtensions `type`

##### Namespace

xyLOGIX.Core.Extensions

##### Summary

Provides methods that extend the [Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') class.

<a name='M-xyLOGIX-Core-Extensions-IntExtensions-EqualsOneOf-System-Int32,System-Int32[]-'></a>
### EqualsOneOf(value,list) `method`

##### Summary

Returns a value indicating whether the specified
`value` is equal to one of the items in a collection of
integers.

##### Returns

`true` if `value` is one of the
elements of the collection; `false` if not.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | Integer to be compared to the members of the list. |
| list | [System.Int32[]](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32[] 'System.Int32[]') | Collection of integers that should be searched for the
`value`. |

<a name='M-xyLOGIX-Core-Extensions-IntExtensions-IsBitmaskOn-System-Int32,System-Int32-'></a>
### IsBitmaskOn(num,bitmask) `method`

##### Summary

Determines whether a bitmask is 'on' or 'off'.

##### Returns

`true` if the bit that is identified by the bitmask
in the data is 'on'; `false` if it is not.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| num | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | (Required.) Value containing the data to be checked. |
| bitmask | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | (Required.) Bitmask. |

<a name='M-xyLOGIX-Core-Extensions-IntExtensions-ToOrdinalString-System-Int32-'></a>
### ToOrdinalString(value) `method`

##### Summary

Converts an [Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32')`value` to
its ordinal string representation, appending the appropriate suffix (e.g.,
`"st"`, `"nd"`, `"rd"`, `"th"`, etc.) based on the
specified `value`.

##### Returns

If successful, a [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') containing the ordinal
representation of the provided `value`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | (Required.) An [Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') value that
represents the number to format.



The argument of this parameter must be `1` or greater. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentOutOfRangeException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentOutOfRangeException 'System.ArgumentOutOfRangeException') | Thrown when the provided
`value` is less than 1. |

<a name='T-xyLOGIX-Core-Extensions-LanguageArticleType'></a>
## LanguageArticleType `type`

##### Namespace

xyLOGIX.Core.Extensions

##### Summary

Specifies the kind of article, if any, to be inserted before a noun phrase
during phrase rewording.

<a name='F-xyLOGIX-Core-Extensions-LanguageArticleType-Definite'></a>
### Definite `constants`

##### Summary

Indicates that the definite article `the` should be inserted.

<a name='F-xyLOGIX-Core-Extensions-LanguageArticleType-Indefinite'></a>
### Indefinite `constants`

##### Summary

Indicates that the indefinite article `a` or `an` should be inserted,
depending on the starting sound of the following word.

<a name='F-xyLOGIX-Core-Extensions-LanguageArticleType-None'></a>
### None `constants`

##### Summary

Indicates that no article should be inserted.

<a name='F-xyLOGIX-Core-Extensions-LanguageArticleType-PrepopsitionWithDefinite'></a>
### PrepopsitionWithDefinite `constants`

##### Summary

Indicates that a preposition should be inserted, the default being `of`,
followed by the definite article, `the`.

<a name='F-xyLOGIX-Core-Extensions-LanguageArticleType-PrepopsitionWithIndefinite'></a>
### PrepopsitionWithIndefinite `constants`

##### Summary

Indicates that a preposition should be inserted, the default being `of`,
followed by the indefinite article, `a` or `an`.

<a name='F-xyLOGIX-Core-Extensions-LanguageArticleType-Preposition'></a>
### Preposition `constants`

##### Summary

Indicates that a preposition should be inserted, the default being `of`.

<a name='F-xyLOGIX-Core-Extensions-LanguageArticleType-Unknown'></a>
### Unknown `constants`

##### Summary

Unknown article type.

<a name='T-xyLOGIX-Core-Extensions-LanguageArticleTypeValidator'></a>
## LanguageArticleTypeValidator `type`

##### Namespace

xyLOGIX.Core.Extensions

##### Summary

Validates whether certain value(s) are within the defined value set of the
[LanguageArticleType](#T-xyLOGIX-Core-Extensions-LanguageArticleType 'xyLOGIX.Core.Extensions.LanguageArticleType') enumeration.

<a name='M-xyLOGIX-Core-Extensions-LanguageArticleTypeValidator-#ctor'></a>
### #ctor() `constructor`

##### Summary

Empty, private constructor to prohibit direct allocation of this
class.

##### Parameters

This constructor has no parameters.

<a name='P-xyLOGIX-Core-Extensions-LanguageArticleTypeValidator-Instance'></a>
### Instance `property`

##### Summary

Gets a reference to the one and only instance of the object that
implements the
[ILanguageArticleTypeValidator](#T-xyLOGIX-Core-Extensions-ILanguageArticleTypeValidator 'xyLOGIX.Core.Extensions.ILanguageArticleTypeValidator')
interface.

<a name='M-xyLOGIX-Core-Extensions-LanguageArticleTypeValidator-#cctor'></a>
### #cctor() `method`

##### Summary

Empty, `static` constructor to prohibit direct allocation of this class.

##### Parameters

This method has no parameters.

<a name='M-xyLOGIX-Core-Extensions-LanguageArticleTypeValidator-IsValid-xyLOGIX-Core-Extensions-LanguageArticleType-'></a>
### IsValid(type) `method`

##### Summary

Determines whether the language article `type` value
passed is within the value set that is defined by the
[LanguageArticleType](#T-xyLOGIX-Core-Extensions-LanguageArticleType 'xyLOGIX.Core.Extensions.LanguageArticleType') enumeration.

##### Returns

`true` if the language article
`type` falls within the defined value set;
`false` otherwise.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| type | [xyLOGIX.Core.Extensions.LanguageArticleType](#T-xyLOGIX-Core-Extensions-LanguageArticleType 'xyLOGIX.Core.Extensions.LanguageArticleType') | (Required.) One of the
[LanguageArticleType](#T-xyLOGIX-Core-Extensions-LanguageArticleType 'xyLOGIX.Core.Extensions.LanguageArticleType') value(s) that is to
be examined. |

<a name='T-xyLOGIX-Core-Extensions-ListExtensions'></a>
## ListExtensions `type`

##### Namespace

xyLOGIX.Core.Extensions

##### Summary

Provides methods to help with lists of items.

<a name='M-xyLOGIX-Core-Extensions-ListExtensions-#cctor'></a>
### #cctor() `method`

##### Summary

Initializes static data or performs actions that need to be performed once only
for the [ListExtensions](#T-xyLOGIX-Core-Extensions-ListExtensions 'xyLOGIX.Core.Extensions.ListExtensions') class.

##### Parameters

This method has no parameters.

##### Remarks

This constructor is called automatically prior to the first instance being
created or before any static members are referenced.



We've decorated this constructor with the `[Log(AttributeExclude = true)]`
attribute in order to simplify the logging output.

<a name='M-xyLOGIX-Core-Extensions-ListExtensions-AddDistinct-System-Collections-IList,System-Object-'></a>
### AddDistinct(list,item) `method`

##### Summary

Adds an `item` to a `list`, but
only if the item is not already present in the list. If it is, then this method
does nothing. If `null` is passed for the
`list` parameter, then this method likewise also does
nothing.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| list | [System.Collections.IList](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.IList 'System.Collections.IList') | Reference to an instance of an object that implements the
[IList](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.IList 'System.Collections.IList') interface. |
| item | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | Element to be added to the collection, unless it's in the
collection already. |

<a name='M-xyLOGIX-Core-Extensions-ListExtensions-AddDistinct``1-System-Collections-Generic-IList{``0},``0-'></a>
### AddDistinct\`\`1(list,item) `method`

##### Summary

Adds an `item` to a `list`, but
only if the item is not already present in the collection. If it is, then this
method does nothing.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| list | [System.Collections.Generic.IList{\`\`0}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IList 'System.Collections.Generic.IList{``0}') | Reference to a list that implements the
[IList](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IList 'System.Collections.Generic.IList') interface for items of type
`T`. |
| item | [\`\`0](#T-``0 '``0') | Element to be added to the collection, unless it's in the
collection already. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | Type of the new element. |

##### Remarks

This method does nothing if the values of either the `list`
or the `item` parameter(s), respectively, are set to a
`null` reference.

<a name='M-xyLOGIX-Core-Extensions-ListExtensions-AddDistinct``1-System-Collections-Generic-ICollection{``0},``0-'></a>
### AddDistinct\`\`1(collection,item) `method`

##### Summary

Adds an `item` to a `collection`,
but only if the item is not already present in the collection. If the
`item` is already a member of the
`collection` , then this method does nothing.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| collection | [System.Collections.Generic.ICollection{\`\`0}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.ICollection 'System.Collections.Generic.ICollection{``0}') | Reference to a list that implements the
[ICollection{T}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.ICollection 'System.Collections.Generic.ICollection{T}') interface for items
of type `T`. |
| item | [\`\`0](#T-``0 '``0') | Element to be added to the collection, unless it's in the
collection already. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | Type of the elements of the `collection`
. |

<a name='M-xyLOGIX-Core-Extensions-ListExtensions-AddRange``1-System-Collections-Generic-IList{``0},System-Collections-Generic-IEnumerable{``0}-'></a>
### AddRange\`\`1(list,items) `method`

##### Summary

Adds a collection of `items` to the specified
`list`.

##### Returns

The specified `list` with the provided
`items` added to it.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| list | [System.Collections.Generic.IList{\`\`0}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IList 'System.Collections.Generic.IList{``0}') | (Required.) Collection to which the specified
`items` are to be added. |
| items | [System.Collections.Generic.IEnumerable{\`\`0}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable 'System.Collections.Generic.IEnumerable{``0}') | (Required.) Collection of `items` to be
added to the specified `list`. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | (Required.) Name of the type of the individual elements of
the `list`. |

<a name='M-xyLOGIX-Core-Extensions-ListExtensions-Clone``1-System-Collections-Generic-ICollection{``0}-'></a>
### Clone\`\`1(source) `method`

##### Summary

Creates a duplicate of the list given to it and returns a reference
to the clone.

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

<a name='M-xyLOGIX-Core-Extensions-ListExtensions-DumpToLog``1-System-Collections-Generic-IList{``0}-'></a>
### DumpToLog\`\`1(list) `method`

##### Summary

Dumps the contents of the specified `list` to the log, with
indices of the individual element(s) shown.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| list | [System.Collections.Generic.IList{\`\`0}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IList 'System.Collections.Generic.IList{``0}') | (Required.) Reference to an instance of the list whose
contents are to be dumped. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | (Required.) The type of each of the element(s) of the list. |

##### Remarks

This method is primarily intended to be called from the
window in the Visual Studio IDE.



If a `null` reference is passed for the argument of the
`list` parameter, then this method does nothing.



No action is also taken if the `list` contains zero
element(s).

<a name='M-xyLOGIX-Core-Extensions-ListExtensions-FindIndex``1-System-Collections-Generic-IList{``0},System-Predicate{``0}-'></a>
### FindIndex\`\`1(list,predicate) `method`

##### Summary

Searches the provided `list`, trying to locate the element
that satisfies the Boolean conditions imposed by the specified
`predicate`.



The zero-based index into the list at which the first matching element exists
is returned, or `-1` if no matching element can be found.

##### Returns

Zero-based index of the first element of the specified
`list` for which the specified `predicate`
evaluates to `true`; or `-1` if no such element can be
located.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| list | [System.Collections.Generic.IList{\`\`0}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IList 'System.Collections.Generic.IList{``0}') | (Required.) Reference to an instance of the collection of
items that is to be searched. |
| predicate | [System.Predicate{\`\`0}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Predicate 'System.Predicate{``0}') | (Required.) A predicate that evaluates to
`true` or `false` for each element of the
specified `list`, specifying the conditions by which a match
is to be identified. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | (Required.) Data type of each `list`
element. |

<a name='M-xyLOGIX-Core-Extensions-ListExtensions-IsIdenticalTo``1-System-Collections-Generic-IList{``0},System-Collections-Generic-IList{``0}-'></a>
### IsIdenticalTo\`\`1(left,right) `method`

##### Summary

Compares a `left` and `right` list.

##### Returns

`true` if both the `left` and
`right` lists are identical; otherwise,
`false`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| left | [System.Collections.Generic.IList{\`\`0}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IList 'System.Collections.Generic.IList{``0}') | (Required.) A collection of objects to check against. |
| right | [System.Collections.Generic.IList{\`\`0}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IList 'System.Collections.Generic.IList{``0}') | (Required.) A collection of objects that serves as the
right-hand side of the comparison. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | (Required.) Data type of each element. |

##### Remarks

Returns `true` if either both the `left` and
`right` lists are set to a `null` reference;
otherwise, they must both be non-`null`, have the same count
of elements, and all elements must be identical, otherwise this method returns
`false`.

<a name='M-xyLOGIX-Core-Extensions-ListExtensions-IsOneOf-System-Int32,System-Collections-Generic-IEnumerable{System-Int32}-'></a>
### IsOneOf(value,valueSet) `method`

##### Summary

Gets a value indicating whether the `value` is
among the elements of the `valueSet`.

##### Returns

true if `value` is in the
`valueSet` ; false otherwise.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | Value to compare. |
| valueSet | [System.Collections.Generic.IEnumerable{System.Int32}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable 'System.Collections.Generic.IEnumerable{System.Int32}') | Range of integer values to check. |

<a name='M-xyLOGIX-Core-Extensions-ListExtensions-NthLast``1-System-Collections-Generic-IList{``0},System-Int32-'></a>
### NthLast\`\`1(source,index) `method`

##### Summary

Returns the `index`-th element counted from the end of
the `source` collection (0 ⇒ last, 1 ⇒ second-to-last,
and so on).

##### Returns

A reference to the requested element, or the default value of
`TSource` on failure.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| source | [System.Collections.Generic.IList{\`\`0}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IList 'System.Collections.Generic.IList{``0}') | (Required.) The collection to inspect.  A `null`
reference or an empty collection causes the method to return the default
value of `TSource`. |
| index | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | (Required.) Zero-based offset from the last element.  Must be greater
than or equal to zero and strictly less than `source.Count`. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TSource | The element type of the `source` collection. |

##### Remarks

The method never throws; on any error it returns
`default()` after logging the
exception.

<a name='M-xyLOGIX-Core-Extensions-ListExtensions-RemoveRange``1-System-Collections-Generic-IList{``0},System-Int32,System-Int32-'></a>
### RemoveRange\`\`1(list,index,count) `method`

##### Summary

Removes `count` items from the specified
`list`, starting at the specified zero-based
`index`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| list | [System.Collections.Generic.IList{\`\`0}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IList 'System.Collections.Generic.IList{``0}') | (Required.) Collection of items from which certain elements
are to be removed. |
| index | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | (Required.) Must be zero or greater.  Starting zero-based
index of the first element to be removed from the specified
`list`. |
| count | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | (Required.) A number that is 1 or greater, indicating how
many items are to be removed from the specified `list`. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | (Required.) Data type of each of the elements of
`list`. |

##### Remarks

If the input `list` is `null` or
contains zero elements, then this method does nothing.



This method also does nothing in the event that `index` is
less than zero, or `count` is less than or equal to zero.

<a name='M-xyLOGIX-Core-Extensions-ListExtensions-TakeAllButLast``1-System-Collections-Generic-IList{``0},System-Int32,System-Boolean-'></a>
### TakeAllButLast\`\`1(source,count,includeNulls) `method`

##### Summary

Returns a new collection that contains every element of
`source`the last
`count` element(s).

##### Returns

A new [AdvisableCollection{TSource}](#T-AdvisableCollection{TSource} 'AdvisableCollection{TSource}') that contains all
elements of `source` except the last
`count`; or an empty collection under the conditions
noted above.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| source | [System.Collections.Generic.IList{\`\`0}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IList 'System.Collections.Generic.IList{``0}') | (Required.) The input list.  If it is `null` or empty,
the method returns an empty collection. |
| count | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | (Required.) The number of trailing elements to omit.  If
`count` is less than or equal to zero, the method
returns a copy of the entire `source` collection.  If
`count` is greater than or equal to
`source.Count`, the method returns an empty collection. |
| includeNulls | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | (Optional.) If `true`, the method copies
`null` value(s) that may be present in the specified
`source` collection to the resulting collection; if
`false`, the method skips `null` value(s) in
the specified `source` collection.



The default value of this parameter is `true`. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TSource | The element type of the `source` collection. |

##### Remarks



<a name='M-xyLOGIX-Core-Extensions-ListExtensions-ToConcurrentList``1-System-Collections-Generic-IEnumerable{``0}-'></a>
### ToConcurrentList\`\`1(items) `method`

##### Summary

Adds the specified `items` to an instance of
[ConcurrentList\`1](#T-xyLOGIX-Collections-Synchronized-ConcurrentList`1 'xyLOGIX.Collections.Synchronized.ConcurrentList`1').

##### Returns

Adds the provided `items` to a new instance of
[ConcurrentList\`1](#T-xyLOGIX-Collections-Synchronized-ConcurrentList`1 'xyLOGIX.Collections.Synchronized.ConcurrentList`1'), and returns
a reference to it.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| items | [System.Collections.Generic.IEnumerable{\`\`0}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable 'System.Collections.Generic.IEnumerable{``0}') | (Required.) Enumerable collection of items to be added to
the new list. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | (Required.) Data type of each element. |

##### Remarks

If no `items` are supplied, or the
`items` parameter is set to a `null`
reference, then this method returns the empty collection.



The collection to be returned has its excess memory storage reduced to match
the actual number of items in the collection, and the garbage collector is run,
prior to being returned by this method.

<a name='M-xyLOGIX-Core-Extensions-ListExtensions-ToSetString``1-System-Collections-Generic-IList{``0},System-Int32,System-Boolean-'></a>
### ToSetString\`\`1(list,max,all) `method`

##### Summary

Writes a list variable out in “Pythonic” notation, e.g.,
`[ 1, 2, 3 ]`.

##### Returns

The list, formatted as a string for logging.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| list | [System.Collections.Generic.IList{\`\`0}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IList 'System.Collections.Generic.IList{``0}') | List to be written. |
| max | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | Maximum number of items to include before appending an ellipsis;
must be `>= 1`. Default is `2`. |
| all | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | `true` to write **every** non-null item,
`false` (to write only the first `max`
items) is the default. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | The type of each element of the list. |

##### Remarks

Per-item formatting is delegated to
[ToLogRepresentation](#M-xyLOGIX-Core-Extensions-ObjectExtensions-ToLogRepresentation-System-Object- 'xyLOGIX.Core.Extensions.ObjectExtensions.ToLogRepresentation(System.Object)'), so any
PostSharp `Formatter<T>` you register is automatically applied.

<a name='M-xyLOGIX-Core-Extensions-ListExtensions-ToSetString``1-System-Collections-Generic-ICollection{``0},System-Int32-'></a>
### ToSetString\`\`1(collection,max) `method`

##### Summary

Converts an [ICollection\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.ICollection`1 'System.Collections.Generic.ICollection`1') to a
concise, Pythonic, set-style string (e.g., `[ 1, 2, 3, ... ]`) for
logging.

##### Returns

A string such as `[ 42, 99 ]`, `[ <null> ]`,
`[ person:Brian, ... ]`, etc.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| collection | [System.Collections.Generic.ICollection{\`\`0}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.ICollection 'System.Collections.Generic.ICollection{``0}') | The collection to format. |
| max | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | Maximum number of items to include before appending an ellipsis; must
be `>= 1`. Defaults to `2`. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | Type of the collection item. |

##### Remarks

Uses [ToLogRepresentation](#M-xyLOGIX-Core-Extensions-ObjectExtensions-ToLogRepresentation-System-Object- 'xyLOGIX.Core.Extensions.ObjectExtensions.ToLogRepresentation(System.Object)') for
per-item formatting, so any `Formatter<T>` you register with
PostSharp is automatically honored.

<a name='M-xyLOGIX-Core-Extensions-ListExtensions-ToSetString``1-System-Collections-Generic-IEnumerable{``0},System-Int32-'></a>
### ToSetString\`\`1(source,max) `method`

##### Summary

Writes a list variable out as a Pythonic list, [1,2,3,4] e.g. Stops past the
tenth item.

##### Returns

The `source`, formatted as a set string.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| source | [System.Collections.Generic.IEnumerable{\`\`0}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable 'System.Collections.Generic.IEnumerable{``0}') | Collection to be written. |
| max | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | (Optional.) Integer value specifying the max number of element(s) of the
collection to write.



Must be one or greater.



The default value of this parameter is 2. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | The type of each element of the list. |

##### Remarks

This method is helpful for writing some of the members of a
collection to a log file.

<a name='T-xyLOGIX-Core-Extensions-LongExtensions'></a>
## LongExtensions `type`

##### Namespace

xyLOGIX.Core.Extensions

##### Summary

Extension methods for a `long` value.

<a name='M-xyLOGIX-Core-Extensions-LongExtensions-IsNegative-System-Int64-'></a>
### IsNegative(value) `method`

##### Summary

Indicates whether the specified `value` is non-
`null` and has a strictly negative (i.e., less than zero)
numerical value.

##### Returns

`true` if the `value` is non-
`null` and has a numerical value that is strictly less than
zero; `false` otherwise.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.Int64](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int64 'System.Int64') | A nullable [Int64](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int64 'System.Int64') value to be
checked. |

<a name='M-xyLOGIX-Core-Extensions-LongExtensions-IsNonNegative-System-Int64-'></a>
### IsNonNegative(value) `method`

##### Summary

Indicates whether the specified `value` is nonnegative (i.e.,
greater than, or equal to, zero).

##### Returns

`true` if the `value` is greater than, or
equal to, zero; `false` otherwise.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.Int64](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int64 'System.Int64') | A [Int64](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int64 'System.Int64') value to be checked. |

<a name='M-xyLOGIX-Core-Extensions-LongExtensions-IsNonPositive-System-Int64-'></a>
### IsNonPositive(value) `method`

##### Summary

Indicates whether the specified `value` is nonpositive (i.e.,
less than, or equal to, zero).

##### Returns

`true` if the `value` is less than, or
equal to, zero; `false` otherwise.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.Int64](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int64 'System.Int64') | A [Int64](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int64 'System.Int64') value to be checked. |

<a name='M-xyLOGIX-Core-Extensions-LongExtensions-IsNonzero-System-Int64-'></a>
### IsNonzero(value) `method`

##### Summary

Indicates whether the specified `value` is non-
`null` and has a numerical value that is strictly not equal to
zero.

##### Returns

`true` if the `value` is non-
`null` and has a numerical value that is strictly not equal
zero; `false` if the `value` is identically
equal to zero

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.Int64](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int64 'System.Int64') | A nullable [Int64](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int64 'System.Int64') value to be
checked. |

##### Remarks

Callers must remember that this method returns
`falsedoc` only in the case where the numeric value of
`value` is identically equal to `0L`.

<a name='M-xyLOGIX-Core-Extensions-LongExtensions-IsPositive-System-Int64-'></a>
### IsPositive(value) `method`

##### Summary

Indicates whether the specified `value` is strictly
positive (i.e., greater than zero).

##### Returns

`true` if the `value` is strictly
greater than zero; `false` otherwise.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.Int64](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int64 'System.Int64') | A [Int64](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int64 'System.Int64') value to be checked. |

<a name='T-xyLOGIX-Core-Extensions-MarkdownExtensions'></a>
## MarkdownExtensions `type`

##### Namespace

xyLOGIX.Core.Extensions

##### Summary

Exposes static extension method(s) for manipulating Markdown text.

<a name='M-xyLOGIX-Core-Extensions-MarkdownExtensions-#cctor'></a>
### #cctor() `method`

##### Summary

Initializes static data or performs actions that need to be performed once only
for the [MarkdownExtensions](#T-xyLOGIX-Core-Extensions-MarkdownExtensions 'xyLOGIX.Core.Extensions.MarkdownExtensions') class.

##### Parameters

This method has no parameters.

##### Remarks

This constructor is called automatically prior to the first instance being
created or before any static members are referenced.



We've decorated this constructor with the `[Log(AttributeExclude = true)]`
attribute in order to simplify the logging output.

<a name='M-xyLOGIX-Core-Extensions-MarkdownExtensions-AsCode-System-String-'></a>
### AsCode(code) `method`

##### Summary

Wraps the `code` into Markdown backticks safely.

##### Returns

If successful, a [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') containing the
corresponding Markdown; otherwise, the method returns the
[Empty](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String.Empty 'System.String.Empty') value.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| code | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) A [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') containing the content that is to
be wrapped in Markdown backticks. |

##### Remarks

See also

.

<a name='M-xyLOGIX-Core-Extensions-MarkdownExtensions-AsSpanMargin-System-Xml-Linq-XNode-'></a>
### AsSpanMargin(node) `method`

##### Summary

Attempts to detect leading whitespace in the value of the specified
`node` and, if found, carries the whitespace over to the
resultant Markdown span as a whitespace character.

##### Returns

If successful, a [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') containing the
resultant Markdown; otherwise, the method returns the
[Empty](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String.Empty 'System.String.Empty') value.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| node | [System.Xml.Linq.XNode](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Xml.Linq.XNode 'System.Xml.Linq.XNode') | (Required.) Reference to an instance of [XNode](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Xml.Linq.XNode 'System.Xml.Linq.XNode')
that represents the XML node that is to be examined for leading whitespace. |

##### Remarks

If a `null` reference is passed as the argument of
the `node` parameter, then the method returns the
[Empty](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String.Empty 'System.String.Empty') value.



The method also returns the [Empty](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String.Empty 'System.String.Empty') value if the
specified `node` is not of type
[XText](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Xml.Linq.XText 'System.Xml.Linq.XText').

<a name='M-xyLOGIX-Core-Extensions-MarkdownExtensions-EscapeMarkdownText-System-String-'></a>
### EscapeMarkdownText(content) `method`

##### Summary

Escapes the specified `content` by replacing all backticks
with a backtick preceded by a backslash, so that the content can be safely used
in Markdown as-is.

##### Returns

The escaped content.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| content | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) A [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') containing the content that is to
be escaped. |

##### Remarks

If `null`, a blank [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String'), or
the [Empty](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String.Empty 'System.String.Empty') value is passed as the argument of the
parameter, `content`, then this method returns the
[Empty](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String.Empty 'System.String.Empty') value.



The method is idempotent if the `content` does not contain
any backticks.

<a name='M-xyLOGIX-Core-Extensions-MarkdownExtensions-ToHereLink-System-String-'></a>
### ToHereLink(hyperlink) `method`

##### Summary

Generates a "to here" link for the `hyperlink`.

##### Returns

The "to here" link for the `hyperlink`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| hyperlink | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) A [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') that
contains the hyperlink reference destination. |

<a name='M-xyLOGIX-Core-Extensions-MarkdownExtensions-ToOpeningAnchorTag-System-String-'></a>
### ToOpeningAnchorTag(hyperlink) `method`

##### Summary

Generates an opening anchor tag, i.e., `<a name="hyperlink" >` for
the specified `hyperlink`.

##### Returns

If successful, a [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') containing the anchor
for the specified `hyperlink`; otherwise, the method returns
the [Empty](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String.Empty 'System.String.Empty') value.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| hyperlink | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) A [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') that
contains the hyperlink reference destination. |

##### Remarks

If `null`, a blank [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String'), or the
[Empty](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String.Empty 'System.String.Empty') value is passed as the argument of the
`hyperlink` parameter, then this method returns the
[Empty](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String.Empty 'System.String.Empty') value.



Callers of this method should ensure that the value of the
`hyperlink` parameter is a valid HTML anchor name.



This method only generates the opening anchor tag; it does not generate the
closing anchor tag, i.e., `</a>`.

<a name='T-xyLOGIX-Core-Extensions-NullableDecimalExtensions'></a>
## NullableDecimalExtensions `type`

##### Namespace

xyLOGIX.Core.Extensions

##### Summary

Extension methods for a `decimal?` value.

<a name='M-xyLOGIX-Core-Extensions-NullableDecimalExtensions-IsNegative-System-Nullable{System-Decimal}-'></a>
### IsNegative(value) `method`

##### Summary

Indicates whether the specified `value` is non-
`null` and has a strictly negative (i.e., less than zero)
numerical value.

##### Returns

`true` if the `value` is non-
`null` and has a numerical value that is strictly less than
zero; `false` otherwise.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.Nullable{System.Decimal}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{System.Decimal}') | A nullable [decimal](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.decimal 'System.decimal') value to be
checked. |

<a name='M-xyLOGIX-Core-Extensions-NullableDecimalExtensions-IsNonPositive-System-Nullable{System-Decimal}-'></a>
### IsNonPositive(value) `method`

##### Summary

Determines whether the specified `value` is
non-positive; i.e., zero, or a negative number.

##### Returns

`true` if the specified `value` is
nonpositive; `false` if the `value` is
strictly greater than[Zero](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Decimal.Zero 'System.Decimal.Zero').

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.Nullable{System.Decimal}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{System.Decimal}') | (Required.) Value to be compared.  Must be of
[Decimal](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Decimal 'System.Decimal') data type. |

<a name='M-xyLOGIX-Core-Extensions-NullableDecimalExtensions-IsNonzero-System-Nullable{System-Decimal}-'></a>
### IsNonzero(value) `method`

##### Summary

Indicates whether the specified `value` is non-
`null` and has a numerical value that is strictly not equal to
zero.

##### Returns

`true` if the `value` is non-
`null` and has a numerical value that is strictly not equal
zero; `false` if the `value` is identically
equal to zero

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.Nullable{System.Decimal}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{System.Decimal}') | A nullable [decimal](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.decimal 'System.decimal') value to be
checked. |

##### Remarks

Callers must remember that this method returns
`falsedoc` only in the case where the numeric value of
`value` is identically equal to `decimal.Zero`.

<a name='M-xyLOGIX-Core-Extensions-NullableDecimalExtensions-IsPositive-System-Nullable{System-Decimal}-'></a>
### IsPositive(value) `method`

##### Summary

Indicates whether the specified `value` is non-
`null` and has a strictly positive (i.e., greater than zero)
numerical value.

##### Returns

`true` if the `value` is non-
`null` and has a numerical value that is strictly greater than
zero; `false` otherwise.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.Nullable{System.Decimal}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{System.Decimal}') | A nullable [decimal](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.decimal 'System.decimal') value to be
checked. |

<a name='M-xyLOGIX-Core-Extensions-NullableDecimalExtensions-IsValid-System-Nullable{System-Decimal}-'></a>
### IsValid(value) `method`

##### Summary

Indicates whether the specified `value` is non-
`null`.

##### Returns

`true` if the `value` is non-
`null`; `false` otherwise.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.Nullable{System.Decimal}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{System.Decimal}') | A nullable [decimal](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.decimal 'System.decimal') value to be
checked. |

<a name='M-xyLOGIX-Core-Extensions-NullableDecimalExtensions-ToNearestCent-System-Nullable{System-Decimal}-'></a>
### ToNearestCent(value) `method`

##### Summary

Rounds the specified `value` to the nearest cent, assuming
that the specified `value` is denominated in
`U.S. Dollars (USD)`.

##### Returns

Result of the rounding, using banker's rounding; or
[Zero](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Decimal.Zero 'System.Decimal.Zero') if not successful.



[Zero](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Decimal.Zero 'System.Decimal.Zero') is also returned if
[Zero](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Decimal.Zero 'System.Decimal.Zero') or less is passed as the argument of
`value`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.Nullable{System.Decimal}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{System.Decimal}') | (Required.) The [Decimal](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Decimal 'System.Decimal') value that
is to be rounded. |

<a name='T-xyLOGIX-Core-Extensions-NullableDoubleExtensions'></a>
## NullableDoubleExtensions `type`

##### Namespace

xyLOGIX.Core.Extensions

##### Summary

Extension methods for a `double?` value.

<a name='M-xyLOGIX-Core-Extensions-NullableDoubleExtensions-IsNegative-System-Nullable{System-Double}-'></a>
### IsNegative(value) `method`

##### Summary

Indicates whether the specified `value` is non-
`null` and has a strictly negative (i.e., less than zero)
numerical value.

##### Returns

`true` if the `value` is non-
`null` and has a numerical value that is strictly less than
zero; `false` otherwise.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.Nullable{System.Double}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{System.Double}') | A nullable [Double](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Double 'System.Double') value to be
checked. |

<a name='M-xyLOGIX-Core-Extensions-NullableDoubleExtensions-IsNonzero-System-Nullable{System-Double}-'></a>
### IsNonzero(value) `method`

##### Summary

Indicates whether the specified `value` is non-
`null` and has a numerical value that is strictly not equal to
zero.

##### Returns

`true` if the `value` is non-
`null` and has a numerical value that is strictly not equal
zero; `false` if the `value` is identically
equal to zero

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.Nullable{System.Double}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{System.Double}') | A nullable [Double](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Double 'System.Double') value to be
checked. |

##### Remarks

Callers must remember that this method returns
`falsedoc` only in the case where the numeric value of
`value` is identically equal to `0D`.

<a name='M-xyLOGIX-Core-Extensions-NullableDoubleExtensions-IsPositive-System-Nullable{System-Double}-'></a>
### IsPositive(value) `method`

##### Summary

Indicates whether the specified `value` is non-
`null` and has a strictly positive (i.e., greater than zero)
numerical value.

##### Returns

`true` if the `value` is non-
`null` and has a numerical value that is strictly greater than
zero; `false` otherwise.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.Nullable{System.Double}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{System.Double}') | A nullable [Double](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Double 'System.Double') value to be
checked. |

<a name='M-xyLOGIX-Core-Extensions-NullableDoubleExtensions-IsValid-System-Nullable{System-Double}-'></a>
### IsValid(value) `method`

##### Summary

Indicates whether the specified `value` is non-
`null`.

##### Returns

`true` if the `value` is non-
`null`; `false` otherwise.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.Nullable{System.Double}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{System.Double}') | A nullable [Double](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Double 'System.Double') value to be
checked. |

<a name='T-xyLOGIX-Core-Extensions-NullableIntExtensions'></a>
## NullableIntExtensions `type`

##### Namespace

xyLOGIX.Core.Extensions

##### Summary

Extension methods for a `int?` value.

<a name='M-xyLOGIX-Core-Extensions-NullableIntExtensions-IsNegative-System-Nullable{System-Int32}-'></a>
### IsNegative(value) `method`

##### Summary

Indicates whether the specified `value` is non-
`null` and has a strictly negative (i.e., less than zero)
numerical value.

##### Returns

`true` if the `value` is non-
`null` and has a numerical value that is strictly less than
zero; `false` otherwise.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.Nullable{System.Int32}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{System.Int32}') | A nullable [Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') value to be
checked. |

<a name='M-xyLOGIX-Core-Extensions-NullableIntExtensions-IsNonzero-System-Nullable{System-Int32}-'></a>
### IsNonzero(value) `method`

##### Summary

Indicates whether the specified `value` is non-
`null` and has a numerical value that is strictly not equal to
zero.

##### Returns

`true` if the `value` is non-
`null` and has a numerical value that is strictly not equal
zero; `false` if the `value` is identically
equal to zero

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.Nullable{System.Int32}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{System.Int32}') | A nullable [Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') value to be
checked. |

##### Remarks

Callers must remember that this method returns
`falsedoc` only in the case where the numeric value of
`value` is identically equal to zero.

<a name='M-xyLOGIX-Core-Extensions-NullableIntExtensions-IsPositive-System-Nullable{System-Int32}-'></a>
### IsPositive(value) `method`

##### Summary

Indicates whether the specified `value` is non-
`null` and has a strictly positive (i.e., greater than zero)
numerical value.

##### Returns

`true` if the `value` is non-
`null` and has a numerical value that is strictly greater than
zero; `false` otherwise.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.Nullable{System.Int32}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{System.Int32}') | A nullable [Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') value to be
checked. |

<a name='M-xyLOGIX-Core-Extensions-NullableIntExtensions-IsValid-System-Nullable{System-Int32}-'></a>
### IsValid(value) `method`

##### Summary

Indicates whether the specified `value` is non-
`null`.

##### Returns

`true` if the `value` is non-
`null`; `false` otherwise.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.Nullable{System.Int32}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{System.Int32}') | A nullable [Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') value to be
checked. |

<a name='T-xyLOGIX-Core-Extensions-NullableLongExtensions'></a>
## NullableLongExtensions `type`

##### Namespace

xyLOGIX.Core.Extensions

##### Summary

Extension methods for a `long?` value.

<a name='M-xyLOGIX-Core-Extensions-NullableLongExtensions-IsNegative-System-Nullable{System-Int64}-'></a>
### IsNegative(value) `method`

##### Summary

Indicates whether the specified `value` is non-
`null` and has a strictly negative (i.e., less than zero)
numerical value.

##### Returns

`true` if the `value` is non-
`null` and has a numerical value that is strictly less than
zero; `false` otherwise.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.Nullable{System.Int64}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{System.Int64}') | A nullable [Int64](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int64 'System.Int64') value to be
checked. |

<a name='M-xyLOGIX-Core-Extensions-NullableLongExtensions-IsNonzero-System-Nullable{System-Int64}-'></a>
### IsNonzero(value) `method`

##### Summary

Indicates whether the specified `value` is non-
`null` and has a numerical value that is strictly not equal to
zero.

##### Returns

`true` if the `value` is non-
`null` and has a numerical value that is strictly not equal
zero; `false` if the `value` is identically
equal to zero

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.Nullable{System.Int64}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{System.Int64}') | A nullable [Int64](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int64 'System.Int64') value to be
checked. |

##### Remarks

Callers must remember that this method returns
`falsedoc` only in the case where the numeric value of
`value` is identically equal to `0L`.

<a name='M-xyLOGIX-Core-Extensions-NullableLongExtensions-IsPositive-System-Nullable{System-Int64}-'></a>
### IsPositive(value) `method`

##### Summary

Indicates whether the specified `value` is non-
`null` and has a strictly positive (i.e., greater than zero)
numerical value.

##### Returns

`true` if the `value` is non-
`null` and has a numerical value that is strictly greater than
zero; `false` otherwise.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.Nullable{System.Int64}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{System.Int64}') | A nullable [Int64](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int64 'System.Int64') value to be
checked. |

<a name='M-xyLOGIX-Core-Extensions-NullableLongExtensions-IsValid-System-Nullable{System-Int64}-'></a>
### IsValid(value) `method`

##### Summary

Indicates whether the specified `value` is non-
`null`.

##### Returns

`true` if the `value` is non-
`null`; `false` otherwise.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.Nullable{System.Int64}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{System.Int64}') | A nullable [Int64](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int64 'System.Int64') value to be
checked. |

<a name='T-xyLOGIX-Core-Extensions-NumberExtensions'></a>
## NumberExtensions `type`

##### Namespace

xyLOGIX.Core.Extensions

##### Summary

Helper functions for doing operations on, or making decisions about,
numerical data.

<a name='M-xyLOGIX-Core-Extensions-NumberExtensions-#cctor'></a>
### #cctor() `method`

##### Summary

Initializes static data or performs actions that need to be performed once only
for the [NumberExtensions](#T-xyLOGIX-Core-Extensions-NumberExtensions 'xyLOGIX.Core.Extensions.NumberExtensions') class.

##### Parameters

This method has no parameters.

##### Remarks

This constructor is called automatically prior to the first instance being
created or before any static members are referenced.



We've decorated this constructor with the `[Log(AttributeExclude = true)]`
attribute in order to simplify the logging output.

<a name='M-xyLOGIX-Core-Extensions-NumberExtensions-AsDecimal-System-Double-'></a>
### AsDecimal(value) `method`

##### Summary

Converts the specified `double` value to
`decimal`.

##### Returns

The specified `value`, converted to type
`decimal`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.Double](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Double 'System.Double') | (Required.) The `double` value to be
converted to `decimal`. |

##### Remarks

This method returns zero if the conversion was not successful, or if
zero is passed for `value`.

<a name='M-xyLOGIX-Core-Extensions-NumberExtensions-AsDecimal-System-Nullable{System-Double}-'></a>
### AsDecimal(value) `method`

##### Summary

Converts the specified `double` value to
`decimal`.

##### Returns

The specified `value`, converted to type
`decimal`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.Nullable{System.Double}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{System.Double}') | (Required.) The `double` value to be
converted to `decimal`. |

##### Remarks

This method returns zero if the conversion was not successful, or if
zero is passed for `value`.

<a name='M-xyLOGIX-Core-Extensions-NumberExtensions-AsDecimal-System-Nullable{System-Int64}-'></a>
### AsDecimal(value) `method`

##### Summary

Converts the specified `long` value to
`decimal`.

##### Returns

The specified `value`, converted to type
`decimal`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.Nullable{System.Int64}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{System.Int64}') | (Required.) The `long` value to be
converted to `decimal`. |

##### Remarks

This method returns zero if the conversion was not successful, or if
zero is passed for `value`.

<a name='M-xyLOGIX-Core-Extensions-NumberExtensions-FloorOf-System-Int32,System-Int32-'></a>
### FloorOf(value,floorValue) `method`

##### Summary

Returns a value that is not less than the specified
`floorValue`.

##### Returns

`floorValue` if the specified
`value` is less than `floorValue`,
otherwise `value`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | (Required.) Input value. |
| floorValue | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | (Required.) Floor value. |

##### Remarks

If the specified `value` is equal to or greater than
the `floorValue`, then this method is the identity.

<a name='M-xyLOGIX-Core-Extensions-NumberExtensions-IsBetween-System-Decimal,System-Decimal,System-Decimal-'></a>
### IsBetween(value,lowerBound,upperBound) `method`

##### Summary

Determines whether a number is strictly between (as in, can't be
equal to either).

##### Returns

True if `value` is strictly greater than
`lowerBound` and strictly less than
`upperBound` ; false otherwise.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.Decimal](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Decimal 'System.Decimal') | The value to be checked. |
| lowerBound | [System.Decimal](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Decimal 'System.Decimal') | Lower bound. |
| upperBound | [System.Decimal](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Decimal 'System.Decimal') | Upper bound. |

<a name='M-xyLOGIX-Core-Extensions-NumberExtensions-IsBetween-System-Int32,System-Int32,System-Int32-'></a>
### IsBetween(value,lowerBound,upperBound) `method`

##### Summary

Determines whether a number is strictly between (as in, can't be
equal to either).

##### Returns

True if `value` is strictly greater than
`lowerBound` and strictly less than
`upperBound` ; false otherwise.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The value to be checked. |
| lowerBound | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | Lower bound. |
| upperBound | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | Upper bound. |

<a name='M-xyLOGIX-Core-Extensions-NumberExtensions-IsBetween-System-Int64,System-Int64,System-Int64-'></a>
### IsBetween(value,lowerBound,upperBound) `method`

##### Summary

Determines whether a number is strictly between (as in, can't be
equal to either).

##### Returns

True if `value` is strictly greater than
`lowerBound` and strictly less than
`upperBound` ; false otherwise.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.Int64](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int64 'System.Int64') | The value to be checked. |
| lowerBound | [System.Int64](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int64 'System.Int64') | Lower bound. |
| upperBound | [System.Int64](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int64 'System.Int64') | Upper bound. |

<a name='M-xyLOGIX-Core-Extensions-NumberExtensions-IsInRangeWithLowerBound-System-Int32,System-Int32,System-Int32-'></a>
### IsInRangeWithLowerBound(value,lowerBound,upperBound) `method`

##### Summary

Determines if an [Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') value is between a pair of
values or equal to the lower bound of the given range.

##### Returns

`true` if the value is either within the range specified or
equal to the `lowerBound`; `false`
otherwise.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The value to be checked. |
| lowerBound | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | Lower bound. |
| upperBound | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | Upper bound. |

##### Remarks

The `upperBound` is EXCLUDED from the range of valid
value(s) by this method.

<a name='M-xyLOGIX-Core-Extensions-NumberExtensions-IsInRangeWithUpperBound-System-Int32,System-Int32,System-Int32-'></a>
### IsInRangeWithUpperBound(value,lowerBound,upperBound) `method`

##### Summary

Determines if an [Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') value is either strictly between
a pair of values or equal to the upper bound of the given range.

##### Returns

`true` if the value is either within the range specified or
equal to the `upperBound`; `false`
otherwise.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The value to be checked. |
| lowerBound | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | Lower bound. |
| upperBound | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | Upper bound. |

<a name='M-xyLOGIX-Core-Extensions-NumberExtensions-IsIncludedInRange-System-Decimal,System-Decimal,System-Decimal-'></a>
### IsIncludedInRange(value,lowerBound,upperBound) `method`

##### Summary

Determines if a decimal value is between a pair of values or equal to
either of them.

##### Returns

`true` if the value is either within the range
specified or equal to either of the bounds; `false` otherwise.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.Decimal](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Decimal 'System.Decimal') | The value to be checked. |
| lowerBound | [System.Decimal](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Decimal 'System.Decimal') | Lower bound. |
| upperBound | [System.Decimal](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Decimal 'System.Decimal') | Upper bound. |

<a name='M-xyLOGIX-Core-Extensions-NumberExtensions-IsIncludedInRange-System-Int32,System-Int32,System-Int32-'></a>
### IsIncludedInRange(value,lowerBound,upperBound) `method`

##### Summary

Determines if an integer value is between a pair of values or equal to
either of them.

##### Returns

`true` if the value is either within the range
specified or equal to either of the bounds; `false` otherwise.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The value to be checked. |
| lowerBound | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | Lower bound. |
| upperBound | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | Upper bound. |

<a name='M-xyLOGIX-Core-Extensions-NumberExtensions-IsNaturalNumber-System-Int32-'></a>
### IsNaturalNumber(value) `method`

##### Summary

Determines whether the specified `value` is a member of the
set of all natural numbers; i.e., one or greater.

##### Returns

`true` if the specified `value` is
a member of the set of all natural numbers; otherwise, `false`
.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | Value to be compared.  Must be of
[Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') data type. |

<a name='M-xyLOGIX-Core-Extensions-NumberExtensions-IsNegative-System-Decimal-'></a>
### IsNegative(value) `method`

##### Summary

Determines if a `value` is negative.

##### Returns

`true` if the `value` is strictly
less than zero; `false` otherwise.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.Decimal](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Decimal 'System.Decimal') | (Required.) Value to be compared. Must be of
[Decimal](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Decimal 'System.Decimal') data type. |

<a name='M-xyLOGIX-Core-Extensions-NumberExtensions-IsNegative-System-Int32-'></a>
### IsNegative(value) `method`

##### Summary

Determines whether the specified `value` is negative; i.e.,
strictly less than zero.

##### Returns

`true` if the specified `value` is negative;
`false` if the `value` is zero or greater.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | (Required.) Value to be compared.  Must be of [Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32')
type. |

<a name='M-xyLOGIX-Core-Extensions-NumberExtensions-IsNonNegative-System-Decimal-'></a>
### IsNonNegative(value) `method`

##### Summary

Determines whether the specified `value` is
non-positive; i.e., zero, or a negative number.

##### Returns

`true` if the specified `value` is
nonnegative; `false` if the `value` is
strictly less than [Zero](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Decimal.Zero 'System.Decimal.Zero').

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.Decimal](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Decimal 'System.Decimal') | (Required.) Value to be compared.  Must be of
[Decimal](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Decimal 'System.Decimal') data type. |

<a name='M-xyLOGIX-Core-Extensions-NumberExtensions-IsNonNegative-System-Int32-'></a>
### IsNonNegative(value) `method`

##### Summary

Determines whether the specified `value` is
non-negative; i.e., zero, or a positive number.

##### Returns

`true` if the specified `value` is
nonnegative; `false` if the `value` is
strictly less than [Zero](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32.Zero 'System.Int32.Zero').

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | (Required.) Value to be compared.  Must be of
[Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') data type. |

<a name='M-xyLOGIX-Core-Extensions-NumberExtensions-IsNonPositive-System-Decimal-'></a>
### IsNonPositive(value) `method`

##### Summary

Determines whether the specified `value` is
non-positive; i.e., zero, or a negative number.

##### Returns

`true` if the specified `value` is
nonpositive; `false` if the `value` is
strictly greater than[Zero](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Decimal.Zero 'System.Decimal.Zero').

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.Decimal](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Decimal 'System.Decimal') | (Required.) Value to be compared.  Must be of
[Decimal](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Decimal 'System.Decimal') data type. |

<a name='M-xyLOGIX-Core-Extensions-NumberExtensions-IsNonPositive-System-Int32-'></a>
### IsNonPositive(value) `method`

##### Summary

Determines whether the specified `value` is
non-positive; i.e., zero, or a negative number.

##### Returns

`true` if the specified `value` is
nonpositive; `false` if the `value` is
strictly greater than[Zero](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32.Zero 'System.Int32.Zero').

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | (Required.) Value to be compared.  Must be of
[Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') data type. |

<a name='M-xyLOGIX-Core-Extensions-NumberExtensions-IsNonzero-System-Decimal-'></a>
### IsNonzero(value) `method`

##### Summary

Determines whether a `value` is nonzero.

##### Returns

`true` if the specified `value` is
strictly nonzero; `false` if the `value` is
identically equal to [Zero](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Decimal.Zero 'System.Decimal.Zero').

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.Decimal](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Decimal 'System.Decimal') | (Required.) Value to be compared.  Must be of
[Decimal](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Decimal 'System.Decimal') data type. |

<a name='M-xyLOGIX-Core-Extensions-NumberExtensions-IsNonzero-System-Double-'></a>
### IsNonzero(value) `method`

##### Summary

Determines whether a `value` is nonzero.

##### Returns

`true` if the specified `value` is
strictly nonzero; `false` if the `value` is
identically equal to [Zero](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Decimal.Zero 'System.Decimal.Zero').

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.Double](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Double 'System.Double') | (Required.) Value to be compared.  Must be of
[Decimal](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Decimal 'System.Decimal') data type. |

<a name='M-xyLOGIX-Core-Extensions-NumberExtensions-IsPositive-System-Int32-'></a>
### IsPositive(value) `method`

##### Summary

Determines whether the specified `value` is a positive
integer; i.e., the `value` is strictly greater than zero.

##### Returns

`true` if the specified `value` is
greater than zero; otherwise, `false`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | Value to be compared.  Must be of
[Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') data type. |

<a name='M-xyLOGIX-Core-Extensions-NumberExtensions-IsPositive-System-Decimal-'></a>
### IsPositive(value) `method`

##### Summary

Determines whether a `value` is positive.

##### Returns

`true` if the `value` is strictly
greater than zero; `false` otherwise.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.Decimal](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Decimal 'System.Decimal') | (Required.)  Value to be compared. Must be of
[Decimal](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Decimal 'System.Decimal') data type. |

<a name='M-xyLOGIX-Core-Extensions-NumberExtensions-IsPositive-System-Double-'></a>
### IsPositive(value) `method`

##### Summary

Determines whether a `value` is positive.

##### Returns

`true` if the `value` is strictly
greater than zero; `false` otherwise.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.Double](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Double 'System.Double') | (Required.)  Value to be compared. Must be of
[Double](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Double 'System.Double') data type. |

<a name='M-xyLOGIX-Core-Extensions-NumberExtensions-IsZero-System-Decimal-'></a>
### IsZero(value) `method`

##### Summary

Determines whether a `value` is zero.

##### Returns

True if the `value` is zero; false otherwise.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.Decimal](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Decimal 'System.Decimal') | Value to be compared. |

<a name='M-xyLOGIX-Core-Extensions-NumberExtensions-ToNearestCent-System-Decimal-'></a>
### ToNearestCent(value) `method`

##### Summary

Rounds the specified `value` to the nearest cent, using
banker's rounding, assuming that the specified `value` is
denominated in `U.S. Dollars (USD)`.

##### Returns

Result of the rounding, using banker's rounding; or
[Zero](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Decimal.Zero 'System.Decimal.Zero') if not successful.



[Zero](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Decimal.Zero 'System.Decimal.Zero') is also returned if
[Zero](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Decimal.Zero 'System.Decimal.Zero') or less is passed as the argument of
`value`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.Decimal](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Decimal 'System.Decimal') | (Required.) The [Decimal](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Decimal 'System.Decimal') value that
is to be rounded. |

<a name='M-xyLOGIX-Core-Extensions-NumberExtensions-TruncateDecimalPlaces-System-Decimal,System-Int32-'></a>
### TruncateDecimalPlaces(val,places) `method`

##### Summary

Takes a value of type decimal and truncates it to the specified
number of places.

##### Returns

New decimal value with all the digits removed except places digits
following the decimal point.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| val | [System.Decimal](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Decimal 'System.Decimal') | Value to be truncated. |
| places | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | Number of digits following the decimal point. |

<a name='M-xyLOGIX-Core-Extensions-NumberExtensions-ZeroFloor-System-Int32-'></a>
### ZeroFloor(value) `method`

##### Summary

Computes the zero floor.  Meaning, if the specified
`value` is negative, then this method returns zero.



If the specified `value` is zero or greater, then this method
is the identity.

##### Returns

Zero if the specified `value` is negative;
otherwise, if the specified `value` is zero or greater, then
the method is the identity map.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | (Required.) Input value. |

<a name='M-xyLOGIX-Core-Extensions-NumberExtensions-ZeroFloor-System-Double-'></a>
### ZeroFloor(value) `method`

##### Summary

Computes the zero floor.  Meaning, if the specified
`value` is negative, then this method returns zero.



If the specified `value` is zero or greater, then this method
is the identity.

##### Returns

Zero if the specified `value` is negative;
otherwise, if the specified `value` is zero or greater, then
the method is the identity map.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.Double](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Double 'System.Double') | (Required.) Input value. |

<a name='M-xyLOGIX-Core-Extensions-NumberExtensions-ZeroFloor-System-Decimal-'></a>
### ZeroFloor(value) `method`

##### Summary

Computes the zero floor.  Meaning, if the specified
`value` is negative, then this method returns zero.



If the specified `value` is zero or greater, then this method
is idempotent.

##### Returns

Zero if the specified `value` is negative;
otherwise, if the specified `value` is zero or greater, then
the method is the identity map.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.Decimal](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Decimal 'System.Decimal') | (Required.) Input value. |

<a name='T-xyLOGIX-Core-Extensions-ObjectExtensions'></a>
## ObjectExtensions `type`

##### Namespace

xyLOGIX.Core.Extensions

##### Summary

Exposes static extension methods for [Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object').

<a name='M-xyLOGIX-Core-Extensions-ObjectExtensions-#cctor'></a>
### #cctor() `method`

##### Summary

Initializes static data or performs actions that need to be performed once only
for the [ObjectExtensions](#T-xyLOGIX-Core-Extensions-ObjectExtensions 'xyLOGIX.Core.Extensions.ObjectExtensions') class.

##### Parameters

This method has no parameters.

##### Remarks

This constructor is called automatically prior to the first instance being
created or before any static members are referenced.



We've decorated this constructor with the `[Log(AttributeExclude = true)]`
attribute in order to simplify the logging output.

<a name='M-xyLOGIX-Core-Extensions-ObjectExtensions-ToLogRepresentation-System-Object-'></a>
### ToLogRepresentation(value) `method`

##### Summary

Converts a reference to [Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') to a string
representation suitable for logging.

##### Returns

If successful, a [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') containing the textual
representation of the object; otherwise a [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String')
containing the text `<error>`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | (Required.) Reference to an instance of
[Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') that represents the object that is to be
converted to a log-friendly string representation. |

##### Remarks

If a `null` reference is passed as the argument of the
`value` parameter, then the method returns the string
`<null>`.



This method uses PostSharp's formatting system to generate the string
representation.



If PostSharp's formatter is not available, this method attempts to call
[ToString](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object.ToString 'System.Object.ToString') on the specified
`value`; failing that, the method returns
`<error>`.

<a name='T-xyLOGIX-Core-Extensions-PathnameExtensions'></a>
## PathnameExtensions `type`

##### Namespace

xyLOGIX.Core.Extensions

##### Summary

Exposes static methods to extend the [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') class in
order to help a caller in using [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') variables known
or suspected to contain the fully-qualified pathname of a folder or a file.

<a name='M-xyLOGIX-Core-Extensions-PathnameExtensions-FileExists-System-String-'></a>
### FileExists(pathname) `method`

##### Summary

Determines whether the file having the specified
`pathname` exists on the filesystem or not.

##### Returns

`true` if the specified `pathname`
is not blank, and if it contains the fully-qualified pathname of a file that
currently exists on the filesystem, or `false` otherwise.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| pathname | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) A [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') containing
the fully-qualified pathname of the file to check for existence. |

##### Remarks

This method is superior to calling the
[Exists](#M-Alphaleonis-Win32-Filesystem-File-Exists 'Alphaleonis.Win32.Filesystem.File.Exists') method.  This is due
to the fact that the other method throws an exception if it is passed a blank
string, whereas this method simply returns `false`.

<a name='M-xyLOGIX-Core-Extensions-PathnameExtensions-HasAnyOfTheseExtensions-System-String,System-String[]-'></a>
### HasAnyOfTheseExtensions(pathname,extensions) `method`

##### Summary

Extension method that can be used with all
[String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') variables to determine whether a particular
file's `pathname` has a given filename
`extensions`.

##### Returns

`true` if the specified `pathname`
has the specified filename `extensions`;
`false` otherwise.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| pathname | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) A [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') containing
the fully-qualified pathname whose filename extension is to be tested. |
| extensions | [System.String[]](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String[] 'System.String[]') | (Required.) One or more [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') value(s) indicating the
possible extension(s) that the provided `pathname` must have. |

##### Remarks

If the `pathname` or `extensions`
have `null` or blank [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') value(s) as
their arguments, then this method returns `false`.



`false` is also returned if the argument of the
`pathname` parameter refers to a file that does not exist on
the filesystem.



This method is meant to be used as an extension method of type
[String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String').

<a name='M-xyLOGIX-Core-Extensions-PathnameExtensions-HasExtension-System-String,System-String-'></a>
### HasExtension(pathname,extension) `method`

##### Summary

Extension method that can be used with all
[String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') variables to determine whether a particular
file's `pathname` has a given filename
`extension`.

##### Returns

`true` if the specified `pathname`
has the specified filename `extension`;
`false` otherwise.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| pathname | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) A [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') containing
the fully-qualified pathname whose filename extension is to be tested. |
| extension | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) A [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String')
containing the filename extension that the specified
`pathname` should have. |

##### Remarks

If the `pathname` or `extension`
have `null` or blank [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') value(s) as
their arguments, then this method returns `false`.



`false` is also returned if the argument of the
`pathname` parameter refers to a file that does not exist on
the filesystem.



This method is meant to be used as an extension method of type
[String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String').

<a name='T-xyLOGIX-Core-Extensions-ReplaceAnyOfOption'></a>
## ReplaceAnyOfOption `type`

##### Namespace

xyLOGIX.Core.Extensions

##### Summary

Value(s) that allow the caller of the
[ReplaceAnyOf](#M-xyLOGIX-Core-Extensions-StringExtensions-ReplaceAnyOf 'xyLOGIX.Core.Extensions.StringExtensions.ReplaceAnyOf') method
to specify options for how the replacement should be performed.

<a name='F-xyLOGIX-Core-Extensions-ReplaceAnyOfOption-All'></a>
### All `constants`

##### Summary

All occurrences of the target string(s) should be replaced.

<a name='F-xyLOGIX-Core-Extensions-ReplaceAnyOfOption-First'></a>
### First `constants`

##### Summary

Only the first occurrence of the target string(s) should be replaced.

<a name='F-xyLOGIX-Core-Extensions-ReplaceAnyOfOption-Unknown'></a>
### Unknown `constants`

##### Summary

Represents an unknown or undefined state.

##### Remarks

This value is typically used as a default or sentinel value to indicate that
the
state is not recognized or has not been explicitly set.

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

<a name='P-xyLOGIX-Core-Extensions-Properties-Resources-Error_ValueCannotBeNullOrWhiteSpace'></a>
### Error_ValueCannotBeNullOrWhiteSpace `property`

##### Summary

Looks up a localized string similar to Value cannot be null or the blank string..

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

<a name='P-xyLOGIX-Core-Extensions-Properties-Resources-StringExtensions_Left_CountMustBeLessThanOrEqualToLengthOfString'></a>
### StringExtensions_Left_CountMustBeLessThanOrEqualToLengthOfString `property`

##### Summary

Looks up a localized string similar to The argument of the 'count' parameter of the 'Left' method must not be greater than the length of the string passed in the 'value' parameter, which is {0} character(s)..

<a name='P-xyLOGIX-Core-Extensions-Properties-Resources-StringExtensions_Left_CountMustBeNaturalNumber'></a>
### StringExtensions_Left_CountMustBeNaturalNumber `property`

##### Summary

Looks up a localized string similar to The argument of the 'count' parameter of the 'Left' method must be greater than zero..

<a name='T-xyLOGIX-Core-Extensions-SetExtensions'></a>
## SetExtensions `type`

##### Namespace

xyLOGIX.Core.Extensions

##### Summary

Exposes static extension methods for instances of object(s) that implement the
[ISet\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.ISet`1 'System.Collections.Generic.ISet`1') interface.

<a name='M-xyLOGIX-Core-Extensions-SetExtensions-#cctor'></a>
### #cctor() `method`

##### Summary

Initializes static data or performs actions that need to be performed once only
for the [SetExtensions](#T-xyLOGIX-Core-Extensions-SetExtensions 'xyLOGIX.Core.Extensions.SetExtensions') class.

##### Parameters

This method has no parameters.

##### Remarks

This constructor is called automatically prior to the first instance being
created or before any static members are referenced.



We've decorated this constructor with the `[Log(AttributeExclude = true)]`
attribute in order to simplify the logging output.

<a name='M-xyLOGIX-Core-Extensions-SetExtensions-AddRange``1-System-Collections-Generic-ISet{``0},System-Collections-Generic-IEnumerable{``0}-'></a>
### AddRange\`\`1(target,source) `method`

##### Summary

Adds a range of data value(s) from the specified `source`
collection to the `target` set.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| target | [System.Collections.Generic.ISet{\`\`0}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.ISet 'System.Collections.Generic.ISet{``0}') | (Required.) Reference to a collection of element(s), each of which is of type,
`T`, that implements the
[ISet\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.ISet`1 'System.Collections.Generic.ISet`1') interface that is to receive
the element(s) of `source`. |
| source | [System.Collections.Generic.IEnumerable{\`\`0}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable 'System.Collections.Generic.IEnumerable{``0}') | (Required.) Reference to a collection of element(s), each
of which is of type, `T`, that is enumerated and added to
the `target`. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | (Required.) Data type of the individual element(s) of the
`target` and `source`. |

##### Remarks

If the `source` collection is passed a
`null` reference, or has zero element(s), then this method
does nothing.



This method also does nothing if a `null` reference is passed
for the `target` collection.
If an element from the `source` collection is
already a member of the `target` collection, then it is
skipped.



`null` references are also skipped.

<a name='T-xyLOGIX-Core-Extensions-StringArrayExtensions'></a>
## StringArrayExtensions `type`

##### Namespace

xyLOGIX.Core.Extensions

##### Summary

Provides extension methods for [String[]](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String[] 'System.String[]') arrays.

<a name='M-xyLOGIX-Core-Extensions-StringArrayExtensions-#cctor'></a>
### #cctor() `method`

##### Summary

Initializes static data or performs actions that need to be performed once only
for the [StringArrayExtensions](#T-xyLOGIX-Core-Extensions-StringArrayExtensions 'xyLOGIX.Core.Extensions.StringArrayExtensions') class.

##### Parameters

This method has no parameters.

##### Remarks

This constructor is called automatically prior to the first instance being
created or before any static members are referenced.



We've decorated this constructor with the `[Log(AttributeExclude = true)]`
attribute in order to simplify the logging output.

<a name='M-xyLOGIX-Core-Extensions-StringArrayExtensions-DumpToLog-System-String[]-'></a>
### DumpToLog(values) `method`

##### Summary

Dumps the contents of the specified [String[]](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String[] 'System.String[]')
array to the application log.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| values | [System.String[]](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String[] 'System.String[]') | (Required.) Reference to the [String[]](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String[] 'System.String[]') whose
contents are to be logged. |

<a name='T-xyLOGIX-Core-Extensions-StringExtensions'></a>
## StringExtensions `type`

##### Namespace

xyLOGIX.Core.Extensions

##### Summary

Provides methods and properties to assist with manipulating strings
of text.

<a name='F-xyLOGIX-Core-Extensions-StringExtensions-AcronymList'></a>
### AcronymList `constants`

##### Summary

Collection of strings that are commonly-used acronyms.

<a name='F-xyLOGIX-Core-Extensions-StringExtensions-AcronymPattern'></a>
### AcronymPattern `constants`

##### Summary

A regular expression pattern that matches an entire string consisting only of
uppercase letters.
This pattern is useful for identifying acronyms (e.g., "NASA", "AI", "RADAR")
that appear as
standalone words without any lowercase letters.

This pattern ensures that the input string contains only uppercase letters from
A to Z
and does not include numbers, spaces, or lowercase characters.

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

<a name='F-xyLOGIX-Core-Extensions-StringExtensions-ErrorPrefix'></a>
### ErrorPrefix `constants`

##### Summary

A [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') that is set to the error prefix used by all
debugging messages.

<a name='F-xyLOGIX-Core-Extensions-StringExtensions-GuidRegexLowercaseNoBraces'></a>
### GuidRegexLowercaseNoBraces `constants`

##### Summary

A [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') containing a regular expression to match a
GUID that is in all lowercase with no surrounding braces; e.g., for example,
`b8f967ce-911d-4184-a0ba-b37e443b4541`.

<a name='F-xyLOGIX-Core-Extensions-StringExtensions-NamesOfStreetsThatShouldBeCapitalized'></a>
### NamesOfStreetsThatShouldBeCapitalized `constants`

##### Summary

Collection of strings that contain words commonly found in the name
of a street, and that need to be capitalized.

<a name='F-xyLOGIX-Core-Extensions-StringExtensions-ShortWordsThatAreNotAcronyms'></a>
### ShortWordsThatAreNotAcronyms `constants`

##### Summary

Collection of strings which are short words but are not acronyms per
se.

<a name='F-xyLOGIX-Core-Extensions-StringExtensions-StateAbbrList'></a>
### StateAbbrList `constants`

##### Summary

Collection of strings that are the two-letter abbreviations of the 50
U.S. states.

<a name='F-xyLOGIX-Core-Extensions-StringExtensions-_textInfoFromCurrentCulture'></a>
### _textInfoFromCurrentCulture `constants`

##### Summary

Reference to an instance of [TextInfo](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Globalization.TextInfo 'System.Globalization.TextInfo') that
works for the [CurrentCulture](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Globalization.CultureInfo.CurrentCulture 'System.Globalization.CultureInfo.CurrentCulture').

<a name='P-xyLOGIX-Core-Extensions-StringExtensions-EndsWithColonAndNumberRegex'></a>
### EndsWithColonAndNumberRegex `property`

##### Summary

Gets a reference to an instance of
[Regex](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Text.RegularExpressions.Regex 'System.Text.RegularExpressions.Regex') that is compiled to match
a [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') that ends with a colon (`:`) and then a
natural number.

<a name='P-xyLOGIX-Core-Extensions-StringExtensions-IsEmailAddressInvalid'></a>
### IsEmailAddressInvalid `property`

##### Summary

Gets or sets a value that indicates whether the string most recently
checked for whether it contains a valid email address, does in fact contain
such a valid address.

<a name='P-xyLOGIX-Core-Extensions-StringExtensions-LanguageArticleTypeValidator'></a>
### LanguageArticleTypeValidator `property`

##### Summary

Gets a reference to the one and only instance of the object that implements the
[ILanguageArticleTypeValidator](#T-xyLOGIX-Core-Extensions-ILanguageArticleTypeValidator 'xyLOGIX.Core.Extensions.ILanguageArticleTypeValidator')
interface.

<a name='P-xyLOGIX-Core-Extensions-StringExtensions-PluralizationService'></a>
### PluralizationService `property`

##### Summary

Gets a reference to an instance of
[PluralizationService](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Data.Entity.Design.PluralizationServices.PluralizationService 'System.Data.Entity.Design.PluralizationServices.PluralizationService')
for the current culture.

<a name='P-xyLOGIX-Core-Extensions-StringExtensions-WhiteSpaceRegex'></a>
### WhiteSpaceRegex `property`

##### Summary

Gets a [Regex](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Text.RegularExpressions.Regex 'System.Text.RegularExpressions.Regex') that
matches all whitespace characters.

<a name='M-xyLOGIX-Core-Extensions-StringExtensions-#cctor'></a>
### #cctor() `method`

##### Summary

Initializes static data or performs actions that need to be performed once only
for the [StringExtensions](#T-xyLOGIX-Core-Extensions-StringExtensions 'xyLOGIX.Core.Extensions.StringExtensions') class.

##### Parameters

This method has no parameters.

##### Remarks

This constructor is called automatically prior to the first instance being
created or before any static members are referenced.



We've decorated this constructor with the `[Log(AttributeExclude = true)]`
attribute in order to simplify the logging output.

<a name='M-xyLOGIX-Core-Extensions-StringExtensions-AnyContainNoCase-System-Collections-Generic-IEnumerable{System-String},System-String-'></a>
### AnyContainNoCase(collection,value) `method`

##### Summary

Asks if the search text, in `value`, is a substring
of the strings in `collection`, ignoring case.

##### Returns

`true` if the indicated value is in the specified
collection, regardless of case; `false` otherwise.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| collection | [System.Collections.Generic.IEnumerable{System.String}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable 'System.Collections.Generic.IEnumerable{System.String}') | Collection to search. |
| value | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Value to compare. |

<a name='M-xyLOGIX-Core-Extensions-StringExtensions-AnyStartWithAny-System-Collections-Generic-IEnumerable{System-String},System-String[]-'></a>
### AnyStartWithAny(targets,values) `method`

##### Summary

Determines if any of the [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String')s in
`targets` start with any of the specified
`values`.

##### Returns

`true`if any of the `targets` start
with any of the `values`; `false` otherwise.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| targets | [System.Collections.Generic.IEnumerable{System.String}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable 'System.Collections.Generic.IEnumerable{System.String}') | (Required.) Collection of [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String')
value(s) that are to be searched. |
| values | [System.String[]](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String[] 'System.String[]') | (Required.) One or more [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String')
value(s) that are to be used as search criteria. |

##### Remarks

If a `null` reference is passed as the argument of
the `targets` parameter, of if either of the
`targets` or `values` parameter(s) refer to
the empty collection, then this method returns `false`.

<a name='M-xyLOGIX-Core-Extensions-StringExtensions-AreAnyLettersLowercase-System-String-'></a>
### AreAnyLettersLowercase(value) `method`

##### Summary

Determines if the specified `value` contains any letters that
are recognized as lowercase.

##### Returns

`true` if the specified `value` has
at least one lowercase letter; `false` otherwise.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) A [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') whose
characters are to be checked. |

<a name='M-xyLOGIX-Core-Extensions-StringExtensions-AsCodeElement-System-String-'></a>
### AsCodeElement(text) `method`

##### Summary

Surrounds the specified `text` with XML documentation
tags <c> and </c>, to indicate inline code formatting.

##### Returns

A [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') containing the input surrounded by
<c> and </c> tags. If `text` is
`null`
or whitespace, the original value is returned.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| text | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) The text to format as inline code. |

<a name='M-xyLOGIX-Core-Extensions-StringExtensions-AsDecimal-System-String-'></a>
### AsDecimal(value) `method`

##### Summary

Attempts to express the provided [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String')`value` as a [Decimal](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Decimal 'System.Decimal') value.

##### Returns

A [Decimal](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Decimal 'System.Decimal') value that corresponds to what is
represented by the ASCII `value` specified; or
[MinValue](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Decimal.MinValue 'System.Decimal.MinValue') if an issue occurred in formatting the
value.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) A [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') containing
the ASCII representation of a [Decimal](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Decimal 'System.Decimal') value. |

<a name='M-xyLOGIX-Core-Extensions-StringExtensions-AsDouble-System-String-'></a>
### AsDouble(value) `method`

##### Summary

Attempts to express the provided [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String')`value` as a [Double](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Double 'System.Double') value.

##### Returns

A [Double](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Double 'System.Double') value that corresponds to what is
represented by the ASCII `value` specified; or
[MinValue](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Double.MinValue 'System.Double.MinValue') if an issue occurred in formatting the
value.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) A [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') containing
the ASCII representation of a [Double](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Double 'System.Double') value. |

<a name='M-xyLOGIX-Core-Extensions-StringExtensions-AsProseList``1-System-Collections-Generic-IEnumerable{``0},System-Func{``0,System-String}-'></a>
### AsProseList\`\`1(quote,selectorFunc) `method`

##### Summary

Takes a quote and a selector function and exports a string that is
comma-separated according to proper English grammar, i.e.
` "dog, cat, and horse" ` not just `"dog, cat, horse."`

##### Returns

String containing the strings selected by the selector, as
illustrated above.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| quote | [System.Collections.Generic.IEnumerable{\`\`0}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable 'System.Collections.Generic.IEnumerable{``0}') | Collection of `TSource` to iterate
over. |
| selectorFunc | [System.Func{\`\`0,System.String}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Func 'System.Func{``0,System.String}') | Delegate specifying the way to represent each
element of the collection `quote` as a string. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TSource | Type of each item in the quote collection. |

##### Remarks

If this method is fed a `null` reference or the
empty collection for `quote`, then the return value is the
empty string.

<a name='M-xyLOGIX-Core-Extensions-StringExtensions-BreakTextIntoLines-System-String-'></a>
### BreakTextIntoLines(text) `method`

##### Summary

Breaks a large body of `text` into individual
lines, on the newline character for the particular operating system. The result
is a collection of strings, one for each line.

##### Returns

Collection of strings containing one string per line of
`text`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| text | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) String containing the text to be split. |

##### Remarks

If this method is passed the empty string or a blank string as input,
then it returns the empty collection.

<a name='M-xyLOGIX-Core-Extensions-StringExtensions-CleanLine-System-String-'></a>
### CleanLine(line) `method`

##### Summary

Strips newlines from the text in `line`, and then
calls [Trim](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String.Trim 'System.String.Trim()') on the results.

##### Returns

Same as input, except all newline characters and whitespace has been
removed.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| line | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Text to clean. |

##### Remarks

If the empty string is provided as input, then the empty string is
returned.

<a name='M-xyLOGIX-Core-Extensions-StringExtensions-CollapseNewlinesToSpaces-System-String-'></a>
### CollapseNewlinesToSpaces(value) `method`

##### Summary

"Collapses" or "folds" the specified `value` so that all
newlines are transformed to single whitespace characters.

##### Returns

A [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') containing the value passed, but with
all newlines transformed to single whitespace characters.



Multiple newlines are removed.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) A [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') containing the
value that is to be collapsed. |

<a name='M-xyLOGIX-Core-Extensions-StringExtensions-Concat-System-String,System-String[]-'></a>
### Concat(initialString,parts) `method`

##### Summary

Takes the specified `initialString` and joins the provided
[String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String')`parts` array of strings onto
it, in the order specified.

##### Returns

A [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') consisting of the
`initialString` with the `parts`
concatenated to it.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| initialString | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) A [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') that
specifies the initial value to have other [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String')
value(s)
concatenated to it. |
| parts | [System.String[]](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String[] 'System.String[]') | (Required.) One or more [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String')
values that are to be concatenated, in the order specified, to the
`initialString`. |

##### Remarks

This method does nothing if the `initialString` is
blank or `null`, or if there are zero values in the
`parts`.

<a name='M-xyLOGIX-Core-Extensions-StringExtensions-Contains-System-String,System-String,System-StringComparison-'></a>
### Contains(source,value,comparisonType) `method`

##### Summary

Returns `true` if `source`
contains `value`, using the chosen comparison
rule.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| source | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) A [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') containing the text
that is to be searched for `value`. |
| value | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) A [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') containing the text
that is to be searched for. |
| comparisonType | [System.StringComparison](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.StringComparison 'System.StringComparison') | (Required.) One of the [StringComparison](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.StringComparison 'System.StringComparison')
values that dictates how the comparison is performed. |

<a name='M-xyLOGIX-Core-Extensions-StringExtensions-ContainsAny-System-String,System-String[]-'></a>
### ContainsAny(value,searchStrings) `method`

##### Summary

Returns `true` if the `value` has
any of the strings in `searchStrings` as a substring.

##### Returns

Value indicating whether any of the strings in
`searchStrings` are substrings (case-insensitive) of
`value`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) The value to be used as a filter. |
| searchStrings | [System.String[]](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String[] 'System.String[]') | (Required.) Collection of strings, any of which
might be substrings of `value`. |

##### Remarks

If `value` is the empty string or if the
`searchStrings` collection is empty or is a
`null` reference, then this method returns
`false`.

<a name='M-xyLOGIX-Core-Extensions-StringExtensions-ContainsAny-System-String,System-Collections-Generic-IEnumerable{System-String}-'></a>
### ContainsAny(value,searchStrings) `method`

##### Summary

Returns `true` if the `value` has
any of the strings in `searchStrings` as a substring.

##### Returns

Value indicating whether any of the strings in
`searchStrings` are substrings (case-insensitive) of
`value`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) The value to be used as a filter. |
| searchStrings | [System.Collections.Generic.IEnumerable{System.String}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable 'System.Collections.Generic.IEnumerable{System.String}') | (Required.) Collection of strings, any of which
might be substrings of `value`. |

##### Remarks

If `value` is the empty string or if the
`searchStrings` collection is empty or is a
`null` reference, then this method returns
`false`.

<a name='M-xyLOGIX-Core-Extensions-StringExtensions-ContainsAny-System-String,System-Char[]-'></a>
### ContainsAny(value,searchChars) `method`

##### Summary

Returns `true` if the `value`
contains any of the characters in `searchChars`
(case-insensitive).

##### Returns

`true` if the string in `value`
contains any of the characters (case-insensitive) in the
`searchChars` array; `false` otherwise.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) String to be searched. |
| searchChars | [System.Char[]](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Char[] 'System.Char[]') | (Required.) Array of characters to look for in the
`value`. |

##### Remarks

If this method is passed the empty string for
`value` or a `null` reference or an empty
collection for `searchChars`, then this method returns
`false`.

<a name='M-xyLOGIX-Core-Extensions-StringExtensions-ContainsAnyOf-System-String,System-Collections-Generic-IEnumerable{System-String}-'></a>
### ContainsAnyOf(value,searchStrings) `method`

##### Summary

Returns `true` if the `value` has
any of the strings in `searchStrings` as a substring.

##### Returns

Value indicating whether any of the strings in
`searchStrings` are substrings (case-insensitive) of
`value`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) The value to be used as a filter. |
| searchStrings | [System.Collections.Generic.IEnumerable{System.String}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable 'System.Collections.Generic.IEnumerable{System.String}') | (Required.) Collection of strings, any of which
might be substrings of `value`. |

##### Remarks

If `value` is the empty string or if the
`searchStrings` collection is empty or is a
`null` reference, then this method returns
`false`.

<a name='M-xyLOGIX-Core-Extensions-StringExtensions-ContainsAnyOf-System-String,System-String[]-'></a>
### ContainsAnyOf(value,searchStrings) `method`

##### Summary

Returns `true` if the `value` has
any of the strings in `searchStrings` as a substring.

##### Returns

Value indicating whether any of the strings in
`searchStrings` are substrings (case-insensitive) of
`value`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) The value to be used as a filter. |
| searchStrings | [System.String[]](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String[] 'System.String[]') | (Required.) Collection of strings, any of which
might be substrings of `value`. |

##### Remarks

If `value` is the empty string or if the
`searchStrings` collection is empty or is a
`null` reference, then this method returns
`false`.

<a name='M-xyLOGIX-Core-Extensions-StringExtensions-ContainsAnyOf-System-String,System-Char[]-'></a>
### ContainsAnyOf(value,searchChars) `method`

##### Summary

Returns `true` if the `value`
contains any of the characters in `searchChars`
(case-insensitive).

##### Returns

`true` if the string in `value`
contains any of the characters (case-insensitive) in the
`searchChars` array; `false` otherwise.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) String to be searched. |
| searchChars | [System.Char[]](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Char[] 'System.Char[]') | (Required.) Array of characters to look for in the
`value`. |

##### Remarks

If this method is passed the empty string for
`value` or a `null` reference or an empty
collection for `searchChars`, then this method returns
`false`.

<a name='M-xyLOGIX-Core-Extensions-StringExtensions-ContainsNamespaceSeparator-System-String-'></a>
### ContainsNamespaceSeparator(value) `method`

##### Summary

Determines whether the specified `value` contains a namespace
separator character, which in C# and VB is a period (`.`).

##### Returns

`true` if the specified `value`
contains a namespace separator character, which in C# or VB is a period (
`.`); `false` otherwise.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) A [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') containing the value that is to be
checked. |

##### Remarks

If a `null`, blank, or
[Empty](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String.Empty 'System.String.Empty') value is passed for the argument of the
`value` parameter, then the method returns
`false`.

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

<a name='M-xyLOGIX-Core-Extensions-StringExtensions-ContainsNumbers-System-String-'></a>
### ContainsNumbers(value) `method`

##### Summary

Ascertains whether the specified [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String'),
provided as the argument to the `value` parameter, contains
any digits.

##### Returns

`true`q if the [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') passed
contains any digits.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) A [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') that is to be
checked. |

<a name='M-xyLOGIX-Core-Extensions-StringExtensions-ContainsWhitespace-System-String-'></a>
### ContainsWhitespace(value) `method`

##### Summary

Determines whether the specified `value` contains a
whitespace character.

##### Returns

`true` if the specified `value` contains a
whitespace character; otherwise, `false`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) A [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') containing the text that is to be
examined. |

##### Remarks

The text in the argument of the `value` parameter is
expressed as an array of [Char](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Char 'System.Char') element(s).



This method then iterates over said array, element-by-element.



The method stops iteration, and returns `true`, the first time
any whitespace character is encountered.



If the argument of the `value` parameter is
`null`, blank, or the [Empty](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String.Empty 'System.String.Empty')
value, then this method returns `true`.

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
| value | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) String containing the word that needs to be
initial-capitalized. |

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
| match | [System.Text.RegularExpressions.Match](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Text.RegularExpressions.Match 'System.Text.RegularExpressions.Match') | Reference to an instance of
[Match](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Text.RegularExpressions.Match 'System.Text.RegularExpressions.Match') that resulted from a
regex search. |

##### Remarks

This method also sets the value of the
[IsEmailAddressInvalid](#P-xyLOGIX-Core-Extensions-StringExtensions-IsEmailAddressInvalid 'xyLOGIX.Core.Extensions.StringExtensions.IsEmailAddressInvalid')
property to `true` in the event that an error occurs.

<a name='M-xyLOGIX-Core-Extensions-StringExtensions-EndsWithAny-System-String,System-String[]-'></a>
### EndsWithAny(value,endings) `method`

##### Summary

Determines if the specified [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String')`value` ends with any of the specified
`endings`.

##### Returns

`true` if the specified `value`
ends with any of the specified `endings`;
`false` otherwise.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) A [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') containing the value to be
checked. |
| endings | [System.String[]](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String[] 'System.String[]') | (Required.) One or more [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String')
elements, each of which is to be assessed against the specified
`value` as being what it ends with. |

##### Remarks

This method returns `false` if no values are
passed for
`endings`.

<a name='M-xyLOGIX-Core-Extensions-StringExtensions-EndsWithAny-System-String,System-StringComparison,System-String[]-'></a>
### EndsWithAny(value,comparisonType,endings) `method`

##### Summary

Determines if the specified [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String')`value` ends with any of the specified
`endings`.

##### Returns

`true` if the specified `value`
ends with any of the specified `endings`;
`false` otherwise.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) A [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') containing the value to be
checked. |
| comparisonType | [System.StringComparison](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.StringComparison 'System.StringComparison') | (Required.) One of the [StringComparison](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.StringComparison 'System.StringComparison') value(s) that
specifies how the comparison is to be performed. |
| endings | [System.String[]](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String[] 'System.String[]') | (Required.) One or more [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String')
elements, each of which is to be assessed against the specified
`value` as being what it ends with. |

##### Remarks

This method returns `false` if no values are
passed for
`endings`.

<a name='M-xyLOGIX-Core-Extensions-StringExtensions-EndsWithAny-System-String,System-Collections-Generic-IEnumerable{System-String}-'></a>
### EndsWithAny(value,endings) `method`

##### Summary

Determines if the specified [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String')`value` ends with any of the specified
`endings`.

##### Returns

`true` if the specified `value`
ends with any of the specified `endings`;
`false` otherwise.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) A [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') containing the value to be
checked. |
| endings | [System.Collections.Generic.IEnumerable{System.String}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable 'System.Collections.Generic.IEnumerable{System.String}') | (Required.) One or more [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String')
elements, each of which is to be assessed against the specified
`value` as being what it ends with. |

##### Remarks

This method returns `false` if no values are
passed for
`endings`.

<a name='M-xyLOGIX-Core-Extensions-StringExtensions-EndsWithAny-System-String,System-StringComparison,System-Collections-Generic-IEnumerable{System-String}-'></a>
### EndsWithAny(value,comparisonType,endings) `method`

##### Summary

Determines if the specified [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String')`value` ends with any of the specified
`endings`.

##### Returns

`true` if the specified `value`
ends with any of the specified `endings`;
`false` otherwise.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) A [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') containing the value to be
checked. |
| comparisonType | [System.StringComparison](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.StringComparison 'System.StringComparison') | (Required.) One of the [StringComparison](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.StringComparison 'System.StringComparison') value(s) that
specifies how the comparison is to be performed. |
| endings | [System.Collections.Generic.IEnumerable{System.String}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable 'System.Collections.Generic.IEnumerable{System.String}') | (Required.) One or more [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String')
elements, each of which is to be assessed against the specified
`value` as being what it ends with. |

##### Remarks

This method returns `false` if no values are
passed for
`endings`.

<a name='M-xyLOGIX-Core-Extensions-StringExtensions-EndsWithAnyOf-System-String,System-String[]-'></a>
### EndsWithAnyOf(value,endings) `method`

##### Summary

Determines if the specified [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String')`value` ends with any of the specified
`endings`.

##### Returns

`true` if the specified `value`
ends with any of the specified `endings`;
`false` otherwise.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) A [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') containing the value to be
checked. |
| endings | [System.String[]](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String[] 'System.String[]') | (Required.) One or more [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String')
elements, each of which is to be assessed against the specified
`value` as being what it ends with. |

##### Remarks

This method returns `false` if no values are
passed for
`endings`.

<a name='M-xyLOGIX-Core-Extensions-StringExtensions-EndsWithAnyOf-System-String,System-StringComparison,System-String[]-'></a>
### EndsWithAnyOf(value,comparisonType,endings) `method`

##### Summary

Determines if the specified [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String')`value` ends with any of the specified
`endings`.

##### Returns

`true` if the specified `value`
ends with any of the specified `endings`;
`false` otherwise.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) A [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') containing the value to be
checked. |
| comparisonType | [System.StringComparison](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.StringComparison 'System.StringComparison') | (Required.) One of the [StringComparison](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.StringComparison 'System.StringComparison') value(s) that
specifies how the comparison is to be performed. |
| endings | [System.String[]](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String[] 'System.String[]') | (Required.) One or more [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String')
elements, each of which is to be assessed against the specified
`value` as being what it ends with. |

##### Remarks

This method returns `false` if no values are
passed for
`endings`.

<a name='M-xyLOGIX-Core-Extensions-StringExtensions-EndsWithColonAndNumber-System-String-'></a>
### EndsWithColonAndNumber(value) `method`

##### Summary

Determines whether the specified `value` ends with a colon
and a number.

##### Returns

`true`if the specified `value` ends
with a colon and a number; `false` otherwise.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) A [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') that is set to
the value that is to be examined. |

<a name='M-xyLOGIX-Core-Extensions-StringExtensions-EnsureAtIsInFront-System-String-'></a>
### EnsureAtIsInFront(twitterSite) `method`

##### Summary

Double-checks a `twitterSite` (at-mention) string
to make sure it begins with the character '@'.

##### Returns

String containing the same value as in
`twitterSite` , but one which is guaranteed to start with the
'@' character.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| twitterSite | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) Twitter handle to at-mention. |

##### Remarks

If this method is passed the empty string, then the result is the
empty string.

<a name='M-xyLOGIX-Core-Extensions-StringExtensions-EqualsAnyOf-System-String,System-String[]-'></a>
### EqualsAnyOf(value,list) `method`

##### Summary

Determines whether the specified `value` is equal to,
respecting case, any of the item(s) in the specified `list`.

##### Returns

`true` if one of the element(s) of the specified
`list` matches the value, accounting for character casing;
otherwise, `false`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) A [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') containing the
value that is to be examined. |
| list | [System.String[]](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String[] 'System.String[]') | (Required.) One or more [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String')
value(s) that are to be checked for equality without regard to case. |

##### Remarks

If nothing is passed for the `list` parameter, then
the method returns `false`.



If the value is the `null`, blank, or
[Empty](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String.Empty 'System.String.Empty') value, and one of the element(s) of the
`list` is also, then this method returns
`true`.

<a name='M-xyLOGIX-Core-Extensions-StringExtensions-EqualsAnyOfNoCase-System-String,System-String[]-'></a>
### EqualsAnyOfNoCase(value,list) `method`

##### Summary

Determines whether the specified `value` is equal to,
regardless of case, any of the item(s) in the specified
`list`.

##### Returns

`true` if one of the element(s) of the specified
`list` matches the value, regardless of case; otherwise,
`false`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) A [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') containing the
value that is to be examined. |
| list | [System.String[]](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String[] 'System.String[]') | (Required.) One or more [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String')
value(s) that are to be checked for equality without regard to case. |

##### Remarks

If nothing is passed for the `list` parameter, then
the method returns `false`.



If the value is the `null`, blank, or
[Empty](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String.Empty 'System.String.Empty') value, and one of the element(s) of the
`list` is also, then this method returns
`true`.

<a name='M-xyLOGIX-Core-Extensions-StringExtensions-EqualsNoCase-System-String,System-String-'></a>
### EqualsNoCase(str1,str2) `method`

##### Summary

A case-insensitive equality comparer for strings. Basically, converts
each of its operands to lowercase before comparing.

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

A case-insensitive equality comparer for strings. Basically, converts
each of its operands to lowercase before comparing.

##### Returns

Whether the two strings are the same, regardless of case.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| str1 | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | First string to compare. |
| str2 | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Second string to compare. |
| comparisonType | [System.StringComparison](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.StringComparison 'System.StringComparison') | One of the
[StringComparison](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.StringComparison 'System.StringComparison') value(s) saying how the strings are to
be compared. |

<a name='M-xyLOGIX-Core-Extensions-StringExtensions-EscapePowerShellNewline-System-String-'></a>
### EscapePowerShellNewline(value) `method`

##### Summary

Escapes newlines (e.g., `\r\n`) in the provided `value`,
assuming that it is destined to then be written to a PowerShell Script (
`*.ps1`) file.



This method is useful when you need to write a string to a PowerShell script
file, and you want to ensure that the newlines (e.g., `\r\n`), within a
value to be sent somewhere else, are properly escaped.

##### Returns

If successful, a [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') containing the
specified `value`, but altered to properly escape newline(s)
so that they are sent properly to whichever command the PowerShell Script (
`*.ps1`) file is calling; otherwise, the method is idempotent.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) A [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') containing the
original value. |

##### Remarks

If the `null` blank, or
[Empty](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String.Empty 'System.String.Empty') value is passed as the argument of the
`value` parameter, or if there is a problem completing the
replacement, then the method is idempotent.



This method is also idempotent when the text that is to be
replaced is not present.

<a name='M-xyLOGIX-Core-Extensions-StringExtensions-EscapePowerShellQuotes-System-String-'></a>
### EscapePowerShellQuotes(value) `method`

##### Summary

Escapes double-quotation marks in the provided `value`,
assuming that it is destined to then be written to a PowerShell Script (
`*.ps1`) file.



This method is useful when you need to write a string to a PowerShell script
file, and you want to ensure that the double-quotation marks (`"`) are
properly escaped.

##### Returns

If successful, a [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') containing the
specified `value`, but altered to properly escape
double-quotation mark(s) so that they are sent properly to whichever command
the PowerShell Script (`*.ps1`) file is calling; otherwise, the method is
idempotent.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) A [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') containing the
original value. |

##### Remarks

If the `null` blank, or
[Empty](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String.Empty 'System.String.Empty') value is passed as the argument of the
`value` parameter, or if there is a problem completing the
replacement, then the method is idempotent.



This method is also idempotent when the text that is to be
replaced is not present.

<a name='M-xyLOGIX-Core-Extensions-StringExtensions-ExcludingWhitespace-System-String-'></a>
### ExcludingWhitespace(value) `method`

##### Summary

Excludes whitespace characters from the specified
`value`.

##### Returns

A [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') that matches
`value`, but with all whitespace characters removed.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) A [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') from which to
exclude all whitespace characters. |

##### Remarks

This method is useful for conducting whitespace-insensitive testing
of strings.

<a name='M-xyLOGIX-Core-Extensions-StringExtensions-ExtractUpToColon-System-String-'></a>
### ExtractUpToColon(value) `method`

##### Summary

Extracts all characters of the specified `value` up to but
not including the first occurrence of a colon (`:`).

##### Returns

A [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') containing all characters of the
specified `value` up to but not including the first colon (
`:`), if present.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) A [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') that is set to the value to be
processed. |

##### Remarks

If the specified `value` is `null`,
blank, the [Empty](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String.Empty 'System.String.Empty') value, or does not contain a
colon, then the method is idempotent.

<a name='M-xyLOGIX-Core-Extensions-StringExtensions-FirstOrNotEmpty-System-String,System-String-'></a>
### FirstOrNotEmpty(val1,val2) `method`

##### Summary

Returns the specified `val2` if `val1` is
`null` or a blank string; otherwise, `val1`
is returned if both `val1` and `val2` are
non-blank.

##### Returns

Specified `val2` if `val1` is
`null` or a blank string; otherwise, `val1`
is returned if both `val1` and `val2` are
non-blank.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| val1 | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) A [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') that is the
preferred value to be returned. |
| val2 | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) A [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') whose value is
to be returned in the event that the argument of `val1` is
`null`, whitespace, or the
[Empty](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String.Empty 'System.String.Empty') value. |

<a name='M-xyLOGIX-Core-Extensions-StringExtensions-FormatAsHtml-System-String-'></a>
### FormatAsHtml(content) `method`

##### Summary

Formats the specified `content` as HTML by replacing certain
characters
with their corresponding HTML entities.

##### Returns

A [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') containing the formatted HTML text.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| content | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) A [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') containing the text to be
formatted as HTML. |

##### Remarks

This method replaces the following characters in the input string:



In addition, this method also transforms 'smart' quotes, i.e., "curly" quotes,
to 'straight' quotes before performing the reformat of single and double
quotation marks.



If an exception occurs during the formatting process, then this method is
idempotent.

<a name='M-xyLOGIX-Core-Extensions-StringExtensions-FormatLikePython-System-String,System-Object[]-'></a>
### FormatLikePython(value,args) `method`

##### Summary

Provides a method to format a string in a more Pythonic manner, where we simply
call `Format()` following the string to be formatted.

##### Returns

If successful, this method returns the specified
`value`, with the format placeholders updated according to
the specified `args`, if any; otherwise, the method is
idempotent.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) A [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') containing the
value that is to be formatted. |
| args | [System.Object[]](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object[] 'System.Object[]') | (Required.) Zero or more object(s) whose value(s) are to be
substituted in for the format specifier(s) in the specified
`value`. |

<a name='M-xyLOGIX-Core-Extensions-StringExtensions-GetCompactedString-System-String,System-Drawing-Font,System-Int32-'></a>
### GetCompactedString(stringToCompact,font,maxWidth) `method`

##### Summary

Re-expresses strings with ellipsis (...) if they are longer than a
certain length.

##### Returns

Version of the string that has ellipsis (...) so as to fit within the
given length.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| stringToCompact | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The text to be compacted. |
| font | [System.Drawing.Font](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Drawing.Font 'System.Drawing.Font') | Font the text is in. |
| maxWidth | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The maximum length of the string. |

<a name='M-xyLOGIX-Core-Extensions-StringExtensions-GetDottedSuffix-System-String,System-Boolean-'></a>
### GetDottedSuffix(value,includingDot) `method`

##### Summary

Gets the suffix of a so-called string, i.e.,
`My.Dotted.String`, which is presumed to be passed as the argument of the
`value` parameter.



For the example above, `.String` or `String` is the result of
calling
this method, depending on the value of the `includingDot`
parameter.

##### Returns

If successful, a [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') containing the final
part, or , of the dotted string supplied as the argument to the
`value` parameter. The result includes the `.` character
if `includingDot` is set to `true`;
otherwise,
the result does not include the `.` character. If the input is invalid,
the
`value` parameter is idempotently returned.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) A [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') containing the
text to be parsed. |
| includingDot | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | (Optional.) `true` to make the resultant string include the
`.` character at the start of the suffix; `false` to
exclude the `.` character.



The default value of this parameter is `false`. |

<a name='M-xyLOGIX-Core-Extensions-StringExtensions-GetFirstNChars-System-String,System-Int32-'></a>
### GetFirstNChars(value,nChars) `method`

##### Summary

Gets the first `nChars` characters of the string
`value` and returns them; returns the entire string
`value` if the string is smaller than
`nChars` characters in length.

##### Returns

First `nChars` characters of the string in
`value`; or, if `value` is shorter than
`nChars` characters, the entire string that is passed in
`value` is returned. If a problem occurred, the empty string
is returned.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | String to pull the first `nChars`
characters from. |
| nChars | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | (Must be a positive number.) Number of characters from
the start of the string to get. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentOutOfRangeException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentOutOfRangeException 'System.ArgumentOutOfRangeException') | Thrown if
`nChars` has a zero or negative number value.
`nChars` must be a positive number. |

<a name='M-xyLOGIX-Core-Extensions-StringExtensions-GetFirstNonBlankLine-System-String-'></a>
### GetFirstNonBlankLine(value) `method`

##### Summary

Gets the first non-blank line, if any, of a multi-line
`value`, splitting on `CRLF`.

##### Returns

If successful, a [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') value that corresponds
to the first non-blank line of the specified `value`,
splitting on `CRLF`; otherwise, the [Empty](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String.Empty 'System.String.Empty')
value is returned.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) A [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') containing the
value for which the first line is to be obtained. |

<a name='M-xyLOGIX-Core-Extensions-StringExtensions-GetFirstTwoNonBlankLines-System-String-'></a>
### GetFirstTwoNonBlankLines(value) `method`

##### Summary

Gets the first two non-blank line(s), if any, of a multi-line
`value`, splitting on `CRLF`.

##### Returns

If the specified `value` has less than two non-blank
line(s), then this method is idempotent.



If successful, a [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') value that corresponds to the
first two non-blank line(s) of the specified `value`,
splitting on `CRLF`; otherwise, the [Empty](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String.Empty 'System.String.Empty')
value is returned.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) A [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') containing the
value for which the first two non-blank line(s) are to be obtained. |

<a name='M-xyLOGIX-Core-Extensions-StringExtensions-GetLanguageArticleText-xyLOGIX-Core-Extensions-LanguageArticleType,System-String-'></a>
### GetLanguageArticleText(type,text) `method`

##### Summary

Determines whether the specified `text` starts with a vowel
sound, and, if so, applies the specified `type`
setting to determine the appropriate article, if any, to return.

##### Returns

If successful, a [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') containing the appropriate
article, if any, based on the specified `type`
setting and whether the specified `text` starts with a vowel
sound; otherwise, the method returns the [Empty](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String.Empty 'System.String.Empty')
value.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| type | [xyLOGIX.Core.Extensions.LanguageArticleType](#T-xyLOGIX-Core-Extensions-LanguageArticleType 'xyLOGIX.Core.Extensions.LanguageArticleType') | (Required.) One of the
[LanguageArticleType](#T-xyLOGIX-Core-Extensions-LanguageArticleType 'xyLOGIX.Core.Extensions.LanguageArticleType') value(s) that
indicates which article, if any, is to be returned. |
| text | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) A [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') containing the text that is to be
parsed. |

<a name='M-xyLOGIX-Core-Extensions-StringExtensions-GetLastWord-System-String-'></a>
### GetLastWord(input) `method`

##### Summary

Extracts the last initial-capped word from a fully-qualified class name or
string containing a name such as `FooBarBaz` (in which case, it would
return `Baz`).

##### Returns

If successful, a [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') containing the last
initial-capped word in the `input`; otherwise, this method is
idempotent.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| input | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) A [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') containing the
text that is to be parsed. |

<a name='M-xyLOGIX-Core-Extensions-StringExtensions-GetNonBlankLineCount-System-String-'></a>
### GetNonBlankLineCount(value) `method`

##### Summary

Gets the count of the number of non-blank line(s) in the specified
`value`, splitting on `CRLF`, if any.

##### Returns

The count of non-blank line(s) in the specified
`value`, splitting on `CRLF`, or zero if, e.g., the
specified `value` is blank, the
[Empty](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String.Empty 'System.String.Empty') value, or `null`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) A [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') containing the
value for which the non-blank line count is to be determined. |

<a name='M-xyLOGIX-Core-Extensions-StringExtensions-GetPersonFirstName-System-String-'></a>
### GetPersonFirstName(fullName) `method`

##### Summary

Very na?ve determination of person first name 99.9% of the time,
persons' names are // given as <First Name> <Rest>.

##### Returns

String containing the first name of the person. Empty string if this
method is passed the empty string as input.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| fullName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) String value containing the full name of
the person. |

##### Remarks

Therefore, we can assume that, if we break the name field up by
spaces, then everything before the first space is word of the first name. 
This should even catch 'fancy' last name, such as "de la Haye." For instance,
this method would read "Nathan de la Montoya" and return "Nathan," so our way
of determining the last name is pretty safe, given the above assumptions and
input patterns. If the empty string is passed as input to this method, then the
empty string is returned.

<a name='M-xyLOGIX-Core-Extensions-StringExtensions-GetPersonLastName-System-String-'></a>
### GetPersonLastName(fullName) `method`

##### Summary

Very na?ve determination of person last name. In our software
consulting and tutoring practice, new clients tend to given their first and
last name only when signing up --- about 99.9% of the time.

##### Returns

String containing the first name of the person. Empty string if this
method is passed the empty string as input.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| fullName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) String value containing the full name of
the person. |

##### Remarks

Therefore, we can assume that, if we break the name field up by
spaces, then everything after the first space is word of the last name. 
This should even catch 'fancy' last name, such as "de la Haye." For instance,
this method would read "Nathan de la Montoya" and return "de la Montoya," so
our way of determining the last name is pretty safe, given the above
assumptions and input patterns. If the empty string is passed as input, then
the empty string is returned. If a string containing just one word is passed as
input, a [InvalidDataException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IO.InvalidDataException 'System.IO.InvalidDataException') is thrown.

<a name='M-xyLOGIX-Core-Extensions-StringExtensions-IsAbsolutePath-System-String-'></a>
### IsAbsolutePath(path) `method`

##### Summary

Determines whether the specified `path` is a
fully-qualified, absolute path or not.

##### Returns

`true` if the `path` specified is
a fully-qualified, absolute path; `false` otherwise.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| path | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) String containing the path to be checked. |

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

<a name='M-xyLOGIX-Core-Extensions-StringExtensions-IsAlphaNumeric-System-String-'></a>
### IsAlphaNumeric(value) `method`

##### Summary

Determines whether the specified [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String')`value` is alphanumeric.

##### Returns

`true` if every character of the specified
`value` is a letter or a digit, excluding any whitespace
characters; `false` otherwise.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) A [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') that is to  be
examined. |

<a name='M-xyLOGIX-Core-Extensions-StringExtensions-IsAlphaNumericLowercase-System-String-'></a>
### IsAlphaNumericLowercase(value) `method`

##### Summary

Determines whether the specified `value` is an
alphanumeric [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') that consists solely of digits or
lowercase letters (excluding whitespace).

##### Returns

`true` if the specified `value`
consists solely of either digits or lowercase letters (excluding whitespace);
`false` otherwise.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) A [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') containing
the text to be checked. |

##### Remarks

If a blank [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') or a
`null` reference is passed to this method, then this method
returns `false`.



If an error occurs during the check, then this method returns
`false`.

<a name='M-xyLOGIX-Core-Extensions-StringExtensions-IsAlphaNumericUppercase-System-String-'></a>
### IsAlphaNumericUppercase(value) `method`

##### Summary

Determines whether the specified `value` is an
alphanumeric [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') that consists solely of digits or
uppercase letters (excluding whitespace).

##### Returns

`true` if the specified `value`
consists solely of either digits or uppercase letters (excluding whitespace);
`false` otherwise.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) A [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') containing
the text to be checked. |

##### Remarks

If a blank [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') or a
`null` reference is passed to this method, then this method
returns `false`.



If an error occurs during the check, then this method returns
`false`.

<a name='M-xyLOGIX-Core-Extensions-StringExtensions-IsBlankOrNull-System-String-'></a>
### IsBlankOrNull(value) `method`

##### Summary

Gets a value that indicates whether the specified
`value` is blank, only consists of whitespace, or a
`null` reference.

##### Returns

`true` if the specified `value` is
blank, only consists of whitespace, or a `null` reference.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) A [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') value that
should be checked. |

<a name='M-xyLOGIX-Core-Extensions-StringExtensions-IsDecimal-System-String-'></a>
### IsDecimal(value) `method`

##### Summary

Determines whether the `value` passed is a
`decimal` number or not.

##### Returns

`true` if the string passed in
`value` is the string representation of a value that is in
the range of the `decimal` data type; `false` otherwise.
The method also returns `false` if it is passed the empty
string.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) String containing the value or not. |

<a name='M-xyLOGIX-Core-Extensions-StringExtensions-IsFolderPath-System-String-'></a>
### IsFolderPath(path) `method`

##### Summary

Determines whether the specified `path` is the path
to a folder or not.

##### Returns

`true` if the object at the specified pathname is a
folder; `false` otherwise. If the specified pathname is blank,
then this method simply returns `false`. If a file-system
error occurs during the checking, `false` is also returned.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| path | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) String containing the fully-qualified pathname
of the file-system entry to be checked. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentException 'System.ArgumentException') | Thrown if the required parameter,
`path`, is passed a blank or `null` string
for a value. |

##### Remarks

Note the exact words of the Returns statement: "if the object at the
specified pathname is a folder." So if you pass in the phrase, "Hello, world,"
it will be rejected.

<a name='M-xyLOGIX-Core-Extensions-StringExtensions-IsLowercase-System-String-'></a>
### IsLowercase(value) `method`

##### Summary

Determines whether the specified `value` is a
[String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') that consists solely of lowercase letters
(excluding whitespace).

##### Returns

`true` if the specified `value`
consists solely of lowercase letters (excluding whitespace);
`false` otherwise.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) A [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') containing
the text to be checked. |

##### Remarks

If a blank [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') or a
`null` reference is passed to this method, then this method
returns `false`.



If an error occurs during the check, then this method returns
`false`.

<a name='M-xyLOGIX-Core-Extensions-StringExtensions-IsNumeric-System-String-'></a>
### IsNumeric(value) `method`

##### Summary

Determines whether the `value` passed is the string
representation of a 32-bit `int` or not.

##### Returns

`true` if the string passed in
`value` is the string representation of a value that is in
the range of the 32-bit `int` data type; `false`
otherwise. The method also returns `false` if it is passed the
empty string.

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

`true` if the string `value`
matches one or more of the `choices`;
`false` otherwise.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Value to match. |
| choices | [System.Collections.Generic.IEnumerable{System.String}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable 'System.Collections.Generic.IEnumerable{System.String}') | Choices to match against. |

##### Remarks

If `value` is the empty string, or if
`choices` is the empty collection, then this method returns
`false`.

<a name='M-xyLOGIX-Core-Extensions-StringExtensions-IsRomanNumerals-System-String-'></a>
### IsRomanNumerals(value) `method`

##### Summary

Determines whether the passed [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') contains Roman
numerals.

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
'Dr.' or 'Mr.' or 'Ms.' or 'A' etc. is the first word of a word and still needs
to be initial-capitalized.

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
parsed (as part of a character-casing operation) is the component of common
names for US streets.

##### Returns

`true` if the current word belongs as part of the
name of common US streets; `false` otherwise.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| array | [System.Collections.Generic.IReadOnlyList{System.String}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IReadOnlyList 'System.Collections.Generic.IReadOnlyList{System.String}') | (Required.) Collection of words from the text being
parsed. |
| i | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | (Required.) Index into the `array` of the
current word being parsed. |

##### Remarks

If this method is provided with the empty collection or an array
index outside the bounds of the collection, then this method returns
`false`.

<a name='M-xyLOGIX-Core-Extensions-StringExtensions-IsUppercase-System-String-'></a>
### IsUppercase(value) `method`

##### Summary

Determines whether the specified `value` is a
[String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') that consists solely of uppercase letters
(excluding whitespace).

##### Returns

`true` if the specified `value`
consists solely of uppercase letters (excluding whitespace);
`false` otherwise.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) A [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') containing
the text to be checked. |

##### Remarks

If a blank [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') or a
`null` reference is passed to this method, then this method
returns `false`.



If an error occurs during the check, then this method returns
`false`.

<a name='M-xyLOGIX-Core-Extensions-StringExtensions-IsValidAssetSymbol-System-String-'></a>
### IsValidAssetSymbol(symbol) `method`

##### Summary

Determines whether the specified `symbol` string contains a
properly-formatted asset symbol, such as `FB`, `00`, `1INCH`,
`cBETH` etc.

##### Returns

`true` if the specified `symbol` is
of the proper format; `false` otherwise.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| symbol | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) A [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') containing
the text, whose format is to be validated. |

##### Remarks

If the `symbol` parameter is passed a
`null` reference, the [Empty](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String.Empty 'System.String.Empty')
value, or a [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') containing only whitespace, then the
method returns `false`.

<a name='M-xyLOGIX-Core-Extensions-StringExtensions-IsValidEmail-System-String-'></a>
### IsValidEmail(value) `method`

##### Summary

Validates whether `value` is a valid email address
or not.

##### Returns

true if the string contains a valid email address value; false
otherwise.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | String to be checked. |

<a name='M-xyLOGIX-Core-Extensions-StringExtensions-IsValidLowercaseGuidWithNoBraces-System-String-'></a>
### IsValidLowercaseGuidWithNoBraces(value) `method`

##### Summary

Determines if the specified `value` is a string that contains
a globally-unique identifier (GUID) that is in all lowercase with no
surrounding curly braces; e.g., for example,
`b68d770b-8e37-4a20-b2cc-6cbc2ef4f136`.

##### Returns

`true` if the contents of `value`
consists of a single GUID that is in all lowercase with no surrounding curly
braces; `false` otherwise.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) A [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') containing the
data to be validated. |

##### Remarks

This method returns `false` if the argument of the
`value` parameter is a `null` reference or
consists of only whitespace characters, or is the
[Empty](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String.Empty 'System.String.Empty') value.

<a name='M-xyLOGIX-Core-Extensions-StringExtensions-IsVowelSound-System-String-'></a>
### IsVowelSound(text) `method`

##### Summary

Determines if the first word of the phrase begins with a vowel sound
for the purposes of choosing between the indefinite articles 'a' or 'an'.

##### Returns

`true` if the first word begins with a vowel sound; otherwise,
`false`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| text | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) The phrase to analyze. |

<a name='M-xyLOGIX-Core-Extensions-StringExtensions-Join-System-Collections-Generic-IList{System-String},System-String-'></a>
### Join(values,separator) `method`

##### Summary

Concatenates each element of `values` using the
specified `separator`.

##### Returns

A [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') representing the concatenated result,
or the [Empty](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String.Empty 'System.String.Empty') value on failure.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| values | [System.Collections.Generic.IList{System.String}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IList 'System.Collections.Generic.IList{System.String}') | (Required.) A collection of [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') instances to
concatenate. |
| separator | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) The [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') to insert between
adjacent elements of `values`.  If
`null`, it is treated as the
[Empty](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String.Empty 'System.String.Empty') value. |

##### Remarks

The method returns the [Empty](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String.Empty 'System.String.Empty') value if
`values` is `null` or contains no
elements.



If `null`, a blank [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String'), or the
[Empty](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String.Empty 'System.String.Empty') value is passed as the argument of the
parameter, `separator`, then this method assumes that the
separator is the [Empty](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String.Empty 'System.String.Empty') value.

<a name='M-xyLOGIX-Core-Extensions-StringExtensions-Left-System-String,System-Int32-'></a>
### Left(value,count) `method`

##### Summary

Returns the first `count` characters of
`value`.
If the source string is `null`,
empty, or shorter than `count`, the original string (or
[Empty](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String.Empty 'System.String.Empty')) is returned.

##### Returns

The requested leading substring, or a safe fallback.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) The source [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String'). |
| count | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The number of leading characters to keep.



Must be a natural number and less than or equal to the length of the string. |

<a name='M-xyLOGIX-Core-Extensions-StringExtensions-MakeSingular-System-String-'></a>
### MakeSingular(pluralWord) `method`

##### Summary

Assuming that the specified `pluralWord` contains a plural
pluralWord, this method will attempt to make it singular.

##### Returns

If successful, a [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') containing the
singular version of the specified `pluralWord`; otherwise,
the method returns the [Empty](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String.Empty 'System.String.Empty') pluralWord.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| pluralWord | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) A [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') contaiing
the pluralWord to make singular. |

##### Remarks

If `null`, a blank [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String'), or
the [Empty](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String.Empty 'System.String.Empty') value is passed as the argument of the
parameter, `pluralWord`, then this method is idempotent.



This method is also idempotent if the operation cannot be completed
successfully.

<a name='M-xyLOGIX-Core-Extensions-StringExtensions-MatchesNoCase-System-String,System-String-'></a>
### MatchesNoCase(stringToSearch,findWhat) `method`

##### Summary

Determines whether the `stringToSearch` contains
the text in the `findWhat` parameter, in a case-insensitive
fashion.

##### Returns

`true` if the case-insensitive search determines
that the `stringToSearch` value(s) contains one or more
instances of the `findWhat` text; `false`
otherwise.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| stringToSearch | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) A [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String')
value containing the text that is to be searched. |
| findWhat | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) A [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') containing
the text that is to be located within the `stringToSearch`. |

<a name='M-xyLOGIX-Core-Extensions-StringExtensions-MatchesWithCase-System-String,System-String-'></a>
### MatchesWithCase(stringToSearch,findWhat) `method`

##### Summary

Determines whether the `stringToSearch` contains
the text in the `findWhat` parameter, in a case-sensitive
fashion.

##### Returns

`true` if the case-sensitive search determines that
the `stringToSearch` value(s) contains instances of the
`findWhat` text; `false` otherwise.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| stringToSearch | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) A [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String')
value containing the text that is to be searched. |
| findWhat | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) A [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') containing
the text that is to be located within the `stringToSearch`. |

<a name='M-xyLOGIX-Core-Extensions-StringExtensions-PluralizeWord-System-String,System-Globalization-CultureInfo-'></a>
### PluralizeWord(word,culture) `method`

##### Summary

Pluralizes the word passed in, applying language rules from the
specified `culture`.

##### Returns

The `word` if it is already plural; otherwise, a
[String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') containing the plural version of the
`word`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| word | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Word to be pluralized. |
| culture | [System.Globalization.CultureInfo](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Globalization.CultureInfo 'System.Globalization.CultureInfo') | Specifies the
[CultureInfo](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Globalization.CultureInfo 'System.Globalization.CultureInfo') value to use when applying
language rules. |

##### Remarks

If the empty string is passed for `word`, then this
method returns the empty string.

<a name='M-xyLOGIX-Core-Extensions-StringExtensions-PluralizeWord-System-String-'></a>
### PluralizeWord(word) `method`

##### Summary

Pluralizes the word passed in, using the current UI culture.

##### Returns

The `word` if it is already plural; otherwise, a
[String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') containing the plural version of the
`word`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| word | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | String containing the word to be pluralized. |

##### Remarks

If the empty string is passed for `word`, then this
method returns the empty string.

<a name='M-xyLOGIX-Core-Extensions-StringExtensions-PostfixFormat-System-String,System-Object[]-'></a>
### PostfixFormat(value,args) `method`

##### Summary

More Pythonic version of the
[FormatLikePython](#M-xyLOGIX-Core-Extensions-StringExtensions-FormatLikePython 'xyLOGIX.Core.Extensions.StringExtensions.FormatLikePython')
method, which you can put after a string literal or
[String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') variable to format a string.

##### Returns

A [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') that is the result of the formatting
operation, or idempotent if the format operation could not be carried out, or
if no format values were provided in the `args` parameter.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) A [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') that
optionally contains one or more format placeholder(s). |
| args | [System.Object[]](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object[] 'System.Object[]') | (Optional.) One or more format values to be substituted in
the corresponding locations in the specified `value`. |

<a name='M-xyLOGIX-Core-Extensions-StringExtensions-PrependBang-System-String-'></a>
### PrependBang(value) `method`

##### Summary

Prepends a bang (`!`) character before the specified
`value`, and then returns the result.

##### Returns

If successful, the argument of the `value`
parameter, with a bang (`!`) character prepended; otherwise, the method is
idempotent.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) A [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') containing the
value to which a bang (`!`) character is to be prepended. |

<a name='M-xyLOGIX-Core-Extensions-StringExtensions-PrependLanguageArticle-System-String,xyLOGIX-Core-Extensions-LanguageArticleType-'></a>
### PrependLanguageArticle(value,type) `method`

##### Summary

Prepends the specified `value` with the text of the language
article specified by the `type` parameter.

##### Returns

If successful, the argument of the `value` parameter, with
the language article specified by the `type` parameter
prepended; otherwise, the method is idempotent.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) A [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') containing the value to which the
language article is to be prepended. |
| type | [xyLOGIX.Core.Extensions.LanguageArticleType](#T-xyLOGIX-Core-Extensions-LanguageArticleType 'xyLOGIX.Core.Extensions.LanguageArticleType') | (Required.) One of the
[LanguageArticleType](#T-xyLOGIX-Core-Extensions-LanguageArticleType 'xyLOGIX.Core.Extensions.LanguageArticleType') value(s) that
specifies the type of language article to prepend. |

<a name='M-xyLOGIX-Core-Extensions-StringExtensions-RegexMatchesNoCase-System-String,System-String-'></a>
### RegexMatchesNoCase(stringToSearch,regex) `method`

##### Summary

Determines whether the specified `stringToSearch`
matches the regular expression specified by the `regex`
parameter's value, without regards to upper- or lower-case.

##### Returns

If even one match is found by the `regex`, returns
`true`. Otherwise, if one or both of the required parameters
are blank or `null`, or if no matches are found by the
`regex`, then this method returns `false`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| stringToSearch | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) String containing the data to be
searched for a match. |
| regex | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) String containing the regular expression that
expresses the criteria to be used for matching. |

<a name='M-xyLOGIX-Core-Extensions-StringExtensions-RegexMatchesWithCase-System-String,System-String-'></a>
### RegexMatchesWithCase(stringToSearch,regex) `method`

##### Summary

Determines whether the specified `stringToSearch`
matches the regular expression specified by the `regex`
parameter's value, respecting case.

##### Returns

If even one match is found by the `regex`, returns
`true`. Otherwise, if one or both of the required parameters
are blank or `null`, or if no matches are found by the
`regex`, then this method returns `false`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| stringToSearch | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) String containing the data to be
searched for a match. |
| regex | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) String containing the regular expression that
expresses the criteria to be used for matching. |

<a name='M-xyLOGIX-Core-Extensions-StringExtensions-RegexReplaceNoCase-System-String,System-String,System-String-'></a>
### RegexReplaceNoCase(value,search,replacement) `method`

##### Summary

Replaces the string specified by `search` by the
`replacement` string in the `value` . The
`search` parameter may contain a Regular Expression (regex).
Case is ignored.

##### Returns

String containing the result.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) String containing the data in which the search
and replace operation is to be performed. |
| search | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) String containing the data to be found in the
string. May contain a regular expression. |
| replacement | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) String containing the data that any
found occurrences of `search` are to be substituted with. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentException 'System.ArgumentException') | Thrown if any of the required
parameters, `value`, `search`, or
`replacement`, are passed blank or `null`
strings for values. |

<a name='M-xyLOGIX-Core-Extensions-StringExtensions-RegexReplaceNoCase-System-String,System-String,System-String,System-Text-RegularExpressions-RegexOptions-'></a>
### RegexReplaceNoCase(value,search,replacement,options) `method`

##### Summary

Replaces the string specified by `search` by the
`replacement` string in the `value` . The
`search` parameter may contain a Regular Expression (regex).
Case is ignored.

##### Returns

String containing the result.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) String containing the data in which the search
and replace operation is to be performed. |
| search | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) String containing the data to be found in the
string. May contain a regular expression. |
| replacement | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) String containing the data that any
found occurrences of `search` are to be substituted with. |
| options | [System.Text.RegularExpressions.RegexOptions](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Text.RegularExpressions.RegexOptions 'System.Text.RegularExpressions.RegexOptions') | (Required.) A bitwise combination of the
[RegexOptions](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Text.RegularExpressions.RegexOptions 'System.Text.RegularExpressions.RegexOptions') enumeration values
that provide options for matching. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentException 'System.ArgumentException') | Thrown if any of the required
parameters, `value`, `search`, or
`replacement`, are passed blank or `null`
strings for values. |

##### Remarks

This overload allows specification of options in the
`options` parameter.



The
[IgnoreCase](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Text.RegularExpressions.RegexOptions.IgnoreCase 'System.Text.RegularExpressions.RegexOptions.IgnoreCase')
enumeration value is combined with whatever else is provided in the
`options` parameter by default.

<a name='M-xyLOGIX-Core-Extensions-StringExtensions-RegexReplaceWithCase-System-String,System-String,System-String-'></a>
### RegexReplaceWithCase(value,search,replacement) `method`

##### Summary

Replaces the string specified by `search` by the
`replacement` string in the `value` . The
`search` parameter may contain a Regular Expression (regex).

##### Returns

String containing the result.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) String containing the data in which the search
and replace operation is to be performed. |
| search | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) String containing the data to be found in the
string. May contain a regular expression. |
| replacement | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) String containing the data that any
found occurrences of `search` are to be substituted with. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentException 'System.ArgumentException') | Thrown if any of the required
parameters, `value`, `search`, or
`replacement`, are passed blank or `null`
strings for values. |

<a name='M-xyLOGIX-Core-Extensions-StringExtensions-RegexReplaceWithCase-System-String,System-String,System-String,System-Text-RegularExpressions-RegexOptions-'></a>
### RegexReplaceWithCase(value,search,replacement,options) `method`

##### Summary

Replaces the string specified by `search` by the
`replacement` string in the `value` . The
`search` parameter may contain a Regular Expression (regex).

##### Returns

String containing the result.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) String containing the data in which the search
and replace operation is to be performed. |
| search | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) String containing the data to be found in the
string. May contain a regular expression. |
| replacement | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) String containing the data that any
found occurrences of `search` are to be substituted with. |
| options | [System.Text.RegularExpressions.RegexOptions](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Text.RegularExpressions.RegexOptions 'System.Text.RegularExpressions.RegexOptions') | (Required.) A bitwise combination of the
[RegexOptions](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Text.RegularExpressions.RegexOptions 'System.Text.RegularExpressions.RegexOptions') enumeration values
that provide options for matching. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentException 'System.ArgumentException') | Thrown if any of the required
parameters, `value`, `search`, or
`replacement`, are passed blank or `null`
strings for values. |

<a name='M-xyLOGIX-Core-Extensions-StringExtensions-RemoveAmpersands-System-String-'></a>
### RemoveAmpersands(value) `method`

##### Summary

Removes all ampersand (`&`) character(s) from the specified
`value`.

##### Returns

A [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') that is the same as the input
`value`, but with all ampersand (`&`) character(s)
removed.



If the input `value` is `null`, empty, or
consists only of whitespace characters, then the return value is the same as
the input `value`.



If another sort of issue occurs, then this method is also idempotent.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) A [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') containing the value from which
the ampersand (`&`) character(s) are to be removed. |

<a name='M-xyLOGIX-Core-Extensions-StringExtensions-RemoveDigitsAndPunctuation-System-String-'></a>
### RemoveDigitsAndPunctuation(value) `method`

##### Summary

Strips all punctuation and numeric digits from a string and trims the
result.

##### Returns

String after transformation.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | String to have punctuation and numbers stripped. |

##### Remarks

If the empty string is passed to `value`, then the
empty string is returned.

<a name='M-xyLOGIX-Core-Extensions-StringExtensions-RemoveErrorPrefix-System-String-'></a>
### RemoveErrorPrefix(message) `method`

##### Summary

Removes the `*** ERROR *** ` prefix from the specified
`message`, and then returns the altered content.

##### Returns

If successful, a [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') containing the
specified `message` without the `*** ERROR *** ` prefix;
otherwise, the method is idempotent.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| message | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) A [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') containing
the message that is to be altered. |

##### Remarks

If the specified `message` does not contain the
`*** ERROR *** ` prefix, then this method is idempotent.

<a name='M-xyLOGIX-Core-Extensions-StringExtensions-RemoveExtraEmptyLines-System-String-'></a>
### RemoveExtraEmptyLines(value) `method`

##### Summary

Removes any extra blank lines from the end of the specified
`value`.

##### Returns

A [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') with extra blank lines removed from the end.
If
`value` is `null` or only whitespace,
returns [Empty](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String.Empty 'System.String.Empty').

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) A [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') to normalize trailing newlines in. |

<a name='M-xyLOGIX-Core-Extensions-StringExtensions-RemoveLastWord-System-String-'></a>
### RemoveLastWord(text) `method`

##### Summary

Removes the last word from the specified space-delimited phrase.

##### Returns

A [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') containing all but the final word of
`text`. If `text` contains only
one word, the empty string is returned.
If `text` is `null` or whitespace,
the original value is returned.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| text | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) The phrase to process. |

<a name='M-xyLOGIX-Core-Extensions-StringExtensions-RemoveTrailingBackslashes-System-String-'></a>
### RemoveTrailingBackslashes(value) `method`

##### Summary

Removes any trailing `\` characters from the string provided in
`value`.

##### Returns

Same as `value`, but with no trailing backslash
characters.



If the `value` parameter's argument has no trailing backslash
characters to begin with, then this method is idempotent.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) String containing the value to be stripped of
trailing backslash characters. |

##### Remarks

If the argument of the `value` parameter is blank
or `null`, then the [Empty](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String.Empty 'System.String.Empty') value
is returned.

<a name='M-xyLOGIX-Core-Extensions-StringExtensions-Replace-System-String,System-String,System-String,System-StringComparison-'></a>
### Replace(source,oldValue,newValue,comparisonType) `method`

##### Summary

Replaces all occurrences of `oldValue` with
`newValue`, using
`comparisonType` to control the matching logic.

##### Returns

A new [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') with all appropriate
replacements applied, or the original
`source` if no replacements were made or if
validation failed.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| source | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) The original [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') to
operate on. |
| oldValue | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) The substring to be replaced. |
| newValue | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) The replacement text. |
| comparisonType | [System.StringComparison](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.StringComparison 'System.StringComparison') | (Required.) One of the [StringComparison](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.StringComparison 'System.StringComparison')
values that dictates how the comparison is performed. |

<a name='M-xyLOGIX-Core-Extensions-StringExtensions-Replace-System-String,System-Char,System-Char,System-StringComparison-'></a>
### Replace(source,oldChar,newChar,comparisonType) `method`

##### Summary

Replaces all occurrences of `oldChar` with
`newChar`.  The
`comparisonType` parameter is accepted only to
mirror the other overload; it is ignored because
character‑for‑character replacement is culture‑invariant.

##### Returns

A new [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') with all occurrences of
`oldChar` replaced, or the original string if
`source` is `null`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| source | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) The original [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') to
operate on. |
| oldChar | [System.Char](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Char 'System.Char') | (Required.) The character to be replaced. |
| newChar | [System.Char](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Char 'System.Char') | (Required.) The replacement character. |
| comparisonType | [System.StringComparison](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.StringComparison 'System.StringComparison') | (Required.) One of the [StringComparison](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.StringComparison 'System.StringComparison') value(s) that
defines how the old and new value(s) are to be compared.



This parameter is ignored; it is accepted only to provide symmetry with the
other overload(s) of this method. |

<a name='M-xyLOGIX-Core-Extensions-StringExtensions-ReplaceAnyOf-System-String,System-Collections-Generic-ICollection{System-String},System-String,xyLOGIX-Core-Extensions-ReplaceAnyOfOption-'></a>
### ReplaceAnyOf(source,findWhatValues,replacementText,option) `method`

##### Summary

Replaces any of the elements of the specified
`findWhatValues` in `source` with the
specified `replacementText`.

##### Returns

If successful, the `source` string, with any of the
specified `findWhatValues`, if they occur in it, replaced
with the specified `replacementText`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| source | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) A [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') that is to be
searched. |
| findWhatValues | [System.Collections.Generic.ICollection{System.String}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.ICollection 'System.Collections.Generic.ICollection{System.String}') | (Required.) Collection of
[String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') value(s), each of which is to be searched for in
the `source`[String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String'). |
| replacementText | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) A [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') that
is to serve as the replacement for any of the specified
`findWhatValues` in `source`. |
| option | [xyLOGIX.Core.Extensions.ReplaceAnyOfOption](#T-xyLOGIX-Core-Extensions-ReplaceAnyOfOption 'xyLOGIX.Core.Extensions.ReplaceAnyOfOption') | (Required.) One of the [ReplaceAnyOfOption](#T-xyLOGIX-Core-Extensions-ReplaceAnyOfOption 'xyLOGIX.Core.Extensions.ReplaceAnyOfOption') value(s) that indicates which of the occurrence(s) of the specified `source` string are to be replaced.



The default value of this parameter is [First](#F-xyLOGIX-Core-Extensions-ReplaceAnyOfOption-First 'xyLOGIX.Core.Extensions.ReplaceAnyOfOption.First'). |

<a name='M-xyLOGIX-Core-Extensions-StringExtensions-ReplaceCopyrightSymbolWithEscapeSequence-System-String-'></a>
### ReplaceCopyrightSymbolWithEscapeSequence(value) `method`

##### Summary

Replaces the copyright symbol (©) with a PowerShell escape sequence that allows
it to show up correctly in a Git commit message.

##### Returns

If successful, a [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') containing the
modified text; otherwise, the method returns the
[Empty](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String.Empty 'System.String.Empty') value.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) A [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') containing the
text that is to be replaced. |

<a name='M-xyLOGIX-Core-Extensions-StringExtensions-ReplaceNoCase-System-String,System-String,System-String-'></a>
### ReplaceNoCase(value,search,replacement) `method`

##### Summary

Replaces the string specified by `search` by the
`replacement` string in the `value` ,
ignoring case.

##### Returns

String containing the result.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) String containing the data in which the search
and replace operation is to be performed. |
| search | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) String containing the data to be found in the
string. |
| replacement | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) String containing the data that any
found occurrences of `search` are to be substituted with. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentException 'System.ArgumentException') | Thrown if any of the required
parameters, `value`, `search`, or
`replacement`, are passed blank or `null`
strings for values. |

<a name='M-xyLOGIX-Core-Extensions-StringExtensions-ReplaceSingleQuotesWithHTMLApostrophes-System-String-'></a>
### ReplaceSingleQuotesWithHTMLApostrophes(inputString) `method`

##### Summary

Replaces single quotation marks, `'`, appearing in the specified
`inputString` with the HTML entity `&apos;`.

##### Returns

A [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') that contains the text that has had
the replacement done on it.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| inputString | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) A [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') value in
which the replacement is to take place. |

##### Remarks

If the value of the `inputString` parameter is
`null`, blank, contains only whitespace, or is the
[Empty](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String.Empty 'System.String.Empty') value, then this method is idempotent.



This method is also idempotent if an exception is caught during the execution
of the algorithm.v

<a name='M-xyLOGIX-Core-Extensions-StringExtensions-ReplaceSpacesWithHtmlNonBreakingSpace-System-String-'></a>
### ReplaceSpacesWithHtmlNonBreakingSpace(inputString) `method`

##### Summary

Replaces all spaces in the specified `inputString` with HTML
non-breaking space entities (`&nbsp;`).

##### Returns

A [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') with all spaces replaced by HTML non-breaking
space entities (`&nbsp;`).

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| inputString | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) A [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') containing the text in which
spaces are to be replaced. |

##### Remarks

If the `inputString` is `null` or consists
only of whitespace, the method returns the original
`inputString`.

<a name='M-xyLOGIX-Core-Extensions-StringExtensions-RewordAsTypeOfPhrase-System-String,xyLOGIX-Core-Extensions-LanguageArticleType,System-Boolean,System-Globalization-CultureInfo-'></a>
### RewordAsTypeOfPhrase(phrase,languageArticle,pluralizeRemainder,culture) `method`

##### Summary

Rearranges a space-separated phrase by moving the last word to the front,
inserting the preposition 'of', and conditionally adding an languageArticle
before the
rest
of the phrase. Optionally pluralizes the remainder of the phrase.

##### Returns

A [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') formatted as one of:

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| phrase | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) The space-separated phrase to transform. |
| languageArticle | [xyLOGIX.Core.Extensions.LanguageArticleType](#T-xyLOGIX-Core-Extensions-LanguageArticleType 'xyLOGIX.Core.Extensions.LanguageArticleType') | (Optional.) One of the
[LanguageArticleType](#T-xyLOGIX-Core-Extensions-LanguageArticleType 'xyLOGIX.Core.Extensions.LanguageArticleType') enumeration
value(s) indicating which article to insert before the remaining phrase.



The default value of this parameter is
[None](#F-xyLOGIX-Core-Extensions-LanguageArticleType-None 'xyLOGIX.Core.Extensions.LanguageArticleType.None'). |
| pluralizeRemainder | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | (Optional.) `true` to pluralize the remainder of the phrase
(after the
preposition); otherwise, `false`.



The default value of this parameter is `false`. |
| culture | [System.Globalization.CultureInfo](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Globalization.CultureInfo 'System.Globalization.CultureInfo') | (Optional.) A [CultureInfo](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Globalization.CultureInfo 'System.Globalization.CultureInfo') to apply for
languageArticle
rules and pluralization.



Defaults to
[InvariantCulture](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Globalization.CultureInfo.InvariantCulture 'System.Globalization.CultureInfo.InvariantCulture'). |

##### Remarks

If the [Empty](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String.Empty 'System.String.Empty') value, a blank
[String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String'), or `null` is passed as the
argument of the `phrase` parameter, then this method is
idempotent.

<a name='M-xyLOGIX-Core-Extensions-StringExtensions-SplitOn-System-String,System-String-'></a>
### SplitOn(value,delimiter) `method`

##### Summary

Splits a string `value` on a provided
`delimiter`.

##### Returns

An array whose elements contain the substrings that were split on the
provided `delimiter`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) String containing the value to be tokenized. |
| delimiter | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) String containing the delimiter on which
the `value` should be split. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentException 'System.ArgumentException') | Thrown if either of the required
parameters, `value` or `delimiter`, are
passed blank or `null` strings for values. |

<a name='M-xyLOGIX-Core-Extensions-StringExtensions-StartsWithAny-System-String,System-String[]-'></a>
### StartsWithAny(value,beginnings) `method`

##### Summary

Determines if the specified [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String')`value` starts with any of the specified
`beginnings`.

##### Returns

`true` if the specified `value`
starts with any of the specified `beginnings`;
`false` otherwise.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) A [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') containing the value to be
checked. |
| beginnings | [System.String[]](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String[] 'System.String[]') | (Required.) One or more [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String')
elements, each of which is to be assessed against the specified
`value` as being what it starts with. |

##### Remarks

This method returns `false` if no values are
passed for
`beginnings`.

<a name='M-xyLOGIX-Core-Extensions-StringExtensions-StartsWithAnyOf-System-String,System-String[]-'></a>
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
| list | [System.String[]](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String[] 'System.String[]') | List of entries. |

##### Remarks

This method performs a case-insensitive search. It returns
`false` if passed the empty string for
`text` or the empty collection for `list`.

<a name='M-xyLOGIX-Core-Extensions-StringExtensions-StartsWithNoCase-System-String,System-String-'></a>
### StartsWithNoCase(value,searchText) `method`

##### Summary

Tells whether the `value` starts with the substring
`searchText`, ignoring case.

##### Returns

`true` if `value` starts with the
`searchText`. `false` otherwise.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Value to search. |
| searchText | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Suspected starting substring. |

##### Remarks

If `value` is the empty string or if
`searchText` is the empty string, then this method returns
`false`.

<a name='M-xyLOGIX-Core-Extensions-StringExtensions-StripIncompatibleQuotes-System-String-'></a>
### StripIncompatibleQuotes(inputString) `method`

##### Summary

Strips "smart quotes" from the specified `inputString` and
replaces them with "straight quotes."

##### Returns

If successful, the `inputString`, but with "smart
quotes" replaced by "straight quotes." Otherwise, the method is idempotent.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| inputString | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) A [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String')
containing the data on which replacement is to be performed. |

##### Remarks

If the value of the `inputString` is
`null`, only consists of whitespace, or is the
[Empty](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String.Empty 'System.String.Empty') value, then this method is idempotent.

<a name='M-xyLOGIX-Core-Extensions-StringExtensions-StripNewlines-System-String-'></a>
### StripNewlines(value) `method`

##### Summary

Removes all carriage-return (`CR`) and newline (`NL`) ASCII
character(s) from the provided `value`.

##### Returns

If successful, a [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') that is identical to
the specified `value` but where all newline character(s) have
been converted to blanks; otherwise, the method is idempotent.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) A [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') containing the text from which
newline(s) are to be stripped. |

<a name='M-xyLOGIX-Core-Extensions-StringExtensions-Sub-System-String,System-Object[]-'></a>
### Sub(format,args) `method`

##### Summary

Formats a string using the `format` and
`args`.

##### Returns

A [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') with the format placeholders replaced
by the args.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| format | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) A [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') that
optionally contains one or more format specifier(s). |
| args | [System.Object[]](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object[] 'System.Object[]') | (Optional.) Collection of args whose values are to be
replaced in the format string. |

##### Remarks

This method is just an alias for the
[FormatLikePython](#T-xyLOGIX-Core-Extensions-StringExtensions-FormatLikePython 'xyLOGIX.Core.Extensions.StringExtensions.FormatLikePython')
method.



It is here to provide a way to translate VB to C# code and still use the
moniker Sub from VB that does the same operation.



If this method is passed the empty string for `format`, then
the return value is the empty string.

<a name='M-xyLOGIX-Core-Extensions-StringExtensions-Suffix-System-String,System-String-'></a>
### Suffix(value,suffix) `method`

##### Summary

Produces a new [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') by appending the specified
`suffix` to the end of the specified
`value`.

##### Returns

If successful, a new [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') containing the
concatenation of
`value` and `suffix`, or the
[Empty](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String.Empty 'System.String.Empty') value on failure.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) A [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') that is the
original string.  If this parameter is `null`, the method
treats it as the [Empty](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String.Empty 'System.String.Empty') value. |
| suffix | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) A [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') that contains
the text to append.



If this parameter is `null`, the method treats it as the
[Empty](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String.Empty 'System.String.Empty') value. |

##### Remarks



<a name='M-xyLOGIX-Core-Extensions-StringExtensions-ToASCII-System-String-'></a>
### ToASCII(value) `method`

##### Summary

Forces all characters in the input string, `value`,
to be ASCII-encoded characters only. If any Unicode characters are found in
`value`, then they are mapped back into the range of
ASCII-encoded values.

##### Returns

Same string as `value`, except that all characters
are now ASCII-encoded.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) String containing the characters to be
processed. |

##### Remarks

If this method is passed the empty or whitespace string for
`value`, then this method returns the empty string.

<a name='M-xyLOGIX-Core-Extensions-StringExtensions-ToAcronym-System-String-'></a>
### ToAcronym(phrase) `method`

##### Summary

Turns the specified `phrase` into an all-caps acronym, if a
corresponding entry is not found in our dictionary fields of short, non-acronym
terms, i.e.,
[ShortWordsThatAreNotAcronyms](#F-xyLOGIX-Core-Extensions-StringExtensions-ShortWordsThatAreNotAcronyms 'xyLOGIX.Core.Extensions.StringExtensions.ShortWordsThatAreNotAcronyms')
.

##### Returns

Acronym converted from `phrase`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| phrase | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) String containing the phrase to turn into an
acronym. |

##### Remarks

If this method is passed the empty or whitespace string, then it
returns the empty string. If this method is passed a word or phrase that is
short, but not an acronym, then the input is returned with no alteration.

<a name='M-xyLOGIX-Core-Extensions-StringExtensions-ToAcronymLetter-System-String-'></a>
### ToAcronymLetter(word) `method`

##### Summary

Uses the first letter (turned into being uppercase, if necessary) of
the `word` provided to be one of the letters of an acronym
that is being built, e.g., from a phrase, using the first letter of each of the
words of the phrase as each of the corresponding letters of the resulting
acronym.

##### Returns

String containing the letter(s) to be utilized in the acronym.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| word | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) String containing the word whose first letter
should be made into a corresponding acronym letter. |

##### Remarks

If `word` is the empty or whitespace string, then
this method returns the empty string.

<a name='M-xyLOGIX-Core-Extensions-StringExtensions-ToCodeElementPreservingPluralization-System-String-'></a>
### ToCodeElementPreservingPluralization(text) `method`

##### Summary

Converts the specified `text` into a code element by
preserving pluralization.

##### Returns

A [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') that is the same as the
`text` but with the first letter of each word capitalized and
pluralization preserved.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| text | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) A [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') containing the text to convert
into a code element. |

<a name='M-xyLOGIX-Core-Extensions-StringExtensions-ToGuidWithNoPunctuation-System-Guid-'></a>
### ToGuidWithNoPunctuation(guid) `method`

##### Summary

Turns a GUID into a string representation but removes all the '{',
'}' and '-' from the string representation, so that the string representation
contains only letters and/or numbers.

##### Returns

String representation with no '{', '}' and '-' in the string
representation, so that the string representation contains only letters and/or
numbers.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| guid | [System.Guid](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Guid 'System.Guid') | Reference to a [Guid](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Guid 'System.Guid') to turn into a
string of letters and numbers. |

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

<a name='M-xyLOGIX-Core-Extensions-StringExtensions-ToLanguageArticle-System-String,xyLOGIX-Core-Extensions-LanguageArticleType-'></a>
### ToLanguageArticle(value,type) `method`

##### Summary

Obtains the text of the language article specified by the
`type` parameter for the `value` passed.

##### Returns

If successful, the language article specified by the `type`
parameter for the `value` passed; otherwise, the method is
idempotent.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) A [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') containing the value to which the
language article is to be obtained. |
| type | [xyLOGIX.Core.Extensions.LanguageArticleType](#T-xyLOGIX-Core-Extensions-LanguageArticleType 'xyLOGIX.Core.Extensions.LanguageArticleType') | (Required.) One of the
[LanguageArticleType](#T-xyLOGIX-Core-Extensions-LanguageArticleType 'xyLOGIX.Core.Extensions.LanguageArticleType') value(s) that
specifies the type of language article to obtain. |

<a name='M-xyLOGIX-Core-Extensions-StringExtensions-ToList-System-String,System-String[]-'></a>
### ToList(quote,separators) `method`

##### Summary

Turns a delimited [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') into a collection of
strings with one delimited entry per element.

##### Returns

Collection of strings containing the delimited entries.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| quote | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) String containing the text to be
transformed. |
| separators | [System.String[]](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String[] 'System.String[]') | Collection of strings specifying the delimiter(s) to
split upon. |

##### Remarks

Any empty entries in the resultant collection are removed. If the
empty string is provided as input to this method, then the method returns the
empty string. If no separators are specified, then the empty collection is
returned.

<a name='M-xyLOGIX-Core-Extensions-StringExtensions-ToLowercase-System-String-'></a>
### ToLowercase(value) `method`

##### Summary

Converts the specified `value` to lowercase, ignoring
culture.

##### Returns

If successful, the `value` specified, but converted to
lowercase; otherwise, this method is idempotent.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) A [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') containing the text to be
converted to lowercase. |

<a name='M-xyLOGIX-Core-Extensions-StringExtensions-ToPhrase-System-String-'></a>
### ToPhrase(value) `method`

##### Summary

Converts an initial-caps string into a space-separated, lowercase phrase,
preserving acronyms.

##### Returns

A [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') where all words are separated by spaces.
Acronyms remain in uppercase while other words are converted to lowercase.



If `value` is `null` or empty, an empty
string is returned.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The initial-caps string to be transformed. (Required.) |

<a name='M-xyLOGIX-Core-Extensions-StringExtensions-ToPhraseInTitleCase-System-String-'></a>
### ToPhraseInTitleCase(value) `method`

##### Summary

Converts an initial-caps string into a space-separated, title-cased phrase,
preserving acronyms.

##### Returns

A [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') where all words are separated by spaces.
Acronyms remain in uppercase while other words are converted to
`Title Case`.



If `value` is `null` or empty, an empty
string is returned.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The initial-caps string to be transformed. (Required.) |

<a name='M-xyLOGIX-Core-Extensions-StringExtensions-ToSolutionFileEntryFormat-System-String-'></a>
### ToSolutionFileEntryFormat(pathname) `method`

##### Summary

Formats the specified `pathname` as a Visual Studio Solution
(`*.sln`) file entry, e.g., `MyProject\MyProject.csproj`.

##### Returns

If successful, the specified `pathname`, formatted
as a Visual Studio Solution (`*.sln`) file entry, e.g.,
`MyProject\MyProject.csproj`; otherwise, the
[Empty](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String.Empty 'System.String.Empty') value is returned.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| pathname | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) A [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') that contains the fully-qualified
pathname of a file that is to be formatted as a Visual Studio Solution (
`*.sln`) file entry. |

##### Remarks

If a `null` blank, or
[Empty](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String.Empty 'System.String.Empty') value is passed for the argument of the
`pathname` parameter, then the method returns the
[Empty](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String.Empty 'System.String.Empty') value,

<a name='M-xyLOGIX-Core-Extensions-StringExtensions-ToTitleCase-System-String-'></a>
### ToTitleCase(value) `method`

##### Summary

Converts the specified `value` to Title Case,
preserving the casing of acronyms.

##### Returns

A [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') containing the text from
`value` converted to Title Case, with acronyms preserved.



If `value` is `null` or whitespace, the
original value is returned.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) A [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') containing the text to be
converted to Title Case. |

<a name='M-xyLOGIX-Core-Extensions-StringExtensions-ToUnicode-System-String-'></a>
### ToUnicode(value) `method`

##### Summary

Translates each character of the provided `value`,
character-by-character, to Unicode encoding. This method performs the inverse
operation of the
[ToASCII](#M-xyLOGIX-Core-Extensions-StringExtensions-ToASCII 'xyLOGIX.Core.Extensions.StringExtensions.ToASCII') method.

##### Returns

String containing the re-encoded corresponding text to that in
`value`; or the empty string if the empty string is provided
to this method.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) String containing the text to be re-encoded. |

<a name='M-xyLOGIX-Core-Extensions-StringExtensions-ToUppercase-System-String-'></a>
### ToUppercase(value) `method`

##### Summary

Converts the provided [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String')`value`
to all uppercase, ignoring culture.

##### Returns

If successful, the `value` specified, but converted
to uppercase; otherwise, this method is idempotent.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) A [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') containing the text to be
converted to uppercase. |

<a name='M-xyLOGIX-Core-Extensions-StringExtensions-TrimAnyOffEnd-System-String,System-Boolean,System-Boolean,System-String[]-'></a>
### TrimAnyOffEnd(value,caseSensitive,recursive,badEndings) `method`

##### Summary

Removes any specified substrings from the end of the given string.

##### Returns

A [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') with any matching substrings from
`badEndings`
removed from the end. If `value` is `null`,
whitespace,
or no matches are found, the original string is returned.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) A [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') containing the text to be
processed. |
| caseSensitive | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | (Optional.) A [Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') value indicating whether a
case-sensitive search is to be performed.



The default value of this parameter is `false`. |
| recursive | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | (Optional.) A [Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') value indicating whether the
removal of bad endings should be applied repeatedly until no matches remain.



The default value of this parameter is `true`. |
| badEndings | [System.String[]](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String[] 'System.String[]') | An array of [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') value(s) representing the substrings
to remove from the end of `value`. If
`badEndings`
is `null` or empty, no changes are made. |

##### Remarks

The method iterates through the `badEndings` array to
identify
and remove any substrings that match the end of `value`.
It performs case-sensitive or case-insensitive comparisons depending on
the value of `caseSensitive`.
If `recursive` is set to `true`, the method
will repeatedly trim matches until no further matches are found.

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

If the empty or whitespace string is provided for
`currentLine` , then the empty string is returned by this
method.

<a name='T-xyLOGIX-Core-Extensions-TextBoxExtensions'></a>
## TextBoxExtensions `type`

##### Namespace

xyLOGIX.Core.Extensions

##### Summary

Exposes static extension methods for
[TextBox](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.TextBox 'System.Windows.Forms.TextBox')-derived controls.

<a name='F-xyLOGIX-Core-Extensions-TextBoxExtensions-EM_SETCUEBANNER'></a>
### EM_SETCUEBANNER `constants`

##### Summary

Specifies the message to set the cue banner text (placeholder text) for a
[TextBox](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.TextBox 'System.Windows.Forms.TextBox') control.

##### Remarks

This message is sent to a [TextBox](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.TextBox 'System.Windows.Forms.TextBox') control
to display grayed-out text when the
[TextBox](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.TextBox 'System.Windows.Forms.TextBox') is empty and unfocused.

<a name='M-xyLOGIX-Core-Extensions-TextBoxExtensions-IsWindow-System-IntPtr-'></a>
### IsWindow(hWnd) `method`

##### Summary

Determines whether the specified window handle identifies an existing window.

##### Returns

`true` if the window handle identifies an existing window;
otherwise, `false`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| hWnd | [System.IntPtr](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IntPtr 'System.IntPtr') | A handle to the window to be tested. |

##### Remarks

The `hWnd` parameter is a handle to a window.
The function checks if the window associated with the handle still exists.

<a name='M-xyLOGIX-Core-Extensions-TextBoxExtensions-SendMessage-System-IntPtr,System-UInt32,System-IntPtr,System-String-'></a>
### SendMessage(hWnd,Msg,wParam,lParam) `method`

##### Summary

Sends the specified message to a window or windows.



The `SendMessage` function calls the window procedure for the specified
window and does not return until the window procedure has processed the
message.

##### Returns

The result of the message processing, which depends on the message sent.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| hWnd | [System.IntPtr](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IntPtr 'System.IntPtr') | (Required.) A handle to the window whose window procedure
will receive the message. |
| Msg | [System.UInt32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.UInt32 'System.UInt32') | (Required.) The message to be sent. |
| wParam | [System.IntPtr](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IntPtr 'System.IntPtr') | (Required.) Additional message-specific information. |
| lParam | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) Additional message-specific information,
passed as a string. |

##### Remarks

Use this method to send messages directly to a window's window procedure,
bypassing the system's message queue.

<a name='M-xyLOGIX-Core-Extensions-TextBoxExtensions-SetCueBanner-System-Windows-Forms-TextBoxBase,System-String-'></a>
### SetCueBanner(textBox,cueText) `method`

##### Summary

Sets the cue banner of the specified `textBox` to the
specified `cueText`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| textBox | [System.Windows.Forms.TextBoxBase](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.TextBoxBase 'System.Windows.Forms.TextBoxBase') | (Required.) Reference to an instance of
[TextBox](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.TextBox 'System.Windows.Forms.TextBox') that refers to the textbox for
which cue text is to be set. |
| cueText | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Optional.) A [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') that
contains the cue text.



Pass the [Empty](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String.Empty 'System.String.Empty') value to remove the cue text. |

<a name='T-xyLOGIX-Core-Extensions-ToolStripMenuItemExtensions'></a>
## ToolStripMenuItemExtensions `type`

##### Namespace

xyLOGIX.Core.Extensions

##### Summary

Exposes static extension methods for
[ToolStripMenuItem](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.ToolStripMenuItem 'System.Windows.Forms.ToolStripMenuItem') controls.

<a name='M-xyLOGIX-Core-Extensions-ToolStripMenuItemExtensions-#cctor'></a>
### #cctor() `method`

##### Summary

Initializes static data or performs actions that need to be performed once only
for the [ToolStripMenuItemExtensions](#T-xyLOGIX-Core-Extensions-ToolStripMenuItemExtensions 'xyLOGIX.Core.Extensions.ToolStripMenuItemExtensions')
class.

##### Parameters

This method has no parameters.

##### Remarks

This constructor is called automatically prior to the first instance being
created or before any static members are referenced.



We've decorated this constructor with the `[Log(AttributeExclude = true)]`
attribute in order to simplify the logging output.

<a name='M-xyLOGIX-Core-Extensions-ToolStripMenuItemExtensions-ContainsMenuItemNamed-System-Windows-Forms-ToolStripMenuItem,System-String-'></a>
### ContainsMenuItemNamed(item,name) `method`

##### Summary

Determines whether the specified `item` contains a menu item
with the specified `name`.

##### Returns

`true` if a drop-down menu item having the specified
`name` is found in the drop-down items of the specified
`item`; `false` otherwise.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| item | [System.Windows.Forms.ToolStripMenuItem](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.ToolStripMenuItem 'System.Windows.Forms.ToolStripMenuItem') | (Required.) Reference to an instance of
[ToolStripMenuItem](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.ToolStripMenuItem 'System.Windows.Forms.ToolStripMenuItem') that is the menu item
whose drop-down item(s) are to be searched. |
| name | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) A [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') containing the name of the menu
item to search for. |

<a name='M-xyLOGIX-Core-Extensions-ToolStripMenuItemExtensions-ContainsMenuItemNamed-System-Windows-Forms-MenuStrip,System-String-'></a>
### ContainsMenuItemNamed(menu,name) `method`

##### Summary

Determines whether the specified `menu` contains a menu item
with the specified `name`.

##### Returns

`true` if a drop-down menu item having the specified
`name` is found in the drop-down items of the specified
`menu`; `false` otherwise.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| menu | [System.Windows.Forms.MenuStrip](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.MenuStrip 'System.Windows.Forms.MenuStrip') | (Required.) Reference to an instance of
[ToolStripMenuItem](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.ToolStripMenuItem 'System.Windows.Forms.ToolStripMenuItem') that is the menu
whose drop-down menu(s) are to be searched. |
| name | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) A [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') containing the name of the menu
item to search for. |

<a name='M-xyLOGIX-Core-Extensions-ToolStripMenuItemExtensions-GetMenuItemNamed-System-Windows-Forms-ToolStripMenuItem,System-String-'></a>
### GetMenuItemNamed(menu,name) `method`

##### Summary

Among the drop-down items of the specified `menu`,
gets a reference to an instance of
[ToolStripMenuItem](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.ToolStripMenuItem 'System.Windows.Forms.ToolStripMenuItem') that has the specified
`name`.

##### Returns

If successful, a reference to an instance of
[ToolStripMenuItem](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.ToolStripMenuItem 'System.Windows.Forms.ToolStripMenuItem') that refers to the
matching menu item; otherwise, a `null` reference is
returned.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| menu | [System.Windows.Forms.ToolStripMenuItem](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.ToolStripMenuItem 'System.Windows.Forms.ToolStripMenuItem') | (Required.) Reference to an instance of
[ToolStripMenuItem](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.ToolStripMenuItem 'System.Windows.Forms.ToolStripMenuItem') that is the menu
whose drop-down menu(s) are to be searched. |
| name | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) A [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') containing the name of the menu
item to search for. |

<a name='M-xyLOGIX-Core-Extensions-ToolStripMenuItemExtensions-GetMenuItemNamed-System-Windows-Forms-MenuStrip,System-String-'></a>
### GetMenuItemNamed(menu,name) `method`

##### Summary

Among the drop-down items of the specified `menu`, gets a
reference to an instance of
[ToolStripMenuItem](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.ToolStripMenuItem 'System.Windows.Forms.ToolStripMenuItem') that has the specified
`name`.

##### Returns

If successful, a reference to an instance of
[ToolStripMenuItem](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.ToolStripMenuItem 'System.Windows.Forms.ToolStripMenuItem') that refers to the
matching menu item; otherwise, a `null` reference is returned.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| menu | [System.Windows.Forms.MenuStrip](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.MenuStrip 'System.Windows.Forms.MenuStrip') | (Required.) Reference to an instance of
[ToolStripMenuItem](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.ToolStripMenuItem 'System.Windows.Forms.ToolStripMenuItem') that is the menu
whose drop-down menu(s) are to be searched. |
| name | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) A [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') containing the name of the menu
item to search for. |

<a name='T-xyLOGIX-Core-Extensions-Transform'></a>
## Transform `type`

##### Namespace

xyLOGIX.Core.Extensions

##### Summary

Exposes static method(s) to transform text strings in various ways.

<a name='F-xyLOGIX-Core-Extensions-Transform-AcronymPattern'></a>
### AcronymPattern `constants`

##### Summary

A regular expression pattern that matches an entire string consisting only of
uppercase letters.
This pattern is useful for identifying acronyms (e.g., "NASA", "AI", "RADAR")
that appear as
standalone words without any lowercase letters.

This pattern ensures that the input string contains only uppercase letters from
A to Z
and does not include numbers, spaces, or lowercase characters.

<a name='F-xyLOGIX-Core-Extensions-Transform-InitialCapsWordPattern'></a>
### InitialCapsWordPattern `constants`

##### Summary

A regular expression pattern that matches words in an initial-caps formatted
string.
This pattern identifies:

The matched words can be used to transform an initial-caps string into a
space-separated phrase
while preserving acronyms.

<a name='M-xyLOGIX-Core-Extensions-Transform-#cctor'></a>
### #cctor() `method`

##### Summary

Initializes static data or performs actions that need to be performed once only
for the [Transform](#T-xyLOGIX-Core-Extensions-Transform 'xyLOGIX.Core.Extensions.Transform') class.

##### Parameters

This method has no parameters.

##### Remarks

This constructor is called automatically prior to the first instance being
created or before any static members are referenced.



We've decorated this constructor with the `[Log(AttributeExclude = true)]`
attribute in order to simplify the logging output.

<a name='M-xyLOGIX-Core-Extensions-Transform-PascalCasedTextToPhrase-System-String-'></a>
### PascalCasedTextToPhrase(input) `method`

##### Summary

Converts an initial-caps string into a space-separated, lowercase phrase,
preserving acronyms.

##### Returns

A [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') where all words are separated by spaces.
Acronyms remain in uppercase while other words are converted to lowercase.
If `input` is `null` or empty, an empty
string is returned.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| input | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The initial-caps string to be transformed. (Required.) |

<a name='T-xyLOGIX-Core-Extensions-TypeExtensions'></a>
## TypeExtensions `type`

##### Namespace

xyLOGIX.Core.Extensions

##### Summary

Helper methods to assist in handling runtime type information.

<a name='P-xyLOGIX-Core-Extensions-TypeExtensions-CachedActualType'></a>
### CachedActualType `property`

##### Summary

Dictionary that caches the results of the
[GetActualType](#M-xyLOGIX-Core-Extensions-TypeExtensions-GetActualType 'xyLOGIX.Core.Extensions.TypeExtensions.GetActualType') method
for faster performance.

<a name='M-xyLOGIX-Core-Extensions-TypeExtensions-#cctor'></a>
### #cctor() `method`

##### Summary

Initializes static data or performs actions that need to be performed once only
for the [TypeExtensions](#T-xyLOGIX-Core-Extensions-TypeExtensions 'xyLOGIX.Core.Extensions.TypeExtensions') class.

##### Parameters

This method has no parameters.

##### Remarks

This constructor is called automatically prior to the first instance being
created or before any static members are referenced.

<a name='M-xyLOGIX-Core-Extensions-TypeExtensions-GetActualType-System-Type-'></a>
### GetActualType() `method`

##### Summary

Gets the public type of IList. When the type is not a list then
this method will return the same type. if type is List of T then this method
will return the type of T.

##### Parameters

This method has no parameters.

<a name='M-xyLOGIX-Core-Extensions-TypeExtensions-IsSameOrSubclassOf-System-Type,System-Type-'></a>
### IsSameOrSubclassOf(potentialDescendant,potentialBaseType) `method`

##### Summary

Ascertains whether the `potentialDescendant` is of
the same, or a subclass of, the base class whose [Type](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Type 'System.Type')
is passed.

##### Returns

True if the type of the `potentialDescendant` is
the same as, or a subclass of, the base type.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| potentialDescendant | [System.Type](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Type 'System.Type') | Type to be examined. |
| potentialBaseType | [System.Type](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Type 'System.Type') | Reference to the [Type](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Type 'System.Type')
structure of the class you think might be the
`potentialDescendant`'s base. |
