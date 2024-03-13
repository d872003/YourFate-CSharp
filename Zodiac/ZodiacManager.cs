using Services;

namespace Zodiac
{
    //Class Form1 chính là class kế thừa cái class gốc mà Windows cung cấp để render ra cửa sổ tương tác
    //Form là class cha có khả năng render 1 hình chữ nhật để cung cấp mặt sàn tương tác với user
    //Ta lập trình app GUI, app Desktop, tức là cái app chạy trên nền Desktop, có icon biểu tượng trên thanh Taskbar
    //Chính là tạo ra 1 class kế thừa class Form
    //Con extends Cha
    public partial class ZodiacManager : Form
    {
        public ZodiacManager()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {


        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Image img = Image.FromFile("C:\\Study\\S5\\CSharp\\Session07-GUI\\YourFate\\Zodiac\\bin\\Debug\\net6.0-windows\\signs\\hotgirl.jpg");
            Image img = Image.FromFile(@"signs\hotgirl.jpg");
            //2. show ảnh
            picImg.Image = img;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            int day = int.Parse(txtDay.Text);
            int month = int.Parse(txtMonth.Text);
            string zodiacEnglish = ZodiacCalculator.GetZodiacEnglish(month, day);
            string zodiacVietnamese = ZodiacCalculator.GetZodiacVietnamese(zodiacEnglish);
            string zodiacImg = @"signs\" + zodiacEnglish + ".jpg";
            // load ảnh và cập nhật cung 
            picImg.Image = Image.FromFile(zodiacImg);
            lblYourZodiac.Text = "Your zodiac sign is \n" + zodiacEnglish + "\n" + zodiacVietnamese;
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void ZodiacManager_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click_3(object sender, EventArgs e)
        {

        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            //hỏi thật sự muốn thoát hay không
            DialogResult answer = MessageBox.Show("Do you want to exit?", "Exit", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if(answer == DialogResult.OK)
            {
                Application.Exit();
            }

        }

        private void txtDay_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblDay_Click(object sender, EventArgs e)
        {

        }
    }
}
