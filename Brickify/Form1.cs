///////////////////////////////////////////////////////////////////////////
//
// Copyright 2015 Qodex Software.
//
// Permission is hereby granted, free of charge, to any person obtaining
// a copy of this software and associated documentation files (the
// "Software"), to deal in the Software without restriction, including
// without limitation the rights to use, copy, modify, merge, publish,
// distribute, sublicense, and/or sell copies of the Software, and to
// permit persons to whom the Software is furnished to do so, subject to
// the following conditions:
// 
// The above copyright notice and this permission notice shall be
// included in all copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF
// MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
// NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE
// LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION
// OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF, OR IN CONNECTION
// WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
//
///////////////////////////////////////////////////////////////////////////
//
//        FILE: TestCustomCheckedListBox.cs
//
//      AUTHOR: Tim Bomgardner
//
// DESCRIPTION: Simple test driver for CustomCheckedListBox.
//
///////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using Qodex;
using System.IO;
using System.Threading.Tasks;
using System.Diagnostics;

namespace TestCustomCheckedListBox
{
	public partial class Form1 : Form
	{
        public Bitmap objBitmap;
        public int width;
        public int height;
        public int text_r =0;
        public int text_g = 0;
        public int text_b=0;
        public double aspectratio;
        public Boolean width_text_cur_editing;
        Status[] rowStatus = new Status[47];
        public brickbase[] lego_colour_palette;
        public Boolean can_change_colours = false;
        public brickbase[] current_legos;


        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {

            //create brick dataset
            lego_colour_palette = create_brick_dataset();



        }


        public struct brickbase
        {
            public Boolean is_greyscale;
            public Boolean is_fullcolour;
            public Boolean is_common_colour;
            public Boolean is_selected;
            public Color colour;
            public string brick_name;
            public int number;
        }


        struct Status
        {
            public Color background;
            public Color foreground;
        }
        private Color customCheckedListBox1_GetBackColor(CustomCheckedListBox listbox, DrawItemEventArgs e)
        {
            return rowStatus[e.Index].background;
        }

        private Color customCheckedListBox1_GetFrontColor(CustomCheckedListBox listbox, DrawItemEventArgs e)
        {
            return rowStatus[e.Index].foreground;
        }



