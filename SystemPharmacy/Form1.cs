﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using System.IO;
using System.Data.Linq;
using System.Data.SqlClient;

namespace SystemPharmacy
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "myDBDataSet.NalDGV". При необходимости она может быть перемещена или удалена.
            this.nalDGVTableAdapter.Fill(this.myDBDataSet.NalDGV);
            label4.Visible = false;
            textBox3.Visible = false;
            BTN_OK.Visible = false;
           // dataGridView2.AllowUserToAddRows = false;
           // dataGridView2.AllowUserToDeleteRows = false;
            // TODO: данная строка кода позволяет загрузить данные в таблицу "myDBDataSet1.saleDGV". При необходимости она может быть перемещена или удалена.
           // this.saleDGVTableAdapter.Fill(this.myDBDataSet1.saleDGV);
          //  var c = from i in myDBDataSet.Setup select i;
          /*  foreach (var i in c)
            {
                comboBox2.Items.Add(i.Porog.ToString());
            }*/
           // DataGridViewComboBoxColumn newc = new DataGridViewComboBoxColumn();
          //  newc.Name = "abc";
            //  newc.DataSource = new string[] { "a", "b", "c" };
         //   dataGridView1.Columns.Add(newc);
         /*   foreach (var i in c)
            {
                newc.Items.Add(i.ToString());
            }*/
        //   MessageBox.Show(monthCalendar1.TodayDate.ToString());
            // TODO: данная строка кода позволяет загрузить данные в таблицу "myDBDataSet.Setup". При необходимости она может быть перемещена или удалена.
          //  this.setupTableAdapter.Fill(this.myDBDataSet.Setup);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "myDBDataSet.Preparat". При необходимости она может быть перемещена или удалена.
         //   this.preparatTableAdapter.Fill(this.myDBDataSet.Preparat);

         /*  Class_Zakupki_Excel cl = new Class_Zakupki_Excel();
            int count=0;
            this.Text = "System_of_Pharmacy";
            string str= @"D:\Zakupki";
            DirectoryInfo docs = new DirectoryInfo(str);
            FileInfo[] files = docs.GetFiles();
          foreach (FileInfo f in files)
            { count++;
            int result = cl.Zakupki(@"D:\MyDB.mdf", f.FullName);
           f.Delete();
            }
            MessageBox.Show(count.ToString());
            
            DataGridViewComboBoxColumn cmb = new DataGridViewComboBoxColumn();
           var c = from i in this.myDBDataSet.Setup select i.Porog;
          idsetupDataGridViewTextBoxColumn.
           for (int i = 0; i < c.Count();i++ )
            {
               idsetupDataGridViewTextBoxColumn.Items.Add(c);
           }
            dataGridView1.Columns.AddRange(cmb);
            DataTable dt = new DataTable();
            combobox1.DataSource = setupBindingSource;
            combobox1.ValueMember = "Id_setup";
            combobox1.DisplayMember = "Porog";
          DataGridViewComboBoxColumn newc = new DataGridViewComboBoxColumn();
           newc.Name = "abc";
           newc.DataSource = new string[] { "a", "b", "c" };
           dataGridView1.Columns.Add(newc);
           newc.Items.Add("sdfghjhgfdfg");
           foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                DataGridViewComboBoxCell cell = (DataGridViewComboBoxCell)(row.Cells["abc"]);
                cell.DataSource = new string[] { "a", "c" };
            }*/
        }
        
        private void BTN_zakaz_Click(object sender, EventArgs e)
        {
            Zakaz zakaz = new Zakaz();
            zakaz.Show();
        }

        private void algoritm_menu_Click_1(object sender, EventArgs e)
        {

            Algoritm alg = new Algoritm();
            alg.Show();
        }

        private void card_menu_Click_1(object sender, EventArgs e)
        {
            Card card = new Card();
            card.Show();
        }

        private void setup_menu_Click(object sender, EventArgs e)
        {
            Setup set = new Setup();
            set.Show();
        }

        private void postavchik_menu_Click(object sender, EventArgs e)
        {
            Postavchik post = new Postavchik();
            post.Show();
        }

        private void group_menu_Click(object sender, EventArgs e)
        {
            Group group = new Group();
            group.Show();
        }

        private void button_sale_Click(object sender, EventArgs e)
        {/*
           ADD_Preparat ads = new ADD_Preparat();
            preparatBindingSource.AddNew();
            ads.preparatBindingSource.DataSource = saleDGVBindingSource;
            ads.preparatBindingSource.Position = saleDGVBindingSource.Position;
            if (ads.ShowDialog() == DialogResult.OK)
            {
                saleDGVTableAdapter.Update(myDBDataSet.saleDGV);
                this.saleDGVTableAdapter.Fill(this.myDBDataSet.saleDGV);

            }*/
        }

        private void BTN_search_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                if (dataGridView1[2,i].FormattedValue.ToString().Contains(tBSearch.Text.Trim()))
                    {
                        dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.Yellow;
                        return;
                    }
            }
        }
       
        private void button2_Click(object sender, EventArgs e)
        {
          /*  var c = from i in myDBDataSet.Setup select i;
            foreach (var i in c)
            {
         //       combobox1.Items.Add(i.Porog.ToString());
            }*/
           // dataGridView1.Columns.Add(this.
        }

        private void preparat_menu_Click(object sender, EventArgs e)
        {
            Preparat prep = new Preparat();
            prep.Show();
        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ADD_sale ads = new ADD_sale();
            ads.Owner = this;
            ads.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            label4.Visible = true;
            textBox3.Visible = true;
            BTN_OK.Visible = true;
        }

        private void BTN_OK_Click(object sender, EventArgs e)
        {
            textBox3.Text = "";
            DataBase db = new DataBase(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\user\Documents\GitHub\oop\MyDB.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True");
            int t = 0;
            var c = from i in db.Card select i;
             foreach (var i in c)
            {
                if (i.id_card == Convert.ToInt32(textBox1.Text))
                {
                    t = i.current_procent;
                }
                else
                { MessageBox.Show("Данная карта не зарегестрирована в сети аптек"); }
                }
            
            textBox3.Text = (Convert.ToDouble(textBox2.Text) - (Convert.ToInt32(textBox2.Text) * t*0.01)).ToString();
        }

      
    }
}

