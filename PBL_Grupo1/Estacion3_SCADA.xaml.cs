using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace PBL_Grupo1
{
    /// <summary>
    /// Lógica de interacción para Estacion3_SCADA.xaml
    /// </summary>
    public partial class Estacion3_SCADA : Window
    {
        public Estacion3_SCADA()
        {
            InitializeComponent();
        }

        public void setBits(BitArray bits)
        {
            //this.bitsEstacion1 = bits;
        }

        private void WindowLoaded(object sender, RoutedEventArgs e)
        {
            DispatcherTimer dispatcherTimer = new DispatcherTimer();
            dispatcherTimer.Tick += new EventHandler(procesaDatosEstacion);
            dispatcherTimer.Interval = new TimeSpan(0, 0, 0, 0, 100);
            dispatcherTimer.Start();
        }

        private void Window_Closed(object sender, EventArgs e)
        {
            this.Hide();
        }
        private void Window_Closing(object sender, CancelEventArgs e)
        {
            this.Hide();
        }


        private void procesaDatosEstacion(object sender, EventArgs e)
        {
            LiveTimeLabel.Content = DateTime.Now.ToString();

            //if (bitsEstacion1 != null)
            //{
            //    for (int i = 0; i < bitsEstacion1.Count; i++)
            //    {
            //        if (listaCheckboxes[i] != null)
            //        {
            //            listaCheckboxes[i].IsChecked = bitsEstacion1[i];
            //        }
            //    }
            //}
        }


        private void Cilindro_elevador_arriba_Checked(object sender, RoutedEventArgs e)
        {

        }


        /*    private void parar_pallet_Checked(object sender, RoutedEventArgs e)
            {

                    guardarCarril = (Model3DGroup)Model.Children[24];
                    Model.Children[24] = vacio;

            }

            private void parar_pallet_Unchecked(object sender, RoutedEventArgs e)
            {
                Model.Children[24] = guardarCarril;
                guardarCarril = null;
            }
        */
        private void Arrancar_cinta_derecha_Checked(object sender, RoutedEventArgs e)
        {
            Storyboard fDir = (Storyboard)FindResource("Cinta_mover_dir");
            Storyboard Fcarril = (Storyboard)FindResource("CARRIL_STORY");

            fDir.Resume();

            //if (guardar_carril == Model.Children[0])
            //{
            //    Fcarril.Resume();
            //}

            //if (palet_extremo_izquierdo.IsChecked == true)
            //{
            //    Model.Children[0] = guardar_carril;
            //    Fcarril.Resume();
            //}

        }

        private void Arrancar_cinta_derecha_Unchecked(object sender, RoutedEventArgs e)
        {
            Storyboard fDir = (Storyboard)FindResource("Cinta_mover_dir");
            fDir.Pause();
            Storyboard Fcarril = (Storyboard)FindResource("CARRIL_STORY");
            Fcarril.Pause();
        }

        private void bajar_cilindro_elevador_Checked_1(object sender, RoutedEventArgs e)
        {
            Storyboard ALMAZEN_BAJAR = (Storyboard)FindResource("ALMAZEN_STORY_BAJAR");
            ALMAZEN_BAJAR.Begin();
        }

        private void subir_cilindro_elevador_Checked(object sender, RoutedEventArgs e)
        {
            Storyboard ALMAZEN_SUBIR = (Storyboard)FindResource("ALMAZEN_STORY_SUBIR");
            ALMAZEN_SUBIR.Begin();
        }

        private void abrir_freno_cilindro_Checked(object sender, RoutedEventArgs e)
        {
            Storyboard freno_story = (Storyboard)FindResource("Freno_cilindro_story");
            freno_story.Begin();
        }

        private void abrir_freno_cilindro_Unchecked(object sender, RoutedEventArgs e)
        {
            Storyboard freno_story = (Storyboard)FindResource("Freno_cilindro_story");
            freno_story.Stop();
        }

        private void palet_extremo_izquierdo_Checked(object sender, RoutedEventArgs e)
        {
            Storyboard fDir = (Storyboard)FindResource("Cinta_mover_dir");
            Storyboard Fcarril = (Storyboard)FindResource("CARRIL_STORY");

            fDir.SetSpeedRatio(1);
            Fcarril.SetSpeedRatio(1);

            //Model.Children[24] = guardar_carril;
            //CARRIL_PALLET.Children[1] = vacio;

            if (!fDir.GetIsPaused())
            {
                Fcarril.Resume();
            }

        }

        private void palet_extremo_derecho_Checked(object sender, RoutedEventArgs e)
        {
            Storyboard fDir = (Storyboard)FindResource("Cinta_mover_dir");
            Storyboard Fcarril = (Storyboard)FindResource("CARRIL_STORY");

            fDir.SetSpeedRatio(2.15);
            Fcarril.SetSpeedRatio(2.15);

        }


        private void Hay_carril_Checked(object sender, RoutedEventArgs e)
        {
            Storyboard fDir = (Storyboard)FindResource("Cinta_mover_dir");
            Storyboard Fcarril = (Storyboard)FindResource("CARRIL_STORY");

            if (!fDir.GetIsPaused())
            {
                Fcarril.Resume();
            }

        }




       

        private void Hay_pallet_Checked(object sender, RoutedEventArgs e)
        {
            //CARRIL_PALLET.Children[1] = guardar_pallet_enCarril;
        }

        private void Hay_pallet_Unchecked(object sender, RoutedEventArgs e)
        {
            //CARRIL_PALLET.Children[1] = vacio;
        }



        private void MainViewport3D_MouseWheel(object sender, MouseWheelEventArgs e)
        {

            /*
             * var st = ;
                  var tt = GetTranslateTransform(child);

                  double zoom = e.Delta > 0 ? .2 : -.2;
                  if (!(e.Delta > 0) && (st.ScaleX < .4 || st.ScaleY < .4))
                      return;

                  Point relative = e.GetPosition(child);
                  double absoluteX;
                  double absoluteY;

                  absoluteX = relative.X * st.ScaleX + tt.X;
                  absoluteY = relative.Y * st.ScaleY + tt.Y;

                  st.ScaleX += zoom;
                  st.ScaleY += zoom;

                  tt.X = absoluteX - relative.X * st.ScaleX;
                  tt.Y = absoluteY - relative.Y * st.ScaleY;
            */
        }


        private void cam_Xdir_Click(object sender, RoutedEventArgs e)
        {
            //Cam_Y_angle.Angle = Y_Scroll;
            //Y_Scroll = Y_Scroll + 2;
        }

        private void cam_Ycima_Click(object sender, RoutedEventArgs e)
        {
            //Cam_X_angle.Angle = X_Scroll;
            //X_Scroll = X_Scroll + 2;
        }

        private void cam_XIzq_Click(object sender, RoutedEventArgs e)
        {
            //Y_Scroll = Y_Scroll - 2;
            //Cam_Y_angle.Angle = Y_Scroll;

        }

        private void cam_Yabajo_Click(object sender, RoutedEventArgs e)
        {
            //X_Scroll = X_Scroll - 2;
            //Cam_X_angle.Angle = X_Scroll;

        }

        private void cam_Zfrente_Click(object sender, RoutedEventArgs e)
        {
            //Z_Scroll = Z_Scroll - 2;
            //cam_Z.OffsetZ = Z_Scroll;
        }

        private void cam_Ztras_Click(object sender, RoutedEventArgs e)
        {
            //Z_Scroll = Z_Scroll + 2;
            //cam_Z.OffsetZ = Z_Scroll;

        }

        private void center_Cam_MouseDown(object sender, MouseButtonEventArgs e)
        {
            //cam_Z.OffsetZ = 250;
            //Cam_X_angle.Angle = 0;
            //Cam_Y_angle.Angle = 90;
        }
        void timer_Tick(object sender, EventArgs e)
        {
            LiveTimeLabel.Content = DateTime.Now.ToString("HH:mm:ss");
        }

        private void Conveyor_view_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Conveyour_view_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Almazen_View_Click(object sender, RoutedEventArgs e)
        {

        }

        private void DIN_View_Click(object sender, RoutedEventArgs e)
        {

        }


        private void ISOMET_Click(object sender, RoutedEventArgs e)
        {
            //cam_Z.OffsetZ = 0;
            //Cam_X_angle.Angle = 0;
            //Cam_Y_angle.Angle = 0;
        }

        private void LEFT_Click(object sender, RoutedEventArgs e)
        {
            //cam_Z.OffsetZ = 0;
            //Cam_X_angle.Angle = 0;
            //Cam_Y_angle.Angle = -50;
        }

        private void TOP_Click(object sender, RoutedEventArgs e)
        {
            //cam_Z.OffsetZ = 200;
            //Cam_X_angle.Angle = -70;
            //Cam_Y_angle.Angle = 20;
        }

        private void BOTTOM_Click(object sender, RoutedEventArgs e)
        {
            //cam_Z.OffsetZ = 0;
            //Cam_X_angle.Angle = 10;
            //Cam_Y_angle.Angle = 25;

            //CILINDRO_ALMAZEN00.Brush = Brushes.BlueViolet;
            //CILINDRO_ALMAZEN01.Brush = Brushes.Blue;



        }

        

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
        }
    }
}
