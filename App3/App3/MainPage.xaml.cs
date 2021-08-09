using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App3
{
	public partial class MainPage : ContentPage
	{
       // public string[] Resimler = new string[6];
        public int Secilen1=0;//dokunulan 2 resimlere sayısal olarak karşılaştırmak için 
        public int Secilen2=0;
        public int sayac=2;
        public Image SecilenResim1 = new Image();
        public Image SecilenResim2 = new Image();
        public Image Bosnesne = new Image();
        public int[] resimler = new int[6];
        string sayilarr;
        Random rastgele = new Random();

        public MainPage()
		{

			InitializeComponent();
            Picture1.Source = ImageSource.FromResource("App3.Droid.Resources.soru.png");
            Picture2.Source = ImageSource.FromResource("App3.Droid.Resources.soru.png");
            Picture3.Source = ImageSource.FromResource("App3.Droid.Resources.soru.png");
            Picture4.Source = ImageSource.FromResource("App3.Droid.Resources.soru.png");
            Picture5.Source = ImageSource.FromResource("App3.Droid.Resources.soru.png");
            Picture6.Source = ImageSource.FromResource("App3.Droid.Resources.soru.png");



            for (int i = 0; i < 6; i++)
            {
                b:
                int sayi = rastgele.Next(1, 7);//7 dahil değil
                if (resimler.Contains(sayi))
                {
                    goto b;

                }
                else
                {
                //    sayilarr = (sayilarr.ToString() + sayi.ToString());
                    resimler[i] = sayi;
                }
                
            }

               lbldizi.Text = ""  + resimler[0].ToString() + "" + resimler[1].ToString() + "" + resimler[2].ToString() + "" + resimler[3].ToString() + "" + resimler[4].ToString() + "" + resimler[5].ToString() + "";

            //Picture1.Source = ImageSource.FromResource("App3.Droid.Resources." + resimler[0] + ".jpg");
            //Picture2.Source = ImageSource.FromResource("App3.Droid.Resources." + resimler[1] + ".jpg");
            //Picture3.Source = ImageSource.FromResource("App3.Droid.Resources." + resimler[2]+ ".jpg");
            //Picture4.Source = ImageSource.FromResource("App3.Droid.Resources." + resimler[3]+ ".jpg");
            //Picture5.Source = ImageSource.FromResource("App3.Droid.Resources." + resimler[4]+ ".jpg");
            //Picture6.Source = ImageSource.FromResource("App3.Droid.Resources." + resimler[5]+ ".jpg");

            lblSecilen1.Text = Secilen1.ToString();
            lblSecilen2.Text = Secilen2.ToString();

        }

  

        private void Picture1_Tapped(object sender, EventArgs e)
        {
         //   SecilenResim1 = Picture1;
                            if (Secilen1==0)//seçilen 1 eşitse 0 a seçilen 1 e o nesneyi aktarır
                {
                Picture1.Source = ImageSource.FromResource("App3.Droid.Resources." + resimler[0] + ".jpg");
                Secilen1 = resimler[0];
                 SecilenResim1 = Picture1;
                Picture1.IsEnabled = false;
                lbls.Text = Secilen1.ToString();
                lblSecilen1.Text = Secilen1.ToString();
                lblSecilen2.Text = Secilen2.ToString();

                sayac--;

                if (sayac==0)
                {
                    if (Secilen1-Secilen2==3|| Secilen1 - Secilen2 == -3)
                    {
                        //SecilenResim1.IsVisible = false;
                        //SecilenResim2.IsVisible = false;
                        SecilenResim1.IsEnabled = false;
                        SecilenResim2.IsEnabled = false;
                        Secilen1 = 0;
                        Secilen2 = 0;
                        SecilenResim1 = Bosnesne;
                        SecilenResim2 = Bosnesne;
                        sayac = 2;
                        lbls.Text = "eslesti";
                        lblSecilen1.Text = Secilen1.ToString();
                        lblSecilen2.Text = Secilen2.ToString();

                    }
                    else
                    {
                        SecilenResim1.IsEnabled = true;
                        SecilenResim2.IsEnabled = true;
                        SecilenResim1.Source = ImageSource.FromResource("App3.Droid.Resources.soru.png");
                        SecilenResim2.Source = ImageSource.FromResource("App3.Droid.Resources.soru.png");
                        Secilen1 = 0;
                        Secilen2 = 0;
                        SecilenResim1 = Bosnesne;
                        SecilenResim2 = Bosnesne;
                        sayac = 2;
                        lbls.Text = lbls.Text + "eslesmedi";
                        lblSecilen1.Text = Secilen1.ToString();
                        lblSecilen2.Text = Secilen2.ToString();
                    }
                }

            }


                 else if (Secilen2==0)
            {
                Picture1.Source = ImageSource.FromResource("App3.Droid.Resources." + resimler[0] + ".jpg");
                Secilen2 = resimler[0];
                SecilenResim2 = Picture1;
                Picture1.IsEnabled = false;
                lbls.Text = Secilen2.ToString();
                lblSecilen1.Text = Secilen1.ToString();
                lblSecilen2.Text = Secilen2.ToString();
                sayac--;

                if (sayac == 0)//sayaç o sa eşleşip eşleşmed
                {
                    if (Secilen1 - Secilen2 == 3 || Secilen1 - Secilen2 == -3)
                    {
                        SecilenResim1.IsEnabled = false;
                        SecilenResim2.IsEnabled = false;
                        Secilen1 = 0;
                        Secilen2 = 0;
                        SecilenResim1 = Bosnesne;
                        SecilenResim2 = Bosnesne;
                        sayac = 2;
                        lbls.Text = "eslesti";
                        lblSecilen1.Text = Secilen1.ToString();
                        lblSecilen2.Text = Secilen2.ToString();
                    }
                    else
                    {
                        SecilenResim1.IsEnabled = true;
                        SecilenResim2.IsEnabled = true;
                        SecilenResim1.Source = ImageSource.FromResource("App3.Droid.Resources.soru.png");
                        SecilenResim2.Source = ImageSource.FromResource("App3.Droid.Resources.soru.png");
                        Secilen1 = 0;
                        Secilen2 = 0;
                        SecilenResim1 = Bosnesne;
                        SecilenResim2 = Bosnesne;
                        sayac = 2;
                        lbls.Text = lbls.Text + "eslesmedi";
                        lblSecilen1.Text = Secilen1.ToString();
                        lblSecilen2.Text = Secilen2.ToString();
                    }
                }
            }

        }

        private void Picture2_Tapped(object sender, EventArgs e)
        {
          //  SecilenResim1.IsVisible = false;

            //   if (String.IsNullOrEmpty(Secilen1.ToString()))
            if (Secilen1 == 0)//seçilen 1 eşitse 0 a 
            {
                Picture2.Source = ImageSource.FromResource("App3.Droid.Resources." + resimler[1] + ".jpg");
                Secilen1 = resimler[1];
                SecilenResim1 = Picture2;
                Picture2.IsEnabled = false;
                lbls.Text = Secilen1.ToString();
                lblSecilen1.Text = Secilen1.ToString();
                lblSecilen2.Text = Secilen2.ToString();
                sayac--;

                if (sayac == 0)
                {
                    if (Secilen1 - Secilen2 == 3 || Secilen1 - Secilen2 == -3)
                    {
                        SecilenResim1.IsEnabled = false;
                        SecilenResim2.IsEnabled = false;
                       
                        Secilen1 = 0;
                        Secilen2 = 0;
                        SecilenResim1 = Bosnesne;
                        SecilenResim2 = Bosnesne;
                        sayac = 2;
                        lbls.Text = "eslesti";
                        lblSecilen1.Text = Secilen1.ToString();
                        lblSecilen2.Text = Secilen2.ToString();

                    }
                    else
                    {
                        SecilenResim1.Source = ImageSource.FromResource("App3.Droid.Resources.soru.png");
                        SecilenResim2.Source = ImageSource.FromResource("App3.Droid.Resources.soru.png");
                        SecilenResim1.IsEnabled = true;
                        SecilenResim2.IsEnabled = true;


                        Secilen1 = 0;
                        Secilen2 = 0;
                        SecilenResim1 = Bosnesne;
                        SecilenResim2 = Bosnesne;
                        sayac = 2;
                        lbls.Text = lbls.Text + "eslesmedi";
                        lblSecilen1.Text = Secilen1.ToString();
                        lblSecilen2.Text = Secilen2.ToString();
                    }
                }

            }

            //    else if (String.IsNullOrEmpty(Secilen2.ToString()))
            else if (Secilen2 == 0)
            {
                Picture2.Source = ImageSource.FromResource("App3.Droid.Resources." + resimler[1] + ".jpg");
                Secilen2 = resimler[1];
                SecilenResim2 = Picture2;
                Picture2.IsEnabled = false;
                lbls.Text = Secilen2.ToString();
                lblSecilen1.Text = Secilen1.ToString();
                lblSecilen2.Text = Secilen2.ToString();
                sayac--;

                if (sayac == 0)//sayaç o sa eşleşip eşleşmed
                {
                    if (Secilen1 - Secilen2 == 3 || Secilen1 - Secilen2 == -3)
                    {
                        SecilenResim1.IsEnabled = false;
                        SecilenResim2.IsEnabled = false;
                        sayac = 2;
                        Secilen1 = 0;
                        Secilen2 = 0;
                        SecilenResim1 = Bosnesne;
                        SecilenResim2 = Bosnesne;
                        lbls.Text = "eslesti";
                        lblSecilen1.Text = Secilen1.ToString();
                        lblSecilen2.Text = Secilen2.ToString();
                    }
                    else
                    {
                        SecilenResim1.Source = ImageSource.FromResource("App3.Droid.Resources.soru.png");
                        SecilenResim2.Source = ImageSource.FromResource("App3.Droid.Resources.soru.png");
                        SecilenResim1.IsEnabled = true;
                        SecilenResim2.IsEnabled = true;


                        Secilen1 = 0;
                        Secilen2 = 0;
                        SecilenResim1 = Bosnesne;
                        SecilenResim2 = Bosnesne;
                        sayac = 2;

                        lbls.Text = lbls.Text + "eslesmedi";
                        lblSecilen1.Text = Secilen1.ToString();
                        lblSecilen2.Text = Secilen2.ToString();
                    }
                }
            }

        }

        private void Picture3_Tapped(object sender, EventArgs e)
        {

            //   if (String.IsNullOrEmpty(Secilen1.ToString()))
            if (Secilen1 == 0)//seçilen 1 eşit değilse 0 a 
            {
                Picture3.Source = ImageSource.FromResource("App3.Droid.Resources." + resimler[2] + ".jpg");
                Secilen1 = resimler[2];
                SecilenResim1 = Picture3;
                Picture3.IsEnabled = false;
                lbls.Text = Secilen1.ToString();
                lblSecilen1.Text = Secilen1.ToString();
                lblSecilen2.Text = Secilen2.ToString();
                sayac--;

                if (sayac == 0)
                {
                    if (Secilen1 - Secilen2 == 3 || Secilen1 - Secilen2 == -3)
                    {
                        SecilenResim1.IsEnabled = true;
                        SecilenResim2.IsEnabled = true;
                        Secilen1 = 0;
                        Secilen2 = 0;
                        SecilenResim1 = Bosnesne;
                        SecilenResim2 = Bosnesne;
                        sayac = 2;
                        lbls.Text = "eslesti";
                        lblSecilen1.Text = Secilen1.ToString();
                        lblSecilen2.Text = Secilen2.ToString();

                    }
                    else
                    {
                        SecilenResim1.Source = ImageSource.FromResource("App3.Droid.Resources.soru.png");
                        SecilenResim2.Source = ImageSource.FromResource("App3.Droid.Resources.soru.png");
                        SecilenResim1.IsEnabled = true;
                        SecilenResim2.IsEnabled = true;
                        sayac = 2;
                        Secilen1 = 0;
                        Secilen2 = 0;
                        SecilenResim1 = Bosnesne;
                        SecilenResim2 = Bosnesne;
                        lbls.Text = lbls.Text + "eslesmedi";
                        lblSecilen1.Text = Secilen1.ToString();
                        lblSecilen2.Text = Secilen2.ToString();
                    }
                }

            }

            //    else if (String.IsNullOrEmpty(Secilen2.ToString()))
            else if (Secilen2 == 0)
            {
                Picture3.Source = ImageSource.FromResource("App3.Droid.Resources." + resimler[2] + ".jpg");
                Secilen2 = resimler[2];
                SecilenResim2 = Picture3;
                Picture3.IsEnabled = false;
                lbls.Text = Secilen2.ToString();
                lblSecilen1.Text = Secilen1.ToString();
                lblSecilen2.Text = Secilen2.ToString();
                sayac--;

                if (sayac == 0)//sayaç o sa eşleşip eşleşmed
                {
                    if (Secilen1 - Secilen2 == 3 || Secilen1 - Secilen2 == -3)
                    {
                        SecilenResim1.IsEnabled = false;
                        SecilenResim2.IsEnabled = false;
                        Secilen1 = 0;
                        Secilen2 = 0;
                        SecilenResim1 = Bosnesne;
                        SecilenResim2 = Bosnesne;
                        sayac = 2;
                        lbls.Text = "eslesti";
                        lblSecilen1.Text = Secilen1.ToString();
                        lblSecilen2.Text = Secilen2.ToString();
                    }
                    else
                    {
                        SecilenResim1.Source = ImageSource.FromResource("App3.Droid.Resources.soru.png");
                        SecilenResim2.Source = ImageSource.FromResource("App3.Droid.Resources.soru.png");
                        SecilenResim1.IsEnabled = true;
                        SecilenResim2.IsEnabled = true;


                        Secilen1 = 0;
                        Secilen2 = 0;
                        SecilenResim1 = Bosnesne;
                        SecilenResim2 = Bosnesne;
                        sayac = 2;
                        lbls.Text = lbls.Text + "eslesmedi";
                        lblSecilen1.Text = Secilen1.ToString();
                        lblSecilen2.Text = Secilen2.ToString();
                    }
                }
            }

        }

        private void Picture4_Tapped(object sender, EventArgs e)
        {
            //   if (String.IsNullOrEmpty(Secilen1.ToString()))
            if (Secilen1 == 0)//seçilen 1 eşit değilse 0 a 
            {
                Picture4.Source = ImageSource.FromResource("App3.Droid.Resources." + resimler[3] + ".jpg");
                Secilen1 = resimler[3];
                SecilenResim1 = Picture4;
                Picture4.IsEnabled = false;
                lbls.Text = Secilen1.ToString();
                lblSecilen1.Text = Secilen1.ToString();
                lblSecilen2.Text = Secilen2.ToString();
                sayac--;

                if (sayac == 0)
                {
                    if (Secilen1 - Secilen2 == 3 || Secilen1 - Secilen2 == -3)
                    {
                        SecilenResim1.IsEnabled = false;
                        SecilenResim2.IsEnabled = false;

                        Secilen1 = 0;
                        Secilen2 = 0;
                        SecilenResim1 = Bosnesne;
                        SecilenResim2 = Bosnesne;
                        sayac = 2;
                        lbls.Text = "eslesti";
                        lblSecilen1.Text = Secilen1.ToString();
                        lblSecilen2.Text = Secilen2.ToString();


                    }
                    else
                    {
                        SecilenResim1.Source = ImageSource.FromResource("App3.Droid.Resources.soru.png");
                        SecilenResim2.Source = ImageSource.FromResource("App3.Droid.Resources.soru.png");
                        SecilenResim1.IsEnabled = true;
                        SecilenResim2.IsEnabled = true;


                       
                        Secilen1 = 0;
                        Secilen2 = 0;
                        SecilenResim1 = Bosnesne;
                        SecilenResim2 = Bosnesne;
                        sayac = 2;
                        lbls.Text = lbls.Text + "eslesmedi";
                        lblSecilen1.Text = Secilen1.ToString();
                        lblSecilen2.Text = Secilen2.ToString();
                    }
                }

            }

            //    else if (String.IsNullOrEmpty(Secilen2.ToString()))
            else if (Secilen2 == 0)
            {
                Picture4.Source = ImageSource.FromResource("App3.Droid.Resources." + resimler[3] + ".jpg");
                Secilen2 = resimler[3];
                SecilenResim2 = Picture4;
                Picture4.IsEnabled = false;
                lbls.Text = Secilen2.ToString();
                lblSecilen1.Text = Secilen1.ToString();
                lblSecilen2.Text = Secilen2.ToString();
                sayac--;

                if (sayac == 0)//sayaç o sa eşleşip eşleşmed
                {
                    if (Secilen1 - Secilen2 == 3 || Secilen1 - Secilen2 == -3)
                    {
                        SecilenResim1.IsEnabled = false;
                        SecilenResim2.IsEnabled = false;
                        sayac = 2;
                        Secilen1 = 0;
                        Secilen2 = 0;
                        SecilenResim1 = Bosnesne;
                        SecilenResim2 = Bosnesne;
                        lbls.Text = "eslesti";
                        lblSecilen1.Text = Secilen1.ToString();
                        lblSecilen2.Text = Secilen2.ToString();
                    }
                    else
                    {
                        SecilenResim1.Source = ImageSource.FromResource("App3.Droid.Resources.soru.png");
                        SecilenResim2.Source = ImageSource.FromResource("App3.Droid.Resources.soru.png");
                        SecilenResim1.IsEnabled = true;
                        SecilenResim2.IsEnabled = true;

                     //   Picture4.Source = ImageSource.FromResource("App3.Droid.Resources.soru.png");

                        Secilen1 = 0;
                        Secilen2 = 0;
                        SecilenResim1 = Bosnesne;
                        SecilenResim2 = Bosnesne;
                        sayac = 2;
                        lbls.Text = lbls.Text+ "eslesmedi";
                        lblSecilen1.Text = Secilen1.ToString();
                        lblSecilen2.Text = Secilen2.ToString();
                    }
                }
            }
        }

        private void Picture5_Tapped(object sender, EventArgs e)
        {
            //   if (String.IsNullOrEmpty(Secilen1.ToString()))
            if (Secilen1 == 0)//seçilen 1 eşit değilse 0 a 
            {
                Picture5.Source = ImageSource.FromResource("App3.Droid.Resources." + resimler[4] + ".jpg");
                Secilen1 = resimler[4];
                SecilenResim1 = Picture5;
                Picture5.IsEnabled = false;
                lbls.Text = Secilen1.ToString();
                lblSecilen1.Text = Secilen1.ToString();
                lblSecilen2.Text = Secilen2.ToString();
                sayac--;

                if (sayac == 0)
                {
                    if (Secilen1 - Secilen2 == 3 || Secilen1 - Secilen2 == -3)
                    {
                        SecilenResim1.IsEnabled = false;
                        SecilenResim2.IsEnabled = false;
                        Secilen1 = 0;
                        Secilen2 = 0;
                        SecilenResim1 = Bosnesne;
                        SecilenResim2 = Bosnesne;
                        sayac = 2;
                        lbls.Text = "eslesti";
                        lblSecilen1.Text = Secilen1.ToString();
                        lblSecilen2.Text = Secilen2.ToString();


                    }
                    else
                    {
                        SecilenResim1.Source = ImageSource.FromResource("App3.Droid.Resources.soru.png");
                        SecilenResim2.Source = ImageSource.FromResource("App3.Droid.Resources.soru.png");
                        SecilenResim1.IsEnabled = true;
                        SecilenResim2.IsEnabled = true;



                        Secilen1 = 0;
                        Secilen2 = 0;
                        SecilenResim1 = Bosnesne;
                        SecilenResim2 = Bosnesne;
                        sayac = 2;
                        lbls.Text = lbls.Text+ "eslesmedi";
                        lblSecilen1.Text = Secilen1.ToString();
                        lblSecilen2.Text = Secilen2.ToString();
                    }
                }

            }

            //    else if (String.IsNullOrEmpty(Secilen2.ToString()))
            else if (Secilen2 == 0)
            {
                Picture5.Source = ImageSource.FromResource("App3.Droid.Resources." + resimler[4] + ".jpg");
                Secilen2 = resimler[4];
                SecilenResim2 = Picture5;
                Picture5.IsEnabled = false;
                lbls.Text = Secilen2.ToString();
                lblSecilen1.Text = Secilen1.ToString();
                lblSecilen2.Text = Secilen2.ToString();
                sayac--;

                if (sayac == 0)//sayaç o sa eşleşip eşleşmed
                {
                    if (Secilen1 - Secilen2 == 3 || Secilen1 - Secilen2 == -3)
                    {
                        SecilenResim1.IsEnabled = false;
                        SecilenResim2.IsEnabled = false;
                        sayac = 2;
                        Secilen1 = 0;
                        Secilen2 = 0;
                        SecilenResim1 = Bosnesne;
                        SecilenResim2 = Bosnesne;
                        lbls.Text = "eslesti";
                        lblSecilen1.Text = Secilen1.ToString();
                        lblSecilen2.Text = Secilen2.ToString();
                    }
                    else
                    {
                        SecilenResim1.Source = ImageSource.FromResource("App3.Droid.Resources.soru.png");
                        SecilenResim2.Source = ImageSource.FromResource("App3.Droid.Resources.soru.png");
                        SecilenResim1.IsEnabled = true;
                        SecilenResim2.IsEnabled = true;


                        Secilen1 = 0;
                        Secilen2 = 0;
                        SecilenResim1 = Bosnesne;
                        SecilenResim2 = Bosnesne;
                        sayac = 2;
                        lbls.Text = lbls.Text + "eslesmedi";
                        lblSecilen1.Text = Secilen1.ToString();
                        lblSecilen2.Text = Secilen2.ToString();
                    }
                }
            }


        }

        private void Picture6_Tapped(object sender, EventArgs e)
        {
            //   if (String.IsNullOrEmpty(Secilen1.ToString()))
            if (Secilen1 == 0)//seçilen 1 eşit değilse 0 a 
            {
                Picture6.Source = ImageSource.FromResource("App3.Droid.Resources." + resimler[5] + ".jpg");

                Secilen1 = resimler[5];
                SecilenResim1 = Picture6;
                Picture6.IsEnabled = false;
                lbls.Text = Secilen1.ToString();
                lblSecilen1.Text = Secilen1.ToString();
                lblSecilen2.Text = Secilen2.ToString();
                sayac--;

                if (sayac == 0)
                {
                    if (Secilen1 - Secilen2 == 3 || Secilen1 - Secilen2 == -3)
                    {
                        SecilenResim1.IsEnabled = false;
                        SecilenResim2.IsEnabled = false;
                        sayac = 2;
                        Secilen1 = 0;
                        Secilen2 = 0;
                        SecilenResim1 = Bosnesne;
                        SecilenResim2 = Bosnesne;
                        lbls.Text = "eslesti";
                        lblSecilen1.Text = Secilen1.ToString();
                        lblSecilen2.Text = Secilen2.ToString();



                    }
                    else
                    {
                        SecilenResim1.Source = ImageSource.FromResource("App3.Droid.Resources.soru.png");
                        SecilenResim2.Source = ImageSource.FromResource("App3.Droid.Resources.soru.png");
                        SecilenResim1.IsEnabled = true;
                        SecilenResim2.IsEnabled = true;

                        Secilen1 = 0;
                        Secilen2 = 0;
                        SecilenResim1 = Bosnesne;
                        SecilenResim2 = Bosnesne;
                        sayac = 2;
                        lbls.Text = lbls.Text + "eslesmedi";
                        lblSecilen1.Text = Secilen1.ToString();
                        lblSecilen2.Text = Secilen2.ToString();
                    }
                }

            }

            //    else if (String.IsNullOrEmpty(Secilen2.ToString()))
            else if (Secilen2 == 0)
            {
                Picture6.Source = ImageSource.FromResource("App3.Droid.Resources." + resimler[5] + ".jpg");

                Secilen2 = resimler[5];
                SecilenResim2 = Picture6;
                Picture6.IsEnabled = false;
                lbls.Text = Secilen2.ToString();
                lblSecilen1.Text = Secilen1.ToString();
                lblSecilen2.Text = Secilen2.ToString();
                sayac--;

                if (sayac == 0)//sayaç o sa eşleşip eşleşmed
                {
                    if (Secilen1 - Secilen2 == 3 || Secilen1 - Secilen2 == -3)
                    {
                        SecilenResim1.IsEnabled = false;
                        SecilenResim2.IsEnabled = false;
                        sayac = 2;
                        Secilen1 = 0;
                        Secilen2 = 0;
                        SecilenResim1 = Bosnesne;
                        SecilenResim2 = Bosnesne;
                        lbls.Text = "eslesti";
                        lblSecilen1.Text = Secilen1.ToString();
                        lblSecilen2.Text = Secilen2.ToString();
                    }
                    else
                    {
                        SecilenResim1.Source = ImageSource.FromResource("App3.Droid.Resources.soru.png");
                        SecilenResim2.Source = ImageSource.FromResource("App3.Droid.Resources.soru.png");
                        SecilenResim1.IsEnabled = true;
                        SecilenResim2.IsEnabled = true;


                        Secilen1 = 0;
                        Secilen2 = 0;
                        SecilenResim1 = Bosnesne;
                        SecilenResim2 = Bosnesne;
                        sayac = 2;
                        lbls.Text = lbls.Text + "eslesmedi";
                        lblSecilen1.Text = Secilen1.ToString();
                        lblSecilen2.Text = Secilen2.ToString();
                    }
                }
            }
        }

        private void btnSifirla_Clicked(object sender, EventArgs e)
        {


            SecilenResim1 = Bosnesne;
            SecilenResim2 = Bosnesne;
            Secilen1=0;
            Secilen2=0;
            sayac = 2;

            resimler = new int[6];

            for (int i = 0; i < 6; i++)
            {
            b:
                int sayi = rastgele.Next(1, 7);//7 dahil değil
                if (resimler.Contains(sayi))
                {
                    goto b;

                }
                else
                {
                    //    sayilarr = (sayilarr.ToString() + sayi.ToString());
                    resimler[i] = sayi;
                }

            }//resimleri döngüyle karıştırma

            //Picture1.Source = ImageSource.FromResource("App3.Droid.Resources." + resimler[0] + ".jpg");
            //Picture2.Source = ImageSource.FromResource("App3.Droid.Resources." + resimler[1] + ".jpg");
            //Picture3.Source = ImageSource.FromResource("App3.Droid.Resources." + resimler[2] + ".jpg");
            //Picture4.Source = ImageSource.FromResource("App3.Droid.Resources." + resimler[3] + ".jpg");
            //Picture5.Source = ImageSource.FromResource("App3.Droid.Resources." + resimler[4] + ".jpg");
            //Picture6.Source = ImageSource.FromResource("App3.Droid.Resources." + resimler[5] + ".jpg");


            Picture1.Source = ImageSource.FromResource("App3.Droid.Resources.soru.png");
            Picture2.Source = ImageSource.FromResource("App3.Droid.Resources.soru.png");
            Picture3.Source = ImageSource.FromResource("App3.Droid.Resources.soru.png");
            Picture4.Source = ImageSource.FromResource("App3.Droid.Resources.soru.png");
            Picture5.Source = ImageSource.FromResource("App3.Droid.Resources.soru.png");
            Picture6.Source = ImageSource.FromResource("App3.Droid.Resources.soru.png");

            Picture1.IsEnabled = true;
            Picture2.IsEnabled = true;
            Picture3.IsEnabled = true;
            Picture4.IsEnabled = true;
            Picture5.IsEnabled = true;
            Picture6.IsEnabled = true;

            lbls.Text = "";


            lbldizi.Text = "" + resimler[0].ToString() + "" + resimler[1].ToString() + "" + resimler[2].ToString() + "" + resimler[3].ToString() + "" + resimler[4].ToString() + "" + resimler[5].ToString() + "";


        }
    }
    
}
