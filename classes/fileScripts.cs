using System;
using System.IO;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Linq;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Wordprocessing;

namespace CPPKConverter
{
    class fileScripts
    {

        public static List<string> docToList(string path)
        {
            List<string> strings = new List<string>();
            FileInfo fileInf = new FileInfo(path);
            //достаём текст из файла и создаём путь дополнительного файла
            if (fileInf.Exists)
            {

                //чтение файла
                WordprocessingDocument doc = WordprocessingDocument.Open(path, true);
                Body body = doc.MainDocumentPart.Document.Body;
                string docText = "";
                for (int i = 0; i < body.ChildElements.Count; i++)
                {
                    docText += "\n";
                    if (body.ChildElements[i].InnerText.Length > 0)
                    {
                    }
                    for (int l = 0; l < body.ChildElements[i].ChildElements.Count; l++)
                    {
                        docText += body.ChildElements[i].ChildElements[l].InnerText;
                    }
                }
                doc.Close();
                //создание и очистка листа с фигнёй
                List<string> randomShit = docText.Split("\n").ToList<string>();
                for (int i = randomShit.Count-1; i >= 0; i--)
                {
                    if (randomShit[i] == "" || randomShit[i] == " " || randomShit[i] == "\t" || randomShit[i].Length < 2)
                    {
                        randomShit.RemoveAt(i);
                    }
                    else if (randomShit[i].Length > 2)
                    {
                        if (randomShit[i][0] == '\t' && randomShit[i][1] == ' ' && randomShit[i][2] == '\t')
                        {
                            randomShit.RemoveAt(i);
                        }
                    }
                }
                //вывод фигни
                int state = 0;
                for (int i = 0; i < randomShit.Count; i++)
                {
                    if (state == 0)
                    {
                        strings.Add("X.0.0");
                        strings.Add(randomShit[i]);
                        state++;
                    }
                    else
                    {
                        strings.Add(randomShit[i]);
                        if (randomShit.Count - 1 >= i + 1)
                        {
                            if (randomShit[i + 1][0] != '-' && randomShit[i + 1][0] != '+')
                            {
                                strings.Add(" ");
                                state = 0;
                            }
                        }
                    }
                }
            }
            return strings;
        }

        //функция которая разделяет текст из бдшки на строки и складывет их в лист + обрезает лишнее
        public static List<string> readFile(string path)
        {
            FileInfo fileInf = new FileInfo(path);
            //достаём текст из файла и создаём путь дополнительного файла
            List<string> list = new List<string>();
            if (fileInf.Exists)
            {

                string newpath = "C:\\" + fileInf.Name.Substring(0, fileInf.Name.Length - 4) + "_redacted.txt";
                string text;
                using (FileStream fstream = File.OpenRead(path))
                {
                    byte[] byteArray = new byte[fstream.Length];
                    fstream.Read(byteArray, 0, byteArray.Length);
                    text = System.Text.Encoding.Default.GetString(byteArray);
                }

                string[] themeAr = text.Split("\n");
                string[] cacheAr = new string[0];
                for (int i = 0; i < themeAr.Length; i++)
                {
                    cacheAr = themeAr[i].Split("\t");
                    if (cacheAr.Length > 1)
                    {
                        static bool statement(string n)
                        {
                            return n != "" && n != " ";
                        }
                        cacheAr = Array.FindAll(cacheAr, statement);
                        for (int l = 0; l < cacheAr.Length; l++)
                        {
                            list.Add(cacheAr[l]);
                        }
                    }
                    else
                    {
                        if (cacheAr[0].Length > 0)
                        {
                            if (cacheAr[0][0] == ' ')
                            {
                                cacheAr[0] = cacheAr[0].Substring(1, cacheAr[0].Length - 1);
                            }
                            while (Char.IsNumber(cacheAr[0][0]))
                            {
                                cacheAr[0] = cacheAr[0].Substring(1, cacheAr[0].Length - 1);
                            }
                            if (cacheAr[0][0] == '.')
                            {
                                cacheAr[0] = cacheAr[0].Substring(1, cacheAr[0].Length - 1);
                            }
                            else if (cacheAr[0][0] == ' ')
                            {
                                cacheAr[0] = cacheAr[0].Substring(1, cacheAr[0].Length - 1);
                            }
                        }
                        if (cacheAr[0].Length > 1)
                        {
                            if (cacheAr[0][0] == ' ')
                            {
                                cacheAr[0] = cacheAr[0].Substring(1, cacheAr[0].Length-1);
                            }
                            if (list[list.Count - 1][list[list.Count - 1].Length-1] == '\n' || list[list.Count - 1][list[list.Count - 1].Length - 1] == '\r')
                            {
                                list[list.Count - 1] = list[list.Count - 1].Substring(0, list[list.Count - 1].Length - 2);
                            }
                            list[list.Count - 1] += ".\n" + cacheAr[0];
                        }
                    }
                }
            }
            return list;
        }

