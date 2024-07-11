using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using ns0;
using Font = System.Drawing.Font;

[DefaultProperty("BarInnerColor")]
[ToolboxBitmap(typeof(TrackBar))]
[DefaultEvent("ValueChanged")]
public sealed class FlatTrackBarSmooth : Control
{
    [CompilerGenerated]
    private EventHandler eventHandler_0;

    [CompilerGenerated]
    private ScrollEventHandler scrollEventHandler_0;

    private Rectangle rectangle_0;

    private Rectangle rectangle_1;

    private Rectangle rectangle_2;

    private readonly int int_0;

    private readonly int int_1;

    private Rectangle rectangle_3;

    private Color color_0;

    private Color color_1;

    private Color color_2;

    private bool bool_0;

    private float float_0 = 1f;

    private int int_2 = 10;

    private int int_3;

    private int int_4 = 100;

    private float float_1 = 1f;

    private bool bool_1 = true;

    private Color color_3 = Color.Black;

    private Color color_4 = Color.FromArgb(118, 126, 226);

    private Color color_5 = Color.FromArgb(0, 0, 0);

    private decimal decimal_0 = 1m;

    private bool bool_2 = true;

    public static bool bool_3;

    private int int_5;

    private int int_6 = 8;

    [CompilerGenerated]
    private bool bool_4;

    public static bool bool_5;

    private bool bool_6;

    [Browsable(false)]
    public Rectangle Rectangle_0 => rectangle_3;

    [Category("QuarrySlider - HoveredState")]
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

    [Category("QuarrySlider - HoveredState")]
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

    [Category("QuarrySlider - HoveredState")]
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

    [Category("QuarrySlider")]
    public bool Boolean_0
    {
        get
        {
            return bool_0;
        }
        set
        {
            bool_0 = value;
            Invalidate();
        }
    }

    [DefaultValue(10)]
    [Category("QuarrySlider")]
    public int ValueInt
    {
        get
        {
            return int_2;
        }
        set
        {
            if (value >= int_3 & value <= int_4)
            {
                int_2 = value;
                eventHandler_0?.Invoke(this, new EventArgs());
                Invalidate();
                return;
            }
        }
    }

    [Category("QuarrySlider")]
    [DefaultValue(0)]
    public int Min
    {
        get
        {
            return int_3;
        }
        set
        {
            if (value < int_4)
            {
                int_3 = value;
                if (int_2 < int_3)
                {
                    int_2 = int_3;
                    eventHandler_0?.Invoke(this, new EventArgs());
                }
                Invalidate();
                return;
            }
        }
    }

    [Category("QuarrySlider")]
    [DefaultValue(100)]
    public int Max
    {
        get
        {
            return int_4;
        }
        set
        {
            if (value > int_3)
            {
                int_4 = value;
                if (int_2 > int_4)
                {
                    int_2 = int_4;
                    eventHandler_0?.Invoke(this, new EventArgs());
                }
                Invalidate();
            }
        }
    }

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

    [Category("QuarrySlider")]
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

    public bool ShowText
    {
        [CompilerGenerated]
        get
        {
            return bool_4;
        }
        [CompilerGenerated]
        set
        {
            bool_4 = value;
        }
    }

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

    public bool Boolean_1
    {
        get
        {
            return bool_1;
        }
        set
        {
            bool_1 = value;
        }
    }

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

    public int Int32_3
    {
        get
        {
            return int_6;
        }
        set
        {
            int_6 = value;
        }
    }

    [Category("Action")]
    [Description("Event fires when the ValueInt property changes")]
    public event EventHandler Event_0
    {
        [CompilerGenerated]
        add
        {
            EventHandler eventHandler = eventHandler_0;
            EventHandler eventHandler2;
            do
            {
                eventHandler2 = eventHandler;
                EventHandler value2 = (EventHandler)Delegate.Combine(eventHandler2, value);
                eventHandler = Interlocked.CompareExchange(ref eventHandler_0, value2, eventHandler2);
            }
            while ((object)eventHandler != eventHandler2);
        }
        [CompilerGenerated]
        remove
        {
            EventHandler eventHandler = eventHandler_0;
            EventHandler eventHandler2;
            do
            {
                eventHandler2 = eventHandler;
                EventHandler value2 = (EventHandler)Delegate.Remove(eventHandler2, value);
                eventHandler = Interlocked.CompareExchange(ref eventHandler_0, value2, eventHandler2);
            }
            while ((object)eventHandler != eventHandler2);
        }
    }

