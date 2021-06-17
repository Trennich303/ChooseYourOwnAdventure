using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace ChooseYourOwnAdventure
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            DisplayPage();
        }
        double percentage;
        int page = 1;
        Random randGen = new Random();
        
        

        private void outputText_Click(object sender, EventArgs e)
        {

        }

        private void buttonOption1_Click(object sender, EventArgs e)
        {
            if (page == 1)
            {
                // int rand = randGen.Next(1,100)
                // if rand is less than 70 go to page 6
                // else go to page 10
                page = 2;
            }
            else if (page == 2) { page = 5; }
            else if (page == 3) { page = 1; }
            else if (page == 4) { page = 1; }
            else if (page == 5) { page = 6; }
            else if (page == 6) { page = 1; }
            else if (page == 7) { page = 8; }
            else if (page == 8) { page = 9; }
            else if (page == 9) { page = 1; }
            else if (page == 10) { page = 11; }
            else if (page == 11) { page = 1; }
            else if (page == 12) { page = 1; }
            else if (page == 13) { page = 1; }

            DisplayPage();
        }
        private void buttonOption2_Click(object sender, EventArgs e)
        {
            if (page == 1)
            {
                // int rand = randGen.Next(1,100)
                // if rand is less than 70 go to page 6
                // else go to page 10
                page = 4;
            }
            else if (page == 2) { page = 3; }
            else if (page == 3) { page = 14; }
            else if (page == 4) { page = 14; }
            else if (page == 5) { page = 7; }
            else if (page == 6) { page = 14; }
            else if (page == 7) { page = 12; }
            else if (page == 8) { page = 10; }
            else if (page == 9) { page = 14; }
            else if (page == 10) { page = 13; }
            else if (page == 11) { page = 14; }
            else if (page == 12) { page = 14; }
            else if (page == 13) { page = 14; }

            DisplayPage();
        }


        public void DisplayPage()
        {
            switch (page)
            {
                case 1:
                    //  musicPlayer = new SoundPlayer(Properties.Resources.jungle);
                    //  musicPlayer.Play();

                    this.BackgroundImage = Properties.Resources.amazon_rainforest;

                    outputText.Text = "You wakeup in the Amazon Rainforest from a plane crash, " +
                        "you need to find supplies but they are all in the tail section of the crash " +
                        "which is further in the forest. You stumble across two pathways, the pathway" +
                        " infront of you will get you to the plane crash faster but it is in the more " +
                        "dense and dangourus part of the forest. The pathway to the left is the longer yet safer route";
                    labelOption1.Text = "Go left";
                    labelOption2.Text = "Go straight";
                    break;
                case 2:
                    //musicPlayer = new SoundPlayer(Properties.Resources.brook);
                    //  musicPlayer.Play();

                    this.BackgroundImage = Properties.Resources.secret_cave_260nw_175283300__1_;

                    outputText.Text = "You come to a small clearing in the forest, but it starts to rain, do you take shelter in the cave to your left or do you continue thorugh the forest?";
                    labelOption1.Text = "Continue on your path";
                    labelOption2.Text = "Take shelter in the cave";
                    break;
               
                case 3:
                    
                    outputText.Text = "You take shelter in the cave but you realize that it is a jaguar den and they eat you," +
                        "do you want to play again?";
                    labelOption1.Text = "Yes";
                    labelOption2.Text = "No";
                    break;
                case 4:
                    this.BackgroundImage = Properties.Resources.cottonmouth_snake_bushes_everglades_florida_600w_1026182830;
                    outputText.Text = "While walking thorugh the dense forest you step on a snake and it bites you" +
                       " and kills you with its venom, do you want to play again?";
                    labelOption1.Text = "Yes";
                    labelOption2.Text = "No";
                    break;
                case 5:
                    this.BackgroundImage = Properties.Resources.Lake_in_the_Forest__9654486219_;
                    buttonOption3.Visible = true;
                    outputText.Text = "As you get closer and closer to the wreckage of the plane, you come across" +
                        " a lake with two pathways on the left and right. The pathway in the left is half submerged in water.";
                    labelOption1.Text = "Swim through the lake";
                    labelOption2.Text = "Take the pathway on the right";
                    labelOption3.Text = "Go left";
                    break;
                case 6:
                    this.BackgroundImage = Properties.Resources.spectacled_caiman;
                    buttonOption3.Visible = false;
                    labelOption3.Text = "";
                    outputText.Text = "The water has Caiman in it and they eat you, do you want to play again?";
                    labelOption1.Text = "Yes";
                    labelOption2.Text = "No";
                    break;
                case 7:
                    this.BackgroundImage = Properties.Resources.Plane_Crash;
                    buttonOption3.Visible = false;
                    labelOption3.Text = "";
                    outputText.Text = "After getting past the river, you come across the tail section of the plane," +
                        " you find food, clean water, and flares. It has become night time, you can continue through the " +
                        "forest with your extra supplies or wait it out in the shleter of the plane. ";
                    labelOption1.Text = "Wait it out";
                    labelOption2.Text = "Continue through the forest";
                    break;
                case 8:
                    outputText.Text =  "You wait it out till morning and gain some strength from sleeping and eating some" +
                        " of the supplies, you can light the flare where the plane crashed, but in the thick forest it" +
                        "is harder for someone to find you, or you can continue on the original path to the " +
                        "less dense part of the forest ";
                    labelOption1.Text = "Light flare here";
                    labelOption2.Text = "Continue on your original path";

                    break;
                case 9:
                    outputText.Text = "No one sees the flare and you die of starvation," +
                        "do you want to play again?"; 
                    labelOption1.Text = "Yes";
                    labelOption2.Text = "No";
                    break;
                case 10:
                    this.BackgroundImage = Properties.Resources.waterfall;
                    outputText.Text = "You are walking along your path near a waterfall when a " +
                        "A jaguar nearby spots you, do you try to scale a tree to escape or jump into the ravine?";
                    labelOption1.Text = "Climb the tree";
                    labelOption2.Text = "Jump into the ravine";
                    
                    break;
                case 11:
                    this.BackgroundImage = Properties.Resources.tree2;
                    outputText.Text = "You figure out the hard way that jaguars can climb trees, " +
                        "do you want to play again?";
                    labelOption1.Text = "Yes";
                    labelOption2.Text = "No";
                    break;
                case 12:
                    this.BackgroundImage = Properties.Resources.Night_Time;
                    outputText.Text = "While walking in the dark you trip and fall off a clif, do you want to play again?";
                    labelOption1.Text = "Yes";
                    labelOption2.Text = "No";
                    break;
                case 13:
                    this.BackgroundImage = Properties.Resources.Rescue_Helicopter;
                    outputText.Text = "You escaped the jaguar, after lighting the flare in the open clearing a" +
                        " rescue helicopter finds you after a couple hours. Do you want to play again?";
                    labelOption1.Text = "Yes";
                    labelOption2.Text = "No";
                    break;
                case 14:
                    outputText.Text = "Thank you for playing, do you want to play again";
                    labelOption1.Text = "Yes";
                    labelOption2.Text = "No";

                    Refresh();
                    Thread.Sleep(2000);
                    Application.Exit();
                    break;
                default:
                    break;
            }
        }
        
        private void buttonOption3_Click(object sender, EventArgs e)
        {
            percentage = randGen.Next(1, 101);
            if (page == 5 && percentage >= 70)
            {
                page = 7;
            }
            else if (page ==5)
            {
                page = 6;
            }
            DisplayPage();
        }
    }
}
