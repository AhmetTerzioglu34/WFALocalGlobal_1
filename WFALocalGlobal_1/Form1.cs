using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFALocalGlobal_1
{


    public partial class Form1 : Form
    {


        #region LocalAreaNotlari

        //Local alan  (Local Area) su anda bu yorum satırlarını yazdıgımız yerin (Form1 yasam alanının) icerisinde yer alan ekstra scope'tur(Scope,block, yaşam alanı eş anlamlı kullanılır...)

        //Local alanın bir dısında kalan alan da global alandır...


        //Siz kontrollerinize sadece ve sadece local alanlardan ulasabilirsiniz... Local alan dısında karsınıza cıkan turkuaz renkli kontrol ismi sakın kafanızı karıstırmasın...Onlar sistemde gömülü olan orijinal yapılardır...


        //Her local alanınız bir event degildir...

        //Local alan kendi dısarısından asla görülmez...Local alanda olan her şey sadece local alanda kalır...Dolayısıyla bir local alanda olusturulan degişken ismi baska bir local alanda da olusturulabilir... 

        //Local alanları kendi iclerini göstermeyen ama bir dıslarını görebilen alanlar olarak düsünün...

        //Local alan istisnasız her zaman önceligi kendisine verir...Global alanda olusturulmus bir degişken ile aynı isimde bir degişken local alanda tanımlanıyorsa local alan kendi degişkenini tanır... Local alanın icerisinde tanımlanan kendi degişkeninin yanında global alandaki aynı isimde olan degişkene de ulasmak istiyorsanız this keyword'unu kullanmanız gerekir...




        #endregion

        

        public Form1()
        {
            InitializeComponent();
            
        }



        int a = 1;

        

       

        
        
        
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void btnDeneme_Click(object sender, EventArgs e)
        {
            //Garbage Collector


            

            int a = 2; //normalde burada yine a isimli degişken tanımlandıgı icin artık bu local alan normal şartlar altında global'deki a'yı göremez..

            //this.a; => böyle diyerek global alandaki a'ya ulasabilirsiniz...


            a++;
            MessageBox.Show(a++.ToString()); //cıktı 3
            MessageBox.Show(a.ToString()); //cıktı 4

        }

        private void btnAzalt_Click(object sender, EventArgs e)
        {
            a--;
            MessageBox.Show(a.ToString());
        }
    }
}
