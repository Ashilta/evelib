﻿using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace eZet.EveLib.Modules.Models.Resources {
    /// <summary>
    ///     Represents a CREST market history response
    /// </summary>
    [DataContract]
    public sealed class CrestMarketHistory : CrestCollectionResource<CrestMarketHistory> {
        public CrestMarketHistory() {
            Version = "application/vnd.ccp.eve.MarketTypeHistoryCollection-v1+json";
        }

        /// <summary>
        ///     A list of market history entries
        /// </summary>
        [DataMember(Name = "items")]
        public IList<MarketHistoryEntry> Items { get; set; }

        /// <summary>
        ///     Represents an entry (day) in the market history
        /// </summary>
        [DataContract]
        public class MarketHistoryEntry {
            /// <summary>
            ///     The volume of items moved
            /// </summary>
            [DataMember(Name = "volume")]
            public long Volume { get; set; }

            /// <summary>
            ///     The number of orders
            /// </summary>
            [DataMember(Name = "orderCount")]
            public long OrderCount { get; set; }

            /// <summary>
            ///     The lowest price
            /// </summary>
            [DataMember(Name = "lowPrice")]
            public decimal LowPrice { get; set; }

            /// <summary>
            ///     The highst price
            /// </summary>
            [DataMember(Name = "highPrice")]
            public decimal HighPrice { get; set; }

            /// <summary>
            ///     The average price
            /// </summary>
            [DataMember(Name = "avgPrice")]
            public decimal AvgPrice { get; set; }

            /// <summary>
            ///     The date this entry represents
            /// </summary>
            [DataMember(Name = "date")]
            public DateTime Date { get; set; }
        }
    }
}