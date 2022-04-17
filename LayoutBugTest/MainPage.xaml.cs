namespace LayoutBugTest;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
		LoadLayout();
	}

	private void LoadLayout()
	{
		Label label1 = new Label();
		Label label2 = new Label();
		Label label3 = new Label();

		label1.Text = "1";
		label2.Text = "2";
		label3.Text = "3";

		layout.Clear();

		layout.Add(label1);
		layout.Add(label2);
		layout.Add(label3);
	}

	private void Button_Pressed(object sender, EventArgs e)
	{
		LoadLayout();
	}
}

