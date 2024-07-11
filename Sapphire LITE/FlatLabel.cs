using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

public class FlatLabel : Label
{
    private float opacity = 1.0f;
    private Bitmap backBuffer;

    [Category("Appearance")]
    [Description("The opacity of the label. Value ranges from 0.0 (completely transparent) to 1.0 (completely opaque).")]
    public float Opacity
    {
        get { return opacity; }
        set
        {
            opacity = value;
            Invalidate();
        }
    }

    protected override void OnPaint(PaintEventArgs e)
    {
        if (backBuffer == null || backBuffer.Size != ClientSize)
        {
            if (backBuffer != null)
            {
                backBuffer.Dispose();
            }

            backBuffer = new Bitmap(ClientSize.Width, ClientSize.Height);
        }

        using (var graphics = Graphics.FromImage(backBuffer))
        {
            graphics.Clear(BackColor);
            using (var brush = new SolidBrush(Color.FromArgb((int)(Opacity * 255), ForeColor)))
            {
                graphics.DrawString(Text, Font, brush, ClientRectangle);
            }
        }

        e.Graphics.DrawImageUnscaled(backBuffer, 0, 0);
    }

    protected override void OnResize(EventArgs e)
    {
        if (backBuffer != null)
        {
            backBuffer.Dispose();
            backBuffer = null;
        }

        base.OnResize(e);
    }

    protected override void Dispose(bool disposing)
    {
        if (disposing)
        {
            backBuffer?.Dispose();
        }

        base.Dispose(disposing);
    }

}
