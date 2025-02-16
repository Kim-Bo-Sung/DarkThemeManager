using System.Windows.Forms;
using static DarkThemeManager.DarkThemeManager;

namespace DarkThemeManager
{
    public partial class MainForm : Form
    {
        DarkThemeManager currentTheme = new();
        Theme theme;
        private System.Windows.Forms.Timer? timer;

        public MainForm()
        {
            InitializeComponent();
            InitializeContextMenu();
            InitializeLinkLabel();
            InitializeProgressBar();
            InitializeTimer();
            InitializeTreeView();
            InitializePictureBox();
            InitializePropertyGrid();
            InitializeTrackBar();
            InitializeTableLayoutPanel();
            InitializeFlowLayoutPanel();
            InitializeDataGridView();
            InitializeRadioButton();

            currentTheme.ApplyTheme(this, theme);
        }

        private void InitializeRadioButton()
        {
            radioButton1.Checked = true;
            theme = Theme.Light;
            currentTheme.ApplyTitleBarTheme(titleBarPanel, theme);
        }

        private void InitializeDataGridView()
        {
            dataGridView1.RowHeadersVisible = false;

            // Add rows
            string[] row1 = new string[] { "Row1-Cell1", "Row1-Cell2" };
            string[] row2 = new string[] { "Row2-Cell1", "Row2-Cell2" };
            string[] row3 = new string[] { "Row3-Cell1", "Row3-Cell2" };
            dataGridView1.Rows.Add(row1);
            dataGridView1.Rows.Add(row2);
            dataGridView1.Rows.Add(row3);
        }

        private void InitializeFlowLayoutPanel()
        {
            for (int i = 0; i < 5; i++)
            {
                Button btn = new Button();
                btn.Size = new Size(112, 34);
                btn.Text = "flpButton" + (i + 1).ToString();
                flowLayoutPanel1.Controls.Add(btn);
            }
        }

        private void InitializeTableLayoutPanel()
        {
            for (int i = 0; i < tableLayoutPanel1.ColumnCount; i++)
            {
                for (int j = 0; j < tableLayoutPanel1.RowCount; j++)
                {
                    Panel panel = new Panel()
                    {
                        Dock = DockStyle.Fill,
                    };

                    int r = new Random().Next(256);
                    int g = new Random().Next(256);
                    int b = new Random().Next(256);
                    Color color = Color.FromArgb(r, g, b);
                    panel.Paint += (sender, e) =>
                    {
                        e.Graphics.FillRectangle(new SolidBrush(color), panel.ClientRectangle);
                    };
                    tableLayoutPanel1.Controls.Add(panel, i, j);
                }
            }
        }

        private void InitializeTrackBar()
        {
            trackBar1.Maximum = 10;
            trackBar1.Value = 0;
        }

        private void InitializePropertyGrid()
        {
            propertyGrid1.Font = new Font("¸¼Àº °íµñ", 8);
            propertyGrid1.SelectedObject = this;
        }

        private void InitializePictureBox()
        {
            toolTip1.SetToolTip(pictureBox1, "Jodie Comer, most beautiful woman in the world 2025!");
        }

        private void InitializeContextMenu()
        {
            ContextMenuStrip contextMenuStrip = new ContextMenuStrip();
            contextMenuStrip.Items.Add("Exit");
            contextMenuStrip.ItemClicked += ContextMenuStrip_ItemClicked;
            dataGridView1.ContextMenuStrip = contextMenuStrip;
        }

        private void InitializeLinkLabel()
        {
            linkLabel1.LinkBehavior = LinkBehavior.HoverUnderline;
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
        }

        private void InitializeProgressBar()
        {
            progressBar1.Value = 0;
            progressBar1.Maximum = 100;
        }

        private void InitializeTimer()
        {
            if (timer == null)
            {
                timer = new System.Windows.Forms.Timer
                {
                    Interval = 500,
                };
                timer.Tick += Timer_Tick;
            }

            timer.Start();
        }

        private void Timer_Tick(object? sender, EventArgs e)
        {
            if (progressBar1.Value < progressBar1.Maximum)
            {
                progressBar1.PerformStep();
                trackBar1.Value += 1;
            }
            else
            {
                progressBar1.Value = 0;
                trackBar1.Value = 0;
                timer!.Stop();
                timer!.Dispose();
            }
        }

        private void InitializeTreeView()
        {
            treeView1.ExpandAll();
        }

        private void ContextMenuStrip_ItemClicked(object? sender, ToolStripItemClickedEventArgs e)
        {
            textBox1.Text = "Application exit.";
            maskedTextBox1.Text = "Application exit.";
            richTextBox1.AppendText("Application exit.\n");

            // Scroll to the last line
            richTextBox1.SelectionStart = richTextBox1.TextLength;
            richTextBox1.ScrollToCaret();

            if (timer != null)
            {
                timer.Stop();
                timer.Dispose();
            }
            Application.Exit();
        }

