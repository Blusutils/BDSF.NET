namespace Blusutils.BDSF {
    public class BdsfIO {
        public static void CreateFile(string path, DataType dataType, BdsfDocument[] docs = null) {
            using var file = new FileStream(path, new FileStreamOptions() { Mode = FileMode.OpenOrCreate, Access = FileAccess.ReadWrite });
            file.Position = 0;
            // type of file
            file.WriteByte((byte)dataType);
            // write pathes
            foreach (var doc in docs) {
                file.WriteByte(doc.path.key);

                file.WriteByte(0);
            }
            file.WriteByte(0);
        }
    }
}