        public brickbase[] create_brick_dataset()
        {
            int data_base_size = 47;
            //colour_list.Items.Add("poo",true);

            brickbase[] bricks_list = new brickbase[data_base_size];
            //above1000 in bricklink
            bricks_list[0].number = 0;
            bricks_list[0].brick_name = "black";
            bricks_list[0].colour = Color.FromArgb(5, 19, 29);
            bricks_list[0].is_greyscale = true;
            bricks_list[0].is_fullcolour = false;
            bricks_list[0].is_common_colour = true;
            bricks_list[1].brick_name = "blue";
            bricks_list[1].colour = Color.FromArgb(0, 85, 191);
            bricks_list[1].is_greyscale = false;
            bricks_list[1].is_fullcolour = true;
            bricks_list[1].is_common_colour = true;
            bricks_list[2].brick_name = "bright_light_orange";
            bricks_list[2].colour = Color.FromArgb(248, 187, 61);
            bricks_list[2].is_greyscale = false;
            bricks_list[2].is_fullcolour = true;
            bricks_list[2].is_common_colour = true;
            bricks_list[3].brick_name = "bright_pink";
            bricks_list[3].colour = Color.FromArgb(228, 173, 200);
            bricks_list[3].is_greyscale = false;
            bricks_list[3].is_fullcolour = false;
            bricks_list[3].is_common_colour = false;
            bricks_list[4].brick_name = "dark_grey";
            bricks_list[4].colour = Color.FromArgb(109, 110, 92);
            bricks_list[4].is_greyscale = false;
            bricks_list[4].is_fullcolour = false;
            bricks_list[4].is_common_colour = false;
            bricks_list[5].brick_name = "dark_bluish_grey";
            bricks_list[5].colour = Color.FromArgb(108, 110, 104);
            bricks_list[5].is_greyscale = true;
            bricks_list[5].is_fullcolour = false;
            bricks_list[5].is_common_colour = true;
            bricks_list[6].brick_name = "purple";
            bricks_list[6].colour = Color.FromArgb(129, 0, 123);
            bricks_list[6].is_greyscale = false;
            bricks_list[6].is_fullcolour = true;
            bricks_list[6].is_common_colour = false;
            bricks_list[7].brick_name = "dark_purple";
            bricks_list[7].colour = Color.FromArgb(63, 54, 145);
            bricks_list[7].is_greyscale = false;
            bricks_list[7].is_fullcolour = false;
            bricks_list[7].is_common_colour = false;
            bricks_list[8].brick_name = "light_grey";
            bricks_list[8].colour = Color.FromArgb(155, 161, 157);
            bricks_list[8].is_greyscale = false;
            bricks_list[8].is_fullcolour = false;
            bricks_list[8].is_common_colour = false;
            bricks_list[9].brick_name = "medium azure";
            bricks_list[9].colour = Color.FromArgb(54,174,191);
            bricks_list[9].is_greyscale = false;
            bricks_list[9].is_fullcolour = false;
            bricks_list[9].is_common_colour = false;
            bricks_list[10].brick_name = "green";
            bricks_list[10].colour = Color.FromArgb(35, 120, 65);
            bricks_list[10].is_greyscale = false;
            bricks_list[10].is_fullcolour = true;
            bricks_list[10].is_common_colour = true;
            bricks_list[11].brick_name = "light_bluish_grey";
            bricks_list[11].colour = Color.FromArgb(160, 165, 169);
            bricks_list[11].is_greyscale = true;
            bricks_list[11].is_fullcolour = false;
            bricks_list[11].is_common_colour = true;
            bricks_list[12].brick_name = "lime";
            bricks_list[12].colour = Color.FromArgb(187, 233, 11);
            bricks_list[12].is_greyscale = false;
            bricks_list[12].is_fullcolour = false;
            bricks_list[12].is_common_colour = true;
            bricks_list[13].brick_name = "medium_blue";
            bricks_list[13].colour = Color.FromArgb(90, 147, 219);
            bricks_list[13].is_greyscale = false;
            bricks_list[13].is_fullcolour = false;
            bricks_list[13].is_common_colour = true;
            bricks_list[14].brick_name = "dark_blue";
            bricks_list[14].colour = Color.FromArgb(10, 52, 99);
            bricks_list[14].is_greyscale = false;
            bricks_list[14].is_fullcolour = false;
            bricks_list[14].is_common_colour = true;
            bricks_list[15].brick_name = "orange";
            bricks_list[15].colour = Color.FromArgb(254, 138, 24);
            bricks_list[15].is_greyscale = false;
            bricks_list[15].is_fullcolour = true;
            bricks_list[15].is_common_colour = true;
            bricks_list[16].brick_name = "red";
            bricks_list[16].colour = Color.FromArgb(201, 26, 9);
            bricks_list[16].is_greyscale = false;
            bricks_list[16].is_fullcolour = true;
            bricks_list[16].is_common_colour = true;
            bricks_list[17].brick_name = "white";
            bricks_list[17].colour = Color.FromArgb(255, 255, 255);
            bricks_list[17].is_greyscale = true;
            bricks_list[17].is_fullcolour = true;
            bricks_list[17].is_common_colour = true;
            bricks_list[18].brick_name = "yellow";
            bricks_list[18].colour = Color.FromArgb(242, 205, 55);
            bricks_list[18].is_greyscale = false;
            bricks_list[18].is_fullcolour = true;
            bricks_list[18].is_common_colour = true;
            bricks_list[19].brick_name = "dark_green";
            bricks_list[19].colour = Color.FromArgb(24, 70, 50);
            bricks_list[19].is_greyscale = false;
            bricks_list[19].is_fullcolour = true;
            bricks_list[19].is_common_colour = true;
            bricks_list[20].brick_name = "tan";
            bricks_list[20].colour = Color.FromArgb(228, 205, 158);
            bricks_list[20].is_greyscale = false;
            bricks_list[20].is_fullcolour = true;
            bricks_list[20].is_common_colour = true;
            bricks_list[21].brick_name = "reddish_brown";
            bricks_list[21].colour = Color.FromArgb(88, 42, 18);
            bricks_list[21].is_greyscale = false;
            bricks_list[21].is_fullcolour = true;
            bricks_list[21].is_common_colour = true;
            bricks_list[20].brick_name = "medium_lavender";
            bricks_list[20].colour = Color.FromArgb(172, 120, 186);
            bricks_list[20].is_greyscale = false;
            bricks_list[20].is_fullcolour = true;
            bricks_list[20].is_common_colour = true;
            bricks_list[21].brick_name = "dark_grey (old)";
            bricks_list[21].colour = Color.FromArgb(84, 89, 85);
            bricks_list[21].is_greyscale = true;
            bricks_list[21].is_fullcolour = true;
            bricks_list[21].is_common_colour = false;
            bricks_list[22].brick_name = "brown";
            bricks_list[22].colour = Color.FromArgb(88, 57, 39);
            bricks_list[22].is_greyscale = false;
            bricks_list[22].is_fullcolour = false;
            bricks_list[22].is_common_colour = false;
            bricks_list[23].brick_name = "aqua";
            bricks_list[23].colour = Color.FromArgb(173,195,192);
            bricks_list[23].is_greyscale = false;
            bricks_list[23].is_fullcolour = false;
            bricks_list[23].is_common_colour = false;
            bricks_list[24].brick_name = "bright_light_blue";
            bricks_list[24].colour = Color.FromArgb(159,195,233);
            bricks_list[24].is_greyscale = false;
            bricks_list[24].is_fullcolour = false;
            bricks_list[24].is_common_colour = false;
            bricks_list[25].brick_name = "bright_light_yellow";
            bricks_list[25].colour = Color.FromArgb(255, 240, 58);
            bricks_list[25].is_greyscale = false;
            bricks_list[25].is_fullcolour = false;
            bricks_list[25].is_common_colour = false;
            bricks_list[26].brick_name = "coral";
            bricks_list[26].colour = Color.FromArgb(255, 105, 143);
            bricks_list[26].is_greyscale = false;
            bricks_list[26].is_fullcolour = false;
            bricks_list[26].is_common_colour = false;
            bricks_list[27].brick_name = "dark_azure";
            bricks_list[27].colour = Color.FromArgb(7, 139, 201);
            bricks_list[27].is_greyscale = false;
            bricks_list[27].is_fullcolour = false;
            bricks_list[27].is_common_colour = false;
            bricks_list[28].brick_name = "dark_brown";
            bricks_list[28].colour = Color.FromArgb(53, 33, 0);
            bricks_list[28].is_greyscale = false;
            bricks_list[28].is_fullcolour = false;
            bricks_list[28].is_common_colour = false;
            bricks_list[29].brick_name = "dark_orange";
            bricks_list[29].colour = Color.FromArgb(169,85,0);
            bricks_list[29].is_greyscale = false;
            bricks_list[29].is_fullcolour = false;
            bricks_list[29].is_common_colour = true;
            bricks_list[30].brick_name = "dark_pink";
            bricks_list[30].colour = Color.FromArgb(200, 112, 160);
            bricks_list[30].is_greyscale = false;
            bricks_list[30].is_fullcolour = false;
            bricks_list[30].is_common_colour = true;
            bricks_list[31].brick_name = "dark_red";
            bricks_list[31].colour = Color.FromArgb(114, 14, 15);
            bricks_list[31].is_greyscale = false;
            bricks_list[31].is_fullcolour = false;
            bricks_list[31].is_common_colour = true;
            bricks_list[32].brick_name = "dark_tan";
            bricks_list[32].colour = Color.FromArgb(149, 138, 115);
            bricks_list[32].is_greyscale = false;
            bricks_list[32].is_fullcolour = false;
            bricks_list[32].is_common_colour = true;
            bricks_list[33].brick_name = "dark_turquoise";
            bricks_list[33].colour = Color.FromArgb(0, 143, 155);
            bricks_list[33].is_greyscale = false;
            bricks_list[33].is_fullcolour = false;
            bricks_list[33].is_common_colour = false;
            bricks_list[34].brick_name = "lavender";
            bricks_list[34].colour = Color.FromArgb(225, 213, 237);
            bricks_list[34].is_greyscale = false;
            bricks_list[34].is_fullcolour = false;
            bricks_list[34].is_common_colour = true;
            bricks_list[35].brick_name = "light_aqua";
            bricks_list[35].colour = Color.FromArgb(173, 195, 192);
            bricks_list[35].is_greyscale = false;
            bricks_list[35].is_fullcolour = false;
            bricks_list[35].is_common_colour = false;
            bricks_list[36].brick_name = "maersk_blue";
            bricks_list[36].colour = Color.FromArgb(53, 146, 195);
            bricks_list[36].is_greyscale = false;
            bricks_list[36].is_fullcolour = false;
            bricks_list[36].is_common_colour = false;
            bricks_list[37].brick_name = "magenta";
            bricks_list[37].colour = Color.FromArgb(146, 57, 120);
            bricks_list[37].is_greyscale = false;
            bricks_list[37].is_fullcolour = false;
            bricks_list[37].is_common_colour = true;
            bricks_list[38].brick_name = "medium_azure";
            bricks_list[38].colour = Color.FromArgb(54, 174, 191);
            bricks_list[38].is_greyscale = false;
            bricks_list[38].is_fullcolour = false;
            bricks_list[38].is_common_colour = true;
            bricks_list[39].brick_name = "medium_nougat";
            bricks_list[39].colour = Color.FromArgb(204, 112, 42);
            bricks_list[39].is_greyscale = false;
            bricks_list[39].is_fullcolour = false;
            bricks_list[39].is_common_colour = true;
            bricks_list[40].brick_name = "medium_orange";
            bricks_list[40].colour = Color.FromArgb(255, 167, 11);
            bricks_list[40].is_greyscale = false;
            bricks_list[40].is_fullcolour = false;
            bricks_list[40].is_common_colour = false;//
            bricks_list[41].brick_name = "nougat";
            bricks_list[41].colour = Color.FromArgb(208, 145, 104);
            bricks_list[41].is_greyscale = false;
            bricks_list[41].is_fullcolour = false;
            bricks_list[41].is_common_colour = false;
            bricks_list[42].brick_name = "olive_green";
            bricks_list[42].colour = Color.FromArgb(155, 154, 90);
            bricks_list[42].is_greyscale = false;
            bricks_list[42].is_fullcolour = false;
            bricks_list[42].is_common_colour = false;
            bricks_list[43].brick_name = "pink";
            bricks_list[43].colour = Color.FromArgb(252, 151, 172);
            bricks_list[43].is_greyscale = false;
            bricks_list[43].is_fullcolour = false;
            bricks_list[43].is_common_colour = false;
            bricks_list[44].brick_name = "sand_blue";
            bricks_list[44].colour = Color.FromArgb(96, 116, 161);
            bricks_list[44].is_greyscale = false;
            bricks_list[44].is_fullcolour = false;
            bricks_list[44].is_common_colour = false;
            bricks_list[45].brick_name = "sand_green";
            bricks_list[45].colour = Color.FromArgb(160, 188, 172);
            bricks_list[45].is_greyscale = false;
            bricks_list[45].is_fullcolour = false;
            bricks_list[45].is_common_colour = true;
            bricks_list[46].brick_name = "yellowish_green";
            bricks_list[46].colour = Color.FromArgb(223, 238, 165);
            bricks_list[46].is_greyscale = false;
            bricks_list[46].is_fullcolour = false;
            bricks_list[46].is_common_colour = false;





            colour_list(bricks_list);

            return bricks_list;
        }


