using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using static DarkThemeManager.DarkThemeManager;

namespace DarkThemeManager
{
    public class DarkThemeManager
    {
        private int titleBarHeight = 0;
        private int titleBarWidth = 0;
        private int captionButtonX = 0;
        private int captionButtonY = 0;
        public Size borderSize = SystemInformation.FrameBorderSize;
        public Size buttonSize = SystemInformation.CaptionButtonSize;
        //private bool isShifted = false;

        private const int WM_SYSCOMMAND = 0x112;
        private const int SC_DRAGMOVE = 0xF012;

        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        public enum Theme
        {
            Light,
            Dark
        }

        public void ApplyTitleBarTheme(Panel titleBarPanel, Theme theme)
        {
            Form form = (Form)titleBarPanel.Parent!;
            form.FormBorderStyle = FormBorderStyle.None;

            titleBarHeight = titleBarPanel.Height;
            titleBarWidth = titleBarPanel.Width;
            titleBarPanel.Text = "titleBarPanel";
            titleBarPanel.BackColor = theme == Theme.Light ? SystemColors.Control : MyColor.BackColor;

            titleBarPanel.MouseDown += TitleBarPanel_MouseDown;
            titleBarPanel.MouseMove += TitleBarPanel_MouseMove;
            titleBarPanel.MouseUp += TitleBarPanel_MouseUp;

            captionButtonX = titleBarWidth - buttonSize.Width * 3 - borderSize.Width;
            captionButtonY = (titleBarHeight - buttonSize.Height) / 2;

            Label label = new Label()
            {
                Text = "DarkThemeManager",
                Location = new Point(borderSize.Width, captionButtonY),
            };
            using (Graphics g = label.CreateGraphics())
            {
                SizeF stringSize = g.MeasureString(label.Text, label.Font);
                label.Width = (int)Math.Ceiling(stringSize.Width);
            }

            titleBarPanel.Controls.Add(label);

            CaptionButton buttonMinimize = new("0", theme)
            {
                Size = buttonSize,
                Location = new Point(captionButtonX, captionButtonY),
            };
            buttonMinimize.FlatAppearance.BorderColor = theme == Theme.Light ? SystemColors.ControlDark : MyColor.BorderColor;

            captionButtonX += buttonSize.Width;
            CaptionButton buttonMaximize = new("1", theme)
            {
                Size = buttonSize,
                Location = new Point(captionButtonX, captionButtonY),
            };
            buttonMaximize.FlatAppearance.BorderColor = theme == Theme.Light ? SystemColors.ControlDark : MyColor.BorderColor;

            captionButtonX += buttonSize.Width;
            CaptionButton buttonClose = new("r", theme)
            {
                Size = buttonSize,
                Location = new Point(captionButtonX, captionButtonY),
                BackColor = Color.Red,
                ForeColor = SystemColors.ControlLightLight,
            };
            buttonClose.FlatAppearance.BorderColor = theme == Theme.Light ? SystemColors.ControlDark : MyColor.BorderColor;

            buttonMinimize.MouseDown += ButtonMinimize_MouseDown;
            buttonMaximize.MouseDown += ButtonMaximize_MouseDown;
            buttonClose.MouseDown += ButtonClose_MouseDown;

            titleBarPanel.Controls.Add(buttonMinimize);
            titleBarPanel.Controls.Add(buttonMaximize);
            titleBarPanel.Controls.Add(buttonClose);
        }

