namespace AgeCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            btnCalculate.Click += btnCalculate_Click;
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            DateTime birthDate = dtpBirthdate.Value.Date;
            DateTime currentDate = dtpCurrentdate.Value.Date;

            if (birthDate >= currentDate)
            {
                MessageBox.Show("Birth date must be before the current date!", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            TimeSpan span = currentDate - birthDate;
            double totalDays = span.TotalDays;
            double totalHours = span.TotalHours;
            double totalMinutes = span.TotalMinutes;
            double totalSeconds = span.TotalSeconds;

            double years = Math.Floor(totalDays / 365.25);
            double remainingDays = totalDays % 365.25;
            double months = Math.Floor(remainingDays / 30.436875);
            double days = Math.Floor(remainingDays % 30.436875);

            lblYears.Text = $"{years}  Months: {months}  Days: {days}";
            lblDayss.Text = $"{Math.Floor(totalDays)}";
            lblWeeks.Text = $"{Math.Floor(totalDays / 7)}";
            lblHours.Text = $"{Math.Floor(totalHours)}";
            lblMinutes.Text = $"{Math.Floor(totalMinutes)}";
            lblSeconds.Text = $"{Math.Floor(totalSeconds)}";
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
