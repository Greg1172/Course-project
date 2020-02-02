namespace WindowsFormsApplication1
{
    partial class Kurs
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.button13 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.domainUpDown2 = new System.Windows.Forms.DomainUpDown();
            this.domainUpDown1 = new System.Windows.Forms.DomainUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Chocolate;
            this.panel1.Controls.Add(this.button13);
            this.panel1.Controls.Add(this.button12);
            this.panel1.Controls.Add(this.button10);
            this.panel1.Controls.Add(this.button9);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.dataGridView3);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.dataGridView2);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.domainUpDown2);
            this.panel1.Controls.Add(this.domainUpDown1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1247, 742);
            this.panel1.TabIndex = 0;
            // 
            // button13
            // 
            this.button13.BackColor = System.Drawing.Color.LightCoral;
            this.button13.Location = new System.Drawing.Point(334, 515);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(117, 35);
            this.button13.TabIndex = 33;
            this.button13.Text = "Перезапись матриц";
            this.button13.UseVisualStyleBackColor = false;
            this.button13.Click += new System.EventHandler(this.button13_Click);
            // 
            // button12
            // 
            this.button12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.button12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button12.Location = new System.Drawing.Point(487, 580);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(150, 66);
            this.button12.TabIndex = 32;
            this.button12.Text = "Записать результат в текстовый документ";
            this.button12.UseVisualStyleBackColor = false;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.button10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button10.Location = new System.Drawing.Point(487, 652);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(150, 66);
            this.button10.TabIndex = 29;
            this.button10.Text = "Вывести на принтер";
            this.button10.UseVisualStyleBackColor = false;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(440, 190);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(120, 60);
            this.button9.TabIndex = 28;
            this.button9.Text = "Выбор текстового файла";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(15, 58);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(304, 95);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Выберите способ ввода матриц:";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(13, 58);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(195, 20);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Из текстового документа";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(13, 32);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(85, 20);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Вручную";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // dataGridView3
            // 
            this.dataGridView3.AllowUserToAddRows = false;
            this.dataGridView3.AllowUserToDeleteRows = false;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.ColumnHeadersVisible = false;
            this.dataGridView3.Location = new System.Drawing.Point(132, 580);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.ReadOnly = true;
            this.dataGridView3.RowHeadersVisible = false;
            this.dataGridView3.Size = new System.Drawing.Size(301, 138);
            this.dataGridView3.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(12, 580);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 24);
            this.label6.TabIndex = 11;
            this.label6.Text = "N*M и M*N:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightCoral;
            this.button1.Location = new System.Drawing.Point(212, 515);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 35);
            this.button1.TabIndex = 10;
            this.button1.Text = "Результат";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.ColumnHeadersVisible = false;
            this.dataGridView2.Location = new System.Drawing.Point(212, 386);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.Size = new System.Drawing.Size(239, 114);
            this.dataGridView2.TabIndex = 9;
            this.dataGridView2.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellValueChanged);
            this.dataGridView2.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dataGridView2_EditingControlShowing);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(13, 386);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(168, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Элементы 2-ой матрицы:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.ColumnHeadersVisible = false;
            this.dataGridView1.Location = new System.Drawing.Point(212, 266);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(239, 114);
            this.dataGridView1.TabIndex = 7;
            this.dataGridView1.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellValueChanged);
            this.dataGridView1.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dataGridView1_EditingControlShowing);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(13, 266);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Элементы 1 матрицы:";
            // 
            // domainUpDown2
            // 
            this.domainUpDown2.Items.Add("1");
            this.domainUpDown2.Items.Add("2");
            this.domainUpDown2.Items.Add("3 ");
            this.domainUpDown2.Items.Add("4 ");
            this.domainUpDown2.Items.Add("5");
            this.domainUpDown2.Items.Add(" 6 ");
            this.domainUpDown2.Items.Add("7 ");
            this.domainUpDown2.Items.Add("8 ");
            this.domainUpDown2.Items.Add("9 ");
            this.domainUpDown2.Items.Add("10");
            this.domainUpDown2.Items.Add(" 11 ");
            this.domainUpDown2.Items.Add("12 ");
            this.domainUpDown2.Items.Add("13 ");
            this.domainUpDown2.Items.Add("14 ");
            this.domainUpDown2.Items.Add("15 ");
            this.domainUpDown2.Items.Add("16 ");
            this.domainUpDown2.Items.Add("17 ");
            this.domainUpDown2.Items.Add("18 ");
            this.domainUpDown2.Items.Add("19 ");
            this.domainUpDown2.Items.Add("20 ");
            this.domainUpDown2.Items.Add("21 ");
            this.domainUpDown2.Items.Add("22 ");
            this.domainUpDown2.Items.Add("23 ");
            this.domainUpDown2.Items.Add("24 ");
            this.domainUpDown2.Items.Add("25 ");
            this.domainUpDown2.Items.Add("26 ");
            this.domainUpDown2.Items.Add("27 ");
            this.domainUpDown2.Items.Add("28 ");
            this.domainUpDown2.Items.Add("29 ");
            this.domainUpDown2.Items.Add("30 ");
            this.domainUpDown2.Items.Add("31 ");
            this.domainUpDown2.Items.Add("32 ");
            this.domainUpDown2.Items.Add("33 ");
            this.domainUpDown2.Items.Add("34 ");
            this.domainUpDown2.Items.Add("35 ");
            this.domainUpDown2.Items.Add("36 ");
            this.domainUpDown2.Items.Add("37 ");
            this.domainUpDown2.Items.Add("38 ");
            this.domainUpDown2.Items.Add("39 ");
            this.domainUpDown2.Items.Add("40 ");
            this.domainUpDown2.Items.Add("41 ");
            this.domainUpDown2.Items.Add("42 ");
            this.domainUpDown2.Items.Add("43 ");
            this.domainUpDown2.Items.Add("44");
            this.domainUpDown2.Items.Add(" 45 ");
            this.domainUpDown2.Items.Add("46 ");
            this.domainUpDown2.Items.Add("47 ");
            this.domainUpDown2.Items.Add("48 ");
            this.domainUpDown2.Items.Add("49 ");
            this.domainUpDown2.Items.Add("50 ");
            this.domainUpDown2.Items.Add("51 ");
            this.domainUpDown2.Items.Add("52 ");
            this.domainUpDown2.Items.Add("53 ");
            this.domainUpDown2.Items.Add("54 ");
            this.domainUpDown2.Items.Add("55 ");
            this.domainUpDown2.Items.Add("56 ");
            this.domainUpDown2.Items.Add("57 ");
            this.domainUpDown2.Items.Add("58 ");
            this.domainUpDown2.Items.Add("59 ");
            this.domainUpDown2.Items.Add("60 ");
            this.domainUpDown2.Items.Add("61 ");
            this.domainUpDown2.Items.Add("62 ");
            this.domainUpDown2.Items.Add("63 ");
            this.domainUpDown2.Items.Add("64 ");
            this.domainUpDown2.Items.Add("65 ");
            this.domainUpDown2.Items.Add("66 ");
            this.domainUpDown2.Items.Add("67 ");
            this.domainUpDown2.Items.Add("68 ");
            this.domainUpDown2.Items.Add("69 ");
            this.domainUpDown2.Items.Add("70 ");
            this.domainUpDown2.Items.Add("71 ");
            this.domainUpDown2.Items.Add("72 ");
            this.domainUpDown2.Items.Add("73 ");
            this.domainUpDown2.Items.Add("74 ");
            this.domainUpDown2.Items.Add("75 ");
            this.domainUpDown2.Items.Add("76 ");
            this.domainUpDown2.Items.Add("77 ");
            this.domainUpDown2.Items.Add("78 ");
            this.domainUpDown2.Items.Add("79 ");
            this.domainUpDown2.Items.Add("80 ");
            this.domainUpDown2.Items.Add("81 ");
            this.domainUpDown2.Items.Add("82 ");
            this.domainUpDown2.Items.Add("83 ");
            this.domainUpDown2.Items.Add("84 ");
            this.domainUpDown2.Items.Add("85 ");
            this.domainUpDown2.Items.Add("86 ");
            this.domainUpDown2.Items.Add("87 ");
            this.domainUpDown2.Items.Add("88 ");
            this.domainUpDown2.Items.Add("89 ");
            this.domainUpDown2.Items.Add("90 ");
            this.domainUpDown2.Items.Add("91 ");
            this.domainUpDown2.Items.Add("92 ");
            this.domainUpDown2.Items.Add("93 ");
            this.domainUpDown2.Items.Add("94 ");
            this.domainUpDown2.Items.Add("95 ");
            this.domainUpDown2.Items.Add("96 ");
            this.domainUpDown2.Items.Add("97 ");
            this.domainUpDown2.Items.Add("98 ");
            this.domainUpDown2.Items.Add("99 ");
            this.domainUpDown2.Items.Add("100");
            this.domainUpDown2.Location = new System.Drawing.Point(285, 230);
            this.domainUpDown2.Name = "domainUpDown2";
            this.domainUpDown2.Size = new System.Drawing.Size(109, 20);
            this.domainUpDown2.TabIndex = 4;
            this.domainUpDown2.TextChanged += new System.EventHandler(this.domainUpDown2_SelectedItemChanged);
            this.domainUpDown2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.domainUpDown2_KeyPress);
            // 
            // domainUpDown1
            // 
            this.domainUpDown1.Items.Add("1");
            this.domainUpDown1.Items.Add("2");
            this.domainUpDown1.Items.Add("3 ");
            this.domainUpDown1.Items.Add("4 ");
            this.domainUpDown1.Items.Add("5");
            this.domainUpDown1.Items.Add(" 6 ");
            this.domainUpDown1.Items.Add("7 ");
            this.domainUpDown1.Items.Add("8 ");
            this.domainUpDown1.Items.Add("9 ");
            this.domainUpDown1.Items.Add("10");
            this.domainUpDown1.Items.Add(" 11 ");
            this.domainUpDown1.Items.Add("12 ");
            this.domainUpDown1.Items.Add("13 ");
            this.domainUpDown1.Items.Add("14 ");
            this.domainUpDown1.Items.Add("15 ");
            this.domainUpDown1.Items.Add("16 ");
            this.domainUpDown1.Items.Add("17 ");
            this.domainUpDown1.Items.Add("18 ");
            this.domainUpDown1.Items.Add("19 ");
            this.domainUpDown1.Items.Add("20 ");
            this.domainUpDown1.Items.Add("21 ");
            this.domainUpDown1.Items.Add("22 ");
            this.domainUpDown1.Items.Add("23 ");
            this.domainUpDown1.Items.Add("24 ");
            this.domainUpDown1.Items.Add("25 ");
            this.domainUpDown1.Items.Add("26 ");
            this.domainUpDown1.Items.Add("27 ");
            this.domainUpDown1.Items.Add("28 ");
            this.domainUpDown1.Items.Add("29 ");
            this.domainUpDown1.Items.Add("30 ");
            this.domainUpDown1.Items.Add("31 ");
            this.domainUpDown1.Items.Add("32 ");
            this.domainUpDown1.Items.Add("33 ");
            this.domainUpDown1.Items.Add("34 ");
            this.domainUpDown1.Items.Add("35 ");
            this.domainUpDown1.Items.Add("36 ");
            this.domainUpDown1.Items.Add("37 ");
            this.domainUpDown1.Items.Add("38 ");
            this.domainUpDown1.Items.Add("39 ");
            this.domainUpDown1.Items.Add("40 ");
            this.domainUpDown1.Items.Add("41 ");
            this.domainUpDown1.Items.Add("42 ");
            this.domainUpDown1.Items.Add("43 ");
            this.domainUpDown1.Items.Add("44");
            this.domainUpDown1.Items.Add(" 45 ");
            this.domainUpDown1.Items.Add("46 ");
            this.domainUpDown1.Items.Add("47 ");
            this.domainUpDown1.Items.Add("48 ");
            this.domainUpDown1.Items.Add("49 ");
            this.domainUpDown1.Items.Add("50 ");
            this.domainUpDown1.Items.Add("51 ");
            this.domainUpDown1.Items.Add("52 ");
            this.domainUpDown1.Items.Add("53 ");
            this.domainUpDown1.Items.Add("54 ");
            this.domainUpDown1.Items.Add("55 ");
            this.domainUpDown1.Items.Add("56 ");
            this.domainUpDown1.Items.Add("57 ");
            this.domainUpDown1.Items.Add("58 ");
            this.domainUpDown1.Items.Add("59 ");
            this.domainUpDown1.Items.Add("60 ");
            this.domainUpDown1.Items.Add("61 ");
            this.domainUpDown1.Items.Add("62 ");
            this.domainUpDown1.Items.Add("63 ");
            this.domainUpDown1.Items.Add("64 ");
            this.domainUpDown1.Items.Add("65 ");
            this.domainUpDown1.Items.Add("66 ");
            this.domainUpDown1.Items.Add("67 ");
            this.domainUpDown1.Items.Add("68 ");
            this.domainUpDown1.Items.Add("69 ");
            this.domainUpDown1.Items.Add("70 ");
            this.domainUpDown1.Items.Add("71 ");
            this.domainUpDown1.Items.Add("72 ");
            this.domainUpDown1.Items.Add("73 ");
            this.domainUpDown1.Items.Add("74 ");
            this.domainUpDown1.Items.Add("75 ");
            this.domainUpDown1.Items.Add("76 ");
            this.domainUpDown1.Items.Add("77 ");
            this.domainUpDown1.Items.Add("78 ");
            this.domainUpDown1.Items.Add("79 ");
            this.domainUpDown1.Items.Add("80 ");
            this.domainUpDown1.Items.Add("81 ");
            this.domainUpDown1.Items.Add("82 ");
            this.domainUpDown1.Items.Add("83 ");
            this.domainUpDown1.Items.Add("84 ");
            this.domainUpDown1.Items.Add("85 ");
            this.domainUpDown1.Items.Add("86 ");
            this.domainUpDown1.Items.Add("87 ");
            this.domainUpDown1.Items.Add("88 ");
            this.domainUpDown1.Items.Add("89 ");
            this.domainUpDown1.Items.Add("90 ");
            this.domainUpDown1.Items.Add("91 ");
            this.domainUpDown1.Items.Add("92 ");
            this.domainUpDown1.Items.Add("93 ");
            this.domainUpDown1.Items.Add("94 ");
            this.domainUpDown1.Items.Add("95 ");
            this.domainUpDown1.Items.Add("96 ");
            this.domainUpDown1.Items.Add("97 ");
            this.domainUpDown1.Items.Add("98 ");
            this.domainUpDown1.Items.Add("99 ");
            this.domainUpDown1.Items.Add("100");
            this.domainUpDown1.Location = new System.Drawing.Point(285, 193);
            this.domainUpDown1.Name = "domainUpDown1";
            this.domainUpDown1.Size = new System.Drawing.Size(109, 20);
            this.domainUpDown1.TabIndex = 3;
            this.domainUpDown1.TextChanged += new System.EventHandler(this.domainUpDown1_SelectedItemChanged);
            this.domainUpDown1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.domainUpDown1_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(12, 230);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(267, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Введите кол-во столбцов 1-ой матрице:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 197);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(253, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Введите кол-во строк в 1-ой матрице:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(294, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(628, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Перемножение матриц N*M и M*N ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Kurs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1247, 742);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Kurs";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Перемножение матриц N*M и M*N";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DomainUpDown domainUpDown1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DomainUpDown domainUpDown2;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton1;
        public System.Windows.Forms.DataGridView dataGridView1;
        public System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button13;
    }
}

