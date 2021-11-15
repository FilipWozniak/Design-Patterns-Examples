using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Xml;

namespace CalculatorChainofResponsibility
{
    public partial class MainWindow : Window
    {
        int saveFiles = 0;
        int currentDrawing = 0;
        Caretaker caretaker = new Caretaker();
        Originator originator = new Originator();
        Point currentPoint = new Point();

        public MainWindow()
        {
            InitializeComponent();
            RedoDrawing.IsEnabled = false;
            UndoDrawing.IsEnabled = false;
        }

        private void PaintSurface_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ButtonState == MouseButtonState.Pressed)
                currentPoint = e.GetPosition(this);
        }

        private void PaintSurface_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                Line line = new Line();   
                line.Stroke = SystemColors.WindowFrameBrush;
                line.StrokeThickness = 8; 
                line.X1 = currentPoint.X;
                line.Y1 = currentPoint.Y;
                line.X2 = e.GetPosition(this).X;
                line.Y2 = e.GetPosition(this).Y;   
                currentPoint = e.GetPosition(this);
                paintSurface.Children.Add(line);
            }
        }

        private void SaveDrawing_Click(object sender, RoutedEventArgs e)
        {
            string saved = XamlWriter.Save(paintSurface);
            StringReader sReader = new StringReader(saved);
            XmlReader xReader = XmlReader.Create(sReader);
            Canvas newCanvas = (Canvas)XamlReader.Load(xReader);
            originator.set(newCanvas);
            caretaker.addMemento(originator.storeInMemento());
            saveFiles++;
            currentDrawing++;
            Console.WriteLine("Save Files " + saveFiles);
            UndoDrawing.IsEnabled = true;
            DebugButton.Text = "Number of Saved Versions: " + saveFiles;
        }

        private void UndoDrawing_Click(object sender, RoutedEventArgs e)
        {
            if(currentDrawing >= 1)
            {
                currentDrawing--;
                DebugButton.Text = "Current: " + currentDrawing + " / " + saveFiles;
                StackMainWindow.Children.Clear();
                originator.restoreFromMemento(caretaker.getMemento(currentDrawing)).MouseDown += PaintSurface_MouseDown;
                originator.restoreFromMemento(caretaker.getMemento(currentDrawing)).MouseMove += PaintSurface_MouseMove;
                StackMainWindow.Children.Add(originator.restoreFromMemento(caretaker.getMemento(currentDrawing)));
                paintSurface.InvalidateVisual();
                paintSurface.UpdateLayout();
                RedoDrawing.IsEnabled = true;
            } else
            {
                UndoDrawing.IsEnabled = false;
            }
        }

        private void RedoDrawing_Click(object sender, RoutedEventArgs e)
        {
            if ((saveFiles - 1) > currentDrawing)
            {
                currentDrawing++;
                DebugButton.Text = "Current: " + currentDrawing + " / " + saveFiles;
                StackMainWindow.Children.Clear();
                originator.restoreFromMemento(caretaker.getMemento(currentDrawing)).MouseDown += PaintSurface_MouseDown;
                originator.restoreFromMemento(caretaker.getMemento(currentDrawing)).MouseMove += PaintSurface_MouseMove;
                StackMainWindow.Children.Add(originator.restoreFromMemento(caretaker.getMemento(currentDrawing)));
                UndoDrawing.IsEnabled = true;
            }
            else
            {
                RedoDrawing.IsEnabled = true;
            }
        }
    }
}