        private void radio_button_updater(object sender, EventArgs e)
        {
            if (GreyButton.Checked)
            {
                for (int i= 0; i< lego_colour_palette.Length; i++)
                {
                    if (lego_colour_palette[i].is_greyscale)
                    {
                        BrickColourList.SetItemChecked(i, true);
                    }
                    else
                    {
                        BrickColourList.SetItemChecked(i, false);
                    }
                }
            }
            else if (CommonButton.Checked)
            {
                for (int i = 0; i < lego_colour_palette.Length; i++)
                {
                    if (lego_colour_palette[i].is_common_colour)
                    {
                        BrickColourList.SetItemChecked(i, true);
                    }
                    else
                    {
                        BrickColourList.SetItemChecked(i, false);
                    }
                }
            }
            else if (AllButton.Checked)
            {
                for (int i = 0; i < lego_colour_palette.Length; i++)
                {

                    BrickColourList.SetItemChecked(i, true);

                }
            }


        }


        public void colour_list(brickbase[] bricks_list)
        {
            
            for (int i = 0; i < rowStatus.Length; i++)
            {
                rowStatus[i] = new Status();
                BrickColourList.Items.AddRange(new object[] { bricks_list[i].brick_name });
                rowStatus[i].background = bricks_list[i].colour;
                Color foreground_colour = Color.FromArgb(255 - bricks_list[i].colour.R, 255 - bricks_list[i].colour.G, 255 - bricks_list[i].colour.B);
                rowStatus[i].foreground = foreground_colour;
            }
            
        }

        


