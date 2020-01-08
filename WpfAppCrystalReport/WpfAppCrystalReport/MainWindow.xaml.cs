using CrystalDecisions.CrystalReports.Engine;
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

namespace WpfAppCrystalReport
{
	/// <summary>
	/// Logika interakcji dla klasy MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();

			ReportDocument reportDocument = new ReportDocument();
			string path = AppDomain.CurrentDomain.BaseDirectory + "CrystalReport1.rpt";

			reportDocument.Load(path);
			reportDocument.DataSourceConnections[0].IntegratedSecurity = true;
			reportDocument.Refresh();

			reportDocument.SetParameterValue("Id", 1);
			viewer.ViewerCore.ReportSource = reportDocument;
		}
	}
}
