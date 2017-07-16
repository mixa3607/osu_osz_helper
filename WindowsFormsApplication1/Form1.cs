using System;
using System.Data;
using System.Linq;
using System.IO;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using Microsoft.Win32;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //MessageBox.Show("test");
            //from_path_box.Text = @"D:\beatmaps";
            //to_path_box.Text = @"D:\Songs";
            //Regex rgx = new Regex("^\"(.*).osu!.exe\",.*");
            //to_path_box.Text = (string)Registry.GetValue(@"HKEY_CLASSES_ROOT\\osu!\\DefaultIcon", "", "test");
            to_path_box.Text = new Regex("^\"(.*).osu!.exe\",.*").Replace((string)Registry.GetValue(@"HKEY_CLASSES_ROOT\\osu!\\DefaultIcon", "", "test"), "$1") + @"\Songs";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void from_butt_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog from = new FolderBrowserDialog();
            from.ShowNewFolderButton = false;
            if (from.ShowDialog() == DialogResult.OK)
                from_path_box.Text = from.SelectedPath;
        }

        private void from_path_box_TextChanged(object sender, EventArgs e)
        {

        }

        private void to_butt_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog from = new FolderBrowserDialog();
            from.ShowNewFolderButton = false;
            if (from.ShowDialog() == DialogResult.OK)
                to_path_box.Text = from.SelectedPath;
        }

        private void scann_butt_Click(object sender, EventArgs e)
        {
            if (to_path_box.Text != "" && from_path_box.Text != "")
            {
                string[] directories_from = Directory.GetFiles(@from_path_box.Text,"*.osz");
                string[] directories_to = Directory.GetDirectories(@to_path_box.Text).Concat(Directory.GetFiles(to_path_box.Text, "*.osz")).ToArray();
                int i1 = 0, i2 = 0;
                int len_from = directories_from.Length;
                int len_to = directories_to.Length;
                Boolean check = false;
                Regex rgx = new Regex(@".*\\");
                Regex dots = new Regex(@"\.");



                from_list.Items.Clear();
                to_list.Items.Clear();

                progressbar.Maximum = len_from * len_to;
                progressbar.Value = 0;
                //max_progressbar.Text = Convert.ToString(progressbar.Maximum);

                while (i1 < len_from)
                {
                    while (i2 < len_to)
                    {
                        if (string.Equals(dots.Replace(rgx.Replace(directories_from[i1], ""), ""), dots.Replace(rgx.Replace(directories_to[i2], ""), "") + "osz") || string.Equals(dots.Replace(rgx.Replace(directories_from[i1], ""), ""), dots.Replace(rgx.Replace(directories_to[i2], ""), "")))
                        {
                            check = true;
                           // to_list.Items.Add("true");
                        }
                        //else
                           // to_list.Items.Add("false");

                        //from_list.Items.Add(rgx.Replace(directories_from[i1], "")+"\n"+rgx.Replace(directories_to[i2], "") + ".osz");
                        i2++;
                        progressbar.Value++;
                    }
                    if (!check)
                        from_list.Items.Add(rgx.Replace(directories_from[i1], ""));
                    i1++;
                    check = false;
                    i2 = 0;
                    //progressbar.Value++;
                    //curr_progressbar.Text = Convert.ToString(progressbar.Value); //
                }
            }
            else
                MessageBox.Show("Задайте 2 папки!");
        }

        private void from_list_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void start_butt_Click(object sender, EventArgs e)
        {
            string[] files = to_list.Items.Cast<string>().ToArray();
            progressbar.Maximum = files.Length;
            progressbar.Value = 0;
            if (copy_butt.Checked)
            {
                while (progressbar.Value < progressbar.Maximum)
                {
                    File.Copy(from_path_box.Text + @"\" + files[progressbar.Value], to_path_box.Text + @"\" + files[progressbar.Value]);
                    progressbar.Value++;
                }
            }
            else
            {
                while (progressbar.Value < progressbar.Maximum)
                {
                    File.Move(from_path_box.Text + @"\" + files[progressbar.Value], to_path_box.Text + @"\" + files[progressbar.Value]);
                    progressbar.Value++;
                }
            }
            to_list.Items.Clear();
        }

        private void select_to_Click(object sender, EventArgs e)
        {
            string[] move_arr = from_list.SelectedItems.Cast<string>().ToArray();
            to_list.Items.AddRange(move_arr);
            foreach (string item in move_arr)
            {
                from_list.Items.Remove(item);
            }
        }

        private void all_to_Click(object sender, EventArgs e)
        {
            string[] move_arr = from_list.Items.Cast<string>().ToArray();
            to_list.Items.AddRange(move_arr);
            foreach (string item in move_arr)
            {
                from_list.Items.Remove(item);
            }
        }

        private void all_from_Click(object sender, EventArgs e)
        {
            string[] move_arr = to_list.Items.Cast<string>().ToArray();
            from_list.Items.AddRange(move_arr);
            foreach (string item in move_arr)
            {
                to_list.Items.Remove(item);
            }
        }

        private void select_from_Click(object sender, EventArgs e)
        {
            string[] move_arr = to_list.SelectedItems.Cast<string>().ToArray();
            from_list.Items.AddRange(move_arr);
            foreach (string item in move_arr)
            {
                to_list.Items.Remove(item);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private int x = 0; private int y = 0;
        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                this.Location = new System.Drawing.Point(this.Location.X + (e.X - x), this.Location.Y + (e.Y - y));

            }
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            x = e.X; y = e.Y;
        }
    }
}
