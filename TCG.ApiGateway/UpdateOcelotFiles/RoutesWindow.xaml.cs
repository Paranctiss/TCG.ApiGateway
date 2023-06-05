using System;
using System.Collections.Generic;
using System.Windows;
using UpdateOcelotFiles.Helpers;
using UpdateOcelotFiles.OcelotClasses.Routes;

namespace UpdateOcelotFiles
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class RoutesWindow : Window
    {
        public RoutesWindow()
        {
            InitializeComponent();
        }

        private void BtnUpdate_Click(object sender, RoutedEventArgs e)
        {
            string ocelotDevPath = PathHelper.GetPath("ocelot.Development.json");
            string ocelotProdPath = PathHelper.GetPath("ocelot.Production.json");
            string ocelotLocalPath = PathHelper.GetPath("ocelot.Local.json");

            var ocelotDev = JsonHelper.Desarialize(ocelotDevPath);
            var ocelotProd = JsonHelper.Desarialize(ocelotProdPath);
            var ocelotLocal = JsonHelper.Desarialize(ocelotLocalPath);

            var newRoute = new Route
            {
                UpstreamPathTemplate = TxtBox_UpstreamPathTemplate.Text,
                UpstreamHttpMethod = new List<string> { TxtBox_UpstreamHttpMethod.Text },
                DownstreamScheme = TxtBox_DownstreamScheme.Text,
                DownstreamHostAndPorts = new List<DownstreamHostAndPortItem>
                {
                    new DownstreamHostAndPortItem
                    {
                        Host = TxtBox_Host.Text,
                        Port = int.Parse(TxtBox_Port.Text)
                    }
                },
                DownstreamPathTemplate = TxtBox_DownstreamPathTemplate.Text,
                SwaggerKey = TxtBox_SwaggerKey.Text
            };
            ocelotDev.Routes.Add(newRoute);
            ocelotProd.Routes.Add(newRoute);
            ocelotLocal.Routes.Add(newRoute);

            JsonHelper.UpdateOcelotFile(ocelotDevPath, ocelotDev);
            JsonHelper.UpdateOcelotFile(ocelotProdPath, ocelotProd);
            JsonHelper.UpdateOcelotFile(ocelotLocalPath, ocelotLocal);

            var newForm = new MenuWindow();
            newForm.Show();
            this.Close();

        }

     
    }
}
