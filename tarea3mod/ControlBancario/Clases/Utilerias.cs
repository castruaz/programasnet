using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace ControlBancario.Clases
{
    public static class Utilerias
    {
        public static void Grabar(Banco banco, string nomarch) {
            IFormatter formatter = new BinaryFormatter();  
            Stream stream = new FileStream(nomarch, FileMode.Create, FileAccess.Write, FileShare.None);  
            formatter.Serialize(stream, banco);  
            stream.Close();  
        }

          public static Banco Leer(string nomarch) {
            IFormatter formatter = new BinaryFormatter();  
            Stream stream = new FileStream(nomarch, FileMode.Open, FileAccess.Read, FileShare.Read);  
            Banco obj = (Banco) formatter.Deserialize(stream);  
            stream.Close();  
            return obj;
          }
    }

}

  

