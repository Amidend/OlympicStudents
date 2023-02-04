﻿using Microsoft.Data.Sqlite;
using StudentInfo;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlympicStudents
{
    internal abstract class Adapter
    {
        public static void InitializeListViewSudent(ListView listView)
        {
            listView.Clear();
            listView.View = View.Details;
            listView.GridLines = true;
            listView.FullRowSelect = true;
            listView.Columns.AddRange(new[]
            {
            new ColumnHeader {Text = "ФИО"},
            new ColumnHeader {Text = "Дата рождения"},
            new ColumnHeader {Text = "Адрес"},
            new ColumnHeader {Text = "Номер телефона"},
            new ColumnHeader {Text = "Группа"},
            new ColumnHeader {Text = "Дата поступления"},
            new ColumnHeader {Text = "Дата выпуска"},
            new ColumnHeader {Text = "Курс"},
            new ColumnHeader {Text = "Специализация"}
            });
            int columnWidth = listView.ClientSize.Width / listView.Columns.Count;
            for (int i = 0; i < listView.Columns.Count; i++)
            {
                listView.Columns[i].Width = columnWidth;
            }
            listView.ColumnClick += (sender, e) =>
            {
                var list = (ListView)sender;
                list.ListViewItemSorter = new ListViewItemComparer(e.Column);
            };
        }
        public static void InitializeListViewOlimpiads(ListView listView)
        {
            listView.Clear();
            listView.View = View.Details;
            listView.GridLines = true;
            listView.FullRowSelect = true;
            listView.Columns.AddRange(new[]
            {
            new ColumnHeader {Text = "Дата"},
            new ColumnHeader {Text = "Уровень"},
            new ColumnHeader {Text = "Вид"},
            new ColumnHeader {Text = "Награда"},
            new ColumnHeader {Text = "Поощерение"},
            new ColumnHeader {Text = "Номинации"},
            new ColumnHeader {Text = "Продалжительность"},
            new ColumnHeader {Text = "Название"},
            new ColumnHeader {Text = "Место проведения"},
            new ColumnHeader {Text = "id"},
            });
            int columnWidth = listView.ClientSize.Width / (listView.Columns.Count - 1);
            for (int i = 0; i < listView.Columns.Count - 1; i++)
            {
                listView.Columns[i].Width = columnWidth;
            }
            listView.Columns[listView.Columns.Count - 1].Width = 0;
            listView.ColumnClick += (sender, e) =>
            {
                var list = (ListView)sender;
                list.ListViewItemSorter = new ListViewItemComparer(e.Column);
            };
        }
        public static async Task FillStudentListVewAsync(ListView listViewStudent)
        {
            var items = await DataBase.GetAllFromTableAsync("student", 9);
            foreach (var item in items)
            {
                listViewStudent.Items.Add(item);
            }
        }
        public static async Task FillOlimpiadsListVewAsync(ListView listViewStudent)
        {
            var items = await DataBase.GetAllFromTableAsync("olympiad", 10);
            foreach (var item in items)
            {
                listViewStudent.Items.Add(item);
            }
        }
        public static async Task StudentOlympiadsAsync(ListView listViewStudent,int id)
        {
            var items = await DataBase.GetAllOlympiadsByStudentIdAsync(id);
            foreach (var item in items)
            {
                listViewStudent.Items.Add(item);
            }
        }
        public static async Task SearchByStudetsCategories() 
        { 
        
        
        }
    }
    class ListViewItemComparer : IComparer
    {
        private int col;
        public ListViewItemComparer()
        {
            col = 0;
        }
        public ListViewItemComparer(int column)
        {
            col = column;
        }
        public int Compare(object x, object y)
        {
            return String.Compare(((ListViewItem)x).SubItems[col].Text, ((ListViewItem)y).SubItems[col].Text);
        }
    }
}
