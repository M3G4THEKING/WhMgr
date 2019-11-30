﻿namespace WhMgr.Data.Subscriptions.Models
{
    using ServiceStack.DataAnnotations;

    using Newtonsoft.Json;

    using WhMgr.Net.Models;

    [
        JsonObject("invasions"),
        Alias("invasions")
    ]
    public class InvasionSubscription
    {
        [
            JsonIgnore,
            Alias("id"),
            PrimaryKey, 
            AutoIncrement
        ]
        public int Id { get; set; }

        [
            Alias("subscription_id"),
            ForeignKey(typeof(SubscriptionObject))
        ]
        public int SubscriptionId { get; set; }

        [
             JsonProperty("guild_id"),
             Alias("guild_id"),
             Required
         ]
        public ulong GuildId { get; set; }

        [
            JsonProperty("user_id"),
            Alias("userId"),
            Required
        ]
        public ulong UserId { get; set; }

        [
            JsonProperty("grunt_type"),
            Alias("grunt_type"), 
            Required
        ]
        public InvasionGruntType GruntType { get; set; }

        [
            JsonProperty("city"),
            Alias("city"), 
            Required
        ]
        public string City { get; set; }
    }
}