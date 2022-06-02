using DevExpress.Xpf.Core;
using System.Windows;

namespace How_to_Drag_and_Drop_Between_GridControl_and_ListBoxEdit {
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
            gridControl.ItemsSource = Staff.GetStaff1();
            listBoxEdit.ItemsSource = Staff.GetStaff2();
        }

        void OnDragRecordOver(object sender, DragRecordOverEventArgs e) {
            if (e.IsFromOutside && typeof(Employee).IsAssignableFrom(e.GetRecordType())) {
                e.Effects = DragDropEffects.Move;
                e.Handled = true;
            }
        }
    }
}