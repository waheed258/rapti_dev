using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace BusinessManager
{
  public  class BALGlobal
  {
      //added by anitha on 05/05/2018
      #region To display message in label
      
      public string ShowMessage(string sOperation, string TitleMessage, string sMessage)
      {
          StringBuilder sbMessage = new StringBuilder();
          // operations class 1.success,2.danger,3.info4.warning
          sbMessage.Append(" <div class='alert alert-" + sOperation + " fade in'>");
          sbMessage.Append("<a href='#' class='close' data-dismiss='alert'>&times;</a>   <strong>" + TitleMessage + "!</strong>" + sMessage + "</div>");
          return sbMessage.ToString();

      }
    #endregion
      //added by anitha on 05/05/2018
      #region encrypt and decrypt methods 
      //changed by mounika encrypt to encrypts same decrypt to decrypts of old method
     
      public string Decrypts(string cipherString, bool useHashing)
      {
          //space replace to "+" 
          cipherString = cipherString.Replace(" ", "+");

          byte[] keyArray;
          byte[] toEncryptArray = Convert.FromBase64String(cipherString);

          //System.Configuration.AppSettingsReader settingsReader = new AppSettingsReader();
          //Get your key from config file to open the lock!
          string key = "dinoosys@!@#";

          if (useHashing)
          {
              MD5CryptoServiceProvider hashmd5 = new MD5CryptoServiceProvider();
              keyArray = hashmd5.ComputeHash(UTF8Encoding.UTF8.GetBytes(key));
              hashmd5.Clear();
          }
          else
              keyArray = UTF8Encoding.UTF8.GetBytes(key);

          TripleDESCryptoServiceProvider tdes = new TripleDESCryptoServiceProvider();
          tdes.Key = keyArray;
          tdes.Mode = CipherMode.ECB;
          tdes.Padding = PaddingMode.PKCS7;

          ICryptoTransform cTransform = tdes.CreateDecryptor();
          byte[] resultArray = cTransform.TransformFinalBlock(toEncryptArray, 0, toEncryptArray.Length);

          tdes.Clear();
          return UTF8Encoding.UTF8.GetString(resultArray);
          string ResultString = string.Empty;
          try
          {
              System.Text.UTF8Encoding encoder = new System.Text.UTF8Encoding();
              System.Text.Decoder utf8Decode = encoder.GetDecoder();
              byte[] todecode_byte = Convert.FromBase64String(cipherString);
              int charCount = utf8Decode.GetCharCount(todecode_byte, 0, todecode_byte.Length);
              char[] decoded_char = new char[charCount];
              utf8Decode.GetChars(todecode_byte, 0, todecode_byte.Length, decoded_char, 0);
              ResultString = new String(decoded_char);
          }
          catch (Exception ex)
          {
              throw new Exception("invalid result.");
          }
          return ResultString;
      }

      public string Encrypts(string toEncrypt, bool useHashing)
      {
          byte[] keyArray;
          byte[] toEncryptArray = UTF8Encoding.UTF8.GetBytes(toEncrypt);

          //System.Configuration.AppSettingsReader settingsReader = new AppSettingsReader();
          // Get the key from config file
          string key = "dinoosys@!@#";
          //System.Windows.Forms.MessageBox.Show(key);
          if (useHashing)
          {
              MD5CryptoServiceProvider hashmd5 = new MD5CryptoServiceProvider();
              keyArray = hashmd5.ComputeHash(UTF8Encoding.UTF8.GetBytes(key));
              hashmd5.Clear();
          }
          else
              keyArray = UTF8Encoding.UTF8.GetBytes(key);

          TripleDESCryptoServiceProvider tdes = new TripleDESCryptoServiceProvider();
          tdes.Key = keyArray;
          tdes.Mode = CipherMode.ECB;
          tdes.Padding = PaddingMode.PKCS7;

          ICryptoTransform cTransform = tdes.CreateEncryptor();
          byte[] resultArray = cTransform.TransformFinalBlock(toEncryptArray, 0, toEncryptArray.Length);
          tdes.Clear();
          return Convert.ToBase64String(resultArray, 0, resultArray.Length);

          string ResultString = string.Empty;
          try
          {
              byte[] encData_byte = new byte[toEncrypt.Length];
              encData_byte = System.Text.Encoding.UTF8.GetBytes(toEncrypt);
              ResultString = Convert.ToBase64String(encData_byte);
          }
          catch (Exception ex)
          {
              throw new Exception("Unable to encrypt.");
          }
          return ResultString;
      }

      #endregion

      //  added by anitha on 05/05/2018
      #region convert to decimal places
   
      public string ConvertToDecimalPlace(string value, int countOfDecimalPlace)
      {
          decimal decimalAmount = Convert.ToDecimal(value);
          return decimalAmount.ToString(string.Format("0.{0}", new string('0', countOfDecimalPlace)));
      }
      #endregion


      
  }
}
