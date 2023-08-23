namespace ElasticCollision
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.startStopBtn = new System.Windows.Forms.Button();
            this.resetBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.restitutionCoefficientLabel1 = new System.Windows.Forms.Label();
            this.ballMaterialLabel1 = new System.Windows.Forms.Label();
            this.materialComboBox1 = new System.Windows.Forms.ComboBox();
            this.radiusLabel1 = new System.Windows.Forms.Label();
            this.massLabel1 = new System.Windows.Forms.Label();
            this.radiusNumeric1 = new System.Windows.Forms.NumericUpDown();
            this.massNumeric1 = new System.Windows.Forms.NumericUpDown();
            this.velocityNumeric1 = new System.Windows.Forms.NumericUpDown();
            this.startVelocityLabel1 = new System.Windows.Forms.Label();
            this.energyLabel1 = new System.Windows.Forms.Label();
            this.velocityLabel1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.restitutionCoefficientLabel2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.materialComboBox2 = new System.Windows.Forms.ComboBox();
            this.energyLabel2 = new System.Windows.Forms.Label();
            this.velocityLabel2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.frictionCoefficientLabel1 = new System.Windows.Forms.Label();
            this.restitutionCoefficientLabel3 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.materialComboBox4 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.materialComboBox3 = new System.Windows.Forms.ComboBox();
            this.setDefaultBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.velocityNumeric2 = new System.Windows.Forms.NumericUpDown();
            this.massNumeric2 = new System.Windows.Forms.NumericUpDown();
            this.radiusNumeric2 = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radiusNumeric1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.massNumeric1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.velocityNumeric1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.velocityNumeric2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.massNumeric2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radiusNumeric2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(830, 100);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox_Paint);
            // 
            // startStopBtn
            // 
            this.startStopBtn.BackColor = System.Drawing.SystemColors.Control;
            this.startStopBtn.Location = new System.Drawing.Point(848, 62);
            this.startStopBtn.Name = "startStopBtn";
            this.startStopBtn.Size = new System.Drawing.Size(122, 50);
            this.startStopBtn.TabIndex = 1;
            this.startStopBtn.Text = "Запуск";
            this.startStopBtn.UseVisualStyleBackColor = false;
            this.startStopBtn.Click += new System.EventHandler(this.startBtn_Click);
            // 
            // resetBtn
            // 
            this.resetBtn.BackColor = System.Drawing.SystemColors.Control;
            this.resetBtn.Location = new System.Drawing.Point(848, 12);
            this.resetBtn.Name = "resetBtn";
            this.resetBtn.Size = new System.Drawing.Size(122, 50);
            this.resetBtn.TabIndex = 2;
            this.resetBtn.Text = "Перезапуск";
            this.resetBtn.UseVisualStyleBackColor = false;
            this.resetBtn.Click += new System.EventHandler(this.resetBtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.restitutionCoefficientLabel1);
            this.groupBox1.Controls.Add(this.ballMaterialLabel1);
            this.groupBox1.Controls.Add(this.materialComboBox1);
            this.groupBox1.Controls.Add(this.radiusLabel1);
            this.groupBox1.Controls.Add(this.massLabel1);
            this.groupBox1.Controls.Add(this.radiusNumeric1);
            this.groupBox1.Controls.Add(this.massNumeric1);
            this.groupBox1.Controls.Add(this.velocityNumeric1);
            this.groupBox1.Controls.Add(this.startVelocityLabel1);
            this.groupBox1.Controls.Add(this.energyLabel1);
            this.groupBox1.Controls.Add(this.velocityLabel1);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.groupBox1.Location = new System.Drawing.Point(12, 118);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(415, 337);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Шар №1";
            // 
            // restitutionCoefficientLabel1
            // 
            this.restitutionCoefficientLabel1.AutoSize = true;
            this.restitutionCoefficientLabel1.Location = new System.Drawing.Point(6, 81);
            this.restitutionCoefficientLabel1.Name = "restitutionCoefficientLabel1";
            this.restitutionCoefficientLabel1.Size = new System.Drawing.Size(175, 16);
            this.restitutionCoefficientLabel1.TabIndex = 11;
            this.restitutionCoefficientLabel1.Text = "Коэфф упругости шара ---";
            // 
            // ballMaterialLabel1
            // 
            this.ballMaterialLabel1.AutoSize = true;
            this.ballMaterialLabel1.Location = new System.Drawing.Point(6, 290);
            this.ballMaterialLabel1.Name = "ballMaterialLabel1";
            this.ballMaterialLabel1.Size = new System.Drawing.Size(109, 16);
            this.ballMaterialLabel1.TabIndex = 10;
            this.ballMaterialLabel1.Text = "Материал шара";
            // 
            // materialComboBox1
            // 
            this.materialComboBox1.FormattingEnabled = true;
            this.materialComboBox1.Location = new System.Drawing.Point(262, 287);
            this.materialComboBox1.Name = "materialComboBox1";
            this.materialComboBox1.Size = new System.Drawing.Size(147, 24);
            this.materialComboBox1.TabIndex = 9;
            this.materialComboBox1.Tag = "0";
            this.materialComboBox1.SelectedIndexChanged += new System.EventHandler(this.materialComboBox_SelectedIndexChanged);
            // 
            // radiusLabel1
            // 
            this.radiusLabel1.AutoSize = true;
            this.radiusLabel1.Location = new System.Drawing.Point(6, 246);
            this.radiusLabel1.Name = "radiusLabel1";
            this.radiusLabel1.Size = new System.Drawing.Size(103, 16);
            this.radiusLabel1.TabIndex = 8;
            this.radiusLabel1.Text = "Радиус шара м";
            // 
            // massLabel1
            // 
            this.massLabel1.AutoSize = true;
            this.massLabel1.Location = new System.Drawing.Point(6, 218);
            this.massLabel1.Name = "massLabel1";
            this.massLabel1.Size = new System.Drawing.Size(100, 16);
            this.massLabel1.TabIndex = 7;
            this.massLabel1.Text = "Масса шара кг";
            // 
            // radiusNumeric1
            // 
            this.radiusNumeric1.DecimalPlaces = 1;
            this.radiusNumeric1.Location = new System.Drawing.Point(333, 240);
            this.radiusNumeric1.Maximum = new decimal(new int[] {
            40,
            0,
            0,
            0});
            this.radiusNumeric1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.radiusNumeric1.Name = "radiusNumeric1";
            this.radiusNumeric1.Size = new System.Drawing.Size(76, 22);
            this.radiusNumeric1.TabIndex = 6;
            this.radiusNumeric1.Tag = "4";
            this.radiusNumeric1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.radiusNumeric1.ValueChanged += new System.EventHandler(this.NumericUpDown_ValueChanged);
            // 
            // massNumeric1
            // 
            this.massNumeric1.DecimalPlaces = 1;
            this.massNumeric1.Location = new System.Drawing.Point(333, 212);
            this.massNumeric1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.massNumeric1.Name = "massNumeric1";
            this.massNumeric1.Size = new System.Drawing.Size(76, 22);
            this.massNumeric1.TabIndex = 5;
            this.massNumeric1.Tag = "2";
            this.massNumeric1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.massNumeric1.ValueChanged += new System.EventHandler(this.NumericUpDown_ValueChanged);
            // 
            // velocityNumeric1
            // 
            this.velocityNumeric1.DecimalPlaces = 1;
            this.velocityNumeric1.Location = new System.Drawing.Point(333, 184);
            this.velocityNumeric1.Maximum = new decimal(new int[] {
            400,
            0,
            0,
            0});
            this.velocityNumeric1.Minimum = new decimal(new int[] {
            400,
            0,
            0,
            -2147483648});
            this.velocityNumeric1.Name = "velocityNumeric1";
            this.velocityNumeric1.Size = new System.Drawing.Size(76, 22);
            this.velocityNumeric1.TabIndex = 4;
            this.velocityNumeric1.Tag = "0";
            this.velocityNumeric1.ValueChanged += new System.EventHandler(this.NumericUpDown_ValueChanged);
            // 
            // startVelocityLabel1
            // 
            this.startVelocityLabel1.AutoSize = true;
            this.startVelocityLabel1.Location = new System.Drawing.Point(6, 190);
            this.startVelocityLabel1.Name = "startVelocityLabel1";
            this.startVelocityLabel1.Size = new System.Drawing.Size(200, 16);
            this.startVelocityLabel1.TabIndex = 3;
            this.startVelocityLabel1.Text = "Начальная скорость шара м/с";
            // 
            // energyLabel1
            // 
            this.energyLabel1.AutoSize = true;
            this.energyLabel1.Location = new System.Drawing.Point(6, 52);
            this.energyLabel1.Name = "energyLabel1";
            this.energyLabel1.Size = new System.Drawing.Size(240, 16);
            this.energyLabel1.TabIndex = 2;
            this.energyLabel1.Text = "Кинетическая энергия шара : --- кДж";
            // 
            // velocityLabel1
            // 
            this.velocityLabel1.AutoSize = true;
            this.velocityLabel1.Location = new System.Drawing.Point(6, 27);
            this.velocityLabel1.Name = "velocityLabel1";
            this.velocityLabel1.Size = new System.Drawing.Size(148, 16);
            this.velocityLabel1.TabIndex = 1;
            this.velocityLabel1.Text = "Скорость шара : --- м/с";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox2.Controls.Add(this.radiusNumeric2);
            this.groupBox2.Controls.Add(this.massNumeric2);
            this.groupBox2.Controls.Add(this.velocityNumeric2);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.restitutionCoefficientLabel2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.materialComboBox2);
            this.groupBox2.Controls.Add(this.energyLabel2);
            this.groupBox2.Controls.Add(this.velocityLabel2);
            this.groupBox2.ForeColor = System.Drawing.Color.Red;
            this.groupBox2.Location = new System.Drawing.Point(433, 118);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(409, 337);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Шар №2";
            // 
            // restitutionCoefficientLabel2
            // 
            this.restitutionCoefficientLabel2.AutoSize = true;
            this.restitutionCoefficientLabel2.Location = new System.Drawing.Point(6, 81);
            this.restitutionCoefficientLabel2.Name = "restitutionCoefficientLabel2";
            this.restitutionCoefficientLabel2.Size = new System.Drawing.Size(175, 16);
            this.restitutionCoefficientLabel2.TabIndex = 13;
            this.restitutionCoefficientLabel2.Text = "Коэфф упругости шара ---";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 290);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 16);
            this.label1.TabIndex = 11;
            this.label1.Text = "Материал шара";
            // 
            // materialComboBox2
            // 
            this.materialComboBox2.FormattingEnabled = true;
            this.materialComboBox2.Location = new System.Drawing.Point(256, 287);
            this.materialComboBox2.Name = "materialComboBox2";
            this.materialComboBox2.Size = new System.Drawing.Size(147, 24);
            this.materialComboBox2.TabIndex = 12;
            this.materialComboBox2.Tag = "1";
            this.materialComboBox2.SelectedIndexChanged += new System.EventHandler(this.materialComboBox_SelectedIndexChanged);
            // 
            // energyLabel2
            // 
            this.energyLabel2.AutoSize = true;
            this.energyLabel2.Location = new System.Drawing.Point(6, 52);
            this.energyLabel2.Name = "energyLabel2";
            this.energyLabel2.Size = new System.Drawing.Size(240, 16);
            this.energyLabel2.TabIndex = 3;
            this.energyLabel2.Text = "Кинетическая энергия шара : --- кДж";
            // 
            // velocityLabel2
            // 
            this.velocityLabel2.AutoSize = true;
            this.velocityLabel2.Location = new System.Drawing.Point(6, 27);
            this.velocityLabel2.Name = "velocityLabel2";
            this.velocityLabel2.Size = new System.Drawing.Size(148, 16);
            this.velocityLabel2.TabIndex = 2;
            this.velocityLabel2.Text = "Скорость шара : --- м/с";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox3.Controls.Add(this.frictionCoefficientLabel1);
            this.groupBox3.Controls.Add(this.restitutionCoefficientLabel3);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.materialComboBox4);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.materialComboBox3);
            this.groupBox3.ForeColor = System.Drawing.Color.Green;
            this.groupBox3.Location = new System.Drawing.Point(12, 461);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(830, 133);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Окружение";
            // 
            // frictionCoefficientLabel1
            // 
            this.frictionCoefficientLabel1.AutoSize = true;
            this.frictionCoefficientLabel1.Location = new System.Drawing.Point(427, 30);
            this.frictionCoefficientLabel1.Name = "frictionCoefficientLabel1";
            this.frictionCoefficientLabel1.Size = new System.Drawing.Size(102, 16);
            this.frictionCoefficientLabel1.TabIndex = 5;
            this.frictionCoefficientLabel1.Text = "Коэфф трения";
            // 
            // restitutionCoefficientLabel3
            // 
            this.restitutionCoefficientLabel3.AutoSize = true;
            this.restitutionCoefficientLabel3.Location = new System.Drawing.Point(6, 30);
            this.restitutionCoefficientLabel3.Name = "restitutionCoefficientLabel3";
            this.restitutionCoefficientLabel3.Size = new System.Drawing.Size(157, 16);
            this.restitutionCoefficientLabel3.TabIndex = 4;
            this.restitutionCoefficientLabel3.Text = "Коэфф упругости стен";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(427, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(160, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Материал поверхности";
            // 
            // materialComboBox4
            // 
            this.materialComboBox4.FormattingEnabled = true;
            this.materialComboBox4.Location = new System.Drawing.Point(677, 70);
            this.materialComboBox4.Name = "materialComboBox4";
            this.materialComboBox4.Size = new System.Drawing.Size(147, 24);
            this.materialComboBox4.TabIndex = 2;
            this.materialComboBox4.Tag = "3";
            this.materialComboBox4.SelectedIndexChanged += new System.EventHandler(this.materialComboBox_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Материал стен";
            // 
            // materialComboBox3
            // 
            this.materialComboBox3.FormattingEnabled = true;
            this.materialComboBox3.Location = new System.Drawing.Point(262, 70);
            this.materialComboBox3.Name = "materialComboBox3";
            this.materialComboBox3.Size = new System.Drawing.Size(147, 24);
            this.materialComboBox3.TabIndex = 0;
            this.materialComboBox3.Tag = "2";
            this.materialComboBox3.SelectedIndexChanged += new System.EventHandler(this.materialComboBox_SelectedIndexChanged);
            // 
            // setDefaultBtn
            // 
            this.setDefaultBtn.Location = new System.Drawing.Point(848, 118);
            this.setDefaultBtn.Name = "setDefaultBtn";
            this.setDefaultBtn.Size = new System.Drawing.Size(120, 50);
            this.setDefaultBtn.TabIndex = 6;
            this.setDefaultBtn.Text = "По-умолчанию";
            this.setDefaultBtn.UseVisualStyleBackColor = true;
            this.setDefaultBtn.Click += new System.EventHandler(this.setDefaultBtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(200, 16);
            this.label4.TabIndex = 12;
            this.label4.Text = "Начальная скорость шара м/с";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 214);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 16);
            this.label5.TabIndex = 12;
            this.label5.Text = "Масса шара кг";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 242);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 16);
            this.label6.TabIndex = 12;
            this.label6.Text = "Радиус шара м";
            // 
            // velocityNumeric2
            // 
            this.velocityNumeric2.DecimalPlaces = 1;
            this.velocityNumeric2.Location = new System.Drawing.Point(327, 184);
            this.velocityNumeric2.Maximum = new decimal(new int[] {
            400,
            0,
            0,
            0});
            this.velocityNumeric2.Minimum = new decimal(new int[] {
            400,
            0,
            0,
            -2147483648});
            this.velocityNumeric2.Name = "velocityNumeric2";
            this.velocityNumeric2.Size = new System.Drawing.Size(76, 22);
            this.velocityNumeric2.TabIndex = 12;
            this.velocityNumeric2.Tag = "1";
            this.velocityNumeric2.ValueChanged += new System.EventHandler(this.NumericUpDown_ValueChanged);
            // 
            // massNumeric2
            // 
            this.massNumeric2.DecimalPlaces = 1;
            this.massNumeric2.Location = new System.Drawing.Point(327, 212);
            this.massNumeric2.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.massNumeric2.Name = "massNumeric2";
            this.massNumeric2.Size = new System.Drawing.Size(76, 22);
            this.massNumeric2.TabIndex = 14;
            this.massNumeric2.Tag = "3";
            this.massNumeric2.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.massNumeric2.ValueChanged += new System.EventHandler(this.NumericUpDown_ValueChanged);
            // 
            // radiusNumeric2
            // 
            this.radiusNumeric2.DecimalPlaces = 1;
            this.radiusNumeric2.Location = new System.Drawing.Point(327, 240);
            this.radiusNumeric2.Maximum = new decimal(new int[] {
            40,
            0,
            0,
            0});
            this.radiusNumeric2.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.radiusNumeric2.Name = "radiusNumeric2";
            this.radiusNumeric2.Size = new System.Drawing.Size(76, 22);
            this.radiusNumeric2.TabIndex = 15;
            this.radiusNumeric2.Tag = "5";
            this.radiusNumeric2.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.radiusNumeric2.ValueChanged += new System.EventHandler(this.NumericUpDown_ValueChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(980, 614);
            this.Controls.Add(this.setDefaultBtn);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.resetBtn);
            this.Controls.Add(this.startStopBtn);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Упругое соударение";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radiusNumeric1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.massNumeric1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.velocityNumeric1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.velocityNumeric2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.massNumeric2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radiusNumeric2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button startStopBtn;
        private System.Windows.Forms.Button resetBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label velocityLabel1;
        private System.Windows.Forms.Label energyLabel1;
        private System.Windows.Forms.Label energyLabel2;
        private System.Windows.Forms.Label velocityLabel2;
        private System.Windows.Forms.NumericUpDown velocityNumeric1;
        private System.Windows.Forms.Label startVelocityLabel1;
        private System.Windows.Forms.Label radiusLabel1;
        private System.Windows.Forms.Label massLabel1;
        private System.Windows.Forms.NumericUpDown radiusNumeric1;
        private System.Windows.Forms.NumericUpDown massNumeric1;
        private System.Windows.Forms.Label ballMaterialLabel1;
        private System.Windows.Forms.ComboBox materialComboBox1;
        private System.Windows.Forms.Label restitutionCoefficientLabel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox materialComboBox2;
        private System.Windows.Forms.Label restitutionCoefficientLabel2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox materialComboBox4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox materialComboBox3;
        private System.Windows.Forms.Label frictionCoefficientLabel1;
        private System.Windows.Forms.Label restitutionCoefficientLabel3;
        private System.Windows.Forms.Button setDefaultBtn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown radiusNumeric2;
        private System.Windows.Forms.NumericUpDown massNumeric2;
        private System.Windows.Forms.NumericUpDown velocityNumeric2;
    }
}

