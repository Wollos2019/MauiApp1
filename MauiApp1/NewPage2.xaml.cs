namespace MauiApp1;

public partial class NewPage2 : ContentPage
{
    public const double MyFontSize = 28;
    string _fileName = Path.Combine(FileSystem.AppDataDirectory, "notes.txt");
    public NewPage2()
	{
		InitializeComponent();

        if (File.Exists(_fileName))
        {
            editor.Text = File.ReadAllText(_fileName);
        }
    }

    void OnSaveButtonClicked(object sender, EventArgs e)
    {
        File.WriteAllText(_fileName, editor.Text);
    }

    void OnDeleteButtonClicked(object sender, EventArgs e)
    {
        if (File.Exists(_fileName))
        {
            File.Delete(_fileName);
        }
        editor.Text = string.Empty;
    }
}

public class GlobalFontSizeExtension : IMarkupExtension
{
    public object ProvideValue(IServiceProvider serviceProvider)
    {
        return NewPage2.MyFontSize;
    }
}