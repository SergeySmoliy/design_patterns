using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Console;
namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        Coin_Hendler five = null;
        Coin_Hendler ten = null;
        Coin_Hendler twenty_five = null;
        Coin_Hendler fifty = null;
        Coin_Hendler hundret = null;
        Client client = new Client();
        public Form1()
        {
            InitializeComponent();





            //five.Handle(Coin)
        }
        public class Client
        {
            public int suma { set; get; }


        }
        public class Coin
        {
            public int diametr { set; get; }
            public int ves { set; get; }
            public Coin(int w, int d)
            {
                this.diametr = d;
                this.ves = w;
            }

        }
        public abstract class Coin_Hendler
        {
            public Coin_Hendler Successor { get; set; }
            public abstract void Handle(Coin coin, Client client);

        }
        class five_coin_handler : Coin_Hendler
        {
            public override void Handle(Coin coin, Client client)
            {
                if (coin.ves == 40 && coin.diametr == 40)
                    client.suma += 5;
                else if (Successor != null)
                    Successor.Handle(coin, client);
            }
        }
        class ten_coin_handler : Coin_Hendler
        {
            public override void Handle(Coin coin, Client client)
            {
                if (coin.ves == 10 && coin.diametr == 10)
                    client.suma += 10;
                else if (Successor != null)
                    Successor.Handle(coin, client);
            }
        }

        class twenty_five_handler : Coin_Hendler
        {
            public override void Handle(Coin coin, Client client)
            {
                if (coin.ves == 25 && coin.diametr == 25)
                    client.suma += 25;
                else if (Successor != null)
                    Successor.Handle(coin, client);
            }
        }

        class fifty_hendler : Coin_Hendler
        {
            public override void Handle(Coin coin, Client client)
            {
                if (coin.ves == 50 && coin.diametr == 50)
                    client.suma += 50;
                else if (Successor != null)
                    Successor.Handle(coin, client);
            }
        }

        class hundret_hendler : Coin_Hendler
        {
            public override void Handle(Coin coin, Client client)
            {
                if (coin.ves == 100 && coin.diametr == 100)
                    client.suma += 100;
                else if (Successor != null)
                    Successor.Handle(coin, client);
            }
        }




        private void Form1_Load(object sender, EventArgs e)
        {





        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox3.Text != null)
            {

                if (textBox2.Text != "")
                {
                    Coin coin = new Coin(int.Parse(textBox3.Text), int.Parse(textBox2.Text));
                    five = new five_coin_handler();
                    ten = new ten_coin_handler();
                    twenty_five = new twenty_five_handler();
                    fifty = new fifty_hendler();
                    hundret = new hundret_hendler();


                    five.Successor = ten;
                    ten.Successor = twenty_five;
                    twenty_five.Successor = fifty;
                    fifty.Successor = hundret;
                    five.Handle(coin, client);
                    label1.Text = client.suma.ToString() + " коп.";

                }

            }
        }
    }
}
