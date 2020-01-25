using System.Windows;

namespace WpfWebScraper
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Scraper scraper;
        public MainWindow()
        {
            InitializeComponent();
            scraper = new Scraper();
            DataContext = scraper;

        }

        private void BtnScraper_Click(object sender, RoutedEventArgs e)
        {
            scraper.ScrapeData(TbPage.Text);

        }

        private void ItemExport_Click(object sender, RoutedEventArgs e)
        {
            scraper.Export();
        }
    }
}
