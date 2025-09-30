namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string gender = "";
            if (checkBox1.Checked) gender = "male";
            if (checkBox2.Checked) gender = "qadin";

            string language = "";
            if (checkBox3.Checked) language += "ingilisce ";
            if (checkBox4.Checked) language += "Azerbaycanca ";

            string program = "";
            if (checkBox5.Checked) program += "C++ ";
            if (checkBox6.Checked) program += "Java ";

            string yasadigiYer = comboBox1.Text;
            string oxuduguYer = comboBox2.Text;

            string message = $"Gender: {gender}\nLanguage: {language}\nProgram: {program}\nYasadığı yer: {yasadigiYer}\nOxuduğu yer: {oxuduguYer}";

            MessageBox.Show(message);
        }

    }
}