        //maybe also add which pallete to choose from, load these palleted in text files?
        public (Color, int) lego_colour_matcher(Color pixelcolor, Color[] cur_legos)
        {
            int R = 0, G = 0, B = 0, returnedi = 0;


            double difference;
            double past_diff = 9000;
            for (int i = 0; i < cur_legos.GetLength(0); i++)
            {
                difference = Math.Abs(pixelcolor.R - cur_legos[i].R + text_r) + Math.Abs(pixelcolor.G - cur_legos[i].G + text_g) + Math.Abs(pixelcolor.B - cur_legos[i].B + text_b);


                if (past_diff > difference)
                {
                    past_diff = difference;
                    R = cur_legos[i].R;
                    G = cur_legos[i].G;
                    B = cur_legos[i].B;
                    //lego_list.Add(cur_legos[i].brick_name);
                    returnedi = i;
                }

            }

            

            Color lego_colour = Color.FromArgb(R, G, B);

            return (lego_colour, returnedi);
        }


        
        public string time = "";
        private void stopwatch_stop(Stopwatch stopWatch)
        {
            stopWatch.Stop();
            // Get the elapsed time as a TimeSpan value.
            TimeSpan ts = stopWatch.Elapsed;

            // Format and display the TimeSpan value.
            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
                ts.Hours, ts.Minutes, ts.Seconds,
                ts.Milliseconds / 10);

