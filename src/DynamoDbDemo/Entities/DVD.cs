using System.Collections.Generic;
using Amazon.DynamoDBv2.DataModel;

namespace DynamoDbDemo.Entities
{
    [DynamoDBTable("DVD")]
    public class DVD
    {
        [DynamoDBHashKey] // Básicamente es un primary key
        public string Title { get; set; }
        [DynamoDBRangeKey] // Complementary key (?) 
        public int ReleaseYear { get; set; }
        [DynamoDBProperty]
        public List<string> ActorNames { get; set; }

        public string Director { get; set; }

        public string Producer { get; set; }

        public override string ToString()
        {
            return string.Format(@"{0} – {1} Actors: {2}", Title, ReleaseYear, string.Join(", ", ActorNames.ToArray()));
        }

    }


}