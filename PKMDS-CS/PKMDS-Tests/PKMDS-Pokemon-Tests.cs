using Microsoft.VisualStudio.TestTools.UnitTesting;
using PKMDS_CS;
using System.Linq;

namespace PKMDS_Tests
{
    [TestClass]
    public class PokemonTests
    {
        private const string veekundb = @"veekun-pokedex.sqlite";
        private const string xysavfile = @"..\..\..\files\sav\PokemonXYDecrypted.sav";

        [TestMethod]
        public void TestEncryption()
        {
            ISave _sav;
            _sav = StructUtils.RawDeserialize<XYSav>(xysavfile);
            var oPIDs = _sav.PCStorageSystem.Boxes.SelectMany(box => box.Pokemon).ToList().Select(pokemon => pokemon.PID).ToList();
            _sav.PCStorageSystem.Boxes.SelectMany(box => box.Pokemon).ToList().ForEach(pokemon => pokemon.Decrypt());
            _sav.PCStorageSystem.Boxes.SelectMany(box => box.Pokemon).ToList().ForEach(pokemon => pokemon.Encrypt());
            var nPIDs = _sav.PCStorageSystem.Boxes.SelectMany(box => box.Pokemon).ToList().Select(pokemon => pokemon.PID).ToList();
            for (int i = 0; i < oPIDs.Count(); i++)
            {
                Assert.AreEqual(oPIDs[i], nPIDs[i]);
            }
        }
    }
}