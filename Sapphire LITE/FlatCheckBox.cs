using ns0;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Windows.Forms;

public sealed class FlatCheckBox : CheckBox
{
    private int int_0;

    private bool bool_0;

    private string string_0 = "Center";

    private Padding padding_0 = new Padding(0, 0, 0, 0);

    private Color color_0;

    private int int_1;

    private int int_2;

    private Padding padding_1 = new Padding(0, 0, 0, 0);

    private Color color_1;

    private Color color_2;

    private bool bool_1 = true;

    private int int_3 = 3;

    private float float_0 = 1f;

    private string string_1 = "";

    private float float_1 = 1f;

    private Color color_3 = Color.White;

    private Color color_4 = Color.LightGray;

    private Color color_5 = Color.Black;

    private Color color_6 = Color.White;

    private Color color_7 = Color.FromArgb(0, 0, 255);

    private Color color_8 = Color.Black;

    private Padding padding_2 = new Padding(0, 0, 0, 0);

    private Color color_9;

    [Description("Use these keywords (capitals included): Center ; Left ; Right")]
    [Category("QuarryCheckbox - Misc")]
    public string String_0
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

    [Category("QuarryCheckbox - Checked")]
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

    [Category("QuarryCheckbox - Checked")]
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

    [Category("QuarryCheckbox - TextOptions")]
    [Description("Changes the size of the border")]
    public int Int32_0
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

    [Category("QuarryCheckbox - TextOptions")]
    [Description("Changes the size of the border")]
    public int Int32_1
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

    [Category("QuarryCheckbox - Hovered")]
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

    [Category("QuarryCheckbox - Hovered")]
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

    [Description("Changes the border color of the checkbox when checked")]
    [Category("QuarryCheckbox - Hovered")]
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

    [Category("QuarryCheckbox - Misc")]
    public bool Boolean_0
    {
        get
        {
            return bool_1;
        }
        set
        {
            bool_1 = value;
            Invalidate();
        }
    }

    [Category("QuarryCheckbox - Misc")]
    public int Int32_2
    {
        get
        {
            return int_3;
        }
        set
        {
            int_3 = value;
            Invalidate();
        }
    }

    [Category("QuarryCheckbox - Misc")]
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

    public string String_1
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

    [Category("Quarry - Unchecked")]
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
    [Category("QuarryCheckbox - Unchecked")]
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

    [Category("QuarryCheckbox - Checked")]
    [Description("Changes the size of the text")]
    public Color Color_6
    {
        get
        {
            return color_6;
        }
        set
        {
            color_6 = value;
            Invalidate();
        }
    }

    [Description("Changes the color of the toggle when checked")]
    [Category("QuarryCheckbox - Checked")]
    public Color Color_7
    {
        get
        {
            return color_7;
        }
        set
        {
            color_7 = value;
            Invalidate();
        }
    }

    [Category("QuarryCheckbox - Checked")]
    [Description("Changes the border color of the checkbox when checked")]
    public Color Color_8
    {
        get
        {
            return color_8;
        }
        set
        {
            color_8 = value;
            Invalidate();
        }
    }

    [Category("QuarryCheckbox - Unchecked")]
    public Padding Padding_2
    {
        get
        {
            return padding_2;
        }
        set
        {
            padding_2 = value;
        }
    }

    [Category("QuarryCheckbox - Unchecked")]
    public Color Color_9
    {
        get
        {
            return color_9;
        }
        set
        {
            color_9 = value;
            Invalidate();
        }
    }

    public FlatCheckBox()
    {
        SetStyle(ControlStyles.UserPaint | ControlStyles.ResizeRedraw | ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer, value: true);
        DoubleBuffered = true;
    }

    protected override void OnHandleCreated(EventArgs e)
    {
        AutoSize = false;
        base.OnHandleCreated(e);
    }

