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
using System.IO;
using MaterialSkin.Animations;
using MaterialSkin.Controls;
using MaterialSkin;


namespace Password_Generator
{
    
    public partial class Form1 : MaterialForm
    {
        private readonly MaterialSkinManager materialSkinManager;
        private int __passlengh=0;
        private long number_of_possible_characters;//you count number of possible characters and write there! 
        private string _chars;
        private Thread _thread;
        private long _passcount=0;
        private bool _stop = false;
        private int _timeoute=0;
        private bool _autosave = false;

        public Form1()
        {
            InitializeComponent();
             // Initialize MaterialSkinManager
            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
			materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Blue700, Primary.Blue600, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

 

        private void generator(long n, string lastpass)
        {

            if (n > 0)
            {
                if (_stop == true)
                    return;
                string lastpass_new;
                for (long i = 0; i < number_of_possible_characters; i++)
                {
                    lastpass_new = lastpass + _chars.Substring((int)i, 1);
                    generator(n - 1, lastpass_new);
                    Thread.Sleep(_timeoute);
                }
            }
            else
                use_the_password(lastpass); 
        }


        private void use_the_password(string password)
        {
            //cout << password << "\n";
            //This code from stack... website
            _passcount += 1;
            Invoke(new Action(() => { 
                listpass.Items.Add(password);
                lblpasscount.Text = _passcount.ToString();
            }
            ));
            if (_autosave==true)
                File.AppendAllText(@"Passwords.txt", password + Environment.NewLine);
        }


        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            _stop = false;
            if (txtchars.Text.Length > 77)
            {
                MessageBox.Show("Chars can't more than 77", "Notice");
            }
            else
            {
                try
                {
                    string lengh = txtlengh.Text;
                    __passlengh = Int32.Parse(lengh);
                    _chars = txtchars.Text;
                    number_of_possible_characters = _chars.Length;
                    try
                    {
                        _timeoute = (int) numtimeout.Value;
                    }
                    catch
                    {
                        MessageBox.Show("An Error ecording convert timeout to int!!!!! ","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    }
                    if (checkautosave.Checked == true)
                    {
                        _autosave = true;
                        if (File.Exists(@"Passwords.txt"))
                            File.Delete(@"Passwords.txt");
                    }
                    start();
                }
                catch
                {
                    MessageBox.Show("Goosfand adad bezan", "Notice");
                }

            }

        }

        public void start()
        {
                    _thread = new Thread(run);
                    _thread.Start();
        }

        private void run()
        {
            generator(__passlengh, "");
        }

        private void listpass_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnstop_Click(object sender, EventArgs e)
        {
            _stop = true;
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            listpass.Items.Clear();
            _passcount = 0;
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            string add="";
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "Text Files (*.txt*)|*.txt*";
            save.InitialDirectory = Directory.GetCurrentDirectory();
            save.Title = "Where do you want to save?";
            save.FileName = "Passwords.txt";
           if (save.ShowDialog() == DialogResult.OK)
            {
                 add = save.FileName;
            }
            for(int a=0;a<listpass.Items.Count;a++)
                File.AppendAllText(add, listpass.Items[a] + Environment.NewLine);
            MessageBox.Show("Save successfull !","Success");
        }
    }
}
