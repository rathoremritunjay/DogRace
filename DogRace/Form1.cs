﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DogRace
{
    /* using the concept of multilevel concept i have used the concept of interface . in the interface we  can just declare the method 
     * initilization is depends upon that class in which we inherit this interface main is the  that is inherited by the Form1 class 
    */
    public interface main {
        // for finding winner this method is used
        void findWinner();
        // to reset game reset function is used
        void resetGame();
    }

    //inherit the Interface main using : operator
    public partial class Form1 : Form, main
    {
        // global variable for different Task like keep the record of bet amount and dog no and player no also 
        int tmr = 0;
        int amt1 = 120, amt2 = 100, amt3 = 150;
        int plyr1 = 1, plyr2 = 2, plyr3 = 0;
        int winner = 0, bet1 = 0, bet2 = 0, bet3 = 0;
        int dog1 = 0, dog2 = 0, dog3 = 0, strt = 0,Num=0,Number=0;

        //Object for the Random Class 
        Random objRandom = new Random();
        Race objRace = new Race();

        private void tmRace_Tick(object sender, EventArgs e)
        {
            // generate a random number for the movement of the picture 
            Num = Convert.ToInt32(objRandom.Next(1, 50));
            Number = runDog.generateNo();
            //pass the value to the image till the image position is less then the end point
            if (pbDog1.Left <= 710)
            {
                pbDog1.Left += Convert.ToInt32(Number);
            }
            else {
                // storing the name of the winner dog and display the error message
                winner = 1;
                tmRace.Enabled = false;
                MessageBox.Show("Dog 1 is Winner");
                findWinner();
                resetGame();
                btnStart.Enabled = false;
            }
            // for image movement random function is used 
            Num = Convert.ToInt32(objRandom.Next(1, 50));
            Number = runDog.generateNo();
            //pass the value to the image till the image position is less then the end point
            if (pbDog2.Left <= 710)
            {
                pbDog2.Left += Convert.ToInt32(Number);
            }
            else
            {
                // displaying nay error messge
                winner = 2;
                tmRace.Enabled = false;
                MessageBox.Show("Dog 2 is Winner");
                findWinner();
                resetGame();
                btnStart.Enabled = false;
            }
            // generate a random number for the movement of the picture 
            Num = Convert.ToInt32(objRandom.Next(1, 50));
            Number = runDog.generateNo();
            if (pbDog3.Left <= 710)
            {
                pbDog3.Left += Convert.ToInt32(Number);
            }
            else
            {
                // storing the name of the winner dog and display the error message
                winner = 3;
                tmRace.Enabled = false;
                MessageBox.Show("Dog 3 is Winner");
                findWinner();
                resetGame();
                btnStart.Enabled = false;
            }
            // generate a random number for the movement of the picture 
            Num = Convert.ToInt32(objRandom.Next(1, 50));

            Number = runDog.generateNo();
            if (pbDog4.Left <=710)
            {
                pbDog4.Left += Convert.ToInt32(Number);
            }
            else
            {
                // storing the name of the winner dog and display the error message
                winner = 4;
                tmRace.Enabled = false;
                MessageBox.Show("Dog 4 is Winner");
                findWinner();
                resetGame();
                btnStart.Enabled = false;
            }
        }
        // another post define method to find the winner of the game from the interface , this is the initlization of the inherited method 
        public void findWinner() {
            // checking the player no 1 is winner or looser if he is winner then his amount will be increased or if he loos the game then his amount will be decreased
            if (winner == dog1 && plyr1 == 1)
            {
                Mithun.Mithunresult(amt1,bet1,1);
                amt1 += bet1;

                lblPlayer1.Text = "Mithun has " + amt1 + " Dollar ";

            }
            if(plyr1==1 && winner!=dog1){
                Mithun.Mithunresult(amt1, bet1, 0);
                amt1 -= bet1;
                lblPlayer1.Text = "Mithun has " + amt1 + " Dollar ";

            }

            // checking the player no 2 is winner or looser if he is winner then his amount will be increased or if he loos the game then his amount will be decreased


            if (winner == dog2 && plyr2 == 2)
            {
                Rathore.Rathoreresult(amt2, bet2, 1);
                amt2 += bet2;
                lblPlayer2.Text = "Rathore has " + amt2 + " Dollar ";
            }
            if (plyr2 == 2 && winner != dog2)
            {
                Rathore.Rathoreresult(amt2, bet2, 0);
                amt2 -= bet2;
                lblPlayer2.Text = "Rathore has " + amt2 + " Dollar ";
            }


            // checking the player no 3 is winner or looser if he is winner then his amount will be increased or if he loos the game then his amount will be decreased
            if (winner == dog3 && plyr3 == 3)
            {
                Jatinder.Jatinderresult(amt3, bet3, 1);
                amt3 += bet3;
                lblPlayer3.Text = "Jatinder has " + amt3 + " Dollar ";
            }


            if (plyr3 == 3 && winner != dog3)
            {
                Jatinder.Jatinderresult(amt3, bet3, 0);
                amt3 -= bet3;
                lblPlayer3.Text = "Jatinder has " + amt3 + " Dollar ";
            }

         }
        // another method from the interface , this is the initlization of the inherited method
        public void resetGame() {

            // reset the image to his starting position
            pbDog1.Left =objRace.resetImage();
            pbDog2.Left =objRace.resetImage();
            pbDog3.Left =-10;
            pbDog4.Left =-10;

            //reset the combo box of the player so the image
            cbPlayer.Text = "";
            cbPlayer.Items[0] = "Mithun has "+amt1 +" Dollar";
            cbPlayer.Items[1] = "Rathore has " + amt2 + " Dollar";
            cbPlayer.Items[2] = "Jatinder has " + amt3 + " Dollar";

        }
        // this is sued to start the running between the dog
        private void btnStart_Click(object sender, EventArgs e)
        {
            // enable the timer for Starting the Race 
            tmRace.Enabled = true;
            btnStart.Enabled = false;
        }
        
        public Form1()
        {
            InitializeComponent();
            //disable the Start Button 
            btnStart.Enabled = false;
            pbDog1.Image = DogRace.Properties.Resources.dogy1;
            pbDog2.Image = DogRace.Properties.Resources.dogy2;
            pbDog3.Image = DogRace.Properties.Resources.dogy3;
            pbDog4.Image = DogRace.Properties.Resources.dogy4;
        }

        //this is used to blink the label continusly with the help of timer
        private void tmSlogan_Tick(object sender, EventArgs e)
        {
            //timer to keep the wel come message in blinking mode for display automatically 
            tmr += 1;
            //increase the counter by ne and then reset it after another mode
            if (tmr == 1)
            {
                // hidden the label of Wel come Message 
                lblSlogan.Visible = false;
            }
            else {
                // visible the Label of Wel Come Message
                lblSlogan.Visible = true;
                tmr = 0;
            }
        }

        private void btnBet_Click(object sender, EventArgs e)
        {
            // check the amount of the bet it must be greater then the minimum amount 
            if (nmBet.Value ==0)
            {
                //display the error message if the bet amount is less than minimum amount
                MessageBox.Show("Check might all values are selected or not");
            }
            else {
                // after verifying the bet amount now verify the player have the enough amount for bet or not if he has then it will prooced other wise it will give an error
                if (cbPlayer.SelectedIndex == 0 && nmBet.Value <= amt1 && nmDog.Value>0)
                {
                    
                    // pass the bet amount to the global variable and dog no also for later comparision 
                    bet1 =Convert.ToInt32(nmBet.Value);
                    dog1 = Convert.ToInt32(nmDog.Value);
                    plyr1 = 1;
                    
                    //set the label for displaying the message of the bet amount with the dog no
                    lblPlayer1.Text = "Mithun set the Bet of " + bet1+ " Dollar on Dog No " + dog1;
                    
                    //this counter is used to increment the counter for race button
                    strt = 1;
                    btnStart.Enabled = true;
                }
                else if (cbPlayer.SelectedIndex == 1 && nmBet.Value <= amt2  && nmDog.Value > 0)
                {
                    // pass the bet amount to the global variable and dog no also for later comparision 
                    bet2 = Convert.ToInt32(nmBet.Value);
                    dog2 = Convert.ToInt32(nmDog.Value);
                    plyr2 = 2;
                    
                    //set the label for displaying the message of the bet amount with the dog no
                    lblPlayer2.Text = "Rathore set the Bet of " + bet2 + " Dollar on Dog No " + dog2;
                    
                    //this counter is used to increment the counter for race button
                    strt = 1;
                    btnStart.Enabled = true;
                }
                else if (cbPlayer.SelectedIndex == 2 && nmBet.Value <=amt3 && nmDog.Value > 0)
                {
                    // pass the bet amount to the global variable and dog no also for later comparision 
                    bet3 = Convert.ToInt32(nmBet.Value);
                    dog3 = Convert.ToInt32(nmDog.Value);
                    plyr3 = 3;
                    //set the label for displaying the message of the bet amount with the dog no
                    lblPlayer3.Text = "Jatinder set the Bet of " + bet3 + " Dollar on Dog No " + dog3;
                    //this counter is used to increment the counter for race button
                    strt = 1;
                    btnStart.Enabled = true;
                }
                else
                {
                    //display the error message
                    MessageBox.Show("You Don't have enough Balance");
                }

                // checking the  counter for enable the button of the Race
                if (strt == 1) {
                    btnStart.Enabled = true;
                    strt = 0;
                }

            }



        }
    }
}
