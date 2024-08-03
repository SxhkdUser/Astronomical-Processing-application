using System.Diagnostics.Eventing.Reader;
using System.Web;
// Connor, sxhkd, Sprint 1 
// Date: 25/07/2024
// Version: 1.0
// Astronomical Processing application
// To process randomly generated data and sort it with a algorithm and display it on a listbox, 
// that can be edited and search from a GUI.
namespace _1._0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        //24 numbers that are random must for by comparing each to the other and swapping if less than
        public int[] Bubble_Sort()
        {
            int[] arr = new int[24];
        foreach (int num in Array())
            {
                for (int i = 0; i<24; i++)
                arr[i]=num;
            }
        foreach (int option in arr)
            switch (option)
                {
                    case 0:

                        break;
                }
            return new int[90];
        }
        public string Binary_Search(object message)
        {
        int choice = Convert.ToInt16(message);

        if (choice < 12)
            {

            }
            return "lol";
        }

        public static int[] Array()
        {
            Random random = new Random();
            int[] hours = new int[24];
            for (int i = 0; i<24; i++)
            hours[i] = random.Next(0, 24);
            return hours;
        }
        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void Search_TextChanged(object sender, EventArgs e)
        {
            string txtmessage;
            object message;
            if (sender == null)
            {
                txtmessage = "Error:You didn't enter anything";
            }
            else { message = sender; }
            //Binary_Search(message, int[]);
        }

        private void edit_input_TextChanged(object sender, EventArgs e)
        {
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button_decending_Click(object sender, EventArgs e)
        {
        }
        public int rnd()
        {
            Random rnd = new Random();
            int val;
            val = rnd.Next(0, 10);
            return val;
        }
        private void Gen_data_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count == 0) 
            {
                foreach (int num in Array())
                {
                    listBox1.Items.Add(num);
                }
            }
            else if (listBox1.Items.Count ==24)
            {
                listBox1.Items.Clear();
                foreach (int num in Array())
                {
                    listBox1.Items.Add(num);
                }
            }
        }

        private void Confirm_Srch_Click(object sender, EventArgs e)
        {

        }
    }
}
