/*
 * Created by SharpDevelop.
 * User: Sveta
 * Date: 31.08.2017
 * Time: 22:17
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace mRandom
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.Button conquestbutton;
		private System.Windows.Forms.TextBox conquesttext;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button account;
		private System.Windows.Forms.TextBox accounttext;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Label success;
		private System.Windows.Forms.Label conquestt;
		private System.Windows.Forms.Label acount;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label acount1;
		private System.Windows.Forms.GroupBox groupBox4;
		private System.Windows.Forms.RichTextBox richTextBox1;
		private System.Windows.Forms.OpenFileDialog OpenFileDialog1;
		private System.Windows.Forms.OpenFileDialog openFileDialog2;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.conquestbutton = new System.Windows.Forms.Button();
			this.conquesttext = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.account = new System.Windows.Forms.Button();
			this.accounttext = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.success = new System.Windows.Forms.Label();
			this.conquestt = new System.Windows.Forms.Label();
			this.acount = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.acount1 = new System.Windows.Forms.Label();
			this.groupBox4 = new System.Windows.Forms.GroupBox();
			this.richTextBox1 = new System.Windows.Forms.RichTextBox();
			this.OpenFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox4.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.groupBox3);
			this.groupBox1.Controls.Add(this.conquestbutton);
			this.groupBox1.Controls.Add(this.conquesttext);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.account);
			this.groupBox1.Controls.Add(this.accounttext);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.button1);
			this.groupBox1.Location = new System.Drawing.Point(13, 6);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(267, 250);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Настройка";
			// 
			// groupBox3
			// 
			this.groupBox3.Enabled = false;
			this.groupBox3.Location = new System.Drawing.Point(14, 129);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(246, 72);
			this.groupBox3.TabIndex = 7;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Дорабатываемая часть";
			// 
			// conquestbutton
			// 
			this.conquestbutton.Location = new System.Drawing.Point(189, 86);
			this.conquestbutton.Name = "conquestbutton";
			this.conquestbutton.Size = new System.Drawing.Size(75, 23);
			this.conquestbutton.TabIndex = 6;
			this.conquestbutton.Text = "Выбрать";
			this.conquestbutton.UseVisualStyleBackColor = true;
			this.conquestbutton.Click += new System.EventHandler(this.ConquestbuttonClick);
			// 
			// conquesttext
			// 
			this.conquesttext.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.conquesttext.HideSelection = false;
			this.conquesttext.Location = new System.Drawing.Point(12, 89);
			this.conquesttext.Name = "conquesttext";
			this.conquesttext.ReadOnly = true;
			this.conquesttext.Size = new System.Drawing.Size(171, 20);
			this.conquesttext.TabIndex = 5;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(12, 73);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(218, 22);
			this.label2.TabIndex = 4;
			this.label2.Text = "Список конкурсов";
			// 
			// account
			// 
			this.account.Location = new System.Drawing.Point(189, 29);
			this.account.Name = "account";
			this.account.Size = new System.Drawing.Size(75, 23);
			this.account.TabIndex = 3;
			this.account.Text = "Выбрать";
			this.account.UseVisualStyleBackColor = true;
			this.account.Click += new System.EventHandler(this.AccountClick);
			// 
			// accounttext
			// 
			this.accounttext.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.accounttext.ForeColor = System.Drawing.SystemColors.WindowText;
			this.accounttext.HideSelection = false;
			this.accounttext.Location = new System.Drawing.Point(12, 32);
			this.accounttext.Name = "accounttext";
			this.accounttext.ReadOnly = true;
			this.accounttext.Size = new System.Drawing.Size(171, 20);
			this.accounttext.TabIndex = 2;
			this.accounttext.TextChanged += new System.EventHandler(this.AccounttextTextChanged);
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(12, 16);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(218, 22);
			this.label1.TabIndex = 1;
			this.label1.Text = "Список аккаунтов";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(6, 214);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(255, 23);
			this.button1.TabIndex = 0;
			this.button1.Text = "Старт";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.success);
			this.groupBox2.Controls.Add(this.conquestt);
			this.groupBox2.Controls.Add(this.acount);
			this.groupBox2.Controls.Add(this.label4);
			this.groupBox2.Controls.Add(this.label3);
			this.groupBox2.Controls.Add(this.acount1);
			this.groupBox2.Location = new System.Drawing.Point(295, 6);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(244, 249);
			this.groupBox2.TabIndex = 1;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Статистика";
			// 
			// success
			// 
			this.success.Location = new System.Drawing.Point(219, 79);
			this.success.Name = "success";
			this.success.Size = new System.Drawing.Size(19, 15);
			this.success.TabIndex = 5;
			this.success.Text = "0";
			// 
			// conquestt
			// 
			this.conquestt.Location = new System.Drawing.Point(219, 56);
			this.conquestt.Name = "conquestt";
			this.conquestt.Size = new System.Drawing.Size(19, 15);
			this.conquestt.TabIndex = 4;
			this.conquestt.Text = "0";
			// 
			// acount
			// 
			this.acount.Location = new System.Drawing.Point(219, 35);
			this.acount.Name = "acount";
			this.acount.Size = new System.Drawing.Size(19, 15);
			this.acount.TabIndex = 3;
			this.acount.Text = "0";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(6, 79);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(100, 23);
			this.label4.TabIndex = 2;
			this.label4.Text = "Успешно:";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(6, 56);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 23);
			this.label3.TabIndex = 1;
			this.label3.Text = "Конкурсов:";
			// 
			// acount1
			// 
			this.acount1.Location = new System.Drawing.Point(6, 35);
			this.acount1.Name = "acount1";
			this.acount1.Size = new System.Drawing.Size(100, 23);
			this.acount1.TabIndex = 0;
			this.acount1.Text = "Аккаунтов:";
			// 
			// groupBox4
			// 
			this.groupBox4.Controls.Add(this.richTextBox1);
			this.groupBox4.Location = new System.Drawing.Point(560, 6);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Size = new System.Drawing.Size(270, 249);
			this.groupBox4.TabIndex = 2;
			this.groupBox4.TabStop = false;
			this.groupBox4.Text = "Обновления";
			// 
			// richTextBox1
			// 
			this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.richTextBox1.Location = new System.Drawing.Point(6, 19);
			this.richTextBox1.Name = "richTextBox1";
			this.richTextBox1.Size = new System.Drawing.Size(258, 224);
			this.richTextBox1.TabIndex = 0;
			this.richTextBox1.Text = "Обновление 1.0:\nРелиз программы.\nВ дорабатываемой части будет присутсвовать выбор" +
	" прокси.";
			// 
			// OpenFileDialog1
			// 
			this.OpenFileDialog1.Filter = "TXT Files |* .txt";
			this.OpenFileDialog1.Title = "Выберите файл";
			// 
			// openFileDialog2
			// 
			this.openFileDialog2.Filter = "TXT Files | *.txt";
			this.openFileDialog2.Title = "Выберите файл";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(842, 267);
			this.Controls.Add(this.groupBox4);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Name = "MainForm";
			this.Text = "mRandom";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox4.ResumeLayout(false);
			this.ResumeLayout(false);

		}
	}
}
