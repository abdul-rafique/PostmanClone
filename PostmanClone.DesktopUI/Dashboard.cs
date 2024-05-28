using PostmanClone.Library;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Net.Mime;
using System.Text;

namespace PostmanClone.DesktopUI;

public partial class Dashboard : Form
{
    private readonly IApiAccess _api = new ApiAccess();

    public Dashboard()
    {
        InitializeComponent();
        httpVerbSelectionBox.SelectedItem = "GET";
        apiTextBox.Text = "https://jsonplaceholder.typicode.com/posts";
    }

    private async void callApiBtn_Click(object sender, EventArgs e)
    {
        systemStatus.Text = "Calling API...";
        resultTextBox.Text = string.Empty;

        if (_api.IsValidUrl(apiTextBox.Text) == false)
        {
            systemStatus.Text = "Invalid URL";
            return;
        }

        HttpAction action;

        if (Enum.TryParse(httpVerbSelectionBox.SelectedItem!.ToString(), out action) == false)
        {
            systemStatus.Text = "Invalid HTTP Verb";
            return;
        }

        try
        {
            resultTextBox.Text = await _api.CallApiAsync(apiTextBox.Text, bodyTextBox.Text, action);

            callDataTabControl.SelectedTab = resultsTab;
            resultsTab.Focus();

            systemStatus.Text = "Ready";
        }
        catch (Exception ex)
        {
            resultTextBox.Text = "Error: " + ex.Message;
            systemStatus.Text = "Error";
        }
    }

    private void resultTextBox_TextChanged(object sender, EventArgs e)
    {

    }
}
