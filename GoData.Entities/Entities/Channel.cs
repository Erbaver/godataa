using System.Collections.Generic;

namespace GoData.Entities.Entities
{

    public class Channel : BaseEntity
    {

        public string ChannelName { get; set; }

        public ICollection<DataForm> DataForms { get; set; }
    }
}
