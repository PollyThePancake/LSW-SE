namespace SaveFileStructure
{
    class Program
    {

        public static void CalcSaveChecksums(string savePath, int start, int end, uint salt, int saveLength)
        {
            List<byte> byteArray = new List<byte>(File.ReadAllBytes(savePath));
            for (int a = 0; a < saveLength * 3; a += saveLength)
            {
                uint checksum = salt;
                for (int b = start + a; b < end + a; b += 4)
                {
                    checksum += BitConverter.ToUInt32(byteArray.Skip(b).Take(4).Reverse().ToArray());
                }
                if (checksum == salt) { checksum = 0; }
                Console.WriteLine(checksum.ToString("X8"));
                byteArray[end + a] = (byte)(checksum >> 24);
                byteArray[end + a + 1] = (byte)(checksum >> 16);
                byteArray[end + a + 2] = (byte)(checksum >> 8);
                byteArray[end + a + 3] = (byte)checksum;
            }
            File.WriteAllBytes(savePath, byteArray.ToArray());
        }

        public static void CalcFileChecksum(string savePath, int start, int end, uint salt)
        {
            List<byte> byteArray = new List<byte>(File.ReadAllBytes(savePath));
            uint checksum = salt;
            for (int a = start; a < end; a++)
            {
                checksum += byteArray[a];
            }
            Console.WriteLine(checksum.ToString("X8"));
            byteArray[end] = (byte)(checksum >> 24);
            byteArray[end + 1] = (byte)(checksum >> 16);
            byteArray[end + 2] = (byte)(checksum >> 8);
            byteArray[end + 3] = (byte)checksum;
            File.WriteAllBytes(savePath, byteArray.ToArray());
        }

        static void Main(string[] args)
        {
            string saveDirectory = "D:\\Downloads\\Final\\FILE_V28";
            CalcSaveChecksums(saveDirectory, 0x3C, 0x7E88, 0x5C0999, 0x7E7C);
            CalcFileChecksum(saveDirectory, 0x0, 0x1FA00, 0xDEADBEEF);
            saveDirectory = "D:\\Downloads\\Print Preview\\FILE_V28";
            CalcSaveChecksums(saveDirectory, 0x3C, 0x7C64, 0x5C0999, 0x7C58);
            CalcFileChecksum(saveDirectory, 0x0, 0x1F170, 0xDEADBEEF);
        }
    }
}