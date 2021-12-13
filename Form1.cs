using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace Cliker_Proj
{

    //игра состоит не в достижении наибольшего числа печенек (но за достижение большого числа будет даватся ачивка),
    //а в заработке денег с продажи печенек

    //Апгрейды клика (но не по тупому,т.е. в виде емкостей(пачка печенья, вагон печенья),
    //а в виде(например) средств для доставки(рюкзак для хранения печенья, скутер для перемещения, грузовик для доставки печенья))
    //глобальный таймер времени (отдельные переменные для секунд > минут > часов > дней)
        //день не длится столько же, сколько и в реальном мире
    //меню
    //автокликеры и их апгрейды

    //система "чтобы продавать печенье нужен потребитель"
        //максимум в день ты можешь продать столько печенья, сколько человек проживает в городе
            //1 человек != 1 печенье, а больше; выясниться в процессе калибровки


    //меню с подсказками
    //система города с количеством жителей
        //не все жители хотят покупать печенье, а только определенный % "печеньканутых" (настроенных к покупке печенья)
        //продвинутая система продажи
            //Если уровень продаж печенья удовлетворяет спрос
            //(продажи печенья в день >= 80%-100% от кол-ва жителей/потребляемого им печенья в день)
            //в течении какого-то времени (несколько дней, например) подряд
            //то % "печеньканутых" / или кол-во жителей в городе немного увеличится
            //в противном же случае, если спрос не удовлетворен (30%-0%), всё будет наоборот, и в более большом количестве
    //ачивки
    //апрейд города
        //строительство домов > кол-во домов = кол-во жителей
        //увеличение % "печеньканутых" путём разовой(временной) или постоянной(купил-и-забыл) рекламы
    //скины на печенье


    public partial class Form1 : Form
    {
        /*
        public string[,] Localization_names_In(string lg)
        {
            string[,] end_mas = new string[Convert.ToInt32(Localization("all_num", "")),2];
            /*
            for (short cycle1 = 0; cycle1 < end_mas.GetLength(0); cycle1++)
            {
                cycle1[cycle1,0] = 
            }
            
            return end_mas;
        }*/
    
        public string Localization(string name, string lg)
        {
            /*if ((name == "all_num") && (lg == "")) return "3";
            else if ()
            else*/ return "";
        }
        //private string[,] Localization_names;
        public void Update_All()
        {
            textBox1.Text = Main_num.ToString("F0");
            button1.Text  = button1_lvl + ":Upgrade1: +" + button1_plus + " to click. \nCost: " + button1_cost.ToString("F0");
            button2.Text  = button2_lvl + ":Upgrade2: +" + button2_plus + " to click. \nCost: " + button2_cost.ToString("F0");
            button7.Text  = button3_lvl + ":Upgrade3: +" + button3_plus + " to click. \nCost: " + button3_cost.ToString("F0");
            button8.Text  = button4_lvl + ":Upgrade4: +" + button4_plus + " to click. \nCost: " + button4_cost.ToString("F0");
            button14.Text = button5_lvl + ":Upgrade5: +" + button5_plus + " to click. \nCost: " + button5_cost.ToString("F0");
            button12.Text = button6_lvl + ":Upgrade6: +" + button6_plus + " to click. \nCost: " + button6_cost.ToString("F0");
            button13.Text = button7_lvl + ":Upgrade7: +" + button7_plus + " to click. \nCost: " + button7_cost.ToString("F0");
            button11.Text = button8_lvl + ":Upgrade8: +" + button8_plus + " to click. \nCost: " + button8_cost.ToString("F0");
            button10.Text = button9_lvl + ":Upgrade9: +" + button9_plus + " to click. \nCost: " + button9_cost.ToString("F0");
            textBox2.Text = click_num.ToString("F0") + " per click";

            /*
            if (Main_num.ToString("F0").Contains("69") || click_num.ToString("F0").Contains("69") || button1_lvl.ToString().Contains("69")) button3.Visible = true;
            else button3.Visible = false;
            */
            if (button1_lvl.ToString().Contains("69")) button3.Visible = true;
            else button3.Visible = false;
        }
        
        private double Main_num = 0; private double click_num = 1;
        private double button1_plus = 10; private double button1_cost = 10; private double button1_lvl = 1; private double button1_mp = 1.1;
        private double button2_plus = 1000 / 20 * 3; private double button2_cost = 1000; private double button2_lvl = 0; private double button2_mp = 1.4;
        private double button3_plus = 10000 / 20 * 4; private double button3_cost = 10000; private double button3_lvl = 0; private double button3_mp = 1.6;
        private double button4_plus = 100000 / 20 * 5; private double button4_cost = 100000; private double button4_lvl = 0; private double button4_mp = 1.8;
        private double button5_plus = 1000000 / 20 * 6; private double button5_cost = 1000000; private double button5_lvl = 0; private double button5_mp = 2.0;
        private double button6_plus = 10000000 / 20 * 8; private double button6_cost = 10000000; private double button6_lvl = 0; private double button6_mp = 2.3;
        private double button7_plus = 100000000 / 20 * 10; private double button7_cost = 100000000; private double button7_lvl = 0; private double button7_mp = 2.6;
        private double button8_plus = 1000000000 / 20 * 12; private double button8_cost = 1000000000; private double button8_lvl = 0; private double button8_mp = 3.0;
        private double button9_plus = 10000000000 / 20 * 16; private double button9_cost = 10000000000; private double button9_lvl = 0; private double button9_mp = 3.5;


        short skin_num = 0;

        short active_upgrade_panel = 1;
        
        private bool yes = false; 
        private System.Media.SoundPlayer splayer = new System.Media.SoundPlayer();


        //система переключения языков RU/EN
            
        //хранение активных данных нет, вызов любого названия согласовывается из string[] метода(string название элемента на английском, string используемый язык)
                //if (используемый язык == ru) else 
                //текст хранится в столбах из case;
        public Form1()
        {
            InitializeComponent();
            
            timer1.Interval = 10;
            timer1.Enabled = true;
            timer3.Enabled = true;

            //Form1.ActiveForm.ActiveControl.Size = new System.Drawing.Size(810, 487);

            panel2.Location = panel1.Location; panel2.Visible = false;
            panel3.Location = panel1.Location; panel3.Visible = false;
            button15.Visible = false; button16.Visible = false;
            button15.Location = new Point(451, 390); button16.Location = new Point(615, 390);

            button3.Visible = false;

            //Localization_names = Localization_names_In("RU");

            Update_All();
        }

        public void Autoclick()
        {
            //pictureBox1_click();
            //button9_click();
            /*
            if (button2_cost / 10 < button1_cost) button2_click();
            else button1_click();
            */
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            Autoclick();Update_All();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }


        //picture click
        private void picture_click(object sender, MouseEventArgs e)
        {
            pictureBox1_click(); Update_All();
        }
        private void timer2_Tick(object sender, EventArgs e)
        {
            if (yes) { yes = false; 
                {
                    switch (skin_num)
                    {
                        case 0: pictureBox1.Image = Properties.Resources.cookie_original_1; break;
                        case 1: pictureBox1.Image = Properties.Resources.low_poly_cookie_1; break;
                        default: pictureBox1.Image = Properties.Resources.cookie_original_1;break;
                    } 
                } 
                timer2.Enabled = false; }
            else { yes = true; switch (skin_num)
                {
                    case 0: pictureBox1.Image = Properties.Resources.cookie_original_2; break;
                    case 1: pictureBox1.Image = Properties.Resources.low_poly_cookie_2; break;
                    default: pictureBox1.Image = Properties.Resources.cookie_original_2; break;
                }
            }
        }
        public void pictureBox1_click() { Main_num += click_num; timer2.Enabled = true; }
        

        //easter egg
        
        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Now its a easter egg ;)");
            pictureBox1.Image = Properties.Resources.phatto;
        }

        
        //upgrade buttons
        private void button1_Click(object sender, EventArgs e)
        {
            button1_click();
            Color_update();
            Update_All();
        }
        public void button1_click()
        {
            if (Main_num >= button1_cost)
            {
                Main_num -= button1_cost;
                button1_lvl++;
                click_num += button1_plus;
                button1_cost *= button1_mp;
                
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            button2_click(); Color_update(); Update_All();
        }
        public void button2_click()
        {
            if (Main_num >= button2_cost)
            {
                Main_num -= button2_cost;
                button2_lvl++;
                click_num += button2_plus;
                button2_cost *= button2_mp;
                
            }
        }
        private void button7_Click(object sender, EventArgs e)
        {
            button3_click(); Color_update(); Update_All();
        }
        public void button3_click()
        {
            if (Main_num >= button3_cost)
            {
                Main_num -= button3_cost;
                button3_lvl++;
                click_num += button3_plus;
                button3_cost *= button3_mp;
            }
        }
        private void button8_Click(object sender, EventArgs e)
        {
            button4_click(); Color_update(); Update_All();
        }
        public void button4_click()
        {
            if (Main_num >= button4_cost)
            {
                Main_num -= button4_cost;
                button4_lvl++;
                click_num += button4_plus;
                button4_cost *= button4_mp;
            }
        }
        private void button14_Click(object sender, EventArgs e)
        {
            button5_click(); Color_update(); Update_All();
        }
        public void button5_click()
        {
            if (Main_num >= button5_cost)
            {
                Main_num -= button5_cost;
                button5_lvl++;
                click_num += button5_plus;
                button5_cost *= button5_mp;
            }
        }
        private void button12_Click(object sender, EventArgs e)
        {
            button6_click(); Color_update(); Update_All();
        }
        public void button6_click()
        {
            if (Main_num >= button6_cost)
            {
                Main_num -= button6_cost;
                button6_lvl++;
                click_num += button6_plus;
                button6_cost *= button6_mp;
            }
        }
        private void button13_Click(object sender, EventArgs e)
        {
            button7_click(); Color_update(); Update_All();
        }
        public void button7_click()
        {
            if (Main_num >= button7_cost)
            {
                Main_num -= button7_cost;
                button7_lvl++;
                click_num += button7_plus;
                button7_cost *= button7_mp;

            }
        }
        private void button11_Click(object sender, EventArgs e)
        {
            button8_click(); Color_update(); Update_All();
        }
        public void button8_click()
        {
            if (Main_num >= button8_cost)
            {
                Main_num -= button8_cost;
                button8_lvl++;
                click_num += button8_plus;
                button8_cost *= button8_mp;

            }
        }
        private void button10_Click(object sender, EventArgs e)
        {
            button9_click(); Color_update(); Update_All();
        }
        public void button9_click()
        {
            if (Main_num >= button9_cost)
            {
                Main_num -= button9_cost;
                button9_lvl++;
                click_num += button9_plus;
                button9_cost *= button9_mp;

            }
        }


        //main upgrade button
        private void button4_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            Active_upgrade_panel();

            button5.Visible = true;
        }
        public void Active_upgrade_panel()
        {
            switch (active_upgrade_panel)
            {
                case 1: panel2.Visible = true; panel1.Visible = false; panel3.Visible = false; break;
                case 2: panel3.Visible = true; panel1.Visible = false; panel2.Visible = false; break;
                default: break;
            }
            if (active_upgrade_panel != 1) { button15.Visible = true; button15.Text = (active_upgrade_panel - 1).ToString(); }
            else button15.Visible = false;
            if (active_upgrade_panel != 2) { button16.Visible = true; button16.Text = (active_upgrade_panel + 1).ToString(); }
            else button16.Visible = false;
        }

        //back from upgrages button
        private void button5_Click(object sender, EventArgs e)
        {
            button5.Visible = false;
            panel1.Visible = true;

            panel2.Visible = false;
            panel3.Visible = false;

            button15.Visible = false; button16.Visible = false;
        }

        //upgrade panels +- buttons
        private void button16_Click(object sender, EventArgs e)
        {
            if (active_upgrade_panel != 2)
            {
                active_upgrade_panel++;
                Active_upgrade_panel();
            }
        }
        private void button15_Click(object sender, EventArgs e)
        {
            if (active_upgrade_panel != 1)
            {
                active_upgrade_panel--;
                Active_upgrade_panel();
            }
        }
        


        //skins button
        private void button6_Click(object sender, EventArgs e)
        {
            
            if (skin_num == 0) skin_num = 1;
            else skin_num = 0;
            switch (skin_num)
            {
                case 0: pictureBox1.Image = Properties.Resources.cookie_original_1; break;
                case 1: pictureBox1.Image = Properties.Resources.low_poly_cookie_1; break;
                default: pictureBox1.Image = Properties.Resources.cookie_original_1; break;
            }
        }

        //reset button
        private void button9_Click(object sender, EventArgs e)
        {
            button1_cost = 10; button2_cost = 1000; button3_cost = 10000; button4_cost = 100000; button5_cost = 1000000; button6_cost = 10000000; button7_cost = 100000000; button8_cost = 1000000000; button9_cost = 10000000000;
            button1_lvl = 0; button2_lvl = 0; button3_lvl = 0; button4_lvl = 0; button5_lvl = 0; button6_lvl = 0; button7_lvl = 0; button8_lvl = 0; button9_lvl = 0;
            Main_num = 0; click_num = 1;
            Update_All();
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            Color_update();
        }
        public void Color_update()
        {
            Color good = Color.FromArgb(192, 255, 192);
            if (button1_cost < Main_num) button1.BackColor = good;
            else button1.BackColor = SystemColors.ControlLight;
            if (button2_cost < Main_num) button2.BackColor = good;
            else button2.BackColor = SystemColors.ControlLight;
            if (button3_cost < Main_num) button7.BackColor = good;
            else button7.BackColor = SystemColors.ControlLight;
            if (button4_cost < Main_num) button8.BackColor = good;
            else button8.BackColor = SystemColors.ControlLight;
            if (button5_cost < Main_num) button14.BackColor = good;
            else button14.BackColor = SystemColors.ControlLight;
            if (button6_cost < Main_num) button12.BackColor = good;
            else button12.BackColor = SystemColors.ControlLight;
            if (button7_cost < Main_num) button13.BackColor = good;
            else button13.BackColor = SystemColors.ControlLight;
            if (button8_cost < Main_num) button11.BackColor = good;
            else button11.BackColor = SystemColors.ControlLight;
            if (button9_cost < Main_num) button10.BackColor = good;
            else button10.BackColor = SystemColors.ControlLight;
        }
    }
}
