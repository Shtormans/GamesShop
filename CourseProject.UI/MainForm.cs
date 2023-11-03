
using CourseProject.UI.Abstractions;
using CourseProject.UI.Enums;
using CourseProject.UI.Settings;

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

            if (settings.IsLocked is not null)
            {
                if (settings.IsLocked.Value)
                {
                    this.FormBorderStyle = FormBorderStyle.FixedSingle;
                }
                else
                {
                    this.FormBorderStyle = FormBorderStyle.Sizable;
                }
            }
        });
    }

    public async Task WaitCursor(bool wait)
    {
        this.UseWaitCursor = wait;
    }

    public async Task ShowView(BaseView view)
    {
        this.Invoke(() =>
        {
            this.Controls.Clear();

            this.Controls.Add(view);
        });
    }

    public async Task ShowErrorMessage(string message)
    {
        this.Invoke(() =>
        {
            MessageBox.Show(message);
        });
    }

    public async Task<string?> OpenFileDialog(string filter)
    {
        string? result = null;

        Thread t = new Thread(() => {
            OpenFileDialog saveFileDialog1 = new OpenFileDialog();

            saveFileDialog1.Filter = filter;

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                result = saveFileDialog1.FileName;
            }
            else
            {
                result = null;
            }
        });

        t.SetApartmentState(ApartmentState.STA);
        t.Start();
        t.Join();

        return result;
    }
}
