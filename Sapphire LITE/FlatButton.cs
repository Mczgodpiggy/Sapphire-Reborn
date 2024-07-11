using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Windows.Forms;
using ns0;

public sealed class FlatButton : Button
{
    private bool bool_0;

    private Padding padding_0 = new Padding(0, 0, 0, 0);

    private Color color_0;

    private Padding padding_1 = new Padding(0, 0, 0, 0);

    private Color color_1;

    private int int_0;

    private int int_1;

    private Color color_2;

    private float float_0 = 1f;

    private string string_0 = "button";

    private Color color_3 = Color.White;

    private float float_1 = 1f;

    private Color color_4 = Color.LightGray;

    private Color color_5 = Color.FromArgb(100, 100, 100);

    private int int_2;

    private string string_1 = "Center";

    [Category("QuarryButton - Custom")]
    public Padding Padding_0
    {
        get
        {
            return padding_0;
        }
        set
        {
            padding_0 = value;
        }
    }

    [Category("QuarryButton - Custom")]
    public Color Color_0
    {
        get
        {
            return color_0;
        }
        set
        {
            color_0 = value;
            Invalidate();
        }
    }

    [Category("QuarryButton - Hovered")]
    public Padding Padding_1
    {
        get
        {
            return padding_1;
        }
        set
        {
            padding_1 = value;
        }
    }

    [Category("QuarryButton - Hovered")]
    public Color Color_1
    {
        get
        {
            return color_1;
        }
        set
        {
            color_1 = value;
            Invalidate();
        }
    }

    [Category("QuarryButton - TextOptions")]
    public int Int32_0
    {
        get
        {
            return int_0;
        }
        set
        {
            int_0 = value;
            Invalidate();
        }
    }

    [Category("QuarryButton - TextOptions")]
    public int Int32_1
    {
        get
        {
            return int_1;
        }
        set
        {
            int_1 = value;
            Invalidate();
        }
    }

    [Category("QuarryButton - Hovered")]
    public Color Color_2
    {
        get
        {
            return color_2;
        }
        set
        {
            color_2 = value;
            Invalidate();
        }
    }

    [Category("QuarryButton - Misc")]
    public float Single_0
    {
        get
        {
            return float_0;
        }
        set
        {
            float_0 = value;
            Invalidate();
        }
    }

    [Description("Changes the size of the text")]
    public Color Color_3
    {
        get
        {
            return color_3;
        }
        set
        {
            color_3 = value;
            Invalidate();
        }
    }

    public float Single_1
    {
        get
        {
            return float_1;
        }
        set
        {
            float_1 = value;
            Invalidate();
        }
    }

    [Description("Changes the color of the checkbox when unchecked")]
    public Color Color_4
    {
        get
        {
            return color_4;
        }
        set
        {
            color_4 = value;
            Invalidate();
        }
    }

    [Description("Changes the border color of the checkbox when unchecked")]
    public Color Color_5
    {
        get
        {
            return color_5;
        }
        set
        {
            color_5 = value;
            Invalidate();
        }
    }

    [Description("Use these keywords (capitals included): Center ; Left ; Right")]
    [Category("QuarryButton - Misc")]
    public string String_0
    {
        get
        {
            return string_1;
        }
        set
        {
            string_1 = value;
            Invalidate();
        }
    }

    public string String_1
    {
        get
        {
            return string_0;
        }
        set
        {
            string_0 = value;
            Invalidate();
        }
    }

    public int Int32_2
    {
        get
        {
            return int_2;
        }
        set
        {
            int_2 = value;
            Invalidate();
        }
    }

    public FlatButton()
    {
        SetStyle(ControlStyles.UserPaint | ControlStyles.ResizeRedraw | ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer, value: true);
        DoubleBuffered = true;
    }

    protected override void OnHandleCreated(EventArgs e)
    {
        base.OnHandleCreated(e);
    }

