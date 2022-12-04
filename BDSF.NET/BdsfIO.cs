using Blusutils.BDSF.Conversions;

namespace Blusutils.BDSF {
    public class BdsfIO {
        static byte[] EncodeObject(object o) {
            return new byte[0];
        }
        public static void CreateFile(string path, DocType docType, BdsfDocument[] docs = null) {
            using var file = new FileStream(path, new FileStreamOptions() { Mode = FileMode.OpenOrCreate, Access = FileAccess.ReadWrite });
            file.Position = 0;
            // type of file
            file.WriteByte((byte)docType);
            // write pathes
            foreach (var doc in docs) {
                file.WriteByte(doc.Path!.keyType);

                foreach (var b in doc.Path.keyValue!)
                    file.WriteByte(b);
                
                foreach (var b in doc.Path.indents!)
                    foreach (var bb in b.ToBdsfObject())
                        file.WriteByte(bb);

                file.WriteByte(0);
            }
            file.WriteByte(0);
        }
    }
}