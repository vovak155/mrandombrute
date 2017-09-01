/*
 * Created by SharpDevelop.
 * User: Sveta
 * Date: 31.08.2017
 * Time: 22:17
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System.IO;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace mRandom
{
	/// <summary>
	/// TODO:Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
			//this.account.Click += new System.EventHandler(this.AccountClick);
			//this.conquestbutton.Click += new System.EventHandler(this.ConquestbuttonClick);
		}
		void AccountClick(object sender, EventArgs e) // Кнопка "Выбрать"(аккаунты)
		{
			try
			{
   				if(OpenFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
   				{
      				System.IO.StreamReader sr = new 
      				System.IO.StreamReader(OpenFileDialog1.FileName);
      				String line;
      				Int64 i=0;
      				while((line = sr.ReadLine()) != null)
      				{
      					i++;
      				}
      				this.acount.Text = i.ToString();
    				this.accounttext.Text = OpenFileDialog1.FileName;
      				//this.accounttext.Text = OpenFileDialog1.InitialDirectory;
      				sr.Close(); 
   				}
			}
			catch
			{
			}
		}
		void ConquestbuttonClick(object sender, EventArgs e) // Кнопка "Выбрать"(конкурсы)
		{
			try
			{
   				if(openFileDialog2.ShowDialog() == System.Windows.Forms.DialogResult.OK)
   				{
      				System.IO.StreamReader sr = new 
         			System.IO.StreamReader(openFileDialog2.FileName);
      				String lines;
      				Int64 i=0;
      				//Array string[] 
      				while((lines = sr.ReadLine()) != null)
      				{
      					i++;
      				}
      				this.conquestt.Text = i.ToString();
    				this.conquesttext.Text = openFileDialog2.FileName;
      				//this.conquesttext.Text = openFileDialog2.InitialDirectory;
      				sr.Close(); 
   				}
			}
			catch
			{
			}
		}
		void Button1Click(object sender, EventArgs e) // Кнопка "Старт"
		{
			MessageBox.Show("Hello, world!");
		}
		void AccounttextTextChanged(object sender, EventArgs e)
		{
	
		}
	}
}