        //считает кол-во вопросов в итоговом листе
        public static int countQuestions(List<string> list)
        {

            int qA = 0;

            if (list != null)
            {
                for (int i = 0; i < list.Count; i++)
                {
                    if (list[i].Length > 3)
                    {
                        if (list[i].Substring(0, 3) == "NEW")
                        {
                            qA++;
                        }
                        else if (list[i][1] == '.' && list[i][3] == '.')
                        {
                            qA++;
                        }
                    }
                }
            }

            return qA;
        }

        //*path в функции входит уже готовый т.е. путь+имя+формат
        //конвертация в txt для ленивца
        public static void lazyConvert(List<string> list, string cource, string theme, string path)
        {
            string newText = "";
            newText += "$" + cource + "\n|" + theme + "\n";
            int reWriteState = 0;
            //*0 название, 1 вопрос, 2 ответы, 3 пояснение
            for (int i = 0; i < list.Count; i++)
            {
                if (reWriteState == 0)
                {
                    reWriteState++;
                }
                else if (reWriteState == 1)
                {
                    newText += "@" + list[i] + "\n";
                    reWriteState++;
                }
                else if (reWriteState == 2)
                {
                    if (list[i].Length > 0) 
                    {
                        if (list[i][0] == '_' || list[i][0] == '-')
                        {
                            newText += "~" + list[i].Substring(1, list[i].Length - 1) + "\n";
                        }
                        else
                        {
                            if (list[i].Length > 0)
                            {
                                newText += "!" + list[i].Substring(1, list[i].Length - 1) + "\n";
                            }
                        }
                    }
                    if(list.Count-1 >= i + 1)
                    {
                        if (list[i + 1].Length > 0)
                        {
                            if (list[i + 1][0] != '_' && list[i + 1][0] != '+' && list[i + 1][0] != '-')
                            {
                                reWriteState++;
                            }
                        }
                    }
                }
                else
                {
                    newText += "[" + list[i] + "\n]\n#\n";
                    reWriteState = 0;
                }
            }
            //записываем текст
            using (FileStream fstream = new FileStream(path, FileMode.Create))
            {
                byte[] array = System.Text.Encoding.Default.GetBytes(newText);
                fstream.Write(array, 0, array.Length);
            }
        }
        //конвертация в gift для moodle
        public static void moodleConvert(List<string> list, string cource, string theme, string path)
        {
            string newText = "";
            newText += "$" + cource + "\n|" + theme + "\n";
            int reWriteState = 0;
            int qurAnsws = 0;
            //*0 название, 1 вопрос, 2 ответы, 3 пояснение
            for (int i = 0; i < list.Count; i++)
            {
                if (reWriteState == 0)
                {
                    reWriteState++;
                }
                else if (reWriteState == 1)
                {
                    newText += "::" + list[i] + "{\n";
                    reWriteState++;
                    qurAnsws = 0;
                    int l = 1;
                    while (list[i + l][0] == '+' && l != 0 || list[i + l][0] == '-' && l != 0 || list[i + l][0] == '_' && l != 0)
                    {
                        if (list[i + l][0] == '+')
                        {
                             qurAnsws++;
                        }
                        if (list.Count-1 >= l+i+1)
                        {
                            l++;
                        }
                        else
                        {
                            l = 0;
                        }
                    }
                }
                else if (reWriteState == 2)
                {
                    string symb = "=";
                    if (qurAnsws > 1)
                    {
                        symb = "~%" + (int)(100 / qurAnsws) + "%";
                    }
                    if (list[i][0] == '_' || list[i][0] == '-')
                    {
                        newText += "~" + list[i].Substring(1, list[i].Length - 1) + "\n";
                    }
                    else
                    {
                        newText += symb + list[i].Substring(1, list[i].Length - 1) + "\n";
                    }
                    if (list.Count - 1 >= i + 1)
                    {
                        if (list[i + 1][0] != '_' && list[i + 1][0] != '+' && list[i + 1][0] != '-')
                        {
                            reWriteState++;
                        }
                    }
                }
                else
                {
                    newText += "####" + list[i] + "\n}\n\n";
                    reWriteState = 0;
                }
            }

            //записываем текст
            using (FileStream fstream = new FileStream(path, FileMode.Create))
            {
                byte[] array = System.Text.Encoding.Default.GetBytes(newText);
                fstream.Write(array, 0, array.Length);
            }
        }
        //создание ксмльки
        public static void xlmConvert(List<string> list, string cource, string theme, string path)
        {
            string ourXML = "<?xml version=\"1.0\" encoding=\"UTF-8\"?><?mso-infoPathSolution solutionVersion=\"1.0.0.76\" name=\"urn:schemas-microsoft-com:office:infopath:OlimpCourse:-myXSD-2005-09-12T06-50-44\" productVersion=\"14.0.0\" PIVersion=\"1.0.0.0\" ?>\n<?mso-application progid=\"InfoPath.Document\"?><my:field xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xhtml=\"http://www.w3.org/1999/xhtml\" xmlns:my=\"http://schemas.microsoft.com/office/infopath/2003/myXSD/2005-09-12T06:50:44\" xmlns:xd=\"http://schemas.microsoft.com/office/infopath/2003\" xml:lang=\"ru\"><my:group></my:group>\n";
            //создание xml из нашего текста
            ourXML += "<my:curs>" + cource + "</my:curs><my:temicursov>\n<my:temacursa><my:tktext>" + theme + "</my:tktext><my:questions>\n";
            //тема

            int reWriteState = 0;
            //*0 название, 1 вопрос, 2 ответы, 3 пояснение
            for (int i = 0; i < list.Count; i++)
            {
                if (reWriteState == 0)
                {
                    reWriteState++;
                }
                else if (reWriteState == 1)
                {
                    ourXML += "<my:question><my:qtext><div style=\"FONT-FAMILY: Microsoft Sans Serif\" align=\"center\" xmlns=\"http://www.w3.org/1999/xhtml\" xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\"><strong>" + list[i] + "</strong></div></my:qtext>\n";
                    reWriteState++;
                }
                else if (reWriteState == 2)
                {
                    if (list[i][0] == '_' || list[i][0] == '-')
                    {
                        ourXML += "<my:answer><my:astatus>" + "Неправильный ответ" + "</my:astatus><my:atext>" + list[i].Substring(1, list[i].Length - 1) + "</my:atext></my:answer>\n";
                    }
                    else
                    {
                        ourXML += "<my:answer><my:astatus>" + "Правильный ответ" + "</my:astatus><my:atext>" + list[i].Substring(1, list[i].Length - 1) + "</my:atext></my:answer>\n";
                    }

                    if (list.Count - 1 >= i + 1)
                    {
                        if (list[i + 1][0] != '_' && list[i + 1][0] != '+' && list[i + 1][0] != '-')
                        {
                            reWriteState++;
                        }
                    }
                }
                else
                {
                    ourXML += "<my:qhelp><div xmlns=\"http://www.w3.org/1999/xhtml\">\n";
                    string[] descriptions = list[i].Split("\n");
                    for (int l = 0; l < descriptions.Length; l++)
                    {
                        ourXML += "<div>" + descriptions[l] + "</div>\n";
                    }
                    ourXML += "</div></my:qhelp>\n</my:question>\n";
                    reWriteState = 0;
                }
            }

            ourXML += "</my:questions><my:tkabout>\n</my:tkabout><my:materials><my:material><my:name></my:name><my:filename></my:filename></my:material></my:materials></my:temacursa>\n</my:temicursov></my:field>";
            using (FileStream fstream = new FileStream(path, FileMode.Create))
            {
                byte[] array = System.Text.Encoding.Default.GetBytes(ourXML);
                fstream.Write(array, 0, array.Length);
            }
        }
        //создание другой ксмльки
        public static void xlmSecondConvert(List<string> list, string cource, string theme, string path)
        {
            string ourXML = "<?xml version=\"1.0\" encoding=\"UTF-8\"?>\n<?mso-infoPathSolution solutionVersion=\"1.0.0.76\" name=\"urn:schemas-microsoft-com:office:infopath:OlimpCourse:-myXSD-2005-09-12T06-50-44\" productVersion=\"14.0.0\" PIVersion=\"1.0.0.0\" ?>\n<?mso-application progid=\"InfoPath.Document\"?>\n<my:field xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xhtml=\"http://www.w3.org/1999/xhtml\" xmlns:my=\"http://schemas.microsoft.com/office/infopath/2003/myXSD/2005-09-12T06:50:44\" \nxmlns:xd=\"http://schemas.microsoft.com/office/infopath/2003\" xml:lang=\"ru\">\n\t<my:group></my:group>\n";
            //создание xml из нашего текста
            ourXML += "\t<my:curs>" + cource + "</my:curs>\n";
            ourXML += "\t<my:temicursov>\n\t\t<my:temacursa>\n\t\t\t<my:tktext>"+ theme + "</my:tktext>\n\t\t\t<my:questions>\n";
            //тема

            int reWriteState = 0;
            //*0 название, 1 вопрос, 2 ответы, 3 пояснение
            for (int i = 0; i < list.Count; i++)
            {
                if (reWriteState == 0)
                {
                    reWriteState++;
                }
                else if (reWriteState == 1)
                {
                    ourXML += "\t\t\t\t<my:question><my:qtext><my:div style=\"font-family: microsoft sans serif\" align=\"center\" xmlns=\"http://www.w3.org/1999/xhtml\" xmlns:xsi=\"http://www.w3.org/2001/xmlschema-instance\"><my:strong><my:font face=\"calibri\">" + list[i] + "</my:font></my:strong></my:div></my:qtext>\n";
                    reWriteState++;
                }
                else if (reWriteState == 2)
                {
                    if (list[i][0] == '_' || list[i][0] == '-')
                    {
                        ourXML += "\t\t\t\t<my:answer><my:astatus>" + "Неправильный ответ" + "</my:astatus><my:atext>" + list[i].Substring(1, list[i].Length - 1) + "</my:atext></my:answer>\n";
                    }
                    else
                    {
                        ourXML += "\t\t\t\t<my:answer><my:astatus>" + "Правильный ответ" + "</my:astatus><my:atext>" + list[i].Substring(1, list[i].Length - 1) + "</my:atext></my:answer>\n";
                    }

                    if (list.Count - 1 >= i + 1)
                    {
                        if (list[i + 1][0] != '_' && list[i + 1][0] != '+' && list[i + 1][0] != '-')
                        {
                            reWriteState++;
                        }
                    }
                }
                else
                {
                    ourXML += "\t\t\t\t</my:question>\n";
                    reWriteState = 0;
                }
            }

            ourXML += "\t\t\t</my:questions>\n\t\t\t<my:tkabout></my:tkabout>\n\t\t\t<my:materials>\n\t\t\t\t<my:material>\n\t\t\t\t\t<my:name></my:name>\n\t\t\t\t\t<my:filename></my:filename>\n\t\t\t\t</my:material>\n\t\t\t</my:materials>\n\t\t\t<my:extensions>\n\t\t\t\t<my:extension>\n\t\t\t\t\t<my:DisplayName></my:DisplayName>\n\t\t\t\t\t<my:LinkAddress></my:LinkAddress>\n\t\t\t\t</my:extension>\n\t\t\t</my:extensions>\n\t\t</my:temacursa>\n\t</my:temicursov>\n</my:field>";
            using (FileStream fstream = new FileStream(path, FileMode.Create))
            {
                byte[] array = System.Text.Encoding.Default.GetBytes(ourXML);
                fstream.Write(array, 0, array.Length);
            }
        }
    }
}
