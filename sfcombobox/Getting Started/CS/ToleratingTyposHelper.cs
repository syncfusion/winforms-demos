#region Copyright Syncfusion Inc. 2001-2021.
// Copyright Syncfusion Inc. 2001-2021. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GettingStarted
{
    public class ToleratingTyposHelper
    {
        public static List<string> soundexTerms = new List<string>();

        /// <summary>
        /// Filter the values based on search text.
        /// </summary>
        /// <param name="value1"> Data value </param>
        /// <param name="value2">Search text </param>
        /// <returns>Return true, if search logic matched. Otherwise returns false.</returns>
        public static bool CustomAutoCompleteFilter(object value1, object value2)
        {
            double Fuzzythreshold = 0.70;
            var string1 = value1.ToString().ToLower();
            var string2 = value2.ToString().ToLower();
            if (string1.Length > 0 && string2.Length > 0)
                if (string1[0] != string2[0])
                    return false;
            var originalString1 = string.Empty;
            var originalString2 = string.Empty;

            if (string1.Length < string2.Length)
            {
                originalString2 = string2.Remove(string1.Length);
                originalString1 = string1;
            }

            if (string2.Length == string1.Length)
            {
                originalString1 = string1;
                originalString2 = string2;
            }

            bool IsMatchSoundex = ProcessOnSoundexAlgorithmn(originalString1) == ProcessOnSoundexAlgorithmn(originalString2);

            // Calculate the Levenshtein-distance:
            int levenshteinDistance =
                   GetDamerauLevenshteinDistance(originalString1, originalString2);

            // Length of the longer string()
            int length = Math.Max(originalString1.Length, originalString2.Length);

            // Calculate the score:
            double score = 1.0 - (double)levenshteinDistance / length;

            // Match?
            if (score > Fuzzythreshold || IsMatchSoundex)
                return true;
            return false;
        }

        /// <summary>
        /// Filter the values based on LevenshteinDistance algorithm.
        /// </summary>
        /// <param name="source"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        public static int GetDamerauLevenshteinDistance(string source, string target)
        {
            var bounds = new { Height = source.Length + 1, Width = target.Length + 1 };

            int[,] matrix = new int[bounds.Height, bounds.Width];

            for (int height = 0; height < bounds.Height; height++) { matrix[height, 0] = height; };
            for (int width = 0; width < bounds.Width; width++) { matrix[0, width] = width; };

            for (int height = 1; height < bounds.Height; height++)
            {
                for (int width = 1; width < bounds.Width; width++)
                {
                    int cost = (source[height - 1] == target[width - 1]) ? 0 : 1;
                    int insertion = matrix[height, width - 1] + 1;
                    int deletion = matrix[height - 1, width] + 1;
                    int substitution = matrix[height - 1, width - 1] + cost;

                    int distance = Math.Min(insertion, Math.Min(deletion, substitution));

                    if (height > 1 && width > 1 && source[height - 1] == target[width - 2] && source[height - 2] == target[width - 1])
                    {
                        distance = Math.Min(distance, matrix[height - 2, width - 2] + cost);
                    }

                    matrix[height, width] = distance;
                }
            }

            return matrix[bounds.Height - 1, bounds.Width - 1];
        }

        /// <summary>
        /// Filter the values based on SoundX algorithm.
        /// </summary>
        /// <param name="value1"></param>
        /// <param name="moreAccuracy"></param>
        /// <returns></returns>
        public static string ProcessOnSoundexAlgorithmn(string value1, bool moreAccuracy = true)
        {
            string stringValue = string.Empty;
            foreach (var item in value1.ToLower())
            {
                for (int i = 0; i < soundexTerms.Count; i++)
                {
                    if (soundexTerms[i].Contains(item.ToString()))
                    {
                        stringValue += i.ToString();
                        continue;
                    }
                }
            }
            if (stringValue.Length > 0)
            {
                if (moreAccuracy)
                {
                    stringValue = stringValue.Insert(0, value1[0].ToString());
                    stringValue = stringValue.Replace("0", "");
                }
            }
            return stringValue;
        }
    }
}
