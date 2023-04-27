namespace Ukol4NakupniSeznam
{
	public partial class PolozkaForm : Form
	{
		private SpravcePolozek spravcePolozek = new SpravcePolozek();
		public PolozkaForm()
		{
			InitializeComponent();
			try
			{
				spravcePolozek.Nacti();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			polozkyListBox.DataSource = spravcePolozek.Polozky;
		}

		private void pridatButton_Click(object sender, EventArgs e)
		{
			if (pridatTextBox !=null)
			{
				spravcePolozek.PridejPolozku(pridatTextBox.Text);
				spravcePolozek.Uloz();
			}
		}

		private void odebratPolozkuButton_Click(object sender, EventArgs e)
		{
			if (polozkyListBox!= null)
			{
				spravcePolozek.OdeberPolozku((Polozka)polozkyListBox.SelectedItem);
				spravcePolozek.Uloz();
			}
		}
	}
}