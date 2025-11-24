using System;
using System.Windows.Forms;
using System.Diagnostics;


/*
 * Make Own Quiz
 * Xavier Lambert
 * 11/120/2025
 *
 * Description:
 * Timed multiple-choice quiz 
 * with five physics questions. Tracks the user's score 
 * and remaining time, displays results at the end, and provides 
 * a simple interface for answering questions.
 */

namespace Quiz
{
    public partial class Form1 : Form
    {
        // Timer object used to count down quiz time
        private System.Windows.Forms.Timer timer;

        // Tracks which question/page the user is currently on
        int currentPage = 1;
        // Tracks the number of correct answers given
        int corrects = 0;
        // Total time allowed for the quiz (in seconds)
        double time = 25;

        Stopwatch stopwatch = new Stopwatch();
        double[] times = {0,0,0,0,0 };

        public Form1()
        {
            InitializeComponent();
            DisplayPage();

            // Configure timer to tick every second
            timer = new System.Windows.Forms.Timer();
            timer.Interval = 1000;
            timer.Tick += Timer_Tick;// Event for countdown

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            //stop stopwatch and store it in list to be used at end of quiz
            stopwatch.Stop();
            string elapsed = "";
            //grab time and convert to double and then put in list when not on first page
            if (currentPage > 1)
            {
                stopwatch.ElapsedMilliseconds.ToString(elapsed);
                times[currentPage - 2] = Convert.ToDouble(elapsed);
            }

            int choice = 0;

            // Start timer when quiz begins (on first page)
            if (currentPage == 1)
            {
                lblTimer.Visible = true;
                timer.Start();
            }

            // Change button text after start screen
            if (currentPage != 7) btnSubmit.Text = "Submit";

            // Determine which radio button was selected
            radCheck(choice);

            // Evaluate answer depending on current question
            switch (currentPage)
            {
                case 1:
                    // Show answer options after start
                    radioButton1.Visible = radioButton2.Visible = radioButton3.Visible = radioButton4.Visible = true;
                    break;
                case 2:
                    if (choice == 3) corrects++; //Velocity
                    break;
                case 3:
                    if (choice == 2) corrects++; //Decreases
                    break;
                case 4:
                    if (choice == 1) corrects++; //First Law (Inertia)
                    break;
                case 5:
                    if (choice == 2) corrects++; //Ohm
                    break;
                case 6:
                    if (choice == 4) corrects++; //Gamma rays
                    break;
                case 7:
                    this.Close();   // End quiz
                    break;
            }

            // Move to next question/page
            currentPage++;
            DisplayPage();
        }

        //Checks which radio button is selected and returns its number
        private int radCheck(int chose)
        {
            if (radioButton1.Checked)
            {
                chose = 1;
            }
            else if (radioButton2.Checked)
            {
                chose = 2;
            }
            else if (radioButton3.Checked)
            {
                chose = 3;
            }
            else if (radioButton4.Checked)
            {
                chose = 4;
            }
            return chose;
        }

        // Displays question text and answer options based on current page
        private void DisplayPage()
        {
            // Reset radio button selections
            radioButton1.Checked = radioButton2.Checked = radioButton3.Checked = radioButton4.Checked = false;
            switch (currentPage)
            {
                case 1:
                    // Title screen
                    lblQuestion.Text = "Quiz";
                    radioButton1.Visible = radioButton2.Visible = radioButton3.Visible = radioButton4.Visible = false;
                    btnSubmit.Visible = true;
                    btnSubmit.Text = "Start";
                    break;
                case 2:
                    // Question 1
                    lblQuestion.Text = "Which of the following quantities is a vector?";
                    radioButton1.Text = "Speed";
                    radioButton2.Text = "Distance";
                    radioButton3.Text = "Velocity";
                    radioButton4.Text = "Energy";
                    break;
                case 3:
                    // Question 2
                    lblQuestion.Text = "What happens to the frequency of a wave if its wavelength increases while the speed stays constant?";
                    radioButton1.Text = "Increases";
                    radioButton2.Text = "Decreases";
                    radioButton3.Text = "Remains the same";
                    radioButton4.Text = "Doubles";
                    break;
                case 4:
                    // Question 3
                    lblQuestion.Text = "Which of Newton's laws explains why passengers lurch forward when a car suddenly stops?";
                    radioButton1.Text = "First Law (Inertia)";
                    radioButton2.Text = "Second Law (Force = mass x acceleration)";
                    radioButton3.Text = "Third Law (Action and Reaction)";
                    radioButton4.Text = "Law of Universal Gravitation";
                    break;
                case 5:
                    // Question 4
                    lblQuestion.Text = "What is the unit of electrical resistance?";
                    radioButton1.Text = "Volt";
                    radioButton2.Text = "Ohm";
                    radioButton3.Text = "Ampere";
                    radioButton4.Text = "Watt";
                    break;
                case 6:
                    // Question 5
                    lblQuestion.Text = "Which type of electromagnetic wave has the shortest wavelength?";
                    radioButton1.Text = "Radio waves";
                    radioButton2.Text = "Infrared";
                    radioButton3.Text = "X-rays";
                    radioButton4.Text = "Gamma rays";
                    break;

                case 7:
                    // Results screen
                    lblQuestion.Text = "Results";
                    radioButton1.Visible = radioButton2.Visible = radioButton3.Visible = radioButton4.Visible = false;
                    lblResult.Visible = true;
                    lblResult.Text = $"{corrects}/5" + $"{time}s remaining";
                    break;

            }

        }

        // Timer tick event: updates countdown and ends quiz if time runs out
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

        private void restarted_Click(object sender, EventArgs e)
        {
            // Reset quiz state for restart
            currentPage = 1;
            DisplayPage();
            corrects = 0;
            time = 25;
            lblResult.Visible = false;
            lblTimer.Visible = false;
            radioButton1.Visible = radioButton2.Visible = radioButton3.Visible = radioButton4.Visible = false;
        }
    }
}
