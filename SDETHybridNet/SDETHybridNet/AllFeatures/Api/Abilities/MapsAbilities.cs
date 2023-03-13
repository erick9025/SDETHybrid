using System;
using System.Collections.Generic;
using System.Text;

namespace CoreFramework.API.Abilities
{
    public class MapsAbilities
    {
        public string EndpointPostAddPlace { get; } = "maps/api/place/add/json?key={keyValue}";
        public string EndpointPutUpdatePlace { get; } = "maps/api/place/update/json?key={keyValue}";
        public string EndpointGetPlaceDetails { get; } = "maps/api/place/get/json?key={keyValue}&place_id={place_idValue}";
    }
}
