using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FacebookApplication.UI.blastFromThePast;
using FacebookWrapper.ObjectModel;

namespace FacebookApplication.UI
{
    internal partial class PastPhotoForm : Form
    {

        internal PastPhotoForm(Photo i_PastPhoto)
        {
            InitializeComponent();
            populateFieldsWithRandomPhotoData(i_PastPhoto);
        }

        private void populateFieldsWithRandomPhotoData(Photo i_ChosenPhoto)
        {
            if(i_ChosenPhoto != null)
            {
                string photoUrl = i_ChosenPhoto.PictureNormalURL;
                this.userPictureBox.ImageLocation = photoUrl;
                DateTime chosenPhotoDate = (DateTime)i_ChosenPhoto.CreatedTime;
                this.pictureDate.Text = chosenPhotoDate.ToLongDateString();
            }
            else
            {
                this.pageTitle.Text = "Sorry, no photos found from the chosen year!";
                this.userPictureBox.Size = new Size(0, 0);
                this.AutoSize = true;
            }
        }
    }
}
