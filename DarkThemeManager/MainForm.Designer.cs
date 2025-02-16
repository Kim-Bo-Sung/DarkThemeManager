namespace DarkThemeManager
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            ListViewItem listViewItem4 = new ListViewItem(new string[] { "listViewItem1", "ListViewSubItem1" }, -1);
            ListViewItem listViewItem5 = new ListViewItem(new string[] { "listViewItem2", "ListViewSubItem2" }, -1);
            ListViewItem listViewItem6 = new ListViewItem(new string[] { "listViewItem3", "ListViewSubItem3" }, -1);
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            TreeNode treeNode5 = new TreeNode("subNode1");
            TreeNode treeNode6 = new TreeNode("subNode2");
            TreeNode treeNode7 = new TreeNode("subNode3");
            TreeNode treeNode8 = new TreeNode("node0", new TreeNode[] { treeNode5, treeNode6, treeNode7 });
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem1 = new ToolStripMenuItem();
            themeToolStripMenuItem = new ToolStripMenuItem();
            toolStripComboBox1 = new ToolStripComboBox();
            helpToolStripMenuItem = new ToolStripMenuItem();
            informationToolStripMenuItem = new ToolStripMenuItem();
            checkBox1 = new CheckBox();
            checkBox2 = new CheckBox();
            checkBox3 = new CheckBox();
            comboBox1 = new ComboBox();
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            flowLayoutPanel1 = new FlowLayoutPanel();
            groupBox1 = new GroupBox();
            button4 = new Button();
            button2 = new Button();
            button3 = new Button();
            radioButton3 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            linkLabel1 = new LinkLabel();
            listBox1 = new ListBox();
            listView1 = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            numericUpDown1 = new NumericUpDown();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            progressBar1 = new ProgressBar();
            richTextBox1 = new RichTextBox();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            textBox1 = new TextBox();
            trackBar1 = new TrackBar();
            treeView1 = new TreeView();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            label15 = new Label();
            titleBarPanel = new Panel();
            panel3 = new Panel();
            checkedListBox1 = new CheckedListBox();
            label16 = new Label();
            dateTimePicker1 = new DateTimePicker();
            label17 = new Label();
            domainUpDown1 = new DomainUpDown();
            label18 = new Label();
            maskedTextBox1 = new MaskedTextBox();
            label20 = new Label();
            propertyGrid1 = new PropertyGrid();
            label19 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            label21 = new Label();
            label22 = new Label();
            toolTip1 = new ToolTip(components);
            label23 = new Label();
            linkLabel2 = new LinkLabel();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tabControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)trackBar1).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, themeToolStripMenuItem, helpToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1848, 33);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { exitToolStripMenuItem1 });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(55, 29);
            fileToolStripMenuItem.Text = "&File";
            // 
            // exitToolStripMenuItem1
            // 
            exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
            exitToolStripMenuItem1.Size = new Size(141, 34);
            exitToolStripMenuItem1.Text = "E&xit";
            exitToolStripMenuItem1.Click += exitToolStripMenuItem1_Click;
            // 
            // themeToolStripMenuItem
            // 
            themeToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { toolStripComboBox1 });
            themeToolStripMenuItem.Name = "themeToolStripMenuItem";
            themeToolStripMenuItem.Size = new Size(84, 29);
            themeToolStripMenuItem.Text = "Theme";
            // 
            // toolStripComboBox1
            // 
            toolStripComboBox1.Items.AddRange(new object[] { "Light", "Dark" });
            toolStripComboBox1.Name = "toolStripComboBox1";
            toolStripComboBox1.Size = new Size(173, 33);
            toolStripComboBox1.Text = "Select theme";
            toolStripComboBox1.SelectedIndexChanged += toolStripComboBox1_SelectedIndexChanged;
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { informationToolStripMenuItem });
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new Size(66, 29);
            helpToolStripMenuItem.Text = "&Help";
            // 
            // informationToolStripMenuItem
            // 
            informationToolStripMenuItem.Name = "informationToolStripMenuItem";
            informationToolStripMenuItem.Size = new Size(208, 34);
            informationToolStripMenuItem.Text = "&Information";
            informationToolStripMenuItem.Click += informationToolStripMenuItem_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(14, 30);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(125, 29);
            checkBox1.TabIndex = 4;
            checkBox1.Text = "checkBox1";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(14, 70);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(125, 29);
            checkBox2.TabIndex = 5;
            checkBox2.Text = "checkBox2";
            checkBox2.UseVisualStyleBackColor = true;
            checkBox2.CheckedChanged += checkBox2_CheckedChanged;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Location = new Point(14, 110);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(125, 29);
            checkBox3.TabIndex = 6;
            checkBox3.Text = "checkBox3";
            checkBox3.UseVisualStyleBackColor = true;
            checkBox3.CheckedChanged += checkBox3_CheckedChanged;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "comboBoxItem1", "comboBoxItem2", "comboBoxItem3" });
            comboBox1.Location = new Point(12, 113);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(360, 33);
            comboBox1.TabIndex = 7;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            dataGridView1.BackgroundColor = SystemColors.Control;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2 });
            dataGridView1.Location = new Point(1111, 443);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(360, 229);
            dataGridView1.TabIndex = 8;
            // 
            // Column1
            // 
            Column1.HeaderText = "Column1";
            Column1.MinimumWidth = 8;
            Column1.Name = "Column1";
            Column1.Width = 180;
            // 
            // Column2
            // 
            Column2.HeaderText = "Column2";
            Column2.MinimumWidth = 8;
            Column2.Name = "Column2";
            Column2.Width = 180;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            flowLayoutPanel1.Location = new Point(12, 443);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(360, 229);
            flowLayoutPanel1.TabIndex = 9;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            groupBox1.Controls.Add(button4);
            groupBox1.Controls.Add(checkBox1);
            groupBox1.Controls.Add(checkBox2);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(checkBox3);
            groupBox1.Controls.Add(radioButton3);
            groupBox1.Controls.Add(radioButton2);
            groupBox1.Controls.Add(radioButton1);
            groupBox1.Controls.Add(button1);
            groupBox1.Location = new Point(12, 183);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(360, 229);
            groupBox1.TabIndex = 10;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // button4
            // 
            button4.Location = new Point(124, 149);
            button4.Name = "button4";
            button4.Size = new Size(230, 34);
            button4.TabIndex = 29;
            button4.Text = "Change TLP's color";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button2
            // 
            button2.Location = new Point(6, 189);
            button2.Name = "button2";
            button2.Size = new Size(112, 34);
            button2.TabIndex = 27;
            button2.Text = "Clear all";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(124, 189);
            button3.Name = "button3";
            button3.Size = new Size(230, 34);
            button3.TabIndex = 28;
            button3.Text = "Show progressBar";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(173, 110);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(142, 29);
            radioButton3.TabIndex = 25;
            radioButton3.TabStop = true;
            radioButton3.Text = "radioButton3";
            radioButton3.UseVisualStyleBackColor = true;
            radioButton3.CheckedChanged += radioButton3_CheckedChanged;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(173, 69);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(136, 29);
            radioButton2.TabIndex = 24;
            radioButton2.TabStop = true;
            radioButton2.Text = "Dark Theme";
            radioButton2.UseVisualStyleBackColor = true;
            radioButton2.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(173, 29);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(139, 29);
            radioButton1.TabIndex = 23;
            radioButton1.TabStop = true;
            radioButton1.Text = "Light Theme";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // button1
            // 
            button1.Location = new Point(6, 149);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 26;
            button1.Text = "Check all";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Location = new Point(745, 941);
            label1.Name = "label1";
            label1.Size = new Size(108, 25);
            label1.TabIndex = 11;
            label1.Text = "ProgressBar";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label2.AutoSize = true;
            label2.Location = new Point(12, 941);
            label2.Name = "label2";
            label2.Size = new Size(76, 25);
            label2.TabIndex = 12;
            label2.Text = "TextBox";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label3.AutoSize = true;
            label3.Location = new Point(12, 675);
            label3.Name = "label3";
            label3.Size = new Size(86, 25);
            label3.TabIndex = 13;
            label3.Text = "TreeView";
            // 
            // linkLabel1
            // 
            linkLabel1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(158, 1010);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(278, 25);
            linkLabel1.TabIndex = 14;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "https://github.com/Kim-Bo-Sung";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // listBox1
            // 
            listBox1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 25;
            listBox1.Items.AddRange(new object[] { "listBoxItem1", "listBoxItem2", "listBoxItem3" });
            listBox1.Location = new Point(378, 703);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(360, 229);
            listBox1.TabIndex = 17;
            // 
            // listView1
            // 
            listView1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            listView1.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2 });
            listView1.GridLines = true;
            listView1.Items.AddRange(new ListViewItem[] { listViewItem4, listViewItem5, listViewItem6 });
            listView1.Location = new Point(744, 443);
            listView1.Name = "listView1";
            listView1.Size = new Size(360, 229);
            listView1.TabIndex = 18;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Width = 180;
            // 
            // columnHeader2
            // 
            columnHeader2.Width = 180;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(378, 113);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(360, 31);
            numericUpDown1.TabIndex = 19;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            panel1.Location = new Point(378, 183);
            panel1.Name = "panel1";
            panel1.Size = new Size(360, 229);
            panel1.TabIndex = 20;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(744, 183);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(360, 229);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 21;
            pictureBox1.TabStop = false;
            // 
            // progressBar1
            // 
            progressBar1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            progressBar1.Location = new Point(859, 941);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(612, 25);
            progressBar1.TabIndex = 22;
            // 
            // richTextBox1
            // 
            richTextBox1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            richTextBox1.Location = new Point(1111, 703);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(360, 229);
            richTextBox1.TabIndex = 29;
            richTextBox1.Text = "";
            // 
            // tabControl1
            // 
            tabControl1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(378, 443);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(360, 229);
            tabControl1.TabIndex = 30;
            // 
            // tabPage1
            // 
            tabPage1.Location = new Point(4, 34);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(352, 191);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "tabPage1";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 34);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(352, 191);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "tabPage2";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            textBox1.Location = new Point(158, 938);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(580, 31);
            textBox1.TabIndex = 31;
            // 
            // trackBar1
            // 
            trackBar1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            trackBar1.Location = new Point(859, 972);
            trackBar1.Name = "trackBar1";
            trackBar1.Size = new Size(612, 69);
            trackBar1.TabIndex = 32;
            // 
            // treeView1
            // 
            treeView1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            treeView1.Location = new Point(12, 703);
            treeView1.Name = "treeView1";
            treeNode5.Name = "subNode1";
            treeNode5.Text = "subNode1";
            treeNode6.Name = "subNode2";
            treeNode6.Text = "subNode2";
            treeNode7.Name = "subNode3";
            treeNode7.Text = "subNode3";
            treeNode8.Name = "node0";
            treeNode8.Text = "node0";
            treeView1.Nodes.AddRange(new TreeNode[] { treeNode8 });
            treeView1.Size = new Size(360, 229);
            treeView1.TabIndex = 33;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label4.AutoSize = true;
            label4.Location = new Point(378, 675);
            label4.Name = "label4";
            label4.Size = new Size(69, 25);
            label4.TabIndex = 34;
            label4.Text = "ListBox";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label5.AutoSize = true;
            label5.Location = new Point(745, 415);
            label5.Name = "label5";
            label5.Size = new Size(77, 25);
            label5.TabIndex = 35;
            label5.Text = "ListView";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label6.AutoSize = true;
            label6.Location = new Point(1111, 675);
            label6.Name = "label6";
            label6.Size = new Size(110, 25);
            label6.TabIndex = 36;
            label6.Text = "RichTextBox";
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label7.AutoSize = true;
            label7.Location = new Point(378, 155);
            label7.Name = "label7";
            label7.Size = new Size(55, 25);
            label7.TabIndex = 37;
            label7.Text = "Panel";
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label8.AutoSize = true;
            label8.Location = new Point(12, 415);
            label8.Name = "label8";
            label8.Size = new Size(146, 25);
            label8.TabIndex = 38;
            label8.Text = "FlowLayoutPanel";
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label9.AutoSize = true;
            label9.Location = new Point(744, 155);
            label9.Name = "label9";
            label9.Size = new Size(97, 25);
            label9.TabIndex = 39;
            label9.Text = "PictureBox";
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label10.AutoSize = true;
            label10.Location = new Point(1111, 415);
            label10.Name = "label10";
            label10.Size = new Size(113, 25);
            label10.TabIndex = 40;
            label10.Text = "DataGridBox";
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label11.AutoSize = true;
            label11.Location = new Point(378, 415);
            label11.Name = "label11";
            label11.Size = new Size(101, 25);
            label11.TabIndex = 41;
            label11.Text = "TabControl";
            // 
            // label12
            // 
            label12.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label12.AutoSize = true;
            label12.Location = new Point(745, 978);
            label12.Name = "label12";
            label12.Size = new Size(81, 25);
            label12.TabIndex = 42;
            label12.Text = "TrackBar";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(378, 85);
            label13.Name = "label13";
            label13.Size = new Size(152, 25);
            label13.TabIndex = 43;
            label13.Text = "NumericUpDown";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(12, 85);
            label14.Name = "label14";
            label14.Size = new Size(102, 25);
            label14.TabIndex = 44;
            label14.Text = "ComboBox";
            // 
            // label15
            // 
            label15.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label15.AutoSize = true;
            label15.Location = new Point(12, 1010);
            label15.Name = "label15";
            label15.Size = new Size(87, 25);
            label15.TabIndex = 45;
            label15.Text = "LinkLabel";
            // 
            // titleBarPanel
            // 
            titleBarPanel.Dock = DockStyle.Top;
            titleBarPanel.Location = new Point(0, 0);
            titleBarPanel.Name = "titleBarPanel";
            titleBarPanel.Size = new Size(1848, 46);
            titleBarPanel.TabIndex = 46;
            // 
            // panel3
            // 
            panel3.Controls.Add(menuStrip1);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 46);
            panel3.Name = "panel3";
            panel3.Size = new Size(1848, 33);
            panel3.TabIndex = 47;
            // 
            // checkedListBox1
            // 
            checkedListBox1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Items.AddRange(new object[] { "checkedListBoxItem1", "checkedListBoxItem2", "checkedListBoxItem3" });
            checkedListBox1.Location = new Point(745, 703);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(360, 228);
            checkedListBox1.TabIndex = 48;
            // 
            // label16
            // 
            label16.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label16.AutoSize = true;
            label16.Location = new Point(745, 675);
            label16.Name = "label16";
            label16.Size = new Size(139, 25);
            label16.TabIndex = 49;
            label16.Text = "CheckedListBox";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(1111, 113);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(360, 31);
            dateTimePicker1.TabIndex = 50;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(1111, 85);
            label17.Name = "label17";
            label17.Size = new Size(138, 25);
            label17.TabIndex = 51;
            label17.Text = "DateTimePicker";
            // 
            // domainUpDown1
            // 
            domainUpDown1.Items.Add("titleBarColorDefault");
            domainUpDown1.Items.Add("titleBarColorDarkBlue");
            domainUpDown1.Items.Add("titleBarColorOrange");
            domainUpDown1.Items.Add("titleBarColorDarkGreen");
            domainUpDown1.Location = new Point(745, 113);
            domainUpDown1.Name = "domainUpDown1";
            domainUpDown1.Size = new Size(360, 31);
            domainUpDown1.TabIndex = 52;
            domainUpDown1.SelectedItemChanged += domainUpDown1_SelectedItemChanged;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(744, 85);
            label18.Name = "label18";
            label18.Size = new Size(146, 25);
            label18.TabIndex = 53;
            label18.Text = "DomainUpDown";
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            maskedTextBox1.Location = new Point(158, 975);
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(580, 31);
            maskedTextBox1.TabIndex = 54;
            // 
            // label20
            // 
            label20.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label20.AutoSize = true;
            label20.Location = new Point(12, 978);
            label20.Name = "label20";
            label20.Size = new Size(140, 25);
            label20.TabIndex = 56;
            label20.Text = "MaskedTextBox";
            // 
            // propertyGrid1
            // 
            propertyGrid1.Location = new Point(1477, 116);
            propertyGrid1.Name = "propertyGrid1";
            propertyGrid1.Size = new Size(360, 916);
            propertyGrid1.TabIndex = 57;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(1477, 85);
            label19.Name = "label19";
            label19.Size = new Size(115, 25);
            label19.TabIndex = 58;
            label19.Text = "PropertyGrid";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.Location = new Point(1111, 183);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.Size = new Size(360, 229);
            tableLayoutPanel1.TabIndex = 59;
            // 
            // label21
            // 
            label21.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label21.AutoSize = true;
            label21.Location = new Point(1111, 155);
            label21.Name = "label21";
            label21.Size = new Size(153, 25);
            label21.TabIndex = 60;
            label21.Text = "TableLayoutPanel";
            // 
            // label22
            // 
            label22.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label22.AutoSize = true;
            label22.Location = new Point(12, 155);
            label22.Name = "label22";
            label22.Size = new Size(93, 25);
            label22.TabIndex = 61;
            label22.Text = "GroupBox";
            // 
            // label23
            // 
            label23.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label23.AutoSize = true;
            label23.Location = new Point(745, 1010);
            label23.Name = "label23";
            label23.Size = new Size(91, 25);
            label23.TabIndex = 62;
            label23.Text = "Copyright";
            // 
            // linkLabel2
            // 
            linkLabel2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            linkLabel2.AutoSize = true;
            linkLabel2.Location = new Point(859, 1010);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new Size(571, 25);
            linkLabel2.TabIndex = 63;
            linkLabel2.TabStop = true;
            linkLabel2.Text = "This program is protected by Korea and international copyright laws.";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1848, 1044);
            Controls.Add(linkLabel2);
            Controls.Add(label23);
            Controls.Add(propertyGrid1);
            Controls.Add(label19);
            Controls.Add(label22);
            Controls.Add(progressBar1);
            Controls.Add(label21);
            Controls.Add(label1);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(label20);
            Controls.Add(maskedTextBox1);
            Controls.Add(label18);
            Controls.Add(domainUpDown1);
            Controls.Add(label17);
            Controls.Add(dateTimePicker1);
            Controls.Add(label16);
            Controls.Add(checkedListBox1);
            Controls.Add(panel3);
            Controls.Add(titleBarPanel);
            Controls.Add(label15);
            Controls.Add(label14);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(linkLabel1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(treeView1);
            Controls.Add(trackBar1);
            Controls.Add(textBox1);
            Controls.Add(tabControl1);
            Controls.Add(richTextBox1);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            Controls.Add(numericUpDown1);
            Controls.Add(listView1);
            Controls.Add(listBox1);
            Controls.Add(groupBox1);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(dataGridView1);
            Controls.Add(comboBox1);
            MainMenuStrip = menuStrip1;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tabControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)trackBar1).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MenuStrip menuStrip1;
        private ToolStripMenuItem themeToolStripMenuItem;
        private ToolStripComboBox toolStripComboBox1;
        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private CheckBox checkBox3;
        private ComboBox comboBox1;
        private DataGridView dataGridView1;
        private FlowLayoutPanel flowLayoutPanel1;
        private GroupBox groupBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private LinkLabel linkLabel1;
        private ListBox listBox1;
        private ListView listView1;
        private NumericUpDown numericUpDown1;
        private Panel panel1;
        private PictureBox pictureBox1;
        private ProgressBar progressBar1;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private RadioButton radioButton3;
        private Button button1;
        private Button button2;
        private Button button3;
        private RichTextBox richTextBox1;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TextBox textBox1;
        private TrackBar trackBar1;
        private TreeView treeView1;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label14;
        private Label label15;
        private Panel titleBarPanel;
        private Panel panel3;
        private CheckedListBox checkedListBox1;
        private Label label16;
        private DateTimePicker dateTimePicker1;
        private Label label17;
        private DomainUpDown domainUpDown1;
        private Label label18;
        private MaskedTextBox maskedTextBox1;
        private Label label20;
        private PropertyGrid propertyGrid1;
        private Label label19;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label21;
        private Label label22;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ToolTip toolTip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem1;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem informationToolStripMenuItem;
        private Button button4;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private Label label23;
        private LinkLabel linkLabel2;
    }
}
