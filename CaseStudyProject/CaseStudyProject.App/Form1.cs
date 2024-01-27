using CaseStudyProject.Toolbox.RandomGenerateCode;
using CaseStudyProject.Toolbox.ReceiptParserJson;

namespace CaseStudyProject.App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRandomCode_Click(object sender, EventArgs e)
        {

          // JsonParser.ResultJson();
            var guidCodeList= GenerateRandom.GenerateRandomCode();


            Console.ReadLine();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}