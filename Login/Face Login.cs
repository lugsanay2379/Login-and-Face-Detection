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
    public partial class Form2 : Form
    {
        FaceRec faceRec = new FaceRec();
        public Form2()
        {
            InitializeComponent();
        }
        private void btnOpenCamera_Click(object sender, EventArgs e)
        {
            faceRec.openCamera(pbCamera, pbCaptured);
        }

        private void btnSaveImage_Click(object sender, EventArgs e)
        {
            faceRec.Save_IMAGE(textBox3.Text);
            MessageBox.Show("Save Success!");
        }

        private void btnDetectFaces_Click(object sender, EventArgs e)
        {
            faceRec.isTrained = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Login Login = new Login();
            Login.Show();
            this.Hide();

        }
    }
}
