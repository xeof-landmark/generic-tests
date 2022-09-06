using AutoFixture;
using System.Collections.Generic;

namespace GenericsTest
{
    public class Map
    {
        static Fixture fixture = new Fixture();

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
