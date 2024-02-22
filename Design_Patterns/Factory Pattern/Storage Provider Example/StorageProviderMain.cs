using Design_Patterns.Abstract_Factory_Pattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Factory_Pattern.Storage_Provider_Example
{
    public class StorageProviderMain
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Select your storage provider (AWS, Azure, GoogleCloud): ");
            string providerName = Console.ReadLine();

            try
            {
                IStorageProvider storageProvider = StorageProviderFactory.CreateStorageProvider(providerName);
                storageProvider.SaveFile("sample.txt", new byte[] { 0x01, 0x02 });   
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadKey();
        }
    }
}
