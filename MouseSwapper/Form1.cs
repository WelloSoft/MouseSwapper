
using System;
using Microsoft.Win32;
using System.Windows.Forms;

public partial class Form1
{

	private Inverter MouseHooker;
	private void Form1_Load(object sender, System.EventArgs e)
	{
		MouseHooker = new Inverter();
		SystemEvents.DisplaySettingsChanged += DisplayUpdated;
	}

    void DisplayUpdated(object sender, EventArgs e)
    {
        ScrRot.SelectedIndex = (int)SystemInformation.ScreenOrientation;
        MsHook_Refresh(sender, e);
    }


    public void MsHook_Refresh(object sender, EventArgs e)
	{
        var hooker = this.MouseHooker;
        var screenOrientation = SystemInformation.ScreenOrientation;
        var targetOrient = (ScreenOrientation)ScrRot.SelectedIndex;
        if (screenOrientation != targetOrient)
        {
            if (ScrRot.SelectedIndex >= 0)
            {
                Display.Rotate(1, targetOrient);
            }
        }
        if (this.AutoFlip.Checked)
        {
            switch ((int)(screenOrientation))
            {
                case 0:
                    hooker.Set(false, false, false);
                    break;
                case 1:
                    hooker.Set(true, false, true);
                    break;
                case 2:
                    hooker.Set(true, true, false);
                    break;
                case 3:
                    hooker.Set(false, true, true);
                    break;
            }
        }
        else
        {
            hooker.Set(FlipX.Checked, FlipY.Checked, SwapXY.Checked);
        }
        if (Enabler.Checked)
        {
            if (!hooker._running)
                hooker.Start();
        }
        else if (hooker._running)
        {
            hooker.Stop();
        }
    }

    private void ParamUpdate(System.Object sender, System.EventArgs e)
	{
        if (Visible)    
    	    MsHook_Refresh(sender, e);
        FlipX.Enabled = FlipY.Enabled = SwapXY.Enabled = !AutoFlip.Checked;
    }

    public Form1()
	{
		Load += Form1_Load;
        InitializeComponent();
        ScrRot.SelectedIndex = (int)SystemInformation.ScreenOrientation;
	}
}

//=======================================================
//Service provided by Telerik (www.telerik.com)
//Conversion powered by NRefactory.
//Twitter: @telerik
//Facebook: facebook.com/telerik
//=======================================================
