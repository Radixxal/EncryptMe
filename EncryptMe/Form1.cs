using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EncryptMe
{
    public partial class Form1 : Form
    {

        static string hj = @" ZYXWVUTSRQPONMLKJIHGFEDCBA[]@\^`abcdefghijklmnopqrstuvwxyz{|}~£¥¦§©ª«¬®¯°±²³´µ¶·¸¹º»¼½¾¿ÀÁÂÃÄÅÆÇÈÉÊËÌÍÎÏÐÑÒÓÔÕÖ×ØÙÚÛÜÝÞßàáâãäåæçèéêëìíîïðñòóôõö÷øùúûüýþÿ!\#$% &'()*+-._/0123456789:;<=>?@АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯабвгдеёжзийклмнопрстуфхцчшщъыьэюя,
";
        static char[] book = hj.ToArray();
        static int fortimer = 0;
        static int fortimer_final;
        static string input;
        static string output_final;
        static char[] input_char;
        static char[] output_char;
        static int[] keyarray;
        static string output_encrypt;


        public Form1()
        {
            InitializeComponent();
            
            // НЕ НУЖНО!!!!!!!!!!!!!!!!!!!!!!!!!!
            int h = book.Length;
            MessageBox.Show(h.ToString());

            MessageBox.Show(Array.IndexOf(book, 'd').ToString());
            // НЕ НУЖНО!!!!!!!!!!!!!!!!!!!!!!!!!!
            
        }
        
        public void button1_Click(object sender, EventArgs e)
        {
            fortimer = 0;
            timer1.Enabled = false;
            try
            {
                if (tb_input.Text == "") { MessageBox.Show("Чтобы зашифровать текст, его нужно сначала написать =("); return; } ;

                // Входной текст и выходной
                input = tb_input.Text;
                output_final = "";

                // Входной текст в массиве символов
                input_char = input.ToArray();

                // Выходные данные
                output_char = input_char;

                // Объявление переменной ключа, рандомной и промежуточной переменных
                Random rnd = new Random();
                int random;
                string key = "";

                keyarray = new int[input_char.Length];

                // Шифрование
                for (int i = 0; i <= output_char.Length - 1; i++)
                {
                    // Случайное число в границах кол-ва символов
                    random = rnd.Next(0, 256);
                    // Запись номера символа в ключ (массив натуральных чисел)
                    keyarray[i] = Array.IndexOf(book, input_char[i]);

                    // Выходной текст (зашифрованный)
                    output_char[i] = book[random];
                }

                //char[] testch = key.ToArray();
                //testch = testch.Where(val => val != ' ').ToArray();

                output_encrypt = "";

                // Запись зашифрованного сообщения в строку
                for (int i = 0; i <= output_char.Length - 1; i++)
                {
                    output_encrypt += output_char[i];
                }

                tb_input.Text = output_encrypt;
            }
            catch(Exception) { MessageBox.Show("Unknown Error"); }

            if(cb_mv_after_enc.Checked == true) { tb_main.Text = output_encrypt; }
            if(cb_cop_after_enc.Checked == true) { Clipboard.SetText(output_encrypt); }
            if(cut_input_after_enc.Checked == true) { tb_input.Text = ""; Clipboard.SetText(output_encrypt); }
            
        }

        private void bt_dec_Click(object sender, EventArgs e)
        {
            fortimer = 0;
            timer1.Enabled = false;
            // Расшифровка сообщения и запись в строку
            for (int i = 0; i <= output_char.Length - 1; i++)
            {
                output_final += book[keyarray[i]];
            }

            tb_input.Text = output_final;

            if (cb_mv_after_dec.Checked == true) { tb_input.Text = ""; tb_main.Text = output_final; }
            if (cb_cop_aft_dec.Checked == true) { Clipboard.SetText(output_encrypt); }
            if (cb_cop_aft_dec.Checked == true) { tb_input.Text = ""; Clipboard.SetText(output_encrypt); }
        }

        private void bt_clear_Click(object sender, EventArgs e) { tb_main.Text = ""; }

        private void bt_copy_Click(object sender, EventArgs e) { Clipboard.SetText(tb_main.Text); }

        private void bt_cut_Click(object sender, EventArgs e) { Clipboard.SetText(tb_main.Text); tb_main.Text = ""; }

        private void timer1_Tick(object sender, EventArgs e)
        {
            fortimer += 1000;
            if(fortimer == fortimer_final) { tb_input.Text = ""; tb_main.Text = ""; }
        }



        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                MessageBox.Show("f");
                fortimer = 0;
                int timer_val = 60000;
                fortimer_final = timer_val * Convert.ToInt32(num_timer.Value);
                timer1.Enabled = true;
            }
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            fortimer = 0;
            timer1.Enabled = false;
        }

        private void button_tomain_Click(object sender, EventArgs e)
        {
            tb_main.Text = tb_input.Text;
            tb_input.Text = "";
        }

        private void button_toencdec_Click(object sender, EventArgs e)
        {
            tb_input.Text = tb_main.Text;
        }
    }
}
