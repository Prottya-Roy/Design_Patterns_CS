using Design_Patterns.Abstract_Factory_Pattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Factory_Pattern.Storage_Provider_Example
{
    internal class AWSProvider : IStorageProvider
    {
        public byte[] RetrieveFile(string fileName)
        {
            Console.WriteLine($"Retrieving {fileName} from AWS...");
            // Logic for retrieving file 
            return new byte[0];
        }

        public void SaveFile(string fileName, byte[] fileData)
        {
            Console.WriteLine($"Saving {fileName} to AWS...");
            //Logic for Saving File
        }
    }
}