        private void toolStripComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string str = ((ToolStripComboBox)sender).SelectedIndex == 0 ? "Light" : "Dark";

            textBox1.Text = str + " Theme selected.";
            maskedTextBox1.Text = str + " Theme selected.";
            richTextBox1.AppendText(str + " Theme selected.\n");

            // Scroll to the last line
            richTextBox1.SelectionStart = richTextBox1.TextLength;
            richTextBox1.ScrollToCaret();

            theme = (Theme)((ToolStripComboBox)sender).SelectedIndex;
            currentTheme.ApplyTheme(this, theme);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string str = ((ComboBox)sender).SelectedItem!.ToString()!;

            textBox1.Text = str + " selected.";
            maskedTextBox1.Text = str + " selected.";
            richTextBox1.AppendText(str + " selected.\n");

            // Scroll to the last line
            richTextBox1.SelectionStart = richTextBox1.TextLength;
            richTextBox1.ScrollToCaret();
        }

        private void linkLabel1_LinkClicked(object? sender, LinkLabelLinkClickedEventArgs e)
        {
            textBox1.Text = linkLabel1.Text + " linked.";
            maskedTextBox1.Text = linkLabel1.Text + " linked.";
            richTextBox1.AppendText(linkLabel1.Text + " linked.\n");

            // Scroll to the last line
            richTextBox1.SelectionStart = richTextBox1.TextLength;
            richTextBox1.ScrollToCaret();

            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
            {
                FileName = "https://github.com/Kim-Bo-Sung",
                UseShellExecute = true
            });
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = button1.Text + " clicked.";
            maskedTextBox1.Text = button1.Text + " clicked.";
            richTextBox1.AppendText(button1.Text + " clicked.\n");

            // Scroll to the last line
            richTextBox1.SelectionStart = richTextBox1.TextLength;
            richTextBox1.ScrollToCaret();

            if (button1.Text == "Check all")
            {
                checkBox1.Checked = true;
                checkBox2.Checked = true;
                checkBox3.Checked = true;
                button1.Text = "Un-check all";
            }
            else
            {
                checkBox1.Checked = false;
                checkBox2.Checked = false;
                checkBox3.Checked = false;
                button1.Text = "Check all";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = button2.Text + " clicked.";
            maskedTextBox1.Text = button2.Text + " clicked.";
            richTextBox1.AppendText(button2.Text + " clicked.\n");

            // Scroll to the last line
            richTextBox1.SelectionStart = richTextBox1.TextLength;
            richTextBox1.ScrollToCaret();

            panel1.Controls.Clear();
            flowLayoutPanel1.Controls.Clear();
            listView1.Controls.Clear();
            dataGridView1.Controls.Clear();
            treeView1.Controls.Clear();
            listView1.Controls.Clear();
            checkedListBox1.Controls.Clear();
            richTextBox1.Controls.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = button3.Text + " clicked.";
            maskedTextBox1.Text = button3.Text + " clicked.";
            richTextBox1.AppendText(button3.Text + " clicked.\n");

            // Scroll to the last line
            richTextBox1.SelectionStart = richTextBox1.TextLength;
            richTextBox1.ScrollToCaret();

            if (timer != null) { InitializeTimer(); }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = button4.Text + " clicked.";
            maskedTextBox1.Text = button4.Text + " clicked.";
            richTextBox1.AppendText(button4.Text + " clicked.\n");

            // Scroll to the last line
            richTextBox1.SelectionStart = richTextBox1.TextLength;
            richTextBox1.ScrollToCaret();

            InitializeTableLayoutPanel();
        }

        private void informationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Text = "Information clicked.";
            maskedTextBox1.Text = "Information clicked.";
            richTextBox1.AppendText("Information clicked.\n");

            // Scroll to the last line
            richTextBox1.SelectionStart = richTextBox1.TextLength;
            richTextBox1.ScrollToCaret();

            MessageBox.Show("DarkThemeManager, ver. 0.0.8\n(producted by bskim)", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "Application exit.";
            maskedTextBox1.Text = "Application exit.";
            richTextBox1.AppendText("Application exit.\n");

            // Scroll to the last line
            richTextBox1.SelectionStart = richTextBox1.TextLength;
            richTextBox1.ScrollToCaret();

            if (timer != null)
            {
                timer.Stop();
                timer.Dispose();
            }
            Application.Exit();
        }

