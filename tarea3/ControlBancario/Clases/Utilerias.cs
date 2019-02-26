using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace ControlBancario.Clases
{
    public static class Utilerias
    {
        public static void Grabar(Banco banco, string arch) {
            IFormatter formatter = new BinaryFormatter();  
            Stream stream = new FileStream(arch, FileMode.Create, FileAccess.Write, FileShare.None);  
            formatter.Serialize(stream, banco);  
            stream.Close(); 
        }

        public static Banco Leer(string arch) {
            IFormatter formatter = new BinaryFormatter();  
            Stream stream = new FileStream(arch, FileMode.Open, FileAccess.Read, FileShare.Read);  
            Banco obj = (Banco) formatter.Deserialize(stream);  
            stream.Close();  
            return obj;
        }

    }
}