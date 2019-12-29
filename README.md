# BasicControlsValidation
A small .Net  winForm input controls (TextBox, ComboBox, MaskedTextBox, DataGridView) library that check empty and null values.

Usage / Example

``` C#
using static BasicControlValidation.Validation;

private void Click(object sender, EventArgs e)
{
   if (AreValidTextBoxesWithError(tb1,tb2,...,tbn))
   {
        // Code Block
   }
}

private void KeyPress(object sender, KeyPressEventArgs e)
{
     e.Handled = MakeNumeric(sender as TextBox, e.KeyChar);
}
        
```

## Installing via the NuGet Package Command ##

    Install-Package BasicControlsValidation
