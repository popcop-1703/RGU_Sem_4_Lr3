
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
                //��������� ��� ��������� ������

                //������ ����������� ���������
                try
                {
                    if (Convert.ToInt32(textBox3.Text) >= 0 && Int32.TryParse(textBox3.Text, out int number3) && Convert.ToInt32(textBox3.Text) <= 1000)
                    {
                        station1.LuggageCapacityUp(Math.Abs(Convert.ToInt32(textBox3.Text)));

                    }
                    else if (Convert.ToInt32(textBox3.Text) > 1000)
                    {
                        MessageBox.Show("����������� ��������� �� ����� ��������� 1000 ������\n������� �������� � ��������� �� 0 �� 1000 ", "��������� ������ � ��������� �������");
                        textBox3.Text = "";

                    }
                    else if (textBox3.Text == "")
                    {


                    }
                    else if (Convert.ToInt32(textBox3.Text) < 0 || Int32.TryParse(textBox3.Text, out int number21) == false)
                    {
                        MessageBox.Show("������� ����������� ����� �����, \n���� �������� ����������� � ������ ����", "��������� ������ � ��������� �������");
                        textBox3.Text = "";
                        listBox1.Items.Clear();

                    }
                }
                catch
                {

                }
                //������ ���-�� ������ � ���������

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
                        MessageBox.Show("���������� ���� �� ������ ��������� ����������� ���������", "��������� �������� � ��������� �������");
                    }
                }
                else if (textBox4.Text == "")
                {

                }
                else
                {
                    MessageBox.Show("� ���� '�������� �����' ����� ������� ������ ����� ����� ������ 0\n��������� �������� � ��������� �������");
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
                    MessageBox.Show("� ���� '������� �����' ����� ������� ������ ����� ����� ������ 0\n��������� �������� � ��������� �������");
                }


                if (listBox1.Items.Count > 0)
                {

                    listBox1.Items.Insert(0, "���������� ����: " + station1.LuggageCountOfBag);
                    listBox1.Items.Insert(0, "����������� ��������������: " + station1.LuggageCapacity);
                    listBox1.Items.Insert(0, "��������� �������: " + station1.IsLuggageWorkOn);
                    listBox1.Items.Insert(0, "�������� ����������: " + station1.StationName);
                    listBox1.Items.Insert(0, "����������� ������� " + station1.VokzalWork);
                    listBox1.Items.Insert(0, "��������� ��: " + DateTime.Now);

                }
            }
            else
            {
                MessageBox.Show("����������, ������� �������� ���������� � ��������� �������");
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
                MessageBox.Show("������� ����� '1' ��� '0', \n���� �������� ����������� � ������ ����", "��������� ������ � ��������� �������");
                listBox1.Items.Clear();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            openCloseBook = !openCloseBook;
            //��������� ��� ��������� ���������
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