    protected override void OnPaint(PaintEventArgs e)
    {
        Pen pen = new Pen(color_5, float_1);
        SolidBrush brush = new SolidBrush(color_4);
        Pen pen2 = new Pen(color_8, float_1);
        SolidBrush brush2 = new SolidBrush(color_7);
        Pen pen3 = new Pen(color_2, float_1);
        Rectangle bounds = new Rectangle(int_1, int_2, Width - 1, Height - 1);
        Graphics graphics = e.Graphics;
        graphics.SmoothingMode = SmoothingMode.AntiAlias;
        graphics.TextRenderingHint = TextRenderingHint.AntiAlias;
        graphics.Clear(Parent.BackColor);
        using (GraphicsPath path = Class1.smethod_0(0f, 0f, Width - 1, Height - 1, float_0))
        {
            graphics.FillPath(brush, path);
            graphics.DrawPath(pen, path);
            if (!Checked)
            {
                graphics.FillPath(brush, path);
                graphics.DrawPath(pen, path);
                Font font = new Font(Font, FontStyle.Regular);
                graphics.TextRenderingHint = TextRenderingHint.ClearTypeGridFit;
                TextFormatFlags flags = TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter | TextFormatFlags.WordBreak;
                TextFormatFlags flags2 = TextFormatFlags.VerticalCenter | TextFormatFlags.WordBreak;
                TextFormatFlags flags3 = TextFormatFlags.Right | TextFormatFlags.VerticalCenter | TextFormatFlags.WordBreak;
                if (string_0 == "Center")
                {
                    TextRenderer.DrawText(e.Graphics, string_1, font, bounds, color_3, flags);
                }
                if (string_0 == "Left")
                {
                    TextRenderer.DrawText(e.Graphics, string_1, font, bounds, color_3, flags2);
                }
                if (string_0 == "Right")
                {
                    TextRenderer.DrawText(e.Graphics, string_1, font, bounds, color_3, flags3);
                }
                if (padding_2.Top != 0)
                {
                    graphics.DrawLine(new Pen(color_9, padding_2.Top), 0f + float_0, 0f, Width - float_0, 0f);
                }
                if (padding_2.Right != 0)
                {
                    graphics.DrawLine(new Pen(color_9, padding_2.Right), -1 + Width, 0f + float_0, -1 + Width, Height - float_0);
                }
                if (padding_2.Bottom != 0)
                {
                    graphics.DrawLine(new Pen(color_9, padding_2.Bottom), Width - float_0, Height - 1, 0f + float_0, Height - 1);
                }
                if (padding_2.Left != 0)
                {
                    graphics.DrawLine(new Pen(color_9, padding_2.Left), 0f, Height - float_0, 0f, 0f + float_0);
                }
            }
            else
            {
                if (bool_1)
                {
                    graphics.FillPath(brush2, Class1.smethod_0(0f, 0f, int_0 - 1, Height - 1, float_0));
                }
                else
                {
                    graphics.FillPath(brush2, path);
                }
                graphics.DrawPath(pen2, path);
                graphics.TextRenderingHint = TextRenderingHint.ClearTypeGridFit;
                Font font2 = new Font(Font, FontStyle.Regular);
                TextFormatFlags flags4 = TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter | TextFormatFlags.WordBreak;
                TextFormatFlags flags5 = TextFormatFlags.VerticalCenter | TextFormatFlags.WordBreak;
                TextFormatFlags flags6 = TextFormatFlags.Right | TextFormatFlags.VerticalCenter | TextFormatFlags.WordBreak;
                if (string_0 == "Center")
                {
                    TextRenderer.DrawText(e.Graphics, string_1, font2, bounds, color_3, flags4);
                }
                if (string_0 == "Left")
                {
                    TextRenderer.DrawText(e.Graphics, string_1, font2, bounds, color_3, flags5);
                }
                if (string_0 == "Right")
                {
                    TextRenderer.DrawText(e.Graphics, string_1, font2, bounds, color_3, flags6);
                }
            }
        }
        if (bool_0 && !Checked)
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
            if (!Checked)
            {
                GraphicsPath path2 = Class1.smethod_0(0f, 0f, Width - 1, Height - 1, float_0);
                graphics.DrawPath(pen3, path2);
            }
        }
        if (Checked)
        {
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

    protected override void OnResize(EventArgs e)
    {
        Invalidate();
    }

    protected override async void OnCheckedChanged(EventArgs e)
    {
        base.OnCheckedChanged(e);
        if (!bool_1)
        {
            return;
        }
        if (!Checked)
        {
            int_0 = -1;
            return;
        }
        while (int_0 < Width)
        {
            int_0 += Width / int_3;
            Invalidate();
            await Task.Delay(1);
        }
        if (int_0 > Width)
        {
            int_0 = Width;
            Invalidate();
        }
    }

    [CompilerGenerated]
    [DebuggerHidden]
    private void method_0(EventArgs eventArgs_0)
    {
        base.OnCheckedChanged(eventArgs_0);
    }
}
