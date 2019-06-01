using CrystalDecisions.CrystalReports.Engine;
using ResearchRecordingSystem;
using System.Windows.Forms;

namespace Test.Tabpages
{
    public partial class ViewReportForrm : Form
    {
        public int selectedThesisId;
        ResearchBook thesisTitle = new ResearchBook();
        RRSContext db = new RRSContext();
        ReportDocument myReportDocument;
        public ViewReportForrm()
        {
            InitializeComponent();
        }

        private void ViewReportForrm_Load(object sender, System.EventArgs e)
        {
            thesisTitle = db.ResearchBooks.Find(selectedThesisId);
            myReportDocument = new ReportDocument();
            myReportDocument.Load((Application.StartupPath + "\\CrystalReport.rpt"));
            //myReportDocument.SetDatabaseLogon("bhimbol", "inpout32.dll", "air/bhimsqlinstance", "axaDB");
            myReportDocument.SetParameterValue("ThesisTitleId", thesisTitle.ThesisTitleId);
            crystalReportViewer1.ReportSource = myReportDocument;
        }
    }
}
