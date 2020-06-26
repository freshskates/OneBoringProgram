using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OneBoringProgram
{

    public partial class Form1 : Form
    {


        int mov;
        int movX;
        int movY;
        int age;
        int people;
        int sum = 0;
        double avg = 0.0;
        

        public Form1()
        {
            InitializeComponent();

        }


        private void moveImageBox(object sender)
        {
            Guna2Button b = (Guna2Button)sender;
            imgSlide.Location = new Point(b.Location.X + 121, b.Location.Y - 30);

            imgSlide.SendToBack();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timebox.Text = DateTime.Now.ToString();


        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {


            mov = 1;

            movX = e.X;
            movY = e.Y; 



        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {

            if(mov == 1)
            {

                this.SetDesktopLocation(MousePosition.X - movX, MousePosition.Y - movY);

            }


        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            mov = 0;

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_CheckedChanged(object sender, EventArgs e)
        {
            moveImageBox(sender);
        }

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }

        private void out_1_Click(object sender, EventArgs e)
        {

        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {

            out_1.Visible = true;
            //var selectedValue = info1.SelectedItem.value;
            MessageBox.Show("");



        }

        private void bpeople_Click(object sender, EventArgs e)
        {

            int people;
            people = Convert.ToInt32(tpeople.Text);



            //tpeople.Text.Now.ToInt();

            if (people <= 2)
            {

                MessageBox.Show("Please Enter a valid number. ");
            }
            else
            {
                info1.Items.Add(people);
                
                
                lpeople.Visible = true;

                bage.Visible = true; 
                tage.Visible = true;
                bpeople.Enabled = false;
                tpeople.Enabled = false;
                bpeople.Enabled = false;
                agelabel1.Visible = true;

                rpeople.Text = people.ToString();
                rpeople.Visible = true;
                rpeoplelabel.Visible = true; 


            }
        }

        private void VisitLink()
        {
            // Change the color of the link text by setting LinkVisited
            // to true.
            linkLabel1.LinkVisited = true;
            //Call the Process.Start method to open the default browser
            //with a URL:
            System.Diagnostics.Process.Start("http://www.microsoft.com");
        }





        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                VisitLink();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to open link that was clicked.");
            }
        }


        private void tpeople_KeyDown(object sender, KeyEventArgs e)
        {

            switch (e.KeyCode)
            {
                case Keys.Enter:

                    int people;
                    people = Convert.ToInt32(tpeople.Text);

                    if (people <= 2)
                    {
                        MessageBox.Show("Please Enter a valid number. ");
                        break;
                    }
                    info1.Items.Add(people);
                    lpeople.Visible = true;
                    tage.Enabled = true;
                    tpeople.Enabled = false;
                    bpeople.Enabled = false;

                   break;

            }

        }

        private void guna2HtmlLabel4_Click(object sender, EventArgs e)
        {

        }




        private void bage_Click(object sender, EventArgs e)
        {
            people = Convert.ToInt32(tpeople.Text);

                
            age = Convert.ToInt32(tage.Text);


            for (int i = 0; i < people; i++)
            {

                tage.Text = "";
                //while( bage_Click.Click == false)
                //{



                //}

            }
            int count = info1.Items.Count;
            

            int pdisplay = people - count; 

            rpeople.Text = pdisplay.ToString(); ;
            lage.Visible = true;


            info1.Items.Add(age);


            
            
            if (count == people)
            {

                tage.Enabled = false;
                bage.Enabled = false;

                

                for (int i = 0; i <= people;i++)
                {

                    if (i == people)
                    {
                        sum = sum + (int)info1.Items[i];

                    }

                    else
                    {
                        info1.Items.Add((i + 1) + " | Age: " + info1.Items[i + 1].ToString());
                        //int value = (int)info1.Items[i];


                        sum = sum + (int)info1.Items[i];
                    } 
                }
                sum = sum - people;

                avg = sum;
                avg = avg / people;
                info1.Items.Add("Sum: " + sum.ToString());

                info1.Items.Add("Average: " + avg);

            }





        }

        private void tage_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:

                    people = Convert.ToInt32(tpeople.Text);


                    age = Convert.ToInt32(tage.Text);


                    for (int i = 0; i < people; i++)
                    {

                        tage.Text = "";
                        //while( bage_Click.Click == false)
                        //{



                        //}

                    }
                    int count = info1.Items.Count;


                    int pdisplay = people - count;

                    rpeople.Text = pdisplay.ToString(); ;
                    lage.Visible = true;


                    info1.Items.Add(age);




                    if (count == people)
                    {

                        tage.Enabled = false;
                        bage.Enabled = false;



                        for (int i = 0; i <= people; i++)
                        {

                            if (i == people)
                            {
                                sum = sum + (int)info1.Items[i];

                            }

                            else
                            {
                                info1.Items.Add((i + 1) + " | Age: " + info1.Items[i + 1].ToString());
                                //int value = (int)info1.Items[i];


                                sum = sum + (int)info1.Items[i];
                            }
                        }
                        sum = sum - people;

                        avg = sum;
                        avg = avg / people;
                        info1.Items.Add("Sum: " + sum.ToString());

                        info1.Items.Add("Average: " + avg);

                    }

                    break;

            }
        }

        private void breset_Click(object sender, EventArgs e)
        {


            bage.Enabled = true;
            tage.Enabled = true;
            tpeople.Text = "";
            tage.Text = "";
            bage.Enabled = true;
            tage.Enabled = true;


            info1.Items.Clear();

            tpeople.Enabled = true;
            bpeople.Enabled = true; 


            rpeople.Visible = false;
            rpeoplelabel.Visible = false; 















        }

        private void guna2Button7_Click(object sender, EventArgs e)
        {
            {


                bage.Enabled = true;
                tage.Enabled = true;
                tpeople.Text = "";
                tage.Text = "";
                bage.Enabled = true;
                tage.Enabled = true;


                info1.Items.Clear();

                tpeople.Enabled = true;
                bpeople.Enabled = true;


                rpeople.Visible = false;
                rpeoplelabel.Visible = false;















            }
        }
    }
}
