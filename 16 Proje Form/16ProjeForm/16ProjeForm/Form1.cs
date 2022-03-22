using System;
using System.Windows.Forms;

namespace _16ProjeForm
{


    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


       
       


        /////  METOTLAR ///////////


        #region Tek mi Çift mi Metot (Void)
        public void TekÇift(int a)
        {

            // int sonuc = 0;
            // int a = 0;
            if (a % 2 == 0)
            {

                label7.Text = (a).ToString();

            }
            else
            {

                label9.Text = (a).ToString();


            }


            // textBox3.Text = "";
        }
        #endregion         

        #region 20 Sayıdan Kaç Negatif Kaç Pozitif Metod (Void)
        void NegPof(int sayi5)
        {


            listBox2.Items.Add(sayi5);
            textBox5.Text = "";
            sayac++;

            if (sayac <= 5)
            {
                if (sayi5 < 0)
                {
                    Nsayi++;



                }
                else
                {
                    Psayi++;

                }
                label16.Text = Nsayi.ToString();
                label17.Text = Psayi.ToString();

            }

            else
            {

                textBox5.Visible = false;

                //Console.WriteLine("{0} Tane Negatif Sayı Var", Nsayi);
                //Console.WriteLine("{0} Tane Pazitif Sayı Var", Psayi);



            }
        }

        #endregion

        #region 0 Girilene Kadar Sayıların Toplamı Metot (Void)
        int topla99 = 0;
        void sıfırgir(int sayi6)
        {


            //  sayi6 = Convert.ToInt32(textBox6.Text);

            //  textBox6.Text = "";
            if (sayi6 == 0)
            {
                //Console.WriteLine("Başarılı Toplam sayı{0}", topla);

                label20.Text = topla99.ToString();

            }
            else
            {
                topla99 = topla99 + sayi6;


            }





        }

        #endregion

        #region 20 Sayının Tek Kare Küp Küpü Metot (Void-Ref)
        int sayac22 = 0;

        public void KareKup(int sayi7, ref int Tsayi)
        {

            int Csayi = 0;
             Tsayi = 0;



            if (sayi7 % 2 == 0)
            {
                Csayi += sayi7 * sayi7;
                label25.Text = (Csayi).ToString();

                // CsayıT += toplam4 + Csayi;
            }
            else
            {
                Tsayi += sayi7 * sayi7 * sayi7;




                label24.Text = (Tsayi).ToString();


                // TsayıT += toplam4 + sayi7;
            }




        }
        #endregion

        #region Üniversite Otomasyonu Metot (Void)

        int toplam5 = 0;
        int sayac91 = 0;
        public void Universite(int vize4, int final3)
        {

            vize4 = (vize4 * 40) / 100;
            final3 = (final3 * 60) / 100;
            toplam5 = vize4 + final3;
            label36.Text = toplam5.ToString();

            if (toplam5 >= 50)
            {
                //label36.Text = toplam5.ToString();
                label37.Text = "Dersten Geçtiniz";

            }
            else if (toplam5 < 50)
            {
                int but = 0;
                label37.Text = "Bütünlemeye Kaldınız";
                textBox9.Visible = true;
                label30.Visible = true;

                if (sayac91 > 0)
                {
                    label37.Text = "Bütünleme Notunu Giriniz";
                    label37.Text = "";
                    but = Convert.ToInt32(textBox9.Text);
                    textBox9.Text = but.ToString();
                    textBox9.Visible = true;

                    if (but > 50)
                    {
                        label37.Text = "Dersten Geçtiniz";

                    }
                    else
                    {
                        label37.Text = "Bütünlemeden Kaldınız";

                    }
                }


                sayac91++;
            }

        }




        #endregion

        #region 10 Öğrenci Dönem Sonu Ort Metot (Void)
        int sayac98 = 1;
        float OnOgrOrt(float val5 = 0f, float val6 = 0f)


        {
         

            float toplam6 = 0f, ort1 = 0f;
            float sonuc = 0f;
            if (sayac98 < 11)
            {
                ort1 = (val5 + val6) / 2;
                toplam6 = ort1 + toplam6;

                sonuc = toplam6 / 5;
                listBox5.Items.Add(sayac98 + "//" + ort1);
                sayac98++;
            }
            return sonuc;

        }

        #endregion

        #region Çarpım Tablosu (Void)
        public void CarpımT(int a)
        {
            for (int ii = 1; ii <= 10; ii++)
            {
                for (int iii = 1; iii <= 10; iii++)
                {
                    listBox6.Items.Add(ii + "+" + iii + "=" + ii * iii);
                }
                listBox6.Items.Add("");
            }
        }
        #endregion

        #region Girilen Sayı Kaç Basamaklı (Dinamik)
        int sayacbasamak = 0;
           public int hesapla(int sayi)
            {
                while (sayi > 0)
                {
                    sayi /= 10;
                    sayacbasamak++;
                }
                return sayacbasamak;
            }

        #endregion

        #region Mağazadan belli sayıda ürün alımlarında indirim (Void - Out)

        public void  Magazaİnd(int sayi12, out int toplam)
        {
             toplam = 0;
            

            toplam = toplam + sayi12;
            if (toplam < 3)
            {
                label54.Text = "İndirim Bulunamamaktadır";
             
                
            }
            else
            {
                label54.Text = " %50 indirim bulunmaktadır";

               

            }
         
        }
        #endregion

        #region KDV HESAPLAMA (Dinamik)
        public  int KDVH( int fiyat1,string islemtipi )
        {      
            switch (islemtipi)
            {
                case "1":
                    kdvfiyat = (fiyat1 * 10) / 100;
                    break;
                case "2":
                    kdvfiyat = (fiyat1 * 20) / 100;
                    break;
                case "3":
                    kdvfiyat = (fiyat1 * 30) / 100;
                    break;
            }
       
            return kdvfiyat;
        }


