
﻿using System;
using System.Collections;
using System.Threading;
using System.Text;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
//using iTextSharp.text.pdf;
//using iTextSharp.text.pdf.parser;
//using Novacode;
using System.Diagnostics;
using Microsoft.Office;
using Microsoft.Office.Interop.Word;
using System.IO;
using System.Data;
using System.Drawing;
using System.Text;
using System.ComponentModel;
using SpeechLib;
using System.Speech.Synthesis;




public partial class demo : System.Web.UI.Page
{   
    static Stack s1 = new Stack();
    static char ch;
    static String w = "";
    static String meaning = "";
    static Stack s2 = new Stack();
    static List<string> l1 = new List<string>();
    static List<string> l2 = new List<string>();
    System.Web.UI.Timer timer1 = new System.Web.UI.Timer();
    static String chosen;
    static String bg;
    static String sound="";
    static String sound1 = "";
    
    
    protected void Page_Load(object sender, EventArgs e)
    {
        
    }
    
 


   public void BgSelected(object sender,EventArgs e)
    {
        bg = ((LinkButton)sender).Text;
        if (bg == '1'.ToString())
            lblSelectedFont.BackColor = System.Drawing.Color.Green;
        else if (bg == '2'.ToString())
            lblSelectedFont.BackColor = System.Drawing.Color.White;
        else if (bg == '3'.ToString())
            lblSelectedFont.BackColor = System.Drawing.Color.Yellow;

        else if (bg == '4'.ToString())
            lblSelectedFont.BackColor = System.Drawing.Color.Red;


        

    }
    public void ColorSelected(object sender, EventArgs e)
    {   
        
        //color = ((LinkButton)sender).ForeColor.ToString();
        chosen = ((LinkButton)sender).Text;
        if(chosen=='1'.ToString())
        lblSelectedFont.ForeColor = System.Drawing.Color.Brown;
        else if(chosen=='2'.ToString())
            lblSelectedFont.ForeColor = System.Drawing.Color.Blue;
        else if (chosen == '3'.ToString())
            lblSelectedFont.ForeColor = System.Drawing.Color.Black;
        else if (chosen == '4'.ToString())
            lblSelectedFont.ForeColor = System.Drawing.Color.Plum;
 

    }
    protected void FontSelected(object sender, EventArgs e)
    {
        string font = ((LinkButton)sender).Font.Name;
        lblSelectedFont.Font.Name = font;
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        /*    String a = FileUpload1.FileName;
            String ext = Path.GetExtension(a);
            //Label1.Text = ext;
            if (ext == ".txt")
            {

                System.IO.StreamReader reader = new System.IO.StreamReader(FileUpload1.FileContent);
                string text = reader.ReadToEnd();
                //Response.Write(text);
                TextBox1.Text = text;

                //char b=text.ElementAt(3);
                //Response.Write(b);

                //Above section for text file


            }
            if (ext == ".docx" || ext == ".doc")
            {
                //String b = FileUpload1.PostedFile.FileName;
                // Open a doc file.

                string filename = Path.GetFileName(FileUpload1.FileName);
                FileUpload1.SaveAs(Server.MapPath("~/") + filename);
                Application application = new Application();
                Document document = application.Documents.Open(Server.MapPath("~/") + filename);

                // Loop through all words in the document.
                int count = document.Words.Count;
                for (int i = 1; i <= count; i++)
                {
                    // Write the word.
                    string text = document.Words[i].Text;
                    //Response.Write(text);
                    TextBox1.Text = text;
                }
                // Close word.
                application.Quit();
            }
        */
    }


