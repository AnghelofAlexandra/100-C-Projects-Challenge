using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelloWorld
{
    public partial class Form2 : Form
    {
        private string name;
        private string message;
        private Timer typingTimer;
        private int currentIndex;

        public Form2(string _name)
        {
            InitializeComponent();

            this.name = _name;
            this.message = "Hello, " + this.name + "! Nice to meet you! =)";

            lblGreeting.Text = "";

            this.currentIndex = 0;
            this.typingTimer = new Timer();
            this.typingTimer.Interval = 60;
            this.typingTimer.Tick += TypingTimer_Tick;
            this.typingTimer.Start();
        }

        private void TypingTimer_Tick(object sender, EventArgs e)
        {
            if (this.currentIndex < this.message.Length)
            {
                lblGreeting.Text += this.message[currentIndex];
                currentIndex++;
            }
            else
            {
                this.typingTimer.Stop();
                this.typingTimer.Dispose();
            }
        }
    }
}