        #endregion

        #region 10 Sayıdan En Küçüğünü bulma (Dinamik)
        int kucuk2 = 0, sayac111 = 1;
        public  int OnSayıEn(int sayi15)
        {
        
            if (sayac111 <= 5)
            {     
                if (sayac111 == 1)
                {
                    kucuk2 = sayi15;

                }
                else if (sayi15 < kucuk2)
                {
                    kucuk2 = sayi15;

                }
                sayac111++;
            }

            return kucuk2;

        }

        #endregion

        #region Mükemmel Sayı (Void)
        public void  Mukemmel(int sayi)
        {
            //mükemmel sayı
            int toplam = 0;
           
         
            for (int i = 1; i < sayi; i++)
            {
                if (sayi % i == 0)
                {
                    toplam += i;
                }
            }
            if (toplam == sayi)
            {
                label59.Text = "Mükemmel Sayı";
             
            }
            else
            {
                label59.Text = "Mükemmel Sayı Değildir";

              

            }
        }


        #endregion






        ///// RADİOBUTTON //////////

        #region Kullanılan RadioButton lar 
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            groupBox18.Visible = true;
            groupBox7.Visible = false;
            groupBox3.Visible = false;
            groupBox4.Visible = false;
            groupBox15.Visible = false;
            groupBox16.Visible = false;
            groupBox9.Visible = false;
            groupBox17.Visible = false;
            groupBox14.Visible = false;
            groupBox5.Visible = false;
            groupBox13.Visible = false;
            groupBox6.Visible = false;
            groupBox8.Visible = false;
            groupBox10.Visible = false;
            groupBox11.Visible = false;
            groupBox12.Visible = false;
            groupBox2.Visible = false;





