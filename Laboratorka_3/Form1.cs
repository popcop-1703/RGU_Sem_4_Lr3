
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;

namespace Laboratorka_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Station station1 = Station.GetStationInstance();
        bool openCloseLib, openCloseBook = false;
        public int flag = 0;
        private void button1_Click_1(object sender, EventArgs e)
        {
            if (flag == 0)
            {
                textBox4.BackColor = Color.Gray;
                textBox4.Enabled = false;
                textBox6.BackColor = Color.Gray;
                textBox6.Enabled = false;
            }
            else
            {
                textBox4.BackColor = Color.White;
                textBox4.Enabled = true;
                textBox6.BackColor = Color.White;
                textBox6.Enabled = true;
            }

            if (textBox1.Text != "")

            {

                listBox1.Items.Insert(0, "");
                station1.StationName = Convert.ToString(textBox1.Text);
                //открываем или закрываем вокзал

                //меняем вместимость отделения
                try
                {
                    if (Convert.ToInt32(textBox3.Text) >= 0 && Int32.TryParse(textBox3.Text, out int number3) && Convert.ToInt32(textBox3.Text) <= 1000)
                    {
                        station1.LuggageCapacityUp(Math.Abs(Convert.ToInt32(textBox3.Text)));

                    }
                    else if (Convert.ToInt32(textBox3.Text) > 1000)
                    {
                        MessageBox.Show("Вместимость хранилища не может превышать 1000 единиц\nВведите значение в диапазоне от 0 до 1000 ", "Проверьте данные и повторите попытку");
                        textBox3.Text = "";

                    }
                    else if (textBox3.Text == "")
                    {


                    }
                    else if (Convert.ToInt32(textBox3.Text) < 0 || Int32.TryParse(textBox3.Text, out int number21) == false)
                    {
                        MessageBox.Show("Введите натуральное целое число, \nИные значения недопустимы в данном поле", "Проверьте данные и повторите попытку");
                        textBox3.Text = "";
                        listBox1.Items.Clear();

                    }
                }
                catch
                {

                }
                //меняем кол-во багажа в отделении

                if (Int32.TryParse(textBox4.Text, out int number421))
                {

                    int up = Convert.ToInt32(textBox4.Text);
                    if (up + station1.LuggageCountOfBag <= station1.LuggageCapacity)
                    {
                        station1.LuggageCountOfBagUp(up);
                        textBox4.Text = "";

                    }
                    else
                    {
                        MessageBox.Show("Количество книг не должно превышать вместимость хранилища", "Проверьте значения и повторите попытку");
                    }
                }
                else if (textBox4.Text == "")
                {

                }
                else
                {
                    MessageBox.Show("В поле 'Добавить книгу' можно вводить только целые числа больше 0\nПроверьте значения и повторите попытку");
                }


                if (Int32.TryParse(textBox6.Text, out int number4231))
                {
                    int down = Convert.ToInt32(textBox6.Text);
                    station1.LuggageCountOfBagDown(down);
                    textBox6.Text = "";
                }
                else if (textBox6.Text == "")
                {

                }
                else
                {
                    MessageBox.Show("В поле 'Забрать книгу' можно вводить только целые числа больше 0\nПроверьте значения и повторите попытку");
                }


                if (listBox1.Items.Count > 0)
                {

                    listBox1.Items.Insert(0, "Количество книг: " + station1.LuggageCountOfBag);
                    listBox1.Items.Insert(0, "Вместимость книгохранилища: " + station1.LuggageCapacity);
                    listBox1.Items.Insert(0, "Хранилище открыто: " + station1.IsLuggageWorkOn);
                    listBox1.Items.Insert(0, "Название библиотеки: " + station1.StationName);
                    listBox1.Items.Insert(0, "Бибилиотека открыта " + station1.VokzalWork);
                    listBox1.Items.Insert(0, "Изменение от: " + DateTime.Now);

                }
            }
            else
            {
                MessageBox.Show("Пожалуйста, укажите название библиотеки и повторите попытку");
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            flag += 1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            openCloseLib = !openCloseLib;

            if (openCloseLib == true)
            {
                station1.VokzalWork = true;
                button3.BackColor = Color.White;
                button3.Enabled = true;
                textBox3.BackColor = Color.White;
                textBox3.Enabled = true;
                textBox4.BackColor = Color.White;
                textBox4.Enabled = true;
                textBox6.BackColor = Color.White;
                textBox6.Enabled = true;

            }
            else if (openCloseLib == false)
            {
                station1.VokzalWork = false;
                button3.BackColor = Color.Gray;
                button3.Enabled = false;
                textBox3.BackColor = Color.Gray;
                textBox3.Enabled = false;
                textBox4.BackColor = Color.Gray;
                textBox4.Enabled = false;
                textBox6.BackColor = Color.Gray;
                textBox6.Enabled = false;
                station1.LuggageWorkOff();

            }

            else
            {
                MessageBox.Show("Введите цифры '1' или '0', \nИные значения недопустимы в данном поле", "Проверьте данные и повторите попытку");
                listBox1.Items.Clear();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            openCloseBook = !openCloseBook;
            //открываем или закрываем отделение
            if (openCloseBook == true && station1.VokzalWork == true)
            {
                station1.LuggageWorkOn();
                textBox4.BackColor = Color.White;
                textBox4.Enabled = true;
                textBox6.BackColor = Color.White;
                textBox6.Enabled = true;
            }
            else if (openCloseBook == false)
            {
                station1.LuggageWorkOff();
                textBox4.BackColor = Color.Gray;
                textBox4.Enabled = false;
                textBox6.BackColor = Color.Gray;
                textBox6.Enabled = false;
            }
        }
    }
}