            time += elapsedTime + ",";
            
        }

        public Bitmap destImage;
        private void Generate_Image_Click(object sender, EventArgs e)
        {
            //preload the strut
            int counter = 0;
            for (int i = 0; i < lego_colour_palette.Length; i++)
            {
                if (BrickColourList.GetItemChecked(i))
                {
                    counter += 1;
                }
            }
            Color[] clist = new Color[counter+1];
            current_legos = new brickbase[counter+1];

            


            if (original_image.Image != null)
            {
                int hor_pixel = Int32.Parse(WidthBox.Text);
                int ver_pixel = Int32.Parse(HeightBox.Text);
                destImage = new Bitmap(objBitmap, new Size(hor_pixel, ver_pixel));
                int cur_lego_num = 0;
                //get new brickbase
                for(int i = 0; i<lego_colour_palette.Length; i++)
                {
                    if (BrickColourList.GetItemChecked(i))
                    {
                        current_legos[cur_lego_num] = lego_colour_palette[i];
                        clist[cur_lego_num] = lego_colour_palette[i].colour;
                        cur_lego_num += 1;
                    }
                }
                
                int[] quant_error = new int[3];
                Color lego_pixel;
                int returnedi;
                int percent_done = 0;
                Color cur_colour;
                double percent_incriment = 100/(ver_pixel*hor_pixel);

                for (int i = 0; i < current_legos.Length; i++)
                {
                    current_legos[i].number = 0;
                }

                for (int j = 0; j < ver_pixel; j++)
                {
                    for (int i = 0; i < hor_pixel; i++)
                    {

                        cur_colour = destImage.GetPixel(i, j);
                        (lego_pixel, returnedi) = lego_colour_matcher(cur_colour, clist);
                        destImage.SetPixel(i, j, lego_pixel);
                            //dither
                        if (OptionsList.GetItemChecked(1))
                        {
                            quant_error[0] = cur_colour.R - lego_pixel.R;
                            quant_error[1] = cur_colour.G - lego_pixel.G;
                            quant_error[2] = cur_colour.B - lego_pixel.B;

                            if (i < hor_pixel - 1)
                            {
                                destImage = dither_set_surrounding(i + 1, j, destImage, 7, quant_error);
                            }
                            if (j < ver_pixel - 1)
                            {
                                if (i > 0)
                                {
                                    destImage = dither_set_surrounding(i - 1, j + 1, destImage, 3, quant_error);
                                }
                                if (i < hor_pixel - 1)
                                {
                                    destImage = dither_set_surrounding(i+1, j+1, destImage, 1, quant_error);
                                }
                                destImage = dither_set_surrounding(i, j + 1, destImage, 5, quant_error);
                            }
                        }
                        //counts the number of bricks of each colour
                        current_legos[returnedi].number += 1;
                        percent_done = (int)Math.Round((j * hor_pixel + i) * percent_incriment);
                        textBox1.Text = percent_done.ToString() + "% Complete";
                    }
                }
                Bitmap EditableImg = new Bitmap(hor_pixel * 2, ver_pixel * 2);
                //draw
                using (Graphics g = Graphics.FromImage(EditableImg))
                {
                    //g.DrawImage(objBitmap, 0, 0);
                    g.InterpolationMode = InterpolationMode.NearestNeighbor;
                    g.DrawImage(destImage, 0, 0, hor_pixel * 2, ver_pixel * 2);
                }
                finished_lego_pic.Image = EditableImg;
                finished_lego_pic.SizeMode = PictureBoxSizeMode.Zoom;
                //objBitmap = destImage;
            }
            textBox1.Text ="100% Complete";

        }

