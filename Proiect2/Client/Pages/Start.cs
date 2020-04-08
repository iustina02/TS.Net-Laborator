using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

using ModelMyPhotos;

namespace Client.Pages
{
    public partial class Start : Form
    {
        string[] files;
        int counterFiles;
        int maxCounterFiles;

        List<Photos> photos = new List<Photos>();

        public Start()
        {
            InitializeComponent();
        }

            private void Start_Load(object sender, EventArgs e)
        {
            addProp1.Hide();
            imageView1.Hide();
            FilesList.Hide();
        }

        private void Properties_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        //Butonul care iti va permite sa trimiti fisierul prin Email
        private void EmailButton_Click(object sender, EventArgs e)
        {

        }

        // Selectarea folderului de unde se vor afisa si modifica detaliile acestuia
        private void SelectFolder_Click(object sender, EventArgs e)
        {
            String directorPath = "";
            try
            {
                FolderBrowserDialog dialog = new FolderBrowserDialog();
                DialogResult result = dialog.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(dialog.SelectedPath))
                {
                    ModelMyPhotosClient pc = new ModelMyPhotosClient();

                    files = Directory.GetFiles(dialog.SelectedPath);
                    directorPath = dialog.SelectedPath;
                    //MessageBox.Show("Files found: " + files.Length.ToString(), "Message");
                    //MessageBox.Show("DirectPath: " + directorPath, "Message");
                    for (int i = 0; i < files.Length; i++)
                    {
                        string nameFile = files[i].Replace(directorPath, "").Replace("\\", "");
                        if (nameFile.Split('.').Length > 1)
                        {
                            if (nameFile.Split('.')[1] == "jpg" || nameFile.Split('.')[1] == "png" || nameFile.Split('.')[1] == "PNG")
                            {
                                //MessageBox.Show("Files: " + files[i], "Message");
                                FilesList.Items.Add(nameFile);

                                Photos newPhoto;
                                Places photoPlace = new Places()
                                {
                                    Country = "CountryDB",
                                    City = "CityDB",
                                    Region = "RegionDB"
                                };
                                Persons photoPerson = new Persons()
                                {
                                    Name = "NameDB",
                                    Description = "DescriptionDB"
                                };
                                Persons[] persons = { photoPerson };
                                newPhoto = new Photos()
                                {
                                    Date = DateTime.Now,
                                    Event = "EventDB",
                                    Landscape = "LandscapeDB",
                                    Path = files[i],
                                    Places_Photo = photoPlace,
                                    Persons_Photo = persons
                                };

                                if (pc.AddPhoto(newPhoto) == true)
                                {
                                    MessageBox.Show("Add True");
                                }
                                else
                                {
                                    MessageBox.Show("Add False");
                                }

                            }
                        }
                    }

                    Image.Show();
                    addProp1.Show();
                    //imageView1.Show();

                    maxCounterFiles = files.Length - 1;
                    counterFiles = 0;
                    Image.ImageLocation = files[0];
                    Photos actualPhoto = pc.GetPhotoByPath(files[0]);

                    DataTextBox.Text = actualPhoto.Date.ToString();
                    EvenimentTextBox.Text = actualPhoto.Event;
                    LandscapeTextBox.Text = actualPhoto.Landscape;


                    //CountryTextBox.Text = actualPlace.Country;
                    //CityTextBox.Text = actualPhoto.Places_Photo.City;
                    //RegionTextBox.Text = actualPhoto.Places_Photo.Region;
                    //PersonsTextBox.Text = actualPhoto.Persons_Photo[0].Name;
                    //PersonsDescriptionTextBox.Text = actualPhoto.Persons_Photo[0].Description;
                }
            }
            catch (Exception excep)
            {
                MessageBox.Show("An Error Occured" + excep.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        // Selectarea fisierului de unde se vor afisa si modifica detaliile acestuia
        private void SelectFile_Click(object sender, EventArgs e)
        {
            String imagePath = "";
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "Jpg files (*.jpg)|*.jpg|Png files (*.png)|*.png|All files (*.*)|*.*";

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    imagePath = dialog.FileName;

                    Image.ImageLocation = imagePath;

                    addProp1.Show();
                    imageView1.Show();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("An Error Occured", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Butonul care iti va permite sa printezi fisierul
        private void Printer_Click(object sender, EventArgs e)
        {

        }

        //Butonul care va cauta fisierele ce au proprietatea selectata si descrisa de catre utilizator
        private void FindButton_Click(object sender, EventArgs e)
        {

        }

        //Butonul ce va adauga o proprietatea acelui fisier
        //Exemplu: Proprietatea: Ora ; Descriere: 18:56
        private void AddPropButton_Button(object sender, EventArgs e)
        {

        }

        //Butonul ce va avea ca sarcina de a afisa fisierul aratat anterior celui prezent
        private void PrevButton_Click(object sender, EventArgs e)
        {
            int checkValue = counterFiles - 1;


            if (checkValue >= 0 && counterFiles <= maxCounterFiles)
            {
                counterFiles--;
                Image.ImageLocation = files[counterFiles];
            }
        }

        //Butonul ce va avea ca sarcinva afisarea urmatorului fisier din directorul selectat sau din lista cu elemente gasite ca si rezultat
        private void NextButton_Click(object sender, EventArgs e)
        {
            int checkValue = counterFiles + 1;

            if (checkValue <= maxCounterFiles && counterFiles >= 0)
            {
                counterFiles++;
                Image.ImageLocation = files[counterFiles];
            }
        }
    }
}

