using System.Windows.Forms;

namespace BasicControlsValidation
{
    /// <summary>
    /// -----------------------------------------------------------------
    ///   Author:           Qasim
    ///   Date:             28-Dec-2019
    ///-----------------------------------------------------------------
    /// </summary>

    /// <summary>
    /// Validation Class
    /// </summary>
    public static class Validation
    {
        #region TextBoxes
        private static ErrorProvider errorProvider = new ErrorProvider();

        /// <summary>
        /// Indicates whether the all Specified TextBoxes are not Empty/Null.
        /// </summary>
        /// <param name="TextBoxList">List of TextBoxes</param>
        /// <returns>
        /// Boolean Value
        /// </returns>
        public static bool AreValidTextBoxes(params TextBox[] TextBoxList)
        {
            bool result = false;
            foreach (TextBox con in TextBoxList)
            {
                if (string.IsNullOrWhiteSpace(con.Text))
                {
                    con.Focus();
                    result = false;
                    break;
                }
                else
                {
                    result = true;
                }
            }
            return result;
        }

        /// <summary>
        /// Indicates whether the all Specified TextBoxes are not Empty/Null along with Error Provider.
        /// </summary>
        /// <param name="TextBoxList">List of TextBoxes</param>
        /// <returns>
        /// Boolean Value
        /// </returns>
        public static bool AreValidTextBoxesWithError(params TextBox[] TextBoxList)
        {
            return AreValidTextBoxess("", TextBoxList);
        }

        /// <summary>
        /// Indicates whether the all Specified TextBoxes are not Empty/Null along with Error Provider and Custom Message.
        /// </summary>
        /// /// <param name="ErrorMessage">Error Message</param>
        /// <param name="TextBoxList">List of TextBoxes</param>
        /// <returns>
        /// Boolean Value
        /// </returns>
        public static bool AreValidTextBoxesWithError(string ErrorMessage, params TextBox[] TextBoxList)
        {
            return AreValidTextBoxess(ErrorMessage, TextBoxList);
        }

        private static bool AreValidTextBoxess(string ErrorMessage, TextBox[] TextBoxList)
        {
            bool result = false;
            errorProvider.Clear();
            foreach (TextBox text in TextBoxList)
            {
                if (string.IsNullOrWhiteSpace(text.Text))
                {
                    text.Focus();
                    if (!string.IsNullOrWhiteSpace(ErrorMessage))
                    {
                        errorProvider.SetError(text as TextBox, ErrorMessage);
                    }
                    else
                    {
                        errorProvider.SetError(text as TextBox, "Required Field Can't Be Empty");
                    }
                    result = false;
                    break;
                }
                else
                {
                    result = true;
                }
            }
            return result;
        }

        /// <summary>
        /// Indicates whether the all Specified TextBoxes are not Empty/Null.
        /// </summary>
        /// <param name="TextBox">TextBox</param>
        /// <returns>
        /// Boolean Value
        /// </returns>
        public static bool IsValidTextBox(TextBox TextBox)
        {
            bool result;
            if (string.IsNullOrWhiteSpace(TextBox.Text))
            {
                TextBox.Focus();
                result = false;
            }
            else
            {
                result = true;
            }
            return result;
        }

        /// <summary>
        /// Indicates whether the all Specified TextBoxes are not Empty/Null.
        /// </summary>
        /// <param name="TextBox">TextBox</param>
        /// <returns>
        /// Boolean Value
        /// </returns>
        public static bool IsValidTextBoxWithError(TextBox TextBox)
        {
            bool result = false;
            errorProvider.Clear();
            if (string.IsNullOrWhiteSpace(TextBox.Text))
            {
                TextBox.Focus();
                errorProvider.SetError(TextBox, "Required Field Can't Be Empty");
                result = false;
            }
            else
            {
                result = true;
            }
            return result;
        }

        /// <summary>
        /// Make TextBox numeric only 
        /// </summary>
        /// <param name="TextBox">TextBox</param>
        /// <param name="character"></param>
        /// <returns>
        /// Boolean Value
        /// </returns>
        public static bool MakeNumeric(TextBox TextBox, char character)
        {
            bool result = (character == '.')
                && (TextBox.Text.IndexOf('.') > -1) || (!char.IsControl(character)
                && !char.IsDigit(character) && (character != '.')) ? true : false;
            return result;
        }

        #endregion

        #region ComboBoxes

        /// <summary>
        /// Indicates whether the all Specified Comboboxes are not Empty/Null.
        /// </summary>
        /// <param name="ComboBoxList">List of ComboBoxes</param>
        /// <returns>
        /// Boolean Value
        /// </returns>
        public static bool AreValidComboBoxes(params ComboBox[] ComboBoxList)
        {
            bool result = false;
            foreach (ComboBox con in ComboBoxList)
            {
                if (con.SelectedIndex == -1)
                {
                    con.Focus();
                    result = false;
                    break;
                }
                else
                {
                    result = true;
                }
            }
            return result;
        }