    protected override void OnMouseHover(EventArgs e)
    {
        base.OnMouseHover(e);
    }

    protected override void OnPaint(PaintEventArgs e)
    {
        Pen pen = new Pen(color_5, float_1);
        SolidBrush brush = new SolidBrush(color_4);
        Pen pen2 = new Pen(color_2, float_1);
        Rectangle bounds = new Rectangle(int_0, int_1, Width - 1, Height - 1);
        Graphics graphics = e.Graphics;
        graphics.SmoothingMode = SmoothingMode.AntiAlias;
        graphics.TextRenderingHint = TextRenderingHint.AntiAlias;
        graphics.Clear(Parent.BackColor);
        using (GraphicsPath path = Class1.smethod_0(0f, 0f, Width - 1, Height - 1, float_0))
        {
            graphics.FillPath(brush, path);
            graphics.DrawPath(pen, path);
            graphics.TextRenderingHint = TextRenderingHint.ClearTypeGridFit;
            TextFormatFlags flags = TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter | TextFormatFlags.WordBreak;
            TextFormatFlags flags2 = TextFormatFlags.VerticalCenter | TextFormatFlags.WordBreak;
            TextFormatFlags flags3 = TextFormatFlags.Right | TextFormatFlags.VerticalCenter | TextFormatFlags.WordBreak;
            Font font = new Font(Font, FontStyle.Regular);
            if (string_1 == "Center")
            {
                TextRenderer.DrawText(e.Graphics, string_0, font, bounds, color_3, flags);
            }
            if (string_1 == "Left")
            {
                TextRenderer.DrawText(e.Graphics, string_0, font, bounds, color_3, flags2);
            }
            if (string_1 == "Right")
            {
                TextRenderer.DrawText(e.Graphics, string_0, font, bounds, color_3, flags3);
            }
        }
        if (bool_0)
        {
            if (padding_1.Top != 0)
            {
                graphics.DrawLine(new Pen(color_1, padding_1.Top), 0f + float_0, 0f, Width - float_0, 0f);
            }
            if (padding_1.Right != 0)
            {
                graphics.DrawLine(new Pen(color_1, padding_1.Right), -1 + Width, 0f + float_0, -1 + Width, Height - float_0);
            }
            if (padding_1.Bottom != 0)
            {
                graphics.DrawLine(new Pen(color_1, padding_1.Bottom), Width - float_0, Height - 1, 0f + float_0, Height - 1);
            }
            if (padding_1.Left != 0)
            {
                graphics.DrawLine(new Pen(color_1, padding_1.Left), 0f, Height - float_0, 0f, 0f + float_0);
            }
            GraphicsPath path2 = Class1.smethod_0(0f, 0f, Width - 1, Height - 1, float_0);
            graphics.DrawPath(pen2, path2);
            return;
        }
        if (padding_0.Top != 0)
        {
            graphics.DrawLine(new Pen(color_0, padding_0.Top), 0f + float_0, 0f, Width - float_0, 0f);
        }
        if (padding_0.Right != 0)
        {
            graphics.DrawLine(new Pen(color_0, padding_0.Right), -1 + Width, 0f + float_0, -1 + Width, Height - float_0);
        }
        if (padding_0.Bottom != 0)
        {
            graphics.DrawLine(new Pen(color_0, padding_0.Bottom), Width - float_0, Height - 1, 0f + float_0, Height - 1);
        }
        if (padding_0.Left != 0)
        {
            graphics.DrawLine(new Pen(color_0, padding_0.Left), 0f, Height - float_0, 0f, 0f + float_0);
        }
    }

    protected override void OnMouseEnter(EventArgs e)
    {
        base.OnMouseEnter(e);
        bool_0 = true;
        Invalidate();
    }

    protected override void OnMouseLeave(EventArgs e)
    {
        base.OnMouseLeave(e);
        bool_0 = false;
        Invalidate();
    }
}
