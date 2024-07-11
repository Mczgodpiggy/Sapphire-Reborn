using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Windows.Forms;
using ns0;

public sealed class FlatPanel : Panel
{
    private bool bool_0;

    private Padding padding_0 = new Padding(0, 0, 0, 0);

    private Color color_0;

    private Padding padding_1 = new Padding(0, 0, 0, 0);

    private Color color_1;

    private float float_0 = 1f;

    private float float_1 = 1f;

    private float float_2 = 1f;

    private Color color_2 = Color.LightGray;

    private Color color_3 = Color.Black;

    [Category("QuarryPanel - Custom")]
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

    [Category("QuarryPanel - Custom")]
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

    [Category("QuarryPanel - Hovered")]
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

    [Category("QuarryPanel - Hovered")]
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

    [Category("QuarryPanel - Hovered")]
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

    [Category("QuarryPanel - Misc")]
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

    [Category("QuarryPanel - Misc")]
    public float Single_2
    {
        get
        {
            return float_2;
        }
        set
        {
            float_2 = value;
            Invalidate();
        }
    }

    [Category("QuarryPanel - Main")]
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

    [Category("QuarryPanel - Main")]
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

    public FlatPanel()
    {
        SetStyle(ControlStyles.UserPaint | ControlStyles.ResizeRedraw | ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer, value: true);
        DoubleBuffered = true;
    }

    protected override void OnHandleCreated(EventArgs e)
    {
        base.OnHandleCreated(e);
    }

    protected override void OnPaint(PaintEventArgs e)
    {
        Pen pen = new Pen(color_3, float_2);
        SolidBrush brush = new SolidBrush(color_2);
        Graphics graphics = e.Graphics;
        graphics.SmoothingMode = SmoothingMode.AntiAlias;
        graphics.TextRenderingHint = TextRenderingHint.AntiAlias;
        graphics.Clear(Parent.BackColor);
        using (GraphicsPath path = Class1.smethod_0(0f, 0f, Width - 1, Height - 1, float_1))
        {
            graphics.FillPath(brush, path);
            graphics.DrawPath(pen, path);
            graphics.FillPath(brush, path);
            graphics.DrawPath(pen, path);
        }
        if (bool_0)
        {
            if (padding_1.Top != 0)
            {
                graphics.DrawLine(new Pen(color_1, padding_1.Top), 0f + float_1, 0f, Width - float_1, 0f);
            }
            if (padding_1.Right != 0)
            {
                graphics.DrawLine(new Pen(color_1, padding_1.Right), -1 + Width, 0f + float_1, -1 + Width, Height - float_1);
            }
            if (padding_1.Bottom != 0)
            {
                graphics.DrawLine(new Pen(color_1, padding_1.Bottom), Width - float_1, Height - 1, 0f + float_1, Height - 1);
            }
            if (padding_1.Left != 0)
            {
                graphics.DrawLine(new Pen(color_1, padding_1.Left), 0f, Height - float_1, 0f, 0f + float_1);
            }
        }
        else
        {
            if (padding_0.Top != 0)
            {
                graphics.DrawLine(new Pen(color_0, padding_0.Top), 0f + float_1, 0f, Width - float_1, 0f);
            }
            if (padding_0.Right != 0)
            {
                graphics.DrawLine(new Pen(color_0, padding_0.Right), -1 + Width, 0f + float_1, -1 + Width, Height - float_1);
            }
            if (padding_0.Bottom != 0)
            {
                graphics.DrawLine(new Pen(color_0, padding_0.Bottom), Width - float_1, Height - 1, 0f + float_1, Height - 1);
            }
            if (padding_0.Left != 0)
            {
                graphics.DrawLine(new Pen(color_0, padding_0.Left), 0f, Height - float_1, 0f, 0f + float_1);
            }
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
