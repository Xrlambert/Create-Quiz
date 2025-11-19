using System;
using System.Windows.Forms;

namespace Quiz
{
    public partial class Form1 : Form
    {
        private System.Windows.Forms.Timer timer;

        int currentPage = 1;
        int corrects = 0;
        double time = 25;
        
        public Form1()
        {
            InitializeComponent();
            DisplayPage();

            timer = new System.Windows.Forms.Timer();
            timer.Interval = 1000;
            timer.Tick += Timer_Tick;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            int choice = 0;
            if (currentPage == 1)
            {
                lblTimer.Visible = true;
                timer.Start();
            }
            if (currentPage != 7) btnSubmit.Text = "Submit";
            radCheck(choice);
            switch (currentPage) {
                case 1:
                    radioButton1.Visible = radioButton2.Visible = radioButton3.Visible = radioButton4.Visible = true;
                    break;
                case 2:
                    if (choice == 3) corrects++;
                    break;
                case 3:
                    if (choice == 2) corrects++;
                    break;
                case 4:
                    if (choice == 1) corrects++;
                    break;
                case 5:
                    if (choice == 2) corrects++;
                    break;
                case 6:
                    if (choice == 4) corrects++;
                    break;
                case 7:
                    this.Close();
                    break;
                default:
                    //
                    break;
            }
            currentPage++;
            DisplayPage();
        }

        private int radCheck(int chose)
        {
            if (radioButton1.Checked) {
                chose = 1;
            } else if (radioButton2.Checked) {
                chose = 2;
            } else if (radioButton3.Checked) {
                chose = 3;
            } else if (radioButton4.Checked) {
                chose = 4;
            }
            return chose;
        }
        private void DisplayPage()
        {
            radioButton1.Checked = radioButton2.Checked = radioButton3.Checked = radioButton4.Checked = false;
            switch (currentPage) {
                case 1:
                    lblQuestion.Text = "Quiz";
                    radioButton1.Visible = radioButton2.Visible = radioButton3.Visible = radioButton4.Visible = false;
                    btnSubmit.Visible = true;
                    btnSubmit.Text = "Start";
                    break;
                case 2:
                    lblQuestion.Text = "Which of the following quantities is a vector?";
                    radioButton1.Text = "Speed";
                    radioButton2.Text = "Distance";
                    radioButton3.Text = "Velocity";
                    radioButton4.Text = "Energy";
                    break;
                case 3:
                    lblQuestion.Text = "What happens to the frequency of a wave if its wavelength increases while the speed stays constant?";
                    radioButton1.Text = "Increases";
                    radioButton2.Text = "Decreases";
                    radioButton3.Text = "Remains the same";
                    radioButton4.Text = "Doubles";
                    break;
                case 4:
                    lblQuestion.Text = "Which of Newton's laws explains why passengers lurch forward when a car suddenly stops?";
                    radioButton1.Text = "First Law (Inertia)";
                    radioButton2.Text = "Second Law (Force = mass x acceleration)";
                    radioButton3.Text = "Third Law (Action and Reaction)";
                    radioButton4.Text = "Law of Universal Gravitation";
                    break;
                case 5:
                    lblQuestion.Text = "What is the unit of electrical resistance?";
                    radioButton1.Text = "Volt";
                    radioButton2.Text = "Ohm";
                    radioButton3.Text = "Ampere";
                    radioButton4.Text = "Watt";
                    break;
                case 6:
                    lblQuestion.Text = "Which type of electromagnetic wave has the shortest wavelength?";
                    radioButton1.Text = "Radio waves";
                    radioButton2.Text = "Infrared";
                    radioButton3.Text = "X-rays";
                    radioButton4.Text = "Gamma rays";
                    break;

                case 7:
                    lblQuestion.Text = "Results";
                    radioButton1.Visible = radioButton2.Visible = radioButton3.Visible = radioButton4.Visible = false;
                    lblResult.Visible = true;
                    lblResult.Text = $"{corrects}/5" + $"{time}s remaining";
                    break;

            }

        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            lblTimer.Text = $"Time Left: {time}s";
            time--;
            if (time < 0)
            {
                timer.Stop();
                MessageBox.Show("Time's up!");
                Thread.Sleep(1000);
                currentPage = 7;
            }
        }
    }
}
