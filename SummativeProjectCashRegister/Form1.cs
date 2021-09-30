using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace SummativeProjectCashRegister
{
    public partial class Form1 : Form
    {
        /// global varriables for prices, totals, change, order number, taxes and amounts of items
        double sealPrice = 450;
        double kingsPrice = 800;
        double eggPrice = 1200;
        double taxAmount = 0.13;
        double taxPrice;
        double subTotal;
        double totalPrice;
        double sealTotalPrice;
        double kingsTotalPrice;
        double eggTotalPrice;
        double changePrice;
        double orderNumber;
        string goodByeMessage;
        int tenderedAmount;
        int changeAmount;
        int sealAmount;
        int kingsAmount;
        int eggAmount;
        /// global varriables for prices, totals, change, order number, taxes and amounts of items
        public Form1()
        {
            InitializeComponent();
            /// keeps buttons disabled for future use
            changeCalcButton.Enabled = false;
            tenderedInput.Enabled = false;
            printerButton.Enabled = false;
            newOrderButton.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                /// calculates the prices of every item you purcahse, as an example it would calculate how much 2 seals, 3 kings idols and 5 eggs all cost in total
                sealAmount = Convert.ToInt32(sealTextBox.Text);
                kingsAmount = Convert.ToInt32(kingsTextBox.Text);
                eggAmount = Convert.ToInt32(eggTextBox.Text);
                sealTotalPrice = sealPrice * sealAmount;
                kingsTotalPrice = kingsPrice * kingsAmount;
                eggTotalPrice = eggPrice * eggAmount;
                totalPrice = sealTotalPrice + kingsTotalPrice + eggTotalPrice * (1 + taxAmount);
                subTotal = sealTotalPrice + kingsTotalPrice + eggTotalPrice;
                taxPrice = totalPrice - subTotal;
                subTotalText.Text = $"{subTotal.ToString("C")}";
                taxLabel.Text = $"{taxPrice.ToString("C")}";
                totalLabel.Text = $"{totalPrice.ToString("C")}";

                /// enables next button in use and disables buttons that were previously used
                tenderedInput.Enabled = true;
                changeCalcButton.Enabled = true;
                sealTextBox.Enabled = false;
                kingsTextBox.Enabled = false;
                eggTextBox.Enabled = false;
                geoCalcButton.Enabled = false;

            }
            catch
            {

            }
        
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                tenderedAmount = Convert.ToInt32(tenderedInput.Text);
                changePrice = tenderedAmount - totalPrice;
                if (tenderedAmount >= totalPrice)
                {
                    /// shows and stores the value of the change you will get after entering a correct amount in the tendered textbox
                    changeTextLabel.Text = $"Change";
                changeLabel.Text = $"{changePrice.ToString("C")}";
                printerButton.Enabled = true;
                changeCalcButton.Enabled = false;
                tenderedInput.Enabled = false;
                } else if (tenderedAmount < totalPrice)
                {
                    /// tells you if you put an incorect amount in the tendered textbox
                    changeTextLabel.Text = $"Incorect Input";
                    Refresh();
                    printerButton.Enabled = false;
                    changeCalcButton.Enabled = true;
                }
            }
            catch
            {

            }
        }

        private void printerButton_Click(object sender, EventArgs e)
        {
            PrintReceipt();
        }
        
        private async void PrintReceipt()
        {
            try
            {
                ///Changes the value of the order number on the receipt
                if (tenderedAmount >= 3333333)
                {

                    orderNumber = Convert.ToInt32(tenderedInput.Text);
                    orderNumber = 17;
                    goodByeMessage = "Good luck on your journey little Shadow...";
                }
                else if (tenderedAmount == 5212)
                {
                    /// Easter Egg Number 1
                    orderNumber = Convert.ToInt32(tenderedInput.Text);
                    orderNumber = 20051022;
                    goodByeMessage = "Aha! You're one of the Knights! Enjoy your geo!";
                }
                else if (tenderedAmount == 19474)
                {
                    /// Easter Egg Number 2
                    orderNumber = Convert.ToInt32(tenderedInput.Text);
                    orderNumber = 1784;
                    goodByeMessage = "Oh? You've been exploring this world for quite a while! Congratulations on collecting every artifact! Here is your geo.";
                }
                else if (tenderedAmount < 5212)
                {
                    orderNumber = Convert.ToInt32(tenderedInput.Text);
                    orderNumber = 17;
                    goodByeMessage = "Good luck on your journey little Shadow...";
                }
                ///Changes the value of the order number on the receipt
                else if (tenderedAmount > 5212)
                {
                    orderNumber = Convert.ToInt32(tenderedInput.Text);
                    orderNumber = 84;
                    goodByeMessage = "Good luck on your journey little Shadow...";
                }
                ///Changes the value of the order number on the receipt

                ///plays sound when you hit the print receipt button
                SoundPlayer printSound = new SoundPlayer(Properties.Resources.receiptPrintSound);
                printSound.Play();
                ///makes the receipt have the correct properties and have a backcolor
                printerTextLabel.BackColor = Color.DarkCyan;
                printerTextLabel.Text = $"Lemm's Relic Shop";
                ///adds a delay between text on the receipt showing up so it can sync with the sound
                await Task.Delay(500);
                printerTextLabel.Text += $"\n\nOrder Number {orderNumber}";
                ///adds a delay between text on the receipt showing up so it can sync with the sound
                await Task.Delay(500);
                printerTextLabel.Text += $"\nDecember 31, 2021";
                ///adds a delay between text on the receipt showing up so it can sync with the sound
                await Task.Delay(500);
                printerTextLabel.Text += $"\n\nHallownest Seal      x{sealAmount}     = {sealTotalPrice.ToString("C")}";
                await Task.Delay(100);
                printerTextLabel.Text += $"\nKings Idol               x{kingsAmount}     = {kingsTotalPrice.ToString("C")}";
                await Task.Delay(100);
                printerTextLabel.Text += $"\nArcane Egg             x{eggAmount}     = {eggTotalPrice.ToString("C")}";
                await Task.Delay(100);
                printerTextLabel.Text += $"\n\nSub Total                           {subTotal.ToString("C")}";
                await Task.Delay(100);
                printerTextLabel.Text += $"\nTax                                    {taxPrice.ToString("C")}";
                await Task.Delay(100);
                printerTextLabel.Text += $"\nTotal                                  {totalPrice.ToString("C")}";
                await Task.Delay(100);
                printerTextLabel.Text += $"\n\nTendered                            {tenderedAmount.ToString("C")}";
                await Task.Delay(100);
                printerTextLabel.Text += $"\nChange                               {changePrice.ToString("C")}";
                await Task.Delay(100);
                printerTextLabel.Text += $"\n\n\n{goodByeMessage}";
                await Task.Delay(250);
                ///makes the receipt have the correct properties and have a backcolor
                printerButton.Enabled = false;
                newOrderButton.Enabled = true;
                /// disables last useable button and enables a button to start a new order
            }
            catch
            {
                ///plays sound when you hit the print receipt button
                SoundPlayer printSound = new SoundPlayer(Properties.Resources.receiptPrintSound);
                printSound.Play();
                ///makes the receipt have the correct properties and have a backcolor
                printerTextLabel.BackColor = Color.DarkCyan;
                printerTextLabel.Text = $"Lemm's Relic Shop";
                ///adds a delay between text on the receipt showing up so it can sync with the sound
                await Task.Delay(500);
                printerTextLabel.Text += $"\n\nOrder Number {orderNumber}";
                ///adds a delay between text on the receipt showing up so it can sync with the sound
                await Task.Delay(500);
                printerTextLabel.Text += $"\nSeptember 30, 20XX";
                ///adds a delay between text on the receipt showing up so it can sync with the sound
                await Task.Delay(500);
                printerTextLabel.Text += $"\n\nHallownest Seal      x{sealAmount}     = {sealTotalPrice.ToString("C")}";
                printerTextLabel.Text += $"\nKings Idol               x{kingsAmount}     = {kingsTotalPrice.ToString("C")}";
                printerTextLabel.Text += $"\nArcane Egg             x{eggAmount}     = {eggTotalPrice.ToString("C")}";
                printerTextLabel.Text += $"\n\nSub Total                           {subTotal.ToString("C")}";
                printerTextLabel.Text += $"\nTax                                    {taxPrice.ToString("C")}";
                printerTextLabel.Text += $"\nTotal                                  {totalPrice.ToString("C")}";
                printerTextLabel.Text += $"\n\nTendered                            {tenderedAmount.ToString("C")}";
                printerTextLabel.Text += $"\nChange                               {changePrice.ToString("C")}";
                printerTextLabel.Text += $"\n\n\nAha! You're one of the Knights! Enjoy your geo!";
                await Task.Delay(250);
                ///makes the receipt have the correct properties and have a backcolor
                printerButton.Enabled = false;
                newOrderButton.Enabled = true;
            }
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            try
            {
                Application.Restart();
                Environment.Exit(0);
                /// restarts the program so you can enter a new order
            }
            catch
            {

            }
        }

        private void sealTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
