using System.Collections.Generic;

namespace Kiosk
{
    public static class QueueStore
    {
        public static List<Order> Orders =
            new List<Order>();

        public static int NextOrderNumber = 1;
    }
}