        public Bitmap dither_set_surrounding(int i_pos, int j_pos,Bitmap destimage, byte multiple, int[] quant_error)
        {
            int new_red, new_blue, new_green;
            Color new_pixel, cur_colour;

            cur_colour = destimage.GetPixel(i_pos, j_pos);
            new_red = cur_colour.R + ((quant_error[0] * multiple) >> 4);
            new_blue = cur_colour.G + ((quant_error[1] * multiple) >> 4);
            new_green = cur_colour.B + ((quant_error[2] * multiple) >> 4);
            if (new_red > 255)
            {
                new_red = 255;
            }
            else if (new_red < 0)
            {
                new_red = 0;
            }

            if (new_blue > 255)
            {
                new_blue = 255;
            }
            else if (new_blue < 0)
            {
                new_blue = 0;
            }

            if (new_green > 255)
            {
                new_green = 255;
            }
            else if (new_green  < 0)
            {
                new_green = 0;
            }


            new_pixel = Color.FromArgb(Convert.ToByte(new_red), Convert.ToByte(new_blue), Convert.ToByte(new_green));
            destimage.SetPixel(i_pos, j_pos, new_pixel);
            return destimage;
        }

        private void R_Saturation_TextChanged(object sender, EventArgs e)
        {
            if (Rsat.Text != "" && Rsat.Text != "-")
            {
                try
                {
                    if (int.Parse(Rsat.Text) > 255 || int.Parse(Rsat.Text) < -255)
                    {
                        Rsat.Text = text_r.ToString();
                    }
                    else
                    {
                        text_r = int.Parse(Rsat.Text);
                    }
                }
                catch
                {

                }
            }
        }

        private void G_Saturation_TextChanged(object sender, EventArgs e)
        {
            if (Gsat.Text != "" && Gsat.Text != "-")
            {
                try
                {
                    if (int.Parse(Gsat.Text) > 255 || int.Parse(Gsat.Text) < -255)
                    {
                        Gsat.Text = text_g.ToString();
                    }
                    else
                    {
                        text_g = int.Parse(Gsat.Text);
                    }
                }
                catch
                {

                }
            }
        }

        private void B_Saturation_TextChanged(object sender, EventArgs e)
        {
            if (Bsat.Text != "" && Gsat.Text != "-")
            {
                try
                {
                    if (int.Parse(Bsat.Text) > 255 || int.Parse(Bsat.Text) < -255)
                    {
                        Bsat.Text = text_b.ToString();
                    }
                    else
                    {
                        text_b = int.Parse(Bsat.Text);
                    }
                }
                catch
                {

                }
            }
        }