        /// <summary>
        /// Indicates whether the all Specified Comboboxes are not Empty/Null along with Error Provider.
        /// </summary>
        /// <param name="ComboBoxList">List of ComboBoxes</param>
        /// <returns>
        /// Boolean Value
        /// </returns>
        public static bool AreValidComboBoxesWithError(params ComboBox[] ComboBoxList)
        {
            return AreValidComboBoxess("", ComboBoxList);
        }

        /// <summary>
        /// Indicates whether the all Specified Comboboxes are not Empty/Null along with Error Provider and Custom Message
        /// </summary>
        /// <param name="ErrorMessage">Error Message</param>
        /// <param name="ComboBoxList">List of ComboBoxes</param>
        /// <returns>
        /// Boolean Value
        /// </returns>
        public static bool AreValidComboBoxesWithError(string ErrorMessage, params ComboBox[] ComboBoxList)
        {
            return AreValidComboBoxess(ErrorMessage, ComboBoxList);
        }

        private static bool AreValidComboBoxess(string ErrorMessage, ComboBox[] comboBoxList)
        {
            bool result = false;
            errorProvider.Clear();
            foreach (ComboBox combo in comboBoxList)
            {
                if (combo.SelectedIndex == -1)
                {
                    combo.Focus();
                    if (!string.IsNullOrWhiteSpace(ErrorMessage))
                    {
                        errorProvider.SetError(combo as ComboBox, ErrorMessage);
                    }
                    else
                    {
                        errorProvider.SetError(combo as ComboBox, "Required Field Can't Be Empty");
                    }
                    result = false;
                    break;
                }
                else
                {
                    result = true;
                }
            }
            return result;
        }

        /// <summary>Indicates whether the Specified single Combobox is not Empty/Null.</summary>
        /// <param name="combobox">Combobox</param>
        /// <returns>Boolean Value</returns>
        public static bool IsValidComboBox(ComboBox combobox)
        {
            bool result = false;
            if (combobox.SelectedIndex == -1)
            {
                combobox.Focus();
                result = false;
            }
            else
            {
                result = true;
            }
            return result;
        }

        /// <summary>
        /// Indicates whether the Specified single Combobox is not Empty/Null With ErrorProvider.
        /// </summary>
        /// <param name="combobox">Combobox</param>
        /// <returns>
        /// Boolean Value
        /// </returns>
        public static bool IsValidComboBoxWithError(ComboBox combobox)
        {
            bool result = false;
            errorProvider.Clear();
            if (combobox.SelectedIndex == -1)
            {
                combobox.Focus();
                errorProvider.SetError(combobox, "Required Field Can't Be Empty");
                result = false;
            }
            else
            {
                result = true;
            }
            return result;
        }

        #endregion

        #region MaskedTextBox

        /// <summary>
        /// Indicates whether the all Specified MaskedTextBoxes are not Empty/Null.
        /// </summary>
        /// <param name="MaskedTextBoxes">List of MaskedTextBoxes</param>
        /// <returns>
        /// Boolean Value
        /// </returns>
        public static bool IsValidMaskedTextBoxes(params MaskedTextBox[] MaskedTextBoxes)
        {
            bool result = false;
            foreach (MaskedTextBox mask in MaskedTextBoxes)
            {
                if (!mask.MaskCompleted)
                {
                    mask.Focus();
                    result = false;
                    break;
                }
                else
                {
                    result = true;
                }
            }
            return result;
        }

        /// <summary>
        /// Indicates whether the all Specified MaskedTextBoxes are not Empty/Null along with Error Provider
        /// </summary>
        /// <param name="MaskedTextBoxes">List of MaskedTextBoxes</param>
        /// <returns>
        /// Boolean Value
        /// </returns>
        public static bool AreValidMaskedTextBoxesWithError(params MaskedTextBox[] MaskedTextBoxes)
        {
            return AreValidMaskedTextBoxWithErrors("", MaskedTextBoxes);
        }

        /// <summary>
        /// Indicates whether the all Specified Comboboxes are not Empty/Null along with Error Provider and Custom Message
        /// </summary>
        /// <param name="ErrorMessage">Error Message</param>
        /// <param name="MaskedTextBoxes">List of MasekdTextBoxes</param>
        /// <returns>
        /// Boolean Value
        /// </returns>
        public static bool AreValidMaskedTextBoxesWithError(string ErrorMessage, params MaskedTextBox[] MaskedTextBoxes)
        {
            return AreValidMaskedTextBoxWithErrors(ErrorMessage, MaskedTextBoxes);
        }