    public event ScrollEventHandler Event_1
    {
        [CompilerGenerated]
        add
        {
            ScrollEventHandler scrollEventHandler = scrollEventHandler_0;
            ScrollEventHandler scrollEventHandler2;
            do
            {
                scrollEventHandler2 = scrollEventHandler;
                ScrollEventHandler value2 = (ScrollEventHandler)Delegate.Combine(scrollEventHandler2, value);
                scrollEventHandler = Interlocked.CompareExchange(ref scrollEventHandler_0, value2, scrollEventHandler2);
            }
            while ((object)scrollEventHandler != scrollEventHandler2);
        }
        [CompilerGenerated]
        remove
        {
            ScrollEventHandler scrollEventHandler = scrollEventHandler_0;
            ScrollEventHandler scrollEventHandler2;
            do
            {
                scrollEventHandler2 = scrollEventHandler;
                ScrollEventHandler value2 = (ScrollEventHandler)Delegate.Remove(scrollEventHandler2, value);
                scrollEventHandler = Interlocked.CompareExchange(ref scrollEventHandler_0, value2, scrollEventHandler2);
            }
            while ((object)scrollEventHandler != scrollEventHandler2);
        }
    }

    public FlatTrackBarSmooth(int int_7, int int_8, int int_9)
    {
        SetStyle(ControlStyles.UserPaint | ControlStyles.ResizeRedraw | ControlStyles.Selectable | ControlStyles.UserMouse | ControlStyles.SupportsTransparentBackColor | ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer, value: true);
        Size = new Size(100, 20);
        Text = "";
        Min = int_7;
        Max = int_8;
        ValueInt = int_9;
    }

    public FlatTrackBarSmooth()
        : this(0, 100, 10)
    {
    }

    protected override void OnHandleCreated(EventArgs e)
    {
        base.OnHandleCreated(e);
        bool_5 = true;
        bool_3 = true;
        method_0();
    }

    private async void method_0()
    {
        bool_5 = true;
        await Task.Run(delegate
        {
            method_1();
        });
    }

    protected override void OnPaint(PaintEventArgs e)
    {
        method_2(e, color_3);
    }

    public async void method_1()
    {
        try
        {
            bool_2 = false;
            while (bool_5)
            {
                await Task.Delay(15);
                int num = rectangle_3.Left + 8;
                if (decimal_0 < num)
                {
                    //Positive speed
                    decimal num2 = (num - decimal_0) * 0.058m * (num - decimal_0) / 100 * 4;
                    decimal_0 += num2;
                    Invalidate();
                }
                if (decimal_0 > num)
                {
                    //Negetive speed
                    decimal num3 = (num - decimal_0) * 0.058m * (num - decimal_0) / -100 * 4;
                    decimal_0 += num3;
                    Invalidate();
                }
            }
        }
        finally
        {
            bool_2 = true;
        }
    }

