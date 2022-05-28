﻿using System.Collections.Generic;

namespace Unity.MARS.Tests
{
    static class MetaEnumeratorTestData
    {
        public static Dictionary<int, int>[] Source =
        {
            /*
             each key-value pair is setup such that
             1) the key is the index of the pair in the dictionary's enumerator
             2) the value is the index + 1 of the dictionary into the array
            */
            new Dictionary<int, int>{ {0, 1}, {1, 1}, {2, 1}, {3, 1}, {4, 1}, {5, 1} },
            new Dictionary<int, int>{ {0, 2}, {1, 2}, {2, 2}, {3, 2}, {4, 2}, {5, 2} },
            new Dictionary<int, int>{ {0, 3}, {1, 3}, {2, 3}, {3, 3}, {4, 3}, {5, 3} },
            new Dictionary<int, int>{ {0, 4}, {1, 4}, {2, 4}, {3, 4}, {4, 4}, {5, 4} },
            new Dictionary<int, int>{ {0, 5}, {1, 5}, {2, 5}, {3, 5}, {4, 5}, {5, 5} },
        };

        public static int[][] ExpectedAnswerKeys =
        {
            new [] { 0, 0, 0, 0, 0 },
            new [] { 0, 0, 0, 0, 1 },
            new [] { 0, 0, 0, 0, 2 },
            new [] { 0, 0, 0, 1, 0 },
            new [] { 0, 0, 0, 1, 1 },
            new [] { 0, 0, 0, 1, 2 },
            new [] { 0, 0, 0, 2, 0 },
            new [] { 0, 0, 0, 2, 1 },
            new [] { 0, 0, 0, 2, 2 },
            new [] { 0, 0, 1, 0, 0 },
            new [] { 0, 0, 1, 0, 1 },
            new [] { 0, 0, 1, 0, 2 },
            new [] { 0, 0, 1, 1, 0 },
            new [] { 0, 0, 1, 1, 1 },
            new [] { 0, 0, 1, 1, 2 },
            new [] { 0, 0, 1, 2, 0 },
            new [] { 0, 0, 1, 2, 1 },
            new [] { 0, 0, 1, 2, 2 },
            new [] { 0, 0, 2, 0, 0 },
            new [] { 0, 0, 2, 0, 1 },
            new [] { 0, 0, 2, 0, 2 },
            new [] { 0, 0, 2, 1, 0 },
            new [] { 0, 0, 2, 1, 1 },
            new [] { 0, 0, 2, 1, 2 },
            new [] { 0, 0, 2, 2, 0 },
            new [] { 0, 0, 2, 2, 1 },
            new [] { 0, 0, 2, 2, 2 },
            new [] { 0, 1, 0, 0, 0 },
            new [] { 0, 1, 0, 0, 1 },
            new [] { 0, 1, 0, 0, 2 },
            new [] { 0, 1, 0, 1, 0 },
            new [] { 0, 1, 0, 1, 1 },
            new [] { 0, 1, 0, 1, 2 },
            new [] { 0, 1, 0, 2, 0 },
            new [] { 0, 1, 0, 2, 1 },
            new [] { 0, 1, 0, 2, 2 },
            new [] { 0, 1, 1, 0, 0 },
            new [] { 0, 1, 1, 0, 1 },
            new [] { 0, 1, 1, 0, 2 },
            new [] { 0, 1, 1, 1, 0 },
            new [] { 0, 1, 1, 1, 1 },
            new [] { 0, 1, 1, 1, 2 },
            new [] { 0, 1, 1, 2, 0 },
            new [] { 0, 1, 1, 2, 1 },
            new [] { 0, 1, 1, 2, 2 },
            new [] { 0, 1, 2, 0, 0 },
            new [] { 0, 1, 2, 0, 1 },
            new [] { 0, 1, 2, 0, 2 },
            new [] { 0, 1, 2, 1, 0 },
            new [] { 0, 1, 2, 1, 1 },
            new [] { 0, 1, 2, 1, 2 },
            new [] { 0, 1, 2, 2, 0 },
            new [] { 0, 1, 2, 2, 1 },
            new [] { 0, 1, 2, 2, 2 },
            new [] { 0, 2, 0, 0, 0 },
            new [] { 0, 2, 0, 0, 1 },
            new [] { 0, 2, 0, 0, 2 },
            new [] { 0, 2, 0, 1, 0 },
            new [] { 0, 2, 0, 1, 1 },
            new [] { 0, 2, 0, 1, 2 },
            new [] { 0, 2, 0, 2, 0 },
            new [] { 0, 2, 0, 2, 1 },
            new [] { 0, 2, 0, 2, 2 },
            new [] { 0, 2, 1, 0, 0 },
            new [] { 0, 2, 1, 0, 1 },
            new [] { 0, 2, 1, 0, 2 },
            new [] { 0, 2, 1, 1, 0 },
            new [] { 0, 2, 1, 1, 1 },
            new [] { 0, 2, 1, 1, 2 },
            new [] { 0, 2, 1, 2, 0 },
            new [] { 0, 2, 1, 2, 1 },
            new [] { 0, 2, 1, 2, 2 },
            new [] { 0, 2, 2, 0, 0 },
            new [] { 0, 2, 2, 0, 1 },
            new [] { 0, 2, 2, 0, 2 },
            new [] { 0, 2, 2, 1, 0 },
            new [] { 0, 2, 2, 1, 1 },
            new [] { 0, 2, 2, 1, 2 },
            new [] { 0, 2, 2, 2, 0 },
            new [] { 0, 2, 2, 2, 1 },
            new [] { 0, 2, 2, 2, 2 },
            // iterate index 0
            new [] { 1, 0, 0, 0, 0 },
            new [] { 1, 0, 0, 0, 1 },
            new [] { 1, 0, 0, 0, 2 },
            new [] { 1, 0, 0, 1, 0 },
            new [] { 1, 0, 0, 1, 1 },
            new [] { 1, 0, 0, 1, 2 },
            new [] { 1, 0, 0, 2, 0 },
            new [] { 1, 0, 0, 2, 1 },
            new [] { 1, 0, 0, 2, 2 },
            new [] { 1, 0, 1, 0, 0 },
            new [] { 1, 0, 1, 0, 1 },
            new [] { 1, 0, 1, 0, 2 },
            new [] { 1, 0, 1, 1, 0 },
            new [] { 1, 0, 1, 1, 1 },
            new [] { 1, 0, 1, 1, 2 },
            new [] { 1, 0, 1, 2, 0 },
            new [] { 1, 0, 1, 2, 1 },
            new [] { 1, 0, 1, 2, 2 },
            new [] { 1, 0, 2, 0, 0 },
            new [] { 1, 0, 2, 0, 1 },
            new [] { 1, 0, 2, 0, 2 },
            new [] { 1, 0, 2, 1, 0 },
            new [] { 1, 0, 2, 1, 1 },
            new [] { 1, 0, 2, 1, 2 },
            new [] { 1, 0, 2, 2, 0 },
            new [] { 1, 0, 2, 2, 1 },
            new [] { 1, 0, 2, 2, 2 },
            new [] { 1, 1, 0, 0, 0 },
            new [] { 1, 1, 0, 0, 1 },
            new [] { 1, 1, 0, 0, 2 },
            new [] { 1, 1, 0, 1, 0 },
            new [] { 1, 1, 0, 1, 1 },
            new [] { 1, 1, 0, 1, 2 },
            new [] { 1, 1, 0, 2, 0 },
            new [] { 1, 1, 0, 2, 1 },
            new [] { 1, 1, 0, 2, 2 },
            new [] { 1, 1, 1, 0, 0 },
            new [] { 1, 1, 1, 0, 1 },
            new [] { 1, 1, 1, 0, 2 },
            new [] { 1, 1, 1, 1, 0 },
            new [] { 1, 1, 1, 1, 1 },
            new [] { 1, 1, 1, 1, 2 },
            new [] { 1, 1, 1, 2, 0 },
            new [] { 1, 1, 1, 2, 1 },
            new [] { 1, 1, 1, 2, 2 },
            new [] { 1, 1, 2, 0, 0 },
            new [] { 1, 1, 2, 0, 1 },
            new [] { 1, 1, 2, 0, 2 },
            new [] { 1, 1, 2, 1, 0 },
            new [] { 1, 1, 2, 1, 1 },
            new [] { 1, 1, 2, 1, 2 },
            new [] { 1, 1, 2, 2, 0 },
            new [] { 1, 1, 2, 2, 1 },
            new [] { 1, 1, 2, 2, 2 },
            new [] { 1, 2, 0, 0, 0 },
            new [] { 1, 2, 0, 0, 1 },
            new [] { 1, 2, 0, 0, 2 },
            new [] { 1, 2, 0, 1, 0 },
            new [] { 1, 2, 0, 1, 1 },
            new [] { 1, 2, 0, 1, 2 },
            new [] { 1, 2, 0, 2, 0 },
            new [] { 1, 2, 0, 2, 1 },
            new [] { 1, 2, 0, 2, 2 },
            new [] { 1, 2, 1, 0, 0 },
            new [] { 1, 2, 1, 0, 1 },
            new [] { 1, 2, 1, 0, 2 },
            new [] { 1, 2, 1, 1, 0 },
            new [] { 1, 2, 1, 1, 1 },
            new [] { 1, 2, 1, 1, 2 },
            new [] { 1, 2, 1, 2, 0 },
            new [] { 1, 2, 1, 2, 1 },
            new [] { 1, 2, 1, 2, 2 },
            new [] { 1, 2, 2, 0, 0 },
            new [] { 1, 2, 2, 0, 1 },
            new [] { 1, 2, 2, 0, 2 },
            new [] { 1, 2, 2, 1, 0 },
            new [] { 1, 2, 2, 1, 1 },
            new [] { 1, 2, 2, 1, 2 },
            new [] { 1, 2, 2, 2, 0 },
            new [] { 1, 2, 2, 2, 1 },
            new [] { 1, 2, 2, 2, 2 },
            // iterate index 0 again
            new [] { 2, 0, 0, 0, 0 },
            new [] { 2, 0, 0, 0, 1 },
            new [] { 2, 0, 0, 0, 2 },
            new [] { 2, 0, 0, 1, 0 },
            new [] { 2, 0, 0, 1, 1 },
            new [] { 2, 0, 0, 1, 2 },
            new [] { 2, 0, 0, 2, 0 },
            new [] { 2, 0, 0, 2, 1 },
            new [] { 2, 0, 0, 2, 2 },
            new [] { 2, 0, 1, 0, 0 },
            new [] { 2, 0, 1, 0, 1 },
            new [] { 2, 0, 1, 0, 2 },
            new [] { 2, 0, 1, 1, 0 },
            new [] { 2, 0, 1, 1, 1 },
            new [] { 2, 0, 1, 1, 2 },
            new [] { 2, 0, 1, 2, 0 },
            new [] { 2, 0, 1, 2, 1 },
            new [] { 2, 0, 1, 2, 2 },
            new [] { 2, 0, 2, 0, 0 },
            new [] { 2, 0, 2, 0, 1 },
            new [] { 2, 0, 2, 0, 2 },
            new [] { 2, 0, 2, 1, 0 },
            new [] { 2, 0, 2, 1, 1 },
            new [] { 2, 0, 2, 1, 2 },
            new [] { 2, 0, 2, 2, 0 },
            new [] { 2, 0, 2, 2, 1 },
            new [] { 2, 0, 2, 2, 2 },
            new [] { 2, 1, 0, 0, 0 },
            new [] { 2, 1, 0, 0, 1 },
            new [] { 2, 1, 0, 0, 2 },
            new [] { 2, 1, 0, 1, 0 },
            new [] { 2, 1, 0, 1, 1 },
            new [] { 2, 1, 0, 1, 2 },
            new [] { 2, 1, 0, 2, 0 },
            new [] { 2, 1, 0, 2, 1 },
            new [] { 2, 1, 0, 2, 2 },
            new [] { 2, 1, 1, 0, 0 },
            new [] { 2, 1, 1, 0, 1 },
            new [] { 2, 1, 1, 0, 2 },
            new [] { 2, 1, 1, 1, 0 },
            new [] { 2, 1, 1, 1, 1 },
            new [] { 2, 1, 1, 1, 2 },
            new [] { 2, 1, 1, 2, 0 },
            new [] { 2, 1, 1, 2, 1 },
            new [] { 2, 1, 1, 2, 2 },
            new [] { 2, 1, 2, 0, 0 },
            new [] { 2, 1, 2, 0, 1 },
            new [] { 2, 1, 2, 0, 2 },
            new [] { 2, 1, 2, 1, 0 },
            new [] { 2, 1, 2, 1, 1 },
            new [] { 2, 1, 2, 1, 2 },
            new [] { 2, 1, 2, 2, 0 },
            new [] { 2, 1, 2, 2, 1 },
            new [] { 2, 1, 2, 2, 2 },
            new [] { 2, 2, 0, 0, 0 },
            new [] { 2, 2, 0, 0, 1 },
            new [] { 2, 2, 0, 0, 2 },
            new [] { 2, 2, 0, 1, 0 },
            new [] { 2, 2, 0, 1, 1 },
            new [] { 2, 2, 0, 1, 2 },
            new [] { 2, 2, 0, 2, 0 },
            new [] { 2, 2, 0, 2, 1 },
            new [] { 2, 2, 0, 2, 2 },
            new [] { 2, 2, 1, 0, 0 },
            new [] { 2, 2, 1, 0, 1 },
            new [] { 2, 2, 1, 0, 2 },
            new [] { 2, 2, 1, 1, 0 },
            new [] { 2, 2, 1, 1, 1 },
            new [] { 2, 2, 1, 1, 2 },
            new [] { 2, 2, 1, 2, 0 },
            new [] { 2, 2, 1, 2, 1 },
            new [] { 2, 2, 1, 2, 2 },
            new [] { 2, 2, 2, 0, 0 },
            new [] { 2, 2, 2, 0, 1 },
            new [] { 2, 2, 2, 0, 2 },
            new [] { 2, 2, 2, 1, 0 },
            new [] { 2, 2, 2, 1, 1 },
            new [] { 2, 2, 2, 1, 2 },
            new [] { 2, 2, 2, 2, 0 },
            new [] { 2, 2, 2, 2, 1 },
            new [] { 2, 2, 2, 2, 2 }
            // no remainder for this test case
        };
    }
}
