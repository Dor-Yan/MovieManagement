using MovieManagement.Application.Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieManagement.Infrastructure.FileStore
{
    public class FileWrapper : IFileWrapper
    {
        public void WriteAllBytes(string outpuFile, byte[] content)
        {
            File.WriteAllBytes(outpuFile, content);
        }
    }
}
