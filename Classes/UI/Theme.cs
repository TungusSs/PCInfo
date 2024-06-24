using System.Drawing;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using System.IO;

/// <summary>
/// Класс для управления темами приложения.
/// </summary>
public class Theme
{
    public Color BackgroundColor { get; set; }
    public Color ForegroundColor { get; set; }
    public Color PanelColor { get; set; }
    public Color Header { get; set; }

    /// <summary>
    /// Конструктор, устанавливающий цвета темы в зависимости от переданного параметра.
    /// </summary>
    /// <param name="dark">Если true, устанавливается тёмная тема, иначе светлая.</param>
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

    /// <summary>
    /// Метод для получения цвета фона.
    /// </summary>
    /// <returns>Цвет фона.</returns>
    public Color getBackColor()
    {
        return BackgroundColor;
    }

    /// <summary>
    /// Метод для получения цвета переднего плана.
    /// </summary>
    /// <returns>Цвет переднего плана.</returns>
    public Color getForeColor()
    {
        return ForegroundColor;
    }

    /// <summary>
    /// Применяет текущую тему к указанному элементу управления и его дочерним элементам.
    /// </summary>
    /// <param name="control">Элемент управления, к которому применяется тема.</param>
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

        if (control is Guna2ContainerControl gunaControl)
        {
            gunaControl.FillColor = BackgroundColor;
        }

        foreach (Control childControl in control.Controls)
        {
            ApplyTheme(childControl);
        }
    }

    /// <summary>
    /// Сохраняет текущую тему в файл.
    /// </summary>
    /// <param name="isDark">Если true, сохраняется тёмная тема, иначе светлая.</param>
    public static void SaveTheme(bool isDark)
    {
        string theme = isDark ? "dark" : "light";
        File.WriteAllText("theme.txt", theme);
    }

    /// <summary>
    /// Загружает тему из файла.
    /// </summary>
    /// <returns>Возвращает true, если тема тёмная, иначе false.</returns>
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

    /// <summary>
    /// Проверяет, является ли текущая тема тёмной.
    /// </summary>
    /// <returns>Возвращает true, если тема тёмная, иначе false.</returns>
    public static bool IsDarkTheme()
    {
        return LoadTheme();
    }
}
