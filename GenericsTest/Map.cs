using AutoFixture;
using System.Collections.Generic;
using System.Linq;

namespace GenericsTest
{
    public class Map
    {
        static Fixture fixture = new Fixture();

        public List<IUnit> MapList(List<IComparable<IUnit>> unitsComparables)
        {
            var mapUnitComparables = unitsComparables.Where(x => x is Comparable<IUnit>).Select(s => (Comparable<IUnit>)s).ToList();
            var mapUnitNonComparables = unitsComparables.Where(x => x is NonComparable<IUnit>).Select(s => (NonComparable<IUnit>)s).ToList();
            var result = new List<IUnit>();

            result.AddRange(MapList(mapUnitComparables));
            result.AddRange(MapList(mapUnitNonComparables));

            return result;
        }

        public List<IUnit> MapList(List<Comparable<IUnit>> compareOnes)
        {
            return new List<IUnit>()
            {
                fixture.Create<LegacyUnit>(),
                fixture.Create<LegacyUnit>(),
                fixture.Create<LegacyUnit>(),
                fixture.Create<SaleUnit>(),
                fixture.Create<SaleUnit>(),
            };
        }

        public List<IUnit> MapList(List<NonComparable<IUnit>> compareOnes)
        {
            return new List<IUnit>()
            {
                fixture.Create<LegacyUnit>(),
                fixture.Create<LegacyUnit>(),
                fixture.Create<LegacyUnit>(),
                fixture.Create<SaleUnit>(),
                fixture.Create<SaleUnit>(),
            };
        }
    }
}
