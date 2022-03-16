
namespace Bank
{
    partial class FormMain
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.fullName_label = new System.Windows.Forms.Label();
            this.birthday_label = new System.Windows.Forms.Label();
            this.passport_label = new System.Windows.Forms.Label();
            this.number_label = new System.Windows.Forms.Label();
            this.openDate_label = new System.Windows.Forms.Label();
            this.sum = new System.Windows.Forms.Label();
            this.passport_textBox = new System.Windows.Forms.TextBox();
            this.addServ = new System.Windows.Forms.GroupBox();
            this.netBank_checkBox = new System.Windows.Forms.CheckBox();
            this.sms_checkBox = new System.Windows.Forms.CheckBox();
            this.opendate_calendar = new System.Windows.Forms.DateTimePicker();
            this.fullName_textBox = new System.Windows.Forms.TextBox();
            this.birthday_calendar = new System.Windows.Forms.DateTimePicker();
            this.sum_trackBar = new System.Windows.Forms.TrackBar();
            this.number_textBox = new System.Windows.Forms.TextBox();
            this.toFile_button = new System.Windows.Forms.Button();
            this.fromFile_button = new System.Windows.Forms.Button();
            this.reg_button = new System.Windows.Forms.Button();
            this.header = new System.Windows.Forms.Label();
            this.contribType_comboBox = new System.Windows.Forms.ComboBox();
            this.balance_textBox = new System.Windows.Forms.TextBox();
            this.fixedProc_radioButton = new System.Windows.Forms.RadioButton();
            this.floatProc_radioButton = new System.Windows.Forms.RadioButton();
            this.ContribTypeBox = new System.Windows.Forms.GroupBox();
            this.BYN_label = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.SearchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SrchNumberToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SrchFullNameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SrchBalanceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SrchContribTypeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SortingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SortedComtrTTtoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SortedOpenDateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ClearForm = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.StatusStrip = new System.Windows.Forms.StatusStrip();
            this.CountOfItemsStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.lastActionStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.TopToolStrip = new System.Windows.Forms.ToolStrip();
            this.msUndo = new System.Windows.Forms.ToolStripButton();
            this.msRedo = new System.Windows.Forms.ToolStripButton();
            this.DelToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.HideToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.ShowToolStripButton = new System.Windows.Forms.Button();
            this.OutputBox = new System.Windows.Forms.RichTextBox();
            this.help_label = new System.Windows.Forms.Label();
            this.addServ.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sum_trackBar)).BeginInit();
            this.ContribTypeBox.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.StatusStrip.SuspendLayout();
            this.TopToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // fullName_label
            // 
            this.fullName_label.AutoSize = true;
            this.fullName_label.Font = new System.Drawing.Font("Yu Gothic UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fullName_label.Location = new System.Drawing.Point(78, 87);
            this.fullName_label.Name = "fullName_label";
            this.fullName_label.Size = new System.Drawing.Size(49, 23);
            this.fullName_label.TabIndex = 0;
            this.fullName_label.Text = "ФИО";
            // 
            // birthday_label
            // 
            this.birthday_label.AutoSize = true;
            this.birthday_label.Font = new System.Drawing.Font("Yu Gothic UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.birthday_label.Location = new System.Drawing.Point(80, 157);
            this.birthday_label.Name = "birthday_label";
            this.birthday_label.Size = new System.Drawing.Size(133, 23);
            this.birthday_label.TabIndex = 1;
            this.birthday_label.Text = "Дата рождения";
            // 
            // passport_label
            // 
            this.passport_label.AutoSize = true;
            this.passport_label.Font = new System.Drawing.Font("Yu Gothic UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passport_label.Location = new System.Drawing.Point(79, 234);
            this.passport_label.Name = "passport_label";
            this.passport_label.Size = new System.Drawing.Size(182, 23);
            this.passport_label.TabIndex = 2;
            this.passport_label.Text = "Паспортные данные*";
            this.passport_label.MouseLeave += new System.EventHandler(this.passport_label_MouseLeave);
            this.passport_label.MouseHover += new System.EventHandler(this.passport_label_MouseHover);
            // 
            // number_label
            // 
            this.number_label.AutoSize = true;
            this.number_label.Font = new System.Drawing.Font("Yu Gothic UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.number_label.Location = new System.Drawing.Point(469, 87);
            this.number_label.Name = "number_label";
            this.number_label.Size = new System.Drawing.Size(113, 23);
            this.number_label.TabIndex = 4;
            this.number_label.Text = "Номер счёта";
            // 
            // openDate_label
            // 
            this.openDate_label.AutoSize = true;
            this.openDate_label.Font = new System.Drawing.Font("Yu Gothic UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.openDate_label.Location = new System.Drawing.Point(469, 157);
            this.openDate_label.Name = "openDate_label";
            this.openDate_label.Size = new System.Drawing.Size(175, 23);
            this.openDate_label.TabIndex = 5;
            this.openDate_label.Text = "Дата открытия счёта";
            // 
            // sum
            // 
            this.sum.AutoSize = true;
            this.sum.Font = new System.Drawing.Font("Yu Gothic UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sum.Location = new System.Drawing.Point(468, 234);
            this.sum.Name = "sum";
            this.sum.Size = new System.Drawing.Size(126, 23);
            this.sum.TabIndex = 6;
            this.sum.Text = "Сумма вклада";
            // 
            // passport_textBox
            // 
            this.passport_textBox.BackColor = System.Drawing.Color.Silver;
            this.passport_textBox.Font = new System.Drawing.Font("Yu Gothic UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passport_textBox.Location = new System.Drawing.Point(77, 260);
            this.passport_textBox.Name = "passport_textBox";
            this.passport_textBox.Size = new System.Drawing.Size(293, 30);
            this.passport_textBox.TabIndex = 5;
            // 
            // addServ
            // 
            this.addServ.Controls.Add(this.netBank_checkBox);
            this.addServ.Controls.Add(this.sms_checkBox);
            this.addServ.Font = new System.Drawing.Font("Yu Gothic UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addServ.Location = new System.Drawing.Point(77, 328);
            this.addServ.Name = "addServ";
            this.addServ.Size = new System.Drawing.Size(293, 122);
            this.addServ.TabIndex = 7;
            this.addServ.TabStop = false;
            this.addServ.Text = "Дополнительные услуги";
            // 
            // netBank_checkBox
            // 
            this.netBank_checkBox.AutoSize = true;
            this.netBank_checkBox.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.netBank_checkBox.Location = new System.Drawing.Point(7, 85);
            this.netBank_checkBox.Name = "netBank_checkBox";
            this.netBank_checkBox.Size = new System.Drawing.Size(267, 24);
            this.netBank_checkBox.TabIndex = 1;
            this.netBank_checkBox.Text = "подключение Интернет-банкинга";
            this.netBank_checkBox.UseVisualStyleBackColor = true;
            // 
            // sms_checkBox
            // 
            this.sms_checkBox.AutoSize = true;
            this.sms_checkBox.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sms_checkBox.Location = new System.Drawing.Point(7, 44);
            this.sms_checkBox.Name = "sms_checkBox";
            this.sms_checkBox.Size = new System.Drawing.Size(256, 24);
            this.sms_checkBox.TabIndex = 0;
            this.sms_checkBox.Text = "подключение СМС-оповещения";
            this.sms_checkBox.UseVisualStyleBackColor = true;
            // 
            // opendate_calendar
            // 
            this.opendate_calendar.Font = new System.Drawing.Font("Yu Gothic UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.opendate_calendar.Location = new System.Drawing.Point(461, 188);
            this.opendate_calendar.MaxDate = new System.DateTime(2022, 3, 15, 0, 0, 0, 0);
            this.opendate_calendar.Name = "opendate_calendar";
            this.opendate_calendar.Size = new System.Drawing.Size(294, 30);
            this.opendate_calendar.TabIndex = 4;
            this.opendate_calendar.Value = new System.DateTime(2022, 2, 22, 0, 0, 0, 0);
            // 
            // fullName_textBox
            // 
            this.fullName_textBox.BackColor = System.Drawing.Color.Silver;
            this.fullName_textBox.Font = new System.Drawing.Font("Yu Gothic UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fullName_textBox.Location = new System.Drawing.Point(77, 113);
            this.fullName_textBox.Name = "fullName_textBox";
            this.fullName_textBox.Size = new System.Drawing.Size(294, 30);
            this.fullName_textBox.TabIndex = 1;
            this.fullName_textBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.fullName_textBox_KeyDown);
            this.fullName_textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.fullName_textBox_KeyPress);
            // 
            // birthday_calendar
            // 
            this.birthday_calendar.CalendarMonthBackground = System.Drawing.Color.LavenderBlush;
            this.birthday_calendar.Font = new System.Drawing.Font("Yu Gothic UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.birthday_calendar.Location = new System.Drawing.Point(76, 188);
            this.birthday_calendar.MaxDate = new System.DateTime(2003, 12, 31, 0, 0, 0, 0);
            this.birthday_calendar.MinDate = new System.DateTime(1755, 1, 6, 0, 0, 0, 0);
            this.birthday_calendar.Name = "birthday_calendar";
            this.birthday_calendar.Size = new System.Drawing.Size(294, 30);
            this.birthday_calendar.TabIndex = 3;
            this.birthday_calendar.Value = new System.DateTime(2003, 12, 31, 0, 0, 0, 0);
            // 
            // sum_trackBar
            // 
            this.sum_trackBar.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.sum_trackBar.Location = new System.Drawing.Point(458, 264);
            this.sum_trackBar.Maximum = 120;
            this.sum_trackBar.Minimum = 100;
            this.sum_trackBar.Name = "sum_trackBar";
            this.sum_trackBar.Size = new System.Drawing.Size(297, 56);
            this.sum_trackBar.TabIndex = 6;
            this.sum_trackBar.Value = 100;
            this.sum_trackBar.Scroll += new System.EventHandler(this.sum_trackBar_Scroll);
            // 
            // number_textBox
            // 
            this.number_textBox.BackColor = System.Drawing.Color.Silver;
            this.number_textBox.Font = new System.Drawing.Font("Yu Gothic UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.number_textBox.Location = new System.Drawing.Point(462, 113);
            this.number_textBox.Name = "number_textBox";
            this.number_textBox.Size = new System.Drawing.Size(294, 30);
            this.number_textBox.TabIndex = 2;
            this.number_textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.number_textBox_KeyPress);
            // 
            // toFile_button
            // 
            this.toFile_button.BackColor = System.Drawing.Color.Silver;
            this.toFile_button.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.toFile_button.Location = new System.Drawing.Point(136, 715);
            this.toFile_button.Name = "toFile_button";
            this.toFile_button.Size = new System.Drawing.Size(215, 48);
            this.toFile_button.TabIndex = 17;
            this.toFile_button.Text = "Сохранить в файл";
            this.toFile_button.UseVisualStyleBackColor = false;
            this.toFile_button.Click += new System.EventHandler(this.toFile_button_Click);
            // 
            // fromFile_button
            // 
            this.fromFile_button.BackColor = System.Drawing.Color.Silver;
            this.fromFile_button.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fromFile_button.Location = new System.Drawing.Point(468, 715);
            this.fromFile_button.Name = "fromFile_button";
            this.fromFile_button.Size = new System.Drawing.Size(215, 48);
            this.fromFile_button.TabIndex = 18;
            this.fromFile_button.Text = "Загрузить из файла";
            this.fromFile_button.UseVisualStyleBackColor = false;
            this.fromFile_button.Click += new System.EventHandler(this.fromFile_button_Click);
            // 
            // reg_button
            // 
            this.reg_button.BackColor = System.Drawing.Color.Silver;
            this.reg_button.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.reg_button.Location = new System.Drawing.Point(136, 639);
            this.reg_button.Name = "reg_button";
            this.reg_button.Size = new System.Drawing.Size(547, 48);
            this.reg_button.TabIndex = 19;
            this.reg_button.Text = "Зарегистрировать";
            this.reg_button.UseVisualStyleBackColor = false;
            this.reg_button.Click += new System.EventHandler(this.reg_button_Click);
            // 
            // header
            // 
            this.header.AutoSize = true;
            this.header.Font = new System.Drawing.Font("Swis721 Blk BT", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.header.Location = new System.Drawing.Point(78, 39);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(136, 34);
            this.header.TabIndex = 21;
            this.header.Text = "MyBank";
            // 
            // contribType_comboBox
            // 
            this.contribType_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.contribType_comboBox.Font = new System.Drawing.Font("Yu Gothic UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.contribType_comboBox.FormattingEnabled = true;
            this.contribType_comboBox.Items.AddRange(new object[] {
            "Бессрочный",
            "Краткосрочный",
            "Долгосрочный"});
            this.contribType_comboBox.Location = new System.Drawing.Point(5, 29);
            this.contribType_comboBox.Name = "contribType_comboBox";
            this.contribType_comboBox.Size = new System.Drawing.Size(294, 31);
            this.contribType_comboBox.TabIndex = 22;
            // 
            // balance_textBox
            // 
            this.balance_textBox.Enabled = false;
            this.balance_textBox.Font = new System.Drawing.Font("Yu Gothic UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.balance_textBox.Location = new System.Drawing.Point(601, 237);
            this.balance_textBox.Name = "balance_textBox";
            this.balance_textBox.Size = new System.Drawing.Size(100, 25);
            this.balance_textBox.TabIndex = 36;
            this.balance_textBox.Text = "100";
            // 
            // fixedProc_radioButton
            // 
            this.fixedProc_radioButton.AutoSize = true;
            this.fixedProc_radioButton.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fixedProc_radioButton.Location = new System.Drawing.Point(8, 61);
            this.fixedProc_radioButton.Name = "fixedProc_radioButton";
            this.fixedProc_radioButton.Size = new System.Drawing.Size(277, 24);
            this.fixedProc_radioButton.TabIndex = 37;
            this.fixedProc_radioButton.TabStop = true;
            this.fixedProc_radioButton.Text = "Фиксированная процентная ставка";
            this.fixedProc_radioButton.UseVisualStyleBackColor = true;
            // 
            // floatProc_radioButton
            // 
            this.floatProc_radioButton.AutoSize = true;
            this.floatProc_radioButton.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.floatProc_radioButton.Location = new System.Drawing.Point(8, 88);
            this.floatProc_radioButton.Name = "floatProc_radioButton";
            this.floatProc_radioButton.Size = new System.Drawing.Size(249, 24);
            this.floatProc_radioButton.TabIndex = 38;
            this.floatProc_radioButton.TabStop = true;
            this.floatProc_radioButton.Text = "Плавающая процентная ставка";
            this.floatProc_radioButton.UseVisualStyleBackColor = true;
            // 
            // ContribTypeBox
            // 
            this.ContribTypeBox.Controls.Add(this.fixedProc_radioButton);
            this.ContribTypeBox.Controls.Add(this.floatProc_radioButton);
            this.ContribTypeBox.Controls.Add(this.contribType_comboBox);
            this.ContribTypeBox.Font = new System.Drawing.Font("Yu Gothic UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ContribTypeBox.Location = new System.Drawing.Point(458, 328);
            this.ContribTypeBox.Name = "ContribTypeBox";
            this.ContribTypeBox.Size = new System.Drawing.Size(305, 122);
            this.ContribTypeBox.TabIndex = 8;
            this.ContribTypeBox.TabStop = false;
            this.ContribTypeBox.Text = "Тип вклада";
            // 
            // BYN_label
            // 
            this.BYN_label.AutoSize = true;
            this.BYN_label.Font = new System.Drawing.Font("Yu Gothic UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BYN_label.Location = new System.Drawing.Point(705, 238);
            this.BYN_label.Name = "BYN_label";
            this.BYN_label.Size = new System.Drawing.Size(43, 23);
            this.BYN_label.TabIndex = 40;
            this.BYN_label.Text = "BYN";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SearchToolStripMenuItem,
            this.SortingToolStripMenuItem,
            this.ClearForm,
            this.AboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(842, 28);
            this.menuStrip1.TabIndex = 41;
            this.menuStrip1.Text = "Поиск";
            // 
            // SearchToolStripMenuItem
            // 
            this.SearchToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.SearchToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SrchNumberToolStripMenuItem,
            this.SrchFullNameToolStripMenuItem,
            this.SrchBalanceToolStripMenuItem,
            this.SrchContribTypeToolStripMenuItem});
            this.SearchToolStripMenuItem.Name = "SearchToolStripMenuItem";
            this.SearchToolStripMenuItem.Size = new System.Drawing.Size(66, 24);
            this.SearchToolStripMenuItem.Text = "Поиск";
            // 
            // SrchNumberToolStripMenuItem
            // 
            this.SrchNumberToolStripMenuItem.Name = "SrchNumberToolStripMenuItem";
            this.SrchNumberToolStripMenuItem.Size = new System.Drawing.Size(196, 26);
            this.SrchNumberToolStripMenuItem.Text = "по номеру";
            this.SrchNumberToolStripMenuItem.Click += new System.EventHandler(this.SrchNumberToolStripMenuItem_Click);
            // 
            // SrchFullNameToolStripMenuItem
            // 
            this.SrchFullNameToolStripMenuItem.Name = "SrchFullNameToolStripMenuItem";
            this.SrchFullNameToolStripMenuItem.Size = new System.Drawing.Size(196, 26);
            this.SrchFullNameToolStripMenuItem.Text = "по ФИО";
            this.SrchFullNameToolStripMenuItem.Click += new System.EventHandler(this.SrchFullNameToolStripMenuItem_Click);
            // 
            // SrchBalanceToolStripMenuItem
            // 
            this.SrchBalanceToolStripMenuItem.Name = "SrchBalanceToolStripMenuItem";
            this.SrchBalanceToolStripMenuItem.Size = new System.Drawing.Size(196, 26);
            this.SrchBalanceToolStripMenuItem.Text = "по балансу";
            this.SrchBalanceToolStripMenuItem.Click += new System.EventHandler(this.SrchBalanceToolStripMenuItem_Click);
            // 
            // SrchContribTypeToolStripMenuItem
            // 
            this.SrchContribTypeToolStripMenuItem.Name = "SrchContribTypeToolStripMenuItem";
            this.SrchContribTypeToolStripMenuItem.Size = new System.Drawing.Size(196, 26);
            this.SrchContribTypeToolStripMenuItem.Text = "по типу вклада";
            this.SrchContribTypeToolStripMenuItem.Click += new System.EventHandler(this.SrchContribTypeToolStripMenuItem_Click);
            // 
            // SortingToolStripMenuItem
            // 
            this.SortingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SortedComtrTTtoolStripMenuItem,
            this.SortedOpenDateToolStripMenuItem});
            this.SortingToolStripMenuItem.Name = "SortingToolStripMenuItem";
            this.SortingToolStripMenuItem.Size = new System.Drawing.Size(106, 24);
            this.SortingToolStripMenuItem.Text = "Сортировка";
            // 
            // SortedComtrTTtoolStripMenuItem
            // 
            this.SortedComtrTTtoolStripMenuItem.Name = "SortedComtrTTtoolStripMenuItem";
            this.SortedComtrTTtoolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.SortedComtrTTtoolStripMenuItem.Text = "по типу вклада";
            this.SortedComtrTTtoolStripMenuItem.Click += new System.EventHandler(this.SortedComtrTTtoolStripMenuItem_Click);
            // 
            // SortedOpenDateToolStripMenuItem
            // 
            this.SortedOpenDateToolStripMenuItem.Name = "SortedOpenDateToolStripMenuItem";
            this.SortedOpenDateToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.SortedOpenDateToolStripMenuItem.Text = "по дате открытия";
            this.SortedOpenDateToolStripMenuItem.Click += new System.EventHandler(this.SortedOpenDateToolStripMenuItem_Click);
            // 
            // ClearForm
            // 
            this.ClearForm.Name = "ClearForm";
            this.ClearForm.Size = new System.Drawing.Size(137, 24);
            this.ClearForm.Text = "Очистить форму";
            this.ClearForm.Click += new System.EventHandler(this.ClearForm_Click);
            // 
            // AboutToolStripMenuItem
            // 
            this.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem";
            this.AboutToolStripMenuItem.Size = new System.Drawing.Size(118, 24);
            this.AboutToolStripMenuItem.Text = "О программе";
            this.AboutToolStripMenuItem.Click += new System.EventHandler(this.AboutToolStripMenuItem_Click);
            // 
            // StatusStrip
            // 
            this.StatusStrip.BackColor = System.Drawing.Color.Transparent;
            this.StatusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.StatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CountOfItemsStatusLabel,
            this.lastActionStatusLabel});
            this.StatusStrip.Location = new System.Drawing.Point(0, 790);
            this.StatusStrip.Name = "StatusStrip";
            this.StatusStrip.Size = new System.Drawing.Size(842, 26);
            this.StatusStrip.TabIndex = 42;
            this.StatusStrip.Text = "statusStrip1";
            // 
            // CountOfItemsStatusLabel
            // 
            this.CountOfItemsStatusLabel.Name = "CountOfItemsStatusLabel";
            this.CountOfItemsStatusLabel.Size = new System.Drawing.Size(134, 20);
            this.CountOfItemsStatusLabel.Text = "Кол-во объектов: ";
            // 
            // lastActionStatusLabel
            // 
            this.lastActionStatusLabel.Name = "lastActionStatusLabel";
            this.lastActionStatusLabel.Size = new System.Drawing.Size(151, 20);
            this.lastActionStatusLabel.Text = "lastActionStatusLabel";
            // 
            // TopToolStrip
            // 
            this.TopToolStrip.BackColor = System.Drawing.Color.Transparent;
            this.TopToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.TopToolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.TopToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msUndo,
            this.msRedo,
            this.DelToolStripButton,
            this.toolStripSeparator1,
            this.HideToolStripButton});
            this.TopToolStrip.Location = new System.Drawing.Point(0, 28);
            this.TopToolStrip.Name = "TopToolStrip";
            this.TopToolStrip.Size = new System.Drawing.Size(774, 27);
            this.TopToolStrip.TabIndex = 43;
            this.TopToolStrip.Text = "toolStrip1";
            this.TopToolStrip.Visible = false;
            // 
            // msUndo
            // 
            this.msUndo.Image = ((System.Drawing.Image)(resources.GetObject("msUndo.Image")));
            this.msUndo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.msUndo.Name = "msUndo";
            this.msUndo.Size = new System.Drawing.Size(75, 24);
            this.msUndo.Text = "Назад";
            this.msUndo.Click += new System.EventHandler(this.msUndo_Click);
            // 
            // msRedo
            // 
            this.msRedo.Image = ((System.Drawing.Image)(resources.GetObject("msRedo.Image")));
            this.msRedo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.msRedo.Name = "msRedo";
            this.msRedo.Size = new System.Drawing.Size(84, 24);
            this.msRedo.Text = "Вперёд";
            this.msRedo.Click += new System.EventHandler(this.msRedo_Click);
            // 
            // DelToolStripButton
            // 
            this.DelToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("DelToolStripButton.Image")));
            this.DelToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.DelToolStripButton.Name = "DelToolStripButton";
            this.DelToolStripButton.Size = new System.Drawing.Size(89, 24);
            this.DelToolStripButton.Text = "Удалить";
            this.DelToolStripButton.Click += new System.EventHandler(this.DelToolStripButton_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // HideToolStripButton
            // 
            this.HideToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.HideToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("HideToolStripButton.Image")));
            this.HideToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.HideToolStripButton.Name = "HideToolStripButton";
            this.HideToolStripButton.Size = new System.Drawing.Size(63, 24);
            this.HideToolStripButton.Text = "Скрыть";
            this.HideToolStripButton.Click += new System.EventHandler(this.HideToolStripButton_Click);
            // 
            // ShowToolStripButton
            // 
            this.ShowToolStripButton.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ShowToolStripButton.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ShowToolStripButton.Location = new System.Drawing.Point(654, 23);
            this.ShowToolStripButton.Name = "ShowToolStripButton";
            this.ShowToolStripButton.Size = new System.Drawing.Size(95, 32);
            this.ShowToolStripButton.TabIndex = 44;
            this.ShowToolStripButton.Text = "Показать";
            this.ShowToolStripButton.UseVisualStyleBackColor = false;
            this.ShowToolStripButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // OutputBox
            // 
            this.OutputBox.BackColor = System.Drawing.Color.Silver;
            this.OutputBox.Location = new System.Drawing.Point(77, 484);
            this.OutputBox.Name = "OutputBox";
            this.OutputBox.ReadOnly = true;
            this.OutputBox.Size = new System.Drawing.Size(686, 136);
            this.OutputBox.TabIndex = 47;
            this.OutputBox.Text = "";
            // 
            // help_label
            // 
            this.help_label.AutoSize = true;
            this.help_label.BackColor = System.Drawing.Color.White;
            this.help_label.Font = new System.Drawing.Font("Yu Gothic UI Light", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.help_label.Location = new System.Drawing.Point(257, 224);
            this.help_label.Name = "help_label";
            this.help_label.Size = new System.Drawing.Size(260, 19);
            this.help_label.TabIndex = 48;
            this.help_label.Text = "Введите номер своего паспорта (33 стр.)";
            this.help_label.Visible = false;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(842, 816);
            this.Controls.Add(this.help_label);
            this.Controls.Add(this.OutputBox);
            this.Controls.Add(this.ShowToolStripButton);
            this.Controls.Add(this.TopToolStrip);
            this.Controls.Add(this.StatusStrip);
            this.Controls.Add(this.BYN_label);
            this.Controls.Add(this.ContribTypeBox);
            this.Controls.Add(this.balance_textBox);
            this.Controls.Add(this.header);
            this.Controls.Add(this.reg_button);
            this.Controls.Add(this.fromFile_button);
            this.Controls.Add(this.toFile_button);
            this.Controls.Add(this.number_textBox);
            this.Controls.Add(this.sum_trackBar);
            this.Controls.Add(this.birthday_calendar);
            this.Controls.Add(this.fullName_textBox);
            this.Controls.Add(this.opendate_calendar);
            this.Controls.Add(this.addServ);
            this.Controls.Add(this.passport_textBox);
            this.Controls.Add(this.sum);
            this.Controls.Add(this.openDate_label);
            this.Controls.Add(this.number_label);
            this.Controls.Add(this.passport_label);
            this.Controls.Add(this.birthday_label);
            this.Controls.Add(this.fullName_label);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Форма регистрация клиента";
            this.addServ.ResumeLayout(false);
            this.addServ.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sum_trackBar)).EndInit();
            this.ContribTypeBox.ResumeLayout(false);
            this.ContribTypeBox.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.StatusStrip.ResumeLayout(false);
            this.StatusStrip.PerformLayout();
            this.TopToolStrip.ResumeLayout(false);
            this.TopToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label fullName_label;
        private System.Windows.Forms.Label birthday_label;
        private System.Windows.Forms.Label passport_label;
        private System.Windows.Forms.Label number_label;
        private System.Windows.Forms.Label openDate_label;
        private System.Windows.Forms.Label sum;
        private System.Windows.Forms.TextBox passport_textBox;
        private System.Windows.Forms.GroupBox addServ;
        private System.Windows.Forms.CheckBox netBank_checkBox;
        private System.Windows.Forms.CheckBox sms_checkBox;
        private System.Windows.Forms.DateTimePicker opendate_calendar;
        private System.Windows.Forms.TextBox fullName_textBox;
        private System.Windows.Forms.DateTimePicker birthday_calendar;
        private System.Windows.Forms.TextBox number_textBox;
        private System.Windows.Forms.Button toFile_button;
        private System.Windows.Forms.Button fromFile_button;
        private System.Windows.Forms.Button reg_button;
        private System.Windows.Forms.Label header;
        private System.Windows.Forms.ComboBox contribType_comboBox;
        public System.Windows.Forms.TextBox balance_textBox;
        public System.Windows.Forms.TrackBar sum_trackBar;
        private System.Windows.Forms.RadioButton fixedProc_radioButton;
        private System.Windows.Forms.RadioButton floatProc_radioButton;
        private System.Windows.Forms.GroupBox ContribTypeBox;
        private System.Windows.Forms.Label BYN_label;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem SearchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SortingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SrchNumberToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SrchFullNameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SrchBalanceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SrchContribTypeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SortedComtrTTtoolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SortedOpenDateToolStripMenuItem;
        private System.Windows.Forms.StatusStrip StatusStrip;
        private System.Windows.Forms.ToolStrip TopToolStrip;
        private System.Windows.Forms.ToolStripButton msUndo;
        private System.Windows.Forms.ToolStripButton msRedo;
        private System.Windows.Forms.ToolStripButton DelToolStripButton;
        private System.Windows.Forms.ToolStripButton HideToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.Button ShowToolStripButton;
        private System.Windows.Forms.ToolStripStatusLabel CountOfItemsStatusLabel;
        private System.Windows.Forms.RichTextBox OutputBox;
        private System.Windows.Forms.ToolStripStatusLabel lastActionStatusLabel;
        private System.Windows.Forms.Label help_label;
        private System.Windows.Forms.ToolStripMenuItem ClearForm;
    }
}

