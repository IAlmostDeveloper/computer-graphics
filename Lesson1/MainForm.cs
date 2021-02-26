using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lesson1
{
    public partial class MainForm : Form
    {
        private Canvas mainCanvas;
        public MainForm()
        {
            InitializeComponent();
            mainCanvas = new Canvas(mainPictureBox.CreateGraphics());
        }

        private void pickColorButton_Click(object sender, EventArgs e)
        {
            pickColorDialog.ShowDialog();
        }

        private void paintLineButton_Click(object sender, EventArgs e)
        {
            if (!mainCanvas.IsEnabled)
                return;
            try
            {
                switch (mainControlsPage.SelectedTab.Text)
                {
                    case "Линия":
                        DrawLine();
                        break;
                    case "Круг":
                        DrawCircle();
                        break;
                    case "Многоугольник":
                        DrawPolygon();
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        
        private void DrawLine()
        {
            var line = new Line(
                    new Point(int.Parse(x1textBox.Text), int.Parse(y1textBox.Text)),
                    new Point(int.Parse(x2textBox.Text), int.Parse(y2textBox.Text)),
                    int.Parse(lineWidthTextBox.Text),
                    pickColorDialog.Color == null ? Color.Black : pickColorDialog.Color);
            mainCanvas.DrawLine(line);
        }

        private void DrawCircle()
        {
            var circle = new Circle(
                new Point(int.Parse(circleXTextbox.Text), int.Parse(circleYTextbox.Text)),
                int.Parse(circleRadiusTextBox.Text), 
                pickColorDialog.Color
                );
            mainCanvas.DrawCircle(circle);
        }

        private void DrawPolygon()
        {
            var polygon = new Polygon(pickColorDialog == null ? Color.Black : pickColorDialog.Color, 
                polygonPointsListBox.Items.Cast<Point>(), int.Parse(polygonWidthTextBox.Text));
            mainCanvas.DrawPolygon(polygon);
            polygonPointsListBox.ClearSelected();
        }

        private void clearLineButton_Click(object sender, EventArgs e)
        {
            mainCanvas.Clear();
        }

        private void toggleGraphicsButton_Click(object sender, EventArgs e)
        {
            mainCanvas.Toggle();
        }

        private void tooltipButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Нажмите кнопку \"Вкл./Выкл.\", чтобы включить режим рисования. Выберите цвет, введите координаты и ширину линии.");
        }

        private void polygonAddPointButton_Click(object sender, EventArgs e)
        {
            polygonPointsListBox.Items.Add(new Point(int.Parse(polygonXTextBox.Text), int.Parse(polygonYTextBox.Text)));
        }
    }
}
