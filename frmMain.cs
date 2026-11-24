namespace WF_Controls_GroupboxCheckboxEx
{
	public partial class frmMain : Form
	{
		public frmMain()
		{
			InitializeComponent();
		}

		private void cbItalic_CheckedChanged(object sender, EventArgs e)
		{
			llExample.Font = 
				new Font(llExample.Font, llExample.Font.Style ^ FontStyle.Italic);
		}

		private void cbBold_CheckedChanged(object sender, EventArgs e)
		{
			llExample.Font = new Font(llExample.Font, llExample.Font.Style ^ FontStyle.Bold);
		}
	}
}