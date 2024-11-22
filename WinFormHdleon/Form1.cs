using Microsoft.Extensions.DependencyInjection;

namespace WinFormHdleon
{
    public partial class Form1 : Form
    {
        private readonly IServiceProvider _serviceProvider;


        public Form1(IServiceProvider serviceProvider)
        {
            InitializeComponent();
            _serviceProvider = serviceProvider;
        }

        private void marcasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //var frm = new FromBrand();
            var frm = _serviceProvider!.GetRequiredService<FromBrand>();
            frm.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void cervezasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = _serviceProvider!.GetRequiredService<FormBeer>();
            frm.ShowDialog();
        }
    }
}