    public void Button2_Click(object sender, EventArgs e)
    {
        //Thread t1 = new Thread();
        s1.Clear();
        s2.Clear();
        l2.Clear();
        String a1 = FileUpload1.FileName;
        String ext1 = Path.GetExtension(a1);
        if (ext1 == ".txt")
        {


            System.IO.StreamReader reader = new System.IO.StreamReader(FileUpload1.FileContent);
            string text = reader.ReadToEnd();
            sound1 = text;

           

            /*foreach (char c in text)
            {
                TextBox2.Text = c.ToString();
                System.Threading.Thread.Sleep();
            }*/


            TextBox1.Text = text;
            String[] words = text.Split();
            for (int i = 0; i < words.Length; i++)
            {
                l1.Add(words[i]);
            }
            foreach (string word in words)
            {

                Char[] letters = word.ToCharArray();
                foreach (char letter in letters)
                {
                    //Label1.Text = "";
                    //Label1.Text = letter.ToString();
                    s1.Push(letter);

                    //Response.Write(letter);
                    //Response.Write("<br>");
                    //TextBox2.Text = "letter";
                    //  timer1.Interval = 5000;
                    //TextBox2.Text = "";

                    // Response.Write(s1.ToString());

                    //Response.Clear();


                    //TextBox2.Text = letter + "\t";
                }
                s1.Push(" ");
                //s2.Push(word);
                //Response.Write(s2.ToString());
                //Label1.Text = "";
                //Label1.Text = word;
                //Thread.Sleep(1000);
                //Response.Write(word);
                //Response.Write("<br>");
                //TextBox2.Text = "word";

                //TextBox2.Text = "";

                //Response.Clear();
                //TextBox2.Text = word + "\n";
            }
            //TextBox2.Text = text;
            w = "";
            while (s1.Count != 0)
            {
                s2.Push(s1.Pop());
            }
        }

    }

    private void Page_Load()
    {
        throw new NotImplementedException();
        //Button3.Enabled = true;
        //Button4.Enabled = true;
    }
    /*Byte[] FileBuffer = FileUpload1.FileBytes;
    if (FileBuffer != null)
    {
        Response.ContentType = "application/pdf";
        String fb = FileBuffer.Length.ToString();
        Response.AddHeader("content-length", fb);
        Response.BinaryWrite(FileBuffer);
            
            
    }*/

    //Extracts PDF, no manipulation
    /*String path=Request.Path.ToString();

    using (iTextSharp.text.pdf.PdfReader x = new PdfReader(path)) 
    {
        StringBuilder text1 = new StringBuilder();

        for (int i = 1; i <= x.NumberOfPages; i++)
        {
            text1.Append(PdfTextExtractor.GetTextFromPage(x, i));
        }

         Response.Write(text1.ToString());
    }

/*string strText = string.Empty;
StringBuilder text = new StringBuilder();
try
{ 
   String a=FileUpload1.FileName;
PdfReader reader = new PdfReader((string)a);
if (System.IO.File.Exists(a))
{
PdfReader pdfReader = new PdfReader(a);

for (int page = 1; page <= pdfReader.NumberOfPages; page++)
  {

ITextExtractionStrategy strategy = new SimpleTextExtractionStrategy();

string currentText = PdfTextExtractor.GetTextFromPage(pdfReader, page, strategy);

      text.Append(currentText);

            }
            pdfReader.Close();
        }
    }
    catch (Exception ex)
    {
        Response.Write(ex.Message);
    }
    String Text = text.ToString();
    Response.Write(Text);*/


    /*protected void Button3_Click(object sender, EventArgs e)
    {

        String a1 = FileUpload1.FileName;
        String ext1 = Path.GetExtension(a1);
        if (ext1 == ".txt")
        {

            System.IO.StreamReader reader = new System.IO.StreamReader(FileUpload1.FileContent);
            string text = reader.ReadToEnd();
            Stack st1 = new Stack();
            Stack st2 = new Stack();
            String[] words = text.Split();
            foreach (string word in words)
            {

                Char[] letters = word.ToCharArray();
                foreach (char letter in letters)
                {
                    //Response.Write(letter);
                    //Response.Write("<br>");


                    st1.Push(letter);
                    Response.ClearContent();
                    Response.Write(letter);

                }
                //st1.Clear();

                //Response.Write(word);
                //Response.Write("<br>");

                st2.Push(word);
            }
            st2.Clear();

        }

    }

    */

