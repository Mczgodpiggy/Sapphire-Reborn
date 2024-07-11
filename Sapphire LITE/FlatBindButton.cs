using System;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

public sealed class FlatBindButton : Label
{
    [CompilerGenerated]
    private int int_0;

    private string string_0;

    private string string_1 = "NONE";

    public int BindKey
    {
        [CompilerGenerated]
        get
        {
            return int_0;
        }
        [CompilerGenerated]
        set
        {
            int_0 = value;
        }
    }

    public string MouseBindKey
    {
        get
        {
            return string_0;
        }
        [CompilerGenerated]
        set
        {
            string_0 = value;
        }
    }

    public string String_0
    {
        get
        {
            return string_1;
        }
        set
        {
            string_1 = value;
        }
    }

    public FlatBindButton()
    {
        Text = "[" + string_1 + "]";
    }

    protected override void OnClick(EventArgs e)
    {
        Text = "[...]";
        Focus();
    }

    protected override void OnKeyDown(KeyEventArgs e)
    {
        if (Text == "[...]")
        {
            if (e.KeyCode == Keys.Escape)
            {
                BindKey = 0;
                Text = "[" + string_1 + "]";
            }
            else
            {
                BindKey = (int)e.KeyCode;
                Text = "[" + e.KeyCode.ToString() + "]";
            }
        }
    }
}
