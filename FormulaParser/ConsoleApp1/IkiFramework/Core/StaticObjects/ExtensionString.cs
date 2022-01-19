using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
namespace IkiCore
{
    public static class ExtensionString
    {
        public static string SortStringLength(this string a, string b)
        {
            if (a.Length > b.Length)
            {
                return a;
            }
            else if (a.Length < b.Length)
            {
                return b;
            }
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] < b[i])
                {
                    return a;
                }
                else if (a[i] > b[i])
                {
                    return b;
                }
            }
            return a;
        }
        public static (string, string) SortStringLength(this (string, string) x)
        {
            if (SortStringLength(x.Item1, x.Item2) != x.Item1)
            {
                return (x.Item2, x.Item1);
            }
            return x;
        }
        public static (string, object, string, object) SortStringLength(this (string, object, string, object) x)
        {
            if (SortStringLength(x.Item1, x.Item3) != x.Item1)
            {
                return (x.Item3, x.Item4, x.Item1, x.Item2);
            }
            return x;
        }
        public static string SortStringName(this string a, string b)
        {
            string priority = a.Length >= b.Length ? a : b;
            int minLength = a.Length > b.Length ? b.Length : a.Length;
            for (int i = 0; i < minLength; i++)
            {
                if (a[i] < b[i])
                {
                    return a;
                }
                else if (a[i] > b[i])
                {
                    return b;
                }
            }
            return priority;
        }
        public static string GetStringWhile(this string content, ref int i, Func<char, bool> test)
        {
            if (i >= content.Length || i < 0)
            {
                return "";
            }
            else if (test(content[i]))
            {
                return $"{content[i++]}{GetStringWhile(content, ref i, test)}";
            }
            i--;
            return "";
        }
        public static string GetNumberWhile(this string content, ref int i, ref int p, bool pointOverComma = true, bool acceptExponent = false)
        {
            if (i >= content.Length || i < 0)
            {
                return "";
            }
            else if (char.IsDigit(content[i]))
            {
                return $"{content[i++]}{GetNumberWhile(content, ref i, ref p, pointOverComma, acceptExponent)}";
            }
            else if ((pointOverComma && content[i] == '.') || (!pointOverComma && content[i] == ','))
            {
                if (p <= 1 && (i + 1 < content.Length) && ((pointOverComma && content[i + 1] == '.') || (!pointOverComma && content[i + 1] == ',')))
                {
                    return "";
                }
                p++;
                if (p > 1)
                {
                    return "";
                }
                return $"{content[i++]}{GetNumberWhile(content, ref i, ref p, pointOverComma, acceptExponent)}";
            }
            else if (char.IsLetter(content[i]) && acceptExponent && (content[i] == 'E' || content[i] == 'e') && i + 2 < content.Length && (content[i + 1] == '+' || content[i + 1] == '-') && char.IsDigit(content[i + 2]))
            {
                return $"{content[i++]}{content[i++]}{GetNumberWhile(content, ref i, ref p, pointOverComma)}";
            }
            return "";
        }
        public static bool IsSamePattern(this string x, string pattern, int i) => !(x == null || pattern == null || i + pattern.Length >= x.Length || i < 0 || x.Substring(i, pattern.Length) != pattern);
        /// <summary>
        /// Get all the duplicated characters in a string.
        /// </summary>
        /// <param name="sentence"></param>
        /// <returns></returns>
        public static string GetDuplicatedChars(this string sentence)
        {
            StringBuilder sb = new StringBuilder();
            StringBuilder sb2 = new StringBuilder();
            for (int i = 0; i < sentence.Length; i++)
            {
                if (sb.ToString().IndexOf(sentence[i]) == -1)
                {
                    sb.Append(sentence[i]);
                }
                else if (sb2.ToString().IndexOf(sentence[i]) == -1)
                {
                    sb2.Append(sentence[i]);
                }
            }
            return sb2.ToString();
        }
        /// <summary>
        /// Remove duplicated characters from a string. Case sensitive version.
        /// </summary>
        /// <param name="sentence"></param>
        /// <returns></returns>
        public static string RemoveDuplicatedChars(this string sentence)
        {
            StringBuilder sb = new StringBuilder();
            for(int i = 0; i < sentence.Length; i++)
            {
                if(sb.ToString().IndexOf(sentence[i]) == -1)
                {
                    sb.Append(sentence[i]);
                }
            }
            return sb.ToString();
        }
        /// <summary>
        /// Remove duplicated characters from a string. Not case sensitive version.
        /// </summary>
        /// <param name="sentence"></param>
        /// <returns></returns>
        public static string RemoveEveryDuplicatedChars(this string sentence)
        {
            StringBuilder sb = new StringBuilder();
            for(int i = 0; i < sentence.Length; i++)
            {
                if(sb.ToString().IndexOf(char.ToLower(sentence[i])) == -1)
                {
                    sb.Append(sentence[i]);
                }
            }
            return sb.ToString();
        }
        /// <summary>
        /// Return true if the string share the same set of letters.
        /// </summary>
        /// <param name="sentenceA"></param>
        /// <param name="sentenceB"></param>
        /// <returns></returns>
        public static bool IsAnagrams(this string sentenceA, string sentenceB)
        {
            char[] a = sentenceA.ToLower().ToCharArray();
            char[] b = sentenceB.ToLower().ToCharArray();
            Array.Sort(a);
            Array.Sort(b);
            return new string(a) == new string(b);
        }
        /// <summary>
        /// Reverse the string.
        /// </summary>
        /// <param name="sentence"></param>
        /// <returns></returns>
        public static string Reverse(this string sentence)
        {
            return new string(sentence.ToCharArray().Reverse());
        }
        /// <summary>
        /// Count the number of words in the string.
        /// </summary>
        /// <param name="sentence"></param>
        /// <returns></returns>
        public static int CountWord(this string sentence)
        {
            sentence = sentence.Trim();
            if(sentence == "")
            {
                return 0;
            }
            while(sentence.Contains("  "))
            {
                sentence = sentence.Replace("  ", " ");
            }
            string[] arr;
            arr = sentence.Split(' ');
            return arr.Length;
        }
        /// <summary>
        /// Return true if a string is palindrom (it can be read in both directions).
        /// </summary>
        /// <param name="sentence"></param>
        /// <returns></returns>
        public static bool IsPalindrome(this string sentence)
        {
            char[] words = sentence.ToLower().ToCharArray();
            int length = words.Length / 2;
            for (int i = 0, j = words.Length - 1; i < length; i++, j--)
            {
                if(words[i] == words[j])
                {
                    continue;
                }
                return false;
            }
            return true;
        }
        /// <summary>
        /// Return the highest occured character in a string.
        /// </summary>
        /// <param name="sentence"></param>
        /// <returns></returns>
        public static char HighestOccuredChar(this string sentence)
        {
            Dictionary<char, int> dic = new Dictionary<char, int>();
            char higestOccured = '\0';
            int occured = 0;
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < sentence.Length; i++)
            {
                if (sb.ToString().IndexOf(sentence[i]) == -1)
                {
                    sb.Append(sentence[i]);
                }
                else
                {
                    if(dic.ContainsKey(sentence[i]))
                    {
                        dic[sentence[i]]++;
                        if(dic[sentence[i]] > occured)
                        {
                            higestOccured = sentence[i];
                            occured = dic[sentence[i]];
                        }
                    }
                    else
                    {
                        if(occured == 0)
                        {
                            occured = 1;
                            higestOccured = sentence[i];
                        }
                        dic.Add(sentence[i], 1);
                    }
                }
            }
            return higestOccured;
        }
        /// <summary>
        /// Return true if all characters in the string are unique.
        /// </summary>
        /// <param name="sentence"></param>
        /// <returns></returns>
        public static bool IsUnique(this string sentence)
        {
            Dictionary<char, int> dic = new Dictionary<char, int>();
            for(int i = 0; i < sentence.Length; i++)
            {
                if(dic.ContainsKey(sentence[i]))
                {
                    return false;
                }
                dic.Add(sentence[i], 1);
            }
            return true;
        }
        /// <summary>
        /// Return all the possible substring from a string.
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static string[] SubString(this string s)
        {
            List<string> subString = new List<string>();
            string sub;
            int i, j;
            for (i = 1; i <= s.Length; i++)
            {
                for (j = 0; j <= s.Length - i; j++)
                {
                    sub = s.Substring(j, i);
                    if (!subString.Contains(sub))
                    {
                        subString.Add(sub);
                    }
                }
            }
            subString.RemoveAt(subString.Count - 1);
            return subString.ToArray();
        }
        /// <summary>
        /// Convert a string to an int if it's possible.
        /// </summary>
        /// <param name="value"></param>
        /// <param name="defaultInt">The default int value to return if you can't convert the string</param>
        /// <returns></returns>
        public static int ToInt(this string value, int defaultInt = 0)
        {
            int resultNum = defaultInt;
            try
            {
                if (!string.IsNullOrEmpty(value))
                {
                    resultNum = Convert.ToInt32(value);
                }
            }
            catch
            {
            }
            return resultNum;
        }
        /// <summary>
        /// Converts string to enum object
        /// </summary>
        /// <typeparam name="T">Type of enum</typeparam>
        /// <param name="value">String value to convert</param>
        /// <returns>Returns enum object</returns>
        public static T ToEnum<T>(this string value) where T : struct
        {
            return (T)Enum.Parse(typeof(T), value, true);
        }
        /// <summary>
        /// Add space between uppercase.
        /// </summary>
        /// <param name="sentence"></param>
        /// <param name="handleSingleChar"></param>
        /// <returns></returns>
        public static string SpaceBetweenUppercase(this string sentence, bool handleSingleChar = true)
        {
            if (handleSingleChar)
            {
                return Regex.Replace(sentence, "(?<!^)_?([A-Z])", " $1");
            }
            else
            {
                return Regex.Replace(sentence, "([a-z])_?([A-Z])", "$1 $2");
            }
        }
        /// <summary>
        /// Convert the string to float.
        /// </summary>
        /// <param name="value"></param>
        /// <param name="defaultValue"></param>
        /// <returns></returns>
        public static float ToFloat(this string value, float defaultValue = 0)
        {
            try
            {
                return Single.Parse(value);
            }
            catch
            {
                return defaultValue;
            }
        }
        /// <summary>
        /// Return the string with the first char in Uppercase.
        /// </summary>
        /// <param name="sentence"></param>
        /// <param name="lowerOthersChar"></param>
        /// <returns></returns>
        public static string UppercaseFirst(this string sentence, bool lowerOthersChar)
        {
            if (string.IsNullOrEmpty(sentence))
            {
                return string.Empty;
            }
            if (lowerOthersChar)
            {
                sentence = sentence.ToLower();
            }
            char[] a = sentence.ToCharArray();
            a[0] = char.ToUpper(a[0]);
            return new string(a);
        }
        /// <summary>
        /// Return a wrapped a string.
        /// </summary>
        /// <param name="sentence"></param>
        /// <param name="charsPerLine"></param>
        /// <param name="forceWrap"></param>
        /// <returns></returns>
        public static string WrapLine(this string sentence, int charsPerLine, bool forceWrap)
        {
            if (sentence.Length < charsPerLine)
            {
                return sentence;
            }
            StringBuilder sb = new StringBuilder();
            StringBuilder sb2 = new StringBuilder();
            int cursor = 0, charCount = 0;
            bool bLineEmpty = false;
            while (cursor < sentence.Length)
            {
                sb2.Append(sentence[cursor]);
                charCount++;
                if (sentence[cursor] == ' ')
                {
                    sb.Append(sb2.ToString());
                    sb2.Clear();
                    bLineEmpty = false;
                }
                else if (sentence[cursor] == '\n')
                {
                    sb.Append(sb2.ToString());
                    sb2.Clear();
                    charCount = 0;
                }
                if (charCount >= charsPerLine)
                {
                    if (!bLineEmpty)
                    {
                        sb.Append($"\n");
                        charCount = sb2.ToString().Length;
                        bLineEmpty = true;
                    }
                    else if (forceWrap)
                    {
                        sb.Append($"{sb2.ToString()}\n");
                        sb2.Clear();
                        bLineEmpty = true;
                        charCount = 0;
                    }
                }
                cursor++;
            }
            sb.Append(sb2.ToString());
            return sb.ToString();
        }
    }
}
