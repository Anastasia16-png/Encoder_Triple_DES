using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace triple_DES_cipher.Services
{
    public static class AccessControl
    {
        public static readonly Dictionary<string, List<string>> DepartmentFilePermissions = new()
        {
            { "Генеральний директор", new List<string> { "file1.txt", "file2.txt" } },
            { "Секретар", new List<string> { "file3.txt" } },
            { "Відділ кадрів", new List<string> { "file4.txt", "file5.txt" } },
            { "Бухгалтерія", new List<string> { "file6.txt" } },
            { "Економічний відділ", new List<string> { "file7.txt" } },
            { "Відділ охорони", new List<string> { "file8.txt" } },
            { "IT відділ", new List<string> { "file9.txt", "file10.txt" } },
            { "Відділ маркетингу", new List<string> { "file11.txt" } },
            { "Відділ продажів", new List<string> { "file12.txt" } },
            { "Юридичний відділ", new List<string> { "file13.txt" } }
        };

        public static bool HasAccess(string department, string fileName)
        {
            return DepartmentFilePermissions.ContainsKey(department) && DepartmentFilePermissions[department].Contains(fileName);
        }
    }
}
