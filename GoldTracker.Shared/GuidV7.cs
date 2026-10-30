using System;
using UUIDNext;

namespace GoldTracker.Shared
{
    public static class GuidV7
    {
        public static Guid NewGuid() => Uuid.NewDatabaseFriendly(Database.PostgreSql);
    }
}
