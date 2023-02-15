using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NoMoreMash
{
    public partial class Form1 : Form
    {
        static Figure f;
        Point ptX, ptY, mouse;
        Bitmap bmpX, bmpY;
        Graphics gX, gY;
        Canvas canvas;
        float deltaX = 0;
        float deltaY = 1;
        Scene scene;
        bool IsMouseDownX = false;
        bool IsMouseDownY = false;
        bool isMouseDown = false;
        bool fr = false;

        public Form1()
        {
            InitializeComponent();
            Init();
            IsMouseDownX = false;
        }

        bool scroller = false;
        private bool animatpl = false;

        private void Init()
        {
            bmpX = new Bitmap(sliderX.Width, sliderX.Height);
            bmpY = new Bitmap(sliderY.Width, sliderY.Height);

            gX = Graphics.FromImage(bmpX);
            gY = Graphics.FromImage(bmpY);

            sliderX.Image = bmpX;
            sliderY.Image = bmpY;

            gX.DrawLine(Pens.Gold, 0, bmpX.Height / 2, bmpX.Width, bmpX.Height / 2);
            gX.FillEllipse(Brushes.Purple, bmpX.Width / 2, bmpX.Height / 4, bmpX.Height / 2, bmpX.Height / 2);

            gY.DrawLine(Pens.Gold, bmpY.Width / 2, 0, bmpY.Width / 2, bmpY.Height);
            gY.FillEllipse(Brushes.Purple, bmpY.Width / 4, bmpY.Height / 2, bmpX.Height / 2, bmpX.Height / 2);

            scene = new Scene();
            canvas = new Canvas(PCT_CANVAS);

        }

        //PCT_CANVAS Methods
        private void PCT_CANVAS_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (f != null)
            {
                f.Add(new PointF(e.X, e.Y));
            }
        }

        private void PCT_CANVAS_MouseDown(object sender, MouseEventArgs e) 
        {
            mouse = e.Location;
            isMouseDown = true;
        }

        private void PCT_CANVAS_MouseUp(object sender, MouseEventArgs e) 
        {
            isMouseDown = false;
            PCT_CANVAS.Select();
        }

        private void PCT_CANVAS_MouseMove(object sender, MouseEventArgs e) 
        {
            if (isMouseDown)
            {
                mouse.X -= e.X;
                mouse.Y -= e.Y;
                f.TranslatePoints(new Point(-mouse.X, -mouse.Y));
                f.UpdateAttributes();
                mouse = e.Location;
            }
        }


        private void sliderY_MouseUp(object sender, MouseEventArgs e)
        {
            IsMouseDownY = false;
            gY.Clear(Color.Transparent);
            gY.DrawLine(Pens.DimGray, bmpY.Width / 2, 0, bmpY.Width / 2, bmpY.Height);
            gY.FillEllipse(Brushes.Aquamarine, bmpY.Width / 4, bmpY.Height / 2, bmpX.Height / 2, bmpX.Height / 2);

            sliderY.Invalidate();
        }

        private void sliderY_MouseMove(object sender, MouseEventArgs e)
        {
            if (IsMouseDownY)
            {
                gY.Clear(Color.Transparent);
                gY.DrawLine(Pens.DimGray, bmpY.Width / 2, 0, bmpY.Width / 2, bmpY.Height);
                gY.FillEllipse(Brushes.Aquamarine, bmpY.Width / 4, e.Y, bmpX.Height / 2, bmpX.Height / 2);

                sliderY.Invalidate();
                deltaY += (float)(ptY.Y - e.Location.Y) / 500;
                ptY.Y = e.Location.Y;
            }
        }

        private void sliderY_MouseDown(object sender, MouseEventArgs e)
        {
            ptY = e.Location;
            IsMouseDownY = true;
        }

        
        private void sliderX_MouseDown(object sender, MouseEventArgs e)
        {
            ptX = e.Location;
            IsMouseDownX = true;
        }

        private void sliderX_MouseMove(object sender, MouseEventArgs e)
        {
            if (IsMouseDownX)
            {
                gX.Clear(Color.Transparent);
                gX.DrawLine(Pens.DimGray, 0, sliderX.Height / 2, sliderX.Width, sliderX.Height / 2);
                gX.FillEllipse(Brushes.Aquamarine, e.X, sliderX.Height / 4, sliderX.Height / 2, sliderX.Height / 2);

                sliderX.Invalidate();
                deltaX += (float)(e.Location.X - ptX.X) / 3;
                ptX.X = e.Location.X;
            }
        }

        private void sliderX_MouseUp(object sender, MouseEventArgs e)
        {
            IsMouseDownX = false;
            gX.Clear(Color.Transparent);
            gX.DrawLine(Pens.DimGray, 0, sliderX.Height / 2, sliderX.Width, sliderX.Height / 2);
            gX.FillEllipse(Brushes.Aquamarine, sliderX.Width / 2, sliderX.Height / 4, sliderX.Height / 2, sliderX.Height / 2);

            sliderX.Invalidate();
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            if (f != null)
            {
                f.TranslateToOrigin();
                f.Scale(deltaY);
                f.Rotate(deltaX);
                f.TranslatePoints(f.Centroid);
                f.Arotation += deltaX;
                f.Ascale *= deltaY;
            }
            deltaX = 0;
            deltaY = 1;
            canvas.Render(scene); 
            if (animatpl)
            {
                if (trackBar1.Value < trackBar1.Maximum)
                {
                    trackBar1.Value++;
                    trackBar2.Value = trackBar1.Value / 100;
                    Animate();
                }
                else trackBar1.Value = trackBar1.Minimum;
            }
        }

        private void Update(Figure figs, float x, float y) 
        {

            if (figs != null)
            {
                figs.TranslateToOrigin();
                figs.Scale(1 / figs.Ascale); 
                figs.Ascale *= 1 / figs.Ascale;
                figs.Scale(y);
                figs.Rotate(-figs.Arotation + x); 
                figs.Arotation = x; 
                figs.Ascale = y; 
                figs.TranslatePoints(figs.Centroid);
            }
        }

        private void Animate()
        {

            if (checkBox1.Checked) foreach (Figure figure in scene.Figures) FigureAnimation(figure);
            else FigureAnimation(f);
        }

        private void FigureAnimation(Figure figs)
        {
            float angle;
            float deltatemp;
            float figsize;
            int FrameByFrameFirst = -1;
            int FrameByFrameEnding = -1;

            if (scene.Figures.Count == 0 || figs.frames[trackBar1.Value]) return; 
            else
            {
                for (int i = trackBar1.Value; i >= 0; i--)
                {
                    if (figs.frames[i])
                    {
                        FrameByFrameFirst = i;
                        break;
                    }
                }
                for (int i = trackBar1.Value; i <= figs.positions.Length - 1; i++)
                {
                    if (figs.frames[i])
                    {
                        FrameByFrameEnding = i;
                        break;
                    }
                }
            }
            if (FrameByFrameFirst != -1 && FrameByFrameEnding != -1) 
            {

                deltatemp = ((float)trackBar1.Value - FrameByFrameFirst) / (FrameByFrameEnding - FrameByFrameFirst); 



                angle = ((figs.rotations[FrameByFrameEnding] - figs.rotations[FrameByFrameFirst]) * deltatemp) + figs.rotations[FrameByFrameFirst]; 



                figsize = ((figs.sizes[FrameByFrameEnding] - figs.sizes[FrameByFrameFirst]) * deltatemp) + figs.sizes[FrameByFrameFirst];



                figs.Follow(figs.positions[FrameByFrameFirst], figs.positions[FrameByFrameEnding], deltatemp); 



                Update(figs, angle, figsize); 
            }
        }


        private void LBL_TITLE_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void PCT_CANVAS_Click(object sender, EventArgs e)
        {

        }


        private void ADD_Click(object sender, EventArgs e)
        {
            f = new Figure(trackBar1.Maximum);
            scene.Figures.Add(f);
            TreeNode node = new TreeNode("Fig" + (treeView1.Nodes.Count + 1));
            node.Tag = f;
            treeView1.Nodes.Add(node);
        }
        private void PLAY_Click(object sender, EventArgs e)
        {
            animatpl = true;
        }

        private void STOP_Click(object sender, EventArgs e)
        {
            animatpl = false;
        }

        private void SF_Click(object sender, EventArgs e)
        {
            if (fr)
            {
                SF.Text = "SECONDS";
                trackBar2.Visible = false;
                fr = false;
            }
            else
            {
                SF.Text = "FRAMES";
                trackBar2.Visible = true;
                fr = true;
            }
        }

        private void RECORD_Click(object sender, EventArgs e)
        {
            f.frames[trackBar1.Value] = true;
            f.positions[trackBar1.Value] = f.Centroid;
            f.rotations[trackBar1.Value] = f.Arotation;
            f.sizes[trackBar1.Value] = f.Ascale;
            if (trackBar2.Value < trackBar2.Maximum)
            {
                trackBar2.Value++;
            }
            else trackBar2.Value = trackBar2.Minimum;
            trackBar1.Value = trackBar2.Value * 100;
        }
        private void treeView1_KeyPress(object sender, KeyPressEventArgs e)
        {
            return;
        }
        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            f = (Figure)treeView1.SelectedNode.Tag;
            FIGURE_BTT.Select();
        }
        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            Animate();
            trackBar2.Value = trackBar1.Value / 100;
        }
    }
}
