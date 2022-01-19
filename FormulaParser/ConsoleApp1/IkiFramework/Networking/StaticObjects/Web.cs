using System;
using System.Net;
using System.Text;
namespace IkiCore.Core
{
    /// <summary>
    /// Some web tools
    /// </summary>
    public static class Web
    {
        /// <summary>
        /// Post the data to a website, then, return the value of the page.
        /// </summary>
        /// <param name="Url"></param>
        /// <param name="postdata"></param>
        /// <returns></returns>
        public static string GetPost(string Url, params string[] postdata)
        {
            string result;
            string data = string.Empty;
            if (postdata.Length % 2 != 0)
            {
                throw new InvalidProgramException("Parameters must be even , \"user\" , \"value\" , ... etc");
            }
            for (int i = 0; i < postdata.Length; i += 2)
            {
                data = $"{data}{string.Format("&{0}={1}", postdata[i], postdata[i + 1])}";
            }
            data = data.Remove(0, 1);
            byte[] bytesarr = new ASCIIEncoding().GetBytes(data);
            try
            {
                WebRequest request = WebRequest.Create(Url);
                request.Method = "POST";
                request.ContentType = "application/x-www-form-urlencoded";
                request.ContentLength = bytesarr.Length;
                System.IO.Stream streamwriter = request.GetRequestStream();
                streamwriter.Write(bytesarr, 0, bytesarr.Length);
                streamwriter.Close();
                WebResponse response = request.GetResponse();
                streamwriter = response.GetResponseStream();
                System.IO.StreamReader streamread = new System.IO.StreamReader(streamwriter);
                result = streamread.ReadToEnd();
                streamread.Close();
            }
            catch (Exception ex)
            {
                throw new InvalidProgramException(ex.Message);
            }
            return result;
        }
        /// <summary>
        /// Post datas on a website
        /// </summary>
        /// <param name="Url"></param>
        /// <param name="postdata"></param>
        public static void Post(string Url, params string[] postdata)
        {
            string data = string.Empty;
            if (postdata.Length % 2 != 0)
            {
                throw new InvalidProgramException("Parameters must be even , \"user\" , \"value\" , ... etc");
            }
            for (int i = 0; i < postdata.Length; i += 2)
            {
                data = $"{data}{string.Format("&{0}={1}", postdata[i], postdata[i + 1])}";
            }
            data = data.Remove(0, 1);
            byte[] bytesarr = new ASCIIEncoding().GetBytes(data);
            try
            {
                WebRequest request = WebRequest.Create(Url);
                request.Method = "POST";
                request.ContentType = "application/x-www-form-urlencoded";
                request.ContentLength = bytesarr.Length;
                System.IO.Stream streamwriter = request.GetRequestStream();
                streamwriter.Write(bytesarr, 0, bytesarr.Length);
                streamwriter.Close();
            }
            catch (Exception ex)
            {
                throw new InvalidProgramException(ex.Message);
            }
        }
        /// <summary>
        /// Get datas from a website
        /// </summary>
        /// <param name="Url"></param>
        /// <returns></returns>
        public static string Get(string Url)
        {
            string result;
            try
            {
                WebRequest request = WebRequest.Create(Url);
                request.Method = "GET";
                request.ContentType = "application/x-www-form-urlencoded";
                System.IO.Stream streamwriter = request.GetRequestStream();
                WebResponse response = request.GetResponse();
                streamwriter = response.GetResponseStream();
                System.IO.StreamReader streamread = new System.IO.StreamReader(streamwriter);
                result = streamread.ReadToEnd();
                streamread.Close();
            }
            catch (Exception ex)
            {
                throw new InvalidProgramException(ex.Message);
            }
            return result;
        }
    }
}