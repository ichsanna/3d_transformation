using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Media.Media3D;

namespace _3D_Transformation
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Model3DGroup objects = new Model3DGroup();
        public MainWindow()
        {
            InitializeComponent();
            initviewport();
            gambarkubus();
        }
        private void gambarsumbux()
        {
            var meshx = new MeshGeometry3D();
            meshx.Positions.Add(new Point3D(-20, -0.05, -0.05));
            meshx.Positions.Add(new Point3D(20, -0.05, -0.05));
            meshx.Positions.Add(new Point3D(-20, 0.05, -0.05));
            meshx.Positions.Add(new Point3D(20, 0.05, -0.05));
            meshx.Positions.Add(new Point3D(-20, -0.05, 0.05));
            meshx.Positions.Add(new Point3D(20, -0.05, 0.05));
            meshx.Positions.Add(new Point3D(-20, 0.05, 0.05));
            meshx.Positions.Add(new Point3D(20, 0.05, 0.05));
            meshx.TriangleIndices.Add(2);
            meshx.TriangleIndices.Add(3);
            meshx.TriangleIndices.Add(1);
            meshx.TriangleIndices.Add(2);
            meshx.TriangleIndices.Add(1);
            meshx.TriangleIndices.Add(0);
            meshx.TriangleIndices.Add(7);
            meshx.TriangleIndices.Add(1);
            meshx.TriangleIndices.Add(3);
            meshx.TriangleIndices.Add(7);
            meshx.TriangleIndices.Add(5);
            meshx.TriangleIndices.Add(1);
            meshx.TriangleIndices.Add(6);
            meshx.TriangleIndices.Add(5);
            meshx.TriangleIndices.Add(7);
            meshx.TriangleIndices.Add(6);
            meshx.TriangleIndices.Add(4);
            meshx.TriangleIndices.Add(5);
            meshx.TriangleIndices.Add(6);
            meshx.TriangleIndices.Add(2);
            meshx.TriangleIndices.Add(0);
            meshx.TriangleIndices.Add(2);
            meshx.TriangleIndices.Add(0);
            meshx.TriangleIndices.Add(4);
            meshx.TriangleIndices.Add(2);
            meshx.TriangleIndices.Add(7);
            meshx.TriangleIndices.Add(3);
            meshx.TriangleIndices.Add(2);
            meshx.TriangleIndices.Add(6);
            meshx.TriangleIndices.Add(7);
            meshx.TriangleIndices.Add(0);
            meshx.TriangleIndices.Add(1);
            meshx.TriangleIndices.Add(5);
            meshx.TriangleIndices.Add(0);
            meshx.TriangleIndices.Add(5);
            meshx.TriangleIndices.Add(4);
            SolidColorBrush brushx = new SolidColorBrush(Colors.Red);
            var materialx = new DiffuseMaterial(brushx);
            var modelgroupx = new Model3DGroup();
            modelgroupx.Children.Add(new GeometryModel3D(meshx, materialx));
            //modelgroupx.Children.Add(new AmbientLight(Colors.Red));
            var modelvisualx = new ModelVisual3D();
            modelvisualx.Content = modelgroupx;
            viewport.Children.Add(modelvisualx);
        }
        private void gambarsumbuy()
        {
            var meshy = new MeshGeometry3D();
            meshy.Positions.Add(new Point3D(-0.05, -20, -0.05));
            meshy.Positions.Add(new Point3D(0.05, -20, -0.05));
            meshy.Positions.Add(new Point3D(-0.05, 20, -0.05));
            meshy.Positions.Add(new Point3D(0.05, 20, -0.05));
            meshy.Positions.Add(new Point3D(-0.05, -20, 0.05));
            meshy.Positions.Add(new Point3D(0.05, -20, 0.05));
            meshy.Positions.Add(new Point3D(-0.05, 20, 0.05));
            meshy.Positions.Add(new Point3D(0.05, 20, 0.05));
            meshy.TriangleIndices.Add(2);
            meshy.TriangleIndices.Add(3);
            meshy.TriangleIndices.Add(1);
            meshy.TriangleIndices.Add(2);
            meshy.TriangleIndices.Add(1);
            meshy.TriangleIndices.Add(0);
            meshy.TriangleIndices.Add(7);
            meshy.TriangleIndices.Add(1);
            meshy.TriangleIndices.Add(3);
            meshy.TriangleIndices.Add(7);
            meshy.TriangleIndices.Add(5);
            meshy.TriangleIndices.Add(1);
            meshy.TriangleIndices.Add(6);
            meshy.TriangleIndices.Add(5);
            meshy.TriangleIndices.Add(7);
            meshy.TriangleIndices.Add(6);
            meshy.TriangleIndices.Add(4);
            meshy.TriangleIndices.Add(5);
            meshy.TriangleIndices.Add(6);
            meshy.TriangleIndices.Add(2);
            meshy.TriangleIndices.Add(0);
            meshy.TriangleIndices.Add(2);
            meshy.TriangleIndices.Add(0);
            meshy.TriangleIndices.Add(4);
            meshy.TriangleIndices.Add(2);
            meshy.TriangleIndices.Add(7);
            meshy.TriangleIndices.Add(3);
            meshy.TriangleIndices.Add(2);
            meshy.TriangleIndices.Add(6);
            meshy.TriangleIndices.Add(7);
            meshy.TriangleIndices.Add(0);
            meshy.TriangleIndices.Add(1);
            meshy.TriangleIndices.Add(5);
            meshy.TriangleIndices.Add(0);
            meshy.TriangleIndices.Add(5);
            meshy.TriangleIndices.Add(4);
            SolidColorBrush brushy = new SolidColorBrush(Colors.Green);
            var materialy = new DiffuseMaterial(brushy);
            var modelgroupy = new Model3DGroup();
            modelgroupy.Children.Add(new GeometryModel3D(meshy, materialy));
            //modelgroupx.Children.Add(new AmbientLight(Colors.Red));
            var modelvisualy = new ModelVisual3D();
            modelvisualy.Content = modelgroupy;
            viewport.Children.Add(modelvisualy);
        }
        private void gambarsumbuz()
        {
            var meshz = new MeshGeometry3D();
            meshz.Positions.Add(new Point3D(-0.05, -0.05, -20));
            meshz.Positions.Add(new Point3D(0.05, -0.05, -20));
            meshz.Positions.Add(new Point3D(-0.05, 0.05, -20));
            meshz.Positions.Add(new Point3D(0.05, 0.05, -20));
            meshz.Positions.Add(new Point3D(-0.05, -0.05, 20));
            meshz.Positions.Add(new Point3D(0.05, -0.05, 20));
            meshz.Positions.Add(new Point3D(-0.05, 0.05, 20));
            meshz.Positions.Add(new Point3D(0.05, 0.05, 20));
            meshz.TriangleIndices.Add(2);
            meshz.TriangleIndices.Add(3);
            meshz.TriangleIndices.Add(1);
            meshz.TriangleIndices.Add(2);
            meshz.TriangleIndices.Add(1);
            meshz.TriangleIndices.Add(0);
            meshz.TriangleIndices.Add(7);
            meshz.TriangleIndices.Add(1);
            meshz.TriangleIndices.Add(3);
            meshz.TriangleIndices.Add(7);
            meshz.TriangleIndices.Add(5);
            meshz.TriangleIndices.Add(1);
            meshz.TriangleIndices.Add(6);
            meshz.TriangleIndices.Add(5);
            meshz.TriangleIndices.Add(7);
            meshz.TriangleIndices.Add(6);
            meshz.TriangleIndices.Add(4);
            meshz.TriangleIndices.Add(5);
            meshz.TriangleIndices.Add(6);
            meshz.TriangleIndices.Add(2);
            meshz.TriangleIndices.Add(0);
            meshz.TriangleIndices.Add(2);
            meshz.TriangleIndices.Add(0);
            meshz.TriangleIndices.Add(4);
            meshz.TriangleIndices.Add(2);
            meshz.TriangleIndices.Add(7);
            meshz.TriangleIndices.Add(3);
            meshz.TriangleIndices.Add(2);
            meshz.TriangleIndices.Add(6);
            meshz.TriangleIndices.Add(7);
            meshz.TriangleIndices.Add(0);
            meshz.TriangleIndices.Add(1);
            meshz.TriangleIndices.Add(5);
            meshz.TriangleIndices.Add(0);
            meshz.TriangleIndices.Add(5);
            meshz.TriangleIndices.Add(4);
            SolidColorBrush brushz = new SolidColorBrush(Colors.Blue);
            var materialz = new DiffuseMaterial(brushz);
            var modelgroupz = new Model3DGroup();
            modelgroupz.Children.Add(new GeometryModel3D(meshz, materialz));
            //modelgroupx.Children.Add(new AmbientLight(Colors.Red));
            var modelvisualz = new ModelVisual3D();
            modelvisualz.Content = modelgroupz;
            viewport.Children.Add(modelvisualz);
        }
        private void initviewport()
        {
            gambarsumbux();
            gambarsumbuy();
            gambarsumbuz();
        }
        private void gambarkubus()
        {
            var mesh = new MeshGeometry3D();
            mesh.Positions.Add(new Point3D(0, 0, 0));
            mesh.Positions.Add(new Point3D(1, 0, 0));
            mesh.Positions.Add(new Point3D(0, 1, 0));
            mesh.Positions.Add(new Point3D(1, 1, 0));
            mesh.Positions.Add(new Point3D(0, 0, 1));
            mesh.Positions.Add(new Point3D(1, 0, 1));
            mesh.Positions.Add(new Point3D(0, 1, 1));
            mesh.Positions.Add(new Point3D(1, 1, 1));
            mesh.TriangleIndices.Add(2);
            mesh.TriangleIndices.Add(3);
            mesh.TriangleIndices.Add(1);
            mesh.TriangleIndices.Add(2);
            mesh.TriangleIndices.Add(1);
            mesh.TriangleIndices.Add(0);
            mesh.TriangleIndices.Add(7);
            mesh.TriangleIndices.Add(1);
            mesh.TriangleIndices.Add(3);
            mesh.TriangleIndices.Add(7);
            mesh.TriangleIndices.Add(5);
            mesh.TriangleIndices.Add(1);
            mesh.TriangleIndices.Add(6);
            mesh.TriangleIndices.Add(5);
            mesh.TriangleIndices.Add(7);
            mesh.TriangleIndices.Add(6);
            mesh.TriangleIndices.Add(4);
            mesh.TriangleIndices.Add(5);
            mesh.TriangleIndices.Add(6);
            mesh.TriangleIndices.Add(2);
            mesh.TriangleIndices.Add(0);
            mesh.TriangleIndices.Add(2);
            mesh.TriangleIndices.Add(0);
            mesh.TriangleIndices.Add(4);
            mesh.TriangleIndices.Add(2);
            mesh.TriangleIndices.Add(7);
            mesh.TriangleIndices.Add(3);
            mesh.TriangleIndices.Add(2);
            mesh.TriangleIndices.Add(6);
            mesh.TriangleIndices.Add(7);
            mesh.TriangleIndices.Add(0);
            mesh.TriangleIndices.Add(1);
            mesh.TriangleIndices.Add(5);
            mesh.TriangleIndices.Add(0);
            mesh.TriangleIndices.Add(5);
            mesh.TriangleIndices.Add(4);
            SolidColorBrush brush = new SolidColorBrush(Colors.Red);
            var material = new DiffuseMaterial(brush);
            var modelgroup = new Model3DGroup();
            modelgroup.Children.Add(new GeometryModel3D(mesh, material));
            //modelgroup.Children.Add(new AmbientLight(Colors.Red));
            var modelvisual = new ModelVisual3D();
            modelvisual.Content = modelgroup;
            viewport.Children.Add(modelvisual);
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
