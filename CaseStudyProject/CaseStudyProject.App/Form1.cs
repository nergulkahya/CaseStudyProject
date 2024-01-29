using CaseStudyProject.Toolbox.RandomGenerateCode;
using CaseStudyProject.Toolbox.ReceiptParserJson;
using Newtonsoft.Json.Linq;

namespace CaseStudyProject.App
{
    public partial class FrmGenerateCode : Form
    {
        public FrmGenerateCode()
        {
            InitializeComponent();
        }

       

        private void FrmGenerateCode_Load(object sender, EventArgs e)
        {
            JsonParser.ResultJson();
        }

        private void btnCode_Click(object sender, EventArgs e)
        {
            string code = GenerateRandom.GenerateRandomCode();
            if (code != "")
            {
                lstCodeList.Items.Add(code);
            }
            
        }
    }
}