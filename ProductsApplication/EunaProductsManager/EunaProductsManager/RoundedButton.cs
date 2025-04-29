using System.Drawing.Drawing2D;
using System.Windows.Forms;

public class RoundedButton : Button
{
    protected override void OnPaint(PaintEventArgs pevent)
    {
        base.OnPaint(pevent);

        // Create a rounded rectangle path
        GraphicsPath path = new GraphicsPath();
        int radius = 20; // adjust corner radius
        path.AddArc(0, 0, radius, radius, 180, 90);
        path.AddArc(Width - radius, 0, radius, radius, 270, 90);
        path.AddArc(Width - radius, Height - radius, radius, radius, 0, 90);
        path.AddArc(0, Height - radius, radius, radius, 90, 90);
        path.CloseAllFigures();

        // Set button region
        this.Region = new Region(path);
    }
}
