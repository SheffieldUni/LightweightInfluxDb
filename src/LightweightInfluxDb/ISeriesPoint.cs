using System;
using System.Collections.Generic;

namespace LightweightInfluxDb
{
    public interface ISeriesPoint
    {
	    string Name { get; }
	
	    SortedDictionary<string, string> Tags { get; }
	
	    List<string> Fields { get; }
	
	    List<object> Values { get; }

        DateTime? Timestamp { get; }
    }
}