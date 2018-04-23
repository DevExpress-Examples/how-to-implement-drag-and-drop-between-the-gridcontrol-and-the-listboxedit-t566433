using System.Windows;
using System.Collections.ObjectModel;
using DevExpress.Xpf.Core;

namespace How_to_Drag_and_Drop_Between_GridControl_and_ListBoxEdit {
    public partial class MainWindow : Window {
        public class Employee {
            public int ID { get; set; }
            public string Name { get; set; }
            public string Position { get; set; }
            public string Department { get; set; }
            public override string ToString() {
                return Name;
            }
        }

        public static class Stuff {
            public static ObservableCollection<Employee> GetStuff1() {
                ObservableCollection<Employee> stuff = new ObservableCollection<Employee>();
                stuff.Add(new Employee() { ID = 1, Name = "Gregory S. Price", Department = "", Position = "President" });
                stuff.Add(new Employee() { ID = 2, Name = "Irma R. Marshall", Department = "Marketing", Position = "Vice President" });
                stuff.Add(new Employee() { ID = 3, Name = "John C. Powell", Department = "Operations", Position = "Vice President" });
                stuff.Add(new Employee() { ID = 4, Name = "Christian P. Laclair", Department = "Production", Position = "Vice President" });
                stuff.Add(new Employee() { ID = 5, Name = "Karen J. Kelly", Department = "Finance", Position = "Vice President" });

                stuff.Add(new Employee() { ID = 6, Name = "Brian C. Cowling", Department = "Marketing", Position = "Manager" });
                stuff.Add(new Employee() { ID = 7, Name = "Thomas C. Dawson", Department = "Marketing", Position = "Manager" });
                stuff.Add(new Employee() { ID = 8, Name = "Angel M. Wilson", Department = "Marketing", Position = "Manager" });
                stuff.Add(new Employee() { ID = 9, Name = "Bryan R. Henderson", Department = "Marketing", Position = "Manager" });
                return stuff;
            }

            public static ObservableCollection<Employee> GetStuff2() {
                ObservableCollection<Employee> stuff = new ObservableCollection<Employee>();
                stuff.Add(new Employee() { ID = 10, Name = "Harold S. Brandes", Department = "Operations", Position = "Manager" });
                stuff.Add(new Employee() { ID = 11, Name = "Michael S. Blevins", Department = "Operations", Position = "Manager" });
                stuff.Add(new Employee() { ID = 12, Name = "Jan K. Sisk", Department = "Operations", Position = "Manager" });
                stuff.Add(new Employee() { ID = 13, Name = "Sidney L. Holder", Department = "Operations", Position = "Manager" });

                stuff.Add(new Employee() { ID = 14, Name = "James L. Kelsey", Department = "Production", Position = "Manager" });
                stuff.Add(new Employee() { ID = 15, Name = "Howard M. Carpenter", Department = "Production", Position = "Manager" });
                stuff.Add(new Employee() { ID = 16, Name = "Jennifer T. Tapia", Department = "Production", Position = "Manager" });

                stuff.Add(new Employee() { ID = 17, Name = "Judith P. Underhill", Department = "Finance", Position = "Manager" });
                stuff.Add(new Employee() { ID = 18, Name = "Russell E. Belton", Department = "Finance", Position = "Manager" });
                return stuff;
            }
        }
        public MainWindow() {
            InitializeComponent();
            gridControl.ItemsSource = Stuff.GetStuff1();
            listBoxEdit.ItemsSource = Stuff.GetStuff2();
        }

        void OnDragRecordOver(object sender, DragRecordOverEventArgs e) {
            if (e.IsFromOutside && typeof(Employee).IsAssignableFrom(e.GetRecordType())) {
                e.Effects = DragDropEffects.Move;
                e.Handled = true;
            }
        }
    }
}