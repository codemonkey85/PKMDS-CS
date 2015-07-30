using Microsoft.VisualStudio.TestTools.UnitTesting;
using PKMDS_CS;
using System;
using System.Linq;

namespace PKMDS_Tests
{
    [TestClass]
    public class PokemonTests
    {
        private const string veekundb = @"veekun-pokedex.sqlite";
        private const string xysavfile = @"..\..\..\files\sav\PokemonXYDecrypted.sav";

        private IPokemon testPokemon;

        [TestInitialize]
        public void TestInit()
        {
            testPokemon = new Pokemon()
            {
                Species = Species.Pikachu,
                EncryptionKey = 0,
                OTGameID = 28,
                OTName = "Mike",
                OTGender = Genders.Male,
                OTID = 12345,
                OTSecretID = 54321,
                PID = 0x44444444,
                ivs = 0x55555555,
                EXP = 50000,
                Ability = Abilities.Static,
                HeldItem = Items.NoItem,
                Ball = Items.Poke_Ball,
                MetDate = new DateTime(2015, 07, 31),
                MetLocation = Locations.Route_1
            };
        }

        [TestMethod]
        public void TestAbility()
        {
            Assert.AreEqual(testPokemon.Ability.Name, Lists.AbilityList.FirstOrDefault(ability => ability.Value == Abilities.Static).Name);
        }

        [TestMethod]
        public void TestGender()
        {
            DBTools.OpenDB(veekundb);
            var gender = testPokemon.Gender;
            DBTools.CloseDB();
        }

        [TestMethod]
        public void TestItemQuantity()
        {
            ItemObject item = new ItemObject() { Value = Items.Protector, Quantity = 2 };
            item += 1;
            Assert.AreEqual(item.Quantity, 3);
            item -= 2;
            Assert.AreEqual(item.Quantity, 1);
            item++;
            Assert.AreEqual(item.Quantity, 2);
            item--;
            Assert.AreEqual(item.Quantity, 1);
        }

        [TestMethod]
        public void TestItemInitializerUInt32()
        {
            ItemObject item1 = new ItemObject() { Value = Items.Poke_Ball, Quantity = 2 };
            ItemObject item2 = new ItemObject(131076);
            Assert.AreEqual(item1.Value, item2.Value);
            Assert.AreEqual(item1.Quantity, item2.Quantity);
        }

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