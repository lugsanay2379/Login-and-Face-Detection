using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;
using FaceRecognition;

namespace Login
{
    public partial class Login : Form
    {
        FaceRec faceRec = new FaceRec();
        public Login()
        {
            InitializeComponent();
        }
        DataClasses1DataContext db = new DataClasses1DataContext();
        private void button1_Click(object sender, EventArgs e)
        {
            int result;
            result = db.sp_login(textBox1.Text, textBox2.Text).Count();

            if (result == 0)
            {
                MessageBox.Show("Unknown name or password");

            }
            else
            {
                if (db.sp_type(textBox1.Text, textBox2.Text) == 0)
                {
                    MessageBox.Show("Welcome Admin");

                }
                else
                {
                    MessageBox.Show("Welcome Staff");
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 facedetection = new Form2();
            facedetection.Show();
            this.Hide();
        }
    }
}
