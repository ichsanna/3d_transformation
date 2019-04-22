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
    // Kelompok:
    // Dian Rahmaji (17/413896/TK/46336)
    // Raden Ichsan Nur Aldiansyah (17/413915/TK/46355)
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
            meshx.TriangleIndices.Add(4);
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
            meshy.TriangleIndices.Add(4);
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
            meshz.TriangleIndices.Add(4);
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
            light.Direction = new Vector3D(-5, -5, -5);
            light2.Direction = new Vector3D(5, 5, 5);
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
            var modelvisual = new ModelVisual3D();
            modelvisual.Content = modelgroup;
            viewport.Children.Add(modelvisual);
            updateposisi();
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
                matrikstransformasi[1, 1] = Math.Cos(Math.PI * angle/180);
                matrikstransformasi[2, 2] = Math.Cos(Math.PI * angle / 180);
                matrikstransformasi[3, 3] = 1;
                matrikstransformasi[1, 2] = Math.Sin(Math.PI * angle / 180) * -1;
                matrikstransformasi[2, 1] = Math.Sin(Math.PI * angle / 180);
            }
            else if (axis == 'y')
            {
                matrikstransformasi[0, 0] = Math.Cos(Math.PI * angle / 180);
                matrikstransformasi[1, 1] = 1;
                matrikstransformasi[2, 2] = Math.Cos(Math.PI * angle / 180);
                matrikstransformasi[3, 3] = 1;
                matrikstransformasi[0, 2] = Math.Sin(Math.PI * angle / 180);
                matrikstransformasi[2, 0] = Math.Sin(Math.PI * angle / 180) *-1;
            }
            else if (axis == 'z')
            {
                matrikstransformasi[0, 0] = Math.Cos(Math.PI * angle / 180);
                matrikstransformasi[1, 1] = Math.Cos(Math.PI * angle / 180);
                matrikstransformasi[2, 2] = 1;
                matrikstransformasi[3, 3] = 1;
                matrikstransformasi[0, 1] = Math.Sin(Math.PI * angle / 180) *-1;
                matrikstransformasi[1, 0] = Math.Sin(Math.PI * angle / 180);
            }
            perkalianmatriks();
        }
        private void rotate2(double angle,double x1, double y1, double z1, double x2, double y2, double z2)
        {
            resetmatrikstransform();
            matrikstransformasi[0, 0] = 1;
            matrikstransformasi[1, 1] = 1;
            matrikstransformasi[2, 2] = 1;
            matrikstransformasi[3, 3] = 1;
            matrikstransformasi[0, 3] = x1*-1;
            matrikstransformasi[1, 3] = y1*-1;
            matrikstransformasi[2, 3] = z1*-1;
            perkalianmatriks();
            var a = x2 - x1;
            var b = y2 - y1;
            var c = z2 - z1;
            var panjanggaris = Math.Sqrt(Math.Pow(b, 2)+Math.Pow(c,2));
            var panjanggaris2 = Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2) + Math.Pow(c, 2));
            var sin = b / panjanggaris;
            var cos = c / panjanggaris;
            matrikstransformasi[0, 0] = 1;
            matrikstransformasi[1, 1] = cos;
            matrikstransformasi[2, 2] = cos;
            matrikstransformasi[3, 3] = 1;
            matrikstransformasi[1, 2] = sin * -1;
            matrikstransformasi[2, 1] = sin;
            perkalianmatriks();
            matrikstransformasi[0, 0] = panjanggaris/panjanggaris2;
            matrikstransformasi[1, 1] = 1;
            matrikstransformasi[2, 2] = panjanggaris/panjanggaris2;
            matrikstransformasi[3, 3] = 1;
            matrikstransformasi[0, 2] = (a/panjanggaris2)*-1;
            matrikstransformasi[2, 0] = a / panjanggaris2;
            perkalianmatriks();
            rotate(angle, 'z');
            matrikstransformasi[0, 0] = panjanggaris / panjanggaris2;
            matrikstransformasi[1, 1] = 1;
            matrikstransformasi[2, 2] = panjanggaris / panjanggaris2;
            matrikstransformasi[3, 3] = 1;
            matrikstransformasi[0, 2] = a / panjanggaris2;
            matrikstransformasi[2, 0] = (a / panjanggaris2) * -1;
            perkalianmatriks();
            matrikstransformasi[0, 0] = 1;
            matrikstransformasi[1, 1] = cos;
            matrikstransformasi[2, 2] = cos;
            matrikstransformasi[3, 3] = 1;
            matrikstransformasi[1, 2] = sin;
            matrikstransformasi[2, 1] = sin * -1;
            perkalianmatriks();
            matrikstransformasi[0, 0] = 1;
            matrikstransformasi[1, 1] = 1;
            matrikstransformasi[2, 2] = 1;
            matrikstransformasi[3, 3] = 1;
            matrikstransformasi[0, 3] = x1;
            matrikstransformasi[1, 3] = y1;
            matrikstransformasi[2, 3] = z1;
            perkalianmatriks();
        }
        private void shear(double xy,double xz, double yx, double yz, double zx, double zy)
        {
            resetmatrikstransform();
            matrikstransformasi[0, 0] = 1;
            matrikstransformasi[1, 1] = 1;
            matrikstransformasi[2, 2] = 1;
            matrikstransformasi[3, 3] = 1;
            matrikstransformasi[0, 1] = yx;
            matrikstransformasi[0, 2] = zx;
            matrikstransformasi[1, 0] = xy;
            matrikstransformasi[1, 2] = zy;
            matrikstransformasi[2, 0] = xz;
            matrikstransformasi[2, 1] = yz;
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
                titik[h].X = Math.Round(tempx,4);
                titik[h].Y = Math.Round(tempy,4);
                titik[h].Z = Math.Round(tempz,4);
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
        private void resetviewport()
        {
            viewport.Children.Clear();
            initviewport();
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
            if (textboxrotateangle.Text == "")
            {
                textboxrotateangle.Text = "0";
            }
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
            else if (comboboxrotate.SelectedIndex == 3)
            {
                var x1 = Convert.ToDouble(textboxrotatepointxa.Text);
                var y1 = Convert.ToDouble(textboxrotatepointya.Text);
                var z1 = Convert.ToDouble(textboxrotatepointza.Text);
                var x2 = Convert.ToDouble(textboxrotatepointxb.Text);
                var y2 = Convert.ToDouble(textboxrotatepointyb.Text);
                var z2 = Convert.ToDouble(textboxrotatepointzb.Text);
                rotate2(Convert.ToDouble(textboxrotateangle.Text),x1, y1,z1,x2,y2,z2);
            }
        }

        private void buttonshear_Click(object sender, RoutedEventArgs e)
        {
            if (textboxshearxy.Text == "")
            {
                textboxshearxy.Text = "0";
            }
            if (textboxshearxz.Text == "")
            {
                textboxshearxz.Text = "0";
            }
            if (textboxshearyx.Text == "")
            {
                textboxshearyx.Text = "0";
            }
            if (textboxshearyz.Text == "")
            {
                textboxshearyz.Text = "0";
            }
            if (textboxshearzx.Text == "")
            {
                textboxshearzx.Text = "0";
            }
            if (textboxshearzy.Text == "")
            {
                textboxshearzy.Text = "0";
            }
            shear(Convert.ToDouble(textboxshearxy.Text), Convert.ToDouble(textboxshearxz.Text), Convert.ToDouble(textboxshearyx.Text), Convert.ToDouble(textboxshearyz.Text), Convert.ToDouble(textboxshearzx.Text), Convert.ToDouble(textboxshearzy.Text));
        }
    }
}