        private void domainUpDown1_SelectedItemChanged(object? sender, EventArgs e)
        {
            DomainUpDown domainUpDown = (DomainUpDown)sender!;
            Label foundLabel = FindLabelInPanel(titleBarPanel, "DarkThemeManager");

            string str = ((DomainUpDown)sender!).SelectedItem!.ToString()!;

            textBox1.Text = str + " selected.";
            maskedTextBox1.Text = str + " selected.";
            richTextBox1.AppendText(str + " selected.\n");

            // Scroll to the last line
            richTextBox1.SelectionStart = richTextBox1.TextLength;
            richTextBox1.ScrollToCaret();

            switch (domainUpDown.SelectedIndex)
            {
                case 0:
                    titleBarPanel.BackColor = theme == Theme.Light ? SystemColors.Control : MyColor.BackColor;
                    titleBarPanel.ForeColor = theme == Theme.Light ? SystemColors.ControlText : MyColor.TextColor;
                    break;
                case 1:
                    titleBarPanel.BackColor = Color.DarkBlue;
                    titleBarPanel.ForeColor = MyColor.TextColor;
                    break;
                case 2:
                    titleBarPanel.BackColor = Color.Orange;
                    titleBarPanel.ForeColor = SystemColors.ControlText;
                    break;
                case 3:
                    titleBarPanel.BackColor = Color.DarkGreen;
                    titleBarPanel.ForeColor = MyColor.TextColor;
                    break;
            }

            if (foundLabel != null)
            {
                foundLabel.BackColor = titleBarPanel.BackColor;
                foundLabel.ForeColor = titleBarPanel.ForeColor;
            }
        }

        private Label FindLabelInPanel(Panel panel, string labelName)
        {
            foreach (Control control in panel.Controls)
            {
                if (control is Label label && label.Text == labelName)
                {
                    return label;
                }
            }
            return null!;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBox1.Text = checkBox1.Text + " checked.";
                maskedTextBox1.Text = checkBox1.Text + " checked.";
                richTextBox1.AppendText(checkBox1.Text + " checked.\n");
            }
            else
            {
                textBox1.Text = checkBox1.Text + " un-checked.";
                maskedTextBox1.Text = checkBox1.Text + " un-checked.";
                richTextBox1.AppendText(checkBox1.Text + " un-checked.\n");
            }
            // Scroll to the last line
            richTextBox1.SelectionStart = richTextBox1.TextLength;
            richTextBox1.ScrollToCaret();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                textBox1.Text = checkBox2.Text + " checked.";
                maskedTextBox1.Text = checkBox2.Text + " checked.";
                richTextBox1.AppendText(checkBox2.Text + " checked.\n");
            }
            else
            {
                textBox1.Text = checkBox2.Text + " un-checked.";
                maskedTextBox1.Text = checkBox2.Text + " un-checked.";
                richTextBox1.AppendText(checkBox2.Text + " un-checked.\n");
            }
            // Scroll to the last line
            richTextBox1.SelectionStart = richTextBox1.TextLength;
            richTextBox1.ScrollToCaret();
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
            {
                textBox1.Text = checkBox3.Text + " checked.";
                maskedTextBox1.Text = checkBox3.Text + " checked.";
                richTextBox1.AppendText(checkBox3.Text + " checked.\n");
            }
            else
            {
                textBox1.Text = checkBox3.Text + " un-checked.";
                maskedTextBox1.Text = checkBox3.Text + " un-checked.";
                richTextBox1.AppendText(checkBox3.Text + " un-checked.\n");
            }
            // Scroll to the last line
            richTextBox1.SelectionStart = richTextBox1.TextLength;
            richTextBox1.ScrollToCaret();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                textBox1.Text = radioButton1.Text + " checked.";
                maskedTextBox1.Text = radioButton1.Text + " checked.";
                richTextBox1.AppendText(radioButton1.Text + " checked.\n");

                // Scroll to the last line
                richTextBox1.SelectionStart = richTextBox1.TextLength;
                richTextBox1.ScrollToCaret();
            }
            currentTheme.ApplyTheme(this, theme = Theme.Light);
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                textBox1.Text = radioButton2.Text + " checked.";
                maskedTextBox1.Text = radioButton2.Text + " checked.";
                richTextBox1.AppendText(radioButton2.Text + " checked.\n");

                // Scroll to the last line
                richTextBox1.SelectionStart = richTextBox1.TextLength;
                richTextBox1.ScrollToCaret();
            }
            currentTheme.ApplyTheme(this, theme = Theme.Dark);
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked)
            {
                textBox1.Text = radioButton3.Text + " checked.";
                maskedTextBox1.Text = radioButton3.Text + " checked.";
                richTextBox1.AppendText(radioButton3.Text + " checked.\n");

                // Scroll to the last line
                richTextBox1.SelectionStart = richTextBox1.TextLength;
                richTextBox1.ScrollToCaret();
            }
        }
    }
}