    private void method_2(PaintEventArgs paintEventArgs_0, Color color_6)
    {
        rectangle_0 = ClientRectangle;
        int_5 = (int_2 - int_3) * (ClientRectangle.Width - 16) / (int_4 - int_3);
        rectangle_3 = new Rectangle(int_5, rectangle_0.Y + ClientRectangle.Height / 2 - 8, 16, 16);
        rectangle_1 = rectangle_0;
        rectangle_1.Height /= 2;
        rectangle_2 = rectangle_0;
        rectangle_2.Width = rectangle_3.Left + 8 - int_0;
        paintEventArgs_0.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
        paintEventArgs_0.Graphics.TextRenderingHint = TextRenderingHint.AntiAlias;
        paintEventArgs_0.Graphics.Clear(Parent.BackColor);
        Pen pen = new Pen(color_5, float_1);
        Pen pen2 = new Pen(color_0, float_1);
        GraphicsPath path = Class1.smethod_0(rectangle_0.X, rectangle_0.Y, rectangle_0.X + (float)decimal_0 + 7f, Height - 1, float_0);
        GraphicsPath path2 = Class1.smethod_0(rectangle_0.X, rectangle_0.Y, rectangle_0.X + rectangle_2.Width + 7, Height - 1, float_0);
        if (bool_6 && color_0 != Color.Empty && color_2 != Color.Empty && color_1 != Color.Empty)
        {
            GraphicsPath path3 = Class1.smethod_0(0f, 0f, Width - 1, Height - 1, float_0);
            paintEventArgs_0.Graphics.FillPath(new SolidBrush(color_2), path3);
            if (bool_1)
            {
                paintEventArgs_0.Graphics.FillPath(new SolidBrush(color_1), path);
            }
            else
            {
                paintEventArgs_0.Graphics.FillPath(new SolidBrush(color_1), path2);
            }
            paintEventArgs_0.Graphics.DrawPath(pen2, path3);
            paintEventArgs_0.Graphics.TextRenderingHint = TextRenderingHint.ClearTypeGridFit;
        }
        else
        {
            GraphicsPath path4 = Class1.smethod_0(0f, 0f, Width - 1, Height - 1, float_0);
            paintEventArgs_0.Graphics.FillPath(new SolidBrush(color_6), path4);
            if (bool_1)
            {
                paintEventArgs_0.Graphics.FillPath(new SolidBrush(Color_4), path);
            }
            else
            {
                paintEventArgs_0.Graphics.FillPath(new SolidBrush(Color_4), path2);
            }
            paintEventArgs_0.Graphics.DrawPath(pen, path4);
            paintEventArgs_0.Graphics.TextRenderingHint = TextRenderingHint.ClearTypeGridFit;
        }
        if (Boolean_0)
        {
            Font font = new Font(Font, FontStyle.Regular);
            paintEventArgs_0.Graphics.DrawString(ValueInt.ToString(), font, new SolidBrush(ForeColor), new Rectangle(0, 0, Width, Height + 2), new StringFormat
            {
                Alignment = StringAlignment.Center,
                LineAlignment = StringAlignment.Center
            });
        }
        if (ShowText)
        {
            Font font2 = new Font(Font, FontStyle.Regular);
            paintEventArgs_0.Graphics.DrawString(Text, font2, new SolidBrush(ForeColor), new Rectangle(0, 0, Width, Height + 2), new StringFormat
            {
                Alignment = StringAlignment.Center,
                LineAlignment = StringAlignment.Center
            });
        }
    }

    protected override void OnMouseDown(MouseEventArgs e)
    {
        base.OnMouseDown(e);
        if (e.Button == MouseButtons.Left)
        {
            Capture = true;
            scrollEventHandler_0?.Invoke(this, new ScrollEventArgs(ScrollEventType.ThumbTrack, int_2));
            eventHandler_0?.Invoke(this, new EventArgs());
            OnMouseMove(e);
        }
        Invalidate();
    }

    protected override void OnMouseMove(MouseEventArgs e)
    {
        base.OnMouseMove(e);
        if (Capture & e.Button == MouseButtons.Left)
        {
            ScrollEventType type = ScrollEventType.ThumbPosition;
            int num = e.Location.X;
            num -= 8;
            int_2 = int_3 + (num - int_0 - 8) * (int_4 - int_3) / (ClientRectangle.Width - int_0 - int_1 - 16);
            if (int_2 <= int_3)
            {
                int_2 = int_3;
                type = ScrollEventType.First;
            }
            else if (int_2 >= int_4)
            {
                int_2 = int_4;
                type = ScrollEventType.Last;
            }
            scrollEventHandler_0?.Invoke(this, new ScrollEventArgs(type, int_2));
            eventHandler_0?.Invoke(this, new EventArgs());
        }
        Invalidate();
    }

    protected override void OnMouseEnter(EventArgs e)
    {
        base.OnMouseEnter(e);
        bool_6 = true;
        Invalidate();
    }

    protected override void OnMouseLeave(EventArgs e)
    {
        base.OnMouseLeave(e);
        bool_6 = false;
        Invalidate();
    }

    protected override void OnMouseUp(MouseEventArgs e)
    {
        base.OnMouseUp(e);
        Capture = false;
        scrollEventHandler_0?.Invoke(this, new ScrollEventArgs(ScrollEventType.EndScroll, int_2));
        eventHandler_0?.Invoke(this, new EventArgs());
        Invalidate();
    }

    [CompilerGenerated]
    private void method_3()
    {
        method_1();
    }
}
