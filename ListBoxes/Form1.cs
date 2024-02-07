using System.Collections;

namespace ListBoxes
{
    public partial class Form1 : Form
    {
        readonly string[] someData = ["Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота", "Воскресенье"];

        public Form1()
        {
            InitializeComponent();
            foreach (var item in someData)
            {
                LeftList.Items.Add(item);
            }
            OnSelect();

            SelectedToLeft.Click += (sender, args) => MoveSelectedToLeft();
            SelectedToRight.Click += (sender, args) => MoveSelectedToRight();
            AllToLeft.Click += (sender, args) => MoveAllToLeft();
            AllToRight.Click += (sender, args) => MoveAllToRight();
            LeftList.SelectedValueChanged += (sender, args) => OnSelect();
            RightList.SelectedValueChanged += (sender, args) => OnSelect();
        }

        private void MoveSelectedToRight()
        {
            MoveItems(LeftList, RightList, LeftList.SelectedItems);
            if (LeftList.Items.Count == 0)
            {
                AllToRight.Enabled = false;
                SelectedToRight.Enabled = false;
            }
            AllToLeft.Enabled = true;
        }

        private void MoveSelectedToLeft()
        {
            MoveItems(RightList, LeftList, RightList.SelectedItems);
            if (RightList.Items.Count == 0)
            {
                AllToLeft.Enabled = false;
                SelectedToLeft.Enabled = false;
            }
            AllToRight.Enabled = true;
        }


        private void MoveAllToRight()
        {
            LeftList.SelectedItems.Clear();
            for (var i = 0; i < LeftList.Items.Count; i++)
            {
                LeftList.SelectedItems.Add(LeftList.Items[i]);
            }
            MoveItems(LeftList, RightList, LeftList.Items);
            AllToRight.Enabled = false;
            SelectedToRight.Enabled = false;
            AllToLeft.Enabled = true;
        }

        private void MoveAllToLeft()
        {
            RightList.SelectedItems.Clear();
            for (var i = 0; i < LeftList.Items.Count; i++)
            {
                RightList.SelectedItems.Add(LeftList.Items[i]);
            }
            MoveItems(RightList, LeftList, RightList.Items);
            AllToLeft.Enabled = false;
            SelectedToRight.Enabled = false;
            AllToRight.Enabled = true;
        }

        private void MoveItems<T>(ListBox from, ListBox to, T items)
            where T : IList
        {
            while (items.Count > 0)
            {
                var item = items[0];
                from.Items.Remove(item);
                to.Items.Add(item);
            }
        }

        private void OnSelect()
        {
            SelectedToRight.Enabled = LeftList.SelectedItems.Count > 0;
            AllToRight.Enabled = LeftList.Items.Count > 0;

            SelectedToLeft.Enabled = RightList.SelectedItems.Count > 0;
            AllToLeft.Enabled = RightList.Items.Count > 0;
        }
    }
}
