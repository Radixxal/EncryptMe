
namespace EncryptMe
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
            this.components = new System.ComponentModel.Container();
            this.tb_input = new System.Windows.Forms.TextBox();
            this.bt_enc = new System.Windows.Forms.Button();
            this.bt_dec = new System.Windows.Forms.Button();
            this.tb_main = new System.Windows.Forms.TextBox();
            this.bt_copy = new System.Windows.Forms.Button();
            this.bt_clear = new System.Windows.Forms.Button();
            this.bt_cut = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.num_timer = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.cb_onlycopy = new System.Windows.Forms.CheckBox();
            this.button_tomain = new System.Windows.Forms.Button();
            this.cb_mv_after_enc = new System.Windows.Forms.CheckBox();
            this.cb_mv_after_dec = new System.Windows.Forms.CheckBox();
            this.cut_aft_dec = new System.Windows.Forms.CheckBox();
            this.cb_cop_aft_dec = new System.Windows.Forms.CheckBox();
            this.cut_input_after_enc = new System.Windows.Forms.CheckBox();
            this.cb_cop_after_enc = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button_toencdec = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_timer)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tb_input
            // 
            this.tb_input.Font = new System.Drawing.Font("Liberation Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_input.Location = new System.Drawing.Point(17, 46);
            this.tb_input.Multiline = true;
            this.tb_input.Name = "tb_input";
            this.tb_input.Size = new System.Drawing.Size(328, 64);
            this.tb_input.TabIndex = 0;
            // 
            // bt_enc
            // 
            this.bt_enc.BackColor = System.Drawing.Color.Yellow;
            this.bt_enc.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bt_enc.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Strikeout, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bt_enc.ForeColor = System.Drawing.Color.Black;
            this.bt_enc.Location = new System.Drawing.Point(162, 116);
            this.bt_enc.Name = "bt_enc";
            this.bt_enc.Size = new System.Drawing.Size(183, 25);
            this.bt_enc.TabIndex = 1;
            this.bt_enc.Text = "encrypt";
            this.bt_enc.UseVisualStyleBackColor = false;
            this.bt_enc.Click += new System.EventHandler(this.button1_Click);
            // 
            // bt_dec
            // 
            this.bt_dec.BackColor = System.Drawing.Color.Yellow;
            this.bt_dec.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bt_dec.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bt_dec.ForeColor = System.Drawing.Color.Black;
            this.bt_dec.Location = new System.Drawing.Point(162, 147);
            this.bt_dec.Name = "bt_dec";
            this.bt_dec.Size = new System.Drawing.Size(183, 25);
            this.bt_dec.TabIndex = 3;
            this.bt_dec.Text = "decrypt";
            this.bt_dec.UseVisualStyleBackColor = false;
            this.bt_dec.Click += new System.EventHandler(this.bt_dec_Click);
            // 
            // tb_main
            // 
            this.tb_main.Font = new System.Drawing.Font("Liberation Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_main.Location = new System.Drawing.Point(16, 34);
            this.tb_main.Multiline = true;
            this.tb_main.Name = "tb_main";
            this.tb_main.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tb_main.Size = new System.Drawing.Size(375, 212);
            this.tb_main.TabIndex = 4;
            // 
            // bt_copy
            // 
            this.bt_copy.BackColor = System.Drawing.Color.Fuchsia;
            this.bt_copy.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bt_copy.Font = new System.Drawing.Font("Rubik", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bt_copy.ForeColor = System.Drawing.Color.Black;
            this.bt_copy.Location = new System.Drawing.Point(87, 253);
            this.bt_copy.Name = "bt_copy";
            this.bt_copy.Size = new System.Drawing.Size(54, 25);
            this.bt_copy.TabIndex = 5;
            this.bt_copy.Text = "copy";
            this.bt_copy.UseVisualStyleBackColor = false;
            this.bt_copy.Click += new System.EventHandler(this.bt_copy_Click);
            // 
            // bt_clear
            // 
            this.bt_clear.BackColor = System.Drawing.Color.Fuchsia;
            this.bt_clear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bt_clear.Font = new System.Drawing.Font("Rubik", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bt_clear.ForeColor = System.Drawing.Color.Black;
            this.bt_clear.Location = new System.Drawing.Point(207, 253);
            this.bt_clear.Name = "bt_clear";
            this.bt_clear.Size = new System.Drawing.Size(54, 25);
            this.bt_clear.TabIndex = 6;
            this.bt_clear.Text = "clear";
            this.bt_clear.UseVisualStyleBackColor = false;
            this.bt_clear.Click += new System.EventHandler(this.bt_clear_Click);
            // 
            // bt_cut
            // 
            this.bt_cut.BackColor = System.Drawing.Color.Fuchsia;
            this.bt_cut.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bt_cut.Font = new System.Drawing.Font("Rubik", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bt_cut.ForeColor = System.Drawing.Color.Black;
            this.bt_cut.Location = new System.Drawing.Point(147, 253);
            this.bt_cut.Name = "bt_cut";
            this.bt_cut.Size = new System.Drawing.Size(54, 25);
            this.bt_cut.TabIndex = 7;
            this.bt_cut.Text = "to cut";
            this.bt_cut.UseVisualStyleBackColor = false;
            this.bt_cut.Click += new System.EventHandler(this.bt_cut_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(17, 157);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(96, 15);
            this.textBox3.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Cyan;
            this.label1.Location = new System.Drawing.Point(14, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "Key:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.num_timer);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Controls.Add(this.cb_onlycopy);
            this.groupBox1.Controls.Add(this.button_tomain);
            this.groupBox1.Controls.Add(this.cb_mv_after_enc);
            this.groupBox1.Controls.Add(this.cb_mv_after_dec);
            this.groupBox1.Controls.Add(this.cut_aft_dec);
            this.groupBox1.Controls.Add(this.cb_cop_aft_dec);
            this.groupBox1.Controls.Add(this.cut_input_after_enc);
            this.groupBox1.Controls.Add(this.cb_cop_after_enc);
            this.groupBox1.Controls.Add(this.tb_input);
            this.groupBox1.Controls.Add(this.bt_enc);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.bt_dec);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(12, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(368, 328);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Enc/Dec";
            // 
            // num_timer
            // 
            this.num_timer.Location = new System.Drawing.Point(180, 294);
            this.num_timer.Name = "num_timer";
            this.num_timer.Size = new System.Drawing.Size(39, 22);
            this.num_timer.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(225, 296);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 16);
            this.label2.TabIndex = 18;
            this.label2.Text = "minutes";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.checkBox1.Location = new System.Drawing.Point(7, 295);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(159, 20);
            this.checkBox1.TabIndex = 18;
            this.checkBox1.Text = "clear all if not active in:";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // cb_onlycopy
            // 
            this.cb_onlycopy.AutoSize = true;
            this.cb_onlycopy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cb_onlycopy.Location = new System.Drawing.Point(17, 133);
            this.cb_onlycopy.Name = "cb_onlycopy";
            this.cb_onlycopy.Size = new System.Drawing.Size(85, 20);
            this.cb_onlycopy.TabIndex = 18;
            this.cb_onlycopy.Text = "only copy";
            this.cb_onlycopy.UseVisualStyleBackColor = true;
            // 
            // button_tomain
            // 
            this.button_tomain.BackColor = System.Drawing.Color.Yellow;
            this.button_tomain.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_tomain.Font = new System.Drawing.Font("Rubik", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_tomain.ForeColor = System.Drawing.Color.Black;
            this.button_tomain.Location = new System.Drawing.Point(280, 15);
            this.button_tomain.Name = "button_tomain";
            this.button_tomain.Size = new System.Drawing.Size(65, 25);
            this.button_tomain.TabIndex = 17;
            this.button_tomain.Text = ">>>";
            this.button_tomain.UseVisualStyleBackColor = false;
            this.button_tomain.Click += new System.EventHandler(this.button_tomain_Click);
            // 
            // cb_mv_after_enc
            // 
            this.cb_mv_after_enc.AutoSize = true;
            this.cb_mv_after_enc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cb_mv_after_enc.Location = new System.Drawing.Point(6, 212);
            this.cb_mv_after_enc.Name = "cb_mv_after_enc";
            this.cb_mv_after_enc.Size = new System.Drawing.Size(164, 20);
            this.cb_mv_after_enc.TabIndex = 16;
            this.cb_mv_after_enc.Text = "move to main after enc.";
            this.cb_mv_after_enc.UseVisualStyleBackColor = true;
            // 
            // cb_mv_after_dec
            // 
            this.cb_mv_after_dec.AutoSize = true;
            this.cb_mv_after_dec.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cb_mv_after_dec.Location = new System.Drawing.Point(180, 212);
            this.cb_mv_after_dec.Name = "cb_mv_after_dec";
            this.cb_mv_after_dec.Size = new System.Drawing.Size(165, 20);
            this.cb_mv_after_dec.TabIndex = 15;
            this.cb_mv_after_dec.Text = "move to main after dec.";
            this.cb_mv_after_dec.UseVisualStyleBackColor = true;
            // 
            // cut_aft_dec
            // 
            this.cut_aft_dec.AutoSize = true;
            this.cut_aft_dec.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.cut_aft_dec.Location = new System.Drawing.Point(180, 264);
            this.cut_aft_dec.Name = "cut_aft_dec";
            this.cut_aft_dec.Size = new System.Drawing.Size(121, 20);
            this.cut_aft_dec.TabIndex = 14;
            this.cut_aft_dec.Text = "cut after decrypt";
            this.cut_aft_dec.UseVisualStyleBackColor = true;
            // 
            // cb_cop_aft_dec
            // 
            this.cb_cop_aft_dec.AutoSize = true;
            this.cb_cop_aft_dec.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.cb_cop_aft_dec.Location = new System.Drawing.Point(180, 238);
            this.cb_cop_aft_dec.Name = "cb_cop_aft_dec";
            this.cb_cop_aft_dec.Size = new System.Drawing.Size(134, 20);
            this.cb_cop_aft_dec.TabIndex = 13;
            this.cb_cop_aft_dec.Text = "copy after decrypt";
            this.cb_cop_aft_dec.UseVisualStyleBackColor = true;
            // 
            // cut_input_after_enc
            // 
            this.cut_input_after_enc.AutoSize = true;
            this.cut_input_after_enc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.cut_input_after_enc.Location = new System.Drawing.Point(6, 264);
            this.cut_input_after_enc.Name = "cut_input_after_enc";
            this.cut_input_after_enc.Size = new System.Drawing.Size(151, 20);
            this.cut_input_after_enc.TabIndex = 12;
            this.cut_input_after_enc.Text = "cut input after ecnrypt";
            this.cut_input_after_enc.UseVisualStyleBackColor = true;
            // 
            // cb_cop_after_enc
            // 
            this.cb_cop_after_enc.AutoSize = true;
            this.cb_cop_after_enc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cb_cop_after_enc.Location = new System.Drawing.Point(6, 238);
            this.cb_cop_after_enc.Name = "cb_cop_after_enc";
            this.cb_cop_after_enc.Size = new System.Drawing.Size(164, 20);
            this.cb_cop_after_enc.TabIndex = 11;
            this.cb_cop_after_enc.Text = "copy input after encrypt";
            this.cb_cop_after_enc.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.LightGray;
            this.label3.Location = new System.Drawing.Point(752, 338);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "EncryptMe Beta";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Fuchsia;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Rubik", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(267, 253);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(54, 25);
            this.button1.TabIndex = 14;
            this.button1.Text = "ToUp";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Fuchsia;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Rubik", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(327, 253);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(64, 25);
            this.button2.TabIndex = 15;
            this.button2.Text = "ToDown";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button_toencdec
            // 
            this.button_toencdec.BackColor = System.Drawing.Color.Yellow;
            this.button_toencdec.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_toencdec.Font = new System.Drawing.Font("Rubik", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_toencdec.ForeColor = System.Drawing.Color.Black;
            this.button_toencdec.Location = new System.Drawing.Point(16, 253);
            this.button_toencdec.Name = "button_toencdec";
            this.button_toencdec.Size = new System.Drawing.Size(65, 25);
            this.button_toencdec.TabIndex = 16;
            this.button_toencdec.Text = "<<<";
            this.button_toencdec.UseVisualStyleBackColor = false;
            this.button_toencdec.Click += new System.EventHandler(this.button_toencdec_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tb_main);
            this.groupBox2.Controls.Add(this.button_toencdec);
            this.groupBox2.Controls.Add(this.bt_copy);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.bt_clear);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.bt_cut);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(415, 23);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(420, 301);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Editor";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.ClientSize = new System.Drawing.Size(858, 370);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Click += new System.EventHandler(this.Form1_Click);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_timer)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_input;
        private System.Windows.Forms.Button bt_enc;
        private System.Windows.Forms.Button bt_dec;
        private System.Windows.Forms.TextBox tb_main;
        private System.Windows.Forms.Button bt_copy;
        private System.Windows.Forms.Button bt_clear;
        private System.Windows.Forms.Button bt_cut;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox cb_cop_after_enc;
        private System.Windows.Forms.CheckBox cut_aft_dec;
        private System.Windows.Forms.CheckBox cb_cop_aft_dec;
        private System.Windows.Forms.CheckBox cut_input_after_enc;
        private System.Windows.Forms.CheckBox cb_onlycopy;
        private System.Windows.Forms.Button button_tomain;
        private System.Windows.Forms.CheckBox cb_mv_after_enc;
        private System.Windows.Forms.CheckBox cb_mv_after_dec;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button_toencdec;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.NumericUpDown num_timer;
    }
}

