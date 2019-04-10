using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrelloApp
{
    public partial class ManagerioMainWindow : Form
    {
        public Day[] AllDays = new Day[7];

        public ManagerioMainWindow()
        {
            AllDays[0] = new Day("Monday",0);
            AllDays[1] = new Day("Tuesday",1);
            AllDays[2] = new Day("Wednesday",2);
            AllDays[3] = new Day("Thursday",3);
            AllDays[4] = new Day("Friday",4);
            AllDays[5] = new Day("Saturday",5);
            AllDays[6] = new Day("Sunday",6);
            InitializeComponent();
            FillComboBox();

            //Task add and removal done
            //Need to add button to add task at runtime.
            Task t = new Task("Download Ready Player One in 720P");
            Task t3 = new Task("Task3");
            Task t2 = new Task("Task2");
            Task t4 = new Task("Task4");
            AddTask(0, t);
            AddTask(0, t3);
            AddTask(0, t2);
            RemoveTask(0, "Task3");
            AddTask(0, t3);
            RemoveTask(0, "Task3");
            AddTask(0, t4);
        }

        void FillComboBox()
        {
            for(int i=0; i< AllDays.Length; i++)
            {
                DaySelectionComboBox.Items.Add(AllDays[i].DayName);
            }
        }

        GroupBox FindGroupBox(int DayIndex)
        {
            switch(DayIndex)
            {
                case 0:
                    {
                        return MondayGB;
                    }
                case 1:
                    {
                        return TuesdayGB;
                    }
                case 2:
                    {
                        return WednesdayGB;
                    }
                case 3:
                    {
                        return ThursdayGB;
                    }
                case 4:
                    {
                        return FridayGB;
                    }
                case 5:
                    {
                        return SaturdayGB;
                    }
                default:
                case 6:
                    {
                        return SundayGB;
                    }
            }
        }

        public void RemoveTask(int DayIndex, string TName)
        {
            if (AllDays[DayIndex].TList.Count > 0)
            {
                for (int i = 0; i < AllDays[DayIndex].TList.Count; i++)
                {
                    if (AllDays[DayIndex].TList[i].TaskName == TName)
                    {
                        AllDays[DayIndex].TList.RemoveAt(i);
                        GroupBox dBox = FindGroupBox(DayIndex);
                        dBox.Controls.RemoveByKey(TName);
                        AllDays[DayIndex].YOffset -= 60;
                        for(int j = i; j <dBox.Controls.Count ; j++)
                        {
                            Point newLoc = new Point(dBox.Controls[j].Location.X, dBox.Controls[j].Location.Y - 60);
                            dBox.Controls[j].Location = newLoc;
                        }
                        break;
                    }
                }
            }
        }

        public void AddTask(int DayIndex, Task T)
        {
            if(AllDays[DayIndex].TList.Count < 9)
            {
                AllDays[DayIndex].TList.Add(T);
                Label TaskLabel = new Label();
                //Defining settings for label
                TaskLabel.BackColor = Color.White;
                TaskLabel.Name = T.TaskName;
                TaskLabel.Location = new Point(10, 20 + AllDays[DayIndex].YOffset);
                TaskLabel.MinimumSize = new Size(160, 50);
                TaskLabel.AutoSize = false;
                TaskLabel.Dock = DockStyle.None;
                TaskLabel.Anchor = (AnchorStyles.Top | AnchorStyles.Left);
                TaskLabel.Size = new Size(160, 50);
                TaskLabel.Text = T.TaskName;
                TaskLabel.TextAlign = ContentAlignment.MiddleCenter;
                FindGroupBox(DayIndex).Controls.Add(TaskLabel);
                AllDays[DayIndex].YOffset += 60;
            }
        }
    }
}