        private void TitleBarPanel_MouseDown(object? sender, MouseEventArgs e)
        {
            Panel titleBarPanel = (Panel)sender!;
            Form form = (Form)titleBarPanel.Parent!;

            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(form.Handle, WM_SYSCOMMAND, SC_DRAGMOVE, 0);

                titleBarPanel.Width = form.ClientSize.Width;
                foreach (Control control in titleBarPanel.Controls)
                {
                    if (control is CaptionButton)
                    {
                        CaptionButton button = (CaptionButton)control;
                        switch (button.Text)
                        {
                            case "0":
                                button.Location = new Point(titleBarPanel.Width - buttonSize.Width * 3 - borderSize.Width, captionButtonY);
                                break;
                            case "1":
                                button.Text = form.WindowState == FormWindowState.Maximized ? "2" : "1";
                                button.Location = new Point(titleBarPanel.Width - buttonSize.Width * 2 - borderSize.Width, captionButtonY);
                                break;
                            case "2":
                                button.Text = form.WindowState == FormWindowState.Maximized ? "2" : "1";
                                button.Location = new Point(titleBarPanel.Width - buttonSize.Width * 2 - borderSize.Width, captionButtonY);
                                break;
                            case "r":
                                button.Location = new Point(titleBarPanel.Width - buttonSize.Width * 1 - borderSize.Width, captionButtonY);
                                break;
                        }
                    }
                }
            }
        }

        private void ButtonMaximize_MouseDown(object? sender, MouseEventArgs e)
        {
            Panel titleBarPanel = (Panel)((CaptionButton)sender!).Parent!;
            Form form = (Form)titleBarPanel.Parent!;

            form.WindowState = form.WindowState == FormWindowState.Maximized ? FormWindowState.Normal : FormWindowState.Maximized;
            titleBarPanel.Width = form.ClientSize.Width;

            foreach (CaptionButton button in titleBarPanel.Controls)
            {
                switch (button.Text)
                {
                    case "0":
                        button.Location = new Point(titleBarPanel.Width - buttonSize.Width * 3 - borderSize.Width, captionButtonY);
                        break;
                    case "1":
                        button.Text = form.WindowState == FormWindowState.Maximized ? "2" : "1";
                        button.Location = new Point(titleBarPanel.Width - buttonSize.Width * 2 - borderSize.Width, captionButtonY);
                        break;
                    case "2":
                        button.Text = form.WindowState == FormWindowState.Maximized ? "2" : "1";
                        button.Location = new Point(titleBarPanel.Width - buttonSize.Width * 2 - borderSize.Width, captionButtonY);
                        break;
                    case "r":
                        button.Location = new Point(titleBarPanel.Width - buttonSize.Width * 1 - borderSize.Width, captionButtonY);
                        break;
                }
            }
        }

        private void TitleBarPanel_MouseMove(object? sender, MouseEventArgs e) { }
        private void TitleBarPanel_MouseUp(object? sender, MouseEventArgs e) { }
        private void ButtonClose_MouseDown(object? sender, MouseEventArgs e) => ((Form)((CaptionButton)sender!).Parent!.Parent!).Close();
        private void ButtonMinimize_MouseDown(object? sender, MouseEventArgs e) => ((Form)((Button)sender!).Parent!.Parent!).WindowState = FormWindowState.Minimized;

        public void ApplyTheme(Form form, Theme theme)
        {
            CheckIfControlHasContextMenu(form, theme);
            form.BackColor = theme == Theme.Light ? SystemColors.Control : MyColor.BackColor;
            form.ForeColor = theme == Theme.Light ? SystemColors.ControlText : MyColor.TextColor;

            foreach (Control control in form.Controls)
            {
                ApplyControlTheme(control, theme);
            }
        }

