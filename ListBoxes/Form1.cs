using System.Collections;

namespace ListBoxes
{
    public partial class Form1 : Form
    {
        private readonly string[] someData = ["Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота", "Воскресенье"];
        private ListBox? draggedFrom;

        public Form1()
        {
            InitializeComponent();
            foreach (var item in someData)
            {
                LeftList.Items.Add(item);
            }
            OnChange();

            SelectedToLeft.Click += (sender, args) => MoveItems(RightList, LeftList, RightList.SelectedItems);
            SelectedToRight.Click += (sender, args) => MoveItems(LeftList, RightList, LeftList.SelectedItems);
            AllToLeft.Click += (sender, args) => MoveAllToLeft();
            AllToRight.Click += (sender, args) => MoveAllToRight();

            LeftList.MouseDown += OnMouseDown;
            LeftList.DragEnter += OnDragEnter;
            LeftList.DragDrop += OnDragDrop;

            RightList.MouseDown += OnMouseDown;
            RightList.DragEnter += OnDragEnter;
            RightList.DragDrop += OnDragDrop;
        }

        private void MoveAllToRight()
        {
            LeftList.SelectedItems.Clear();
            for (var i = 0; i < LeftList.Items.Count; i++)
            {
                LeftList.SelectedItems.Add(LeftList.Items[i]);
            }
            MoveItems(LeftList, RightList, LeftList.Items);
        }

        private void MoveAllToLeft()
        {
            RightList.SelectedItems.Clear();
            for (var i = 0; i < LeftList.Items.Count; i++)
            {
                RightList.SelectedItems.Add(LeftList.Items[i]);
            }
            MoveItems(RightList, LeftList, RightList.Items);
        }

        private void MoveItems<T>(ListBox from, ListBox to, T items)
            where T : IList
        {
            while (items.Count > 0)
            {
                var item = items[0];
                from.Items.Remove(item!);
                to.Items.Add(item!);
            }
            OnChange();
        }

        private void OnMouseDown(object? sender, MouseEventArgs args)
        {
            OnChange();
            if (sender is ListBox list)
            {
                draggedFrom = list;
                list.DoDragDrop(list.SelectedItems, DragDropEffects.Copy);
            }
        }

        private void OnDragEnter(object? sender, DragEventArgs args)
        {
            args.Effect = DragDropEffects.Copy;
        }

        private void OnDragDrop(object? sender, DragEventArgs args)
        {
            if (sender is ListBox list && list != draggedFrom)
            {
                var dragged = args.Data!.GetData(typeof(ListBox.SelectedObjectCollection)) as ListBox.SelectedObjectCollection;
                while (dragged!.Count > 0)
                {
                    list.Items.Add(dragged[0]!);
                    draggedFrom!.Items.Remove(dragged[0]!);
                }
                OnChange();
            }
        }

        private void OnChange()
        {
            SelectedToRight.Enabled = LeftList.SelectedItems.Count > 0;
            AllToRight.Enabled = LeftList.Items.Count > 0;

            SelectedToLeft.Enabled = RightList.SelectedItems.Count > 0;
            AllToLeft.Enabled = RightList.Items.Count > 0;
        }
    }
}
