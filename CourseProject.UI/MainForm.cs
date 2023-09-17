using CourseProject.UI.Abstractions;
using CourseProject.UI.Settings;
using CourseProject.UI.Enums;

namespace CourseProject.UI;

internal partial class MainForm : Form, IMainForm
{
    public MainForm()
    {
        InitializeComponent();
    }

    public async Task ChangeSettings(BrowserSettings settings)
    {
        this.Invoke(() =>
        {
            if (settings.Title is not null)
            {
                this.Text = settings.Title;
            }

            if (settings.SizeMode is not null)
            {
                switch (settings.SizeMode)
                {
                    case SizeMode.FullSize:
                        this.WindowState = FormWindowState.Maximized;
                        break;
                    case SizeMode.Windowed:
                        this.WindowState = FormWindowState.Normal;
                        break;
                }
            }

            if (settings.BackgroundColor is not null)
            {
                this.BackColor = settings.BackgroundColor.Value;
            }

            if (settings.ScreenSize is not null)
            {
                this.Size = settings.ScreenSize.Value;
            }
        });
    }

    public async Task WaitCursor(bool wait)
    {
        throw new NotImplementedException();
    }

    public async Task ShowView(BaseView view)
    {
        this.Invoke(() =>
        {
            this.Controls.Clear();

            this.Controls.Add(view);
        });
    }
}
