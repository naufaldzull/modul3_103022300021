namespace modul3_103022300021
{
    public partial class Form1 : Form
    {
        string hasilString = ""; // inisiasi hasilString
        int hasilInt = 0; // inisiasi hasilInt
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e) 
        {
            hasilInt += Convert.ToInt16(textBox1.Text); // Mengkonversi textbox string menjadi int
            textBox1.Text = ""; // String kosong mengisi textbox
        }

        private void button3_Click(object sender, EventArgs e) // Button Angka 3
        {
            textBox1.Text += "3"; // Textbox akan terisi angka apabila di click
        }

        private void button6_Click(object sender, EventArgs e) // Button Angka 6
        {
            textBox1.Text += "6"; // Textbox akan terisi angka apabila di click
        }

        private void button11_Click(object sender, EventArgs e) // Button Angka 0
        {
            textBox1.Text += "0"; // Textbox akan terisi angka apabila di click
        }

        private void button1_Click(object sender, EventArgs e) // Button Angka 1
        {
           
            textBox1.Text += "1"; // Textbox akan terisi angka apabila di click
        }

        private void button2_Click(object sender, EventArgs e) // Button Angka 2
        {
            
            textBox1.Text += "2"; // Textbox akan terisi angka apabila di click
        }

        private void button4_Click(object sender, EventArgs e) // Button Angka 4
        {
            textBox1.Text += "4"; // Textbox akan terisi angka apabila di click
        }

        private void button5_Click(object sender, EventArgs e) // Button Angka 5
        {
            textBox1.Text += "5"; // Textbox akan terisi angka apabila di click
        }

        private void button7_Click(object sender, EventArgs e) // Button Angka 7
        {
            textBox1.Text += "7"; // Textbox akan terisi angka apabila di click
        }

        private void button8_Click(object sender, EventArgs e) // Button Angka 8
        {
            textBox1.Text += "8"; // Textbox akan terisi angka apabila di click
        }

        private void button9_Click(object sender, EventArgs e) // Button Angka 9
        {
            textBox1.Text += "9"; // Textbox akan terisi angka apabila di click
        }

        private void button12_Click(object sender, EventArgs e) 
        {
            hasilInt += Convert.ToInt16(textBox1.Text); // Menkonvert textBox yang awalnya String menjadi Integer
            textBox1.Text =  hasilInt.ToString(); // Hasil int akan mengisi textbox
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

      
    }
}