        private static bool AreValidMaskedTextBoxWithErrors(string ErrorMessage, MaskedTextBox[] MaskedTextBoxes)
        {
            bool result = false;
            errorProvider.Clear();
            foreach (MaskedTextBox masked in MaskedTextBoxes)
            {
                if (!masked.MaskCompleted)
                {
                    masked.Focus();
                    if (!string.IsNullOrWhiteSpace(ErrorMessage))
                    {
                        errorProvider.SetError(masked as MaskedTextBox, ErrorMessage);
                    }
                    else
                    {
                        errorProvider.SetError(masked as MaskedTextBox, "Required Field Can't Be Empty");
                    }
                    result = false;
                    break;
                }
                else
                {
                    result = true;
                }
            }
            return result;
        }

        /// <summary>
        /// Indicates whether the Specified single TextBox is not Empty/Null.
        /// </summary>
        /// <param name="maskedTextBox">MaskedTextBox</param>
        /// <returns>
        /// Boolean Value
        /// </returns>
        public static bool IsValidMaskedTextBox(MaskedTextBox maskedTextBox)
        {
            bool result = false;
            if (!maskedTextBox.MaskCompleted)
            {
                maskedTextBox.Focus();
                result = false;
            }
            else
            {
                result = true;
            }
            return result;
        }

        /// <summary>
        /// Indicates whether the Specified single TextBox is not Empty/Null.
        /// </summary>
        /// <param name="maskedTextBox">MaskedTextBox</param>
        /// <returns>
        /// Boolean Value
        /// </returns>
        public static bool IsValidMaskedTextBoxWithError(MaskedTextBox maskedTextBox)
        {
            bool result = false;
            errorProvider.Clear();
            if (!maskedTextBox.MaskCompleted)
            {
                maskedTextBox.Focus();
                errorProvider.SetError(maskedTextBox, "Required Field Can't Be Empty");
                result = false;
            }
            else
            {
                result = true;
            }
            return result;
        }
        #endregion

        #region Mix Controls

        /// <summary>
        /// Indicates whether the DatagridView has atleaset one row and Cell[0,0] value is not Empty/Null.
        /// </summary>
        /// <param name="DGV">DataGridView</param>
        /// <returns>
        /// Boolean Value
        /// </returns>
        public static bool IsValidDataGridView(DataGridView DGV)
        {
            if (DGV.Rows.Count <= 0)
            {
                DGV.Rows.Add();
                return false;
            }
            else if (DGV.Rows.Count > 0 && DGV[0, 0].Value != null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        /// <summary>
        /// Indicates whether the all Specified Control are not Empty/Null.
        /// </summary>
        /// <param name="ControlList">List of Controls</param>
        /// <returns>
        /// Boolean Value
        /// </returns>
        public static bool AreValidControls(params Control[] ControlList)
        {
            bool result = false;
            foreach (Control con in ControlList[0].Controls)
            {
                if ((con is TextBox) && string.IsNullOrWhiteSpace((con as TextBox).Text))
                {
                    (con as TextBox).Focus();
                    result = false;
                    break;
                }
                else if ((con is ComboBox) && (con as ComboBox).SelectedIndex == -1)
                {
                    (con as ComboBox).Focus();
                    result = false;
                    break;
                }
                else
                {
                    result = true;
                }
            }
            return result;
        }

        /// <summary>
        /// Indicates whether the all Specified Control are not Empty/Null and along With Error Provider.
        /// </summary>
        /// <param name="ControlList">List Control</param>
        /// <returns>
        /// Boolean Value
        /// </returns>
        public static bool AreValidControlsWithError(params Control[] ControlList)
        {
            bool result = false;
            errorProvider.Clear();
            foreach (Control con in ControlList[0].Controls)
            {
                if ((con is TextBox) && string.IsNullOrWhiteSpace((con as TextBox).Text))
                {
                    (con as TextBox).Focus();
                    errorProvider.SetError(con as TextBox, "Required Field Can't Be Empty");
                    result = false;
                    break;
                }
                else if ((con is ComboBox) && (con as ComboBox).SelectedIndex == -1)
                {
                    (con as ComboBox).Focus();
                    errorProvider.SetError(con as ComboBox, "Required Field Can't Be Empty");
                    result = false;
                    break;
                }
                else if ((con is MaskedTextBox) && !(con as MaskedTextBox).MaskCompleted)
                {
                    (con as MaskedTextBox).Focus();
                    errorProvider.SetError(con as MaskedTextBox, "Required Field Can't Be Empty");
                    result = false;
                    break;
                }
                else
                {
                    result = true;
                }
            }
            return result;
        }

        #endregion
    }
}
