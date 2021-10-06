using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace Veloso_Monoalphabetic_encrypt_decrypt
{
    class ClsmonoCipher
    {
       public class monoalph
        {
            public string key = "ybionjmqegvdwhkcapfxsluztr";
           public static string Encrypt(string plainText,string key)
            {//function used to encrypt the message
                char[] chars = new char[plainText.Length];
    
                int i = 0;
                while ( i < plainText.Length)//condition
                {

                    if (char.IsLetter(plainText[i]) == false)

                    {
                        chars[i] = plainText[i];
                    }
                    else
                    {
                        int j = plainText[i] - 97;
                        chars[i] = key[j];
                    }
                   
                    i++;//increment
                }
                return new string(chars);
              
            }

 
            //function used to decrypt the message
            public static string Decrypt(string cipherText, string key)
            {
                char[] chars = new char[cipherText.Length];

                int i = 0;
                while (i < cipherText.Length) //condition
                {

                    if (char.IsLetter(cipherText[i]) == false)

                    {
                        chars[i] = cipherText[i];
                    }
                    else
                    {
                        int j = key.IndexOf(cipherText[i]) + 97;
                        chars[i] = (char)j;
                    }

                    i++; //increment
                }
                return new string(chars);
            }
        }

    }
}
