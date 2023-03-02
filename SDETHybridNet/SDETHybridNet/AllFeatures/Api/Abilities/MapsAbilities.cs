using System;
using System.Collections.Generic;
using System.Text;

namespace CoreFramework.API.Abilities
{
    internal class MapsAbilities
    {
        internal string EndpointPostAddPlace { get; } = "maps/api/place/add/json?key={keyValue}";
        internal string EndpointPutUpdatePlace { get; } = "maps/api/place/update/json?key={keyValue}";
        internal string EndpointGetPlaceDetails { get; } = "maps/api/place/get/json?key={keyValue}&place_id={place_idValue}";
    }
}
