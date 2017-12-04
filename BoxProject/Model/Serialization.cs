using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;
using Windows.Storage;

namespace BoxProject.Model
{
    class Serialization
    {
        private ObservableCollection<Item> _itemsCatalog;

        public async Task SavetoJson(ObservableCollection<Item> items)
        {
            var localFolder = ApplicationData.Current.LocalFolder;
            var jsonFile = await localFolder.CreateFileAsync("items2.json", CreationCollisionOption.ReplaceExisting);
            var jsonSerializer = new DataContractJsonSerializer(typeof(ObservableCollection<Item>));
            using (var stream = await jsonFile.OpenStreamForWriteAsync())
            {
                jsonSerializer.WriteObject(stream, items);
            }
        }
        
        public async Task<ObservableCollection<Item>> LoadFromJson()
        {
            var localFolder = ApplicationData.Current.LocalFolder;
            var jsonFile = await localFolder.GetFileAsync("itemCatalog.json");
            var jsonSerializer = new DataContractJsonSerializer(typeof(ObservableCollection<Item>));
            using (var stream = await jsonFile.OpenStreamForReadAsync())
            {
                _itemsCatalog = jsonSerializer.ReadObject(stream) as ObservableCollection<Item>;
            }

            return _itemsCatalog;
        }
    }
}
