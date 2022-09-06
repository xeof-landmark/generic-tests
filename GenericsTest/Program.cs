using AutoFixture;
using System;
using System.Collections.Generic;

namespace GenericsTest
{
    class Program
    {
        static Fixture fixture = new Fixture();
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var map = new Map();

            var unitsComparables = InitializeComparables();
            var unitsNonComparables = InitializeNonComparables();


            var unitsMappedCompared = map.MapList(unitsComparables);
            var unitsMappedNonCompared = map.MapList(unitsNonComparables);

            var units = new List<IUnit>();
            units.AddRange(unitsMappedCompared);
            units.AddRange(unitsMappedNonCompared);

            foreach (var unit in units)
            {
                Console.WriteLine(unit.Name);
                Console.WriteLine(Environment.NewLine);
            }
        }

        static List<Comparable<IUnit>> InitializeComparables()
        {
            return new List<Comparable<IUnit>>()
            {
                new Comparable<IUnit> { Unit = fixture.Create<LegacyUnit>() },
                new Comparable<IUnit> { Unit = fixture.Create<LegacyUnit>() },
                new Comparable<IUnit> { Unit = fixture.Create<LegacyUnit>() },
                new Comparable<IUnit> { Unit = fixture.Create<SaleUnit>() },
                new Comparable<IUnit> { Unit = fixture.Create<SaleUnit>() },
            };
        }

        static List<NonComparable<IUnit>> InitializeNonComparables()
        {
            return new List<NonComparable<IUnit>>()
            {
                new NonComparable<IUnit> { Unit = fixture.Create<LegacyUnit>() },
                new NonComparable<IUnit> { Unit = fixture.Create<LegacyUnit>() },
                new NonComparable<IUnit> { Unit = fixture.Create<LegacyUnit>() },
                new NonComparable<IUnit> { Unit = fixture.Create<SaleUnit>() },
                new NonComparable<IUnit> { Unit = fixture.Create<SaleUnit>() },
            };
        }
    }
}
