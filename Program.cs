using System.Collections;
using System.Diagnostics.SymbolStore;
using System.Globalization;
using System.Security.Cryptography;
using Microsoft.VisualBasic;

internal class Program
{
    private static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the first string: ");
        string str1 = Convert.ToString(Console.ReadLine());
        while (true)
            {
                int sel = menu();
                switch (sel)
                {
                    case 0: Console.WriteLine("Bye"); return;
                    case 1: FindLength(str1); break;
                    case 2: separate(str1); break;
                    case 3: reserve(str1); break;
                    case 4: count_word(str1); break;
                    case 5: 
                            System.Console.WriteLine("Enter the second string: ");
                            string str2 = Convert.ToString(Console.ReadLine());
                            if(compare(str1,str2) == true) System.Console.WriteLine("The strings are equal");
                            else System.Console.WriteLine("The strings are not equal"); 
                            break;
                    case 6: count_A_D_S(str1); break;
                    case 7: count_vowel_consonant (str1); break;
                    case 8: 
                            System.Console.WriteLine("Enter the second string: ");
                            string str3 = Convert.ToString(Console.ReadLine());
                            if (checkSubstring(str1,str3) == true) System.Console.WriteLine("The Substring is present in the give string.");
                            else System.Console.WriteLine("The Substring is not present in the give string.");
                            break;
                    case 9: 
                            System.Console.WriteLine("Enter the substring: ");
                            string str4 = Convert.ToString(Console.ReadLine());
                            if (find_position_substring(str1,str4) == -1)
                            Console.WriteLine("The substring was not found in the main string.");
                            break;
                    case 10: 
                            System.Console.WriteLine("Enter the substring: ");
                            string str5 = Convert.ToString(Console.ReadLine());
                            count_subString(str1,str5);
                            break;
                    case 11: 
                            System.Console.WriteLine("Enter the string to find: ");
                            string str6 = Convert.ToString(Console.ReadLine());
                            System.Console.WriteLine("Enter the substring to insert: ");
                            string str7 = Convert.ToString(Console.ReadLine());
                            Insert_substring(str1,str1,str7);
                            break;
                }
            }
    }
    static int menu() {
        Console.WriteLine("\n======================================================");
            Console.WriteLine("\t\tThis is the menu: \n");
            Console.WriteLine("0. exit");
            Console.WriteLine("1. Find the length.");
            Console.WriteLine("2. Separate individual characters.");
            Console.WriteLine("3. Print individual characters in reverse order.");
            Console.WriteLine("4. Count the total number of words.");
            Console.WriteLine("5. Compare two strings.");
            Console.WriteLine("6. Count the number of alphabets, digits and special characters.");
            Console.WriteLine("7. Count the number of vowels or consonants.");
            Console.WriteLine("8. Check whether a given substring is present in the given string.");
            Console.WriteLine("9. search for the position of a substring within a string.");
            Console.WriteLine("10. Find the number of times a substring appears in a given string.");
            Console.WriteLine("11. Insert a substring before the first occurrence of a string.");
            Console.WriteLine();
            Console.Write("Your select <1..11>");
            int sel = 0;
            while(true) {
                bool c = int.TryParse(Console.ReadLine(), out sel);
                if (c && sel >= 0 && sel <= 11)
                    break;
                else Console.WriteLine("Please enter a valid choice!");
            }
            return sel;
    }
    static int FindLength(string s) //to find the length of a string without using a library function
    {
        int num = 0;
        for (int i = 0; i < s.Length; i++) 
        num++;
        System.Console.Write($"The length of the string: {num}");
        return num;
    }
    static string separate(string s) //to separate individual characters from a string.
    {
        System.Console.Write($"The string after separate individual char: ");
        foreach(char c in s) 
        System.Console.Write(c + " ");
        return s;
    }
    static string reserve(string s) //to print individual characters of the string in reverse order. 
    { 
        System.Console.Write($"The string after separate reserve order: ");
        for (int i = s.Length-1; i >=0; i--)
            System.Console.Write(s[i] + " ");
        return s;
    }
    static int count_word(string s) //to count the total number of words in a string.
    {
        s=s.Trim();
        int n = 0;
        if (!string.IsNullOrEmpty(s)) n = 1;
        int i = 0;
        while (i<s.Length) {
            if (s[i]==' '&&s[i+1]!=' ') n++;
            i++;
        }
        System.Console.Write($"The number words of the string: {n} ");
        return n;
    }
    static bool compare(string s1, string s2) //to compare two strings without using a string library functions.
    {
        int nums1 = 0;
        for (int i = 0; i < s1.Length; i++) nums1++;
        int nums2 = 0;
        for (int i = 0; i < s2.Length; i++) nums2++;
        if (nums1 == nums2) {
        for (int i=0; i<s1.Length; i++) {
            if (s1[i] != s2[i]) return false;
          }
        }
        else return false;
        return true;
    }
    static int[] count_A_D_S(string s) //to count the number of alphabets, digits and special characters in a string.
    {
        s = s.ToLower();
        //arr[0]=alphabets, arr[1]=digits, arr[2]=special characters
        int[]arr = new int[3];
        int a = 0, d=0, sc = 0;
        foreach(int c in s) {
            if ((c>='a'&& c <= 'z')) a++;
            else if (c>='0' && c<='9') d++;
            else sc++;
        }
        arr[0] = a;
        arr[1] = d;
        arr[2] = sc;
        Console.WriteLine($"Number of alphabets : {arr[0]}");
        Console.WriteLine($"Number of digits : {arr[1]}");
        Console.WriteLine($"Number of special char : {arr[2]}");
        return arr;
    }
    static int[] count_vowel_consonant (string s) //to count the number of vowels or consonants in a string
    {
        s = s.ToLower();
        int[]arr = new int[2];
        int v = 0, con = 0;
        foreach (int c in s ) {
            if ((c>='a'&& c <= 'z')) {
            if (c== 'a' || c=='e' || c=='i'||c=='o'|| c =='u') v++;
            else con++;
            }
        }
        arr[0] = v;
        arr[1] = con;
        Console.WriteLine($"Number of vowels : {arr[0]}");
        Console.WriteLine($"Number of consonants : {arr[1]}");
        return arr;
    }
    static bool checkSubstring (string s1, string s2) //to check whether a given substring is present in the given string
    {
        for(int i = 0 ; i<=s1.Length-s2.Length; i++)
        {
            int j;
                for (j =0; j<s2.Length; j++) 
                {
                    if (s1[i+j]!= s2[j]) break;
                }
            if (j==s2.Length)return true;
        }
        return false;
    }
    static int find_position_substring (string s1, string s2) //to search for the position of a substring within a string.
    {
        for(int i = 0 ; i<=s1.Length-s2.Length; i++)
        {
            int j;
                for (j =0; j<s2.Length; j++) 
                {
                    if (s1[i+j]!= s2[j]) break;
                }
            if (j == s2.Length)
            {
                Console.WriteLine($"The substring is found at position {i}.");
                return i;  // Return the starting position of the substring
            }
        }
        return -1; // Return -1 if the substring is not found
    }
    static int count_subString (string s1, string s2) //to find the number of times a substring appears in a given string.
    {
        int count = 0;
        for (int i = 0; i <= s1.Length - s2.Length; i++)
        {
            int j;
            // Check if substring matches from the current index
            for (j = 0; j < s2.Length; j++)
            {
                if (s1[i + j] != s2[j])
                {
                    break;
                }
            }
            // If the full substring was matched, increment the count and move to the next possible match
            if (j == s2.Length)
            {
                count++;
                i = i + s2.Length - 1;  // Move the index forward to avoid overlapping matches
            }
        }
        Console.WriteLine($"The substring appears {count} time(s) in the main string.");
        return count;
    }
    static string Insert_substring (string s1, string s2, string s3) //to insert a substring before the first occurrence of a string.
    {
        for (int i = 0; i <= s1.Length -s2.Length; i++)
        {
            // Check if the substring matches from the current index
            bool matchFound = true; // Assume we have a match initially
            for (int j = 0; j < s2.Length; j++)
            {
                if (s1[i + j] != s2[j])
                {
                    matchFound = false; // Found a mismatch
                    break; // No need to check further
                }
            }
            // If we found a match, insert the substring
            if (matchFound)
            {
                return s1 = s1.Substring(0, i) + s3 + s1.Substring(i);
            }
            Console.WriteLine($"Resulting string: {s1}");
        }
        return s1; // If the findString is not found, return the original mainString
    }
}






