using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestExam
{
   public class User
    {
        string fname;
        string lname;
        string tel;

       public void SetFname(string fname)
        {
            this.fname = fname;

        }
        public string GetFname()
        {
            return fname;

        }
        public void SetLname(string lname)
        {
            this.lname = lname;

        }
        public string GetLname()
        {
            return lname;

        }
        public void SetTel(string tel)
        {
            this.tel = tel;

        }
        public string GetTel()
        {
            return tel;

        }
        public void CreateFile(string content, string path)
        {
            if (!File.Exists(path))
            {
                FileStream stream = new FileStream(path, FileMode.Create);
                using (StreamWriter writer = new StreamWriter(stream))
                {
                    writer.Write(content);
                }
            }
            else
            using (StreamWriter sw = File.AppendText(path))
            {
                sw.Write(content);
            }
        }
        public string ReadFile(string path)
        {
            string fileContent = string.Empty;

            using (StreamReader reader = new StreamReader(path))
            {
                fileContent = reader.ReadToEnd();
            }

            return fileContent;
        }
        public int ReadLines(string path)
        {
            int lines = 0;
            using (TextReader reader = File.OpenText(path))
            {
                while (reader.ReadLine() != null) { lines++; }
            }
            return lines;
        }
        public bool DeleteFile(string path)
        {
            try
            {
                File.Delete(path);
            }
            catch (Exception exc)
            {
                //Log system
                Console.Write(exc.Message);
                return false;
            }
            return true;
        }
    }
}
