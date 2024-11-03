using deneme_class_v1;

namespace DiktorgenHesabı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Ogrenci ogr1 = new Ogrenci();
            Ogrenci ogr2 = new Ogrenci();
            ogr1.Ad = "Mustafa";
            ogr1.Soyad = "YILMAZ";
            ogr1.OgrenciNo = 12345678;
            ogr1.Bolum = "ENM";
            ogr1.Sinif = 1;
            ogr1.AdYaz();
            ogr2.Ad = "Yunus";
            ogr2.Soyad = "Demir";
            ogr2.OgrenciNo = 1235874;
            ogr2.Bolum = "ENM-YL";
            ogr2.AdYaz();
            ogr1.AdYaz();
        }

    }
}