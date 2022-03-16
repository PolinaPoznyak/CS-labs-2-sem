
namespace Bank
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
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
            this.clean_button = new System.Windows.Forms.Button();
            this.toFile_button = new System.Windows.Forms.Button();
            this.fromFile_button = new System.Windows.Forms.Button();
            this.reg_button = new System.Windows.Forms.Button();
            this.OutputBox = new System.Windows.Forms.TextBox();
            this.header = new System.Windows.Forms.Label();
            this.contribType_comboBox = new System.Windows.Forms.ComboBox();
            this.balance_textBox = new System.Windows.Forms.TextBox();
            this.fixedProc_radioButton = new System.Windows.Forms.RadioButton();
            this.floatProc_radioButton = new System.Windows.Forms.RadioButton();
            this.ContribTypeBox = new System.Windows.Forms.GroupBox();
            this.BYN_label = new System.Windows.Forms.Label();
            this.addServ.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sum_trackBar)).BeginInit();
            this.ContribTypeBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // fullName_label
            // 
            this.fullName_label.AutoSize = true;
            this.fullName_label.Font = new System.Drawing.Font("Yu Gothic UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fullName_label.Location = new System.Drawing.Point(31, 87);
            this.fullName_label.Name = "fullName_label";
            this.fullName_label.Size = new System.Drawing.Size(49, 23);
            this.fullName_label.TabIndex = 0;
            this.fullName_label.Text = "ФИО";
            // 
            // birthday_label
            // 
            this.birthday_label.AutoSize = true;
            this.birthday_label.Font = new System.Drawing.Font("Yu Gothic UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.birthday_label.Location = new System.Drawing.Point(33, 157);
            this.birthday_label.Name = "birthday_label";
            this.birthday_label.Size = new System.Drawing.Size(133, 23);
            this.birthday_label.TabIndex = 1;
            this.birthday_label.Text = "Дата рождения";
            // 
            // passport_label
            // 
            this.passport_label.AutoSize = true;
            this.passport_label.Font = new System.Drawing.Font("Yu Gothic UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passport_label.Location = new System.Drawing.Point(33, 234);
            this.passport_label.Name = "passport_label";
            this.passport_label.Size = new System.Drawing.Size(175, 23);
            this.passport_label.TabIndex = 2;
            this.passport_label.Text = "Паспортные данные";
            // 
            // number_label
            // 
            this.number_label.AutoSize = true;
            this.number_label.Font = new System.Drawing.Font("Yu Gothic UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.number_label.Location = new System.Drawing.Point(366, 87);
            this.number_label.Name = "number_label";
            this.number_label.Size = new System.Drawing.Size(113, 23);
            this.number_label.TabIndex = 4;
            this.number_label.Text = "Номер счёта";
            // 
            // openDate_label
            // 
            this.openDate_label.AutoSize = true;
            this.openDate_label.Font = new System.Drawing.Font("Yu Gothic UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.openDate_label.Location = new System.Drawing.Point(366, 157);
            this.openDate_label.Name = "openDate_label";
            this.openDate_label.Size = new System.Drawing.Size(175, 23);
            this.openDate_label.TabIndex = 5;
            this.openDate_label.Text = "Дата открытия счёта";
            // 
            // sum
            // 
            this.sum.AutoSize = true;
            this.sum.Font = new System.Drawing.Font("Yu Gothic UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sum.Location = new System.Drawing.Point(366, 234);
            this.sum.Name = "sum";
            this.sum.Size = new System.Drawing.Size(126, 23);
            this.sum.TabIndex = 6;
            this.sum.Text = "Сумма вклада";
            // 
            // passport_textBox
            // 
            this.passport_textBox.BackColor = System.Drawing.Color.Silver;
            this.passport_textBox.Font = new System.Drawing.Font("Yu Gothic UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passport_textBox.Location = new System.Drawing.Point(31, 260);
            this.passport_textBox.Name = "passport_textBox";
            this.passport_textBox.Size = new System.Drawing.Size(293, 30);
            this.passport_textBox.TabIndex = 8;
            // 
            // addServ
            // 
            this.addServ.Controls.Add(this.netBank_checkBox);
            this.addServ.Controls.Add(this.sms_checkBox);
            this.addServ.Font = new System.Drawing.Font("Yu Gothic UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addServ.Location = new System.Drawing.Point(31, 318);
            this.addServ.Name = "addServ";
            this.addServ.Size = new System.Drawing.Size(293, 122);
            this.addServ.TabIndex = 9;
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
            this.opendate_calendar.Location = new System.Drawing.Point(359, 188);
            this.opendate_calendar.MaxDate = new System.DateTime(2022, 2, 22, 0, 0, 0, 0);
            this.opendate_calendar.Name = "opendate_calendar";
            this.opendate_calendar.Size = new System.Drawing.Size(294, 30);
            this.opendate_calendar.TabIndex = 10;
            this.opendate_calendar.Value = new System.DateTime(2022, 2, 22, 0, 0, 0, 0);
            // 
            // fullName_textBox
            // 
            this.fullName_textBox.BackColor = System.Drawing.Color.Silver;
            this.fullName_textBox.Font = new System.Drawing.Font("Yu Gothic UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fullName_textBox.Location = new System.Drawing.Point(30, 113);
            this.fullName_textBox.Name = "fullName_textBox";
            this.fullName_textBox.Size = new System.Drawing.Size(294, 30);
            this.fullName_textBox.TabIndex = 11;
            this.fullName_textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.fullName_textBox_KeyPress);
            // 
            // birthday_calendar
            // 
            this.birthday_calendar.CalendarMonthBackground = System.Drawing.Color.LavenderBlush;
            this.birthday_calendar.Font = new System.Drawing.Font("Yu Gothic UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.birthday_calendar.Location = new System.Drawing.Point(30, 188);
            this.birthday_calendar.MaxDate = new System.DateTime(2003, 12, 31, 0, 0, 0, 0);
            this.birthday_calendar.MinDate = new System.DateTime(1755, 1, 6, 0, 0, 0, 0);
            this.birthday_calendar.Name = "birthday_calendar";
            this.birthday_calendar.Size = new System.Drawing.Size(294, 30);
            this.birthday_calendar.TabIndex = 12;
            this.birthday_calendar.Value = new System.DateTime(2003, 12, 31, 0, 0, 0, 0);
            // 
            // sum_trackBar
            // 
            this.sum_trackBar.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.sum_trackBar.Location = new System.Drawing.Point(356, 264);
            this.sum_trackBar.Maximum = 120;
            this.sum_trackBar.Minimum = 100;
            this.sum_trackBar.Name = "sum_trackBar";
            this.sum_trackBar.Size = new System.Drawing.Size(297, 56);
            this.sum_trackBar.TabIndex = 35;
            this.sum_trackBar.Value = 100;
            this.sum_trackBar.Scroll += new System.EventHandler(this.sum_trackBar_Scroll);
            // 
            // number_textBox
            // 
            this.number_textBox.BackColor = System.Drawing.Color.Silver;
            this.number_textBox.Font = new System.Drawing.Font("Yu Gothic UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.number_textBox.Location = new System.Drawing.Point(359, 113);
            this.number_textBox.Name = "number_textBox";
            this.number_textBox.Size = new System.Drawing.Size(294, 30);
            this.number_textBox.TabIndex = 14;
            this.number_textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.number_textBox_KeyPress);
            // 
            // clean_button
            // 
            this.clean_button.BackColor = System.Drawing.Color.Silver;
            this.clean_button.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.clean_button.Location = new System.Drawing.Point(90, 615);
            this.clean_button.Name = "clean_button";
            this.clean_button.Size = new System.Drawing.Size(215, 48);
            this.clean_button.TabIndex = 16;
            this.clean_button.Text = "Очистить";
            this.clean_button.UseVisualStyleBackColor = false;
            this.clean_button.Click += new System.EventHandler(this.clean_button_Click);
            // 
            // toFile_button
            // 
            this.toFile_button.BackColor = System.Drawing.Color.Silver;
            this.toFile_button.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.toFile_button.Location = new System.Drawing.Point(90, 691);
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
            this.fromFile_button.Location = new System.Drawing.Point(384, 691);
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
            this.reg_button.Location = new System.Drawing.Point(384, 615);
            this.reg_button.Name = "reg_button";
            this.reg_button.Size = new System.Drawing.Size(215, 48);
            this.reg_button.TabIndex = 19;
            this.reg_button.Text = "Записать данные";
            this.reg_button.UseVisualStyleBackColor = false;
            this.reg_button.Click += new System.EventHandler(this.reg_button_Click);
            // 
            // OutputBox
            // 
            this.OutputBox.BackColor = System.Drawing.Color.Silver;
            this.OutputBox.Location = new System.Drawing.Point(30, 460);
            this.OutputBox.Multiline = true;
            this.OutputBox.Name = "OutputBox";
            this.OutputBox.ReadOnly = true;
            this.OutputBox.Size = new System.Drawing.Size(631, 136);
            this.OutputBox.TabIndex = 20;
            // 
            // header
            // 
            this.header.AutoSize = true;
            this.header.Font = new System.Drawing.Font("Swis721 Blk BT", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.header.Location = new System.Drawing.Point(31, 32);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(136, 34);
            this.header.TabIndex = 21;
            this.header.Text = "MyBank";
            // 
            // contribType_comboBox
            // 
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
            this.balance_textBox.Location = new System.Drawing.Point(499, 237);
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
            this.ContribTypeBox.Location = new System.Drawing.Point(356, 318);
            this.ContribTypeBox.Name = "ContribTypeBox";
            this.ContribTypeBox.Size = new System.Drawing.Size(305, 122);
            this.ContribTypeBox.TabIndex = 39;
            this.ContribTypeBox.TabStop = false;
            this.ContribTypeBox.Text = "Тип вклада";
            // 
            // BYN_label
            // 
            this.BYN_label.AutoSize = true;
            this.BYN_label.Font = new System.Drawing.Font("Yu Gothic UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BYN_label.Location = new System.Drawing.Point(603, 238);
            this.BYN_label.Name = "BYN_label";
            this.BYN_label.Size = new System.Drawing.Size(43, 23);
            this.BYN_label.TabIndex = 40;
            this.BYN_label.Text = "BYN";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(702, 763);
            this.Controls.Add(this.BYN_label);
            this.Controls.Add(this.ContribTypeBox);
            this.Controls.Add(this.balance_textBox);
            this.Controls.Add(this.header);
            this.Controls.Add(this.OutputBox);
            this.Controls.Add(this.reg_button);
            this.Controls.Add(this.fromFile_button);
            this.Controls.Add(this.toFile_button);
            this.Controls.Add(this.clean_button);
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
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bank registration";
            this.addServ.ResumeLayout(false);
            this.addServ.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sum_trackBar)).EndInit();
            this.ContribTypeBox.ResumeLayout(false);
            this.ContribTypeBox.PerformLayout();
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
        private System.Windows.Forms.Button clean_button;
        private System.Windows.Forms.Button toFile_button;
        private System.Windows.Forms.Button fromFile_button;
        private System.Windows.Forms.Button reg_button;
        private System.Windows.Forms.TextBox OutputBox;
        private System.Windows.Forms.Label header;
        private System.Windows.Forms.ComboBox contribType_comboBox;
        public System.Windows.Forms.TextBox balance_textBox;
        public System.Windows.Forms.TrackBar sum_trackBar;
        private System.Windows.Forms.RadioButton fixedProc_radioButton;
        private System.Windows.Forms.RadioButton floatProc_radioButton;
        private System.Windows.Forms.GroupBox ContribTypeBox;
        private System.Windows.Forms.Label BYN_label;
    }
}

