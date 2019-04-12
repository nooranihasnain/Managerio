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
            
        }

        void FillComboBox()
        {
            for(int i=0; i< AllDays.Length; i++)
            {
                DaySelectionComboBox.Items.Add(AllDays[i].DayName);
            }
            DaySelectionComboBox.SelectedIndex = 0;
        }

        bool IsPresent(int DayIndex, string TaskName)
        {
            for(int i=0; i < AllDays[DayIndex].TList.Count; i++)
            {
                if(AllDays[DayIndex].TList[i].TaskName == TaskName)
                {
                    return true;
                }
            }
            return false;
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
                        //dBox.Controls.RemoveByKey(TName);
                        dBox.Controls.RemoveAt(i);
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
            if(!IsPresent(DayIndex,T.TaskName))
            {
                if(AllDays[DayIndex].TList.Count < 9)
                {
                    AllDays[DayIndex].TList.Add(T);
                    //Trying out buttons
                    Button TaskButton = new Button();
                    TaskButton.BackColor = Color.White;
                    TaskButton.Text = T.TaskName;
                    TaskButton.Location = new Point(10, 20 + AllDays[DayIndex].YOffset);
                    TaskButton.MinimumSize = new Size(160, 50);
                    TaskButton.AutoSize = false;
                    TaskButton.Dock = DockStyle.None;
                    TaskButton.Anchor = (AnchorStyles.Top | AnchorStyles.Left);
                    TaskButton.Size = new Size(160, 50);
                    TaskButton.TextAlign = ContentAlignment.MiddleCenter;
                    TaskButton.Click += new EventHandler(DeleteTask_Click);
                    FindGroupBox(DayIndex).Controls.Add(TaskButton);
                    AllDays[DayIndex].YOffset += 60;
                }
                else
                {
                    MessageBox.Show("Oof! No more space for additional tasks!", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Oof! The task is already in the day with the same name.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(TaskInputTextBox.Text))
            {
                Task addTask = new Task(TaskInputTextBox.Text);
                AddTask(DaySelectionComboBox.SelectedIndex, addTask);
            }
            else
            {
                MessageBox.Show("Task name can not be empty", "Empty task name",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DeleteTask_Click(object sender, EventArgs e)
        {
            Button aButton = sender as Button;
            string TaskName = aButton.Text;
            string Day = aButton.Parent.Text;
            int DayIndex = 0;
            for (int i = 0; i < AllDays.Length; i++)
            {
                if(AllDays[i].DayName == Day)
                {
                    DayIndex = i;
                    break;
                }
            }
            RemoveTask(DayIndex, TaskName);
        }
    }
}
