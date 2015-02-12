using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace Game_Database
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            YARTE.UI.Buttons.PredefinedButtonSets.SetupDefaultButtons(this.gameNoteBox);
        }

        #region Startup

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            SetAspects();
            LoadListNames();
            if (listNameViewer.GetItemCount() > 0)
            {
                listNameViewer.SelectedIndex = 0;
            }
            if (gameListViewer.GetItemCount() > 0)
            {
                gameListViewer.SelectedIndex = 0;
            }

            LoadSettings();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            SaveSettings();
        }

        public void SetAspects()
        {
            RatingCol.AspectToStringConverter = delegate(object dat)
            {
                return string.Format("{0:0.0}", dat);
            };
            TypeCol.AspectToStringConverter = delegate(object dat)
            {
                return dat.ToString().Replace('_', ' ');
            };
            itemCountCol.AspectGetter = delegate(object obj)
            {
                return ((ListName)obj).database.Count;
            };
        }

        private void ListViewer_FormatCell(object sender, BrightIdeasSoftware.FormatCellEventArgs e)
        {
            Color fore = Color.Black;
            float size = 9.0F;
            string family = "Segoe UI";

            if (e.Column == listNameViewerCol)
            {
                family = "Segoe UI Semibold";
                size = 9.5F;
            }
            else if (e.Column == itemCountCol)
            {
                size = 8.25F;
                fore = Color.Gray;
            }
            else if (e.Column == NameCol)
            {
                family = "Segoe UI Semibold";
                size = 9.5F;
            }
            else if (e.Column == RatingCol)
            {
                family = "Consolas";
                size = 10F;
                fore = Color.Navy;
            }
            else
            {
                return;
            }

            e.SubItem.ForeColor = fore;
            e.SubItem.Font = new Font(family, size);
        }

        #endregion

        #region Local Directory

        public static string DefExt
        {
            get { return ".ssgdbl"; }
        }

        public static string GetDirectory()
        {
            string doc = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string company = Path.Combine(doc, "Sand Soft");
            string path = Path.Combine(company, "Game Database");
            Directory.CreateDirectory(path);
            return path;
        }

        public static string GetList(string name)
        {
            return Path.Combine(GetDirectory(), name + DefExt);
        }

        public static bool isNameValid(string name)
        {
            foreach (char ch in Path.GetInvalidFileNameChars())
            {
                if (name.Contains(ch.ToString())) return false;
            }
            return true;
        }

        public static void CopyFile(string source, string dest = null)
        {
            if (dest == null)
            {
                string name = Path.GetFileNameWithoutExtension(source);
                dest = Path.Combine(GetDirectory(), name);
            }

            if (File.Exists(dest + DefExt))
            {
                int i = 2;
                string tmp = dest + " (" + i + ")";
                while (File.Exists(tmp))
                {
                    ++i;
                    tmp = dest + " (" + i + ")";
                }
                dest = tmp;
            }

            dest += DefExt;
            File.Copy(source, dest, true);
        }


        #endregion

        #region List Name Class

        public class ListName
        {
            public ListName(string file)
            {
                path = file;
                LoadList();
            }

            public string name { get; set; }
            public string path { get; set; }
            public List<GameInfo> database;

            private bool saving = false;

            private void save(object state)
            {
                saving = true;
                string content = Newtonsoft.Json.JsonConvert.SerializeObject(database);
                File.WriteAllText(path, content);
                saving = false;
            }

            public void SaveList()
            {
                if (saving) return;
                System.Threading.ThreadPool.QueueUserWorkItem(save);
            }

            public void Delete()
            {
                database.Clear();
                File.Delete(path);
            }

            public bool Rename(string newName)
            {
                if (!isNameValid(newName)) return false;
                string newPath = Path.GetDirectoryName(path);                
                newPath = Path.Combine(newPath, newName + DefExt);
                if (File.Exists(newPath)) return false;
                File.Copy(path, newPath, true);
                File.Delete(path);
                path = newPath;
                name = newName;
                return true;
            }

            public void LoadList()
            {
                name = Path.GetFileNameWithoutExtension(path);
                string content = File.ReadAllText(path);
                database = Newtonsoft.Json.JsonConvert.DeserializeObject<List<GameInfo>>(content);

            }
        }

        #endregion

        #region List Names

        List<ListName> listNames = new List<ListName>();

        public void LoadListNames()
        {
            listNames.Clear();
            foreach (string file in Directory.GetFiles(GetDirectory()))
            {
                try
                {
                    listNames.Add(new ListName(file));
                }
                catch { }
            }
            listNameViewer.SetObjects(listNames, true);
        }

        public void AddList()
        {
            string name = listNameBox.Text;
            if (!isNameValid(name))
            {
                string msg = "List name is not valid. Please avoid using following characters : ";
                msg += Environment.NewLine;
                foreach (char ch in Path.GetInvalidFileNameChars())
                {
                    msg += ch + " ";
                }
                MessageBox.Show(msg);
                return;
            }

            string file = GetList(name);
            if (File.Exists(file))
            {
                string msg = "Another list with the same name already existed.";
                MessageBox.Show(msg);
                return;
            }

            listNameBox.Clear();
            File.WriteAllText(file, "[]");
            listNames.Add(new ListName(file));
            listNameViewer.SetObjects(listNames);
        }

        private void listAddButton_Click(object sender, EventArgs e)
        {
            AddList();
        }

        private void listNameBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                AddList();
            }
        }

        private void listNameViewer_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadGameList((ListName)listNameViewer.SelectedObject);
        }

        private void listNameViewer_CellEditStarting(object sender, BrightIdeasSoftware.CellEditEventArgs e)
        {
            if (e.Column != listNameViewerCol)
            {
                return;
            }
        }

        private void listNameViewer_CellEditFinishing(object sender, BrightIdeasSoftware.CellEditEventArgs e)
        {
            if (e.Column == listNameViewerCol)
            {
                var ln = (ListName)e.RowObject;
                e.Cancel = !ln.Rename((string)e.NewValue);
                listNameViewer.SetObjects(listNames); 
            }
        }

        private void listNameViewer_CellEditValidating(object sender, BrightIdeasSoftware.CellEditEventArgs e)
        {
            e.Cancel = !isNameValid((string)e.NewValue);
        }

        #endregion

        #region Game Database List

        public ListName selectedList;

        public void LoadGameList(ListName list)
        {
            LoadNote(null);
            selectedList = list;

            if (list == null)
            {
                gameListViewer.ClearObjects();
                gameLabel.Text = (string)gameLabel.Tag;
            }
            else
            {
                gameListViewer.SetObjects(list.database, false);
                gameLabel.Text = list.name;
            }
        }

        private void gameListViewer_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadNote((GameInfo)gameListViewer.SelectedObject);
        }


        private void addGameButton_Click(object sender, EventArgs e)
        {
            if (selectedList == null)
            {
                MessageBox.Show("Select a game list first");
            }
            else
            {
                selectedList.database.Add(new GameInfo());
                selectedList.SaveList();
                LoadGameList(selectedList);
                listNameViewer.SetObjects(listNames, true);
            }
        }


        private void removeSelectedButton_Click(object sender, EventArgs e)
        {
            if (selectedList == null) return;

            var sel = gameListViewer.SelectedObjects;
            if (sel == null || sel.Count == 0) return;

            string msg = "Are you sure to delete this game(s)?";
            if (MessageBox.Show(msg, Application.ProductName, MessageBoxButtons.YesNo)
                == System.Windows.Forms.DialogResult.No)
                return;

            LoadNote(null);
            foreach (object v in sel)
            {
                selectedList.database.Remove((GameInfo)v);
            }
            selectedList.SaveList();
            LoadGameList(selectedList);
            listNameViewer.SetObjects(listNames, true);
        }

        private void gameListViewer_CellEditFinishing(object sender, BrightIdeasSoftware.CellEditEventArgs e)
        {
            if (selectedGame == null) return;

            if (e.Column == NameCol)
                selectedGame.Name = (string)e.NewValue;
            else if (e.Column == RatingCol)
                selectedGame.Rating = float.Parse(e.NewValue.ToString());
            else if (e.Column == TypeCol)
                selectedGame.Type = (GameType)e.NewValue;

            LoadNote(selectedGame);
            selectedList.SaveList();
        }

        private void gameListViewer_CellEditStarting(object sender, BrightIdeasSoftware.CellEditEventArgs e)
        {
            if (e.Column == RatingCol)
            {
                var num = (NumericUpDown)e.Control;
                num.Minimum = (decimal)0;
                num.Maximum = (decimal)10;
                num.DecimalPlaces = 1;
                num.Increment = (decimal)0.1;
                num.Location = new Point(e.CellBounds.Left - 5, e.CellBounds.Top);
                num.Width = 50;
                num.ForeColor = Color.Navy;
                num.Font = new Font("Consolas", 9.0F);
            }
            else if (e.Column == TypeCol)
            {
                var combo = (ComboBox)e.Control;
                combo.FormattingEnabled = true;
                combo.Format += (par, ex) =>
                    {
                        ex.Value = ex.Value.ToString().Replace('_', ' ');
                    };
            }
        }

        #endregion

        #region Game List

        public GameInfo selectedGame;

        private void LoadNote(GameInfo game)
        {
            selectedGame = game;
            if (game == null)
            {
                noteLabel.Text = (string)noteLabel.Tag;
                gameNoteBox.ReadOnly = true;
                gameNoteBox.Html = "";
            }
            else
            {
                noteLabel.Text = game.Name;
                gameNoteBox.ReadOnly = false;
                gameNoteBox.Html = selectedGame.Notes;

            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (selectedList != null)
            {
                if (selectedGame != null)
                {
                    selectedGame.Notes = gameNoteBox.Html;
                }
                selectedList.SaveList();
            }
        }

        #endregion

        #region List Name Context

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (selectedList == null) return;

            string msg = "Are you sure to delete " + selectedList.name + "?";
            if (MessageBox.Show(msg, Application.ProductName, MessageBoxButtons.YesNo)
                == System.Windows.Forms.DialogResult.No)
                return;

            selectedList.Delete();
            listNames.Remove(selectedList);
            listNameViewer.SetObjects(listNames, true);
        }
                
        private void renameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listNameViewer.SelectedIndex == -1) return;
            listNameViewer.StartCellEdit(listNameViewer.SelectedItem, 0);
        }

        private void refreshToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            LoadListNames();
        }

        private void exportListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (selectedList == null)
            {
                MessageBox.Show("Select a list to export.");
                return;
            }

            SaveFileDialog sfd = new SaveFileDialog();
            sfd.FileName = selectedList.name + DefExt;
            sfd.Filter = "Game Database List|*" + DefExt;
            sfd.OverwritePrompt = true;
            if (sfd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                File.Copy(selectedList.path, sfd.FileName, true);
            }
        }

        private void importListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Game Database List|*" + DefExt;
            ofd.Multiselect = true;
            ofd.CheckFileExists = true;
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                foreach (string file in ofd.FileNames)
                {
                    CopyFile(file);
                }
                LoadListNames();
            }
        }

        private void exportAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.Description = "Select destination folder to export all list.";
            if (fbd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                foreach (ListName list in listNames)
                {
                    CopyFile(list.path, Path.Combine(fbd.SelectedPath, list.name));
                }
            }
        }

        #endregion

        #region Game List Context

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadGameList(selectedList);
        }

        private void printListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (selectedList == null)
            {
                string msg = "Select a list to print";
                MessageBox.Show(msg);
                return;
            }

            var listViewPrinter1 = new BrightIdeasSoftware.ListViewPrinter();

            listViewPrinter1.ListView = this.gameListViewer;

            listViewPrinter1.Header = selectedList.name;
            listViewPrinter1.DocumentName = selectedList.name;
            listViewPrinter1.IsListHeaderOnEachPage = false;
            listViewPrinter1.IsPrintSelectionOnly = false;
            listViewPrinter1.AlwaysCenterListHeader = true;

            listViewPrinter1.CellFormat = null;
            listViewPrinter1.ListFont = new Font("Segoe UI", 10);
            listViewPrinter1.ListGridPen = new Pen(Color.PowderBlue);

            listViewPrinter1.HeaderFormat.TextBrush = Brushes.Black;
            listViewPrinter1.HeaderFormat.BackgroundBrush = Brushes.Transparent;
            listViewPrinter1.HeaderFormat.SetBorder(BrightIdeasSoftware.Sides.Bottom, 1.0F, Brushes.LightBlue);

            listViewPrinter1.GroupHeaderFormat = BrightIdeasSoftware.BlockFormat.GroupHeader();
            Brush brush = new HatchBrush(HatchStyle.LargeConfetti, Color.Blue, Color.Empty);
            listViewPrinter1.GroupHeaderFormat.SetBorder(BrightIdeasSoftware.Sides.Bottom, 5, brush);

            listViewPrinter1.ListHeaderFormat =
                BrightIdeasSoftware.BlockFormat.ListHeader(new Font("Segoe UI Semibold", 12));
            listViewPrinter1.ListHeaderFormat.BackgroundBrush = Brushes.PaleTurquoise;
            listViewPrinter1.ListHeaderFormat.TextBrush = Brushes.Black;

            listViewPrinter1.PrintWithDialog();
            listViewPrinter1.Dispose();
        }

        #endregion

        #region Load and save settings

        public void SaveSettings()
        {
            Properties.Settings.Default.Split1Distance =
                (double)splitContainer1.SplitterDistance / splitContainer1.Width;
            Properties.Settings.Default.Split2Distance =
                (double)splitContainer2.SplitterDistance / splitContainer2.Width;

            List<int> state1 = new List<int>();
            foreach (var col in listNameViewer.AllColumns)
            {
                state1.Add(col.Width);
            }

            List<int> state2 = new List<int>();
            foreach (var col in gameListViewer.AllColumns)
            {
                state2.Add(col.Width);
            }

            Properties.Settings.Default.ListNameState = Newtonsoft.Json.JsonConvert.SerializeObject(state1);
            Properties.Settings.Default.GameListState = Newtonsoft.Json.JsonConvert.SerializeObject(state2);

            Properties.Settings.Default.Save();
        }

        public void LoadSettings()
        {
            Properties.Settings.Default.Reload();

            splitContainer1.SplitterDistance =
                (int)(splitContainer1.Width * Properties.Settings.Default.Split1Distance);
            splitContainer2.SplitterDistance =
                (int)(splitContainer2.Width * Properties.Settings.Default.Split2Distance);

            try
            {
                List<int> state = Newtonsoft.Json.JsonConvert.DeserializeObject
                    <List<int>>(Properties.Settings.Default.ListNameState);
                for (int i = 0; i < listNameViewer.AllColumns.Count; ++i)
                {
                    if (!listNameViewer.AllColumns[i].FillsFreeSpace)
                        listNameViewer.AllColumns[i].Width = state[i];
                }
            }
            catch { }


            try
            {
                List<int> state = Newtonsoft.Json.JsonConvert.DeserializeObject
                    <List<int>>(Properties.Settings.Default.GameListState);
                for (int i = 0; i < gameListViewer.AllColumns.Count; ++i)
                {
                    if (!gameListViewer.AllColumns[i].FillsFreeSpace)
                        gameListViewer.AllColumns[i].Width = state[i];
                }
            }
            catch { }
        }

        #endregion



    }
}
