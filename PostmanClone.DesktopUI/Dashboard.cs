using PostmanClone.Library;

namespace PostmanClone.DesktopUI;

public partial class Dashboard : Form
{
    private readonly IApiAccess _api = new ApiAccess();

    public Dashboard()
    {
        InitializeComponent();
    }

    private async void callApiBtn_Click(object sender, EventArgs e)
    {
        systemStatus.Text = "Calling API...";
        resultTextBox.Text = string.Empty;

        if(_api.IsValidUrl(apiTextBox.Text) == false)
        {
            systemStatus.Text = "Invalid URL";
            return;
        }

        try
        {
            resultTextBox.Text = await _api.CallApiAsync(apiTextBox.Text);

            systemStatus.Text = "Ready";
        }
        catch (Exception ex)
        {
            resultTextBox.Text = "Error: " + ex.Message;
            systemStatus.Text = "Error";
        }
    }

}
