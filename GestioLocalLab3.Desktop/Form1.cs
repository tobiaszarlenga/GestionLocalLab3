namespace GestioLocalLab3.Desktop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cbMes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tabReporte_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cbMes.Items.AddRange(new string[]
{
    "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12"
});
            cbMes.SelectedIndex = DateTime.Now.Month - 1;

            nudDia.Value = DateTime.Now.Day;
        }
    }
}
