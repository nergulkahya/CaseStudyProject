using CaseStudyProject.Toolbox.RandomGenerateCode;
using CaseStudyProject.Toolbox.ReceiptParserJson;

namespace CaseStudyProject.App
{
    public partial class FrmGenerateCode : Form
    {
        public FrmGenerateCode()
        {
            InitializeComponent();
        }

        private void btnRandomCode_Click(object sender, EventArgs e)
        {
          // JsonParser.ResultJson();
           
        }

        private void FrmGenerateCode_Load(object sender, EventArgs e)
        {
            var guidCodeList = GenerateRandom.GenerateRandomCode();
            foreach (var item in guidCodeList)
            {
                lstCodeList.Items.Add(item);

            }
        }
    }
}