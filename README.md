# BasicControlsValidation
A small .Net  winForm input controls (TextBox, ComboBox, MaskedTextBox, DataGridView) library that check empty and null values.


``` C#
Example

        using static BasicControlValidation.Validation;

        private void button1_Click(object sender, EventArgs e)
        {
            if (AreValidControlsWithError(this))
            {
                // Code Block
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = MakeNumeric(sender as TextBox, e.KeyChar);
        }
```
