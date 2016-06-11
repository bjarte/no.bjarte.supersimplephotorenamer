﻿using System;
using MediaInfoLib;
using Renamer.Helpers;

namespace Renamer.MediaDataHelpers
{
    public static class MediaInfoHelpers
    {
        public static DateTime GetMediaInfoEncodedDate(string fileName)
        {
            var mediaInfo = new MediaInfo();
            mediaInfo.Open(fileName);

            var encodedDateString = mediaInfo.Get(0, 0, "Encoded_Date");
            mediaInfo.Close();

            return encodedDateString.ConvertToDateTime();
        }

        public static DateTime GetMediaInfoMasteredDate(string fileName)
        {
            var mediaInfo = new MediaInfo();
            mediaInfo.Open(fileName);

            var encodedDateString = mediaInfo.Get(0, 0, "Mastered_Date");
            mediaInfo.Close();

            return encodedDateString.ConvertToDateTime();
        }
    }
}
