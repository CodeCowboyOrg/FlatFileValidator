using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace FlatFileValidator.Parser
{
    public class FileReader
    {
        private string m_fileName = null;
        private int m_lineCount = 0;

        #region Properties
        public int LineCount
        {
            get { return m_lineCount; }
            set { m_lineCount = value; }
        }

        public string FileName
        {
            get { return m_fileName; }
            set { m_fileName = value; }
        }
        #endregion Properties
        
        #region Public Constructor
        public FileReader(string fileName)
        {
            m_fileName = fileName;
        }
        #endregion Public Constructor

        #region Public Methods

        public void Process()
        {
            string path = m_fileName;
            try
            {
                if (File.Exists(path))
                {
                    using (StreamReader sr = new StreamReader(path))
                    {
                        string line = null;
                        while ((line = sr.ReadLine()) != null)
                        {
                            m_lineCount++;
                        }

                    }
                }

            }
            catch (Exception e)
            {
                Console.WriteLine("The process failed: {0}", e.ToString());
            }
        }
        #endregion Public Methods

    }
}
