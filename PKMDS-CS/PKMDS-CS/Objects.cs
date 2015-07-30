using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;

namespace PKMDS_CS
{
    public struct ItemObject
    {
        public ItemObject(Items item)
            : this()
        {
            Value = item;
            Quantity = 0;
        }

        private Items value;
        private ushort quantity;

        public Items Value
        {
            get
            {
                return value;
            }
            set
            {
                this.value = Enum.IsDefined(typeof(Items), value)
                    ? (Items)value
                    : Items.NoItem;
            }
        }

        public ushort Quantity
        {
            get
            {
                return quantity;
            }
            set
            {
                quantity = value;
            }
        }

        public Image Image
        {
            get { return Images.GetItemImage((ushort)Value); }
        }

        public string Name
        {
            get { return value.EnumToString(); }
        }

        public override string ToString()
        {
            return Name;
        }

        public override bool Equals(Object obj)
        {
            try
            {
                if (obj == null || obj == DBNull.Value)
                {
                    return false;
                }

                if (obj is Items) return Value == (Items)obj;

                ItemObject i = (ItemObject)obj;
                if ((Object)i == null)
                {
                    return false;
                }

                return Value == i.Value;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Equals(Items i)
        {
            if ((object)i == null)
            {
                return false;
            }

            return Value == i;
        }

        public override int GetHashCode()
        {
            return (int)value;
        }

        public static bool operator ==(ItemObject a, Items b)
        {
            if (Object.ReferenceEquals(a, b))
            {
                return true;
            }

            if (((object)a == null) || ((object)b == null))
            {
                return false;
            }

            return a.Value == b;
        }

        public static bool operator !=(ItemObject a, Items b)
        {
            return !(a == b);
        }

        public static implicit operator Items(ItemObject i)
        {
            return i.Value;
        }

        public static implicit operator ItemObject(Items i)
        {
            return new ItemObject(i);
        }

        public static ItemObject operator +(ItemObject i, ushort q)
        {
            return new ItemObject(i.Value) { Quantity = Convert.ToUInt16(i.Quantity + q) };
        }

        public static ItemObject operator -(ItemObject i, ushort q)
        {
            return new ItemObject(i.Value) { Quantity = Convert.ToUInt16(i.Quantity - q) };
        }

        public static ItemObject operator ++(ItemObject i)
        {
            return new ItemObject(i.Value) { Quantity = Convert.ToUInt16(i.Quantity + 1) };
        }

        public static ItemObject operator --(ItemObject i)
        {
            return new ItemObject(i.Value) { Quantity = Convert.ToUInt16(i.Quantity - 1) };
        }
    }

    public struct SpeciesObject
    {
        public SpeciesObject(Species species)
            : this()
        {
            Value = species;
        }

        private Species value;

        public Species Value
        {
            get
            {
                return value;
            }
            set
            {
                this.value = Enum.IsDefined(typeof(Species), value)
                    ? (Species)value
                    : Species.NoSpecies;
            }
        }

        public string Name
        {
            get { return value.EnumToString(); }
        }

        public override string ToString()
        {
            return value.EnumToString();
        }

        public override bool Equals(Object obj)
        {
            try
            {
                if (obj == null || obj == DBNull.Value)
                {
                    return false;
                }

                SpeciesObject i = (SpeciesObject)obj;
                if ((Object)i == null)
                {
                    return false;
                }

                return Value == i.Value;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Equals(Species i)
        {
            if ((object)i == null)
            {
                return false;
            }

            return Value == i;
        }

        public override int GetHashCode()
        {
            return (int)value;
        }

        public static bool operator ==(SpeciesObject a, Species b)
        {
            if (Object.ReferenceEquals(a, b))
            {
                return true;
            }

            if (((object)a == null) || ((object)b == null))
            {
                return false;
            }

            return a.Value == b;
        }

        public static bool operator !=(SpeciesObject a, Species b)
        {
            return !(a == b);
        }

        public static implicit operator Species(SpeciesObject i)
        {
            return i.Value;
        }

        public static implicit operator SpeciesObject(Species i)
        {
            return new SpeciesObject(i);
        }
    }

    public struct LocationObject
    {
        public LocationObject(Locations location)
            : this()
        {
            Value = location;
        }

        private Locations value;

        public Locations Value
        {
            get
            {
                return Enum.IsDefined(typeof(Locations), value)
                    ? (Locations)value
                    : Locations.Mystery_Zone;
            }
            set
            {
                this.value = Enum.IsDefined(typeof(Locations), value)
                    ? (Locations)value
                    : Locations.Mystery_Zone;
            }
        }

        public string Name
        {
            get { return value.EnumToString(); }
        }

        public override string ToString()
        {
            return value.EnumToString();
        }

        public override bool Equals(Object obj)
        {
            try
            {
                if (obj == null || obj == DBNull.Value)
                {
                    return false;
                }

                LocationObject i = (LocationObject)obj;
                if ((Object)i == null)
                {
                    return false;
                }

                return Value == i.Value;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Equals(Locations i)
        {
            if ((object)i == null)
            {
                return false;
            }

            return Value == i;
        }

        public override int GetHashCode()
        {
            return (int)value;
        }

        public static bool operator ==(LocationObject a, Locations b)
        {
            if (Object.ReferenceEquals(a, b))
            {
                return true;
            }

            if (((object)a == null) || ((object)b == null))
            {
                return false;
            }

            return a.Value == b;
        }

        public static bool operator !=(LocationObject a, Locations b)
        {
            return !(a == b);
        }

        public static implicit operator Locations(LocationObject i)
        {
            return i.Value;
        }

        public static implicit operator LocationObject(Locations i)
        {
            return new LocationObject(i);
        }
    }

    public struct MovesObject
    {
        public MovesObject(Moves move)
            : this()
        {
            Value = move;
        }

        private Moves value;

        [DisplayName("Move")]
        public Moves Value
        {
            get
            {
                return value;
            }
            set
            {
                this.value = Enum.IsDefined(typeof(Moves), value)
                    ? (Moves)value
                    : Moves.NoMove;
            }
        }

        [DisplayName("Name")]
        public string Name
        {
            get { return value.EnumToString(); }
        }

        [DisplayName("Type")]
        public TypeObject? Type
        {
            get
            {
                int typeid = 0;
                var typequery = DBTools.GetMoveDataTable.Select(string.Format("id = {0}", (int)value));
                if (typequery.Length == 0) return null;
                string typeidstr = typequery[0].ItemArray[(int)DBTools.MoveDataTableColumns.type_id].ToString();
                if (!int.TryParse(typeidstr, out typeid)) return new TypeObject();
                if (!Enum.IsDefined(typeof(Types), typeid)) return new TypeObject();
                return new TypeObject((Types)typeid);
            }
        }

        [DisplayName("Type")]
        public Image TypeImage
        {
            get
            {
                if (!Type.HasValue) return null;
                return Type.Value.Image;
            }
        }

        [DisplayName("Category")]
        public Image CategoryImage
        {
            get
            {
                var damageclassquery = DBTools.GetMoveDataTable.Select(string.Format("id = {0}", (int)value));
                if (damageclassquery.Length == 0) return null;
                var damageclassidstr = damageclassquery[0].ItemArray[(int)DBTools.MoveDataTableColumns.damage_class_id].ToString();
                int damageclassid = -1;
                int.TryParse(damageclassidstr, out damageclassid);
                switch (damageclassid)
                {
                    case 1:
                        return Images.GetImageFromResource("physical");

                    case 2:
                        return Images.GetImageFromResource("special");

                    case 0:
                        return Images.GetImageFromResource("other");

                    default:
                        return null;
                }
            }
        }

        [DisplayName("Power")]
        public int Power
        {
            get
            {
                int power = 0;
                var powerquery = DBTools.GetMoveDataTable.Select(string.Format("id = {0}", (int)value));
                if (powerquery.Length != 0)
                {
                    string powerstr = powerquery[0].ItemArray[(int)DBTools.MoveDataTableColumns.power].ToString();
                    int.TryParse(powerstr, out power);
                }
                return power;
            }
        }

        [DisplayName("Accuracy")]
        public decimal Accuracy
        {
            get
            {
                decimal accuracy = 0M;
                var accuracyquery = DBTools.GetMoveDataTable.Select(string.Format("id = {0}", (int)value));
                if (accuracyquery.Length != 0)
                {
                    string accuracystr = accuracyquery[0].ItemArray[(int)DBTools.MoveDataTableColumns.accuracy].ToString();
                    decimal.TryParse(accuracystr, out accuracy);
                }
                return accuracy;
            }
        }

        [DisplayName("Base PP")]
        public byte BasePP
        {
            get
            {
                byte basepp = 0;
                var baseppquery = DBTools.GetMoveDataTable.Select(string.Format("id = {0}", (int)value));
                if (baseppquery.Length != 0)
                {
                    string baseppstr = baseppquery[0].ItemArray[(int)DBTools.MoveDataTableColumns.pp].ToString();
                    byte.TryParse(baseppstr, out basepp);
                }
                return basepp;
            }
        }

        [DisplayName("Current PP")]
        public byte CurrentPP { get; set; }

        [DisplayName("PP Ups")]
        public byte PPUps { get; set; }

        [DisplayName("Max PP")]
        public byte MaxPP
        {
            get
            {
                return (byte)(BasePP + (BasePP * 0.2 * PPUps));
            }
        }

        [DisplayName("Flavor Text")]
        public string FlavorText
        {
            get
            {
                var flavor = DBTools.GetMoveDataTable.Select(string.Format("id = {0}", (int)value));
                if (flavor.Length != 0)
                {
                    return flavor[0].ItemArray[(int)DBTools.MoveDataTableColumns.flavor_text].ToString();
                }
                else
                {
                    return string.Empty;
                }
            }
        }

        public override string ToString()
        {
            return value.EnumToString();
        }

        public override bool Equals(Object obj)
        {
            try
            {
                if (obj == null || obj == DBNull.Value)
                {
                    return false;
                }

                MovesObject i = (MovesObject)obj;
                if ((Object)i == null)
                {
                    return false;
                }

                return Value == i.Value;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Equals(Moves i)
        {
            if ((object)i == null)
            {
                return false;
            }

            return Value == i;
        }

        public override int GetHashCode()
        {
            return (int)value;
        }

        public static bool operator ==(MovesObject a, Moves b)
        {
            if (Object.ReferenceEquals(a, b))
            {
                return true;
            }

            if (((object)a == null) || ((object)b == null))
            {
                return false;
            }

            return a.Value == b;
        }

        public static bool operator !=(MovesObject a, Moves b)
        {
            return !(a == b);
        }

        public static implicit operator Moves(MovesObject i)
        {
            return i.Value;
        }

        public static implicit operator MovesObject(Moves i)
        {
            return new MovesObject(i);
        }
    }

    public struct AbilityObject
    {
        public AbilityObject(Abilities abilities)
            : this()
        {
            Value = abilities;
        }

        private Abilities value;

        public Abilities Value
        {
            get
            {
                return value;
            }
            set
            {
                this.value = Enum.IsDefined(typeof(Abilities), value)
                    ? (Abilities)value
                    : Abilities.NoAbility;
            }
        }

        public string Name
        {
            get { return value.EnumToString(); }
        }

        public override string ToString()
        {
            return value.EnumToString();
        }

        public override bool Equals(Object obj)
        {
            try
            {
                if (obj == null || obj == DBNull.Value)
                {
                    return false;
                }

                AbilityObject i = (AbilityObject)obj;
                if ((Object)i == null)
                {
                    return false;
                }

                return Value == i.Value;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Equals(Abilities i)
        {
            if ((object)i == null)
            {
                return false;
            }

            return Value == i;
        }

        public override int GetHashCode()
        {
            return (int)value;
        }

        public static bool operator ==(AbilityObject a, Abilities b)
        {
            if (Object.ReferenceEquals(a, b))
            {
                return true;
            }

            if (((object)a == null) || ((object)b == null))
            {
                return false;
            }

            return a.Value == b;
        }

        public static bool operator !=(AbilityObject a, Abilities b)
        {
            return !(a == b);
        }

        public static implicit operator Abilities(AbilityObject i)
        {
            return i.Value;
        }

        public static implicit operator AbilityObject(Abilities i)
        {
            return new AbilityObject(i);
        }
    }

    public struct NatureObject
    {
        public NatureObject(Natures nature)
            : this()
        {
            Value = nature;
        }

        private Natures value;

        public Natures Value
        {
            get
            {
                return value;
            }
            set
            {
                this.value = Enum.IsDefined(typeof(Natures), value)
                    ? (Natures)value
                    : Natures.Hardy;
            }
        }

        public string Name
        {
            get { return value.EnumToString(); }
        }

        public override string ToString()
        {
            return value.EnumToString();
        }

        public override bool Equals(Object obj)
        {
            try
            {
                if (obj == null || obj == DBNull.Value)
                {
                    return false;
                }

                NatureObject i = (NatureObject)obj;
                if ((Object)i == null)
                {
                    return false;
                }

                return Value == i.Value;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Equals(Natures i)
        {
            if ((object)i == null)
            {
                return false;
            }

            return Value == i;
        }

        public override int GetHashCode()
        {
            return (int)value;
        }

        public static bool operator ==(NatureObject a, Natures b)
        {
            if (Object.ReferenceEquals(a, b))
            {
                return true;
            }

            if (((object)a == null) || ((object)b == null))
            {
                return false;
            }

            return a.Value == b;
        }

        public static bool operator !=(NatureObject a, Natures b)
        {
            return !(a == b);
        }

        public static implicit operator Natures(NatureObject i)
        {
            return i.Value;
        }

        public static implicit operator NatureObject(Natures i)
        {
            return new NatureObject(i);
        }
    }

    public struct TypeObject
    {
        public TypeObject(Types Type)
        {
            this.value = Enum.IsDefined(typeof(Types), Type)
                ? (Types)Type
                : Types.Normal;
        }

        private Types value;

        public Types Value
        {
            get
            {
                return value;
            }
            set
            {
                this.value = Enum.IsDefined(typeof(Types), value)
                    ? (Types)value
                    : Types.Normal;
            }
        }

        public string Name
        {
            get { return value.EnumToString(); }
        }

        public Image Image
        {
            get
            {
                return Images.GetTypeImage(Value);
            }
        }

        public override string ToString()
        {
            return value.EnumToString();
        }

        public override bool Equals(Object obj)
        {
            try
            {
                if (obj == null || obj == DBNull.Value)
                {
                    return false;
                }

                TypeObject i = (TypeObject)obj;
                if ((Object)i == null)
                {
                    return false;
                }

                return Value == i.Value;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Equals(Types i)
        {
            if ((object)i == null)
            {
                return false;
            }

            return Value == i;
        }

        public override int GetHashCode()
        {
            return (int)value;
        }

        public static bool operator ==(TypeObject a, Types b)
        {
            if (Object.ReferenceEquals(a, b))
            {
                return true;
            }

            if (((object)a == null) || ((object)b == null))
            {
                return false;
            }

            return a.Value == b;
        }

        public static bool operator !=(TypeObject a, Types b)
        {
            return !(a == b);
        }

        public static implicit operator Types(TypeObject i)
        {
            return i.Value;
        }

        public static implicit operator TypeObject(Types i)
        {
            return new TypeObject(i);
        }
    }

    public static class Lists
    {
        private static List<MovesObject> _moveList = new List<MovesObject>();
        private static List<SpeciesObject> _speciesList = new List<SpeciesObject>();
        private static List<ItemObject> _itemList = new List<ItemObject>();
        private static List<AbilityObject> _abilityList = new List<AbilityObject>();
        private static List<LocationObject> _locationList = new List<LocationObject>();
        private static List<NatureObject> _natureList = new List<NatureObject>();
        private static List<TypeObject> _typeList = new List<TypeObject>();

        public static List<MovesObject> MoveList
        {
            get
            {
                if (!_moveList.Any())
                    foreach (var move in Enum.GetValues(typeof(Moves)).Cast<Moves>().ToArray<Moves>())
                    {
                        _moveList.Add(new MovesObject(move));
                    }
                return _moveList;
            }
        }

        public static List<SpeciesObject> SpeciesList
        {
            get
            {
                if (!_speciesList.Any())
                    foreach (var species in Enum.GetValues(typeof(Species)).Cast<Species>().Where(s => s != Species.NoSpecies).ToArray<Species>())
                    {
                        _speciesList.Add(new SpeciesObject(species));
                    }
                return _speciesList;
            }
        }

        public static List<ItemObject> ItemList
        {
            get
            {
                if (!_itemList.Any())
                    foreach (var item in Enum.GetValues(typeof(Items)).Cast<Items>().ToArray<Items>())
                    {
                        _itemList.Add(new ItemObject(item));
                    }
                return _itemList;
            }
        }

        public static List<AbilityObject> AbilityList
        {
            get
            {
                if (!_abilityList.Any())
                    foreach (var ability in Enum.GetValues(typeof(Abilities)).Cast<Abilities>().ToArray<Abilities>())
                    {
                        _abilityList.Add(new AbilityObject(ability));
                    }
                return _abilityList;
            }
        }

        public static List<LocationObject> LocationList
        {
            get
            {
                if (!_locationList.Any())
                    foreach (var location in Enum.GetValues(typeof(Locations)).Cast<Locations>().ToArray<Locations>())
                    {
                        _locationList.Add(new LocationObject(location));
                    }
                return _locationList;
            }
        }

        public static List<NatureObject> NatureList
        {
            get
            {
                if (!_natureList.Any())
                    foreach (var nature in Enum.GetValues(typeof(Natures)).Cast<Natures>().ToArray<Natures>())
                    {
                        _natureList.Add(new NatureObject(nature));
                    }
                return _natureList;
            }
        }

        public static List<TypeObject> TypeList
        {
            get
            {
                if (!_typeList.Any())
                    foreach (var type in Enum.GetValues(typeof(Types)).Cast<Types>().ToArray<Types>())
                    {
                        _typeList.Add(new TypeObject(type));
                    }
                return _typeList;
            }
        }
    }
}