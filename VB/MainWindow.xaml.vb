Imports System.Windows
Imports System.Collections.ObjectModel
Imports DevExpress.Xpf.Core

Namespace How_to_Drag_and_Drop_Between_GridControl_and_ListBoxEdit
    Partial Public Class MainWindow
        Inherits Window

        Public Class Employee
            Public Property ID() As Integer
            Public Property Name() As String
            Public Property Position() As String
            Public Property Department() As String
            Public Overrides Function ToString() As String
                Return Name
            End Function
        End Class

        Public NotInheritable Class Stuff

            Private Sub New()
            End Sub

            Public Shared Function GetStuff1() As ObservableCollection(Of Employee)

                Dim stuff_Renamed As New ObservableCollection(Of Employee)()
                stuff_Renamed.Add(New Employee() With { _
                    .ID = 1, _
                    .Name = "Gregory S. Price", _
                    .Department = "", _
                    .Position = "President" _
                })
                stuff_Renamed.Add(New Employee() With { _
                    .ID = 2, _
                    .Name = "Irma R. Marshall", _
                    .Department = "Marketing", _
                    .Position = "Vice President" _
                })
                stuff_Renamed.Add(New Employee() With { _
                    .ID = 3, _
                    .Name = "John C. Powell", _
                    .Department = "Operations", _
                    .Position = "Vice President" _
                })
                stuff_Renamed.Add(New Employee() With { _
                    .ID = 4, _
                    .Name = "Christian P. Laclair", _
                    .Department = "Production", _
                    .Position = "Vice President" _
                })
                stuff_Renamed.Add(New Employee() With { _
                    .ID = 5, _
                    .Name = "Karen J. Kelly", _
                    .Department = "Finance", _
                    .Position = "Vice President" _
                })

                stuff_Renamed.Add(New Employee() With { _
                    .ID = 6, _
                    .Name = "Brian C. Cowling", _
                    .Department = "Marketing", _
                    .Position = "Manager" _
                })
                stuff_Renamed.Add(New Employee() With { _
                    .ID = 7, _
                    .Name = "Thomas C. Dawson", _
                    .Department = "Marketing", _
                    .Position = "Manager" _
                })
                stuff_Renamed.Add(New Employee() With { _
                    .ID = 8, _
                    .Name = "Angel M. Wilson", _
                    .Department = "Marketing", _
                    .Position = "Manager" _
                })
                stuff_Renamed.Add(New Employee() With { _
                    .ID = 9, _
                    .Name = "Bryan R. Henderson", _
                    .Department = "Marketing", _
                    .Position = "Manager" _
                })
                Return stuff_Renamed
            End Function

            Public Shared Function GetStuff2() As ObservableCollection(Of Employee)

                Dim stuff_Renamed As New ObservableCollection(Of Employee)()
                stuff_Renamed.Add(New Employee() With { _
                    .ID = 10, _
                    .Name = "Harold S. Brandes", _
                    .Department = "Operations", _
                    .Position = "Manager" _
                })
                stuff_Renamed.Add(New Employee() With { _
                    .ID = 11, _
                    .Name = "Michael S. Blevins", _
                    .Department = "Operations", _
                    .Position = "Manager" _
                })
                stuff_Renamed.Add(New Employee() With { _
                    .ID = 12, _
                    .Name = "Jan K. Sisk", _
                    .Department = "Operations", _
                    .Position = "Manager" _
                })
                stuff_Renamed.Add(New Employee() With { _
                    .ID = 13, _
                    .Name = "Sidney L. Holder", _
                    .Department = "Operations", _
                    .Position = "Manager" _
                })

                stuff_Renamed.Add(New Employee() With { _
                    .ID = 14, _
                    .Name = "James L. Kelsey", _
                    .Department = "Production", _
                    .Position = "Manager" _
                })
                stuff_Renamed.Add(New Employee() With { _
                    .ID = 15, _
                    .Name = "Howard M. Carpenter", _
                    .Department = "Production", _
                    .Position = "Manager" _
                })
                stuff_Renamed.Add(New Employee() With { _
                    .ID = 16, _
                    .Name = "Jennifer T. Tapia", _
                    .Department = "Production", _
                    .Position = "Manager" _
                })

                stuff_Renamed.Add(New Employee() With { _
                    .ID = 17, _
                    .Name = "Judith P. Underhill", _
                    .Department = "Finance", _
                    .Position = "Manager" _
                })
                stuff_Renamed.Add(New Employee() With { _
                    .ID = 18, _
                    .Name = "Russell E. Belton", _
                    .Department = "Finance", _
                    .Position = "Manager" _
                })
                Return stuff_Renamed
            End Function
        End Class
        Public Sub New()
            InitializeComponent()
            gridControl.ItemsSource = Stuff.GetStuff1()
            listBoxEdit.ItemsSource = Stuff.GetStuff2()
        End Sub

        Private Sub OnDragRecordOver(ByVal sender As Object, ByVal e As DragRecordOverEventArgs)
            If e.IsFromOutside AndAlso GetType(Employee).IsAssignableFrom(e.GetRecordType()) Then
                e.Effects = DragDropEffects.Move
                e.Handled = True
            End If
        End Sub
    End Class
End Namespace