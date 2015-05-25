using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Overclock.pl_App
{
    class CodeGenerator
    {

        public static String generateHTML(Int32 imagesQuanity, List<String>[] bigAndMini, String articleDescription, String FTPAddress, Boolean saveToFile)
        {
            System.IO.StreamWriter file = null;

            if (saveToFile == true)
            {
                file = new System.IO.StreamWriter(@"kod_wynikowy.txt");
            }

            List<String> bigImagesPaths = bigAndMini[0];
            List<String> miniImagesPaths = bigAndMini[1];

            String number, description, big, mini, finalCode;
            StringBuilder completeCode = new StringBuilder();

            for (Int32 index = 0; index < imagesQuanity; index++)
            {
                number = index.ToString();

                description = "\"" + articleDescription + "\"";
                big = "\"../../../images/articles/content/artykuly/" + FTPAddress + bigImagesPaths.ElementAt(index) + ".jpg\"";
                mini = "\"../../../images/articles/content/artykuly/" + FTPAddress + miniImagesPaths.ElementAt(index) + ".jpg\"";

                finalCode =
                "<p><a title=" + description +
                " href=" + big +
                "><img style=\"display: block; margin-left: auto; margin-right: auto;\"" +
                " title=" + description +
                " src=" + mini +
                " alt=" + description +
                " /></a></p><p></p>";

                completeCode.Append(finalCode);
            }

            if (saveToFile == true && file != null)
            {
                file.WriteLine(completeCode);
                file.Close();
            }

            number = null;
            description = null;
            big = null;
            mini = null;
            GC.Collect();
            GC.WaitForPendingFinalizers();

            return completeCode.ToString();
        }

        public static String toFilename(String name)
        {
            char[] illegalSigns = { ' ', '!', '@', '#', '$', '%', '^', '&', '*', '.', ',', '[', ']', '{', '{', '\'', '/', '\\', ';', ':', '"', '|', '~' };
            char[] fileName = new char[name.Length];
            char buffer;

            for (int i = 0; i < name.Length; i++)
            {
                buffer = name.ElementAt(i);

                for (int j = 0; j < illegalSigns.Length; j++)
                {
                    if (buffer.Equals(illegalSigns[j]))
                    {
                        buffer = '_';
                    }
                }

                fileName[i] = buffer;
            }

            return new String(fileName);
        } 
    }
}
