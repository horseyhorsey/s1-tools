using Xunit;
using S1.Domain;
using System.Linq;
using S1.DataStore;

namespace S1.Tests
{
    public partial class UnitTest1
    {
        const string PLUGIN_FILE = @"C:\Users\funky\AppData\Roaming\PreSonus\Studio One 5\x64\Plugins-en.settings";

        const string S1_DATA_DIR = @"E:\Audio\Studio One 5 Data";


        [Fact]
        public void DeseriliazePluginSettings_Tests()
        {
            var s1Plugins = S1Plugin.GetS1Plugins(PLUGIN_FILE);
            Assert.NotNull(s1Plugins);
            Assert.True(s1Plugins.Length > 0);
        }

        [Fact]
        public void GetMacroFiles()
        {            
            var macros = Macro.GetS1Macros(S1_DATA_DIR);
            Assert.True(macros.Length > 0);
        }

        [Fact]
        public void GetDataStore()
        {
            using (var d = new DataStoreContext())
            {
                var items = d.PresetDescriptors.Take(100).ToList();
                Assert.True(items.Count > 0);
            };
        }
    }
}