        private void ApplyControlTheme(Control ctrl, Theme theme)
        {
            if (ctrl.GetType().GetProperty("BackColor") != null)
            {
                ctrl.BackColor = theme == Theme.Light ? SystemColors.ControlLight : MyColor.MouseLeaveColor;
            }

            if (ctrl.GetType().GetProperty("ForeColor") != null)
            {
                ctrl.ForeColor = theme == Theme.Light ? SystemColors.ControlText : MyColor.TextColor;
            }

            switch (ctrl)
            {
                case Button:
                    ApplyControlTheme((Button)ctrl, theme);
                    break;
                case CheckBox:
                    ApplyControlTheme((CheckBox)ctrl, theme);
                    break;
                case ComboBox:
                    ApplyControlTheme((ComboBox)ctrl, theme);
                    break;
                case ContextMenuStrip:
                    ApplyControlTheme((ContextMenuStrip)ctrl, theme);
                    break;
                case DataGridView:
                    ApplyControlTheme((DataGridView)ctrl, theme);
                    break;
                case DateTimePicker:
                    ApplyControlTheme((DateTimePicker)ctrl, theme);
                    break;
                case FlowLayoutPanel:
                    ApplyControlTheme((FlowLayoutPanel)ctrl, theme);
                    break;
                case GroupBox:
                    ApplyControlTheme((GroupBox)ctrl, theme);
                    break;
                case Label:
                    ApplyControlTheme((Label)ctrl, theme);
                    break;
                case ListView:
                    ApplyControlTheme((ListView)ctrl, theme);
                    break;
                case MenuStrip:
                    ApplyControlTheme((MenuStrip)ctrl, theme);
                    break;
                case NumericUpDown:
                    ApplyControlTheme((NumericUpDown)ctrl, theme);
                    break;
                case Panel:
                    ApplyControlTheme((Panel)ctrl, theme);
                    break;
                case PictureBox:
                    ApplyControlTheme((PictureBox)ctrl, theme);
                    break;
                case ProgressBar:
                    ApplyControlTheme((ProgressBar)ctrl, theme);
                    break;
                case PropertyGrid:
                    ApplyControlTheme((PropertyGrid)ctrl, theme);
                    break;
                case RadioButton:
                    ApplyControlTheme((RadioButton)ctrl, theme);
                    break;
                case RichTextBox:
                    ApplyControlTheme((RichTextBox)ctrl, theme);
                    break;
                case TabControl:
                    ApplyControlTheme((TabControl)ctrl, theme);
                    break;
                case TextBox:
                    ApplyControlTheme((TextBox)ctrl, theme);
                    break;
                case ToolStrip:
                    ApplyControlTheme((ToolStrip)ctrl, theme);
                    break;
                case TrackBar:
                    ApplyControlTheme((TrackBar)ctrl, theme);
                    break;
                case TreeView:
                    ApplyControlTheme((TreeView)ctrl, theme);
                    break;
                default:
                    break;
            }

            foreach (Control child in ctrl.Controls)
            {
                ApplyControlTheme(child, theme);
            }
        }

        private void ApplyControlTheme(Button ctrl, Theme theme)
        {
            CheckIfControlHasContextMenu(ctrl, theme);
            ctrl.FlatStyle = theme == Theme.Light ? FlatStyle.Standard : FlatStyle.Flat;
            ctrl.BackColor = theme == Theme.Light ? SystemColors.ControlLightLight : MyColor.MouseLeaveColor;

            if (ctrl is CaptionButton)
            {
                ApplyControlTheme((CaptionButton)ctrl, theme);
            }
        }
        private void ApplyControlTheme(CaptionButton ctrl, Theme theme)
        {
            if (ctrl.Text == "r" && ctrl.Parent!.Text == "titleBarPanel")
            {
                ctrl.BackColor = Color.Red;
                ctrl.ForeColor = SystemColors.ControlLightLight;
            }
        }
        private void ApplyControlTheme(CheckBox ctrl, Theme theme) 
        {
            CheckIfControlHasContextMenu(ctrl, theme);
            ctrl.BackColor = theme == Theme.Light ? SystemColors.Control : MyColor.BackColor;
        }
        private void ApplyControlTheme(ComboBox ctrl, Theme theme) { CheckIfControlHasContextMenu(ctrl, theme); }
        private void ApplyControlTheme(ContextMenuStrip ctrl, Theme theme)
        {
            ctrl.Renderer = theme == Theme.Light ? new ToolStripProfessionalRenderer() : new MyRenderer();
        }
        private void ApplyControlTheme(DataGridView ctrl, Theme theme) 
        {
            CheckIfControlHasContextMenu(ctrl, theme);

            ctrl.CellPainting += (sender, e) => DataGridView_CellPainting(sender, e, theme);

            ctrl.BackgroundColor = theme == Theme.Light ? SystemColors.Control : MyColor.BackColor;
            ctrl.ColumnHeadersDefaultCellStyle.BackColor = theme == Theme.Light ? SystemColors.ControlLightLight : MyColor.MouseLeaveColor;
            ctrl.ColumnHeadersDefaultCellStyle.ForeColor = theme == Theme.Light ? SystemColors.ControlText : MyColor.TextColor;
            ctrl.EnableHeadersVisualStyles = false;

            // Set default cell styles
            ctrl.DefaultCellStyle.BackColor = theme == Theme.Light ? SystemColors.ControlLight : MyColor.MouseLeaveColor;
            ctrl.DefaultCellStyle.ForeColor = theme == Theme.Light ? SystemColors.ControlText : MyColor.TextColor;
            //ctrl.AlternatingRowsDefaultCellStyle.BackColor = theme == Theme.Light ? SystemColors.Control : MyColor.BackColor;
            ctrl.DefaultCellStyle.SelectionBackColor = theme == Theme.Light ? SystemColors.Control : MyColor.MouseHoverColor;
            ctrl.DefaultCellStyle.SelectionForeColor = theme == Theme.Light ? SystemColors.ControlText : MyColor.TextColor;
        }