            textBox1.Select();




        }
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            groupBox3.Visible = true;
            groupBox7.Visible = false;
            groupBox14.Visible = false;
            groupBox18.Visible = false;
            groupBox16.Visible = false;
            groupBox15.Visible = false;
            groupBox17.Visible = false;
            groupBox9.Visible = false;
            groupBox13.Visible = false;
            groupBox4.Visible = false;
            groupBox5.Visible = false;
            groupBox6.Visible = false;
            groupBox8.Visible = false;
            groupBox10.Visible = false;
            groupBox11.Visible = false;
            groupBox12.Visible = false;
            groupBox2.Visible = false;








        }
        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            groupBox4.Visible = true;
            groupBox7.Visible = false;
            groupBox3.Visible = false;
            groupBox14.Visible = false;
            groupBox17.Visible = false;
            groupBox16.Visible = false;
            groupBox9.Visible = false;
            groupBox15.Visible = false;
            groupBox18.Visible = false;
            groupBox13.Visible = false;
            groupBox5.Visible = false;
            groupBox6.Visible = false;
            groupBox8.Visible = false;
            groupBox10.Visible = false;
            groupBox11.Visible = false;
            groupBox12.Visible = false;
            groupBox2.Visible = false;







        }
        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            groupBox5.Visible = true;
            groupBox7.Visible = false;
            groupBox4.Visible = false;
            groupBox15.Visible = false;
            groupBox17.Visible = false;
            groupBox9.Visible = false;
            groupBox16.Visible = false;
            groupBox14.Visible = false;
            groupBox3.Visible = false;
            groupBox18.Visible = false;
            groupBox6.Visible = false;
            groupBox13.Visible = false;
            groupBox8.Visible = false;
            groupBox10.Visible = false;
            groupBox11.Visible = false;
            groupBox12.Visible = false;
            groupBox2.Visible = false;






        }
        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            groupBox6.Visible = true;
            groupBox5.Visible = false;
            groupBox4.Visible = false;
            groupBox16.Visible = false;
            groupBox9.Visible = false;
            groupBox3.Visible = false;
            groupBox17.Visible = false;
            groupBox15.Visible = false;
            groupBox14.Visible = false;
            groupBox18.Visible = false;
            groupBox7.Visible = false;
            groupBox13.Visible = false;
            groupBox8.Visible = false;
            groupBox10.Visible = false;
            groupBox11.Visible = false;
            groupBox12.Visible = false;
            groupBox2.Visible = false;






        }
        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            groupBox7.Visible = true;
            groupBox6.Visible = false;
            groupBox16.Visible = false;
            groupBox9.Visible = false;
            groupBox5.Visible = false;
            groupBox17.Visible = false;
            groupBox4.Visible = false;
            groupBox15.Visible = false;
            groupBox14.Visible = false;
            groupBox3.Visible = false;
            groupBox13.Visible = false;
            groupBox18.Visible = false;
            groupBox8.Visible = false;
            groupBox10.Visible = false;
            groupBox11.Visible = false;
            groupBox12.Visible = false;
            groupBox2.Visible = false;






        }
        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            groupBox8.Visible = true;
            groupBox7.Visible = false;
            groupBox17.Visible = false;
            groupBox9.Visible = false;
            groupBox6.Visible = false;
            groupBox5.Visible = false;
            groupBox16.Visible = false;
            groupBox15.Visible = false;
            groupBox4.Visible = false;
            groupBox14.Visible = false;
            groupBox13.Visible = false;
            groupBox3.Visible = false;
            groupBox18.Visible = false;
            groupBox10.Visible = false;
            groupBox11.Visible = false;
            groupBox2.Visible = false;
            groupBox12.Visible = false;



        }
        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {
            groupBox10.Visible = true;
            groupBox8.Visible = false;
            groupBox17.Visible = false;
            groupBox7.Visible = false;
            groupBox6.Visible = false;
            groupBox9.Visible = false;
            groupBox16.Visible = false;
            groupBox5.Visible = false;
            groupBox15.Visible = false;
            groupBox14.Visible = false;
            groupBox4.Visible = false;
            groupBox13.Visible = false;
            groupBox3.Visible = false;
            groupBox18.Visible = false;
            groupBox11.Visible = false;
            groupBox2.Visible = false;
            groupBox12.Visible = false;


        }
        private void radioButton9_CheckedChanged(object sender, EventArgs e)
        {
            groupBox11.Visible = true;
            groupBox10.Visible = false;
            groupBox8.Visible = false;
            groupBox14.Visible = false;
            groupBox16.Visible = false;
            groupBox17.Visible = false;
            groupBox9.Visible = false;
            groupBox7.Visible = false;
            groupBox15.Visible = false;
            groupBox6.Visible = false;
            groupBox5.Visible = false;
            groupBox13.Visible = false;
            groupBox4.Visible = false;
            groupBox3.Visible = false;
            groupBox18.Visible = false;
            groupBox12.Visible = false;
            groupBox2.Visible = false;


        }
        private void radioButton10_CheckedChanged(object sender, EventArgs e)
        {
            groupBox12.Visible = true;
            groupBox11.Visible = false;
            groupBox10.Visible = false;
            groupBox8.Visible = false;
            groupBox17.Visible = false;
            groupBox16.Visible = false;
            groupBox9.Visible = false;
            groupBox7.Visible = false;
            groupBox6.Visible = false;
            groupBox15.Visible = false;
            groupBox5.Visible = false;
            groupBox4.Visible = false;
            groupBox3.Visible = false;
            groupBox18.Visible = false;
            groupBox13.Visible = false;
            groupBox14.Visible = false;
            groupBox2.Visible = false;



        }
        private void radioButton11_CheckedChanged(object sender, EventArgs e)
        {
            groupBox13.Visible = true;
            groupBox12.Visible = false;
            groupBox11.Visible = false;
            groupBox16.Visible = false;
            groupBox17.Visible = false;
            groupBox10.Visible = false;
            groupBox9.Visible = false;
            groupBox8.Visible = false;
            groupBox7.Visible = false;
            groupBox6.Visible = false;
            groupBox5.Visible = false;
            groupBox15.Visible = false;
            groupBox4.Visible = false;
            groupBox3.Visible = false;
            groupBox18.Visible = false;
            groupBox14.Visible = false;
            groupBox2.Visible = false;


        }
        private void radioButton12_CheckedChanged(object sender, EventArgs e)
        {
            groupBox14.Visible = true;
            groupBox13.Visible = false;
            groupBox12.Visible = false;
            groupBox16.Visible = false;
            groupBox11.Visible = false;
            groupBox17.Visible = false;
            groupBox10.Visible = false;
            groupBox9.Visible = false;
            groupBox8.Visible = false;
            groupBox7.Visible = false;
            groupBox6.Visible = false;
            groupBox5.Visible = false;
            groupBox4.Visible = false;
            groupBox3.Visible = false;
            groupBox18.Visible = false;
            groupBox15.Visible = false;
            groupBox2.Visible = false;


        }
        private void radioButton13_CheckedChanged(object sender, EventArgs e)
        {
            groupBox15.Visible = true;
            groupBox16.Visible = false;
            groupBox14.Visible = false;
            groupBox13.Visible = false;
            groupBox12.Visible = false;
            groupBox11.Visible = false;
            groupBox17.Visible = false;
            groupBox10.Visible = false;
            groupBox9.Visible = false;
            groupBox8.Visible = false;
            groupBox7.Visible = false;
            groupBox6.Visible = false;
            groupBox5.Visible = false;
            groupBox4.Visible = false;
            groupBox3.Visible = false;
            groupBox18.Visible = false;
            groupBox2.Visible = false;

        }
        private void radioButton14_CheckedChanged(object sender, EventArgs e)
        {
            groupBox16.Visible = true;
            groupBox15.Visible = false;
            groupBox14.Visible = false;
            groupBox13.Visible = false;
            groupBox17.Visible = false;
            groupBox12.Visible = false;
            groupBox11.Visible = false;
            groupBox10.Visible = false;
            groupBox8.Visible = false;
            groupBox7.Visible = false;
            groupBox6.Visible = false;
            groupBox5.Visible = false;
            groupBox4.Visible = false;
            groupBox3.Visible = false;
            groupBox18.Visible = false;
            groupBox9.Visible = false;
            groupBox2.Visible = false;


        }
        private void radioButton15_CheckedChanged(object sender, EventArgs e)
        {
            groupBox9.Visible = true;
            groupBox17.Visible = false;
            groupBox16.Visible = false;
            groupBox15.Visible = false;
            groupBox14.Visible = false;
            groupBox13.Visible = false;
            groupBox12.Visible = false;
            groupBox11.Visible = false;
            groupBox10.Visible = false;
            groupBox8.Visible = false;
            groupBox7.Visible = false;
            groupBox6.Visible = false;
            groupBox5.Visible = false;
            groupBox4.Visible = false;
            groupBox3.Visible = false;
            groupBox18.Visible = false;
            groupBox2.Visible = false;

        }
        private void radioButton16_CheckedChanged(object sender, EventArgs e)
        {
            groupBox17.Visible = true;
            groupBox9.Visible = false;
            groupBox16.Visible = false;
            groupBox15.Visible = false;
            groupBox14.Visible = false;
            groupBox13.Visible = false;
            groupBox12.Visible = false;
            groupBox11.Visible = false;
            groupBox10.Visible = false;
            groupBox8.Visible = false;
            groupBox7.Visible = false;
            groupBox6.Visible = false;
            groupBox5.Visible = false;
            groupBox4.Visible = false;
            groupBox3.Visible = false;
            groupBox18.Visible = false;
            groupBox2.Visible = false;

        }
        private void radioButton17_CheckedChanged(object sender, EventArgs e)
        {
            //NORMAL 
            groupBox17.Visible = true;
            groupBox9.Visible = true;
            groupBox16.Visible = true;
            groupBox15.Visible = true;
            groupBox14.Visible = true;
            groupBox13.Visible = true;
            groupBox12.Visible = true;
            groupBox11.Visible = true;
            groupBox10.Visible = true;
            groupBox8.Visible = true;
            groupBox7.Visible = true;
            groupBox6.Visible = true;
            groupBox5.Visible = true;
            groupBox4.Visible = true;
            groupBox3.Visible = true;
            groupBox18.Visible = true;
            groupBox2.Visible = false;

            radioButton10.Visible = true;
            radioButton1.Visible = true;
            radioButton2.Visible = true;
            radioButton3.Visible = true;
            radioButton4.Visible = true;
            radioButton5.Visible = true;
            radioButton6.Visible = true;
            radioButton7.Visible = true;
            radioButton8.Visible = true;
            radioButton9.Visible = true;
            radioButton11.Visible = true;
            radioButton12.Visible = true;
            radioButton13.Visible = true;
            radioButton14.Visible = true;
            radioButton15.Visible = true;
            radioButton16.Visible = true;
            radioButton14.Visible = true;
           






        }
        private void radioBtnMTT_CheckedChanged(object sender, EventArgs e)
        {
            groupBox17.Visible = true;
            groupBox9.Visible = true;
            groupBox16.Visible = true;
            groupBox15.Visible = true;
            groupBox14.Visible = true;
            groupBox13.Visible = true;
            groupBox12.Visible = true;
            groupBox11.Visible = true;
            groupBox10.Visible = true;
            groupBox8.Visible = true;
            groupBox7.Visible = true;
            groupBox6.Visible = true;
            groupBox5.Visible = true;
            groupBox4.Visible = true;
            groupBox3.Visible = true;
            groupBox18.Visible = true;



            radioButton1.Visible = true;
            radioButton2.Visible = true;
            radioButton3.Visible = true;
            radioButton4.Visible = true;
            radioButton5.Visible = true;
            radioButton6.Visible = true;
            radioButton7.Visible = true;
            radioButton8.Visible = true;
            radioButton9.Visible = true;
            radioButton10.Visible = true;
            radioButton11.Visible = true;
            radioButton12.Visible = true;
            radioButton13.Visible = true;
            radioButton14.Visible = true;
            radioButton15.Visible = true;
            radioButton16.Visible = true;
            radioButton14.Visible = true;

            //RB2SayıKıyas.Visible = true;
            //RBTekÇiftM.Visible = true;
            //RBGirilen100.Visible = true;
            //RBNegPof.Visible = true;
            //RB0Gir.Visible = true;
            //RBTekKüp.Visible = true;
            //RBÜniNot.Visible = true;
            //RBHesapM.Visible = true;
            //RB10ÖgrOrt.Visible = true;
        }
        #endregion




        ////////// UYGULAMALAR ///////////

        #region 2 Sayı Kıyaslama
        private void button17_Click(object sender, EventArgs e)
        {
            if (radioBtnNOR.Checked)
            {
                if (radioButton1.Checked) // NORMAL UYGULAMA
                {
                    int sayi = 0, sayi2 = 0;

                    sayi = Convert.ToInt32(textBox19.Text);
                    sayi2 = Convert.ToInt32(textBox20.Text);

                    if (sayi < sayi2)
                    {
                        //label4.Text = sayi.ToString();
                        label64.Text = sayi.ToString();
                    }
                    else if (sayi2 < sayi)
                    {
                        //label4.Text = sayi2.ToString();
                        label64.Text = sayi2.ToString();

                    }
                    else
                    {
                        label64.Text = "Sayılar Eşit";
                    }
                }


            }
            if (radioBtnMTT.Checked)
            {
                if (radioButton1.Checked) // METOT UYGULAMA
                {
                    int sayi1 = Convert.ToInt32(textBox20.Text);
                    int sayi2 = Convert.ToInt32(textBox19.Text);
                    // Metotlar nesne = new Metotlar();
                    label64.Text = Metotlar.Kıyasla(sayi1, sayi2).ToString();
                  
                    
                }
            }
           
        }
        #endregion

        #region Tek mi Çift mi
        private void button2_Click(object sender, EventArgs e)
        {
            //Tek mi Çift mi
            if (radioBtnNOR.Checked)
            {
                if (radioButton2.Checked) // NORMAL UYGULAMA
                {
                    int val;
                    if (!Int32.TryParse(textBox3.Text, out val))
                    {
                        MessageBox.Show("Lütfen Sayı giriniz");
                        textBox3.Select();
                        // sayı1txt.BackColor = Color.Red;
                        return;
                    }
                    else
                    {
                        // tek mi çift mi
                        int a = 0;

                        a = int.Parse(textBox3.Text);
                        textBox3.Text = "";


                        if (a % 2 == 0)
                        {
                            label7.Text = a.ToString();
                        }
                        else
                        {
                            label9.Text = a.ToString();


                        }
                        textBox3.Text = "";
                    }
                }
            }
            else if (radioBtnMTT.Checked)
            {
                int a = Convert.ToInt32(textBox3.Text);
            

                if (radioButton2.Checked == true)
                {

                    // METOT UYGULAMA

                    //Metotlar.TekÇift(a);
                    TekÇift(a);


                }

            }





        }
        #endregion

        #region Girilen 10 Sayının Toplamı
        int sayi3 = 0;
        int sayac3 = 1;
        int toplam3 = 0;
        int sayac44 = 0;
        Metotlar nesne = new Metotlar();
        private void button3_Click(object sender, EventArgs e)
        {
            

            if (radioBtnNOR.Checked) // NORMAL UYGULAMA
            {
                if (radioButton3.Checked)
                {
                    int val;
                    if (!Int32.TryParse(textBox4.Text, out val))
                    {
                        MessageBox.Show("Lütfen Sayı Giriniz");
                        textBox4.Select();
                        // textBox1.BackColor = Color.Red;
                        return;
                    }
                    else
                    {
                        // Girilen 10 sayının toplamı


                        sayi3 = int.Parse(textBox4.Text);
                        textBox4.Text = "";


                        if (sayac3 < 6)
                        {
                            // listBox1.Text = sayi.ToString();
                            //textBox4.Text = "";
                            listBox1.Items.Add(sayi3);

                            toplam3 = toplam3 + sayi3;
                            label12.Text = toplam3.ToString();
                            sayac3++;
                        }
                        else
                        {
                            textBox4.Visible = false;
                            button3.Visible = false;
                        }


                    }
                }

            }
            else

            {
                if (radioBtnMTT.Checked) // METOT UYGULAMA
                {
                    if (radioButton3.Checked)
                    {
                        if (sayac44<5)
                        {
                            int sayi3 = int.Parse(textBox4.Text);

                            listBox1.Items.Add(sayi3);
                            sayac44++;
                            label12.Text = nesne.sayıtop(sayi3).ToString();

                        }
                        



                    }

                }

            }




        }
        #endregion

        #region 20 Sayıdan kaçı Negatif Pozitif
        int sayi5 = 0;
        int Nsayi = 0;
        int Psayi = 0;
        int sayac = 0;
        private void button4_Click(object sender, EventArgs e)
        {
            if (radioBtnNOR.Checked)
            {
                if (radioButton4.Checked) // NORMAL UYGULAMA 
                {
                    int val;
                    if (!Int32.TryParse(textBox5.Text, out val))
                    {
                        MessageBox.Show("Lütfen Sayı Giriniz");
                        textBox5.Select();
                        // textBox1.BackColor = Color.Red;
                        return;
                    }
                    else
                    {
                        //20 sayıdan kaç tanesi negatif pozitif


                        sayi5 = int.Parse(textBox5.Text);

                        listBox2.Items.Add(sayi5);
                        textBox5.Text = "";
                        sayac++;

                        if (sayac <= 5)
                        {
                            if (sayi5 < 0)
                            {
                                Nsayi++;



                            }
                            else
                            {
                                Psayi++;

                            }
                            label16.Text = Nsayi.ToString();
                            label17.Text = Psayi.ToString();

                        }

                        else
                        {

                            textBox5.Visible = false;

                            //Console.WriteLine("{0} Tane Negatif Sayı Var", Nsayi);
                            //Console.WriteLine("{0} Tane Pazitif Sayı Var", Psayi);



                        }

                    }
                }

            }
            else if (radioBtnMTT.Checked)
            {

                if (radioButton4.Checked) // UYGULAMA METOT
                {
                    sayi5 = int.Parse(textBox5.Text);
                    NegPof(sayi5);
                }
            }



        }
        #endregion

        #region 0 Girilene Kadar Sayıların Toplamı
        int sayi6 = 0;
        int topla1 = 0;
        private void button5_Click(object sender, EventArgs e)
        {
            if (radioBtnNOR.Checked) //UYGULAMA NORMAL
            {
                if (radioButton5.Checked)
                {
                    int val;
                    if (!Int32.TryParse(textBox6.Text, out val))
                    {
                        MessageBox.Show("Lütfen Sayı Giriniz");
                        textBox6.Select();
                        // textBox1.BackColor = Color.Red;
                        return;
                    }
                    else
                    {
                        //0 girilene kadar sayıların toplamı



                        sayi6 = Convert.ToInt32(textBox6.Text);
                        listBox3.Items.Add(sayi6);
                        textBox6.Text = "";


                        if (sayi6 == 0)
                        {
                            //Console.WriteLine("Başarılı Toplam sayı{0}", topla);

                            label20.Text = topla1.ToString();

                        }
                        else
                        {
                            topla1 = topla1 + sayi6;


                        }
                    }
                }
            }
            else if (radioBtnMTT.Checked) // UYGULAMA METOT
            {
                if (radioButton5.Checked)
                {

                    sayi6 = Convert.ToInt32(textBox6.Text);
                    listBox3.Items.Add(sayi6);
                    sıfırgir(sayi6);










                }

            }





        }
        #endregion

        #region 20 sayıdan teklerin kareleri çiftlerin küpleri toplam
        int toplam4 = 0;
        int Tsayi = 0;
        int Csayi = 0;
        int sayac2 = 1;
        int CsayıT = 0;
        int TsayıT = 0;
        int sayi7 = 0;
        private void button6_Click(object sender, EventArgs e)
        {
            if (radioBtnNOR.Checked) // UYGULAMA NORMAL
            {
                if (radioButton6.Checked)
                {
                    int val;
                    if (!Int32.TryParse(textBox7.Text, out val))
                    {
                        MessageBox.Show("Lütfen Sayı Giriniz");
                        textBox7.Select();
                        // textBox1.BackColor = Color.Red;
                        return;
                    }
                    else
                    {
                        //20 sayıdan teklerin kareleri çiftlerin küpleri toplam


                        sayi7 = int.Parse(textBox7.Text);
                        listBox4.Items.Add(sayi7);
                        textBox7.Text = "";


                        sayac2++;

                        if (sayac2 < 6)
                        {

                            if (sayi7 % 2 == 0)
                            {
                                Csayi += sayi7 * sayi7;
                                // CsayıT += toplam4 + Csayi;
                            }
                            else
                            {
                                Tsayi += sayi7 * sayi7 * sayi7;




                                // TsayıT += toplam4 + sayi7;
                            }

                        }
                        else if (sayac2 == 6)
                        {
                            textBox7.Visible = false;
                            button6.Visible = false;
                        }




                        label25.Text = Csayi.ToString();
                        label24.Text = Tsayi.ToString();





                    }
                }
            }
            if (radioBtnMTT.Checked)
            {
                if (radioButton6.Checked) //UYGULAMA METOT
                {
                    if (sayac22 < 6)
                    {
                        int tsayi = 10;

                        sayi7 = int.Parse(textBox7.Text);
                        listBox4.Items.Add(sayi7);
                        KareKup(sayi7,ref tsayi);
                        sayac22++;
                    }
                    //textBox7.Text = "";


                }
            }
        }
        #endregion

        #region Üniversite Otomasyanu
        int sayac8 = 0;
        private void button7_Click(object sender, EventArgs e)
        {
            //Üniversite Otomasyonu
            if (radioBtnNOR.Checked)
            {
                if (radioButton7.Checked) //UYGULAA NORMAL
                {
                    int toplam5 = 0;

                    int vize4 = Convert.ToInt32(textBox8.Text);
                    textBox8.Text = vize4.ToString();
                    int final3 = Convert.ToInt32(textBox12.Text);
                    textBox12.Text = vize4.ToString();
                    vize4 = (vize4 * 40) / 100;
                    final3 = (final3 * 60) / 100;
                    toplam5 = vize4 + final3;


                    if (toplam5 >= 50)
                    {

                        label37.Text = "Dersten Geçtiniz";
                        label36.Text = toplam5.ToString();
                    }
                    else if (toplam5 < 50)
                    {
                        int but = 0;
                        label37.Text = "Bütünlemeye Kaldınız";
                        textBox9.Visible = true;
                        label30.Visible = true;

                        if (sayac8 > 0)
                        {
                            label37.Text = "Bütünleme Notunu Giriniz";
                            label37.Text = "";
                            but = Convert.ToInt32(textBox9.Text);
                            textBox9.Text = but.ToString();
                            textBox9.Visible = true;

                            if (but > 50)
                            {
                                label37.Text = "Dersten Geçtiniz";

                            }
                            else
                            {
                                label37.Text = "Bütünlemeden Kaldınız";

                            }
                        }

                        sayac8++;
                    }

                }
            }

            if (radioBtnMTT.Checked)
            {
                if (radioButton7.Checked) //UYGULAMA METOT

                {


                    int final3 = Convert.ToInt32(textBox12.Text);


                    int vize4 = Convert.ToInt32(textBox8.Text);

                    Universite(vize4, final3);





                }
            }




        }
        #endregion

        #region Hesap Makinesi
        int sayi8 = 0;
        int sayi9 = 0;
        private void button9_Click(object sender, EventArgs e)
        {   // 4 işlem 
            if (radioBtnNOR.Checked)
            {
                if (radioButton8.Checked) //UYGULAMA NORMAL
                {
                    int val3;
                    int val4;
                    if (!Int32.TryParse(sayi1txt.Text, out val3) || !Int32.TryParse(sayi2txt.Text, out val4))
                    {
                        MessageBox.Show("Lütfen Sayı Giriniz");
                        textBox6.Select();
                        // textBox1.BackColor = Color.Red;
                        return;
                    }
                    else
                    {
                        int sayi8 = int.Parse(sayi1txt.Text);
                        int sayi9 = int.Parse(sayi2txt.Text);

                        if (comboBox1.Text == "+")
                        {
                            sonuclbl.Text = (sayi8 + sayi9).ToString();

                        }
                        else if (comboBox1.Text == "-")
                        {
                            sonuclbl.Text = (sayi8 - sayi9).ToString();

                        }
                        else if (comboBox1.Text == "*")
                        {
                            sonuclbl.Text = (sayi8 * sayi9).ToString();


                        }
                        else if (comboBox1.Text == "/")

                        {
                            sonuclbl.Text = (sayi8 / sayi9).ToString();


                        }
                        else
                        {

                        }




                    }
                }
            }
            if (radioBtnMTT.Checked)
            {
                if (radioButton8.Checked) // UYGULAMA METOT

                {
                    int sayi1 = int.Parse(sayi1txt.Text);
                    int sayi2 = int.Parse(sayi2txt.Text);
                    string sec = comboBox1.Text;
                    sonuclbl.Text = Metotlar.Hesapla(sayi1, sayi2, sec).ToString();

                }
            }




        }
        #endregion

        #region 10 Ögrencinin Dönem Sonu Ortalaması
        float toplam6 = 0f, ort1 = 0f, sayac9 = 1f, vize1 = 0f, final1 = 0f, sonuc = 0f;
        private void button10_Click(object sender, EventArgs e)
        {
            //10 öğrencinin dönem sonu ortalaması 
            if (radioBtnNOR.Checked)
            {
                if (radioButton9.Checked) // UYGULAMA NORMAL
                {
                    float val5 = 0f;
                    float val6 = 0f;
                    if (float.TryParse(textBox13.Text, out val5) && float.TryParse(textBox14.Text, out val6))
                    {
                        if (sayac9 < 11)
                        {
                            ort1 = (val5 + val6) / 2;
                            toplam6 = ort1 + toplam6;

                            sonuc = toplam6 / 5;
                            listBox5.Items.Add(sayac9 + "//" + ort1);
                            sayac9++;
                        }
                        else
                        {
                            label45.Text = sonuc.ToString();

                        }
                    }
                    else
                    {
                        MessageBox.Show("Lütfen Sayı Giriniz");
                        textBox6.Select();
                        // textBox1.BackColor = Color.Red;
                        return;

                    }

                }
            }
            if (radioBtnMTT.Checked)
            {
                if (radioButton9.Checked) // UYGULAMA METOT
                {
                    float val5 = float.Parse(textBox13.Text);
                    float val6 = float.Parse(textBox14.Text);

                    label45.Text = OnOgrOrt(val5, val6).ToString();


                }

            }

        }
        #endregion

        #region Faktoriyel
        int sayacburhan = 1, faktoriyel = 1;
        int sayi10 = 0;
        private void button11_Click(object sender, EventArgs e)
        {       //Faktöriyel
            if (radioBtnNOR.Checked) //UYGULAMA NORMAL
            {
                if (radioButton10.Checked)
                {
                    if (Int32.TryParse(textBox15.Text, out sayi10))
                    {
                        for (int i = 1; i <= sayi10; i++)
                        {
                            if (sayi10 > 0)
                            {
                                faktoriyel = i * faktoriyel;
                                label48.Text = faktoriyel.ToString();

                            }
                            else if (sayi10 == 0)
                            {
                                label48.Text = "1";

                            }
                            else
                            {
                                label48.Text = "Negatif Sayılarda Tanım Gereği Faktöriyel Yoktur";
                            }

                        }



                    }
                    else if (!Int32.TryParse(textBox15.Text, out sayi10))
                    {
                        MessageBox.Show("Lütfen Sayı Giriniz");
                        textBox6.Select();
                        // textBox1.BackColor = Color.Red;
                        return;


                    }
                }
            }
            if (radioBtnMTT.Checked)
            {
                if (radioButton10.Checked) //UYGULAMA METOT
                {
                    int sayi10 = int.Parse(textBox15.Text);
                    Metotlar nesne = new Metotlar();
                    label48.Text = nesne.Faktoriyel(sayi10).ToString();
                }
            }






        }
        #endregion

        #region Çarpım Tablosu
        private void button12_Click(object sender, EventArgs e)
        {
            if (radioBtnNOR.Checked) //UYGULAMA NORMAL
            {
                if (radioButton11.Checked)
                {
                    //çarpım tablosu
                    for (int ii = 1; ii <= 10; ii++)
                    {
                        for (int iii = 1; iii <= 10; iii++)
                        {
                            listBox6.Items.Add(ii + "+" + iii + "=" + ii * iii);
                        }
                        listBox6.Items.Add("");
                    }
                }
            }
            if (radioBtnMTT.Checked)
            {
                if (radioButton11.Checked) //UYGULAMA METOT
                {
                    int a =0;
                    CarpımT(a);
                }
            }

        

        }
        #endregion

        #region Mükemmel Sayı
        private void button16_Click(object sender, EventArgs e)
        {
            if (radioBtnNOR.Checked)
            {
                if (radioButton16.Checked) //UYGULAMA NORMAL
                {
                    //mükemmel sayı
                    int toplam = 0, sayi = 0;
                
                    sayi = int.Parse(textBox11.Text);
                    for (int i = 1; i < sayi; i++)
                    {
                        if (sayi % i == 0)
                        {
                            toplam += i;
                        }
                    }
                    if (toplam == sayi)
                    {
                        label59.Text = "Mükemmel Sayı";
                
                    }
                    else
                    {
                        label59.Text = "Mükemmel Sayı Değildir";

                     

                    }
                }
            }
            if (radioBtnMTT.Checked) //UYGULAMA METOT
            {
                if (radioButton16.Checked)
                {
                   int sayi = int.Parse(textBox11.Text);
                    Mukemmel(sayi);
                }
            }
         
          






        }
        #endregion

        #region 10 Sayıdan En Küçüğünü Bulma
        int sayi15 = 0, kucuk = 0, sayac15 = 1;
        private void button8_Click(object sender, EventArgs e)
        {
            // 10 sayıdan en küçüğü bulma 
            if (radioBtnNOR.Checked)
            {
                if (radioButton15.Checked) //UYGULAMA NORMAL
                {
                    if (sayac15 <= 5)
                    {

                        // Console.WriteLine("Lütfen {0} Sayı Giriniz", sayac15);
                        sayi15 = int.Parse(textBox10.Text);
                        listBox7.Items.Add(sayi15);
                        if (sayac15 == 1)
                        {
                            kucuk = sayi15;

                        }
                        else if (sayi15 < kucuk)
                        {
                            kucuk = sayi15;

                        }
                        sayac15++;
                    }
                    label33.Text = kucuk.ToString();
                }
            }
            if (radioBtnMTT.Checked)
            {
                if (radioButton15.Checked) //UYGULAMA METOT
                {
                   int sayi15 = int.Parse(textBox10.Text);
                    listBox7.Items.Add(sayi15);
                    label33.Text = OnSayıEn(sayi15).ToString();
                }
            }


          
         
        }
        #endregion

        #region Girilen Sayı Kaç Basamaklı
        int sayac11 = 1, bas = 9;
        private void button13_Click(object sender, EventArgs e)
        {
            //Girilen sayı kaç basamaklı

            if (radioBtnNOR.Checked) //UYGULAMA NORMAL

            {
                if (radioButton12.Checked)
                {
                    int val14 = 0;

                    if (!Int32.TryParse(textBox16.Text, out val14))

                    {

                        MessageBox.Show("Lütfen Sayı Giriniz");
                        textBox6.Select();
                        // textBox1.BackColor = Color.Red;
                        return;
                    }
                    else
                    {
                        // Console.WriteLine("Bir Sayı Giriniz");
                        while (val14 > bas)
                        {
                            val14 = val14 / 10;
                            sayac11++;
                        }
                        label51.Text = sayac11.ToString();


                    }

                   

                }
            }
            if (radioBtnMTT.Checked)
            {
                if (radioButton12.Checked) //UYGULAMA METOT
                {

                    int sayi2 = 0;

                    sayi2 = Convert.ToInt32(textBox16.Text);

                    Form1 nesne = new Form1();

                    int sayac2 = nesne.hesapla(sayi2);

                    label51.Text = sayac2.ToString();

                }
            }

        }



        #endregion

        #region Mağazadan belli sayıda ürün alımlarında indirim
        int toplam = 0, sayi12 = 0;
        private void button14_Click(object sender, EventArgs e)
        {
            //Mağazadan belli sayıda ürün alımlarında indirim
            if (radioBtnNOR.Checked)
            {
                if (radioButton13.Checked) //UYGULAMA NORMAL
                {
                    int sayi12 = 0;

                    if (!Int32.TryParse(textBox17.Text, out sayi12))

                    {

                        MessageBox.Show("Lütfen Sayı Giriniz");
                        textBox6.Select();
                        // textBox1.BackColor = Color.Red;
                        return;
                    }
                    else
                    {
                        // Console.WriteLine("Lütfen Ürün Sayısını Giriniz");

                        toplam = toplam + sayi12;
                        if (toplam < 3)
                        {
                            label54.Text = "İndirim Bulunamamaktadır";
                            // Console.WriteLine("İndirim Bulunamamaktadır");

                        }
                        else
                        {
                            label54.Text = " %50 indirim bulunmaktadır";

                            //  Console.WriteLine("{0} adet ürün için %50 indirim bulunmaktadır", sayi);

                        }
                    }
                }
            }
            if (radioBtnMTT.Checked)
            {
                if (radioButton13.Checked) //UYGULAMA METOT
                {
                    int toplam;
                    sayi12 = Convert.ToInt32(textBox17.Text);
                    Magazaİnd(sayi12, out toplam);
                }
            }

           




        }
        #endregion

        #region KDV Hesaplama
        int kod1 = 1, kod2 = 2, kod3 = 3, kod = 0, fiyat = 0, kdvfiyat = 0;
        private void button15_Click(object sender, EventArgs e)
        {
            if (radioBtnNOR.Checked)
            {
                if (radioButton14.Checked) //UYGULAMA NORMAL
                {
                    int fiyat1 = 0;
                    // int kod1 = 0;

                    if (!Int32.TryParse(textBox18.Text, out fiyat1))
                    //Console.WriteLine("Lütfen Ürünün Fiyatını Giriniz");
                    //fiyat = int.Parse(Console.ReadLine());
                    //Console.WriteLine("Lütfen Kod Bilgisini Giriniz");
                    //kod = int.Parse(Console.ReadLine());
                    {

                        MessageBox.Show("Lütfen Sayı Giriniz");
                        textBox6.Select();
                        // textBox1.BackColor = Color.Red;
                        return;
                    }
                    else
                    {

                        if (comboBox2.Text == "1")
                        {
                            kdvfiyat = (fiyat1 * 10) / 100;
                            //Console.WriteLine("KDV Fiyatı {0} ", kdvfiyat);
                            label58.Text = kdvfiyat.ToString();


                        }
                        else if (comboBox2.Text == "2")
                        {
                            kdvfiyat = (fiyat1 * 20) / 100;
                            // Console.WriteLine("KDV Fiyatı {0} ", kdvfiyat);
                            label58.Text = kdvfiyat.ToString();


                        }
                        else if (comboBox2.Text == "3")
                        {
                            kdvfiyat = (fiyat1 * 30) / 100;
                            //Console.WriteLine("KDV Fiyatı {0} ", kdvfiyat);
                            label58.Text = kdvfiyat.ToString();


                        }
                        else
                        {

                        }


                    }
                }
            }
            if (radioBtnMTT.Checked)
            {
                if (radioButton14.Checked) //UYGULAMA METOT
                {
                    //int fiyat1;
                    int fiyat1 = int.Parse(textBox18.Text);
                    string islentipi = comboBox2.Text;
                    
                    label58.Text = KDVH(fiyat1,islentipi).ToString();
                }
            }
           
        }

        #endregion




    }



    ///////// FARKLI SINIFTAN METOTLAR  /////////////
    class Metotlar
    {

        #region 2 Sayı Kıyasla Metot (Static Metot)
        public static int Kıyasla(int sayi1, int sayi2)
        {
            string sonuc = "";
            int toplam = 0;
            // string b = "Sayılar Eşit";


            if (sayi1 < sayi2)
            {
                toplam = sayi1;
            }
            else if (sayi1 > sayi2)
            {

                toplam = sayi2;

            }
            else
            {

                sonuc = "Sayılar Eşit";
            }

            return toplam;

        }
        #endregion

        #region Faktöriyel Metot (Dinamik Metot)
        int sayacburhan1 = 1, faktoriyel2 = 1;

        public int Faktoriyel(int sayi10)
        {
            for (int i = 1; i <= sayi10; i++)
            {
                if (sayi10 > 0)
                {
                    faktoriyel2 = i * faktoriyel2;


                }


            }
            return faktoriyel2;
        }


        #endregion

        #region Hesap Makinesi Metot (Statik Metot)
        public static float Hesapla(float sayi1, float sayi2, string islemtipi)
        {
            #region Params Kullanmadan Yapılan
            float toplam = 0f;
            switch (islemtipi)
            {
                case "+":
                    toplam = sayi1 + sayi2;
                    break;
                case "-":
                    toplam = sayi1 - sayi2;

                    break;
                case "*":
                    toplam = sayi1 * sayi2;

                    break;
                case "/":
                    toplam = sayi1 / sayi2;

                    break;
                default:

                    break;
            }
            return toplam;
            #endregion


        }


        #endregion

        #region Girilen 10 Sayının Toplamı Metot (PARAMS)


        int toplam38 = 0;
        public int sayıtop(params int[] sayi3)
        {

            foreach (var item in sayi3)
            {
                toplam38 += item;
            }

            return toplam38;
        }


        #endregion

    }

}
