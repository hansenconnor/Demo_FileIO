using System;
using System.Collections.Generic;
using System.IO;
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
            List<string> charactersString = new List<string>();
            List<Character> characters = new List<Character>();

            try
            {
                StreamReader sr = new StreamReader(_dataFilePath);
                using (sr)
                {
                    while (!sr.EndOfStream)
                    {
                        charactersString.Add(sr.ReadLine());
                    }
                    foreach (string characterString in charactersString)
                    {
                        characters.Add(CharacterObjectBuilder(characterString));
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }

            return characters;
        }

        public void WriteAll(IEnumerable<Character> characters)
        {
            throw new NotImplementedException();
        }
    }
}
