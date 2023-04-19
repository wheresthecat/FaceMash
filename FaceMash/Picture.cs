using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FaceMash
{
    internal class Picture
    {
        private bool m_isSamba;
        private string m_picPath;

        public Picture()
        {

        }
        public Picture(bool isSamba, string picPath)
        {
            m_isSamba = isSamba;
            m_picPath = picPath;
        }

        public void setPath(string path)
        {
            m_picPath = path;
        }

        public string getPath()
        {
            return m_picPath;
        }

        public void setSamba(bool samba)
        {
            m_isSamba = samba;
        }

        public bool getSamba()
        {
            return m_isSamba;
        }
    }
}