    protected void Button3_Click(object sender, EventArgs e)
    {
        Button4.Enabled = true;
        //Label1.Text = "";
        lblSelectedFont.Text = "";
        //sound = lblSelectedFont.Text;
        pushpop(s2, s1);

        //s2 is s1 after reversing stack. S1 is empty.
    }
    public void pushpop(Stack j, Stack k)
    {
        //Button3.Enabled = true;
        if (j.Count != 0)
        {
            k.Push(j.Peek());
            ch = Convert.ToChar(j.Pop());
            if (ch != ' ')
            {
                w = w + ch.ToString();
                //Label1.Text = ch.ToString();
                lblSelectedFont.Text = String.Format(ch.ToString());
                sound = lblSelectedFont.Text;
                
                
            }
            else if (j.Count != 0)
            {
                //  String mno = k.Pop().ToString();
                //Label1.Text = w;
                lblSelectedFont.Text = String.Format(w);
                sound = lblSelectedFont.Text;
                l2.Add(w);
                meaning = w;
                w = "";
            }
        }
        else if (j.Count == 0)
        {
            //Label1.Text = w;
            lblSelectedFont.Text = String.Format(w);
            sound = lblSelectedFont.Text;
            l2.Add(w);
            meaning = w;
            w = "";
            Response.Write("END");
            Button3.Enabled = false;
        }

    }
    protected void Button4_Click(object sender, EventArgs e)
    {
        Button3.Enabled = true;
        //Label1.Text = "";
        lblSelectedFont.Text = "";
        sound = lblSelectedFont.Text;
        goback(s2, s1);
        //S1 must have prev letter s2 is current
    }
    public void goback(Stack j, Stack k)
    {
        //Button4.Enabled = true;
        if (k.Count != 0)
        {
            j.Push(k.Peek());
            ch = Convert.ToChar(k.Pop());

            if (ch != ' ')
            {
                w = w.Remove(w.Length - 1);
                //Label1.Text = ch.ToString();
                lblSelectedFont.Text = String.Format(ch.ToString());
                sound = lblSelectedFont.Text;
            }
            else if (k.Count != 0)
            {
                //  String mno = k.Pop().ToString();
                w = string.Copy(l2.ElementAt(l2.Count - 1));
                l2.RemoveAt(l2.Count - 1);
                //Label1.Text = w;
                lblSelectedFont.Text = String.Format(w);
                sound = lblSelectedFont.Text;
                meaning = w;

            }
        }
        else if (k.Count == 0)
        {
            // w = string.Copy(l2.ElementAt(l2.Count - 1));
            //Label1.Text = w;
            lblSelectedFont.Text = String.Format(w);
            sound = lblSelectedFont.Text;
            meaning = w;
            Response.Write("BEGINNING OF TEXT");
            //l2.RemoveAt(l2.Count - 1);
            Button4.Enabled = false;
        }
    }


    protected void Button5_Click(object sender, EventArgs e)
    {
        if(sound=="")
        {
            sound = "Please press a button to continue";
        }
        using (SpeechSynthesizer synth =
  new SpeechSynthesizer())
        {
            synth.Volume = 100;
            synth.Rate = -5;
            synth.Speak(sound);
        }
    }
    protected void Button6_Click(object sender, EventArgs e)
    {
        if (sound1 == "")
        {
            sound1 = "Please select a file to continue";
        }
        using (SpeechSynthesizer synth1 =
  new SpeechSynthesizer())
        {
            synth1.Volume = 100;
            synth1.Rate = -5;
            
            synth1.Speak(sound1);
            
        }
    }
    
    protected void Button7_Click(object sender, EventArgs e)
    {
        //Response.Redirect("OtherPage.aspx");
        Response.Redirect("OtherPage.aspx?m1= "+meaning);
    }

    
}