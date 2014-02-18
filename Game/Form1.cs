using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game
{
    public partial class Form1 : Form
    {
        byte count_users;
        byte current_users;
        List<users> list_of_users = new List<users>();
        public Form1()
        {
            InitializeComponent();
            Program.data.EventHandler = new Program.data.MyEvent(read_count_users);
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            pictureBox4.Visible = false;
            pictureBox5.Visible = false;
        }
        void read_count_users(byte _count)
        {
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            pictureBox4.Visible = false;
            pictureBox5.Visible = false;
            list_of_users.Clear();

            count_users = _count;
            dataGridView1.Rows.Clear();
            for (byte i = 1; i <= _count; i++)
            {
                dataGridView1.Rows.Add(i.ToString(), "Игрок №" + i.ToString());
                list_of_users.Add(new users(i-1));
                list_of_users[i - 1].Steping += Form1_Steping;
                list_of_users[i - 1].ExtraStep += Form1_ExtraStep;
                list_of_users[i - 1].SkipStep += Form1_SkipStep;
                list_of_users[i - 1].Transition += Form1_Transition;
                list_of_users[i - 1].Winner += Form1_Winner;
            }

            switch (_count)
            {
                case 1:
                    {
                        pictureBox2.Visible = true;
                        break;
                    }
                case 2:
                    {
                        pictureBox2.Visible = true;
                        pictureBox3.Visible = true;
                        break;
                    }
                case 3:
                    {
                        pictureBox2.Visible = true;
                        pictureBox3.Visible = true;
                        pictureBox4.Visible = true;
                        break;
                    }
                case 4:
                    {
                        pictureBox2.Visible = true;
                        pictureBox3.Visible = true;
                        pictureBox4.Visible = true;
                        pictureBox5.Visible = true;
                        break;
                    }
            }
 
        }

        void Form1_Winner(object ob, Users1EventArgs e)
        {
            //throw new NotImplementedException();
        }

        void Form1_Transition(object ob, Users1EventArgs e)
        {
            //throw new NotImplementedException();
        }

        void Form1_SkipStep(object ob, Users1EventArgs e)
        {
            //throw new NotImplementedException();
        }

        void Form1_ExtraStep(object ob, Users1EventArgs e)
        {
            //throw new NotImplementedException();
        }

        void Form1_Steping(object sender, UsersEventArgs e)
        {
            dataGridView1[2, e.NameUser].Value = e.Step.ToString();
            if (e.NameUser==0)
                label1.Text = e.Position.ToString();
            if (e.NameUser == 1)
                label2.Text = e.Position.ToString();

            PaintChips(e.NameUser, e.Position);
            //throw new NotImplementedException();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.ShowDialog();
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar==(char)Keys.Space)
            {
                list_of_users[0].do_step();
            }
        }

        private void dataGridView1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Space)
            {
                if (current_users == count_users)
                {
                    current_users = 0;
                }
                list_of_users[current_users].do_step();
                current_users++;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (current_users == count_users)
            {
                current_users = 0;
            }
            list_of_users[current_users].do_step();
            current_users++;
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            label3.Text = e.X.ToString();
            label4.Text = e.Y.ToString();
        }

        private void PaintChips(byte _users, int _position)
        {
            //массив с координатами мест поля
            Chips[] chips = new Chips[512];
            chips[0].x = 170;
            chips[0].y = 771;
            chips[1].x = 230;
            chips[1].y = 732;
            chips[2].x = 267;
            chips[2].y = 688;
            chips[3].x = 312;
            chips[3].y = 648;
            chips[4].x = 367;
            chips[4].y = 631;
            chips[5].x = 424;
            chips[5].y = 626;
            chips[6].x = 484;
            chips[6].y = 632;
            chips[7].x = 538;
            chips[7].y = 644;
            chips[8].x = 592;
            chips[8].y = 658;
            chips[9].x = 650;
            chips[9].y = 674;
            chips[10].x = 705;
            chips[10].y = 671;
            chips[11].x = 725;
            chips[11].y = 617;
            chips[12].x = 688;
            chips[12].y = 577;
            chips[13].x = 633;
            chips[13].y = 568;
            chips[14].x = 575;
            chips[14].y = 559;
            chips[15].x = 518;
            chips[15].y = 552;
            chips[16].x = 462;
            chips[16].y = 539;
            chips[17].x = 407;
            chips[17].y = 516;
            chips[18].x = 361;
            chips[18].y = 484;
            chips[19].x = 333;
            chips[19].y = 440;
            chips[20].x = 304;
            chips[20].y = 390;
            chips[21].x = 321;
            chips[21].y = 344;
            chips[22].x = 359;
            chips[22].y = 309;
            chips[23].x = 415;
            chips[23].y = 304;
            chips[24].x = 470;
            chips[24].y = 324;
            chips[25].x = 509;
            chips[25].y = 361;
            chips[26].x = 554;
            chips[26].y = 404;
            chips[27].x = 595;
            chips[27].y = 443;
            chips[28].x = 643;
            chips[28].y = 478;
            chips[29].x = 698;
            chips[29].y = 490;
            chips[30].x = 753;
            chips[30].y = 472;
            chips[31].x = 787;
            chips[31].y = 429;
            chips[32].x = 782;
            chips[32].y = 373;
            chips[33].x = 753;
            chips[33].y = 322;
            chips[34].x = 712;
            chips[34].y = 279;
            chips[35].x = 671;
            chips[35].y = 243;
            chips[36].x = 619;
            chips[36].y = 216;
            chips[37].x = 565;
            chips[37].y = 197;
            chips[38].x = 505;
            chips[38].y = 186;
            chips[39].x = 456;
            chips[39].y = 171;
            chips[40].x = 415;
            chips[40].y = 130;
            chips[41].x = 427;
            chips[41].y = 76;
            chips[42].x = 478;
            chips[42].y = 53;
            chips[43].x = 537;
            chips[43].y = 45;
            chips[44].x = 594;
            chips[44].y = 46;
            chips[45].x = 651;
            chips[45].y = 52;
            chips[46].x = 76;
            chips[46].y = 70;
            chips[47].x = 756;
            chips[47].y = 99;
            chips[48].x = 797;
            chips[48].y = 139;
            chips[49].x = 818;
            chips[49].y = 191;
            chips[50].x = 837;
            chips[50].y = 249;
            chips[51].x = 843;
            chips[51].y = 307;
            chips[52].x = 844;
            chips[52].y = 364;
            chips[53].x = 842;
            chips[53].y = 423;
            chips[54].x = 842;
            chips[54].y = 481;
            chips[55].x = 841;
            chips[55].y = 538;
            chips[56].x = 842;
            chips[56].y = 596;
            chips[57].x = 880;
            chips[57].y = 635;
            chips[58].x = 937;
            chips[58].y = 628;
            chips[59].x = 989;
            chips[59].y = 598;
            chips[60].x = 1023;
            chips[60].y = 543;
            chips[61].x = 1038;
            chips[61].y = 480;
            chips[62].x = 1045;
            chips[62].y = 414;
            chips[63].x = 1045;
            chips[63].y = 347;
            chips[64].x = 1048;
            chips[64].y = 281;
            chips[65].x = 1054;
            chips[65].y = 216;
            chips[66].x = 1064;
            chips[66].y = 153;
            chips[67].x = 1090;
            chips[67].y = 107;

            if (_users == 0)
            {
                this.pictureBox2.Location = new System.Drawing.Point(chips[_position - 1].x, chips[_position - 1].y);
            }
            if (_users == 1)
            {
                this.pictureBox3.Location = new System.Drawing.Point(chips[_position - 1].x+2, chips[_position - 1].y+2);
            }
        }
        struct Chips
        {
            public int x;
            public int y;
        }

    }

    public class users
    {
        private int position;
        private int step_count;
        private byte step_skip;
        private byte name_users;
        //private byte step_extra;

        public delegate void MyDel(object sender, UsersEventArgs e);
        public delegate void MyDel1(object sender,Users1EventArgs e);

        //событие шага. Выдача на сколько шагов перешли и новую позицию
        public event MyDel Steping;
        //событие пропуска шага
        public event MyDel1 SkipStep;
        //событие перехода
        public event MyDel1 Transition;
        //событие дополнительного шага
        public event MyDel1 ExtraStep;
        //событие конца игры
        public event MyDel1 Winner;

        public users(int _name_users)
        {
            position = 0;
            step_count = 0;
            name_users = (byte)_name_users;
        }
        public void do_step()
        {
            Users1EventArgs ev = new Users1EventArgs(name_users);
            if (step_skip == 0)
            {
                Random rnd = new Random();
                byte _count = (byte)rnd.Next(1, 6);
                if ((position+_count)>=120)
                {
                    position = 24 + (_count - (119 - position));
                }
                else
                    if ((position + _count) >= 406)
                    {
                        position = 34 + (_count - (405 - position));
                    }
                    else
                        if ((position + _count) >= 512)
                        {
                            position = 57 + (_count - (511 - position));
                        }
                        else
                            if ((position + _count) >= 406)
                            {
                                position = 34 + (_count - (405 - position));
                            }
                            else
                                if ((position + _count) >= 308)
                                {
                                    position = 23 + (_count - (307 - position));
                                }
                                else
                                    if ((position + _count) >= 204)
                                    {
                                        position = 103 + (_count - (203 - position));
                                    }
                                    else
                                        position += _count;
                step_count++;
                //проверка на пропуск хода
                if ((position==9)||(position==19)||(position==64)||(position==109)||(position==507))
                {
                    step_skip=1;
                }
                //проверка на пропуск двух ходов
                if ((position == 16) || (position == 115) || (position == 403) || (position == 59))
                {
                    step_skip=2;
                }
                //проверка на дополнительный ход
                if ((position == 305) || (position == 117) || (position == 44) || (position == 37) || (position == 52))
                {
                    //do_step();
                    //при событии повторного шага - установить в МЕЙНЕ флаг, что необходим еще один ход. И не инкрементировать пользователя.
                    if (ExtraStep != null)
                    {
                        ExtraStep(this,ev);
                    }
                }
                //проверка на конец игры
                if (position==68)
                    {
                        if (Winner!=null)
                        {
                            Winner(this,ev);
                        }
                    }
                //проверка на переход
                switch(position)
                {
                    case 3:
                        {
                            position = 101;
                            if (Transition != null)
                            {
                                Transition(this,ev);
                            }
                            break;
                        }
                    case 5:
                        {
                            position = 201;
                            if (Transition != null)
                            {
                                Transition(this,ev);
                            }
                            break;
                        }
                    case 21:
                        {
                            position = 301;
                            if (Transition != null)
                            {
                                Transition(this,ev);
                            }
                            break;
                        }
                    case 26:
                        {
                            position = 401;
                            if (Transition != null)
                            {
                                Transition(this,ev);
                            }
                            break;
                        }
                    case 50:
                        {
                            position = 501;
                            if (Transition != null)
                            {
                                Transition(this,ev);
                            }
                            break;
                        }
                    case 105:
                        {
                            position = 106;
                            if (Transition != null)
                            {
                                Transition(this,ev);
                            }
                            break;
                        }
                    //case 203:
                    //    {
                    //        position = 103;
                    //        if (Transition != null)
                    //       {
                    //            Transition(this, ev);
                    //        }
                    //        break;
                    //   }
                    //case 119:
                    //    {
                    //        position = 24;
                    //        if (Transition != null)
                    //        {
                    //           Transition(this,ev);
                    //        }
                    //        break;
                    //    }
                    case 40:
                        {
                            position = 112;
                            if (Transition != null)
                            {
                                Transition(this,ev);
                            }
                            break;
                        }
                    case 39:
                        {
                            position = 46;
                            if (Transition != null)
                            {
                                Transition(this,ev);
                            }
                            break;
                        }
                    case 49:
                        {
                            position = 36;
                            if (Transition != null)
                            {
                                Transition(this, ev);
                            }
                            break;
                        }
                    case 35:
                        {
                            position = 51;
                            if (Transition != null)
                            {
                                Transition(this, ev);
                            }
                            break;
                        }
                    case 31:
                        {
                            position = 12;
                            if (Transition != null)
                            {
                                Transition(this, ev);
                            }
                            break;
                        }
                }
                if (Steping!=null)
                {
                    UsersEventArgs ev1 = new UsersEventArgs(name_users, step_count,_count, position);
                    Steping(this,ev1);
                }
            }
            else
            {
                step_skip--;
                if (SkipStep != null)
                {
                    SkipStep(this, ev);
                }
            }
        }
    }

    public class UsersEventArgs : EventArgs
    {
        public UsersEventArgs(byte _NameUser, int _step,byte _step_count,int _position)
        {
            Step = _step;
            StepCount = _step_count;
            Position = _position;
            NameUser = _NameUser;
        }
        public int Step { get; set; }
        public int Position { get; set; }

        public byte NameUser { get; set; }
        public byte StepCount { get; set; }
    }
    public class Users1EventArgs : EventArgs
    {
        public Users1EventArgs(byte _NameUser)
        {
            NameUser = _NameUser;
        }
        public byte NameUser { get; set; }
    }
}