        private void DataGridView_CellPainting(object? sender, DataGridViewCellPaintingEventArgs e, Theme theme)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                // Custom grid line color
                Color gridColor = theme == Theme.Light ? SystemColors.Control : MyColor.TextColor;

                e.Paint(e.CellBounds, DataGridViewPaintParts.All & ~DataGridViewPaintParts.Border);
                ControlPaint.DrawBorder(e.Graphics!, e.CellBounds, gridColor, ButtonBorderStyle.Solid);
                e.Handled = true;
            }
        }

        private void ApplyControlTheme(DateTimePicker ctrl, Theme theme) { }
        private void ApplyControlTheme(FlowLayoutPanel ctrl, Theme theme) { }
        private void ApplyControlTheme(GroupBox ctrl, Theme theme) 
        {
            ctrl.BackColor = theme == Theme.Light ? SystemColors.Control : MyColor.BackColor;
        }
        private void ApplyControlTheme(Label ctrl, Theme theme) 
        { 
            CheckIfControlHasContextMenu(ctrl, theme);
            ctrl.BackColor = theme == Theme.Light ? SystemColors.Control : MyColor.BackColor;
        }
        private void ApplyControlTheme(ListBox ctrl, Theme theme) { CheckIfControlHasContextMenu(ctrl, theme); }
        private void ApplyControlTheme(ListView ctrl, Theme theme) 
        { 
            CheckIfControlHasContextMenu(ctrl, theme);
            ctrl.OwnerDraw = true;
            ctrl.DrawColumnHeader += (sender, e) => ListView_DrawColumnHeader(sender, e, theme);
            ctrl.DrawItem += (sender, e) => ListView_DrawItem(sender, e, theme);
            ctrl.DrawSubItem += (sender, e) => ListView_DrawSubItem(sender, e, theme);
        }

        private void ListView_DrawColumnHeader(object? sender, DrawListViewColumnHeaderEventArgs e, Theme theme)
        {
            Color color;

            // Set custom background color for the header
            color = theme == Theme.Light ? SystemColors.ControlLightLight : MyColor.MouseLeaveColor;
            e.Graphics.FillRectangle(new SolidBrush(color), e.Bounds);

            // Draw the header text
            color = theme == Theme.Light ? SystemColors.ControlText : MyColor.TextColor;
            TextRenderer.DrawText(e.Graphics, e.Header!.Text, e.Font, e.Bounds, color);

            color = theme == Theme.Light ? SystemColors.Control : MyColor.TextColor;
            ControlPaint.DrawBorder(e.Graphics, e.Bounds, color, ButtonBorderStyle.Solid);
        }

        private void ListView_DrawItem(object? sender, DrawListViewItemEventArgs e, Theme theme)
        {
            e.DrawDefault = true;
        }

        private void ListView_DrawSubItem(object? sender, DrawListViewSubItemEventArgs e, Theme theme)
        {
            e.DrawDefault = true;
        }

        private void ApplyControlTheme(MenuStrip ctrl, Theme theme) 
        {
            ctrl.BackColor = theme == Theme.Light ? SystemColors.ControlLightLight : MyColor.MouseLeaveColor;
            //ctrl.ForeColor = theme == Theme.Light ? SystemColors.ControlText : MyColor.TextColor;
            ctrl.Renderer = theme == Theme.Light ? new ToolStripProfessionalRenderer() : new MyRenderer();

            foreach (ToolStripMenuItem item in ctrl.Items)
            {
                ApplyControlTheme(item, theme);
            }
        }
        private void ApplyControlTheme(ToolStripMenuItem ctrl, Theme theme)
        {
            //ctrl.BackColor = theme == Theme.Light ? SystemColors.ControlLightLight : MyColor.MouseLeaveColor;
            ctrl.ForeColor = theme == Theme.Light ? SystemColors.ControlText : MyColor.TextColor;

            foreach (object item in ctrl.DropDownItems)
            {
                if (item is ToolStripMenuItem)
                {
                    ApplyControlTheme((ToolStripMenuItem)item, theme);
                }
                else if (item is ToolStripComboBox)
                {
                    ApplyControlTheme((ToolStripComboBox)item, theme);
                }
            }
        }
        private void ApplyControlTheme(ToolStripComboBox ctrl, Theme theme) 
        {
            ctrl.BackColor = theme == Theme.Light ? SystemColors.ControlLightLight : MyColor.MouseLeaveColor;
            ctrl.ForeColor = theme == Theme.Light ? SystemColors.ControlText : MyColor.TextColor;
        }

        private void ApplyControlTheme(NumericUpDown ctrl, Theme theme) { }
        private void ApplyControlTheme(Panel ctrl, Theme theme) 
        {
            CheckIfControlHasContextMenu(ctrl, theme);
            ctrl.BackColor = theme == Theme.Light 
                ? (((Panel)ctrl).Text == "titleBarPanel" ? SystemColors.Control : SystemColors.ControlLight) 
                : (((Panel)ctrl).Text == "titleBarPanel" ? MyColor.BackColor : MyColor.MouseLeaveColor);
        }
        private void ApplyControlTheme(PictureBox ctrl, Theme theme) { CheckIfControlHasContextMenu(ctrl, theme); }
        private void ApplyControlTheme(ProgressBar ctrl, Theme theme) 
        { 
            CheckIfControlHasContextMenu(ctrl, theme);
        }
        private void ApplyControlTheme(PropertyGrid ctrl, Theme theme) { }
        private void ApplyControlTheme(RadioButton ctrl, Theme theme) 
        { 
            CheckIfControlHasContextMenu(ctrl, theme);
            ctrl.BackColor = theme == Theme.Light ? SystemColors.Control : MyColor.BackColor;
        }
        private void ApplyControlTheme(RichTextBox ctrl, Theme theme) { CheckIfControlHasContextMenu(ctrl, theme); }
        private void ApplyControlTheme(TabControl ctrl, Theme theme)
        {
            ctrl.DrawMode = TabDrawMode.OwnerDrawFixed;
            ctrl.DrawItem += (sender, e) => TabControl_DrawItem(sender, e, theme);
            if (ctrl.SelectedTab != null)
            {
                ctrl.SelectedTab!.BackColor = theme == Theme.Light ? SystemColors.Control : MyColor.MouseLeaveColor;
            }
        }

        private void TabControl_DrawItem(object? sender, DrawItemEventArgs e, Theme theme)
        {
            TabControl tabControl = (TabControl)sender!;
            TabPage _tabPage;
            Graphics g = e.Graphics;
            Color color;
            Brush _backBrush;
            Brush _tabBrush;

            // fill in the whole rectangle
            color = theme == Theme.Light ? SystemColors.Control : MyColor.BackColor;
            _backBrush = new SolidBrush(color);
            g.FillRectangle(_backBrush, tabControl.ClientRectangle);

            // draw the tabs
            if (tabControl.TabPages.Count > 0)
            {
                for (int i = 0; i < tabControl.TabPages.Count; i++)
                {
                    // Get the item from the collection.
                    _tabPage = tabControl.TabPages[i];
                    _tabPage.BorderStyle = BorderStyle.FixedSingle;

                    // Get the real bounds for the tab rectangle.
                    Rectangle _tabBounds = tabControl.GetTabRect(i);

                    // Get Tab's text color & back color
                    if (tabControl.SelectedTab == _tabPage)
                    {
                        color = theme == Theme.Light ? SystemColors.Control : MyColor.MouseHoverColor;
                    }
                    else
                    {
                        color = theme == Theme.Light ? SystemColors.ControlLight : MyColor.MouseLeaveColor;
                    }

                    // Fill Tab's back color with _tabBrush.
                    _tabBrush = new SolidBrush(color);
                    g.FillRectangle(_tabBrush, _tabBounds);

                    // Use our own font.
                    string _tabText = _tabPage.Text;
                    color = theme == Theme.Light ? SystemColors.ControlText : MyColor.TextColor;
                    Brush _textBrush = new SolidBrush(color);
                    Font _tabFont = _tabPage.Font;

                    // Draw string. Center the text.
                    StringFormat _stringFlags = new()
                    {
                        Alignment = StringAlignment.Near,
                        LineAlignment = StringAlignment.Center
                    };
                    g.DrawString(_tabText, _tabFont, _textBrush, _tabBounds, new StringFormat(_stringFlags));

                    color = theme == Theme.Light ? SystemColors.Control : MyColor.BackColor;
                    ControlPaint.DrawBorder(g, _tabBounds, color, ButtonBorderStyle.Solid);
                }
            }
        }

        private void ApplyControlTheme(TextBox ctrl, Theme theme) { CheckIfControlHasContextMenu(ctrl, theme); }
        private void ApplyControlTheme(ToolStrip ctrl, Theme theme) { CheckIfControlHasContextMenu(ctrl, theme); }
        private void ApplyControlTheme(TrackBar ctrl, Theme theme) 
        {
            ctrl.BackColor = theme == Theme.Light ? SystemColors.Control : MyColor.BackColor;
        }
        private void ApplyControlTheme(TreeView ctrl, Theme theme) { CheckIfControlHasContextMenu(ctrl, theme); }
        private void CheckIfControlHasContextMenu(Control ctrl, Theme theme)
        {
            if (ctrl.ContextMenuStrip != null)
            {
                ApplyControlTheme(ctrl.ContextMenuStrip, theme);
            }
        }
    }

    public class CaptionButton : Button
    {
        public CaptionButton(string text, Theme theme)
        {
            Font = new Font("Webdings", 9f, FontStyle.Bold);
            Text = text;
            TextAlign = ContentAlignment.MiddleCenter;
            FlatStyle = FlatStyle.Flat;
            BackColor = theme == Theme.Light ? SystemColors.Control : MyColor.MouseLeaveColor;
            ForeColor = theme == Theme.Light ? SystemColors.ControlText : MyColor.TextColor;
        }
    }

    public class MyColor
    {
        // define colors to used in MyButton control.
        public static Color BackColor { get; set; } = Color.FromArgb(31, 31, 31);
        public static Color DisabledColor { get; set; } = Color.FromArgb(46, 46, 46);
        public static Color TextColor { get; set; } = Color.FromArgb(219, 219, 219);
        public static Color BorderColor { get; set; } = Color.FromArgb(62, 62, 62);
        public static Color MouseLeaveColor { get; set; } = Color.FromArgb(56, 56, 56);
        public static Color MouseHoverColor { get; set; } = Color.FromArgb(88, 88, 88);
        public static Color PurpleColor { get; set; } = Color.FromArgb(109, 92, 221);
        public static Color GreenColor { get; set; } = Color.FromArgb(138, 226, 138);
        public static Color SkyBlueColor { get; set; } = Color.FromArgb(96, 175, 255);
        public static Color BrownColor { get; set; } = Color.FromArgb(67, 53, 25);
        public static Color ErrorColor { get; set; } = Color.FromArgb(214, 157, 133);
        public static Color NormalColor { get; set; } = Color.FromArgb(86, 156, 214);
    }

    public class MyRenderer : ToolStripProfessionalRenderer
    {
        public MyRenderer() : base(new MyDarkColorTable()) { }

        protected override void OnRenderMenuItemBackground(ToolStripItemRenderEventArgs e)
        {
            if (e.Item.Selected)
            {
                Rectangle rc = new Rectangle(Point.Empty, e.Item.Size);
                e.Graphics.FillRectangle(new SolidBrush(MyColor.MouseHoverColor), rc);
            }
            else
            {
                base.OnRenderMenuItemBackground(e);
            }
        }

        protected override void OnRenderItemText(ToolStripItemTextRenderEventArgs e)
        {
            e.TextColor = MyColor.TextColor;
            base.OnRenderItemText(e);
        }
    }

    public class MyDarkColorTable : ProfessionalColorTable
    {
        /// <summary> Gets the solid background color of the System.Windows.Forms.ToolStripDropDown. </summary>
        public override Color ToolStripDropDownBackground => Color.FromArgb(31, 31, 31);
        /// <summary> Gets the starting color of the gradient used when the System.Windows.Forms.ToolStripMenuItem is selected. </summary>
        public override Color MenuItemSelectedGradientBegin => Color.FromArgb(46, 46, 46);
        /// <summary> Gets the end color of the gradient used when the System.Windows.Forms.ToolStripMenuItem is selected. </summary>
        public override Color MenuItemSelectedGradientEnd => Color.FromArgb(46, 46, 46);
        /// <summary> Gets the starting color of the gradient used in the image margin of a System.Windows.Forms.ToolStripDropDownMenu. </summary>
        public override Color ImageMarginGradientBegin => Color.FromArgb(51, 51, 51);
        /// <summary> Gets the middle color of the gradient used in the image margin of a System.Windows.Forms.ToolStripDropDownMenu. </summary>
        public override Color ImageMarginGradientMiddle => Color.FromArgb(51, 51, 51);
        /// <summary> Gets the end color of the gradient used in the image margin of a System.Windows.Forms.ToolStripDropDownMenu. </summary>
        public override Color ImageMarginGradientEnd => Color.FromArgb(51, 51, 51);
        /// <summary> Gets the solid selected color of the  System.Windows.Forms.ToolStripMenuItem. </summary>
        public override Color MenuItemSelected => Color.FromArgb(56, 56, 56);
        /// <summary> Gets the color that is the border color to use on a System.Windows.Forms.MenuStrip. </summary>
        public override Color MenuBorder => Color.FromArgb(62, 62, 62);
        /// <summary> Gets the starting color of the gradient used when a top-level System.Windows.Forms.ToolStripMenuItem is pressed. </summary>
        public override Color MenuItemPressedGradientBegin => Color.FromArgb(66, 66, 66);
        /// <summary> Gets the end color of the gradient used when a top-level System.Windows.Forms.ToolStripMenuItem is pressed. </summary>
        public override Color MenuItemPressedGradientEnd => Color.FromArgb(66, 66, 66);
        /// <summary> Gets the color to use to for shadow effects on the System.Windows.Forms.ToolStripSeparator. </summary>
        public override Color SeparatorDark => Color.FromArgb(88, 88, 88);
        /// <summary> Gets the border color to use with a System.Windows.Forms.ToolStripMenuItem. </summary>
        public override Color MenuItemBorder => Color.FromArgb(112, 112, 112);
    }
}
