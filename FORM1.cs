using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
namespace ConsoleApp2
{
   public partial class FORM1:Form
    {
        private TextBox textBox1;
        private Button button1;

        public FORM1()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(24, 177);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(527, 100);
            this.button1.TabIndex = 0;
            this.button1.Text = "click";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(101, 118);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(337, 26);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "tamar";
            // 
            // FORM1
            // 
            this.ClientSize = new System.Drawing.Size(597, 329);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Name = "FORM1";
            this.ResumeLayout(false);
            this.PerformLayout();
            this.BackColor = Color.Gold;


        }

        private void Button1_Click(object sender, EventArgs e)
        {
            button1.Text = textBox1.Text;
            Form f = new Form();
            f.StartPosition = FormStartPosition.Manual;
            Random r = new Random();
         
            f.Location = new Point(23,45);
            f.Show();
           f.BackColor = Color.Aqua;

            textBox1.Font = new Font( new FontFamily("Magneto"),25);
            button1.Enabled = false;
            button1.ForeColor = Color.DarkKhaki;
            button1.Visible = false;
            textBox1.Cursor = Cursors.Cross;
            Button b2 = new Button();
            b2.Location = new Point(12,12);
            b2.Size = new Size(120,98);
            b2.Text = "butten";
            Label L1 = new Label();
            L1.Text = textBox1.Text;
            this.Controls.Add(b2);
            this.Controls.Add(L1);

        }
    }
  
 }



        
            
     
