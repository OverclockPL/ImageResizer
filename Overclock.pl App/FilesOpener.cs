using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.IO;

namespace Overclock.pl_App
{
    class FilesOpener
    {
        private OpenFileDialog openFileDialog;
        private List<String> filesNames;

        public FilesOpener()
        {
            this.openFileDialog = new OpenFileDialog();
            this.filesNames = new List<String>();

            initializeOpenFileDialog();
        }

        private void initializeOpenFileDialog()
        {
            this.openFileDialog.Title = "Wybierz zdjęcia";
            this.openFileDialog.Filter = "Image Files (*.jpg)|*.jpg";
            this.openFileDialog.Multiselect = true;
        }

        public void loadFiles()
        {
            DialogResult dialogResult = openFileDialog.ShowDialog();

            if (dialogResult == DialogResult.OK)
            {
                filesNames.AddRange(openFileDialog.FileNames);
            }
            else if (dialogResult == DialogResult.Cancel)
            {}
            else
            {
                MessageBox.Show("Błąd przy wczytywaniu zdjęć. Spróbuj ponownie.");
            }
        }

        public int filesQuanity()
        {
            return filesNames.Count;
        }

        public Image get(int index)
        {
            return Image.FromFile(filesNames[index]);
        }

        public string getFilePath(int index)
        {
            return filesNames[index];
        }

        public string getFileNameWithoutExtension(int index)
        {
            return Path.GetFileNameWithoutExtension(filesNames[index]);
        }

        public void clear()
        {
            filesNames.Clear();
        }
    }
}
