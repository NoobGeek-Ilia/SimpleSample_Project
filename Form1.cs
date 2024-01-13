using System.Data;
using System.Media;
using System.Data.SQLite;

namespace SimpleSample
{
    public partial class Form1 : Form
    {
        public SQLiteConnection sqlConnection = null;
        public KeyBase keyBase;
        public int index;
        public uint id;
        public bool flag;
        public int currIndex;
        public bool editOn;
        string currQuestion = "";
        string connString = $"data source={Application.StartupPath}\\Data.db;Version=3";


        private void Form1_Load(object sender, EventArgs e)
        {

            sqlConnection = new SQLiteConnection(connString);
            sqlConnection.Open();
            updateData();
            keyBase = new(dataGridView1.RowCount);
            updateDataSSTable();
            dataGridView1.Columns["Id"].Visible = false;
            dataGridView1.AllowUserToAddRows = false;
            timer1.Enabled = true;
            dataGridView1.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            //запретить изменять размер
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            //поверх всех  окон
            button4.Image = System.Drawing.Image.FromFile("images/attach.png");
            TopMost = true;
            MessageBox.Show($"{dataGridView1.RowCount}");
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            textBox1 = new TextBox();
            button1 = new Button();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            dataGridView2 = new DataGridView();
            tableLayoutPanel1 = new TableLayoutPanel();
            dataGridView1 = new DataGridView();
            tableLayoutPanel3 = new TableLayoutPanel();
            saveSaplesBut = new Button();
            button3 = new Button();
            button5 = new Button();
            button4 = new Button();
            button8 = new Button();
            tableLayoutPanel14 = new TableLayoutPanel();
            label1 = new Label();
            hideBut = new Button();
            addBut = new Button();
            button9 = new Button();
            tableLayoutPanel5 = new TableLayoutPanel();
            SearchBox = new TextBox();
            button6 = new Button();
            smartSearchBut = new Button();
            OpenWinBut = new Button();
            tabPage2 = new TabPage();
            tableLayoutPanel2 = new TableLayoutPanel();
            panel1 = new Panel();
            AddBox = new TextBox();
            tableLayoutPanel8 = new TableLayoutPanel();
            button2 = new Button();
            cancelAdd = new Button();
            tabPage3 = new TabPage();
            button7 = new Button();
            tabPage4 = new TabPage();
            tableLayoutPanel4 = new TableLayoutPanel();
            editBox = new TextBox();
            tableLayoutPanel7 = new TableLayoutPanel();
            applyBut = new Button();
            cancelBut = new Button();
            tabPage5 = new TabPage();
            tableLayoutPanel6 = new TableLayoutPanel();
            tableLayoutPanel11 = new TableLayoutPanel();
            cancelSsBut = new Button();
            searchBut = new Button();
            questionBox = new TextBox();
            label3 = new Label();
            answerBox = new TextBox();
            label4 = new Label();
            tabPage6 = new TabPage();
            tableLayoutPanel9 = new TableLayoutPanel();
            tableLayoutPanel10 = new TableLayoutPanel();
            applyCollBut = new Button();
            cancelAddCollBut = new Button();
            addCollBox = new TextBox();
            timer1 = new System.Windows.Forms.Timer(components);
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel14.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            tabPage2.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            panel1.SuspendLayout();
            tableLayoutPanel8.SuspendLayout();
            tabPage3.SuspendLayout();
            tabPage4.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            tableLayoutPanel7.SuspendLayout();
            tabPage5.SuspendLayout();
            tableLayoutPanel6.SuspendLayout();
            tableLayoutPanel11.SuspendLayout();
            tabPage6.SuspendLayout();
            tableLayoutPanel9.SuspendLayout();
            tableLayoutPanel10.SuspendLayout();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 24);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(205, 27);
            textBox1.TabIndex = 1;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 7F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(223, 24);
            button1.Name = "button1";
            button1.Size = new Size(43, 31);
            button1.TabIndex = 2;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            tabControl1.Appearance = TabAppearance.FlatButtons;
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Controls.Add(tabPage4);
            tabControl1.Controls.Add(tabPage5);
            tabControl1.Controls.Add(tabPage6);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.ItemSize = new Size(0, 1);
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(344, 368);
            tabControl1.SizeMode = TabSizeMode.Fixed;
            tabControl1.TabIndex = 3;
            tabControl1.TabStop = false;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.WhiteSmoke;
            tabPage1.Controls.Add(dataGridView2);
            tabPage1.Controls.Add(tableLayoutPanel1);
            tabPage1.Controls.Add(OpenWinBut);
            tabPage1.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            tabPage1.Location = new Point(4, 5);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(336, 359);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Шаблоны";
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(180, 0);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 62;
            dataGridView2.RowTemplate.Height = 33;
            dataGridView2.Size = new Size(108, 11);
            dataGridView2.TabIndex = 2;
            dataGridView2.Visible = false;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.WhiteSmoke;
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(dataGridView1, 0, 1);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel3, 0, 2);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel5, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            tableLayoutPanel1.Location = new Point(3, 3);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 13.333333F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 86.6666641F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 52F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(330, 353);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.BackgroundColor = SystemColors.Window;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.ColumnHeadersVisible = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = Color.LightGreen;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(3, 43);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 62;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.RowTemplate.Height = 33;
            dataGridView1.ScrollBars = ScrollBars.Vertical;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dataGridView1.Size = new Size(324, 254);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellEnter += dataGridView1_CellEnter;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.BackColor = Color.WhiteSmoke;
            tableLayoutPanel3.ColumnCount = 8;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.6608286F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.6608438F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.6608438F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.655777F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 13.2517262F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.66368F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 23.4462986F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel3.Controls.Add(saveSaplesBut, 5, 0);
            tableLayoutPanel3.Controls.Add(button3, 0, 0);
            tableLayoutPanel3.Controls.Add(button5, 1, 0);
            tableLayoutPanel3.Controls.Add(button4, 2, 0);
            tableLayoutPanel3.Controls.Add(button8, 3, 0);
            tableLayoutPanel3.Controls.Add(tableLayoutPanel14, 6, 0);
            tableLayoutPanel3.Controls.Add(addBut, 4, 0);
            tableLayoutPanel3.Controls.Add(button9, 7, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(3, 303);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Size = new Size(324, 47);
            tableLayoutPanel3.TabIndex = 2;
            // 
            // saveSaplesBut
            // 
            saveSaplesBut.BackColor = Color.WhiteSmoke;
            saveSaplesBut.Dock = DockStyle.Fill;
            saveSaplesBut.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            saveSaplesBut.Image = Properties.Resources.pngwing_com__1___1_;
            saveSaplesBut.Location = new Point(195, 3);
            saveSaplesBut.Name = "saveSaplesBut";
            saveSaplesBut.Size = new Size(32, 41);
            saveSaplesBut.TabIndex = 11;
            saveSaplesBut.UseVisualStyleBackColor = false;
            saveSaplesBut.Click += saveSaplesBut_Click_1;
            // 
            // button3
            // 
            button3.BackColor = Color.WhiteSmoke;
            button3.Dock = DockStyle.Fill;
            button3.Image = Properties.Resources.clipart842915__3_;
            button3.Location = new Point(3, 3);
            button3.Name = "button3";
            button3.Size = new Size(32, 41);
            button3.TabIndex = 3;
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.WhiteSmoke;
            button5.Dock = DockStyle.Fill;
            button5.Image = Properties.Resources.pngwing_com__4___1_;
            button5.Location = new Point(41, 3);
            button5.Name = "button5";
            button5.Size = new Size(32, 41);
            button5.TabIndex = 0;
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.WhiteSmoke;
            button4.Dock = DockStyle.Fill;
            button4.Font = new Font("Cascadia Code", 8F, FontStyle.Regular, GraphicsUnit.Point);
            button4.ForeColor = SystemColors.ControlText;
            button4.Image = Properties.Resources.noAttach;
            button4.Location = new Point(79, 3);
            button4.Name = "button4";
            button4.Size = new Size(32, 41);
            button4.TabIndex = 4;
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button8
            // 
            button8.BackColor = Color.WhiteSmoke;
            button8.Dock = DockStyle.Fill;
            button8.Image = Properties.Resources.pencil1;
            button8.Location = new Point(117, 3);
            button8.Name = "button8";
            button8.Size = new Size(32, 41);
            button8.TabIndex = 5;
            button8.UseVisualStyleBackColor = false;
            button8.Click += button8_Click;
            // 
            // tableLayoutPanel14
            // 
            tableLayoutPanel14.ColumnCount = 1;
            tableLayoutPanel14.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel14.Controls.Add(label1, 0, 0);
            tableLayoutPanel14.Controls.Add(hideBut, 0, 1);
            tableLayoutPanel14.Location = new Point(233, 3);
            tableLayoutPanel14.Name = "tableLayoutPanel14";
            tableLayoutPanel14.RowCount = 2;
            tableLayoutPanel14.RowStyles.Add(new RowStyle(SizeType.Percent, 53.658535F));
            tableLayoutPanel14.RowStyles.Add(new RowStyle(SizeType.Percent, 46.341465F));
            tableLayoutPanel14.Size = new Size(65, 41);
            tableLayoutPanel14.TabIndex = 10;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.WhiteSmoke;
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Calibri", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(59, 22);
            label1.TabIndex = 2;
            label1.Text = "23:22";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // hideBut
            // 
            hideBut.BackColor = Color.DimGray;
            hideBut.Dock = DockStyle.Fill;
            hideBut.Location = new Point(3, 25);
            hideBut.Name = "hideBut";
            hideBut.Size = new Size(59, 13);
            hideBut.TabIndex = 7;
            hideBut.UseVisualStyleBackColor = false;
            hideBut.Click += hideBut_Click;
            // 
            // addBut
            // 
            addBut.BackColor = Color.WhiteSmoke;
            addBut.Dock = DockStyle.Fill;
            addBut.Image = Properties.Resources.plus;
            addBut.Location = new Point(155, 3);
            addBut.Name = "addBut";
            addBut.Size = new Size(34, 41);
            addBut.TabIndex = 6;
            addBut.UseVisualStyleBackColor = false;
            addBut.Click += addBut_Click;
            // 
            // button9
            // 
            button9.Dock = DockStyle.Fill;
            button9.Location = new Point(304, 3);
            button9.Name = "button9";
            button9.Size = new Size(17, 41);
            button9.TabIndex = 12;
            button9.UseVisualStyleBackColor = true;
            button9.Click += button9_Click;
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.AutoSize = true;
            tableLayoutPanel5.ColumnCount = 3;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70.62147F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.6892653F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.6892653F));
            tableLayoutPanel5.Controls.Add(SearchBox, 0, 0);
            tableLayoutPanel5.Controls.Add(button6, 1, 0);
            tableLayoutPanel5.Controls.Add(smartSearchBut, 2, 0);
            tableLayoutPanel5.Dock = DockStyle.Fill;
            tableLayoutPanel5.Location = new Point(3, 3);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 1;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel5.Size = new Size(324, 34);
            tableLayoutPanel5.TabIndex = 5;
            // 
            // SearchBox
            // 
            SearchBox.Dock = DockStyle.Fill;
            SearchBox.Location = new Point(3, 3);
            SearchBox.Name = "SearchBox";
            SearchBox.Size = new Size(222, 25);
            SearchBox.TabIndex = 1;
            SearchBox.TextChanged += SearchBox_TextChanged;
            // 
            // button6
            // 
            button6.Dock = DockStyle.Fill;
            button6.Image = Properties.Resources.pngwing_com__1_;
            button6.Location = new Point(231, 3);
            button6.Name = "button6";
            button6.Size = new Size(41, 28);
            button6.TabIndex = 1;
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // smartSearchBut
            // 
            smartSearchBut.Dock = DockStyle.Fill;
            smartSearchBut.Image = Properties.Resources.pngwing_com__2___1_;
            smartSearchBut.Location = new Point(278, 3);
            smartSearchBut.Name = "smartSearchBut";
            smartSearchBut.Size = new Size(43, 28);
            smartSearchBut.TabIndex = 2;
            smartSearchBut.UseVisualStyleBackColor = true;
            smartSearchBut.Click += smartSearchBut_Click;
            // 
            // OpenWinBut
            // 
            OpenWinBut.BackColor = Color.LightGreen;
            OpenWinBut.ForeColor = SystemColors.ActiveCaptionText;
            OpenWinBut.Location = new Point(-4, -25);
            OpenWinBut.Name = "OpenWinBut";
            OpenWinBut.Size = new Size(103, 65);
            OpenWinBut.TabIndex = 1;
            OpenWinBut.Text = "Развернуть";
            OpenWinBut.UseVisualStyleBackColor = false;
            OpenWinBut.Visible = false;
            OpenWinBut.Click += OpenWinBut_Click;
            // 
            // tabPage2
            // 
            tabPage2.BackColor = Color.Gainsboro;
            tabPage2.Controls.Add(tableLayoutPanel2);
            tabPage2.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            tabPage2.Location = new Point(4, 5);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(336, 359);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Добавить";
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.AutoScroll = true;
            tableLayoutPanel2.BackColor = Color.WhiteSmoke;
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 81.43939F));
            tableLayoutPanel2.Controls.Add(panel1, 0, 0);
            tableLayoutPanel2.Controls.Add(tableLayoutPanel8, 0, 1);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 42F));
            tableLayoutPanel2.Size = new Size(330, 353);
            tableLayoutPanel2.TabIndex = 2;
            // 
            // panel1
            // 
            panel1.Controls.Add(AddBox);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(324, 305);
            panel1.TabIndex = 2;
            // 
            // AddBox
            // 
            AddBox.BackColor = SystemColors.Window;
            AddBox.Dock = DockStyle.Fill;
            AddBox.Location = new Point(0, 0);
            AddBox.Multiline = true;
            AddBox.Name = "AddBox";
            AddBox.ScrollBars = ScrollBars.Vertical;
            AddBox.Size = new Size(324, 305);
            AddBox.TabIndex = 0;
            // 
            // tableLayoutPanel8
            // 
            tableLayoutPanel8.ColumnCount = 2;
            tableLayoutPanel8.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel8.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel8.Controls.Add(button2, 1, 0);
            tableLayoutPanel8.Controls.Add(cancelAdd, 0, 0);
            tableLayoutPanel8.Dock = DockStyle.Fill;
            tableLayoutPanel8.Location = new Point(3, 314);
            tableLayoutPanel8.Name = "tableLayoutPanel8";
            tableLayoutPanel8.RowCount = 1;
            tableLayoutPanel8.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel8.Size = new Size(324, 36);
            tableLayoutPanel8.TabIndex = 3;
            // 
            // button2
            // 
            button2.BackColor = Color.WhiteSmoke;
            button2.Dock = DockStyle.Fill;
            button2.Font = new Font("Segoe UI", 7F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(165, 3);
            button2.Name = "button2";
            button2.Size = new Size(156, 30);
            button2.TabIndex = 1;
            button2.Text = "Добавить шаблон";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // cancelAdd
            // 
            cancelAdd.BackColor = Color.White;
            cancelAdd.Dock = DockStyle.Fill;
            cancelAdd.Location = new Point(3, 3);
            cancelAdd.Name = "cancelAdd";
            cancelAdd.Size = new Size(156, 30);
            cancelAdd.TabIndex = 2;
            cancelAdd.Text = "Назад";
            cancelAdd.UseVisualStyleBackColor = false;
            cancelAdd.Click += cancelAdd_Click;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(button7);
            tabPage3.Location = new Point(4, 5);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(336, 359);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Скрыть";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            button7.Dock = DockStyle.Top;
            button7.Location = new Point(0, 0);
            button7.Name = "button7";
            button7.Size = new Size(336, 12);
            button7.TabIndex = 0;
            button7.Text = "button7";
            button7.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            tabPage4.Controls.Add(tableLayoutPanel4);
            tabPage4.Location = new Point(4, 5);
            tabPage4.Name = "tabPage4";
            tabPage4.Size = new Size(336, 359);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "Редактор";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 1;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.Controls.Add(editBox, 0, 0);
            tableLayoutPanel4.Controls.Add(tableLayoutPanel7, 0, 1);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(0, 0);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 2;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 86.5625F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 13.4375F));
            tableLayoutPanel4.Size = new Size(336, 359);
            tableLayoutPanel4.TabIndex = 0;
            // 
            // editBox
            // 
            editBox.Dock = DockStyle.Fill;
            editBox.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            editBox.Location = new Point(3, 3);
            editBox.Multiline = true;
            editBox.Name = "editBox";
            editBox.ScrollBars = ScrollBars.Vertical;
            editBox.Size = new Size(330, 304);
            editBox.TabIndex = 0;
            // 
            // tableLayoutPanel7
            // 
            tableLayoutPanel7.ColumnCount = 2;
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel7.Controls.Add(applyBut, 1, 0);
            tableLayoutPanel7.Controls.Add(cancelBut, 0, 0);
            tableLayoutPanel7.Dock = DockStyle.Fill;
            tableLayoutPanel7.Location = new Point(3, 313);
            tableLayoutPanel7.Name = "tableLayoutPanel7";
            tableLayoutPanel7.RowCount = 1;
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel7.Size = new Size(330, 43);
            tableLayoutPanel7.TabIndex = 3;
            // 
            // applyBut
            // 
            applyBut.BackColor = Color.WhiteSmoke;
            applyBut.Dock = DockStyle.Fill;
            applyBut.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            applyBut.Location = new Point(168, 3);
            applyBut.Name = "applyBut";
            applyBut.Size = new Size(159, 37);
            applyBut.TabIndex = 1;
            applyBut.Text = "Применить";
            applyBut.UseVisualStyleBackColor = false;
            applyBut.Click += applyBut_Click;
            // 
            // cancelBut
            // 
            cancelBut.BackColor = Color.WhiteSmoke;
            cancelBut.Dock = DockStyle.Fill;
            cancelBut.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            cancelBut.Location = new Point(3, 3);
            cancelBut.Name = "cancelBut";
            cancelBut.Size = new Size(159, 37);
            cancelBut.TabIndex = 2;
            cancelBut.Text = "Назад";
            cancelBut.UseVisualStyleBackColor = false;
            cancelBut.Click += cancelBut_Click;
            // 
            // tabPage5
            // 
            tabPage5.Controls.Add(tableLayoutPanel6);
            tabPage5.Location = new Point(4, 5);
            tabPage5.Name = "tabPage5";
            tabPage5.Size = new Size(336, 359);
            tabPage5.TabIndex = 4;
            tabPage5.Text = "Умный поиск";
            tabPage5.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel6
            // 
            tableLayoutPanel6.ColumnCount = 1;
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel6.Controls.Add(tableLayoutPanel11, 0, 4);
            tableLayoutPanel6.Controls.Add(questionBox, 0, 1);
            tableLayoutPanel6.Controls.Add(label3, 0, 0);
            tableLayoutPanel6.Controls.Add(answerBox, 0, 3);
            tableLayoutPanel6.Controls.Add(label4, 0, 2);
            tableLayoutPanel6.Dock = DockStyle.Fill;
            tableLayoutPanel6.Location = new Point(0, 0);
            tableLayoutPanel6.Name = "tableLayoutPanel6";
            tableLayoutPanel6.RowCount = 5;
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 6.299213F));
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 37.7952766F));
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 6.29921246F));
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 37.7952766F));
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 11.8110247F));
            tableLayoutPanel6.Size = new Size(336, 359);
            tableLayoutPanel6.TabIndex = 0;
            // 
            // tableLayoutPanel11
            // 
            tableLayoutPanel11.ColumnCount = 2;
            tableLayoutPanel11.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel11.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel11.Controls.Add(cancelSsBut, 0, 0);
            tableLayoutPanel11.Controls.Add(searchBut, 1, 0);
            tableLayoutPanel11.Dock = DockStyle.Fill;
            tableLayoutPanel11.Location = new Point(3, 317);
            tableLayoutPanel11.Name = "tableLayoutPanel11";
            tableLayoutPanel11.RowCount = 1;
            tableLayoutPanel11.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel11.Size = new Size(330, 39);
            tableLayoutPanel11.TabIndex = 5;
            // 
            // cancelSsBut
            // 
            cancelSsBut.BackColor = Color.WhiteSmoke;
            cancelSsBut.Dock = DockStyle.Fill;
            cancelSsBut.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            cancelSsBut.Location = new Point(3, 3);
            cancelSsBut.Name = "cancelSsBut";
            cancelSsBut.Size = new Size(159, 33);
            cancelSsBut.TabIndex = 0;
            cancelSsBut.Text = "Назад";
            cancelSsBut.UseVisualStyleBackColor = false;
            cancelSsBut.Click += cancelSsBut_Click;
            // 
            // searchBut
            // 
            searchBut.BackColor = Color.WhiteSmoke;
            searchBut.Dock = DockStyle.Fill;
            searchBut.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            searchBut.Location = new Point(168, 3);
            searchBut.Name = "searchBut";
            searchBut.Size = new Size(159, 33);
            searchBut.TabIndex = 2;
            searchBut.Text = "Генерировать";
            searchBut.UseVisualStyleBackColor = false;
            searchBut.Click += searchBut_Click;
            // 
            // questionBox
            // 
            questionBox.Dock = DockStyle.Fill;
            questionBox.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            questionBox.Location = new Point(3, 25);
            questionBox.Multiline = true;
            questionBox.Name = "questionBox";
            questionBox.ScrollBars = ScrollBars.Vertical;
            questionBox.Size = new Size(330, 129);
            questionBox.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Fill;
            label3.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(3, 0);
            label3.Name = "label3";
            label3.Size = new Size(330, 22);
            label3.TabIndex = 6;
            label3.Text = "Введите вопрос";
            label3.TextAlign = ContentAlignment.TopCenter;
            // 
            // answerBox
            // 
            answerBox.Dock = DockStyle.Fill;
            answerBox.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            answerBox.Location = new Point(3, 182);
            answerBox.Multiline = true;
            answerBox.Name = "answerBox";
            answerBox.ScrollBars = ScrollBars.Vertical;
            answerBox.Size = new Size(330, 129);
            answerBox.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Dock = DockStyle.Fill;
            label4.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(3, 157);
            label4.Name = "label4";
            label4.Size = new Size(330, 22);
            label4.TabIndex = 7;
            label4.Text = "Релевантные ответы";
            label4.TextAlign = ContentAlignment.TopCenter;
            // 
            // tabPage6
            // 
            tabPage6.Controls.Add(tableLayoutPanel9);
            tabPage6.Location = new Point(4, 5);
            tabPage6.Name = "tabPage6";
            tabPage6.Size = new Size(336, 359);
            tabPage6.TabIndex = 5;
            tabPage6.Text = "Добавить коллекцию";
            tabPage6.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel9
            // 
            tableLayoutPanel9.ColumnCount = 1;
            tableLayoutPanel9.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel9.Controls.Add(tableLayoutPanel10, 0, 1);
            tableLayoutPanel9.Controls.Add(addCollBox, 0, 0);
            tableLayoutPanel9.Dock = DockStyle.Fill;
            tableLayoutPanel9.Location = new Point(0, 0);
            tableLayoutPanel9.Name = "tableLayoutPanel9";
            tableLayoutPanel9.RowCount = 2;
            tableLayoutPanel9.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel9.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel9.Size = new Size(336, 359);
            tableLayoutPanel9.TabIndex = 0;
            // 
            // tableLayoutPanel10
            // 
            tableLayoutPanel10.ColumnCount = 2;
            tableLayoutPanel10.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 51.155117F));
            tableLayoutPanel10.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 48.844883F));
            tableLayoutPanel10.Controls.Add(applyCollBut, 1, 0);
            tableLayoutPanel10.Controls.Add(cancelAddCollBut, 0, 0);
            tableLayoutPanel10.Dock = DockStyle.Fill;
            tableLayoutPanel10.Location = new Point(3, 322);
            tableLayoutPanel10.Name = "tableLayoutPanel10";
            tableLayoutPanel10.RowCount = 1;
            tableLayoutPanel10.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel10.Size = new Size(330, 34);
            tableLayoutPanel10.TabIndex = 0;
            // 
            // applyCollBut
            // 
            applyCollBut.BackColor = Color.WhiteSmoke;
            applyCollBut.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            applyCollBut.Location = new Point(171, 3);
            applyCollBut.Name = "applyCollBut";
            applyCollBut.Size = new Size(142, 28);
            applyCollBut.TabIndex = 0;
            applyCollBut.Text = "Пересобрать";
            applyCollBut.UseVisualStyleBackColor = false;
            applyCollBut.Click += applyCollBut_Click;
            // 
            // cancelAddCollBut
            // 
            cancelAddCollBut.BackColor = Color.WhiteSmoke;
            cancelAddCollBut.Dock = DockStyle.Fill;
            cancelAddCollBut.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            cancelAddCollBut.Location = new Point(3, 3);
            cancelAddCollBut.Name = "cancelAddCollBut";
            cancelAddCollBut.Size = new Size(162, 28);
            cancelAddCollBut.TabIndex = 1;
            cancelAddCollBut.Text = "Назад";
            cancelAddCollBut.UseVisualStyleBackColor = false;
            cancelAddCollBut.Click += cancelAddCollBut_Click;
            // 
            // addCollBox
            // 
            addCollBox.Dock = DockStyle.Fill;
            addCollBox.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            addCollBox.Location = new Point(3, 3);
            addCollBox.MaxLength = 99999999;
            addCollBox.Multiline = true;
            addCollBox.Name = "addCollBox";
            addCollBox.Size = new Size(330, 313);
            addCollBox.TabIndex = 1;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // Form1
            // 
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(344, 368);
            Controls.Add(tabControl1);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            KeyPreview = true;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Simple Sample";
            Load += Form1_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel14.ResumeLayout(false);
            tableLayoutPanel14.PerformLayout();
            tableLayoutPanel5.ResumeLayout(false);
            tableLayoutPanel5.PerformLayout();
            tabPage2.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tableLayoutPanel8.ResumeLayout(false);
            tabPage3.ResumeLayout(false);
            tabPage4.ResumeLayout(false);
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel4.PerformLayout();
            tableLayoutPanel7.ResumeLayout(false);
            tabPage5.ResumeLayout(false);
            tableLayoutPanel6.ResumeLayout(false);
            tableLayoutPanel6.PerformLayout();
            tableLayoutPanel11.ResumeLayout(false);
            tabPage6.ResumeLayout(false);
            tableLayoutPanel9.ResumeLayout(false);
            tableLayoutPanel9.PerformLayout();
            tableLayoutPanel10.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (AddBox.Text != "")
            {
                SystemSounds.Hand.Play();
                SQLiteCommand comm = new SQLiteCommand($"INSERT INTO [TableOfTemplates] (Sample) VALUES ('{AddBox.Text}')", sqlConnection);
                comm.ExecuteNonQuery();
                MessageBox.Show("Шаблон успешно занесен в базу");
                updateData();
                AddBox.Text = null;
                tabControl1.SelectedIndex = 0;
            }
            else
                MessageBox.Show("Нет шаблона для добавления. Попробуйте еще раз.");
        }

        private void searchBut_Click(object sender, EventArgs e)
        {
            // последний индекс не находит!!!!
            // 0. Проверка был ли изменен вопрос
            if (questionBox.Text != "")
            {
                if (questionBox.Text != currQuestion)
                {
                    // 1. Закинули вопрос по словам во временную таблицу
                    string qPhrase = questionBox.Text;
                    char[] separators = { ' ', '\n' };
                    string[] qWord = qPhrase.Split(separators);
                    //удалили с обнулением id
                    SQLiteCommand delComm = new SQLiteCommand($"DELETE FROM TempQuestion", sqlConnection);
                    delComm.ExecuteNonQuery();
                    //очистить все значения из ключей
                    ClearKey();
                    //закинули новые слова из вопроса
                    foreach (string word in qWord)
                    {
                        SQLiteCommand qComm = new SQLiteCommand($"INSERT INTO [TempQuestion] (Word) VALUES ('{word}')", sqlConnection);
                        qComm.ExecuteNonQuery();
                    }
                    //заполняем счет каждого из ключа
                    for (int i = 0; i < keyBase.keysCollection; i++)
                    {
                        for (int j = 0; j < keyBase.getKey[i].Count; j++)
                        {
                            SQLiteCommand countComm = new SQLiteCommand($"SELECT COUNT(*) FROM TempQuestion WHERE Word LIKE '%{keyBase.getKey[i][j]}%'", sqlConnection);
                            //определили количество совпадений по ключам
                            keyBase.keyCount[i] += Convert.ToInt32(countComm.ExecuteScalar());
                            //присвоили ключам количество совпадений 
                            keyBase.sortedKeys[i] = keyBase.keyCount[i];
                        }
                    }
                    //запоминаем вопрос
                    currQuestion = questionBox.Text;
                    SortingKeys();
                }
                else
                {
                    if (currIndex < keyBase.sortedIndex.Count)
                        currIndex++;
                    if (currIndex == keyBase.sortedIndex.Count)
                        currIndex = 0;
                }
                if (keyBase.sortedIndex.Count > 0)
                {
                    //MessageBox.Show($"sortedIndex: {keyBase.sortedIndex.Length}, currIndex: {currIndex}");
                    if (currIndex < keyBase.sortedIndex.Count)
                        answerBox.Text = $"{currIndex + 1}. {dataGridView1.Rows[keyBase.sortedIndex[currIndex]].Cells[1].Value}";
                }
                else
                {
                    answerBox.Text = "Совпадения не найдены";
                }
            }
            else
                answerBox.Text = "Вы не ввели вопрос";
        }

        void ClearKey()
        {
            keyBase.kTest.Clear();
            for (int i = 0; i < keyBase.sortedIndex.Count; i++)
            {
                keyBase.sortedIndex[i] = 0;
            }
            for (int i = 0; i < keyBase.keysCollection; i++)
            {
                keyBase.keyCount[i] = 0;
                keyBase.sortedKeys[i] = 0;
            }
            currIndex = 0;
        }

        void SortingKeys()
        {
            //сортировка от большего к меншьшему в sortedKeys
            keyBase.sortedKeys.Sort();
            keyBase.sortedKeys.Reverse();
            foreach (int key in keyBase.sortedKeys)
                //находим индекс keyCount с наибольшим значением, затем записываем данный индекс в sortedKey.
                //т.е. sortedKey становится отсортированным массивом из упорядоченных индексов от большего к меньшему.
                for (int i = 0; i < keyBase.keysCollection; i++)
                {
                    for (int j = 0; j < keyBase.keysCollection; j++)
                    {
                        if (keyBase.sortedKeys[i] == keyBase.keyCount[j] && keyBase.sortedKeys[i] != 0)
                        {
                            keyBase.kTest.Add(j);
                        }
                    }
                }
            //!!! убрать нули в tempIndex (незаполненные индексы),  тк они попадают в sortedIndex
            keyBase.sortedIndex = keyBase.kTest.Distinct().ToList();
        }

        public void updateData()
        {
            SQLiteDataAdapter dataAdapter = new SQLiteDataAdapter("SELECT * FROM TableOfTemplates", sqlConnection);
            DataSet ds = new DataSet();
            dataAdapter.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }
        public void updateDataSSTable()
        {
            SQLiteDataAdapter ssDataAdapter = new SQLiteDataAdapter("SELECT * FROM TableOfTemplates_SS", sqlConnection);
            DataSet ssDs = new DataSet();
            ssDataAdapter.Fill(ssDs);
            dataGridView2.DataSource = ssDs.Tables[0];
        }

        private void SearchBox_TextChanged(object sender, EventArgs e)
        {
            (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = $"Sample LIKE '%{SearchBox.Text}%'";
        }


        public void DeleteCell()
        {
            var cellValue = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[0].Value;
            if (cellValue != DBNull.Value)
            {
                id = Convert.ToUInt32(cellValue);
                dataGridView1.Rows.RemoveAt(dataGridView1.CurrentCell.RowIndex);

                SQLiteCommand qq = new SQLiteCommand($"DELETE FROM TableOfTemplates WHERE Id = {id}", sqlConnection);
                qq.ExecuteNonQuery();

                MessageBox.Show($"Шаблон успешно удален");
            }
        }

        public void EditON()
        {
            MessageBox.Show("Шаблон успешно отредактирован");
            updateData();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SystemSounds.Hand.Play();
            if (dataGridView1.Rows.Count > 0)
            {
                if (MessageBox.Show($"Вы действительно хотите удалить выделенный шаблоны?", "Внимание!", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    DeleteCell();
                }
            }
            else
                MessageBox.Show($"Нет шаблонов для удаления");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (TopMost == false)
            {
                TopMost = true;
                button4.Image = System.Drawing.Image.FromFile("images/attach.png");
            }

            else
            {
                TopMost = false;
                button4.Image = System.Drawing.Image.FromFile("images/noAttach.png");
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            if (dataGridView1.CurrentCell != null)
                index = dataGridView1.CurrentCell.RowIndex;
            label1.Text = $"{now:mm}:{now:ss}";
        }

        //down
        private void button5_Click(object sender, EventArgs e)
        {
            if (FormBorderStyle == FormBorderStyle.FixedSingle)
                FormBorderStyle = FormBorderStyle.None;
            else
                FormBorderStyle = FormBorderStyle.FixedSingle;
        }
        //up
        private void button6_Click(object sender, EventArgs e)
        {
            SearchBox.Text = "";
        }

        //редактирование шаблона
        private void button8_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentCell != null)
            {
                tabControl1.SelectedIndex = 3;
                editBox.Text = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[1].Value.ToString();
            }
            else
            {
                SystemSounds.Hand.Play();
                MessageBox.Show("Выберете шаблон для редактирования");
            }
        }

        private void applyBut_Click(object sender, EventArgs e)
        {
            if (editBox.Text != "")
            {
                SystemSounds.Hand.Play();
                id = Convert.ToUInt32(dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[0].Value);
                SQLiteCommand rep = new SQLiteCommand($"UPDATE TableOfTemplates SET Sample = '{editBox.Text}' WHERE Id = {id}", sqlConnection);
                rep.ExecuteNonQuery();
                updateData();
                MessageBox.Show("Шаблон успешно отредактирован");
                tabControl1.SelectedIndex = 0;
            }
            else
            {
                SystemSounds.Hand.Play();
                MessageBox.Show("Поле не может быть пустым. Редактирование не завершено.");
            }
        }

        private void cancelBut_Click(object sender, EventArgs e)
        {
            editBox.Text = null;
            tabControl1.SelectedIndex = 0;
        }

        //добавить шаблон
        //добавить шаблон или колекцию?
        private void addBut_Click(object sender, EventArgs e)
        {
            SystemSounds.Hand.Play();
            if (MessageBox.Show($"Вы хотите пересобрать шаблоны?", "Внимание!", MessageBoxButtons.YesNo) == DialogResult.No)
                tabControl1.SelectedIndex = 1;
            else
                tabControl1.SelectedIndex = 5;
        }

        private void cancelAdd_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 0;
            AddBox.Text = null;
        }
        //
        private void hideBut_Click(object sender, EventArgs e)
        {
            if (FormBorderStyle == FormBorderStyle.None)
            {
                Size = new Size(100, 25);
                tableLayoutPanel1.Visible = false;
                OpenWinBut.Visible = true;
            }
        }

        private void OpenWinBut_Click(object sender, EventArgs e)
        {
            Size = new Size(339 - 20, 424 - 55);
            tableLayoutPanel1.Visible = true;
            OpenWinBut.Visible = false;
        }

        private void smartSearchBut_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 4;
        }

        //пересобрать шаблоны

        // работает при переносе строки и пробеле (создается новая ячейка)
        private void applyCollBut_Click(object sender, EventArgs e)
        {
            string qPhrase = addCollBox.Text;
            string[] qWord = qPhrase.Split(new string[] { Environment.NewLine + Environment.NewLine }, StringSplitOptions.None);

            if (qWord.Length > 0)
            {
                // delete all cells
                SQLiteCommand delComm = new SQLiteCommand("DELETE FROM TableOfTemplates", sqlConnection);
                delComm.ExecuteNonQuery();

                // add cells
                foreach (string word in qWord)
                {
                    SQLiteCommand qComm = new SQLiteCommand($"INSERT INTO [TableOfTemplates] (Sample) VALUES ('{word}')", sqlConnection);
                    qComm.ExecuteNonQuery();
                }

                // MessageBox.Show($"Добавлено {qWord.Length} записей.");
                MessageBox.Show($"Добавлено {qWord.Length} записей.");
                updateData();
                addCollBox.Text = null;
                tabControl1.SelectedIndex = 0;
            }
            else
            {
                MessageBox.Show("Нет данных для добавления.");
            }
        }


        private void addCollBut_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 5;
        }

        private void cancelAddCollBut_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 0;
        }

        //
        private void cancelSsBut_Click(object sender, EventArgs e)
        {
            ClearKey();
            answerBox.Text = "";
            questionBox.Text = "";
            tabControl1.SelectedIndex = 0;
            currQuestion = "";
        }

        //сохраниение
        private void saveSaplesBut_Click_1(object sender, EventArgs e)
        {
            SystemSounds.Hand.Play();
            if (MessageBox.Show($"После подтверждения, все шаблоны будут сохранены в файл SavedSamples.txt. Сохранить всю коллекцию?", "Внимание!", MessageBoxButtons.YesNo) != DialogResult.No)
            {
                string filePath = Path.Combine(Application.StartupPath, "SimpleSample.txt");
                FileStream fs = new FileStream(filePath, FileMode.Create);
                StreamWriter streamWriter = new StreamWriter(fs);
                try
                {
                    for (int j = 0; j < dataGridView1.Rows.Count; j++)
                    {
                        streamWriter.Write(dataGridView1.Rows[j].Cells[1].Value + Environment.NewLine + Environment.NewLine);
                    }
                    streamWriter.Close();
                    fs.Close();
                    MessageBox.Show("Коллекция успешно сохранена");
                }
                catch
                {
                    MessageBox.Show("Ошибка при сохранении файла!");
                }
            }
        }
        // копируем содержимое строки в буфер
        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.CurrentCell != null)
            {
                Clipboard.SetDataObject(dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[1].Value.ToString());

            }
        }

        bool keyFormOpened;
        private void button9_Click(object sender, EventArgs e)
        {

            if (!keyFormOpened)
            {
                Form2 newForm = new Form2(this);
                newForm.Left = this.Right - 10;
                newForm.Top = this.Bottom - newForm.Height;
                newForm.FormClosed += (s, args) => keyFormOpened = false; // Обработчик события закрытия формы
                newForm.Show();
                keyFormOpened = true;
            }
        }
    }
}