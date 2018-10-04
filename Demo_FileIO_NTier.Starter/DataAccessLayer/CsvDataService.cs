using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Demo_FileIO_NTier.Models;

namespace Demo_FileIO_NTier.Starter.DataAccessLayer
{
    class CsvDataService : IDataService
    {
        private string _dataFilePath;

        public CsvDataService()
        {
            _dataFilePath = DataSettings.dataFilePath;
        }

        public IEnumerable<Character> ReadAll()
        {
            List<string> characters
        }

        public void WriteAll(IEnumerable<Character> characters)
        {
            throw new NotImplementedException();
        }
    }
}
