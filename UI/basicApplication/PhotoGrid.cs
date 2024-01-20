using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;
using Utils;

namespace FacebookApplication.UI
{
    internal partial class PhotoGrid : UserControl
    {
        private FacebookObjectCollection<Album> m_userPhotoAlbums = null;
        private const int k_GridWidth = 3;
        private const int k_GridHeight = 6;

        internal PhotoGrid()
        {
            InitializeComponent();
            this.Anchor = AnchorStyles.Top;
            this.Size = new Size(585, 1200);
            if (m_userPhotoAlbums == null)
            {
                populateUserPhotos();
            }
       
            displayUserPhotos();
        }

        private void populateUserPhotos()
        {
            DataFetcher fetcher = DataFetcher.Instance;
            m_userPhotoAlbums = fetcher.GetUserAlbums();
        }

        private void displayUserPhotos()
        {
            IEnumerator<Album> albumEnumerator = m_userPhotoAlbums.GetEnumerator();

            for (int i = 0; i < k_GridWidth; i++)
            {
                for (int j = 0; j < k_GridHeight; j++)
                {
                    if (albumEnumerator.Current != null)
                    {
                        PictureBox currentPhoto = new PictureBox()
                        {
                            ImageLocation = albumEnumerator.Current.PictureAlbumURL,
                            SizeMode = PictureBoxSizeMode.StretchImage,
                            Dock = DockStyle.Fill
                        };

                        photoGridTable.Controls.Add(currentPhoto, i, j);
                    }

                    albumEnumerator.MoveNext();
                }
            }
        }
    }
}
