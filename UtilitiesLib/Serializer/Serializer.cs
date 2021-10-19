using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateDAL.Serializer
{
    public class Serializer
    {
        public static string BinaryFileSerialize(Object obj, string filePath)
        {
            FileStream fileStream = null; 
            string errorMsg = null;
            try
            {
                fileStream = new FileStream(filePath, FileMode.Create);
                BinaryFormatter b = new BinaryFormatter();
                b.Serialize(fileStream, obj);
            }
            catch (Exception e)
            { 
                errorMsg = e.Message;
            }
            finally
            {
                Debug.WriteLine("5");
                if (fileStream != null) fileStream.Close();
            }
            return errorMsg; 
        }

        public static T BinaryFileDeSerialize<T>(string filePath, out string errorMessage) 
        {     
            FileStream fileStream = null; 
            errorMessage = null;     
            Object obj = null; 
            try    
            { 
                if (!File.Exists(filePath))         
                {
                    errorMessage = $"The file {filePath}  was not found. "; 
                    throw (new FileNotFoundException(errorMessage));         
                }
                fileStream = new FileStream(filePath, FileMode.Open); 
                BinaryFormatter b = new BinaryFormatter(); 
                obj = b.Deserialize(fileStream);     
            } 
            catch (Exception e)
            {
                if (errorMessage != null) errorMessage = e.Message;    
            } 
            finally    
            { 
                if (fileStream != null) fileStream.Close();     
            }
            return (T)obj;                             
        }

        public static byte[] BinaryArraySerialize(Object obj)
        {
            byte[] serializedObject;
            MemoryStream ms = new MemoryStream();
            BinaryFormatter b = new BinaryFormatter();
            b.Serialize(ms, obj);
            ms.Seek(0, 0);
            serializedObject = ms.ToArray();
            ms.Close();
            return serializedObject;
        }

        public static T BinaryArrayDeSerialize<T>(byte[] serializedObject) 
        { 
            MemoryStream ms = new MemoryStream(); 
            ms.Write(serializedObject,  0, serializedObject.Length);    
            ms.Seek(0, 0); 
            BinaryFormatter b = new BinaryFormatter(); 
            Object obj = b.Deserialize(ms); 
            ms.Close(); 
            return (T) obj;
        }
    }
}


