using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FacebookWrapper.ObjectModel;

namespace FacebookApplication.UI.blastFromThePast
{
    static class RandomPastPhotoGenerator
    {
        internal static Photo GenerateRandomPhotoFromGivenYear(
            User i_LoggedInUser,
            int i_YearFromWhichToGenerateRandomPhoto)
        {
            FacebookObjectCollection<Photo> photosFromChosenYear = getPhotosFromChosenYear(i_LoggedInUser, i_YearFromWhichToGenerateRandomPhoto);
            Photo chosenPhoto = null;
            int numberOfPhotosFromChosenYear = photosFromChosenYear.Count;

            if(numberOfPhotosFromChosenYear > 0)
            {
                Random randomPhotoGenerator = new Random();
                int chosenPhotoIndex = randomPhotoGenerator.Next(0, numberOfPhotosFromChosenYear);
                chosenPhoto = photosFromChosenYear[chosenPhotoIndex];
            }

            return chosenPhoto;
        }

        private static FacebookObjectCollection<Photo> getPhotosFromChosenYear(User i_LoggedInUser,
                                                                               int i_YearFromWhichToGenerateRandomPhoto)
        {
            FacebookObjectCollection<Photo> photosFromChosenYear = new FacebookObjectCollection<Photo>();

            foreach (Photo userPhoto in i_LoggedInUser.PhotosTaggedIn)
            {
                if (userPhoto.CreatedTime.HasValue
                    && userPhoto.CreatedTime.Value.Year == i_YearFromWhichToGenerateRandomPhoto)
                {
                    photosFromChosenYear.Add(userPhoto);
                }
            }

            return photosFromChosenYear;
        }
    }
}   
