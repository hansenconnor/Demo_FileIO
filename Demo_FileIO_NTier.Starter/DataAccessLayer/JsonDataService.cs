using Demo_FileIO_NTier.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Collections;

namespace Demo_FileIO_NTier.Starter.DataAccessLayer
{
    class JsonDataService : IDataService
    {
 
        private string _dataFilePath;

        public JsonDataService()
        {
            _dataFilePath = DataSettings.dataFilePathJSON;
        }

        public IEnumerable<Character> ReadAll()
        {
            List<Character> characters = new List<Character>();
            Character jsonCharacterObj;
            string json = File.ReadAllText(_dataFilePath);

            try
            {


                StreamReader sr = new StreamReader(_dataFilePath);
                using (sr)
                {
                    using (JsonReader reader = new JsonTextReader(sr))
                    {
                        JsonSerializer serializer = new JsonSerializer();

                        // read the json from a stream
                        // json size doesn't matter because only a small piece is read at a time from the HTTP request
                        // characters = serializer.Deserialize<List<Character>>(reader);
                        //IList<Character> result = serializer.Deserialize<List<Character>>(reader);


                        characters = JsonConvert.DeserializeObject<List<Character>>(json);
                        //characters.Add(result);
                    }
                }

                //RootObject rootObject = JsonConvert.DeserializeObject<RootObject>(json);
                //characters = rootObject.Characters.Character;

                //var characterObj = JsonConvert.DeserializeObject<Character>(json);
                //jsonCharacterObj = JsonConvert.DeserializeObject<Character>(json);
                //foreach (Character characterObj in jsonCharacterObj)
                //{
                //    characters.Add(characterObj);
                //}



                //var objectToSerialize = new RootObject();
                //objectToSerialize.items = new List<Character>
                //          {
                //             new Character { FirstName = "test1", Age = 22 },
                //             new Character { FirstName = "test2", Age = 22 }
                //          };


            }
            catch (Exception)
            {
                throw;
            }

            return characters;
        }

        public void WriteAll(IEnumerable<Character> characters)
        {
            try
            {
                StreamWriter sw = new StreamWriter(_dataFilePath);
                using (sw)
                {
                    StringBuilder sb = new StringBuilder();
                    sb.Clear();
                    foreach (Character character in characters)
                    {
                        sb.AppendLine(CharacterStringBuilder(character));
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private string CharacterStringBuilder(Character characterObject)
        {
            const string DEL = ",";
            string characterString;

            characterString =
                characterObject.Id + DEL +
                characterObject.LastName + DEL +
                characterObject.FirstName + DEL +
                characterObject.Address + DEL +
                characterObject.City + DEL +
                characterObject.State + DEL +
                characterObject.Zip + DEL +
                characterObject.Age + DEL +
                characterObject.Gender;

            return characterString;
        }
    }
}
