using System.Windows.Forms;

namespace Wiener_Filtering
{
    public partial class AnalysisForm : Form
    {
        public AnalysisForm()
        {
            InitializeComponent();
        }

        private void OnClickButtonClose(object sender, System.EventArgs e)
        {
            if (MessageBox.Show(this, "Вы действительно хотите закрыть отчёт о полном анализе? Все экспериментальные данные будут потеряны без возможности восстановления!", 
                "Закрыть отчёт по анализу", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                Close();
        }
    }
}