using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Windows.Forms;

using System.Drawing.Imaging;

// adapté de https://www.codeproject.com/Articles/4390/AlphaBlendTextBox-A-transparent-translucent-textbo

// namespace ZTrsl {

public class ZoneTranslucide : Control
	{
		private uPictureBox myPictureBox;
		private bool myUpToDate = false;
		private Bitmap myBitmap;
		private Bitmap myAlphaBitmap;

        // private bool myPaintedFirstTime = false;

		private Color myBackColor = Color.White;
		private int myBackAlpha = 10;		
		
		private System.ComponentModel.Container components = null;
    
		public ZoneTranslucide()
		{
			// This call is required by the Windows.Forms Form Designer.
			InitializeComponent();

			this.BackColor = myBackColor; 

			this.SetStyle(ControlStyles.UserPaint,false);
			this.SetStyle(ControlStyles.AllPaintingInWmPaint,true);
			this.SetStyle(ControlStyles.DoubleBuffer,true);

            myPictureBox = new uPictureBox();
        
        /**/
            myPictureBox.Click += OnClickMyPictureBox;
			this.Controls.Add(myPictureBox);
			myPictureBox.Dock = DockStyle.Fill;
		}


    public new event EventHandler Click;
    // Gère les clics. Déclenché par un clic sur la picturebox. déclenche l'évènement "clicksurcettezone"
    void OnClickMyPictureBox(object sender, EventArgs e) {
        this.Click(this, e);
    }



    protected override void OnGiveFeedback(GiveFeedbackEventArgs gfbevent)
		{
			base.OnGiveFeedback (gfbevent);
			myUpToDate = false;
			this.Invalidate();
		}


		protected override void OnMouseLeave(EventArgs e)
		{
			//found this code to find the current cursor location
			//at http://www.syncfusion.com/FAQ/WinForms/FAQ_c50c.asp#q597q

			Point ptCursor = Cursor.Position; 
			
			Form f = this.FindForm();
			ptCursor = f.PointToClient(ptCursor); 
			if( !this.Bounds.Contains(ptCursor) )  
				base.OnMouseLeave (e);
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

        /**//**/
        /**//**/

			// need to rewrite as a big switch

			if (m.Msg == win32.WM_PAINT)
			{
				// myPaintedFirstTime = true;

				if (!myUpToDate)
					GetBitmaps();
				myUpToDate = true;

				if (myPictureBox.Image != null) myPictureBox.Image.Dispose();
				myPictureBox.Image = (Image)myAlphaBitmap.Clone();

			}
		}


		protected override void Dispose( bool disposing )
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
		}

        /*
		public new BorderStyle BorderStyle
		{
			get {return base.BorderStyle;}
			set 
			{
				if (this.myPaintedFirstTime)
					this.SetStyle(ControlStyles.UserPaint,false);

				base.BorderStyle = value;
				
				if (this.myPaintedFirstTime)
					this.SetStyle(ControlStyles.UserPaint,true);

				this.myBitmap = null;
				this.myAlphaBitmap = null;
				myUpToDate = false;
				this.Invalidate();
			}
		}
        */

		public  new Color BackColor
		{
			get
			{
				return Color.FromArgb(base.BackColor.R, base.BackColor.G, base.BackColor.B);
			}
			set
			{
				myBackColor = value;
				base.BackColor = value;
				myUpToDate = false;
			}
		}

        /*
		public override bool Multiline
		{
			get{return base.Multiline;}
			set
			{
				if (this.myPaintedFirstTime)
					this.SetStyle(ControlStyles.UserPaint,false);
				
				base.Multiline = value;

				if (this.myPaintedFirstTime)
					this.SetStyle(ControlStyles.UserPaint,true);

				this.myBitmap = null;
				this.myAlphaBitmap = null;
				myUpToDate = false;
				this.Invalidate();
			}
		}
        */

		
		
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
				//Capture the TextBox control window

				this.SetStyle(ControlStyles.UserPaint,false);
				
				win32.CaptureWindow(this,ref myBitmap);

				this.SetStyle(ControlStyles.UserPaint,true);
				this.SetStyle(ControlStyles.SupportsTransparentBackColor,true);
				this.BackColor = Color.FromArgb(myBackAlpha,myBackColor);

			}
			
			
		
			Rectangle r2 = new Rectangle(0,0,this.ClientRectangle.Width,this.ClientRectangle.Height);
			ImageAttributes tempImageAttr = new ImageAttributes();
						

			//Found the color map code in the MS Help

			ColorMap[] tempColorMap = new ColorMap[1];
			tempColorMap[0] = new ColorMap();
			tempColorMap[0].OldColor = Color.FromArgb(255,myBackColor); 
			tempColorMap[0].NewColor = Color.FromArgb(myBackAlpha,myBackColor);

			tempImageAttr.SetRemapTable(tempColorMap);

			if (myAlphaBitmap != null)
				myAlphaBitmap.Dispose();
					
					
			myAlphaBitmap = new Bitmap(this.ClientRectangle.Width,this.ClientRectangle.Height);

			Graphics tempGraphics1 = Graphics.FromImage(myAlphaBitmap);

			tempGraphics1.DrawImage(myBitmap,r2,0,0,this.ClientRectangle.Width,this.ClientRectangle.Height,GraphicsUnit.Pixel,tempImageAttr);

			tempGraphics1.Dispose();
			

		}





		private class uPictureBox : PictureBox 
		{
			public uPictureBox() 
			{
				this.SetStyle(ControlStyles.Selectable,false);
				this.SetStyle(ControlStyles.UserPaint,true);
				this.SetStyle(ControlStyles.AllPaintingInWmPaint,true);
				this.SetStyle(ControlStyles.DoubleBuffer,true);

				this.Cursor = null;
				this.Enabled = true; 
				this.SizeMode = PictureBoxSizeMode.Normal;
				
			}

            // les messages liés à la souris, même renvoyés au parent, ne déclenchent pas d'évènement Click
			//uPictureBox
			/*protected override void WndProc(ref Message m)
			{
				if (m.Msg == win32.WM_LBUTTONDOWN 
					|| m.Msg == win32.WM_RBUTTONDOWN
					|| m.Msg == win32.WM_LBUTTONDBLCLK
					|| m.Msg == win32.WM_MOUSELEAVE
                    ////|| m.Msg == 0x202  //win32.WM_LBUTTONUP
                    ////|| m.Msg == 0x2A1  //win32.WM_MOUSEHOVER
                    || m.Msg == win32.WM_MOUSEMOVE )
				{
                //Send the above messages back to the parent control
					win32.PostMessage(this.Parent.Handle,(uint) m.Msg,m.WParam,m.LParam);
				}
                
				else if (m.Msg == win32.WM_LBUTTONUP)
				{
					//??  for selects and such
					this.Parent.Invalidate();
				}

        
				base.WndProc (ref m);
			}
            */

		}   // End uPictureBox Class

        

		private void InitializeComponent()
		{
			components = new System.ComponentModel.Container();
		}
    
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


//}  // End namespace ZTrsl

