using System;
using System.Net;
using System.Net.Mail;
using TMPro;
using UnityEngine;

public class MailEncodeSender : MonoBehaviour
{
    private string senderEmail = "ingmultimediausbbog@gmail.com";
    private string senderPassword = "qnlp lyyq wzrw mbdy";
    private string emailSubject;
    private string recipientEmail;
    private string emailContent;

    public TMP_InputField subjectInput;
    public TMP_InputField recipientInput;
    public TMP_InputField messageInput;

    public void SendEmail()
    {
        if (subjectInput != null)
        {
            emailSubject = subjectInput.text;
            Debug.Log("Email subject: " + emailSubject);
        }

        if (recipientInput != null)
        {
            recipientEmail = recipientInput.text;
            Debug.Log("Recipient email: " + recipientEmail);
        }

        if (messageInput != null)
        {
            emailContent = EncryptMessage(messageInput.text);
            Debug.Log("Encrypted email content: " + emailContent);
        }

        MailMessage mail = new MailMessage();
        mail.From = new MailAddress(senderEmail);
        mail.To.Add(recipientEmail);
        mail.Subject = emailSubject;
        mail.Body = emailContent;

        SmtpClient smtpServer = new SmtpClient("smtp.gmail.com");
        smtpServer.Port = 587;
        smtpServer.Credentials = new NetworkCredential(senderEmail, senderPassword) as ICredentialsByHost;
        smtpServer.EnableSsl = true;

        try
        {
            smtpServer.Send(mail);
            Debug.Log("Email sent successfully.");
            
        }
        catch (System.Exception e)
        {
            Debug.LogError("Error sending email: " + e.Message);
            
        }
    }

    public string EncryptMessage(string message)
    {
        string filter1 = ReplaceVowels(message);
        Debug.Log("Filter 1: " + filter1);

        string filter2 = ReverseText(filter1);
        Debug.Log("Filter 2: " + filter2);

        string filter3 = WordReplacer(filter2);
        Debug.Log("Filter 3: " + filter3);

        return filter3;
    }

    private string ReplaceVowels(string text)
    {
        return text
            .Replace("a", "3")
            .Replace("e", "$")
            .Replace("i", "&")
            .Replace("o", "##")
            .Replace("u", "?");
    }

    private string ReverseText(string text)
    {
        char[] chars = text.ToCharArray();
        Array.Reverse(chars);
        return new string(chars);
    }

    private string WordReplacer(string text)
    {
        string result = text;

        result = result
            .Replace("k", "W")
            .Replace("s", "d")
            .Replace("m", "t")
            .Replace("a", "g")
            .Replace("n", "p")
            .Replace("e", "q")
            .Replace("o", "8")
            .Replace("u", "98")
            .Replace("r", "0")
            .Replace("l", "1")
            .Replace("d", "4")
            .Replace("t", "999");

        return result;
    }
}
