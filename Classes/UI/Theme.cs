using System.Drawing;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using System.IO; 

public class Theme
{
    public Color BackgroundColor { get; set; }
    public Color ForegroundColor { get; set; }
    public Color PanelColor { get; set; }
    public Color Header { get; set; }

    public Theme(bool dark)
    {
        if (dark)
        {
            BackgroundColor = Color.FromArgb(62, 62, 66);
            PanelColor = Color.FromArgb(31, 31, 33);
            Header = Color.FromArgb(36, 36, 39);
            ForegroundColor = Color.White;
        }
        else
        {
            BackgroundColor = Color.FromArgb(192, 192, 196);
            PanelColor = Color.FromArgb(223, 223, 225);
            Header = Color.FromArgb(223, 223, 225);
            ForegroundColor = Color.Black;
        }
    }

    public Color getBackColor()
    {
        return BackgroundColor;
    } 
    
    public Color getForeColor()
    {
        return ForegroundColor;
    }

    public void ApplyTheme(Control control)
    {
        control.BackColor = BackgroundColor;
        control.ForeColor = ForegroundColor;

        if (control.Name.Contains("panel"))
        {
            control.BackColor = PanelColor;
        }

        if (control.Name.Contains("header"))
        {
            control.BackColor = Header;
        }

        if (control is Guna2ContainerControl)
        {
            var gunaControl = control as Guna2ContainerControl;
            gunaControl.FillColor = BackgroundColor;
        }

        foreach (Control childControl in control.Controls)
        {
            ApplyTheme(childControl);
        }
    }

    public static void SaveTheme(bool isDark)
    {
        string theme = isDark ? "dark" : "light";
        File.WriteAllText("theme.txt", theme);
    }

    public static bool LoadTheme()
    {
        try
        {
            string theme = File.ReadAllText("theme.txt");
            return theme == "dark";
        }
        catch
        {
            return false;
        }
    }

    public static bool IsDarkTheme()
    {
        return LoadTheme();
    }
}
