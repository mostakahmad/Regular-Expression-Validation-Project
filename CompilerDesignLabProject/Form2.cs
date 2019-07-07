using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CompilerDesignLabProject
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form1 fm = new Form1();
            this.Hide();
            fm.Show();
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            this.button14.BackColor = System.Drawing.Color.Silver;
            this.button13.BackColor = System.Drawing.Color.Silver;
            this.button12.BackColor = System.Drawing.Color.Silver;
            this.button11.BackColor = System.Drawing.Color.Silver;
            this.button10.BackColor = System.Drawing.Color.Silver;
            this.button9.BackColor = System.Drawing.Color.Silver;
            this.button14.ForeColor = System.Drawing.Color.DimGray;
            this.button13.ForeColor = System.Drawing.Color.DimGray;
            this.button12.ForeColor = System.Drawing.Color.DimGray;
            this.button11.ForeColor = System.Drawing.Color.DimGray;
            this.button10.ForeColor = System.Drawing.Color.DimGray;
            this.button9.ForeColor = System.Drawing.Color.DimGray;


            textBox1.Text = "";
            button9.Text = "Not Yet Judged";
            button10.Text = "Not Yet Judged";
            button11.Text = "Not Yet Judged";
            button12.Text = "Not Yet Judged";
            button13.Text = "Not Yet Judged";
            button14.Text = "Not Yet Judged";
        }

        string str1;
        char[] str2 = new char[100];
        char[] str3 = new char[100];
        int ac1 = 0, ac2 = 0, ac3 = 0, ac4 = 0, ac5 = 0, ac6 = 0;
        
        private void button1_Click(object sender, EventArgs e)
        {
            int j;
            str1 = textBox1.Text;
            str2 = str1.ToCharArray();

            if(str1.Length == 0)
            {
                MessageBox.Show("Please Give a String First");
                button15_Click(sender, e);
            }

            else
            {
                for (j = 0; j < str2.Length; j++)
                {
                    str3[j] = str2[j];
                }
                str3[j] = '\0';

                re1();
                re2();
                re3();
                re4();
                re5();
                re6();


            }

            
            
        }

        private void re1()
        {
            
            //a(bc)*de 

            int i = 1;

            if (str3[0] == 'a')
            {
                for (i = 1; ; i += 2)
                {
                    if (str3[i] == 'b' && str3[i + 1] == 'c') { }
                    else
                    {
                        break;
                    }                   
                    
                }
                if (str3[i] == 'd' && str3[i + 1] == 'e' && str3[i+2] == '\0')
                {
                    this.button14.ForeColor = System.Drawing.Color.White;
                    this.button14.BackColor = System.Drawing.Color.DarkGreen;
                    button14.Text = "Accepted";
                    ac1 = 1;
                }
                else
                {
                    this.button14.ForeColor = System.Drawing.Color.White;
                    this.button14.BackColor = System.Drawing.Color.DarkRed;
                    button14.Text = "Not Accepted";
                    ac1 = 0;
                }
            }
            else
            {
                this.button14.ForeColor = System.Drawing.Color.White;
                this.button14.BackColor = System.Drawing.Color.DarkRed;
                button14.Text = "Not Accepted";
                ac1 = 0;
            }
            

        }

        private void re2()
        {
            //a(bc)+de
            int i = 1;

            if (str3[0] == 'a' && str3[1] == 'b' && str3[2] == 'c'  )
            {
                for (i = 3; ; i += 2)
                {
                    if (str3[i] == 'b' && str3[i + 1] == 'c') { }
                    else
                    {
                        break;
                    }

                }
                if (str3[i] == 'd' && str3[i + 1] == 'e' && str3[i + 2] == '\0')
                {
                    this.button13.ForeColor = System.Drawing.Color.White;
                    this.button13.BackColor = System.Drawing.Color.DarkGreen;
                    button13.Text = "Accepted";
                    ac2 = 1;
                }
                else
                {
                    this.button13.ForeColor = System.Drawing.Color.White;
                    this.button13.BackColor = System.Drawing.Color.DarkRed;
                    button13.Text = "Not Accepted";
                    ac2 = 0;
                }
            }
            else
            {
                this.button13.ForeColor = System.Drawing.Color.White;
                this.button13.BackColor = System.Drawing.Color.DarkRed;
                button13.Text = "Not Accepted";
                ac2 = 0;
            }
            
        }

        private void re3()
        {
            //a(bc)?de
            int i = 1;

            if (str3[0] == 'a' )
            {
                for (i = 1; ; i += 2)
                {
                    if (str3[i] == 'b' && str3[i + 1] == 'c')
                    {
                        i += 2;
                        break;
                    }
                    else
                    {
                        break;
                    }

                }
                if (str3[i] == 'd' && str3[i + 1] == 'e' && str3[i + 2] == '\0')
                {
                    this.button12.ForeColor = System.Drawing.Color.White;
                    this.button12.BackColor = System.Drawing.Color.DarkGreen;
                    button12.Text = "Accepted";
                    ac3 = 1;
                }
                else
                {
                    this.button12.ForeColor = System.Drawing.Color.White;
                    this.button12.BackColor = System.Drawing.Color.DarkRed;
                    button12.Text = "Not Accepted";
                    ac3 = 0;
                }
            }
            else
            {
                this.button12.ForeColor = System.Drawing.Color.White;
                this.button12.BackColor = System.Drawing.Color.DarkRed;
                button12.Text = "Not Accepted";
                ac3 = 0;
            }
        }

        private void re4()
        {
            //[a-m]*

            int flag = 0;

            for (int i = 0; i < str2.Length ; i++)
            {
                if (str2[i] < 'a' || str2[i] > 'm')
                {
                    flag = 1;
                    this.button11.ForeColor = System.Drawing.Color.White;
                    this.button11.BackColor = System.Drawing.Color.DarkRed;
                    button11.Text = "Not Accepted";
                    ac4 = 0;
                    break;
                }
            }
            if (flag == 0)
            {
                this.button11.ForeColor = System.Drawing.Color.White;
                this.button11.BackColor = System.Drawing.Color.DarkGreen;
                button11.Text = "Accepted";
                ac4 = 1;
            }
        }

        private void re5()
        {
            //[^aeiou]

            int flag = 0;

            for (int i = 0; i < str2.Length; i++)
            {
                if (str2[i] == 'a' || str2[i] == 'e' || str2[i] == 'i' || str2[i] == 'o' || str2[i] == 'u')
                {
                    flag = 1;
                    this.button10.ForeColor = System.Drawing.Color.White;
                    this.button10.BackColor = System.Drawing.Color.DarkRed;
                    button10.Text = "Not Accepted";
                    ac5 = 0; 
                    break;
                }
            }
            if (flag == 0)
            {
                this.button10.ForeColor = System.Drawing.Color.White;
                this.button10.BackColor = System.Drawing.Color.DarkGreen;
                button10.Text = "Accepted";
                ac5 = 1;
            }
        }

        private void re6()
        {
            //[^aeiou]{6}

            int flag = 0;

            if (str2.Length == 6)
            {

                for (int i = 0; i < str2.Length; i++)
                {
                    if (str2[i] == 'a' || str2[i] == 'e' || str2[i] == 'i' || str2[i] == 'o' || str2[i] == 'u')
                    {
                        flag = 1;
                        this.button9.ForeColor = System.Drawing.Color.White;
                        this.button9.BackColor = System.Drawing.Color.DarkRed;
                        button9.Text = "Not Accepted";
                        ac6 = 0;
                        break;
                    }
                }
                if (flag == 0)
                {
                    this.button9.ForeColor = System.Drawing.Color.White;
                    this.button9.BackColor = System.Drawing.Color.DarkGreen;
                    button9.Text = "Accepted";
                    ac6 = 1;
                }
            }
            else
            {
                this.button9.ForeColor = System.Drawing.Color.White;
                this.button9.BackColor = System.Drawing.Color.DarkRed;
                button9.Text = "Not Accepted";
                ac6 = 0;
            }

        }

        int j;
        private void button2_Click(object sender, EventArgs e)
        {
            str1 = textBox1.Text;
            str2 = str1.ToCharArray();

            for (j = 0; j < str2.Length; j++)
            {
                str3[j] = str2[j];
            }
            str3[j] = '\0';

            if (str1.Length == 0)
            {
                MessageBox.Show("Please Give a String First");
                button15_Click(sender, e);
            }

            else
            {
                re1();
            }

            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            str1 = textBox1.Text;
            str2 = str1.ToCharArray();

            for (j = 0; j < str2.Length; j++)
            {
                str3[j] = str2[j];
            }
            str3[j] = '\0';

            if (str1.Length == 0)
            {
                MessageBox.Show("Please Give a String First");
                button15_Click(sender, e);
            }

            else
            {
                re2();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            str1 = textBox1.Text;
            str2 = str1.ToCharArray();

            for (j = 0; j < str2.Length; j++)
            {
                str3[j] = str2[j];
            }
            str3[j] = '\0';

            if (str1.Length == 0)
            {
                MessageBox.Show("Please Give a String First");
                button15_Click(sender, e);
            }

            else
            {
                re3();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            str1 = textBox1.Text;
            str2 = str1.ToCharArray();

            for (j = 0; j < str2.Length; j++)
            {
                str3[j] = str2[j];
            }
            str3[j] = '\0';

            if (str1.Length == 0)
            {
                MessageBox.Show("Please Give a String First");
                button15_Click(sender, e);
            }

            else
            {
                re4();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            str1 = textBox1.Text;
            str2 = str1.ToCharArray();

            for (j = 0; j < str2.Length; j++)
            {
                str3[j] = str2[j];
            }
            str3[j] = '\0';

            if (str1.Length == 0)
            {
                MessageBox.Show("Please Give a String First");
                button15_Click(sender, e);
            }

            else
            {
                re5();
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            str1 = textBox1.Text;
            str2 = str1.ToCharArray();

            for (j = 0; j < str2.Length; j++)
            {
                str3[j] = str2[j];
            }
            str3[j] = '\0';

            if (str1.Length == 0)
            {
                MessageBox.Show("Please Give a String First");
                button15_Click(sender, e);
            }

            else
            {
                re6();
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            ac1 = 0;
           
                voice();           

                re1();

                if (ac1 == 0)
                {
                    System.Media.SoundPlayer player = new System.Media.SoundPlayer();
                    player.SoundLocation = @"E:\9th Semester\Compiler Design\Lab Report\CompilerDesignLabProject\Voice\NotAccepted.wav";
                    player.Load();
                    player.PlaySync();
                }
                else
                {
                    System.Media.SoundPlayer player = new System.Media.SoundPlayer();
                    player.SoundLocation = @"E:\9th Semester\Compiler Design\Lab Report\CompilerDesignLabProject\Voice\Accepted.wav";
                    player.Load();
                    player.PlaySync();
                }

            
        }

        private void button17_Click(object sender, EventArgs e)
        {
            ac2 = 0;

            voice();

            re2();

            if (ac2 == 0)
            {
                System.Media.SoundPlayer player = new System.Media.SoundPlayer();
                player.SoundLocation = @"E:\9th Semester\Compiler Design\Lab Report\CompilerDesignLabProject\Voice\NotAccepted.wav";
                player.Load();
                player.PlaySync();
            }
            else
            {
                System.Media.SoundPlayer player = new System.Media.SoundPlayer();
                player.SoundLocation = @"E:\9th Semester\Compiler Design\Lab Report\CompilerDesignLabProject\Voice\Accepted.wav";
                player.Load();
                player.PlaySync();
            }

        }

        public void voice()
        {
            str1 = textBox1.Text;
            str2 = str1.ToCharArray();

            for (j = 0; j < str2.Length; j++)
            {
                str3[j] = str2[j];
            }
            str3[j] = '\0';

            if (str1.Length == 0)
            {
                MessageBox.Show("Please Give a String First");
            }

            else
            {
                System.Media.SoundPlayer player0 = new System.Media.SoundPlayer();
                player0.SoundLocation = @"E:\9th Semester\Compiler Design\Lab Report\CompilerDesignLabProject\Voice\string.wav";
                player0.Load();
                player0.PlaySync();

                for (j = 0; j < str2.Length; j++)
                {
                    if(str3[j] == 'a')
                    {
                        System.Media.SoundPlayer player = new System.Media.SoundPlayer();
                        player.SoundLocation = @"E:\9th Semester\Compiler Design\Lab Report\CompilerDesignLabProject\Voice\a.wav";
                        player.Load();
                        player.PlaySync();
                    }
                    if (str3[j] == 'b')
                    {
                        System.Media.SoundPlayer player = new System.Media.SoundPlayer();
                        player.SoundLocation = @"E:\9th Semester\Compiler Design\Lab Report\CompilerDesignLabProject\Voice\b.wav";
                        player.Load();
                        player.PlaySync();
                    }
                    if (str3[j] == 'c')
                    {
                        System.Media.SoundPlayer player = new System.Media.SoundPlayer();
                        player.SoundLocation = @"E:\9th Semester\Compiler Design\Lab Report\CompilerDesignLabProject\Voice\c.wav";
                        player.Load();
                        player.PlaySync();
                    }
                    if (str3[j] == 'd')
                    {
                        System.Media.SoundPlayer player = new System.Media.SoundPlayer();
                        player.SoundLocation = @"E:\9th Semester\Compiler Design\Lab Report\CompilerDesignLabProject\Voice\d.wav";
                        player.Load();
                        player.PlaySync();
                    }
                    if (str3[j] == 'e')
                    {
                        System.Media.SoundPlayer player = new System.Media.SoundPlayer();
                        player.SoundLocation = @"E:\9th Semester\Compiler Design\Lab Report\CompilerDesignLabProject\Voice\e.wav";
                        player.Load();
                        player.PlaySync();
                    }
                    if (str3[j] == 'f')
                    {
                        System.Media.SoundPlayer player = new System.Media.SoundPlayer();
                        player.SoundLocation = @"E:\9th Semester\Compiler Design\Lab Report\CompilerDesignLabProject\Voice\f.wav";
                        player.Load();
                        player.PlaySync();
                    }
                    if (str3[j] == 'g')
                    {
                        System.Media.SoundPlayer player = new System.Media.SoundPlayer();
                        player.SoundLocation = @"E:\9th Semester\Compiler Design\Lab Report\CompilerDesignLabProject\Voice\g.wav";
                        player.Load();
                        player.PlaySync();
                    }
                    if (str3[j] == 'h')
                    {
                        System.Media.SoundPlayer player = new System.Media.SoundPlayer();
                        player.SoundLocation = @"E:\9th Semester\Compiler Design\Lab Report\CompilerDesignLabProject\Voice\h.wav";
                        player.Load();
                        player.PlaySync();
                    }
                    if (str3[j] == 'i')
                    {
                        System.Media.SoundPlayer player = new System.Media.SoundPlayer();
                        player.SoundLocation = @"E:\9th Semester\Compiler Design\Lab Report\CompilerDesignLabProject\Voice\i.wav";
                        player.Load();
                        player.PlaySync();
                    }
                    if (str3[j] == 'j')
                    {
                        System.Media.SoundPlayer player = new System.Media.SoundPlayer();
                        player.SoundLocation = @"E:\9th Semester\Compiler Design\Lab Report\CompilerDesignLabProject\Voice\j.wav";
                        player.Load();
                        player.PlaySync();
                    }
                    if (str3[j] == 'k')
                    {
                        System.Media.SoundPlayer player = new System.Media.SoundPlayer();
                        player.SoundLocation = @"E:\9th Semester\Compiler Design\Lab Report\CompilerDesignLabProject\Voice\k.wav";
                        player.Load();
                        player.PlaySync();
                    }
                    if (str3[j] == 'l')
                    {
                        System.Media.SoundPlayer player = new System.Media.SoundPlayer();
                        player.SoundLocation = @"E:\9th Semester\Compiler Design\Lab Report\CompilerDesignLabProject\Voice\l.wav";
                        player.Load();
                        player.PlaySync();
                    }
                    if (str3[j] == 'm')
                    {
                        System.Media.SoundPlayer player = new System.Media.SoundPlayer();
                        player.SoundLocation = @"E:\9th Semester\Compiler Design\Lab Report\CompilerDesignLabProject\Voice\m.wav";
                        player.Load();
                        player.PlaySync();
                    }
                    if (str3[j] == 'n')
                    {
                        System.Media.SoundPlayer player = new System.Media.SoundPlayer();
                        player.SoundLocation = @"E:\9th Semester\Compiler Design\Lab Report\CompilerDesignLabProject\Voice\n.wav";
                        player.Load();
                        player.PlaySync();
                    }
                    if (str3[j] == 'o')
                    {
                        System.Media.SoundPlayer player = new System.Media.SoundPlayer();
                        player.SoundLocation = @"E:\9th Semester\Compiler Design\Lab Report\CompilerDesignLabProject\Voice\o.wav";
                        player.Load();
                        player.PlaySync();
                    }
                    if (str3[j] == 'p')
                    {
                        System.Media.SoundPlayer player = new System.Media.SoundPlayer();
                        player.SoundLocation = @"E:\9th Semester\Compiler Design\Lab Report\CompilerDesignLabProject\Voice\p.wav";
                        player.Load();
                        player.PlaySync();
                    }
                    if (str3[j] == 'q')
                    {
                        System.Media.SoundPlayer player = new System.Media.SoundPlayer();
                        player.SoundLocation = @"E:\9th Semester\Compiler Design\Lab Report\CompilerDesignLabProject\Voice\q.wav";
                        player.Load();
                        player.PlaySync();
                    }
                    if (str3[j] == 'r')
                    {
                        System.Media.SoundPlayer player = new System.Media.SoundPlayer();
                        player.SoundLocation = @"E:\9th Semester\Compiler Design\Lab Report\CompilerDesignLabProject\Voice\r.wav";
                        player.Load();
                        player.PlaySync();
                    }
                    if (str3[j] == 's')
                    {
                        System.Media.SoundPlayer player = new System.Media.SoundPlayer();
                        player.SoundLocation = @"E:\9th Semester\Compiler Design\Lab Report\CompilerDesignLabProject\Voice\s.wav";
                        player.Load();
                        player.PlaySync();
                    }
                    if (str3[j] == 't')
                    {
                        System.Media.SoundPlayer player = new System.Media.SoundPlayer();
                        player.SoundLocation = @"E:\9th Semester\Compiler Design\Lab Report\CompilerDesignLabProject\Voice\t.wav";
                        player.Load();
                        player.PlaySync();
                    }
                    if (str3[j] == 'u')
                    {
                        System.Media.SoundPlayer player = new System.Media.SoundPlayer();
                        player.SoundLocation = @"E:\9th Semester\Compiler Design\Lab Report\CompilerDesignLabProject\Voice\u.wav";
                        player.Load();
                        player.PlaySync();
                    }
                    if (str3[j] == 'v')
                    {
                        System.Media.SoundPlayer player = new System.Media.SoundPlayer();
                        player.SoundLocation = @"E:\9th Semester\Compiler Design\Lab Report\CompilerDesignLabProject\Voice\v.wav";
                        player.Load();
                        player.PlaySync();
                    }
                    if (str3[j] == 'w')
                    {
                        System.Media.SoundPlayer player = new System.Media.SoundPlayer();
                        player.SoundLocation = @"E:\9th Semester\Compiler Design\Lab Report\CompilerDesignLabProject\Voice\w.wav";
                        player.Load();
                        player.PlaySync();
                    }
                    if (str3[j] == 'x')
                    {
                        System.Media.SoundPlayer player = new System.Media.SoundPlayer();
                        player.SoundLocation = @"E:\9th Semester\Compiler Design\Lab Report\CompilerDesignLabProject\Voice\x.wav";
                        player.Load();
                        player.PlaySync();
                    }
                    if (str3[j] == 'y')
                    {
                        System.Media.SoundPlayer player = new System.Media.SoundPlayer();
                        player.SoundLocation = @"E:\9th Semester\Compiler Design\Lab Report\CompilerDesignLabProject\Voice\y.wav";
                        player.Load();
                        player.PlaySync();
                    }
                    if (str3[j] == 'z')
                    {
                        System.Media.SoundPlayer player = new System.Media.SoundPlayer();
                        player.SoundLocation = @"E:\9th Semester\Compiler Design\Lab Report\CompilerDesignLabProject\Voice\z.wav";
                        player.Load();
                        player.PlaySync();
                    }
                }
        }


        }

        private void button18_Click(object sender, EventArgs e)
        {
            ac3 = 0;

            voice();

            re3();

            if (ac3 == 0)
            {
                System.Media.SoundPlayer player = new System.Media.SoundPlayer();
                player.SoundLocation = @"E:\9th Semester\Compiler Design\Lab Report\CompilerDesignLabProject\Voice\NotAccepted.wav";
                player.Load();
                player.PlaySync();
            }
            else
            {
                System.Media.SoundPlayer player = new System.Media.SoundPlayer();
                player.SoundLocation = @"E:\9th Semester\Compiler Design\Lab Report\CompilerDesignLabProject\Voice\Accepted.wav";
                player.Load();
                player.PlaySync();
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            ac4 = 0;

            voice();

            re4();

            if (ac4 == 0)
            {
                System.Media.SoundPlayer player = new System.Media.SoundPlayer();
                player.SoundLocation = @"E:\9th Semester\Compiler Design\Lab Report\CompilerDesignLabProject\Voice\NotAccepted.wav";
                player.Load();
                player.PlaySync();
            }
            else
            {
                System.Media.SoundPlayer player = new System.Media.SoundPlayer();
                player.SoundLocation = @"E:\9th Semester\Compiler Design\Lab Report\CompilerDesignLabProject\Voice\Accepted.wav";
                player.Load();
                player.PlaySync();
            }
        }

        private void button20_Click(object sender, EventArgs e)
        {
            ac5 = 0;

            voice();

            re5();

            if (ac5 == 0)
            {
                System.Media.SoundPlayer player = new System.Media.SoundPlayer();
                player.SoundLocation = @"E:\9th Semester\Compiler Design\Lab Report\CompilerDesignLabProject\Voice\NotAccepted.wav";
                player.Load();
                player.PlaySync();
            }
            else
            {
                System.Media.SoundPlayer player = new System.Media.SoundPlayer();
                player.SoundLocation = @"E:\9th Semester\Compiler Design\Lab Report\CompilerDesignLabProject\Voice\Accepted.wav";
                player.Load();
                player.PlaySync();
            }
        }

        private void button21_Click(object sender, EventArgs e)
        {
            ac6 = 0;

            voice();

            re6();

            if (ac6 == 0)
            {
                System.Media.SoundPlayer player = new System.Media.SoundPlayer();
                player.SoundLocation = @"E:\9th Semester\Compiler Design\Lab Report\CompilerDesignLabProject\Voice\NotAccepted.wav";
                player.Load();
                player.PlaySync();
            }
            else
            {
                System.Media.SoundPlayer player = new System.Media.SoundPlayer();
                player.SoundLocation = @"E:\9th Semester\Compiler Design\Lab Report\CompilerDesignLabProject\Voice\Accepted.wav";
                player.Load();
                player.PlaySync();
            }
        }

        

        
    }
}