        private void WidthBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (original_image.Image != null && WidthBox.Text != "" && width_text_cur_editing == true)
                {
                    if (double.Parse(WidthBox.Text) > objBitmap.Width * 0.9)
                    {
                        WidthBox.Text = width.ToString();
                    }
                    else
                    {
                        //if aspect ratio
                        if (OptionsList.GetItemChecked(0))
                        {
                            width = Int32.Parse(WidthBox.Text);
                            double test_height = (double)width / aspectratio;
                            if (test_height < objBitmap.Height * 0.9)
                            {

                                HeightBox.Text = Math.Round(test_height).ToString();

                                height = Int32.Parse(HeightBox.Text);

                            }
                        }
                        else
                        {
                            width = Int32.Parse(WidthBox.Text);
                        }
                    }
                }
            }
            catch
            {
                MessageBox.Show("error");
            }

        }

        private void HeightBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (original_image.Image != null && HeightBox.Text != "" && width_text_cur_editing == false)
                {
                    if (double.Parse(HeightBox.Text) > objBitmap.Height * 0.9)
                    {
                        HeightBox.Text = height.ToString();
                    }
                    else
                    {
                        //if aspect ratio
                        if (OptionsList.GetItemChecked(0))
                        {
                            height = Int32.Parse(HeightBox.Text);
                            double test_width = (double)height * aspectratio;
                            if (test_width < objBitmap.Width * 0.9)
                            {

                                WidthBox.Text = Math.Round(test_width).ToString();

                                width = Int32.Parse(WidthBox.Text);

                            }
                        }
                        else
                        {
                            height = Int32.Parse(HeightBox.Text);
                        }
                    }
                }
            }
            catch
            {
                MessageBox.Show("error");
            }

        }

        private void Widthbox_input(object sender, KeyPressEventArgs e)
        {
            width_text_cur_editing = true;
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;

            }

        }

        private void Heightbox_input(object sender, KeyPressEventArgs e)
        {
            width_text_cur_editing = false;
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;

            }
        }
        private void Saturation_input(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)&&(e.KeyChar != '-') && ((sender as TextBox).Text.IndexOf('-') > -1))
            {
                e.Handled = true;
            }
        }


        private void Load_Image_Click_1(object sender, EventArgs e)
        {
            var filePath = string.Empty;

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\Documents";
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    filePath = openFileDialog.FileName;
                    try
                    {
                        objBitmap = new Bitmap(Image.FromFile(filePath));
                        original_image.Image = objBitmap;
                        original_image.SizeMode = PictureBoxSizeMode.Zoom;
                    }
                    catch
                    {
                        MessageBox.Show(filePath, "File Content at path: " + filePath + " aren't valid", MessageBoxButtons.OK);
                    }
                }
            }

            try
            {
                width = objBitmap.Width / 2;
                height = objBitmap.Height / 2;
                aspectratio = (double)width / (double)height;
                WidthBox.Text = width.ToString();
                HeightBox.Text = height.ToString();
            }
            catch
            {
                MessageBox.Show("select something");
            }
            //SET THE VALUES OF HEIGHT AND WIDTH TO THAT OF THE IMAGE. THIS CAN THEN BE CHECKER FOR THE COMPUTATION AS UPPER BOUND

        }

        private void Save_Image_Click(object sender, EventArgs e)
        {
            var filePath = string.Empty;

            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.InitialDirectory = "c:\\Documents";
                saveFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;";
                saveFileDialog.FilterIndex = 2;
                saveFileDialog.RestoreDirectory = true;

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    filePath = saveFileDialog.FileName;
                    try
                    {
                        destImage.Save(filePath, ImageFormat.Png);
                        string ext = filePath.Substring(0, filePath.LastIndexOf("\\") + 1);
                        // Create a file to write to.
                        string result = Path.GetFileName(filePath);
                        result = result.Substring(0, result.LastIndexOf("."));
                        using (StreamWriter sw = File.CreateText(ext + "\\" + result + "-brick_list.txt"))
                            {
                                sw.WriteLine("Lego required");
                                for (int i = 0; i < current_legos.Length-1; i++)
                                {
                                    if (current_legos[i].number>0)
                                    {
                                        string cur_num = current_legos[i].number.ToString();

                                        sw.WriteLine(current_legos[i].brick_name + ": " + cur_num);
                                    }
                                }
                                
                                sw.WriteLine("Buy it on bricklink or summing add the bricks listed to wishlist: ");
                                sw.WriteLine(@"https://www.bricklink.com/v2/catalog/catalogitem.page?P=3005&name=Brick%201%20x%201");
                            }

                    }
                    catch
                    {
                        MessageBox.Show("Not saved properly");
                    }
                }
            }
        }
    }

}

