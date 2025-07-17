using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VicsekFractal
{
    public partial class Form1 : Form
    {
        private Bitmap fractalBitmap;
        private bool isDrawing = false;
        private Graphics graphics;
        private Pen drawingPen = new Pen(Color.Black, 1);

        public Form1()
        {
            InitializeComponent();
            InitializeComponents();
        }

        private void InitializeComponents()
        {
            pictureBox.Size = new Size(300, 300);
            pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox.BackColor = Color.White;
            btnGenerate.Text = "�������������";
            label1.Text = "���������� �������� (0-7):";
            drawingPen = new Pen(Color.Black, 1);
        }

        private async void btnGenerate_Click(object sender, EventArgs e)
        {
            if (isDrawing) return;

            if (!int.TryParse(txtIterations.Text, out int iterations) || iterations < 0 || iterations > 7)
            {
                MessageBox.Show("������� ����� �� 0 �� 7!", "������",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            isDrawing = true;
            btnGenerate.Enabled = false;

            // ������������� �����������
            fractalBitmap = new Bitmap(pictureBox.Width, pictureBox.Height);
            graphics = Graphics.FromImage(fractalBitmap);
            graphics.Clear(Color.White);
            pictureBox.Image = fractalBitmap;

            // ����������� ���������� � ���������
            await DrawAnimatedFractal(iterations);

            isDrawing = false;
            btnGenerate.Enabled = true;
        }

        private async Task DrawAnimatedFractal(int maxDepth)
        {
            RectangleF bounds = new RectangleF(0, 0, pictureBox.Width, pictureBox.Height);
            await Task.Run(() => DrawVicsekAnimated(graphics, maxDepth, bounds, 0));
        }

        private void DrawVicsekAnimated(Graphics g, int maxDepth, RectangleF rect, int currentDepth)
        {
            if (currentDepth > maxDepth) return;

            float w = rect.Width / 3;
            float h = rect.Height / 3;

            // ������ ������ �� ��������� �������� �������
            if (currentDepth == maxDepth)
            {
                g.FillRectangle(Brushes.Black, rect);
                UpdatePictureBox();
                System.Threading.Thread.Sleep(50); // �������� ��� ��������
                return;
            }

            // ����������� ������ ��� ��������� �������
            DrawVicsekAnimated(g, maxDepth, new RectangleF(rect.X + w, rect.Y + h, w, h), currentDepth + 1); // �����
            DrawVicsekAnimated(g, maxDepth, new RectangleF(rect.X + w, rect.Y, w, h), currentDepth + 1);     // ����
            DrawVicsekAnimated(g, maxDepth, new RectangleF(rect.X + w, rect.Y + 2 * h, w, h), currentDepth + 1); // ���
            DrawVicsekAnimated(g, maxDepth, new RectangleF(rect.X, rect.Y + h, w, h), currentDepth + 1);     // ����
            DrawVicsekAnimated(g, maxDepth, new RectangleF(rect.X + 2 * w, rect.Y + h, w, h), currentDepth + 1); // �����
        }

        private void UpdatePictureBox()
        {
            if (pictureBox.InvokeRequired)
            {
                pictureBox.Invoke(new Action(UpdatePictureBox));
                return;
            }
            pictureBox.Refresh();
        }

        // ������� ��������
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            graphics?.Dispose();
            fractalBitmap?.Dispose();
        }

        // ��������� ������
        private void Form1_Load(object sender, EventArgs e) { }
        private void label1_Click(object sender, EventArgs e) { }
        private void txtIterations_TextChanged(object sender, EventArgs e) { }
        private void pictureBox_Click(object sender, EventArgs e) { }
    }
}