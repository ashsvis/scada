using System.Data.OleDb;
using System.Windows.Forms;

namespace awp.View
{
    public partial class ucBrowserDatabase : UserControl
    {
        public static string connectString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=awp.mdb;";

        private static OleDbConnection myConnection;

        private static OleDbTransaction myTransaction;

        public ucBrowserDatabase()
        {
            InitializeComponent();
        }

        private static void BeginTransaction()
        {
            myTransaction = myConnection.BeginTransaction();
        }

        private static void CommitTransaction()
        {
            myTransaction?.Commit();
            myTransaction = null;
        }

        private static void RollbackTransaction()
        {
            myTransaction?.Rollback();
            myTransaction = null;
        }

        private void ucBrowserDatabase_Load(object sender, System.EventArgs e)
        {

        }
    }
}
