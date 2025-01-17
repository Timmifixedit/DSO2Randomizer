﻿using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.IO;
using System.Linq;
using System.Text;
using Microsoft.VisualBasic.CompilerServices;
using Newtonsoft.Json;

namespace DOS2Randomizer.DataStructures {

    public interface IConstSpell {
        public string Name { get; }
        public string ImagePath { get; }
        public int Level { get; }

        [JsonIgnore]
        public ImmutableArray<IConstSpell> CDependencies { get; }
        public ImmutableDictionary<Spell.School, int> SchoolRequirements { get; }
        public Player.SkillType EquipmentRequirement { get; }
        public ImmutableArray<Spell.Type> Types { get; }
        public Attribute Scaling { get; }
        public int MemorySlots { get; }
        public int LoadoutCost { get; }
        public Spell.School Benefit { get; }
    }

    /// <summary>
    /// Spell class
    /// </summary>
    public class Spell : IEquatable<Spell>, IConstSpell {

        /// <summary>
        /// Spell school type
        /// </summary>
        public enum School {
            Aero,
            Geo,
            Huntsman,
            Hydro,
            Necro,
            Poly,
            Pyro,
            Scoundrel,
            Summoning,
            Warfare,
            None
        }

        /// <summary>
        /// Spell type
        /// </summary>
        public enum Type {
            Util,
            Dmg,
            Cc,
            Heal,
            BuffDebuff
        }

        /// <summary>
        /// Creates a spell with a name and an image. All other members are default initialized
        /// </summary>
        /// <param name="name"></param>
        /// <param name="imagePath"></param>
        public Spell(string name, string imagePath) {
            Name = name;
            ImagePath = imagePath;
            Level = 1;
            Dependencies = ImmutableArray<Spell>.Empty;
            SchoolRequirements = new Dictionary<School, int>(
                    ((School[])Enum.GetValues(typeof(School))).Select(
                        school => new KeyValuePair<School, int>(school, 0)))
                .ToImmutableDictionary();
            Types = ImmutableArray<Type>.Empty;
            Scaling = Attribute.None;
            MemorySlots = 1;
            LoadoutCost = 0;
            EquipmentRequirement = Player.SkillType.None;
            Benefit = School.None;
        }

        [JsonConstructor]
        public Spell(string name, string imagePath, int level, ImmutableArray<Spell> dependencies,
            ImmutableDictionary<School, int> schoolRequirements, Player.SkillType equipmentRequirement,
            ImmutableArray<Type> types, Attribute scaling, int memorySlots, int loadoutCost, School benefit) {
            Name = name;
            ImagePath = imagePath;
            Level = level;
            Dependencies = dependencies;
            SchoolRequirements = schoolRequirements;
            Types = types;
            Scaling = scaling;
            MemorySlots = memorySlots;
            LoadoutCost = loadoutCost;
            EquipmentRequirement = equipmentRequirement;
            Benefit = benefit;
        }

        public string Name { get; set; }
        public string ImagePath { get; set; }
        public int Level { get; set; }
        public ImmutableArray<Spell> Dependencies { get; set; }
        public ImmutableArray<IConstSpell> CDependencies => Dependencies.CastArray<IConstSpell>();
        public ImmutableDictionary<School, int> SchoolRequirements { get; set; }
        public Player.SkillType EquipmentRequirement { get; set; }
        public ImmutableArray<Type> Types { get; set; }
        public Attribute Scaling { get; set; }
        public int MemorySlots { get; set; }
        public int LoadoutCost { get; set; }
        public School Benefit { get; set; }

        /// <summary>
        /// Compares Spell member fields
        /// </summary>
        /// <param name="other"></param>
        /// <returns></returns>
        public bool Equals(Spell? other) {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return Name == other.Name && ImagePath == other.ImagePath && Level == other.Level &&
                   SequenceEqual(Types, other.Types) && Scaling == other.Scaling &&
                   MemorySlots == other.MemorySlots && LoadoutCost == other.LoadoutCost && Benefit == other.Benefit;
        }
        private static bool SequenceEqual<T>(IEnumerable<T>? lhs, IEnumerable<T>? rhs) {
            if (ReferenceEquals(lhs, rhs)) {
                return true;
            }

            if (rhs is null || lhs is null) {
                return false;
            }

            return lhs.SequenceEqual(rhs);
        }

        public override bool Equals(object? obj) {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((Spell) obj);
        }

        public override int GetHashCode() {
            return HashCode.Combine(Name, ImagePath, Level, (int) Scaling, MemorySlots, LoadoutCost, Benefit);
        }

        public static bool operator ==(Spell? left, Spell? right) {
            return Equals(left, right);
        }

        public static bool operator !=(Spell? left, Spell? right) {
            return !Equals(left, right);
        }

        public override string ToString() {
            return Name;
        }
    }
}
