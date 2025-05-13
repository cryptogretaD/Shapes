using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

using MyPaint.Models;
using MyPaint.Models.Enums;

namespace MyPaint
{
    public partial class MainForm : Form
    {
        private ShapesEnum shapeToDraw = ShapesEnum.None;

        private bool isDrawing = false;

        private bool isMoving = false;

        private Point startPoint;

        private Point startMovePoint;

        private Shape selectedFigure;

        private Shape currentShape;

        private List<Shape> shapes = new List<Shape>();

        private BindingSource bindingSource;

        public MainForm()
        {
            InitializeComponent();
            
            panel1.MouseDown += panel1_MouseDown;
            panel1.MouseUp += panel1_MouseUp;
            panel1.MouseMove += panel1_MouseMove;
            panel1.Paint += panel1_Paint;

            bindingSource = new BindingSource();
            bindingSource.DataSource = shapes;
            listBox1.DataSource = bindingSource;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            // LINQ
            shapes.ForEach(figure =>
            {
                figure.Draw(e.Graphics);

                if (figure != selectedFigure)
                {
                    return;
                }

                Pen pen = new Pen(Color.Red, 2);
                e.Graphics.DrawRectangle(pen, figure.GetBounds());
                pen.Dispose();
            });

            if (isDrawing && currentShape != null)
            {
                currentShape.Draw(e.Graphics);
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
            {
                return;
            }

            if (shapeToDraw == ShapesEnum.None)
            {
                return;
            }

            bool isBlankClick = true;
            // LINQ
            var shapeIndex = shapes.FindIndex(shape => shape.Contains(e.Location));
            if (shapeIndex != -1)
            {
                listBox1.SelectedIndex = shapeIndex;
                selectedFigure = shapes[shapeIndex];
                isBlankClick = false;
                panel1.Invalidate();
            }

            if (selectedFigure != null && selectedFigure.Contains(e.Location))
            {
                isMoving = true;
                startMovePoint = e.Location;

                if (!btnActivateFill.Enabled)
                {
                    selectedFigure.FillBrush.Color = pbxFillBrush.BackColor;
                    btnActivateFill.Enabled = selectedFigure.IsFilled = true;
                }
            }

            if (selectedFigure == null && !isMoving)
            {
                isDrawing = true;
                startPoint = e.Location;
            }

            if (isBlankClick)
            {
                selectedFigure = null;
                listBox1.ClearSelected();
            }
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (isMoving)
            {
                int dx = e.Location.X - startMovePoint.X;
                int dy = e.Location.Y - startMovePoint.Y;

                // calculate new position of the figure
                int newX = selectedFigure.Position.X + dx;
                int newY = selectedFigure.Position.Y + dy;

                // check if new position will exceed panel boundaries
                int maxX = panel1.Width - selectedFigure.Width;
                int maxY = panel1.Height - selectedFigure.Height;

                if (newX < 0)
                {
                    newX = 0;
                }

                if (newX > maxX)
                {
                    newX = maxX;
                }

                if (newY < 0)
                {
                    newY = 0;
                }

                if (newY > maxY)
                {
                    newY = maxY;
                }

                selectedFigure.Position = new Point(newX, newY);

                startMovePoint = e.Location;
            }

            if (isDrawing)
            {
                int width = e.X - startPoint.X;
                int height = e.Y - startPoint.Y;

                switch (shapeToDraw)
                {
                    case ShapesEnum.Circle:
                        currentShape = new Circle(
                            startPoint.X,
                            startPoint.Y,
                            width);
                        break;

                    case ShapesEnum.Rectangle:
                        currentShape = new Models.Rectangle(
                            startPoint.X,
                            startPoint.Y,
                            width,
                            height);
                        break;

                    case ShapesEnum.Square:
                        currentShape = new Square(
                            startPoint.X,
                            startPoint.Y,
                            height);
                        break;

                    case ShapesEnum.Triangle:
                        int x3 = startPoint.X - e.X / 2;
                        int y3 = e.Y;

                        currentShape =
                            new Triangle(
                                startPoint.X,
                                startPoint.Y,
                                e.X,
                                e.Y,
                                x3,
                                y3);
                        break;
                }

                currentShape.Border = new Pen(pbxBorderColor.BackColor, (float)numericUpDown2.Value);
                currentShape.FillBrush = new SolidBrush(pbxFillBrush.BackColor);
            }

            panel1.Invalidate();
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            if (isMoving)
            {
                isMoving = false;
            }

            if (!isDrawing)
            {
                return;
            }

            isDrawing = false;
            if (currentShape != null)
            {
                shapes.Add(currentShape);
                bindingSource.ResetBindings(false);
            }

            currentShape = null;
            startPoint = Point.Empty;

            // LINQ
            groupBox1
                .Controls
                .OfType<RadioButton>()
                .ToList()
                .ForEach(
                    radioButton => radioButton.Checked = false);

            //shapeToDraw = ShapesEnum.None;
            panel1.Invalidate();
        }

        private void rbtn_CheckedChanged(object sender, System.EventArgs e)
        {
            var radioButton = sender as RadioButton;

            if (radioButton == null)
            {
                return;
            }

            if (rbtnCircle.Checked)
            {
                shapeToDraw = ShapesEnum.Circle;
            }

            if (rbtnSquare.Checked)
            {
                shapeToDraw = ShapesEnum.Square;
            }

            if (rbtnRectangle.Checked)
            {
                shapeToDraw = ShapesEnum.Rectangle;
            }

            if (rbtnTriangle.Checked)
            {
                shapeToDraw = ShapesEnum.Triangle;
            }
            selectedFigure = null;
        }

        private void btnFillColor_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();

            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                pbxFillBrush.BackColor = colorDialog.Color;
            }
        }

