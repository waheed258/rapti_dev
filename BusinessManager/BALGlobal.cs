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
     
      public string Decrypt(string EncryptedText)
      {
          byte[] inputByteArray = new byte[EncryptedText.Length + 1];
          byte[] rgbIV = { 0x21, 0x43, 0x56, 0x87, 0x10, 0xfd, 0xea, 0x1c };
          byte[] key = { };

          try
          {
              key = System.Text.Encoding.UTF8.GetBytes("McaMCAMA");
              DESCryptoServiceProvider des = new DESCryptoServiceProvider();
              inputByteArray = Convert.FromBase64String(EncryptedText);
              MemoryStream ms = new MemoryStream();
              CryptoStream cs = new CryptoStream(ms, des.CreateDecryptor(key, rgbIV), CryptoStreamMode.Write);
              cs.Write(inputByteArray, 0, inputByteArray.Length);
              cs.FlushFinalBlock();
              System.Text.Encoding encoding = System.Text.Encoding.UTF8;
              return encoding.GetString(ms.ToArray());
          }
          catch (Exception e)
          {
              return e.Message;
          }
      }


      public string Encrypt(string stringToEncrypt)
      {
          byte[] inputByteArray = Encoding.UTF8.GetBytes(stringToEncrypt);
          byte[] rgbIV = { 0x21, 0x43, 0x56, 0x87, 0x10, 0xfd, 0xea, 0x1c };
          byte[] key = { };
          try
          {
              key = System.Text.Encoding.UTF8.GetBytes("McaMCAMA");
              DESCryptoServiceProvider des = new DESCryptoServiceProvider();
              MemoryStream ms = new MemoryStream();
              CryptoStream cs = new CryptoStream(ms, des.CreateEncryptor(key, rgbIV), CryptoStreamMode.Write);
              cs.Write(inputByteArray, 0, inputByteArray.Length);
              cs.FlushFinalBlock();
              return Convert.ToBase64String(ms.ToArray());
          }
          catch (Exception e)
          {
              return e.Message;
          }
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
