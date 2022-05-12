using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sheltered_2_SE
{
    class ProcessFile
    {

        public static string tempFilePath = string.Empty;
        public static string fileName = string.Empty;
        public string LoadFile(string filePath)
        {
            string data = string.Empty;
            fileName = Path.GetFileName(filePath);
            if (!File.Exists(filePath))
            {
                return "";
            }
            using (FileStream fileStream = File.OpenRead(filePath))
            {
                if (fileStream != null)
                {
                    byte[] array = new byte[fileStream.Length];
                    int num = fileStream.Read(array, 0, (int)fileStream.Length);
                    if ((long)num != fileStream.Length)
                    {
                        return "";
                    }
                    int num2 = 0;
                    byte[] array2 = new byte[]
                    {
                    172,
                    242,
                    115,
                    58,
                    254,
                    222,
                    170,
                    33,
                    48,
                    13,
                    167,
                    21,
                    139,
                    109,
                    74,
                    186,
                    171
                    };
                    byte[] array3 = new byte[]
                    {
                    0,
                    2,
                    4,
                    1,
                    6,
                    15,
                    13,
                    16,
                    8,
                    3,
                    12,
                    10,
                    5,
                    9,
                    11,
                    7,
                    14
                    };
                    for (int i = 0; i < array.Length; i++)
                    {
                        array[i] ^= array2[(int)array3[num2++]];
                        if (num2 >= array3.Length)
                        {
                            num2 = 0;
                        }
                    }
                    data = Encoding.UTF8.GetString(array);
                    tempFilePath = Path.GetTempPath() + Guid.NewGuid().ToString() + ".tmp";
                    using (FileStream fileStream2 = File.Create(tempFilePath))
                    {
                        if (fileStream2 != null)
                        {
                            fileStream2.Write(array, 0, array.Length);
                            fileStream2.Flush();
                        }
                        else
                        {
                            return "";
                        }
                    }
                }
            }
            return data;
        }
        public bool SaveFile(string filePath)
        {
            var data = File.ReadAllBytes(tempFilePath);
            if (data == null || data.Length == 0)
            {
                return false;
            }
            if (data.Length > 0)
            {
                int num = 0;
                byte[] array = new byte[]
                {
                172,
                242,
                115,
                58,
                254,
                222,
                170,
                33,
                48,
                13,
                167,
                21,
                139,
                109,
                74,
                186,
                171
                };
                byte[] array2 = new byte[]
                {
                0,
                2,
                4,
                1,
                6,
                15,
                13,
                16,
                8,
                3,
                12,
                10,
                5,
                9,
                11,
                7,
                14
                };
                for (int i = 0; i < data.Length; i++)
                {
                    data[i] ^= array[(int)array2[num++]];
                    if (num >= array2.Length)
                    {
                        num = 0;
                    }
                }
                using (FileStream fileStream = File.Create(filePath))
                {
                    if (fileStream != null)
                    {
                        fileStream.Write(data, 0, data.Length);
                        fileStream.Flush();
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            else
            {
                return false;
            }
        }
    }
}

