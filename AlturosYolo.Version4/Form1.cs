using Alturos.Yolo;
using Alturos.Yolo.Model;
using AlturosYolo.Version4.custom;
using AlturosYolo.Version4.Model;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlturosYolo.Version4
{
    public partial class Form1 : Form
    {
        YoloWrapper_custom YOLO;
        public Form1()
        {
            
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = $"Alturos Yolo TestUI {Application.ProductVersion}";
            toolStripStatusLabelYoloInfo.Text = "";
            btnDetect.Enabled = false;
            
        }
        void YoloV3()
        {

            var GpuConfig = new GpuConfig_custom();
            GpuConfig.GpuIndex = 0;
            
            YOLO = new YoloWrapper_custom(configPath.configFile,configPath.weightsFile,configPath.namesFile,GpuConfig);
            
        }
        private void DetectSelectedImage()
        {
            var items = this.Detect();
            this.dataGridResult.DataSource = items;   
            this.DrawBoundingBoxes(items);
        }
        private ImageInfo GetCurrentImage()
        {
            ImageInfo item;
            item = (ImageInfo)(this.dataGridViewFile.CurrentRow?.DataBoundItem);  
            return item;
        }
        private List<YoloItem> Detect(bool memoryTransfer = true)     //because there maybe more than one detected items in picturebox so I wrote that function to list them to List<YoloItem> items
        {
            if (this.YOLO == null)
            {
                MessageBox.Show("YoloV3 is not init...");
                return null;
            }

            var imageInfo = this.GetCurrentImage();
            var imageData = File.ReadAllBytes(imageInfo.Path);
            //List<YoloItem> items;
            var sw = new Stopwatch();
            sw.Start();
            List<YoloItem> items;
            if (memoryTransfer)
            {
                items = this.YOLO.Detect(imageData).ToList();
            }
            else
            {
                items = this.YOLO.Detect(imageInfo.Path).ToList();
            }
            sw.Stop();
            this.groupBoxResult.Text = $"Result [ Processed in {sw.Elapsed.TotalMilliseconds:0} ms ]";
            return items;
        }
        private void DrawBoundingBoxes(List<YoloItem> items,YoloItem selectedItem=null)
        {
            //Get Images' location and load them
            var imageInfo = GetCurrentImage();
            var image = Image.FromFile(imageInfo.Path);

            //Load text's font to write detected items'types
            var font = new Font(FontFamily.GenericSansSerif, 20);

            //load canvas to border detected items.Need to use "using" for faster resolvement
            using (var canvas = Graphics.FromImage(image))
            {
                foreach (var item in items)
                {
                    var x = item.X;
                    var y = item.Y;
                    var width = item.Width;
                    var height = item.Height;

                    var brush = this.GetBrush(item.Confidence);
                    var penSize = image.Width / 100.0f;

                    using(var pen =new Pen(brush, penSize))
                    {
                        canvas.DrawRectangle(pen, x, y, width, height);
                        canvas.FillRectangle(brush, x - (penSize/2), y - 15, width+penSize, 25);
                        canvas.DrawString(item.Type.ToString(), font, Brushes.White, item.X, item.Y - 20); 
                    }
                }
                canvas.Flush();
            }
            var oldImage = this.pictureBox1.Image;
            this.pictureBox1.Image = image;
            oldImage?.Dispose();
        }
        private void DrawSelectingBox(List<YoloItem> items,YoloItem selectedItem = null)
        {
            var imageInfo = this.GetCurrentImage();
            var image = Image.FromFile(imageInfo.Path);
            using(var canvas = Graphics.FromImage(image))
            {
                foreach (var item in items)
                {
                    var x = item.X;
                    var y = item.Y;
                    var width = item.Width;
                    var height = item.Height;

                    var font = new Font(FontFamily.GenericSansSerif, 20);
                    var brush = this.GetBrush(item.Confidence);
                    var penSize = image.Width / 100.0f;
                    var pen = new Pen(brush, penSize);
                    using(var overlayBrush=new SolidBrush(Color.FromArgb(150, 255, 255, 102)))
                    {
                        if (item.Equals(selectedItem))
                        {
                            canvas.FillRectangle(overlayBrush, x, y, width, height);
                        }
                        canvas.DrawRectangle(pen, x, y, width, height);
                        canvas.FillRectangle(brush, x - (penSize / 2), y - 15, width + penSize, 25);
                        canvas.DrawString(item.Type.ToString(), font, Brushes.White, item.X, item.Y - 20);
                    }

                }
                canvas.Flush();
            }
            var oldImage = this.pictureBox1.Image;
            this.pictureBox1.Image = image;
            oldImage?.Dispose();
        }
        private Brush GetBrush(double confidence)   
        {
            if (confidence > 0.5)
            {
                return Brushes.Green;
            }
            else if(confidence >=0.2 && confidence <= 0.5)
            {
                return Brushes.Orange;
            }
            return Brushes.DarkRed;
        }


        private void btnOpen_Click(object sender, EventArgs e)
        {
            var imageInfos = new DirectoryImageReader().Analyze(@"H:\DATN\Trained file\data anh");  
            this.dataGridViewFile.DataSource = imageInfos.ToList();           
        }
        private void btnDetect_Click(object sender, EventArgs e)
        {
            this.DetectSelectedImage();
        }

        private void dataGridView2_SelectionChanged(object sender, EventArgs e)
        {
            var oldImage = this.pictureBox1.Image;
            var imageInfo = this.GetCurrentImage();
            this.pictureBox1.Image = Image.FromFile(imageInfo.Path);
            oldImage?.Dispose();

            this.dataGridResult.DataSource = null;
            this.groupBoxResult.Text = $"Result";
        }
        private void btnLoad_Click(object sender, EventArgs e)
        {
            var GpuConfig = new GpuConfig_custom();
            toolStripStatusLabelYoloInfo.Text = "Initializing...";
            Task.Run(() => 
            {
                var sw = new Stopwatch();
                sw.Start();
                notifyIconYoloInformation.ShowBalloonTip(5000, "YOLO Information", "Loading your YOLO", ToolTipIcon.None);
                YoloV3();
                Invoke(new Action(() =>
                {
                    btnDetect.Enabled = true;
                    btnLoad.Enabled = false;
                    btnLoad.Text = "Loaded";
                }));
                sw.Stop();

                var action = new MethodInvoker(delegate ()
                {
                    var deviceName = this.YOLO.GetGraphicDeviceName(GpuConfig);
                    this.toolStripStatusLabelYoloInfo.Text = $"Initialized Yolo in {sw.Elapsed.TotalMilliseconds:0} ms - Detection System: {this.YOLO.DetectionSystem} {deviceName} - Weights: YoloV4-custom_last.weights";
                });
                notifyIconYoloInformation.ShowBalloonTip(7000, "YOLO Information", "Loading completed \nGPU: Nvidia Geforce GTX 1050 \nWeights File: YoloV4-custom_last.weights", ToolTipIcon.None);
                this.statusStrip1.Invoke(action);
            });          
        }

        private void dataGridResult_SelectionChanged(object sender, EventArgs e)
        {
            if (!dataGridResult.Focused)
            {
                return;
            }
            var items = dataGridResult.DataSource as List<YoloItem>;
            var selectedItem = dataGridResult.CurrentRow?.DataBoundItem as YoloItem;
            DrawSelectingBox(items, selectedItem);
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            YOLO.Dispose();
        }
    }
}
