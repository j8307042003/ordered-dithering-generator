using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bayerImage
{
    public partial class Form1 : Form
    {
        int[,] bayer;
        int MaxBayerNum;
        int SliderMax = 100;

        int fixedPicSize = 256;
        Color defColor = Color.Black;

        class BMNode
        {
            public int x;
            public int y;
            public BMNode(int x, int y)
            {
                this.x = x;
                this.y = y;
            }
        }


        public Form1()
        {
            InitializeComponent();
            ResultViewer.Size = new Size(fixedPicSize, fixedPicSize);
            Bitmap map = new Bitmap( fixedPicSize, fixedPicSize );
            
            for (int i = 0; i < map.Size.Height; i++)
                for (int j = 0; j < map.Size.Width; j++)
                    map.SetPixel(i, j, defColor);

            ResultViewer.Image = map;
            CreateBM();
        }

        private void bayerGen_Click(object sender, EventArgs e)
        {


            CreateBM();     

        }


        void CreateBM()
        {
            int n = Int32.Parse(sizeText.Text);
            int size = 1 << n;

            MaxBayerNum = 1;
            for (int i = 0; i < n; i++)
                MaxBayerNum *= 4;

            bayer = new int[size, size];
            List<BMNode> list = new List<BMNode>();

            BMGen(n, 0, 0, list);

        }


        void BMGen(int n, int x, int y, List<BMNode> BMs)
        {
            if (n == 0)
            {
                BMNode node = new BMNode(x, y);
                BMs.Add(node);
            }
            else
            {
                List<BMNode> list00 = new List<BMNode>();
                BMGen(n - 1, x, y, list00);
                calResult(4, 0, list00);

                List<BMNode> list11 = new List<BMNode>();
                BMGen(n - 1, x + (1 << (n - 1)), y + (1 << (n - 1)), list11);
                calResult(4, 1, list11);

                List<BMNode> list01 = new List<BMNode>();
                BMGen(n - 1, x, y + (1 << (n - 1)), list01);
                calResult(4, 2, list01);

                List<BMNode> list10 = new List<BMNode>();
                BMGen(n - 1, x + (1 << (n - 1)), y, list10);
                calResult(4, 3, list10);


                foreach( BMNode node in list00 )
                {
                    BMs.Add(node);
                }
                foreach (BMNode node in list01)
                {
                    BMs.Add(node);
                }
                foreach (BMNode node in list11)
                {
                    BMs.Add(node);
                }
                foreach (BMNode node in list10)
                {
                    BMs.Add(node);
                }
            }


        }


        void calResult(int mul, int add, List<BMNode> BMs)
        {
            for (int i = 0; i < BMs.Count; i++)
            {
                BMNode currNode = BMs[i];
                bayer[currNode.x, currNode.y] *= mul;
                bayer[currNode.x, currNode.y] += add;
            }

        }

        private void addSize_btn_Click(object sender, EventArgs e)
        {
             sizeText.Text = (Int32.Parse(sizeText.Text) + 1 ).ToString();
        }

        private void minusSize_btn_Click(object sender, EventArgs e)
        {
            sizeText.Text = (Int32.Parse(sizeText.Text) - 1).ToString();
        }

        private void valueSlider_Scroll(object sender, EventArgs e)
        {
            sliderViewText.Text = (valueSlider.Value/(float)SliderMax).ToString();
        

            Bitmap map = new Bitmap(fixedPicSize, fixedPicSize);

            int bayerSize = 1 << Int32.Parse(sizeText.Text);
            for (int y = 0; y < map.Size.Height; y++)
                for (int x = 0; x < map.Size.Width; x++)
                {
                    int locationX = x % bayerSize;
                    int locationY = y % bayerSize;

                    float sampleResult = (float) bayer[locationX, locationY] / MaxBayerNum ;
                    int rangeResult = (sampleResult + (valueSlider.Value / (float)SliderMax)) > 0.95f ? 1 : 0;
                    int alphaResult = (rangeResult == 1 ) ? 255 << 24 : 1 << 24 ;
                    int newCol = (alphaResult ) ;
  
                    newCol += 255 + 255 << 8 + 255 << 16;
                    map.SetPixel(x, y, Color.FromArgb(newCol));
                }


            ResultViewer.Image = map;
            GC.Collect();
        }

        private void SaveBitmap_Btn_Click(object sender, EventArgs e)
        {

            int n = Int32.Parse(sizeText.Text);
            int size = 1 << n;
            Bitmap map = new Bitmap( size, size );
            for (int y = 0; y < map.Size.Height; y++)
                for (int x = 0; x < map.Size.Width; x++)
                {
                    
                    int curColor = ((int) (255 * ( (float) bayer[x, y] / MaxBayerNum)) << 24 ) ;
                    curColor += 255 + 255 << 8 + 255 << 16;
                    map.SetPixel(x, y, Color.FromArgb(curColor));
                }


            map.Save("bayer" + size + "x" + size + ".bmp");

        }
    }
}
