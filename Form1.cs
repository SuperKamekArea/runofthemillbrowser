using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace run_of_the_mill_browser
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            webBrowser1.GoBack();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            webBrowser1.Refresh();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            webBrowser1.GoForward();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var TypedUrl = textBox1.Text;
            webBrowser1.Navigate(TypedUrl);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {

        }

        private void MediaPlayerOpen_Click(object sender, EventArgs e)
        {
            var FileForPlayer = textBox2.Text;
            axWindowsMediaPlayer1.URL = FileForPlayer;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var FileForPlayer = textBox2.Text;
            axWindowsMediaPlayer1.openPlayer(FileForPlayer);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            var UpdateURL = webBrowser1.Url.ToString();
            textBox3.Text = UpdateURL;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void axProgressBar1_Enter(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("http://dogpile.com/serp?q=" + textBox4.Text);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("http://www.ask.com/web?q=" + textBox4.Text); 
        }

        private void button10_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("http://google.com/search?q=" + textBox4.Text);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("http://search.aol.com/aol/search?q=" + textBox4.Text);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("http://search.yahoo.com/search?p=" + textBox4.Text);
        
        }

        private void button9_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("http://www.bing.com/search?q=" + textBox4.Text);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("http://yandex.com/search/?text=" + textBox4.Text); 
        }

        private void button7_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("http://ddg.gg/?q=" + textBox4.Text);
        }

        private void axXcpControl1_Enter(object sender, EventArgs e)
        {

        }

        private void axXcpControl1_Enter_1(object sender, EventArgs e)
        {

        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void button15_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("http://twitter.com/");
        }

        private void button16_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("http://facebook.com/");
        }

        private void button19_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("http:///");
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button17_Click(object sender, EventArgs e)
        {
            Bookmarks.Items.Add(textBox5.Text);
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button15_Click_1(object sender, EventArgs e)
        {
            webBrowser1.Navigate("http://twitter.com/");
        }

        private void button18_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("http://answers.yahoo.com/");
        }

        private void button16_Click_1(object sender, EventArgs e)
        {
            webBrowser1.Navigate("http://facebook.com/");
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
