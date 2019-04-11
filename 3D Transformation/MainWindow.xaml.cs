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
using HelixToolkit.Wpf;
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
            initcomboboxnewshape();
            gambarsumbu();
        }
        private void initcomboboxnewshape()
        {
            comboboxnewshape.Items.Add("Persegi Panjang");
            comboboxnewshape.Items.Add("Bola");
        }
        private void gambarsumbu()
        {
            var sumbux = new MeshBuilder(false, false);
            var sumbuy = new MeshBuilder(false, false);
            var sumbuz = new MeshBuilder(false, false);
            sumbux.AddPipe(new Point3D(-100, 0, 0), new Point3D(100, 0, 0), 0, 0.1, 90);
            sumbuy.AddPipe(new Point3D(0, -100, 0), new Point3D(0, 100, 0), 0, 0.1, 90);
            sumbuz.AddPipe(new Point3D(0, 0, -100), new Point3D(0, 0, 100), 0, 0.1, 90);
            var mesh = sumbux.ToMesh(true);
            var material = MaterialHelper.CreateMaterial(Colors.DarkRed);
            objects.Children.Add(new GeometryModel3D
            {
                Geometry = mesh,
                Material = material
            });
            mesh = sumbuy.ToMesh(true);
            material = MaterialHelper.CreateMaterial(Colors.ForestGreen);
            objects.Children.Add(new GeometryModel3D
            {
                Geometry = mesh,
                Material = material
            });
            mesh = sumbuz.ToMesh(true);
            material = MaterialHelper.CreateMaterial(Colors.RoyalBlue);
            objects.Children.Add(new GeometryModel3D
            {
                Geometry = mesh,
                Material = material
            });
            placedobjects.Content = objects;
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
