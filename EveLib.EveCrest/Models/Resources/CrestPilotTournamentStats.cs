﻿// ***********************************************************************
// Assembly         : EveLib.EveCrest
// Author           : Lars Kristian
// Created          : 12-17-2014
//
// Last Modified By : Lars Kristian
// Last Modified On : 12-17-2014
// ***********************************************************************
// <copyright file="CrestPilotTournamentStats.cs" company="">
//     Copyright (c) . All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using eZet.EveLib.Modules.Models.Entities;
using eZet.EveLib.Modules.Models.Shared;

namespace eZet.EveLib.Modules.Models.Resources {
    /// <summary>
    /// Class CrestPilotTournamentStats. This class cannot be inherited.
    /// </summary>
    [DataContract]
    public sealed class CrestPilotTournamentStats : CrestResource {

        /// <summary>
        /// Initializes a new instance of the <see cref="CrestPilotTournamentStats"/> class.
        /// </summary>
        public CrestPilotTournamentStats() {
            Version = "application/vnd.ccp.eve.TournamentPilotTournamentStats-v1+json";
        }

        /// <summary>
        /// Gets or sets the corp join date.
        /// </summary>
        /// <value>The corp join date.</value>
        [DataMember(Name = "corpJoinDate")]
        public DateTime CorpJoinDate { get; set; }

        /// <summary>
        /// Gets or sets the alliance.
        /// </summary>
        /// <value>The alliance.</value>
        [DataMember(Name = "alliance")]
        public CrestLinkedEntity<CrestAlliance> Alliance { get; set; }

        /// <summary>
        /// Gets or sets the damage done.
        /// </summary>
        /// <value>The damage done.</value>
        [DataMember(Name = "damageDone")]
        public double DamageDone { get; set; }

        /// <summary>
        /// Gets or sets the kills.
        /// </summary>
        /// <value>The kills.</value>
        [DataMember(Name = "kills")]
        public int Kills { get; set; }

        /// <summary>
        /// Gets or sets the deaths.
        /// </summary>
        /// <value>The deaths.</value>
        [DataMember(Name = "deaths")]
        public int Deaths { get; set; }

        /// <summary>
        /// Gets or sets the corporation.
        /// </summary>
        /// <value>The corporation.</value>
        [DataMember(Name = "corporation")]
        public CorporationEntry Corporation { get; set; }

        /// <summary>
        /// Gets or sets the character.
        /// </summary>
        /// <value>The character.</value>
        [DataMember(Name = "character")]
        public CrestLinkedIconEntity<CrestNotImplemented> Character { get; set; }

        /// <summary>
        /// Gets or sets the matches participated in.
        /// </summary>
        /// <value>The matches participated in.</value>
        [DataMember(Name = "matchesParticipatedIn")]
        public IReadOnlyList<CrestHref<CrestTournamentMatch>> MatchesParticipatedIn { get; set; }

        /// <summary>
        /// Gets or sets the recent ships.
        /// </summary>
        /// <value>The recent ships.</value>
        [DataMember(Name = "recentShips")]
        public IReadOnlyList<CrestLinkedIconEntity<CrestItemType>> RecentShips { get; set; }

        /// <summary>
        /// Gets or sets the creation date.
        /// </summary>
        /// <value>The creation date.</value>
        [DataMember(Name = "creationDate")]
        public DateTime CreationDate { get; set; }



    }
}
