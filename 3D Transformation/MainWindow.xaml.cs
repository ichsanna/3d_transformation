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
        bool objekterbuat =false;
        Model3DGroup objects = new Model3DGroup();
        double[,] matrikstransformasi = new double[,]
        {
            {0,0,0,0},
            {0,0,0,0},
            {0,0,0,0},
            {0,0,0,0}
        };
        Point3D[] titik = new Point3D[8] {
                new Point3D(0,0,0),
                new Point3D(0,0,0),
                new Point3D(0,0,0),
                new Point3D(0,0,0),
                new Point3D(0,0,0),
                new Point3D(0,0,0),
                new Point3D(0,0,0),
                new Point3D(0,0,0)
            };
        public MainWindow()
        {
            InitializeComponent();
            initviewport();
            initcombobox();
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
            addlight();
            updateposisi();
        }
        private void initcombobox()
        {
            comboboxrotate.Items.Add("X-Axis");
            comboboxrotate.Items.Add("Y-Axis");
            comboboxrotate.Items.Add("Z-Axis");
            comboboxrotate.Items.Add("Line AB");
        }
        private void addlight()
        {
            ModelVisual3D lighting = new ModelVisual3D();
            ModelVisual3D lighting2 = new ModelVisual3D();
            DirectionalLight light = new DirectionalLight();
            DirectionalLight light2 = new DirectionalLight();
            light.Color = Colors.White;
            light2.Color = Colors.White;
            light.Direction = new Vector3D(-2, -2, -2);
            light2.Direction = new Vector3D(2, 2, 2);
            lighting.Content = light;
            lighting2.Content = light2;
            viewport.Children.Add(lighting);
            viewport.Children.Add(lighting2);
        }
        private void updateposisi()
        {
            labeltitik1.Content = "1:\t" + titik[0];
            labeltitik2.Content = "2:\t" + titik[1];
            labeltitik3.Content = "3:\t" + titik[2];
            labeltitik4.Content = "4:\t" + titik[3];
            labeltitik5.Content = "5:\t" + titik[4];
            labeltitik6.Content = "6:\t" + titik[5];
            labeltitik7.Content = "7:\t" + titik[6];
            labeltitik8.Content = "8:\t" + titik[7];
        }
        private void gambarkubus()
        {
            var mesh = new MeshGeometry3D();
            mesh.Positions.Add(titik[0]);
            mesh.Positions.Add(titik[1]);
            mesh.Positions.Add(titik[2]);
            mesh.Positions.Add(titik[3]);
            mesh.Positions.Add(titik[4]);
            mesh.Positions.Add(titik[5]);
            mesh.Positions.Add(titik[6]);
            mesh.Positions.Add(titik[7]);
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
            mesh.TriangleIndices.Add(4);
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
            updateposisi();
        }

        private void buttonbuatobjek_Click(object sender, RoutedEventArgs e)
        {
            if (!objekterbuat)
            {
                objekterbuat = true;
                buttonbuatobjek.Content = "Reset";
                var panjang = Convert.ToDouble(textboxpanjangsisi.Text);
                var panjang2 = panjang / 2;
                var x = Convert.ToDouble(textboxposisiawalx.Text);
                var y = Convert.ToDouble(textboxposisiawaly.Text);
                var z = Convert.ToDouble(textboxposisiawalz.Text);
                titik[0] = new Point3D(x - panjang2, y - panjang2, z - panjang2);
                titik[1] = new Point3D(x + panjang2, y - panjang2, z - panjang2);
                titik[2] = new Point3D(x - panjang2, y + panjang2, z - panjang2);
                titik[3] = new Point3D(x + panjang2, y + panjang2, z - panjang2);
                titik[4] = new Point3D(x - panjang2, y - panjang2, z + panjang2);
                titik[5] = new Point3D(x + panjang2, y - panjang2, z + panjang2);
                titik[6] = new Point3D(x - panjang2, y + panjang2, z + panjang2);
                titik[7] = new Point3D(x + panjang2, y + panjang2, z + panjang2);
                gambarkubus();
            }
            else
            {
                resetviewport();
                objekterbuat = false;
                buttonbuatobjek.Content = "Buat Kubus";
            }
        }
        private void resetviewport()
        {
            viewport.Children.Clear();
            initviewport();
        }
        private void translate(double x, double y, double z)
        {
            resetmatrikstransform();
            matrikstransformasi[0, 0] = 1;
            matrikstransformasi[1, 1] = 1;
            matrikstransformasi[2, 2] = 1;
            matrikstransformasi[3, 3] = 1;
            matrikstransformasi[0, 3] = x;
            matrikstransformasi[1, 3] = y;
            matrikstransformasi[2, 3] = z;
            perkalianmatriks();
        }
        private void scale(double x, double y, double z)
        {
            resetmatrikstransform();
            matrikstransformasi[0, 0] = x;
            matrikstransformasi[1, 1] = y;
            matrikstransformasi[2, 2] = z;
            matrikstransformasi[3, 3] = 1;
            perkalianmatriks();
        }
        private void rotate(double angle, char axis)
        {
            resetmatrikstransform();
            if (axis == 'x')
            {
                matrikstransformasi[0, 0] = 1;
                matrikstransformasi[1, 1] = Math.Round(Math.Cos(Math.PI * angle/180),2);
                matrikstransformasi[2, 2] = Math.Round(Math.Cos(Math.PI * angle / 180), 2);
                matrikstransformasi[3, 3] = 1;
                matrikstransformasi[1, 2] = Math.Round(Math.Sin(Math.PI * angle / 180) * -1, 2);
                matrikstransformasi[2, 1] = Math.Round(Math.Sin(Math.PI * angle / 180), 2);
            }
            else if (axis == 'y')
            {
                matrikstransformasi[0, 0] = Math.Round(Math.Cos(Math.PI * angle / 180), 2);
                matrikstransformasi[1, 1] = 1;
                matrikstransformasi[2, 2] = Math.Round(Math.Cos(Math.PI * angle / 180), 2);
                matrikstransformasi[3, 3] = 1;
                matrikstransformasi[0, 2] = Math.Round(Math.Sin(Math.PI * angle / 180), 2);
                matrikstransformasi[2, 0] = Math.Round(Math.Sin(Math.PI * angle / 180) *-1, 2);
            }
            else if (axis == 'z')
            {
                matrikstransformasi[0, 0] = Math.Round(Math.Cos(Math.PI * angle / 180), 2);
                matrikstransformasi[1, 1] = Math.Round(Math.Cos(Math.PI * angle / 180), 2);
                matrikstransformasi[2, 2] = 1;
                matrikstransformasi[3, 3] = 1;
                matrikstransformasi[0, 1] = Math.Round(Math.Sin(Math.PI * angle / 180) *-1, 2);
                matrikstransformasi[1, 0] = Math.Round(Math.Sin(Math.PI * angle / 180), 2);
            }
            perkalianmatriks();
        }
        private void perkalianmatriks()
        {
            double tempx,tempy,tempz;
            for (int h = 0; h < 8; h++)
            {
                double[,] matriks2 = new double[,]
                {
                    {titik[h].X},{titik[h].Y},{titik[h].Z},{1}
                };
                tempx = 0;
                tempy = 0;
                tempz = 0;
                for (int i = 0; i < 4; i++)
                {
                    tempx += (matrikstransformasi[0, i] * matriks2[i, 0]);
                    tempy += (matrikstransformasi[1, i] * matriks2[i, 0]);
                    tempz += (matrikstransformasi[2, i] * matriks2[i, 0]);
                }
                titik[h].X = tempx;
                titik[h].Y = tempy;
                titik[h].Z = tempz;
            }
            resetviewport();
            resetmatrikstransform();
            gambarkubus();
        }
        private void resetmatrikstransform()
        {
            for (int i=0;i<4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    matrikstransformasi[i, j] = 0;
                }
            }
        }
        private void buttontranslate_Click(object sender, RoutedEventArgs e)
        {
            double x, y, z;
            if (textboxtranslatex.Text == "") x = 0;
            else x = Convert.ToDouble(textboxtranslatex.Text);
            if (textboxtranslatey.Text == "") y = 0;
            else y = Convert.ToDouble(textboxtranslatey.Text);
            if (textboxtranslatez.Text == "") z = 0;
            else z = Convert.ToDouble(textboxtranslatez.Text);
            translate(x,y,z);
        }

        private void buttonscale_Click(object sender, RoutedEventArgs e)
        {
            double x, y, z;
            if (textboxscalex.Text == "") x = 1;
            else x = Convert.ToDouble(textboxscalex.Text);
            if (textboxscaley.Text == "") y = 1;
            else y = Convert.ToDouble(textboxscaley.Text);
            if (textboxscalez.Text == "") z = 1;
            else z = Convert.ToDouble(textboxscalez.Text);
            scale(x, y, z);
        }

        private void comboboxrotate_SChanged(object sender, SelectionChangedEventArgs e)
        {
            if (comboboxrotate.SelectedIndex == 3)
            {
                textboxrotatepointxa.IsEnabled = true;
                textboxrotatepointya.IsEnabled = true;
                textboxrotatepointza.IsEnabled = true;
                textboxrotatepointxb.IsEnabled = true;
                textboxrotatepointyb.IsEnabled = true;
                textboxrotatepointzb.IsEnabled = true;
            }
            else
            {
                textboxrotatepointxa.IsEnabled = false;
                textboxrotatepointya.IsEnabled = false;
                textboxrotatepointza.IsEnabled = false;
                textboxrotatepointxb.IsEnabled = false;
                textboxrotatepointyb.IsEnabled = false;
                textboxrotatepointzb.IsEnabled = false;
            }
        }

        private void buttonrotate_Click(object sender, RoutedEventArgs e)
        {
            if (comboboxrotate.SelectedIndex == 0)
            {
                rotate(Convert.ToDouble(textboxrotateangle.Text), 'x');
            }
            else if (comboboxrotate.SelectedIndex == 1)
            {
                rotate(Convert.ToDouble(textboxrotateangle.Text), 'y');
            }
            else if (comboboxrotate.SelectedIndex == 2)
            {
                rotate(Convert.ToDouble(textboxrotateangle.Text), 'z');
            }
        }
    }
}
