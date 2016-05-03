using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.IO.Compression;

namespace QompresC
{
    class Kompress
    {

        public static byte[] CompressBuffer(byte[] byteArray)
        {
            MemoryStream strm = new MemoryStream();
            GZipStream GZipStrem = new GZipStream(strm, CompressionMode.Compress, true);
            GZipStrem.Write(byteArray, 0, byteArray.Length);
            GZipStrem.Flush();
            strm.Flush();
            byte[] ByteArrayToreturn = strm.GetBuffer();
            GZipStrem.Close();
            strm.Close();
            return ByteArrayToreturn;
        }
        public static byte[] DeCompressBuffer(byte[] byteArray)
        {
            MemoryStream strm = new MemoryStream(byteArray);
            GZipStream GZipStrem = new GZipStream(strm, CompressionMode.Decompress, true);
            List<byte> ByteListUncompressedData = new List<byte>();

            int bytesRead = GZipStrem.ReadByte();
            while (bytesRead != -1)
            {
                ByteListUncompressedData.Add((byte)bytesRead);
                bytesRead = GZipStrem.ReadByte();
            }
            GZipStrem.Flush();
            strm.Flush();
            GZipStrem.Close();
            strm.Close();
            return ByteListUncompressedData.ToArray();
        }
    }
}