        private void btnBorder_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();

            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                pbxBorderColor.BackColor = colorDialog.Color;
            }
        }

        private void btnActivateFill_Click(object sender, EventArgs e)
        {
            if (shapes.Count == 0)
            {
                return;
            }

            btnActivateFill.Enabled = false;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (shapes.Count == 0)
            {
                return;
            }

            int selectedIndex = listBox1.SelectedIndex;

            if (selectedIndex == -1)
            {
                return;
            }

            selectedFigure = shapes[selectedIndex];
            panel1.Invalidate();
        }

        private void btnAction_Click(object sender, EventArgs e)
        {
            if (cbxActions.Text == "Import")
            {
                OpenFileDialog importFileDialog = new OpenFileDialog();
                importFileDialog.Filter = "Serialized files (*.bin)|*.bin|All files (*.*)|*.*";
                importFileDialog.FilterIndex = 1;
                importFileDialog.RestoreDirectory = true;

                if (importFileDialog.ShowDialog() != DialogResult.OK)
                {
                    return;
                }

                try
                {
                    Shape deserializedObject = null;
                    using (FileStream stream = File.Open(importFileDialog.FileName, FileMode.Open))
                    {
                        BinaryFormatter formatter = new BinaryFormatter();
                        Shape result = formatter.Deserialize(stream) as Shape;

                        switch (result)
                        {
                            case Circle circle:
                                deserializedObject = circle;
                                break;
                            case Models.Rectangle rec:
                                deserializedObject = rec;
                                break;
                            case Square square:
                                deserializedObject = square;
                                break;

                            case Triangle triangle:
                                deserializedObject = triangle;
                                break;
                        }
                    }

                    if (deserializedObject == null)
                    {
                        return;
                    }

                    deserializedObject.Border = new Pen(pbxBorderColor.BackColor, (float)numericUpDown2.Value);
                    deserializedObject.FillBrush = new SolidBrush(pbxFillBrush.BackColor);
                    shapes.Add(deserializedObject);
                    bindingSource.ResetBindings(false);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error opening file: " + ex.Message);
                }
            }

            int selectedIndex = listBox1.SelectedIndex;

            if (selectedIndex == -1)
            {
                return;
            }

            if (cbxActions.Text == "Delete")
            {
                shapes.RemoveAt(selectedIndex);
                bindingSource.ResetBindings(false);
                panel1.Invalidate();
                return;
            }

            var selectedShape = shapes[selectedIndex];

            if (cbxActions.Text == "Calculate Area and Parameter")
            {
                using (SecondForm secondForm = new SecondForm())
                {
                    secondForm.Shape = selectedShape;
                    secondForm.ShowDialog();
                }
            }

            if (cbxActions.Text == "Export")
            {
                SaveFileDialog exportFileDialog = new SaveFileDialog();
                exportFileDialog.FileName = selectedShape.ToString();
                exportFileDialog.Filter = "Binary files (*.bin)|*.bin|All files (*.*)|*.*";
                if (exportFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string fileName = exportFileDialog.FileName;
                    FileStream fileStream = null;

                    try
                    {
                        fileStream = new FileStream(fileName, FileMode.Create);
                        BinaryFormatter binaryFormatter = new BinaryFormatter();
                        binaryFormatter.Serialize(fileStream, selectedShape);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error saving file: " + ex.Message);
                    }
                    finally
                    {
                        if (fileStream != null)
                        {
                            fileStream.Close();
                        }
                    }
                }
            }
        }
    }
}
