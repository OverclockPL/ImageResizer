using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Threading;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.Net;

namespace Overclock.pl_App
{
    public partial class mainForm : Form
    {
        private FilesOpener filesOpener;
        private Watermarks watermarks;
        private List<String> bigImagesPaths = new List<String>();
        private List<String> miniImagesPaths = new List<String>();

        public mainForm()
        {
            filesOpener = new FilesOpener();
            watermarks = new Watermarks();

            InitializeComponent();
        }

        private void setToolStripStatus(string status)
        {
            toolStripStatusLabel.Text = status;
        }

        private void openFile_action(object sender, EventArgs e)
        {
            setToolStripStatus("Wczytywanie zdjęć z plików...");

            filesOpener.loadFiles();

            if (filesOpener.filesQuanity() > 0)
            {
                clearLoadedImagesList.Enabled = true;
                setToolStripStatus("Zdjęcia zostały wczytane!");
            }
            else
            {
                setToolStripStatus("Nie zostały wczytane żadne nowe zdjęcia!");
            }
        }

        private void generateImages()
        {
            int width = 1280, height = 1024;

            if (width1024_ratio.Checked == true)
            {
                width = 1024;
                height = 768;
            }
            else if (width1280_ratio.Checked == true)
            {
                width = 1280;
                height = 1024;
            }
            else if (widthManual_ratio.Checked == true)
            {
                width = Int32.Parse(manualWidth.Text);
                height = width;
            }

            Boolean generateMiniatures = generateMiniatures_CheckBox.Checked;
            Boolean bigAndMiniCatalogs = cataloguesCheckBox.Checked;

            String articleTitle = CodeGenerator.toFilename(articleTitle_textBox.Text);
            Boolean originalFilename = originalFilename_CheckBox.Checked;

            if (articleTitle != null)
            {
                System.IO.Directory.CreateDirectory(articleTitle);
            }
            else
            {
                throw new Exception("Problem przy tworzeniu katalogu! Proszę spróbować ponownie lub zmienić prawa dostępu do katalogu, gdzie znajduje się aplikacja.");
            }

            if (bigAndMiniCatalogs == true)
            {
                System.IO.Directory.CreateDirectory(articleTitle + "/big");
                System.IO.Directory.CreateDirectory(articleTitle + "/mini");
            }

            Image original;
            Bitmap resized;

            int imagesQuanity = filesOpener.filesQuanity();

            toolStripProgressBar.Value = 0;
            toolStripProgressBar.Maximum = imagesQuanity;

            String dirBig = "/";
            String dirMini = "/";
            String descriptionBig = "_big";
            String descriptionMini = "_mini";
            String filePath = null;

            if (bigAndMiniCatalogs == true)
            {
                dirBig = "/big/";
                dirMini = "/mini/";
                descriptionBig = "";
                descriptionMini = "";
            }

            for (int i = 0; i < imagesQuanity; i++)
            {
                original = filesOpener.get(i);

                // ----- BIG -------

                resized = ImageManipulations.resize(original, width);
                ImageManipulations.addWatermark(resized, watermarks);

                switch (originalFilename)
                {
                    case true: filePath = @articleTitle + dirBig + filesOpener.getFileNameWithoutExtension(i) + descriptionBig; break;
                    default: filePath = @articleTitle + dirBig + articleTitle + descriptionBig + i; break;
                }

                FileSaver.save(resized, filePath, ImageFormat.Jpeg);
                bigImagesPaths.Add(filePath);

                //---- MINIATURES ----

                if (generateMiniatures == true)
                {
                    resized = ImageManipulations.resize(resized, 250);
                    ImageManipulations.addMagnifier(resized, watermarks);

                    switch(originalFilename) 
                    {
                        case true: filePath = @articleTitle + dirMini + filesOpener.getFileNameWithoutExtension(i) + descriptionMini; break;
                        default: filePath = @articleTitle + dirMini + articleTitle + descriptionMini + i; break;
                    }

                    FileSaver.save(resized, filePath, ImageFormat.Jpeg); 
                    miniImagesPaths.Add(filePath);
                }

                // ---- CLEANING RAM -----

                original.Dispose();
                original = null;
                resized.Dispose();
                resized = null;
                GC.Collect();
                GC.WaitForPendingFinalizers();

                toolStripProgressBar.Value++;
            }
        }

        private void generateImages_action(object sender, EventArgs e)
        {
            if (originalFilename_CheckBox.Checked == true && articleTitle_textBox.Text.Length <= 0)
            {
                MessageBox.Show("Musisz podać tytuł artykułu!");
            }
            else
            {
                try
                {
                    setToolStripStatus("Zmniejszanie zdjęć oraz ich zapisywanie na dysku...");
                    generateImages();
                    setToolStripStatus("Zdjęcia zostały zmniejszone i zapisywane na dysku!");
                }
                catch (Exception exp)
                {
                    MessageBox.Show(exp.Message);
                }
            }
        }

        private void generateHTML_action(object sender, EventArgs e)
        {
            checkArticleDescriptionFields();

            if (address_textBox.Text.Length > 0 && articleDescription_textBox.Text.Length > 0 && articleTitle_textBox.Text.Length > 0 && generateMiniatures_CheckBox.Checked == true)
            {
                setToolStripStatus("Generowanie kodu HTML...");

                String articleTitle = CodeGenerator.toFilename(articleTitle_textBox.Text);
                String articleDescription = CodeGenerator.toFilename(articleDescription_textBox.Text);
                String FTPAddress = address_textBox.Text;

                List<String>[] bigAndMini = { bigImagesPaths, miniImagesPaths };

                String finalCode = CodeGenerator.generateHTML(filesOpener.filesQuanity(), bigAndMini, articleDescription, FTPAddress, HTMLToFile_CheckBox.Checked);
                

                if (HTMLinNewWindow_CheckBox.Checked == true)
                {
                    new GeneratedHTML(finalCode).Show();
                }

                setToolStripStatus("Kod HTML został wygenerowany!");
            }
        }

        private void info_action(object sender, EventArgs e)
        {
            setToolStripStatus("Wyświetlanie informacji o programie...");

            String baseInfo = "Aplikacja służy do generowania odpowiednio pomniejszonych i nazwanych zdjęć lub grafik oraz ich miniaturek.";
            String info = "Wymagane jest podanie tytułu artykułu (najlepiej bez polskich znaków). Pomniejszone zdjęcia są zapisywane w głównym folderze programu. Program automatycznie dobiera logo Overclock.pl wg koloru tła.";
            String authorsInfo = "Autorzy: Dawid Samołyk";

            MessageBox.Show(baseInfo + "\n " + info + "\n" + authorsInfo);
        }

        private void widthManual_ratio_CheckedChanged(object sender, EventArgs e)
        {
            manualWidth.Enabled = true;
        }

        private void clearLoadedImagesList_Click(object sender, EventArgs e)
        {
            if (filesOpener.filesQuanity() > 0)
            {
                filesOpener.clear();
                clearLoadedImagesList.Enabled = false;
                setToolStripStatus("Lista zdjęć została wyczyszczona!");
            }
        }

        private void checkArticleDescriptionFields()
        {
            if (articleDescription_textBox.Text.Length <= 0)
            {
                MessageBox.Show("Musisz podać opis artykułu!");
            }
            if (address_textBox.Text.Length <= 0)
            {
                MessageBox.Show("Musisz podać adres artykułu na serwerze!");
            }
            if (articleTitle_textBox.Text.Length <= 0)
            {
                MessageBox.Show("Musisz podać tytuł artykułu!");
            }
        }
    }
}
