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

namespace OrderMgmt
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Random random = new Random();

        #region Data
        private Tuple<string, string>[] orders = new Tuple<string, string>[] {
            Tuple.Create("IOZ-3332-IJ", "Merry Eustace"),
            Tuple.Create("AHU-2043-HW", "Jayson Andrew"),
            Tuple.Create("NDY-3401-PD", "Lexie Owen"),
            Tuple.Create("ZAI-5178-GN", "Norah Lucia"),
            Tuple.Create("TZF-9509-UJ", "Tilly Lysette"),
            Tuple.Create("IUI-5416-GR", "Kaitlyn Andrina"),
            Tuple.Create("OPD-5440-TU", "Brittany Lori"),
            Tuple.Create("MDM-6582-NF", "Brett Julianna"),
            Tuple.Create("OLS-6283-OT", "Miquel Henrietta"),
            Tuple.Create("IFY-5526-NX", "Jannah Kody"),
            Tuple.Create("NKH-4232-TS", "Garret Ashleigh"),
            Tuple.Create("OJY-1052-TN", "Alishia Barbie"),
            Tuple.Create("SQR-7914-IK", "Enola Josceline"),
            Tuple.Create("LYC-2392-TR", "Kerr Cassarah"),
            Tuple.Create("QXG-9566-SN", "Dutch Valerie"),
            Tuple.Create("DQB-5485-YL", "Wenda Unice"),
            Tuple.Create("RKA-9420-JH", "Jenn Brittney"),
            Tuple.Create("MBM-3200-KE", "Gail Gwilherm"),
            Tuple.Create("KKS-7062-PC", "Cade Garfield"),
            Tuple.Create("OHC-8369-GY", "Thom River"),
            Tuple.Create("MPX-2917-CY", "Kian Otto"),
            Tuple.Create("UNR-9513-NM", "Shaye Kristel"),
            Tuple.Create("RMM-5947-LG", "Wilton Laurelle"),
            Tuple.Create("UVM-4476-AY", "Kade Tamzen"),
            Tuple.Create("VDY-8897-EL", "Graeme Zackery"),
            Tuple.Create("BWF-6353-ZQ", "Starr Lyall"),
            Tuple.Create("CXP-5546-DZ", "Sid Shelby"),
            Tuple.Create("NAR-7373-OR", "Sofia Quinten"),
            Tuple.Create("SCE-8143-ZO", "Pru Roxy"),
            Tuple.Create("IXQ-8202-JE", "Grahame Clemence"),
            Tuple.Create("OZQ-1244-YB", "Velda Evangelina"),
            Tuple.Create("KDI-5731-TQ", "Brenda Freddie"),
            Tuple.Create("NKS-1312-EJ", "Wilfrid Albin"),
            Tuple.Create("LGQ-1148-FE", "Raylene Amos"),
            Tuple.Create("UST-9682-WZ", "Lise Janele"),
            Tuple.Create("QFH-5747-TV", "Rene Shelby"),
            Tuple.Create("DJH-1725-OP", "Leyla Flossie"),
            Tuple.Create("OLD-5064-HE", "Addison Inez"),
            Tuple.Create("RIJ-7455-ZI", "Addy Sara"),
            Tuple.Create("HEQ-8834-IS", "Mandy Eva"),
            Tuple.Create("UNE-6380-PC", "Merry Eustace"),
            Tuple.Create("QUO-3894-WR", "Jayson Andrew"),
            Tuple.Create("EZI-9622-HL", "Lexie Owen"),
            Tuple.Create("VDZ-3061-CQ", "Norah Lucia"),
            Tuple.Create("CKW-1260-KW", "Tilly Lysette"),
            Tuple.Create("PGX-6520-VE", "Kaitlyn Andrina"),
            Tuple.Create("MVW-8502-AF", "Brittany Lori"),
            Tuple.Create("MEX-3961-ZM", "Brett Julianna"),
            Tuple.Create("TZP-8148-OV", "Miquel Henrietta"),
            Tuple.Create("EAU-2921-NK", "Jannah Kody"),
            Tuple.Create("RIM-7321-VZ", "Garret Ashleigh"),
            Tuple.Create("HXF-8143-YR", "Alishia Barbie"),
            Tuple.Create("DKB-2424-BT", "Enola Josceline"),
            Tuple.Create("ATR-5489-YE", "Kerr Cassarah"),
            Tuple.Create("MRJ-9025-ET", "Dutch Valerie"),
            Tuple.Create("KCO-7337-SE", "Wenda Unice"),
            Tuple.Create("CYW-6552-ND", "Jenn Brittney"),
            Tuple.Create("DFD-7736-WN", "Gail Gwilherm"),
            Tuple.Create("JAG-6329-IY", "Cade Garfield"),
            Tuple.Create("NNX-6459-FP", "Thom River"),
            Tuple.Create("TRM-2833-AT", "Kian Otto"),
            Tuple.Create("GKI-3423-YZ", "Shaye Kristel"),
            Tuple.Create("XJN-4697-BB", "Wilton Laurelle"),
            Tuple.Create("HGL-3482-DW", "Kade Tamzen"),
            Tuple.Create("XVA-8864-YC", "Graeme Zackery"),
            Tuple.Create("HJM-8055-QO", "Starr Lyall"),
            Tuple.Create("BZT-5671-DW", "Sid Shelby"),
            Tuple.Create("DLL-8403-PL", "Sofia Quinten"),
            Tuple.Create("AUN-2873-TD", "Pru Roxy"),
            Tuple.Create("KNF-2410-ZA", "Grahame Clemence"),
            Tuple.Create("GHL-7663-ME", "Velda Evangelina"),
            Tuple.Create("CLM-2372-BD", "Brenda Freddie"),
            Tuple.Create("AJX-4532-KF", "Wilfrid Albin"),
            Tuple.Create("EGZ-6349-AH", "Raylene Amos"),
            Tuple.Create("VXG-5801-SZ", "Lise Janele"),
            Tuple.Create("UEL-4127-FH", "Rene Shelby"),
            Tuple.Create("AGJ-4670-FX", "Leyla Flossie"),
            Tuple.Create("QTL-3473-TB", "Addison Inez"),
            Tuple.Create("RGW-9770-TH", "Addy Sara"),
            Tuple.Create("QYM-5844-WD", "Mandy Eva")};
        #endregion

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Initialized(object sender, EventArgs e)
        {
            lbOrders.ItemsSource = this.orders;
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            string criterion = txtFilter.Text.ToUpper();
            lbOrders.ItemsSource = this.orders.Where(o => (o.Item1.IndexOf(criterion) >= 0 || o.Item2.ToUpper().IndexOf(criterion) >= 0));
        }

        private void LbOrders_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Tuple<string, string> selectedItem = (Tuple<string, string>)lbOrders.SelectedItem;
            if (selectedItem != null)
            {
                double monthly = random.Next(12486, 42156) / 100;
                lbOrderDetails.ItemsSource = new string[] {
                    string.Format("Order # {0}", selectedItem.Item1),
                    "",
                    "                              Details:",
                    "",
                    string.Format("{0}", selectedItem.Item2),
                    string.Format("Monthly Payment: ${0:#.00}", monthly),
                    string.Format("YoY Value: ${0}", monthly / 100 * 23)
                };
            } else
            {
                lbOrderDetails.ItemsSource = new string[] { };
            }
        }
    }
}
