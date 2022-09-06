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

            var units = map.MapList(unitsComparables);

            foreach (var unit in units)
            {
                Console.WriteLine(unit.Name);
                Console.WriteLine(Environment.NewLine);
            }
        }

        static List<IComparable<IUnit>> InitializeComparables()
        {
            return new List<IComparable<IUnit>>()
            {
                new Comparable<IUnit> { Unit = fixture.Create<LegacyUnit>() },
                new Comparable<IUnit> { Unit = fixture.Create<LegacyUnit>() },
                new Comparable<IUnit> { Unit = fixture.Create<LegacyUnit>() },
                new Comparable<IUnit> { Unit = fixture.Create<SaleUnit>() },
                new Comparable<IUnit> { Unit = fixture.Create<SaleUnit>() },
                new NonComparable<IUnit> { Unit = fixture.Create<LegacyUnit>() },
                new NonComparable<IUnit> { Unit = fixture.Create<LegacyUnit>() },
                new NonComparable<IUnit> { Unit = fixture.Create<LegacyUnit>() },
                new NonComparable<IUnit> { Unit = fixture.Create<SaleUnit>() },
                new NonComparable<IUnit> { Unit = fixture.Create<SaleUnit>() },
            };
        }
    }
}
