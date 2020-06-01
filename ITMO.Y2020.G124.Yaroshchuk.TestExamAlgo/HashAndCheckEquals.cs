using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITMO.Y2020.G124.Yaroshchuk.TestExamAlgo
{
    public class HashAndCheckEquals
    {
        const int alpha = 31;
        int cycleCount = 1;
        public string finalMessage;
        List<long> pewpews = new List<long>(10000);
        SortedDictionary<int, long> hashes = new SortedDictionary<int, long>();

        public long HashHash(string needHash)
        {
            long whatLen = needHash.Length;
            long hash = 0;
            for (int j = 0; j < whatLen; ++j)
            {
                hash += ((long)needHash[j] - (long)'a' + 1) * (long)pewpews[j];
            }
            return hash;
        }

        public HashAndCheckEquals(List <string> stringsToCheck)
        {
            pewpews.Add(1);

            for (int i = 1; i < 1000; i++)
            {
                long impera = 0;
                impera = (pewpews[i - 1] * alpha);
                pewpews.Add(impera);
            }

            foreach(string strings in stringsToCheck)
            {
                long realHash = 0;
                realHash = HashHash(strings);
                hashes.Add(cycleCount, realHash);
                cycleCount++;
            }

            var stringEq = hashes.ToLookup(x => x.Value, x => x.Key).Where(x => x.Count() > 1);
            //foreach (var item in stringEq)
            Parallel.ForEach(stringEq, item =>
            {
                var keys = item.Aggregate("", (s, v) => s + " " + v);
                var message = keys;
                finalMessage += "\r" + "These strings are equal: " + message.ToString();
            });
            hashes.Clear();
        }
    }
}
