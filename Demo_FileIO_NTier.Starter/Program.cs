using Demo_FileIO_NTier.Starter.DataAccessLayer;
using Demo_FileIO_NTier.Starter.BusinessLogicLayer;
using Demo_FileIO_NTier.Starter.PresentationLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_FileIO_NTier
{
    class Program
    {
        static void Main(string[] args)
        {

            IDataService dataService;
            CharacterBLL characterBLL;
            Presenter presenter;

            // Run CSV Serializer
            dataService = new CsvDataService();
            characterBLL = new CharacterBLL(dataService);
            presenter = new Presenter(characterBLL);

            // Run XML Serializer
            dataService = new XmlDataService();
            characterBLL = new CharacterBLL(dataService);
            presenter = new Presenter(characterBLL);

        }
    }
}
