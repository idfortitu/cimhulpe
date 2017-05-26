using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Windows.Forms;

using System.Drawing.Imaging;

// adapté de https://www.codeproject.com/Articles/4390/AlphaBlendTextBox-A-transparent-translucent-textbo

public class ZoneTranslucide : Control
	{
		private bool myUpToDate = false;
    private Bitmap myBitmap;
        private Bitmap myAlphaBitmap;

    private Color myBackColor = Color.White;
		private int myBackAlpha = 10;

        //private System.ComponentModel.Container components = null;        // a l'air de fonctionner sans

    public ZoneTranslucide()
		{
			// This call is required by the Windows.Forms Form Designer.
			//InitializeComponent();    // a l'air de fonctionner sans, peut-être parce que le contrôle n'a pas de sous-contrôles

			this.BackColor = myBackColor;

        //		this.SetStyle(ControlStyles.UserPaint,false);
        //this.SetStyle(ControlStyles.AllPaintingInWmPaint,true);
        this.SetStyle(ControlStyles.OptimizedDoubleBuffer,true);  // anciennement DoubleBuffer
    }


    protected override void OnGiveFeedback(GiveFeedbackEventArgs gfbevent)
		{
			base.OnGiveFeedback (gfbevent);
			myUpToDate = false;
			this.Invalidate();
		}


		protected override void OnGotFocus(EventArgs e)
		{
			base.OnGotFocus (e);
			myUpToDate = false;
			this.Invalidate();							
		}

		protected override void OnLostFocus(EventArgs e)
		{
			base.OnLostFocus (e);
			myUpToDate = false;
			this.Invalidate();
		}

		protected override void WndProc(ref Message m)
		{

        base.WndProc (ref m);

			// need to rewrite as a big switch

			if (m.Msg == win32.WM_PAINT)
			{
				if (!myUpToDate)
					GetBitmaps();
				myUpToDate = true;
            }
		}


		/*protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				//this.BackColor = Color.Pink;
				if(components != null)
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}*/

		public new Color BackColor
		{
			get
			{
				//return Color.FromArgb(base.BackColor.R, base.BackColor.G, base.BackColor.B);
                return base.BackColor;
			}
			set
			{
				myBackColor = value;
				base.BackColor = value;
				myUpToDate = false;
			}
		}
		
		private void GetBitmaps()
		{

			if (myBitmap == null
				|| myAlphaBitmap == null
				|| myBitmap.Width != Width 
				|| myBitmap.Height != Height		
				|| myAlphaBitmap.Width != Width 
				|| myAlphaBitmap.Height != Height)
			{
				myBitmap = null;
				myAlphaBitmap = null;
			}

		if (myBitmap == null)
			{
				myBitmap = new Bitmap(this.ClientRectangle.Width,this.ClientRectangle.Height);
				myUpToDate = false;
			}

			if (!myUpToDate)
			{
				// Capture the control window
				this.SetStyle(ControlStyles.UserPaint,false);
				win32.CaptureWindow(this,ref myBitmap);

				this.SetStyle(ControlStyles.UserPaint,true);
				this.SetStyle(ControlStyles.SupportsTransparentBackColor,true);
				this.BackColor = Color.FromArgb(myBackAlpha,myBackColor);
			}
			
			Rectangle r2 = new Rectangle(0,0,this.ClientRectangle.Width,this.ClientRectangle.Height);
			ImageAttributes tempImageAttr = new ImageAttributes();

			// Found the color map code in the MS Help

			ColorMap[] tempColorMap = new ColorMap[1];
			tempColorMap[0] = new ColorMap();
			tempColorMap[0].OldColor = Color.FromArgb(255,myBackColor); 
			tempColorMap[0].NewColor = Color.FromArgb(myBackAlpha,myBackColor);

			tempImageAttr.SetRemapTable(tempColorMap);

			if (myAlphaBitmap != null)
				myAlphaBitmap.Dispose();
					
			myAlphaBitmap = new Bitmap(this.ClientRectangle.Width,this.ClientRectangle.Height);

        //Graphics tempGraphics1 = Graphics.FromImage(myAlphaBitmap);
        //tempGraphics1.DrawImage(myBitmap,r2,0,0,this.ClientRectangle.Width,this.ClientRectangle.Height,GraphicsUnit.Pixel,tempImageAttr);
        //tempGraphics1.Dispose();
        this.BackgroundImage = myAlphaBitmap;

		}

        // a l'air de marcher sans
		/*private void InitializeComponent()
		{
			components = new System.ComponentModel.Container();
		}*/
    
		[
		Category("Appearance"),
		Description("The alpha value used to blend the control's background. Valid values are 0 through 255."),
		Browsable(true),
		DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)

		]
		public int BackAlpha
		{
			get { return myBackAlpha; }
			set 
			{
				int v = value;
				if (v > 255)
					v = 255;
				myBackAlpha = v;
				myUpToDate = false; 
				Invalidate();
			}
		}		
	}
